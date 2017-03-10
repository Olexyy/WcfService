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
    public partial class ChatForm : Form
    {
        public enum ChatMessageTypes { Posting, Service }
        private ContractChatClient ChatClient { get; set; }
        protected const int PollingInterval = 3000;
        private Timer PollingTimer { get; set; }
        private bool LoggedIn { get; set; }
        public ChatForm()
        {
            this.ChatClient = new ContractChatClient();
            this.InitializeComponent();
            this.PollingTimer = new Timer();
            this.PollingTimer.Tick += this.PollingEventHandler;
            this.PollingTimer.Interval = ChatForm.PollingInterval;
            this.PollingTimer.Start();
        }
        ~ChatForm()
        {
            this.ChatClient.Close();
        }
        private void PollingEventHandler(object sender, EventArgs args)
        {
            this.PollingTimer.Stop();
            Task.Run(() => this.GetMessages());
        }
        private void GetMessages()
        {
            try
            {
                List<ChatMessage> messages = this.ChatClient.GetMessages().ToList();
                this.Invoke(new Action(() => {
                    this.HandleMessages(messages);
                    this.PollingTimer.Start();
                }));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HandleMessages(List<ChatMessage> messages)
        {
            foreach(ChatMessage message in messages)
            {
                if (message.Type == ChatForm.ChatMessageTypes.Service.ToString())
                    this.labelTotaDigit.Text = message.Text;
                if (message.Type == ChatForm.ChatMessageTypes.Posting.ToString())
                    this.listViewChat.Items.Add(new ListViewItem(new String[] { message.User.Name, DateTime.Now.ToShortDateString(), message.Text }));
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(this.ChatClient);
            loginForm.ShowDialog();
            this.LoggedIn = loginForm.LoggedIn;
            if (this.LoggedIn)
                this.labelStatusValue.Text = "Logged in";
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.textBoxMessage.Text))
            this.ChatClient.PushMessage(this.textBoxMessage.Text);
        }
    }
}
