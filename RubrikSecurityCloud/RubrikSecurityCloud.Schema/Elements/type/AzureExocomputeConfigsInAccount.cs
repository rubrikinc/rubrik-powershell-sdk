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

namespace Rubrik.SecurityCloud.Types
{
    #region AzureExocomputeConfigsInAccount
    public class AzureExocomputeConfigsInAccount: IFragment
    {
        #region members
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

        //      C# -> List<AzureCloudAccountRegion>? ExocomputeEligibleRegions
        // GraphQL -> exocomputeEligibleRegions: [AzureCloudAccountRegion!]! (enum)
        [JsonProperty("exocomputeEligibleRegions")]
        public List<AzureCloudAccountRegion>? ExocomputeEligibleRegions { get; set; }

        #endregion

    #region methods

    public AzureExocomputeConfigsInAccount Set(
        AzureCloudAccountSubscriptionDetail? AzureCloudAccount = null,
        List<AzureExocomputeGetConfigResponse>? Configs = null,
        AzureCloudAccountFeatureDetail? FeatureDetails = null,
        List<AzureCloudAccountRegion>? ExocomputeEligibleRegions = null
    ) 
    {
        if ( AzureCloudAccount != null ) {
            this.AzureCloudAccount = AzureCloudAccount;
        }
        if ( Configs != null ) {
            this.Configs = Configs;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
        }
        if ( ExocomputeEligibleRegions != null ) {
            this.ExocomputeEligibleRegions = ExocomputeEligibleRegions;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> AzureCloudAccountSubscriptionDetail? AzureCloudAccount
            // GraphQL -> azureCloudAccount: AzureCloudAccountSubscriptionDetail! (type)
            if (this.AzureCloudAccount != null)
            {
                 s += ind + "azureCloudAccount\n";

                 s += ind + "{\n" + 
                 this.AzureCloudAccount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AzureExocomputeGetConfigResponse>? Configs
            // GraphQL -> configs: [AzureExocomputeGetConfigResponse!]! (type)
            if (this.Configs != null)
            {
                 s += ind + "configs\n";

                 s += ind + "{\n" + 
                 this.Configs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureCloudAccountFeatureDetail? FeatureDetails
            // GraphQL -> featureDetails: AzureCloudAccountFeatureDetail! (type)
            if (this.FeatureDetails != null)
            {
                 s += ind + "featureDetails\n";

                 s += ind + "{\n" + 
                 this.FeatureDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AzureCloudAccountRegion>? ExocomputeEligibleRegions
            // GraphQL -> exocomputeEligibleRegions: [AzureCloudAccountRegion!]! (enum)
            if (this.ExocomputeEligibleRegions != null)
            {
                 s += ind + "exocomputeEligibleRegions\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AzureCloudAccountSubscriptionDetail? AzureCloudAccount
            // GraphQL -> azureCloudAccount: AzureCloudAccountSubscriptionDetail! (type)
            if (this.AzureCloudAccount == null && Exploration.Includes(parent + ".azureCloudAccount"))
            {
                this.AzureCloudAccount = new AzureCloudAccountSubscriptionDetail();
                this.AzureCloudAccount.ApplyExploratoryFragment(parent + ".azureCloudAccount");
            }
            //      C# -> List<AzureExocomputeGetConfigResponse>? Configs
            // GraphQL -> configs: [AzureExocomputeGetConfigResponse!]! (type)
            if (this.Configs == null && Exploration.Includes(parent + ".configs"))
            {
                this.Configs = new List<AzureExocomputeGetConfigResponse>();
                this.Configs.ApplyExploratoryFragment(parent + ".configs");
            }
            //      C# -> AzureCloudAccountFeatureDetail? FeatureDetails
            // GraphQL -> featureDetails: AzureCloudAccountFeatureDetail! (type)
            if (this.FeatureDetails == null && Exploration.Includes(parent + ".featureDetails"))
            {
                this.FeatureDetails = new AzureCloudAccountFeatureDetail();
                this.FeatureDetails.ApplyExploratoryFragment(parent + ".featureDetails");
            }
            //      C# -> List<AzureCloudAccountRegion>? ExocomputeEligibleRegions
            // GraphQL -> exocomputeEligibleRegions: [AzureCloudAccountRegion!]! (enum)
            if (this.ExocomputeEligibleRegions == null && Exploration.Includes(parent + ".exocomputeEligibleRegions$"))
            {
                this.ExocomputeEligibleRegions = new List<AzureCloudAccountRegion>();
            }
        }


    #endregion

    } // class AzureExocomputeConfigsInAccount
    #endregion

    public static class ListAzureExocomputeConfigsInAccountExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AzureExocomputeConfigsInAccount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureExocomputeConfigsInAccount> list, 
            String parent = "")
        {
            var item = new AzureExocomputeConfigsInAccount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types