// GcpNativeProject.cs
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
    #region GcpNativeProject
 
    public class GcpNativeProject: IFragment, HierarchyObject, PolarisHierarchyObject
    {
        #region members
        //      C# -> System.Int32? DiskCount
        // GraphQL -> diskCount: Int! (scalar)
        [JsonProperty("diskCount")]
        public System.Int32? DiskCount { get; set; }

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

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        [JsonProperty("nativeName")]
        public System.String? NativeName { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> System.String? ProjectNumber
        // GraphQL -> projectNumber: String! (scalar)
        [JsonProperty("projectNumber")]
        public System.String? ProjectNumber { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Int32? VmCount
        // GraphQL -> vmCount: Int! (scalar)
        [JsonProperty("vmCount")]
        public System.Int32? VmCount { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> GcpNativeGceInstanceConnection? GcpNativeGceInstanceConnection
        // GraphQL -> gcpNativeGceInstanceConnection: GcpNativeGceInstanceConnection! (type)
        [JsonProperty("gcpNativeGceInstanceConnection")]
        public GcpNativeGceInstanceConnection? GcpNativeGceInstanceConnection { get; set; }

        //      C# -> GcpNativeProjectLogicalChildTypeConnection? LogicalChildConnection
        // GraphQL -> logicalChildConnection: GcpNativeProjectLogicalChildTypeConnection! (type)
        [JsonProperty("logicalChildConnection")]
        public GcpNativeProjectLogicalChildTypeConnection? LogicalChildConnection { get; set; }

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

        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> GcpNativeProjectStatus? Status
        // GraphQL -> status: GcpNativeProjectStatus! (enum)
        [JsonProperty("status")]
        public GcpNativeProjectStatus? Status { get; set; }

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

    public GcpNativeProject Set(
        System.Int32? DiskCount = null,
        System.String? Id = null,
        DateTime? LastRefreshedAt = null,
        System.String? Name = null,
        System.String? NativeId = null,
        System.String? NativeName = null,
        System.Int32? NumWorkloadDescendants = null,
        System.String? OrganizationName = null,
        System.String? ProjectNumber = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int32? VmCount = null,
        List<Org>? AllOrgs = null,
        PathNode? EffectiveSlaSourceObject = null,
        GcpNativeGceInstanceConnection? GcpNativeGceInstanceConnection = null,
        GcpNativeProjectLogicalChildTypeConnection? LogicalChildConnection = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        SnapshotDistribution? SnapshotDistribution = null,
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        GcpNativeProjectStatus? Status = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
        if ( DiskCount != null ) {
            this.DiskCount = DiskCount;
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
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( NativeName != null ) {
            this.NativeName = NativeName;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OrganizationName != null ) {
            this.OrganizationName = OrganizationName;
        }
        if ( ProjectNumber != null ) {
            this.ProjectNumber = ProjectNumber;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( VmCount != null ) {
            this.VmCount = VmCount;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( GcpNativeGceInstanceConnection != null ) {
            this.GcpNativeGceInstanceConnection = GcpNativeGceInstanceConnection;
        }
        if ( LogicalChildConnection != null ) {
            this.LogicalChildConnection = LogicalChildConnection;
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
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.Int32? DiskCount
            // GraphQL -> diskCount: Int! (scalar)
            if (this.DiskCount != null)
            {
                 s += ind + "diskCount\n";

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
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId != null)
            {
                 s += ind + "nativeId\n";

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
            //      C# -> System.String? OrganizationName
            // GraphQL -> organizationName: String! (scalar)
            if (this.OrganizationName != null)
            {
                 s += ind + "organizationName\n";

            }
            //      C# -> System.String? ProjectNumber
            // GraphQL -> projectNumber: String! (scalar)
            if (this.ProjectNumber != null)
            {
                 s += ind + "projectNumber\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> System.Int32? VmCount
            // GraphQL -> vmCount: Int! (scalar)
            if (this.VmCount != null)
            {
                 s += ind + "vmCount\n";

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
            //      C# -> GcpNativeGceInstanceConnection? GcpNativeGceInstanceConnection
            // GraphQL -> gcpNativeGceInstanceConnection: GcpNativeGceInstanceConnection! (type)
            if (this.GcpNativeGceInstanceConnection != null)
            {
                 s += ind + "gcpNativeGceInstanceConnection\n";

                 s += ind + "{\n" + 
                 this.GcpNativeGceInstanceConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GcpNativeProjectLogicalChildTypeConnection? LogicalChildConnection
            // GraphQL -> logicalChildConnection: GcpNativeProjectLogicalChildTypeConnection! (type)
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
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath != null)
            {
                 s += ind + "physicalPath\n";

                 s += ind + "{\n" + 
                 this.PhysicalPath.AsFragment(indent+1) + 
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
            //      C# -> GcpNativeProjectStatus? Status
            // GraphQL -> status: GcpNativeProjectStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

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
            //      C# -> System.Int32? DiskCount
            // GraphQL -> diskCount: Int! (scalar)
            if (this.DiskCount == null && Exploration.Includes(parent + ".diskCount$"))
            {
                this.DiskCount = new System.Int32();
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
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId == null && Exploration.Includes(parent + ".nativeId$"))
            {
                this.NativeId = new System.String("FETCH");
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
            //      C# -> System.String? OrganizationName
            // GraphQL -> organizationName: String! (scalar)
            if (this.OrganizationName == null && Exploration.Includes(parent + ".organizationName$"))
            {
                this.OrganizationName = new System.String("FETCH");
            }
            //      C# -> System.String? ProjectNumber
            // GraphQL -> projectNumber: String! (scalar)
            if (this.ProjectNumber == null && Exploration.Includes(parent + ".projectNumber$"))
            {
                this.ProjectNumber = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> System.Int32? VmCount
            // GraphQL -> vmCount: Int! (scalar)
            if (this.VmCount == null && Exploration.Includes(parent + ".vmCount$"))
            {
                this.VmCount = new System.Int32();
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
            //      C# -> GcpNativeGceInstanceConnection? GcpNativeGceInstanceConnection
            // GraphQL -> gcpNativeGceInstanceConnection: GcpNativeGceInstanceConnection! (type)
            if (this.GcpNativeGceInstanceConnection == null && Exploration.Includes(parent + ".gcpNativeGceInstanceConnection"))
            {
                this.GcpNativeGceInstanceConnection = new GcpNativeGceInstanceConnection();
                this.GcpNativeGceInstanceConnection.ApplyExploratoryFragment(parent + ".gcpNativeGceInstanceConnection");
            }
            //      C# -> GcpNativeProjectLogicalChildTypeConnection? LogicalChildConnection
            // GraphQL -> logicalChildConnection: GcpNativeProjectLogicalChildTypeConnection! (type)
            if (this.LogicalChildConnection == null && Exploration.Includes(parent + ".logicalChildConnection"))
            {
                this.LogicalChildConnection = new GcpNativeProjectLogicalChildTypeConnection();
                this.LogicalChildConnection.ApplyExploratoryFragment(parent + ".logicalChildConnection");
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
            //      C# -> GcpNativeProjectStatus? Status
            // GraphQL -> status: GcpNativeProjectStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new GcpNativeProjectStatus();
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

    } // class GcpNativeProject
    #endregion

    public static class ListGcpNativeProjectExtensions
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
            this List<GcpNativeProject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpNativeProject> list, 
            String parent = "")
        {
            var item = new GcpNativeProject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types