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

        //      C# -> ActiveDirectoryAppMetadata? ActiveDirectoryAppMetadata
        // GraphQL -> activeDirectoryAppMetadata: ActiveDirectoryAppMetadata (type)
        [JsonProperty("activeDirectoryAppMetadata")]
        public ActiveDirectoryAppMetadata? ActiveDirectoryAppMetadata { get; set; }

        //      C# -> List<DataLocation>? ArchivalLocations
        // GraphQL -> archivalLocations: [DataLocation!] (type)
        [JsonProperty("archivalLocations")]
        public List<DataLocation>? ArchivalLocations { get; set; }

        //      C# -> CdmWorkloadSnapshot? CdmWorkloadSnapshot
        // GraphQL -> cdmWorkloadSnapshot: CdmWorkloadSnapshot (type)
        [JsonProperty("cdmWorkloadSnapshot")]
        public CdmWorkloadSnapshot? CdmWorkloadSnapshot { get; set; }

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

        //      C# -> MssqlAppMetadata? MssqlAppMetadata
        // GraphQL -> mssqlAppMetadata: MssqlAppMetadata (type)
        [JsonProperty("mssqlAppMetadata")]
        public MssqlAppMetadata? MssqlAppMetadata { get; set; }

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
        ActiveDirectoryAppMetadata? ActiveDirectoryAppMetadata = null,
        List<DataLocation>? ArchivalLocations = null,
        CdmWorkloadSnapshot? CdmWorkloadSnapshot = null,
        List<CdmSnapshot>? ChildSnapshots = null,
        List<DataLocation>? CloudNativeLocations = null,
        Cluster? Cluster = null,
        Db2AppMetadata? Db2AppMetadata = null,
        LatestUserNote? LatestUserNote = null,
        LegalHoldInfo? LegalHoldInfo = null,
        List<DataLocation>? LocalLocations = null,
        List<DataLocation>? Locations = null,
        ManagedVolumeAppMetadata? ManagedVolumeAppMetadata = null,
        MssqlAppMetadata? MssqlAppMetadata = null,
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
        if ( ActiveDirectoryAppMetadata != null ) {
            this.ActiveDirectoryAppMetadata = ActiveDirectoryAppMetadata;
        }
        if ( ArchivalLocations != null ) {
            this.ArchivalLocations = ArchivalLocations;
        }
        if ( CdmWorkloadSnapshot != null ) {
            this.CdmWorkloadSnapshot = CdmWorkloadSnapshot;
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
        if ( MssqlAppMetadata != null ) {
            this.MssqlAppMetadata = MssqlAppMetadata;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SnapshotCloudState? CloudState
        // GraphQL -> cloudState: SnapshotCloudState (enum)
        if (this.CloudState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudState\n" ;
            } else {
                s += ind + "cloudState\n" ;
            }
        }
        //      C# -> ConsistencyLevelEnum? ConsistencyLevel
        // GraphQL -> consistencyLevel: ConsistencyLevelEnum (enum)
        if (this.ConsistencyLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "consistencyLevel\n" ;
            } else {
                s += ind + "consistencyLevel\n" ;
            }
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.PendingSla, conf.Child("pendingSla"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSla" + " " + "{\n" + fspec + ind + "}\n";
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
        //      C# -> CdmHierarchySnappableNew? SnappableNew
        // GraphQL -> snappableNew: CdmHierarchySnappableNew! (interface)
        if (this.SnappableNew != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.SnappableNew, conf.Child("snappableNew"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappableNew" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmVersion\n" ;
            } else {
                s += ind + "cdmVersion\n" ;
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
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        if (this.FileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileCount\n" ;
            } else {
                s += ind + "fileCount\n" ;
            }
        }
        //      C# -> System.Boolean? HasDelta
        // GraphQL -> hasDelta: Boolean! (scalar)
        if (this.HasDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasDelta\n" ;
            } else {
                s += ind + "hasDelta\n" ;
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
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexingAttempts\n" ;
            } else {
                s += ind + "indexingAttempts\n" ;
            }
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomaly\n" ;
            } else {
                s += ind + "isAnomaly\n" ;
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
        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        if (this.IsRetentionLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRetentionLocked\n" ;
            } else {
                s += ind + "isRetentionLocked\n" ;
            }
        }
        //      C# -> System.Boolean? IsSapHanaIncrementalSnapshot
        // GraphQL -> isSapHanaIncrementalSnapshot: Boolean (scalar)
        if (this.IsSapHanaIncrementalSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSapHanaIncrementalSnapshot\n" ;
            } else {
                s += ind + "isSapHanaIncrementalSnapshot\n" ;
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
        //      C# -> System.String? ResourceSpec
        // GraphQL -> resourceSpec: String (scalar)
        if (this.ResourceSpec != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceSpec\n" ;
            } else {
                s += ind + "resourceSpec\n" ;
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
        //      C# -> ActiveDirectoryAppMetadata? ActiveDirectoryAppMetadata
        // GraphQL -> activeDirectoryAppMetadata: ActiveDirectoryAppMetadata (type)
        if (this.ActiveDirectoryAppMetadata != null) {
            var fspec = this.ActiveDirectoryAppMetadata.AsFieldSpec(conf.Child("activeDirectoryAppMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activeDirectoryAppMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataLocation>? ArchivalLocations
        // GraphQL -> archivalLocations: [DataLocation!] (type)
        if (this.ArchivalLocations != null) {
            var fspec = this.ArchivalLocations.AsFieldSpec(conf.Child("archivalLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalLocations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkloadSnapshot? CdmWorkloadSnapshot
        // GraphQL -> cdmWorkloadSnapshot: CdmWorkloadSnapshot (type)
        if (this.CdmWorkloadSnapshot != null) {
            var fspec = this.CdmWorkloadSnapshot.AsFieldSpec(conf.Child("cdmWorkloadSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmWorkloadSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CdmSnapshot>? ChildSnapshots
        // GraphQL -> childSnapshots: [CdmSnapshot!]! (type)
        if (this.ChildSnapshots != null) {
            var fspec = this.ChildSnapshots.AsFieldSpec(conf.Child("childSnapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "childSnapshots" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataLocation>? CloudNativeLocations
        // GraphQL -> cloudNativeLocations: [DataLocation!] (type)
        if (this.CloudNativeLocations != null) {
            var fspec = this.CloudNativeLocations.AsFieldSpec(conf.Child("cloudNativeLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudNativeLocations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Db2AppMetadata? Db2AppMetadata
        // GraphQL -> db2AppMetadata: Db2AppMetadata (type)
        if (this.Db2AppMetadata != null) {
            var fspec = this.Db2AppMetadata.AsFieldSpec(conf.Child("db2AppMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "db2AppMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> LegalHoldInfo? LegalHoldInfo
        // GraphQL -> legalHoldInfo: LegalHoldInfo (type)
        if (this.LegalHoldInfo != null) {
            var fspec = this.LegalHoldInfo.AsFieldSpec(conf.Child("legalHoldInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "legalHoldInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataLocation>? LocalLocations
        // GraphQL -> localLocations: [DataLocation!] (type)
        if (this.LocalLocations != null) {
            var fspec = this.LocalLocations.AsFieldSpec(conf.Child("localLocations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "localLocations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataLocation>? Locations
        // GraphQL -> locations: [DataLocation!] (type)
        if (this.Locations != null) {
            var fspec = this.Locations.AsFieldSpec(conf.Child("locations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "locations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeAppMetadata? ManagedVolumeAppMetadata
        // GraphQL -> managedVolumeAppMetadata: ManagedVolumeAppMetadata (type)
        if (this.ManagedVolumeAppMetadata != null) {
            var fspec = this.ManagedVolumeAppMetadata.AsFieldSpec(conf.Child("managedVolumeAppMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeAppMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlAppMetadata? MssqlAppMetadata
        // GraphQL -> mssqlAppMetadata: MssqlAppMetadata (type)
        if (this.MssqlAppMetadata != null) {
            var fspec = this.MssqlAppMetadata.AsFieldSpec(conf.Child("mssqlAppMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlAppMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PendingSnapshotDeletion? PendingSnapshotDeletion
        // GraphQL -> pendingSnapshotDeletion: PendingSnapshotDeletion (type)
        if (this.PendingSnapshotDeletion != null) {
            var fspec = this.PendingSnapshotDeletion.AsFieldSpec(conf.Child("pendingSnapshotDeletion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSnapshotDeletion" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> SapHanaAppMetadata? SapHanaAppMetadata
        // GraphQL -> sapHanaAppMetadata: SapHanaAppMetadata (type)
        if (this.SapHanaAppMetadata != null) {
            var fspec = this.SapHanaAppMetadata.AsFieldSpec(conf.Child("sapHanaAppMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sapHanaAppMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: CdmSnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo != null) {
            var fspec = this.SnapshotRetentionInfo.AsFieldSpec(conf.Child("snapshotRetentionInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotRetentionInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VappAppMetadata>? VappAppMetadata
        // GraphQL -> vappAppMetadata: [VappAppMetadata!] (type)
        if (this.VappAppMetadata != null) {
            var fspec = this.VappAppMetadata.AsFieldSpec(conf.Child("vappAppMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vappAppMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareAppMetadata? VmwareAppMetadata
        // GraphQL -> vmwareAppMetadata: VmwareAppMetadata (type)
        if (this.VmwareAppMetadata != null) {
            var fspec = this.VmwareAppMetadata.AsFieldSpec(conf.Child("vmwareAppMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareAppMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotCloudState? CloudState
        // GraphQL -> cloudState: SnapshotCloudState (enum)
        if (ec.Includes("cloudState",true))
        {
            if(this.CloudState == null) {

                this.CloudState = new SnapshotCloudState();

            } else {


            }
        }
        else if (this.CloudState != null && ec.Excludes("cloudState",true))
        {
            this.CloudState = null;
        }
        //      C# -> ConsistencyLevelEnum? ConsistencyLevel
        // GraphQL -> consistencyLevel: ConsistencyLevelEnum (enum)
        if (ec.Includes("consistencyLevel",true))
        {
            if(this.ConsistencyLevel == null) {

                this.ConsistencyLevel = new ConsistencyLevelEnum();

            } else {


            }
        }
        else if (this.ConsistencyLevel != null && ec.Excludes("consistencyLevel",true))
        {
            this.ConsistencyLevel = null;
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (ec.Includes("pendingSla",false))
        {
            if(this.PendingSla == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.PendingSla != null && ec.Excludes("pendingSla",false))
        {
            this.PendingSla = null;
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
        //      C# -> CdmHierarchySnappableNew? SnappableNew
        // GraphQL -> snappableNew: CdmHierarchySnappableNew! (interface)
        if (ec.Includes("snappableNew",false))
        {
            if(this.SnappableNew == null) {

                var impls = new List<CdmHierarchySnappableNew>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snappableNew"));
                this.SnappableNew = (CdmHierarchySnappableNew)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<CdmHierarchySnappableNew>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snappableNew"));
                this.SnappableNew = (CdmHierarchySnappableNew)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.SnappableNew != null && ec.Excludes("snappableNew",false))
        {
            this.SnappableNew = null;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (ec.Includes("cdmVersion",true))
        {
            if(this.CdmVersion == null) {

                this.CdmVersion = "FETCH";

            } else {


            }
        }
        else if (this.CdmVersion != null && ec.Excludes("cdmVersion",true))
        {
            this.CdmVersion = null;
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
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long! (scalar)
        if (ec.Includes("fileCount",true))
        {
            if(this.FileCount == null) {

                this.FileCount = new System.Int64();

            } else {


            }
        }
        else if (this.FileCount != null && ec.Excludes("fileCount",true))
        {
            this.FileCount = null;
        }
        //      C# -> System.Boolean? HasDelta
        // GraphQL -> hasDelta: Boolean! (scalar)
        if (ec.Includes("hasDelta",true))
        {
            if(this.HasDelta == null) {

                this.HasDelta = true;

            } else {


            }
        }
        else if (this.HasDelta != null && ec.Excludes("hasDelta",true))
        {
            this.HasDelta = null;
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
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (ec.Includes("isAnomaly",true))
        {
            if(this.IsAnomaly == null) {

                this.IsAnomaly = true;

            } else {


            }
        }
        else if (this.IsAnomaly != null && ec.Excludes("isAnomaly",true))
        {
            this.IsAnomaly = null;
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
        //      C# -> System.Boolean? IsRetentionLocked
        // GraphQL -> isRetentionLocked: Boolean (scalar)
        if (ec.Includes("isRetentionLocked",true))
        {
            if(this.IsRetentionLocked == null) {

                this.IsRetentionLocked = true;

            } else {


            }
        }
        else if (this.IsRetentionLocked != null && ec.Excludes("isRetentionLocked",true))
        {
            this.IsRetentionLocked = null;
        }
        //      C# -> System.Boolean? IsSapHanaIncrementalSnapshot
        // GraphQL -> isSapHanaIncrementalSnapshot: Boolean (scalar)
        if (ec.Includes("isSapHanaIncrementalSnapshot",true))
        {
            if(this.IsSapHanaIncrementalSnapshot == null) {

                this.IsSapHanaIncrementalSnapshot = true;

            } else {


            }
        }
        else if (this.IsSapHanaIncrementalSnapshot != null && ec.Excludes("isSapHanaIncrementalSnapshot",true))
        {
            this.IsSapHanaIncrementalSnapshot = null;
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
        //      C# -> System.String? ResourceSpec
        // GraphQL -> resourceSpec: String (scalar)
        if (ec.Includes("resourceSpec",true))
        {
            if(this.ResourceSpec == null) {

                this.ResourceSpec = "FETCH";

            } else {


            }
        }
        else if (this.ResourceSpec != null && ec.Excludes("resourceSpec",true))
        {
            this.ResourceSpec = null;
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
        //      C# -> ActiveDirectoryAppMetadata? ActiveDirectoryAppMetadata
        // GraphQL -> activeDirectoryAppMetadata: ActiveDirectoryAppMetadata (type)
        if (ec.Includes("activeDirectoryAppMetadata",false))
        {
            if(this.ActiveDirectoryAppMetadata == null) {

                this.ActiveDirectoryAppMetadata = new ActiveDirectoryAppMetadata();
                this.ActiveDirectoryAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("activeDirectoryAppMetadata"));

            } else {

                this.ActiveDirectoryAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("activeDirectoryAppMetadata"));

            }
        }
        else if (this.ActiveDirectoryAppMetadata != null && ec.Excludes("activeDirectoryAppMetadata",false))
        {
            this.ActiveDirectoryAppMetadata = null;
        }
        //      C# -> List<DataLocation>? ArchivalLocations
        // GraphQL -> archivalLocations: [DataLocation!] (type)
        if (ec.Includes("archivalLocations",false))
        {
            if(this.ArchivalLocations == null) {

                this.ArchivalLocations = new List<DataLocation>();
                this.ArchivalLocations.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocations"));

            } else {

                this.ArchivalLocations.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocations"));

            }
        }
        else if (this.ArchivalLocations != null && ec.Excludes("archivalLocations",false))
        {
            this.ArchivalLocations = null;
        }
        //      C# -> CdmWorkloadSnapshot? CdmWorkloadSnapshot
        // GraphQL -> cdmWorkloadSnapshot: CdmWorkloadSnapshot (type)
        if (ec.Includes("cdmWorkloadSnapshot",false))
        {
            if(this.CdmWorkloadSnapshot == null) {

                this.CdmWorkloadSnapshot = new CdmWorkloadSnapshot();
                this.CdmWorkloadSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("cdmWorkloadSnapshot"));

            } else {

                this.CdmWorkloadSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("cdmWorkloadSnapshot"));

            }
        }
        else if (this.CdmWorkloadSnapshot != null && ec.Excludes("cdmWorkloadSnapshot",false))
        {
            this.CdmWorkloadSnapshot = null;
        }
        //      C# -> List<CdmSnapshot>? ChildSnapshots
        // GraphQL -> childSnapshots: [CdmSnapshot!]! (type)
        if (ec.Includes("childSnapshots",false))
        {
            if(this.ChildSnapshots == null) {

                this.ChildSnapshots = new List<CdmSnapshot>();
                this.ChildSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("childSnapshots"));

            } else {

                this.ChildSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("childSnapshots"));

            }
        }
        else if (this.ChildSnapshots != null && ec.Excludes("childSnapshots",false))
        {
            this.ChildSnapshots = null;
        }
        //      C# -> List<DataLocation>? CloudNativeLocations
        // GraphQL -> cloudNativeLocations: [DataLocation!] (type)
        if (ec.Includes("cloudNativeLocations",false))
        {
            if(this.CloudNativeLocations == null) {

                this.CloudNativeLocations = new List<DataLocation>();
                this.CloudNativeLocations.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeLocations"));

            } else {

                this.CloudNativeLocations.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeLocations"));

            }
        }
        else if (this.CloudNativeLocations != null && ec.Excludes("cloudNativeLocations",false))
        {
            this.CloudNativeLocations = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> Db2AppMetadata? Db2AppMetadata
        // GraphQL -> db2AppMetadata: Db2AppMetadata (type)
        if (ec.Includes("db2AppMetadata",false))
        {
            if(this.Db2AppMetadata == null) {

                this.Db2AppMetadata = new Db2AppMetadata();
                this.Db2AppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("db2AppMetadata"));

            } else {

                this.Db2AppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("db2AppMetadata"));

            }
        }
        else if (this.Db2AppMetadata != null && ec.Excludes("db2AppMetadata",false))
        {
            this.Db2AppMetadata = null;
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
        //      C# -> LegalHoldInfo? LegalHoldInfo
        // GraphQL -> legalHoldInfo: LegalHoldInfo (type)
        if (ec.Includes("legalHoldInfo",false))
        {
            if(this.LegalHoldInfo == null) {

                this.LegalHoldInfo = new LegalHoldInfo();
                this.LegalHoldInfo.ApplyExploratoryFieldSpec(ec.NewChild("legalHoldInfo"));

            } else {

                this.LegalHoldInfo.ApplyExploratoryFieldSpec(ec.NewChild("legalHoldInfo"));

            }
        }
        else if (this.LegalHoldInfo != null && ec.Excludes("legalHoldInfo",false))
        {
            this.LegalHoldInfo = null;
        }
        //      C# -> List<DataLocation>? LocalLocations
        // GraphQL -> localLocations: [DataLocation!] (type)
        if (ec.Includes("localLocations",false))
        {
            if(this.LocalLocations == null) {

                this.LocalLocations = new List<DataLocation>();
                this.LocalLocations.ApplyExploratoryFieldSpec(ec.NewChild("localLocations"));

            } else {

                this.LocalLocations.ApplyExploratoryFieldSpec(ec.NewChild("localLocations"));

            }
        }
        else if (this.LocalLocations != null && ec.Excludes("localLocations",false))
        {
            this.LocalLocations = null;
        }
        //      C# -> List<DataLocation>? Locations
        // GraphQL -> locations: [DataLocation!] (type)
        if (ec.Includes("locations",false))
        {
            if(this.Locations == null) {

                this.Locations = new List<DataLocation>();
                this.Locations.ApplyExploratoryFieldSpec(ec.NewChild("locations"));

            } else {

                this.Locations.ApplyExploratoryFieldSpec(ec.NewChild("locations"));

            }
        }
        else if (this.Locations != null && ec.Excludes("locations",false))
        {
            this.Locations = null;
        }
        //      C# -> ManagedVolumeAppMetadata? ManagedVolumeAppMetadata
        // GraphQL -> managedVolumeAppMetadata: ManagedVolumeAppMetadata (type)
        if (ec.Includes("managedVolumeAppMetadata",false))
        {
            if(this.ManagedVolumeAppMetadata == null) {

                this.ManagedVolumeAppMetadata = new ManagedVolumeAppMetadata();
                this.ManagedVolumeAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeAppMetadata"));

            } else {

                this.ManagedVolumeAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeAppMetadata"));

            }
        }
        else if (this.ManagedVolumeAppMetadata != null && ec.Excludes("managedVolumeAppMetadata",false))
        {
            this.ManagedVolumeAppMetadata = null;
        }
        //      C# -> MssqlAppMetadata? MssqlAppMetadata
        // GraphQL -> mssqlAppMetadata: MssqlAppMetadata (type)
        if (ec.Includes("mssqlAppMetadata",false))
        {
            if(this.MssqlAppMetadata == null) {

                this.MssqlAppMetadata = new MssqlAppMetadata();
                this.MssqlAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("mssqlAppMetadata"));

            } else {

                this.MssqlAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("mssqlAppMetadata"));

            }
        }
        else if (this.MssqlAppMetadata != null && ec.Excludes("mssqlAppMetadata",false))
        {
            this.MssqlAppMetadata = null;
        }
        //      C# -> PendingSnapshotDeletion? PendingSnapshotDeletion
        // GraphQL -> pendingSnapshotDeletion: PendingSnapshotDeletion (type)
        if (ec.Includes("pendingSnapshotDeletion",false))
        {
            if(this.PendingSnapshotDeletion == null) {

                this.PendingSnapshotDeletion = new PendingSnapshotDeletion();
                this.PendingSnapshotDeletion.ApplyExploratoryFieldSpec(ec.NewChild("pendingSnapshotDeletion"));

            } else {

                this.PendingSnapshotDeletion.ApplyExploratoryFieldSpec(ec.NewChild("pendingSnapshotDeletion"));

            }
        }
        else if (this.PendingSnapshotDeletion != null && ec.Excludes("pendingSnapshotDeletion",false))
        {
            this.PendingSnapshotDeletion = null;
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
        //      C# -> SapHanaAppMetadata? SapHanaAppMetadata
        // GraphQL -> sapHanaAppMetadata: SapHanaAppMetadata (type)
        if (ec.Includes("sapHanaAppMetadata",false))
        {
            if(this.SapHanaAppMetadata == null) {

                this.SapHanaAppMetadata = new SapHanaAppMetadata();
                this.SapHanaAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("sapHanaAppMetadata"));

            } else {

                this.SapHanaAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("sapHanaAppMetadata"));

            }
        }
        else if (this.SapHanaAppMetadata != null && ec.Excludes("sapHanaAppMetadata",false))
        {
            this.SapHanaAppMetadata = null;
        }
        //      C# -> CdmSnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: CdmSnapshotRetentionInfo (type)
        if (ec.Includes("snapshotRetentionInfo",false))
        {
            if(this.SnapshotRetentionInfo == null) {

                this.SnapshotRetentionInfo = new CdmSnapshotRetentionInfo();
                this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));

            } else {

                this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));

            }
        }
        else if (this.SnapshotRetentionInfo != null && ec.Excludes("snapshotRetentionInfo",false))
        {
            this.SnapshotRetentionInfo = null;
        }
        //      C# -> List<VappAppMetadata>? VappAppMetadata
        // GraphQL -> vappAppMetadata: [VappAppMetadata!] (type)
        if (ec.Includes("vappAppMetadata",false))
        {
            if(this.VappAppMetadata == null) {

                this.VappAppMetadata = new List<VappAppMetadata>();
                this.VappAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("vappAppMetadata"));

            } else {

                this.VappAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("vappAppMetadata"));

            }
        }
        else if (this.VappAppMetadata != null && ec.Excludes("vappAppMetadata",false))
        {
            this.VappAppMetadata = null;
        }
        //      C# -> VmwareAppMetadata? VmwareAppMetadata
        // GraphQL -> vmwareAppMetadata: VmwareAppMetadata (type)
        if (ec.Includes("vmwareAppMetadata",false))
        {
            if(this.VmwareAppMetadata == null) {

                this.VmwareAppMetadata = new VmwareAppMetadata();
                this.VmwareAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("vmwareAppMetadata"));

            } else {

                this.VmwareAppMetadata.ApplyExploratoryFieldSpec(ec.NewChild("vmwareAppMetadata"));

            }
        }
        else if (this.VmwareAppMetadata != null && ec.Excludes("vmwareAppMetadata",false))
        {
            this.VmwareAppMetadata = null;
        }
    }


    #endregion

    } // class CdmSnapshot
    
    #endregion

    public static class ListCdmSnapshotExtensions
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
            this List<CdmSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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