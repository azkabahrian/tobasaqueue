﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tobasa.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ad7415644add93d6e719d2b593da6e6e")]
        public string ConnectionStringPassword {
            get {
                return ((string)(this["ConnectionStringPassword"]));
            }
            set {
                this["ConnectionStringPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C4BC3A3AC2D6D367A74580388B20BC069C96B048DFEAF5CCDC0CE1E25BF23F39")]
        public string SecuritySalt {
            get {
                return ((string)(this["SecuritySalt"]));
            }
            set {
                this["SecuritySalt"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string QueueServerHost {
            get {
                return ((string)(this["QueueServerHost"]));
            }
            set {
                this["QueueServerHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2345")]
        public int QueueServerPort {
            get {
                return ((int)(this["QueueServerPort"]));
            }
            set {
                this["QueueServerPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ADMIN#1")]
        public string StationName {
            get {
                return ((string)(this["StationName"]));
            }
            set {
                this["StationName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("POST0")]
        public string StationPost {
            get {
                return ((string)(this["StationPost"]));
            }
            set {
                this["StationPost"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=SQLOLEDB;Data Source=127.0.0.1,1433;User ID=antrian;Initial Catalog=antr" +
            "i")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tobasaqueue")]
        public string QueueUserName {
            get {
                return ((string)(this["QueueUserName"]));
            }
            set {
                this["QueueUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("e4ee0e54215f5e3dd7683923abe1dac8")]
        public string QueuePassword {
            get {
                return ((string)(this["QueuePassword"]));
            }
            set {
                this["QueuePassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>POST0</string>
  <string>POST1</string>
  <string>POST2</string>
  <string>POST3</string>
  <string>POST4</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection UIPostList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["UIPostList"]));
            }
            set {
                this["UIPostList"] = value;
            }
        }
    }
}
