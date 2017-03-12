using System;
using System.Linq;
using System.ServiceModel;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

namespace ChatLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class Service : IContractChat, IContractWeather
    {

        private List<ChatMessage> Messages { get; set; }

        public User User { get; set; }

        public Service()
        {
            this.User = null;
            this.Messages = new List<ChatMessage>();
            // Won't work for Single/PerCall InstanceContextMode.
            OperationContext.Current.InstanceContext.Closing += this.ServiceSessionClosed;
            Services.Update(Services.ServicesEvents.SessionStart, this);
        }
        private List<Service> Group()
        {
            if (this.User == null)
                return new List<Service>();
            else
                return Services.Group(this.User.Group);
        }
        public void Notify(string text, ChatMessageTypes type, User user = null)
        {
            this.Messages.Add(new ChatMessage() { Text = text, User = user, Type = type });
        }
        private void ServiceSessionClosed(object sender, EventArgs e)
        {
            Services.Update(Services.ServicesEvents.SessionEnd, this);
        }
        public void PostMessage(ChatMessage message)
        {
            if (message.Type == ChatMessageTypes.PostAll)
                Services.List.ForEach(i => i.Notify(message.Text, message.Type, this.User));
            else if (message.Type == ChatMessageTypes.PostGroup)
                Services.Group(this.User.Group).ForEach(i => i.Notify(message.Text, message.Type, this.User));
        }
        public List<ChatMessage> GetMessages()
        {
            var messages = this.Messages;
            this.Messages = new List<ChatMessage>();
            return messages;
        }
        public bool LogIn(string name, string password)
        {
            if ((Services.LoggedIn.Where(i => i.User.Name == name)).ToList().Count > 0)
                return false;
            using (DBContext DB = new DBContext())
            {
                var result = DB.Users.Where(i => i.Name == name && i.Password == password).ToList();
                if (result.Count > 0)
                {
                    var user = result.First();
                    user.LastLogin = DateTime.Now;
                    this.UpdateUser(user);
                    this.User = user;
                    Services.Update(Services.ServicesEvents.Login, this);
                    return true;
                }
                return false;
            }
        }
        public bool LogOut()
        {
            if (this.User == null)
                return false;
            else
            {
                Services.Update(Services.ServicesEvents.Logout, this);
                this.User = null;
                return true;
            }
        }
        public User GetUser()
        {
            if (this.User != null)
                return this.User;
            return null;
        }
        public bool AddUser(User user)
        {
            using (DBContext DB = new DBContext())
            {
                try
                {
                    DB.Users.Add(user);
                    DB.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool UpdateUser(User user)
        {
            using (DBContext DB = new DBContext())
            {
                try
                {
                    DB.Entry(user).State = EntityState.Modified;
                    DB.SaveChanges();
                    this.User = user;
                    this.Notify(String.Empty, ChatMessageTypes.UserDetails, this.User);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public bool DeleteUser(User user)
        {
            using (DBContext DB = new DBContext())
            {
                try
                {
                    DB.Users.Remove(user);
                    DB.SaveChanges();
                    this.User = null;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        //***Weather implementation****//
        public WeathersCo GetWeather(string city)
        {
            HttpWebRequest webRequest = HttpWebRequest.CreateHttp(@"http://weathers.co/api.php?city=" + city.Trim());
            using (HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse)
            {
                using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
                {
                    JavaScriptSerializer Json = new JavaScriptSerializer();
                    try
                    {
                        return Json.Deserialize<WeathersCo>(streamReader.ReadToEnd());
                    }
                    finally { }
                }
            }
        }
    }
}