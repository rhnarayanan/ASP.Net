﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharedResourceNamespace {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LoaderResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LoaderResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Owin.Hosting.App_Packages.Owin.Loader.LoaderResources", typeof(LoaderResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For the app startup parameter value &apos;{0}&apos;, the assembly &apos;{1}&apos; was not found..
        /// </summary>
        internal static string AssemblyNotFound {
            get {
                return ResourceManager.GetString("AssemblyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For the app startup parameter value &apos;{0}&apos;, the assembly or class &apos;{0}&apos; was not found.  Specify the fully qualified startup class or configuration method name..
        /// </summary>
        internal static string AutodetectFailed {
            get {
                return ResourceManager.GetString("AutodetectFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For the app startup parameter value &apos;{0}&apos;, the class &apos;{1}&apos; was not found in assembly &apos;{2}&apos;..
        /// </summary>
        internal static string ClassNotFoundInAssembly {
            get {
                return ResourceManager.GetString("ClassNotFoundInAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No &apos;{0}&apos; method was found in class &apos;{1}&apos;..
        /// </summary>
        internal static string MethodNotFoundInClass {
            get {
                return ResourceManager.GetString("MethodNotFoundInClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatic app startup discovery found no assembly containing the class Startup in the global or default namespace..
        /// </summary>
        internal static string NoAssemblyWithStartup {
            get {
                return ResourceManager.GetString("NoAssemblyWithStartup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; method on class &apos;{1}&apos; does not have the expected signature &apos;void {0}(IAppBuilder)&apos;..
        /// </summary>
        internal static string UnexpectedMethodSignature {
            get {
                return ResourceManager.GetString("UnexpectedMethodSignature", resourceCulture);
            }
        }
    }
}