﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceClient.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeathersCo", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class WeathersCo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apiVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFServiceClient.ServiceReference.WeathersCo.WeathersCoData dataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apiVersion {
            get {
                return this.apiVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.apiVersionField, value) != true)) {
                    this.apiVersionField = value;
                    this.RaisePropertyChanged("apiVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFServiceClient.ServiceReference.WeathersCo.WeathersCoData data {
            get {
                return this.dataField;
            }
            set {
                if ((object.ReferenceEquals(this.dataField, value) != true)) {
                    this.dataField = value;
                    this.RaisePropertyChanged("data");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="WeathersCo.WeathersCoData", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
        [System.SerializableAttribute()]
        public partial class WeathersCoData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
            
            [System.NonSerializedAttribute()]
            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string dateField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string dayField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string humidityField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string locationField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string skytextField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string temperatureField;
            
            [System.Runtime.Serialization.OptionalFieldAttribute()]
            private string windField;
            
            public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
                get {
                    return this.extensionDataField;
                }
                set {
                    this.extensionDataField = value;
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string date {
                get {
                    return this.dateField;
                }
                set {
                    if ((object.ReferenceEquals(this.dateField, value) != true)) {
                        this.dateField = value;
                        this.RaisePropertyChanged("date");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string day {
                get {
                    return this.dayField;
                }
                set {
                    if ((object.ReferenceEquals(this.dayField, value) != true)) {
                        this.dayField = value;
                        this.RaisePropertyChanged("day");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string humidity {
                get {
                    return this.humidityField;
                }
                set {
                    if ((object.ReferenceEquals(this.humidityField, value) != true)) {
                        this.humidityField = value;
                        this.RaisePropertyChanged("humidity");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string location {
                get {
                    return this.locationField;
                }
                set {
                    if ((object.ReferenceEquals(this.locationField, value) != true)) {
                        this.locationField = value;
                        this.RaisePropertyChanged("location");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string skytext {
                get {
                    return this.skytextField;
                }
                set {
                    if ((object.ReferenceEquals(this.skytextField, value) != true)) {
                        this.skytextField = value;
                        this.RaisePropertyChanged("skytext");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string temperature {
                get {
                    return this.temperatureField;
                }
                set {
                    if ((object.ReferenceEquals(this.temperatureField, value) != true)) {
                        this.temperatureField = value;
                        this.RaisePropertyChanged("temperature");
                    }
                }
            }
            
            [System.Runtime.Serialization.DataMemberAttribute()]
            public string wind {
                get {
                    return this.windField;
                }
                set {
                    if ((object.ReferenceEquals(this.windField, value) != true)) {
                        this.windField = value;
                        this.RaisePropertyChanged("wind");
                    }
                }
            }
            
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
            
            protected void RaisePropertyChanged(string propertyName) {
                System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if ((propertyChanged != null)) {
                    propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LastLoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastLogin {
            get {
                return this.LastLoginField;
            }
            set {
                if ((this.LastLoginField.Equals(value) != true)) {
                    this.LastLoginField = value;
                    this.RaisePropertyChanged("LastLogin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IContract")]
    public interface IContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetWeather", ReplyAction="http://tempuri.org/IContract/GetWeatherResponse")]
        WCFServiceClient.ServiceReference.WeathersCo GetWeather(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetWeather", ReplyAction="http://tempuri.org/IContract/GetWeatherResponse")]
        System.Threading.Tasks.Task<WCFServiceClient.ServiceReference.WeathersCo> GetWeatherAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/Authenticate", ReplyAction="http://tempuri.org/IContract/AuthenticateResponse")]
        WCFServiceClient.ServiceReference.User Authenticate(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/Authenticate", ReplyAction="http://tempuri.org/IContract/AuthenticateResponse")]
        System.Threading.Tasks.Task<WCFServiceClient.ServiceReference.User> AuthenticateAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/AddUser", ReplyAction="http://tempuri.org/IContract/AddUserResponse")]
        WCFServiceClient.ServiceReference.User AddUser(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/AddUser", ReplyAction="http://tempuri.org/IContract/AddUserResponse")]
        System.Threading.Tasks.Task<WCFServiceClient.ServiceReference.User> AddUserAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/DeleteUser", ReplyAction="http://tempuri.org/IContract/DeleteUserResponse")]
        bool DeleteUser(WCFServiceClient.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/DeleteUser", ReplyAction="http://tempuri.org/IContract/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(WCFServiceClient.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateUser", ReplyAction="http://tempuri.org/IContract/UpdateUserResponse")]
        bool UpdateUser(WCFServiceClient.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateUser", ReplyAction="http://tempuri.org/IContract/UpdateUserResponse")]
        System.Threading.Tasks.Task<bool> UpdateUserAsync(WCFServiceClient.ServiceReference.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContractChannel : WCFServiceClient.ServiceReference.IContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContractClient : System.ServiceModel.ClientBase<WCFServiceClient.ServiceReference.IContract>, WCFServiceClient.ServiceReference.IContract {
        
        public ContractClient() {
        }
        
        public ContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFServiceClient.ServiceReference.WeathersCo GetWeather(string city) {
            return base.Channel.GetWeather(city);
        }
        
        public System.Threading.Tasks.Task<WCFServiceClient.ServiceReference.WeathersCo> GetWeatherAsync(string city) {
            return base.Channel.GetWeatherAsync(city);
        }
        
        public WCFServiceClient.ServiceReference.User Authenticate(string name, string password) {
            return base.Channel.Authenticate(name, password);
        }
        
        public System.Threading.Tasks.Task<WCFServiceClient.ServiceReference.User> AuthenticateAsync(string name, string password) {
            return base.Channel.AuthenticateAsync(name, password);
        }
        
        public WCFServiceClient.ServiceReference.User AddUser(string name, string password) {
            return base.Channel.AddUser(name, password);
        }
        
        public System.Threading.Tasks.Task<WCFServiceClient.ServiceReference.User> AddUserAsync(string name, string password) {
            return base.Channel.AddUserAsync(name, password);
        }
        
        public bool DeleteUser(WCFServiceClient.ServiceReference.User user) {
            return base.Channel.DeleteUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(WCFServiceClient.ServiceReference.User user) {
            return base.Channel.DeleteUserAsync(user);
        }
        
        public bool UpdateUser(WCFServiceClient.ServiceReference.User user) {
            return base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserAsync(WCFServiceClient.ServiceReference.User user) {
            return base.Channel.UpdateUserAsync(user);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IContractAlter")]
    public interface IContractAlter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContractAlter/GetData", ReplyAction="http://tempuri.org/IContractAlter/GetDataResponse")]
        void GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContractAlter/GetData", ReplyAction="http://tempuri.org/IContractAlter/GetDataResponse")]
        System.Threading.Tasks.Task GetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContractAlterChannel : WCFServiceClient.ServiceReference.IContractAlter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContractAlterClient : System.ServiceModel.ClientBase<WCFServiceClient.ServiceReference.IContractAlter>, WCFServiceClient.ServiceReference.IContractAlter {
        
        public ContractAlterClient() {
        }
        
        public ContractAlterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContractAlterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractAlterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractAlterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GetData() {
            base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
    }
}
