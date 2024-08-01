using Newtonsoft.Json;
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
    public partial class FormCommands : UserControl
    {
        private string commandsFilePath = @"Commands/commands.json";
        private List<Command> commandList = new List<Command>();
        public FormCommands()
        {
            InitializeComponent();
            LoadCommandsFromFile();
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            string command = txtBoxCommand.Text.Trim();
            string reply = txtBoxReply.Text.Trim();

            if (string.IsNullOrEmpty(command) || string.IsNullOrEmpty(reply))
            {
                MessageBox.Show("Both command and reply fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dataGridCommands.Rows)
            {
                if (row.Cells[0].Value?.ToString() == command)
                {
                    MessageBox.Show("Duplicate command detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dataGridCommands.Rows.Add(command, reply);

            commandList.Add(new Command { CommandText = command, ReplyText = reply });
            SaveCommandsToFile();
        }

        private void LoadCommandsFromFile()
        {
            if (File.Exists(commandsFilePath))
            {
                string json = File.ReadAllText(commandsFilePath);
                commandList = JsonConvert.DeserializeObject<List<Command>>(json) ?? new List<Command>();

                foreach (var cmd in commandList)
                {
                    dataGridCommands.Rows.Add(cmd.CommandText, cmd.ReplyText);
                }
            }
        }

        private void SaveCommandsToFile()
        {
            string json = JsonConvert.SerializeObject(commandList, Formatting.Indented);
            Directory.CreateDirectory(Path.GetDirectoryName(commandsFilePath));
            File.WriteAllText(commandsFilePath, json);
        }
    }
    public class Command
    {
        public string CommandText { get; set; }
        public string ReplyText { get; set; }
    }
}
