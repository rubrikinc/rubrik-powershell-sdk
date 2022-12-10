// AzureCloudAccountSubscriptionWithFeatures.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:25.
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
    #region AzureCloudAccountSubscriptionWithFeatures
    public class AzureCloudAccountSubscriptionWithFeatures: IFragment
    {
        #region members
        //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
        [JsonProperty("featureDetails")]
        public List<AzureCloudAccountFeatureDetail>? FeatureDetails { get; set; }

        //      C# -> AzureCloudAccountSubscription? Subscription
        // GraphQL -> subscription: AzureCloudAccountSubscription (type)
        [JsonProperty("subscription")]
        public AzureCloudAccountSubscription? Subscription { get; set; }

        #endregion

    #region methods

    public AzureCloudAccountSubscriptionWithFeatures Set(
        List<AzureCloudAccountFeatureDetail>? FeatureDetails = null,
        AzureCloudAccountSubscription? Subscription = null
    ) 
    {
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
        }
        if ( Subscription != null ) {
            this.Subscription = Subscription;
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
            //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
            // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
            if (this.FeatureDetails != null)
            {
                 s += ind + "featureDetails\n";

                 s += ind + "{\n" + 
                 this.FeatureDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureCloudAccountSubscription? Subscription
            // GraphQL -> subscription: AzureCloudAccountSubscription (type)
            if (this.Subscription != null)
            {
                 s += ind + "subscription\n";

                 s += ind + "{\n" + 
                 this.Subscription.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
            // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
            if (this.FeatureDetails == null && Exploration.Includes(parent + ".featureDetails"))
            {
                this.FeatureDetails = new List<AzureCloudAccountFeatureDetail>();
                this.FeatureDetails.ApplyExploratoryFragment(parent + ".featureDetails");
            }
            //      C# -> AzureCloudAccountSubscription? Subscription
            // GraphQL -> subscription: AzureCloudAccountSubscription (type)
            if (this.Subscription == null && Exploration.Includes(parent + ".subscription"))
            {
                this.Subscription = new AzureCloudAccountSubscription();
                this.Subscription.ApplyExploratoryFragment(parent + ".subscription");
            }
        }


    #endregion

    } // class AzureCloudAccountSubscriptionWithFeatures
    #endregion

    public static class ListAzureCloudAccountSubscriptionWithFeaturesExtensions
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
            this List<AzureCloudAccountSubscriptionWithFeatures> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureCloudAccountSubscriptionWithFeatures> list, 
            String parent = "")
        {
            var item = new AzureCloudAccountSubscriptionWithFeatures();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types