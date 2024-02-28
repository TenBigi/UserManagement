using Microsoft.VisualBasic;
using UserManagemet.Data;

namespace UserManagemet
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string usrName = usrNameBox.Text;
            string passwd = passwdBox.Text;

            if (!string.IsNullOrEmpty(usrName) && !string.IsNullOrEmpty(passwd)) 
            {
                /*
                if (usrName == "Admin" || usrName == "admin")
                {
                    MessageBox.Show("Administratorsky ucet neni mozno zalozit. Zvolte prosim jine uzivatelske jmeno");
                    return;
                }
                */

                if (passwd != cnfrmPasswdBox.Text)
                {
                    errorLabel.Text = "Zadana hesla se neshoduji.";
                    return;
                }

                User newUsr = new User()
                {
                    Name = usrName,
                    Password = passwd,
                };

                Logic.Users.Add(newUsr);
                Close();
            }
            else
            {
                errorLabel.Text = "Prosim vyplnte vsechna pole.";
            }
        }
    }
}
