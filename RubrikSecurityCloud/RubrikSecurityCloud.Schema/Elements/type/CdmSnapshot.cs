// CdmSnapshot.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:07.
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
    #region CdmSnapshot
 
    public class CdmSnapshot: IFragment, GenericSnapshot
    {
        #region members
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

        //      C# -> System.Boolean? HasImageConverted
        // GraphQL -> hasImageConverted: Boolean! (scalar)
        [JsonProperty("hasImageConverted")]
        public System.Boolean? HasImageConverted { get; set; }

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

        #endregion

    #region methods

    public CdmSnapshot Set(
        System.String? CdmId = null,
        System.String? CdmVersion = null,
        DateTime? Date = null,
        DateTime? ExpirationDate = null,
        System.Boolean? ExpiryHint = null,
        System.Int64? FileCount = null,
        System.Boolean? HasDelta = null,
        System.Boolean? HasImageConverted = null,
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
        VmwareAppMetadata? VmwareAppMetadata = null,
        SnapshotCloudState? CloudState = null,
        ConsistencyLevelEnum? ConsistencyLevel = null,
        SlaDomain? PendingSla = null,
        SlaDomain? SlaDomain = null,
        CdmHierarchySnappableNew? SnappableNew = null
    ) 
    {
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
        if ( HasImageConverted != null ) {
            this.HasImageConverted = HasImageConverted;
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion != null)
            {
                 s += ind + "cdmVersion\n";

            }
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
            //      C# -> System.Int64? FileCount
            // GraphQL -> fileCount: Long! (scalar)
            if (this.FileCount != null)
            {
                 s += ind + "fileCount\n";

            }
            //      C# -> System.Boolean? HasDelta
            // GraphQL -> hasDelta: Boolean! (scalar)
            if (this.HasDelta != null)
            {
                 s += ind + "hasDelta\n";

            }
            //      C# -> System.Boolean? HasImageConverted
            // GraphQL -> hasImageConverted: Boolean! (scalar)
            if (this.HasImageConverted != null)
            {
                 s += ind + "hasImageConverted\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? IndexingAttempts
            // GraphQL -> indexingAttempts: Long! (scalar)
            if (this.IndexingAttempts != null)
            {
                 s += ind + "indexingAttempts\n";

            }
            //      C# -> System.Boolean? IsAnomaly
            // GraphQL -> isAnomaly: Boolean! (scalar)
            if (this.IsAnomaly != null)
            {
                 s += ind + "isAnomaly\n";

            }
            //      C# -> System.Boolean? IsCorrupted
            // GraphQL -> isCorrupted: Boolean! (scalar)
            if (this.IsCorrupted != null)
            {
                 s += ind + "isCorrupted\n";

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
            //      C# -> System.Boolean? IsRetentionLocked
            // GraphQL -> isRetentionLocked: Boolean (scalar)
            if (this.IsRetentionLocked != null)
            {
                 s += ind + "isRetentionLocked\n";

            }
            //      C# -> System.Boolean? IsSapHanaIncrementalSnapshot
            // GraphQL -> isSapHanaIncrementalSnapshot: Boolean (scalar)
            if (this.IsSapHanaIncrementalSnapshot != null)
            {
                 s += ind + "isSapHanaIncrementalSnapshot\n";

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
            //      C# -> System.String? ResourceSpec
            // GraphQL -> resourceSpec: String (scalar)
            if (this.ResourceSpec != null)
            {
                 s += ind + "resourceSpec\n";

            }
            //      C# -> System.String? SnappableId
            // GraphQL -> snappableId: String! (scalar)
            if (this.SnappableId != null)
            {
                 s += ind + "snappableId\n";

            }
            //      C# -> List<DataLocation>? ArchivalLocations
            // GraphQL -> archivalLocations: [DataLocation!] (type)
            if (this.ArchivalLocations != null)
            {
                 s += ind + "archivalLocations\n";

                 s += ind + "{\n" + 
                 this.ArchivalLocations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<CdmSnapshot>? ChildSnapshots
            // GraphQL -> childSnapshots: [CdmSnapshot!]! (type)
            if (this.ChildSnapshots != null)
            {
                 s += ind + "childSnapshots\n";

                 s += ind + "{\n" + 
                 this.ChildSnapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<DataLocation>? CloudNativeLocations
            // GraphQL -> cloudNativeLocations: [DataLocation!] (type)
            if (this.CloudNativeLocations != null)
            {
                 s += ind + "cloudNativeLocations\n";

                 s += ind + "{\n" + 
                 this.CloudNativeLocations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Db2AppMetadata? Db2AppMetadata
            // GraphQL -> db2AppMetadata: Db2AppMetadata (type)
            if (this.Db2AppMetadata != null)
            {
                 s += ind + "db2AppMetadata\n";

                 s += ind + "{\n" + 
                 this.Db2AppMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> LegalHoldInfo? LegalHoldInfo
            // GraphQL -> legalHoldInfo: LegalHoldInfo (type)
            if (this.LegalHoldInfo != null)
            {
                 s += ind + "legalHoldInfo\n";

                 s += ind + "{\n" + 
                 this.LegalHoldInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<DataLocation>? LocalLocations
            // GraphQL -> localLocations: [DataLocation!] (type)
            if (this.LocalLocations != null)
            {
                 s += ind + "localLocations\n";

                 s += ind + "{\n" + 
                 this.LocalLocations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<DataLocation>? Locations
            // GraphQL -> locations: [DataLocation!] (type)
            if (this.Locations != null)
            {
                 s += ind + "locations\n";

                 s += ind + "{\n" + 
                 this.Locations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeAppMetadata? ManagedVolumeAppMetadata
            // GraphQL -> managedVolumeAppMetadata: ManagedVolumeAppMetadata (type)
            if (this.ManagedVolumeAppMetadata != null)
            {
                 s += ind + "managedVolumeAppMetadata\n";

                 s += ind + "{\n" + 
                 this.ManagedVolumeAppMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PendingSnapshotDeletion? PendingSnapshotDeletion
            // GraphQL -> pendingSnapshotDeletion: PendingSnapshotDeletion (type)
            if (this.PendingSnapshotDeletion != null)
            {
                 s += ind + "pendingSnapshotDeletion\n";

                 s += ind + "{\n" + 
                 this.PendingSnapshotDeletion.AsFragment(indent+1) + 
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
            //      C# -> SapHanaAppMetadata? SapHanaAppMetadata
            // GraphQL -> sapHanaAppMetadata: SapHanaAppMetadata (type)
            if (this.SapHanaAppMetadata != null)
            {
                 s += ind + "sapHanaAppMetadata\n";

                 s += ind + "{\n" + 
                 this.SapHanaAppMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshotRetentionInfo? SnapshotRetentionInfo
            // GraphQL -> snapshotRetentionInfo: CdmSnapshotRetentionInfo (type)
            if (this.SnapshotRetentionInfo != null)
            {
                 s += ind + "snapshotRetentionInfo\n";

                 s += ind + "{\n" + 
                 this.SnapshotRetentionInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<VappAppMetadata>? VappAppMetadata
            // GraphQL -> vappAppMetadata: [VappAppMetadata!] (type)
            if (this.VappAppMetadata != null)
            {
                 s += ind + "vappAppMetadata\n";

                 s += ind + "{\n" + 
                 this.VappAppMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VmwareAppMetadata? VmwareAppMetadata
            // GraphQL -> vmwareAppMetadata: VmwareAppMetadata (type)
            if (this.VmwareAppMetadata != null)
            {
                 s += ind + "vmwareAppMetadata\n";

                 s += ind + "{\n" + 
                 this.VmwareAppMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotCloudState? CloudState
            // GraphQL -> cloudState: SnapshotCloudState (enum)
            if (this.CloudState != null)
            {
                 s += ind + "cloudState\n";

            }
            //      C# -> ConsistencyLevelEnum? ConsistencyLevel
            // GraphQL -> consistencyLevel: ConsistencyLevelEnum (enum)
            if (this.ConsistencyLevel != null)
            {
                 s += ind + "consistencyLevel\n";

            }
                        //      C# -> SlaDomain? PendingSla
            // GraphQL -> pendingSla: SlaDomain (interface)
            if (this.PendingSla != null)
            {
                s += ind + "pendingSla\n";
                s += ind + "{\n";

                string typename = this.PendingSla.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.PendingSla.AsFragment(indent+1) +

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
                        //      C# -> CdmHierarchySnappableNew? SnappableNew
            // GraphQL -> snappableNew: CdmHierarchySnappableNew! (interface)
            if (this.SnappableNew != null)
            {
                s += ind + "snappableNew\n";
                s += ind + "{\n";

                string typename = this.SnappableNew.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.SnappableNew.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? CdmVersion
            // GraphQL -> cdmVersion: String! (scalar)
            if (this.CdmVersion == null && Exploration.Includes(parent + ".cdmVersion$"))
            {
                this.CdmVersion = new System.String("FETCH");
            }
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
            //      C# -> System.Int64? FileCount
            // GraphQL -> fileCount: Long! (scalar)
            if (this.FileCount == null && Exploration.Includes(parent + ".fileCount$"))
            {
                this.FileCount = new System.Int64();
            }
            //      C# -> System.Boolean? HasDelta
            // GraphQL -> hasDelta: Boolean! (scalar)
            if (this.HasDelta == null && Exploration.Includes(parent + ".hasDelta$"))
            {
                this.HasDelta = new System.Boolean();
            }
            //      C# -> System.Boolean? HasImageConverted
            // GraphQL -> hasImageConverted: Boolean! (scalar)
            if (this.HasImageConverted == null && Exploration.Includes(parent + ".hasImageConverted$"))
            {
                this.HasImageConverted = new System.Boolean();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? IndexingAttempts
            // GraphQL -> indexingAttempts: Long! (scalar)
            if (this.IndexingAttempts == null && Exploration.Includes(parent + ".indexingAttempts$"))
            {
                this.IndexingAttempts = new System.Int64();
            }
            //      C# -> System.Boolean? IsAnomaly
            // GraphQL -> isAnomaly: Boolean! (scalar)
            if (this.IsAnomaly == null && Exploration.Includes(parent + ".isAnomaly$"))
            {
                this.IsAnomaly = new System.Boolean();
            }
            //      C# -> System.Boolean? IsCorrupted
            // GraphQL -> isCorrupted: Boolean! (scalar)
            if (this.IsCorrupted == null && Exploration.Includes(parent + ".isCorrupted$"))
            {
                this.IsCorrupted = new System.Boolean();
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
            //      C# -> System.Boolean? IsRetentionLocked
            // GraphQL -> isRetentionLocked: Boolean (scalar)
            if (this.IsRetentionLocked == null && Exploration.Includes(parent + ".isRetentionLocked$"))
            {
                this.IsRetentionLocked = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSapHanaIncrementalSnapshot
            // GraphQL -> isSapHanaIncrementalSnapshot: Boolean (scalar)
            if (this.IsSapHanaIncrementalSnapshot == null && Exploration.Includes(parent + ".isSapHanaIncrementalSnapshot$"))
            {
                this.IsSapHanaIncrementalSnapshot = new System.Boolean();
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
            //      C# -> System.String? ResourceSpec
            // GraphQL -> resourceSpec: String (scalar)
            if (this.ResourceSpec == null && Exploration.Includes(parent + ".resourceSpec$"))
            {
                this.ResourceSpec = new System.String("FETCH");
            }
            //      C# -> System.String? SnappableId
            // GraphQL -> snappableId: String! (scalar)
            if (this.SnappableId == null && Exploration.Includes(parent + ".snappableId$"))
            {
                this.SnappableId = new System.String("FETCH");
            }
            //      C# -> List<DataLocation>? ArchivalLocations
            // GraphQL -> archivalLocations: [DataLocation!] (type)
            if (this.ArchivalLocations == null && Exploration.Includes(parent + ".archivalLocations"))
            {
                this.ArchivalLocations = new List<DataLocation>();
                this.ArchivalLocations.ApplyExploratoryFragment(parent + ".archivalLocations");
            }
            //      C# -> List<CdmSnapshot>? ChildSnapshots
            // GraphQL -> childSnapshots: [CdmSnapshot!]! (type)
            if (this.ChildSnapshots == null && Exploration.Includes(parent + ".childSnapshots"))
            {
                this.ChildSnapshots = new List<CdmSnapshot>();
                this.ChildSnapshots.ApplyExploratoryFragment(parent + ".childSnapshots");
            }
            //      C# -> List<DataLocation>? CloudNativeLocations
            // GraphQL -> cloudNativeLocations: [DataLocation!] (type)
            if (this.CloudNativeLocations == null && Exploration.Includes(parent + ".cloudNativeLocations"))
            {
                this.CloudNativeLocations = new List<DataLocation>();
                this.CloudNativeLocations.ApplyExploratoryFragment(parent + ".cloudNativeLocations");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> Db2AppMetadata? Db2AppMetadata
            // GraphQL -> db2AppMetadata: Db2AppMetadata (type)
            if (this.Db2AppMetadata == null && Exploration.Includes(parent + ".db2AppMetadata"))
            {
                this.Db2AppMetadata = new Db2AppMetadata();
                this.Db2AppMetadata.ApplyExploratoryFragment(parent + ".db2AppMetadata");
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
            {
                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFragment(parent + ".latestUserNote");
            }
            //      C# -> LegalHoldInfo? LegalHoldInfo
            // GraphQL -> legalHoldInfo: LegalHoldInfo (type)
            if (this.LegalHoldInfo == null && Exploration.Includes(parent + ".legalHoldInfo"))
            {
                this.LegalHoldInfo = new LegalHoldInfo();
                this.LegalHoldInfo.ApplyExploratoryFragment(parent + ".legalHoldInfo");
            }
            //      C# -> List<DataLocation>? LocalLocations
            // GraphQL -> localLocations: [DataLocation!] (type)
            if (this.LocalLocations == null && Exploration.Includes(parent + ".localLocations"))
            {
                this.LocalLocations = new List<DataLocation>();
                this.LocalLocations.ApplyExploratoryFragment(parent + ".localLocations");
            }
            //      C# -> List<DataLocation>? Locations
            // GraphQL -> locations: [DataLocation!] (type)
            if (this.Locations == null && Exploration.Includes(parent + ".locations"))
            {
                this.Locations = new List<DataLocation>();
                this.Locations.ApplyExploratoryFragment(parent + ".locations");
            }
            //      C# -> ManagedVolumeAppMetadata? ManagedVolumeAppMetadata
            // GraphQL -> managedVolumeAppMetadata: ManagedVolumeAppMetadata (type)
            if (this.ManagedVolumeAppMetadata == null && Exploration.Includes(parent + ".managedVolumeAppMetadata"))
            {
                this.ManagedVolumeAppMetadata = new ManagedVolumeAppMetadata();
                this.ManagedVolumeAppMetadata.ApplyExploratoryFragment(parent + ".managedVolumeAppMetadata");
            }
            //      C# -> PendingSnapshotDeletion? PendingSnapshotDeletion
            // GraphQL -> pendingSnapshotDeletion: PendingSnapshotDeletion (type)
            if (this.PendingSnapshotDeletion == null && Exploration.Includes(parent + ".pendingSnapshotDeletion"))
            {
                this.PendingSnapshotDeletion = new PendingSnapshotDeletion();
                this.PendingSnapshotDeletion.ApplyExploratoryFragment(parent + ".pendingSnapshotDeletion");
            }
            //      C# -> List<DataLocation>? ReplicationLocations
            // GraphQL -> replicationLocations: [DataLocation!] (type)
            if (this.ReplicationLocations == null && Exploration.Includes(parent + ".replicationLocations"))
            {
                this.ReplicationLocations = new List<DataLocation>();
                this.ReplicationLocations.ApplyExploratoryFragment(parent + ".replicationLocations");
            }
            //      C# -> SapHanaAppMetadata? SapHanaAppMetadata
            // GraphQL -> sapHanaAppMetadata: SapHanaAppMetadata (type)
            if (this.SapHanaAppMetadata == null && Exploration.Includes(parent + ".sapHanaAppMetadata"))
            {
                this.SapHanaAppMetadata = new SapHanaAppMetadata();
                this.SapHanaAppMetadata.ApplyExploratoryFragment(parent + ".sapHanaAppMetadata");
            }
            //      C# -> CdmSnapshotRetentionInfo? SnapshotRetentionInfo
            // GraphQL -> snapshotRetentionInfo: CdmSnapshotRetentionInfo (type)
            if (this.SnapshotRetentionInfo == null && Exploration.Includes(parent + ".snapshotRetentionInfo"))
            {
                this.SnapshotRetentionInfo = new CdmSnapshotRetentionInfo();
                this.SnapshotRetentionInfo.ApplyExploratoryFragment(parent + ".snapshotRetentionInfo");
            }
            //      C# -> List<VappAppMetadata>? VappAppMetadata
            // GraphQL -> vappAppMetadata: [VappAppMetadata!] (type)
            if (this.VappAppMetadata == null && Exploration.Includes(parent + ".vappAppMetadata"))
            {
                this.VappAppMetadata = new List<VappAppMetadata>();
                this.VappAppMetadata.ApplyExploratoryFragment(parent + ".vappAppMetadata");
            }
            //      C# -> VmwareAppMetadata? VmwareAppMetadata
            // GraphQL -> vmwareAppMetadata: VmwareAppMetadata (type)
            if (this.VmwareAppMetadata == null && Exploration.Includes(parent + ".vmwareAppMetadata"))
            {
                this.VmwareAppMetadata = new VmwareAppMetadata();
                this.VmwareAppMetadata.ApplyExploratoryFragment(parent + ".vmwareAppMetadata");
            }
            //      C# -> SnapshotCloudState? CloudState
            // GraphQL -> cloudState: SnapshotCloudState (enum)
            if (this.CloudState == null && Exploration.Includes(parent + ".cloudState$"))
            {
                this.CloudState = new SnapshotCloudState();
            }
            //      C# -> ConsistencyLevelEnum? ConsistencyLevel
            // GraphQL -> consistencyLevel: ConsistencyLevelEnum (enum)
            if (this.ConsistencyLevel == null && Exploration.Includes(parent + ".consistencyLevel$"))
            {
                this.ConsistencyLevel = new ConsistencyLevelEnum();
            }
            //      C# -> SlaDomain? PendingSla
            // GraphQL -> pendingSla: SlaDomain (interface)
            if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
            {
                this.PendingSla = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.PendingSla.ApplyExploratoryFragment(parent + ".pendingSla");
            }
            //      C# -> SlaDomain? SlaDomain
            // GraphQL -> slaDomain: SlaDomain (interface)
            if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
            {
                this.SlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.SlaDomain.ApplyExploratoryFragment(parent + ".slaDomain");
            }
            //      C# -> CdmHierarchySnappableNew? SnappableNew
            // GraphQL -> snappableNew: CdmHierarchySnappableNew! (interface)
            if (this.SnappableNew == null && Exploration.Includes(parent + ".snappableNew"))
            {
                this.SnappableNew = (CdmHierarchySnappableNew)InterfaceHelper.CreateInstanceOfFirstType(typeof(CdmHierarchySnappableNew));
                this.SnappableNew.ApplyExploratoryFragment(parent + ".snappableNew");
            }
        }


    #endregion

    } // class CdmSnapshot
    #endregion

    public static class ListCdmSnapshotExtensions
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
            this List<CdmSnapshot> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmSnapshot> list, 
            String parent = "")
        {
            var item = new CdmSnapshot();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types