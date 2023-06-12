// VirtualMachineSummary.cs
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
    #region VirtualMachineSummary
    public class VirtualMachineSummary: BaseType
    {
        #region members

        //      C# -> VirtualMachineSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: VirtualMachineSummarySnapshotConsistencyMandate! (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public VirtualMachineSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: String! (scalar)
        [JsonProperty("guestCredentialAuthorizationStatus")]
        public System.String? GuestCredentialAuthorizationStatus { get; set; }

        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String (scalar)
        [JsonProperty("guestOsName")]
        public System.String? GuestOsName { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? InstanceUuid
        // GraphQL -> instanceUuid: String (scalar)
        [JsonProperty("instanceUuid")]
        public System.String? InstanceUuid { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Boolean? IsReplicationEnabled
        // GraphQL -> isReplicationEnabled: Boolean! (scalar)
        [JsonProperty("isReplicationEnabled")]
        public System.Boolean? IsReplicationEnabled { get; set; }

        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        [JsonProperty("moid")]
        public System.String? Moid { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        [JsonProperty("protectionDate")]
        public DateTime? ProtectionDate { get; set; }

        //      C# -> System.Boolean? ToolsInstalled
        // GraphQL -> toolsInstalled: Boolean (scalar)
        [JsonProperty("toolsInstalled")]
        public System.Boolean? ToolsInstalled { get; set; }

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        [JsonProperty("vmwareToolsInstalled")]
        public System.Boolean? VmwareToolsInstalled { get; set; }

        //      C# -> AdvancedVirtualMachineSummary? AdvancedSummary
        // GraphQL -> advancedSummary: AdvancedVirtualMachineSummary (type)
        [JsonProperty("advancedSummary")]
        public AdvancedVirtualMachineSummary? AdvancedSummary { get; set; }

        //      C# -> CdmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: CdmAgentStatus (type)
        [JsonProperty("agentStatus")]
        public CdmAgentStatus? AgentStatus { get; set; }

        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        [JsonProperty("cloudInstantiationSpec")]
        public CloudInstantiationSpec? CloudInstantiationSpec { get; set; }

        //      C# -> List<VmPathPoint>? FolderPath
        // GraphQL -> folderPath: [VmPathPoint!]! (type)
        [JsonProperty("folderPath")]
        public List<VmPathPoint>? FolderPath { get; set; }

        //      C# -> List<VmPathPoint>? InfraPath
        // GraphQL -> infraPath: [VmPathPoint!]! (type)
        [JsonProperty("infraPath")]
        public List<VmPathPoint>? InfraPath { get; set; }

        //      C# -> ParentAppInfo? ParentAppInfo
        // GraphQL -> parentAppInfo: ParentAppInfo (type)
        [JsonProperty("parentAppInfo")]
        public ParentAppInfo? ParentAppInfo { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }


        #endregion

    #region methods

    public VirtualMachineSummary Set(
        VirtualMachineSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate = null,
        System.String? ClusterName = null,
        System.String? GuestCredentialAuthorizationStatus = null,
        System.String? GuestOsName = null,
        System.String? HostId = null,
        System.String? HostName = null,
        System.String? InstanceUuid = null,
        System.String? IpAddress = null,
        System.Boolean? IsRelic = null,
        System.Boolean? IsReplicationEnabled = null,
        System.String? Moid = null,
        System.String? PowerStatus = null,
        DateTime? ProtectionDate = null,
        System.Boolean? ToolsInstalled = null,
        System.String? VcenterId = null,
        System.Boolean? VmwareToolsInstalled = null,
        AdvancedVirtualMachineSummary? AdvancedSummary = null,
        CdmAgentStatus? AgentStatus = null,
        CloudInstantiationSpec? CloudInstantiationSpec = null,
        List<VmPathPoint>? FolderPath = null,
        List<VmPathPoint>? InfraPath = null,
        ParentAppInfo? ParentAppInfo = null,
        CdmWorkload? Snappable = null
    ) 
    {
        if ( SnapshotConsistencyMandate != null ) {
            this.SnapshotConsistencyMandate = SnapshotConsistencyMandate;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( GuestCredentialAuthorizationStatus != null ) {
            this.GuestCredentialAuthorizationStatus = GuestCredentialAuthorizationStatus;
        }
        if ( GuestOsName != null ) {
            this.GuestOsName = GuestOsName;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( InstanceUuid != null ) {
            this.InstanceUuid = InstanceUuid;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( IsReplicationEnabled != null ) {
            this.IsReplicationEnabled = IsReplicationEnabled;
        }
        if ( Moid != null ) {
            this.Moid = Moid;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( ToolsInstalled != null ) {
            this.ToolsInstalled = ToolsInstalled;
        }
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( VmwareToolsInstalled != null ) {
            this.VmwareToolsInstalled = VmwareToolsInstalled;
        }
        if ( AdvancedSummary != null ) {
            this.AdvancedSummary = AdvancedSummary;
        }
        if ( AgentStatus != null ) {
            this.AgentStatus = AgentStatus;
        }
        if ( CloudInstantiationSpec != null ) {
            this.CloudInstantiationSpec = CloudInstantiationSpec;
        }
        if ( FolderPath != null ) {
            this.FolderPath = FolderPath;
        }
        if ( InfraPath != null ) {
            this.InfraPath = InfraPath;
        }
        if ( ParentAppInfo != null ) {
            this.ParentAppInfo = ParentAppInfo;
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
        //      C# -> VirtualMachineSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: VirtualMachineSummarySnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate != null) {
            s += ind + "snapshotConsistencyMandate\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: String! (scalar)
        if (this.GuestCredentialAuthorizationStatus != null) {
            s += ind + "guestCredentialAuthorizationStatus\n" ;
        }
        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String (scalar)
        if (this.GuestOsName != null) {
            s += ind + "guestOsName\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
        }
        //      C# -> System.String? InstanceUuid
        // GraphQL -> instanceUuid: String (scalar)
        if (this.InstanceUuid != null) {
            s += ind + "instanceUuid\n" ;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress != null) {
            s += ind + "ipAddress\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.Boolean? IsReplicationEnabled
        // GraphQL -> isReplicationEnabled: Boolean! (scalar)
        if (this.IsReplicationEnabled != null) {
            s += ind + "isReplicationEnabled\n" ;
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (this.Moid != null) {
            s += ind + "moid\n" ;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus != null) {
            s += ind + "powerStatus\n" ;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            s += ind + "protectionDate\n" ;
        }
        //      C# -> System.Boolean? ToolsInstalled
        // GraphQL -> toolsInstalled: Boolean (scalar)
        if (this.ToolsInstalled != null) {
            s += ind + "toolsInstalled\n" ;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (this.VcenterId != null) {
            s += ind + "vcenterId\n" ;
        }
        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        if (this.VmwareToolsInstalled != null) {
            s += ind + "vmwareToolsInstalled\n" ;
        }
        //      C# -> AdvancedVirtualMachineSummary? AdvancedSummary
        // GraphQL -> advancedSummary: AdvancedVirtualMachineSummary (type)
        if (this.AdvancedSummary != null) {
            var fspec = this.AdvancedSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "advancedSummary {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> List<VmPathPoint>? FolderPath
        // GraphQL -> folderPath: [VmPathPoint!]! (type)
        if (this.FolderPath != null) {
            var fspec = this.FolderPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "folderPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VmPathPoint>? InfraPath
        // GraphQL -> infraPath: [VmPathPoint!]! (type)
        if (this.InfraPath != null) {
            var fspec = this.InfraPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "infraPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ParentAppInfo? ParentAppInfo
        // GraphQL -> parentAppInfo: ParentAppInfo (type)
        if (this.ParentAppInfo != null) {
            var fspec = this.ParentAppInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "parentAppInfo {\n" + fspec + ind + "}\n" ;
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
        //      C# -> VirtualMachineSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: VirtualMachineSummarySnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate == null && Exploration.Includes(parent + ".snapshotConsistencyMandate", true))
        {
            this.SnapshotConsistencyMandate = new VirtualMachineSummarySnapshotConsistencyMandate();
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.String? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: String! (scalar)
        if (this.GuestCredentialAuthorizationStatus == null && Exploration.Includes(parent + ".guestCredentialAuthorizationStatus", true))
        {
            this.GuestCredentialAuthorizationStatus = "FETCH";
        }
        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String (scalar)
        if (this.GuestOsName == null && Exploration.Includes(parent + ".guestOsName", true))
        {
            this.GuestOsName = "FETCH";
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = "FETCH";
        }
        //      C# -> System.String? InstanceUuid
        // GraphQL -> instanceUuid: String (scalar)
        if (this.InstanceUuid == null && Exploration.Includes(parent + ".instanceUuid", true))
        {
            this.InstanceUuid = "FETCH";
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress", true))
        {
            this.IpAddress = "FETCH";
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.Boolean? IsReplicationEnabled
        // GraphQL -> isReplicationEnabled: Boolean! (scalar)
        if (this.IsReplicationEnabled == null && Exploration.Includes(parent + ".isReplicationEnabled", true))
        {
            this.IsReplicationEnabled = true;
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (this.Moid == null && Exploration.Includes(parent + ".moid", true))
        {
            this.Moid = "FETCH";
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus", true))
        {
            this.PowerStatus = "FETCH";
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate", true))
        {
            this.ProtectionDate = new DateTime();
        }
        //      C# -> System.Boolean? ToolsInstalled
        // GraphQL -> toolsInstalled: Boolean (scalar)
        if (this.ToolsInstalled == null && Exploration.Includes(parent + ".toolsInstalled", true))
        {
            this.ToolsInstalled = true;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (this.VcenterId == null && Exploration.Includes(parent + ".vcenterId", true))
        {
            this.VcenterId = "FETCH";
        }
        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        if (this.VmwareToolsInstalled == null && Exploration.Includes(parent + ".vmwareToolsInstalled", true))
        {
            this.VmwareToolsInstalled = true;
        }
        //      C# -> AdvancedVirtualMachineSummary? AdvancedSummary
        // GraphQL -> advancedSummary: AdvancedVirtualMachineSummary (type)
        if (this.AdvancedSummary == null && Exploration.Includes(parent + ".advancedSummary"))
        {
            this.AdvancedSummary = new AdvancedVirtualMachineSummary();
            this.AdvancedSummary.ApplyExploratoryFieldSpec(parent + ".advancedSummary");
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
        //      C# -> List<VmPathPoint>? FolderPath
        // GraphQL -> folderPath: [VmPathPoint!]! (type)
        if (this.FolderPath == null && Exploration.Includes(parent + ".folderPath"))
        {
            this.FolderPath = new List<VmPathPoint>();
            this.FolderPath.ApplyExploratoryFieldSpec(parent + ".folderPath");
        }
        //      C# -> List<VmPathPoint>? InfraPath
        // GraphQL -> infraPath: [VmPathPoint!]! (type)
        if (this.InfraPath == null && Exploration.Includes(parent + ".infraPath"))
        {
            this.InfraPath = new List<VmPathPoint>();
            this.InfraPath.ApplyExploratoryFieldSpec(parent + ".infraPath");
        }
        //      C# -> ParentAppInfo? ParentAppInfo
        // GraphQL -> parentAppInfo: ParentAppInfo (type)
        if (this.ParentAppInfo == null && Exploration.Includes(parent + ".parentAppInfo"))
        {
            this.ParentAppInfo = new ParentAppInfo();
            this.ParentAppInfo.ApplyExploratoryFieldSpec(parent + ".parentAppInfo");
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

    } // class VirtualMachineSummary
    
    #endregion

    public static class ListVirtualMachineSummaryExtensions
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
            this List<VirtualMachineSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VirtualMachineSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VirtualMachineSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types