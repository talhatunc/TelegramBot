namespace TelegramBot.Forms
{
    partial class FormCommands
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
            txtBoxCommand = new TextBox();
            txtBoxReply = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridCommands = new DataGridView();
            Command = new DataGridViewTextBoxColumn();
            Reply = new DataGridViewTextBoxColumn();
            btnAddCommand = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridCommands).BeginInit();
            SuspendLayout();
            // 
            // txtBoxCommand
            // 
            txtBoxCommand.Location = new Point(91, 17);
            txtBoxCommand.Name = "txtBoxCommand";
            txtBoxCommand.Size = new Size(100, 23);
            txtBoxCommand.TabIndex = 0;
            // 
            // txtBoxReply
            // 
            txtBoxReply.Location = new Point(91, 46);
            txtBoxReply.Name = "txtBoxReply";
            txtBoxReply.Size = new Size(100, 23);
            txtBoxReply.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Command :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Reply          :";
            // 
            // dataGridCommands
            // 
            dataGridCommands.AllowUserToAddRows = false;
            dataGridCommands.AllowUserToDeleteRows = false;
            dataGridCommands.AllowUserToResizeColumns = false;
            dataGridCommands.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCommands.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridCommands.BorderStyle = BorderStyle.None;
            dataGridCommands.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCommands.Columns.AddRange(new DataGridViewColumn[] { Command, Reply });
            dataGridCommands.Location = new Point(201, 16);
            dataGridCommands.MultiSelect = false;
            dataGridCommands.Name = "dataGridCommands";
            dataGridCommands.ReadOnly = true;
            dataGridCommands.RowHeadersVisible = false;
            dataGridCommands.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCommands.ShowCellErrors = false;
            dataGridCommands.ShowCellToolTips = false;
            dataGridCommands.ShowEditingIcon = false;
            dataGridCommands.ShowRowErrors = false;
            dataGridCommands.Size = new Size(657, 467);
            dataGridCommands.TabIndex = 4;
            // 
            // Command
            // 
            Command.HeaderText = "Command";
            Command.Name = "Command";
            Command.ReadOnly = true;
            // 
            // Reply
            // 
            Reply.HeaderText = "Reply";
            Reply.Name = "Reply";
            Reply.ReadOnly = true;
            // 
            // btnAddCommand
            // 
            btnAddCommand.FlatStyle = FlatStyle.Flat;
            btnAddCommand.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddCommand.ForeColor = Color.FromArgb(0, 126, 249);
            btnAddCommand.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAddCommand.IconColor = Color.FromArgb(0, 126, 249);
            btnAddCommand.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAddCommand.IconSize = 16;
            btnAddCommand.Location = new Point(125, 75);
            btnAddCommand.Name = "btnAddCommand";
            btnAddCommand.Size = new Size(66, 23);
            btnAddCommand.TabIndex = 5;
            btnAddCommand.Text = "Add";
            btnAddCommand.TextAlign = ContentAlignment.MiddleLeft;
            btnAddCommand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCommand.UseVisualStyleBackColor = true;
            btnAddCommand.Click += btnAddCommand_Click;
            // 
            // FormCommands
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnAddCommand);
            Controls.Add(dataGridCommands);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxReply);
            Controls.Add(txtBoxCommand);
            Name = "FormCommands";
            Size = new Size(874, 505);
            ((System.ComponentModel.ISupportInitialize)dataGridCommands).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxCommand;
        private TextBox txtBoxReply;
        private Label label1;
        private Label label2;
        private DataGridView dataGridCommands;
        private DataGridViewTextBoxColumn Command;
        private DataGridViewTextBoxColumn Reply;
        private FontAwesome.Sharp.IconButton btnAddCommand;
    }
}
