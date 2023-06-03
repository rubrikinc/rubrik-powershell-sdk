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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "azureCloudAccount {\n" + this.AzureCloudAccount.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<AzureExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AzureExocomputeGetConfigResponse!]! (type)
        if (this.Configs != null) {
            s += ind + "configs {\n" + this.Configs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetails
        // GraphQL -> featureDetails: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetails != null) {
            s += ind + "featureDetails {\n" + this.FeatureDetails.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AzureCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AzureCloudAccountRegion!]! (enum)
        if (this.ExocomputeEligibleRegions == null && Exploration.Includes(parent + ".exocomputeEligibleRegions", true))
        {
            this.ExocomputeEligibleRegions = new List<AzureCloudAccountRegion>();
        }
        //      C# -> AzureCloudAccountSubscriptionDetail? AzureCloudAccount
        // GraphQL -> azureCloudAccount: AzureCloudAccountSubscriptionDetail! (type)
        if (this.AzureCloudAccount == null && Exploration.Includes(parent + ".azureCloudAccount"))
        {
            this.AzureCloudAccount = new AzureCloudAccountSubscriptionDetail();
            this.AzureCloudAccount.ApplyExploratoryFieldSpec(parent + ".azureCloudAccount");
        }
        //      C# -> List<AzureExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AzureExocomputeGetConfigResponse!]! (type)
        if (this.Configs == null && Exploration.Includes(parent + ".configs"))
        {
            this.Configs = new List<AzureExocomputeGetConfigResponse>();
            this.Configs.ApplyExploratoryFieldSpec(parent + ".configs");
        }
        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetails
        // GraphQL -> featureDetails: AzureCloudAccountFeatureDetail! (type)
        if (this.FeatureDetails == null && Exploration.Includes(parent + ".featureDetails"))
        {
            this.FeatureDetails = new AzureCloudAccountFeatureDetail();
            this.FeatureDetails.ApplyExploratoryFieldSpec(parent + ".featureDetails");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeConfigsInAccount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeConfigsInAccount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types