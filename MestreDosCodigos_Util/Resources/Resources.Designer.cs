﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MestreDosCodigos_Util.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MestreDosCodigos_Util.Resources.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canal Atual: {0}.
        /// </summary>
        public static string CanalAtual {
            get {
                return ResourceManager.GetString("CanalAtual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canal {0} Inexistente.
        /// </summary>
        public static string CanalInexistente {
            get {
                return ResourceManager.GetString("CanalInexistente", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operação Inválida, o valor deve ser maior do que a taxa de operação!.
        /// </summary>
        public static string DepositoContaCorrentInvalido {
            get {
                return ResourceManager.GetString("DepositoContaCorrentInvalido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Número da Conta: {0}.
        /// </summary>
        public static string NumeroConta {
            get {
                return ResourceManager.GetString("NumeroConta", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saldo: R$ {0}.
        /// </summary>
        public static string Saldo {
            get {
                return ResourceManager.GetString("Saldo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operação Inválida, o valor + a taxa de instalação não pode ser maior do que seu saldo!.
        /// </summary>
        public static string SaqueContaCorrenteInvalido {
            get {
                return ResourceManager.GetString("SaqueContaCorrenteInvalido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Taxa de Operação: R$ {0}.
        /// </summary>
        public static string TaxaOperacao {
            get {
                return ResourceManager.GetString("TaxaOperacao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Volume: {0}.
        /// </summary>
        public static string VolumeAtual {
            get {
                return ResourceManager.GetString("VolumeAtual", resourceCulture);
            }
        }
    }
}
