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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "VirtualMachineSummary";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> VirtualMachineSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: VirtualMachineSummarySnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotConsistencyMandate\n" ;
            } else {
                s += ind + "snapshotConsistencyMandate\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: String! (scalar)
        if (this.GuestCredentialAuthorizationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "guestCredentialAuthorizationStatus\n" ;
            } else {
                s += ind + "guestCredentialAuthorizationStatus\n" ;
            }
        }
        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String (scalar)
        if (this.GuestOsName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "guestOsName\n" ;
            } else {
                s += ind + "guestOsName\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? InstanceUuid
        // GraphQL -> instanceUuid: String (scalar)
        if (this.InstanceUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceUuid\n" ;
            } else {
                s += ind + "instanceUuid\n" ;
            }
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.Boolean? IsReplicationEnabled
        // GraphQL -> isReplicationEnabled: Boolean! (scalar)
        if (this.IsReplicationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReplicationEnabled\n" ;
            } else {
                s += ind + "isReplicationEnabled\n" ;
            }
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (this.Moid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "moid\n" ;
            } else {
                s += ind + "moid\n" ;
            }
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "powerStatus\n" ;
            } else {
                s += ind + "powerStatus\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDate\n" ;
            } else {
                s += ind + "protectionDate\n" ;
            }
        }
        //      C# -> System.Boolean? ToolsInstalled
        // GraphQL -> toolsInstalled: Boolean (scalar)
        if (this.ToolsInstalled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "toolsInstalled\n" ;
            } else {
                s += ind + "toolsInstalled\n" ;
            }
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (this.VcenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterId\n" ;
            } else {
                s += ind + "vcenterId\n" ;
            }
        }
        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        if (this.VmwareToolsInstalled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmwareToolsInstalled\n" ;
            } else {
                s += ind + "vmwareToolsInstalled\n" ;
            }
        }
        //      C# -> AdvancedVirtualMachineSummary? AdvancedSummary
        // GraphQL -> advancedSummary: AdvancedVirtualMachineSummary (type)
        if (this.AdvancedSummary != null) {
            var fspec = this.AdvancedSummary.AsFieldSpec(conf.Child("advancedSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "advancedSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: CdmAgentStatus (type)
        if (this.AgentStatus != null) {
            var fspec = this.AgentStatus.AsFieldSpec(conf.Child("agentStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "agentStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (this.CloudInstantiationSpec != null) {
            var fspec = this.CloudInstantiationSpec.AsFieldSpec(conf.Child("cloudInstantiationSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudInstantiationSpec {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VmPathPoint>? FolderPath
        // GraphQL -> folderPath: [VmPathPoint!]! (type)
        if (this.FolderPath != null) {
            var fspec = this.FolderPath.AsFieldSpec(conf.Child("folderPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "folderPath {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VmPathPoint>? InfraPath
        // GraphQL -> infraPath: [VmPathPoint!]! (type)
        if (this.InfraPath != null) {
            var fspec = this.InfraPath.AsFieldSpec(conf.Child("infraPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "infraPath {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ParentAppInfo? ParentAppInfo
        // GraphQL -> parentAppInfo: ParentAppInfo (type)
        if (this.ParentAppInfo != null) {
            var fspec = this.ParentAppInfo.AsFieldSpec(conf.Child("parentAppInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "parentAppInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VirtualMachineSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: VirtualMachineSummarySnapshotConsistencyMandate! (enum)
        if (ec.Includes("snapshotConsistencyMandate",true))
        {
            if(this.SnapshotConsistencyMandate == null) {

                this.SnapshotConsistencyMandate = new VirtualMachineSummarySnapshotConsistencyMandate();

            } else {


            }
        }
        else if (this.SnapshotConsistencyMandate != null && ec.Excludes("snapshotConsistencyMandate",true))
        {
            this.SnapshotConsistencyMandate = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: String! (scalar)
        if (ec.Includes("guestCredentialAuthorizationStatus",true))
        {
            if(this.GuestCredentialAuthorizationStatus == null) {

                this.GuestCredentialAuthorizationStatus = "FETCH";

            } else {


            }
        }
        else if (this.GuestCredentialAuthorizationStatus != null && ec.Excludes("guestCredentialAuthorizationStatus",true))
        {
            this.GuestCredentialAuthorizationStatus = null;
        }
        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String (scalar)
        if (ec.Includes("guestOsName",true))
        {
            if(this.GuestOsName == null) {

                this.GuestOsName = "FETCH";

            } else {


            }
        }
        else if (this.GuestOsName != null && ec.Excludes("guestOsName",true))
        {
            this.GuestOsName = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? InstanceUuid
        // GraphQL -> instanceUuid: String (scalar)
        if (ec.Includes("instanceUuid",true))
        {
            if(this.InstanceUuid == null) {

                this.InstanceUuid = "FETCH";

            } else {


            }
        }
        else if (this.InstanceUuid != null && ec.Excludes("instanceUuid",true))
        {
            this.InstanceUuid = null;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.Boolean? IsReplicationEnabled
        // GraphQL -> isReplicationEnabled: Boolean! (scalar)
        if (ec.Includes("isReplicationEnabled",true))
        {
            if(this.IsReplicationEnabled == null) {

                this.IsReplicationEnabled = true;

            } else {


            }
        }
        else if (this.IsReplicationEnabled != null && ec.Excludes("isReplicationEnabled",true))
        {
            this.IsReplicationEnabled = null;
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (ec.Includes("moid",true))
        {
            if(this.Moid == null) {

                this.Moid = "FETCH";

            } else {


            }
        }
        else if (this.Moid != null && ec.Excludes("moid",true))
        {
            this.Moid = null;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (ec.Includes("powerStatus",true))
        {
            if(this.PowerStatus == null) {

                this.PowerStatus = "FETCH";

            } else {


            }
        }
        else if (this.PowerStatus != null && ec.Excludes("powerStatus",true))
        {
            this.PowerStatus = null;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (ec.Includes("protectionDate",true))
        {
            if(this.ProtectionDate == null) {

                this.ProtectionDate = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDate != null && ec.Excludes("protectionDate",true))
        {
            this.ProtectionDate = null;
        }
        //      C# -> System.Boolean? ToolsInstalled
        // GraphQL -> toolsInstalled: Boolean (scalar)
        if (ec.Includes("toolsInstalled",true))
        {
            if(this.ToolsInstalled == null) {

                this.ToolsInstalled = true;

            } else {


            }
        }
        else if (this.ToolsInstalled != null && ec.Excludes("toolsInstalled",true))
        {
            this.ToolsInstalled = null;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (ec.Includes("vcenterId",true))
        {
            if(this.VcenterId == null) {

                this.VcenterId = "FETCH";

            } else {


            }
        }
        else if (this.VcenterId != null && ec.Excludes("vcenterId",true))
        {
            this.VcenterId = null;
        }
        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        if (ec.Includes("vmwareToolsInstalled",true))
        {
            if(this.VmwareToolsInstalled == null) {

                this.VmwareToolsInstalled = true;

            } else {


            }
        }
        else if (this.VmwareToolsInstalled != null && ec.Excludes("vmwareToolsInstalled",true))
        {
            this.VmwareToolsInstalled = null;
        }
        //      C# -> AdvancedVirtualMachineSummary? AdvancedSummary
        // GraphQL -> advancedSummary: AdvancedVirtualMachineSummary (type)
        if (ec.Includes("advancedSummary",false))
        {
            if(this.AdvancedSummary == null) {

                this.AdvancedSummary = new AdvancedVirtualMachineSummary();
                this.AdvancedSummary.ApplyExploratoryFieldSpec(ec.NewChild("advancedSummary"));

            } else {

                this.AdvancedSummary.ApplyExploratoryFieldSpec(ec.NewChild("advancedSummary"));

            }
        }
        else if (this.AdvancedSummary != null && ec.Excludes("advancedSummary",false))
        {
            this.AdvancedSummary = null;
        }
        //      C# -> CdmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: CdmAgentStatus (type)
        if (ec.Includes("agentStatus",false))
        {
            if(this.AgentStatus == null) {

                this.AgentStatus = new CdmAgentStatus();
                this.AgentStatus.ApplyExploratoryFieldSpec(ec.NewChild("agentStatus"));

            } else {

                this.AgentStatus.ApplyExploratoryFieldSpec(ec.NewChild("agentStatus"));

            }
        }
        else if (this.AgentStatus != null && ec.Excludes("agentStatus",false))
        {
            this.AgentStatus = null;
        }
        //      C# -> CloudInstantiationSpec? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpec (type)
        if (ec.Includes("cloudInstantiationSpec",false))
        {
            if(this.CloudInstantiationSpec == null) {

                this.CloudInstantiationSpec = new CloudInstantiationSpec();
                this.CloudInstantiationSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudInstantiationSpec"));

            } else {

                this.CloudInstantiationSpec.ApplyExploratoryFieldSpec(ec.NewChild("cloudInstantiationSpec"));

            }
        }
        else if (this.CloudInstantiationSpec != null && ec.Excludes("cloudInstantiationSpec",false))
        {
            this.CloudInstantiationSpec = null;
        }
        //      C# -> List<VmPathPoint>? FolderPath
        // GraphQL -> folderPath: [VmPathPoint!]! (type)
        if (ec.Includes("folderPath",false))
        {
            if(this.FolderPath == null) {

                this.FolderPath = new List<VmPathPoint>();
                this.FolderPath.ApplyExploratoryFieldSpec(ec.NewChild("folderPath"));

            } else {

                this.FolderPath.ApplyExploratoryFieldSpec(ec.NewChild("folderPath"));

            }
        }
        else if (this.FolderPath != null && ec.Excludes("folderPath",false))
        {
            this.FolderPath = null;
        }
        //      C# -> List<VmPathPoint>? InfraPath
        // GraphQL -> infraPath: [VmPathPoint!]! (type)
        if (ec.Includes("infraPath",false))
        {
            if(this.InfraPath == null) {

                this.InfraPath = new List<VmPathPoint>();
                this.InfraPath.ApplyExploratoryFieldSpec(ec.NewChild("infraPath"));

            } else {

                this.InfraPath.ApplyExploratoryFieldSpec(ec.NewChild("infraPath"));

            }
        }
        else if (this.InfraPath != null && ec.Excludes("infraPath",false))
        {
            this.InfraPath = null;
        }
        //      C# -> ParentAppInfo? ParentAppInfo
        // GraphQL -> parentAppInfo: ParentAppInfo (type)
        if (ec.Includes("parentAppInfo",false))
        {
            if(this.ParentAppInfo == null) {

                this.ParentAppInfo = new ParentAppInfo();
                this.ParentAppInfo.ApplyExploratoryFieldSpec(ec.NewChild("parentAppInfo"));

            } else {

                this.ParentAppInfo.ApplyExploratoryFieldSpec(ec.NewChild("parentAppInfo"));

            }
        }
        else if (this.ParentAppInfo != null && ec.Excludes("parentAppInfo",false))
        {
            this.ParentAppInfo = null;
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            } else {

                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<VirtualMachineSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VirtualMachineSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VirtualMachineSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VirtualMachineSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types