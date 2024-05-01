// SnappableAggregation.cs
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
    #region SnappableAggregation
    public class SnappableAggregation: BaseType
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

    public override string GetGqlTypeName() {
        return "SnappableAggregation";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
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
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long! (scalar)
        if (this.TransferredBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "transferredBytes\n" ;
            } else {
                s += ind + "transferredBytes\n" ;
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
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long! (scalar)
        if (ec.Includes("transferredBytes",true))
        {
            if(this.TransferredBytes == null) {

                this.TransferredBytes = new System.Int64();

            } else {


            }
        }
        else if (this.TransferredBytes != null && ec.Excludes("transferredBytes",true))
        {
            this.TransferredBytes = null;
        }
    }


    #endregion

    } // class SnappableAggregation
    
    #endregion

    public static class ListSnappableAggregationExtensions
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
            this List<SnappableAggregation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnappableAggregation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnappableAggregation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnappableAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types