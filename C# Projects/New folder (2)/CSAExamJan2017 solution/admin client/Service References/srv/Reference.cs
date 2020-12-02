﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace admin_client.srv {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="House", Namespace="http://schemas.datacontract.org/2004/07/service")]
    [System.SerializableAttribute()]
    public partial class House : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OfferStatus", Namespace="http://schemas.datacontract.org/2004/07/service")]
    public enum OfferStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Succeeded = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SucceededAndUnavailable = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unavailable = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srv.IService", CallbackContract=typeof(admin_client.srv.IServiceCallback))]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAskingPrice", ReplyAction="http://tempuri.org/IService/GetAskingPriceResponse")]
        int GetAskingPrice(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAskingPrice", ReplyAction="http://tempuri.org/IService/GetAskingPriceResponse")]
        System.Threading.Tasks.Task<int> GetAskingPriceAsync(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAvailableHouses", ReplyAction="http://tempuri.org/IService/GetAvailableHousesResponse")]
        admin_client.srv.House[] GetAvailableHouses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAvailableHouses", ReplyAction="http://tempuri.org/IService/GetAvailableHousesResponse")]
        System.Threading.Tasks.Task<admin_client.srv.House[]> GetAvailableHousesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MakeAnOffer", ReplyAction="http://tempuri.org/IService/MakeAnOfferResponse")]
        admin_client.srv.OfferStatus MakeAnOffer(string address, int offer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/MakeAnOffer", ReplyAction="http://tempuri.org/IService/MakeAnOfferResponse")]
        System.Threading.Tasks.Task<admin_client.srv.OfferStatus> MakeAnOfferAsync(string address, int offer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Connect")]
        void Connect();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Connect")]
        System.Threading.Tasks.Task ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Disconnect")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/Disconnect")]
        System.Threading.Tasks.Task DisconnectAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/HouseIsNotAvailable")]
        void HouseIsNotAvailable(string address);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : admin_client.srv.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.DuplexClientBase<admin_client.srv.IService>, admin_client.srv.IService {
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int GetAskingPrice(string address) {
            return base.Channel.GetAskingPrice(address);
        }
        
        public System.Threading.Tasks.Task<int> GetAskingPriceAsync(string address) {
            return base.Channel.GetAskingPriceAsync(address);
        }
        
        public admin_client.srv.House[] GetAvailableHouses() {
            return base.Channel.GetAvailableHouses();
        }
        
        public System.Threading.Tasks.Task<admin_client.srv.House[]> GetAvailableHousesAsync() {
            return base.Channel.GetAvailableHousesAsync();
        }
        
        public admin_client.srv.OfferStatus MakeAnOffer(string address, int offer) {
            return base.Channel.MakeAnOffer(address, offer);
        }
        
        public System.Threading.Tasks.Task<admin_client.srv.OfferStatus> MakeAnOfferAsync(string address, int offer) {
            return base.Channel.MakeAnOfferAsync(address, offer);
        }
        
        public void Connect() {
            base.Channel.Connect();
        }
        
        public System.Threading.Tasks.Task ConnectAsync() {
            return base.Channel.ConnectAsync();
        }
        
        public void Disconnect() {
            base.Channel.Disconnect();
        }
        
        public System.Threading.Tasks.Task DisconnectAsync() {
            return base.Channel.DisconnectAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srv.IAdmin")]
    public interface IAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdmin/GetOffers", ReplyAction="http://tempuri.org/IAdmin/GetOffersResponse")]
        int[] GetOffers(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdmin/GetOffers", ReplyAction="http://tempuri.org/IAdmin/GetOffersResponse")]
        System.Threading.Tasks.Task<int[]> GetOffersAsync(string address);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminChannel : admin_client.srv.IAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminClient : System.ServiceModel.ClientBase<admin_client.srv.IAdmin>, admin_client.srv.IAdmin {
        
        public AdminClient() {
        }
        
        public AdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] GetOffers(string address) {
            return base.Channel.GetOffers(address);
        }
        
        public System.Threading.Tasks.Task<int[]> GetOffersAsync(string address) {
            return base.Channel.GetOffersAsync(address);
        }
    }
}
