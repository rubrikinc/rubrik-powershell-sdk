// AzureNativeVirtualMachine.cs
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
    #region AzureNativeVirtualMachine
 
    public class AzureNativeVirtualMachine: BaseType, AzureNativeHierarchyObjectType, HierarchyObject, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members

        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> AzureNativeVmOsType? OsType
        // GraphQL -> osType: AzureNativeVmOsType! (enum)
        [JsonProperty("osType")]
        public AzureNativeVmOsType? OsType { get; set; }

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

        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String! (scalar)
        [JsonProperty("availabilitySetNativeId")]
        public System.String? AvailabilitySetNativeId { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        [JsonProperty("cloudNativeId")]
        public System.String? CloudNativeId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsAcceleratedNetworkingEnabled
        // GraphQL -> isAcceleratedNetworkingEnabled: Boolean! (scalar)
        [JsonProperty("isAcceleratedNetworkingEnabled")]
        public System.Boolean? IsAcceleratedNetworkingEnabled { get; set; }

        //      C# -> System.Boolean? IsAdeEnabled
        // GraphQL -> isAdeEnabled: Boolean! (scalar)
        [JsonProperty("isAdeEnabled")]
        public System.Boolean? IsAdeEnabled { get; set; }

        //      C# -> System.Boolean? IsAppConsistencyEnabled
        // GraphQL -> isAppConsistencyEnabled: Boolean! (scalar)
        [JsonProperty("isAppConsistencyEnabled")]
        public System.Boolean? IsAppConsistencyEnabled { get; set; }

        //      C# -> System.Boolean? IsExocomputeConfigured
        // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
        [JsonProperty("isExocomputeConfigured")]
        public System.Boolean? IsExocomputeConfigured { get; set; }

        //      C# -> System.Boolean? IsFileIndexingEnabled
        // GraphQL -> isFileIndexingEnabled: Boolean! (scalar)
        [JsonProperty("isFileIndexingEnabled")]
        public System.Boolean? IsFileIndexingEnabled { get; set; }

        //      C# -> System.Boolean? IsPreOrPostScriptEnabled
        // GraphQL -> isPreOrPostScriptEnabled: Boolean! (scalar)
        [JsonProperty("isPreOrPostScriptEnabled")]
        public System.Boolean? IsPreOrPostScriptEnabled { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        [JsonProperty("nativeName")]
        public System.String? NativeName { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? PrivateIp
        // GraphQL -> privateIp: String! (scalar)
        [JsonProperty("privateIp")]
        public System.String? PrivateIp { get; set; }

        //      C# -> System.String? SizeType
        // GraphQL -> sizeType: String! (scalar)
        [JsonProperty("sizeType")]
        public System.String? SizeType { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        [JsonProperty("subnetName")]
        public System.String? SubnetName { get; set; }

        //      C# -> System.String? VirtuaMachineNativeId
        // GraphQL -> virtuaMachineNativeId: String! (scalar)
        [JsonProperty("virtuaMachineNativeId")]
        public System.String? VirtuaMachineNativeId { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> System.String? VnetName
        // GraphQL -> vnetName: String! (scalar)
        [JsonProperty("vnetName")]
        public System.String? VnetName { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AzureNativeManagedDisk>? AttachedManagedDisks
        // GraphQL -> attachedManagedDisks: [AzureNativeManagedDisk!]! (type)
        [JsonProperty("attachedManagedDisks")]
        public List<AzureNativeManagedDisk>? AttachedManagedDisks { get; set; }

        //      C# -> List<AttachmentSpecsForVirtualMachine>? AttachmentSpecs
        // GraphQL -> attachmentSpecs: [AttachmentSpecsForVirtualMachine!]! (type)
        [JsonProperty("attachmentSpecs")]
        public List<AttachmentSpecsForVirtualMachine>? AttachmentSpecs { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> PhysicalHost? HostInfo
        // GraphQL -> hostInfo: PhysicalHost (type)
        [JsonProperty("hostInfo")]
        public PhysicalHost? HostInfo { get; set; }

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

        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public PolarisSnapshot? OldestSnapshot { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> AzureNativeResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureNativeResourceGroup! (type)
        [JsonProperty("resourceGroup")]
        public AzureNativeResourceGroup? ResourceGroup { get; set; }

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

        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        [JsonProperty("tags")]
        public List<AzureTag>? Tags { get; set; }

        //      C# -> VmAppConsistentSpecsInternal? VmAppConsistentSpecs
        // GraphQL -> vmAppConsistentSpecs: VmAppConsistentSpecsInternal (type)
        [JsonProperty("vmAppConsistentSpecs")]
        public VmAppConsistentSpecsInternal? VmAppConsistentSpecs { get; set; }

        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        [JsonProperty("workloadSnapshotConnection")]
        public GenericSnapshotConnection? WorkloadSnapshotConnection { get; set; }


        #endregion

    #region methods

    public AzureNativeVirtualMachine Set(
        List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        AzureNativeVmOsType? OsType = null,
        AzureNativeRegion? Region = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? AvailabilitySetNativeId = null,
        System.String? AvailabilityZone = null,
        System.String? CloudNativeId = null,
        System.String? Id = null,
        System.Boolean? IsAcceleratedNetworkingEnabled = null,
        System.Boolean? IsAdeEnabled = null,
        System.Boolean? IsAppConsistencyEnabled = null,
        System.Boolean? IsExocomputeConfigured = null,
        System.Boolean? IsFileIndexingEnabled = null,
        System.Boolean? IsPreOrPostScriptEnabled = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.String? NativeName = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? PrivateIp = null,
        System.String? SizeType = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? SubnetName = null,
        System.String? VirtuaMachineNativeId = null,
        System.String? VmName = null,
        System.String? VnetName = null,
        List<Org>? AllOrgs = null,
        List<AzureNativeManagedDisk>? AttachedManagedDisks = null,
        List<AttachmentSpecsForVirtualMachine>? AttachmentSpecs = null,
        PathNode? EffectiveSlaSourceObject = null,
        PhysicalHost? HostInfo = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        PolarisSnapshot? OldestSnapshot = null,
        List<PathNode>? PhysicalPath = null,
        AzureNativeResourceGroup? ResourceGroup = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        List<AzureTag>? Tags = null,
        VmAppConsistentSpecsInternal? VmAppConsistentSpecs = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
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
        if ( AvailabilitySetNativeId != null ) {
            this.AvailabilitySetNativeId = AvailabilitySetNativeId;
        }
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( CloudNativeId != null ) {
            this.CloudNativeId = CloudNativeId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsAcceleratedNetworkingEnabled != null ) {
            this.IsAcceleratedNetworkingEnabled = IsAcceleratedNetworkingEnabled;
        }
        if ( IsAdeEnabled != null ) {
            this.IsAdeEnabled = IsAdeEnabled;
        }
        if ( IsAppConsistencyEnabled != null ) {
            this.IsAppConsistencyEnabled = IsAppConsistencyEnabled;
        }
        if ( IsExocomputeConfigured != null ) {
            this.IsExocomputeConfigured = IsExocomputeConfigured;
        }
        if ( IsFileIndexingEnabled != null ) {
            this.IsFileIndexingEnabled = IsFileIndexingEnabled;
        }
        if ( IsPreOrPostScriptEnabled != null ) {
            this.IsPreOrPostScriptEnabled = IsPreOrPostScriptEnabled;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeName != null ) {
            this.NativeName = NativeName;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( PrivateIp != null ) {
            this.PrivateIp = PrivateIp;
        }
        if ( SizeType != null ) {
            this.SizeType = SizeType;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( SubnetName != null ) {
            this.SubnetName = SubnetName;
        }
        if ( VirtuaMachineNativeId != null ) {
            this.VirtuaMachineNativeId = VirtuaMachineNativeId;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
        }
        if ( VnetName != null ) {
            this.VnetName = VnetName;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AttachedManagedDisks != null ) {
            this.AttachedManagedDisks = AttachedManagedDisks;
        }
        if ( AttachmentSpecs != null ) {
            this.AttachmentSpecs = AttachmentSpecs;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( HostInfo != null ) {
            this.HostInfo = HostInfo;
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
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
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
        if ( Tags != null ) {
            this.Tags = Tags;
        }
        if ( VmAppConsistentSpecs != null ) {
            this.VmAppConsistentSpecs = VmAppConsistentSpecs;
        }
        if ( WorkloadSnapshotConnection != null ) {
            this.WorkloadSnapshotConnection = WorkloadSnapshotConnection;
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
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> AzureNativeVmOsType? OsType
        // GraphQL -> osType: AzureNativeVmOsType! (enum)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
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
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configuredSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveRetentionSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String! (scalar)
        if (this.AvailabilitySetNativeId != null) {
            s += ind + "availabilitySetNativeId\n" ;
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            s += ind + "availabilityZone\n" ;
        }
        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        if (this.CloudNativeId != null) {
            s += ind + "cloudNativeId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsAcceleratedNetworkingEnabled
        // GraphQL -> isAcceleratedNetworkingEnabled: Boolean! (scalar)
        if (this.IsAcceleratedNetworkingEnabled != null) {
            s += ind + "isAcceleratedNetworkingEnabled\n" ;
        }
        //      C# -> System.Boolean? IsAdeEnabled
        // GraphQL -> isAdeEnabled: Boolean! (scalar)
        if (this.IsAdeEnabled != null) {
            s += ind + "isAdeEnabled\n" ;
        }
        //      C# -> System.Boolean? IsAppConsistencyEnabled
        // GraphQL -> isAppConsistencyEnabled: Boolean! (scalar)
        if (this.IsAppConsistencyEnabled != null) {
            s += ind + "isAppConsistencyEnabled\n" ;
        }
        //      C# -> System.Boolean? IsExocomputeConfigured
        // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
        if (this.IsExocomputeConfigured != null) {
            s += ind + "isExocomputeConfigured\n" ;
        }
        //      C# -> System.Boolean? IsFileIndexingEnabled
        // GraphQL -> isFileIndexingEnabled: Boolean! (scalar)
        if (this.IsFileIndexingEnabled != null) {
            s += ind + "isFileIndexingEnabled\n" ;
        }
        //      C# -> System.Boolean? IsPreOrPostScriptEnabled
        // GraphQL -> isPreOrPostScriptEnabled: Boolean! (scalar)
        if (this.IsPreOrPostScriptEnabled != null) {
            s += ind + "isPreOrPostScriptEnabled\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName != null) {
            s += ind + "nativeName\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            s += ind + "onDemandSnapshotCount\n" ;
        }
        //      C# -> System.String? PrivateIp
        // GraphQL -> privateIp: String! (scalar)
        if (this.PrivateIp != null) {
            s += ind + "privateIp\n" ;
        }
        //      C# -> System.String? SizeType
        // GraphQL -> sizeType: String! (scalar)
        if (this.SizeType != null) {
            s += ind + "sizeType\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (this.SubnetName != null) {
            s += ind + "subnetName\n" ;
        }
        //      C# -> System.String? VirtuaMachineNativeId
        // GraphQL -> virtuaMachineNativeId: String! (scalar)
        if (this.VirtuaMachineNativeId != null) {
            s += ind + "virtuaMachineNativeId\n" ;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            s += ind + "vmName\n" ;
        }
        //      C# -> System.String? VnetName
        // GraphQL -> vnetName: String! (scalar)
        if (this.VnetName != null) {
            s += ind + "vnetName\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AzureNativeManagedDisk>? AttachedManagedDisks
        // GraphQL -> attachedManagedDisks: [AzureNativeManagedDisk!]! (type)
        if (this.AttachedManagedDisks != null) {
            var fspec = this.AttachedManagedDisks.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "attachedManagedDisks {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AttachmentSpecsForVirtualMachine>? AttachmentSpecs
        // GraphQL -> attachmentSpecs: [AttachmentSpecsForVirtualMachine!]! (type)
        if (this.AttachmentSpecs != null) {
            var fspec = this.AttachmentSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "attachmentSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaSourceObject {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PhysicalHost? HostInfo
        // GraphQL -> hostInfo: PhysicalHost (type)
        if (this.HostInfo != null) {
            var fspec = this.HostInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hostInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot != null) {
            var fspec = this.NewestIndexedSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestIndexedSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureNativeResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureNativeResourceGroup! (type)
        if (this.ResourceGroup != null) {
            var fspec = this.ResourceGroup.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "resourceGroup {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection != null) {
            var fspec = this.SnapshotGroupByNewConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByNewConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tags {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VmAppConsistentSpecsInternal? VmAppConsistentSpecs
        // GraphQL -> vmAppConsistentSpecs: VmAppConsistentSpecsInternal (type)
        if (this.VmAppConsistentSpecs != null) {
            var fspec = this.VmAppConsistentSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmAppConsistentSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection != null) {
            var fspec = this.WorkloadSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "workloadSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> AzureNativeVmOsType? OsType
        // GraphQL -> osType: AzureNativeVmOsType! (enum)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = new AzureNativeVmOsType();
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
        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String! (scalar)
        if (this.AvailabilitySetNativeId == null && Exploration.Includes(parent + ".availabilitySetNativeId", true))
        {
            this.AvailabilitySetNativeId = "FETCH";
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone", true))
        {
            this.AvailabilityZone = "FETCH";
        }
        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        if (this.CloudNativeId == null && Exploration.Includes(parent + ".cloudNativeId", true))
        {
            this.CloudNativeId = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsAcceleratedNetworkingEnabled
        // GraphQL -> isAcceleratedNetworkingEnabled: Boolean! (scalar)
        if (this.IsAcceleratedNetworkingEnabled == null && Exploration.Includes(parent + ".isAcceleratedNetworkingEnabled", true))
        {
            this.IsAcceleratedNetworkingEnabled = true;
        }
        //      C# -> System.Boolean? IsAdeEnabled
        // GraphQL -> isAdeEnabled: Boolean! (scalar)
        if (this.IsAdeEnabled == null && Exploration.Includes(parent + ".isAdeEnabled", true))
        {
            this.IsAdeEnabled = true;
        }
        //      C# -> System.Boolean? IsAppConsistencyEnabled
        // GraphQL -> isAppConsistencyEnabled: Boolean! (scalar)
        if (this.IsAppConsistencyEnabled == null && Exploration.Includes(parent + ".isAppConsistencyEnabled", true))
        {
            this.IsAppConsistencyEnabled = true;
        }
        //      C# -> System.Boolean? IsExocomputeConfigured
        // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
        if (this.IsExocomputeConfigured == null && Exploration.Includes(parent + ".isExocomputeConfigured", true))
        {
            this.IsExocomputeConfigured = true;
        }
        //      C# -> System.Boolean? IsFileIndexingEnabled
        // GraphQL -> isFileIndexingEnabled: Boolean! (scalar)
        if (this.IsFileIndexingEnabled == null && Exploration.Includes(parent + ".isFileIndexingEnabled", true))
        {
            this.IsFileIndexingEnabled = true;
        }
        //      C# -> System.Boolean? IsPreOrPostScriptEnabled
        // GraphQL -> isPreOrPostScriptEnabled: Boolean! (scalar)
        if (this.IsPreOrPostScriptEnabled == null && Exploration.Includes(parent + ".isPreOrPostScriptEnabled", true))
        {
            this.IsPreOrPostScriptEnabled = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        if (this.NativeName == null && Exploration.Includes(parent + ".nativeName", true))
        {
            this.NativeName = "FETCH";
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants", true))
        {
            this.NumWorkloadDescendants = Int32.MinValue;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount", true))
        {
            this.OnDemandSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.String? PrivateIp
        // GraphQL -> privateIp: String! (scalar)
        if (this.PrivateIp == null && Exploration.Includes(parent + ".privateIp", true))
        {
            this.PrivateIp = "FETCH";
        }
        //      C# -> System.String? SizeType
        // GraphQL -> sizeType: String! (scalar)
        if (this.SizeType == null && Exploration.Includes(parent + ".sizeType", true))
        {
            this.SizeType = "FETCH";
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        if (this.SubnetName == null && Exploration.Includes(parent + ".subnetName", true))
        {
            this.SubnetName = "FETCH";
        }
        //      C# -> System.String? VirtuaMachineNativeId
        // GraphQL -> virtuaMachineNativeId: String! (scalar)
        if (this.VirtuaMachineNativeId == null && Exploration.Includes(parent + ".virtuaMachineNativeId", true))
        {
            this.VirtuaMachineNativeId = "FETCH";
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName == null && Exploration.Includes(parent + ".vmName", true))
        {
            this.VmName = "FETCH";
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
        //      C# -> List<AzureNativeManagedDisk>? AttachedManagedDisks
        // GraphQL -> attachedManagedDisks: [AzureNativeManagedDisk!]! (type)
        if (this.AttachedManagedDisks == null && Exploration.Includes(parent + ".attachedManagedDisks"))
        {
            this.AttachedManagedDisks = new List<AzureNativeManagedDisk>();
            this.AttachedManagedDisks.ApplyExploratoryFieldSpec(parent + ".attachedManagedDisks");
        }
        //      C# -> List<AttachmentSpecsForVirtualMachine>? AttachmentSpecs
        // GraphQL -> attachmentSpecs: [AttachmentSpecsForVirtualMachine!]! (type)
        if (this.AttachmentSpecs == null && Exploration.Includes(parent + ".attachmentSpecs"))
        {
            this.AttachmentSpecs = new List<AttachmentSpecsForVirtualMachine>();
            this.AttachmentSpecs.ApplyExploratoryFieldSpec(parent + ".attachmentSpecs");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> PhysicalHost? HostInfo
        // GraphQL -> hostInfo: PhysicalHost (type)
        if (this.HostInfo == null && Exploration.Includes(parent + ".hostInfo"))
        {
            this.HostInfo = new PhysicalHost();
            this.HostInfo.ApplyExploratoryFieldSpec(parent + ".hostInfo");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot == null && Exploration.Includes(parent + ".newestIndexedSnapshot"))
        {
            this.NewestIndexedSnapshot = new PolarisSnapshot();
            this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestIndexedSnapshot");
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
        {
            this.NewestSnapshot = new PolarisSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(parent + ".newestSnapshot");
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
        {
            this.OldestSnapshot = new PolarisSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(parent + ".oldestSnapshot");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> AzureNativeResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureNativeResourceGroup! (type)
        if (this.ResourceGroup == null && Exploration.Includes(parent + ".resourceGroup"))
        {
            this.ResourceGroup = new AzureNativeResourceGroup();
            this.ResourceGroup.ApplyExploratoryFieldSpec(parent + ".resourceGroup");
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
        {
            this.SnapshotConnection = new PolarisSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(parent + ".snapshotConnection");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
        {
            this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByConnection");
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection == null && Exploration.Includes(parent + ".snapshotGroupByNewConnection"))
        {
            this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
            this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByNewConnection");
        }
        //      C# -> List<AzureTag>? Tags
        // GraphQL -> tags: [AzureTag!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<AzureTag>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
        }
        //      C# -> VmAppConsistentSpecsInternal? VmAppConsistentSpecs
        // GraphQL -> vmAppConsistentSpecs: VmAppConsistentSpecsInternal (type)
        if (this.VmAppConsistentSpecs == null && Exploration.Includes(parent + ".vmAppConsistentSpecs"))
        {
            this.VmAppConsistentSpecs = new VmAppConsistentSpecsInternal();
            this.VmAppConsistentSpecs.ApplyExploratoryFieldSpec(parent + ".vmAppConsistentSpecs");
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection == null && Exploration.Includes(parent + ".workloadSnapshotConnection"))
        {
            this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
            this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".workloadSnapshotConnection");
        }
    }


    #endregion

    } // class AzureNativeVirtualMachine
    
    #endregion

    public static class ListAzureNativeVirtualMachineExtensions
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
            this List<AzureNativeVirtualMachine> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeVirtualMachine> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeVirtualMachine());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types