namespace TelegramBot.Forms
{
    partial class FormSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxStartup = new CheckBox();
            SuspendLayout();
            // 
            // checkBoxStartup
            // 
            checkBoxStartup.AutoSize = true;
            checkBoxStartup.FlatStyle = FlatStyle.Flat;
            checkBoxStartup.ForeColor = Color.FromArgb(0, 126, 249);
            checkBoxStartup.Location = new Point(12, 9);
            checkBoxStartup.Name = "checkBoxStartup";
            checkBoxStartup.Size = new Size(176, 19);
            checkBoxStartup.TabIndex = 0;
            checkBoxStartup.Text = "Automatically start at startup";
            checkBoxStartup.UseVisualStyleBackColor = true;
            checkBoxStartup.CheckedChanged += checkBoxStartup_CheckedChanged;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(checkBoxStartup);
            Name = "FormSettings";
            Size = new Size(874, 505);
            Load += FormSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxStartup;
    }
}
