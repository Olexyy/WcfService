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

namespace ChatClient {
    public partial class ProfileForm : Form
    {
        public enum Results { Ok, Cancel }
        public User User { get; private set; }
        public Results Result { get; private set; }
        public ProfileForm(User user)
        {
            this.InitializeComponent();
            this.User = user;
            this.textBoxLogin.Text = user.Name;
            this.textBoxPassword.Text = user.Password;
            this.textBoxGroup.Text = user.Group;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.Result = Results.Ok;
            this.User.Name = this.textBoxLogin.Text.Trim();
            this.User.Password = this.textBoxPassword.Text.Trim();
            this.User.Group = this.textBoxGroup.Text.Trim();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Result = Results.Cancel;
            this.Close();
        }
    }
}
