﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpNBT {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("SharpNBT.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string UnknownTagType {
            get {
                return ResourceManager.GetString("UnknownTagType", resourceCulture);
            }
        }
        
        internal static string AutoDetectNotValid {
            get {
                return ResourceManager.GetString("AutoDetectNotValid", resourceCulture);
            }
        }
        
        internal static string CannotDetectCompression {
            get {
                return ResourceManager.GetString("CannotDetectCompression", resourceCulture);
            }
        }
        
        internal static string CannotReadStream {
            get {
                return ResourceManager.GetString("CannotReadStream", resourceCulture);
            }
        }
        
        internal static string CannotWriteStream {
            get {
                return ResourceManager.GetString("CannotWriteStream", resourceCulture);
            }
        }
        
        internal static string InvalidEndTagChild {
            get {
                return ResourceManager.GetString("InvalidEndTagChild", resourceCulture);
            }
        }
        
        internal static string VarIntTooMuchData {
            get {
                return ResourceManager.GetString("VarIntTooMuchData", resourceCulture);
            }
        }
        
        internal static string VarIntCannotDecode {
            get {
                return ResourceManager.GetString("VarIntCannotDecode", resourceCulture);
            }
        }
        
        internal static string ZLibValueGreater15 {
            get {
                return ResourceManager.GetString("ZLibValueGreater15", resourceCulture);
            }
        }
        
        internal static string ZLibValueGreater31 {
            get {
                return ResourceManager.GetString("ZLibValueGreater31", resourceCulture);
            }
        }
        
        internal static string CRCFail {
            get {
                return ResourceManager.GetString("CRCFail", resourceCulture);
            }
        }
        
        internal static string ZlibUnsupported {
            get {
                return ResourceManager.GetString("ZlibUnsupported", resourceCulture);
            }
        }
        
        internal static string WordElement {
            get {
                return ResourceManager.GetString("WordElement", resourceCulture);
            }
        }
        
        internal static string WordElements {
            get {
                return ResourceManager.GetString("WordElements", resourceCulture);
            }
        }
        
        internal static string WordEntry {
            get {
                return ResourceManager.GetString("WordEntry", resourceCulture);
            }
        }
        
        internal static string WordEntries {
            get {
                return ResourceManager.GetString("WordEntries", resourceCulture);
            }
        }
        
        internal static string ChildCannotBeNull {
            get {
                return ResourceManager.GetString("ChildCannotBeNull", resourceCulture);
            }
        }
        
        internal static string ChildrenMustBeNamed {
            get {
                return ResourceManager.GetString("ChildrenMustBeNamed", resourceCulture);
            }
        }
        
        internal static string ChildrenMustNotBeNamed {
            get {
                return ResourceManager.GetString("ChildrenMustNotBeNamed", resourceCulture);
            }
        }
        
        internal static string ChildWrongType {
            get {
                return ResourceManager.GetString("ChildWrongType", resourceCulture);
            }
        }
    }
}