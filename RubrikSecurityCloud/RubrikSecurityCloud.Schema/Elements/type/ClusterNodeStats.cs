// ClusterNodeStats.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterNodeStats
    public class ClusterNodeStats: IFragment
    {
        #region members
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.Int64? CpuStat
        // GraphQL -> cpuStat: Long! (scalar)
        [JsonProperty("cpuStat")]
        public System.Int64? CpuStat { get; set; }

        //      C# -> System.Int64? IopsReadsPerSecond
        // GraphQL -> iopsReadsPerSecond: Long! (scalar)
        [JsonProperty("iopsReadsPerSecond")]
        public System.Int64? IopsReadsPerSecond { get; set; }

        //      C# -> System.Int64? IopsWritesPerSecond
        // GraphQL -> iopsWritesPerSecond: Long! (scalar)
        [JsonProperty("iopsWritesPerSecond")]
        public System.Int64? IopsWritesPerSecond { get; set; }

        //      C# -> System.Int64? NetworkBytesReceived
        // GraphQL -> networkBytesReceived: Long! (scalar)
        [JsonProperty("networkBytesReceived")]
        public System.Int64? NetworkBytesReceived { get; set; }

        //      C# -> System.Int64? NetworkBytesTransmitted
        // GraphQL -> networkBytesTransmitted: Long! (scalar)
        [JsonProperty("networkBytesTransmitted")]
        public System.Int64? NetworkBytesTransmitted { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.Int64? ReadThroughputBytesPerSecond
        // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
        [JsonProperty("readThroughputBytesPerSecond")]
        public System.Int64? ReadThroughputBytesPerSecond { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> System.Int32? UsedMemoryStat
        // GraphQL -> usedMemoryStat: Int! (scalar)
        [JsonProperty("usedMemoryStat")]
        public System.Int32? UsedMemoryStat { get; set; }

        //      C# -> System.Int64? WriteThroughputBytesPerSecond
        // GraphQL -> writeThroughputBytesPerSecond: Long! (scalar)
        [JsonProperty("writeThroughputBytesPerSecond")]
        public System.Int64? WriteThroughputBytesPerSecond { get; set; }

        #endregion

    #region methods

    public ClusterNodeStats Set(
        System.String? ClusterId = null,
        System.Int64? CpuStat = null,
        System.Int64? IopsReadsPerSecond = null,
        System.Int64? IopsWritesPerSecond = null,
        System.Int64? NetworkBytesReceived = null,
        System.Int64? NetworkBytesTransmitted = null,
        System.String? NodeId = null,
        System.Int64? ReadThroughputBytesPerSecond = null,
        DateTime? Time = null,
        System.Int32? UsedMemoryStat = null,
        System.Int64? WriteThroughputBytesPerSecond = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( CpuStat != null ) {
            this.CpuStat = CpuStat;
        }
        if ( IopsReadsPerSecond != null ) {
            this.IopsReadsPerSecond = IopsReadsPerSecond;
        }
        if ( IopsWritesPerSecond != null ) {
            this.IopsWritesPerSecond = IopsWritesPerSecond;
        }
        if ( NetworkBytesReceived != null ) {
            this.NetworkBytesReceived = NetworkBytesReceived;
        }
        if ( NetworkBytesTransmitted != null ) {
            this.NetworkBytesTransmitted = NetworkBytesTransmitted;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( ReadThroughputBytesPerSecond != null ) {
            this.ReadThroughputBytesPerSecond = ReadThroughputBytesPerSecond;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( UsedMemoryStat != null ) {
            this.UsedMemoryStat = UsedMemoryStat;
        }
        if ( WriteThroughputBytesPerSecond != null ) {
            this.WriteThroughputBytesPerSecond = WriteThroughputBytesPerSecond;
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
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.Int64? CpuStat
            // GraphQL -> cpuStat: Long! (scalar)
            if (this.CpuStat != null)
            {
                 s += ind + "cpuStat\n";

            }
            //      C# -> System.Int64? IopsReadsPerSecond
            // GraphQL -> iopsReadsPerSecond: Long! (scalar)
            if (this.IopsReadsPerSecond != null)
            {
                 s += ind + "iopsReadsPerSecond\n";

            }
            //      C# -> System.Int64? IopsWritesPerSecond
            // GraphQL -> iopsWritesPerSecond: Long! (scalar)
            if (this.IopsWritesPerSecond != null)
            {
                 s += ind + "iopsWritesPerSecond\n";

            }
            //      C# -> System.Int64? NetworkBytesReceived
            // GraphQL -> networkBytesReceived: Long! (scalar)
            if (this.NetworkBytesReceived != null)
            {
                 s += ind + "networkBytesReceived\n";

            }
            //      C# -> System.Int64? NetworkBytesTransmitted
            // GraphQL -> networkBytesTransmitted: Long! (scalar)
            if (this.NetworkBytesTransmitted != null)
            {
                 s += ind + "networkBytesTransmitted\n";

            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            //      C# -> System.Int64? ReadThroughputBytesPerSecond
            // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
            if (this.ReadThroughputBytesPerSecond != null)
            {
                 s += ind + "readThroughputBytesPerSecond\n";

            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time != null)
            {
                 s += ind + "time\n";

            }
            //      C# -> System.Int32? UsedMemoryStat
            // GraphQL -> usedMemoryStat: Int! (scalar)
            if (this.UsedMemoryStat != null)
            {
                 s += ind + "usedMemoryStat\n";

            }
            //      C# -> System.Int64? WriteThroughputBytesPerSecond
            // GraphQL -> writeThroughputBytesPerSecond: Long! (scalar)
            if (this.WriteThroughputBytesPerSecond != null)
            {
                 s += ind + "writeThroughputBytesPerSecond\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.Int64? CpuStat
            // GraphQL -> cpuStat: Long! (scalar)
            if (this.CpuStat == null && Exploration.Includes(parent + ".cpuStat$"))
            {
                this.CpuStat = new System.Int64();
            }
            //      C# -> System.Int64? IopsReadsPerSecond
            // GraphQL -> iopsReadsPerSecond: Long! (scalar)
            if (this.IopsReadsPerSecond == null && Exploration.Includes(parent + ".iopsReadsPerSecond$"))
            {
                this.IopsReadsPerSecond = new System.Int64();
            }
            //      C# -> System.Int64? IopsWritesPerSecond
            // GraphQL -> iopsWritesPerSecond: Long! (scalar)
            if (this.IopsWritesPerSecond == null && Exploration.Includes(parent + ".iopsWritesPerSecond$"))
            {
                this.IopsWritesPerSecond = new System.Int64();
            }
            //      C# -> System.Int64? NetworkBytesReceived
            // GraphQL -> networkBytesReceived: Long! (scalar)
            if (this.NetworkBytesReceived == null && Exploration.Includes(parent + ".networkBytesReceived$"))
            {
                this.NetworkBytesReceived = new System.Int64();
            }
            //      C# -> System.Int64? NetworkBytesTransmitted
            // GraphQL -> networkBytesTransmitted: Long! (scalar)
            if (this.NetworkBytesTransmitted == null && Exploration.Includes(parent + ".networkBytesTransmitted$"))
            {
                this.NetworkBytesTransmitted = new System.Int64();
            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
            //      C# -> System.Int64? ReadThroughputBytesPerSecond
            // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
            if (this.ReadThroughputBytesPerSecond == null && Exploration.Includes(parent + ".readThroughputBytesPerSecond$"))
            {
                this.ReadThroughputBytesPerSecond = new System.Int64();
            }
            //      C# -> DateTime? Time
            // GraphQL -> time: DateTime! (scalar)
            if (this.Time == null && Exploration.Includes(parent + ".time$"))
            {
                this.Time = new DateTime();
            }
            //      C# -> System.Int32? UsedMemoryStat
            // GraphQL -> usedMemoryStat: Int! (scalar)
            if (this.UsedMemoryStat == null && Exploration.Includes(parent + ".usedMemoryStat$"))
            {
                this.UsedMemoryStat = new System.Int32();
            }
            //      C# -> System.Int64? WriteThroughputBytesPerSecond
            // GraphQL -> writeThroughputBytesPerSecond: Long! (scalar)
            if (this.WriteThroughputBytesPerSecond == null && Exploration.Includes(parent + ".writeThroughputBytesPerSecond$"))
            {
                this.WriteThroughputBytesPerSecond = new System.Int64();
            }
        }


    #endregion

    } // class ClusterNodeStats
    #endregion

    public static class ListClusterNodeStatsExtensions
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
            this List<ClusterNodeStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterNodeStats> list, 
            String parent = "")
        {
            var item = new ClusterNodeStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types