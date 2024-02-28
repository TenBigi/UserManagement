using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using UserManagemet.Data;

namespace UserManagemet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadUsersFromXML();
        }

        private string GetXmlPath()
        {
            return Path.Combine("../../../data", "Users.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = usrNameBox.Text;
            string passwd = passwdBox.Text;

            User loginUsr = Logic.Users.FirstOrDefault(x => x.Name == login && x.Password == passwd);
            if (loginUsr != null)
            {
                ApplicationForm app = new(loginUsr);
                app.Show();
            }
            else
            {
                errorLabel.Text = "Spatne jmeno nebo heslo.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm newReg = new();
            newReg.Show();
        }

        private void LoadUsersFromXML()
        {
            Logic logic = new Logic();
            List<User> users;

            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (TextReader reader = new StreamReader(GetXmlPath()))
            {
                try
                {
                    users = (List<User>)serializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Serializace se nezdarila. Chyba:" + "\n" + ex.Message);
                    return;
                }

                if (users != null && users.Any())
                {
                    byte[] key = logic.LoadOrGenerateKey();
                    byte[] iv = logic.LoadOrGenerateIV();

                    logic = new Logic(key, iv);

                    foreach (User u in users)
                    {
                        u.Password = logic.getDecryptedPasswd(Convert.FromBase64String(u.Password));
                        Logic.Users.Add(u);
                    }
                }
                else
                {
                    User usrAdmin = new User
                    {
                        Name = "admin",
                        Password = "password"
                    };
                }
            }       
        }   

        private void SaveUsersToXML()
        {
            List<User> usersToSave = new List<User>();
            usersToSave.AddRange(Logic.Users);

            Logic logic = new Logic();
            byte[] key = logic.LoadOrGenerateKey();
            byte[] iv = logic.LoadOrGenerateIV();

            logic = new Logic(key, iv);
            foreach (User u in usersToSave)
            {
                byte[] encryptedPasswd = logic.getEncryptedPasswd(u.Password);
                u.Password = Convert.ToBase64String(encryptedPasswd);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (TextWriter writer = new StreamWriter(GetXmlPath()))
            {
                serializer.Serialize(writer, usersToSave);
            }
        }

        public void ApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUsersToXML();
        }
    }
}
