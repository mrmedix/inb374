﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Testing.SalesSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Quote", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    [System.SerializableAttribute()]
    public partial class Quote : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AdditionalLabourPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsApprovedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Testing.SalesSvc.Item[] ItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PartsETAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PurchaseOrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalServiceTimeField;
        
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
        public int AdditionalLabourPrice {
            get {
                return this.AdditionalLabourPriceField;
            }
            set {
                if ((this.AdditionalLabourPriceField.Equals(value) != true)) {
                    this.AdditionalLabourPriceField = value;
                    this.RaisePropertyChanged("AdditionalLabourPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsApproved {
            get {
                return this.IsApprovedField;
            }
            set {
                if ((this.IsApprovedField.Equals(value) != true)) {
                    this.IsApprovedField = value;
                    this.RaisePropertyChanged("IsApproved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Testing.SalesSvc.Item[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PartsETA {
            get {
                return this.PartsETAField;
            }
            set {
                if ((this.PartsETAField.Equals(value) != true)) {
                    this.PartsETAField = value;
                    this.RaisePropertyChanged("PartsETA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PurchaseOrderID {
            get {
                return this.PurchaseOrderIDField;
            }
            set {
                if ((this.PurchaseOrderIDField.Equals(value) != true)) {
                    this.PurchaseOrderIDField = value;
                    this.RaisePropertyChanged("PurchaseOrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceDescription {
            get {
                return this.ServiceDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceDescriptionField, value) != true)) {
                    this.ServiceDescriptionField = value;
                    this.RaisePropertyChanged("ServiceDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalServiceTime {
            get {
                return this.TotalServiceTimeField;
            }
            set {
                if ((this.TotalServiceTimeField.Equals(value) != true)) {
                    this.TotalServiceTimeField = value;
                    this.RaisePropertyChanged("TotalServiceTime");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ServiceTimeField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ServiceTime {
            get {
                return this.ServiceTimeField;
            }
            set {
                if ((this.ServiceTimeField.Equals(value) != true)) {
                    this.ServiceTimeField = value;
                    this.RaisePropertyChanged("ServiceTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalesSvc.ISalesService")]
    public interface ISalesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/GetQuotes", ReplyAction="http://tempuri.org/ISalesService/GetQuotesResponse")]
        Testing.SalesSvc.Quote[] GetQuotes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/GetQuotes", ReplyAction="http://tempuri.org/ISalesService/GetQuotesResponse")]
        System.Threading.Tasks.Task<Testing.SalesSvc.Quote[]> GetQuotesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/GetQuote", ReplyAction="http://tempuri.org/ISalesService/GetQuoteResponse")]
        Testing.SalesSvc.Quote GetQuote(int quoteID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/GetQuote", ReplyAction="http://tempuri.org/ISalesService/GetQuoteResponse")]
        System.Threading.Tasks.Task<Testing.SalesSvc.Quote> GetQuoteAsync(int quoteID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/AddNewQuote", ReplyAction="http://tempuri.org/ISalesService/AddNewQuoteResponse")]
        int AddNewQuote(Testing.SalesSvc.Quote quote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesService/AddNewQuote", ReplyAction="http://tempuri.org/ISalesService/AddNewQuoteResponse")]
        System.Threading.Tasks.Task<int> AddNewQuoteAsync(Testing.SalesSvc.Quote quote);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISalesServiceChannel : Testing.SalesSvc.ISalesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalesServiceClient : System.ServiceModel.ClientBase<Testing.SalesSvc.ISalesService>, Testing.SalesSvc.ISalesService {
        
        public SalesServiceClient() {
        }
        
        public SalesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Testing.SalesSvc.Quote[] GetQuotes() {
            return base.Channel.GetQuotes();
        }
        
        public System.Threading.Tasks.Task<Testing.SalesSvc.Quote[]> GetQuotesAsync() {
            return base.Channel.GetQuotesAsync();
        }
        
        public Testing.SalesSvc.Quote GetQuote(int quoteID) {
            return base.Channel.GetQuote(quoteID);
        }
        
        public System.Threading.Tasks.Task<Testing.SalesSvc.Quote> GetQuoteAsync(int quoteID) {
            return base.Channel.GetQuoteAsync(quoteID);
        }
        
        public int AddNewQuote(Testing.SalesSvc.Quote quote) {
            return base.Channel.AddNewQuote(quote);
        }
        
        public System.Threading.Tasks.Task<int> AddNewQuoteAsync(Testing.SalesSvc.Quote quote) {
            return base.Channel.AddNewQuoteAsync(quote);
        }
    }
}