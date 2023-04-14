// RcvEntitlementsUsageDetails.cs
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
    #region RcvEntitlementsUsageDetails
    public class RcvEntitlementsUsageDetails: IFragment
    {
        #region members
        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        [JsonProperty("usedCapacity")]
        public System.Single? UsedCapacity { get; set; }

        //      C# -> RcvEntitlement? Entitlement
        // GraphQL -> entitlement: RcvEntitlement (type)
        [JsonProperty("entitlement")]
        public RcvEntitlement? Entitlement { get; set; }

        #endregion

    #region methods

    public RcvEntitlementsUsageDetails Set(
        System.Single? UsedCapacity = null,
        RcvEntitlement? Entitlement = null
    ) 
    {
        if ( UsedCapacity != null ) {
            this.UsedCapacity = UsedCapacity;
        }
        if ( Entitlement != null ) {
            this.Entitlement = Entitlement;
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
            //      C# -> System.Single? UsedCapacity
            // GraphQL -> usedCapacity: Float! (scalar)
            if (this.UsedCapacity != null)
            {
                 s += ind + "usedCapacity\n";

            }
            //      C# -> RcvEntitlement? Entitlement
            // GraphQL -> entitlement: RcvEntitlement (type)
            if (this.Entitlement != null)
            {
                 s += ind + "entitlement\n";

                 s += ind + "{\n" + 
                 this.Entitlement.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? UsedCapacity
            // GraphQL -> usedCapacity: Float! (scalar)
            if (this.UsedCapacity == null && Exploration.Includes(parent + ".usedCapacity$"))
            {
                this.UsedCapacity = new System.Single();
            }
            //      C# -> RcvEntitlement? Entitlement
            // GraphQL -> entitlement: RcvEntitlement (type)
            if (this.Entitlement == null && Exploration.Includes(parent + ".entitlement"))
            {
                this.Entitlement = new RcvEntitlement();
                this.Entitlement.ApplyExploratoryFragment(parent + ".entitlement");
            }
        }


    #endregion

    } // class RcvEntitlementsUsageDetails
    #endregion

    public static class ListRcvEntitlementsUsageDetailsExtensions
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
            this List<RcvEntitlementsUsageDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RcvEntitlementsUsageDetails> list, 
            String parent = "")
        {
            var item = new RcvEntitlementsUsageDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types