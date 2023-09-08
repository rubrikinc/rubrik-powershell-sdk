// AzureExocomputeConfigsInAccount.cs
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
    #region AzureExocomputeConfigsInAccount
    public class AzureExocomputeConfigsInAccount: BaseType
    {
        #region members

        //      C# -> List<AzureCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AzureCloudAccountRegion!]! (enum)
        [JsonProperty("exocomputeEligibleRegions")]
        public List<AzureCloudAccountRegion>? ExocomputeEligibleRegions { get; set; }

        //      C# -> AzureCloudAccountSubscriptionDetail? AzureCloudAccount
        // GraphQL -> azureCloudAccount: AzureCloudAccountSubscriptionDetail! (type)
        [JsonProperty("azureCloudAccount")]
        public AzureCloudAccountSubscriptionDetail? AzureCloudAccount { get; set; }

        //      C# -> List<AzureExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AzureExocomputeGetConfigResponse!]! (type)
        [JsonProperty("configs")]
        public List<AzureExocomputeGetConfigResponse>? Configs { get; set; }

        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetails
        // GraphQL -> featureDetails: AzureCloudAccountFeatureDetail! (type)
        [JsonProperty("featureDetails")]
        public AzureCloudAccountFeatureDetail? FeatureDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureExocomputeConfigsInAccount";
    }

    public AzureExocomputeConfigsInAccount Set(
        List<AzureCloudAccountRegion>? ExocomputeEligibleRegions = null,
        AzureCloudAccountSubscriptionDetail? AzureCloudAccount = null,
        List<AzureExocomputeGetConfigResponse>? Configs = null,
        AzureCloudAccountFeatureDetail? FeatureDetails = null
    ) 
    {
        if ( ExocomputeEligibleRegions != null ) {
            this.ExocomputeEligibleRegions = ExocomputeEligibleRegions;
        }
        if ( AzureCloudAccount != null ) {
            this.AzureCloudAccount = AzureCloudAccount;
        }
        if ( Configs != null ) {
            this.Configs = Configs;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
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
        //      C# -> List<AzureCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AzureCloudAccountRegion!]! (enum)
        if (this.ExocomputeEligibleRegions != null) {
            s += ind + "exocomputeEligibleRegions\n" ;
        }
        //      C# -> AzureCloudAccountSubscriptionDetail? AzureCloudAccount
        // GraphQL -> azureCloudAccount: AzureCloudAccountSubscriptionDetail! (type)
        if (this.AzureCloudAccount != null) {
            var fspec = this.AzureCloudAccount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureCloudAccount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AzureExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AzureExocomputeGetConfigResponse!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetails
        // GraphQL -> featureDetails: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetails != null) {
            var fspec = this.FeatureDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featureDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AzureCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AzureCloudAccountRegion!]! (enum)
        if (this.ExocomputeEligibleRegions == null && ec.Includes("exocomputeEligibleRegions",true))
        {
            this.ExocomputeEligibleRegions = new List<AzureCloudAccountRegion>();
        }
        //      C# -> AzureCloudAccountSubscriptionDetail? AzureCloudAccount
        // GraphQL -> azureCloudAccount: AzureCloudAccountSubscriptionDetail! (type)
        if (this.AzureCloudAccount == null && ec.Includes("azureCloudAccount",false))
        {
            this.AzureCloudAccount = new AzureCloudAccountSubscriptionDetail();
            this.AzureCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("azureCloudAccount"));
        }
        //      C# -> List<AzureExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AzureExocomputeGetConfigResponse!]! (type)
        if (this.Configs == null && ec.Includes("configs",false))
        {
            this.Configs = new List<AzureExocomputeGetConfigResponse>();
            this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetails
        // GraphQL -> featureDetails: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetails == null && ec.Includes("featureDetails",false))
        {
            this.FeatureDetails = new AzureCloudAccountFeatureDetail();
            this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));
        }
    }


    #endregion

    } // class AzureExocomputeConfigsInAccount
    
    #endregion

    public static class ListAzureExocomputeConfigsInAccountExtensions
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
            this List<AzureExocomputeConfigsInAccount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeConfigsInAccount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeConfigsInAccount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureExocomputeConfigsInAccount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types