// RcvEntitlement.cs
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
    #region RcvEntitlement
    public class RcvEntitlement: BaseType
    {
        #region members

        //      C# -> RcvRegionBundle? Bundle
        // GraphQL -> bundle: RcvRegionBundle! (enum)
        [JsonProperty("bundle")]
        public RcvRegionBundle? Bundle { get; set; }

        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        [JsonProperty("tier")]
        public RcvTier? Tier { get; set; }

        //      C# -> System.Single? Capacity
        // GraphQL -> capacity: Float! (scalar)
        [JsonProperty("capacity")]
        public System.Single? Capacity { get; set; }


        #endregion

    #region methods

    public RcvEntitlement Set(
        RcvRegionBundle? Bundle = null,
        RcvTier? Tier = null,
        System.Single? Capacity = null
    ) 
    {
        if ( Bundle != null ) {
            this.Bundle = Bundle;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        if ( Capacity != null ) {
            this.Capacity = Capacity;
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
        //      C# -> RcvRegionBundle? Bundle
        // GraphQL -> bundle: RcvRegionBundle! (enum)
        if (this.Bundle != null) {
            s += ind + "bundle\n" ;
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (this.Tier != null) {
            s += ind + "tier\n" ;
        }
        //      C# -> System.Single? Capacity
        // GraphQL -> capacity: Float! (scalar)
        if (this.Capacity != null) {
            s += ind + "capacity\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RcvRegionBundle? Bundle
        // GraphQL -> bundle: RcvRegionBundle! (enum)
        if (this.Bundle == null && Exploration.Includes(parent + ".bundle", true))
        {
            this.Bundle = new RcvRegionBundle();
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (this.Tier == null && Exploration.Includes(parent + ".tier", true))
        {
            this.Tier = new RcvTier();
        }
        //      C# -> System.Single? Capacity
        // GraphQL -> capacity: Float! (scalar)
        if (this.Capacity == null && Exploration.Includes(parent + ".capacity", true))
        {
            this.Capacity = new System.Single();
        }
    }


    #endregion

    } // class RcvEntitlement
    
    #endregion

    public static class ListRcvEntitlementExtensions
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
            this List<RcvEntitlement> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlement> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlement());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types