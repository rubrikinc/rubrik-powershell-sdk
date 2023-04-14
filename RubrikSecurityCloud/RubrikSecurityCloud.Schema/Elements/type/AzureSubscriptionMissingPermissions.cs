// AzureSubscriptionMissingPermissions.cs
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
    #region AzureSubscriptionMissingPermissions
    public class AzureSubscriptionMissingPermissions: IFragment
    {
        #region members
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        [JsonProperty("missingPermissions")]
        public List<System.String>? MissingPermissions { get; set; }

        //      C# -> System.String? SubscriptionNativeId
        // GraphQL -> subscriptionNativeId: String! (scalar)
        [JsonProperty("subscriptionNativeId")]
        public System.String? SubscriptionNativeId { get; set; }

        #endregion

    #region methods

    public AzureSubscriptionMissingPermissions Set(
        List<System.String>? MissingPermissions = null,
        System.String? SubscriptionNativeId = null
    ) 
    {
        if ( MissingPermissions != null ) {
            this.MissingPermissions = MissingPermissions;
        }
        if ( SubscriptionNativeId != null ) {
            this.SubscriptionNativeId = SubscriptionNativeId;
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
            //      C# -> List<System.String>? MissingPermissions
            // GraphQL -> missingPermissions: [String!]! (scalar)
            if (this.MissingPermissions != null)
            {
                 s += ind + "missingPermissions\n";

            }
            //      C# -> System.String? SubscriptionNativeId
            // GraphQL -> subscriptionNativeId: String! (scalar)
            if (this.SubscriptionNativeId != null)
            {
                 s += ind + "subscriptionNativeId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? MissingPermissions
            // GraphQL -> missingPermissions: [String!]! (scalar)
            if (this.MissingPermissions == null && Exploration.Includes(parent + ".missingPermissions$"))
            {
                this.MissingPermissions = new List<System.String>();
            }
            //      C# -> System.String? SubscriptionNativeId
            // GraphQL -> subscriptionNativeId: String! (scalar)
            if (this.SubscriptionNativeId == null && Exploration.Includes(parent + ".subscriptionNativeId$"))
            {
                this.SubscriptionNativeId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AzureSubscriptionMissingPermissions
    #endregion

    public static class ListAzureSubscriptionMissingPermissionsExtensions
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
            this List<AzureSubscriptionMissingPermissions> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureSubscriptionMissingPermissions> list, 
            String parent = "")
        {
            var item = new AzureSubscriptionMissingPermissions();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types