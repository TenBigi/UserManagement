namespace UserManagemet
{
    partial class LoginForm
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
            label2 = new Label();
            label1 = new Label();
            passwdBox = new TextBox();
            usrNameBox = new TextBox();
            button1 = new Button();
            errorLabel = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 50);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // passwdBox
            // 
            passwdBox.Location = new Point(47, 112);
            passwdBox.Margin = new Padding(3, 2, 3, 2);
            passwdBox.Name = "passwdBox";
            passwdBox.PasswordChar = '*';
            passwdBox.Size = new Size(200, 23);
            passwdBox.TabIndex = 5;
            // 
            // usrNameBox
            // 
            usrNameBox.Location = new Point(47, 67);
            usrNameBox.Margin = new Padding(3, 2, 3, 2);
            usrNameBox.Name = "usrNameBox";
            usrNameBox.Size = new Size(200, 23);
            usrNameBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(164, 149);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(21, 218);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(262, 19);
            errorLabel.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(47, 149);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 11;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 244);
            Controls.Add(button2);
            Controls.Add(errorLabel);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwdBox);
            Controls.Add(usrNameBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += ApplicationForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox passwdBox;
        private TextBox usrNameBox;
        private Button button1;
        private Label errorLabel;
        private Button button2;
    }
}