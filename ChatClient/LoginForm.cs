using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatClient.ServiceReference;

namespace ChatClient
{
    public partial class LoginForm : Form
    {
        public ContractChatClient ChatClient { get; private set; }
        public bool LoggedIn { get; private set; }
        public LoginForm(ContractChatClient chatClient)
        {
            this.ChatClient = chatClient;
            this.InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        { 
            try
            {
                this.LoggedIn = this.ChatClient.LogIn(this.textBoxLogin.Text.Trim(), this.textBoxPassword.Text.Trim());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.LoggedIn)
                this.Close();
            else
                MessageBox.Show("Service available for registered users only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var profileForm = new ProfileForm(new User());
                profileForm.ShowDialog();
                if (profileForm.Result == ProfileForm.Results.Ok)
                    if(this.ChatClient.AddUser(profileForm.User))
                        MessageBox.Show("User added, please login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Use different credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
