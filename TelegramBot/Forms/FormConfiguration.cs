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

namespace TelegramBot.Forms
{
    public partial class FormConfiguration : UserControl
    {
        static string configFilePath = @"Commands/config.ini";
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void btnSaveToken_Click(object sender, EventArgs e)
        {
            string token = txtBoxBotToken.Text;

            if (string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("Token cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                File.WriteAllText(configFilePath, $"botToken={token}");
                MessageBox.Show("Token saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    string fileContent = File.ReadAllText(configFilePath);
                    if (fileContent.StartsWith("botToken="))
                    {
                        string token = fileContent.Substring("botToken=".Length);
                        txtBoxBotToken.Text = token;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the token: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
