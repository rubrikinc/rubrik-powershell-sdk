// AzureNativeResourceGroup.cs
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
    #region AzureNativeResourceGroup
 
    public class AzureNativeResourceGroup: BaseType, HierarchyObject, PolarisHierarchyObject
    {
        #region members

        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

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

        //      C# -> System.Int32? AzureSqlDatabaseCount
        // GraphQL -> azureSqlDatabaseCount: Int! (scalar)
        [JsonProperty("azureSqlDatabaseCount")]
        public System.Int32? AzureSqlDatabaseCount { get; set; }

        //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
        // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
        [JsonProperty("azureSqlManagedInstanceDbCount")]
        public System.Int32? AzureSqlManagedInstanceDbCount { get; set; }

        //      C# -> System.Int32? AzureStorageAccountCount
        // GraphQL -> azureStorageAccountCount: Int! (scalar)
        [JsonProperty("azureStorageAccountCount")]
        public System.Int32? AzureStorageAccountCount { get; set; }

        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: UUID! (scalar)
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> System.Int32? DisksCount
        // GraphQL -> disksCount: Int! (scalar)
        [JsonProperty("disksCount")]
        public System.Int32? DisksCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsProtectable
        // GraphQL -> isProtectable: Boolean! (scalar)
        [JsonProperty("isProtectable")]
        public System.Boolean? IsProtectable { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Int32? VmsCount
        // GraphQL -> vmsCount: Int! (scalar)
        [JsonProperty("vmsCount")]
        public System.Int32? VmsCount { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        [JsonProperty("allTags")]
        public List<AssignedRscTag>? AllTags { get; set; }

        //      C# -> AzureNativeSubscriptionDetails? AzureNativeSubscriptionDetails
        // GraphQL -> azureNativeSubscriptionDetails: AzureNativeSubscriptionDetails (type)
        [JsonProperty("azureNativeSubscriptionDetails")]
        public AzureNativeSubscriptionDetails? AzureNativeSubscriptionDetails { get; set; }

        //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
        // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
        [JsonProperty("azureNativeVirtualMachines")]
        public AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines { get; set; }

        //      C# -> AzureNativeSubscription? AzureSubscription
        // GraphQL -> azureSubscription: AzureNativeSubscription (type)
        [JsonProperty("azureSubscription")]
        public AzureNativeSubscription? AzureSubscription { get; set; }

        //      C# -> AzureNativeSubscriptionDetails? AzureSubscriptionDetails
        // GraphQL -> azureSubscriptionDetails: AzureNativeSubscriptionDetails! (type)
        [JsonProperty("azureSubscriptionDetails")]
        public AzureNativeSubscriptionDetails? AzureSubscriptionDetails { get; set; }

        //      C# -> AzureNativeResourceGroupSlaAssignment? DiskSla
        // GraphQL -> diskSla: AzureNativeResourceGroupSlaAssignment! (type)
        [JsonProperty("diskSla")]
        public AzureNativeResourceGroupSlaAssignment? DiskSla { get; set; }

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

        //      C# -> List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla
        // GraphQL -> protectedObjectTypeToSla: [ProtectedObjectTypeToSla!]! (type)
        [JsonProperty("protectedObjectTypeToSla")]
        public List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla { get; set; }

        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        [JsonProperty("rscNativeObjectPendingSla")]
        public CompactSlaDomain? RscNativeObjectPendingSla { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        public SecurityMetadata? SecurityMetadata { get; set; }

        //      C# -> List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs
        // GraphQL -> snappableTypeToBackupSetupSpecs: [WorkloadTypeToBackupSetupSpecs!]! (type)
        [JsonProperty("snappableTypeToBackupSetupSpecs")]
        public List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> AzureNativeSubscription? Subscription
        // GraphQL -> subscription: AzureNativeSubscription! (type)
        [JsonProperty("subscription")]
        public AzureNativeSubscription? Subscription { get; set; }

        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        [JsonProperty("tags")]
        public List<AzureTag>? Tags { get; set; }

        //      C# -> AzureNativeResourceGroupSlaAssignment? VmSla
        // GraphQL -> vmSla: AzureNativeResourceGroupSlaAssignment! (type)
        [JsonProperty("vmSla")]
        public AzureNativeResourceGroupSlaAssignment? VmSla { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars IsProtectable { get; set; }

        public RscGqlVars NumWorkloadDescendants { get; set; }

        public RscGqlVars AzureNativeVirtualMachines { get; set; }


        public InlineVars() {
            Tuple<string, string>[] isProtectableArgs = {
                    Tuple.Create("azureNativeProtectionFeatures", "[AzureNativeProtectionFeature!]"),
                };
            this.IsProtectable =
                new RscGqlVars(null, isProtectableArgs, null, true);
            Tuple<string, string>[] numWorkloadDescendantsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("objectTypes", "[ManagedObjectType!]"),
                };
            this.NumWorkloadDescendants =
                new RscGqlVars(null, numWorkloadDescendantsArgs, null, true);
            Tuple<string, string>[] azureNativeVirtualMachinesArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "AzureNativeVirtualMachineSortFields"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("virtualMachineFilters", "AzureNativeVirtualMachineFilters"),
                };
            this.AzureNativeVirtualMachines =
                new RscGqlVars(null, azureNativeVirtualMachinesArgs, null, true);
        }
    }

    public AzureNativeResourceGroup()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "AzureNativeResourceGroup";
    }

    public AzureNativeResourceGroup Set(
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        AzureNativeRegion? Region = null,
        PendingObjectPauseAssignmentStatus? RscPendingObjectPauseAssignment = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.Int32? AzureSqlDatabaseCount = null,
        System.Int32? AzureSqlManagedInstanceDbCount = null,
        System.Int32? AzureStorageAccountCount = null,
        System.String? AzureSubscriptionRubrikId = null,
        System.Int32? DisksCount = null,
        System.String? Id = null,
        System.Boolean? IsProtectable = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int32? VmsCount = null,
        List<Org>? AllOrgs = null,
        List<AssignedRscTag>? AllTags = null,
        AzureNativeSubscriptionDetails? AzureNativeSubscriptionDetails = null,
        AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines = null,
        AzureNativeSubscription? AzureSubscription = null,
        AzureNativeSubscriptionDetails? AzureSubscriptionDetails = null,
        AzureNativeResourceGroupSlaAssignment? DiskSla = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        ObjectPauseStatus? ObjectPauseStatus = null,
        List<PathNode>? PhysicalPath = null,
        List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla = null,
        CompactSlaDomain? RscNativeObjectPendingSla = null,
        SecurityMetadata? SecurityMetadata = null,
        List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs = null,
        SnapshotDistribution? SnapshotDistribution = null,
        AzureNativeSubscription? Subscription = null,
        List<AzureTag>? Tags = null,
        AzureNativeResourceGroupSlaAssignment? VmSla = null
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
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( AzureSqlDatabaseCount != null ) {
            this.AzureSqlDatabaseCount = AzureSqlDatabaseCount;
        }
        if ( AzureSqlManagedInstanceDbCount != null ) {
            this.AzureSqlManagedInstanceDbCount = AzureSqlManagedInstanceDbCount;
        }
        if ( AzureStorageAccountCount != null ) {
            this.AzureStorageAccountCount = AzureStorageAccountCount;
        }
        if ( AzureSubscriptionRubrikId != null ) {
            this.AzureSubscriptionRubrikId = AzureSubscriptionRubrikId;
        }
        if ( DisksCount != null ) {
            this.DisksCount = DisksCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsProtectable != null ) {
            this.IsProtectable = IsProtectable;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( VmsCount != null ) {
            this.VmsCount = VmsCount;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AllTags != null ) {
            this.AllTags = AllTags;
        }
        if ( AzureNativeSubscriptionDetails != null ) {
            this.AzureNativeSubscriptionDetails = AzureNativeSubscriptionDetails;
        }
        if ( AzureNativeVirtualMachines != null ) {
            this.AzureNativeVirtualMachines = AzureNativeVirtualMachines;
        }
        if ( AzureSubscription != null ) {
            this.AzureSubscription = AzureSubscription;
        }
        if ( AzureSubscriptionDetails != null ) {
            this.AzureSubscriptionDetails = AzureSubscriptionDetails;
        }
        if ( DiskSla != null ) {
            this.DiskSla = DiskSla;
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
        if ( ProtectedObjectTypeToSla != null ) {
            this.ProtectedObjectTypeToSla = ProtectedObjectTypeToSla;
        }
        if ( RscNativeObjectPendingSla != null ) {
            this.RscNativeObjectPendingSla = RscNativeObjectPendingSla;
        }
        if ( SecurityMetadata != null ) {
            this.SecurityMetadata = SecurityMetadata;
        }
        if ( SnappableTypeToBackupSetupSpecs != null ) {
            this.SnappableTypeToBackupSetupSpecs = SnappableTypeToBackupSetupSpecs;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( Subscription != null ) {
            this.Subscription = Subscription;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
        }
        if ( VmSla != null ) {
            this.VmSla = VmSla;
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
        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
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
        //      C# -> System.Int32? AzureSqlDatabaseCount
        // GraphQL -> azureSqlDatabaseCount: Int! (scalar)
        if (this.AzureSqlDatabaseCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSqlDatabaseCount\n" ;
            } else {
                s += ind + "azureSqlDatabaseCount\n" ;
            }
        }
        //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
        // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
        if (this.AzureSqlManagedInstanceDbCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSqlManagedInstanceDbCount\n" ;
            } else {
                s += ind + "azureSqlManagedInstanceDbCount\n" ;
            }
        }
        //      C# -> System.Int32? AzureStorageAccountCount
        // GraphQL -> azureStorageAccountCount: Int! (scalar)
        if (this.AzureStorageAccountCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureStorageAccountCount\n" ;
            } else {
                s += ind + "azureStorageAccountCount\n" ;
            }
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: UUID! (scalar)
        if (this.AzureSubscriptionRubrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSubscriptionRubrikId\n" ;
            } else {
                s += ind + "azureSubscriptionRubrikId\n" ;
            }
        }
        //      C# -> System.Int32? DisksCount
        // GraphQL -> disksCount: Int! (scalar)
        if (this.DisksCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disksCount\n" ;
            } else {
                s += ind + "disksCount\n" ;
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
        //      C# -> System.Boolean? IsProtectable
        // GraphQL -> isProtectable: Boolean! (scalar)
        if (this.IsProtectable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isProtectable\n" ;
            } else {
                s += ind + "isProtectable\n" ;
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
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaPauseStatus\n" ;
            } else {
                s += ind + "slaPauseStatus\n" ;
            }
        }
        //      C# -> System.Int32? VmsCount
        // GraphQL -> vmsCount: Int! (scalar)
        if (this.VmsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmsCount\n" ;
            } else {
                s += ind + "vmsCount\n" ;
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
        //      C# -> AzureNativeSubscriptionDetails? AzureNativeSubscriptionDetails
        // GraphQL -> azureNativeSubscriptionDetails: AzureNativeSubscriptionDetails (type)
        if (this.AzureNativeSubscriptionDetails != null) {
            var fspec = this.AzureNativeSubscriptionDetails.AsFieldSpec(conf.Child("azureNativeSubscriptionDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureNativeSubscriptionDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
        // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
        if (this.AzureNativeVirtualMachines != null) {
            var fspec = this.AzureNativeVirtualMachines.AsFieldSpec(conf.Child("azureNativeVirtualMachines"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureNativeVirtualMachines" + "\n(" + this.Vars.AzureNativeVirtualMachines.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeSubscription? AzureSubscription
        // GraphQL -> azureSubscription: AzureNativeSubscription (type)
        if (this.AzureSubscription != null) {
            var fspec = this.AzureSubscription.AsFieldSpec(conf.Child("azureSubscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureSubscription" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeSubscriptionDetails? AzureSubscriptionDetails
        // GraphQL -> azureSubscriptionDetails: AzureNativeSubscriptionDetails! (type)
        if (this.AzureSubscriptionDetails != null) {
            var fspec = this.AzureSubscriptionDetails.AsFieldSpec(conf.Child("azureSubscriptionDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureSubscriptionDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? DiskSla
        // GraphQL -> diskSla: AzureNativeResourceGroupSlaAssignment! (type)
        if (this.DiskSla != null) {
            var fspec = this.DiskSla.AsFieldSpec(conf.Child("diskSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "diskSla" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla
        // GraphQL -> protectedObjectTypeToSla: [ProtectedObjectTypeToSla!]! (type)
        if (this.ProtectedObjectTypeToSla != null) {
            var fspec = this.ProtectedObjectTypeToSla.AsFieldSpec(conf.Child("protectedObjectTypeToSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "protectedObjectTypeToSla" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs
        // GraphQL -> snappableTypeToBackupSetupSpecs: [WorkloadTypeToBackupSetupSpecs!]! (type)
        if (this.SnappableTypeToBackupSetupSpecs != null) {
            var fspec = this.SnappableTypeToBackupSetupSpecs.AsFieldSpec(conf.Child("snappableTypeToBackupSetupSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappableTypeToBackupSetupSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> AzureNativeSubscription? Subscription
        // GraphQL -> subscription: AzureNativeSubscription! (type)
        if (this.Subscription != null) {
            var fspec = this.Subscription.AsFieldSpec(conf.Child("subscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscription" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(conf.Child("tags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? VmSla
        // GraphQL -> vmSla: AzureNativeResourceGroupSlaAssignment! (type)
        if (this.VmSla != null) {
            var fspec = this.VmSla.AsFieldSpec(conf.Child("vmSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmSla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        if (ec.Includes("authorizedOperations",true))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new List<PolarisObjectAuthorizedOperationsEnum>();

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
        //      C# -> System.Int32? AzureSqlDatabaseCount
        // GraphQL -> azureSqlDatabaseCount: Int! (scalar)
        if (ec.Includes("azureSqlDatabaseCount",true))
        {
            if(this.AzureSqlDatabaseCount == null) {

                this.AzureSqlDatabaseCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AzureSqlDatabaseCount != null && ec.Excludes("azureSqlDatabaseCount",true))
        {
            this.AzureSqlDatabaseCount = null;
        }
        //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
        // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
        if (ec.Includes("azureSqlManagedInstanceDbCount",true))
        {
            if(this.AzureSqlManagedInstanceDbCount == null) {

                this.AzureSqlManagedInstanceDbCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AzureSqlManagedInstanceDbCount != null && ec.Excludes("azureSqlManagedInstanceDbCount",true))
        {
            this.AzureSqlManagedInstanceDbCount = null;
        }
        //      C# -> System.Int32? AzureStorageAccountCount
        // GraphQL -> azureStorageAccountCount: Int! (scalar)
        if (ec.Includes("azureStorageAccountCount",true))
        {
            if(this.AzureStorageAccountCount == null) {

                this.AzureStorageAccountCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AzureStorageAccountCount != null && ec.Excludes("azureStorageAccountCount",true))
        {
            this.AzureStorageAccountCount = null;
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: UUID! (scalar)
        if (ec.Includes("azureSubscriptionRubrikId",true))
        {
            if(this.AzureSubscriptionRubrikId == null) {

                this.AzureSubscriptionRubrikId = "FETCH";

            } else {


            }
        }
        else if (this.AzureSubscriptionRubrikId != null && ec.Excludes("azureSubscriptionRubrikId",true))
        {
            this.AzureSubscriptionRubrikId = null;
        }
        //      C# -> System.Int32? DisksCount
        // GraphQL -> disksCount: Int! (scalar)
        if (ec.Includes("disksCount",true))
        {
            if(this.DisksCount == null) {

                this.DisksCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.DisksCount != null && ec.Excludes("disksCount",true))
        {
            this.DisksCount = null;
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
        //      C# -> System.Boolean? IsProtectable
        // GraphQL -> isProtectable: Boolean! (scalar)
        if (ec.Includes("isProtectable",true))
        {
            if(this.IsProtectable == null) {

                this.IsProtectable = true;

            } else {


            }
        }
        else if (this.IsProtectable != null && ec.Excludes("isProtectable",true))
        {
            this.IsProtectable = null;
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
        //      C# -> System.Int32? VmsCount
        // GraphQL -> vmsCount: Int! (scalar)
        if (ec.Includes("vmsCount",true))
        {
            if(this.VmsCount == null) {

                this.VmsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.VmsCount != null && ec.Excludes("vmsCount",true))
        {
            this.VmsCount = null;
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
        //      C# -> AzureNativeSubscriptionDetails? AzureNativeSubscriptionDetails
        // GraphQL -> azureNativeSubscriptionDetails: AzureNativeSubscriptionDetails (type)
        if (ec.Includes("azureNativeSubscriptionDetails",false))
        {
            if(this.AzureNativeSubscriptionDetails == null) {

                this.AzureNativeSubscriptionDetails = new AzureNativeSubscriptionDetails();
                this.AzureNativeSubscriptionDetails.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeSubscriptionDetails"));

            } else {

                this.AzureNativeSubscriptionDetails.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeSubscriptionDetails"));

            }
        }
        else if (this.AzureNativeSubscriptionDetails != null && ec.Excludes("azureNativeSubscriptionDetails",false))
        {
            this.AzureNativeSubscriptionDetails = null;
        }
        //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
        // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
        if (ec.Includes("azureNativeVirtualMachines",false))
        {
            if(this.AzureNativeVirtualMachines == null) {

                this.AzureNativeVirtualMachines = new AzureNativeVirtualMachineConnection();
                this.AzureNativeVirtualMachines.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeVirtualMachines"));

            } else {

                this.AzureNativeVirtualMachines.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeVirtualMachines"));

            }
        }
        else if (this.AzureNativeVirtualMachines != null && ec.Excludes("azureNativeVirtualMachines",false))
        {
            this.AzureNativeVirtualMachines = null;
        }
        //      C# -> AzureNativeSubscription? AzureSubscription
        // GraphQL -> azureSubscription: AzureNativeSubscription (type)
        if (ec.Includes("azureSubscription",false))
        {
            if(this.AzureSubscription == null) {

                this.AzureSubscription = new AzureNativeSubscription();
                this.AzureSubscription.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscription"));

            } else {

                this.AzureSubscription.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscription"));

            }
        }
        else if (this.AzureSubscription != null && ec.Excludes("azureSubscription",false))
        {
            this.AzureSubscription = null;
        }
        //      C# -> AzureNativeSubscriptionDetails? AzureSubscriptionDetails
        // GraphQL -> azureSubscriptionDetails: AzureNativeSubscriptionDetails! (type)
        if (ec.Includes("azureSubscriptionDetails",false))
        {
            if(this.AzureSubscriptionDetails == null) {

                this.AzureSubscriptionDetails = new AzureNativeSubscriptionDetails();
                this.AzureSubscriptionDetails.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscriptionDetails"));

            } else {

                this.AzureSubscriptionDetails.ApplyExploratoryFieldSpec(ec.NewChild("azureSubscriptionDetails"));

            }
        }
        else if (this.AzureSubscriptionDetails != null && ec.Excludes("azureSubscriptionDetails",false))
        {
            this.AzureSubscriptionDetails = null;
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? DiskSla
        // GraphQL -> diskSla: AzureNativeResourceGroupSlaAssignment! (type)
        if (ec.Includes("diskSla",false))
        {
            if(this.DiskSla == null) {

                this.DiskSla = new AzureNativeResourceGroupSlaAssignment();
                this.DiskSla.ApplyExploratoryFieldSpec(ec.NewChild("diskSla"));

            } else {

                this.DiskSla.ApplyExploratoryFieldSpec(ec.NewChild("diskSla"));

            }
        }
        else if (this.DiskSla != null && ec.Excludes("diskSla",false))
        {
            this.DiskSla = null;
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
        //      C# -> List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla
        // GraphQL -> protectedObjectTypeToSla: [ProtectedObjectTypeToSla!]! (type)
        if (ec.Includes("protectedObjectTypeToSla",false))
        {
            if(this.ProtectedObjectTypeToSla == null) {

                this.ProtectedObjectTypeToSla = new List<ProtectedObjectTypeToSla>();
                this.ProtectedObjectTypeToSla.ApplyExploratoryFieldSpec(ec.NewChild("protectedObjectTypeToSla"));

            } else {

                this.ProtectedObjectTypeToSla.ApplyExploratoryFieldSpec(ec.NewChild("protectedObjectTypeToSla"));

            }
        }
        else if (this.ProtectedObjectTypeToSla != null && ec.Excludes("protectedObjectTypeToSla",false))
        {
            this.ProtectedObjectTypeToSla = null;
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
        //      C# -> List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs
        // GraphQL -> snappableTypeToBackupSetupSpecs: [WorkloadTypeToBackupSetupSpecs!]! (type)
        if (ec.Includes("snappableTypeToBackupSetupSpecs",false))
        {
            if(this.SnappableTypeToBackupSetupSpecs == null) {

                this.SnappableTypeToBackupSetupSpecs = new List<WorkloadTypeToBackupSetupSpecs>();
                this.SnappableTypeToBackupSetupSpecs.ApplyExploratoryFieldSpec(ec.NewChild("snappableTypeToBackupSetupSpecs"));

            } else {

                this.SnappableTypeToBackupSetupSpecs.ApplyExploratoryFieldSpec(ec.NewChild("snappableTypeToBackupSetupSpecs"));

            }
        }
        else if (this.SnappableTypeToBackupSetupSpecs != null && ec.Excludes("snappableTypeToBackupSetupSpecs",false))
        {
            this.SnappableTypeToBackupSetupSpecs = null;
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
        //      C# -> AzureNativeSubscription? Subscription
        // GraphQL -> subscription: AzureNativeSubscription! (type)
        if (ec.Includes("subscription",false))
        {
            if(this.Subscription == null) {

                this.Subscription = new AzureNativeSubscription();
                this.Subscription.ApplyExploratoryFieldSpec(ec.NewChild("subscription"));

            } else {

                this.Subscription.ApplyExploratoryFieldSpec(ec.NewChild("subscription"));

            }
        }
        else if (this.Subscription != null && ec.Excludes("subscription",false))
        {
            this.Subscription = null;
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (ec.Includes("tags",false))
        {
            if(this.Tags == null) {

                this.Tags = new List<AzureTag>();
                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            } else {

                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            }
        }
        else if (this.Tags != null && ec.Excludes("tags",false))
        {
            this.Tags = null;
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? VmSla
        // GraphQL -> vmSla: AzureNativeResourceGroupSlaAssignment! (type)
        if (ec.Includes("vmSla",false))
        {
            if(this.VmSla == null) {

                this.VmSla = new AzureNativeResourceGroupSlaAssignment();
                this.VmSla.ApplyExploratoryFieldSpec(ec.NewChild("vmSla"));

            } else {

                this.VmSla.ApplyExploratoryFieldSpec(ec.NewChild("vmSla"));

            }
        }
        else if (this.VmSla != null && ec.Excludes("vmSla",false))
        {
            this.VmSla = null;
        }
    }


    #endregion

    } // class AzureNativeResourceGroup
    
    #endregion

    public static class ListAzureNativeResourceGroupExtensions
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
            this List<AzureNativeResourceGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeResourceGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeResourceGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeResourceGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeResourceGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types