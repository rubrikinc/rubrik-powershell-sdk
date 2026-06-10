// AzureDevOpsOrganization.cs
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
    #region AzureDevOpsOrganization
 
    public class AzureDevOpsOrganization: BaseType, HierarchyObject, PolarisHierarchyObject
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> DevopsConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: DevopsConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public DevopsConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> DevopsOrgType? DevOpsOrgType
        // GraphQL -> devOpsOrgType: DevopsOrgType! (enum)
        [JsonProperty("devOpsOrgType")]
        public DevopsOrgType? DevOpsOrgType { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> DevopsHostType? RepoHostType
        // GraphQL -> repoHostType: DevopsHostType! (enum)
        [JsonProperty("repoHostType")]
        public DevopsHostType? RepoHostType { get; set; }

        //      C# -> PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment
        // GraphQL -> rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        [JsonProperty("rscPendingObjectPauseAssignment")]
        public PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> System.String? BackupLocationId
        // GraphQL -> backupLocationId: String! (scalar)
        [JsonProperty("backupLocationId")]
        public System.String? BackupLocationId { get; set; }

        //      C# -> System.String? BackupLocationName
        // GraphQL -> backupLocationName: String! (scalar)
        [JsonProperty("backupLocationName")]
        public System.String? BackupLocationName { get; set; }

        //      C# -> System.String? BackupRegion
        // GraphQL -> backupRegion: String! (scalar)
        [JsonProperty("backupRegion")]
        public System.String? BackupRegion { get; set; }

        //      C# -> System.String? ExocomputeHostName
        // GraphQL -> exocomputeHostName: String! (scalar)
        [JsonProperty("exocomputeHostName")]
        public System.String? ExocomputeHostName { get; set; }

        //      C# -> System.String? ExocomputeId
        // GraphQL -> exocomputeId: String! (scalar)
        [JsonProperty("exocomputeId")]
        public System.String? ExocomputeId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        [JsonProperty("lastRefreshTime")]
        public DateTime? LastRefreshTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? ProjectCount
        // GraphQL -> projectCount: Int! (scalar)
        [JsonProperty("projectCount")]
        public System.Int32? ProjectCount { get; set; }

        //      C# -> System.Int32? RepoCount
        // GraphQL -> repoCount: Int! (scalar)
        [JsonProperty("repoCount")]
        public System.Int32? RepoCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? TenantUuid
        // GraphQL -> tenantUuid: UUID (scalar)
        [JsonProperty("tenantUuid")]
        public System.String? TenantUuid { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        [JsonProperty("allTags")]
        public List<AssignedRscTag>? AllTags { get; set; }

        //      C# -> DevOpsBackupLocation? BackupLocation
        // GraphQL -> backupLocation: DevOpsBackupLocation (type)
        [JsonProperty("backupLocation")]
        public DevOpsBackupLocation? BackupLocation { get; set; }

        //      C# -> DevOpsCloudNativeExocompute? CloudNativeExocompute
        // GraphQL -> cloudNativeExocompute: DevOpsCloudNativeExocompute (type)
        [JsonProperty("cloudNativeExocompute")]
        public DevOpsCloudNativeExocompute? CloudNativeExocompute { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        [JsonProperty("objectPauseStatus")]
        public ObjectPauseStatus? ObjectPauseStatus { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        [JsonProperty("rscNativeObjectPendingSla")]
        public CompactSlaDomain? RscNativeObjectPendingSla { get; set; }

        //      C# -> DevOpsRubrikHostedExocompute? RubrikHostedExocompute
        // GraphQL -> rubrikHostedExocompute: DevOpsRubrikHostedExocompute (type)
        [JsonProperty("rubrikHostedExocompute")]
        public DevOpsRubrikHostedExocompute? RubrikHostedExocompute { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        public SecurityMetadata? SecurityMetadata { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars NumWorkloadDescendants { get; set; }


        public InlineVars() {
            Tuple<string, string>[] numWorkloadDescendantsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("objectTypes", "[ManagedObjectType!]"),
                };
            this.NumWorkloadDescendants =
                new RscGqlVars(null, numWorkloadDescendantsArgs, null, true);
        }
    }

    public AzureDevOpsOrganization()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "AzureDevOpsOrganization";
    }

    public AzureDevOpsOrganization Set(
        List<Operation>? AuthorizedOperations = null,
        DevopsConnectionStatus? ConnectionStatus = null,
        DevopsOrgType? DevOpsOrgType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        DevopsHostType? RepoHostType = null,
        PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? BackupLocationId = null,
        System.String? BackupLocationName = null,
        System.String? BackupRegion = null,
        System.String? ExocomputeHostName = null,
        System.String? ExocomputeId = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        DateTime? LastRefreshTime = null,
        System.String? Name = null,
        System.String? NativeId = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? ProjectCount = null,
        System.Int32? RepoCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? TenantId = null,
        System.String? TenantUuid = null,
        List<Org>? AllOrgs = null,
        List<AssignedRscTag>? AllTags = null,
        DevOpsBackupLocation? BackupLocation = null,
        DevOpsCloudNativeExocompute? CloudNativeExocompute = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        ObjectPauseStatus? ObjectPauseStatus = null,
        List<PathNode>? PhysicalPath = null,
        CompactSlaDomain? RscNativeObjectPendingSla = null,
        DevOpsRubrikHostedExocompute? RubrikHostedExocompute = null,
        SecurityMetadata? SecurityMetadata = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( DevOpsOrgType != null ) {
            this.DevOpsOrgType = DevOpsOrgType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( RepoHostType != null ) {
            this.RepoHostType = RepoHostType;
        }
        if ( RscPendingObjectPauseAssignment != null ) {
            this.RscPendingObjectPauseAssignment = RscPendingObjectPauseAssignment;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( BackupLocationId != null ) {
            this.BackupLocationId = BackupLocationId;
        }
        if ( BackupLocationName != null ) {
            this.BackupLocationName = BackupLocationName;
        }
        if ( BackupRegion != null ) {
            this.BackupRegion = BackupRegion;
        }
        if ( ExocomputeHostName != null ) {
            this.ExocomputeHostName = ExocomputeHostName;
        }
        if ( ExocomputeId != null ) {
            this.ExocomputeId = ExocomputeId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( ProjectCount != null ) {
            this.ProjectCount = ProjectCount;
        }
        if ( RepoCount != null ) {
            this.RepoCount = RepoCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( TenantUuid != null ) {
            this.TenantUuid = TenantUuid;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AllTags != null ) {
            this.AllTags = AllTags;
        }
        if ( BackupLocation != null ) {
            this.BackupLocation = BackupLocation;
        }
        if ( CloudNativeExocompute != null ) {
            this.CloudNativeExocompute = CloudNativeExocompute;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( ObjectPauseStatus != null ) {
            this.ObjectPauseStatus = ObjectPauseStatus;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( RscNativeObjectPendingSla != null ) {
            this.RscNativeObjectPendingSla = RscNativeObjectPendingSla;
        }
        if ( RubrikHostedExocompute != null ) {
            this.RubrikHostedExocompute = RubrikHostedExocompute;
        }
        if ( SecurityMetadata != null ) {
            this.SecurityMetadata = SecurityMetadata;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
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
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizedOperations\n" ;
            } else {
                s += ind + "authorizedOperations\n" ;
            }
        }
        //      C# -> DevopsConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: DevopsConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> DevopsOrgType? DevOpsOrgType
        // GraphQL -> devOpsOrgType: DevopsOrgType! (enum)
        if (this.DevOpsOrgType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "devOpsOrgType\n" ;
            } else {
                s += ind + "devOpsOrgType\n" ;
            }
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> DevopsHostType? RepoHostType
        // GraphQL -> repoHostType: DevopsHostType! (enum)
        if (this.RepoHostType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "repoHostType\n" ;
            } else {
                s += ind + "repoHostType\n" ;
            }
        }
        //      C# -> PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment
        // GraphQL -> rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        if (this.RscPendingObjectPauseAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscPendingObjectPauseAssignment\n" ;
            } else {
                s += ind + "rscPendingObjectPauseAssignment\n" ;
            }
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.ConfiguredSlaDomain, conf.Child("configuredSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configuredSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.EffectiveRetentionSlaDomain, conf.Child("effectiveRetentionSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveRetentionSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.EffectiveSlaDomain, conf.Child("effectiveSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? BackupLocationId
        // GraphQL -> backupLocationId: String! (scalar)
        if (this.BackupLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupLocationId\n" ;
            } else {
                s += ind + "backupLocationId\n" ;
            }
        }
        //      C# -> System.String? BackupLocationName
        // GraphQL -> backupLocationName: String! (scalar)
        if (this.BackupLocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupLocationName\n" ;
            } else {
                s += ind + "backupLocationName\n" ;
            }
        }
        //      C# -> System.String? BackupRegion
        // GraphQL -> backupRegion: String! (scalar)
        if (this.BackupRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupRegion\n" ;
            } else {
                s += ind + "backupRegion\n" ;
            }
        }
        //      C# -> System.String? ExocomputeHostName
        // GraphQL -> exocomputeHostName: String! (scalar)
        if (this.ExocomputeHostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeHostName\n" ;
            } else {
                s += ind + "exocomputeHostName\n" ;
            }
        }
        //      C# -> System.String? ExocomputeId
        // GraphQL -> exocomputeId: String! (scalar)
        if (this.ExocomputeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exocomputeId\n" ;
            } else {
                s += ind + "exocomputeId\n" ;
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
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTime\n" ;
            } else {
                s += ind + "lastRefreshTime\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeId\n" ;
            } else {
                s += ind + "nativeId\n" ;
            }
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWorkloadDescendants\n" ;
            } else {
                s += ind + "numWorkloadDescendants\n" ;
            }
        }
        //      C# -> System.Int32? ProjectCount
        // GraphQL -> projectCount: Int! (scalar)
        if (this.ProjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectCount\n" ;
            } else {
                s += ind + "projectCount\n" ;
            }
        }
        //      C# -> System.Int32? RepoCount
        // GraphQL -> repoCount: Int! (scalar)
        if (this.RepoCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "repoCount\n" ;
            } else {
                s += ind + "repoCount\n" ;
            }
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaPauseStatus\n" ;
            } else {
                s += ind + "slaPauseStatus\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        //      C# -> System.String? TenantUuid
        // GraphQL -> tenantUuid: UUID (scalar)
        if (this.TenantUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantUuid\n" ;
            } else {
                s += ind + "tenantUuid\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        if (this.AllTags != null) {
            var fspec = this.AllTags.AsFieldSpec(conf.Child("allTags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allTags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DevOpsBackupLocation? BackupLocation
        // GraphQL -> backupLocation: DevOpsBackupLocation (type)
        if (this.BackupLocation != null) {
            var fspec = this.BackupLocation.AsFieldSpec(conf.Child("backupLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DevOpsCloudNativeExocompute? CloudNativeExocompute
        // GraphQL -> cloudNativeExocompute: DevOpsCloudNativeExocompute (type)
        if (this.CloudNativeExocompute != null) {
            var fspec = this.CloudNativeExocompute.AsFieldSpec(conf.Child("cloudNativeExocompute"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudNativeExocompute" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(conf.Child("effectiveSlaSourceObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaSourceObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(conf.Child("logicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        if (this.ObjectPauseStatus != null) {
            var fspec = this.ObjectPauseStatus.AsFieldSpec(conf.Child("objectPauseStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectPauseStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(conf.Child("physicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        if (this.RscNativeObjectPendingSla != null) {
            var fspec = this.RscNativeObjectPendingSla.AsFieldSpec(conf.Child("rscNativeObjectPendingSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rscNativeObjectPendingSla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DevOpsRubrikHostedExocompute? RubrikHostedExocompute
        // GraphQL -> rubrikHostedExocompute: DevOpsRubrikHostedExocompute (type)
        if (this.RubrikHostedExocompute != null) {
            var fspec = this.RubrikHostedExocompute.AsFieldSpec(conf.Child("rubrikHostedExocompute"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rubrikHostedExocompute" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (this.SecurityMetadata != null) {
            var fspec = this.SecurityMetadata.AsFieldSpec(conf.Child("securityMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "securityMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(conf.Child("snapshotDistribution"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDistribution" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (ec.Includes("authorizedOperations",true))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new List<Operation>();

            } else {


            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",true))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> DevopsConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: DevopsConnectionStatus! (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new DevopsConnectionStatus();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> DevopsOrgType? DevOpsOrgType
        // GraphQL -> devOpsOrgType: DevopsOrgType! (enum)
        if (ec.Includes("devOpsOrgType",true))
        {
            if(this.DevOpsOrgType == null) {

                this.DevOpsOrgType = new DevopsOrgType();

            } else {


            }
        }
        else if (this.DevOpsOrgType != null && ec.Excludes("devOpsOrgType",true))
        {
            this.DevOpsOrgType = null;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new HierarchyObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> DevopsHostType? RepoHostType
        // GraphQL -> repoHostType: DevopsHostType! (enum)
        if (ec.Includes("repoHostType",true))
        {
            if(this.RepoHostType == null) {

                this.RepoHostType = new DevopsHostType();

            } else {


            }
        }
        else if (this.RepoHostType != null && ec.Excludes("repoHostType",true))
        {
            this.RepoHostType = null;
        }
        //      C# -> PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment
        // GraphQL -> rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        if (ec.Includes("rscPendingObjectPauseAssignment",true))
        {
            if(this.RscPendingObjectPauseAssignment == null) {

                this.RscPendingObjectPauseAssignment = new PendingObjectPauseAssignmentStatus();

            } else {


            }
        }
        else if (this.RscPendingObjectPauseAssignment != null && ec.Excludes("rscPendingObjectPauseAssignment",true))
        {
            this.RscPendingObjectPauseAssignment = null;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (ec.Includes("slaAssignment",true))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new SlaAssignmentTypeEnum();

            } else {


            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",true))
        {
            this.SlaAssignment = null;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (ec.Includes("configuredSlaDomain",false))
        {
            if(this.ConfiguredSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ConfiguredSlaDomain != null && ec.Excludes("configuredSlaDomain",false))
        {
            this.ConfiguredSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (ec.Includes("effectiveRetentionSlaDomain",false))
        {
            if(this.EffectiveRetentionSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveRetentionSlaDomain != null && ec.Excludes("effectiveRetentionSlaDomain",false))
        {
            this.EffectiveRetentionSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (ec.Includes("effectiveSlaDomain",false))
        {
            if(this.EffectiveSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> System.String? BackupLocationId
        // GraphQL -> backupLocationId: String! (scalar)
        if (ec.Includes("backupLocationId",true))
        {
            if(this.BackupLocationId == null) {

                this.BackupLocationId = "FETCH";

            } else {


            }
        }
        else if (this.BackupLocationId != null && ec.Excludes("backupLocationId",true))
        {
            this.BackupLocationId = null;
        }
        //      C# -> System.String? BackupLocationName
        // GraphQL -> backupLocationName: String! (scalar)
        if (ec.Includes("backupLocationName",true))
        {
            if(this.BackupLocationName == null) {

                this.BackupLocationName = "FETCH";

            } else {


            }
        }
        else if (this.BackupLocationName != null && ec.Excludes("backupLocationName",true))
        {
            this.BackupLocationName = null;
        }
        //      C# -> System.String? BackupRegion
        // GraphQL -> backupRegion: String! (scalar)
        if (ec.Includes("backupRegion",true))
        {
            if(this.BackupRegion == null) {

                this.BackupRegion = "FETCH";

            } else {


            }
        }
        else if (this.BackupRegion != null && ec.Excludes("backupRegion",true))
        {
            this.BackupRegion = null;
        }
        //      C# -> System.String? ExocomputeHostName
        // GraphQL -> exocomputeHostName: String! (scalar)
        if (ec.Includes("exocomputeHostName",true))
        {
            if(this.ExocomputeHostName == null) {

                this.ExocomputeHostName = "FETCH";

            } else {


            }
        }
        else if (this.ExocomputeHostName != null && ec.Excludes("exocomputeHostName",true))
        {
            this.ExocomputeHostName = null;
        }
        //      C# -> System.String? ExocomputeId
        // GraphQL -> exocomputeId: String! (scalar)
        if (ec.Includes("exocomputeId",true))
        {
            if(this.ExocomputeId == null) {

                this.ExocomputeId = "FETCH";

            } else {


            }
        }
        else if (this.ExocomputeId != null && ec.Excludes("exocomputeId",true))
        {
            this.ExocomputeId = null;
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
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (ec.Includes("lastRefreshTime",true))
        {
            if(this.LastRefreshTime == null) {

                this.LastRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshTime != null && ec.Excludes("lastRefreshTime",true))
        {
            this.LastRefreshTime = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (ec.Includes("nativeId",true))
        {
            if(this.NativeId == null) {

                this.NativeId = "FETCH";

            } else {


            }
        }
        else if (this.NativeId != null && ec.Excludes("nativeId",true))
        {
            this.NativeId = null;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (ec.Includes("numWorkloadDescendants",true))
        {
            if(this.NumWorkloadDescendants == null) {

                this.NumWorkloadDescendants = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumWorkloadDescendants != null && ec.Excludes("numWorkloadDescendants",true))
        {
            this.NumWorkloadDescendants = null;
        }
        //      C# -> System.Int32? ProjectCount
        // GraphQL -> projectCount: Int! (scalar)
        if (ec.Includes("projectCount",true))
        {
            if(this.ProjectCount == null) {

                this.ProjectCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ProjectCount != null && ec.Excludes("projectCount",true))
        {
            this.ProjectCount = null;
        }
        //      C# -> System.Int32? RepoCount
        // GraphQL -> repoCount: Int! (scalar)
        if (ec.Includes("repoCount",true))
        {
            if(this.RepoCount == null) {

                this.RepoCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.RepoCount != null && ec.Excludes("repoCount",true))
        {
            this.RepoCount = null;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (ec.Includes("slaPauseStatus",true))
        {
            if(this.SlaPauseStatus == null) {

                this.SlaPauseStatus = true;

            } else {


            }
        }
        else if (this.SlaPauseStatus != null && ec.Excludes("slaPauseStatus",true))
        {
            this.SlaPauseStatus = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
        //      C# -> System.String? TenantUuid
        // GraphQL -> tenantUuid: UUID (scalar)
        if (ec.Includes("tenantUuid",true))
        {
            if(this.TenantUuid == null) {

                this.TenantUuid = "FETCH";

            } else {


            }
        }
        else if (this.TenantUuid != null && ec.Excludes("tenantUuid",true))
        {
            this.TenantUuid = null;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (ec.Includes("allOrgs",false))
        {
            if(this.AllOrgs == null) {

                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            } else {

                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            }
        }
        else if (this.AllOrgs != null && ec.Excludes("allOrgs",false))
        {
            this.AllOrgs = null;
        }
        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        if (ec.Includes("allTags",false))
        {
            if(this.AllTags == null) {

                this.AllTags = new List<AssignedRscTag>();
                this.AllTags.ApplyExploratoryFieldSpec(ec.NewChild("allTags"));

            } else {

                this.AllTags.ApplyExploratoryFieldSpec(ec.NewChild("allTags"));

            }
        }
        else if (this.AllTags != null && ec.Excludes("allTags",false))
        {
            this.AllTags = null;
        }
        //      C# -> DevOpsBackupLocation? BackupLocation
        // GraphQL -> backupLocation: DevOpsBackupLocation (type)
        if (ec.Includes("backupLocation",false))
        {
            if(this.BackupLocation == null) {

                this.BackupLocation = new DevOpsBackupLocation();
                this.BackupLocation.ApplyExploratoryFieldSpec(ec.NewChild("backupLocation"));

            } else {

                this.BackupLocation.ApplyExploratoryFieldSpec(ec.NewChild("backupLocation"));

            }
        }
        else if (this.BackupLocation != null && ec.Excludes("backupLocation",false))
        {
            this.BackupLocation = null;
        }
        //      C# -> DevOpsCloudNativeExocompute? CloudNativeExocompute
        // GraphQL -> cloudNativeExocompute: DevOpsCloudNativeExocompute (type)
        if (ec.Includes("cloudNativeExocompute",false))
        {
            if(this.CloudNativeExocompute == null) {

                this.CloudNativeExocompute = new DevOpsCloudNativeExocompute();
                this.CloudNativeExocompute.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeExocompute"));

            } else {

                this.CloudNativeExocompute.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeExocompute"));

            }
        }
        else if (this.CloudNativeExocompute != null && ec.Excludes("cloudNativeExocompute",false))
        {
            this.CloudNativeExocompute = null;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (ec.Includes("effectiveSlaSourceObject",false))
        {
            if(this.EffectiveSlaSourceObject == null) {

                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            } else {

                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            }
        }
        else if (this.EffectiveSlaSourceObject != null && ec.Excludes("effectiveSlaSourceObject",false))
        {
            this.EffectiveSlaSourceObject = null;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (ec.Includes("logicalPath",false))
        {
            if(this.LogicalPath == null) {

                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            } else {

                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            }
        }
        else if (this.LogicalPath != null && ec.Excludes("logicalPath",false))
        {
            this.LogicalPath = null;
        }
        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        if (ec.Includes("objectPauseStatus",false))
        {
            if(this.ObjectPauseStatus == null) {

                this.ObjectPauseStatus = new ObjectPauseStatus();
                this.ObjectPauseStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectPauseStatus"));

            } else {

                this.ObjectPauseStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectPauseStatus"));

            }
        }
        else if (this.ObjectPauseStatus != null && ec.Excludes("objectPauseStatus",false))
        {
            this.ObjectPauseStatus = null;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (ec.Includes("physicalPath",false))
        {
            if(this.PhysicalPath == null) {

                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            } else {

                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            }
        }
        else if (this.PhysicalPath != null && ec.Excludes("physicalPath",false))
        {
            this.PhysicalPath = null;
        }
        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        if (ec.Includes("rscNativeObjectPendingSla",false))
        {
            if(this.RscNativeObjectPendingSla == null) {

                this.RscNativeObjectPendingSla = new CompactSlaDomain();
                this.RscNativeObjectPendingSla.ApplyExploratoryFieldSpec(ec.NewChild("rscNativeObjectPendingSla"));

            } else {

                this.RscNativeObjectPendingSla.ApplyExploratoryFieldSpec(ec.NewChild("rscNativeObjectPendingSla"));

            }
        }
        else if (this.RscNativeObjectPendingSla != null && ec.Excludes("rscNativeObjectPendingSla",false))
        {
            this.RscNativeObjectPendingSla = null;
        }
        //      C# -> DevOpsRubrikHostedExocompute? RubrikHostedExocompute
        // GraphQL -> rubrikHostedExocompute: DevOpsRubrikHostedExocompute (type)
        if (ec.Includes("rubrikHostedExocompute",false))
        {
            if(this.RubrikHostedExocompute == null) {

                this.RubrikHostedExocompute = new DevOpsRubrikHostedExocompute();
                this.RubrikHostedExocompute.ApplyExploratoryFieldSpec(ec.NewChild("rubrikHostedExocompute"));

            } else {

                this.RubrikHostedExocompute.ApplyExploratoryFieldSpec(ec.NewChild("rubrikHostedExocompute"));

            }
        }
        else if (this.RubrikHostedExocompute != null && ec.Excludes("rubrikHostedExocompute",false))
        {
            this.RubrikHostedExocompute = null;
        }
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (ec.Includes("securityMetadata",false))
        {
            if(this.SecurityMetadata == null) {

                this.SecurityMetadata = new SecurityMetadata();
                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            } else {

                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            }
        }
        else if (this.SecurityMetadata != null && ec.Excludes("securityMetadata",false))
        {
            this.SecurityMetadata = null;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (ec.Includes("snapshotDistribution",false))
        {
            if(this.SnapshotDistribution == null) {

                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            } else {

                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            }
        }
        else if (this.SnapshotDistribution != null && ec.Excludes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = null;
        }
    }


    #endregion

    } // class AzureDevOpsOrganization
    
    #endregion

    public static class ListAzureDevOpsOrganizationExtensions
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
            this List<AzureDevOpsOrganization> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureDevOpsOrganization> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureDevOpsOrganization> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureDevOpsOrganization());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureDevOpsOrganization> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types