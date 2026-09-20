// AzureCosmosNosqlContainer.cs
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
    #region AzureCosmosNosqlContainer
 
    public class AzureCosmosNosqlContainer: BaseType, HierarchyObject, HierarchySnappable, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        [JsonProperty("region")]
        public AzureNativeRegion? Region { get; set; }

        //      C# -> PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment
        // GraphQL -> rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        [JsonProperty("rscPendingObjectPauseAssignment")]
        public PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> AzureCosmosNosqlThroughputMode? ThroughputMode
        // GraphQL -> throughputMode: AzureCosmosNosqlThroughputMode! (enum)
        [JsonProperty("throughputMode")]
        public AzureCosmosNosqlThroughputMode? ThroughputMode { get; set; }

        //      C# -> AzureCosmosNosqlThroughputScope? ThroughputScope
        // GraphQL -> throughputScope: AzureCosmosNosqlThroughputScope! (enum)
        [JsonProperty("throughputScope")]
        public AzureCosmosNosqlThroughputScope? ThroughputScope { get; set; }

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

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.Int32? AutoscaleMaxRuPerSec
        // GraphQL -> autoscaleMaxRuPerSec: Int! (scalar)
        [JsonProperty("autoscaleMaxRuPerSec")]
        public System.Int32? AutoscaleMaxRuPerSec { get; set; }

        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        [JsonProperty("cloudNativeId")]
        public System.String? CloudNativeId { get; set; }

        //      C# -> System.String? ConflictResolutionMode
        // GraphQL -> conflictResolutionMode: String! (scalar)
        [JsonProperty("conflictResolutionMode")]
        public System.String? ConflictResolutionMode { get; set; }

        //      C# -> System.String? ConflictResolutionPath
        // GraphQL -> conflictResolutionPath: String! (scalar)
        [JsonProperty("conflictResolutionPath")]
        public System.String? ConflictResolutionPath { get; set; }

        //      C# -> System.String? ConflictResolutionProcedure
        // GraphQL -> conflictResolutionProcedure: String! (scalar)
        [JsonProperty("conflictResolutionProcedure")]
        public System.String? ConflictResolutionProcedure { get; set; }

        //      C# -> System.String? ContainerName
        // GraphQL -> containerName: String! (scalar)
        [JsonProperty("containerName")]
        public System.String? ContainerName { get; set; }

        //      C# -> System.String? CosmosDbDatabaseId
        // GraphQL -> cosmosDbDatabaseId: String! (scalar)
        [JsonProperty("cosmosDbDatabaseId")]
        public System.String? CosmosDbDatabaseId { get; set; }

        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        [JsonProperty("databaseName")]
        public System.String? DatabaseName { get; set; }

        //      C# -> System.Int32? DefaultTtlSeconds
        // GraphQL -> defaultTtlSeconds: Int! (scalar)
        [JsonProperty("defaultTtlSeconds")]
        public System.Int32? DefaultTtlSeconds { get; set; }

        //      C# -> System.Int32? ExcludedPathCount
        // GraphQL -> excludedPathCount: Int! (scalar)
        [JsonProperty("excludedPathCount")]
        public System.Int32? ExcludedPathCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? IndexedPathCount
        // GraphQL -> indexedPathCount: Int! (scalar)
        [JsonProperty("indexedPathCount")]
        public System.Int32? IndexedPathCount { get; set; }

        //      C# -> System.String? IndexingMode
        // GraphQL -> indexingMode: String! (scalar)
        [JsonProperty("indexingMode")]
        public System.String? IndexingMode { get; set; }

        //      C# -> System.Boolean? IsIndexingAutomatic
        // GraphQL -> isIndexingAutomatic: Boolean! (scalar)
        [JsonProperty("isIndexingAutomatic")]
        public System.Boolean? IsIndexingAutomatic { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? PartitionKeyPath
        // GraphQL -> partitionKeyPath: String! (scalar)
        [JsonProperty("partitionKeyPath")]
        public System.String? PartitionKeyPath { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Int32? ThroughputRuPerSec
        // GraphQL -> throughputRuPerSec: Int! (scalar)
        [JsonProperty("throughputRuPerSec")]
        public System.Int32? ThroughputRuPerSec { get; set; }

        //      C# -> System.Int32? UniqueKeyCount
        // GraphQL -> uniqueKeyCount: Int! (scalar)
        [JsonProperty("uniqueKeyCount")]
        public System.Int32? UniqueKeyCount { get; set; }

        //      C# -> System.String? UniqueKeyPaths
        // GraphQL -> uniqueKeyPaths: String! (scalar)
        [JsonProperty("uniqueKeyPaths")]
        public System.String? UniqueKeyPaths { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        [JsonProperty("allTags")]
        public List<AssignedRscTag>? AllTags { get; set; }

        //      C# -> PathNode? BackupSetupSourceObject
        // GraphQL -> backupSetupSourceObject: PathNode (type)
        [JsonProperty("backupSetupSourceObject")]
        public PathNode? BackupSetupSourceObject { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestIndexedSnapshot")]
        public PolarisSnapshot? NewestIndexedSnapshot { get; set; }

        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public PolarisSnapshot? NewestSnapshot { get; set; }

        //      C# -> ObjectBackupWindowStatus? ObjectBackupWindow
        // GraphQL -> objectBackupWindow: ObjectBackupWindowStatus (type)
        [JsonProperty("objectBackupWindow")]
        public ObjectBackupWindowStatus? ObjectBackupWindow { get; set; }

        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        [JsonProperty("objectPauseStatus")]
        public ObjectPauseStatus? ObjectPauseStatus { get; set; }

        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public PolarisSnapshot? OldestSnapshot { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        [JsonProperty("rscNativeObjectPendingSla")]
        public CompactSlaDomain? RscNativeObjectPendingSla { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        public SecurityMetadata? SecurityMetadata { get; set; }

        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public PolarisSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public PolarisSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        [JsonProperty("snapshotGroupByNewConnection")]
        public PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection { get; set; }

        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        [JsonProperty("workloadSnapshotConnection")]
        public GenericSnapshotConnection? WorkloadSnapshotConnection { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars NumWorkloadDescendants { get; set; }

        public RscGqlVars OnDemandSnapshotCount { get; set; }

        public RscGqlVars NewestSnapshot { get; set; }

        public RscGqlVars OldestSnapshot { get; set; }

        public RscGqlVars SnapshotConnection { get; set; }

        public RscGqlVars SnapshotGroupByConnection { get; set; }

        public RscGqlVars SnapshotGroupByNewConnection { get; set; }

        public RscGqlVars WorkloadSnapshotConnection { get; set; }


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
            Tuple<string, string>[] onDemandSnapshotCountArgs = {
                    Tuple.Create("backupLocationId", "String"),
                };
            this.OnDemandSnapshotCount =
                new RscGqlVars(null, onDemandSnapshotCountArgs, null, true);
            Tuple<string, string>[] newestSnapshotArgs = {
                    Tuple.Create("backupLocationId", "String"),
                };
            this.NewestSnapshot =
                new RscGqlVars(null, newestSnapshotArgs, null, true);
            Tuple<string, string>[] oldestSnapshotArgs = {
                    Tuple.Create("backupLocationId", "String"),
                };
            this.OldestSnapshot =
                new RscGqlVars(null, oldestSnapshotArgs, null, true);
            Tuple<string, string>[] snapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "PolarisSnapshotFilterInput"),
                    Tuple.Create("sortBy", "PolarisSnapshotSortByEnum"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.SnapshotConnection =
                new RscGqlVars(null, snapshotConnectionArgs, null, true);
            Tuple<string, string>[] snapshotGroupByConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("filter", "PolarisSnapshotFilterInput"),
                    Tuple.Create("groupBy", "PolarisSnapshotGroupByEnum!"),
                    Tuple.Create("timezone", "Timezone"),
                };
            this.SnapshotGroupByConnection =
                new RscGqlVars(null, snapshotGroupByConnectionArgs, null, true);
            Tuple<string, string>[] snapshotGroupByNewConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("snapshotFilter", "[PolarisSnapshotFilterNewInput!]!"),
                    Tuple.Create("snapshotGroupBy", "SnapshotGroupByTime!"),
                };
            this.SnapshotGroupByNewConnection =
                new RscGqlVars(null, snapshotGroupByNewConnectionArgs, null, true);
            Tuple<string, string>[] workloadSnapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("workloadId", "String!"),
                    Tuple.Create("snapshotFilter", "[SnapshotQueryFilterInput!]"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "SnapshotQuerySortByField"),
                    Tuple.Create("timeRange", "TimeRangeInput"),
                    Tuple.Create("ignoreActiveWorkloadCheck", "Boolean"),
                };
            this.WorkloadSnapshotConnection =
                new RscGqlVars(null, workloadSnapshotConnectionArgs, null, true);
        }
    }

    public AzureCosmosNosqlContainer()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "AzureCosmosNosqlContainer";
    }

    public AzureCosmosNosqlContainer Set(
        List<Operation>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        AzureNativeRegion? Region = null,
        PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        AzureCosmosNosqlThroughputMode? ThroughputMode = null,
        AzureCosmosNosqlThroughputScope? ThroughputScope = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? AccountName = null,
        System.Int32? AutoscaleMaxRuPerSec = null,
        System.String? CloudNativeId = null,
        System.String? ConflictResolutionMode = null,
        System.String? ConflictResolutionPath = null,
        System.String? ConflictResolutionProcedure = null,
        System.String? ContainerName = null,
        System.String? CosmosDbDatabaseId = null,
        System.String? DatabaseName = null,
        System.Int32? DefaultTtlSeconds = null,
        System.Int32? ExcludedPathCount = null,
        System.String? Id = null,
        System.Int32? IndexedPathCount = null,
        System.String? IndexingMode = null,
        System.Boolean? IsIndexingAutomatic = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? PartitionKeyPath = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int32? ThroughputRuPerSec = null,
        System.Int32? UniqueKeyCount = null,
        System.String? UniqueKeyPaths = null,
        List<Org>? AllOrgs = null,
        List<AssignedRscTag>? AllTags = null,
        PathNode? BackupSetupSourceObject = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        ObjectBackupWindowStatus? ObjectBackupWindow = null,
        ObjectPauseStatus? ObjectPauseStatus = null,
        PolarisSnapshot? OldestSnapshot = null,
        List<PathNode>? PhysicalPath = null,
        CompactSlaDomain? RscNativeObjectPendingSla = null,
        SecurityMetadata? SecurityMetadata = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( RscPendingObjectPauseAssignment != null ) {
            this.RscPendingObjectPauseAssignment = RscPendingObjectPauseAssignment;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ThroughputMode != null ) {
            this.ThroughputMode = ThroughputMode;
        }
        if ( ThroughputScope != null ) {
            this.ThroughputScope = ThroughputScope;
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
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( AutoscaleMaxRuPerSec != null ) {
            this.AutoscaleMaxRuPerSec = AutoscaleMaxRuPerSec;
        }
        if ( CloudNativeId != null ) {
            this.CloudNativeId = CloudNativeId;
        }
        if ( ConflictResolutionMode != null ) {
            this.ConflictResolutionMode = ConflictResolutionMode;
        }
        if ( ConflictResolutionPath != null ) {
            this.ConflictResolutionPath = ConflictResolutionPath;
        }
        if ( ConflictResolutionProcedure != null ) {
            this.ConflictResolutionProcedure = ConflictResolutionProcedure;
        }
        if ( ContainerName != null ) {
            this.ContainerName = ContainerName;
        }
        if ( CosmosDbDatabaseId != null ) {
            this.CosmosDbDatabaseId = CosmosDbDatabaseId;
        }
        if ( DatabaseName != null ) {
            this.DatabaseName = DatabaseName;
        }
        if ( DefaultTtlSeconds != null ) {
            this.DefaultTtlSeconds = DefaultTtlSeconds;
        }
        if ( ExcludedPathCount != null ) {
            this.ExcludedPathCount = ExcludedPathCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IndexedPathCount != null ) {
            this.IndexedPathCount = IndexedPathCount;
        }
        if ( IndexingMode != null ) {
            this.IndexingMode = IndexingMode;
        }
        if ( IsIndexingAutomatic != null ) {
            this.IsIndexingAutomatic = IsIndexingAutomatic;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( PartitionKeyPath != null ) {
            this.PartitionKeyPath = PartitionKeyPath;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( ThroughputRuPerSec != null ) {
            this.ThroughputRuPerSec = ThroughputRuPerSec;
        }
        if ( UniqueKeyCount != null ) {
            this.UniqueKeyCount = UniqueKeyCount;
        }
        if ( UniqueKeyPaths != null ) {
            this.UniqueKeyPaths = UniqueKeyPaths;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AllTags != null ) {
            this.AllTags = AllTags;
        }
        if ( BackupSetupSourceObject != null ) {
            this.BackupSetupSourceObject = BackupSetupSourceObject;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( NewestIndexedSnapshot != null ) {
            this.NewestIndexedSnapshot = NewestIndexedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( ObjectBackupWindow != null ) {
            this.ObjectBackupWindow = ObjectBackupWindow;
        }
        if ( ObjectPauseStatus != null ) {
            this.ObjectPauseStatus = ObjectPauseStatus;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( RscNativeObjectPendingSla != null ) {
            this.RscNativeObjectPendingSla = RscNativeObjectPendingSla;
        }
        if ( SecurityMetadata != null ) {
            this.SecurityMetadata = SecurityMetadata;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SnapshotGroupByConnection != null ) {
            this.SnapshotGroupByConnection = SnapshotGroupByConnection;
        }
        if ( SnapshotGroupByNewConnection != null ) {
            this.SnapshotGroupByNewConnection = SnapshotGroupByNewConnection;
        }
        if ( WorkloadSnapshotConnection != null ) {
            this.WorkloadSnapshotConnection = WorkloadSnapshotConnection;
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
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
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
        //      C# -> AzureCosmosNosqlThroughputMode? ThroughputMode
        // GraphQL -> throughputMode: AzureCosmosNosqlThroughputMode! (enum)
        if (this.ThroughputMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "throughputMode\n" ;
            } else {
                s += ind + "throughputMode\n" ;
            }
        }
        //      C# -> AzureCosmosNosqlThroughputScope? ThroughputScope
        // GraphQL -> throughputScope: AzureCosmosNosqlThroughputScope! (enum)
        if (this.ThroughputScope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "throughputScope\n" ;
            } else {
                s += ind + "throughputScope\n" ;
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
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountName\n" ;
            } else {
                s += ind + "accountName\n" ;
            }
        }
        //      C# -> System.Int32? AutoscaleMaxRuPerSec
        // GraphQL -> autoscaleMaxRuPerSec: Int! (scalar)
        if (this.AutoscaleMaxRuPerSec != null) {
            if (conf.Flat) {
                s += conf.Prefix + "autoscaleMaxRuPerSec\n" ;
            } else {
                s += ind + "autoscaleMaxRuPerSec\n" ;
            }
        }
        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        if (this.CloudNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeId\n" ;
            } else {
                s += ind + "cloudNativeId\n" ;
            }
        }
        //      C# -> System.String? ConflictResolutionMode
        // GraphQL -> conflictResolutionMode: String! (scalar)
        if (this.ConflictResolutionMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "conflictResolutionMode\n" ;
            } else {
                s += ind + "conflictResolutionMode\n" ;
            }
        }
        //      C# -> System.String? ConflictResolutionPath
        // GraphQL -> conflictResolutionPath: String! (scalar)
        if (this.ConflictResolutionPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "conflictResolutionPath\n" ;
            } else {
                s += ind + "conflictResolutionPath\n" ;
            }
        }
        //      C# -> System.String? ConflictResolutionProcedure
        // GraphQL -> conflictResolutionProcedure: String! (scalar)
        if (this.ConflictResolutionProcedure != null) {
            if (conf.Flat) {
                s += conf.Prefix + "conflictResolutionProcedure\n" ;
            } else {
                s += ind + "conflictResolutionProcedure\n" ;
            }
        }
        //      C# -> System.String? ContainerName
        // GraphQL -> containerName: String! (scalar)
        if (this.ContainerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containerName\n" ;
            } else {
                s += ind + "containerName\n" ;
            }
        }
        //      C# -> System.String? CosmosDbDatabaseId
        // GraphQL -> cosmosDbDatabaseId: String! (scalar)
        if (this.CosmosDbDatabaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cosmosDbDatabaseId\n" ;
            } else {
                s += ind + "cosmosDbDatabaseId\n" ;
            }
        }
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (this.DatabaseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseName\n" ;
            } else {
                s += ind + "databaseName\n" ;
            }
        }
        //      C# -> System.Int32? DefaultTtlSeconds
        // GraphQL -> defaultTtlSeconds: Int! (scalar)
        if (this.DefaultTtlSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultTtlSeconds\n" ;
            } else {
                s += ind + "defaultTtlSeconds\n" ;
            }
        }
        //      C# -> System.Int32? ExcludedPathCount
        // GraphQL -> excludedPathCount: Int! (scalar)
        if (this.ExcludedPathCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedPathCount\n" ;
            } else {
                s += ind + "excludedPathCount\n" ;
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
        //      C# -> System.Int32? IndexedPathCount
        // GraphQL -> indexedPathCount: Int! (scalar)
        if (this.IndexedPathCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexedPathCount\n" ;
            } else {
                s += ind + "indexedPathCount\n" ;
            }
        }
        //      C# -> System.String? IndexingMode
        // GraphQL -> indexingMode: String! (scalar)
        if (this.IndexingMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexingMode\n" ;
            } else {
                s += ind + "indexingMode\n" ;
            }
        }
        //      C# -> System.Boolean? IsIndexingAutomatic
        // GraphQL -> isIndexingAutomatic: Boolean! (scalar)
        if (this.IsIndexingAutomatic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isIndexingAutomatic\n" ;
            } else {
                s += ind + "isIndexingAutomatic\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onDemandSnapshotCount\n" ;
            } else {
                s += ind + "onDemandSnapshotCount\n" ;
            }
        }
        //      C# -> System.String? PartitionKeyPath
        // GraphQL -> partitionKeyPath: String! (scalar)
        if (this.PartitionKeyPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "partitionKeyPath\n" ;
            } else {
                s += ind + "partitionKeyPath\n" ;
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
        //      C# -> System.Int32? ThroughputRuPerSec
        // GraphQL -> throughputRuPerSec: Int! (scalar)
        if (this.ThroughputRuPerSec != null) {
            if (conf.Flat) {
                s += conf.Prefix + "throughputRuPerSec\n" ;
            } else {
                s += ind + "throughputRuPerSec\n" ;
            }
        }
        //      C# -> System.Int32? UniqueKeyCount
        // GraphQL -> uniqueKeyCount: Int! (scalar)
        if (this.UniqueKeyCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uniqueKeyCount\n" ;
            } else {
                s += ind + "uniqueKeyCount\n" ;
            }
        }
        //      C# -> System.String? UniqueKeyPaths
        // GraphQL -> uniqueKeyPaths: String! (scalar)
        if (this.UniqueKeyPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uniqueKeyPaths\n" ;
            } else {
                s += ind + "uniqueKeyPaths\n" ;
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
        //      C# -> PathNode? BackupSetupSourceObject
        // GraphQL -> backupSetupSourceObject: PathNode (type)
        if (this.BackupSetupSourceObject != null) {
            var fspec = this.BackupSetupSourceObject.AsFieldSpec(conf.Child("backupSetupSourceObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupSetupSourceObject" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot != null) {
            var fspec = this.NewestIndexedSnapshot.AsFieldSpec(conf.Child("newestIndexedSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestIndexedSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(conf.Child("newestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestSnapshot" + "\n(" + this.Vars.NewestSnapshot.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectBackupWindowStatus? ObjectBackupWindow
        // GraphQL -> objectBackupWindow: ObjectBackupWindowStatus (type)
        if (this.ObjectBackupWindow != null) {
            var fspec = this.ObjectBackupWindow.AsFieldSpec(conf.Child("objectBackupWindow"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectBackupWindow" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(conf.Child("oldestSnapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldestSnapshot" + "\n(" + this.Vars.OldestSnapshot.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(conf.Child("snapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotConnection" + "\n(" + this.Vars.SnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(conf.Child("snapshotGroupByConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupByConnection" + "\n(" + this.Vars.SnapshotGroupByConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection != null) {
            var fspec = this.SnapshotGroupByNewConnection.AsFieldSpec(conf.Child("snapshotGroupByNewConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupByNewConnection" + "\n(" + this.Vars.SnapshotGroupByNewConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection != null) {
            var fspec = this.WorkloadSnapshotConnection.AsFieldSpec(conf.Child("workloadSnapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadSnapshotConnection" + "\n(" + this.Vars.WorkloadSnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AzureNativeRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
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
        //      C# -> AzureCosmosNosqlThroughputMode? ThroughputMode
        // GraphQL -> throughputMode: AzureCosmosNosqlThroughputMode! (enum)
        if (ec.Includes("throughputMode",true))
        {
            if(this.ThroughputMode == null) {

                this.ThroughputMode = new AzureCosmosNosqlThroughputMode();

            } else {


            }
        }
        else if (this.ThroughputMode != null && ec.Excludes("throughputMode",true))
        {
            this.ThroughputMode = null;
        }
        //      C# -> AzureCosmosNosqlThroughputScope? ThroughputScope
        // GraphQL -> throughputScope: AzureCosmosNosqlThroughputScope! (enum)
        if (ec.Includes("throughputScope",true))
        {
            if(this.ThroughputScope == null) {

                this.ThroughputScope = new AzureCosmosNosqlThroughputScope();

            } else {


            }
        }
        else if (this.ThroughputScope != null && ec.Excludes("throughputScope",true))
        {
            this.ThroughputScope = null;
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
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (ec.Includes("accountName",true))
        {
            if(this.AccountName == null) {

                this.AccountName = "FETCH";

            } else {


            }
        }
        else if (this.AccountName != null && ec.Excludes("accountName",true))
        {
            this.AccountName = null;
        }
        //      C# -> System.Int32? AutoscaleMaxRuPerSec
        // GraphQL -> autoscaleMaxRuPerSec: Int! (scalar)
        if (ec.Includes("autoscaleMaxRuPerSec",true))
        {
            if(this.AutoscaleMaxRuPerSec == null) {

                this.AutoscaleMaxRuPerSec = Int32.MinValue;

            } else {


            }
        }
        else if (this.AutoscaleMaxRuPerSec != null && ec.Excludes("autoscaleMaxRuPerSec",true))
        {
            this.AutoscaleMaxRuPerSec = null;
        }
        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        if (ec.Includes("cloudNativeId",true))
        {
            if(this.CloudNativeId == null) {

                this.CloudNativeId = "FETCH";

            } else {


            }
        }
        else if (this.CloudNativeId != null && ec.Excludes("cloudNativeId",true))
        {
            this.CloudNativeId = null;
        }
        //      C# -> System.String? ConflictResolutionMode
        // GraphQL -> conflictResolutionMode: String! (scalar)
        if (ec.Includes("conflictResolutionMode",true))
        {
            if(this.ConflictResolutionMode == null) {

                this.ConflictResolutionMode = "FETCH";

            } else {


            }
        }
        else if (this.ConflictResolutionMode != null && ec.Excludes("conflictResolutionMode",true))
        {
            this.ConflictResolutionMode = null;
        }
        //      C# -> System.String? ConflictResolutionPath
        // GraphQL -> conflictResolutionPath: String! (scalar)
        if (ec.Includes("conflictResolutionPath",true))
        {
            if(this.ConflictResolutionPath == null) {

                this.ConflictResolutionPath = "FETCH";

            } else {


            }
        }
        else if (this.ConflictResolutionPath != null && ec.Excludes("conflictResolutionPath",true))
        {
            this.ConflictResolutionPath = null;
        }
        //      C# -> System.String? ConflictResolutionProcedure
        // GraphQL -> conflictResolutionProcedure: String! (scalar)
        if (ec.Includes("conflictResolutionProcedure",true))
        {
            if(this.ConflictResolutionProcedure == null) {

                this.ConflictResolutionProcedure = "FETCH";

            } else {


            }
        }
        else if (this.ConflictResolutionProcedure != null && ec.Excludes("conflictResolutionProcedure",true))
        {
            this.ConflictResolutionProcedure = null;
        }
        //      C# -> System.String? ContainerName
        // GraphQL -> containerName: String! (scalar)
        if (ec.Includes("containerName",true))
        {
            if(this.ContainerName == null) {

                this.ContainerName = "FETCH";

            } else {


            }
        }
        else if (this.ContainerName != null && ec.Excludes("containerName",true))
        {
            this.ContainerName = null;
        }
        //      C# -> System.String? CosmosDbDatabaseId
        // GraphQL -> cosmosDbDatabaseId: String! (scalar)
        if (ec.Includes("cosmosDbDatabaseId",true))
        {
            if(this.CosmosDbDatabaseId == null) {

                this.CosmosDbDatabaseId = "FETCH";

            } else {


            }
        }
        else if (this.CosmosDbDatabaseId != null && ec.Excludes("cosmosDbDatabaseId",true))
        {
            this.CosmosDbDatabaseId = null;
        }
        //      C# -> System.String? DatabaseName
        // GraphQL -> databaseName: String! (scalar)
        if (ec.Includes("databaseName",true))
        {
            if(this.DatabaseName == null) {

                this.DatabaseName = "FETCH";

            } else {


            }
        }
        else if (this.DatabaseName != null && ec.Excludes("databaseName",true))
        {
            this.DatabaseName = null;
        }
        //      C# -> System.Int32? DefaultTtlSeconds
        // GraphQL -> defaultTtlSeconds: Int! (scalar)
        if (ec.Includes("defaultTtlSeconds",true))
        {
            if(this.DefaultTtlSeconds == null) {

                this.DefaultTtlSeconds = Int32.MinValue;

            } else {


            }
        }
        else if (this.DefaultTtlSeconds != null && ec.Excludes("defaultTtlSeconds",true))
        {
            this.DefaultTtlSeconds = null;
        }
        //      C# -> System.Int32? ExcludedPathCount
        // GraphQL -> excludedPathCount: Int! (scalar)
        if (ec.Includes("excludedPathCount",true))
        {
            if(this.ExcludedPathCount == null) {

                this.ExcludedPathCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ExcludedPathCount != null && ec.Excludes("excludedPathCount",true))
        {
            this.ExcludedPathCount = null;
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
        //      C# -> System.Int32? IndexedPathCount
        // GraphQL -> indexedPathCount: Int! (scalar)
        if (ec.Includes("indexedPathCount",true))
        {
            if(this.IndexedPathCount == null) {

                this.IndexedPathCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.IndexedPathCount != null && ec.Excludes("indexedPathCount",true))
        {
            this.IndexedPathCount = null;
        }
        //      C# -> System.String? IndexingMode
        // GraphQL -> indexingMode: String! (scalar)
        if (ec.Includes("indexingMode",true))
        {
            if(this.IndexingMode == null) {

                this.IndexingMode = "FETCH";

            } else {


            }
        }
        else if (this.IndexingMode != null && ec.Excludes("indexingMode",true))
        {
            this.IndexingMode = null;
        }
        //      C# -> System.Boolean? IsIndexingAutomatic
        // GraphQL -> isIndexingAutomatic: Boolean! (scalar)
        if (ec.Includes("isIndexingAutomatic",true))
        {
            if(this.IsIndexingAutomatic == null) {

                this.IsIndexingAutomatic = true;

            } else {


            }
        }
        else if (this.IsIndexingAutomatic != null && ec.Excludes("isIndexingAutomatic",true))
        {
            this.IsIndexingAutomatic = null;
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
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (ec.Includes("onDemandSnapshotCount",true))
        {
            if(this.OnDemandSnapshotCount == null) {

                this.OnDemandSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.OnDemandSnapshotCount != null && ec.Excludes("onDemandSnapshotCount",true))
        {
            this.OnDemandSnapshotCount = null;
        }
        //      C# -> System.String? PartitionKeyPath
        // GraphQL -> partitionKeyPath: String! (scalar)
        if (ec.Includes("partitionKeyPath",true))
        {
            if(this.PartitionKeyPath == null) {

                this.PartitionKeyPath = "FETCH";

            } else {


            }
        }
        else if (this.PartitionKeyPath != null && ec.Excludes("partitionKeyPath",true))
        {
            this.PartitionKeyPath = null;
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
        //      C# -> System.Int32? ThroughputRuPerSec
        // GraphQL -> throughputRuPerSec: Int! (scalar)
        if (ec.Includes("throughputRuPerSec",true))
        {
            if(this.ThroughputRuPerSec == null) {

                this.ThroughputRuPerSec = Int32.MinValue;

            } else {


            }
        }
        else if (this.ThroughputRuPerSec != null && ec.Excludes("throughputRuPerSec",true))
        {
            this.ThroughputRuPerSec = null;
        }
        //      C# -> System.Int32? UniqueKeyCount
        // GraphQL -> uniqueKeyCount: Int! (scalar)
        if (ec.Includes("uniqueKeyCount",true))
        {
            if(this.UniqueKeyCount == null) {

                this.UniqueKeyCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UniqueKeyCount != null && ec.Excludes("uniqueKeyCount",true))
        {
            this.UniqueKeyCount = null;
        }
        //      C# -> System.String? UniqueKeyPaths
        // GraphQL -> uniqueKeyPaths: String! (scalar)
        if (ec.Includes("uniqueKeyPaths",true))
        {
            if(this.UniqueKeyPaths == null) {

                this.UniqueKeyPaths = "FETCH";

            } else {


            }
        }
        else if (this.UniqueKeyPaths != null && ec.Excludes("uniqueKeyPaths",true))
        {
            this.UniqueKeyPaths = null;
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
        //      C# -> PathNode? BackupSetupSourceObject
        // GraphQL -> backupSetupSourceObject: PathNode (type)
        if (ec.Includes("backupSetupSourceObject",false))
        {
            if(this.BackupSetupSourceObject == null) {

                this.BackupSetupSourceObject = new PathNode();
                this.BackupSetupSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("backupSetupSourceObject"));

            } else {

                this.BackupSetupSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("backupSetupSourceObject"));

            }
        }
        else if (this.BackupSetupSourceObject != null && ec.Excludes("backupSetupSourceObject",false))
        {
            this.BackupSetupSourceObject = null;
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
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (ec.Includes("newestIndexedSnapshot",false))
        {
            if(this.NewestIndexedSnapshot == null) {

                this.NewestIndexedSnapshot = new PolarisSnapshot();
                this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestIndexedSnapshot"));

            } else {

                this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestIndexedSnapshot"));

            }
        }
        else if (this.NewestIndexedSnapshot != null && ec.Excludes("newestIndexedSnapshot",false))
        {
            this.NewestIndexedSnapshot = null;
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (ec.Includes("newestSnapshot",false))
        {
            if(this.NewestSnapshot == null) {

                this.NewestSnapshot = new PolarisSnapshot();
                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            } else {

                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            }
        }
        else if (this.NewestSnapshot != null && ec.Excludes("newestSnapshot",false))
        {
            this.NewestSnapshot = null;
        }
        //      C# -> ObjectBackupWindowStatus? ObjectBackupWindow
        // GraphQL -> objectBackupWindow: ObjectBackupWindowStatus (type)
        if (ec.Includes("objectBackupWindow",false))
        {
            if(this.ObjectBackupWindow == null) {

                this.ObjectBackupWindow = new ObjectBackupWindowStatus();
                this.ObjectBackupWindow.ApplyExploratoryFieldSpec(ec.NewChild("objectBackupWindow"));

            } else {

                this.ObjectBackupWindow.ApplyExploratoryFieldSpec(ec.NewChild("objectBackupWindow"));

            }
        }
        else if (this.ObjectBackupWindow != null && ec.Excludes("objectBackupWindow",false))
        {
            this.ObjectBackupWindow = null;
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
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (ec.Includes("oldestSnapshot",false))
        {
            if(this.OldestSnapshot == null) {

                this.OldestSnapshot = new PolarisSnapshot();
                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            } else {

                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            }
        }
        else if (this.OldestSnapshot != null && ec.Excludes("oldestSnapshot",false))
        {
            this.OldestSnapshot = null;
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
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (ec.Includes("snapshotConnection",false))
        {
            if(this.SnapshotConnection == null) {

                this.SnapshotConnection = new PolarisSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            } else {

                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            }
        }
        else if (this.SnapshotConnection != null && ec.Excludes("snapshotConnection",false))
        {
            this.SnapshotConnection = null;
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
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (ec.Includes("snapshotGroupByConnection",false))
        {
            if(this.SnapshotGroupByConnection == null) {

                this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            } else {

                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            }
        }
        else if (this.SnapshotGroupByConnection != null && ec.Excludes("snapshotGroupByConnection",false))
        {
            this.SnapshotGroupByConnection = null;
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (ec.Includes("snapshotGroupByNewConnection",false))
        {
            if(this.SnapshotGroupByNewConnection == null) {

                this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
                this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByNewConnection"));

            } else {

                this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByNewConnection"));

            }
        }
        else if (this.SnapshotGroupByNewConnection != null && ec.Excludes("snapshotGroupByNewConnection",false))
        {
            this.SnapshotGroupByNewConnection = null;
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (ec.Includes("workloadSnapshotConnection",false))
        {
            if(this.WorkloadSnapshotConnection == null) {

                this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
                this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("workloadSnapshotConnection"));

            } else {

                this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("workloadSnapshotConnection"));

            }
        }
        else if (this.WorkloadSnapshotConnection != null && ec.Excludes("workloadSnapshotConnection",false))
        {
            this.WorkloadSnapshotConnection = null;
        }
    }


    #endregion

    } // class AzureCosmosNosqlContainer
    
    #endregion

    public static class ListAzureCosmosNosqlContainerExtensions
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
            this List<AzureCosmosNosqlContainer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCosmosNosqlContainer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCosmosNosqlContainer> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCosmosNosqlContainer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCosmosNosqlContainer> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types