// O365Mailbox.cs
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
    #region O365Mailbox
 
    public class O365Mailbox: IFragment, HierarchyObject, HierarchySnappable, O365OrgDescendant, O365UserDescendant, O365UserDescendantMetadata, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

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

        //      C# -> System.String? PreferredDataLocation
        // GraphQL -> preferredDataLocation: String! (scalar)
        [JsonProperty("preferredDataLocation")]
        public System.String? PreferredDataLocation { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        [JsonProperty("userPrincipalName")]
        public System.String? UserPrincipalName { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

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

        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public PolarisSnapshot? OldestSnapshot { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

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

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

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

    public O365Mailbox Set(
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? PreferredDataLocation = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? UserPrincipalName = null,
        List<Org>? AllOrgs = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        PolarisSnapshot? OldestSnapshot = null,
        List<PathNode>? PhysicalPath = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null,
        List<Operation>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
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
        if ( PreferredDataLocation != null ) {
            this.PreferredDataLocation = PreferredDataLocation;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( UserPrincipalName != null ) {
            this.UserPrincipalName = UserPrincipalName;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
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
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
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
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
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
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

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
            //      C# -> System.String? PreferredDataLocation
            // GraphQL -> preferredDataLocation: String! (scalar)
            if (this.PreferredDataLocation != null)
            {
                 s += ind + "preferredDataLocation\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> System.String? UserPrincipalName
            // GraphQL -> userPrincipalName: String! (scalar)
            if (this.UserPrincipalName != null)
            {
                 s += ind + "userPrincipalName\n";

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
            //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
            // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
            if (this.WorkloadSnapshotConnection != null)
            {
                 s += ind + "workloadSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.WorkloadSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
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
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
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
            //      C# -> System.String? PreferredDataLocation
            // GraphQL -> preferredDataLocation: String! (scalar)
            if (this.PreferredDataLocation == null && Exploration.Includes(parent + ".preferredDataLocation$"))
            {
                this.PreferredDataLocation = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> System.String? UserPrincipalName
            // GraphQL -> userPrincipalName: String! (scalar)
            if (this.UserPrincipalName == null && Exploration.Includes(parent + ".userPrincipalName$"))
            {
                this.UserPrincipalName = new System.String("FETCH");
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
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
            //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
            // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
            if (this.WorkloadSnapshotConnection == null && Exploration.Includes(parent + ".workloadSnapshotConnection"))
            {
                this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
                this.WorkloadSnapshotConnection.ApplyExploratoryFragment(parent + ".workloadSnapshotConnection");
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<Operation>();
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

    } // class O365Mailbox
    #endregion

    public static class ListO365MailboxExtensions
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
            this List<O365Mailbox> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365Mailbox> list, 
            String parent = "")
        {
            var item = new O365Mailbox();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types