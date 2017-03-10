using System;
using System.Linq;
using System.ServiceModel;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ServiceLibrary
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

    /*public class SessionManager
    {
        public enum SessionManagerEvents { SessionStart, SessionEnd, Login, Logout };
        public const string All = "All";
        private static Dictionary<string, ObservableCollection<Service>> Sessions { get; set; }
        static SessionManager()
        {
            SessionManager.Sessions = new Dictionary<string, ObservableCollection<Service>>();
            AddSessionCollection(SessionManager.All);
        }
        private static void SessionEventHandler(object sender, NotifyCollectionChangedEventArgs args)
        {
            var sessions = sender as ObservableCollection<Service>;
            string key = SessionManager.Sessions.Where(i => i.Value == sessions).Select(i => i.Key).FirstOrDefault();
            // Main collection: session start or end
            if (key == SessionManager.All)
                SessionManager.Sessions[SessionManager.All].ToList().ForEach(i => i.AnnounceSelf(SessionManager.CountTotal().ToString(), ChatMessageTypes.GroupTotal));
            // Not main collection: login, logout (notify all about registered and group about group)
            else
            {
                string countRegistered = SessionManager.CountRegistered().ToString();
                sessions.ToList().ForEach(i => i.AnnounceSelf(sessions.Count.ToString(), ChatMessageTypes.GroupTotal));
                SessionManager.Sessions[SessionManager.All].ToList().ForEach(i => i.AnnounceSelf(countRegistered, ChatMessageTypes.GroupTotal));
                //SessionManager.Sessions.Where(i => i.Key != SessionManager.All).ToList().ForEach(j => j.Value.ToList().ForEach(y => y.AnnounceSelf(countRegistered, ChatMessageTypes.GroupTotal)));
            }
        }
        private static void AddSessionCollection(string name)
        {
            Sessions.Add(name, new ObservableCollection<Service>());
            Sessions[name].CollectionChanged += SessionManager.SessionEventHandler;
        }
        public static void Update(SessionManagerEvents sessionEvent, Service session)
        {
            switch (sessionEvent)
            {
                case SessionManagerEvents.SessionStart:
                    SessionManager.Sessions[SessionManager.All].Add(session);
                    break;
                case SessionManagerEvents.SessionEnd:
                    SessionManager.Sessions[SessionManager.All].Remove(session);
                    break;
                case SessionManagerEvents.Login:
                    string key = session.User.Group;
                    if (!SessionManager.Sessions.ContainsKey(key))
                        SessionManager.AddSessionCollection(key);
                    SessionManager.Sessions[key].Add(session);
                    break;
                case SessionManagerEvents.Logout:
                    SessionManager.Sessions[session.User.Group].Remove(session);
                    break;
                default: break;
            }
        }
        private static int CountTotal()
        {
            return SessionManager.Sessions[SessionManager.All].Count;
        }
        private static int CountRegistered()
        {
            return SessionManager.Sessions.Where(i => i.Key != SessionManager.All).ToList().Sum(i => i.Value.Count);
        }
    }*/
}