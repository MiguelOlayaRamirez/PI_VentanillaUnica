﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceDatos.Web.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/PI_VentanillaUnica/Servicios/Ventanilla_Unica_Ws.asmx")]
        public string WebServiceDatos_Web_NuevoRadicadoWs_Ventanilla_Unica_Ws {
            get {
                return ((string)(this["WebServiceDatos_Web_NuevoRadicadoWs_Ventanilla_Unica_Ws"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/PI_VentanillaUnica/Ventanilla_Unica_Ws.asmx")]
        public string WebServiceDatos_Web_wsNuevoRadicado_Ventanilla_Unica_Ws {
            get {
                return ((string)(this["WebServiceDatos_Web_wsNuevoRadicado_Ventanilla_Unica_Ws"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/PI_VentanillaUnica/NuevoDespacho.Ws.asmx")]
        public string WebServiceDatos_Web_wsNuevoDespacho_NuevoDespacho_Ws {
            get {
                return ((string)(this["WebServiceDatos_Web_wsNuevoDespacho_NuevoDespacho_Ws"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/PI_VentanillaUnica/NuevoUsuario.asmx")]
        public string WebServiceDatos_Web_NuevoUsuariows_NuevoUsuario {
            get {
                return ((string)(this["WebServiceDatos_Web_NuevoUsuariows_NuevoUsuario"]));
            }
        }
    }
}
