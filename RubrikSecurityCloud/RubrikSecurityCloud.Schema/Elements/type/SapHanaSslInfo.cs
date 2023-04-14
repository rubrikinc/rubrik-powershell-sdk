// SapHanaSslInfo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region SapHanaSslInfo
    public class SapHanaSslInfo: IFragment
    {
        #region members
        //      C# -> System.String? CryptoLibPath
        // GraphQL -> cryptoLibPath: String (scalar)
        [JsonProperty("cryptoLibPath")]
        public System.String? CryptoLibPath { get; set; }

        //      C# -> System.String? HostNameInCertificate
        // GraphQL -> hostNameInCertificate: String (scalar)
        [JsonProperty("hostNameInCertificate")]
        public System.String? HostNameInCertificate { get; set; }

        //      C# -> System.String? KeyStorePath
        // GraphQL -> keyStorePath: String! (scalar)
        [JsonProperty("keyStorePath")]
        public System.String? KeyStorePath { get; set; }

        //      C# -> System.Boolean? ShouldEncrypt
        // GraphQL -> shouldEncrypt: Boolean (scalar)
        [JsonProperty("shouldEncrypt")]
        public System.Boolean? ShouldEncrypt { get; set; }

        //      C# -> System.Boolean? ShouldValidateCertificate
        // GraphQL -> shouldValidateCertificate: Boolean (scalar)
        [JsonProperty("shouldValidateCertificate")]
        public System.Boolean? ShouldValidateCertificate { get; set; }

        //      C# -> System.String? TrustStorePath
        // GraphQL -> trustStorePath: String (scalar)
        [JsonProperty("trustStorePath")]
        public System.String? TrustStorePath { get; set; }

        //      C# -> SapHanaSslInfoEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaSslInfoEncryptionProvider! (enum)
        [JsonProperty("encryptionProvider")]
        public SapHanaSslInfoEncryptionProvider? EncryptionProvider { get; set; }

        #endregion

    #region methods

    public SapHanaSslInfo Set(
        System.String? CryptoLibPath = null,
        System.String? HostNameInCertificate = null,
        System.String? KeyStorePath = null,
        System.Boolean? ShouldEncrypt = null,
        System.Boolean? ShouldValidateCertificate = null,
        System.String? TrustStorePath = null,
        SapHanaSslInfoEncryptionProvider? EncryptionProvider = null
    ) 
    {
        if ( CryptoLibPath != null ) {
            this.CryptoLibPath = CryptoLibPath;
        }
        if ( HostNameInCertificate != null ) {
            this.HostNameInCertificate = HostNameInCertificate;
        }
        if ( KeyStorePath != null ) {
            this.KeyStorePath = KeyStorePath;
        }
        if ( ShouldEncrypt != null ) {
            this.ShouldEncrypt = ShouldEncrypt;
        }
        if ( ShouldValidateCertificate != null ) {
            this.ShouldValidateCertificate = ShouldValidateCertificate;
        }
        if ( TrustStorePath != null ) {
            this.TrustStorePath = TrustStorePath;
        }
        if ( EncryptionProvider != null ) {
            this.EncryptionProvider = EncryptionProvider;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CryptoLibPath
            // GraphQL -> cryptoLibPath: String (scalar)
            if (this.CryptoLibPath != null)
            {
                 s += ind + "cryptoLibPath\n";

            }
            //      C# -> System.String? HostNameInCertificate
            // GraphQL -> hostNameInCertificate: String (scalar)
            if (this.HostNameInCertificate != null)
            {
                 s += ind + "hostNameInCertificate\n";

            }
            //      C# -> System.String? KeyStorePath
            // GraphQL -> keyStorePath: String! (scalar)
            if (this.KeyStorePath != null)
            {
                 s += ind + "keyStorePath\n";

            }
            //      C# -> System.Boolean? ShouldEncrypt
            // GraphQL -> shouldEncrypt: Boolean (scalar)
            if (this.ShouldEncrypt != null)
            {
                 s += ind + "shouldEncrypt\n";

            }
            //      C# -> System.Boolean? ShouldValidateCertificate
            // GraphQL -> shouldValidateCertificate: Boolean (scalar)
            if (this.ShouldValidateCertificate != null)
            {
                 s += ind + "shouldValidateCertificate\n";

            }
            //      C# -> System.String? TrustStorePath
            // GraphQL -> trustStorePath: String (scalar)
            if (this.TrustStorePath != null)
            {
                 s += ind + "trustStorePath\n";

            }
            //      C# -> SapHanaSslInfoEncryptionProvider? EncryptionProvider
            // GraphQL -> encryptionProvider: SapHanaSslInfoEncryptionProvider! (enum)
            if (this.EncryptionProvider != null)
            {
                 s += ind + "encryptionProvider\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CryptoLibPath
            // GraphQL -> cryptoLibPath: String (scalar)
            if (this.CryptoLibPath == null && Exploration.Includes(parent + ".cryptoLibPath$"))
            {
                this.CryptoLibPath = new System.String("FETCH");
            }
            //      C# -> System.String? HostNameInCertificate
            // GraphQL -> hostNameInCertificate: String (scalar)
            if (this.HostNameInCertificate == null && Exploration.Includes(parent + ".hostNameInCertificate$"))
            {
                this.HostNameInCertificate = new System.String("FETCH");
            }
            //      C# -> System.String? KeyStorePath
            // GraphQL -> keyStorePath: String! (scalar)
            if (this.KeyStorePath == null && Exploration.Includes(parent + ".keyStorePath$"))
            {
                this.KeyStorePath = new System.String("FETCH");
            }
            //      C# -> System.Boolean? ShouldEncrypt
            // GraphQL -> shouldEncrypt: Boolean (scalar)
            if (this.ShouldEncrypt == null && Exploration.Includes(parent + ".shouldEncrypt$"))
            {
                this.ShouldEncrypt = new System.Boolean();
            }
            //      C# -> System.Boolean? ShouldValidateCertificate
            // GraphQL -> shouldValidateCertificate: Boolean (scalar)
            if (this.ShouldValidateCertificate == null && Exploration.Includes(parent + ".shouldValidateCertificate$"))
            {
                this.ShouldValidateCertificate = new System.Boolean();
            }
            //      C# -> System.String? TrustStorePath
            // GraphQL -> trustStorePath: String (scalar)
            if (this.TrustStorePath == null && Exploration.Includes(parent + ".trustStorePath$"))
            {
                this.TrustStorePath = new System.String("FETCH");
            }
            //      C# -> SapHanaSslInfoEncryptionProvider? EncryptionProvider
            // GraphQL -> encryptionProvider: SapHanaSslInfoEncryptionProvider! (enum)
            if (this.EncryptionProvider == null && Exploration.Includes(parent + ".encryptionProvider$"))
            {
                this.EncryptionProvider = new SapHanaSslInfoEncryptionProvider();
            }
        }


    #endregion

    } // class SapHanaSslInfo
    #endregion

    public static class ListSapHanaSslInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<SapHanaSslInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaSslInfo> list, 
            String parent = "")
        {
            var item = new SapHanaSslInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types