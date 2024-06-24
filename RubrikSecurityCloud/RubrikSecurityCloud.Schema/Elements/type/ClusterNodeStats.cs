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

        //      C# -> System.Int64? ClusterPhysicalDataIngest
        // GraphQL -> clusterPhysicalDataIngest: Long! (scalar)
        [JsonProperty("clusterPhysicalDataIngest")]
        public System.Int64? ClusterPhysicalDataIngest { get; set; }

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
        System.Int64? ClusterPhysicalDataIngest = null,
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
        if ( ClusterPhysicalDataIngest != null ) {
            this.ClusterPhysicalDataIngest = ClusterPhysicalDataIngest;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.Int64? ClusterPhysicalDataIngest
        // GraphQL -> clusterPhysicalDataIngest: Long! (scalar)
        if (this.ClusterPhysicalDataIngest != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterPhysicalDataIngest\n" ;
            } else {
                s += ind + "clusterPhysicalDataIngest\n" ;
            }
        }
        //      C# -> System.Int64? CpuStat
        // GraphQL -> cpuStat: Long! (scalar)
        if (this.CpuStat != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cpuStat\n" ;
            } else {
                s += ind + "cpuStat\n" ;
            }
        }
        //      C# -> System.Int64? IopsReadsPerSecond
        // GraphQL -> iopsReadsPerSecond: Long! (scalar)
        if (this.IopsReadsPerSecond != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iopsReadsPerSecond\n" ;
            } else {
                s += ind + "iopsReadsPerSecond\n" ;
            }
        }
        //      C# -> System.Int64? IopsWritesPerSecond
        // GraphQL -> iopsWritesPerSecond: Long! (scalar)
        if (this.IopsWritesPerSecond != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iopsWritesPerSecond\n" ;
            } else {
                s += ind + "iopsWritesPerSecond\n" ;
            }
        }
        //      C# -> System.Int64? NetworkBytesReceived
        // GraphQL -> networkBytesReceived: Long! (scalar)
        if (this.NetworkBytesReceived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkBytesReceived\n" ;
            } else {
                s += ind + "networkBytesReceived\n" ;
            }
        }
        //      C# -> System.Int64? NetworkBytesTransmitted
        // GraphQL -> networkBytesTransmitted: Long! (scalar)
        if (this.NetworkBytesTransmitted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkBytesTransmitted\n" ;
            } else {
                s += ind + "networkBytesTransmitted\n" ;
            }
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.Int64? ReadThroughputBytesPerSecond
        // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
        if (this.ReadThroughputBytesPerSecond != null) {
            if (conf.Flat) {
                s += conf.Prefix + "readThroughputBytesPerSecond\n" ;
            } else {
                s += ind + "readThroughputBytesPerSecond\n" ;
            }
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (this.Time != null) {
            if (conf.Flat) {
                s += conf.Prefix + "time\n" ;
            } else {
                s += ind + "time\n" ;
            }
        }
        //      C# -> System.Int32? UsedMemoryStat
        // GraphQL -> usedMemoryStat: Int! (scalar)
        if (this.UsedMemoryStat != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedMemoryStat\n" ;
            } else {
                s += ind + "usedMemoryStat\n" ;
            }
        }
        //      C# -> System.Int64? WriteThroughputBytesPerSecond
        // GraphQL -> writeThroughputBytesPerSecond: Long! (scalar)
        if (this.WriteThroughputBytesPerSecond != null) {
            if (conf.Flat) {
                s += conf.Prefix + "writeThroughputBytesPerSecond\n" ;
            } else {
                s += ind + "writeThroughputBytesPerSecond\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.Int64? ClusterPhysicalDataIngest
        // GraphQL -> clusterPhysicalDataIngest: Long! (scalar)
        if (ec.Includes("clusterPhysicalDataIngest",true))
        {
            if(this.ClusterPhysicalDataIngest == null) {

                this.ClusterPhysicalDataIngest = new System.Int64();

            } else {


            }
        }
        else if (this.ClusterPhysicalDataIngest != null && ec.Excludes("clusterPhysicalDataIngest",true))
        {
            this.ClusterPhysicalDataIngest = null;
        }
        //      C# -> System.Int64? CpuStat
        // GraphQL -> cpuStat: Long! (scalar)
        if (ec.Includes("cpuStat",true))
        {
            if(this.CpuStat == null) {

                this.CpuStat = new System.Int64();

            } else {


            }
        }
        else if (this.CpuStat != null && ec.Excludes("cpuStat",true))
        {
            this.CpuStat = null;
        }
        //      C# -> System.Int64? IopsReadsPerSecond
        // GraphQL -> iopsReadsPerSecond: Long! (scalar)
        if (ec.Includes("iopsReadsPerSecond",true))
        {
            if(this.IopsReadsPerSecond == null) {

                this.IopsReadsPerSecond = new System.Int64();

            } else {


            }
        }
        else if (this.IopsReadsPerSecond != null && ec.Excludes("iopsReadsPerSecond",true))
        {
            this.IopsReadsPerSecond = null;
        }
        //      C# -> System.Int64? IopsWritesPerSecond
        // GraphQL -> iopsWritesPerSecond: Long! (scalar)
        if (ec.Includes("iopsWritesPerSecond",true))
        {
            if(this.IopsWritesPerSecond == null) {

                this.IopsWritesPerSecond = new System.Int64();

            } else {


            }
        }
        else if (this.IopsWritesPerSecond != null && ec.Excludes("iopsWritesPerSecond",true))
        {
            this.IopsWritesPerSecond = null;
        }
        //      C# -> System.Int64? NetworkBytesReceived
        // GraphQL -> networkBytesReceived: Long! (scalar)
        if (ec.Includes("networkBytesReceived",true))
        {
            if(this.NetworkBytesReceived == null) {

                this.NetworkBytesReceived = new System.Int64();

            } else {


            }
        }
        else if (this.NetworkBytesReceived != null && ec.Excludes("networkBytesReceived",true))
        {
            this.NetworkBytesReceived = null;
        }
        //      C# -> System.Int64? NetworkBytesTransmitted
        // GraphQL -> networkBytesTransmitted: Long! (scalar)
        if (ec.Includes("networkBytesTransmitted",true))
        {
            if(this.NetworkBytesTransmitted == null) {

                this.NetworkBytesTransmitted = new System.Int64();

            } else {


            }
        }
        else if (this.NetworkBytesTransmitted != null && ec.Excludes("networkBytesTransmitted",true))
        {
            this.NetworkBytesTransmitted = null;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (ec.Includes("nodeId",true))
        {
            if(this.NodeId == null) {

                this.NodeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeId != null && ec.Excludes("nodeId",true))
        {
            this.NodeId = null;
        }
        //      C# -> System.Int64? ReadThroughputBytesPerSecond
        // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
        if (ec.Includes("readThroughputBytesPerSecond",true))
        {
            if(this.ReadThroughputBytesPerSecond == null) {

                this.ReadThroughputBytesPerSecond = new System.Int64();

            } else {


            }
        }
        else if (this.ReadThroughputBytesPerSecond != null && ec.Excludes("readThroughputBytesPerSecond",true))
        {
            this.ReadThroughputBytesPerSecond = null;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        if (ec.Includes("time",true))
        {
            if(this.Time == null) {

                this.Time = new DateTime();

            } else {


            }
        }
        else if (this.Time != null && ec.Excludes("time",true))
        {
            this.Time = null;
        }
        //      C# -> System.Int32? UsedMemoryStat
        // GraphQL -> usedMemoryStat: Int! (scalar)
        if (ec.Includes("usedMemoryStat",true))
        {
            if(this.UsedMemoryStat == null) {

                this.UsedMemoryStat = Int32.MinValue;

            } else {


            }
        }
        else if (this.UsedMemoryStat != null && ec.Excludes("usedMemoryStat",true))
        {
            this.UsedMemoryStat = null;
        }
        //      C# -> System.Int64? WriteThroughputBytesPerSecond
        // GraphQL -> writeThroughputBytesPerSecond: Long! (scalar)
        if (ec.Includes("writeThroughputBytesPerSecond",true))
        {
            if(this.WriteThroughputBytesPerSecond == null) {

                this.WriteThroughputBytesPerSecond = new System.Int64();

            } else {


            }
        }
        else if (this.WriteThroughputBytesPerSecond != null && ec.Excludes("writeThroughputBytesPerSecond",true))
        {
            this.WriteThroughputBytesPerSecond = null;
        }
    }


    #endregion

    } // class ClusterNodeStats
    
    #endregion

    public static class ListClusterNodeStatsExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClusterNodeStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterNodeStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<ClusterNodeStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types