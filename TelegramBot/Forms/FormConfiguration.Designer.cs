namespace TelegramBot.Forms
{
    partial class FormConfiguration
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
            label1 = new Label();
            txtBoxBotToken = new TextBox();
            btnSaveToken = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Bot Token :";
            // 
            // txtBoxBotToken
            // 
            txtBoxBotToken.Location = new Point(85, 10);
            txtBoxBotToken.Name = "txtBoxBotToken";
            txtBoxBotToken.Size = new Size(774, 23);
            txtBoxBotToken.TabIndex = 1;
            // 
            // btnSaveToken
            // 
            btnSaveToken.FlatStyle = FlatStyle.Flat;
            btnSaveToken.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveToken.ForeColor = Color.FromArgb(0, 126, 249);
            btnSaveToken.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSaveToken.IconColor = Color.FromArgb(0, 126, 249);
            btnSaveToken.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSaveToken.IconSize = 16;
            btnSaveToken.Location = new Point(793, 468);
            btnSaveToken.Name = "btnSaveToken";
            btnSaveToken.Size = new Size(66, 23);
            btnSaveToken.TabIndex = 6;
            btnSaveToken.Text = "Save";
            btnSaveToken.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveToken.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveToken.UseVisualStyleBackColor = true;
            btnSaveToken.Click += btnSaveToken_Click;
            // 
            // FormConfiguration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnSaveToken);
            Controls.Add(txtBoxBotToken);
            Controls.Add(label1);
            Name = "FormConfiguration";
            Size = new Size(874, 505);
            Load += FormConfiguration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxBotToken;
        private FontAwesome.Sharp.IconButton btnSaveToken;
    }
}
