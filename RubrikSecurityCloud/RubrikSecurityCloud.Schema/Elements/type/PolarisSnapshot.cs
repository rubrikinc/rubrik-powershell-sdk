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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region PolarisSnapshot
 
    public class PolarisSnapshot: BaseType, GenericSnapshot
    {
        #region members

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


        #endregion

    #region methods

    public PolarisSnapshot Set(
        SnapshotConsistencyLevel? ConsistencyLevel = null,
        PolarisSpecificSnapshot? PolarisSpecificSnapshot = null,
        SlaDomain? SlaDomain = null,
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
        List<DataLocation>? ReplicationLocations = null
    ) 
    {
        if ( ConsistencyLevel != null ) {
            this.ConsistencyLevel = ConsistencyLevel;
        }
        if ( PolarisSpecificSnapshot != null ) {
            this.PolarisSpecificSnapshot = PolarisSpecificSnapshot;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SnapshotConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotConsistencyLevel! (enum)
        if (this.ConsistencyLevel != null) {
            s += ind + "consistencyLevel\n" ;
        }
        //      C# -> PolarisSpecificSnapshot? PolarisSpecificSnapshot
        // GraphQL -> polarisSpecificSnapshot: PolarisSpecificSnapshot (interface)
        if (this.PolarisSpecificSnapshot != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PolarisSpecificSnapshot).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "polarisSpecificSnapshot {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            s += ind + "expirationDate\n" ;
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint != null) {
            s += ind + "expiryHint\n" ;
        }
        //      C# -> System.Boolean? HasUnexpiredArchivedCopy
        // GraphQL -> hasUnexpiredArchivedCopy: Boolean! (scalar)
        if (this.HasUnexpiredArchivedCopy != null) {
            s += ind + "hasUnexpiredArchivedCopy\n" ;
        }
        //      C# -> System.Boolean? HasUnexpiredReplica
        // GraphQL -> hasUnexpiredReplica: Boolean! (scalar)
        if (this.HasUnexpiredReplica != null) {
            s += ind + "hasUnexpiredReplica\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (this.IndexTime != null) {
            s += ind + "indexTime\n" ;
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts != null) {
            s += ind + "indexingAttempts\n" ;
        }
        //      C# -> System.Boolean? IsArchivalCopy
        // GraphQL -> isArchivalCopy: Boolean (scalar)
        if (this.IsArchivalCopy != null) {
            s += ind + "isArchivalCopy\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted != null) {
            s += ind + "isCorrupted\n" ;
        }
        //      C# -> System.Boolean? IsDeletedFromSource
        // GraphQL -> isDeletedFromSource: Boolean! (scalar)
        if (this.IsDeletedFromSource != null) {
            s += ind + "isDeletedFromSource\n" ;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (this.IsDownloadedSnapshot != null) {
            s += ind + "isDownloadedSnapshot\n" ;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired != null) {
            s += ind + "isExpired\n" ;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed != null) {
            s += ind + "isIndexed\n" ;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            s += ind + "isOnDemandSnapshot\n" ;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            s += ind + "isQuarantined\n" ;
        }
        //      C# -> System.Boolean? IsReplica
        // GraphQL -> isReplica: Boolean (scalar)
        if (this.IsReplica != null) {
            s += ind + "isReplica\n" ;
        }
        //      C# -> System.Boolean? IsReplicated
        // GraphQL -> isReplicated: Boolean! (scalar)
        if (this.IsReplicated != null) {
            s += ind + "isReplicated\n" ;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable != null) {
            s += ind + "isUnindexable\n" ;
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (this.ParentSnapshotId != null) {
            s += ind + "parentSnapshotId\n" ;
        }
        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        if (this.SequenceNumber != null) {
            s += ind + "sequenceNumber\n" ;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> System.Int32? UnexpiredArchivedSnapshotCount
        // GraphQL -> unexpiredArchivedSnapshotCount: Int! (scalar)
        if (this.UnexpiredArchivedSnapshotCount != null) {
            s += ind + "unexpiredArchivedSnapshotCount\n" ;
        }
        //      C# -> System.Int32? UnexpiredReplicaCount
        // GraphQL -> unexpiredReplicaCount: Int! (scalar)
        if (this.UnexpiredReplicaCount != null) {
            s += ind + "unexpiredReplicaCount\n" ;
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestUserNote {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<DataLocation>? ReplicationLocations
        // GraphQL -> replicationLocations: [DataLocation!] (type)
        if (this.ReplicationLocations != null) {
            var fspec = this.ReplicationLocations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationLocations {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SnapshotConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotConsistencyLevel! (enum)
        if (this.ConsistencyLevel == null && Exploration.Includes(parent + ".consistencyLevel", true))
        {
            this.ConsistencyLevel = new SnapshotConsistencyLevel();
        }
        //      C# -> PolarisSpecificSnapshot? PolarisSpecificSnapshot
        // GraphQL -> polarisSpecificSnapshot: PolarisSpecificSnapshot (interface)
        if (this.PolarisSpecificSnapshot == null && Exploration.Includes(parent + ".polarisSpecificSnapshot"))
        {
            var impls = new List<PolarisSpecificSnapshot>();
            impls.ApplyExploratoryFieldSpec(parent + ".polarisSpecificSnapshot");
            this.PolarisSpecificSnapshot = (PolarisSpecificSnapshot)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".slaDomain");
            this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new DateTime();
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate == null && Exploration.Includes(parent + ".expirationDate", true))
        {
            this.ExpirationDate = new DateTime();
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint == null && Exploration.Includes(parent + ".expiryHint", true))
        {
            this.ExpiryHint = true;
        }
        //      C# -> System.Boolean? HasUnexpiredArchivedCopy
        // GraphQL -> hasUnexpiredArchivedCopy: Boolean! (scalar)
        if (this.HasUnexpiredArchivedCopy == null && Exploration.Includes(parent + ".hasUnexpiredArchivedCopy", true))
        {
            this.HasUnexpiredArchivedCopy = true;
        }
        //      C# -> System.Boolean? HasUnexpiredReplica
        // GraphQL -> hasUnexpiredReplica: Boolean! (scalar)
        if (this.HasUnexpiredReplica == null && Exploration.Includes(parent + ".hasUnexpiredReplica", true))
        {
            this.HasUnexpiredReplica = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (this.IndexTime == null && Exploration.Includes(parent + ".indexTime", true))
        {
            this.IndexTime = new DateTime();
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts == null && Exploration.Includes(parent + ".indexingAttempts", true))
        {
            this.IndexingAttempts = new System.Int64();
        }
        //      C# -> System.Boolean? IsArchivalCopy
        // GraphQL -> isArchivalCopy: Boolean (scalar)
        if (this.IsArchivalCopy == null && Exploration.Includes(parent + ".isArchivalCopy", true))
        {
            this.IsArchivalCopy = true;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted == null && Exploration.Includes(parent + ".isCorrupted", true))
        {
            this.IsCorrupted = true;
        }
        //      C# -> System.Boolean? IsDeletedFromSource
        // GraphQL -> isDeletedFromSource: Boolean! (scalar)
        if (this.IsDeletedFromSource == null && Exploration.Includes(parent + ".isDeletedFromSource", true))
        {
            this.IsDeletedFromSource = true;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (this.IsDownloadedSnapshot == null && Exploration.Includes(parent + ".isDownloadedSnapshot", true))
        {
            this.IsDownloadedSnapshot = true;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired == null && Exploration.Includes(parent + ".isExpired", true))
        {
            this.IsExpired = true;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed == null && Exploration.Includes(parent + ".isIndexed", true))
        {
            this.IsIndexed = true;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot == null && Exploration.Includes(parent + ".isOnDemandSnapshot", true))
        {
            this.IsOnDemandSnapshot = true;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined", true))
        {
            this.IsQuarantined = true;
        }
        //      C# -> System.Boolean? IsReplica
        // GraphQL -> isReplica: Boolean (scalar)
        if (this.IsReplica == null && Exploration.Includes(parent + ".isReplica", true))
        {
            this.IsReplica = true;
        }
        //      C# -> System.Boolean? IsReplicated
        // GraphQL -> isReplicated: Boolean! (scalar)
        if (this.IsReplicated == null && Exploration.Includes(parent + ".isReplicated", true))
        {
            this.IsReplicated = true;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable == null && Exploration.Includes(parent + ".isUnindexable", true))
        {
            this.IsUnindexable = true;
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (this.ParentSnapshotId == null && Exploration.Includes(parent + ".parentSnapshotId", true))
        {
            this.ParentSnapshotId = "FETCH";
        }
        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        if (this.SequenceNumber == null && Exploration.Includes(parent + ".sequenceNumber", true))
        {
            this.SequenceNumber = Int32.MinValue;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && Exploration.Includes(parent + ".snappableId", true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> System.Int32? UnexpiredArchivedSnapshotCount
        // GraphQL -> unexpiredArchivedSnapshotCount: Int! (scalar)
        if (this.UnexpiredArchivedSnapshotCount == null && Exploration.Includes(parent + ".unexpiredArchivedSnapshotCount", true))
        {
            this.UnexpiredArchivedSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.Int32? UnexpiredReplicaCount
        // GraphQL -> unexpiredReplicaCount: Int! (scalar)
        if (this.UnexpiredReplicaCount == null && Exploration.Includes(parent + ".unexpiredReplicaCount", true))
        {
            this.UnexpiredReplicaCount = Int32.MinValue;
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
        {
            this.LatestUserNote = new LatestUserNote();
            this.LatestUserNote.ApplyExploratoryFieldSpec(parent + ".latestUserNote");
        }
        //      C# -> List<DataLocation>? ReplicationLocations
        // GraphQL -> replicationLocations: [DataLocation!] (type)
        if (this.ReplicationLocations == null && Exploration.Includes(parent + ".replicationLocations"))
        {
            this.ReplicationLocations = new List<DataLocation>();
            this.ReplicationLocations.ApplyExploratoryFieldSpec(parent + ".replicationLocations");
        }
    }


    #endregion

    } // class PolarisSnapshot
    
    #endregion

    public static class ListPolarisSnapshotExtensions
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
            this List<PolarisSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisSnapshot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types