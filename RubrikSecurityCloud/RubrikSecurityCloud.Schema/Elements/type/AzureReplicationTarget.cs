// AzureReplicationTarget.cs
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
    #region AzureReplicationTarget
    public class AzureReplicationTarget: IFragment
    {
        #region members
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }

        //      C# -> AzureNativeRegionForReplication? Region
        // GraphQL -> region: AzureNativeRegionForReplication! (enum)
        [JsonProperty("region")]
        public AzureNativeRegionForReplication? Region { get; set; }

        #endregion

    #region methods

    public AzureReplicationTarget Set(
        System.String? SubscriptionId = null,
        System.String? SubscriptionName = null,
        AzureNativeRegionForReplication? Region = null
    ) 
    {
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( SubscriptionName != null ) {
            this.SubscriptionName = SubscriptionName;
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
            //      C# -> System.String? SubscriptionId
            // GraphQL -> subscriptionId: String! (scalar)
            if (this.SubscriptionId != null)
            {
                 s += ind + "subscriptionId\n";

            }
            //      C# -> System.String? SubscriptionName
            // GraphQL -> subscriptionName: String! (scalar)
            if (this.SubscriptionName != null)
            {
                 s += ind + "subscriptionName\n";

            }
            //      C# -> AzureNativeRegionForReplication? Region
            // GraphQL -> region: AzureNativeRegionForReplication! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SubscriptionId
            // GraphQL -> subscriptionId: String! (scalar)
            if (this.SubscriptionId == null && Exploration.Includes(parent + ".subscriptionId$"))
            {
                this.SubscriptionId = new System.String("FETCH");
            }
            //      C# -> System.String? SubscriptionName
            // GraphQL -> subscriptionName: String! (scalar)
            if (this.SubscriptionName == null && Exploration.Includes(parent + ".subscriptionName$"))
            {
                this.SubscriptionName = new System.String("FETCH");
            }
            //      C# -> AzureNativeRegionForReplication? Region
            // GraphQL -> region: AzureNativeRegionForReplication! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AzureNativeRegionForReplication();
            }
        }


    #endregion

    } // class AzureReplicationTarget
    #endregion

    public static class ListAzureReplicationTargetExtensions
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
            this List<AzureReplicationTarget> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureReplicationTarget> list, 
            String parent = "")
        {
            var item = new AzureReplicationTarget();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types