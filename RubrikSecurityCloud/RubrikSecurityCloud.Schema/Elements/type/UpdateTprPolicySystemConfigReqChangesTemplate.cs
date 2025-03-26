// UpdateTprPolicySystemConfigReqChangesTemplate.cs
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
    #region UpdateTprPolicySystemConfigReqChangesTemplate
 
    public class UpdateTprPolicySystemConfigReqChangesTemplate: BaseType, RequestedChangesTemplate
    {
        #region members

        //      C# -> System.String? TemplateName
        // GraphQL -> templateName: String! (scalar)
        [JsonProperty("templateName")]
        public System.String? TemplateName { get; set; }

        //      C# -> TprRequestedChangeTprRuleEntry? ClusterTprRules
        // GraphQL -> clusterTprRules: TprRequestedChangeTprRuleEntry (type)
        [JsonProperty("clusterTprRules")]
        public TprRequestedChangeTprRuleEntry? ClusterTprRules { get; set; }

        //      C# -> TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts
        // GraphQL -> exemptServiceAccounts: TprRequestedChangeServiceAccountEntry (type)
        [JsonProperty("exemptServiceAccounts")]
        public TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts { get; set; }

        //      C# -> TprRequestedChangeTprRuleEntry? GlobalTprRules
        // GraphQL -> globalTprRules: TprRequestedChangeTprRuleEntry (type)
        [JsonProperty("globalTprRules")]
        public TprRequestedChangeTprRuleEntry? GlobalTprRules { get; set; }

        //      C# -> TprRequestedChangeEntry? QuorumRequirement
        // GraphQL -> quorumRequirement: TprRequestedChangeEntry (type)
        [JsonProperty("quorumRequirement")]
        public TprRequestedChangeEntry? QuorumRequirement { get; set; }

        //      C# -> TprRequestedChangeClusterSummaryEntry? SelectedClusters
        // GraphQL -> selectedClusters: TprRequestedChangeClusterSummaryEntry (type)
        [JsonProperty("selectedClusters")]
        public TprRequestedChangeClusterSummaryEntry? SelectedClusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateTprPolicySystemConfigReqChangesTemplate";
    }

    public UpdateTprPolicySystemConfigReqChangesTemplate Set(
        System.String? TemplateName = null,
        TprRequestedChangeTprRuleEntry? ClusterTprRules = null,
        TprRequestedChangeServiceAccountEntry? ExemptServiceAccounts = null,
        TprRequestedChangeTprRuleEntry? GlobalTprRules = null,
        TprRequestedChangeEntry? QuorumRequirement = null,
        TprRequestedChangeClusterSummaryEntry? SelectedClusters = null
    ) 
    {
        if ( TemplateName != null ) {
            this.TemplateName = TemplateName;
        }
        if ( ClusterTprRules != null ) {
            this.ClusterTprRules = ClusterTprRules;
        }
        if ( ExemptServiceAccounts != null ) {
            this.ExemptServiceAccounts = ExemptServiceAccounts;
        }
        if ( GlobalTprRules != null ) {
            this.GlobalTprRules = GlobalTprRules;
        }
        if ( QuorumRequirement != null ) {
            this.QuorumRequirement = QuorumRequirement;
        }
        if ( SelectedClusters != null ) {
            this.SelectedClusters = SelectedClusters;
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
        //      C# -> TprRequestedChangeTprRuleEntry? ClusterTprRules
        // GraphQL -> clusterTprRules: TprRequestedChangeTprRuleEntry (type)
        if (this.ClusterTprRules != null) {
            var fspec = this.ClusterTprRules.AsFieldSpec(conf.Child("clusterTprRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterTprRules" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> TprRequestedChangeTprRuleEntry? GlobalTprRules
        // GraphQL -> globalTprRules: TprRequestedChangeTprRuleEntry (type)
        if (this.GlobalTprRules != null) {
            var fspec = this.GlobalTprRules.AsFieldSpec(conf.Child("globalTprRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "globalTprRules" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> TprRequestedChangeTprRuleEntry? ClusterTprRules
        // GraphQL -> clusterTprRules: TprRequestedChangeTprRuleEntry (type)
        if (ec.Includes("clusterTprRules",false))
        {
            if(this.ClusterTprRules == null) {

                this.ClusterTprRules = new TprRequestedChangeTprRuleEntry();
                this.ClusterTprRules.ApplyExploratoryFieldSpec(ec.NewChild("clusterTprRules"));

            } else {

                this.ClusterTprRules.ApplyExploratoryFieldSpec(ec.NewChild("clusterTprRules"));

            }
        }
        else if (this.ClusterTprRules != null && ec.Excludes("clusterTprRules",false))
        {
            this.ClusterTprRules = null;
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
        //      C# -> TprRequestedChangeTprRuleEntry? GlobalTprRules
        // GraphQL -> globalTprRules: TprRequestedChangeTprRuleEntry (type)
        if (ec.Includes("globalTprRules",false))
        {
            if(this.GlobalTprRules == null) {

                this.GlobalTprRules = new TprRequestedChangeTprRuleEntry();
                this.GlobalTprRules.ApplyExploratoryFieldSpec(ec.NewChild("globalTprRules"));

            } else {

                this.GlobalTprRules.ApplyExploratoryFieldSpec(ec.NewChild("globalTprRules"));

            }
        }
        else if (this.GlobalTprRules != null && ec.Excludes("globalTprRules",false))
        {
            this.GlobalTprRules = null;
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
    }


    #endregion

    } // class UpdateTprPolicySystemConfigReqChangesTemplate
    
    #endregion

    public static class ListUpdateTprPolicySystemConfigReqChangesTemplateExtensions
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
            this List<UpdateTprPolicySystemConfigReqChangesTemplate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateTprPolicySystemConfigReqChangesTemplate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateTprPolicySystemConfigReqChangesTemplate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateTprPolicySystemConfigReqChangesTemplate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateTprPolicySystemConfigReqChangesTemplate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types