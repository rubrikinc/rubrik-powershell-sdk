// TprRequestDetail.cs
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
    #region TprRequestDetail
    public class TprRequestDetail: BaseType
    {
        #region members

        //      C# -> RequestedChangesTemplate? RequestedChangesTemplate
        // GraphQL -> requestedChangesTemplate: RequestedChangesTemplate (interface)
        [JsonProperty("requestedChangesTemplate")]
        public RequestedChangesTemplate? RequestedChangesTemplate { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<ClusterSummary>? Clusters
        // GraphQL -> clusters: [ClusterSummary!]! (type)
        [JsonProperty("clusters")]
        public List<ClusterSummary>? Clusters { get; set; }

        //      C# -> TprPolicySummary? EditedPolicy
        // GraphQL -> editedPolicy: TprPolicySummary (type)
        [JsonProperty("editedPolicy")]
        public TprPolicySummary? EditedPolicy { get; set; }

        //      C# -> List<ManagedObjectSummary>? InventoryObjects
        // GraphQL -> inventoryObjects: [ManagedObjectSummary!]! (type)
        [JsonProperty("inventoryObjects")]
        public List<ManagedObjectSummary>? InventoryObjects { get; set; }

        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        [JsonProperty("slaDomain")]
        public SlaDomainSummary? SlaDomain { get; set; }

        //      C# -> SlaDomainSummary? TargetSlaDomain
        // GraphQL -> targetSlaDomain: SlaDomainSummary (type)
        [JsonProperty("targetSlaDomain")]
        public SlaDomainSummary? TargetSlaDomain { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestDetail";
    }

    public TprRequestDetail Set(
        RequestedChangesTemplate? RequestedChangesTemplate = null,
        System.String? Description = null,
        List<ClusterSummary>? Clusters = null,
        TprPolicySummary? EditedPolicy = null,
        List<ManagedObjectSummary>? InventoryObjects = null,
        SlaDomainSummary? SlaDomain = null,
        SlaDomainSummary? TargetSlaDomain = null
    ) 
    {
        if ( RequestedChangesTemplate != null ) {
            this.RequestedChangesTemplate = RequestedChangesTemplate;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
        }
        if ( EditedPolicy != null ) {
            this.EditedPolicy = EditedPolicy;
        }
        if ( InventoryObjects != null ) {
            this.InventoryObjects = InventoryObjects;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( TargetSlaDomain != null ) {
            this.TargetSlaDomain = TargetSlaDomain;
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
        //      C# -> RequestedChangesTemplate? RequestedChangesTemplate
        // GraphQL -> requestedChangesTemplate: RequestedChangesTemplate (interface)
        if (this.RequestedChangesTemplate != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.RequestedChangesTemplate, conf.Child("requestedChangesTemplate"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "requestedChangesTemplate" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> List<ClusterSummary>? Clusters
        // GraphQL -> clusters: [ClusterSummary!]! (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(conf.Child("clusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TprPolicySummary? EditedPolicy
        // GraphQL -> editedPolicy: TprPolicySummary (type)
        if (this.EditedPolicy != null) {
            var fspec = this.EditedPolicy.AsFieldSpec(conf.Child("editedPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "editedPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ManagedObjectSummary>? InventoryObjects
        // GraphQL -> inventoryObjects: [ManagedObjectSummary!]! (type)
        if (this.InventoryObjects != null) {
            var fspec = this.InventoryObjects.AsFieldSpec(conf.Child("inventoryObjects"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "inventoryObjects" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        if (this.SlaDomain != null) {
            var fspec = this.SlaDomain.AsFieldSpec(conf.Child("slaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaDomain" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaDomainSummary? TargetSlaDomain
        // GraphQL -> targetSlaDomain: SlaDomainSummary (type)
        if (this.TargetSlaDomain != null) {
            var fspec = this.TargetSlaDomain.AsFieldSpec(conf.Child("targetSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetSlaDomain" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RequestedChangesTemplate? RequestedChangesTemplate
        // GraphQL -> requestedChangesTemplate: RequestedChangesTemplate (interface)
        if (ec.Includes("requestedChangesTemplate",false))
        {
            if(this.RequestedChangesTemplate == null) {

                var impls = new List<RequestedChangesTemplate>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("requestedChangesTemplate"));
                this.RequestedChangesTemplate = (RequestedChangesTemplate)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<RequestedChangesTemplate>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("requestedChangesTemplate"));
                this.RequestedChangesTemplate = (RequestedChangesTemplate)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.RequestedChangesTemplate != null && ec.Excludes("requestedChangesTemplate",false))
        {
            this.RequestedChangesTemplate = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> List<ClusterSummary>? Clusters
        // GraphQL -> clusters: [ClusterSummary!]! (type)
        if (ec.Includes("clusters",false))
        {
            if(this.Clusters == null) {

                this.Clusters = new List<ClusterSummary>();
                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            } else {

                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            }
        }
        else if (this.Clusters != null && ec.Excludes("clusters",false))
        {
            this.Clusters = null;
        }
        //      C# -> TprPolicySummary? EditedPolicy
        // GraphQL -> editedPolicy: TprPolicySummary (type)
        if (ec.Includes("editedPolicy",false))
        {
            if(this.EditedPolicy == null) {

                this.EditedPolicy = new TprPolicySummary();
                this.EditedPolicy.ApplyExploratoryFieldSpec(ec.NewChild("editedPolicy"));

            } else {

                this.EditedPolicy.ApplyExploratoryFieldSpec(ec.NewChild("editedPolicy"));

            }
        }
        else if (this.EditedPolicy != null && ec.Excludes("editedPolicy",false))
        {
            this.EditedPolicy = null;
        }
        //      C# -> List<ManagedObjectSummary>? InventoryObjects
        // GraphQL -> inventoryObjects: [ManagedObjectSummary!]! (type)
        if (ec.Includes("inventoryObjects",false))
        {
            if(this.InventoryObjects == null) {

                this.InventoryObjects = new List<ManagedObjectSummary>();
                this.InventoryObjects.ApplyExploratoryFieldSpec(ec.NewChild("inventoryObjects"));

            } else {

                this.InventoryObjects.ApplyExploratoryFieldSpec(ec.NewChild("inventoryObjects"));

            }
        }
        else if (this.InventoryObjects != null && ec.Excludes("inventoryObjects",false))
        {
            this.InventoryObjects = null;
        }
        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        if (ec.Includes("slaDomain",false))
        {
            if(this.SlaDomain == null) {

                this.SlaDomain = new SlaDomainSummary();
                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            } else {

                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",false))
        {
            this.SlaDomain = null;
        }
        //      C# -> SlaDomainSummary? TargetSlaDomain
        // GraphQL -> targetSlaDomain: SlaDomainSummary (type)
        if (ec.Includes("targetSlaDomain",false))
        {
            if(this.TargetSlaDomain == null) {

                this.TargetSlaDomain = new SlaDomainSummary();
                this.TargetSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("targetSlaDomain"));

            } else {

                this.TargetSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("targetSlaDomain"));

            }
        }
        else if (this.TargetSlaDomain != null && ec.Excludes("targetSlaDomain",false))
        {
            this.TargetSlaDomain = null;
        }
    }


    #endregion

    } // class TprRequestDetail
    
    #endregion

    public static class ListTprRequestDetailExtensions
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
            this List<TprRequestDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprRequestDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprRequestDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types