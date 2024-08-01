// MutateRoleReqChangesTemplate.cs
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
    #region MutateRoleReqChangesTemplate
 
    public class MutateRoleReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> List<TprPolicySummary>? NewPolicies
        // GraphQL -> newPolicies: [TprPolicySummary!]! (type)
        [JsonProperty("newPolicies")]
        public List<TprPolicySummary>? NewPolicies { get; set; }

        //      C# -> List<TprPolicySummary>? OldPolicies
        // GraphQL -> oldPolicies: [TprPolicySummary!]! (type)
        [JsonProperty("oldPolicies")]
        public List<TprPolicySummary>? OldPolicies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MutateRoleReqChangesTemplate";
    }

    public MutateRoleReqChangesTemplate Set(
        System.String? RoleName = null,
        System.String? TemplateName = null,
        List<TprPolicySummary>? NewPolicies = null,
        List<TprPolicySummary>? OldPolicies = null
    ) 
    {
        if ( RoleName != null ) {
            this.RoleName = RoleName;
        }
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( NewPolicies != null ) {
            this.NewPolicies = NewPolicies;
        }
        if ( OldPolicies != null ) {
            this.OldPolicies = OldPolicies;
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
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (this.RoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleName\n" ;
            } else {
                s += ind + "roleName\n" ;
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
        //      C# -> List<TprPolicySummary>? NewPolicies
        // GraphQL -> newPolicies: [TprPolicySummary!]! (type)
        if (this.NewPolicies != null) {
            var fspec = this.NewPolicies.AsFieldSpec(conf.Child("newPolicies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newPolicies" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TprPolicySummary>? OldPolicies
        // GraphQL -> oldPolicies: [TprPolicySummary!]! (type)
        if (this.OldPolicies != null) {
            var fspec = this.OldPolicies.AsFieldSpec(conf.Child("oldPolicies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldPolicies" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (ec.Includes("roleName",true))
        {
            if(this.RoleName == null) {

                this.RoleName = "FETCH";

            } else {


            }
        }
        else if (this.RoleName != null && ec.Excludes("roleName",true))
        {
            this.RoleName = null;
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
        //      C# -> List<TprPolicySummary>? NewPolicies
        // GraphQL -> newPolicies: [TprPolicySummary!]! (type)
        if (ec.Includes("newPolicies",false))
        {
            if(this.NewPolicies == null) {

                this.NewPolicies = new List<TprPolicySummary>();
                this.NewPolicies.ApplyExploratoryFieldSpec(ec.NewChild("newPolicies"));

            } else {

                this.NewPolicies.ApplyExploratoryFieldSpec(ec.NewChild("newPolicies"));

            }
        }
        else if (this.NewPolicies != null && ec.Excludes("newPolicies",false))
        {
            this.NewPolicies = null;
        }
        //      C# -> List<TprPolicySummary>? OldPolicies
        // GraphQL -> oldPolicies: [TprPolicySummary!]! (type)
        if (ec.Includes("oldPolicies",false))
        {
            if(this.OldPolicies == null) {

                this.OldPolicies = new List<TprPolicySummary>();
                this.OldPolicies.ApplyExploratoryFieldSpec(ec.NewChild("oldPolicies"));

            } else {

                this.OldPolicies.ApplyExploratoryFieldSpec(ec.NewChild("oldPolicies"));

            }
        }
        else if (this.OldPolicies != null && ec.Excludes("oldPolicies",false))
        {
            this.OldPolicies = null;
        }
    }


    #endregion

    } // class MutateRoleReqChangesTemplate
    
    #endregion

    public static class ListMutateRoleReqChangesTemplateExtensions
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
            this List<MutateRoleReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MutateRoleReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MutateRoleReqChangesTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MutateRoleReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MutateRoleReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types