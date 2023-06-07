// AzureSqlManagedInstanceServer.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureSqlManagedInstanceServer
 
    public class AzureSqlManagedInstanceServer: BaseType, HierarchyObject, PolarisHierarchyObject
    {
        #region members

        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy
        // GraphQL -> backupStorageRedundancy: AzureSqlBackupStorageRedundancyType! (enum)
        [JsonProperty("backupStorageRedundancy")]
        public AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy { get; set; }

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

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? InstancePoolName
        // GraphQL -> instancePoolName: String! (scalar)
        [JsonProperty("instancePoolName")]
        public System.String? InstancePoolName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        [JsonProperty("serverName")]
        public System.String? ServerName { get; set; }

        //      C# -> System.String? ServiceTier
        // GraphQL -> serviceTier: String! (scalar)
        [JsonProperty("serviceTier")]
        public System.String? ServiceTier { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Int64? StorageSizeGib
        // GraphQL -> storageSizeGib: Long! (scalar)
        [JsonProperty("storageSizeGib")]
        public System.Int64? StorageSizeGib { get; set; }

        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        [JsonProperty("subnetName")]
        public System.String? SubnetName { get; set; }

        //      C# -> System.Int32? VcoresCount
        // GraphQL -> vCoresCount: Int! (scalar)
        [JsonProperty("vCoresCount")]
        public System.Int32? VcoresCount { get; set; }

        //      C# -> System.String? VnetName
        // GraphQL -> vnetName: String! (scalar)
        [JsonProperty("vnetName")]
        public System.String? VnetName { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> AzureNativeResourceGroup? AzureNativeResourceGroup
        // GraphQL -> azureNativeResourceGroup: AzureNativeResourceGroup! (type)
        [JsonProperty("azureNativeResourceGroup")]
        public AzureNativeResourceGroup? AzureNativeResourceGroup { get; set; }

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

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        [JsonProperty("tags")]
        public List<AzureTag>? Tags { get; set; }


        #endregion

    #region methods

    public AzureSqlManagedInstanceServer Set(
        List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations = null,
        AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        AzureNativeRegion? Region = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? Id = null,
        System.String? InstancePoolName = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.String? ServerName = null,
        System.String? ServiceTier = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int64? StorageSizeGib = null,
        System.String? SubnetName = null,
        System.Int32? VcoresCount = null,
        System.String? VnetName = null,
        List<Org>? AllOrgs = null,
        AzureNativeResourceGroup? AzureNativeResourceGroup = null,
        PathNode? BackupSetupSourceObject = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        SnapshotDistribution? SnapshotDistribution = null,
        List<AzureTag>? Tags = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( BackupStorageRedundancy != null ) {
            this.BackupStorageRedundancy = BackupStorageRedundancy;
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
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( InstancePoolName != null ) {
            this.InstancePoolName = InstancePoolName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( ServerName != null ) {
            this.ServerName = ServerName;
        }
        if ( ServiceTier != null ) {
            this.ServiceTier = ServiceTier;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( StorageSizeGib != null ) {
            this.StorageSizeGib = StorageSizeGib;
        }
        if ( SubnetName != null ) {
            this.SubnetName = SubnetName;
        }
        if ( VcoresCount != null ) {
            this.VcoresCount = VcoresCount;
        }
        if ( VnetName != null ) {
            this.VnetName = VnetName;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AzureNativeResourceGroup != null ) {
            this.AzureNativeResourceGroup = AzureNativeResourceGroup;
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
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy
        // GraphQL -> backupStorageRedundancy: AzureSqlBackupStorageRedundancyType! (enum)
        if (this.BackupStorageRedundancy != null) {
            s += ind + "backupStorageRedundancy\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
            s += ind + "configuredSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
            s += ind + "effectiveRetentionSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
            s += ind + "effectiveSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? InstancePoolName
        // GraphQL -> instancePoolName: String! (scalar)
        if (this.InstancePoolName != null) {
            s += ind + "instancePoolName\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        if (this.ServerName != null) {
            s += ind + "serverName\n" ;
        }
        //      C# -> System.String? ServiceTier
        // GraphQL -> serviceTier: String! (scalar)
        if (this.ServiceTier != null) {
            s += ind + "serviceTier\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> System.Int64? StorageSizeGib
        // GraphQL -> storageSizeGib: Long! (scalar)
        if (this.StorageSizeGib != null) {
            s += ind + "storageSizeGib\n" ;
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (this.SubnetName != null) {
            s += ind + "subnetName\n" ;
        }
        //      C# -> System.Int32? VcoresCount
        // GraphQL -> vCoresCount: Int! (scalar)
        if (this.VcoresCount != null) {
            s += ind + "vCoresCount\n" ;
        }
        //      C# -> System.String? VnetName
        // GraphQL -> vnetName: String! (scalar)
        if (this.VnetName != null) {
            s += ind + "vnetName\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            s += ind + "allOrgs {\n" + this.AllOrgs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AzureNativeResourceGroup? AzureNativeResourceGroup
        // GraphQL -> azureNativeResourceGroup: AzureNativeResourceGroup! (type)
        if (this.AzureNativeResourceGroup != null) {
            s += ind + "azureNativeResourceGroup {\n" + this.AzureNativeResourceGroup.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PathNode? BackupSetupSourceObject
        // GraphQL -> backupSetupSourceObject: PathNode (type)
        if (this.BackupSetupSourceObject != null) {
            s += ind + "backupSetupSourceObject {\n" + this.BackupSetupSourceObject.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            s += ind + "effectiveSlaSourceObject {\n" + this.EffectiveSlaSourceObject.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            s += ind + "logicalPath {\n" + this.LogicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            s += ind + "physicalPath {\n" + this.PhysicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            s += ind + "snapshotDistribution {\n" + this.SnapshotDistribution.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags != null) {
            s += ind + "tags {\n" + this.Tags.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations", true))
        {
            this.AuthorizedOperations = new List<PolarisSnappableAuthorizedOperationsEnum>();
        }
        //      C# -> AzureSqlBackupStorageRedundancyType? BackupStorageRedundancy
        // GraphQL -> backupStorageRedundancy: AzureSqlBackupStorageRedundancyType! (enum)
        if (this.BackupStorageRedundancy == null && Exploration.Includes(parent + ".backupStorageRedundancy", true))
        {
            this.BackupStorageRedundancy = new AzureSqlBackupStorageRedundancyType();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> AzureNativeRegion? Region
        // GraphQL -> region: AzureNativeRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AzureNativeRegion();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".configuredSlaDomain");
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveRetentionSlaDomain");
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveSlaDomain");
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? InstancePoolName
        // GraphQL -> instancePoolName: String! (scalar)
        if (this.InstancePoolName == null && Exploration.Includes(parent + ".instancePoolName", true))
        {
            this.InstancePoolName = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants", true))
        {
            this.NumWorkloadDescendants = Int32.MinValue;
        }
        //      C# -> System.String? ServerName
        // GraphQL -> serverName: String! (scalar)
        if (this.ServerName == null && Exploration.Includes(parent + ".serverName", true))
        {
            this.ServerName = "FETCH";
        }
        //      C# -> System.String? ServiceTier
        // GraphQL -> serviceTier: String! (scalar)
        if (this.ServiceTier == null && Exploration.Includes(parent + ".serviceTier", true))
        {
            this.ServiceTier = "FETCH";
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.Int64? StorageSizeGib
        // GraphQL -> storageSizeGib: Long! (scalar)
        if (this.StorageSizeGib == null && Exploration.Includes(parent + ".storageSizeGib", true))
        {
            this.StorageSizeGib = new System.Int64();
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (this.SubnetName == null && Exploration.Includes(parent + ".subnetName", true))
        {
            this.SubnetName = "FETCH";
        }
        //      C# -> System.Int32? VcoresCount
        // GraphQL -> vCoresCount: Int! (scalar)
        if (this.VcoresCount == null && Exploration.Includes(parent + ".vCoresCount", true))
        {
            this.VcoresCount = Int32.MinValue;
        }
        //      C# -> System.String? VnetName
        // GraphQL -> vnetName: String! (scalar)
        if (this.VnetName == null && Exploration.Includes(parent + ".vnetName", true))
        {
            this.VnetName = "FETCH";
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> AzureNativeResourceGroup? AzureNativeResourceGroup
        // GraphQL -> azureNativeResourceGroup: AzureNativeResourceGroup! (type)
        if (this.AzureNativeResourceGroup == null && Exploration.Includes(parent + ".azureNativeResourceGroup"))
        {
            this.AzureNativeResourceGroup = new AzureNativeResourceGroup();
            this.AzureNativeResourceGroup.ApplyExploratoryFieldSpec(parent + ".azureNativeResourceGroup");
        }
        //      C# -> PathNode? BackupSetupSourceObject
        // GraphQL -> backupSetupSourceObject: PathNode (type)
        if (this.BackupSetupSourceObject == null && Exploration.Includes(parent + ".backupSetupSourceObject"))
        {
            this.BackupSetupSourceObject = new PathNode();
            this.BackupSetupSourceObject.ApplyExploratoryFieldSpec(parent + ".backupSetupSourceObject");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<AzureTag>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
        }
    }


    #endregion

    } // class AzureSqlManagedInstanceServer
    
    #endregion

    public static class ListAzureSqlManagedInstanceServerExtensions
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
            this List<AzureSqlManagedInstanceServer> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSqlManagedInstanceServer> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSqlManagedInstanceServer());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types