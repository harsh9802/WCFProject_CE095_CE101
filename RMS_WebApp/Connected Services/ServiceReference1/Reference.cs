﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMS_WebApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsertOrder", Namespace="http://schemas.datacontract.org/2004/07/RMS_Service")]
    [System.SerializableAttribute()]
    public partial class InsertOrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_CateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_DescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_StatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_TypeField;
        
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
        public string O_Cate {
            get {
                return this.O_CateField;
            }
            set {
                if ((object.ReferenceEquals(this.O_CateField, value) != true)) {
                    this.O_CateField = value;
                    this.RaisePropertyChanged("O_Cate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Desc {
            get {
                return this.O_DescField;
            }
            set {
                if ((object.ReferenceEquals(this.O_DescField, value) != true)) {
                    this.O_DescField = value;
                    this.RaisePropertyChanged("O_Desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Name {
            get {
                return this.O_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.O_NameField, value) != true)) {
                    this.O_NameField = value;
                    this.RaisePropertyChanged("O_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Price {
            get {
                return this.O_PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.O_PriceField, value) != true)) {
                    this.O_PriceField = value;
                    this.RaisePropertyChanged("O_Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Stat {
            get {
                return this.O_StatField;
            }
            set {
                if ((object.ReferenceEquals(this.O_StatField, value) != true)) {
                    this.O_StatField = value;
                    this.RaisePropertyChanged("O_Stat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Type {
            get {
                return this.O_TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.O_TypeField, value) != true)) {
                    this.O_TypeField = value;
                    this.RaisePropertyChanged("O_Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="getdata", Namespace="http://schemas.datacontract.org/2004/07/RMS_Service")]
    [System.SerializableAttribute()]
    public partial class getdata : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.DataTable Res_TabField;
        
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
        public System.Data.DataTable Res_Tab {
            get {
                return this.Res_TabField;
            }
            set {
                if ((object.ReferenceEquals(this.Res_TabField, value) != true)) {
                    this.Res_TabField = value;
                    this.RaisePropertyChanged("Res_Tab");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateOI", Namespace="http://schemas.datacontract.org/2004/07/RMS_Service")]
    [System.SerializableAttribute()]
    public partial class UpdateOI : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_CateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_DescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int O_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_StatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string O_TypeField;
        
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
        public string O_Cate {
            get {
                return this.O_CateField;
            }
            set {
                if ((object.ReferenceEquals(this.O_CateField, value) != true)) {
                    this.O_CateField = value;
                    this.RaisePropertyChanged("O_Cate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Desc {
            get {
                return this.O_DescField;
            }
            set {
                if ((object.ReferenceEquals(this.O_DescField, value) != true)) {
                    this.O_DescField = value;
                    this.RaisePropertyChanged("O_Desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int O_ID {
            get {
                return this.O_IDField;
            }
            set {
                if ((this.O_IDField.Equals(value) != true)) {
                    this.O_IDField = value;
                    this.RaisePropertyChanged("O_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Name {
            get {
                return this.O_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.O_NameField, value) != true)) {
                    this.O_NameField = value;
                    this.RaisePropertyChanged("O_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Price {
            get {
                return this.O_PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.O_PriceField, value) != true)) {
                    this.O_PriceField = value;
                    this.RaisePropertyChanged("O_Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Stat {
            get {
                return this.O_StatField;
            }
            set {
                if ((object.ReferenceEquals(this.O_StatField, value) != true)) {
                    this.O_StatField = value;
                    this.RaisePropertyChanged("O_Stat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string O_Type {
            get {
                return this.O_TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.O_TypeField, value) != true)) {
                    this.O_TypeField = value;
                    this.RaisePropertyChanged("O_Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteOI", Namespace="http://schemas.datacontract.org/2004/07/RMS_Service")]
    [System.SerializableAttribute()]
    public partial class DeleteOI : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int O_IDField;
        
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
        public int O_ID {
            get {
                return this.O_IDField;
            }
            set {
                if ((this.O_IDField.Equals(value) != true)) {
                    this.O_IDField = value;
                    this.RaisePropertyChanged("O_ID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        string Insert(RMS_WebApp.ServiceReference1.InsertOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        System.Threading.Tasks.Task<string> InsertAsync(RMS_WebApp.ServiceReference1.InsertOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOI", ReplyAction="http://tempuri.org/IService1/GetOIResponse")]
        RMS_WebApp.ServiceReference1.getdata GetOI();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOI", ReplyAction="http://tempuri.org/IService1/GetOIResponse")]
        System.Threading.Tasks.Task<RMS_WebApp.ServiceReference1.getdata> GetOIAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        string Update(RMS_WebApp.ServiceReference1.UpdateOI o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        System.Threading.Tasks.Task<string> UpdateAsync(RMS_WebApp.ServiceReference1.UpdateOI o);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        string Delete(RMS_WebApp.ServiceReference1.DeleteOI d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        System.Threading.Tasks.Task<string> DeleteAsync(RMS_WebApp.ServiceReference1.DeleteOI d);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : RMS_WebApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<RMS_WebApp.ServiceReference1.IService1>, RMS_WebApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Insert(RMS_WebApp.ServiceReference1.InsertOrder order) {
            return base.Channel.Insert(order);
        }
        
        public System.Threading.Tasks.Task<string> InsertAsync(RMS_WebApp.ServiceReference1.InsertOrder order) {
            return base.Channel.InsertAsync(order);
        }
        
        public RMS_WebApp.ServiceReference1.getdata GetOI() {
            return base.Channel.GetOI();
        }
        
        public System.Threading.Tasks.Task<RMS_WebApp.ServiceReference1.getdata> GetOIAsync() {
            return base.Channel.GetOIAsync();
        }
        
        public string Update(RMS_WebApp.ServiceReference1.UpdateOI o) {
            return base.Channel.Update(o);
        }
        
        public System.Threading.Tasks.Task<string> UpdateAsync(RMS_WebApp.ServiceReference1.UpdateOI o) {
            return base.Channel.UpdateAsync(o);
        }
        
        public string Delete(RMS_WebApp.ServiceReference1.DeleteOI d) {
            return base.Channel.Delete(d);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAsync(RMS_WebApp.ServiceReference1.DeleteOI d) {
            return base.Channel.DeleteAsync(d);
        }
    }
}
