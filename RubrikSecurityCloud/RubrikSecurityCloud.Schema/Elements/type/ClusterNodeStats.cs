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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ClusterNodeStats
    public class ClusterNodeStats: BaseType
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

    public override string GetGqlTypeName() {
        return "ClusterNodeStats";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.Int64? CpuStat
        // GraphQL -> cpuStat: Long! (scalar)
        if (this.CpuStat != null) {
            s += ind + "cpuStat\n" ;
        }
        //      C# -> System.Int64? IopsReadsPerSecond
        // GraphQL -> iopsReadsPerSecond: Long! (scalar)
        if (this.IopsReadsPerSecond != null) {
            s += ind + "iopsReadsPerSecond\n" ;
        }
        //      C# -> System.Int64? IopsWritesPerSecond
        // GraphQL -> iopsWritesPerSecond: Long! (scalar)
        if (this.IopsWritesPerSecond != null) {
            s += ind + "iopsWritesPerSecond\n" ;
        }
        //      C# -> System.Int64? NetworkBytesReceived
        // GraphQL -> networkBytesReceived: Long! (scalar)
        if (this.NetworkBytesReceived != null) {
            s += ind + "networkBytesReceived\n" ;
        }
        //      C# -> System.Int64? NetworkBytesTransmitted
        // GraphQL -> networkBytesTransmitted: Long! (scalar)
        if (this.NetworkBytesTransmitted != null) {
            s += ind + "networkBytesTransmitted\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> System.Int64? ReadThroughputBytesPerSecond
        // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
        if (this.ReadThroughputBytesPerSecond != null) {
            s += ind + "readThroughputBytesPerSecond\n" ;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            s += ind + "time\n" ;
        }
        //      C# -> System.Int32? UsedMemoryStat
        // GraphQL -> usedMemoryStat: Int! (scalar)
        if (this.UsedMemoryStat != null) {
            s += ind + "usedMemoryStat\n" ;
        }
        //      C# -> System.Int64? WriteThroughputBytesPerSecond
        // GraphQL -> writeThroughputBytesPerSecond: Long! (scalar)
        if (this.WriteThroughputBytesPerSecond != null) {
            s += ind + "writeThroughputBytesPerSecond\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && ec.Includes("clusterId",true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.Int64? CpuStat
        // GraphQL -> cpuStat: Long! (scalar)
        if (this.CpuStat == null && ec.Includes("cpuStat",true))
        {
            this.CpuStat = new System.Int64();
        }
        //      C# -> System.Int64? IopsReadsPerSecond
        // GraphQL -> iopsReadsPerSecond: Long! (scalar)
        if (this.IopsReadsPerSecond == null && ec.Includes("iopsReadsPerSecond",true))
        {
            this.IopsReadsPerSecond = new System.Int64();
        }
        //      C# -> System.Int64? IopsWritesPerSecond
        // GraphQL -> iopsWritesPerSecond: Long! (scalar)
        if (this.IopsWritesPerSecond == null && ec.Includes("iopsWritesPerSecond",true))
        {
            this.IopsWritesPerSecond = new System.Int64();
        }
        //      C# -> System.Int64? NetworkBytesReceived
        // GraphQL -> networkBytesReceived: Long! (scalar)
        if (this.NetworkBytesReceived == null && ec.Includes("networkBytesReceived",true))
        {
            this.NetworkBytesReceived = new System.Int64();
        }
        //      C# -> System.Int64? NetworkBytesTransmitted
        // GraphQL -> networkBytesTransmitted: Long! (scalar)
        if (this.NetworkBytesTransmitted == null && ec.Includes("networkBytesTransmitted",true))
        {
            this.NetworkBytesTransmitted = new System.Int64();
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && ec.Includes("nodeId",true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> System.Int64? ReadThroughputBytesPerSecond
        // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
        if (this.ReadThroughputBytesPerSecond == null && ec.Includes("readThroughputBytesPerSecond",true))
        {
            this.ReadThroughputBytesPerSecond = new System.Int64();
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time == null && ec.Includes("time",true))
        {
            this.Time = new DateTime();
        }
        //      C# -> System.Int32? UsedMemoryStat
        // GraphQL -> usedMemoryStat: Int! (scalar)
        if (this.UsedMemoryStat == null && ec.Includes("usedMemoryStat",true))
        {
            this.UsedMemoryStat = Int32.MinValue;
        }
        //      C# -> System.Int64? WriteThroughputBytesPerSecond
        // GraphQL -> writeThroughputBytesPerSecond: Long! (scalar)
        if (this.WriteThroughputBytesPerSecond == null && ec.Includes("writeThroughputBytesPerSecond",true))
        {
            this.WriteThroughputBytesPerSecond = new System.Int64();
        }
    }


    #endregion

    } // class ClusterNodeStats
    
    #endregion

    public static class ListClusterNodeStatsExtensions
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
            this List<ClusterNodeStats> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNodeStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNodeStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ClusterNodeStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types