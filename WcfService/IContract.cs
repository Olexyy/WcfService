﻿using System;
using System.Linq;
using System.ServiceModel;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ServiceLibrary
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    [ServiceKnownType(typeof(ChatMessageTypes))]
    public interface IContractChat
    {
        [OperationContract]
        List<ChatMessage> GetMessages();
        [OperationContract]
        void PushMessage(string message);
        [OperationContract]
        bool LogIn(string name, string password);
        [OperationContract]
        bool LogOut();
        [OperationContract]
        User Authenticate(string name, string password);
        [OperationContract]
        User GetUser();
        [OperationContract]
        User AddUser(string name, string password);
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
    public enum ChatMessageTypes { [EnumMember] Posting, [EnumMember] UsersTotal, [EnumMember] UsersRegistered }
}