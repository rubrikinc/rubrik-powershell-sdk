// PolarisSnapshot.cs
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
    #region PolarisSnapshot
 
    public class PolarisSnapshot: IFragment, GenericSnapshot
    {
        #region members
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        [JsonProperty("expiryHint")]
        public System.Boolean? ExpiryHint { get; set; }

        //      C# -> System.Boolean? HasUnexpiredArchivedCopy
        // GraphQL -> hasUnexpiredArchivedCopy: Boolean! (scalar)
        [JsonProperty("hasUnexpiredArchivedCopy")]
        public System.Boolean? HasUnexpiredArchivedCopy { get; set; }

        //      C# -> System.Boolean? HasUnexpiredReplica
        // GraphQL -> hasUnexpiredReplica: Boolean! (scalar)
        [JsonProperty("hasUnexpiredReplica")]
        public System.Boolean? HasUnexpiredReplica { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        [JsonProperty("indexTime")]
        public DateTime? IndexTime { get; set; }

        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        [JsonProperty("indexingAttempts")]
        public System.Int64? IndexingAttempts { get; set; }

        //      C# -> System.Boolean? IsArchivalCopy
        // GraphQL -> isArchivalCopy: Boolean (scalar)
        [JsonProperty("isArchivalCopy")]
        public System.Boolean? IsArchivalCopy { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        [JsonProperty("isCorrupted")]
        public System.Boolean? IsCorrupted { get; set; }

        //      C# -> System.Boolean? IsDeletedFromSource
        // GraphQL -> isDeletedFromSource: Boolean! (scalar)
        [JsonProperty("isDeletedFromSource")]
        public System.Boolean? IsDeletedFromSource { get; set; }

        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        [JsonProperty("isDownloadedSnapshot")]
        public System.Boolean? IsDownloadedSnapshot { get; set; }

        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        [JsonProperty("isExpired")]
        public System.Boolean? IsExpired { get; set; }

        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        [JsonProperty("isIndexed")]
        public System.Boolean? IsIndexed { get; set; }

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> System.Boolean? IsReplica
        // GraphQL -> isReplica: Boolean (scalar)
        [JsonProperty("isReplica")]
        public System.Boolean? IsReplica { get; set; }

        //      C# -> System.Boolean? IsReplicated
        // GraphQL -> isReplicated: Boolean! (scalar)
        [JsonProperty("isReplicated")]
        public System.Boolean? IsReplicated { get; set; }

        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        [JsonProperty("isUnindexable")]
        public System.Boolean? IsUnindexable { get; set; }

        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        [JsonProperty("parentSnapshotId")]
        public System.String? ParentSnapshotId { get; set; }

        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        [JsonProperty("sequenceNumber")]
        public System.Int32? SequenceNumber { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.Int32? UnexpiredArchivedSnapshotCount
        // GraphQL -> unexpiredArchivedSnapshotCount: Int! (scalar)
        [JsonProperty("unexpiredArchivedSnapshotCount")]
        public System.Int32? UnexpiredArchivedSnapshotCount { get; set; }

        //      C# -> System.Int32? UnexpiredReplicaCount
        // GraphQL -> unexpiredReplicaCount: Int! (scalar)
        [JsonProperty("unexpiredReplicaCount")]
        public System.Int32? UnexpiredReplicaCount { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> List<DataLocation>? ReplicationLocations
        // GraphQL -> replicationLocations: [DataLocation!] (type)
        [JsonProperty("replicationLocations")]
        public List<DataLocation>? ReplicationLocations { get; set; }

        //      C# -> SnapshotConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotConsistencyLevel! (enum)
        [JsonProperty("consistencyLevel")]
        public SnapshotConsistencyLevel? ConsistencyLevel { get; set; }

        //      C# -> PolarisSpecificSnapshot? PolarisSpecificSnapshot
        // GraphQL -> polarisSpecificSnapshot: PolarisSpecificSnapshot (interface)
        [JsonProperty("polarisSpecificSnapshot")]
        public PolarisSpecificSnapshot? PolarisSpecificSnapshot { get; set; }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        #endregion

    #region methods

    public PolarisSnapshot Set(
        DateTime? Date = null,
        DateTime? ExpirationDate = null,
        System.Boolean? ExpiryHint = null,
        System.Boolean? HasUnexpiredArchivedCopy = null,
        System.Boolean? HasUnexpiredReplica = null,
        System.String? Id = null,
        DateTime? IndexTime = null,
        System.Int64? IndexingAttempts = null,
        System.Boolean? IsArchivalCopy = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsCorrupted = null,
        System.Boolean? IsDeletedFromSource = null,
        System.Boolean? IsDownloadedSnapshot = null,
        System.Boolean? IsExpired = null,
        System.Boolean? IsIndexed = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Boolean? IsQuarantined = null,
        System.Boolean? IsReplica = null,
        System.Boolean? IsReplicated = null,
        System.Boolean? IsUnindexable = null,
        System.String? ParentSnapshotId = null,
        System.Int32? SequenceNumber = null,
        System.String? SnappableId = null,
        System.Int32? UnexpiredArchivedSnapshotCount = null,
        System.Int32? UnexpiredReplicaCount = null,
        LatestUserNote? LatestUserNote = null,
        List<DataLocation>? ReplicationLocations = null,
        SnapshotConsistencyLevel? ConsistencyLevel = null,
        PolarisSpecificSnapshot? PolarisSpecificSnapshot = null,
        SlaDomain? SlaDomain = null
    ) 
    {
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( ExpiryHint != null ) {
            this.ExpiryHint = ExpiryHint;
        }
        if ( HasUnexpiredArchivedCopy != null ) {
            this.HasUnexpiredArchivedCopy = HasUnexpiredArchivedCopy;
        }
        if ( HasUnexpiredReplica != null ) {
            this.HasUnexpiredReplica = HasUnexpiredReplica;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IndexTime != null ) {
            this.IndexTime = IndexTime;
        }
        if ( IndexingAttempts != null ) {
            this.IndexingAttempts = IndexingAttempts;
        }
        if ( IsArchivalCopy != null ) {
            this.IsArchivalCopy = IsArchivalCopy;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsCorrupted != null ) {
            this.IsCorrupted = IsCorrupted;
        }
        if ( IsDeletedFromSource != null ) {
            this.IsDeletedFromSource = IsDeletedFromSource;
        }
        if ( IsDownloadedSnapshot != null ) {
            this.IsDownloadedSnapshot = IsDownloadedSnapshot;
        }
        if ( IsExpired != null ) {
            this.IsExpired = IsExpired;
        }
        if ( IsIndexed != null ) {
            this.IsIndexed = IsIndexed;
        }
        if ( IsOnDemandSnapshot != null ) {
            this.IsOnDemandSnapshot = IsOnDemandSnapshot;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( IsReplica != null ) {
            this.IsReplica = IsReplica;
        }
        if ( IsReplicated != null ) {
            this.IsReplicated = IsReplicated;
        }
        if ( IsUnindexable != null ) {
            this.IsUnindexable = IsUnindexable;
        }
        if ( ParentSnapshotId != null ) {
            this.ParentSnapshotId = ParentSnapshotId;
        }
        if ( SequenceNumber != null ) {
            this.SequenceNumber = SequenceNumber;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( UnexpiredArchivedSnapshotCount != null ) {
            this.UnexpiredArchivedSnapshotCount = UnexpiredArchivedSnapshotCount;
        }
        if ( UnexpiredReplicaCount != null ) {
            this.UnexpiredReplicaCount = UnexpiredReplicaCount;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( ReplicationLocations != null ) {
            this.ReplicationLocations = ReplicationLocations;
        }
        if ( ConsistencyLevel != null ) {
            this.ConsistencyLevel = ConsistencyLevel;
        }
        if ( PolarisSpecificSnapshot != null ) {
            this.PolarisSpecificSnapshot = PolarisSpecificSnapshot;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
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
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime! (scalar)
            if (this.Date != null)
            {
                 s += ind + "date\n";

            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime (scalar)
            if (this.ExpirationDate != null)
            {
                 s += ind + "expirationDate\n";

            }
            //      C# -> System.Boolean? ExpiryHint
            // GraphQL -> expiryHint: Boolean! (scalar)
            if (this.ExpiryHint != null)
            {
                 s += ind + "expiryHint\n";

            }
            //      C# -> System.Boolean? HasUnexpiredArchivedCopy
            // GraphQL -> hasUnexpiredArchivedCopy: Boolean! (scalar)
            if (this.HasUnexpiredArchivedCopy != null)
            {
                 s += ind + "hasUnexpiredArchivedCopy\n";

            }
            //      C# -> System.Boolean? HasUnexpiredReplica
            // GraphQL -> hasUnexpiredReplica: Boolean! (scalar)
            if (this.HasUnexpiredReplica != null)
            {
                 s += ind + "hasUnexpiredReplica\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> DateTime? IndexTime
            // GraphQL -> indexTime: DateTime (scalar)
            if (this.IndexTime != null)
            {
                 s += ind + "indexTime\n";

            }
            //      C# -> System.Int64? IndexingAttempts
            // GraphQL -> indexingAttempts: Long! (scalar)
            if (this.IndexingAttempts != null)
            {
                 s += ind + "indexingAttempts\n";

            }
            //      C# -> System.Boolean? IsArchivalCopy
            // GraphQL -> isArchivalCopy: Boolean (scalar)
            if (this.IsArchivalCopy != null)
            {
                 s += ind + "isArchivalCopy\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.Boolean? IsCorrupted
            // GraphQL -> isCorrupted: Boolean! (scalar)
            if (this.IsCorrupted != null)
            {
                 s += ind + "isCorrupted\n";

            }
            //      C# -> System.Boolean? IsDeletedFromSource
            // GraphQL -> isDeletedFromSource: Boolean! (scalar)
            if (this.IsDeletedFromSource != null)
            {
                 s += ind + "isDeletedFromSource\n";

            }
            //      C# -> System.Boolean? IsDownloadedSnapshot
            // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
            if (this.IsDownloadedSnapshot != null)
            {
                 s += ind + "isDownloadedSnapshot\n";

            }
            //      C# -> System.Boolean? IsExpired
            // GraphQL -> isExpired: Boolean! (scalar)
            if (this.IsExpired != null)
            {
                 s += ind + "isExpired\n";

            }
            //      C# -> System.Boolean? IsIndexed
            // GraphQL -> isIndexed: Boolean! (scalar)
            if (this.IsIndexed != null)
            {
                 s += ind + "isIndexed\n";

            }
            //      C# -> System.Boolean? IsOnDemandSnapshot
            // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
            if (this.IsOnDemandSnapshot != null)
            {
                 s += ind + "isOnDemandSnapshot\n";

            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined != null)
            {
                 s += ind + "isQuarantined\n";

            }
            //      C# -> System.Boolean? IsReplica
            // GraphQL -> isReplica: Boolean (scalar)
            if (this.IsReplica != null)
            {
                 s += ind + "isReplica\n";

            }
            //      C# -> System.Boolean? IsReplicated
            // GraphQL -> isReplicated: Boolean! (scalar)
            if (this.IsReplicated != null)
            {
                 s += ind + "isReplicated\n";

            }
            //      C# -> System.Boolean? IsUnindexable
            // GraphQL -> isUnindexable: Boolean! (scalar)
            if (this.IsUnindexable != null)
            {
                 s += ind + "isUnindexable\n";

            }
            //      C# -> System.String? ParentSnapshotId
            // GraphQL -> parentSnapshotId: String (scalar)
            if (this.ParentSnapshotId != null)
            {
                 s += ind + "parentSnapshotId\n";

            }
            //      C# -> System.Int32? SequenceNumber
            // GraphQL -> sequenceNumber: Int! (scalar)
            if (this.SequenceNumber != null)
            {
                 s += ind + "sequenceNumber\n";

            }
            //      C# -> System.String? SnappableId
            // GraphQL -> snappableId: String! (scalar)
            if (this.SnappableId != null)
            {
                 s += ind + "snappableId\n";

            }
            //      C# -> System.Int32? UnexpiredArchivedSnapshotCount
            // GraphQL -> unexpiredArchivedSnapshotCount: Int! (scalar)
            if (this.UnexpiredArchivedSnapshotCount != null)
            {
                 s += ind + "unexpiredArchivedSnapshotCount\n";

            }
            //      C# -> System.Int32? UnexpiredReplicaCount
            // GraphQL -> unexpiredReplicaCount: Int! (scalar)
            if (this.UnexpiredReplicaCount != null)
            {
                 s += ind + "unexpiredReplicaCount\n";

            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote != null)
            {
                 s += ind + "latestUserNote\n";

                 s += ind + "{\n" + 
                 this.LatestUserNote.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<DataLocation>? ReplicationLocations
            // GraphQL -> replicationLocations: [DataLocation!] (type)
            if (this.ReplicationLocations != null)
            {
                 s += ind + "replicationLocations\n";

                 s += ind + "{\n" + 
                 this.ReplicationLocations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotConsistencyLevel? ConsistencyLevel
            // GraphQL -> consistencyLevel: SnapshotConsistencyLevel! (enum)
            if (this.ConsistencyLevel != null)
            {
                 s += ind + "consistencyLevel\n";

            }
                        //      C# -> PolarisSpecificSnapshot? PolarisSpecificSnapshot
            // GraphQL -> polarisSpecificSnapshot: PolarisSpecificSnapshot (interface)
            if (this.PolarisSpecificSnapshot != null)
            {
                s += ind + "polarisSpecificSnapshot\n";
                s += ind + "{\n";

                string typename = this.PolarisSpecificSnapshot.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.PolarisSpecificSnapshot.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? SlaDomain
            // GraphQL -> slaDomain: SlaDomain (interface)
            if (this.SlaDomain != null)
            {
                s += ind + "slaDomain\n";
                s += ind + "{\n";

                string typename = this.SlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.SlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime! (scalar)
            if (this.Date == null && Exploration.Includes(parent + ".date$"))
            {
                this.Date = new DateTime();
            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime (scalar)
            if (this.ExpirationDate == null && Exploration.Includes(parent + ".expirationDate$"))
            {
                this.ExpirationDate = new DateTime();
            }
            //      C# -> System.Boolean? ExpiryHint
            // GraphQL -> expiryHint: Boolean! (scalar)
            if (this.ExpiryHint == null && Exploration.Includes(parent + ".expiryHint$"))
            {
                this.ExpiryHint = new System.Boolean();
            }
            //      C# -> System.Boolean? HasUnexpiredArchivedCopy
            // GraphQL -> hasUnexpiredArchivedCopy: Boolean! (scalar)
            if (this.HasUnexpiredArchivedCopy == null && Exploration.Includes(parent + ".hasUnexpiredArchivedCopy$"))
            {
                this.HasUnexpiredArchivedCopy = new System.Boolean();
            }
            //      C# -> System.Boolean? HasUnexpiredReplica
            // GraphQL -> hasUnexpiredReplica: Boolean! (scalar)
            if (this.HasUnexpiredReplica == null && Exploration.Includes(parent + ".hasUnexpiredReplica$"))
            {
                this.HasUnexpiredReplica = new System.Boolean();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> DateTime? IndexTime
            // GraphQL -> indexTime: DateTime (scalar)
            if (this.IndexTime == null && Exploration.Includes(parent + ".indexTime$"))
            {
                this.IndexTime = new DateTime();
            }
            //      C# -> System.Int64? IndexingAttempts
            // GraphQL -> indexingAttempts: Long! (scalar)
            if (this.IndexingAttempts == null && Exploration.Includes(parent + ".indexingAttempts$"))
            {
                this.IndexingAttempts = new System.Int64();
            }
            //      C# -> System.Boolean? IsArchivalCopy
            // GraphQL -> isArchivalCopy: Boolean (scalar)
            if (this.IsArchivalCopy == null && Exploration.Includes(parent + ".isArchivalCopy$"))
            {
                this.IsArchivalCopy = new System.Boolean();
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.Boolean? IsCorrupted
            // GraphQL -> isCorrupted: Boolean! (scalar)
            if (this.IsCorrupted == null && Exploration.Includes(parent + ".isCorrupted$"))
            {
                this.IsCorrupted = new System.Boolean();
            }
            //      C# -> System.Boolean? IsDeletedFromSource
            // GraphQL -> isDeletedFromSource: Boolean! (scalar)
            if (this.IsDeletedFromSource == null && Exploration.Includes(parent + ".isDeletedFromSource$"))
            {
                this.IsDeletedFromSource = new System.Boolean();
            }
            //      C# -> System.Boolean? IsDownloadedSnapshot
            // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
            if (this.IsDownloadedSnapshot == null && Exploration.Includes(parent + ".isDownloadedSnapshot$"))
            {
                this.IsDownloadedSnapshot = new System.Boolean();
            }
            //      C# -> System.Boolean? IsExpired
            // GraphQL -> isExpired: Boolean! (scalar)
            if (this.IsExpired == null && Exploration.Includes(parent + ".isExpired$"))
            {
                this.IsExpired = new System.Boolean();
            }
            //      C# -> System.Boolean? IsIndexed
            // GraphQL -> isIndexed: Boolean! (scalar)
            if (this.IsIndexed == null && Exploration.Includes(parent + ".isIndexed$"))
            {
                this.IsIndexed = new System.Boolean();
            }
            //      C# -> System.Boolean? IsOnDemandSnapshot
            // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
            if (this.IsOnDemandSnapshot == null && Exploration.Includes(parent + ".isOnDemandSnapshot$"))
            {
                this.IsOnDemandSnapshot = new System.Boolean();
            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined$"))
            {
                this.IsQuarantined = new System.Boolean();
            }
            //      C# -> System.Boolean? IsReplica
            // GraphQL -> isReplica: Boolean (scalar)
            if (this.IsReplica == null && Exploration.Includes(parent + ".isReplica$"))
            {
                this.IsReplica = new System.Boolean();
            }
            //      C# -> System.Boolean? IsReplicated
            // GraphQL -> isReplicated: Boolean! (scalar)
            if (this.IsReplicated == null && Exploration.Includes(parent + ".isReplicated$"))
            {
                this.IsReplicated = new System.Boolean();
            }
            //      C# -> System.Boolean? IsUnindexable
            // GraphQL -> isUnindexable: Boolean! (scalar)
            if (this.IsUnindexable == null && Exploration.Includes(parent + ".isUnindexable$"))
            {
                this.IsUnindexable = new System.Boolean();
            }
            //      C# -> System.String? ParentSnapshotId
            // GraphQL -> parentSnapshotId: String (scalar)
            if (this.ParentSnapshotId == null && Exploration.Includes(parent + ".parentSnapshotId$"))
            {
                this.ParentSnapshotId = new System.String("FETCH");
            }
            //      C# -> System.Int32? SequenceNumber
            // GraphQL -> sequenceNumber: Int! (scalar)
            if (this.SequenceNumber == null && Exploration.Includes(parent + ".sequenceNumber$"))
            {
                this.SequenceNumber = new System.Int32();
            }
            //      C# -> System.String? SnappableId
            // GraphQL -> snappableId: String! (scalar)
            if (this.SnappableId == null && Exploration.Includes(parent + ".snappableId$"))
            {
                this.SnappableId = new System.String("FETCH");
            }
            //      C# -> System.Int32? UnexpiredArchivedSnapshotCount
            // GraphQL -> unexpiredArchivedSnapshotCount: Int! (scalar)
            if (this.UnexpiredArchivedSnapshotCount == null && Exploration.Includes(parent + ".unexpiredArchivedSnapshotCount$"))
            {
                this.UnexpiredArchivedSnapshotCount = new System.Int32();
            }
            //      C# -> System.Int32? UnexpiredReplicaCount
            // GraphQL -> unexpiredReplicaCount: Int! (scalar)
            if (this.UnexpiredReplicaCount == null && Exploration.Includes(parent + ".unexpiredReplicaCount$"))
            {
                this.UnexpiredReplicaCount = new System.Int32();
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
            {
                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFragment(parent + ".latestUserNote");
            }
            //      C# -> List<DataLocation>? ReplicationLocations
            // GraphQL -> replicationLocations: [DataLocation!] (type)
            if (this.ReplicationLocations == null && Exploration.Includes(parent + ".replicationLocations"))
            {
                this.ReplicationLocations = new List<DataLocation>();
                this.ReplicationLocations.ApplyExploratoryFragment(parent + ".replicationLocations");
            }
            //      C# -> SnapshotConsistencyLevel? ConsistencyLevel
            // GraphQL -> consistencyLevel: SnapshotConsistencyLevel! (enum)
            if (this.ConsistencyLevel == null && Exploration.Includes(parent + ".consistencyLevel$"))
            {
                this.ConsistencyLevel = new SnapshotConsistencyLevel();
            }
            //      C# -> PolarisSpecificSnapshot? PolarisSpecificSnapshot
            // GraphQL -> polarisSpecificSnapshot: PolarisSpecificSnapshot (interface)
            if (this.PolarisSpecificSnapshot == null && Exploration.Includes(parent + ".polarisSpecificSnapshot"))
            {
                this.PolarisSpecificSnapshot = (PolarisSpecificSnapshot)InterfaceHelper.CreateInstanceOfFirstType(typeof(PolarisSpecificSnapshot));
                this.PolarisSpecificSnapshot.ApplyExploratoryFragment(parent + ".polarisSpecificSnapshot");
            }
            //      C# -> SlaDomain? SlaDomain
            // GraphQL -> slaDomain: SlaDomain (interface)
            if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
            {
                this.SlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.SlaDomain.ApplyExploratoryFragment(parent + ".slaDomain");
            }
        }


    #endregion

    } // class PolarisSnapshot
    #endregion

    public static class ListPolarisSnapshotExtensions
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
            this List<PolarisSnapshot> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PolarisSnapshot> list, 
            String parent = "")
        {
            var item = new PolarisSnapshot();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types