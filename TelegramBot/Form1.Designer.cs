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
            pictureBoxPP = new FontAwesome.Sharp.IconPictureBox();
            lblUser = new Label();
            listBoxLog = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPP).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewContact
            // 
            dataGridViewContact.AllowUserToAddRows = false;
            dataGridViewContact.AllowUserToDeleteRows = false;
            dataGridViewContact.AllowUserToResizeColumns = false;
            dataGridViewContact.AllowUserToResizeRows = false;
            dataGridViewContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewContact.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContact.Columns.AddRange(new DataGridViewColumn[] { FullName, UserName, chatId, userId });
            dataGridViewContact.Location = new Point(12, 12);
            dataGridViewContact.MultiSelect = false;
            dataGridViewContact.Name = "dataGridViewContact";
            dataGridViewContact.ReadOnly = true;
            dataGridViewContact.RowHeadersVisible = false;
            dataGridViewContact.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewContact.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewContact.Size = new Size(240, 431);
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
            chatId.ReadOnly = true;
            chatId.Visible = false;
            // 
            // userId
            // 
            userId.HeaderText = "userId";
            userId.Name = "userId";
            userId.ReadOnly = true;
            userId.Visible = false;
            // 
            // pictureBoxPP
            // 
            pictureBoxPP.BackColor = SystemColors.Control;
            pictureBoxPP.ForeColor = Color.Gainsboro;
            pictureBoxPP.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            pictureBoxPP.IconColor = Color.Gainsboro;
            pictureBoxPP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureBoxPP.IconSize = 46;
            pictureBoxPP.Location = new Point(258, 12);
            pictureBoxPP.Name = "pictureBoxPP";
            pictureBoxPP.Size = new Size(47, 46);
            pictureBoxPP.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPP.TabIndex = 2;
            pictureBoxPP.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(311, 29);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 15);
            lblUser.TabIndex = 4;
            // 
            // listBoxLog
            // 
            listBoxLog.FormattingEnabled = true;
            listBoxLog.ItemHeight = 15;
            listBoxLog.Location = new Point(258, 64);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(530, 379);
            listBoxLog.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(lblUser);
            Controls.Add(listBoxLog);
            Controls.Add(pictureBoxPP);
            Controls.Add(dataGridViewContact);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewContact;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn chatId;
        private DataGridViewTextBoxColumn userId;
        private FontAwesome.Sharp.IconPictureBox pictureBoxPP;
        private Label lblUser;
        private ListBox listBoxLog;
    }
}
