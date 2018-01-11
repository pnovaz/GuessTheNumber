﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumberApp.numberServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="numberServices.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/secretNumber", ReplyAction="http://tempuri.org/IService1/secretNumberResponse")]
        int secretNumber(int min, int max);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/secretNumber", ReplyAction="http://tempuri.org/IService1/secretNumberResponse")]
        System.Threading.Tasks.Task<int> secretNumberAsync(int min, int max);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkNumber", ReplyAction="http://tempuri.org/IService1/checkNumberResponse")]
        string checkNumber(int userNum, int secretNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/checkNumber", ReplyAction="http://tempuri.org/IService1/checkNumberResponse")]
        System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int secretNum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : NumberApp.numberServices.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<NumberApp.numberServices.IService1>, NumberApp.numberServices.IService1 {
        
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
        
        public int secretNumber(int min, int max) {
            return base.Channel.secretNumber(min, max);
        }
        
        public System.Threading.Tasks.Task<int> secretNumberAsync(int min, int max) {
            return base.Channel.secretNumberAsync(min, max);
        }
        
        public string checkNumber(int userNum, int secretNum) {
            return base.Channel.checkNumber(userNum, secretNum);
        }
        
        public System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int secretNum) {
            return base.Channel.checkNumberAsync(userNum, secretNum);
        }
    }
}