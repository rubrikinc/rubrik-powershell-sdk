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

namespace Rubrik.SecurityCloud.Types
{
    #region AzureNativeVirtualMachine
 
    public class AzureNativeVirtualMachine: IFragment, PolarisHierarchyObject, PolarisHierarchySnappable, HierarchyObject, AzureNativeHierarchyObjectType
    {
        #region members
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

        #endregion

    #region methods

    public AzureNativeVirtualMachine Set(
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
        GenericSnapshotConnection? WorkloadSnapshotConnection = null,
        List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        AzureNativeVmOsType? OsType = null,
        AzureNativeRegion? Region = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AvailabilitySetNativeId
            // GraphQL -> availabilitySetNativeId: String! (scalar)
            if (this.AvailabilitySetNativeId != null)
            {
                 s += ind + "availabilitySetNativeId\n";

            }
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone != null)
            {
                 s += ind + "availabilityZone\n";

            }
            //      C# -> System.String? CloudNativeId
            // GraphQL -> cloudNativeId: String! (scalar)
            if (this.CloudNativeId != null)
            {
                 s += ind + "cloudNativeId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsAcceleratedNetworkingEnabled
            // GraphQL -> isAcceleratedNetworkingEnabled: Boolean! (scalar)
            if (this.IsAcceleratedNetworkingEnabled != null)
            {
                 s += ind + "isAcceleratedNetworkingEnabled\n";

            }
            //      C# -> System.Boolean? IsAdeEnabled
            // GraphQL -> isAdeEnabled: Boolean! (scalar)
            if (this.IsAdeEnabled != null)
            {
                 s += ind + "isAdeEnabled\n";

            }
            //      C# -> System.Boolean? IsAppConsistencyEnabled
            // GraphQL -> isAppConsistencyEnabled: Boolean! (scalar)
            if (this.IsAppConsistencyEnabled != null)
            {
                 s += ind + "isAppConsistencyEnabled\n";

            }
            //      C# -> System.Boolean? IsExocomputeConfigured
            // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
            if (this.IsExocomputeConfigured != null)
            {
                 s += ind + "isExocomputeConfigured\n";

            }
            //      C# -> System.Boolean? IsFileIndexingEnabled
            // GraphQL -> isFileIndexingEnabled: Boolean! (scalar)
            if (this.IsFileIndexingEnabled != null)
            {
                 s += ind + "isFileIndexingEnabled\n";

            }
            //      C# -> System.Boolean? IsPreOrPostScriptEnabled
            // GraphQL -> isPreOrPostScriptEnabled: Boolean! (scalar)
            if (this.IsPreOrPostScriptEnabled != null)
            {
                 s += ind + "isPreOrPostScriptEnabled\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NativeName
            // GraphQL -> nativeName: String! (scalar)
            if (this.NativeName != null)
            {
                 s += ind + "nativeName\n";

            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants != null)
            {
                 s += ind + "numWorkloadDescendants\n";

            }
            //      C# -> System.Int32? OnDemandSnapshotCount
            // GraphQL -> onDemandSnapshotCount: Int! (scalar)
            if (this.OnDemandSnapshotCount != null)
            {
                 s += ind + "onDemandSnapshotCount\n";

            }
            //      C# -> System.String? PrivateIp
            // GraphQL -> privateIp: String! (scalar)
            if (this.PrivateIp != null)
            {
                 s += ind + "privateIp\n";

            }
            //      C# -> System.String? SizeType
            // GraphQL -> sizeType: String! (scalar)
            if (this.SizeType != null)
            {
                 s += ind + "sizeType\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> System.String? SubnetName
            // GraphQL -> subnetName: String! (scalar)
            if (this.SubnetName != null)
            {
                 s += ind + "subnetName\n";

            }
            //      C# -> System.String? VirtuaMachineNativeId
            // GraphQL -> virtuaMachineNativeId: String! (scalar)
            if (this.VirtuaMachineNativeId != null)
            {
                 s += ind + "virtuaMachineNativeId\n";

            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName != null)
            {
                 s += ind + "vmName\n";

            }
            //      C# -> System.String? VnetName
            // GraphQL -> vnetName: String! (scalar)
            if (this.VnetName != null)
            {
                 s += ind + "vnetName\n";

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
            //      C# -> List<AzureNativeManagedDisk>? AttachedManagedDisks
            // GraphQL -> attachedManagedDisks: [AzureNativeManagedDisk!]! (type)
            if (this.AttachedManagedDisks != null)
            {
                 s += ind + "attachedManagedDisks\n";

                 s += ind + "{\n" + 
                 this.AttachedManagedDisks.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AttachmentSpecsForVirtualMachine>? AttachmentSpecs
            // GraphQL -> attachmentSpecs: [AttachmentSpecsForVirtualMachine!]! (type)
            if (this.AttachmentSpecs != null)
            {
                 s += ind + "attachmentSpecs\n";

                 s += ind + "{\n" + 
                 this.AttachmentSpecs.AsFragment(indent+1) + 
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
            //      C# -> PhysicalHost? HostInfo
            // GraphQL -> hostInfo: PhysicalHost (type)
            if (this.HostInfo != null)
            {
                 s += ind + "hostInfo\n";

                 s += ind + "{\n" + 
                 this.HostInfo.AsFragment(indent+1) + 
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
            //      C# -> PolarisSnapshot? NewestIndexedSnapshot
            // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
            if (this.NewestIndexedSnapshot != null)
            {
                 s += ind + "newestIndexedSnapshot\n";

                 s += ind + "{\n" + 
                 this.NewestIndexedSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshot? NewestSnapshot
            // GraphQL -> newestSnapshot: PolarisSnapshot (type)
            if (this.NewestSnapshot != null)
            {
                 s += ind + "newestSnapshot\n";

                 s += ind + "{\n" + 
                 this.NewestSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshot? OldestSnapshot
            // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
            if (this.OldestSnapshot != null)
            {
                 s += ind + "oldestSnapshot\n";

                 s += ind + "{\n" + 
                 this.OldestSnapshot.AsFragment(indent+1) + 
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
            //      C# -> AzureNativeResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: AzureNativeResourceGroup! (type)
            if (this.ResourceGroup != null)
            {
                 s += ind + "resourceGroup\n";

                 s += ind + "{\n" + 
                 this.ResourceGroup.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
            if (this.SnapshotConnection != null)
            {
                 s += ind + "snapshotConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotConnection.AsFragment(indent+1) + 
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
            //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
            // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
            if (this.SnapshotGroupByConnection != null)
            {
                 s += ind + "snapshotGroupByConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotGroupByConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
            // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
            if (this.SnapshotGroupByNewConnection != null)
            {
                 s += ind + "snapshotGroupByNewConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotGroupByNewConnection.AsFragment(indent+1) + 
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
            //      C# -> VmAppConsistentSpecsInternal? VmAppConsistentSpecs
            // GraphQL -> vmAppConsistentSpecs: VmAppConsistentSpecsInternal (type)
            if (this.VmAppConsistentSpecs != null)
            {
                 s += ind + "vmAppConsistentSpecs\n";

                 s += ind + "{\n" + 
                 this.VmAppConsistentSpecs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
            // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
            if (this.WorkloadSnapshotConnection != null)
            {
                 s += ind + "workloadSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.WorkloadSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
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
            //      C# -> AzureNativeVmOsType? OsType
            // GraphQL -> osType: AzureNativeVmOsType! (enum)
            if (this.OsType != null)
            {
                 s += ind + "osType\n";

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
            //      C# -> System.String? AvailabilitySetNativeId
            // GraphQL -> availabilitySetNativeId: String! (scalar)
            if (this.AvailabilitySetNativeId == null && Exploration.Includes(parent + ".availabilitySetNativeId$"))
            {
                this.AvailabilitySetNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone$"))
            {
                this.AvailabilityZone = new System.String("FETCH");
            }
            //      C# -> System.String? CloudNativeId
            // GraphQL -> cloudNativeId: String! (scalar)
            if (this.CloudNativeId == null && Exploration.Includes(parent + ".cloudNativeId$"))
            {
                this.CloudNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsAcceleratedNetworkingEnabled
            // GraphQL -> isAcceleratedNetworkingEnabled: Boolean! (scalar)
            if (this.IsAcceleratedNetworkingEnabled == null && Exploration.Includes(parent + ".isAcceleratedNetworkingEnabled$"))
            {
                this.IsAcceleratedNetworkingEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsAdeEnabled
            // GraphQL -> isAdeEnabled: Boolean! (scalar)
            if (this.IsAdeEnabled == null && Exploration.Includes(parent + ".isAdeEnabled$"))
            {
                this.IsAdeEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsAppConsistencyEnabled
            // GraphQL -> isAppConsistencyEnabled: Boolean! (scalar)
            if (this.IsAppConsistencyEnabled == null && Exploration.Includes(parent + ".isAppConsistencyEnabled$"))
            {
                this.IsAppConsistencyEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsExocomputeConfigured
            // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
            if (this.IsExocomputeConfigured == null && Exploration.Includes(parent + ".isExocomputeConfigured$"))
            {
                this.IsExocomputeConfigured = new System.Boolean();
            }
            //      C# -> System.Boolean? IsFileIndexingEnabled
            // GraphQL -> isFileIndexingEnabled: Boolean! (scalar)
            if (this.IsFileIndexingEnabled == null && Exploration.Includes(parent + ".isFileIndexingEnabled$"))
            {
                this.IsFileIndexingEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPreOrPostScriptEnabled
            // GraphQL -> isPreOrPostScriptEnabled: Boolean! (scalar)
            if (this.IsPreOrPostScriptEnabled == null && Exploration.Includes(parent + ".isPreOrPostScriptEnabled$"))
            {
                this.IsPreOrPostScriptEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NativeName
            // GraphQL -> nativeName: String! (scalar)
            if (this.NativeName == null && Exploration.Includes(parent + ".nativeName$"))
            {
                this.NativeName = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants$"))
            {
                this.NumWorkloadDescendants = new System.Int32();
            }
            //      C# -> System.Int32? OnDemandSnapshotCount
            // GraphQL -> onDemandSnapshotCount: Int! (scalar)
            if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount$"))
            {
                this.OnDemandSnapshotCount = new System.Int32();
            }
            //      C# -> System.String? PrivateIp
            // GraphQL -> privateIp: String! (scalar)
            if (this.PrivateIp == null && Exploration.Includes(parent + ".privateIp$"))
            {
                this.PrivateIp = new System.String("FETCH");
            }
            //      C# -> System.String? SizeType
            // GraphQL -> sizeType: String! (scalar)
            if (this.SizeType == null && Exploration.Includes(parent + ".sizeType$"))
            {
                this.SizeType = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> System.String? SubnetName
            // GraphQL -> subnetName: String! (scalar)
            if (this.SubnetName == null && Exploration.Includes(parent + ".subnetName$"))
            {
                this.SubnetName = new System.String("FETCH");
            }
            //      C# -> System.String? VirtuaMachineNativeId
            // GraphQL -> virtuaMachineNativeId: String! (scalar)
            if (this.VirtuaMachineNativeId == null && Exploration.Includes(parent + ".virtuaMachineNativeId$"))
            {
                this.VirtuaMachineNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName == null && Exploration.Includes(parent + ".vmName$"))
            {
                this.VmName = new System.String("FETCH");
            }
            //      C# -> System.String? VnetName
            // GraphQL -> vnetName: String! (scalar)
            if (this.VnetName == null && Exploration.Includes(parent + ".vnetName$"))
            {
                this.VnetName = new System.String("FETCH");
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> List<AzureNativeManagedDisk>? AttachedManagedDisks
            // GraphQL -> attachedManagedDisks: [AzureNativeManagedDisk!]! (type)
            if (this.AttachedManagedDisks == null && Exploration.Includes(parent + ".attachedManagedDisks"))
            {
                this.AttachedManagedDisks = new List<AzureNativeManagedDisk>();
                this.AttachedManagedDisks.ApplyExploratoryFragment(parent + ".attachedManagedDisks");
            }
            //      C# -> List<AttachmentSpecsForVirtualMachine>? AttachmentSpecs
            // GraphQL -> attachmentSpecs: [AttachmentSpecsForVirtualMachine!]! (type)
            if (this.AttachmentSpecs == null && Exploration.Includes(parent + ".attachmentSpecs"))
            {
                this.AttachmentSpecs = new List<AttachmentSpecsForVirtualMachine>();
                this.AttachmentSpecs.ApplyExploratoryFragment(parent + ".attachmentSpecs");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> PhysicalHost? HostInfo
            // GraphQL -> hostInfo: PhysicalHost (type)
            if (this.HostInfo == null && Exploration.Includes(parent + ".hostInfo"))
            {
                this.HostInfo = new PhysicalHost();
                this.HostInfo.ApplyExploratoryFragment(parent + ".hostInfo");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> PolarisSnapshot? NewestIndexedSnapshot
            // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
            if (this.NewestIndexedSnapshot == null && Exploration.Includes(parent + ".newestIndexedSnapshot"))
            {
                this.NewestIndexedSnapshot = new PolarisSnapshot();
                this.NewestIndexedSnapshot.ApplyExploratoryFragment(parent + ".newestIndexedSnapshot");
            }
            //      C# -> PolarisSnapshot? NewestSnapshot
            // GraphQL -> newestSnapshot: PolarisSnapshot (type)
            if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
            {
                this.NewestSnapshot = new PolarisSnapshot();
                this.NewestSnapshot.ApplyExploratoryFragment(parent + ".newestSnapshot");
            }
            //      C# -> PolarisSnapshot? OldestSnapshot
            // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
            if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
            {
                this.OldestSnapshot = new PolarisSnapshot();
                this.OldestSnapshot.ApplyExploratoryFragment(parent + ".oldestSnapshot");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> AzureNativeResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: AzureNativeResourceGroup! (type)
            if (this.ResourceGroup == null && Exploration.Includes(parent + ".resourceGroup"))
            {
                this.ResourceGroup = new AzureNativeResourceGroup();
                this.ResourceGroup.ApplyExploratoryFragment(parent + ".resourceGroup");
            }
            //      C# -> PolarisSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
            if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
            {
                this.SnapshotConnection = new PolarisSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFragment(parent + ".snapshotConnection");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
            // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
            if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
            {
                this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
                this.SnapshotGroupByConnection.ApplyExploratoryFragment(parent + ".snapshotGroupByConnection");
            }
            //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
            // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
            if (this.SnapshotGroupByNewConnection == null && Exploration.Includes(parent + ".snapshotGroupByNewConnection"))
            {
                this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
                this.SnapshotGroupByNewConnection.ApplyExploratoryFragment(parent + ".snapshotGroupByNewConnection");
            }
            //      C# -> List<AzureTag>? Tags
            // GraphQL -> tags: [AzureTag!]! (type)
            if (this.Tags == null && Exploration.Includes(parent + ".tags"))
            {
                this.Tags = new List<AzureTag>();
                this.Tags.ApplyExploratoryFragment(parent + ".tags");
            }
            //      C# -> VmAppConsistentSpecsInternal? VmAppConsistentSpecs
            // GraphQL -> vmAppConsistentSpecs: VmAppConsistentSpecsInternal (type)
            if (this.VmAppConsistentSpecs == null && Exploration.Includes(parent + ".vmAppConsistentSpecs"))
            {
                this.VmAppConsistentSpecs = new VmAppConsistentSpecsInternal();
                this.VmAppConsistentSpecs.ApplyExploratoryFragment(parent + ".vmAppConsistentSpecs");
            }
            //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
            // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
            if (this.WorkloadSnapshotConnection == null && Exploration.Includes(parent + ".workloadSnapshotConnection"))
            {
                this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
                this.WorkloadSnapshotConnection.ApplyExploratoryFragment(parent + ".workloadSnapshotConnection");
            }
            //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<PolarisSnappableAuthorizedOperationsEnum>();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> AzureNativeVmOsType? OsType
            // GraphQL -> osType: AzureNativeVmOsType! (enum)
            if (this.OsType == null && Exploration.Includes(parent + ".osType$"))
            {
                this.OsType = new AzureNativeVmOsType();
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

    } // class AzureNativeVirtualMachine
    #endregion

    public static class ListAzureNativeVirtualMachineExtensions
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
            this List<AzureNativeVirtualMachine> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeVirtualMachine> list, 
            String parent = "")
        {
            var item = new AzureNativeVirtualMachine();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types