﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatCheese.Data.CommunicationCachingService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IndexWebIdentifier", Namespace="http://schemas.datacontract.org/2004/07/KnowledgeLake.Index.Client")]
    [System.SerializableAttribute()]
    public partial class IndexWebIdentifier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid SiteIdk__BackingFieldField;
        
        private string SiteUrlk__BackingFieldField;
        
        private System.Guid WebIdk__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<SiteId>k__BackingField", IsRequired=true)]
        public System.Guid SiteIdk__BackingField {
            get {
                return this.SiteIdk__BackingFieldField;
            }
            set {
                if ((this.SiteIdk__BackingFieldField.Equals(value) != true)) {
                    this.SiteIdk__BackingFieldField = value;
                    this.RaisePropertyChanged("SiteIdk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<SiteUrl>k__BackingField", IsRequired=true)]
        public string SiteUrlk__BackingField {
            get {
                return this.SiteUrlk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteUrlk__BackingFieldField, value) != true)) {
                    this.SiteUrlk__BackingFieldField = value;
                    this.RaisePropertyChanged("SiteUrlk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<WebId>k__BackingField", IsRequired=true)]
        public System.Guid WebIdk__BackingField {
            get {
                return this.WebIdk__BackingFieldField;
            }
            set {
                if ((this.WebIdk__BackingFieldField.Equals(value) != true)) {
                    this.WebIdk__BackingFieldField = value;
                    this.RaisePropertyChanged("WebIdk__BackingField");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SchemaDefinition", Namespace="http://schemas.datacontract.org/2004/07/KnowledgeLake.Capture.Server.Common")]
    [System.SerializableAttribute()]
    public partial class SchemaDefinition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SchemaInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid SiteIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string URLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid WebIDField;
        
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
        public string SchemaInfo {
            get {
                return this.SchemaInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.SchemaInfoField, value) != true)) {
                    this.SchemaInfoField = value;
                    this.RaisePropertyChanged("SchemaInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SiteID {
            get {
                return this.SiteIDField;
            }
            set {
                if ((this.SiteIDField.Equals(value) != true)) {
                    this.SiteIDField = value;
                    this.RaisePropertyChanged("SiteID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL {
            get {
                return this.URLField;
            }
            set {
                if ((object.ReferenceEquals(this.URLField, value) != true)) {
                    this.URLField = value;
                    this.RaisePropertyChanged("URL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid WebID {
            get {
                return this.WebIDField;
            }
            set {
                if ((this.WebIDField.Equals(value) != true)) {
                    this.WebIDField = value;
                    this.RaisePropertyChanged("WebID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CommunicationCachingService.ICommunicationCachingService")]
    public interface ICommunicationCachingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinitionResponse")]
        BatCheese.Data.CommunicationCachingService.SchemaDefinition GetSchemaDefinition(BatCheese.Data.CommunicationCachingService.IndexWebIdentifier idx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinitionResponse")]
        System.Threading.Tasks.Task<BatCheese.Data.CommunicationCachingService.SchemaDefinition> GetSchemaDefinitionAsync(BatCheese.Data.CommunicationCachingService.IndexWebIdentifier idx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinitionByUrl", ReplyAction="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinitionByUrlResponse")]
        BatCheese.Data.CommunicationCachingService.SchemaDefinition GetSchemaDefinitionByUrl(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinitionByUrl", ReplyAction="http://tempuri.org/ICommunicationCachingService/GetSchemaDefinitionByUrlResponse")]
        System.Threading.Tasks.Task<BatCheese.Data.CommunicationCachingService.SchemaDefinition> GetSchemaDefinitionByUrlAsync(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/AddRepositoryDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/AddRepositoryDefinitionResponse")]
        string AddRepositoryDefinition(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/AddRepositoryDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/AddRepositoryDefinitionResponse")]
        System.Threading.Tasks.Task<string> AddRepositoryDefinitionAsync(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/EditRepositoryDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/EditRepositoryDefinitionResponse")]
        string EditRepositoryDefinition(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/EditRepositoryDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/EditRepositoryDefinitionResponse")]
        System.Threading.Tasks.Task<string> EditRepositoryDefinitionAsync(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/UpdateRepositorySchema", ReplyAction="http://tempuri.org/ICommunicationCachingService/UpdateRepositorySchemaResponse")]
        bool UpdateRepositorySchema(string SiteURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/UpdateRepositorySchema", ReplyAction="http://tempuri.org/ICommunicationCachingService/UpdateRepositorySchemaResponse")]
        System.Threading.Tasks.Task<bool> UpdateRepositorySchemaAsync(string SiteURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/SaveSchemaDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/SaveSchemaDefinitionResponse")]
        void SaveSchemaDefinition(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/SaveSchemaDefinition", ReplyAction="http://tempuri.org/ICommunicationCachingService/SaveSchemaDefinitionResponse")]
        System.Threading.Tasks.Task SaveSchemaDefinitionAsync(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfo", ReplyAction="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfoResponse")]
        void DeleteSchemaInfo(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfo", ReplyAction="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfoResponse")]
        System.Threading.Tasks.Task DeleteSchemaInfoAsync(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/ClearAllSchemaDefinitions", ReplyAction="http://tempuri.org/ICommunicationCachingService/ClearAllSchemaDefinitionsResponse" +
            "")]
        void ClearAllSchemaDefinitions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/ClearAllSchemaDefinitions", ReplyAction="http://tempuri.org/ICommunicationCachingService/ClearAllSchemaDefinitionsResponse" +
            "")]
        System.Threading.Tasks.Task ClearAllSchemaDefinitionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfoByUrl", ReplyAction="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfoByUrlResponse")]
        void DeleteSchemaInfoByUrl(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfoByUrl", ReplyAction="http://tempuri.org/ICommunicationCachingService/DeleteSchemaInfoByUrlResponse")]
        System.Threading.Tasks.Task DeleteSchemaInfoByUrlAsync(string url);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommunicationCachingServiceChannel : BatCheese.Data.CommunicationCachingService.ICommunicationCachingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommunicationCachingServiceClient : System.ServiceModel.ClientBase<BatCheese.Data.CommunicationCachingService.ICommunicationCachingService>, BatCheese.Data.CommunicationCachingService.ICommunicationCachingService {
        
        public CommunicationCachingServiceClient() {
        }
        
        public CommunicationCachingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommunicationCachingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommunicationCachingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommunicationCachingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BatCheese.Data.CommunicationCachingService.SchemaDefinition GetSchemaDefinition(BatCheese.Data.CommunicationCachingService.IndexWebIdentifier idx) {
            return base.Channel.GetSchemaDefinition(idx);
        }
        
        public System.Threading.Tasks.Task<BatCheese.Data.CommunicationCachingService.SchemaDefinition> GetSchemaDefinitionAsync(BatCheese.Data.CommunicationCachingService.IndexWebIdentifier idx) {
            return base.Channel.GetSchemaDefinitionAsync(idx);
        }
        
        public BatCheese.Data.CommunicationCachingService.SchemaDefinition GetSchemaDefinitionByUrl(string url) {
            return base.Channel.GetSchemaDefinitionByUrl(url);
        }
        
        public System.Threading.Tasks.Task<BatCheese.Data.CommunicationCachingService.SchemaDefinition> GetSchemaDefinitionByUrlAsync(string url) {
            return base.Channel.GetSchemaDefinitionByUrlAsync(url);
        }
        
        public string AddRepositoryDefinition(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl) {
            return base.Channel.AddRepositoryDefinition(SiteURL, CredentialType, UserName, Password, Domain, ADFSUrl);
        }
        
        public System.Threading.Tasks.Task<string> AddRepositoryDefinitionAsync(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl) {
            return base.Channel.AddRepositoryDefinitionAsync(SiteURL, CredentialType, UserName, Password, Domain, ADFSUrl);
        }
        
        public string EditRepositoryDefinition(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl) {
            return base.Channel.EditRepositoryDefinition(SiteURL, CredentialType, UserName, Password, Domain, ADFSUrl);
        }
        
        public System.Threading.Tasks.Task<string> EditRepositoryDefinitionAsync(string SiteURL, string CredentialType, string UserName, string Password, string Domain, string ADFSUrl) {
            return base.Channel.EditRepositoryDefinitionAsync(SiteURL, CredentialType, UserName, Password, Domain, ADFSUrl);
        }
        
        public bool UpdateRepositorySchema(string SiteURL) {
            return base.Channel.UpdateRepositorySchema(SiteURL);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateRepositorySchemaAsync(string SiteURL) {
            return base.Channel.UpdateRepositorySchemaAsync(SiteURL);
        }
        
        public void SaveSchemaDefinition(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd) {
            base.Channel.SaveSchemaDefinition(sd);
        }
        
        public System.Threading.Tasks.Task SaveSchemaDefinitionAsync(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd) {
            return base.Channel.SaveSchemaDefinitionAsync(sd);
        }
        
        public void DeleteSchemaInfo(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd) {
            base.Channel.DeleteSchemaInfo(sd);
        }
        
        public System.Threading.Tasks.Task DeleteSchemaInfoAsync(BatCheese.Data.CommunicationCachingService.SchemaDefinition sd) {
            return base.Channel.DeleteSchemaInfoAsync(sd);
        }
        
        public void ClearAllSchemaDefinitions() {
            base.Channel.ClearAllSchemaDefinitions();
        }
        
        public System.Threading.Tasks.Task ClearAllSchemaDefinitionsAsync() {
            return base.Channel.ClearAllSchemaDefinitionsAsync();
        }
        
        public void DeleteSchemaInfoByUrl(string url) {
            base.Channel.DeleteSchemaInfoByUrl(url);
        }
        
        public System.Threading.Tasks.Task DeleteSchemaInfoByUrlAsync(string url) {
            return base.Channel.DeleteSchemaInfoByUrlAsync(url);
        }
    }
}