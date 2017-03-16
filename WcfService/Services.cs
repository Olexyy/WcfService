using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Data.Entity;

namespace ChatLibrary
{
    public class Services
    {
        public enum ServicesEvents { SessionStart, SessionEnd, Login, Logout };
        private const string Total = "root";
        private static Dictionary<string, ObservableCollection<Service>> Sessions { get; set; }
        static Services()
        {
            Services.Sessions = new Dictionary<string, ObservableCollection<Service>>();
            AddSessionCollection(Services.Total);
        }
        public static List<Service> Group(string name)
        {
            return Services.Sessions[name].ToList();
        }
        public static List<Service> LoggedIn
        {
            get
            {
                return Services.Sessions[Services.Total].Where(i => i.User != null).ToList();
            }
        }
        public static List<Service> All
        {
            get
            {
                return Services.Sessions[Services.Total].ToList();
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
            if (key == Services.Total)
                Services.Sessions[Services.Total].ToList().ForEach(i => i.Notify(Services.All.Count.ToString(), ChatMessageTypes.UsersTotal));
            // Not main collection: login, logout (notify all about registered and group about group)
            else
            {
                string countRegistered = Services.LoggedIn.Count.ToString();
                Services.Sessions[Services.Total].ToList().ForEach(i => i.Notify(countRegistered, ChatMessageTypes.UsersRegistered));
                sessions.ToList().ForEach(i => i.Notify(sessions.Count.ToString(), ChatMessageTypes.GroupTotal));
                // Notify incoming or outcoming user of group and status details
                if (args.OldItems != null)
                    args.OldItems.Cast<Service>().ToList().ForEach(i => i.Notify(String.Empty, ChatMessageTypes.UserDetails, null));
                if (args.NewItems != null)
                    args.NewItems.Cast<Service>().ToList().ForEach(i => i.Notify(String.Empty, ChatMessageTypes.UserDetails, i.User));
            }
        }
        public static void Update(ServicesEvents servicesEvent, Service session)
        {
            switch (servicesEvent)
            {
                case ServicesEvents.SessionStart:
                    Services.Sessions[Services.Total].Add(session);
                    break;
                case ServicesEvents.SessionEnd:
                    if (session.User != null)
                        Services.Sessions[session.User.Group].Remove(session);
                    Services.Sessions[Services.Total].Remove(session);
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
    }
}