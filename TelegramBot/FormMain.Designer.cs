namespace TelegramBot
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNavMenu = new Panel();
            btnConfig = new FontAwesome.Sharp.IconButton();
            btnCommands = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label1 = new Label();
            panelScreen = new Panel();
            panelTitle = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            panelNavMenu.SuspendLayout();
            panel2.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavMenu
            // 
            panelNavMenu.BackColor = Color.FromArgb(24, 30, 54);
            panelNavMenu.Controls.Add(btnConfig);
            panelNavMenu.Controls.Add(btnCommands);
            panelNavMenu.Controls.Add(btnSettings);
            panelNavMenu.Controls.Add(btnHome);
            panelNavMenu.Controls.Add(panel2);
            panelNavMenu.Dock = DockStyle.Left;
            panelNavMenu.Location = new Point(0, 0);
            panelNavMenu.Name = "panelNavMenu";
            panelNavMenu.Size = new Size(186, 538);
            panelNavMenu.TabIndex = 0;
            // 
            // btnConfig
            // 
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfig.ForeColor = Color.FromArgb(0, 126, 249);
            btnConfig.IconChar = FontAwesome.Sharp.IconChar.Memory;
            btnConfig.IconColor = Color.FromArgb(0, 126, 249);
            btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfig.IconSize = 36;
            btnConfig.Location = new Point(0, 140);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(186, 45);
            btnConfig.TabIndex = 4;
            btnConfig.Text = "    Configuration";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            btnConfig.Leave += btnConfig_Leave;
            // 
            // btnCommands
            // 
            btnCommands.Dock = DockStyle.Top;
            btnCommands.FlatAppearance.BorderSize = 0;
            btnCommands.FlatStyle = FlatStyle.Flat;
            btnCommands.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCommands.ForeColor = Color.FromArgb(0, 126, 249);
            btnCommands.IconChar = FontAwesome.Sharp.IconChar.Robot;
            btnCommands.IconColor = Color.FromArgb(0, 126, 249);
            btnCommands.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCommands.IconSize = 36;
            btnCommands.Location = new Point(0, 95);
            btnCommands.Name = "btnCommands";
            btnCommands.Size = new Size(186, 45);
            btnCommands.TabIndex = 3;
            btnCommands.Text = "    Commands";
            btnCommands.TextAlign = ContentAlignment.MiddleLeft;
            btnCommands.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCommands.UseVisualStyleBackColor = true;
            btnCommands.Click += btnCommands_Click;
            btnCommands.Leave += btnCommands_Leave;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            btnSettings.IconColor = Color.FromArgb(0, 126, 249);
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 36;
            btnSettings.Location = new Point(0, 493);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 45);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "    Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Leave += btnSettings_Leave;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(0, 126, 249);
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.FromArgb(0, 126, 249);
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 36;
            btnHome.Location = new Point(0, 50);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(186, 45);
            btnHome.TabIndex = 1;
            btnHome.Text = "    Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            btnHome.Leave += btnHome_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 50);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "github.com/talhatunc";
            // 
            // panelScreen
            // 
            panelScreen.Dock = DockStyle.Fill;
            panelScreen.Location = new Point(186, 33);
            panelScreen.Name = "panelScreen";
            panelScreen.Size = new Size(874, 505);
            panelScreen.TabIndex = 1;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(btnExit);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(186, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(874, 33);
            panelTitle.TabIndex = 2;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            btnExit.IconColor = Color.FromArgb(0, 126, 249);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnExit.IconSize = 12;
            btnExit.Location = new Point(833, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 33);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1060, 538);
            Controls.Add(panelScreen);
            Controls.Add(panelTitle);
            Controls.Add(panelNavMenu);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panelNavMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavMenu;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnHome;
        private Label label1;
        private Panel panelScreen;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnConfig;
        private FontAwesome.Sharp.IconButton btnCommands;
    }
}