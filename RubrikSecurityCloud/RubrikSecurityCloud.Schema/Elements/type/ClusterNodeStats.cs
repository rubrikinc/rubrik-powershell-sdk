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

        //      C# -> System.Int64? DiskUtilBasisPoints
        // GraphQL -> diskUtilBasisPoints: Long (scalar)
        [JsonProperty("diskUtilBasisPoints")]
        public System.Int64? DiskUtilBasisPoints { get; set; }

        //      C# -> System.Int64? IopsReadsPerSecond
        // GraphQL -> iopsReadsPerSecond: Long! (scalar)
        [JsonProperty("iopsReadsPerSecond")]
        public System.Int64? IopsReadsPerSecond { get; set; }

        //      C# -> System.Int64? IopsWritesPerSecond
        // GraphQL -> iopsWritesPerSecond: Long! (scalar)
        [JsonProperty("iopsWritesPerSecond")]
        public System.Int64? IopsWritesPerSecond { get; set; }

        //      C# -> System.Int64? LoadAvg5MinMilli
        // GraphQL -> loadAvg5MinMilli: Long (scalar)
        [JsonProperty("loadAvg5MinMilli")]
        public System.Int64? LoadAvg5MinMilli { get; set; }

        //      C# -> System.Int64? NetworkBytesReceived
        // GraphQL -> networkBytesReceived: Long! (scalar)
        [JsonProperty("networkBytesReceived")]
        public System.Int64? NetworkBytesReceived { get; set; }

        //      C# -> System.Int64? NetworkBytesTransmitted
        // GraphQL -> networkBytesTransmitted: Long! (scalar)
        [JsonProperty("networkBytesTransmitted")]
        public System.Int64? NetworkBytesTransmitted { get; set; }

        //      C# -> System.Int64? NfacctTcpBackupAgentBytes
        // GraphQL -> nfacctTcpBackupAgentBytes: Long (scalar)
        [JsonProperty("nfacctTcpBackupAgentBytes")]
        public System.Int64? NfacctTcpBackupAgentBytes { get; set; }

        //      C# -> System.Int64? NfacctTcpEsxBytes
        // GraphQL -> nfacctTcpEsxBytes: Long (scalar)
        [JsonProperty("nfacctTcpEsxBytes")]
        public System.Int64? NfacctTcpEsxBytes { get; set; }

        //      C# -> System.Int64? NfacctTcpIscsiBytes
        // GraphQL -> nfacctTcpIscsiBytes: Long (scalar)
        [JsonProperty("nfacctTcpIscsiBytes")]
        public System.Int64? NfacctTcpIscsiBytes { get; set; }

        //      C# -> System.Int64? NfacctTcpNfsBytes
        // GraphQL -> nfacctTcpNfsBytes: Long (scalar)
        [JsonProperty("nfacctTcpNfsBytes")]
        public System.Int64? NfacctTcpNfsBytes { get; set; }

        //      C# -> System.Int64? NfacctTcpSmbBytes
        // GraphQL -> nfacctTcpSmbBytes: Long (scalar)
        [JsonProperty("nfacctTcpSmbBytes")]
        public System.Int64? NfacctTcpSmbBytes { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.Int64? ReadThroughputBytesPerSecond
        // GraphQL -> readThroughputBytesPerSecond: Long! (scalar)
        [JsonProperty("readThroughputBytesPerSecond")]
        public System.Int64? ReadThroughputBytesPerSecond { get; set; }

        //      C# -> System.Int64? SnapshotStorageDelta
        // GraphQL -> snapshotStorageDelta: Long (scalar)
        [JsonProperty("snapshotStorageDelta")]
        public System.Int64? SnapshotStorageDelta { get; set; }

        //      C# -> System.Int64? SnapshotStorageIndex
        // GraphQL -> snapshotStorageIndex: Long (scalar)
        [JsonProperty("snapshotStorageIndex")]
        public System.Int64? SnapshotStorageIndex { get; set; }

        //      C# -> System.Int64? SnapshotStorageLive
        // GraphQL -> snapshotStorageLive: Long (scalar)
        [JsonProperty("snapshotStorageLive")]
        public System.Int64? SnapshotStorageLive { get; set; }

        //      C# -> System.Int64? SnapshotStorageMetadata
        // GraphQL -> snapshotStorageMetadata: Long (scalar)
        [JsonProperty("snapshotStorageMetadata")]
        public System.Int64? SnapshotStorageMetadata { get; set; }

        //      C# -> System.Int64? StorageEfficiencyRatio10k
        // GraphQL -> storageEfficiencyRatio10k: Long (scalar)
        [JsonProperty("storageEfficiencyRatio10k")]
        public System.Int64? StorageEfficiencyRatio10k { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime! (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        //      C# -> System.Int64? UptimeSeconds
        // GraphQL -> uptimeSeconds: Long (scalar)
        [JsonProperty("uptimeSeconds")]
        public System.Int64? UptimeSeconds { get; set; }

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
        System.Int64? DiskUtilBasisPoints = null,
        System.Int64? IopsReadsPerSecond = null,
        System.Int64? IopsWritesPerSecond = null,
        System.Int64? LoadAvg5MinMilli = null,
        System.Int64? NetworkBytesReceived = null,
        System.Int64? NetworkBytesTransmitted = null,
        System.Int64? NfacctTcpBackupAgentBytes = null,
        System.Int64? NfacctTcpEsxBytes = null,
        System.Int64? NfacctTcpIscsiBytes = null,
        System.Int64? NfacctTcpNfsBytes = null,
        System.Int64? NfacctTcpSmbBytes = null,
        System.String? NodeId = null,
        System.Int64? ReadThroughputBytesPerSecond = null,
        System.Int64? SnapshotStorageDelta = null,
        System.Int64? SnapshotStorageIndex = null,
        System.Int64? SnapshotStorageLive = null,
        System.Int64? SnapshotStorageMetadata = null,
        System.Int64? StorageEfficiencyRatio10k = null,
        DateTime? Time = null,
        System.Int64? UptimeSeconds = null,
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
        if ( DiskUtilBasisPoints != null ) {
            this.DiskUtilBasisPoints = DiskUtilBasisPoints;
        }
        if ( IopsReadsPerSecond != null ) {
            this.IopsReadsPerSecond = IopsReadsPerSecond;
        }
        if ( IopsWritesPerSecond != null ) {
            this.IopsWritesPerSecond = IopsWritesPerSecond;
        }
        if ( LoadAvg5MinMilli != null ) {
            this.LoadAvg5MinMilli = LoadAvg5MinMilli;
        }
        if ( NetworkBytesReceived != null ) {
            this.NetworkBytesReceived = NetworkBytesReceived;
        }
        if ( NetworkBytesTransmitted != null ) {
            this.NetworkBytesTransmitted = NetworkBytesTransmitted;
        }
        if ( NfacctTcpBackupAgentBytes != null ) {
            this.NfacctTcpBackupAgentBytes = NfacctTcpBackupAgentBytes;
        }
        if ( NfacctTcpEsxBytes != null ) {
            this.NfacctTcpEsxBytes = NfacctTcpEsxBytes;
        }
        if ( NfacctTcpIscsiBytes != null ) {
            this.NfacctTcpIscsiBytes = NfacctTcpIscsiBytes;
        }
        if ( NfacctTcpNfsBytes != null ) {
            this.NfacctTcpNfsBytes = NfacctTcpNfsBytes;
        }
        if ( NfacctTcpSmbBytes != null ) {
            this.NfacctTcpSmbBytes = NfacctTcpSmbBytes;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( ReadThroughputBytesPerSecond != null ) {
            this.ReadThroughputBytesPerSecond = ReadThroughputBytesPerSecond;
        }
        if ( SnapshotStorageDelta != null ) {
            this.SnapshotStorageDelta = SnapshotStorageDelta;
        }
        if ( SnapshotStorageIndex != null ) {
            this.SnapshotStorageIndex = SnapshotStorageIndex;
        }
        if ( SnapshotStorageLive != null ) {
            this.SnapshotStorageLive = SnapshotStorageLive;
        }
        if ( SnapshotStorageMetadata != null ) {
            this.SnapshotStorageMetadata = SnapshotStorageMetadata;
        }
        if ( StorageEfficiencyRatio10k != null ) {
            this.StorageEfficiencyRatio10k = StorageEfficiencyRatio10k;
        }
        if ( Time != null ) {
            this.Time = Time;
        }
        if ( UptimeSeconds != null ) {
            this.UptimeSeconds = UptimeSeconds;
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
        //      C# -> System.Int64? DiskUtilBasisPoints
        // GraphQL -> diskUtilBasisPoints: Long (scalar)
        if (this.DiskUtilBasisPoints != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskUtilBasisPoints\n" ;
            } else {
                s += ind + "diskUtilBasisPoints\n" ;
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
        //      C# -> System.Int64? LoadAvg5MinMilli
        // GraphQL -> loadAvg5MinMilli: Long (scalar)
        if (this.LoadAvg5MinMilli != null) {
            if (conf.Flat) {
                s += conf.Prefix + "loadAvg5MinMilli\n" ;
            } else {
                s += ind + "loadAvg5MinMilli\n" ;
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
        //      C# -> System.Int64? NfacctTcpBackupAgentBytes
        // GraphQL -> nfacctTcpBackupAgentBytes: Long (scalar)
        if (this.NfacctTcpBackupAgentBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nfacctTcpBackupAgentBytes\n" ;
            } else {
                s += ind + "nfacctTcpBackupAgentBytes\n" ;
            }
        }
        //      C# -> System.Int64? NfacctTcpEsxBytes
        // GraphQL -> nfacctTcpEsxBytes: Long (scalar)
        if (this.NfacctTcpEsxBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nfacctTcpEsxBytes\n" ;
            } else {
                s += ind + "nfacctTcpEsxBytes\n" ;
            }
        }
        //      C# -> System.Int64? NfacctTcpIscsiBytes
        // GraphQL -> nfacctTcpIscsiBytes: Long (scalar)
        if (this.NfacctTcpIscsiBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nfacctTcpIscsiBytes\n" ;
            } else {
                s += ind + "nfacctTcpIscsiBytes\n" ;
            }
        }
        //      C# -> System.Int64? NfacctTcpNfsBytes
        // GraphQL -> nfacctTcpNfsBytes: Long (scalar)
        if (this.NfacctTcpNfsBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nfacctTcpNfsBytes\n" ;
            } else {
                s += ind + "nfacctTcpNfsBytes\n" ;
            }
        }
        //      C# -> System.Int64? NfacctTcpSmbBytes
        // GraphQL -> nfacctTcpSmbBytes: Long (scalar)
        if (this.NfacctTcpSmbBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nfacctTcpSmbBytes\n" ;
            } else {
                s += ind + "nfacctTcpSmbBytes\n" ;
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
        //      C# -> System.Int64? SnapshotStorageDelta
        // GraphQL -> snapshotStorageDelta: Long (scalar)
        if (this.SnapshotStorageDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotStorageDelta\n" ;
            } else {
                s += ind + "snapshotStorageDelta\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotStorageIndex
        // GraphQL -> snapshotStorageIndex: Long (scalar)
        if (this.SnapshotStorageIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotStorageIndex\n" ;
            } else {
                s += ind + "snapshotStorageIndex\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotStorageLive
        // GraphQL -> snapshotStorageLive: Long (scalar)
        if (this.SnapshotStorageLive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotStorageLive\n" ;
            } else {
                s += ind + "snapshotStorageLive\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotStorageMetadata
        // GraphQL -> snapshotStorageMetadata: Long (scalar)
        if (this.SnapshotStorageMetadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotStorageMetadata\n" ;
            } else {
                s += ind + "snapshotStorageMetadata\n" ;
            }
        }
        //      C# -> System.Int64? StorageEfficiencyRatio10k
        // GraphQL -> storageEfficiencyRatio10k: Long (scalar)
        if (this.StorageEfficiencyRatio10k != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageEfficiencyRatio10k\n" ;
            } else {
                s += ind + "storageEfficiencyRatio10k\n" ;
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
        //      C# -> System.Int64? UptimeSeconds
        // GraphQL -> uptimeSeconds: Long (scalar)
        if (this.UptimeSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uptimeSeconds\n" ;
            } else {
                s += ind + "uptimeSeconds\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> System.Int64? DiskUtilBasisPoints
        // GraphQL -> diskUtilBasisPoints: Long (scalar)
        if (ec.Includes("diskUtilBasisPoints",true))
        {
            if(this.DiskUtilBasisPoints == null) {

                this.DiskUtilBasisPoints = new System.Int64();

            } else {


            }
        }
        else if (this.DiskUtilBasisPoints != null && ec.Excludes("diskUtilBasisPoints",true))
        {
            this.DiskUtilBasisPoints = null;
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
        //      C# -> System.Int64? LoadAvg5MinMilli
        // GraphQL -> loadAvg5MinMilli: Long (scalar)
        if (ec.Includes("loadAvg5MinMilli",true))
        {
            if(this.LoadAvg5MinMilli == null) {

                this.LoadAvg5MinMilli = new System.Int64();

            } else {


            }
        }
        else if (this.LoadAvg5MinMilli != null && ec.Excludes("loadAvg5MinMilli",true))
        {
            this.LoadAvg5MinMilli = null;
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
        //      C# -> System.Int64? NfacctTcpBackupAgentBytes
        // GraphQL -> nfacctTcpBackupAgentBytes: Long (scalar)
        if (ec.Includes("nfacctTcpBackupAgentBytes",true))
        {
            if(this.NfacctTcpBackupAgentBytes == null) {

                this.NfacctTcpBackupAgentBytes = new System.Int64();

            } else {


            }
        }
        else if (this.NfacctTcpBackupAgentBytes != null && ec.Excludes("nfacctTcpBackupAgentBytes",true))
        {
            this.NfacctTcpBackupAgentBytes = null;
        }
        //      C# -> System.Int64? NfacctTcpEsxBytes
        // GraphQL -> nfacctTcpEsxBytes: Long (scalar)
        if (ec.Includes("nfacctTcpEsxBytes",true))
        {
            if(this.NfacctTcpEsxBytes == null) {

                this.NfacctTcpEsxBytes = new System.Int64();

            } else {


            }
        }
        else if (this.NfacctTcpEsxBytes != null && ec.Excludes("nfacctTcpEsxBytes",true))
        {
            this.NfacctTcpEsxBytes = null;
        }
        //      C# -> System.Int64? NfacctTcpIscsiBytes
        // GraphQL -> nfacctTcpIscsiBytes: Long (scalar)
        if (ec.Includes("nfacctTcpIscsiBytes",true))
        {
            if(this.NfacctTcpIscsiBytes == null) {

                this.NfacctTcpIscsiBytes = new System.Int64();

            } else {


            }
        }
        else if (this.NfacctTcpIscsiBytes != null && ec.Excludes("nfacctTcpIscsiBytes",true))
        {
            this.NfacctTcpIscsiBytes = null;
        }
        //      C# -> System.Int64? NfacctTcpNfsBytes
        // GraphQL -> nfacctTcpNfsBytes: Long (scalar)
        if (ec.Includes("nfacctTcpNfsBytes",true))
        {
            if(this.NfacctTcpNfsBytes == null) {

                this.NfacctTcpNfsBytes = new System.Int64();

            } else {


            }
        }
        else if (this.NfacctTcpNfsBytes != null && ec.Excludes("nfacctTcpNfsBytes",true))
        {
            this.NfacctTcpNfsBytes = null;
        }
        //      C# -> System.Int64? NfacctTcpSmbBytes
        // GraphQL -> nfacctTcpSmbBytes: Long (scalar)
        if (ec.Includes("nfacctTcpSmbBytes",true))
        {
            if(this.NfacctTcpSmbBytes == null) {

                this.NfacctTcpSmbBytes = new System.Int64();

            } else {


            }
        }
        else if (this.NfacctTcpSmbBytes != null && ec.Excludes("nfacctTcpSmbBytes",true))
        {
            this.NfacctTcpSmbBytes = null;
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
        //      C# -> System.Int64? SnapshotStorageDelta
        // GraphQL -> snapshotStorageDelta: Long (scalar)
        if (ec.Includes("snapshotStorageDelta",true))
        {
            if(this.SnapshotStorageDelta == null) {

                this.SnapshotStorageDelta = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotStorageDelta != null && ec.Excludes("snapshotStorageDelta",true))
        {
            this.SnapshotStorageDelta = null;
        }
        //      C# -> System.Int64? SnapshotStorageIndex
        // GraphQL -> snapshotStorageIndex: Long (scalar)
        if (ec.Includes("snapshotStorageIndex",true))
        {
            if(this.SnapshotStorageIndex == null) {

                this.SnapshotStorageIndex = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotStorageIndex != null && ec.Excludes("snapshotStorageIndex",true))
        {
            this.SnapshotStorageIndex = null;
        }
        //      C# -> System.Int64? SnapshotStorageLive
        // GraphQL -> snapshotStorageLive: Long (scalar)
        if (ec.Includes("snapshotStorageLive",true))
        {
            if(this.SnapshotStorageLive == null) {

                this.SnapshotStorageLive = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotStorageLive != null && ec.Excludes("snapshotStorageLive",true))
        {
            this.SnapshotStorageLive = null;
        }
        //      C# -> System.Int64? SnapshotStorageMetadata
        // GraphQL -> snapshotStorageMetadata: Long (scalar)
        if (ec.Includes("snapshotStorageMetadata",true))
        {
            if(this.SnapshotStorageMetadata == null) {

                this.SnapshotStorageMetadata = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotStorageMetadata != null && ec.Excludes("snapshotStorageMetadata",true))
        {
            this.SnapshotStorageMetadata = null;
        }
        //      C# -> System.Int64? StorageEfficiencyRatio10k
        // GraphQL -> storageEfficiencyRatio10k: Long (scalar)
        if (ec.Includes("storageEfficiencyRatio10k",true))
        {
            if(this.StorageEfficiencyRatio10k == null) {

                this.StorageEfficiencyRatio10k = new System.Int64();

            } else {


            }
        }
        else if (this.StorageEfficiencyRatio10k != null && ec.Excludes("storageEfficiencyRatio10k",true))
        {
            this.StorageEfficiencyRatio10k = null;
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
        //      C# -> System.Int64? UptimeSeconds
        // GraphQL -> uptimeSeconds: Long (scalar)
        if (ec.Includes("uptimeSeconds",true))
        {
            if(this.UptimeSeconds == null) {

                this.UptimeSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.UptimeSeconds != null && ec.Excludes("uptimeSeconds",true))
        {
            this.UptimeSeconds = null;
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
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNodeStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterNodeStats> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types