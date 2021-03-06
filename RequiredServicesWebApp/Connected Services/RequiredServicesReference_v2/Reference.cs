//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RequiredServicesWebApp.RequiredServicesReference_v2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RequiredServicesReference_v2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordFilter", ReplyAction="http://tempuri.org/IService1/WordFilterResponse")]
        string WordFilter(string userInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordFilter", ReplyAction="http://tempuri.org/IService1/WordFilterResponse")]
        System.Threading.Tasks.Task<string> WordFilterAsync(string userInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStarted", ReplyAction="http://tempuri.org/IService1/getStartedResponse")]
        string getStarted(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStarted", ReplyAction="http://tempuri.org/IService1/getStartedResponse")]
        System.Threading.Tasks.Task<string> getStartedAsync(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/orderAndTakeTopTen", ReplyAction="http://tempuri.org/IService1/orderAndTakeTopTenResponse")]
        string orderAndTakeTopTen(System.Collections.Generic.Dictionary<string, int> difference);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/orderAndTakeTopTen", ReplyAction="http://tempuri.org/IService1/orderAndTakeTopTenResponse")]
        System.Threading.Tasks.Task<string> orderAndTakeTopTenAsync(System.Collections.Generic.Dictionary<string, int> difference);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addWordsToDictionary", ReplyAction="http://tempuri.org/IService1/addWordsToDictionaryResponse")]
        System.Collections.Generic.Dictionary<string, int> addWordsToDictionary();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addWordsToDictionary", ReplyAction="http://tempuri.org/IService1/addWordsToDictionaryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> addWordsToDictionaryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/differenceInDictionary", ReplyAction="http://tempuri.org/IService1/differenceInDictionaryResponse")]
        System.Collections.Generic.Dictionary<string, int> differenceInDictionary(System.Collections.Generic.Dictionary<string, int> toDictionary, System.Collections.Generic.Dictionary<string, int> englishdictionary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/differenceInDictionary", ReplyAction="http://tempuri.org/IService1/differenceInDictionaryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> differenceInDictionaryAsync(System.Collections.Generic.Dictionary<string, int> toDictionary, System.Collections.Generic.Dictionary<string, int> englishdictionary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/webPageToDictionary", ReplyAction="http://tempuri.org/IService1/webPageToDictionaryResponse")]
        System.Collections.Generic.Dictionary<string, int> webPageToDictionary(string removeHTMLelements);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/webPageToDictionary", ReplyAction="http://tempuri.org/IService1/webPageToDictionaryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> webPageToDictionaryAsync(string removeHTMLelements);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/stripHTML", ReplyAction="http://tempuri.org/IService1/stripHTMLResponse")]
        string stripHTML(string webPageAsString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/stripHTML", ReplyAction="http://tempuri.org/IService1/stripHTMLResponse")]
        System.Threading.Tasks.Task<string> stripHTMLAsync(string webPageAsString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStringFromURL", ReplyAction="http://tempuri.org/IService1/getStringFromURLResponse")]
        string getStringFromURL(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStringFromURL", ReplyAction="http://tempuri.org/IService1/getStringFromURLResponse")]
        System.Threading.Tasks.Task<string> getStringFromURLAsync(string url);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : RequiredServicesWebApp.RequiredServicesReference_v2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<RequiredServicesWebApp.RequiredServicesReference_v2.IService1>, RequiredServicesWebApp.RequiredServicesReference_v2.IService1 {
        
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
        
        public string WordFilter(string userInput) {
            return base.Channel.WordFilter(userInput);
        }
        
        public System.Threading.Tasks.Task<string> WordFilterAsync(string userInput) {
            return base.Channel.WordFilterAsync(userInput);
        }
        
        public string getStarted(string url) {
            return base.Channel.getStarted(url);
        }
        
        public System.Threading.Tasks.Task<string> getStartedAsync(string url) {
            return base.Channel.getStartedAsync(url);
        }
        
        public string orderAndTakeTopTen(System.Collections.Generic.Dictionary<string, int> difference) {
            return base.Channel.orderAndTakeTopTen(difference);
        }
        
        public System.Threading.Tasks.Task<string> orderAndTakeTopTenAsync(System.Collections.Generic.Dictionary<string, int> difference) {
            return base.Channel.orderAndTakeTopTenAsync(difference);
        }
        
        public System.Collections.Generic.Dictionary<string, int> addWordsToDictionary() {
            return base.Channel.addWordsToDictionary();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> addWordsToDictionaryAsync() {
            return base.Channel.addWordsToDictionaryAsync();
        }
        
        public System.Collections.Generic.Dictionary<string, int> differenceInDictionary(System.Collections.Generic.Dictionary<string, int> toDictionary, System.Collections.Generic.Dictionary<string, int> englishdictionary) {
            return base.Channel.differenceInDictionary(toDictionary, englishdictionary);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> differenceInDictionaryAsync(System.Collections.Generic.Dictionary<string, int> toDictionary, System.Collections.Generic.Dictionary<string, int> englishdictionary) {
            return base.Channel.differenceInDictionaryAsync(toDictionary, englishdictionary);
        }
        
        public System.Collections.Generic.Dictionary<string, int> webPageToDictionary(string removeHTMLelements) {
            return base.Channel.webPageToDictionary(removeHTMLelements);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> webPageToDictionaryAsync(string removeHTMLelements) {
            return base.Channel.webPageToDictionaryAsync(removeHTMLelements);
        }
        
        public string stripHTML(string webPageAsString) {
            return base.Channel.stripHTML(webPageAsString);
        }
        
        public System.Threading.Tasks.Task<string> stripHTMLAsync(string webPageAsString) {
            return base.Channel.stripHTMLAsync(webPageAsString);
        }
        
        public string getStringFromURL(string url) {
            return base.Channel.getStringFromURL(url);
        }
        
        public System.Threading.Tasks.Task<string> getStringFromURLAsync(string url) {
            return base.Channel.getStringFromURLAsync(url);
        }
    }
}
