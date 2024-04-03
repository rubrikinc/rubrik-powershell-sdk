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

    public override string GetGqlTypeName() {
        return "PolarisSnapshot";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SnapshotConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotConsistencyLevel! (enum)
        if (this.ConsistencyLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "consistencyLevel\n" ;
            } else {
                s += ind + "consistencyLevel\n" ;
            }
        }
        //      C# -> PolarisSpecificSnapshot? PolarisSpecificSnapshot
        // GraphQL -> polarisSpecificSnapshot: PolarisSpecificSnapshot (interface)
        if (this.PolarisSpecificSnapshot != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.PolarisSpecificSnapshot, conf.Child("polarisSpecificSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "polarisSpecificSnapshot" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.SlaDomain, conf.Child("slaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
            }
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiryHint\n" ;
            } else {
                s += ind + "expiryHint\n" ;
            }
        }
        //      C# -> System.Boolean? HasUnexpiredArchivedCopy
        // GraphQL -> hasUnexpiredArchivedCopy: Boolean! (scalar)
        if (this.HasUnexpiredArchivedCopy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasUnexpiredArchivedCopy\n" ;
            } else {
                s += ind + "hasUnexpiredArchivedCopy\n" ;
            }
        }
        //      C# -> System.Boolean? HasUnexpiredReplica
        // GraphQL -> hasUnexpiredReplica: Boolean! (scalar)
        if (this.HasUnexpiredReplica != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasUnexpiredReplica\n" ;
            } else {
                s += ind + "hasUnexpiredReplica\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (this.IndexTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexTime\n" ;
            } else {
                s += ind + "indexTime\n" ;
            }
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexingAttempts\n" ;
            } else {
                s += ind + "indexingAttempts\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchivalCopy
        // GraphQL -> isArchivalCopy: Boolean (scalar)
        if (this.IsArchivalCopy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchivalCopy\n" ;
            } else {
                s += ind + "isArchivalCopy\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCorrupted\n" ;
            } else {
                s += ind + "isCorrupted\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeletedFromSource
        // GraphQL -> isDeletedFromSource: Boolean! (scalar)
        if (this.IsDeletedFromSource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeletedFromSource\n" ;
            } else {
                s += ind + "isDeletedFromSource\n" ;
            }
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (this.IsDownloadedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDownloadedSnapshot\n" ;
            } else {
                s += ind + "isDownloadedSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExpired\n" ;
            } else {
                s += ind + "isExpired\n" ;
            }
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isIndexed\n" ;
            } else {
                s += ind + "isIndexed\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnDemandSnapshot\n" ;
            } else {
                s += ind + "isOnDemandSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantined\n" ;
            } else {
                s += ind + "isQuarantined\n" ;
            }
        }
        //      C# -> System.Boolean? IsReplica
        // GraphQL -> isReplica: Boolean (scalar)
        if (this.IsReplica != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReplica\n" ;
            } else {
                s += ind + "isReplica\n" ;
            }
        }
        //      C# -> System.Boolean? IsReplicated
        // GraphQL -> isReplicated: Boolean! (scalar)
        if (this.IsReplicated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReplicated\n" ;
            } else {
                s += ind + "isReplicated\n" ;
            }
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUnindexable\n" ;
            } else {
                s += ind + "isUnindexable\n" ;
            }
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (this.ParentSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentSnapshotId\n" ;
            } else {
                s += ind + "parentSnapshotId\n" ;
            }
        }
        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        if (this.SequenceNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sequenceNumber\n" ;
            } else {
                s += ind + "sequenceNumber\n" ;
            }
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> System.Int32? UnexpiredArchivedSnapshotCount
        // GraphQL -> unexpiredArchivedSnapshotCount: Int! (scalar)
        if (this.UnexpiredArchivedSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unexpiredArchivedSnapshotCount\n" ;
            } else {
                s += ind + "unexpiredArchivedSnapshotCount\n" ;
            }
        }
        //      C# -> System.Int32? UnexpiredReplicaCount
        // GraphQL -> unexpiredReplicaCount: Int! (scalar)
        if (this.UnexpiredReplicaCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unexpiredReplicaCount\n" ;
            } else {
                s += ind + "unexpiredReplicaCount\n" ;
            }
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(conf.Child("latestUserNote"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestUserNote" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataLocation>? ReplicationLocations
        // GraphQL -> replicationLocations: [DataLocation!] (type)
        if (this.ReplicationLocations != null) {
            var fspec = this.ReplicationLocations.AsFieldSpec(conf.Child("replicationLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationLocations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotConsistencyLevel? ConsistencyLevel
        // GraphQL -> consistencyLevel: SnapshotConsistencyLevel! (enum)
        if (ec.Includes("consistencyLevel",true))
        {
            if(this.ConsistencyLevel == null) {

                this.ConsistencyLevel = new SnapshotConsistencyLevel();

            } else {


            }
        }
        else if (this.ConsistencyLevel != null && ec.Excludes("consistencyLevel",true))
        {
            this.ConsistencyLevel = null;
        }
        //      C# -> PolarisSpecificSnapshot? PolarisSpecificSnapshot
        // GraphQL -> polarisSpecificSnapshot: PolarisSpecificSnapshot (interface)
        if (ec.Includes("polarisSpecificSnapshot",false))
        {
            if(this.PolarisSpecificSnapshot == null) {

                var impls = new List<PolarisSpecificSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("polarisSpecificSnapshot"));
                this.PolarisSpecificSnapshot = (PolarisSpecificSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<PolarisSpecificSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("polarisSpecificSnapshot"));
                this.PolarisSpecificSnapshot = (PolarisSpecificSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.PolarisSpecificSnapshot != null && ec.Excludes("polarisSpecificSnapshot",false))
        {
            this.PolarisSpecificSnapshot = null;
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (ec.Includes("slaDomain",false))
        {
            if(this.SlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));
                this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));
                this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",false))
        {
            this.SlaDomain = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (ec.Includes("expirationDate",true))
        {
            if(this.ExpirationDate == null) {

                this.ExpirationDate = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationDate != null && ec.Excludes("expirationDate",true))
        {
            this.ExpirationDate = null;
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (ec.Includes("expiryHint",true))
        {
            if(this.ExpiryHint == null) {

                this.ExpiryHint = true;

            } else {


            }
        }
        else if (this.ExpiryHint != null && ec.Excludes("expiryHint",true))
        {
            this.ExpiryHint = null;
        }
        //      C# -> System.Boolean? HasUnexpiredArchivedCopy
        // GraphQL -> hasUnexpiredArchivedCopy: Boolean! (scalar)
        if (ec.Includes("hasUnexpiredArchivedCopy",true))
        {
            if(this.HasUnexpiredArchivedCopy == null) {

                this.HasUnexpiredArchivedCopy = true;

            } else {


            }
        }
        else if (this.HasUnexpiredArchivedCopy != null && ec.Excludes("hasUnexpiredArchivedCopy",true))
        {
            this.HasUnexpiredArchivedCopy = null;
        }
        //      C# -> System.Boolean? HasUnexpiredReplica
        // GraphQL -> hasUnexpiredReplica: Boolean! (scalar)
        if (ec.Includes("hasUnexpiredReplica",true))
        {
            if(this.HasUnexpiredReplica == null) {

                this.HasUnexpiredReplica = true;

            } else {


            }
        }
        else if (this.HasUnexpiredReplica != null && ec.Excludes("hasUnexpiredReplica",true))
        {
            this.HasUnexpiredReplica = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (ec.Includes("indexTime",true))
        {
            if(this.IndexTime == null) {

                this.IndexTime = new DateTime();

            } else {


            }
        }
        else if (this.IndexTime != null && ec.Excludes("indexTime",true))
        {
            this.IndexTime = null;
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (ec.Includes("indexingAttempts",true))
        {
            if(this.IndexingAttempts == null) {

                this.IndexingAttempts = new System.Int64();

            } else {


            }
        }
        else if (this.IndexingAttempts != null && ec.Excludes("indexingAttempts",true))
        {
            this.IndexingAttempts = null;
        }
        //      C# -> System.Boolean? IsArchivalCopy
        // GraphQL -> isArchivalCopy: Boolean (scalar)
        if (ec.Includes("isArchivalCopy",true))
        {
            if(this.IsArchivalCopy == null) {

                this.IsArchivalCopy = true;

            } else {


            }
        }
        else if (this.IsArchivalCopy != null && ec.Excludes("isArchivalCopy",true))
        {
            this.IsArchivalCopy = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (ec.Includes("isCorrupted",true))
        {
            if(this.IsCorrupted == null) {

                this.IsCorrupted = true;

            } else {


            }
        }
        else if (this.IsCorrupted != null && ec.Excludes("isCorrupted",true))
        {
            this.IsCorrupted = null;
        }
        //      C# -> System.Boolean? IsDeletedFromSource
        // GraphQL -> isDeletedFromSource: Boolean! (scalar)
        if (ec.Includes("isDeletedFromSource",true))
        {
            if(this.IsDeletedFromSource == null) {

                this.IsDeletedFromSource = true;

            } else {


            }
        }
        else if (this.IsDeletedFromSource != null && ec.Excludes("isDeletedFromSource",true))
        {
            this.IsDeletedFromSource = null;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (ec.Includes("isDownloadedSnapshot",true))
        {
            if(this.IsDownloadedSnapshot == null) {

                this.IsDownloadedSnapshot = true;

            } else {


            }
        }
        else if (this.IsDownloadedSnapshot != null && ec.Excludes("isDownloadedSnapshot",true))
        {
            this.IsDownloadedSnapshot = null;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (ec.Includes("isExpired",true))
        {
            if(this.IsExpired == null) {

                this.IsExpired = true;

            } else {


            }
        }
        else if (this.IsExpired != null && ec.Excludes("isExpired",true))
        {
            this.IsExpired = null;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (ec.Includes("isIndexed",true))
        {
            if(this.IsIndexed == null) {

                this.IsIndexed = true;

            } else {


            }
        }
        else if (this.IsIndexed != null && ec.Excludes("isIndexed",true))
        {
            this.IsIndexed = null;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (ec.Includes("isOnDemandSnapshot",true))
        {
            if(this.IsOnDemandSnapshot == null) {

                this.IsOnDemandSnapshot = true;

            } else {


            }
        }
        else if (this.IsOnDemandSnapshot != null && ec.Excludes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = null;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (ec.Includes("isQuarantined",true))
        {
            if(this.IsQuarantined == null) {

                this.IsQuarantined = true;

            } else {


            }
        }
        else if (this.IsQuarantined != null && ec.Excludes("isQuarantined",true))
        {
            this.IsQuarantined = null;
        }
        //      C# -> System.Boolean? IsReplica
        // GraphQL -> isReplica: Boolean (scalar)
        if (ec.Includes("isReplica",true))
        {
            if(this.IsReplica == null) {

                this.IsReplica = true;

            } else {


            }
        }
        else if (this.IsReplica != null && ec.Excludes("isReplica",true))
        {
            this.IsReplica = null;
        }
        //      C# -> System.Boolean? IsReplicated
        // GraphQL -> isReplicated: Boolean! (scalar)
        if (ec.Includes("isReplicated",true))
        {
            if(this.IsReplicated == null) {

                this.IsReplicated = true;

            } else {


            }
        }
        else if (this.IsReplicated != null && ec.Excludes("isReplicated",true))
        {
            this.IsReplicated = null;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (ec.Includes("isUnindexable",true))
        {
            if(this.IsUnindexable == null) {

                this.IsUnindexable = true;

            } else {


            }
        }
        else if (this.IsUnindexable != null && ec.Excludes("isUnindexable",true))
        {
            this.IsUnindexable = null;
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (ec.Includes("parentSnapshotId",true))
        {
            if(this.ParentSnapshotId == null) {

                this.ParentSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.ParentSnapshotId != null && ec.Excludes("parentSnapshotId",true))
        {
            this.ParentSnapshotId = null;
        }
        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int! (scalar)
        if (ec.Includes("sequenceNumber",true))
        {
            if(this.SequenceNumber == null) {

                this.SequenceNumber = Int32.MinValue;

            } else {


            }
        }
        else if (this.SequenceNumber != null && ec.Excludes("sequenceNumber",true))
        {
            this.SequenceNumber = null;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> System.Int32? UnexpiredArchivedSnapshotCount
        // GraphQL -> unexpiredArchivedSnapshotCount: Int! (scalar)
        if (ec.Includes("unexpiredArchivedSnapshotCount",true))
        {
            if(this.UnexpiredArchivedSnapshotCount == null) {

                this.UnexpiredArchivedSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UnexpiredArchivedSnapshotCount != null && ec.Excludes("unexpiredArchivedSnapshotCount",true))
        {
            this.UnexpiredArchivedSnapshotCount = null;
        }
        //      C# -> System.Int32? UnexpiredReplicaCount
        // GraphQL -> unexpiredReplicaCount: Int! (scalar)
        if (ec.Includes("unexpiredReplicaCount",true))
        {
            if(this.UnexpiredReplicaCount == null) {

                this.UnexpiredReplicaCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UnexpiredReplicaCount != null && ec.Excludes("unexpiredReplicaCount",true))
        {
            this.UnexpiredReplicaCount = null;
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (ec.Includes("latestUserNote",false))
        {
            if(this.LatestUserNote == null) {

                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));

            } else {

                this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));

            }
        }
        else if (this.LatestUserNote != null && ec.Excludes("latestUserNote",false))
        {
            this.LatestUserNote = null;
        }
        //      C# -> List<DataLocation>? ReplicationLocations
        // GraphQL -> replicationLocations: [DataLocation!] (type)
        if (ec.Includes("replicationLocations",false))
        {
            if(this.ReplicationLocations == null) {

                this.ReplicationLocations = new List<DataLocation>();
                this.ReplicationLocations.ApplyExploratoryFieldSpec(ec.NewChild("replicationLocations"));

            } else {

                this.ReplicationLocations.ApplyExploratoryFieldSpec(ec.NewChild("replicationLocations"));

            }
        }
        else if (this.ReplicationLocations != null && ec.Excludes("replicationLocations",false))
        {
            this.ReplicationLocations = null;
        }
    }


    #endregion

    } // class PolarisSnapshot
    
    #endregion

    public static class ListPolarisSnapshotExtensions
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
            this List<PolarisSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types