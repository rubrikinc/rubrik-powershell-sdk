// AzureSnappableLocation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:39.
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
    #region AzureSnappableLocation
 
    public class AzureSnappableLocation: IFragment, SnappableLocationType
    {
        #region members
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        [JsonProperty("azureRegion")]
        public System.String? AzureRegion { get; set; }

        //      C# -> System.String? SubscriptionRubrikId
        // GraphQL -> subscriptionRubrikId: String (scalar)
        [JsonProperty("subscriptionRubrikId")]
        public System.String? SubscriptionRubrikId { get; set; }

        //      C# -> System.String? SubscriptionRubrikName
        // GraphQL -> subscriptionRubrikName: String (scalar)
        [JsonProperty("subscriptionRubrikName")]
        public System.String? SubscriptionRubrikName { get; set; }

        #endregion

    #region methods

    public AzureSnappableLocation Set(
        System.String? AzureRegion = null,
        System.String? SubscriptionRubrikId = null,
        System.String? SubscriptionRubrikName = null
    ) 
    {
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( SubscriptionRubrikId != null ) {
            this.SubscriptionRubrikId = SubscriptionRubrikId;
        }
        if ( SubscriptionRubrikName != null ) {
            this.SubscriptionRubrikName = SubscriptionRubrikName;
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
            //      C# -> System.String? AzureRegion
            // GraphQL -> azureRegion: String! (scalar)
            if (this.AzureRegion != null)
            {
                 s += ind + "azureRegion\n";

            }
            //      C# -> System.String? SubscriptionRubrikId
            // GraphQL -> subscriptionRubrikId: String (scalar)
            if (this.SubscriptionRubrikId != null)
            {
                 s += ind + "subscriptionRubrikId\n";

            }
            //      C# -> System.String? SubscriptionRubrikName
            // GraphQL -> subscriptionRubrikName: String (scalar)
            if (this.SubscriptionRubrikName != null)
            {
                 s += ind + "subscriptionRubrikName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AzureRegion
            // GraphQL -> azureRegion: String! (scalar)
            if (this.AzureRegion == null && Exploration.Includes(parent + ".azureRegion$"))
            {
                this.AzureRegion = new System.String("FETCH");
            }
            //      C# -> System.String? SubscriptionRubrikId
            // GraphQL -> subscriptionRubrikId: String (scalar)
            if (this.SubscriptionRubrikId == null && Exploration.Includes(parent + ".subscriptionRubrikId$"))
            {
                this.SubscriptionRubrikId = new System.String("FETCH");
            }
            //      C# -> System.String? SubscriptionRubrikName
            // GraphQL -> subscriptionRubrikName: String (scalar)
            if (this.SubscriptionRubrikName == null && Exploration.Includes(parent + ".subscriptionRubrikName$"))
            {
                this.SubscriptionRubrikName = new System.String("FETCH");
            }
        }


    #endregion

    } // class AzureSnappableLocation
    #endregion

    public static class ListAzureSnappableLocationExtensions
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
            this List<AzureSnappableLocation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureSnappableLocation> list, 
            String parent = "")
        {
            var item = new AzureSnappableLocation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types