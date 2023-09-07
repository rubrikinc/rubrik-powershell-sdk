// AzureCloudAccountSubscriptionWithFeatures.cs
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
    #region AzureCloudAccountSubscriptionWithFeatures
    public class AzureCloudAccountSubscriptionWithFeatures: BaseType
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

    public override string GetGqlTypeName() {
        return "AzureCloudAccountSubscriptionWithFeatures";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
        if (this.FeatureDetails != null) {
            var fspec = this.FeatureDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "featureDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureCloudAccountSubscription? Subscription
        // GraphQL -> subscription: AzureCloudAccountSubscription (type)
        if (this.Subscription != null) {
            var fspec = this.Subscription.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subscription {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
        if (this.FeatureDetails == null && ec.Includes("featureDetails",false))
        {
            this.FeatureDetails = new List<AzureCloudAccountFeatureDetail>();
            this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));
        }
        //      C# -> AzureCloudAccountSubscription? Subscription
        // GraphQL -> subscription: AzureCloudAccountSubscription (type)
        if (this.Subscription == null && ec.Includes("subscription",false))
        {
            this.Subscription = new AzureCloudAccountSubscription();
            this.Subscription.ApplyExploratoryFieldSpec(ec.NewChild("subscription"));
        }
    }


    #endregion

    } // class AzureCloudAccountSubscriptionWithFeatures
    
    #endregion

    public static class ListAzureCloudAccountSubscriptionWithFeaturesExtensions
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
            this List<AzureCloudAccountSubscriptionWithFeatures> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountSubscriptionWithFeatures> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountSubscriptionWithFeatures());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureCloudAccountSubscriptionWithFeatures> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types