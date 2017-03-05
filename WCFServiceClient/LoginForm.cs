using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFServiceClient.ServiceReference;

namespace WCFServiceClient
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
            using (ContractWeatherClient client = new ContractWeatherClient())
            {
                try
                {
                    this.User = client.Authenticate(this.textBoxLogin.Text.Trim(), this.textBoxPassword.Text.Trim());
                } catch (Exception ex)
                {
                    var a = 1;
                }
                if (this.User != null)
                    this.Close();
                else
                    MessageBox.Show("Service available for registered users only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            using (ContractWeatherClient client = new ContractWeatherClient())
            {
                if(client.AddUser(this.textBoxLogin.Text.Trim(), this.textBoxPassword.Text.Trim()) != null)
                    MessageBox.Show("User added, please login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                     MessageBox.Show("Use different login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
