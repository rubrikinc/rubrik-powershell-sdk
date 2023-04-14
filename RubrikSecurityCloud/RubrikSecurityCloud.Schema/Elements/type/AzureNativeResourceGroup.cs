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

namespace Rubrik.SecurityCloud.Types
{
    #region AzureNativeResourceGroup
 
    public class AzureNativeResourceGroup: IFragment, PolarisHierarchyObject, HierarchyObject
    {
        #region members
        //      C# -> System.Int32? AzureSqlDatabaseCount
        // GraphQL -> azureSqlDatabaseCount: Int! (scalar)
        [JsonProperty("azureSqlDatabaseCount")]
        public System.Int32? AzureSqlDatabaseCount { get; set; }

        //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
        // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
        [JsonProperty("azureSqlManagedInstanceDbCount")]
        public System.Int32? AzureSqlManagedInstanceDbCount { get; set; }

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

        //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
        // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
        [JsonProperty("azureNativeVirtualMachines")]
        public AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines { get; set; }

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

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla
        // GraphQL -> protectedObjectTypeToSla: [ProtectedObjectTypeToSla!]! (type)
        [JsonProperty("protectedObjectTypeToSla")]
        public List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla { get; set; }

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

    public AzureNativeResourceGroup Set(
        System.Int32? AzureSqlDatabaseCount = null,
        System.Int32? AzureSqlManagedInstanceDbCount = null,
        System.String? AzureSubscriptionRubrikId = null,
        System.Int32? DisksCount = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int32? VmsCount = null,
        List<Org>? AllOrgs = null,
        AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines = null,
        AzureNativeResourceGroupSlaAssignment? DiskSla = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla = null,
        List<WorkloadTypeToBackupSetupSpecs>? SnappableTypeToBackupSetupSpecs = null,
        SnapshotDistribution? SnapshotDistribution = null,
        AzureNativeSubscription? Subscription = null,
        List<AzureTag>? Tags = null,
        AzureNativeResourceGroupSlaAssignment? VmSla = null,
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        AzureNativeRegion? Region = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
        if ( AzureSqlDatabaseCount != null ) {
            this.AzureSqlDatabaseCount = AzureSqlDatabaseCount;
        }
        if ( AzureSqlManagedInstanceDbCount != null ) {
            this.AzureSqlManagedInstanceDbCount = AzureSqlManagedInstanceDbCount;
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
        if ( AzureNativeVirtualMachines != null ) {
            this.AzureNativeVirtualMachines = AzureNativeVirtualMachines;
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
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( ProtectedObjectTypeToSla != null ) {
            this.ProtectedObjectTypeToSla = ProtectedObjectTypeToSla;
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
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Region != null ) {
            this.Region = Region;
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
            //      C# -> System.Int32? AzureSqlDatabaseCount
            // GraphQL -> azureSqlDatabaseCount: Int! (scalar)
            if (this.AzureSqlDatabaseCount != null)
            {
                 s += ind + "azureSqlDatabaseCount\n";

            }
            //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
            // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
            if (this.AzureSqlManagedInstanceDbCount != null)
            {
                 s += ind + "azureSqlManagedInstanceDbCount\n";

            }
            //      C# -> System.String? AzureSubscriptionRubrikId
            // GraphQL -> azureSubscriptionRubrikId: UUID! (scalar)
            if (this.AzureSubscriptionRubrikId != null)
            {
                 s += ind + "azureSubscriptionRubrikId\n";

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
            //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
            // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
            if (this.AzureNativeVirtualMachines != null)
            {
                 s += ind + "azureNativeVirtualMachines\n";

                 s += ind + "{\n" + 
                 this.AzureNativeVirtualMachines.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureNativeResourceGroupSlaAssignment? DiskSla
            // GraphQL -> diskSla: AzureNativeResourceGroupSlaAssignment! (type)
            if (this.DiskSla != null)
            {
                 s += ind + "diskSla\n";

                 s += ind + "{\n" + 
                 this.DiskSla.AsFragment(indent+1) + 
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
            //      C# -> List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla
            // GraphQL -> protectedObjectTypeToSla: [ProtectedObjectTypeToSla!]! (type)
            if (this.ProtectedObjectTypeToSla != null)
            {
                 s += ind + "protectedObjectTypeToSla\n";

                 s += ind + "{\n" + 
                 this.ProtectedObjectTypeToSla.AsFragment(indent+1) + 
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
            //      C# -> AzureNativeSubscription? Subscription
            // GraphQL -> subscription: AzureNativeSubscription! (type)
            if (this.Subscription != null)
            {
                 s += ind + "subscription\n";

                 s += ind + "{\n" + 
                 this.Subscription.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AzureTag>? Tags
            // GraphQL -> tags: [AzureTag!]! (type)
            if (this.Tags != null)
            {
                 s += ind + "tags\n";

                 s += ind + "{\n" + 
                 this.Tags.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureNativeResourceGroupSlaAssignment? VmSla
            // GraphQL -> vmSla: AzureNativeResourceGroupSlaAssignment! (type)
            if (this.VmSla != null)
            {
                 s += ind + "vmSla\n";

                 s += ind + "{\n" + 
                 this.VmSla.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> AzureNativeRegion? Region
            // GraphQL -> region: AzureNativeRegion! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

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
            //      C# -> System.Int32? AzureSqlDatabaseCount
            // GraphQL -> azureSqlDatabaseCount: Int! (scalar)
            if (this.AzureSqlDatabaseCount == null && Exploration.Includes(parent + ".azureSqlDatabaseCount$"))
            {
                this.AzureSqlDatabaseCount = new System.Int32();
            }
            //      C# -> System.Int32? AzureSqlManagedInstanceDbCount
            // GraphQL -> azureSqlManagedInstanceDbCount: Int! (scalar)
            if (this.AzureSqlManagedInstanceDbCount == null && Exploration.Includes(parent + ".azureSqlManagedInstanceDbCount$"))
            {
                this.AzureSqlManagedInstanceDbCount = new System.Int32();
            }
            //      C# -> System.String? AzureSubscriptionRubrikId
            // GraphQL -> azureSubscriptionRubrikId: UUID! (scalar)
            if (this.AzureSubscriptionRubrikId == null && Exploration.Includes(parent + ".azureSubscriptionRubrikId$"))
            {
                this.AzureSubscriptionRubrikId = new System.String("FETCH");
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
            //      C# -> AzureNativeVirtualMachineConnection? AzureNativeVirtualMachines
            // GraphQL -> azureNativeVirtualMachines: AzureNativeVirtualMachineConnection! (type)
            if (this.AzureNativeVirtualMachines == null && Exploration.Includes(parent + ".azureNativeVirtualMachines"))
            {
                this.AzureNativeVirtualMachines = new AzureNativeVirtualMachineConnection();
                this.AzureNativeVirtualMachines.ApplyExploratoryFragment(parent + ".azureNativeVirtualMachines");
            }
            //      C# -> AzureNativeResourceGroupSlaAssignment? DiskSla
            // GraphQL -> diskSla: AzureNativeResourceGroupSlaAssignment! (type)
            if (this.DiskSla == null && Exploration.Includes(parent + ".diskSla"))
            {
                this.DiskSla = new AzureNativeResourceGroupSlaAssignment();
                this.DiskSla.ApplyExploratoryFragment(parent + ".diskSla");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
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
            //      C# -> List<ProtectedObjectTypeToSla>? ProtectedObjectTypeToSla
            // GraphQL -> protectedObjectTypeToSla: [ProtectedObjectTypeToSla!]! (type)
            if (this.ProtectedObjectTypeToSla == null && Exploration.Includes(parent + ".protectedObjectTypeToSla"))
            {
                this.ProtectedObjectTypeToSla = new List<ProtectedObjectTypeToSla>();
                this.ProtectedObjectTypeToSla.ApplyExploratoryFragment(parent + ".protectedObjectTypeToSla");
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
            //      C# -> AzureNativeSubscription? Subscription
            // GraphQL -> subscription: AzureNativeSubscription! (type)
            if (this.Subscription == null && Exploration.Includes(parent + ".subscription"))
            {
                this.Subscription = new AzureNativeSubscription();
                this.Subscription.ApplyExploratoryFragment(parent + ".subscription");
            }
            //      C# -> List<AzureTag>? Tags
            // GraphQL -> tags: [AzureTag!]! (type)
            if (this.Tags == null && Exploration.Includes(parent + ".tags"))
            {
                this.Tags = new List<AzureTag>();
                this.Tags.ApplyExploratoryFragment(parent + ".tags");
            }
            //      C# -> AzureNativeResourceGroupSlaAssignment? VmSla
            // GraphQL -> vmSla: AzureNativeResourceGroupSlaAssignment! (type)
            if (this.VmSla == null && Exploration.Includes(parent + ".vmSla"))
            {
                this.VmSla = new AzureNativeResourceGroupSlaAssignment();
                this.VmSla.ApplyExploratoryFragment(parent + ".vmSla");
            }
            //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<PolarisObjectAuthorizedOperationsEnum>();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> AzureNativeRegion? Region
            // GraphQL -> region: AzureNativeRegion! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AzureNativeRegion();
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

    } // class AzureNativeResourceGroup
    #endregion

    public static class ListAzureNativeResourceGroupExtensions
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
            this List<AzureNativeResourceGroup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeResourceGroup> list, 
            String parent = "")
        {
            var item = new AzureNativeResourceGroup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types