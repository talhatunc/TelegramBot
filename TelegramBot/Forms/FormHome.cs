using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace TelegramBot.Forms
{
    public partial class FormHome : UserControl
    {
        private string commandsFilePath = @"Commands/commands.json";
        private Dictionary<string, string> commandsDictionary = new Dictionary<string, string>();
        private static string Token = string.Empty;
        private TelegramBotClient Bot;
        public FormHome()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public void RefreshToken()
        {
            try
            {
                if (File.Exists(@"Commands/config.ini"))
                {
                    string fileContent = File.ReadAllText(@"Commands/config.ini");
                    if (fileContent.StartsWith("botToken="))
                    {
                        Token = fileContent.Substring("botToken=".Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the token: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            base.Show();
        }

        private void LoadTokenFromFile()
        {
            try
            {
                if (File.Exists(@"Commands/config.ini"))
                {
                    string fileContent = File.ReadAllText(@"Commands/config.ini");
                    if (fileContent.StartsWith("botToken="))
                    {
                        Token = fileContent.Substring("botToken=".Length);
                    }
                    else
                    {
                        MessageBox.Show("Please go to the configuration settings and enter a token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please go to the configuration settings and enter a token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the token: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCommandsFromFile()
        {
            if (File.Exists(commandsFilePath))
            {
                string json = File.ReadAllText(commandsFilePath);
                var commandList = JsonConvert.DeserializeObject<List<Command>>(json) ?? new List<Command>();

                commandsDictionary = new Dictionary<string, string>();
                foreach (var cmd in commandList)
                {
                    commandsDictionary[cmd.CommandText] = cmd.ReplyText;
                }
            }
        }

        private void InitializeDataGridView()
        {
            dataGridViewContact.Columns.Add("FullName", "Full Name");
            dataGridViewContact.Columns.Add("UserName", "User Name");
            dataGridViewContact.Columns.Add("ChatId", "Chat ID");
            dataGridViewContact.Columns.Add("UserId", "User ID");

            dataGridViewContact.Columns["ChatId"].Visible = false;
            dataGridViewContact.Columns["UserId"].Visible = false;
        }

        private void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            string message = e.Message.Text.ToString();
            string firstName = e.Message.From.FirstName ?? string.Empty;
            string lastName = e.Message.From.LastName ?? string.Empty;
            string userName = e.Message.From.Username ?? string.Empty;
            long chatId = e.Message.Chat.Id;
            long userId = e.Message.From.Id;
            AddLogMessage($"Recieved Message: {e.Message.Date.ToShortTimeString()} - {userName}: {message}");
            AddRowToDataGridView(firstName, lastName, userName, chatId, userId);
            switch (message)
            {
                case "/start":
                    SendMessageAsync(userId, "Welcome");
                    break;
                default:
                    if (commandsDictionary.TryGetValue(message, out string reply))
                    {
                        SendMessageAsync(userId, reply);
                    }
                    else
                    {
                        SendMessageAsync(userId, "Unknown command");
                    }
                    break;
            }
        }
        private async Task SendMessageAsync(long chatId, string text)
        {
            try
            {
                var sentMessage = await Bot.SendTextMessageAsync(chatId, text);

                AddLogMessage($"Sent Message: {sentMessage.Date.ToShortTimeString()} - {sentMessage.From.Username}: {sentMessage.Text}");
            }
            catch (Exception ex)
            {
                AddLogMessage($"Error sending message: {ex.Message}");
            }
        }

        private void AddLogMessage(string message)
        {
            if (listBoxLog.InvokeRequired)
            {
                listBoxLog.Invoke(new Action(() => AddLogMessage(message)));
            }
            else
            {
                listBoxLog.Items.Add(message);
            }
        }

        private void AddRowToDataGridView(string firstName, string lastName, string userName, long chatId, long userId)
        {
            if (dataGridViewContact.InvokeRequired)
            {
                dataGridViewContact.Invoke(new Action(() => AddRowToDataGridView(firstName, lastName, userName, chatId, userId)));
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewContact.Rows)
                {
                    if (Convert.ToInt64(row.Cells["userId"].Value) == userId)
                    {
                        return;
                    }
                }
                dataGridViewContact.Rows.Add(firstName + " " + lastName, userName, chatId, userId);
            }
        }

        private async void dataGridViewContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var userId = dataGridViewContact.Rows[e.RowIndex].Cells["userId"].Value;
                var chatId = dataGridViewContact.Rows[e.RowIndex].Cells["chatId"].Value;
                if (userId != null)
                {
                    lblUser.Text = dataGridViewContact.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                    var profilePictureUrl = await GetProfilePictureUrlAsync((long)userId);
                    if (!string.IsNullOrEmpty(profilePictureUrl))
                    {
                        await LoadProfilePictureAsync(profilePictureUrl);
                    }
                }
            }
        }

        private async Task<string> GetProfilePictureUrlAsync(long userId)
        {
            var userProfilePhotos = await Bot.GetUserProfilePhotosAsync(userId);
            if (userProfilePhotos.Photos.Length > 0)
            {
                var photo = userProfilePhotos.Photos[0][0];
                var file = await Bot.GetFileAsync(photo.FileId);
                return $"https://api.telegram.org/file/bot{Token}/{file.FilePath}";
            }

            return null;
        }

        private async Task LoadProfilePictureAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var imageBytes = await client.GetByteArrayAsync(url);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    pictureBoxPP.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            LoadTokenFromFile();
            Bot = new TelegramBotClient(Token);
            LoadCommandsFromFile();
            btnStartListening.Text = "Restart";
            btnStartListening.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            Bot.OnMessage += BotClient_OnMessage;
            Bot.StartReceiving();
        }
    }
}
