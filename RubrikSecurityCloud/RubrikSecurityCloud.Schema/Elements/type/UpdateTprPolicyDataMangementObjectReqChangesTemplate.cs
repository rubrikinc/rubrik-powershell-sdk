// UpdateTprPolicyDataMangementObjectReqChangesTemplate.cs
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
    #region UpdateTprPolicyDataMangementObjectReqChangesTemplate
 
    public class UpdateTprPolicyDataMangementObjectReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: TprRequestedChangeServiceAccountEntry (type)
        [JsonProperty("exemptServiceAccounts")]
        public TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts { get; set; }

        //      C# -> TprRequestedChangeEntry? QuorumRequirement
        // GraphQL -> quorumRequirement: TprRequestedChangeEntry (type)
        [JsonProperty("quorumRequirement")]
        public TprRequestedChangeEntry? QuorumRequirement { get; set; }

        //      C# -> TprRequestedChangeManagedObjectEntry? SelectedObjects
        // GraphQL -> selectedObjects: TprRequestedChangeManagedObjectEntry (type)
        [JsonProperty("selectedObjects")]
        public TprRequestedChangeManagedObjectEntry? SelectedObjects { get; set; }

        //      C# -> TprRequestedChangeTprRuleEntry? TprRules
        // GraphQL -> tprRules: TprRequestedChangeTprRuleEntry (type)
        [JsonProperty("tprRules")]
        public TprRequestedChangeTprRuleEntry? TprRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateTprPolicyDataMangementObjectReqChangesTemplate";
    }

    public UpdateTprPolicyDataMangementObjectReqChangesTemplate Set(
        System.String? TemplateName = null,
        TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts = null,
        TprRequestedChangeEntry? QuorumRequirement = null,
        TprRequestedChangeManagedObjectEntry? SelectedObjects = null,
        TprRequestedChangeTprRuleEntry? TprRules = null
    ) 
    {
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( ExemptServiceAccounts != null ) {
            this.ExemptServiceAccounts = ExemptServiceAccounts;
        }
        if ( QuorumRequirement != null ) {
            this.QuorumRequirement = QuorumRequirement;
        }
        if ( SelectedObjects != null ) {
            this.SelectedObjects = SelectedObjects;
        }
        if ( TprRules != null ) {
            this.TprRules = TprRules;
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
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateName\n" ;
            } else {
                s += ind + "templateName\n" ;
            }
        }
        //      C# -> TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: TprRequestedChangeServiceAccountEntry (type)
        if (this.ExemptServiceAccounts != null) {
            var fspec = this.ExemptServiceAccounts.AsFieldSpec(conf.Child("exemptServiceAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exemptServiceAccounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TprRequestedChangeEntry? QuorumRequirement
        // GraphQL -> quorumRequirement: TprRequestedChangeEntry (type)
        if (this.QuorumRequirement != null) {
            var fspec = this.QuorumRequirement.AsFieldSpec(conf.Child("quorumRequirement"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "quorumRequirement" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TprRequestedChangeManagedObjectEntry? SelectedObjects
        // GraphQL -> selectedObjects: TprRequestedChangeManagedObjectEntry (type)
        if (this.SelectedObjects != null) {
            var fspec = this.SelectedObjects.AsFieldSpec(conf.Child("selectedObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "selectedObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TprRequestedChangeTprRuleEntry? TprRules
        // GraphQL -> tprRules: TprRequestedChangeTprRuleEntry (type)
        if (this.TprRules != null) {
            var fspec = this.TprRules.AsFieldSpec(conf.Child("tprRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tprRules" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: TprRequestedChangeServiceAccountEntry (type)
        if (ec.Includes("exemptServiceAccounts",false))
        {
            if(this.ExemptServiceAccounts == null) {

                this.ExemptServiceAccounts = new TprRequestedChangeServiceAccountEntry();
                this.ExemptServiceAccounts.ApplyExploratoryFieldSpec(ec.NewChild("exemptServiceAccounts"));

            } else {

                this.ExemptServiceAccounts.ApplyExploratoryFieldSpec(ec.NewChild("exemptServiceAccounts"));

            }
        }
        else if (this.ExemptServiceAccounts != null && ec.Excludes("exemptServiceAccounts",false))
        {
            this.ExemptServiceAccounts = null;
        }
        //      C# -> TprRequestedChangeEntry? QuorumRequirement
        // GraphQL -> quorumRequirement: TprRequestedChangeEntry (type)
        if (ec.Includes("quorumRequirement",false))
        {
            if(this.QuorumRequirement == null) {

                this.QuorumRequirement = new TprRequestedChangeEntry();
                this.QuorumRequirement.ApplyExploratoryFieldSpec(ec.NewChild("quorumRequirement"));

            } else {

                this.QuorumRequirement.ApplyExploratoryFieldSpec(ec.NewChild("quorumRequirement"));

            }
        }
        else if (this.QuorumRequirement != null && ec.Excludes("quorumRequirement",false))
        {
            this.QuorumRequirement = null;
        }
        //      C# -> TprRequestedChangeManagedObjectEntry? SelectedObjects
        // GraphQL -> selectedObjects: TprRequestedChangeManagedObjectEntry (type)
        if (ec.Includes("selectedObjects",false))
        {
            if(this.SelectedObjects == null) {

                this.SelectedObjects = new TprRequestedChangeManagedObjectEntry();
                this.SelectedObjects.ApplyExploratoryFieldSpec(ec.NewChild("selectedObjects"));

            } else {

                this.SelectedObjects.ApplyExploratoryFieldSpec(ec.NewChild("selectedObjects"));

            }
        }
        else if (this.SelectedObjects != null && ec.Excludes("selectedObjects",false))
        {
            this.SelectedObjects = null;
        }
        //      C# -> TprRequestedChangeTprRuleEntry? TprRules
        // GraphQL -> tprRules: TprRequestedChangeTprRuleEntry (type)
        if (ec.Includes("tprRules",false))
        {
            if(this.TprRules == null) {

                this.TprRules = new TprRequestedChangeTprRuleEntry();
                this.TprRules.ApplyExploratoryFieldSpec(ec.NewChild("tprRules"));

            } else {

                this.TprRules.ApplyExploratoryFieldSpec(ec.NewChild("tprRules"));

            }
        }
        else if (this.TprRules != null && ec.Excludes("tprRules",false))
        {
            this.TprRules = null;
        }
    }


    #endregion

    } // class UpdateTprPolicyDataMangementObjectReqChangesTemplate
    
    #endregion

    public static class ListUpdateTprPolicyDataMangementObjectReqChangesTemplateExtensions
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
            this List<UpdateTprPolicyDataMangementObjectReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateTprPolicyDataMangementObjectReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateTprPolicyDataMangementObjectReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateTprPolicyDataMangementObjectReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateTprPolicyDataMangementObjectReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types