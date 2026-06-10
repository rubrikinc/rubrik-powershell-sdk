// RcvEntitlementGroupMember.cs
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
    #region RcvEntitlementGroupMember
    public class RcvEntitlementGroupMember: BaseType
    {
        #region members

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        [JsonProperty("tier")]
        public RcsTierEnumType? Tier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvEntitlementGroupMember";
    }

    public RcvEntitlementGroupMember Set(
        RcvRedundancy? Redundancy = null,
        RcsTierEnumType? Tier = null
    ) 
    {
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
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
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new RcsTierEnumType();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
    }


    #endregion

    } // class RcvEntitlementGroupMember
    
    #endregion

    public static class ListRcvEntitlementGroupMemberExtensions
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
            this List<RcvEntitlementGroupMember> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvEntitlementGroupMember> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementGroupMember> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementGroupMember());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlementGroupMember> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types