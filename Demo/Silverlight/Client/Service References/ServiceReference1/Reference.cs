﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50401.0
// 
namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILinqService")]
    public interface ILinqService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ILinqService/GetSqlProviderType", ReplyAction="http://tempuri.org/ILinqService/GetSqlProviderTypeResponse")]
        System.IAsyncResult BeginGetSqlProviderType(System.AsyncCallback callback, object asyncState);
        
        string EndGetSqlProviderType(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ILinqService/ExecuteNonQuery", ReplyAction="http://tempuri.org/ILinqService/ExecuteNonQueryResponse")]
        System.IAsyncResult BeginExecuteNonQuery(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState);
        
        int EndExecuteNonQuery(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ILinqService/ExecuteScalar", ReplyAction="http://tempuri.org/ILinqService/ExecuteScalarResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BLToolkit.ServiceModel.LinqServiceQuery))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BLToolkit.ServiceModel.LinqServiceResult))]
        System.IAsyncResult BeginExecuteScalar(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState);
        
        object EndExecuteScalar(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ILinqService/ExecuteReader", ReplyAction="http://tempuri.org/ILinqService/ExecuteReaderResponse")]
        System.IAsyncResult BeginExecuteReader(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState);
        
        BLToolkit.ServiceModel.LinqServiceResult EndExecuteReader(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILinqServiceChannel : Client.ServiceReference1.ILinqService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetSqlProviderTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetSqlProviderTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteNonQueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteNonQueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteScalarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteScalarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public object Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((object)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteReaderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteReaderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public BLToolkit.ServiceModel.LinqServiceResult Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((BLToolkit.ServiceModel.LinqServiceResult)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LinqServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference1.ILinqService>, Client.ServiceReference1.ILinqService {
        
        private BeginOperationDelegate onBeginGetSqlProviderTypeDelegate;
        
        private EndOperationDelegate onEndGetSqlProviderTypeDelegate;
        
        private System.Threading.SendOrPostCallback onGetSqlProviderTypeCompletedDelegate;
        
        private BeginOperationDelegate onBeginExecuteNonQueryDelegate;
        
        private EndOperationDelegate onEndExecuteNonQueryDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteNonQueryCompletedDelegate;
        
        private BeginOperationDelegate onBeginExecuteScalarDelegate;
        
        private EndOperationDelegate onEndExecuteScalarDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteScalarCompletedDelegate;
        
        private BeginOperationDelegate onBeginExecuteReaderDelegate;
        
        private EndOperationDelegate onEndExecuteReaderDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteReaderCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public LinqServiceClient() {
        }
        
        public LinqServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LinqServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LinqServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LinqServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetSqlProviderTypeCompletedEventArgs> GetSqlProviderTypeCompleted;
        
        public event System.EventHandler<ExecuteNonQueryCompletedEventArgs> ExecuteNonQueryCompleted;
        
        public event System.EventHandler<ExecuteScalarCompletedEventArgs> ExecuteScalarCompleted;
        
        public event System.EventHandler<ExecuteReaderCompletedEventArgs> ExecuteReaderCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Client.ServiceReference1.ILinqService.BeginGetSqlProviderType(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetSqlProviderType(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetSqlProviderType(System.IAsyncResult result) {
            return base.Channel.EndGetSqlProviderType(result);
        }
        
        private System.IAsyncResult OnBeginGetSqlProviderType(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Client.ServiceReference1.ILinqService)(this)).BeginGetSqlProviderType(callback, asyncState);
        }
        
        private object[] OnEndGetSqlProviderType(System.IAsyncResult result) {
            string retVal = ((Client.ServiceReference1.ILinqService)(this)).EndGetSqlProviderType(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetSqlProviderTypeCompleted(object state) {
            if ((this.GetSqlProviderTypeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetSqlProviderTypeCompleted(this, new GetSqlProviderTypeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetSqlProviderTypeAsync() {
            this.GetSqlProviderTypeAsync(null);
        }
        
        public void GetSqlProviderTypeAsync(object userState) {
            if ((this.onBeginGetSqlProviderTypeDelegate == null)) {
                this.onBeginGetSqlProviderTypeDelegate = new BeginOperationDelegate(this.OnBeginGetSqlProviderType);
            }
            if ((this.onEndGetSqlProviderTypeDelegate == null)) {
                this.onEndGetSqlProviderTypeDelegate = new EndOperationDelegate(this.OnEndGetSqlProviderType);
            }
            if ((this.onGetSqlProviderTypeCompletedDelegate == null)) {
                this.onGetSqlProviderTypeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetSqlProviderTypeCompleted);
            }
            base.InvokeAsync(this.onBeginGetSqlProviderTypeDelegate, null, this.onEndGetSqlProviderTypeDelegate, this.onGetSqlProviderTypeCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Client.ServiceReference1.ILinqService.BeginExecuteNonQuery(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteNonQuery(query, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndExecuteNonQuery(System.IAsyncResult result) {
            return base.Channel.EndExecuteNonQuery(result);
        }
        
        private System.IAsyncResult OnBeginExecuteNonQuery(object[] inValues, System.AsyncCallback callback, object asyncState) {
            BLToolkit.ServiceModel.LinqServiceQuery query = ((BLToolkit.ServiceModel.LinqServiceQuery)(inValues[0]));
            return ((Client.ServiceReference1.ILinqService)(this)).BeginExecuteNonQuery(query, callback, asyncState);
        }
        
        private object[] OnEndExecuteNonQuery(System.IAsyncResult result) {
            int retVal = ((Client.ServiceReference1.LinqServiceClient)(this)).EndExecuteNonQuery(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteNonQueryCompleted(object state) {
            if ((this.ExecuteNonQueryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteNonQueryCompleted(this, new ExecuteNonQueryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteNonQueryAsync(BLToolkit.ServiceModel.LinqServiceQuery query) {
            this.ExecuteNonQueryAsync(query, null);
        }
        
        public void ExecuteNonQueryAsync(BLToolkit.ServiceModel.LinqServiceQuery query, object userState) {
            if ((this.onBeginExecuteNonQueryDelegate == null)) {
                this.onBeginExecuteNonQueryDelegate = new BeginOperationDelegate(this.OnBeginExecuteNonQuery);
            }
            if ((this.onEndExecuteNonQueryDelegate == null)) {
                this.onEndExecuteNonQueryDelegate = new EndOperationDelegate(this.OnEndExecuteNonQuery);
            }
            if ((this.onExecuteNonQueryCompletedDelegate == null)) {
                this.onExecuteNonQueryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteNonQueryCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteNonQueryDelegate, new object[] {
                        query}, this.onEndExecuteNonQueryDelegate, this.onExecuteNonQueryCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Client.ServiceReference1.ILinqService.BeginExecuteScalar(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteScalar(query, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        object Client.ServiceReference1.ILinqService.EndExecuteScalar(System.IAsyncResult result) {
            return base.Channel.EndExecuteScalar(result);
        }
        
        private System.IAsyncResult OnBeginExecuteScalar(object[] inValues, System.AsyncCallback callback, object asyncState) {
            BLToolkit.ServiceModel.LinqServiceQuery query = ((BLToolkit.ServiceModel.LinqServiceQuery)(inValues[0]));
            return ((Client.ServiceReference1.ILinqService)(this)).BeginExecuteScalar(query, callback, asyncState);
        }
        
        private object[] OnEndExecuteScalar(System.IAsyncResult result) {
            object retVal = ((Client.ServiceReference1.ILinqService)(this)).EndExecuteScalar(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteScalarCompleted(object state) {
            if ((this.ExecuteScalarCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteScalarCompleted(this, new ExecuteScalarCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteScalarAsync(BLToolkit.ServiceModel.LinqServiceQuery query) {
            this.ExecuteScalarAsync(query, null);
        }
        
        public void ExecuteScalarAsync(BLToolkit.ServiceModel.LinqServiceQuery query, object userState) {
            if ((this.onBeginExecuteScalarDelegate == null)) {
                this.onBeginExecuteScalarDelegate = new BeginOperationDelegate(this.OnBeginExecuteScalar);
            }
            if ((this.onEndExecuteScalarDelegate == null)) {
                this.onEndExecuteScalarDelegate = new EndOperationDelegate(this.OnEndExecuteScalar);
            }
            if ((this.onExecuteScalarCompletedDelegate == null)) {
                this.onExecuteScalarCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteScalarCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteScalarDelegate, new object[] {
                        query}, this.onEndExecuteScalarDelegate, this.onExecuteScalarCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Client.ServiceReference1.ILinqService.BeginExecuteReader(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteReader(query, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BLToolkit.ServiceModel.LinqServiceResult Client.ServiceReference1.ILinqService.EndExecuteReader(System.IAsyncResult result) {
            return base.Channel.EndExecuteReader(result);
        }
        
        private System.IAsyncResult OnBeginExecuteReader(object[] inValues, System.AsyncCallback callback, object asyncState) {
            BLToolkit.ServiceModel.LinqServiceQuery query = ((BLToolkit.ServiceModel.LinqServiceQuery)(inValues[0]));
            return ((Client.ServiceReference1.ILinqService)(this)).BeginExecuteReader(query, callback, asyncState);
        }
        
        private object[] OnEndExecuteReader(System.IAsyncResult result) {
            BLToolkit.ServiceModel.LinqServiceResult retVal = ((Client.ServiceReference1.ILinqService)(this)).EndExecuteReader(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteReaderCompleted(object state) {
            if ((this.ExecuteReaderCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteReaderCompleted(this, new ExecuteReaderCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteReaderAsync(BLToolkit.ServiceModel.LinqServiceQuery query) {
            this.ExecuteReaderAsync(query, null);
        }
        
        public void ExecuteReaderAsync(BLToolkit.ServiceModel.LinqServiceQuery query, object userState) {
            if ((this.onBeginExecuteReaderDelegate == null)) {
                this.onBeginExecuteReaderDelegate = new BeginOperationDelegate(this.OnBeginExecuteReader);
            }
            if ((this.onEndExecuteReaderDelegate == null)) {
                this.onEndExecuteReaderDelegate = new EndOperationDelegate(this.OnEndExecuteReader);
            }
            if ((this.onExecuteReaderCompletedDelegate == null)) {
                this.onExecuteReaderCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteReaderCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteReaderDelegate, new object[] {
                        query}, this.onEndExecuteReaderDelegate, this.onExecuteReaderCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Client.ServiceReference1.ILinqService CreateChannel() {
            return new LinqServiceClientChannel(this);
        }
        
        private class LinqServiceClientChannel : ChannelBase<Client.ServiceReference1.ILinqService>, Client.ServiceReference1.ILinqService {
            
            public LinqServiceClientChannel(System.ServiceModel.ClientBase<Client.ServiceReference1.ILinqService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetSqlProviderType(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetSqlProviderType", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetSqlProviderType(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetSqlProviderType", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginExecuteNonQuery(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = query;
                System.IAsyncResult _result = base.BeginInvoke("ExecuteNonQuery", _args, callback, asyncState);
                return _result;
            }
            
            public int EndExecuteNonQuery(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("ExecuteNonQuery", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginExecuteScalar(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = query;
                System.IAsyncResult _result = base.BeginInvoke("ExecuteScalar", _args, callback, asyncState);
                return _result;
            }
            
            public object EndExecuteScalar(System.IAsyncResult result) {
                object[] _args = new object[0];
                object _result = ((object)(base.EndInvoke("ExecuteScalar", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginExecuteReader(BLToolkit.ServiceModel.LinqServiceQuery query, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = query;
                System.IAsyncResult _result = base.BeginInvoke("ExecuteReader", _args, callback, asyncState);
                return _result;
            }
            
            public BLToolkit.ServiceModel.LinqServiceResult EndExecuteReader(System.IAsyncResult result) {
                object[] _args = new object[0];
                BLToolkit.ServiceModel.LinqServiceResult _result = ((BLToolkit.ServiceModel.LinqServiceResult)(base.EndInvoke("ExecuteReader", _args, result)));
                return _result;
            }
        }
    }
}