﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMVCConsumingWebApi.ServiceGetProducts {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Transaction", Namespace="http://schemas.datacontract.org/2004/07/WCFAuth.Models")]
    [System.SerializableAttribute()]
    public partial class Transaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AppMVCConsumingWebApi.ServiceGetProducts.Product[] ProductsField;
        
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
        public bool IsValid {
            get {
                return this.IsValidField;
            }
            set {
                if ((this.IsValidField.Equals(value) != true)) {
                    this.IsValidField = value;
                    this.RaisePropertyChanged("IsValid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AppMVCConsumingWebApi.ServiceGetProducts.Product[] Products {
            get {
                return this.ProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsField, value) != true)) {
                    this.ProductsField = value;
                    this.RaisePropertyChanged("Products");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WCFAuth.Models")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        public decimal Price {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceGetProducts.IProduct")]
    public interface IProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        AppMVCConsumingWebApi.ServiceGetProducts.GetProductResponse GetProduct(AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        System.IAsyncResult BeginGetProduct(AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest request, System.AsyncCallback callback, object asyncState);
        
        AppMVCConsumingWebApi.ServiceGetProducts.GetProductResponse EndGetProduct(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProduct", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetProductRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string token;
        
        public GetProductRequest() {
        }
        
        public GetProductRequest(string token) {
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetProductResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetProductResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public AppMVCConsumingWebApi.ServiceGetProducts.Transaction GetProductResult;
        
        public GetProductResponse() {
        }
        
        public GetProductResponse(AppMVCConsumingWebApi.ServiceGetProducts.Transaction GetProductResult) {
            this.GetProductResult = GetProductResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductChannel : AppMVCConsumingWebApi.ServiceGetProducts.IProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProductCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProductCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AppMVCConsumingWebApi.ServiceGetProducts.GetProductResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AppMVCConsumingWebApi.ServiceGetProducts.GetProductResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductClient : System.ServiceModel.ClientBase<AppMVCConsumingWebApi.ServiceGetProducts.IProduct>, AppMVCConsumingWebApi.ServiceGetProducts.IProduct {
        
        private BeginOperationDelegate onBeginGetProductDelegate;
        
        private EndOperationDelegate onEndGetProductDelegate;
        
        private System.Threading.SendOrPostCallback onGetProductCompletedDelegate;
        
        public ProductClient() {
        }
        
        public ProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetProductCompletedEventArgs> GetProductCompleted;
        
        public AppMVCConsumingWebApi.ServiceGetProducts.GetProductResponse GetProduct(AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest request) {
            return base.Channel.GetProduct(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetProduct(AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProduct(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public AppMVCConsumingWebApi.ServiceGetProducts.GetProductResponse EndGetProduct(System.IAsyncResult result) {
            return base.Channel.EndGetProduct(result);
        }
        
        private System.IAsyncResult OnBeginGetProduct(object[] inValues, System.AsyncCallback callback, object asyncState) {
            AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest request = ((AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest)(inValues[0]));
            return this.BeginGetProduct(request, callback, asyncState);
        }
        
        private object[] OnEndGetProduct(System.IAsyncResult result) {
            AppMVCConsumingWebApi.ServiceGetProducts.GetProductResponse retVal = this.EndGetProduct(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProductCompleted(object state) {
            if ((this.GetProductCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProductCompleted(this, new GetProductCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProductAsync(AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest request) {
            this.GetProductAsync(request, null);
        }
        
        public void GetProductAsync(AppMVCConsumingWebApi.ServiceGetProducts.GetProductRequest request, object userState) {
            if ((this.onBeginGetProductDelegate == null)) {
                this.onBeginGetProductDelegate = new BeginOperationDelegate(this.OnBeginGetProduct);
            }
            if ((this.onEndGetProductDelegate == null)) {
                this.onEndGetProductDelegate = new EndOperationDelegate(this.OnEndGetProduct);
            }
            if ((this.onGetProductCompletedDelegate == null)) {
                this.onGetProductCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProductCompleted);
            }
            base.InvokeAsync(this.onBeginGetProductDelegate, new object[] {
                        request}, this.onEndGetProductDelegate, this.onGetProductCompletedDelegate, userState);
        }
    }
}
