//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xamarin.iOS.Tasks.Windows.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    ///   This class was generated by MSBuild using the GenerateResource task.
    ///   To add or remove a member, edit your .resx file then rerun MSBuild.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Build.Tasks.StronglyTypedResourceBuilder", "15.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xamarin.iOS.Tasks.Windows.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Could not find the password for the selected Signing Identity, please create a new Certificate from Tools -&gt; Options -&gt; Apple Accounts -&gt; View Team Details..
        /// </summary>
        internal static string Codesign_MissingPasswordFile {
            get {
                return ResourceManager.GetString("Codesign_MissingPasswordFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Info.plist file does not exist under {0}, please rebuild your project.
        /// </summary>
        internal static string CompileAppManifest_MissinInfoPList {
            get {
                return ResourceManager.GetString("CompileAppManifest_MissinInfoPList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Linking with a static library is not supported when using Hot Restart..
        /// </summary>
        internal static string HotRestartStaticLibraryNotSupported {
            get {
                return ResourceManager.GetString("HotRestartStaticLibraryNotSupported", resourceCulture);
            }
        }
    }
}
