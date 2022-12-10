// OracleDbSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:33.
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
    #region OracleDbSummary
    public class OracleDbSummary: IFragment
    {
        #region members
        //      C# -> List<System.String>? ArchiveLogDestinations
        // GraphQL -> archiveLogDestinations: [String!]! (scalar)
        [JsonProperty("archiveLogDestinations")]
        public List<System.String>? ArchiveLogDestinations { get; set; }

        //      C# -> System.String? DataGuardGroupId
        // GraphQL -> dataGuardGroupId: String (scalar)
        [JsonProperty("dataGuardGroupId")]
        public System.String? DataGuardGroupId { get; set; }

        //      C# -> System.String? DataGuardGroupName
        // GraphQL -> dataGuardGroupName: String (scalar)
        [JsonProperty("dataGuardGroupName")]
        public System.String? DataGuardGroupName { get; set; }

        //      C# -> System.String? DatabaseRole
        // GraphQL -> databaseRole: String (scalar)
        [JsonProperty("databaseRole")]
        public System.String? DatabaseRole { get; set; }

        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        [JsonProperty("dbUniqueName")]
        public System.String? DbUniqueName { get; set; }

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        [JsonProperty("includeBackupTaskInfo")]
        public System.Boolean? IncludeBackupTaskInfo { get; set; }

        //      C# -> System.Boolean? IsArchiveLogModeEnabled
        // GraphQL -> isArchiveLogModeEnabled: Boolean (scalar)
        [JsonProperty("isArchiveLogModeEnabled")]
        public System.Boolean? IsArchiveLogModeEnabled { get; set; }

        //      C# -> System.Boolean? IsDbLocalToTheCluster
        // GraphQL -> isDbLocalToTheCluster: Boolean (scalar)
        [JsonProperty("isDbLocalToTheCluster")]
        public System.Boolean? IsDbLocalToTheCluster { get; set; }

        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean (scalar)
        [JsonProperty("isPrimary")]
        public System.Boolean? IsPrimary { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        [JsonProperty("lastSnapshotTime")]
        public DateTime? LastSnapshotTime { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
        [JsonProperty("logBackupFrequencyInMinutes")]
        public System.Int32? LogBackupFrequencyInMinutes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int (scalar)
        [JsonProperty("numInstances")]
        public System.Int32? NumInstances { get; set; }

        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        [JsonProperty("numMissedSnapshot")]
        public System.Int32? NumMissedSnapshot { get; set; }

        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        [JsonProperty("numTablespaces")]
        public System.Int32? NumTablespaces { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        [JsonProperty("racId")]
        public System.String? RacId { get; set; }

        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        [JsonProperty("racName")]
        public System.String? RacName { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        [JsonProperty("standaloneHostId")]
        public System.String? StandaloneHostId { get; set; }

        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        [JsonProperty("standaloneHostName")]
        public System.String? StandaloneHostName { get; set; }

        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        [JsonProperty("currentBackupTaskInfo")]
        public BackupTaskDiagnosticInfo? CurrentBackupTaskInfo { get; set; }

        //      C# -> List<DataGuardGroupMember>? DataGuardGroupMembers
        // GraphQL -> dataGuardGroupMembers: [DataGuardGroupMember!]! (type)
        [JsonProperty("dataGuardGroupMembers")]
        public List<DataGuardGroupMember>? DataGuardGroupMembers { get; set; }

        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        [JsonProperty("infraPath")]
        public List<ManagedHierarchyObjectAncestor>? InfraPath { get; set; }

        //      C# -> List<OracleInstanceProperties>? Instances
        // GraphQL -> instances: [OracleInstanceProperties!]! (type)
        [JsonProperty("instances")]
        public List<OracleInstanceProperties>? Instances { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }

        //      C# -> CdmDataGuardType? DataGuardType
        // GraphQL -> dataGuardType: CdmDataGuardType (enum)
        [JsonProperty("dataGuardType")]
        public CdmDataGuardType? DataGuardType { get; set; }

        #endregion

    #region methods

    public OracleDbSummary Set(
        List<System.String>? ArchiveLogDestinations = null,
        System.String? DataGuardGroupId = null,
        System.String? DataGuardGroupName = null,
        System.String? DatabaseRole = null,
        System.String? DbUniqueName = null,
        System.Boolean? HasLogConfigFromSla = null,
        System.Int32? HostLogRetentionHours = null,
        System.String? Id = null,
        System.Boolean? IncludeBackupTaskInfo = null,
        System.Boolean? IsArchiveLogModeEnabled = null,
        System.Boolean? IsDbLocalToTheCluster = null,
        System.Boolean? IsPrimary = null,
        System.Boolean? IsRelic = null,
        DateTime? LastSnapshotTime = null,
        System.Int32? LogBackupFrequencyInMinutes = null,
        System.String? Name = null,
        System.Int32? NumInstances = null,
        System.Int32? NumMissedSnapshot = null,
        System.Int32? NumTablespaces = null,
        System.String? PrimaryClusterId = null,
        System.String? RacId = null,
        System.String? RacName = null,
        System.String? Sid = null,
        System.String? StandaloneHostId = null,
        System.String? StandaloneHostName = null,
        BackupTaskDiagnosticInfo? CurrentBackupTaskInfo = null,
        List<DataGuardGroupMember>? DataGuardGroupMembers = null,
        List<ManagedHierarchyObjectAncestor>? InfraPath = null,
        List<OracleInstanceProperties>? Instances = null,
        CdmWorkload? Snappable = null,
        CdmDataGuardType? DataGuardType = null
    ) 
    {
        if ( ArchiveLogDestinations != null ) {
            this.ArchiveLogDestinations = ArchiveLogDestinations;
        }
        if ( DataGuardGroupId != null ) {
            this.DataGuardGroupId = DataGuardGroupId;
        }
        if ( DataGuardGroupName != null ) {
            this.DataGuardGroupName = DataGuardGroupName;
        }
        if ( DatabaseRole != null ) {
            this.DatabaseRole = DatabaseRole;
        }
        if ( DbUniqueName != null ) {
            this.DbUniqueName = DbUniqueName;
        }
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IncludeBackupTaskInfo != null ) {
            this.IncludeBackupTaskInfo = IncludeBackupTaskInfo;
        }
        if ( IsArchiveLogModeEnabled != null ) {
            this.IsArchiveLogModeEnabled = IsArchiveLogModeEnabled;
        }
        if ( IsDbLocalToTheCluster != null ) {
            this.IsDbLocalToTheCluster = IsDbLocalToTheCluster;
        }
        if ( IsPrimary != null ) {
            this.IsPrimary = IsPrimary;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( LastSnapshotTime != null ) {
            this.LastSnapshotTime = LastSnapshotTime;
        }
        if ( LogBackupFrequencyInMinutes != null ) {
            this.LogBackupFrequencyInMinutes = LogBackupFrequencyInMinutes;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumInstances != null ) {
            this.NumInstances = NumInstances;
        }
        if ( NumMissedSnapshot != null ) {
            this.NumMissedSnapshot = NumMissedSnapshot;
        }
        if ( NumTablespaces != null ) {
            this.NumTablespaces = NumTablespaces;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( RacId != null ) {
            this.RacId = RacId;
        }
        if ( RacName != null ) {
            this.RacName = RacName;
        }
        if ( Sid != null ) {
            this.Sid = Sid;
        }
        if ( StandaloneHostId != null ) {
            this.StandaloneHostId = StandaloneHostId;
        }
        if ( StandaloneHostName != null ) {
            this.StandaloneHostName = StandaloneHostName;
        }
        if ( CurrentBackupTaskInfo != null ) {
            this.CurrentBackupTaskInfo = CurrentBackupTaskInfo;
        }
        if ( DataGuardGroupMembers != null ) {
            this.DataGuardGroupMembers = DataGuardGroupMembers;
        }
        if ( InfraPath != null ) {
            this.InfraPath = InfraPath;
        }
        if ( Instances != null ) {
            this.Instances = Instances;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
        }
        if ( DataGuardType != null ) {
            this.DataGuardType = DataGuardType;
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
            //      C# -> List<System.String>? ArchiveLogDestinations
            // GraphQL -> archiveLogDestinations: [String!]! (scalar)
            if (this.ArchiveLogDestinations != null)
            {
                 s += ind + "archiveLogDestinations\n";

            }
            //      C# -> System.String? DataGuardGroupId
            // GraphQL -> dataGuardGroupId: String (scalar)
            if (this.DataGuardGroupId != null)
            {
                 s += ind + "dataGuardGroupId\n";

            }
            //      C# -> System.String? DataGuardGroupName
            // GraphQL -> dataGuardGroupName: String (scalar)
            if (this.DataGuardGroupName != null)
            {
                 s += ind + "dataGuardGroupName\n";

            }
            //      C# -> System.String? DatabaseRole
            // GraphQL -> databaseRole: String (scalar)
            if (this.DatabaseRole != null)
            {
                 s += ind + "databaseRole\n";

            }
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String (scalar)
            if (this.DbUniqueName != null)
            {
                 s += ind + "dbUniqueName\n";

            }
            //      C# -> System.Boolean? HasLogConfigFromSla
            // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
            if (this.HasLogConfigFromSla != null)
            {
                 s += ind + "hasLogConfigFromSla\n";

            }
            //      C# -> System.Int32? HostLogRetentionHours
            // GraphQL -> hostLogRetentionHours: Int (scalar)
            if (this.HostLogRetentionHours != null)
            {
                 s += ind + "hostLogRetentionHours\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IncludeBackupTaskInfo
            // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
            if (this.IncludeBackupTaskInfo != null)
            {
                 s += ind + "includeBackupTaskInfo\n";

            }
            //      C# -> System.Boolean? IsArchiveLogModeEnabled
            // GraphQL -> isArchiveLogModeEnabled: Boolean (scalar)
            if (this.IsArchiveLogModeEnabled != null)
            {
                 s += ind + "isArchiveLogModeEnabled\n";

            }
            //      C# -> System.Boolean? IsDbLocalToTheCluster
            // GraphQL -> isDbLocalToTheCluster: Boolean (scalar)
            if (this.IsDbLocalToTheCluster != null)
            {
                 s += ind + "isDbLocalToTheCluster\n";

            }
            //      C# -> System.Boolean? IsPrimary
            // GraphQL -> isPrimary: Boolean (scalar)
            if (this.IsPrimary != null)
            {
                 s += ind + "isPrimary\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> DateTime? LastSnapshotTime
            // GraphQL -> lastSnapshotTime: DateTime (scalar)
            if (this.LastSnapshotTime != null)
            {
                 s += ind + "lastSnapshotTime\n";

            }
            //      C# -> System.Int32? LogBackupFrequencyInMinutes
            // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
            if (this.LogBackupFrequencyInMinutes != null)
            {
                 s += ind + "logBackupFrequencyInMinutes\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumInstances
            // GraphQL -> numInstances: Int (scalar)
            if (this.NumInstances != null)
            {
                 s += ind + "numInstances\n";

            }
            //      C# -> System.Int32? NumMissedSnapshot
            // GraphQL -> numMissedSnapshot: Int (scalar)
            if (this.NumMissedSnapshot != null)
            {
                 s += ind + "numMissedSnapshot\n";

            }
            //      C# -> System.Int32? NumTablespaces
            // GraphQL -> numTablespaces: Int! (scalar)
            if (this.NumTablespaces != null)
            {
                 s += ind + "numTablespaces\n";

            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId != null)
            {
                 s += ind + "primaryClusterId\n";

            }
            //      C# -> System.String? RacId
            // GraphQL -> racId: String (scalar)
            if (this.RacId != null)
            {
                 s += ind + "racId\n";

            }
            //      C# -> System.String? RacName
            // GraphQL -> racName: String (scalar)
            if (this.RacName != null)
            {
                 s += ind + "racName\n";

            }
            //      C# -> System.String? Sid
            // GraphQL -> sid: String (scalar)
            if (this.Sid != null)
            {
                 s += ind + "sid\n";

            }
            //      C# -> System.String? StandaloneHostId
            // GraphQL -> standaloneHostId: String (scalar)
            if (this.StandaloneHostId != null)
            {
                 s += ind + "standaloneHostId\n";

            }
            //      C# -> System.String? StandaloneHostName
            // GraphQL -> standaloneHostName: String (scalar)
            if (this.StandaloneHostName != null)
            {
                 s += ind + "standaloneHostName\n";

            }
            //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
            // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
            if (this.CurrentBackupTaskInfo != null)
            {
                 s += ind + "currentBackupTaskInfo\n";

                 s += ind + "{\n" + 
                 this.CurrentBackupTaskInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<DataGuardGroupMember>? DataGuardGroupMembers
            // GraphQL -> dataGuardGroupMembers: [DataGuardGroupMember!]! (type)
            if (this.DataGuardGroupMembers != null)
            {
                 s += ind + "dataGuardGroupMembers\n";

                 s += ind + "{\n" + 
                 this.DataGuardGroupMembers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
            // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
            if (this.InfraPath != null)
            {
                 s += ind + "infraPath\n";

                 s += ind + "{\n" + 
                 this.InfraPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<OracleInstanceProperties>? Instances
            // GraphQL -> instances: [OracleInstanceProperties!]! (type)
            if (this.Instances != null)
            {
                 s += ind + "instances\n";

                 s += ind + "{\n" + 
                 this.Instances.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmWorkload? Snappable
            // GraphQL -> snappable: CdmWorkload (type)
            if (this.Snappable != null)
            {
                 s += ind + "snappable\n";

                 s += ind + "{\n" + 
                 this.Snappable.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmDataGuardType? DataGuardType
            // GraphQL -> dataGuardType: CdmDataGuardType (enum)
            if (this.DataGuardType != null)
            {
                 s += ind + "dataGuardType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ArchiveLogDestinations
            // GraphQL -> archiveLogDestinations: [String!]! (scalar)
            if (this.ArchiveLogDestinations == null && Exploration.Includes(parent + ".archiveLogDestinations$"))
            {
                this.ArchiveLogDestinations = new List<System.String>();
            }
            //      C# -> System.String? DataGuardGroupId
            // GraphQL -> dataGuardGroupId: String (scalar)
            if (this.DataGuardGroupId == null && Exploration.Includes(parent + ".dataGuardGroupId$"))
            {
                this.DataGuardGroupId = new System.String("FETCH");
            }
            //      C# -> System.String? DataGuardGroupName
            // GraphQL -> dataGuardGroupName: String (scalar)
            if (this.DataGuardGroupName == null && Exploration.Includes(parent + ".dataGuardGroupName$"))
            {
                this.DataGuardGroupName = new System.String("FETCH");
            }
            //      C# -> System.String? DatabaseRole
            // GraphQL -> databaseRole: String (scalar)
            if (this.DatabaseRole == null && Exploration.Includes(parent + ".databaseRole$"))
            {
                this.DatabaseRole = new System.String("FETCH");
            }
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String (scalar)
            if (this.DbUniqueName == null && Exploration.Includes(parent + ".dbUniqueName$"))
            {
                this.DbUniqueName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasLogConfigFromSla
            // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
            if (this.HasLogConfigFromSla == null && Exploration.Includes(parent + ".hasLogConfigFromSla$"))
            {
                this.HasLogConfigFromSla = new System.Boolean();
            }
            //      C# -> System.Int32? HostLogRetentionHours
            // GraphQL -> hostLogRetentionHours: Int (scalar)
            if (this.HostLogRetentionHours == null && Exploration.Includes(parent + ".hostLogRetentionHours$"))
            {
                this.HostLogRetentionHours = new System.Int32();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IncludeBackupTaskInfo
            // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
            if (this.IncludeBackupTaskInfo == null && Exploration.Includes(parent + ".includeBackupTaskInfo$"))
            {
                this.IncludeBackupTaskInfo = new System.Boolean();
            }
            //      C# -> System.Boolean? IsArchiveLogModeEnabled
            // GraphQL -> isArchiveLogModeEnabled: Boolean (scalar)
            if (this.IsArchiveLogModeEnabled == null && Exploration.Includes(parent + ".isArchiveLogModeEnabled$"))
            {
                this.IsArchiveLogModeEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsDbLocalToTheCluster
            // GraphQL -> isDbLocalToTheCluster: Boolean (scalar)
            if (this.IsDbLocalToTheCluster == null && Exploration.Includes(parent + ".isDbLocalToTheCluster$"))
            {
                this.IsDbLocalToTheCluster = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPrimary
            // GraphQL -> isPrimary: Boolean (scalar)
            if (this.IsPrimary == null && Exploration.Includes(parent + ".isPrimary$"))
            {
                this.IsPrimary = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> DateTime? LastSnapshotTime
            // GraphQL -> lastSnapshotTime: DateTime (scalar)
            if (this.LastSnapshotTime == null && Exploration.Includes(parent + ".lastSnapshotTime$"))
            {
                this.LastSnapshotTime = new DateTime();
            }
            //      C# -> System.Int32? LogBackupFrequencyInMinutes
            // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
            if (this.LogBackupFrequencyInMinutes == null && Exploration.Includes(parent + ".logBackupFrequencyInMinutes$"))
            {
                this.LogBackupFrequencyInMinutes = new System.Int32();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumInstances
            // GraphQL -> numInstances: Int (scalar)
            if (this.NumInstances == null && Exploration.Includes(parent + ".numInstances$"))
            {
                this.NumInstances = new System.Int32();
            }
            //      C# -> System.Int32? NumMissedSnapshot
            // GraphQL -> numMissedSnapshot: Int (scalar)
            if (this.NumMissedSnapshot == null && Exploration.Includes(parent + ".numMissedSnapshot$"))
            {
                this.NumMissedSnapshot = new System.Int32();
            }
            //      C# -> System.Int32? NumTablespaces
            // GraphQL -> numTablespaces: Int! (scalar)
            if (this.NumTablespaces == null && Exploration.Includes(parent + ".numTablespaces$"))
            {
                this.NumTablespaces = new System.Int32();
            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId$"))
            {
                this.PrimaryClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? RacId
            // GraphQL -> racId: String (scalar)
            if (this.RacId == null && Exploration.Includes(parent + ".racId$"))
            {
                this.RacId = new System.String("FETCH");
            }
            //      C# -> System.String? RacName
            // GraphQL -> racName: String (scalar)
            if (this.RacName == null && Exploration.Includes(parent + ".racName$"))
            {
                this.RacName = new System.String("FETCH");
            }
            //      C# -> System.String? Sid
            // GraphQL -> sid: String (scalar)
            if (this.Sid == null && Exploration.Includes(parent + ".sid$"))
            {
                this.Sid = new System.String("FETCH");
            }
            //      C# -> System.String? StandaloneHostId
            // GraphQL -> standaloneHostId: String (scalar)
            if (this.StandaloneHostId == null && Exploration.Includes(parent + ".standaloneHostId$"))
            {
                this.StandaloneHostId = new System.String("FETCH");
            }
            //      C# -> System.String? StandaloneHostName
            // GraphQL -> standaloneHostName: String (scalar)
            if (this.StandaloneHostName == null && Exploration.Includes(parent + ".standaloneHostName$"))
            {
                this.StandaloneHostName = new System.String("FETCH");
            }
            //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
            // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
            if (this.CurrentBackupTaskInfo == null && Exploration.Includes(parent + ".currentBackupTaskInfo"))
            {
                this.CurrentBackupTaskInfo = new BackupTaskDiagnosticInfo();
                this.CurrentBackupTaskInfo.ApplyExploratoryFragment(parent + ".currentBackupTaskInfo");
            }
            //      C# -> List<DataGuardGroupMember>? DataGuardGroupMembers
            // GraphQL -> dataGuardGroupMembers: [DataGuardGroupMember!]! (type)
            if (this.DataGuardGroupMembers == null && Exploration.Includes(parent + ".dataGuardGroupMembers"))
            {
                this.DataGuardGroupMembers = new List<DataGuardGroupMember>();
                this.DataGuardGroupMembers.ApplyExploratoryFragment(parent + ".dataGuardGroupMembers");
            }
            //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
            // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
            if (this.InfraPath == null && Exploration.Includes(parent + ".infraPath"))
            {
                this.InfraPath = new List<ManagedHierarchyObjectAncestor>();
                this.InfraPath.ApplyExploratoryFragment(parent + ".infraPath");
            }
            //      C# -> List<OracleInstanceProperties>? Instances
            // GraphQL -> instances: [OracleInstanceProperties!]! (type)
            if (this.Instances == null && Exploration.Includes(parent + ".instances"))
            {
                this.Instances = new List<OracleInstanceProperties>();
                this.Instances.ApplyExploratoryFragment(parent + ".instances");
            }
            //      C# -> CdmWorkload? Snappable
            // GraphQL -> snappable: CdmWorkload (type)
            if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
            {
                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFragment(parent + ".snappable");
            }
            //      C# -> CdmDataGuardType? DataGuardType
            // GraphQL -> dataGuardType: CdmDataGuardType (enum)
            if (this.DataGuardType == null && Exploration.Includes(parent + ".dataGuardType$"))
            {
                this.DataGuardType = new CdmDataGuardType();
            }
        }


    #endregion

    } // class OracleDbSummary
    #endregion

    public static class ListOracleDbSummaryExtensions
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
            this List<OracleDbSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleDbSummary> list, 
            String parent = "")
        {
            var item = new OracleDbSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types