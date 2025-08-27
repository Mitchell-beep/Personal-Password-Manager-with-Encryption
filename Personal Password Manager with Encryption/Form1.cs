using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Personal_Password_Manager_with_Encryption
{
    public partial class Form1 : Form
    {
        private List<(string Site, string Username, string Password)> passwordVault;

        public Form1()
        {
            InitializeComponent();

            passwordVault = new List<(string, string, string)>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string site = txtSite.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(site) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            passwordVault.Add((site, username, password));
            txtSite.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

    }
}
