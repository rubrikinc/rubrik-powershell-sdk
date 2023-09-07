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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName != null) {
            s += ind + "templateName\n" ;
        }
        //      C# -> TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: TprRequestedChangeServiceAccountEntry (type)
        if (this.ExemptServiceAccounts != null) {
            var fspec = this.ExemptServiceAccounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "exemptServiceAccounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TprRequestedChangeManagedObjectEntry? SelectedObjects
        // GraphQL -> selectedObjects: TprRequestedChangeManagedObjectEntry (type)
        if (this.SelectedObjects != null) {
            var fspec = this.SelectedObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "selectedObjects {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TprRequestedChangeTprRuleEntry? TprRules
        // GraphQL -> tprRules: TprRequestedChangeTprRuleEntry (type)
        if (this.TprRules != null) {
            var fspec = this.TprRules.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tprRules {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        if (this.TemplateName == null && ec.Includes("templateName",true))
        {
            this.TemplateName = "FETCH";
        }
        //      C# -> TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: TprRequestedChangeServiceAccountEntry (type)
        if (this.ExemptServiceAccounts == null && ec.Includes("exemptServiceAccounts",false))
        {
            this.ExemptServiceAccounts = new TprRequestedChangeServiceAccountEntry();
            this.ExemptServiceAccounts.ApplyExploratoryFieldSpec(ec.NewChild("exemptServiceAccounts"));
        }
        //      C# -> TprRequestedChangeManagedObjectEntry? SelectedObjects
        // GraphQL -> selectedObjects: TprRequestedChangeManagedObjectEntry (type)
        if (this.SelectedObjects == null && ec.Includes("selectedObjects",false))
        {
            this.SelectedObjects = new TprRequestedChangeManagedObjectEntry();
            this.SelectedObjects.ApplyExploratoryFieldSpec(ec.NewChild("selectedObjects"));
        }
        //      C# -> TprRequestedChangeTprRuleEntry? TprRules
        // GraphQL -> tprRules: TprRequestedChangeTprRuleEntry (type)
        if (this.TprRules == null && ec.Includes("tprRules",false))
        {
            this.TprRules = new TprRequestedChangeTprRuleEntry();
            this.TprRules.ApplyExploratoryFieldSpec(ec.NewChild("tprRules"));
        }
    }


    #endregion

    } // class UpdateTprPolicyDataMangementObjectReqChangesTemplate
    
    #endregion

    public static class ListUpdateTprPolicyDataMangementObjectReqChangesTemplateExtensions
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
            this List<UpdateTprPolicyDataMangementObjectReqChangesTemplate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateTprPolicyDataMangementObjectReqChangesTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateTprPolicyDataMangementObjectReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UpdateTprPolicyDataMangementObjectReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types