﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VendedorPassagem.ControladorPassagemService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Passagem", Namespace="http://schemas.datacontract.org/2004/07/PassagemServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Passagem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DisponivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValorField;
        
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
        public System.DateTime Data {
            get {
                return this.DataField;
            }
            set {
                if ((this.DataField.Equals(value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destino {
            get {
                return this.DestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinoField, value) != true)) {
                    this.DestinoField = value;
                    this.RaisePropertyChanged("Destino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Disponivel {
            get {
                return this.DisponivelField;
            }
            set {
                if ((this.DisponivelField.Equals(value) != true)) {
                    this.DisponivelField = value;
                    this.RaisePropertyChanged("Disponivel");
                }
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
        public decimal Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ControladorPassagemService.IControladorPassagemService")]
    public interface IControladorPassagemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorPassagemService/AddPassagem", ReplyAction="http://tempuri.org/IControladorPassagemService/AddPassagemResponse")]
        bool AddPassagem(string destino, System.DateTime data, decimal valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorPassagemService/AddPassagem", ReplyAction="http://tempuri.org/IControladorPassagemService/AddPassagemResponse")]
        System.Threading.Tasks.Task<bool> AddPassagemAsync(string destino, System.DateTime data, decimal valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorPassagemService/ListarPassagens", ReplyAction="http://tempuri.org/IControladorPassagemService/ListarPassagensResponse")]
        VendedorPassagem.ControladorPassagemService.Passagem[] ListarPassagens();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorPassagemService/ListarPassagens", ReplyAction="http://tempuri.org/IControladorPassagemService/ListarPassagensResponse")]
        System.Threading.Tasks.Task<VendedorPassagem.ControladorPassagemService.Passagem[]> ListarPassagensAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorPassagemService/venderPassagem", ReplyAction="http://tempuri.org/IControladorPassagemService/venderPassagemResponse")]
        bool venderPassagem(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorPassagemService/venderPassagem", ReplyAction="http://tempuri.org/IControladorPassagemService/venderPassagemResponse")]
        System.Threading.Tasks.Task<bool> venderPassagemAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControladorPassagemServiceChannel : VendedorPassagem.ControladorPassagemService.IControladorPassagemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControladorPassagemServiceClient : System.ServiceModel.ClientBase<VendedorPassagem.ControladorPassagemService.IControladorPassagemService>, VendedorPassagem.ControladorPassagemService.IControladorPassagemService {
        
        public ControladorPassagemServiceClient() {
        }
        
        public ControladorPassagemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ControladorPassagemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControladorPassagemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControladorPassagemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddPassagem(string destino, System.DateTime data, decimal valor) {
            return base.Channel.AddPassagem(destino, data, valor);
        }
        
        public System.Threading.Tasks.Task<bool> AddPassagemAsync(string destino, System.DateTime data, decimal valor) {
            return base.Channel.AddPassagemAsync(destino, data, valor);
        }
        
        public VendedorPassagem.ControladorPassagemService.Passagem[] ListarPassagens() {
            return base.Channel.ListarPassagens();
        }
        
        public System.Threading.Tasks.Task<VendedorPassagem.ControladorPassagemService.Passagem[]> ListarPassagensAsync() {
            return base.Channel.ListarPassagensAsync();
        }
        
        public bool venderPassagem(System.Guid id) {
            return base.Channel.venderPassagem(id);
        }
        
        public System.Threading.Tasks.Task<bool> venderPassagemAsync(System.Guid id) {
            return base.Channel.venderPassagemAsync(id);
        }
    }
}