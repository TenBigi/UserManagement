namespace UserManagemet
{
    partial class ApplicationForm
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
            activeUserLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            newPasswd = new TextBox();
            newPasswdConfirm = new TextBox();
            originalPasswd = new TextBox();
            button1 = new Button();
            statusLabel = new Label();
            userScreen = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Heslo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)userScreen).BeginInit();
            SuspendLayout();
            // 
            // activeUserLabel
            // 
            activeUserLabel.AutoSize = true;
            activeUserLabel.Location = new Point(12, 9);
            activeUserLabel.Name = "activeUserLabel";
            activeUserLabel.Size = new Size(13, 15);
            activeUserLabel.TabIndex = 28;
            activeUserLabel.Text = "x";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 27;
            label5.Text = "Heslo znovu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 26;
            label4.Text = "Nove heslo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 25;
            label3.Text = "Puvodni heslo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 24;
            label2.Text = "Zmenit heslo:";
            // 
            // newPasswd
            // 
            newPasswd.Location = new Point(12, 137);
            newPasswd.Name = "newPasswd";
            newPasswd.Size = new Size(245, 23);
            newPasswd.TabIndex = 23;
            // 
            // newPasswdConfirm
            // 
            newPasswdConfirm.Location = new Point(12, 181);
            newPasswdConfirm.Name = "newPasswdConfirm";
            newPasswdConfirm.Size = new Size(245, 23);
            newPasswdConfirm.TabIndex = 22;
            // 
            // originalPasswd
            // 
            originalPasswd.Location = new Point(12, 83);
            originalPasswd.Name = "originalPasswd";
            originalPasswd.Size = new Size(245, 23);
            originalPasswd.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(175, 209);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 20;
            button1.Text = "Potvrdit zmenu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusLabel
            // 
            statusLabel.ForeColor = Color.Red;
            statusLabel.Location = new Point(0, 268);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(215, 19);
            statusLabel.TabIndex = 30;
            // 
            // userScreen
            // 
            userScreen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userScreen.Columns.AddRange(new DataGridViewColumn[] { Username, Heslo });
            userScreen.Location = new Point(12, 9);
            userScreen.Name = "userScreen";
            userScreen.RowHeadersWidth = 43;
            userScreen.Size = new Size(245, 266);
            userScreen.TabIndex = 31;
            userScreen.Visible = false;
            userScreen.CellValueChanged += userScreen_CellValueChanged;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Heslo
            // 
            Heslo.HeaderText = "Heslo";
            Heslo.Name = "Heslo";
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 287);
            Controls.Add(userScreen);
            Controls.Add(statusLabel);
            Controls.Add(activeUserLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(newPasswd);
            Controls.Add(newPasswdConfirm);
            Controls.Add(originalPasswd);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ApplicationForm";
            Text = "RegularUserForm";
            ((System.ComponentModel.ISupportInitialize)userScreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label activeUserLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox newPasswd;
        private TextBox newPasswdConfirm;
        private TextBox originalPasswd;
        private Button button1;
        private Label statusLabel;
        private DataGridView userScreen;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Heslo;
    }
}