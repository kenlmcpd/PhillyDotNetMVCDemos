﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exercise4_Localization.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Exercise4_Localization_Controllers_HomeController {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Exercise4_Localization_Controllers_HomeController() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Exercise4_Localization.Resources.Exercise4_Localization.Controllers.HomeControlle" +
                            "r", typeof(Exercise4_Localization_Controllers_HomeController).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Hola de España.
        /// </summary>
        internal static string Hi_en_ES {
            get {
                return ResourceManager.GetString("Hi.en-ES", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Hello in English.
        /// </summary>
        internal static string Hi_en_US {
            get {
                return ResourceManager.GetString("Hi.en-US", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Bonjour de France.
        /// </summary>
        internal static string Hi_fr_FR {
            get {
                return ResourceManager.GetString("Hi.fr-FR", resourceCulture);
            }
        }
    }
}