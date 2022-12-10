// AzureSubscriptionWithFeaturesType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:26.
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
    #region AzureSubscriptionWithFeaturesType
    public class AzureSubscriptionWithFeaturesType: IFragment
    {
        #region members
        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        [JsonProperty("customerTenantId")]
        public System.String? CustomerTenantId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
        [JsonProperty("featureDetails")]
        public List<AzureCloudAccountFeatureDetail>? FeatureDetails { get; set; }

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        #endregion

    #region methods

    public AzureSubscriptionWithFeaturesType Set(
        System.String? CustomerTenantId = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? NativeId = null,
        List<AzureCloudAccountFeatureDetail>? FeatureDetails = null,
        AzureCloudType? CloudType = null
    ) 
    {
        if ( CustomerTenantId != null ) {
            this.CustomerTenantId = CustomerTenantId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
        }
        if ( CloudType != null ) {
            this.CloudType = CloudType;
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
            //      C# -> System.String? CustomerTenantId
            // GraphQL -> customerTenantId: String! (scalar)
            if (this.CustomerTenantId != null)
            {
                 s += ind + "customerTenantId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId != null)
            {
                 s += ind + "nativeId\n";

            }
            //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
            // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
            if (this.FeatureDetails != null)
            {
                 s += ind + "featureDetails\n";

                 s += ind + "{\n" + 
                 this.FeatureDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureCloudType? CloudType
            // GraphQL -> cloudType: AzureCloudType! (enum)
            if (this.CloudType != null)
            {
                 s += ind + "cloudType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CustomerTenantId
            // GraphQL -> customerTenantId: String! (scalar)
            if (this.CustomerTenantId == null && Exploration.Includes(parent + ".customerTenantId$"))
            {
                this.CustomerTenantId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId == null && Exploration.Includes(parent + ".nativeId$"))
            {
                this.NativeId = new System.String("FETCH");
            }
            //      C# -> List<AzureCloudAccountFeatureDetail>? FeatureDetails
            // GraphQL -> featureDetails: [AzureCloudAccountFeatureDetail!]! (type)
            if (this.FeatureDetails == null && Exploration.Includes(parent + ".featureDetails"))
            {
                this.FeatureDetails = new List<AzureCloudAccountFeatureDetail>();
                this.FeatureDetails.ApplyExploratoryFragment(parent + ".featureDetails");
            }
            //      C# -> AzureCloudType? CloudType
            // GraphQL -> cloudType: AzureCloudType! (enum)
            if (this.CloudType == null && Exploration.Includes(parent + ".cloudType$"))
            {
                this.CloudType = new AzureCloudType();
            }
        }


    #endregion

    } // class AzureSubscriptionWithFeaturesType
    #endregion

    public static class ListAzureSubscriptionWithFeaturesTypeExtensions
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
            this List<AzureSubscriptionWithFeaturesType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureSubscriptionWithFeaturesType> list, 
            String parent = "")
        {
            var item = new AzureSubscriptionWithFeaturesType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types