using System;
using System.Linq;
using System.ServiceModel;
using System.Net;
using System.IO;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ChatLibrary
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    [ServiceKnownType(typeof(ChatMessageTypes))]
    public interface IContractChat
    {
        [OperationContract]
        List<ChatMessage> GetMessages();
        [OperationContract]
        void PostMessage(ChatMessage message);
        [OperationContract]
        bool LogIn(string name, string password);
        [OperationContract]
        bool LogOut();
        [OperationContract]
        User GetUser();
        [OperationContract]
        bool AddUser(User user);
        [OperationContract]
        bool DeleteUser(User user);
        [OperationContract]
        bool UpdateUser(User user);
    }
    [ServiceContract]
    public interface IContractWeather
    {
        [OperationContract]
        WeathersCo GetWeather(string city);
    }
    [DataContract]
    public class WeathersCo
    {
        [DataMember]
        public string apiVersion { get; set; }
        [DataMember]
        public WeathersCoData data { get; set; }
        [DataContract]
        public class WeathersCoData
        {
            [DataMember]
            public string location { get; set; }
            [DataMember]
            public string temperature { get; set; }
            [DataMember]
            public string skytext { get; set; }
            [DataMember]
            public string humidity { get; set; }
            [DataMember]
            public string wind { get; set; }
            [DataMember]
            public string date { get; set; }
            [DataMember]
            public string day { get; set; }
        }
    }
    [DataContract]
    public class ChatMessage
    {
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public ChatMessageTypes Type { get; set; }
        [DataMember]
        public User User { get; set; }
    }
    [DataContract]
    public enum ChatMessageTypes { [EnumMember] PostAll, [EnumMember] PostGroup, [EnumMember] GroupTotal,
    [EnumMember] UsersTotal, [EnumMember] UsersRegistered, [EnumMember] UserDetails }

    public class Services
    {
        public enum ServicesEvents { SessionStart, SessionEnd, Login, Logout };
        private const string All = "All";
        private static Dictionary<string, ObservableCollection<Service>> Sessions { get; set; }
        static Services()
        {
            Services.Sessions = new Dictionary<string, ObservableCollection<Service>>();
            AddSessionCollection(Services.All);
        }
        public static List<Service> Group(string name)
        {
            return Services.Sessions[name].ToList();
        }
        public static List<Service> LoggedIn
        {
            get
            {
                return Services.Sessions[Services.All].Where(i => i.User != null).ToList();
            }
        }
        public static List<Service> List
        {
            get
            {
                return Services.Sessions[Services.All].ToList();
            }
        }
        private static void AddSessionCollection(string name)
        {
            Sessions.Add(name, new ObservableCollection<Service>());
            Sessions[name].CollectionChanged += Services.SessionEventHandler;
        }
        private static void SessionEventHandler(object sender, NotifyCollectionChangedEventArgs args)
        {
            var sessions = sender as ObservableCollection<Service>;
            string key = Services.Sessions.Where(i => i.Value == sessions).Select(i => i.Key).FirstOrDefault();
            // Main collection: session start or end
            if (key == Services.All)
                Services.Sessions[Services.All].ToList().ForEach(i => i.Notify(Services.CountTotal().ToString(), ChatMessageTypes.UsersTotal));
            // Not main collection: login, logout (notify all about registered and group about group)
            else
            {
                string countRegistered = Services.CountRegistered().ToString();
                sessions.ToList().ForEach(i => i.Notify(sessions.Count.ToString(), ChatMessageTypes.GroupTotal));
                Services.Sessions[Services.All].ToList().ForEach(i => i.Notify(countRegistered, ChatMessageTypes.UsersRegistered));
            }
        }
        public static void Update(ServicesEvents servicesEvent, Service session)
        {
            switch (servicesEvent)
            {
                case ServicesEvents.SessionStart:
                    Services.Sessions[Services.All].Add(session);
                    break;
                case ServicesEvents.SessionEnd:
                    if (session.User != null)
                        Services.Sessions[session.User.Group].Remove(session);
                    Services.Sessions[Services.All].Remove(session);
                    break;
                case ServicesEvents.Login:
                    string key = session.User.Group;
                    if (!Services.Sessions.ContainsKey(key))
                        Services.AddSessionCollection(key);
                    Services.Sessions[key].Add(session);
                    break;
                case ServicesEvents.Logout:
                    Services.Sessions[session.User.Group].Remove(session);
                    break;
                default: break;
            }
        }
        private static int CountTotal()
        {
            return Services.Sessions[Services.All].Count;
        }
        private static int CountRegistered()
        {
            return Services.Sessions.Where(i => i.Key != Services.All).ToList().Sum(i => i.Value.Count);
        }
    }
}