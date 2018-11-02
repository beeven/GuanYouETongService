﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace GuanYouETongService.Services
{



    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://postweb.com/", ConfigurationName = "WebPost")]
    public interface WebPost
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://postweb.com/WebPost/endThreadRequest", ReplyAction = "http://postweb.com/WebPost/endThreadResponse")]
        System.Threading.Tasks.Task<endThreadResponse> endThreadAsync(endThreadRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://postweb.com/WebPost/getPostJsonRequest", ReplyAction = "http://postweb.com/WebPost/getPostJsonResponse")]
        System.Threading.Tasks.Task<getPostJsonResponse> getPostJsonAsync(getPostJsonRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://postweb.com/WebPost/getResultBySqlRequest", ReplyAction = "http://postweb.com/WebPost/getResultBySqlResponse")]
        System.Threading.Tasks.Task<getResultBySqlResponse> getResultBySqlAsync(getResultBySqlRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://postweb.com/WebPost/getPostResultBySqlRequest", ReplyAction = "http://postweb.com/WebPost/getPostResultBySqlResponse")]
        System.Threading.Tasks.Task<getPostResultBySqlResponse> getPostResultBySqlAsync(getPostResultBySqlRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://postweb.com/WebPost/getCbeeResultBySqlRequest", ReplyAction = "http://postweb.com/WebPost/getCbeeResultBySqlResponse")]
        System.Threading.Tasks.Task<getCbeeResultBySqlResponse> getCbeeResultBySqlAsync(getCbeeResultBySqlRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class endThreadRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "endThread", Namespace = "http://postweb.com/", Order = 0)]
        public endThreadRequestBody Body;

        public endThreadRequest()
        {
        }

        public endThreadRequest(endThreadRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://demo/")]
    public partial class endThreadRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string value;

        public endThreadRequestBody()
        {
        }

        public endThreadRequestBody(string value)
        {
            this.value = value;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class endThreadResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "endThreadResponse", Namespace = "http://postweb.com/", Order = 0)]
        public endThreadResponseBody Body;

        public endThreadResponse()
        {
        }

        public endThreadResponse(endThreadResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "")]
    public partial class endThreadResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string @return;

        public endThreadResponseBody()
        {
        }

        public endThreadResponseBody(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getPostJsonRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getPostJson", Namespace = "http://postweb.com/", Order = 0)]
        public getPostJsonRequestBody Body;

        public getPostJsonRequest()
        {
        }

        public getPostJsonRequest(getPostJsonRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://demo/")]
    public partial class getPostJsonRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string mailNo;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string taxNo;

        public getPostJsonRequestBody()
        {
        }

        public getPostJsonRequestBody(string mailNo, string taxNo)
        {
            this.mailNo = mailNo;
            this.taxNo = taxNo;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getPostJsonResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getPostJsonResponse", Namespace = "http://postweb.com/", Order = 0)]
        public getPostJsonResponseBody Body;

        public getPostJsonResponse()
        {
        }

        public getPostJsonResponse(getPostJsonResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "")]
    public partial class getPostJsonResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string @return;

        public getPostJsonResponseBody()
        {
        }

        public getPostJsonResponseBody(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getResultBySqlRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getResultBySql", Namespace = "http://postweb.com/", Order = 0)]
        public getResultBySqlRequestBody Body;

        public getResultBySqlRequest()
        {
        }

        public getResultBySqlRequest(getResultBySqlRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://demo/")]
    public partial class getResultBySqlRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string sql1;

        public getResultBySqlRequestBody()
        {
        }

        public getResultBySqlRequestBody(string sql1)
        {
            this.sql1 = sql1;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getResultBySqlResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getResultBySqlResponse", Namespace = "http://postweb.com/", Order = 0)]
        public getResultBySqlResponseBody Body;

        public getResultBySqlResponse()
        {
        }

        public getResultBySqlResponse(getResultBySqlResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "")]
    public partial class getResultBySqlResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string @return;

        public getResultBySqlResponseBody()
        {
        }

        public getResultBySqlResponseBody(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getPostResultBySqlRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getPostResultBySql", Namespace = "http://postweb.com/", Order = 0)]
        public getPostResultBySqlRequestBody Body;

        public getPostResultBySqlRequest()
        {
        }

        public getPostResultBySqlRequest(getPostResultBySqlRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://demo/")]
    public partial class getPostResultBySqlRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string sql1;

        public getPostResultBySqlRequestBody()
        {
        }

        public getPostResultBySqlRequestBody(string sql1)
        {
            this.sql1 = sql1;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getPostResultBySqlResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getPostResultBySqlResponse", Namespace = "http://postweb.com/", Order = 0)]
        public getPostResultBySqlResponseBody Body;

        public getPostResultBySqlResponse()
        {
        }

        public getPostResultBySqlResponse(getPostResultBySqlResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "")]
    public partial class getPostResultBySqlResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string @return;

        public getPostResultBySqlResponseBody()
        {
        }

        public getPostResultBySqlResponseBody(string @return)
        {
            this.@return = @return;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getCbeeResultBySqlRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getCbeeResultBySql", Namespace = "http://postweb.com/", Order = 0)]
        public getCbeeResultBySqlRequestBody Body;

        public getCbeeResultBySqlRequest()
        {
        }

        public getCbeeResultBySqlRequest(getCbeeResultBySqlRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://demo/")]
    public partial class getCbeeResultBySqlRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string sql1;

        public getCbeeResultBySqlRequestBody()
        {
        }

        public getCbeeResultBySqlRequestBody(string sql1)
        {
            this.sql1 = sql1;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getCbeeResultBySqlResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "getCbeeResultBySqlResponse", Namespace = "http://postweb.com/", Order = 0)]
        public getCbeeResultBySqlResponseBody Body;

        public getCbeeResultBySqlResponse()
        {
        }

        public getCbeeResultBySqlResponse(getCbeeResultBySqlResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "")]
    public partial class getCbeeResultBySqlResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string @return;

        public getCbeeResultBySqlResponseBody()
        {
        }

        public getCbeeResultBySqlResponseBody(string @return)
        {
            this.@return = @return;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public interface WebPostChannel : WebPost, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.4")]
    public partial class WebPostClient : System.ServiceModel.ClientBase<WebPost>, WebPost
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public WebPostClient() :
                base(WebPostClient.GetDefaultBinding(), WebPostClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WebPostPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WebPostClient(EndpointConfiguration endpointConfiguration) :
                base(WebPostClient.GetBindingForEndpoint(endpointConfiguration), WebPostClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WebPostClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(WebPostClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WebPostClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(WebPostClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public WebPostClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<endThreadResponse> WebPost.endThreadAsync(endThreadRequest request)
        {
            return base.Channel.endThreadAsync(request);
        }

        public System.Threading.Tasks.Task<endThreadResponse> endThreadAsync(string value)
        {
            endThreadRequest inValue = new endThreadRequest();
            inValue.Body = new endThreadRequestBody();
            inValue.Body.value = value;
            return ((WebPost)(this)).endThreadAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getPostJsonResponse> WebPost.getPostJsonAsync(getPostJsonRequest request)
        {
            return base.Channel.getPostJsonAsync(request);
        }

        public System.Threading.Tasks.Task<getPostJsonResponse> getPostJsonAsync(string mailNo, string taxNo)
        {
            getPostJsonRequest inValue = new getPostJsonRequest();
            inValue.Body = new getPostJsonRequestBody();
            inValue.Body.mailNo = mailNo;
            inValue.Body.taxNo = taxNo;
            return ((WebPost)(this)).getPostJsonAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getResultBySqlResponse> WebPost.getResultBySqlAsync(getResultBySqlRequest request)
        {
            return base.Channel.getResultBySqlAsync(request);
        }

        public System.Threading.Tasks.Task<getResultBySqlResponse> getResultBySqlAsync(string sql1)
        {
            getResultBySqlRequest inValue = new getResultBySqlRequest();
            inValue.Body = new getResultBySqlRequestBody();
            inValue.Body.sql1 = sql1;
            return ((WebPost)(this)).getResultBySqlAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getPostResultBySqlResponse> WebPost.getPostResultBySqlAsync(getPostResultBySqlRequest request)
        {
            return base.Channel.getPostResultBySqlAsync(request);
        }

        public System.Threading.Tasks.Task<getPostResultBySqlResponse> getPostResultBySqlAsync(string sql1)
        {
            getPostResultBySqlRequest inValue = new getPostResultBySqlRequest();
            inValue.Body = new getPostResultBySqlRequestBody();
            inValue.Body.sql1 = sql1;
            return ((WebPost)(this)).getPostResultBySqlAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<getCbeeResultBySqlResponse> WebPost.getCbeeResultBySqlAsync(getCbeeResultBySqlRequest request)
        {
            return base.Channel.getCbeeResultBySqlAsync(request);
        }

        public System.Threading.Tasks.Task<getCbeeResultBySqlResponse> getCbeeResultBySqlAsync(string sql1)
        {
            getCbeeResultBySqlRequest inValue = new getCbeeResultBySqlRequest();
            inValue.Body = new getCbeeResultBySqlRequestBody();
            inValue.Body.sql1 = sql1;
            return ((WebPost)(this)).getCbeeResultBySqlAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebPostPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebPostPort))
            {
                return new System.ServiceModel.EndpointAddress("http://10.53.34.180:8096/post_webservice");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WebPostClient.GetBindingForEndpoint(EndpointConfiguration.WebPostPort);
        }

        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WebPostClient.GetEndpointAddress(EndpointConfiguration.WebPostPort);
        }

        public enum EndpointConfiguration
        {

            WebPostPort,
        }
    }
}