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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "KmsSpec";
    }

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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType! (enum)
        if (this.CloudType == null && ec.Includes("cloudType",true))
        {
            this.CloudType = new O365AzureCloudType();
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId == null && ec.Includes("appId",true))
        {
            this.AppId = "FETCH";
        }
        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        if (this.AppSecret == null && ec.Includes("appSecret",true))
        {
            this.AppSecret = "FETCH";
        }
        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String! (scalar)
        if (this.KekNameColossus == null && ec.Includes("kekNameColossus",true))
        {
            this.KekNameColossus = "FETCH";
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName == null && ec.Includes("keyName",true))
        {
            this.KeyName = "FETCH";
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (this.KmsId == null && ec.Includes("kmsId",true))
        {
            this.KmsId = "FETCH";
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId == null && ec.Includes("tenantId",true))
        {
            this.TenantId = "FETCH";
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KmsSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KmsSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<KmsSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types