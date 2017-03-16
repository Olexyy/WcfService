using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using TestChat.ServiceReference;

namespace ChatClient
{
    public partial class ChatForm : Form
    {
        private ContractChatClient ChatClient { get; set; }
        protected const int PollingInterval = 2000;
        private Timer PollingTimer { get; set; }
        private bool LoggedIn { get; set; }
        private bool Casted { get; set; }
        private bool Caster { get; set; }
        private CastForm CastForm { get; set; }
        public ChatForm()
        {
            this.ChatClient = new ContractChatClient();
            //var credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings.Get("login"), ConfigurationManager.AppSettings.Get("pass"));
            //this.ChatClient.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential("inua", "1qaz!QAZ");
            this.InitializeComponent();
            this.PollingTimer = new Timer();
            this.PollingTimer.Tick += this.PollingEventHandler;
            this.PollingTimer.Interval = ChatForm.PollingInterval;
            this.PollingTimer.Start();
            this.CastForm = new CastForm();
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
                // Service messages.
                if (message.Type == ChatMessageTypes.UsersTotal)
                    this.labelTotalCount.Text = message.Text;
                else if (message.Type == ChatMessageTypes.UsersRegistered)
                    this.labelRegisteredCount.Text = message.Text;
                else if (message.Type == ChatMessageTypes.GroupTotal)
                    this.labelInGroupCount.Text = message.Text;
                else if (message.Type == ChatMessageTypes.UserDetails)
                    this.UserInfo(message.User);
                // Screen messages.
                else if (message.Type == ChatMessageTypes.CastStart || message.Type == ChatMessageTypes.CastEnd ||
                    message.Type == ChatMessageTypes.Cast )
                    this.CastHandler(message);
                // Non service messages.
                else if (message.Type == ChatMessageTypes.PostAll || (message.Type == ChatMessageTypes.PostGroup))
                    this.listViewChat.Items.Add(new ListViewItem(new String[] { message.User.Name, DateTime.Now.ToShortDateString(), message.Text }));
            }
        }
        private void UserInfo(User user = null)
        {
            if (user != null)
            {
                this.LoggedIn = true;
                this.labelGroupValue.Text = user.Group;
                this.labelStatusValue.Text = "Yes";
            }
                
            else
            {
                this.LoggedIn = false;
                this.labelGroupValue.Text = "None";
                this.labelStatusValue.Text = "No";
                this.labelInGroupCount.Text = "0";
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(this.ChatClient);
            loginForm.ShowDialog();
            if(loginForm.LoggedIn)
                this.MessageBoxMarshall("User logged in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonPostAll_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxMessage.Text))
                Task.Run(() => this.PostMessage(this.textBoxMessage.Text, ChatMessageTypes.PostAll));
        }
        private void PostMessage(string text, ChatMessageTypes type)
        {
            try
            {
                this.ChatClient.PostMessage(new ChatMessage() { Text=text, Type = type });
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
            this.Caster = false;
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
                var profileForm = new ProfileForm(user);
                profileForm.ShowDialog();
                if (profileForm.Result == ProfileForm.Results.Ok)
                    this.UpdateUser(profileForm.User);
            }
        }
        private void UpdateUser(User user )
        {
            try
            {
                if (this.ChatClient.UpdateUser(user, true))
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
                        this.MessageBoxMarshall("User logged out.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                this.MessageBoxMarshall(ex.Message);
            }
        }
        private void buttonPostGroup_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBoxMessage.Text))
                Task.Run(() => this.PostMessage(this.textBoxMessage.Text, ChatMessageTypes.PostGroup));
        }
        private void ScreenCast()
        {
            using (Bitmap bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bmpScreenCapture))
                {
                    g.CopyFromScreen(0, 0, 0, 0, bmpScreenCapture.Size);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        Bitmap resized = new Bitmap(bmpScreenCapture, new Size(320, 240));
                        resized.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] binaryData = memoryStream.ToArray();
                        this.ChatClient.PostMessage(new ChatMessage() { BinaryData = binaryData, Type = ChatMessageTypes.Cast });
                    }
                }
            }
        }
        private void CastHandler(ChatMessage message)
        {
            if (message.Type == ChatMessageTypes.CastStart || (message.Type == ChatMessageTypes.Cast && !this.Casted && !this.Caster))
            {
                this.Invoke(new Action(()=>this.CastForm.Show()));
                this.Casted = true;
            }
            else if (message.Type == ChatMessageTypes.CastEnd)
            {
                this.Invoke(new Action(() => this.CastForm.Hide()));
                this.Casted = false;
            }
            else
                    this.CastForm.Show();
            this.CastForm.pictureBox.Image = Image.FromStream(new MemoryStream(message.BinaryData));
        }
        private void buttonCastGroup_Click(object sender, EventArgs e)
        {
            if(this.LoggedIn)
                Task.Run(() => this.CastProcess());
        }
        private void CastProcess()
        {
            if (this.Casted || this.Caster)
                return;
            this.ChatClient.PostMessage(new ChatMessage() { Type = ChatMessageTypes.CastStart });
            this.Caster = true;
            while (this.Caster)
            {
                this.ScreenCast();
                System.Threading.Thread.Sleep(2000);
            }
        }

        private void buttonStopCasting_Click(object sender, EventArgs e)
        {
            if (this.Caster)
            {
                this.Caster = false;
                this.ChatClient.PostMessage(new ChatMessage() { Type = ChatMessageTypes.CastEnd });
            }
        }

    }
}
