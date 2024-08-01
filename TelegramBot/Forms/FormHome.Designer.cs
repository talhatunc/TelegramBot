namespace TelegramBot.Forms
{
    partial class FormHome
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
            listBoxLog = new ListBox();
            dataGridViewContact = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            chatId = new DataGridViewTextBoxColumn();
            userId = new DataGridViewTextBoxColumn();
            lblUser = new Label();
            pictureBoxPP = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPP).BeginInit();
            SuspendLayout();
            // 
            // listBoxLog
            // 
            listBoxLog.FormattingEnabled = true;
            listBoxLog.ItemHeight = 15;
            listBoxLog.Location = new Point(260, 64);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(599, 424);
            listBoxLog.TabIndex = 7;
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
            dataGridViewContact.Location = new Point(14, 12);
            dataGridViewContact.MultiSelect = false;
            dataGridViewContact.Name = "dataGridViewContact";
            dataGridViewContact.ReadOnly = true;
            dataGridViewContact.RowHeadersVisible = false;
            dataGridViewContact.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewContact.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewContact.Size = new Size(240, 478);
            dataGridViewContact.TabIndex = 5;
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
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUser.ForeColor = Color.FromArgb(0, 126, 249);
            lblUser.Location = new Point(313, 33);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(96, 25);
            lblUser.TabIndex = 8;
            lblUser.Text = "username";
            // 
            // pictureBoxPP
            // 
            pictureBoxPP.BackColor = Color.Transparent;
            pictureBoxPP.ForeColor = Color.Gainsboro;
            pictureBoxPP.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            pictureBoxPP.IconColor = Color.Gainsboro;
            pictureBoxPP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureBoxPP.IconSize = 46;
            pictureBoxPP.Location = new Point(260, 12);
            pictureBoxPP.Name = "pictureBoxPP";
            pictureBoxPP.Size = new Size(47, 46);
            pictureBoxPP.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPP.TabIndex = 6;
            pictureBoxPP.TabStop = false;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(listBoxLog);
            Controls.Add(dataGridViewContact);
            Controls.Add(lblUser);
            Controls.Add(pictureBoxPP);
            Name = "FormHome";
            Size = new Size(874, 505);
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxLog;
        private DataGridView dataGridViewContact;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn chatId;
        private DataGridViewTextBoxColumn userId;
        private Label lblUser;
        private FontAwesome.Sharp.IconPictureBox pictureBoxPP;
    }
}
