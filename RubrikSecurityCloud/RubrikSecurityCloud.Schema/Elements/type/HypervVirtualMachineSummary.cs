// HypervVirtualMachineSummary.cs
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
    #region HypervVirtualMachineSummary
    public class HypervVirtualMachineSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        [JsonProperty("forceFull")]
        public System.Boolean? ForceFull { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> CdmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: CdmAgentStatus (type)
        [JsonProperty("agentStatus")]
        public CdmAgentStatus? AgentStatus { get; set; }

        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        [JsonProperty("cloudInstantiationSpec")]
        public CloudInstantiationSpec? CloudInstantiationSpec { get; set; }

        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        [JsonProperty("infraPath")]
        public List<ManagedHierarchyObjectAncestor>? InfraPath { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }


        #endregion

    #region methods

    public HypervVirtualMachineSummary Set(
        System.Boolean? ForceFull = null,
        System.String? HostId = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        CdmAgentStatus? AgentStatus = null,
        CloudInstantiationSpec? CloudInstantiationSpec = null,
        List<ManagedHierarchyObjectAncestor>? InfraPath = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        CdmWorkload? Snappable = null
    ) 
    {
        if ( ForceFull != null ) {
            this.ForceFull = ForceFull;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( AgentStatus != null ) {
            this.AgentStatus = AgentStatus;
        }
        if ( CloudInstantiationSpec != null ) {
            this.CloudInstantiationSpec = CloudInstantiationSpec;
        }
        if ( InfraPath != null ) {
            this.InfraPath = InfraPath;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        if (this.ForceFull != null) {
            s += ind + "forceFull\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> CdmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: CdmAgentStatus (type)
        if (this.AgentStatus != null) {
            var fspec = this.AgentStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "agentStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (this.CloudInstantiationSpec != null) {
            var fspec = this.CloudInstantiationSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudInstantiationSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (this.InfraPath != null) {
            var fspec = this.InfraPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "infraPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        if (this.ForceFull == null && Exploration.Includes(parent + ".forceFull", true))
        {
            this.ForceFull = true;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> CdmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: CdmAgentStatus (type)
        if (this.AgentStatus == null && Exploration.Includes(parent + ".agentStatus"))
        {
            this.AgentStatus = new CdmAgentStatus();
            this.AgentStatus.ApplyExploratoryFieldSpec(parent + ".agentStatus");
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (this.CloudInstantiationSpec == null && Exploration.Includes(parent + ".cloudInstantiationSpec"))
        {
            this.CloudInstantiationSpec = new CloudInstantiationSpec();
            this.CloudInstantiationSpec.ApplyExploratoryFieldSpec(parent + ".cloudInstantiationSpec");
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (this.InfraPath == null && Exploration.Includes(parent + ".infraPath"))
        {
            this.InfraPath = new List<ManagedHierarchyObjectAncestor>();
            this.InfraPath.ApplyExploratoryFieldSpec(parent + ".infraPath");
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
        {
            this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
            this.PendingSlaDomain.ApplyExploratoryFieldSpec(parent + ".pendingSlaDomain");
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
        {
            this.Snappable = new CdmWorkload();
            this.Snappable.ApplyExploratoryFieldSpec(parent + ".snappable");
        }
    }


    #endregion

    } // class HypervVirtualMachineSummary
    
    #endregion

    public static class ListHypervVirtualMachineSummaryExtensions
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
            this List<HypervVirtualMachineSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types