﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControladorPassagem.PassagemService {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PassagemService.IPassagemService")]
    public interface IPassagemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassagemService/criarPassagem", ReplyAction="http://tempuri.org/IPassagemService/criarPassagemResponse")]
        ControladorPassagem.PassagemService.Passagem criarPassagem(string destino, System.DateTime data, decimal valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPassagemService/criarPassagem", ReplyAction="http://tempuri.org/IPassagemService/criarPassagemResponse")]
        System.Threading.Tasks.Task<ControladorPassagem.PassagemService.Passagem> criarPassagemAsync(string destino, System.DateTime data, decimal valor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPassagemServiceChannel : ControladorPassagem.PassagemService.IPassagemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PassagemServiceClient : System.ServiceModel.ClientBase<ControladorPassagem.PassagemService.IPassagemService>, ControladorPassagem.PassagemService.IPassagemService {
        
        public PassagemServiceClient() {
        }
        
        public PassagemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PassagemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassagemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassagemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ControladorPassagem.PassagemService.Passagem criarPassagem(string destino, System.DateTime data, decimal valor) {
            return base.Channel.criarPassagem(destino, data, valor);
        }
        
        public System.Threading.Tasks.Task<ControladorPassagem.PassagemService.Passagem> criarPassagemAsync(string destino, System.DateTime data, decimal valor) {
            return base.Channel.criarPassagemAsync(destino, data, valor);
        }
    }
}
