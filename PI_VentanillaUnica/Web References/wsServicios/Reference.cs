﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PI_VentanillaUnica.wsServicios {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Ventanilla_Unica_WsSoap", Namespace="http://tempuri.org/")]
    public partial class Ventanilla_Unica_Ws : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private clsSeguridad clsSeguridadValueField;
        
        private System.Threading.SendOrPostCallback wsNuevoRadicadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback wsNuevoDespachoOperationCompleted;
        
        private System.Threading.SendOrPostCallback stNuevoUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback dsConsultaTercerosOperationCompleted;
        
        private System.Threading.SendOrPostCallback dsConsultaRadicadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback AutenticacionUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback dsConsultaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Ventanilla_Unica_Ws() {
            this.Url = global::PI_VentanillaUnica.Properties.Settings.Default.PI_VentanillaUnica_wsServicios_Ventanilla_Unica_Ws;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public clsSeguridad clsSeguridadValue {
            get {
                return this.clsSeguridadValueField;
            }
            set {
                this.clsSeguridadValueField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event wsNuevoRadicadoCompletedEventHandler wsNuevoRadicadoCompleted;
        
        /// <remarks/>
        public event wsNuevoDespachoCompletedEventHandler wsNuevoDespachoCompleted;
        
        /// <remarks/>
        public event stNuevoUsuarioCompletedEventHandler stNuevoUsuarioCompleted;
        
        /// <remarks/>
        public event dsConsultaTercerosCompletedEventHandler dsConsultaTercerosCompleted;
        
        /// <remarks/>
        public event dsConsultaRadicadoCompletedEventHandler dsConsultaRadicadoCompleted;
        
        /// <remarks/>
        public event AutenticacionUsuarioCompletedEventHandler AutenticacionUsuarioCompleted;
        
        /// <remarks/>
        public event dsConsultaCompletedEventHandler dsConsultaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("clsSeguridadValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/wsNuevoRadicado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string wsNuevoRadicado(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado) {
            object[] results = this.Invoke("wsNuevoRadicado", new object[] {
                        CodigoRadicado,
                        CodigoTercero,
                        CodigoFuncionario,
                        CodigoUsuario,
                        FechaRadicado,
                        DescripcionRadicado});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void wsNuevoRadicadoAsync(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado) {
            this.wsNuevoRadicadoAsync(CodigoRadicado, CodigoTercero, CodigoFuncionario, CodigoUsuario, FechaRadicado, DescripcionRadicado, null);
        }
        
        /// <remarks/>
        public void wsNuevoRadicadoAsync(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado, object userState) {
            if ((this.wsNuevoRadicadoOperationCompleted == null)) {
                this.wsNuevoRadicadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsNuevoRadicadoOperationCompleted);
            }
            this.InvokeAsync("wsNuevoRadicado", new object[] {
                        CodigoRadicado,
                        CodigoTercero,
                        CodigoFuncionario,
                        CodigoUsuario,
                        FechaRadicado,
                        DescripcionRadicado}, this.wsNuevoRadicadoOperationCompleted, userState);
        }
        
        private void OnwsNuevoRadicadoOperationCompleted(object arg) {
            if ((this.wsNuevoRadicadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.wsNuevoRadicadoCompleted(this, new wsNuevoRadicadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/wsNuevoDespacho", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string wsNuevoDespacho(long CodigoRadicado, string Descripcion, string Destino, string FechaDespacho) {
            object[] results = this.Invoke("wsNuevoDespacho", new object[] {
                        CodigoRadicado,
                        Descripcion,
                        Destino,
                        FechaDespacho});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void wsNuevoDespachoAsync(long CodigoRadicado, string Descripcion, string Destino, string FechaDespacho) {
            this.wsNuevoDespachoAsync(CodigoRadicado, Descripcion, Destino, FechaDespacho, null);
        }
        
        /// <remarks/>
        public void wsNuevoDespachoAsync(long CodigoRadicado, string Descripcion, string Destino, string FechaDespacho, object userState) {
            if ((this.wsNuevoDespachoOperationCompleted == null)) {
                this.wsNuevoDespachoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsNuevoDespachoOperationCompleted);
            }
            this.InvokeAsync("wsNuevoDespacho", new object[] {
                        CodigoRadicado,
                        Descripcion,
                        Destino,
                        FechaDespacho}, this.wsNuevoDespachoOperationCompleted, userState);
        }
        
        private void OnwsNuevoDespachoOperationCompleted(object arg) {
            if ((this.wsNuevoDespachoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.wsNuevoDespachoCompleted(this, new wsNuevoDespachoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/stNuevoUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string stNuevoUsuario(string Identificacion, string setNombres, string setApellidos, string setCargo) {
            object[] results = this.Invoke("stNuevoUsuario", new object[] {
                        Identificacion,
                        setNombres,
                        setApellidos,
                        setCargo});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void stNuevoUsuarioAsync(string Identificacion, string setNombres, string setApellidos, string setCargo) {
            this.stNuevoUsuarioAsync(Identificacion, setNombres, setApellidos, setCargo, null);
        }
        
        /// <remarks/>
        public void stNuevoUsuarioAsync(string Identificacion, string setNombres, string setApellidos, string setCargo, object userState) {
            if ((this.stNuevoUsuarioOperationCompleted == null)) {
                this.stNuevoUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnstNuevoUsuarioOperationCompleted);
            }
            this.InvokeAsync("stNuevoUsuario", new object[] {
                        Identificacion,
                        setNombres,
                        setApellidos,
                        setCargo}, this.stNuevoUsuarioOperationCompleted, userState);
        }
        
        private void OnstNuevoUsuarioOperationCompleted(object arg) {
            if ((this.stNuevoUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.stNuevoUsuarioCompleted(this, new stNuevoUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/dsConsultaTerceros", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] dsConsultaTerceros(string prefixText, int count) {
            object[] results = this.Invoke("dsConsultaTerceros", new object[] {
                        prefixText,
                        count});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void dsConsultaTercerosAsync(string prefixText, int count) {
            this.dsConsultaTercerosAsync(prefixText, count, null);
        }
        
        /// <remarks/>
        public void dsConsultaTercerosAsync(string prefixText, int count, object userState) {
            if ((this.dsConsultaTercerosOperationCompleted == null)) {
                this.dsConsultaTercerosOperationCompleted = new System.Threading.SendOrPostCallback(this.OndsConsultaTercerosOperationCompleted);
            }
            this.InvokeAsync("dsConsultaTerceros", new object[] {
                        prefixText,
                        count}, this.dsConsultaTercerosOperationCompleted, userState);
        }
        
        private void OndsConsultaTercerosOperationCompleted(object arg) {
            if ((this.dsConsultaTercerosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dsConsultaTercerosCompleted(this, new dsConsultaTercerosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/dsConsultaRadicado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] dsConsultaRadicado(string prefixText, int count) {
            object[] results = this.Invoke("dsConsultaRadicado", new object[] {
                        prefixText,
                        count});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void dsConsultaRadicadoAsync(string prefixText, int count) {
            this.dsConsultaRadicadoAsync(prefixText, count, null);
        }
        
        /// <remarks/>
        public void dsConsultaRadicadoAsync(string prefixText, int count, object userState) {
            if ((this.dsConsultaRadicadoOperationCompleted == null)) {
                this.dsConsultaRadicadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OndsConsultaRadicadoOperationCompleted);
            }
            this.InvokeAsync("dsConsultaRadicado", new object[] {
                        prefixText,
                        count}, this.dsConsultaRadicadoOperationCompleted, userState);
        }
        
        private void OndsConsultaRadicadoOperationCompleted(object arg) {
            if ((this.dsConsultaRadicadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dsConsultaRadicadoCompleted(this, new dsConsultaRadicadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("clsSeguridadValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AutenticacionUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AutenticacionUsuario() {
            object[] results = this.Invoke("AutenticacionUsuario", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AutenticacionUsuarioAsync() {
            this.AutenticacionUsuarioAsync(null);
        }
        
        /// <remarks/>
        public void AutenticacionUsuarioAsync(object userState) {
            if ((this.AutenticacionUsuarioOperationCompleted == null)) {
                this.AutenticacionUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAutenticacionUsuarioOperationCompleted);
            }
            this.InvokeAsync("AutenticacionUsuario", new object[0], this.AutenticacionUsuarioOperationCompleted, userState);
        }
        
        private void OnAutenticacionUsuarioOperationCompleted(object arg) {
            if ((this.AutenticacionUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AutenticacionUsuarioCompleted(this, new AutenticacionUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("clsSeguridadValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/dsConsulta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet dsConsulta(long lnId) {
            object[] results = this.Invoke("dsConsulta", new object[] {
                        lnId});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void dsConsultaAsync(long lnId) {
            this.dsConsultaAsync(lnId, null);
        }
        
        /// <remarks/>
        public void dsConsultaAsync(long lnId, object userState) {
            if ((this.dsConsultaOperationCompleted == null)) {
                this.dsConsultaOperationCompleted = new System.Threading.SendOrPostCallback(this.OndsConsultaOperationCompleted);
            }
            this.InvokeAsync("dsConsulta", new object[] {
                        lnId}, this.dsConsultaOperationCompleted, userState);
        }
        
        private void OndsConsultaOperationCompleted(object arg) {
            if ((this.dsConsultaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dsConsultaCompleted(this, new dsConsultaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2558.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class clsSeguridad : System.Web.Services.Protocols.SoapHeader {
        
        private string stTokenField;
        
        private string autenticacionTokenField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string stToken {
            get {
                return this.stTokenField;
            }
            set {
                this.stTokenField = value;
            }
        }
        
        /// <remarks/>
        public string AutenticacionToken {
            get {
                return this.autenticacionTokenField;
            }
            set {
                this.autenticacionTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void wsNuevoRadicadoCompletedEventHandler(object sender, wsNuevoRadicadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class wsNuevoRadicadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal wsNuevoRadicadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void wsNuevoDespachoCompletedEventHandler(object sender, wsNuevoDespachoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class wsNuevoDespachoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal wsNuevoDespachoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void stNuevoUsuarioCompletedEventHandler(object sender, stNuevoUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class stNuevoUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal stNuevoUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void dsConsultaTercerosCompletedEventHandler(object sender, dsConsultaTercerosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dsConsultaTercerosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dsConsultaTercerosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void dsConsultaRadicadoCompletedEventHandler(object sender, dsConsultaRadicadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dsConsultaRadicadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dsConsultaRadicadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void AutenticacionUsuarioCompletedEventHandler(object sender, AutenticacionUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AutenticacionUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AutenticacionUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void dsConsultaCompletedEventHandler(object sender, dsConsultaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dsConsultaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dsConsultaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591