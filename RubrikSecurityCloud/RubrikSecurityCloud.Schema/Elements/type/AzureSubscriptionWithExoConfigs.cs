// AzureSubscriptionWithExoConfigs.cs
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
    #region AzureSubscriptionWithExoConfigs
    public class AzureSubscriptionWithExoConfigs: IFragment
    {
        #region members
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }

        //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
        // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        [JsonProperty("exocomputeConfigs")]
        public List<AzureExocomputeConfigDetails>? ExocomputeConfigs { get; set; }

        //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
        [JsonProperty("featureDetail")]
        public AzureCloudAccountFeatureDetail? FeatureDetail { get; set; }

        //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
        // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
        [JsonProperty("mappedExocomputeConfigs")]
        public List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs { get; set; }

        //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
        // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
        [JsonProperty("mappedExocomputeSubscription")]
        public AzureMappedExocomputeSubscription? MappedExocomputeSubscription { get; set; }

        #endregion

    #region methods

    public AzureSubscriptionWithExoConfigs Set(
        System.String? AzureSubscriptionNativeId = null,
        System.String? AzureSubscriptionRubrikId = null,
        System.String? SubscriptionName = null,
        List<AzureExocomputeConfigDetails>? ExocomputeConfigs = null,
        AzureCloudAccountFeatureDetail? FeatureDetail = null,
        List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs = null,
        AzureMappedExocomputeSubscription? MappedExocomputeSubscription = null
    ) 
    {
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( AzureSubscriptionRubrikId != null ) {
            this.AzureSubscriptionRubrikId = AzureSubscriptionRubrikId;
        }
        if ( SubscriptionName != null ) {
            this.SubscriptionName = SubscriptionName;
        }
        if ( ExocomputeConfigs != null ) {
            this.ExocomputeConfigs = ExocomputeConfigs;
        }
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( MappedExocomputeConfigs != null ) {
            this.MappedExocomputeConfigs = MappedExocomputeConfigs;
        }
        if ( MappedExocomputeSubscription != null ) {
            this.MappedExocomputeSubscription = MappedExocomputeSubscription;
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
            //      C# -> System.String? AzureSubscriptionNativeId
            // GraphQL -> azureSubscriptionNativeId: String! (scalar)
            if (this.AzureSubscriptionNativeId != null)
            {
                 s += ind + "azureSubscriptionNativeId\n";

            }
            //      C# -> System.String? AzureSubscriptionRubrikId
            // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
            if (this.AzureSubscriptionRubrikId != null)
            {
                 s += ind + "azureSubscriptionRubrikId\n";

            }
            //      C# -> System.String? SubscriptionName
            // GraphQL -> subscriptionName: String! (scalar)
            if (this.SubscriptionName != null)
            {
                 s += ind + "subscriptionName\n";

            }
            //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
            // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
            if (this.ExocomputeConfigs != null)
            {
                 s += ind + "exocomputeConfigs\n";

                 s += ind + "{\n" + 
                 this.ExocomputeConfigs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
            // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
            if (this.FeatureDetail != null)
            {
                 s += ind + "featureDetail\n";

                 s += ind + "{\n" + 
                 this.FeatureDetail.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
            // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
            if (this.MappedExocomputeConfigs != null)
            {
                 s += ind + "mappedExocomputeConfigs\n";

                 s += ind + "{\n" + 
                 this.MappedExocomputeConfigs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
            // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
            if (this.MappedExocomputeSubscription != null)
            {
                 s += ind + "mappedExocomputeSubscription\n";

                 s += ind + "{\n" + 
                 this.MappedExocomputeSubscription.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AzureSubscriptionNativeId
            // GraphQL -> azureSubscriptionNativeId: String! (scalar)
            if (this.AzureSubscriptionNativeId == null && Exploration.Includes(parent + ".azureSubscriptionNativeId$"))
            {
                this.AzureSubscriptionNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? AzureSubscriptionRubrikId
            // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
            if (this.AzureSubscriptionRubrikId == null && Exploration.Includes(parent + ".azureSubscriptionRubrikId$"))
            {
                this.AzureSubscriptionRubrikId = new System.String("FETCH");
            }
            //      C# -> System.String? SubscriptionName
            // GraphQL -> subscriptionName: String! (scalar)
            if (this.SubscriptionName == null && Exploration.Includes(parent + ".subscriptionName$"))
            {
                this.SubscriptionName = new System.String("FETCH");
            }
            //      C# -> List<AzureExocomputeConfigDetails>? ExocomputeConfigs
            // GraphQL -> exocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
            if (this.ExocomputeConfigs == null && Exploration.Includes(parent + ".exocomputeConfigs"))
            {
                this.ExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
                this.ExocomputeConfigs.ApplyExploratoryFragment(parent + ".exocomputeConfigs");
            }
            //      C# -> AzureCloudAccountFeatureDetail? FeatureDetail
            // GraphQL -> featureDetail: AzureCloudAccountFeatureDetail! (type)
            if (this.FeatureDetail == null && Exploration.Includes(parent + ".featureDetail"))
            {
                this.FeatureDetail = new AzureCloudAccountFeatureDetail();
                this.FeatureDetail.ApplyExploratoryFragment(parent + ".featureDetail");
            }
            //      C# -> List<AzureExocomputeConfigDetails>? MappedExocomputeConfigs
            // GraphQL -> mappedExocomputeConfigs: [AzureExocomputeConfigDetails!]! (type)
            if (this.MappedExocomputeConfigs == null && Exploration.Includes(parent + ".mappedExocomputeConfigs"))
            {
                this.MappedExocomputeConfigs = new List<AzureExocomputeConfigDetails>();
                this.MappedExocomputeConfigs.ApplyExploratoryFragment(parent + ".mappedExocomputeConfigs");
            }
            //      C# -> AzureMappedExocomputeSubscription? MappedExocomputeSubscription
            // GraphQL -> mappedExocomputeSubscription: AzureMappedExocomputeSubscription (type)
            if (this.MappedExocomputeSubscription == null && Exploration.Includes(parent + ".mappedExocomputeSubscription"))
            {
                this.MappedExocomputeSubscription = new AzureMappedExocomputeSubscription();
                this.MappedExocomputeSubscription.ApplyExploratoryFragment(parent + ".mappedExocomputeSubscription");
            }
        }


    #endregion

    } // class AzureSubscriptionWithExoConfigs
    #endregion

    public static class ListAzureSubscriptionWithExoConfigsExtensions
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
            this List<AzureSubscriptionWithExoConfigs> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureSubscriptionWithExoConfigs> list, 
            String parent = "")
        {
            var item = new AzureSubscriptionWithExoConfigs();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types