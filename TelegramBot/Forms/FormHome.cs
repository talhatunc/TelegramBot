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
        private static readonly string Token = "7479958953:AAEmY5KqoOKwNF6Z2ofog-aypSxME5NeIKk";
        private TelegramBotClient Bot;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Bot = new TelegramBotClient(Token);
            Bot.OnMessage += BotClient_OnMessage;
            Bot.StartReceiving();
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
            switch (message)
            {
                case "/start":
                    AddRowToDataGridView(firstName, lastName, userName, chatId, userId);
                    SendMessageAsync(userId, "Welcome");
                    break;
                default:
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bot.StopReceiving();
        }
    }
}
