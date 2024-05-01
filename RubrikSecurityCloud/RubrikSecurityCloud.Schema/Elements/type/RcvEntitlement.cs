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

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

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

    public override string GetGqlTypeName() {
        return "RcvEntitlement";
    }

    public RcvEntitlement Set(
        RcvRegionBundle? Bundle = null,
        RcvRedundancy? Redundancy = null,
        RcvTier? Tier = null,
        System.Single? Capacity = null
    ) 
    {
        if ( Bundle != null ) {
            this.Bundle = Bundle;
        }
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RcvRegionBundle? Bundle
        // GraphQL -> bundle: RcvRegionBundle! (enum)
        if (this.Bundle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bundle\n" ;
            } else {
                s += ind + "bundle\n" ;
            }
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        //      C# -> System.Single? Capacity
        // GraphQL -> capacity: Float! (scalar)
        if (this.Capacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacity\n" ;
            } else {
                s += ind + "capacity\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RcvRegionBundle? Bundle
        // GraphQL -> bundle: RcvRegionBundle! (enum)
        if (ec.Includes("bundle",true))
        {
            if(this.Bundle == null) {

                this.Bundle = new RcvRegionBundle();

            } else {


            }
        }
        else if (this.Bundle != null && ec.Excludes("bundle",true))
        {
            this.Bundle = null;
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (ec.Includes("redundancy",true))
        {
            if(this.Redundancy == null) {

                this.Redundancy = new RcvRedundancy();

            } else {


            }
        }
        else if (this.Redundancy != null && ec.Excludes("redundancy",true))
        {
            this.Redundancy = null;
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new RcvTier();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
        //      C# -> System.Single? Capacity
        // GraphQL -> capacity: Float! (scalar)
        if (ec.Includes("capacity",true))
        {
            if(this.Capacity == null) {

                this.Capacity = new System.Single();

            } else {


            }
        }
        else if (this.Capacity != null && ec.Excludes("capacity",true))
        {
            this.Capacity = null;
        }
    }


    #endregion

    } // class RcvEntitlement
    
    #endregion

    public static class ListRcvEntitlementExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RcvEntitlement> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvEntitlement> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlement> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlement> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types