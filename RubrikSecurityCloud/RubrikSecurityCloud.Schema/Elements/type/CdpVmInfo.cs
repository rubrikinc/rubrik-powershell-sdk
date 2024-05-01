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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CdpLocalStatus? CdpLocalStatus
        // GraphQL -> cdpLocalStatus: CdpLocalStatus (enum)
        if (this.CdpLocalStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdpLocalStatus\n" ;
            } else {
                s += ind + "cdpLocalStatus\n" ;
            }
        }
        //      C# -> CdpReplicationStatus? CdpReplicationStatus
        // GraphQL -> cdpReplicationStatus: CdpReplicationStatus (enum)
        if (this.CdpReplicationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdpReplicationStatus\n" ;
            } else {
                s += ind + "cdpReplicationStatus\n" ;
            }
        }
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (this.IoFilterStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ioFilterStatus\n" ;
            } else {
                s += ind + "ioFilterStatus\n" ;
            }
        }
        //      C# -> DateTime? LatestSnapshotTime
        // GraphQL -> latestSnapshotTime: DateTime (scalar)
        if (this.LatestSnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestSnapshotTime\n" ;
            } else {
                s += ind + "latestSnapshotTime\n" ;
            }
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String! (scalar)
        if (this.ReplicationTarget != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTarget\n" ;
            } else {
                s += ind + "replicationTarget\n" ;
            }
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainName\n" ;
            } else {
                s += ind + "slaDomainName\n" ;
            }
        }
        //      C# -> System.String? SourceCluster
        // GraphQL -> sourceCluster: String! (scalar)
        if (this.SourceCluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceCluster\n" ;
            } else {
                s += ind + "sourceCluster\n" ;
            }
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        //      C# -> System.String? VmLocation
        // GraphQL -> vmLocation: String! (scalar)
        if (this.VmLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmLocation\n" ;
            } else {
                s += ind + "vmLocation\n" ;
            }
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmName\n" ;
            } else {
                s += ind + "vmName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdpLocalStatus? CdpLocalStatus
        // GraphQL -> cdpLocalStatus: CdpLocalStatus (enum)
        if (ec.Includes("cdpLocalStatus",true))
        {
            if(this.CdpLocalStatus == null) {

                this.CdpLocalStatus = new CdpLocalStatus();

            } else {


            }
        }
        else if (this.CdpLocalStatus != null && ec.Excludes("cdpLocalStatus",true))
        {
            this.CdpLocalStatus = null;
        }
        //      C# -> CdpReplicationStatus? CdpReplicationStatus
        // GraphQL -> cdpReplicationStatus: CdpReplicationStatus (enum)
        if (ec.Includes("cdpReplicationStatus",true))
        {
            if(this.CdpReplicationStatus == null) {

                this.CdpReplicationStatus = new CdpReplicationStatus();

            } else {


            }
        }
        else if (this.CdpReplicationStatus != null && ec.Excludes("cdpReplicationStatus",true))
        {
            this.CdpReplicationStatus = null;
        }
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (ec.Includes("ioFilterStatus",true))
        {
            if(this.IoFilterStatus == null) {

                this.IoFilterStatus = new IoFilterStatus();

            } else {


            }
        }
        else if (this.IoFilterStatus != null && ec.Excludes("ioFilterStatus",true))
        {
            this.IoFilterStatus = null;
        }
        //      C# -> DateTime? LatestSnapshotTime
        // GraphQL -> latestSnapshotTime: DateTime (scalar)
        if (ec.Includes("latestSnapshotTime",true))
        {
            if(this.LatestSnapshotTime == null) {

                this.LatestSnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestSnapshotTime != null && ec.Excludes("latestSnapshotTime",true))
        {
            this.LatestSnapshotTime = null;
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String! (scalar)
        if (ec.Includes("replicationTarget",true))
        {
            if(this.ReplicationTarget == null) {

                this.ReplicationTarget = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTarget != null && ec.Excludes("replicationTarget",true))
        {
            this.ReplicationTarget = null;
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (ec.Includes("slaDomainName",true))
        {
            if(this.SlaDomainName == null) {

                this.SlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomainName != null && ec.Excludes("slaDomainName",true))
        {
            this.SlaDomainName = null;
        }
        //      C# -> System.String? SourceCluster
        // GraphQL -> sourceCluster: String! (scalar)
        if (ec.Includes("sourceCluster",true))
        {
            if(this.SourceCluster == null) {

                this.SourceCluster = "FETCH";

            } else {


            }
        }
        else if (this.SourceCluster != null && ec.Excludes("sourceCluster",true))
        {
            this.SourceCluster = null;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
        //      C# -> System.String? VmLocation
        // GraphQL -> vmLocation: String! (scalar)
        if (ec.Includes("vmLocation",true))
        {
            if(this.VmLocation == null) {

                this.VmLocation = "FETCH";

            } else {


            }
        }
        else if (this.VmLocation != null && ec.Excludes("vmLocation",true))
        {
            this.VmLocation = null;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (ec.Includes("vmName",true))
        {
            if(this.VmName == null) {

                this.VmName = "FETCH";

            } else {


            }
        }
        else if (this.VmName != null && ec.Excludes("vmName",true))
        {
            this.VmName = null;
        }
    }


    #endregion

    } // class CdpVmInfo
    
    #endregion

    public static class ListCdpVmInfoExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CdpVmInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdpVmInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<CdpVmInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types