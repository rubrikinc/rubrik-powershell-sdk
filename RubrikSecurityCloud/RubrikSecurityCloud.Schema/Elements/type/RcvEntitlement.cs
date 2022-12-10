// RcvEntitlement.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:31.
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
    #region RcvEntitlement
    public class RcvEntitlement: IFragment
    {
        #region members
        //      C# -> System.Single? Capacity
        // GraphQL -> capacity: Float! (scalar)
        [JsonProperty("capacity")]
        public System.Single? Capacity { get; set; }

        //      C# -> RcvRegionBundle? Bundle
        // GraphQL -> bundle: RcvRegionBundle! (enum)
        [JsonProperty("bundle")]
        public RcvRegionBundle? Bundle { get; set; }

        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        [JsonProperty("tier")]
        public RcvTier? Tier { get; set; }

        #endregion

    #region methods

    public RcvEntitlement Set(
        System.Single? Capacity = null,
        RcvRegionBundle? Bundle = null,
        RcvTier? Tier = null
    ) 
    {
        if ( Capacity != null ) {
            this.Capacity = Capacity;
        }
        if ( Bundle != null ) {
            this.Bundle = Bundle;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
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
            //      C# -> System.Single? Capacity
            // GraphQL -> capacity: Float! (scalar)
            if (this.Capacity != null)
            {
                 s += ind + "capacity\n";

            }
            //      C# -> RcvRegionBundle? Bundle
            // GraphQL -> bundle: RcvRegionBundle! (enum)
            if (this.Bundle != null)
            {
                 s += ind + "bundle\n";

            }
            //      C# -> RcvTier? Tier
            // GraphQL -> tier: RcvTier! (enum)
            if (this.Tier != null)
            {
                 s += ind + "tier\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? Capacity
            // GraphQL -> capacity: Float! (scalar)
            if (this.Capacity == null && Exploration.Includes(parent + ".capacity$"))
            {
                this.Capacity = new System.Single();
            }
            //      C# -> RcvRegionBundle? Bundle
            // GraphQL -> bundle: RcvRegionBundle! (enum)
            if (this.Bundle == null && Exploration.Includes(parent + ".bundle$"))
            {
                this.Bundle = new RcvRegionBundle();
            }
            //      C# -> RcvTier? Tier
            // GraphQL -> tier: RcvTier! (enum)
            if (this.Tier == null && Exploration.Includes(parent + ".tier$"))
            {
                this.Tier = new RcvTier();
            }
        }


    #endregion

    } // class RcvEntitlement
    #endregion

    public static class ListRcvEntitlementExtensions
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
            this List<RcvEntitlement> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RcvEntitlement> list, 
            String parent = "")
        {
            var item = new RcvEntitlement();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types