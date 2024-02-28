using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagemet.Data;

namespace UserManagemet
{
    public partial class ApplicationForm : Form
    {
        private User activeUser;

        public ApplicationForm(User activeUser)
        {
            InitializeComponent();
            this.activeUser = activeUser;
            activeUserLabel.Text = "Prihlasen jako: " + activeUser.Name;
            if (activeUser.Name == "admin")
            {
                ShowAdminScreen();
            }
        }

        public void ShowAdminScreen()
        {
            userScreen.Visible = true;
            RefreshUserScreen();
        }

        public void RefreshUserScreen()
        {
            userScreen.Rows.Clear();
            foreach (User u in Logic.Users)
            {
                if (u.Name == "admin")
                    continue;
                userScreen.Rows.Add(u.Name, u.Password);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswd.Text;
            if (newPassword == newPasswdConfirm.Text && !string.IsNullOrEmpty(newPassword))
            {
                activeUser.Password = newPassword;
            }
            else
            {
                statusLabel.Text = "Zadana hesla se neshoduji.";
            }
        }

        private void userScreen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex >= 0 && columnIndex == 1)
            {
                string newPassword = userScreen.Rows[rowIndex].Cells[1].Value.ToString();
                User userToUpdate = Logic.Users.FirstOrDefault(u => u.Name == userScreen.Rows[rowIndex].Cells[0].Value.ToString());

                if (userToUpdate != null)
                {
                    userToUpdate.Password = newPassword;
                    statusLabel.Text = $"Heslo pro '{userToUpdate.Name}' bylo zmeneno.";
                }
            }
        }
    }
}
