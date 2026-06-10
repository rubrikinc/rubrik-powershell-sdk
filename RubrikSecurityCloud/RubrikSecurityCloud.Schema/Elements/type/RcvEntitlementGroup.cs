// RcvEntitlementGroup.cs
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
    #region RcvEntitlementGroup
    public class RcvEntitlementGroup: BaseType
    {
        #region members

        //      C# -> System.Single? AggregateCapacity
        // GraphQL -> aggregateCapacity: Float! (scalar)
        [JsonProperty("aggregateCapacity")]
        public System.Single? AggregateCapacity { get; set; }

        //      C# -> System.Single? AggregateExpectedUsedCapacity
        // GraphQL -> aggregateExpectedUsedCapacity: Float! (scalar)
        [JsonProperty("aggregateExpectedUsedCapacity")]
        public System.Single? AggregateExpectedUsedCapacity { get; set; }

        //      C# -> System.Single? AggregateUsedCapacity
        // GraphQL -> aggregateUsedCapacity: Float! (scalar)
        [JsonProperty("aggregateUsedCapacity")]
        public System.Single? AggregateUsedCapacity { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> List<RcvEntitlementGroupMember>? Members
        // GraphQL -> members: [RcvEntitlementGroupMember!]! (type)
        [JsonProperty("members")]
        public List<RcvEntitlementGroupMember>? Members { get; set; }

        //      C# -> RcvEntitlementGroupMember? Representative
        // GraphQL -> representative: RcvEntitlementGroupMember (type)
        [JsonProperty("representative")]
        public RcvEntitlementGroupMember? Representative { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvEntitlementGroup";
    }

    public RcvEntitlementGroup Set(
        System.Single? AggregateCapacity = null,
        System.Single? AggregateExpectedUsedCapacity = null,
        System.Single? AggregateUsedCapacity = null,
        System.String? DisplayName = null,
        List<RcvEntitlementGroupMember>? Members = null,
        RcvEntitlementGroupMember? Representative = null
    ) 
    {
        if ( AggregateCapacity != null ) {
            this.AggregateCapacity = AggregateCapacity;
        }
        if ( AggregateExpectedUsedCapacity != null ) {
            this.AggregateExpectedUsedCapacity = AggregateExpectedUsedCapacity;
        }
        if ( AggregateUsedCapacity != null ) {
            this.AggregateUsedCapacity = AggregateUsedCapacity;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Members != null ) {
            this.Members = Members;
        }
        if ( Representative != null ) {
            this.Representative = Representative;
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
        //      C# -> System.Single? AggregateCapacity
        // GraphQL -> aggregateCapacity: Float! (scalar)
        if (this.AggregateCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregateCapacity\n" ;
            } else {
                s += ind + "aggregateCapacity\n" ;
            }
        }
        //      C# -> System.Single? AggregateExpectedUsedCapacity
        // GraphQL -> aggregateExpectedUsedCapacity: Float! (scalar)
        if (this.AggregateExpectedUsedCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregateExpectedUsedCapacity\n" ;
            } else {
                s += ind + "aggregateExpectedUsedCapacity\n" ;
            }
        }
        //      C# -> System.Single? AggregateUsedCapacity
        // GraphQL -> aggregateUsedCapacity: Float! (scalar)
        if (this.AggregateUsedCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregateUsedCapacity\n" ;
            } else {
                s += ind + "aggregateUsedCapacity\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> List<RcvEntitlementGroupMember>? Members
        // GraphQL -> members: [RcvEntitlementGroupMember!]! (type)
        if (this.Members != null) {
            var fspec = this.Members.AsFieldSpec(conf.Child("members"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "members" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RcvEntitlementGroupMember? Representative
        // GraphQL -> representative: RcvEntitlementGroupMember (type)
        if (this.Representative != null) {
            var fspec = this.Representative.AsFieldSpec(conf.Child("representative"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "representative" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Single? AggregateCapacity
        // GraphQL -> aggregateCapacity: Float! (scalar)
        if (ec.Includes("aggregateCapacity",true))
        {
            if(this.AggregateCapacity == null) {

                this.AggregateCapacity = new System.Single();

            } else {


            }
        }
        else if (this.AggregateCapacity != null && ec.Excludes("aggregateCapacity",true))
        {
            this.AggregateCapacity = null;
        }
        //      C# -> System.Single? AggregateExpectedUsedCapacity
        // GraphQL -> aggregateExpectedUsedCapacity: Float! (scalar)
        if (ec.Includes("aggregateExpectedUsedCapacity",true))
        {
            if(this.AggregateExpectedUsedCapacity == null) {

                this.AggregateExpectedUsedCapacity = new System.Single();

            } else {


            }
        }
        else if (this.AggregateExpectedUsedCapacity != null && ec.Excludes("aggregateExpectedUsedCapacity",true))
        {
            this.AggregateExpectedUsedCapacity = null;
        }
        //      C# -> System.Single? AggregateUsedCapacity
        // GraphQL -> aggregateUsedCapacity: Float! (scalar)
        if (ec.Includes("aggregateUsedCapacity",true))
        {
            if(this.AggregateUsedCapacity == null) {

                this.AggregateUsedCapacity = new System.Single();

            } else {


            }
        }
        else if (this.AggregateUsedCapacity != null && ec.Excludes("aggregateUsedCapacity",true))
        {
            this.AggregateUsedCapacity = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> List<RcvEntitlementGroupMember>? Members
        // GraphQL -> members: [RcvEntitlementGroupMember!]! (type)
        if (ec.Includes("members",false))
        {
            if(this.Members == null) {

                this.Members = new List<RcvEntitlementGroupMember>();
                this.Members.ApplyExploratoryFieldSpec(ec.NewChild("members"));

            } else {

                this.Members.ApplyExploratoryFieldSpec(ec.NewChild("members"));

            }
        }
        else if (this.Members != null && ec.Excludes("members",false))
        {
            this.Members = null;
        }
        //      C# -> RcvEntitlementGroupMember? Representative
        // GraphQL -> representative: RcvEntitlementGroupMember (type)
        if (ec.Includes("representative",false))
        {
            if(this.Representative == null) {

                this.Representative = new RcvEntitlementGroupMember();
                this.Representative.ApplyExploratoryFieldSpec(ec.NewChild("representative"));

            } else {

                this.Representative.ApplyExploratoryFieldSpec(ec.NewChild("representative"));

            }
        }
        else if (this.Representative != null && ec.Excludes("representative",false))
        {
            this.Representative = null;
        }
    }


    #endregion

    } // class RcvEntitlementGroup
    
    #endregion

    public static class ListRcvEntitlementGroupExtensions
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
            this List<RcvEntitlementGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvEntitlementGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlementGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types