// AzureNativeSubscription.cs
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
    #region AzureNativeSubscription
 
    public class AzureNativeSubscription: BaseType, HierarchyObject, PolarisHierarchyObject
    {
        #region members

        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType! (enum)
        [JsonProperty("azureCloudType")]
        public AzureCloudType? AzureCloudType { get; set; }

        //      C# -> AzureSubscriptionStatus? AzureSubscriptionStatus
        // GraphQL -> azureSubscriptionStatus: AzureSubscriptionStatus! (enum)
        [JsonProperty("azureSubscriptionStatus")]
        public AzureSubscriptionStatus? AzureSubscriptionStatus { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

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

        //      C# -> System.String? AccountConnectionId
        // GraphQL -> accountConnectionId: String! (scalar)
        [JsonProperty("accountConnectionId")]
        public System.String? AccountConnectionId { get; set; }

        //      C# -> System.Int32? AzureSqlDatabaseDbCount
        // GraphQL -> azureSqlDatabaseDbCount: Int! (scalar)
        [JsonProperty("azureSqlDatabaseDbCount")]
        public System.Int32? AzureSqlDatabaseDbCount { get; set; }

        //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
        // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
        [JsonProperty("azureSqlManagedInstanceDbCount")]
        public System.Int32? AzureSqlManagedInstanceDbCount { get; set; }

        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.Int32? DisksCount
        // GraphQL -> disksCount: Int! (scalar)
        [JsonProperty("disksCount")]
        public System.Int32? DisksCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        [JsonProperty("lastRefreshedAt")]
        public DateTime? LastRefreshedAt { get; set; }

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

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.Int32? VmsCount
        // GraphQL -> vmsCount: Int! (scalar)
        [JsonProperty("vmsCount")]
        public System.Int32? VmsCount { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
        // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
        [JsonProperty("azureNativeResourceGroups")]
        public AzureNativeResourceGroupConnection? AzureNativeResourceGroups { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
        [JsonProperty("enabledFeatures")]
        public List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
        [JsonProperty("regionSpecs")]
        public List<AzureNativeRegionSpec>? RegionSpecs { get; set; }

        //      C# -> List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs
        // GraphQL -> snappableTypeToBackupSetupSpecs: [WorkloadTypeToBackupSetupSpecs!]! (type)
        [JsonProperty("snappableTypeToBackupSetupSpecs")]
        public List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeSubscription";
    }

    public AzureNativeSubscription Set(
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        AzureCloudType? AzureCloudType = null,
        AzureSubscriptionStatus? AzureSubscriptionStatus = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? AccountConnectionId = null,
        System.Int32? AzureSqlDatabaseDbCount = null,
        System.Int32? AzureSqlManagedInstanceDbCount = null,
        System.String? AzureSubscriptionNativeId = null,
        System.Int32? DisksCount = null,
        System.String? Id = null,
        DateTime? LastRefreshedAt = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? TenantId = null,
        System.Int32? VmsCount = null,
        List<Org>? AllOrgs = null,
        AzureNativeResourceGroupConnection? AzureNativeResourceGroups = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        List<AzureNativeRegionSpec>? RegionSpecs = null,
        List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( AzureCloudType != null ) {
            this.AzureCloudType = AzureCloudType;
        }
        if ( AzureSubscriptionStatus != null ) {
            this.AzureSubscriptionStatus = AzureSubscriptionStatus;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
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
        if ( AccountConnectionId != null ) {
            this.AccountConnectionId = AccountConnectionId;
        }
        if ( AzureSqlDatabaseDbCount != null ) {
            this.AzureSqlDatabaseDbCount = AzureSqlDatabaseDbCount;
        }
        if ( AzureSqlManagedInstanceDbCount != null ) {
            this.AzureSqlManagedInstanceDbCount = AzureSqlManagedInstanceDbCount;
        }
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( DisksCount != null ) {
            this.DisksCount = DisksCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastRefreshedAt != null ) {
            this.LastRefreshedAt = LastRefreshedAt;
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
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( VmsCount != null ) {
            this.VmsCount = VmsCount;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AzureNativeResourceGroups != null ) {
            this.AzureNativeResourceGroups = AzureNativeResourceGroups;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( EnabledFeatures != null ) {
            this.EnabledFeatures = EnabledFeatures;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( RegionSpecs != null ) {
            this.RegionSpecs = RegionSpecs;
        }
        if ( SnappableTypeToBackupSetupSpecs != null ) {
            this.SnappableTypeToBackupSetupSpecs = SnappableTypeToBackupSetupSpecs;
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
        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType! (enum)
        if (this.AzureCloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureCloudType\n" ;
            } else {
                s += ind + "azureCloudType\n" ;
            }
        }
        //      C# -> AzureSubscriptionStatus? AzureSubscriptionStatus
        // GraphQL -> azureSubscriptionStatus: AzureSubscriptionStatus! (enum)
        if (this.AzureSubscriptionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSubscriptionStatus\n" ;
            } else {
                s += ind + "azureSubscriptionStatus\n" ;
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
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(conf.Child("configuredSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "AzureNativeSubscription_INTERFACE_FIELD_configuredSlaDomain: configuredSlaDomain{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(conf.Child("effectiveRetentionSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "AzureNativeSubscription_INTERFACE_FIELD_effectiveRetentionSlaDomain: effectiveRetentionSlaDomain{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(conf.Child("effectiveSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "AzureNativeSubscription_INTERFACE_FIELD_effectiveSlaDomain: effectiveSlaDomain{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? AccountConnectionId
        // GraphQL -> accountConnectionId: String! (scalar)
        if (this.AccountConnectionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountConnectionId\n" ;
            } else {
                s += ind + "accountConnectionId\n" ;
            }
        }
        //      C# -> System.Int32? AzureSqlDatabaseDbCount
        // GraphQL -> azureSqlDatabaseDbCount: Int! (scalar)
        if (this.AzureSqlDatabaseDbCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSqlDatabaseDbCount\n" ;
            } else {
                s += ind + "azureSqlDatabaseDbCount\n" ;
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
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSubscriptionNativeId\n" ;
            } else {
                s += ind + "azureSubscriptionNativeId\n" ;
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
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshedAt\n" ;
            } else {
                s += ind + "lastRefreshedAt\n" ;
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
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
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
                    s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
        // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
        if (this.AzureNativeResourceGroups != null) {
            var fspec = this.AzureNativeResourceGroups.AsFieldSpec(conf.Child("azureNativeResourceGroups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureNativeResourceGroups {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "effectiveSlaSourceObject {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
        if (this.EnabledFeatures != null) {
            var fspec = this.EnabledFeatures.AsFieldSpec(conf.Child("enabledFeatures"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "enabledFeatures {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "logicalPath {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "physicalPath {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
        if (this.RegionSpecs != null) {
            var fspec = this.RegionSpecs.AsFieldSpec(conf.Child("regionSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regionSpecs {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "snappableTypeToBackupSetupSpecs {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType! (enum)
        if (ec.Includes("azureCloudType",true))
        {
            if(this.AzureCloudType == null) {

                this.AzureCloudType = new AzureCloudType();

            } else {


            }
        }
        else if (this.AzureCloudType != null && ec.Excludes("azureCloudType",true))
        {
            this.AzureCloudType = null;
        }
        //      C# -> AzureSubscriptionStatus? AzureSubscriptionStatus
        // GraphQL -> azureSubscriptionStatus: AzureSubscriptionStatus! (enum)
        if (ec.Includes("azureSubscriptionStatus",true))
        {
            if(this.AzureSubscriptionStatus == null) {

                this.AzureSubscriptionStatus = new AzureSubscriptionStatus();

            } else {


            }
        }
        else if (this.AzureSubscriptionStatus != null && ec.Excludes("azureSubscriptionStatus",true))
        {
            this.AzureSubscriptionStatus = null;
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
        //      C# -> System.String? AccountConnectionId
        // GraphQL -> accountConnectionId: String! (scalar)
        if (ec.Includes("accountConnectionId",true))
        {
            if(this.AccountConnectionId == null) {

                this.AccountConnectionId = "FETCH";

            } else {


            }
        }
        else if (this.AccountConnectionId != null && ec.Excludes("accountConnectionId",true))
        {
            this.AccountConnectionId = null;
        }
        //      C# -> System.Int32? AzureSqlDatabaseDbCount
        // GraphQL -> azureSqlDatabaseDbCount: Int! (scalar)
        if (ec.Includes("azureSqlDatabaseDbCount",true))
        {
            if(this.AzureSqlDatabaseDbCount == null) {

                this.AzureSqlDatabaseDbCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AzureSqlDatabaseDbCount != null && ec.Excludes("azureSqlDatabaseDbCount",true))
        {
            this.AzureSqlDatabaseDbCount = null;
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
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (ec.Includes("azureSubscriptionNativeId",true))
        {
            if(this.AzureSubscriptionNativeId == null) {

                this.AzureSubscriptionNativeId = "FETCH";

            } else {


            }
        }
        else if (this.AzureSubscriptionNativeId != null && ec.Excludes("azureSubscriptionNativeId",true))
        {
            this.AzureSubscriptionNativeId = null;
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
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (ec.Includes("lastRefreshedAt",true))
        {
            if(this.LastRefreshedAt == null) {

                this.LastRefreshedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshedAt != null && ec.Excludes("lastRefreshedAt",true))
        {
            this.LastRefreshedAt = null;
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
        //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
        // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
        if (ec.Includes("azureNativeResourceGroups",false))
        {
            if(this.AzureNativeResourceGroups == null) {

                this.AzureNativeResourceGroups = new AzureNativeResourceGroupConnection();
                this.AzureNativeResourceGroups.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeResourceGroups"));

            } else {

                this.AzureNativeResourceGroups.ApplyExploratoryFieldSpec(ec.NewChild("azureNativeResourceGroups"));

            }
        }
        else if (this.AzureNativeResourceGroups != null && ec.Excludes("azureNativeResourceGroups",false))
        {
            this.AzureNativeResourceGroups = null;
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
        //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
        if (ec.Includes("enabledFeatures",false))
        {
            if(this.EnabledFeatures == null) {

                this.EnabledFeatures = new List<AzureNativeSubscriptionEnabledFeature>();
                this.EnabledFeatures.ApplyExploratoryFieldSpec(ec.NewChild("enabledFeatures"));

            } else {

                this.EnabledFeatures.ApplyExploratoryFieldSpec(ec.NewChild("enabledFeatures"));

            }
        }
        else if (this.EnabledFeatures != null && ec.Excludes("enabledFeatures",false))
        {
            this.EnabledFeatures = null;
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
        //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
        if (ec.Includes("regionSpecs",false))
        {
            if(this.RegionSpecs == null) {

                this.RegionSpecs = new List<AzureNativeRegionSpec>();
                this.RegionSpecs.ApplyExploratoryFieldSpec(ec.NewChild("regionSpecs"));

            } else {

                this.RegionSpecs.ApplyExploratoryFieldSpec(ec.NewChild("regionSpecs"));

            }
        }
        else if (this.RegionSpecs != null && ec.Excludes("regionSpecs",false))
        {
            this.RegionSpecs = null;
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
    }


    #endregion

    } // class AzureNativeSubscription
    
    #endregion

    public static class ListAzureNativeSubscriptionExtensions
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
            this List<AzureNativeSubscription> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureNativeSubscription> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeSubscription> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeSubscription());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeSubscription> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types