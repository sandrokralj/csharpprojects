﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfOrderClient.SrvClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/FastFoodService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
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
        public double Price {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SrvClient.IFoodOrder", CallbackContract=typeof(SelfOrderClient.SrvClient.IFoodOrderCallback))]
    public interface IFoodOrder {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodOrder/GetOderNumber", ReplyAction="http://tempuri.org/IFoodOrder/GetOderNumberResponse")]
        int GetOderNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodOrder/GetOderNumber", ReplyAction="http://tempuri.org/IFoodOrder/GetOderNumberResponse")]
        System.Threading.Tasks.Task<int> GetOderNumberAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodOrder/GetProductList", ReplyAction="http://tempuri.org/IFoodOrder/GetProductListResponse")]
        SelfOrderClient.SrvClient.Product[] GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodOrder/GetProductList", ReplyAction="http://tempuri.org/IFoodOrder/GetProductListResponse")]
        System.Threading.Tasks.Task<SelfOrderClient.SrvClient.Product[]> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFoodOrder/CreateOrder")]
        void CreateOrder(string[] list, int orderNr);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IFoodOrder/CreateOrder")]
        System.Threading.Tasks.Task CreateOrderAsync(string[] list, int orderNr);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFoodOrderCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodOrder/OrderStatus", ReplyAction="http://tempuri.org/IFoodOrder/OrderStatusResponse")]
        void OrderStatus(bool status, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFoodOrderChannel : SelfOrderClient.SrvClient.IFoodOrder, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FoodOrderClient : System.ServiceModel.DuplexClientBase<SelfOrderClient.SrvClient.IFoodOrder>, SelfOrderClient.SrvClient.IFoodOrder {
        
        public FoodOrderClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public FoodOrderClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public FoodOrderClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public FoodOrderClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public FoodOrderClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int GetOderNumber() {
            return base.Channel.GetOderNumber();
        }
        
        public System.Threading.Tasks.Task<int> GetOderNumberAsync() {
            return base.Channel.GetOderNumberAsync();
        }
        
        public SelfOrderClient.SrvClient.Product[] GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<SelfOrderClient.SrvClient.Product[]> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public void CreateOrder(string[] list, int orderNr) {
            base.Channel.CreateOrder(list, orderNr);
        }
        
        public System.Threading.Tasks.Task CreateOrderAsync(string[] list, int orderNr) {
            return base.Channel.CreateOrderAsync(list, orderNr);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SrvClient.IFoodAdmin")]
    public interface IFoodAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodAdmin/Connect", ReplyAction="http://tempuri.org/IFoodAdmin/ConnectResponse")]
        void Connect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodAdmin/Connect", ReplyAction="http://tempuri.org/IFoodAdmin/ConnectResponse")]
        System.Threading.Tasks.Task ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodAdmin/Disconnect", ReplyAction="http://tempuri.org/IFoodAdmin/DisconnectResponse")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFoodAdmin/Disconnect", ReplyAction="http://tempuri.org/IFoodAdmin/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFoodAdminChannel : SelfOrderClient.SrvClient.IFoodAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FoodAdminClient : System.ServiceModel.ClientBase<SelfOrderClient.SrvClient.IFoodAdmin>, SelfOrderClient.SrvClient.IFoodAdmin {
        
        public FoodAdminClient() {
        }
        
        public FoodAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FoodAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FoodAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FoodAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
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
}
