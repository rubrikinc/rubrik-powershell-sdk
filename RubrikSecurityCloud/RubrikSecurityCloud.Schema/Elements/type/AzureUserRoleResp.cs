// AzureUserRoleResp.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    #region AzureUserRoleResp
    public class AzureUserRoleResp: IFragment
    {
        #region members
        //      C# -> RoleStatus? GlobalAdministrator
        // GraphQL -> globalAdministrator: RoleStatus (type)
        [JsonProperty("globalAdministrator")]
        public RoleStatus? GlobalAdministrator { get; set; }

        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        [JsonProperty("subscriptionOwner")]
        public RoleStatus? SubscriptionOwner { get; set; }

        #endregion

    #region methods

    public AzureUserRoleResp Set(
        RoleStatus? GlobalAdministrator = null,
        RoleStatus? SubscriptionOwner = null
    ) 
    {
        if ( GlobalAdministrator != null ) {
            this.GlobalAdministrator = GlobalAdministrator;
        }
        if ( SubscriptionOwner != null ) {
            this.SubscriptionOwner = SubscriptionOwner;
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
            //      C# -> RoleStatus? GlobalAdministrator
            // GraphQL -> globalAdministrator: RoleStatus (type)
            if (this.GlobalAdministrator != null)
            {
                 s += ind + "globalAdministrator\n";

                 s += ind + "{\n" + 
                 this.GlobalAdministrator.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RoleStatus? SubscriptionOwner
            // GraphQL -> subscriptionOwner: RoleStatus (type)
            if (this.SubscriptionOwner != null)
            {
                 s += ind + "subscriptionOwner\n";

                 s += ind + "{\n" + 
                 this.SubscriptionOwner.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> RoleStatus? GlobalAdministrator
            // GraphQL -> globalAdministrator: RoleStatus (type)
            if (this.GlobalAdministrator == null && Exploration.Includes(parent + ".globalAdministrator"))
            {
                this.GlobalAdministrator = new RoleStatus();
                this.GlobalAdministrator.ApplyExploratoryFragment(parent + ".globalAdministrator");
            }
            //      C# -> RoleStatus? SubscriptionOwner
            // GraphQL -> subscriptionOwner: RoleStatus (type)
            if (this.SubscriptionOwner == null && Exploration.Includes(parent + ".subscriptionOwner"))
            {
                this.SubscriptionOwner = new RoleStatus();
                this.SubscriptionOwner.ApplyExploratoryFragment(parent + ".subscriptionOwner");
            }
        }


    #endregion

    } // class AzureUserRoleResp
    #endregion

    public static class ListAzureUserRoleRespExtensions
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
            this List<AzureUserRoleResp> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureUserRoleResp> list, 
            String parent = "")
        {
            var item = new AzureUserRoleResp();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types