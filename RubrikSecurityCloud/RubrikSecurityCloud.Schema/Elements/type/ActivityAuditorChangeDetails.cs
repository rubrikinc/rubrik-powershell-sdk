// ActivityAuditorChangeDetails.cs
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
    #region ActivityAuditorChangeDetails
    public class ActivityAuditorChangeDetails: BaseType
    {
        #region members

        //      C# -> ActivityAuditorAclChange? AclChange
        // GraphQL -> aclChange: ActivityAuditorAclChange (type)
        [JsonProperty("aclChange")]
        public ActivityAuditorAclChange? AclChange { get; set; }

        //      C# -> ActivityAuditorAttributeChange? AttributeChange
        // GraphQL -> attributeChange: ActivityAuditorAttributeChange (type)
        [JsonProperty("attributeChange")]
        public ActivityAuditorAttributeChange? AttributeChange { get; set; }

        //      C# -> ActivityAuditorGroupMembershipChange? GroupMembershipChange
        // GraphQL -> groupMembershipChange: ActivityAuditorGroupMembershipChange (type)
        [JsonProperty("groupMembershipChange")]
        public ActivityAuditorGroupMembershipChange? GroupMembershipChange { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivityAuditorChangeDetails";
    }

    public ActivityAuditorChangeDetails Set(
        ActivityAuditorAclChange? AclChange = null,
        ActivityAuditorAttributeChange? AttributeChange = null,
        ActivityAuditorGroupMembershipChange? GroupMembershipChange = null
    ) 
    {
        if ( AclChange != null ) {
            this.AclChange = AclChange;
        }
        if ( AttributeChange != null ) {
            this.AttributeChange = AttributeChange;
        }
        if ( GroupMembershipChange != null ) {
            this.GroupMembershipChange = GroupMembershipChange;
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
        //      C# -> ActivityAuditorAclChange? AclChange
        // GraphQL -> aclChange: ActivityAuditorAclChange (type)
        if (this.AclChange != null) {
            var fspec = this.AclChange.AsFieldSpec(conf.Child("aclChange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "aclChange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivityAuditorAttributeChange? AttributeChange
        // GraphQL -> attributeChange: ActivityAuditorAttributeChange (type)
        if (this.AttributeChange != null) {
            var fspec = this.AttributeChange.AsFieldSpec(conf.Child("attributeChange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "attributeChange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActivityAuditorGroupMembershipChange? GroupMembershipChange
        // GraphQL -> groupMembershipChange: ActivityAuditorGroupMembershipChange (type)
        if (this.GroupMembershipChange != null) {
            var fspec = this.GroupMembershipChange.AsFieldSpec(conf.Child("groupMembershipChange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupMembershipChange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ActivityAuditorAclChange? AclChange
        // GraphQL -> aclChange: ActivityAuditorAclChange (type)
        if (ec.Includes("aclChange",false))
        {
            if(this.AclChange == null) {

                this.AclChange = new ActivityAuditorAclChange();
                this.AclChange.ApplyExploratoryFieldSpec(ec.NewChild("aclChange"));

            } else {

                this.AclChange.ApplyExploratoryFieldSpec(ec.NewChild("aclChange"));

            }
        }
        else if (this.AclChange != null && ec.Excludes("aclChange",false))
        {
            this.AclChange = null;
        }
        //      C# -> ActivityAuditorAttributeChange? AttributeChange
        // GraphQL -> attributeChange: ActivityAuditorAttributeChange (type)
        if (ec.Includes("attributeChange",false))
        {
            if(this.AttributeChange == null) {

                this.AttributeChange = new ActivityAuditorAttributeChange();
                this.AttributeChange.ApplyExploratoryFieldSpec(ec.NewChild("attributeChange"));

            } else {

                this.AttributeChange.ApplyExploratoryFieldSpec(ec.NewChild("attributeChange"));

            }
        }
        else if (this.AttributeChange != null && ec.Excludes("attributeChange",false))
        {
            this.AttributeChange = null;
        }
        //      C# -> ActivityAuditorGroupMembershipChange? GroupMembershipChange
        // GraphQL -> groupMembershipChange: ActivityAuditorGroupMembershipChange (type)
        if (ec.Includes("groupMembershipChange",false))
        {
            if(this.GroupMembershipChange == null) {

                this.GroupMembershipChange = new ActivityAuditorGroupMembershipChange();
                this.GroupMembershipChange.ApplyExploratoryFieldSpec(ec.NewChild("groupMembershipChange"));

            } else {

                this.GroupMembershipChange.ApplyExploratoryFieldSpec(ec.NewChild("groupMembershipChange"));

            }
        }
        else if (this.GroupMembershipChange != null && ec.Excludes("groupMembershipChange",false))
        {
            this.GroupMembershipChange = null;
        }
    }


    #endregion

    } // class ActivityAuditorChangeDetails
    
    #endregion

    public static class ListActivityAuditorChangeDetailsExtensions
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
            this List<ActivityAuditorChangeDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivityAuditorChangeDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivityAuditorChangeDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityAuditorChangeDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivityAuditorChangeDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types