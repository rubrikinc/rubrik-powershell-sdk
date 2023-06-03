// KmsSpec.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region KmsSpec
    public class KmsSpec: BaseType
    {
        #region members

        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public O365AzureCloudType? CloudType { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        [JsonProperty("appSecret")]
        public System.String? AppSecret { get; set; }

        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String! (scalar)
        [JsonProperty("kekNameColossus")]
        public System.String? KekNameColossus { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        [JsonProperty("kmsId")]
        public System.String? KmsId { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }


        #endregion

    #region methods

    public KmsSpec Set(
        O365AzureCloudType? CloudType = null,
        System.String? AppId = null,
        System.String? AppSecret = null,
        System.String? KekNameColossus = null,
        System.String? KeyName = null,
        System.String? KmsId = null,
        System.String? TenantId = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppSecret != null ) {
            this.AppSecret = AppSecret;
        }
        if ( KekNameColossus != null ) {
            this.KekNameColossus = KekNameColossus;
        }
        if ( KeyName != null ) {
            this.KeyName = KeyName;
        }
        if ( KmsId != null ) {
            this.KmsId = KmsId;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType! (enum)
        if (this.CloudType != null) {
            s += ind + "cloudType\n" ;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            s += ind + "appId\n" ;
        }
        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        if (this.AppSecret != null) {
            s += ind + "appSecret\n" ;
        }
        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String! (scalar)
        if (this.KekNameColossus != null) {
            s += ind + "kekNameColossus\n" ;
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName != null) {
            s += ind + "keyName\n" ;
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (this.KmsId != null) {
            s += ind + "kmsId\n" ;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            s += ind + "tenantId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType! (enum)
        if (this.CloudType == null && Exploration.Includes(parent + ".cloudType", true))
        {
            this.CloudType = new O365AzureCloudType();
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId == null && Exploration.Includes(parent + ".appId", true))
        {
            this.AppId = new System.String("FETCH");
        }
        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        if (this.AppSecret == null && Exploration.Includes(parent + ".appSecret", true))
        {
            this.AppSecret = new System.String("FETCH");
        }
        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String! (scalar)
        if (this.KekNameColossus == null && Exploration.Includes(parent + ".kekNameColossus", true))
        {
            this.KekNameColossus = new System.String("FETCH");
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName == null && Exploration.Includes(parent + ".keyName", true))
        {
            this.KeyName = new System.String("FETCH");
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (this.KmsId == null && Exploration.Includes(parent + ".kmsId", true))
        {
            this.KmsId = new System.String("FETCH");
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId == null && Exploration.Includes(parent + ".tenantId", true))
        {
            this.TenantId = new System.String("FETCH");
        }
    }


    #endregion

    } // class KmsSpec
    
    #endregion

    public static class ListKmsSpecExtensions
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
            this List<KmsSpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KmsSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new KmsSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types