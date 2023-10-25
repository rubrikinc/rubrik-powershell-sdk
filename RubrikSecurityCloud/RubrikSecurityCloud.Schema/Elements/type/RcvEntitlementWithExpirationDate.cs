// RcvEntitlementWithExpirationDate.cs
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
    #region RcvEntitlementWithExpirationDate
    public class RcvEntitlementWithExpirationDate: BaseType
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

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvEntitlementWithExpirationDate";
    }

    public RcvEntitlementWithExpirationDate Set(
        RcvRegionBundle? Bundle = null,
        RcvTier? Tier = null,
        System.Single? Capacity = null,
        DateTime? ExpirationDate = null
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
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
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
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
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
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (ec.Includes("expirationDate",true))
        {
            if(this.ExpirationDate == null) {

                this.ExpirationDate = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationDate != null && ec.Excludes("expirationDate",true))
        {
            this.ExpirationDate = null;
        }
    }


    #endregion

    } // class RcvEntitlementWithExpirationDate
    
    #endregion

    public static class ListRcvEntitlementWithExpirationDateExtensions
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
            this List<RcvEntitlementWithExpirationDate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RcvEntitlementWithExpirationDate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementWithExpirationDate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementWithExpirationDate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlementWithExpirationDate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types