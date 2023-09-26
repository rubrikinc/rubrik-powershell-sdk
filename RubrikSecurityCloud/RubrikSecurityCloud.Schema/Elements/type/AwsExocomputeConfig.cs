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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsCloudAccount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(conf.Child("configs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(conf.Child("featureDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetail {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (this.MappedCloudAccounts != null) {
            var fspec = this.MappedCloudAccounts.AsFieldSpec(conf.Child("mappedCloudAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mappedCloudAccounts {\n" + fspec + ind + "}\n" ;
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
            this List<AwsExocomputeConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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