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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region TprRequestDetail
    public class TprRequestDetail: BaseType
    {
        #region members

        //      C# -> RequestedChangesTemplate? RequestedChangesTemplate
        // GraphQL -> requestedChangesTemplate: RequestedChangesTemplate! (interface)
        [JsonProperty("requestedChangesTemplate")]
        public RequestedChangesTemplate? RequestedChangesTemplate { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? EditedPolicy
        // GraphQL -> editedPolicy: String (scalar)
        [JsonProperty("editedPolicy")]
        public System.String? EditedPolicy { get; set; }

        //      C# -> List<ClusterSummary>? Clusters
        // GraphQL -> clusters: [ClusterSummary!]! (type)
        [JsonProperty("clusters")]
        public List<ClusterSummary>? Clusters { get; set; }

        //      C# -> List<ManagedObjectSummary>? Objects
        // GraphQL -> objects: [ManagedObjectSummary!]! (type)
        [JsonProperty("objects")]
        public List<ManagedObjectSummary>? Objects { get; set; }

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

    public TprRequestDetail Set(
        RequestedChangesTemplate? RequestedChangesTemplate = null,
        System.String? Description = null,
        System.String? EditedPolicy = null,
        List<ClusterSummary>? Clusters = null,
        List<ManagedObjectSummary>? Objects = null,
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
        if ( EditedPolicy != null ) {
            this.EditedPolicy = EditedPolicy;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
        }
        if ( Objects != null ) {
            this.Objects = Objects;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> RequestedChangesTemplate? RequestedChangesTemplate
        // GraphQL -> requestedChangesTemplate: RequestedChangesTemplate! (interface)
        if (this.RequestedChangesTemplate != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.RequestedChangesTemplate).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "requestedChangesTemplate {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? EditedPolicy
        // GraphQL -> editedPolicy: String (scalar)
        if (this.EditedPolicy != null) {
            s += ind + "editedPolicy\n" ;
        }
        //      C# -> List<ClusterSummary>? Clusters
        // GraphQL -> clusters: [ClusterSummary!]! (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusters {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ManagedObjectSummary>? Objects
        // GraphQL -> objects: [ManagedObjectSummary!]! (type)
        if (this.Objects != null) {
            var fspec = this.Objects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objects {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        if (this.SlaDomain != null) {
            var fspec = this.SlaDomain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaDomain {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaDomainSummary? TargetSlaDomain
        // GraphQL -> targetSlaDomain: SlaDomainSummary (type)
        if (this.TargetSlaDomain != null) {
            var fspec = this.TargetSlaDomain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetSlaDomain {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RequestedChangesTemplate? RequestedChangesTemplate
        // GraphQL -> requestedChangesTemplate: RequestedChangesTemplate! (interface)
        if (this.RequestedChangesTemplate == null && Exploration.Includes(parent + ".requestedChangesTemplate"))
        {
            var impls = new List<RequestedChangesTemplate>();
            impls.ApplyExploratoryFieldSpec(parent + ".requestedChangesTemplate");
            this.RequestedChangesTemplate = (RequestedChangesTemplate)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? EditedPolicy
        // GraphQL -> editedPolicy: String (scalar)
        if (this.EditedPolicy == null && Exploration.Includes(parent + ".editedPolicy", true))
        {
            this.EditedPolicy = "FETCH";
        }
        //      C# -> List<ClusterSummary>? Clusters
        // GraphQL -> clusters: [ClusterSummary!]! (type)
        if (this.Clusters == null && Exploration.Includes(parent + ".clusters"))
        {
            this.Clusters = new List<ClusterSummary>();
            this.Clusters.ApplyExploratoryFieldSpec(parent + ".clusters");
        }
        //      C# -> List<ManagedObjectSummary>? Objects
        // GraphQL -> objects: [ManagedObjectSummary!]! (type)
        if (this.Objects == null && Exploration.Includes(parent + ".objects"))
        {
            this.Objects = new List<ManagedObjectSummary>();
            this.Objects.ApplyExploratoryFieldSpec(parent + ".objects");
        }
        //      C# -> SlaDomainSummary? SlaDomain
        // GraphQL -> slaDomain: SlaDomainSummary (type)
        if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
        {
            this.SlaDomain = new SlaDomainSummary();
            this.SlaDomain.ApplyExploratoryFieldSpec(parent + ".slaDomain");
        }
        //      C# -> SlaDomainSummary? TargetSlaDomain
        // GraphQL -> targetSlaDomain: SlaDomainSummary (type)
        if (this.TargetSlaDomain == null && Exploration.Includes(parent + ".targetSlaDomain"))
        {
            this.TargetSlaDomain = new SlaDomainSummary();
            this.TargetSlaDomain.ApplyExploratoryFieldSpec(parent + ".targetSlaDomain");
        }
    }


    #endregion

    } // class TprRequestDetail
    
    #endregion

    public static class ListTprRequestDetailExtensions
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
            this List<TprRequestDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types