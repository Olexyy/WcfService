using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class ChatForm : Form
    {
        private Timer Timer { get; set; }
        private User User { get; set; }
        public ChatForm()
        {
            this.InitializeComponent();
            this.Timer = new Timer();
            this.Timer.Tick += this.GetWeatherInfo;
            this.Timer.Interval = 3000;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.User = loginForm.User;
            this.Timer.Start();
        }
    }
}
