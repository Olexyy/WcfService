﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFServiceClient.ServiceReference;

namespace ChatClient
{
    public partial class LoginForm : Form
    {
        public User User { get; set; }
        public LoginForm()
        {
            this.InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (ContractUserClient client = new ContractUserClient())
            {
                try
                {
                    this.User = client.Authenticate(this.textBoxLogin.Text.Trim(), this.textBoxPassword.Text.Trim());
                } catch
                {
                    MessageBox.Show("Service unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                if (this.User != null)
                    this.Close();
                else
                    MessageBox.Show("Service available for registered users only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            using (ContractUserClient client = new ContractUserClient())
            {
                if(client.AddUser(this.textBoxLogin.Text.Trim(), this.textBoxPassword.Text.Trim()) != null)
                    MessageBox.Show("User added, please login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                     MessageBox.Show("Use different login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
