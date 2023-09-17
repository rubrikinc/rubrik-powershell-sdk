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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<AwsCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AwsCloudAccountRegion!]! (enum)
        if (this.ExocomputeEligibleRegions != null) {
            s += ind + "exocomputeEligibleRegions\n" ;
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds != null) {
            s += ind + "mappedCloudAccountIds\n" ;
        }
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount != null) {
            var fspec = this.AwsCloudAccount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsCloudAccount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail != null) {
            var fspec = this.FeatureDetail.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featureDetail {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (this.MappedCloudAccounts != null) {
            var fspec = this.MappedCloudAccounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mappedCloudAccounts {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AwsCloudAccountRegion!]! (enum)
        if (this.ExocomputeEligibleRegions == null && ec.Includes("exocomputeEligibleRegions",true))
        {
            this.ExocomputeEligibleRegions = new List<AwsCloudAccountRegion>();
        }
        //      C# -> List<System.String>? MappedCloudAccountIds
        // GraphQL -> mappedCloudAccountIds: [UUID!]! (scalar)
        if (this.MappedCloudAccountIds == null && ec.Includes("mappedCloudAccountIds",true))
        {
            this.MappedCloudAccountIds = new List<System.String>();
        }
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount! (type)
        if (this.AwsCloudAccount == null && ec.Includes("awsCloudAccount",false))
        {
            this.AwsCloudAccount = new AwsCloudAccount();
            this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));
        }
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.Configs == null && ec.Includes("configs",false))
        {
            this.Configs = new List<AwsExocomputeGetConfigResponse>();
            this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));
        }
        //      C# -> FeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: FeatureDetail! (type)
        if (this.FeatureDetail == null && ec.Includes("featureDetail",false))
        {
            this.FeatureDetail = new FeatureDetail();
            this.FeatureDetail.ApplyExploratoryFieldSpec(ec.NewChild("featureDetail"));
        }
        //      C# -> List<CloudAccountDetails>? MappedCloudAccounts
        // GraphQL -> mappedCloudAccounts: [CloudAccountDetails!]! (type)
        if (this.MappedCloudAccounts == null && ec.Includes("mappedCloudAccounts",false))
        {
            this.MappedCloudAccounts = new List<CloudAccountDetails>();
            this.MappedCloudAccounts.ApplyExploratoryFieldSpec(ec.NewChild("mappedCloudAccounts"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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