﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldServer.Configs {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class CfgCore : global::System.Configuration.ApplicationSettingsBase {
        
        private static CfgCore defaultInstance = ((CfgCore)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CfgCore())));
        
        public static CfgCore Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int LogoutSeconds {
            get {
                return ((int)(this["LogoutSeconds"]));
            }
            set {
                this["LogoutSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public int StartedMoney {
            get {
                return ((int)(this["StartedMoney"]));
            }
            set {
                this["StartedMoney"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int VisibleRangeDistance {
            get {
                return ((int)(this["VisibleRangeDistance"]));
            }
            set {
                this["VisibleRangeDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int WorldChannelsCount {
            get {
                return ((int)(this["WorldChannelsCount"]));
            }
            set {
                this["WorldChannelsCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int MaxPlayersCountOnArea {
            get {
                return ((int)(this["MaxPlayersCountOnArea"]));
            }
            set {
                this["MaxPlayersCountOnArea"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("`")]
        public string AdminCommandPrefix {
            get {
                return ((string)(this["AdminCommandPrefix"]));
            }
            set {
                this["AdminCommandPrefix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogUnkPackets {
            get {
                return ((bool)(this["LogUnkPackets"]));
            }
            set {
                this["LogUnkPackets"] = value;
            }
        }
    }
}
