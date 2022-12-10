// CdpVmInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:08.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region CdpVmInfo
    public class CdpVmInfo: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public CdpVmInfo Set(
        DateTime? LatestSnapshotTime = null,
        System.String? ReplicationTarget = null,
        System.String? SlaDomainName = null,
        System.String? SourceCluster = null,
        System.String? VmId = null,
        System.String? VmLocation = null,
        System.String? VmName = null,
        CdpLocalStatus? CdpLocalStatus = null,
        CdpReplicationStatus? CdpReplicationStatus = null,
        IoFilterStatus? IoFilterStatus = null
    ) 
    {
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
        if ( CdpLocalStatus != null ) {
            this.CdpLocalStatus = CdpLocalStatus;
        }
        if ( CdpReplicationStatus != null ) {
            this.CdpReplicationStatus = CdpReplicationStatus;
        }
        if ( IoFilterStatus != null ) {
            this.IoFilterStatus = IoFilterStatus;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? LatestSnapshotTime
            // GraphQL -> latestSnapshotTime: DateTime (scalar)
            if (this.LatestSnapshotTime != null)
            {
                 s += ind + "latestSnapshotTime\n";

            }
            //      C# -> System.String? ReplicationTarget
            // GraphQL -> replicationTarget: String! (scalar)
            if (this.ReplicationTarget != null)
            {
                 s += ind + "replicationTarget\n";

            }
            //      C# -> System.String? SlaDomainName
            // GraphQL -> slaDomainName: String! (scalar)
            if (this.SlaDomainName != null)
            {
                 s += ind + "slaDomainName\n";

            }
            //      C# -> System.String? SourceCluster
            // GraphQL -> sourceCluster: String! (scalar)
            if (this.SourceCluster != null)
            {
                 s += ind + "sourceCluster\n";

            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId != null)
            {
                 s += ind + "vmId\n";

            }
            //      C# -> System.String? VmLocation
            // GraphQL -> vmLocation: String! (scalar)
            if (this.VmLocation != null)
            {
                 s += ind + "vmLocation\n";

            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName != null)
            {
                 s += ind + "vmName\n";

            }
            //      C# -> CdpLocalStatus? CdpLocalStatus
            // GraphQL -> cdpLocalStatus: CdpLocalStatus (enum)
            if (this.CdpLocalStatus != null)
            {
                 s += ind + "cdpLocalStatus\n";

            }
            //      C# -> CdpReplicationStatus? CdpReplicationStatus
            // GraphQL -> cdpReplicationStatus: CdpReplicationStatus (enum)
            if (this.CdpReplicationStatus != null)
            {
                 s += ind + "cdpReplicationStatus\n";

            }
            //      C# -> IoFilterStatus? IoFilterStatus
            // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
            if (this.IoFilterStatus != null)
            {
                 s += ind + "ioFilterStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? LatestSnapshotTime
            // GraphQL -> latestSnapshotTime: DateTime (scalar)
            if (this.LatestSnapshotTime == null && Exploration.Includes(parent + ".latestSnapshotTime$"))
            {
                this.LatestSnapshotTime = new DateTime();
            }
            //      C# -> System.String? ReplicationTarget
            // GraphQL -> replicationTarget: String! (scalar)
            if (this.ReplicationTarget == null && Exploration.Includes(parent + ".replicationTarget$"))
            {
                this.ReplicationTarget = new System.String("FETCH");
            }
            //      C# -> System.String? SlaDomainName
            // GraphQL -> slaDomainName: String! (scalar)
            if (this.SlaDomainName == null && Exploration.Includes(parent + ".slaDomainName$"))
            {
                this.SlaDomainName = new System.String("FETCH");
            }
            //      C# -> System.String? SourceCluster
            // GraphQL -> sourceCluster: String! (scalar)
            if (this.SourceCluster == null && Exploration.Includes(parent + ".sourceCluster$"))
            {
                this.SourceCluster = new System.String("FETCH");
            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId == null && Exploration.Includes(parent + ".vmId$"))
            {
                this.VmId = new System.String("FETCH");
            }
            //      C# -> System.String? VmLocation
            // GraphQL -> vmLocation: String! (scalar)
            if (this.VmLocation == null && Exploration.Includes(parent + ".vmLocation$"))
            {
                this.VmLocation = new System.String("FETCH");
            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName == null && Exploration.Includes(parent + ".vmName$"))
            {
                this.VmName = new System.String("FETCH");
            }
            //      C# -> CdpLocalStatus? CdpLocalStatus
            // GraphQL -> cdpLocalStatus: CdpLocalStatus (enum)
            if (this.CdpLocalStatus == null && Exploration.Includes(parent + ".cdpLocalStatus$"))
            {
                this.CdpLocalStatus = new CdpLocalStatus();
            }
            //      C# -> CdpReplicationStatus? CdpReplicationStatus
            // GraphQL -> cdpReplicationStatus: CdpReplicationStatus (enum)
            if (this.CdpReplicationStatus == null && Exploration.Includes(parent + ".cdpReplicationStatus$"))
            {
                this.CdpReplicationStatus = new CdpReplicationStatus();
            }
            //      C# -> IoFilterStatus? IoFilterStatus
            // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
            if (this.IoFilterStatus == null && Exploration.Includes(parent + ".ioFilterStatus$"))
            {
                this.IoFilterStatus = new IoFilterStatus();
            }
        }


    #endregion

    } // class CdpVmInfo
    #endregion

    public static class ListCdpVmInfoExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CdpVmInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdpVmInfo> list, 
            String parent = "")
        {
            var item = new CdpVmInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types