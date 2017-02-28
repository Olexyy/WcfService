using System;
using System.Linq;
using System.ServiceModel;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace ServiceLibrary
{
    [ServiceContract]
    public interface IContractAlter
    {
        [OperationContract]
        void GetData();
    }
        [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        WeathersCo GetWeather(string city);
        [OperationContract]
        User Authenticate(string name, string password);
        [OperationContract]
        User AddUser(string name, string password);
        [OperationContract]
        bool DeleteUser(User user);
        [OperationContract]
        bool UpdateUser(User user);
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
}