// EditSlaTprReqChangesTemplate.cs
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
    #region EditSlaTprReqChangesTemplate
 
    public class EditSlaTprReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.Boolean? ShouldApplyToExistingSnapshots
        // GraphQL -> shouldApplyToExistingSnapshots: Boolean! (scalar)
        [JsonProperty("shouldApplyToExistingSnapshots")]
        public System.Boolean? ShouldApplyToExistingSnapshots { get; set; }

        //      C# -> System.Boolean? ShouldApplyToNonPolicySnapshots
        // GraphQL -> shouldApplyToNonPolicySnapshots: Boolean! (scalar)
        [JsonProperty("shouldApplyToNonPolicySnapshots")]
        public System.Boolean? ShouldApplyToNonPolicySnapshots { get; set; }

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> GlobalSlaReply? NewSlaSummary
        // GraphQL -> newSlaSummary: GlobalSlaReply! (type)
        [JsonProperty("newSlaSummary")]
        public GlobalSlaReply? NewSlaSummary { get; set; }

        //      C# -> GlobalSlaReply? OldSlaSummary
        // GraphQL -> oldSlaSummary: GlobalSlaReply! (type)
        [JsonProperty("oldSlaSummary")]
        public GlobalSlaReply? OldSlaSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EditSlaTprReqChangesTemplate";
    }

    public EditSlaTprReqChangesTemplate Set(
        System.Boolean? ShouldApplyToExistingSnapshots = null,
        System.Boolean? ShouldApplyToNonPolicySnapshots = null,
        System.String? TemplateName = null,
        GlobalSlaReply? NewSlaSummary = null,
        GlobalSlaReply? OldSlaSummary = null
    ) 
    {
        if ( ShouldApplyToExistingSnapshots != null ) {
            this.ShouldApplyToExistingSnapshots = ShouldApplyToExistingSnapshots;
        }
        if ( ShouldApplyToNonPolicySnapshots != null ) {
            this.ShouldApplyToNonPolicySnapshots = ShouldApplyToNonPolicySnapshots;
        }
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( NewSlaSummary != null ) {
            this.NewSlaSummary = NewSlaSummary;
        }
        if ( OldSlaSummary != null ) {
            this.OldSlaSummary = OldSlaSummary;
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
        //      C# -> System.Boolean? ShouldApplyToExistingSnapshots
        // GraphQL -> shouldApplyToExistingSnapshots: Boolean! (scalar)
        if (this.ShouldApplyToExistingSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldApplyToExistingSnapshots\n" ;
            } else {
                s += ind + "shouldApplyToExistingSnapshots\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldApplyToNonPolicySnapshots
        // GraphQL -> shouldApplyToNonPolicySnapshots: Boolean! (scalar)
        if (this.ShouldApplyToNonPolicySnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldApplyToNonPolicySnapshots\n" ;
            } else {
                s += ind + "shouldApplyToNonPolicySnapshots\n" ;
            }
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateName\n" ;
            } else {
                s += ind + "templateName\n" ;
            }
        }
        //      C# -> GlobalSlaReply? NewSlaSummary
        // GraphQL -> newSlaSummary: GlobalSlaReply! (type)
        if (this.NewSlaSummary != null) {
            var fspec = this.NewSlaSummary.AsFieldSpec(conf.Child("newSlaSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newSlaSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GlobalSlaReply? OldSlaSummary
        // GraphQL -> oldSlaSummary: GlobalSlaReply! (type)
        if (this.OldSlaSummary != null) {
            var fspec = this.OldSlaSummary.AsFieldSpec(conf.Child("oldSlaSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldSlaSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? ShouldApplyToExistingSnapshots
        // GraphQL -> shouldApplyToExistingSnapshots: Boolean! (scalar)
        if (ec.Includes("shouldApplyToExistingSnapshots",true))
        {
            if(this.ShouldApplyToExistingSnapshots == null) {

                this.ShouldApplyToExistingSnapshots = true;

            } else {


            }
        }
        else if (this.ShouldApplyToExistingSnapshots != null && ec.Excludes("shouldApplyToExistingSnapshots",true))
        {
            this.ShouldApplyToExistingSnapshots = null;
        }
        //      C# -> System.Boolean? ShouldApplyToNonPolicySnapshots
        // GraphQL -> shouldApplyToNonPolicySnapshots: Boolean! (scalar)
        if (ec.Includes("shouldApplyToNonPolicySnapshots",true))
        {
            if(this.ShouldApplyToNonPolicySnapshots == null) {

                this.ShouldApplyToNonPolicySnapshots = true;

            } else {


            }
        }
        else if (this.ShouldApplyToNonPolicySnapshots != null && ec.Excludes("shouldApplyToNonPolicySnapshots",true))
        {
            this.ShouldApplyToNonPolicySnapshots = null;
        }
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (ec.Includes("templateName",true))
        {
            if(this.TemplateName == null) {

                this.TemplateName = "FETCH";

            } else {


            }
        }
        else if (this.TemplateName != null && ec.Excludes("templateName",true))
        {
            this.TemplateName = null;
        }
        //      C# -> GlobalSlaReply? NewSlaSummary
        // GraphQL -> newSlaSummary: GlobalSlaReply! (type)
        if (ec.Includes("newSlaSummary",false))
        {
            if(this.NewSlaSummary == null) {

                this.NewSlaSummary = new GlobalSlaReply();
                this.NewSlaSummary.ApplyExploratoryFieldSpec(ec.NewChild("newSlaSummary"));

            } else {

                this.NewSlaSummary.ApplyExploratoryFieldSpec(ec.NewChild("newSlaSummary"));

            }
        }
        else if (this.NewSlaSummary != null && ec.Excludes("newSlaSummary",false))
        {
            this.NewSlaSummary = null;
        }
        //      C# -> GlobalSlaReply? OldSlaSummary
        // GraphQL -> oldSlaSummary: GlobalSlaReply! (type)
        if (ec.Includes("oldSlaSummary",false))
        {
            if(this.OldSlaSummary == null) {

                this.OldSlaSummary = new GlobalSlaReply();
                this.OldSlaSummary.ApplyExploratoryFieldSpec(ec.NewChild("oldSlaSummary"));

            } else {

                this.OldSlaSummary.ApplyExploratoryFieldSpec(ec.NewChild("oldSlaSummary"));

            }
        }
        else if (this.OldSlaSummary != null && ec.Excludes("oldSlaSummary",false))
        {
            this.OldSlaSummary = null;
        }
    }


    #endregion

    } // class EditSlaTprReqChangesTemplate
    
    #endregion

    public static class ListEditSlaTprReqChangesTemplateExtensions
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
            this List<EditSlaTprReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EditSlaTprReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EditSlaTprReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EditSlaTprReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EditSlaTprReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types