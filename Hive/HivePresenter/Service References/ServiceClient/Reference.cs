﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hive.Presenter.ServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ligasgr.net/services/hive", ConfigurationName="ServiceClient.HiveService")]
    public interface HiveService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ligasgr.net/services/hive/HiveService/Authenticate", ReplyAction="http://ligasgr.net/services/hive/HiveService/AuthenticateResponse")]
        Hive.Domain.User Authenticate(Hive.Domain.User user);
        
        // CODEGEN: Generating message contract since the operation FindAllPatiens is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://ligasgr.net/services/hive/HiveService/FindAllPatiens", ReplyAction="http://ligasgr.net/services/hive/HiveService/FindAllPatiensResponse")]
        Hive.Presenter.ServiceClient.FindPatientsResponse FindAllPatiens(Hive.Presenter.ServiceClient.FindAllPatiensRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindAllPatiensRequest {
        
        public FindAllPatiensRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FindPatientsResponse", WrapperNamespace="http://ligasgr.net/services/hive", IsWrapped=true)]
    public partial class FindPatientsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ligasgr.net/services/hive", Order=0)]
        public System.Collections.Generic.List<Hive.Domain.Patient> Results;
        
        public FindPatientsResponse() {
        }
        
        public FindPatientsResponse(System.Collections.Generic.List<Hive.Domain.Patient> Results) {
            this.Results = Results;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HiveServiceChannel : Hive.Presenter.ServiceClient.HiveService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HiveServiceClient : System.ServiceModel.ClientBase<Hive.Presenter.ServiceClient.HiveService>, Hive.Presenter.ServiceClient.HiveService {
        
        public HiveServiceClient() {
        }
        
        public HiveServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HiveServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HiveServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HiveServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Hive.Domain.User Authenticate(Hive.Domain.User user) {
            return base.Channel.Authenticate(user);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Hive.Presenter.ServiceClient.FindPatientsResponse Hive.Presenter.ServiceClient.HiveService.FindAllPatiens(Hive.Presenter.ServiceClient.FindAllPatiensRequest request) {
            return base.Channel.FindAllPatiens(request);
        }
        
        public System.Collections.Generic.List<Hive.Domain.Patient> FindAllPatiens() {
            Hive.Presenter.ServiceClient.FindAllPatiensRequest inValue = new Hive.Presenter.ServiceClient.FindAllPatiensRequest();
            Hive.Presenter.ServiceClient.FindPatientsResponse retVal = ((Hive.Presenter.ServiceClient.HiveService)(this)).FindAllPatiens(inValue);
            return retVal.Results;
        }
    }
}
