// RcvRegionList.cs
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
    #region RcvRegionList
    public class RcvRegionList: BaseType
    {
        #region members

        //      C# -> System.String? Bundle
        // GraphQL -> bundle: String! (scalar)
        [JsonProperty("bundle")]
        public System.String? Bundle { get; set; }

        //      C# -> System.String? Redundancy
        // GraphQL -> redundancy: String! (scalar)
        [JsonProperty("redundancy")]
        public System.String? Redundancy { get; set; }

        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        [JsonProperty("regions")]
        public List<System.String>? Regions { get; set; }

        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        [JsonProperty("tier")]
        public System.String? Tier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RCVRegionList";
    }

    public RcvRegionList Set(
        System.String? Bundle = null,
        System.String? Redundancy = null,
        List<System.String>? Regions = null,
        System.String? Tier = null
    ) 
    {
        if ( Bundle != null ) {
            this.Bundle = Bundle;
        }
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
        }
        if ( Regions != null ) {
            this.Regions = Regions;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Bundle
        // GraphQL -> bundle: String! (scalar)
        if (this.Bundle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bundle\n" ;
            } else {
                s += ind + "bundle\n" ;
            }
        }
        //      C# -> System.String? Redundancy
        // GraphQL -> redundancy: String! (scalar)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        if (this.Regions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regions\n" ;
            } else {
                s += ind + "regions\n" ;
            }
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Bundle
        // GraphQL -> bundle: String! (scalar)
        if (ec.Includes("bundle",true))
        {
            if(this.Bundle == null) {

                this.Bundle = "FETCH";

            } else {


            }
        }
        else if (this.Bundle != null && ec.Excludes("bundle",true))
        {
            this.Bundle = null;
        }
        //      C# -> System.String? Redundancy
        // GraphQL -> redundancy: String! (scalar)
        if (ec.Includes("redundancy",true))
        {
            if(this.Redundancy == null) {

                this.Redundancy = "FETCH";

            } else {


            }
        }
        else if (this.Redundancy != null && ec.Excludes("redundancy",true))
        {
            this.Redundancy = null;
        }
        //      C# -> List<System.String>? Regions
        // GraphQL -> regions: [String!]! (scalar)
        if (ec.Includes("regions",true))
        {
            if(this.Regions == null) {

                this.Regions = new List<System.String>();

            } else {


            }
        }
        else if (this.Regions != null && ec.Excludes("regions",true))
        {
            this.Regions = null;
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = "FETCH";

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
    }


    #endregion

    } // class RcvRegionList
    
    #endregion

    public static class ListRcvRegionListExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RcvRegionList> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvRegionList> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvRegionList> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvRegionList());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvRegionList> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types