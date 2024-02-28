namespace UserManagemet
{
    partial class RegisterForm
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
            usrNameBox = new TextBox();
            passwdBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            regBtn = new Button();
            label3 = new Label();
            cnfrmPasswdBox = new TextBox();
            label4 = new Label();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // usrNameBox
            // 
            usrNameBox.Location = new Point(67, 128);
            usrNameBox.Name = "usrNameBox";
            usrNameBox.Size = new Size(228, 27);
            usrNameBox.TabIndex = 0;
            // 
            // passwdBox
            // 
            passwdBox.Location = new Point(67, 189);
            passwdBox.Name = "passwdBox";
            passwdBox.PasswordChar = '*';
            passwdBox.Size = new Size(228, 27);
            passwdBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 105);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 166);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // regBtn
            // 
            regBtn.Location = new Point(201, 305);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(94, 29);
            regBtn.TabIndex = 4;
            regBtn.Text = "Register";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 226);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirm password";
            // 
            // cnfrmPasswdBox
            // 
            cnfrmPasswdBox.Location = new Point(67, 249);
            cnfrmPasswdBox.Name = "cnfrmPasswdBox";
            cnfrmPasswdBox.PasswordChar = '*';
            cnfrmPasswdBox.Size = new Size(228, 27);
            cnfrmPasswdBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(86, 41);
            label4.Name = "label4";
            label4.Size = new Size(196, 28);
            label4.TabIndex = 7;
            label4.Text = "Register new account";
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 365);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(363, 25);
            errorLabel.TabIndex = 8;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 394);
            Controls.Add(errorLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cnfrmPasswdBox);
            Controls.Add(regBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwdBox);
            Controls.Add(usrNameBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usrNameBox;
        private TextBox passwdBox;
        private Label label1;
        private Label label2;
        private Button regBtn;
        private Label label3;
        private TextBox cnfrmPasswdBox;
        private Label label4;
        private Label errorLabel;
    }
}
