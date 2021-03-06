﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sales.DataSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public string Postcode {
            get {
                return this.PostcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostcodeField, value) != true)) {
                    this.PostcodeField = value;
                    this.RaisePropertyChanged("Postcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Quote", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    [System.SerializableAttribute()]
    public partial class Quote : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sales.DataSvc.Item[] ItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LabourPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PartsETAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PurchaseOrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sales.DataSvc.StatusCode StatusField;
        
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
        public Sales.DataSvc.Item[] Items {
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
        public int LabourPrice {
            get {
                return this.LabourPriceField;
            }
            set {
                if ((this.LabourPriceField.Equals(value) != true)) {
                    this.LabourPriceField = value;
                    this.RaisePropertyChanged("LabourPrice");
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
        public Sales.DataSvc.StatusCode Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusCode", Namespace="http://schemas.datacontract.org/2004/07/Data")]
    public enum StatusCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        New = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ApprovedCheckStock = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ApprovedBookService = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ApprovedNotInStock = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ETAPendingApproval = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ApprovedETA = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Booked = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejected = 7,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataSvc.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetCustomers", ReplyAction="http://tempuri.org/IDataService/GetCustomersResponse")]
        Sales.DataSvc.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetCustomers", ReplyAction="http://tempuri.org/IDataService/GetCustomersResponse")]
        System.Threading.Tasks.Task<Sales.DataSvc.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetCustomer", ReplyAction="http://tempuri.org/IDataService/GetCustomerResponse")]
        Sales.DataSvc.Customer GetCustomer(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetCustomer", ReplyAction="http://tempuri.org/IDataService/GetCustomerResponse")]
        System.Threading.Tasks.Task<Sales.DataSvc.Customer> GetCustomerAsync(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetQuotes", ReplyAction="http://tempuri.org/IDataService/GetQuotesResponse")]
        Sales.DataSvc.Quote[] GetQuotes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetQuotes", ReplyAction="http://tempuri.org/IDataService/GetQuotesResponse")]
        System.Threading.Tasks.Task<Sales.DataSvc.Quote[]> GetQuotesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetQuote", ReplyAction="http://tempuri.org/IDataService/GetQuoteResponse")]
        Sales.DataSvc.Quote GetQuote(int quoteID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetQuote", ReplyAction="http://tempuri.org/IDataService/GetQuoteResponse")]
        System.Threading.Tasks.Task<Sales.DataSvc.Quote> GetQuoteAsync(int quoteID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/AddNewQuote", ReplyAction="http://tempuri.org/IDataService/AddNewQuoteResponse")]
        int AddNewQuote(Sales.DataSvc.Quote quote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/AddNewQuote", ReplyAction="http://tempuri.org/IDataService/AddNewQuoteResponse")]
        System.Threading.Tasks.Task<int> AddNewQuoteAsync(Sales.DataSvc.Quote quote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/ModifyQuote", ReplyAction="http://tempuri.org/IDataService/ModifyQuoteResponse")]
        void ModifyQuote(Sales.DataSvc.Quote quote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/ModifyQuote", ReplyAction="http://tempuri.org/IDataService/ModifyQuoteResponse")]
        System.Threading.Tasks.Task ModifyQuoteAsync(Sales.DataSvc.Quote quote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetItems", ReplyAction="http://tempuri.org/IDataService/GetItemsResponse")]
        Sales.DataSvc.Item[] GetItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetItems", ReplyAction="http://tempuri.org/IDataService/GetItemsResponse")]
        System.Threading.Tasks.Task<Sales.DataSvc.Item[]> GetItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/HelloWorld", ReplyAction="http://tempuri.org/IDataService/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/HelloWorld", ReplyAction="http://tempuri.org/IDataService/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : Sales.DataSvc.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<Sales.DataSvc.IDataService>, Sales.DataSvc.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sales.DataSvc.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<Sales.DataSvc.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public Sales.DataSvc.Customer GetCustomer(int customerID) {
            return base.Channel.GetCustomer(customerID);
        }
        
        public System.Threading.Tasks.Task<Sales.DataSvc.Customer> GetCustomerAsync(int customerID) {
            return base.Channel.GetCustomerAsync(customerID);
        }
        
        public Sales.DataSvc.Quote[] GetQuotes() {
            return base.Channel.GetQuotes();
        }
        
        public System.Threading.Tasks.Task<Sales.DataSvc.Quote[]> GetQuotesAsync() {
            return base.Channel.GetQuotesAsync();
        }
        
        public Sales.DataSvc.Quote GetQuote(int quoteID) {
            return base.Channel.GetQuote(quoteID);
        }
        
        public System.Threading.Tasks.Task<Sales.DataSvc.Quote> GetQuoteAsync(int quoteID) {
            return base.Channel.GetQuoteAsync(quoteID);
        }
        
        public int AddNewQuote(Sales.DataSvc.Quote quote) {
            return base.Channel.AddNewQuote(quote);
        }
        
        public System.Threading.Tasks.Task<int> AddNewQuoteAsync(Sales.DataSvc.Quote quote) {
            return base.Channel.AddNewQuoteAsync(quote);
        }
        
        public void ModifyQuote(Sales.DataSvc.Quote quote) {
            base.Channel.ModifyQuote(quote);
        }
        
        public System.Threading.Tasks.Task ModifyQuoteAsync(Sales.DataSvc.Quote quote) {
            return base.Channel.ModifyQuoteAsync(quote);
        }
        
        public Sales.DataSvc.Item[] GetItems() {
            return base.Channel.GetItems();
        }
        
        public System.Threading.Tasks.Task<Sales.DataSvc.Item[]> GetItemsAsync() {
            return base.Channel.GetItemsAsync();
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
    }
}
