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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        if (this.AppSecret != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appSecret\n" ;
            } else {
                s += ind + "appSecret\n" ;
            }
        }
        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String! (scalar)
        if (this.KekNameColossus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kekNameColossus\n" ;
            } else {
                s += ind + "kekNameColossus\n" ;
            }
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyName\n" ;
            } else {
                s += ind + "keyName\n" ;
            }
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (this.KmsId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsId\n" ;
            } else {
                s += ind + "kmsId\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new O365AzureCloudType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        if (ec.Includes("appSecret",true))
        {
            if(this.AppSecret == null) {

                this.AppSecret = "FETCH";

            } else {


            }
        }
        else if (this.AppSecret != null && ec.Excludes("appSecret",true))
        {
            this.AppSecret = null;
        }
        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String! (scalar)
        if (ec.Includes("kekNameColossus",true))
        {
            if(this.KekNameColossus == null) {

                this.KekNameColossus = "FETCH";

            } else {


            }
        }
        else if (this.KekNameColossus != null && ec.Excludes("kekNameColossus",true))
        {
            this.KekNameColossus = null;
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (ec.Includes("keyName",true))
        {
            if(this.KeyName == null) {

                this.KeyName = "FETCH";

            } else {


            }
        }
        else if (this.KeyName != null && ec.Excludes("keyName",true))
        {
            this.KeyName = null;
        }
        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        if (ec.Includes("kmsId",true))
        {
            if(this.KmsId == null) {

                this.KmsId = "FETCH";

            } else {


            }
        }
        else if (this.KmsId != null && ec.Excludes("kmsId",true))
        {
            this.KmsId = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
    }


    #endregion

    } // class KmsSpec
    
    #endregion

    public static class ListKmsSpecExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<KmsSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KmsSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<KmsSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types