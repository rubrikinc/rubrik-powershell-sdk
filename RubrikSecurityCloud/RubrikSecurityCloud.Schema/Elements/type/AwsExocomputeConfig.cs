// AwsExocomputeConfig.cs
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
    #region AwsExocomputeConfig
    public class AwsExocomputeConfig: BaseType
    {
        #region members

        //      C# -> List<AwsCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AwsCloudAccountRegion!]! (enum)
        [JsonProperty("exocomputeEligibleRegions")]
        public List<AwsCloudAccountRegion>? ExocomputeEligibleRegions { get; set; }

        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigurationResponse!]! (interface)
        [JsonProperty("exocomputeConfigs")]
        public RscInterfaceList<AwsExocomputeGetConfigurationResponse> ExocomputeConfigs { get; set; }

        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        [JsonProperty("mappedCloudAccountIds")]
        public List<System.String>? MappedCloudAccountIds { get; set; }

        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        [JsonProperty("awsCloudAccount")]
        public AwsCloudAccount? AwsCloudAccount { get; set; }

        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        [JsonProperty("configs")]
        public List<AwsExocomputeGetConfigResponse>? Configs { get; set; }

        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        [JsonProperty("featureDetail")]
        public FeatureDetail? FeatureDetail { get; set; }

        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        [JsonProperty("mappedCloudAccounts")]
        public List<CloudAccountDetails>? MappedCloudAccounts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsExocomputeConfig";
    }

    public AwsExocomputeConfig Set(
        List<AwsCloudAccountRegion>? ExocomputeEligibleRegions = null,
        RscInterfaceList<AwsExocomputeGetConfigurationResponse> ExocomputeConfigs = null,
        List<System.String>? MappedCloudAccountIds = null,
        AwsCloudAccount? AwsCloudAccount = null,
        List<AwsExocomputeGetConfigResponse>? Configs = null,
        FeatureDetail? FeatureDetail = null,
        List<CloudAccountDetails>? MappedCloudAccounts = null
    ) 
    {
        if ( ExocomputeEligibleRegions != null ) {
            this.ExocomputeEligibleRegions = ExocomputeEligibleRegions;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( MappedCloudAccountIds != null ) {
            this.MappedCloudAccountIds = MappedCloudAccountIds;
        }
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( Configs != null ) {
            this.Configs = Configs;
        }
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( MappedCloudAccounts != null ) {
            this.MappedCloudAccounts = MappedCloudAccounts;
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
        //      C# -> List<AwsCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AwsCloudAccountRegion!]! (enum)
        if (this.ExocomputeEligibleRegions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeEligibleRegions\n" ;
            } else {
                s += ind + "exocomputeEligibleRegions\n" ;
            }
        }
        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigurationResponse!]! (interface)
        if (this.ExocomputeConfigs != null) {
            var fspec = this.ExocomputeConfigs.AsFieldSpec(conf.Child("exocomputeConfigs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exocomputeConfigs" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedCloudAccountIds\n" ;
            } else {
                s += ind + "mappedCloudAccountIds\n" ;
            }
        }
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount != null) {
            var fspec = this.AwsCloudAccount.AsFieldSpec(conf.Child("awsCloudAccount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsCloudAccount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(conf.Child("configs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(conf.Child("featureDetail"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (this.MappedCloudAccounts != null) {
            var fspec = this.MappedCloudAccounts.AsFieldSpec(conf.Child("mappedCloudAccounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedCloudAccounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AwsCloudAccountRegion!]! (enum)
        if (ec.Includes("exocomputeEligibleRegions",true))
        {
            if(this.ExocomputeEligibleRegions == null) {

                this.ExocomputeEligibleRegions = new List<AwsCloudAccountRegion>();

            } else {


            }
        }
        else if (this.ExocomputeEligibleRegions != null && ec.Excludes("exocomputeEligibleRegions",true))
        {
            this.ExocomputeEligibleRegions = null;
        }
        //      C# -> List<AwsExocomputeGetConfigurationResponse>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AwsExocomputeGetConfigurationResponse!]! (interface)
        if (ec.Includes("exocomputeConfigs",false))
        {
            if(this.ExocomputeConfigs == null) {

                this.ExocomputeConfigs = new RscInterfaceList<AwsExocomputeGetConfigurationResponse>();
                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            } else {

                this.ExocomputeConfigs.ApplyExploratoryFieldSpec(ec.NewChild("exocomputeConfigs"));

            }
        }
        else if (this.ExocomputeConfigs != null && ec.Excludes("exocomputeConfigs",false))
        {
            this.ExocomputeConfigs = null;
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (ec.Includes("mappedCloudAccountIds",true))
        {
            if(this.MappedCloudAccountIds == null) {

                this.MappedCloudAccountIds = new List<System.String>();

            } else {


            }
        }
        else if (this.MappedCloudAccountIds != null && ec.Excludes("mappedCloudAccountIds",true))
        {
            this.MappedCloudAccountIds = null;
        }
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (ec.Includes("awsCloudAccount",false))
        {
            if(this.AwsCloudAccount == null) {

                this.AwsCloudAccount = new AwsCloudAccount();
                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            } else {

                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            }
        }
        else if (this.AwsCloudAccount != null && ec.Excludes("awsCloudAccount",false))
        {
            this.AwsCloudAccount = null;
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (ec.Includes("configs",false))
        {
            if(this.Configs == null) {

                this.Configs = new List<AwsExocomputeGetConfigResponse>();
                this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));

            } else {

                this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));

            }
        }
        else if (this.Configs != null && ec.Excludes("configs",false))
        {
            this.Configs = null;
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (ec.Includes("featureDetail",false))
        {
            if(this.FeatureDetail == null) {

                this.FeatureDetail = new FeatureDetail();
                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            } else {

                this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));

            }
        }
        else if (this.FeatureDetail != null && ec.Excludes("featureDetail",false))
        {
            this.FeatureDetail = null;
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (ec.Includes("mappedCloudAccounts",false))
        {
            if(this.MappedCloudAccounts == null) {

                this.MappedCloudAccounts = new List<CloudAccountDetails>();
                this.MappedCloudAccounts.ApplyExploratoryFieldSpec(ec.NewChild("mappedCloudAccounts"));

            } else {

                this.MappedCloudAccounts.ApplyExploratoryFieldSpec(ec.NewChild("mappedCloudAccounts"));

            }
        }
        else if (this.MappedCloudAccounts != null && ec.Excludes("mappedCloudAccounts",false))
        {
            this.MappedCloudAccounts = null;
        }
    }


    #endregion

    } // class AwsExocomputeConfig
    
    #endregion

    public static class ListAwsExocomputeConfigExtensions
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
            this List<AwsExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsExocomputeConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsExocomputeConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsExocomputeConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsExocomputeConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types