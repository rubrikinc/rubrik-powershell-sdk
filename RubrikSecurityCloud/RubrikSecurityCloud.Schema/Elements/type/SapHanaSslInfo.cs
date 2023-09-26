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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region SapHanaSslInfo
    public class SapHanaSslInfo: BaseType
    {
        #region members

        //      C# -> SapHanaSslInfoEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaSslInfoEncryptionProvider! (enum)
        [JsonProperty("encryptionProvider")]
        public SapHanaSslInfoEncryptionProvider? EncryptionProvider { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaSslInfo";
    }

    public SapHanaSslInfo Set(
        SapHanaSslInfoEncryptionProvider? EncryptionProvider = null,
        System.String? CryptoLibPath = null,
        System.String? HostNameInCertificate = null,
        System.String? KeyStorePath = null,
        System.Boolean? ShouldEncrypt = null,
        System.Boolean? ShouldValidateCertificate = null,
        System.String? TrustStorePath = null
    ) 
    {
        if ( EncryptionProvider != null ) {
            this.EncryptionProvider = EncryptionProvider;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SapHanaSslInfoEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaSslInfoEncryptionProvider! (enum)
        if (this.EncryptionProvider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionProvider\n" ;
            } else {
                s += ind + "encryptionProvider\n" ;
            }
        }
        //      C# -> System.String? CryptoLibPath
        // GraphQL -> cryptoLibPath: String (scalar)
        if (this.CryptoLibPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cryptoLibPath\n" ;
            } else {
                s += ind + "cryptoLibPath\n" ;
            }
        }
        //      C# -> System.String? HostNameInCertificate
        // GraphQL -> hostNameInCertificate: String (scalar)
        if (this.HostNameInCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostNameInCertificate\n" ;
            } else {
                s += ind + "hostNameInCertificate\n" ;
            }
        }
        //      C# -> System.String? KeyStorePath
        // GraphQL -> keyStorePath: String! (scalar)
        if (this.KeyStorePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyStorePath\n" ;
            } else {
                s += ind + "keyStorePath\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldEncrypt
        // GraphQL -> shouldEncrypt: Boolean (scalar)
        if (this.ShouldEncrypt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldEncrypt\n" ;
            } else {
                s += ind + "shouldEncrypt\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldValidateCertificate
        // GraphQL -> shouldValidateCertificate: Boolean (scalar)
        if (this.ShouldValidateCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldValidateCertificate\n" ;
            } else {
                s += ind + "shouldValidateCertificate\n" ;
            }
        }
        //      C# -> System.String? TrustStorePath
        // GraphQL -> trustStorePath: String (scalar)
        if (this.TrustStorePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "trustStorePath\n" ;
            } else {
                s += ind + "trustStorePath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SapHanaSslInfoEncryptionProvider? EncryptionProvider
        // GraphQL -> encryptionProvider: SapHanaSslInfoEncryptionProvider! (enum)
        if (ec.Includes("encryptionProvider",true))
        {
            if(this.EncryptionProvider == null) {

                this.EncryptionProvider = new SapHanaSslInfoEncryptionProvider();

            } else {


            }
        }
        else if (this.EncryptionProvider != null && ec.Excludes("encryptionProvider",true))
        {
            this.EncryptionProvider = null;
        }
        //      C# -> System.String? CryptoLibPath
        // GraphQL -> cryptoLibPath: String (scalar)
        if (ec.Includes("cryptoLibPath",true))
        {
            if(this.CryptoLibPath == null) {

                this.CryptoLibPath = "FETCH";

            } else {


            }
        }
        else if (this.CryptoLibPath != null && ec.Excludes("cryptoLibPath",true))
        {
            this.CryptoLibPath = null;
        }
        //      C# -> System.String? HostNameInCertificate
        // GraphQL -> hostNameInCertificate: String (scalar)
        if (ec.Includes("hostNameInCertificate",true))
        {
            if(this.HostNameInCertificate == null) {

                this.HostNameInCertificate = "FETCH";

            } else {


            }
        }
        else if (this.HostNameInCertificate != null && ec.Excludes("hostNameInCertificate",true))
        {
            this.HostNameInCertificate = null;
        }
        //      C# -> System.String? KeyStorePath
        // GraphQL -> keyStorePath: String! (scalar)
        if (ec.Includes("keyStorePath",true))
        {
            if(this.KeyStorePath == null) {

                this.KeyStorePath = "FETCH";

            } else {


            }
        }
        else if (this.KeyStorePath != null && ec.Excludes("keyStorePath",true))
        {
            this.KeyStorePath = null;
        }
        //      C# -> System.Boolean? ShouldEncrypt
        // GraphQL -> shouldEncrypt: Boolean (scalar)
        if (ec.Includes("shouldEncrypt",true))
        {
            if(this.ShouldEncrypt == null) {

                this.ShouldEncrypt = true;

            } else {


            }
        }
        else if (this.ShouldEncrypt != null && ec.Excludes("shouldEncrypt",true))
        {
            this.ShouldEncrypt = null;
        }
        //      C# -> System.Boolean? ShouldValidateCertificate
        // GraphQL -> shouldValidateCertificate: Boolean (scalar)
        if (ec.Includes("shouldValidateCertificate",true))
        {
            if(this.ShouldValidateCertificate == null) {

                this.ShouldValidateCertificate = true;

            } else {


            }
        }
        else if (this.ShouldValidateCertificate != null && ec.Excludes("shouldValidateCertificate",true))
        {
            this.ShouldValidateCertificate = null;
        }
        //      C# -> System.String? TrustStorePath
        // GraphQL -> trustStorePath: String (scalar)
        if (ec.Includes("trustStorePath",true))
        {
            if(this.TrustStorePath == null) {

                this.TrustStorePath = "FETCH";

            } else {


            }
        }
        else if (this.TrustStorePath != null && ec.Excludes("trustStorePath",true))
        {
            this.TrustStorePath = null;
        }
    }


    #endregion

    } // class SapHanaSslInfo
    
    #endregion

    public static class ListSapHanaSslInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<SapHanaSslInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaSslInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaSslInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaSslInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types