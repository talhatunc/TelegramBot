using Microsoft.Win32;
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
    public partial class FormSettings : UserControl
    {
        private readonly string keyName = @"Software\Microsoft\Windows\CurrentVersion\Run";
        private readonly string appName = "TelegramBot";
        public FormSettings()
        {
            InitializeComponent();
        }

        private void checkBoxStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartup.Checked)
            {
                SetStartup(true);
            }
            else
            {
                SetStartup(false);
            }
        }

        private void SetStartup(bool enable)
        {
            string appPath = Application.ExecutablePath;

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
                {
                    if (enable)
                    {
                        key.SetValue(appName, appPath);
                    }
                    else
                    {
                        key.DeleteValue(appName, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating startup settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName))
                {
                    if (key != null)
                    {
                        object value = key.GetValue(appName);

                        if (value != null)
                        {
                            checkBoxStartup.Checked = true;
                        }
                        else
                        {
                            checkBoxStartup.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking startup settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
