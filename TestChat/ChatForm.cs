using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestChat.ServiceReference;

namespace TestChat
{
    public partial class ChatForm : Form
    {
        private ContractChatClient ChatClient { get; set; }
        protected const int PollingInterval = 2000;
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
                this.MessageBoxMarshall(ex.Message);
            }
        }
        private void HandleMessages(List<ChatMessage> messages)
        {
            foreach(ChatMessage message in messages)
            {
                if (message.Type == ChatMessageTypes.UsersTotal)
                    this.labelTotalCount.Text = message.Text;
                else if (message.Type == ChatMessageTypes.UsersRegistered)
                    this.labelRegisteredCount.Text = message.Text;
                else if (message.Type == ChatMessageTypes.Posting)
                    this.listViewChat.Items.Add(new ListViewItem(new String[] { message.User.Name, DateTime.Now.ToShortDateString(), message.Text }));
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(this.ChatClient);
            loginForm.ShowDialog();
            this.LoggedIn = loginForm.LoggedIn;
            if (this.LoggedIn)
                this.labelStatusValue.Text = "Yes";
        }
        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxMessage.Text))
                Task.Run(() => this.PushMessage(this.textBoxMessage.Text));
        }
        private void PushMessage(string text)
        {
            try
            {
                this.ChatClient.PushMessage(text);
                this.Invoke(new Action(() => this.textBoxMessage.Text = String.Empty));
            }
            catch (Exception ex)
            {
                this.MessageBoxMarshall(ex.Message);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxMessage.Text = String.Empty;
        }
        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ChatClient.Close();
        }
        private void buttonProfie_Click(object sender, EventArgs e)
        {
            Task.Run(() => this.EditProfile());
        }
        private void EditProfile()
        {
            User user = this.ChatClient.GetUser();
            if(user != null)
            {
                var changeProfileForm = new ChangeProfileForm(user);
                changeProfileForm.ShowDialog();
                if (changeProfileForm.Result == ChangeProfileForm.Results.Apply)
                    this.UpdateUser(changeProfileForm.User);
            }
        }
        private void UpdateUser(User user )
        {
            try
            {
                if (this.ChatClient.UpdateUser(user))
                    this.MessageBoxMarshall("User updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    this.MessageBoxMarshall("User can't be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                this.MessageBoxMarshall(ex.Message);
            }
        }
        private void MessageBoxMarshall(string text, string type = "Info", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            this.Invoke(new Action(() => MessageBox.Show(text, type, buttons, icon)));
        }
        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Task.Run(() => this.LogOut());
        }
        private void LogOut()
        {
            try
            {
                if (this.LoggedIn)
                {
                    if (this.ChatClient.LogOut())
                    {
                        this.MessageBoxMarshall("User logged out.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Invoke(new Action(() => {
                            this.LoggedIn = false;
                            this.labelStatusValue.Text = "No";
                        })); 
                    }
                }
            }
            catch (Exception ex)
            {
                this.MessageBoxMarshall(ex.Message);
            }
        }
    }
}
