// NasShare.cs
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
    #region NasShare
 
    public class NasShare: IFragment, CdmHierarchyObject, HierarchyObject, NasNamespaceDescendantType, NasNamespaceLogicalChildType, NasSystemDescendantType, NasSystemLogicalChildType, NasVolumeDescendantType, NasVolumeLogicalChildType
    {
        #region members
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: UUID! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ExportPoint
        // GraphQL -> exportPoint: String! (scalar)
        [JsonProperty("exportPoint")]
        public System.String? ExportPoint { get; set; }

        //      C# -> System.String? HostAddress
        // GraphQL -> hostAddress: String! (scalar)
        [JsonProperty("hostAddress")]
        public System.String? HostAddress { get; set; }

        //      C# -> System.String? HostIdForRestore
        // GraphQL -> hostIdForRestore: String! (scalar)
        [JsonProperty("hostIdForRestore")]
        public System.String? HostIdForRestore { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsChangelistEnabled
        // GraphQL -> isChangelistEnabled: Boolean! (scalar)
        [JsonProperty("isChangelistEnabled")]
        public System.Boolean? IsChangelistEnabled { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Boolean? IsStale
        // GraphQL -> isStale: Boolean! (scalar)
        [JsonProperty("isStale")]
        public System.Boolean? IsStale { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.String? ShareType
        // GraphQL -> shareType: String! (scalar)
        [JsonProperty("shareType")]
        public System.String? ShareType { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> NasShareDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: NasShareDescendantTypeConnection! (type)
        [JsonProperty("descendantConnection")]
        public NasShareDescendantTypeConnection? DescendantConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> NasShareLogicalChildTypeConnection? LogicalChildConnection
        // GraphQL -> logicalChildConnection: NasShareLogicalChildTypeConnection! (type)
        [JsonProperty("logicalChildConnection")]
        public NasShareLogicalChildTypeConnection? LogicalChildConnection { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> NasSystem? NasSystem
        // GraphQL -> nasSystem: NasSystem! (type)
        [JsonProperty("nasSystem")]
        public NasSystem? NasSystem { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> NasFileset? PrimaryFileset
        // GraphQL -> primaryFileset: NasFileset (type)
        [JsonProperty("primaryFileset")]
        public NasFileset? PrimaryFileset { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> ConnectedThroughEnumType? ConnectedThrough
        // GraphQL -> connectedThrough: ConnectedThroughEnumType! (enum)
        [JsonProperty("connectedThrough")]
        public ConnectedThroughEnumType? ConnectedThrough { get; set; }

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

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public List<CdmHierarchyObject>? ReplicatedObjects { get; set; }

        #endregion

    #region methods

    public NasShare Set(
        System.String? CdmId = null,
        System.String? ExportPoint = null,
        System.String? HostAddress = null,
        System.String? HostIdForRestore = null,
        System.String? Id = null,
        System.Boolean? IsChangelistEnabled = null,
        System.Boolean? IsHidden = null,
        System.Boolean? IsRelic = null,
        System.Boolean? IsStale = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? ReplicatedObjectCount = null,
        System.String? ShareType = null,
        System.Boolean? SlaPauseStatus = null,
        List<Org>? AllOrgs = null,
        Cluster? Cluster = null,
        NasShareDescendantTypeConnection? DescendantConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        LatestUserNote? LatestUserNote = null,
        NasShareLogicalChildTypeConnection? LogicalChildConnection = null,
        List<PathNode>? LogicalPath = null,
        NasSystem? NasSystem = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        NasFileset? PrimaryFileset = null,
        SnapshotDistribution? SnapshotDistribution = null,
        List<Operation>? AuthorizedOperations = null,
        ConnectedThroughEnumType? ConnectedThrough = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ExportPoint != null ) {
            this.ExportPoint = ExportPoint;
        }
        if ( HostAddress != null ) {
            this.HostAddress = HostAddress;
        }
        if ( HostIdForRestore != null ) {
            this.HostIdForRestore = HostIdForRestore;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsChangelistEnabled != null ) {
            this.IsChangelistEnabled = IsChangelistEnabled;
        }
        if ( IsHidden != null ) {
            this.IsHidden = IsHidden;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( IsStale != null ) {
            this.IsStale = IsStale;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LogicalChildConnection != null ) {
            this.LogicalChildConnection = LogicalChildConnection;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( NasSystem != null ) {
            this.NasSystem = NasSystem;
        }
        if ( PendingObjectDeletionStatus != null ) {
            this.PendingObjectDeletionStatus = PendingObjectDeletionStatus;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( PrimaryFileset != null ) {
            this.PrimaryFileset = PrimaryFileset;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ConnectedThrough != null ) {
            this.ConnectedThrough = ConnectedThrough;
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
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
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
            // GraphQL -> cdmId: UUID! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? ExportPoint
            // GraphQL -> exportPoint: String! (scalar)
            if (this.ExportPoint != null)
            {
                 s += ind + "exportPoint\n";

            }
            //      C# -> System.String? HostAddress
            // GraphQL -> hostAddress: String! (scalar)
            if (this.HostAddress != null)
            {
                 s += ind + "hostAddress\n";

            }
            //      C# -> System.String? HostIdForRestore
            // GraphQL -> hostIdForRestore: String! (scalar)
            if (this.HostIdForRestore != null)
            {
                 s += ind + "hostIdForRestore\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsChangelistEnabled
            // GraphQL -> isChangelistEnabled: Boolean! (scalar)
            if (this.IsChangelistEnabled != null)
            {
                 s += ind + "isChangelistEnabled\n";

            }
            //      C# -> System.Boolean? IsHidden
            // GraphQL -> isHidden: Boolean! (scalar)
            if (this.IsHidden != null)
            {
                 s += ind + "isHidden\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.Boolean? IsStale
            // GraphQL -> isStale: Boolean! (scalar)
            if (this.IsStale != null)
            {
                 s += ind + "isStale\n";

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
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount != null)
            {
                 s += ind + "replicatedObjectCount\n";

            }
            //      C# -> System.String? ShareType
            // GraphQL -> shareType: String! (scalar)
            if (this.ShareType != null)
            {
                 s += ind + "shareType\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

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
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NasShareDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: NasShareDescendantTypeConnection! (type)
            if (this.DescendantConnection != null)
            {
                 s += ind + "descendantConnection\n";

                 s += ind + "{\n" + 
                 this.DescendantConnection.AsFragment(indent+1) + 
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
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote != null)
            {
                 s += ind + "latestUserNote\n";

                 s += ind + "{\n" + 
                 this.LatestUserNote.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NasShareLogicalChildTypeConnection? LogicalChildConnection
            // GraphQL -> logicalChildConnection: NasShareLogicalChildTypeConnection! (type)
            if (this.LogicalChildConnection != null)
            {
                 s += ind + "logicalChildConnection\n";

                 s += ind + "{\n" + 
                 this.LogicalChildConnection.AsFragment(indent+1) + 
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
            //      C# -> NasSystem? NasSystem
            // GraphQL -> nasSystem: NasSystem! (type)
            if (this.NasSystem != null)
            {
                 s += ind + "nasSystem\n";

                 s += ind + "{\n" + 
                 this.NasSystem.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
            // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
            if (this.PendingObjectDeletionStatus != null)
            {
                 s += ind + "pendingObjectDeletionStatus\n";

                 s += ind + "{\n" + 
                 this.PendingObjectDeletionStatus.AsFragment(indent+1) + 
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
            //      C# -> DataLocation? PrimaryClusterLocation
            // GraphQL -> primaryClusterLocation: DataLocation! (type)
            if (this.PrimaryClusterLocation != null)
            {
                 s += ind + "primaryClusterLocation\n";

                 s += ind + "{\n" + 
                 this.PrimaryClusterLocation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NasFileset? PrimaryFileset
            // GraphQL -> primaryFileset: NasFileset (type)
            if (this.PrimaryFileset != null)
            {
                 s += ind + "primaryFileset\n";

                 s += ind + "{\n" + 
                 this.PrimaryFileset.AsFragment(indent+1) + 
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
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> ConnectedThroughEnumType? ConnectedThrough
            // GraphQL -> connectedThrough: ConnectedThroughEnumType! (enum)
            if (this.ConnectedThrough != null)
            {
                 s += ind + "connectedThrough\n";

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
                        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
            // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
            if (this.ReplicatedObjects != null)
            {
                s += ind + "replicatedObjects\n";
                s += ind + "{\n";

                s += this.ReplicatedObjects.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: UUID! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? ExportPoint
            // GraphQL -> exportPoint: String! (scalar)
            if (this.ExportPoint == null && Exploration.Includes(parent + ".exportPoint$"))
            {
                this.ExportPoint = new System.String("FETCH");
            }
            //      C# -> System.String? HostAddress
            // GraphQL -> hostAddress: String! (scalar)
            if (this.HostAddress == null && Exploration.Includes(parent + ".hostAddress$"))
            {
                this.HostAddress = new System.String("FETCH");
            }
            //      C# -> System.String? HostIdForRestore
            // GraphQL -> hostIdForRestore: String! (scalar)
            if (this.HostIdForRestore == null && Exploration.Includes(parent + ".hostIdForRestore$"))
            {
                this.HostIdForRestore = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsChangelistEnabled
            // GraphQL -> isChangelistEnabled: Boolean! (scalar)
            if (this.IsChangelistEnabled == null && Exploration.Includes(parent + ".isChangelistEnabled$"))
            {
                this.IsChangelistEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsHidden
            // GraphQL -> isHidden: Boolean! (scalar)
            if (this.IsHidden == null && Exploration.Includes(parent + ".isHidden$"))
            {
                this.IsHidden = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.Boolean? IsStale
            // GraphQL -> isStale: Boolean! (scalar)
            if (this.IsStale == null && Exploration.Includes(parent + ".isStale$"))
            {
                this.IsStale = new System.Boolean();
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
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount == null && Exploration.Includes(parent + ".replicatedObjectCount$"))
            {
                this.ReplicatedObjectCount = new System.Int32();
            }
            //      C# -> System.String? ShareType
            // GraphQL -> shareType: String! (scalar)
            if (this.ShareType == null && Exploration.Includes(parent + ".shareType$"))
            {
                this.ShareType = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> NasShareDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: NasShareDescendantTypeConnection! (type)
            if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
            {
                this.DescendantConnection = new NasShareDescendantTypeConnection();
                this.DescendantConnection.ApplyExploratoryFragment(parent + ".descendantConnection");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
            {
                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFragment(parent + ".latestUserNote");
            }
            //      C# -> NasShareLogicalChildTypeConnection? LogicalChildConnection
            // GraphQL -> logicalChildConnection: NasShareLogicalChildTypeConnection! (type)
            if (this.LogicalChildConnection == null && Exploration.Includes(parent + ".logicalChildConnection"))
            {
                this.LogicalChildConnection = new NasShareLogicalChildTypeConnection();
                this.LogicalChildConnection.ApplyExploratoryFragment(parent + ".logicalChildConnection");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> NasSystem? NasSystem
            // GraphQL -> nasSystem: NasSystem! (type)
            if (this.NasSystem == null && Exploration.Includes(parent + ".nasSystem"))
            {
                this.NasSystem = new NasSystem();
                this.NasSystem.ApplyExploratoryFragment(parent + ".nasSystem");
            }
            //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
            // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
            if (this.PendingObjectDeletionStatus == null && Exploration.Includes(parent + ".pendingObjectDeletionStatus"))
            {
                this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
                this.PendingObjectDeletionStatus.ApplyExploratoryFragment(parent + ".pendingObjectDeletionStatus");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> DataLocation? PrimaryClusterLocation
            // GraphQL -> primaryClusterLocation: DataLocation! (type)
            if (this.PrimaryClusterLocation == null && Exploration.Includes(parent + ".primaryClusterLocation"))
            {
                this.PrimaryClusterLocation = new DataLocation();
                this.PrimaryClusterLocation.ApplyExploratoryFragment(parent + ".primaryClusterLocation");
            }
            //      C# -> NasFileset? PrimaryFileset
            // GraphQL -> primaryFileset: NasFileset (type)
            if (this.PrimaryFileset == null && Exploration.Includes(parent + ".primaryFileset"))
            {
                this.PrimaryFileset = new NasFileset();
                this.PrimaryFileset.ApplyExploratoryFragment(parent + ".primaryFileset");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<Operation>();
            }
            //      C# -> ConnectedThroughEnumType? ConnectedThrough
            // GraphQL -> connectedThrough: ConnectedThroughEnumType! (enum)
            if (this.ConnectedThrough == null && Exploration.Includes(parent + ".connectedThrough$"))
            {
                this.ConnectedThrough = new ConnectedThroughEnumType();
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
            //      C# -> SlaDomain? PendingSla
            // GraphQL -> pendingSla: SlaDomain (interface)
            if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
            {
                this.PendingSla = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.PendingSla.ApplyExploratoryFragment(parent + ".pendingSla");
            }
            //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
            // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
            if (this.ReplicatedObjects == null && Exploration.Includes(parent + ".replicatedObjects"))
            {
                this.ReplicatedObjects = new List<CdmHierarchyObject>();
                this.ReplicatedObjects.ApplyExploratoryFragment(parent + ".replicatedObjects");
            }
        }


    #endregion

    } // class NasShare
    #endregion

    public static class ListNasShareExtensions
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
            this List<NasShare> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NasShare> list, 
            String parent = "")
        {
            var item = new NasShare();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types