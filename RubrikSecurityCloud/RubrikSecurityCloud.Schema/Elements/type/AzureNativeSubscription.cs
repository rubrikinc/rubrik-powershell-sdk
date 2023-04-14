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

namespace Rubrik.SecurityCloud.Types
{
    #region AzureNativeSubscription
 
    public class AzureNativeSubscription: IFragment, PolarisHierarchyObject, HierarchyObject
    {
        #region members
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

        #endregion

    #region methods

    public AzureNativeSubscription Set(
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
        SnapshotDistribution? SnapshotDistribution = null,
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        AzureCloudType? AzureCloudType = null,
        AzureSubscriptionStatus? AzureSubscriptionStatus = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AccountConnectionId
            // GraphQL -> accountConnectionId: String! (scalar)
            if (this.AccountConnectionId != null)
            {
                 s += ind + "accountConnectionId\n";

            }
            //      C# -> System.Int32? AzureSqlDatabaseDbCount
            // GraphQL -> azureSqlDatabaseDbCount: Int! (scalar)
            if (this.AzureSqlDatabaseDbCount != null)
            {
                 s += ind + "azureSqlDatabaseDbCount\n";

            }
            //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
            // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
            if (this.AzureSqlManagedInstanceDbCount != null)
            {
                 s += ind + "azureSqlManagedInstanceDbCount\n";

            }
            //      C# -> System.String? AzureSubscriptionNativeId
            // GraphQL -> azureSubscriptionNativeId: String! (scalar)
            if (this.AzureSubscriptionNativeId != null)
            {
                 s += ind + "azureSubscriptionNativeId\n";

            }
            //      C# -> System.Int32? DisksCount
            // GraphQL -> disksCount: Int! (scalar)
            if (this.DisksCount != null)
            {
                 s += ind + "disksCount\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> DateTime? LastRefreshedAt
            // GraphQL -> lastRefreshedAt: DateTime (scalar)
            if (this.LastRefreshedAt != null)
            {
                 s += ind + "lastRefreshedAt\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants != null)
            {
                 s += ind + "numWorkloadDescendants\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId != null)
            {
                 s += ind + "tenantId\n";

            }
            //      C# -> System.Int32? VmsCount
            // GraphQL -> vmsCount: Int! (scalar)
            if (this.VmsCount != null)
            {
                 s += ind + "vmsCount\n";

            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs != null)
            {
                 s += ind + "allOrgs\n";

                 s += ind + "{\n" + 
                 this.AllOrgs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
            // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
            if (this.AzureNativeResourceGroups != null)
            {
                 s += ind + "azureNativeResourceGroups\n";

                 s += ind + "{\n" + 
                 this.AzureNativeResourceGroups.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject != null)
            {
                 s += ind + "effectiveSlaSourceObject\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaSourceObject.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
            // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
            if (this.EnabledFeatures != null)
            {
                 s += ind + "enabledFeatures\n";

                 s += ind + "{\n" + 
                 this.EnabledFeatures.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath != null)
            {
                 s += ind + "logicalPath\n";

                 s += ind + "{\n" + 
                 this.LogicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath != null)
            {
                 s += ind + "physicalPath\n";

                 s += ind + "{\n" + 
                 this.PhysicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
            // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
            if (this.RegionSpecs != null)
            {
                 s += ind + "regionSpecs\n";

                 s += ind + "{\n" + 
                 this.RegionSpecs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs
            // GraphQL -> snappableTypeToBackupSetupSpecs: [WorkloadTypeToBackupSetupSpecs!]! (type)
            if (this.SnappableTypeToBackupSetupSpecs != null)
            {
                 s += ind + "snappableTypeToBackupSetupSpecs\n";

                 s += ind + "{\n" + 
                 this.SnappableTypeToBackupSetupSpecs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution != null)
            {
                 s += ind + "snapshotDistribution\n";

                 s += ind + "{\n" + 
                 this.SnapshotDistribution.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> AzureCloudType? AzureCloudType
            // GraphQL -> azureCloudType: AzureCloudType! (enum)
            if (this.AzureCloudType != null)
            {
                 s += ind + "azureCloudType\n";

            }
            //      C# -> AzureSubscriptionStatus? AzureSubscriptionStatus
            // GraphQL -> azureSubscriptionStatus: AzureSubscriptionStatus! (enum)
            if (this.AzureSubscriptionStatus != null)
            {
                 s += ind + "azureSubscriptionStatus\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
                        //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain != null)
            {
                s += ind + "configuredSlaDomain\n";
                s += ind + "{\n";

                string typename = this.ConfiguredSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.ConfiguredSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain != null)
            {
                s += ind + "effectiveRetentionSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveRetentionSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveRetentionSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain != null)
            {
                s += ind + "effectiveSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccountConnectionId
            // GraphQL -> accountConnectionId: String! (scalar)
            if (this.AccountConnectionId == null && Exploration.Includes(parent + ".accountConnectionId$"))
            {
                this.AccountConnectionId = new System.String("FETCH");
            }
            //      C# -> System.Int32? AzureSqlDatabaseDbCount
            // GraphQL -> azureSqlDatabaseDbCount: Int! (scalar)
            if (this.AzureSqlDatabaseDbCount == null && Exploration.Includes(parent + ".azureSqlDatabaseDbCount$"))
            {
                this.AzureSqlDatabaseDbCount = new System.Int32();
            }
            //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
            // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
            if (this.AzureSqlManagedInstanceDbCount == null && Exploration.Includes(parent + ".azureSqlManagedInstanceDbCount$"))
            {
                this.AzureSqlManagedInstanceDbCount = new System.Int32();
            }
            //      C# -> System.String? AzureSubscriptionNativeId
            // GraphQL -> azureSubscriptionNativeId: String! (scalar)
            if (this.AzureSubscriptionNativeId == null && Exploration.Includes(parent + ".azureSubscriptionNativeId$"))
            {
                this.AzureSubscriptionNativeId = new System.String("FETCH");
            }
            //      C# -> System.Int32? DisksCount
            // GraphQL -> disksCount: Int! (scalar)
            if (this.DisksCount == null && Exploration.Includes(parent + ".disksCount$"))
            {
                this.DisksCount = new System.Int32();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> DateTime? LastRefreshedAt
            // GraphQL -> lastRefreshedAt: DateTime (scalar)
            if (this.LastRefreshedAt == null && Exploration.Includes(parent + ".lastRefreshedAt$"))
            {
                this.LastRefreshedAt = new DateTime();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants$"))
            {
                this.NumWorkloadDescendants = new System.Int32();
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId == null && Exploration.Includes(parent + ".tenantId$"))
            {
                this.TenantId = new System.String("FETCH");
            }
            //      C# -> System.Int32? VmsCount
            // GraphQL -> vmsCount: Int! (scalar)
            if (this.VmsCount == null && Exploration.Includes(parent + ".vmsCount$"))
            {
                this.VmsCount = new System.Int32();
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> AzureNativeResourceGroupConnection? AzureNativeResourceGroups
            // GraphQL -> azureNativeResourceGroups: AzureNativeResourceGroupConnection! (type)
            if (this.AzureNativeResourceGroups == null && Exploration.Includes(parent + ".azureNativeResourceGroups"))
            {
                this.AzureNativeResourceGroups = new AzureNativeResourceGroupConnection();
                this.AzureNativeResourceGroups.ApplyExploratoryFragment(parent + ".azureNativeResourceGroups");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
            // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
            if (this.EnabledFeatures == null && Exploration.Includes(parent + ".enabledFeatures"))
            {
                this.EnabledFeatures = new List<AzureNativeSubscriptionEnabledFeature>();
                this.EnabledFeatures.ApplyExploratoryFragment(parent + ".enabledFeatures");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
            // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
            if (this.RegionSpecs == null && Exploration.Includes(parent + ".regionSpecs"))
            {
                this.RegionSpecs = new List<AzureNativeRegionSpec>();
                this.RegionSpecs.ApplyExploratoryFragment(parent + ".regionSpecs");
            }
            //      C# -> List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs
            // GraphQL -> snappableTypeToBackupSetupSpecs: [WorkloadTypeToBackupSetupSpecs!]! (type)
            if (this.SnappableTypeToBackupSetupSpecs == null && Exploration.Includes(parent + ".snappableTypeToBackupSetupSpecs"))
            {
                this.SnappableTypeToBackupSetupSpecs = new List<WorkloadTypeToBackupSetupSpecs>();
                this.SnappableTypeToBackupSetupSpecs.ApplyExploratoryFragment(parent + ".snappableTypeToBackupSetupSpecs");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<PolarisObjectAuthorizedOperationsEnum>();
            }
            //      C# -> AzureCloudType? AzureCloudType
            // GraphQL -> azureCloudType: AzureCloudType! (enum)
            if (this.AzureCloudType == null && Exploration.Includes(parent + ".azureCloudType$"))
            {
                this.AzureCloudType = new AzureCloudType();
            }
            //      C# -> AzureSubscriptionStatus? AzureSubscriptionStatus
            // GraphQL -> azureSubscriptionStatus: AzureSubscriptionStatus! (enum)
            if (this.AzureSubscriptionStatus == null && Exploration.Includes(parent + ".azureSubscriptionStatus$"))
            {
                this.AzureSubscriptionStatus = new AzureSubscriptionStatus();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignmentTypeEnum();
            }
            //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
            {
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.ConfiguredSlaDomain.ApplyExploratoryFragment(parent + ".configuredSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
            {
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveRetentionSlaDomain.ApplyExploratoryFragment(parent + ".effectiveRetentionSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
            {
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveSlaDomain.ApplyExploratoryFragment(parent + ".effectiveSlaDomain");
            }
        }


    #endregion

    } // class AzureNativeSubscription
    #endregion

    public static class ListAzureNativeSubscriptionExtensions
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
            this List<AzureNativeSubscription> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeSubscription> list, 
            String parent = "")
        {
            var item = new AzureNativeSubscription();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types