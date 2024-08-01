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
        //      C# -> TprRequestedChangeClusterSummaryEntry? SelectedClusters
        // GraphQL -> selectedClusters: TprRequestedChangeClusterSummaryEntry (type)
        if (this.SelectedClusters != null) {
            var fspec = this.SelectedClusters.AsFieldSpec(conf.Child("selectedClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "selectedClusters" + " " + "{\n" + fspec + ind + "}\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        //      C# -> TprRequestedChangeClusterSummaryEntry? SelectedClusters
        // GraphQL -> selectedClusters: TprRequestedChangeClusterSummaryEntry (type)
        if (ec.Includes("selectedClusters",false))
        {
            if(this.SelectedClusters == null) {

                this.SelectedClusters = new TprRequestedChangeClusterSummaryEntry();
                this.SelectedClusters.ApplyExploratoryFieldSpec(ec.NewChild("selectedClusters"));

            } else {

                this.SelectedClusters.ApplyExploratoryFieldSpec(ec.NewChild("selectedClusters"));

            }
        }
        else if (this.SelectedClusters != null && ec.Excludes("selectedClusters",false))
        {
            this.SelectedClusters = null;
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

    } // class UpdateTprPolicyDataMangementClusterReqChangesTemplate
    
    #endregion

    public static class ListUpdateTprPolicyDataMangementClusterReqChangesTemplateExtensions
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
            this List<UpdateTprPolicyDataMangementClusterReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateTprPolicyDataMangementClusterReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<UpdateTprPolicyDataMangementClusterReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types