// UpdateTprPolicyDataMangementClusterReqChangesTemplate.cs
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
    #region UpdateTprPolicyDataMangementClusterReqChangesTemplate
 
    public class UpdateTprPolicyDataMangementClusterReqChangesTemplate: BaseType, RequestedChangesTemplate
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

        //      C# -> TprRequestedChangeClusterSummaryEntry? SelectedClusters
        // GraphQL -> selectedClusters: TprRequestedChangeClusterSummaryEntry (type)
        [JsonProperty("selectedClusters")]
        public TprRequestedChangeClusterSummaryEntry? SelectedClusters { get; set; }

        //      C# -> TprRequestedChangeTprRuleEntry? TprRules
        // GraphQL -> tprRules: TprRequestedChangeTprRuleEntry (type)
        [JsonProperty("tprRules")]
        public TprRequestedChangeTprRuleEntry? TprRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateTprPolicyDataMangementClusterReqChangesTemplate";
    }

    public UpdateTprPolicyDataMangementClusterReqChangesTemplate Set(
        System.String? TemplateName = null,
        TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts = null,
        TprRequestedChangeClusterSummaryEntry? SelectedClusters = null,
        TprRequestedChangeTprRuleEntry? TprRules = null
    ) 
    {
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( ExemptServiceAccounts != null ) {
            this.ExemptServiceAccounts = ExemptServiceAccounts;
        }
        if ( SelectedClusters != null ) {
            this.SelectedClusters = SelectedClusters;
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
        //      C# -> TprRequestedChangeClusterSummaryEntry? SelectedClusters
        // GraphQL -> selectedClusters: TprRequestedChangeClusterSummaryEntry (type)
        if (this.SelectedClusters != null) {
            var fspec = this.SelectedClusters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "selectedClusters {\n" + fspec + ind + "}\n" ;
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
        //      C# -> TprRequestedChangeClusterSummaryEntry? SelectedClusters
        // GraphQL -> selectedClusters: TprRequestedChangeClusterSummaryEntry (type)
        if (this.SelectedClusters == null && ec.Includes("selectedClusters",false))
        {
            this.SelectedClusters = new TprRequestedChangeClusterSummaryEntry();
            this.SelectedClusters.ApplyExploratoryFieldSpec(ec.NewChild("selectedClusters"));
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

    } // class UpdateTprPolicyDataMangementClusterReqChangesTemplate
    
    #endregion

    public static class ListUpdateTprPolicyDataMangementClusterReqChangesTemplateExtensions
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
            this List<UpdateTprPolicyDataMangementClusterReqChangesTemplate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateTprPolicyDataMangementClusterReqChangesTemplate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateTprPolicyDataMangementClusterReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UpdateTprPolicyDataMangementClusterReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types