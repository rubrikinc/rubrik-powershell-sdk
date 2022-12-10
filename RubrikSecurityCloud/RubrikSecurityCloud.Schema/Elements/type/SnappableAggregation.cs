// SnappableAggregation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:03.
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
    #region SnappableAggregation
    public class SnappableAggregation: IFragment
    {
        #region members
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
        [JsonProperty("lastSnapshotLogicalBytes")]
        public System.Int64? LastSnapshotLogicalBytes { get; set; }

        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        [JsonProperty("logicalBytes")]
        public System.Int64? LogicalBytes { get; set; }

        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int! (scalar)
        [JsonProperty("missedSnapshots")]
        public System.Int32? MissedSnapshots { get; set; }

        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        [JsonProperty("physicalBytes")]
        public System.Int64? PhysicalBytes { get; set; }

        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long! (scalar)
        [JsonProperty("replicaStorage")]
        public System.Int64? ReplicaStorage { get; set; }

        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        [JsonProperty("totalSnapshots")]
        public System.Int32? TotalSnapshots { get; set; }

        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long! (scalar)
        [JsonProperty("transferredBytes")]
        public System.Int64? TransferredBytes { get; set; }

        #endregion

    #region methods

    public SnappableAggregation Set(
        System.Int64? ArchiveStorage = null,
        System.Int64? LastSnapshotLogicalBytes = null,
        System.Int64? LogicalBytes = null,
        System.Int32? MissedSnapshots = null,
        System.Int64? PhysicalBytes = null,
        System.Int64? ReplicaStorage = null,
        System.Int32? TotalSnapshots = null,
        System.Int64? TransferredBytes = null
    ) 
    {
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( LastSnapshotLogicalBytes != null ) {
            this.LastSnapshotLogicalBytes = LastSnapshotLogicalBytes;
        }
        if ( LogicalBytes != null ) {
            this.LogicalBytes = LogicalBytes;
        }
        if ( MissedSnapshots != null ) {
            this.MissedSnapshots = MissedSnapshots;
        }
        if ( PhysicalBytes != null ) {
            this.PhysicalBytes = PhysicalBytes;
        }
        if ( ReplicaStorage != null ) {
            this.ReplicaStorage = ReplicaStorage;
        }
        if ( TotalSnapshots != null ) {
            this.TotalSnapshots = TotalSnapshots;
        }
        if ( TransferredBytes != null ) {
            this.TransferredBytes = TransferredBytes;
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
            //      C# -> System.Int64? ArchiveStorage
            // GraphQL -> archiveStorage: Long! (scalar)
            if (this.ArchiveStorage != null)
            {
                 s += ind + "archiveStorage\n";

            }
            //      C# -> System.Int64? LastSnapshotLogicalBytes
            // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
            if (this.LastSnapshotLogicalBytes != null)
            {
                 s += ind + "lastSnapshotLogicalBytes\n";

            }
            //      C# -> System.Int64? LogicalBytes
            // GraphQL -> logicalBytes: Long! (scalar)
            if (this.LogicalBytes != null)
            {
                 s += ind + "logicalBytes\n";

            }
            //      C# -> System.Int32? MissedSnapshots
            // GraphQL -> missedSnapshots: Int! (scalar)
            if (this.MissedSnapshots != null)
            {
                 s += ind + "missedSnapshots\n";

            }
            //      C# -> System.Int64? PhysicalBytes
            // GraphQL -> physicalBytes: Long! (scalar)
            if (this.PhysicalBytes != null)
            {
                 s += ind + "physicalBytes\n";

            }
            //      C# -> System.Int64? ReplicaStorage
            // GraphQL -> replicaStorage: Long! (scalar)
            if (this.ReplicaStorage != null)
            {
                 s += ind + "replicaStorage\n";

            }
            //      C# -> System.Int32? TotalSnapshots
            // GraphQL -> totalSnapshots: Int! (scalar)
            if (this.TotalSnapshots != null)
            {
                 s += ind + "totalSnapshots\n";

            }
            //      C# -> System.Int64? TransferredBytes
            // GraphQL -> transferredBytes: Long! (scalar)
            if (this.TransferredBytes != null)
            {
                 s += ind + "transferredBytes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ArchiveStorage
            // GraphQL -> archiveStorage: Long! (scalar)
            if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage$"))
            {
                this.ArchiveStorage = new System.Int64();
            }
            //      C# -> System.Int64? LastSnapshotLogicalBytes
            // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
            if (this.LastSnapshotLogicalBytes == null && Exploration.Includes(parent + ".lastSnapshotLogicalBytes$"))
            {
                this.LastSnapshotLogicalBytes = new System.Int64();
            }
            //      C# -> System.Int64? LogicalBytes
            // GraphQL -> logicalBytes: Long! (scalar)
            if (this.LogicalBytes == null && Exploration.Includes(parent + ".logicalBytes$"))
            {
                this.LogicalBytes = new System.Int64();
            }
            //      C# -> System.Int32? MissedSnapshots
            // GraphQL -> missedSnapshots: Int! (scalar)
            if (this.MissedSnapshots == null && Exploration.Includes(parent + ".missedSnapshots$"))
            {
                this.MissedSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? PhysicalBytes
            // GraphQL -> physicalBytes: Long! (scalar)
            if (this.PhysicalBytes == null && Exploration.Includes(parent + ".physicalBytes$"))
            {
                this.PhysicalBytes = new System.Int64();
            }
            //      C# -> System.Int64? ReplicaStorage
            // GraphQL -> replicaStorage: Long! (scalar)
            if (this.ReplicaStorage == null && Exploration.Includes(parent + ".replicaStorage$"))
            {
                this.ReplicaStorage = new System.Int64();
            }
            //      C# -> System.Int32? TotalSnapshots
            // GraphQL -> totalSnapshots: Int! (scalar)
            if (this.TotalSnapshots == null && Exploration.Includes(parent + ".totalSnapshots$"))
            {
                this.TotalSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? TransferredBytes
            // GraphQL -> transferredBytes: Long! (scalar)
            if (this.TransferredBytes == null && Exploration.Includes(parent + ".transferredBytes$"))
            {
                this.TransferredBytes = new System.Int64();
            }
        }


    #endregion

    } // class SnappableAggregation
    #endregion

    public static class ListSnappableAggregationExtensions
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
            this List<SnappableAggregation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnappableAggregation> list, 
            String parent = "")
        {
            var item = new SnappableAggregation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types