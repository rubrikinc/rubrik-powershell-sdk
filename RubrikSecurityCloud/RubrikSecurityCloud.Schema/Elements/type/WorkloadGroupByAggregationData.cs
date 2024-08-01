// WorkloadGroupByAggregationData.cs
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
    #region WorkloadGroupByAggregationData
    public class WorkloadGroupByAggregationData: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadGroupByAggregationData";
    }

    public WorkloadGroupByAggregationData Set(
        System.Int64? ArchiveStorage = null,
        System.Int32? Count = null,
        System.Int64? LastSnapshotLogicalBytes = null,
        System.Int64? LogicalBytes = null,
        System.Int32? MissedSnapshots = null,
        System.Int64? PhysicalBytes = null,
        System.Int64? ReplicaStorage = null,
        System.Int32? TotalSnapshots = null
    ) 
    {
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( Count != null ) {
            this.Count = Count;
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
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (this.ArchiveStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveStorage\n" ;
            } else {
                s += ind + "archiveStorage\n" ;
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
        if (this.LastSnapshotLogicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSnapshotLogicalBytes\n" ;
            } else {
                s += ind + "lastSnapshotLogicalBytes\n" ;
            }
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (this.LogicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalBytes\n" ;
            } else {
                s += ind + "logicalBytes\n" ;
            }
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int! (scalar)
        if (this.MissedSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missedSnapshots\n" ;
            } else {
                s += ind + "missedSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (this.PhysicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalBytes\n" ;
            } else {
                s += ind + "physicalBytes\n" ;
            }
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long! (scalar)
        if (this.ReplicaStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaStorage\n" ;
            } else {
                s += ind + "replicaStorage\n" ;
            }
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        if (this.TotalSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSnapshots\n" ;
            } else {
                s += ind + "totalSnapshots\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (ec.Includes("archiveStorage",true))
        {
            if(this.ArchiveStorage == null) {

                this.ArchiveStorage = new System.Int64();

            } else {


            }
        }
        else if (this.ArchiveStorage != null && ec.Excludes("archiveStorage",true))
        {
            this.ArchiveStorage = null;
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long! (scalar)
        if (ec.Includes("lastSnapshotLogicalBytes",true))
        {
            if(this.LastSnapshotLogicalBytes == null) {

                this.LastSnapshotLogicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LastSnapshotLogicalBytes != null && ec.Excludes("lastSnapshotLogicalBytes",true))
        {
            this.LastSnapshotLogicalBytes = null;
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        if (ec.Includes("logicalBytes",true))
        {
            if(this.LogicalBytes == null) {

                this.LogicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LogicalBytes != null && ec.Excludes("logicalBytes",true))
        {
            this.LogicalBytes = null;
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int! (scalar)
        if (ec.Includes("missedSnapshots",true))
        {
            if(this.MissedSnapshots == null) {

                this.MissedSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.MissedSnapshots != null && ec.Excludes("missedSnapshots",true))
        {
            this.MissedSnapshots = null;
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        if (ec.Includes("physicalBytes",true))
        {
            if(this.PhysicalBytes == null) {

                this.PhysicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalBytes != null && ec.Excludes("physicalBytes",true))
        {
            this.PhysicalBytes = null;
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long! (scalar)
        if (ec.Includes("replicaStorage",true))
        {
            if(this.ReplicaStorage == null) {

                this.ReplicaStorage = new System.Int64();

            } else {


            }
        }
        else if (this.ReplicaStorage != null && ec.Excludes("replicaStorage",true))
        {
            this.ReplicaStorage = null;
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int! (scalar)
        if (ec.Includes("totalSnapshots",true))
        {
            if(this.TotalSnapshots == null) {

                this.TotalSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalSnapshots != null && ec.Excludes("totalSnapshots",true))
        {
            this.TotalSnapshots = null;
        }
    }


    #endregion

    } // class WorkloadGroupByAggregationData
    
    #endregion

    public static class ListWorkloadGroupByAggregationDataExtensions
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
            this List<WorkloadGroupByAggregationData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadGroupByAggregationData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadGroupByAggregationData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadGroupByAggregationData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadGroupByAggregationData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types