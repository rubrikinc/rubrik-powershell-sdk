// AzureApplicationCloudAccountToExocomputeConfig.cs
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
    #region AzureApplicationCloudAccountToExocomputeConfig
    public class AzureApplicationCloudAccountToExocomputeConfig: BaseType
    {
        #region members

        //      C# -> List<AzureCloudAccountRegion>? ExocomputeMappableRegions
        // GraphQL -> exocomputeMappableRegions: [AzureCloudAccountRegion!]! (enum)
        [JsonProperty("exocomputeMappableRegions")]
        public List<AzureCloudAccountRegion>? ExocomputeMappableRegions { get; set; }

        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: String! (scalar)
        [JsonProperty("applicationCloudAccountId")]
        public System.String? ApplicationCloudAccountId { get; set; }

        //      C# -> System.Boolean? IsHost
        // GraphQL -> isHost: Boolean! (scalar)
        [JsonProperty("isHost")]
        public System.Boolean? IsHost { get; set; }

        //      C# -> List<AzureExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeGetConfigResponse!]! (type)
        [JsonProperty("exocomputeConfigs")]
        public List<AzureExocomputeGetConfigResponse>? ExocomputeConfigs { get; set; }

        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        [JsonProperty("mappedExocomputeAccount")]
        public CloudAccountDetails? MappedExocomputeAccount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureApplicationCloudAccountToExocomputeConfig";
    }

    public AzureApplicationCloudAccountToExocomputeConfig Set(
        List<AzureCloudAccountRegion>? ExocomputeMappableRegions = null,
        System.String? ApplicationCloudAccountId = null,
        System.Boolean? IsHost = null,
        List<AzureExocomputeGetConfigResponse>? ExocomputeConfigs = null,
        CloudAccountDetails? MappedExocomputeAccount = null
    ) 
    {
        if ( ExocomputeMappableRegions != null ) {
            this.ExocomputeMappableRegions = ExocomputeMappableRegions;
        }
        if ( ApplicationCloudAccountId != null ) {
            this.ApplicationCloudAccountId = ApplicationCloudAccountId;
        }
        if ( IsHost != null ) {
            this.IsHost = IsHost;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( MappedExocomputeAccount != null ) {
            this.MappedExocomputeAccount = MappedExocomputeAccount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<AzureCloudAccountRegion>? ExocomputeMappableRegions
        // GraphQL -> exocomputeMappableRegions: [AzureCloudAccountRegion!]! (enum)
        if (this.ExocomputeMappableRegions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeMappableRegions\n" ;
            } else {
                s += ind + "exocomputeMappableRegions\n" ;
            }
        }
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: String! (scalar)
        if (this.ApplicationCloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationCloudAccountId\n" ;
            } else {
                s += ind + "applicationCloudAccountId\n" ;
            }
        }
        //      C# -> System.Boolean? IsHost
        // GraphQL -> isHost: Boolean! (scalar)
        if (this.IsHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHost\n" ;
            } else {
                s += ind + "isHost\n" ;
            }
        }
        //      C# -> List<AzureExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeGetConfigResponse!]! (type)
        if (this.ExocomputeConfigs != null) {
            var fspec = this.ExocomputeConfigs.AsFieldSpec(conf.Child("exocomputeConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exocomputeConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (this.MappedExocomputeAccount != null) {
            var fspec = this.MappedExocomputeAccount.AsFieldSpec(conf.Child("mappedExocomputeAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedExocomputeAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<AzureCloudAccountRegion>? ExocomputeMappableRegions
        // GraphQL -> exocomputeMappableRegions: [AzureCloudAccountRegion!]! (enum)
        if (ec.Includes("exocomputeMappableRegions",true))
        {
            if(this.ExocomputeMappableRegions == null) {

                this.ExocomputeMappableRegions = new List<AzureCloudAccountRegion>();

            } else {


            }
        }
        else if (this.ExocomputeMappableRegions != null && ec.Excludes("exocomputeMappableRegions",true))
        {
            this.ExocomputeMappableRegions = null;
        }
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: String! (scalar)
        if (ec.Includes("applicationCloudAccountId",true))
        {
            if(this.ApplicationCloudAccountId == null) {

                this.ApplicationCloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationCloudAccountId != null && ec.Excludes("applicationCloudAccountId",true))
        {
            this.ApplicationCloudAccountId = null;
        }
        //      C# -> System.Boolean? IsHost
        // GraphQL -> isHost: Boolean! (scalar)
        if (ec.Includes("isHost",true))
        {
            if(this.IsHost == null) {

                this.IsHost = true;

            } else {


            }
        }
        else if (this.IsHost != null && ec.Excludes("isHost",true))
        {
            this.IsHost = null;
        }
        //      C# -> List<AzureExocomputeGetConfigResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeGetConfigResponse!]! (type)
        if (ec.Includes("exocomputeConfigs",false))
        {
            if(this.ExocomputeConfigs == null) {

                this.ExocomputeConfigs = new List<AzureExocomputeGetConfigResponse>();
                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            } else {

                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            }
        }
        else if (this.ExocomputeConfigs != null && ec.Excludes("exocomputeConfigs",false))
        {
            this.ExocomputeConfigs = null;
        }
        //      C# -> CloudAccountDetails? MappedExocomputeAccount
        // GraphQL -> mappedExocomputeAccount: CloudAccountDetails (type)
        if (ec.Includes("mappedExocomputeAccount",false))
        {
            if(this.MappedExocomputeAccount == null) {

                this.MappedExocomputeAccount = new CloudAccountDetails();
                this.MappedExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeAccount"));

            } else {

                this.MappedExocomputeAccount.ApplyExploratoryFieldSpec(ec.NewChild("mappedExocomputeAccount"));

            }
        }
        else if (this.MappedExocomputeAccount != null && ec.Excludes("mappedExocomputeAccount",false))
        {
            this.MappedExocomputeAccount = null;
        }
    }


    #endregion

    } // class AzureApplicationCloudAccountToExocomputeConfig
    
    #endregion

    public static class ListAzureApplicationCloudAccountToExocomputeConfigExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureApplicationCloudAccountToExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureApplicationCloudAccountToExocomputeConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureApplicationCloudAccountToExocomputeConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureApplicationCloudAccountToExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureApplicationCloudAccountToExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types