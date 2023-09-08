// CdpVmInfo.cs
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
    #region CdpVmInfo
    public class CdpVmInfo: BaseType
    {
        #region members

        //      C# -> CdpLocalStatus? CdpLocalStatus
        // GraphQL -> cdpLocalStatus: CdpLocalStatus (enum)
        [JsonProperty("cdpLocalStatus")]
        public CdpLocalStatus? CdpLocalStatus { get; set; }

        //      C# -> CdpReplicationStatus? CdpReplicationStatus
        // GraphQL -> cdpReplicationStatus: CdpReplicationStatus (enum)
        [JsonProperty("cdpReplicationStatus")]
        public CdpReplicationStatus? CdpReplicationStatus { get; set; }

        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        [JsonProperty("ioFilterStatus")]
        public IoFilterStatus? IoFilterStatus { get; set; }

        //      C# -> DateTime? LatestSnapshotTime
        // GraphQL -> latestSnapshotTime: DateTime (scalar)
        [JsonProperty("latestSnapshotTime")]
        public DateTime? LatestSnapshotTime { get; set; }

        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String! (scalar)
        [JsonProperty("replicationTarget")]
        public System.String? ReplicationTarget { get; set; }

        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        [JsonProperty("slaDomainName")]
        public System.String? SlaDomainName { get; set; }

        //      C# -> System.String? SourceCluster
        // GraphQL -> sourceCluster: String! (scalar)
        [JsonProperty("sourceCluster")]
        public System.String? SourceCluster { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> System.String? VmLocation
        // GraphQL -> vmLocation: String! (scalar)
        [JsonProperty("vmLocation")]
        public System.String? VmLocation { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdpVmInfo";
    }

    public CdpVmInfo Set(
        CdpLocalStatus? CdpLocalStatus = null,
        CdpReplicationStatus? CdpReplicationStatus = null,
        IoFilterStatus? IoFilterStatus = null,
        DateTime? LatestSnapshotTime = null,
        System.String? ReplicationTarget = null,
        System.String? SlaDomainName = null,
        System.String? SourceCluster = null,
        System.String? VmId = null,
        System.String? VmLocation = null,
        System.String? VmName = null
    ) 
    {
        if ( CdpLocalStatus != null ) {
            this.CdpLocalStatus = CdpLocalStatus;
        }
        if ( CdpReplicationStatus != null ) {
            this.CdpReplicationStatus = CdpReplicationStatus;
        }
        if ( IoFilterStatus != null ) {
            this.IoFilterStatus = IoFilterStatus;
        }
        if ( LatestSnapshotTime != null ) {
            this.LatestSnapshotTime = LatestSnapshotTime;
        }
        if ( ReplicationTarget != null ) {
            this.ReplicationTarget = ReplicationTarget;
        }
        if ( SlaDomainName != null ) {
            this.SlaDomainName = SlaDomainName;
        }
        if ( SourceCluster != null ) {
            this.SourceCluster = SourceCluster;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
        }
        if ( VmLocation != null ) {
            this.VmLocation = VmLocation;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
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
        //      C# -> CdpLocalStatus? CdpLocalStatus
        // GraphQL -> cdpLocalStatus: CdpLocalStatus (enum)
        if (this.CdpLocalStatus != null) {
            s += ind + "cdpLocalStatus\n" ;
        }
        //      C# -> CdpReplicationStatus? CdpReplicationStatus
        // GraphQL -> cdpReplicationStatus: CdpReplicationStatus (enum)
        if (this.CdpReplicationStatus != null) {
            s += ind + "cdpReplicationStatus\n" ;
        }
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (this.IoFilterStatus != null) {
            s += ind + "ioFilterStatus\n" ;
        }
        //      C# -> DateTime? LatestSnapshotTime
        // GraphQL -> latestSnapshotTime: DateTime (scalar)
        if (this.LatestSnapshotTime != null) {
            s += ind + "latestSnapshotTime\n" ;
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String! (scalar)
        if (this.ReplicationTarget != null) {
            s += ind + "replicationTarget\n" ;
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName != null) {
            s += ind + "slaDomainName\n" ;
        }
        //      C# -> System.String? SourceCluster
        // GraphQL -> sourceCluster: String! (scalar)
        if (this.SourceCluster != null) {
            s += ind + "sourceCluster\n" ;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            s += ind + "vmId\n" ;
        }
        //      C# -> System.String? VmLocation
        // GraphQL -> vmLocation: String! (scalar)
        if (this.VmLocation != null) {
            s += ind + "vmLocation\n" ;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            s += ind + "vmName\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdpLocalStatus? CdpLocalStatus
        // GraphQL -> cdpLocalStatus: CdpLocalStatus (enum)
        if (this.CdpLocalStatus == null && ec.Includes("cdpLocalStatus",true))
        {
            this.CdpLocalStatus = new CdpLocalStatus();
        }
        //      C# -> CdpReplicationStatus? CdpReplicationStatus
        // GraphQL -> cdpReplicationStatus: CdpReplicationStatus (enum)
        if (this.CdpReplicationStatus == null && ec.Includes("cdpReplicationStatus",true))
        {
            this.CdpReplicationStatus = new CdpReplicationStatus();
        }
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (this.IoFilterStatus == null && ec.Includes("ioFilterStatus",true))
        {
            this.IoFilterStatus = new IoFilterStatus();
        }
        //      C# -> DateTime? LatestSnapshotTime
        // GraphQL -> latestSnapshotTime: DateTime (scalar)
        if (this.LatestSnapshotTime == null && ec.Includes("latestSnapshotTime",true))
        {
            this.LatestSnapshotTime = new DateTime();
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String! (scalar)
        if (this.ReplicationTarget == null && ec.Includes("replicationTarget",true))
        {
            this.ReplicationTarget = "FETCH";
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName == null && ec.Includes("slaDomainName",true))
        {
            this.SlaDomainName = "FETCH";
        }
        //      C# -> System.String? SourceCluster
        // GraphQL -> sourceCluster: String! (scalar)
        if (this.SourceCluster == null && ec.Includes("sourceCluster",true))
        {
            this.SourceCluster = "FETCH";
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && ec.Includes("vmId",true))
        {
            this.VmId = "FETCH";
        }
        //      C# -> System.String? VmLocation
        // GraphQL -> vmLocation: String! (scalar)
        if (this.VmLocation == null && ec.Includes("vmLocation",true))
        {
            this.VmLocation = "FETCH";
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName == null && ec.Includes("vmName",true))
        {
            this.VmName = "FETCH";
        }
    }


    #endregion

    } // class CdpVmInfo
    
    #endregion

    public static class ListCdpVmInfoExtensions
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
            this List<CdpVmInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdpVmInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdpVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CdpVmInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types