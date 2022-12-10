// AzureResourceGroupInfo.cs
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
    #region AzureResourceGroupInfo
    public class AzureResourceGroupInfo: IFragment
    {
        #region members
        //      C# -> System.String? ResourceGroupName
        // GraphQL -> resourceGroupName: String! (scalar)
        [JsonProperty("resourceGroupName")]
        public System.String? ResourceGroupName { get; set; }

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: UUID! (scalar)
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }

        //      C# -> List<TagObject>? Tags
        // GraphQL -> tags: [TagObject!]! (type)
        [JsonProperty("tags")]
        public List<TagObject>? Tags { get; set; }

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }

        #endregion

    #region methods

    public AzureResourceGroupInfo Set(
        System.String? ResourceGroupName = null,
        System.String? SubscriptionNativeId = null,
        List<TagObject>? Tags = null,
        AzureCloudAccountRegion? Region = null
    ) 
    {
        if ( ResourceGroupName != null ) {
            this.ResourceGroupName = ResourceGroupName;
        }
        if ( SubscriptionNativeId != null ) {
            this.SubscriptionNativeId = SubscriptionNativeId;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
        }
        if ( Region != null ) {
            this.Region = Region;
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
            //      C# -> System.String? ResourceGroupName
            // GraphQL -> resourceGroupName: String! (scalar)
            if (this.ResourceGroupName != null)
            {
                 s += ind + "resourceGroupName\n";

            }
            //      C# -> System.String? SubscriptionNativeId
            // GraphQL -> subscriptionNativeId: UUID! (scalar)
            if (this.SubscriptionNativeId != null)
            {
                 s += ind + "subscriptionNativeId\n";

            }
            //      C# -> List<TagObject>? Tags
            // GraphQL -> tags: [TagObject!]! (type)
            if (this.Tags != null)
            {
                 s += ind + "tags\n";

                 s += ind + "{\n" + 
                 this.Tags.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureCloudAccountRegion? Region
            // GraphQL -> region: AzureCloudAccountRegion! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ResourceGroupName
            // GraphQL -> resourceGroupName: String! (scalar)
            if (this.ResourceGroupName == null && Exploration.Includes(parent + ".resourceGroupName$"))
            {
                this.ResourceGroupName = new System.String("FETCH");
            }
            //      C# -> System.String? SubscriptionNativeId
            // GraphQL -> subscriptionNativeId: UUID! (scalar)
            if (this.SubscriptionNativeId == null && Exploration.Includes(parent + ".subscriptionNativeId$"))
            {
                this.SubscriptionNativeId = new System.String("FETCH");
            }
            //      C# -> List<TagObject>? Tags
            // GraphQL -> tags: [TagObject!]! (type)
            if (this.Tags == null && Exploration.Includes(parent + ".tags"))
            {
                this.Tags = new List<TagObject>();
                this.Tags.ApplyExploratoryFragment(parent + ".tags");
            }
            //      C# -> AzureCloudAccountRegion? Region
            // GraphQL -> region: AzureCloudAccountRegion! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AzureCloudAccountRegion();
            }
        }


    #endregion

    } // class AzureResourceGroupInfo
    #endregion

    public static class ListAzureResourceGroupInfoExtensions
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
            this List<AzureResourceGroupInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureResourceGroupInfo> list, 
            String parent = "")
        {
            var item = new AzureResourceGroupInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types