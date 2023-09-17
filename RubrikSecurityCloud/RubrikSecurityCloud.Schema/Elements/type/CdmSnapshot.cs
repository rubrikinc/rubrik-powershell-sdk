// CdmSnapshot.cs
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
    #region CdmSnapshot
 
    public class CdmSnapshot: BaseType, GenericSnapshot
    {
        #region members

        //      C# -> SnapshotCloudState? CloudState
        // GraphQL -> cloudState: SnapshotCloudState (enum)
        [JsonProperty("cloudState")]
        public SnapshotCloudState? CloudState { get; set; }

        //      C# -> ConsistencyLevelEnum? ConsistencyLevel
        // GraphQL -> consistencyLevel: ConsistencyLevelEnum (enum)
        [JsonProperty("consistencyLevel")]
        public ConsistencyLevelEnum? ConsistencyLevel { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        //      C# -> CdmHierarchySnappableNew? SnappableNew
        // GraphQL -> snappableNew: CdmHierarchySnappableNew! (interface)
        [JsonProperty("snappableNew")]
        public CdmHierarchySnappableNew? SnappableNew { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

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

        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        [JsonProperty("fileCount")]
        public System.Int64? FileCount { get; set; }

        //      C# -> System.Boolean? HasDelta
        // GraphQL -> hasDelta: Boolean! (scalar)
        [JsonProperty("hasDelta")]
        public System.Boolean? HasDelta { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        [JsonProperty("indexingAttempts")]
        public System.Int64? IndexingAttempts { get; set; }

        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        [JsonProperty("isAnomaly")]
        public System.Boolean? IsAnomaly { get; set; }

        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        [JsonProperty("isCorrupted")]
        public System.Boolean? IsCorrupted { get; set; }

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

        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        [JsonProperty("isRetentionLocked")]
        public System.Boolean? IsRetentionLocked { get; set; }

        //      C# -> System.Boolean? IsSapHanaIncrementalSnapshot
        // GraphQL -> isSapHanaIncrementalSnapshot: Boolean (scalar)
        [JsonProperty("isSapHanaIncrementalSnapshot")]
        public System.Boolean? IsSapHanaIncrementalSnapshot { get; set; }

        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        [JsonProperty("isUnindexable")]
        public System.Boolean? IsUnindexable { get; set; }

        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        [JsonProperty("parentSnapshotId")]
        public System.String? ParentSnapshotId { get; set; }

        //      C# -> System.String? ResourceSpec
        // GraphQL -> resourceSpec: String (scalar)
        [JsonProperty("resourceSpec")]
        public System.String? ResourceSpec { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> List<DataLocation>? ArchivalLocations
        // GraphQL -> archivalLocations: [DataLocation!] (type)
        [JsonProperty("archivalLocations")]
        public List<DataLocation>? ArchivalLocations { get; set; }

        //      C# -> List<CdmSnapshot>? ChildSnapshots
        // GraphQL -> childSnapshots: [CdmSnapshot!]! (type)
        [JsonProperty("childSnapshots")]
        public List<CdmSnapshot>? ChildSnapshots { get; set; }

        //      C# -> List<DataLocation>? CloudNativeLocations
        // GraphQL -> cloudNativeLocations: [DataLocation!] (type)
        [JsonProperty("cloudNativeLocations")]
        public List<DataLocation>? CloudNativeLocations { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> Db2AppMetadata? Db2AppMetadata
        // GraphQL -> db2AppMetadata: Db2AppMetadata (type)
        [JsonProperty("db2AppMetadata")]
        public Db2AppMetadata? Db2AppMetadata { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> LegalHoldInfo? LegalHoldInfo
        // GraphQL -> legalHoldInfo: LegalHoldInfo (type)
        [JsonProperty("legalHoldInfo")]
        public LegalHoldInfo? LegalHoldInfo { get; set; }

        //      C# -> List<DataLocation>? LocalLocations
        // GraphQL -> localLocations: [DataLocation!] (type)
        [JsonProperty("localLocations")]
        public List<DataLocation>? LocalLocations { get; set; }

        //      C# -> List<DataLocation>? Locations
        // GraphQL -> locations: [DataLocation!] (type)
        [JsonProperty("locations")]
        public List<DataLocation>? Locations { get; set; }

        //      C# -> ManagedVolumeAppMetadata? ManagedVolumeAppMetadata
        // GraphQL -> managedVolumeAppMetadata: ManagedVolumeAppMetadata (type)
        [JsonProperty("managedVolumeAppMetadata")]
        public ManagedVolumeAppMetadata? ManagedVolumeAppMetadata { get; set; }

        //      C# -> PendingSnapshotDeletion? PendingSnapshotDeletion
        // GraphQL -> pendingSnapshotDeletion: PendingSnapshotDeletion (type)
        [JsonProperty("pendingSnapshotDeletion")]
        public PendingSnapshotDeletion? PendingSnapshotDeletion { get; set; }

        //      C# -> List<DataLocation>? ReplicationLocations
        // GraphQL -> replicationLocations: [DataLocation!] (type)
        [JsonProperty("replicationLocations")]
        public List<DataLocation>? ReplicationLocations { get; set; }

        //      C# -> SapHanaAppMetadata? SapHanaAppMetadata
        // GraphQL -> sapHanaAppMetadata: SapHanaAppMetadata (type)
        [JsonProperty("sapHanaAppMetadata")]
        public SapHanaAppMetadata? SapHanaAppMetadata { get; set; }

        //      C# -> CdmSnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: CdmSnapshotRetentionInfo (type)
        [JsonProperty("snapshotRetentionInfo")]
        public CdmSnapshotRetentionInfo? SnapshotRetentionInfo { get; set; }

        //      C# -> List<VappAppMetadata>? VappAppMetadata
        // GraphQL -> vappAppMetadata: [VappAppMetadata!] (type)
        [JsonProperty("vappAppMetadata")]
        public List<VappAppMetadata>? VappAppMetadata { get; set; }

        //      C# -> VmwareAppMetadata? VmwareAppMetadata
        // GraphQL -> vmwareAppMetadata: VmwareAppMetadata (type)
        [JsonProperty("vmwareAppMetadata")]
        public VmwareAppMetadata? VmwareAppMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmSnapshot";
    }

    public CdmSnapshot Set(
        SnapshotCloudState? CloudState = null,
        ConsistencyLevelEnum? ConsistencyLevel = null,
        SlaDomain? PendingSla = null,
        SlaDomain? SlaDomain = null,
        CdmHierarchySnappableNew? SnappableNew = null,
        System.String? CdmId = null,
        System.String? CdmVersion = null,
        DateTime? Date = null,
        DateTime? ExpirationDate = null,
        System.Boolean? ExpiryHint = null,
        System.Int64? FileCount = null,
        System.Boolean? HasDelta = null,
        System.String? Id = null,
        System.Int64? IndexingAttempts = null,
        System.Boolean? IsAnomaly = null,
        System.Boolean? IsCorrupted = null,
        System.Boolean? IsDownloadedSnapshot = null,
        System.Boolean? IsExpired = null,
        System.Boolean? IsIndexed = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Boolean? IsQuarantined = null,
        System.Boolean? IsRetentionLocked = null,
        System.Boolean? IsSapHanaIncrementalSnapshot = null,
        System.Boolean? IsUnindexable = null,
        System.String? ParentSnapshotId = null,
        System.String? ResourceSpec = null,
        System.String? SnappableId = null,
        List<DataLocation>? ArchivalLocations = null,
        List<CdmSnapshot>? ChildSnapshots = null,
        List<DataLocation>? CloudNativeLocations = null,
        Cluster? Cluster = null,
        Db2AppMetadata? Db2AppMetadata = null,
        LatestUserNote? LatestUserNote = null,
        LegalHoldInfo? LegalHoldInfo = null,
        List<DataLocation>? LocalLocations = null,
        List<DataLocation>? Locations = null,
        ManagedVolumeAppMetadata? ManagedVolumeAppMetadata = null,
        PendingSnapshotDeletion? PendingSnapshotDeletion = null,
        List<DataLocation>? ReplicationLocations = null,
        SapHanaAppMetadata? SapHanaAppMetadata = null,
        CdmSnapshotRetentionInfo? SnapshotRetentionInfo = null,
        List<VappAppMetadata>? VappAppMetadata = null,
        VmwareAppMetadata? VmwareAppMetadata = null
    ) 
    {
        if ( CloudState != null ) {
            this.CloudState = CloudState;
        }
        if ( ConsistencyLevel != null ) {
            this.ConsistencyLevel = ConsistencyLevel;
        }
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( SnappableNew != null ) {
            this.SnappableNew = SnappableNew;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
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
        if ( FileCount != null ) {
            this.FileCount = FileCount;
        }
        if ( HasDelta != null ) {
            this.HasDelta = HasDelta;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IndexingAttempts != null ) {
            this.IndexingAttempts = IndexingAttempts;
        }
        if ( IsAnomaly != null ) {
            this.IsAnomaly = IsAnomaly;
        }
        if ( IsCorrupted != null ) {
            this.IsCorrupted = IsCorrupted;
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
        if ( IsRetentionLocked != null ) {
            this.IsRetentionLocked = IsRetentionLocked;
        }
        if ( IsSapHanaIncrementalSnapshot != null ) {
            this.IsSapHanaIncrementalSnapshot = IsSapHanaIncrementalSnapshot;
        }
        if ( IsUnindexable != null ) {
            this.IsUnindexable = IsUnindexable;
        }
        if ( ParentSnapshotId != null ) {
            this.ParentSnapshotId = ParentSnapshotId;
        }
        if ( ResourceSpec != null ) {
            this.ResourceSpec = ResourceSpec;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( ArchivalLocations != null ) {
            this.ArchivalLocations = ArchivalLocations;
        }
        if ( ChildSnapshots != null ) {
            this.ChildSnapshots = ChildSnapshots;
        }
        if ( CloudNativeLocations != null ) {
            this.CloudNativeLocations = CloudNativeLocations;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Db2AppMetadata != null ) {
            this.Db2AppMetadata = Db2AppMetadata;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LegalHoldInfo != null ) {
            this.LegalHoldInfo = LegalHoldInfo;
        }
        if ( LocalLocations != null ) {
            this.LocalLocations = LocalLocations;
        }
        if ( Locations != null ) {
            this.Locations = Locations;
        }
        if ( ManagedVolumeAppMetadata != null ) {
            this.ManagedVolumeAppMetadata = ManagedVolumeAppMetadata;
        }
        if ( PendingSnapshotDeletion != null ) {
            this.PendingSnapshotDeletion = PendingSnapshotDeletion;
        }
        if ( ReplicationLocations != null ) {
            this.ReplicationLocations = ReplicationLocations;
        }
        if ( SapHanaAppMetadata != null ) {
            this.SapHanaAppMetadata = SapHanaAppMetadata;
        }
        if ( SnapshotRetentionInfo != null ) {
            this.SnapshotRetentionInfo = SnapshotRetentionInfo;
        }
        if ( VappAppMetadata != null ) {
            this.VappAppMetadata = VappAppMetadata;
        }
        if ( VmwareAppMetadata != null ) {
            this.VmwareAppMetadata = VmwareAppMetadata;
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
        //      C# -> SnapshotCloudState? CloudState
        // GraphQL -> cloudState: SnapshotCloudState (enum)
        if (this.CloudState != null) {
            s += ind + "cloudState\n" ;
        }
        //      C# -> ConsistencyLevelEnum? ConsistencyLevel
        // GraphQL -> consistencyLevel: ConsistencyLevelEnum (enum)
        if (this.ConsistencyLevel != null) {
            s += ind + "consistencyLevel\n" ;
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSla {\n" + fspec + ind + "}\n";
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
        //      C# -> CdmHierarchySnappableNew? SnappableNew
        // GraphQL -> snappableNew: CdmHierarchySnappableNew! (interface)
        if (this.SnappableNew != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SnappableNew).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappableNew {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            s += ind + "cdmVersion\n" ;
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
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        if (this.FileCount != null) {
            s += ind + "fileCount\n" ;
        }
        //      C# -> System.Boolean? HasDelta
        // GraphQL -> hasDelta: Boolean! (scalar)
        if (this.HasDelta != null) {
            s += ind + "hasDelta\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts != null) {
            s += ind + "indexingAttempts\n" ;
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly != null) {
            s += ind + "isAnomaly\n" ;
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted != null) {
            s += ind + "isCorrupted\n" ;
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
        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        if (this.IsRetentionLocked != null) {
            s += ind + "isRetentionLocked\n" ;
        }
        //      C# -> System.Boolean? IsSapHanaIncrementalSnapshot
        // GraphQL -> isSapHanaIncrementalSnapshot: Boolean (scalar)
        if (this.IsSapHanaIncrementalSnapshot != null) {
            s += ind + "isSapHanaIncrementalSnapshot\n" ;
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
        //      C# -> System.String? ResourceSpec
        // GraphQL -> resourceSpec: String (scalar)
        if (this.ResourceSpec != null) {
            s += ind + "resourceSpec\n" ;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> List<DataLocation>? ArchivalLocations
        // GraphQL -> archivalLocations: [DataLocation!] (type)
        if (this.ArchivalLocations != null) {
            var fspec = this.ArchivalLocations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalLocations {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CdmSnapshot>? ChildSnapshots
        // GraphQL -> childSnapshots: [CdmSnapshot!]! (type)
        if (this.ChildSnapshots != null) {
            var fspec = this.ChildSnapshots.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "childSnapshots {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<DataLocation>? CloudNativeLocations
        // GraphQL -> cloudNativeLocations: [DataLocation!] (type)
        if (this.CloudNativeLocations != null) {
            var fspec = this.CloudNativeLocations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudNativeLocations {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Db2AppMetadata? Db2AppMetadata
        // GraphQL -> db2AppMetadata: Db2AppMetadata (type)
        if (this.Db2AppMetadata != null) {
            var fspec = this.Db2AppMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "db2AppMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestUserNote {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LegalHoldInfo? LegalHoldInfo
        // GraphQL -> legalHoldInfo: LegalHoldInfo (type)
        if (this.LegalHoldInfo != null) {
            var fspec = this.LegalHoldInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "legalHoldInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<DataLocation>? LocalLocations
        // GraphQL -> localLocations: [DataLocation!] (type)
        if (this.LocalLocations != null) {
            var fspec = this.LocalLocations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "localLocations {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<DataLocation>? Locations
        // GraphQL -> locations: [DataLocation!] (type)
        if (this.Locations != null) {
            var fspec = this.Locations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "locations {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeAppMetadata? ManagedVolumeAppMetadata
        // GraphQL -> managedVolumeAppMetadata: ManagedVolumeAppMetadata (type)
        if (this.ManagedVolumeAppMetadata != null) {
            var fspec = this.ManagedVolumeAppMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "managedVolumeAppMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PendingSnapshotDeletion? PendingSnapshotDeletion
        // GraphQL -> pendingSnapshotDeletion: PendingSnapshotDeletion (type)
        if (this.PendingSnapshotDeletion != null) {
            var fspec = this.PendingSnapshotDeletion.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSnapshotDeletion {\n" + fspec + ind + "}\n" ;
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
        //      C# -> SapHanaAppMetadata? SapHanaAppMetadata
        // GraphQL -> sapHanaAppMetadata: SapHanaAppMetadata (type)
        if (this.SapHanaAppMetadata != null) {
            var fspec = this.SapHanaAppMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sapHanaAppMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: CdmSnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo != null) {
            var fspec = this.SnapshotRetentionInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotRetentionInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VappAppMetadata>? VappAppMetadata
        // GraphQL -> vappAppMetadata: [VappAppMetadata!] (type)
        if (this.VappAppMetadata != null) {
            var fspec = this.VappAppMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vappAppMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VmwareAppMetadata? VmwareAppMetadata
        // GraphQL -> vmwareAppMetadata: VmwareAppMetadata (type)
        if (this.VmwareAppMetadata != null) {
            var fspec = this.VmwareAppMetadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmwareAppMetadata {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotCloudState? CloudState
        // GraphQL -> cloudState: SnapshotCloudState (enum)
        if (this.CloudState == null && ec.Includes("cloudState",true))
        {
            this.CloudState = new SnapshotCloudState();
        }
        //      C# -> ConsistencyLevelEnum? ConsistencyLevel
        // GraphQL -> consistencyLevel: ConsistencyLevelEnum (enum)
        if (this.ConsistencyLevel == null && ec.Includes("consistencyLevel",true))
        {
            this.ConsistencyLevel = new ConsistencyLevelEnum();
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla == null && ec.Includes("pendingSla",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
            this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain == null && ec.Includes("slaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));
            this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> CdmHierarchySnappableNew? SnappableNew
        // GraphQL -> snappableNew: CdmHierarchySnappableNew! (interface)
        if (this.SnappableNew == null && ec.Includes("snappableNew",false))
        {
            var impls = new List<CdmHierarchySnappableNew>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("snappableNew"));
            this.SnappableNew = (CdmHierarchySnappableNew)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && ec.Includes("cdmId",true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion == null && ec.Includes("cdmVersion",true))
        {
            this.CdmVersion = "FETCH";
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date == null && ec.Includes("date",true))
        {
            this.Date = new DateTime();
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate == null && ec.Includes("expirationDate",true))
        {
            this.ExpirationDate = new DateTime();
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint == null && ec.Includes("expiryHint",true))
        {
            this.ExpiryHint = true;
        }
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        if (this.FileCount == null && ec.Includes("fileCount",true))
        {
            this.FileCount = new System.Int64();
        }
        //      C# -> System.Boolean? HasDelta
        // GraphQL -> hasDelta: Boolean! (scalar)
        if (this.HasDelta == null && ec.Includes("hasDelta",true))
        {
            this.HasDelta = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts == null && ec.Includes("indexingAttempts",true))
        {
            this.IndexingAttempts = new System.Int64();
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly == null && ec.Includes("isAnomaly",true))
        {
            this.IsAnomaly = true;
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted == null && ec.Includes("isCorrupted",true))
        {
            this.IsCorrupted = true;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (this.IsDownloadedSnapshot == null && ec.Includes("isDownloadedSnapshot",true))
        {
            this.IsDownloadedSnapshot = true;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired == null && ec.Includes("isExpired",true))
        {
            this.IsExpired = true;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed == null && ec.Includes("isIndexed",true))
        {
            this.IsIndexed = true;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot == null && ec.Includes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = true;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && ec.Includes("isQuarantined",true))
        {
            this.IsQuarantined = true;
        }
        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        if (this.IsRetentionLocked == null && ec.Includes("isRetentionLocked",true))
        {
            this.IsRetentionLocked = true;
        }
        //      C# -> System.Boolean? IsSapHanaIncrementalSnapshot
        // GraphQL -> isSapHanaIncrementalSnapshot: Boolean (scalar)
        if (this.IsSapHanaIncrementalSnapshot == null && ec.Includes("isSapHanaIncrementalSnapshot",true))
        {
            this.IsSapHanaIncrementalSnapshot = true;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable == null && ec.Includes("isUnindexable",true))
        {
            this.IsUnindexable = true;
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (this.ParentSnapshotId == null && ec.Includes("parentSnapshotId",true))
        {
            this.ParentSnapshotId = "FETCH";
        }
        //      C# -> System.String? ResourceSpec
        // GraphQL -> resourceSpec: String (scalar)
        if (this.ResourceSpec == null && ec.Includes("resourceSpec",true))
        {
            this.ResourceSpec = "FETCH";
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && ec.Includes("snappableId",true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> List<DataLocation>? ArchivalLocations
        // GraphQL -> archivalLocations: [DataLocation!] (type)
        if (this.ArchivalLocations == null && ec.Includes("archivalLocations",false))
        {
            this.ArchivalLocations = new List<DataLocation>();
            this.ArchivalLocations.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocations"));
        }
        //      C# -> List<CdmSnapshot>? ChildSnapshots
        // GraphQL -> childSnapshots: [CdmSnapshot!]! (type)
        if (this.ChildSnapshots == null && ec.Includes("childSnapshots",false))
        {
            this.ChildSnapshots = new List<CdmSnapshot>();
            this.ChildSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("childSnapshots"));
        }
        //      C# -> List<DataLocation>? CloudNativeLocations
        // GraphQL -> cloudNativeLocations: [DataLocation!] (type)
        if (this.CloudNativeLocations == null && ec.Includes("cloudNativeLocations",false))
        {
            this.CloudNativeLocations = new List<DataLocation>();
            this.CloudNativeLocations.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeLocations"));
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> Db2AppMetadata? Db2AppMetadata
        // GraphQL -> db2AppMetadata: Db2AppMetadata (type)
        if (this.Db2AppMetadata == null && ec.Includes("db2AppMetadata",false))
        {
            this.Db2AppMetadata = new Db2AppMetadata();
            this.Db2AppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("db2AppMetadata"));
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote == null && ec.Includes("latestUserNote",false))
        {
            this.LatestUserNote = new LatestUserNote();
            this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));
        }
        //      C# -> LegalHoldInfo? LegalHoldInfo
        // GraphQL -> legalHoldInfo: LegalHoldInfo (type)
        if (this.LegalHoldInfo == null && ec.Includes("legalHoldInfo",false))
        {
            this.LegalHoldInfo = new LegalHoldInfo();
            this.LegalHoldInfo.ApplyExploratoryFieldSpec(ec.NewChild("legalHoldInfo"));
        }
        //      C# -> List<DataLocation>? LocalLocations
        // GraphQL -> localLocations: [DataLocation!] (type)
        if (this.LocalLocations == null && ec.Includes("localLocations",false))
        {
            this.LocalLocations = new List<DataLocation>();
            this.LocalLocations.ApplyExploratoryFieldSpec(ec.NewChild("localLocations"));
        }
        //      C# -> List<DataLocation>? Locations
        // GraphQL -> locations: [DataLocation!] (type)
        if (this.Locations == null && ec.Includes("locations",false))
        {
            this.Locations = new List<DataLocation>();
            this.Locations.ApplyExploratoryFieldSpec(ec.NewChild("locations"));
        }
        //      C# -> ManagedVolumeAppMetadata? ManagedVolumeAppMetadata
        // GraphQL -> managedVolumeAppMetadata: ManagedVolumeAppMetadata (type)
        if (this.ManagedVolumeAppMetadata == null && ec.Includes("managedVolumeAppMetadata",false))
        {
            this.ManagedVolumeAppMetadata = new ManagedVolumeAppMetadata();
            this.ManagedVolumeAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeAppMetadata"));
        }
        //      C# -> PendingSnapshotDeletion? PendingSnapshotDeletion
        // GraphQL -> pendingSnapshotDeletion: PendingSnapshotDeletion (type)
        if (this.PendingSnapshotDeletion == null && ec.Includes("pendingSnapshotDeletion",false))
        {
            this.PendingSnapshotDeletion = new PendingSnapshotDeletion();
            this.PendingSnapshotDeletion.ApplyExploratoryFieldSpec(ec.NewChild("pendingSnapshotDeletion"));
        }
        //      C# -> List<DataLocation>? ReplicationLocations
        // GraphQL -> replicationLocations: [DataLocation!] (type)
        if (this.ReplicationLocations == null && ec.Includes("replicationLocations",false))
        {
            this.ReplicationLocations = new List<DataLocation>();
            this.ReplicationLocations.ApplyExploratoryFieldSpec(ec.NewChild("replicationLocations"));
        }
        //      C# -> SapHanaAppMetadata? SapHanaAppMetadata
        // GraphQL -> sapHanaAppMetadata: SapHanaAppMetadata (type)
        if (this.SapHanaAppMetadata == null && ec.Includes("sapHanaAppMetadata",false))
        {
            this.SapHanaAppMetadata = new SapHanaAppMetadata();
            this.SapHanaAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("sapHanaAppMetadata"));
        }
        //      C# -> CdmSnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: CdmSnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo == null && ec.Includes("snapshotRetentionInfo",false))
        {
            this.SnapshotRetentionInfo = new CdmSnapshotRetentionInfo();
            this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));
        }
        //      C# -> List<VappAppMetadata>? VappAppMetadata
        // GraphQL -> vappAppMetadata: [VappAppMetadata!] (type)
        if (this.VappAppMetadata == null && ec.Includes("vappAppMetadata",false))
        {
            this.VappAppMetadata = new List<VappAppMetadata>();
            this.VappAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("vappAppMetadata"));
        }
        //      C# -> VmwareAppMetadata? VmwareAppMetadata
        // GraphQL -> vmwareAppMetadata: VmwareAppMetadata (type)
        if (this.VmwareAppMetadata == null && ec.Includes("vmwareAppMetadata",false))
        {
            this.VmwareAppMetadata = new VmwareAppMetadata();
            this.VmwareAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("vmwareAppMetadata"));
        }
    }


    #endregion

    } // class CdmSnapshot
    
    #endregion

    public static class ListCdmSnapshotExtensions
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
            this List<CdmSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types