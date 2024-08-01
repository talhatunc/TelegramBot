using Telegram.Bot;
using System;
using Telegram.Bot.Types.ReplyMarkups;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;


namespace TelegramBot
{
    public partial class Form1 : Form
    {
        private static readonly string Token = "";
        private TelegramBotClient Bot;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bot = new TelegramBotClient(Token);
            Bot.OnMessage += BotClient_OnMessage;
            Bot.StartReceiving();
        }

        private void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var id = e.Message.From.Id;
            var test = e.Message.Text.ToString();
            var firstName = e.Message.From.FirstName ?? string.Empty;
            var lastName = e.Message.From.LastName ?? string.Empty;
            var userName = e.Message.From.Username ?? string.Empty;
            var chatId = e.Message.Chat.Id;
            var userId = e.Message.From.Id;
            AddRowToDataGridView(firstName, lastName, userName, chatId, userId);
            switch (test)
            {
                case "Hello":
                    Bot.SendTextMessageAsync(id, "oldu");
                    break;
                case "H": break;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bot.StopReceiving();
        }

        private async void dataGridViewContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var userId = dataGridViewContact.Rows[e.RowIndex].Cells["UserId"].Value;
                if (userId != null)
                {
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
    }
}
