namespace TelegramBot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewContact = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            chatId = new DataGridViewTextBoxColumn();
            userId = new DataGridViewTextBoxColumn();
            pictureBoxPP = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPP).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewContact
            // 
            dataGridViewContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContact.Columns.AddRange(new DataGridViewColumn[] { FullName, UserName, chatId, userId });
            dataGridViewContact.Location = new Point(12, 12);
            dataGridViewContact.Name = "dataGridViewContact";
            dataGridViewContact.Size = new Size(240, 426);
            dataGridViewContact.TabIndex = 0;
            dataGridViewContact.CellClick += dataGridViewContact_CellClick;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // chatId
            // 
            chatId.HeaderText = "chatId";
            chatId.Name = "chatId";
            chatId.Visible = false;
            // 
            // userId
            // 
            userId.HeaderText = "userId";
            userId.Name = "userId";
            userId.Visible = false;
            // 
            // pictureBoxPP
            // 
            pictureBoxPP.Location = new Point(267, 15);
            pictureBoxPP.Name = "pictureBoxPP";
            pictureBoxPP.Size = new Size(49, 47);
            pictureBoxPP.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPP.TabIndex = 1;
            pictureBoxPP.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxPP);
            Controls.Add(dataGridViewContact);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewContact;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn chatId;
        private DataGridViewTextBoxColumn userId;
        private PictureBox pictureBoxPP;
    }
}
