// OracleDbSummary.cs
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
    #region OracleDbSummary
    public class OracleDbSummary: BaseType
    {
        #region members

        //      C# -> CdmDataGuardType? DataGuardType
        // GraphQL -> dataGuardType: CdmDataGuardType (enum)
        [JsonProperty("dataGuardType")]
        public CdmDataGuardType? DataGuardType { get; set; }

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

        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        [JsonProperty("blackoutWindowStatus")]
        public BlackoutWindowStatus? BlackoutWindowStatus { get; set; }

        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        [JsonProperty("blackoutWindows")]
        public BlackoutWindows? BlackoutWindows { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleDbSummary";
    }

    public OracleDbSummary Set(
        CdmDataGuardType? DataGuardType = null,
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
        BlackoutWindowStatus? BlackoutWindowStatus = null,
        BlackoutWindows? BlackoutWindows = null,
        BackupTaskDiagnosticInfo? CurrentBackupTaskInfo = null,
        List<DataGuardGroupMember>? DataGuardGroupMembers = null,
        List<ManagedHierarchyObjectAncestor>? InfraPath = null,
        List<OracleInstanceProperties>? Instances = null,
        CdmWorkload? Snappable = null
    ) 
    {
        if ( DataGuardType != null ) {
            this.DataGuardType = DataGuardType;
        }
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
        if ( BlackoutWindowStatus != null ) {
            this.BlackoutWindowStatus = BlackoutWindowStatus;
        }
        if ( BlackoutWindows != null ) {
            this.BlackoutWindows = BlackoutWindows;
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CdmDataGuardType? DataGuardType
        // GraphQL -> dataGuardType: CdmDataGuardType (enum)
        if (this.DataGuardType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataGuardType\n" ;
            } else {
                s += ind + "dataGuardType\n" ;
            }
        }
        //      C# -> List<System.String>? ArchiveLogDestinations
        // GraphQL -> archiveLogDestinations: [String!]! (scalar)
        if (this.ArchiveLogDestinations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveLogDestinations\n" ;
            } else {
                s += ind + "archiveLogDestinations\n" ;
            }
        }
        //      C# -> System.String? DataGuardGroupId
        // GraphQL -> dataGuardGroupId: String (scalar)
        if (this.DataGuardGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataGuardGroupId\n" ;
            } else {
                s += ind + "dataGuardGroupId\n" ;
            }
        }
        //      C# -> System.String? DataGuardGroupName
        // GraphQL -> dataGuardGroupName: String (scalar)
        if (this.DataGuardGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataGuardGroupName\n" ;
            } else {
                s += ind + "dataGuardGroupName\n" ;
            }
        }
        //      C# -> System.String? DatabaseRole
        // GraphQL -> databaseRole: String (scalar)
        if (this.DatabaseRole != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseRole\n" ;
            } else {
                s += ind + "databaseRole\n" ;
            }
        }
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (this.DbUniqueName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbUniqueName\n" ;
            } else {
                s += ind + "dbUniqueName\n" ;
            }
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasLogConfigFromSla\n" ;
            } else {
                s += ind + "hasLogConfigFromSla\n" ;
            }
        }
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (this.HostLogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostLogRetentionHours\n" ;
            } else {
                s += ind + "hostLogRetentionHours\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (this.IncludeBackupTaskInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includeBackupTaskInfo\n" ;
            } else {
                s += ind + "includeBackupTaskInfo\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchiveLogModeEnabled
        // GraphQL -> isArchiveLogModeEnabled: Boolean (scalar)
        if (this.IsArchiveLogModeEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchiveLogModeEnabled\n" ;
            } else {
                s += ind + "isArchiveLogModeEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsDbLocalToTheCluster
        // GraphQL -> isDbLocalToTheCluster: Boolean (scalar)
        if (this.IsDbLocalToTheCluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDbLocalToTheCluster\n" ;
            } else {
                s += ind + "isDbLocalToTheCluster\n" ;
            }
        }
        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean (scalar)
        if (this.IsPrimary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPrimary\n" ;
            } else {
                s += ind + "isPrimary\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSnapshotTime\n" ;
            } else {
                s += ind + "lastSnapshotTime\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
        if (this.LogBackupFrequencyInMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequencyInMinutes\n" ;
            } else {
                s += ind + "logBackupFrequencyInMinutes\n" ;
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
        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int (scalar)
        if (this.NumInstances != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numInstances\n" ;
            } else {
                s += ind + "numInstances\n" ;
            }
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (this.NumMissedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMissedSnapshot\n" ;
            } else {
                s += ind + "numMissedSnapshot\n" ;
            }
        }
        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        if (this.NumTablespaces != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numTablespaces\n" ;
            } else {
                s += ind + "numTablespaces\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (this.RacId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "racId\n" ;
            } else {
                s += ind + "racId\n" ;
            }
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (this.RacName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "racName\n" ;
            } else {
                s += ind + "racName\n" ;
            }
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String (scalar)
        if (this.Sid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sid\n" ;
            } else {
                s += ind + "sid\n" ;
            }
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (this.StandaloneHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "standaloneHostId\n" ;
            } else {
                s += ind + "standaloneHostId\n" ;
            }
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (this.StandaloneHostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "standaloneHostName\n" ;
            } else {
                s += ind + "standaloneHostName\n" ;
            }
        }
        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        if (this.BlackoutWindowStatus != null) {
            var fspec = this.BlackoutWindowStatus.AsFieldSpec(conf.Child("blackoutWindowStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blackoutWindowStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        if (this.BlackoutWindows != null) {
            var fspec = this.BlackoutWindows.AsFieldSpec(conf.Child("blackoutWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blackoutWindows" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (this.CurrentBackupTaskInfo != null) {
            var fspec = this.CurrentBackupTaskInfo.AsFieldSpec(conf.Child("currentBackupTaskInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentBackupTaskInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataGuardGroupMember>? DataGuardGroupMembers
        // GraphQL -> dataGuardGroupMembers: [DataGuardGroupMember!]! (type)
        if (this.DataGuardGroupMembers != null) {
            var fspec = this.DataGuardGroupMembers.AsFieldSpec(conf.Child("dataGuardGroupMembers"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataGuardGroupMembers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (this.InfraPath != null) {
            var fspec = this.InfraPath.AsFieldSpec(conf.Child("infraPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "infraPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<OracleInstanceProperties>? Instances
        // GraphQL -> instances: [OracleInstanceProperties!]! (type)
        if (this.Instances != null) {
            var fspec = this.Instances.AsFieldSpec(conf.Child("instances"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "instances" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdmDataGuardType? DataGuardType
        // GraphQL -> dataGuardType: CdmDataGuardType (enum)
        if (ec.Includes("dataGuardType",true))
        {
            if(this.DataGuardType == null) {

                this.DataGuardType = new CdmDataGuardType();

            } else {


            }
        }
        else if (this.DataGuardType != null && ec.Excludes("dataGuardType",true))
        {
            this.DataGuardType = null;
        }
        //      C# -> List<System.String>? ArchiveLogDestinations
        // GraphQL -> archiveLogDestinations: [String!]! (scalar)
        if (ec.Includes("archiveLogDestinations",true))
        {
            if(this.ArchiveLogDestinations == null) {

                this.ArchiveLogDestinations = new List<System.String>();

            } else {


            }
        }
        else if (this.ArchiveLogDestinations != null && ec.Excludes("archiveLogDestinations",true))
        {
            this.ArchiveLogDestinations = null;
        }
        //      C# -> System.String? DataGuardGroupId
        // GraphQL -> dataGuardGroupId: String (scalar)
        if (ec.Includes("dataGuardGroupId",true))
        {
            if(this.DataGuardGroupId == null) {

                this.DataGuardGroupId = "FETCH";

            } else {


            }
        }
        else if (this.DataGuardGroupId != null && ec.Excludes("dataGuardGroupId",true))
        {
            this.DataGuardGroupId = null;
        }
        //      C# -> System.String? DataGuardGroupName
        // GraphQL -> dataGuardGroupName: String (scalar)
        if (ec.Includes("dataGuardGroupName",true))
        {
            if(this.DataGuardGroupName == null) {

                this.DataGuardGroupName = "FETCH";

            } else {


            }
        }
        else if (this.DataGuardGroupName != null && ec.Excludes("dataGuardGroupName",true))
        {
            this.DataGuardGroupName = null;
        }
        //      C# -> System.String? DatabaseRole
        // GraphQL -> databaseRole: String (scalar)
        if (ec.Includes("databaseRole",true))
        {
            if(this.DatabaseRole == null) {

                this.DatabaseRole = "FETCH";

            } else {


            }
        }
        else if (this.DatabaseRole != null && ec.Excludes("databaseRole",true))
        {
            this.DatabaseRole = null;
        }
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (ec.Includes("dbUniqueName",true))
        {
            if(this.DbUniqueName == null) {

                this.DbUniqueName = "FETCH";

            } else {


            }
        }
        else if (this.DbUniqueName != null && ec.Excludes("dbUniqueName",true))
        {
            this.DbUniqueName = null;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (ec.Includes("hasLogConfigFromSla",true))
        {
            if(this.HasLogConfigFromSla == null) {

                this.HasLogConfigFromSla = true;

            } else {


            }
        }
        else if (this.HasLogConfigFromSla != null && ec.Excludes("hasLogConfigFromSla",true))
        {
            this.HasLogConfigFromSla = null;
        }
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (ec.Includes("hostLogRetentionHours",true))
        {
            if(this.HostLogRetentionHours == null) {

                this.HostLogRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostLogRetentionHours != null && ec.Excludes("hostLogRetentionHours",true))
        {
            this.HostLogRetentionHours = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (ec.Includes("includeBackupTaskInfo",true))
        {
            if(this.IncludeBackupTaskInfo == null) {

                this.IncludeBackupTaskInfo = true;

            } else {


            }
        }
        else if (this.IncludeBackupTaskInfo != null && ec.Excludes("includeBackupTaskInfo",true))
        {
            this.IncludeBackupTaskInfo = null;
        }
        //      C# -> System.Boolean? IsArchiveLogModeEnabled
        // GraphQL -> isArchiveLogModeEnabled: Boolean (scalar)
        if (ec.Includes("isArchiveLogModeEnabled",true))
        {
            if(this.IsArchiveLogModeEnabled == null) {

                this.IsArchiveLogModeEnabled = true;

            } else {


            }
        }
        else if (this.IsArchiveLogModeEnabled != null && ec.Excludes("isArchiveLogModeEnabled",true))
        {
            this.IsArchiveLogModeEnabled = null;
        }
        //      C# -> System.Boolean? IsDbLocalToTheCluster
        // GraphQL -> isDbLocalToTheCluster: Boolean (scalar)
        if (ec.Includes("isDbLocalToTheCluster",true))
        {
            if(this.IsDbLocalToTheCluster == null) {

                this.IsDbLocalToTheCluster = true;

            } else {


            }
        }
        else if (this.IsDbLocalToTheCluster != null && ec.Excludes("isDbLocalToTheCluster",true))
        {
            this.IsDbLocalToTheCluster = null;
        }
        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean (scalar)
        if (ec.Includes("isPrimary",true))
        {
            if(this.IsPrimary == null) {

                this.IsPrimary = true;

            } else {


            }
        }
        else if (this.IsPrimary != null && ec.Excludes("isPrimary",true))
        {
            this.IsPrimary = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (ec.Includes("lastSnapshotTime",true))
        {
            if(this.LastSnapshotTime == null) {

                this.LastSnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSnapshotTime != null && ec.Excludes("lastSnapshotTime",true))
        {
            this.LastSnapshotTime = null;
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
        if (ec.Includes("logBackupFrequencyInMinutes",true))
        {
            if(this.LogBackupFrequencyInMinutes == null) {

                this.LogBackupFrequencyInMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupFrequencyInMinutes != null && ec.Excludes("logBackupFrequencyInMinutes",true))
        {
            this.LogBackupFrequencyInMinutes = null;
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
        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int (scalar)
        if (ec.Includes("numInstances",true))
        {
            if(this.NumInstances == null) {

                this.NumInstances = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumInstances != null && ec.Excludes("numInstances",true))
        {
            this.NumInstances = null;
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (ec.Includes("numMissedSnapshot",true))
        {
            if(this.NumMissedSnapshot == null) {

                this.NumMissedSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumMissedSnapshot != null && ec.Excludes("numMissedSnapshot",true))
        {
            this.NumMissedSnapshot = null;
        }
        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        if (ec.Includes("numTablespaces",true))
        {
            if(this.NumTablespaces == null) {

                this.NumTablespaces = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumTablespaces != null && ec.Excludes("numTablespaces",true))
        {
            this.NumTablespaces = null;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (ec.Includes("racId",true))
        {
            if(this.RacId == null) {

                this.RacId = "FETCH";

            } else {


            }
        }
        else if (this.RacId != null && ec.Excludes("racId",true))
        {
            this.RacId = null;
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (ec.Includes("racName",true))
        {
            if(this.RacName == null) {

                this.RacName = "FETCH";

            } else {


            }
        }
        else if (this.RacName != null && ec.Excludes("racName",true))
        {
            this.RacName = null;
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String (scalar)
        if (ec.Includes("sid",true))
        {
            if(this.Sid == null) {

                this.Sid = "FETCH";

            } else {


            }
        }
        else if (this.Sid != null && ec.Excludes("sid",true))
        {
            this.Sid = null;
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (ec.Includes("standaloneHostId",true))
        {
            if(this.StandaloneHostId == null) {

                this.StandaloneHostId = "FETCH";

            } else {


            }
        }
        else if (this.StandaloneHostId != null && ec.Excludes("standaloneHostId",true))
        {
            this.StandaloneHostId = null;
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (ec.Includes("standaloneHostName",true))
        {
            if(this.StandaloneHostName == null) {

                this.StandaloneHostName = "FETCH";

            } else {


            }
        }
        else if (this.StandaloneHostName != null && ec.Excludes("standaloneHostName",true))
        {
            this.StandaloneHostName = null;
        }
        //      C# -> BlackoutWindowStatus? BlackoutWindowStatus
        // GraphQL -> blackoutWindowStatus: BlackoutWindowStatus (type)
        if (ec.Includes("blackoutWindowStatus",false))
        {
            if(this.BlackoutWindowStatus == null) {

                this.BlackoutWindowStatus = new BlackoutWindowStatus();
                this.BlackoutWindowStatus.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowStatus"));

            } else {

                this.BlackoutWindowStatus.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindowStatus"));

            }
        }
        else if (this.BlackoutWindowStatus != null && ec.Excludes("blackoutWindowStatus",false))
        {
            this.BlackoutWindowStatus = null;
        }
        //      C# -> BlackoutWindows? BlackoutWindows
        // GraphQL -> blackoutWindows: BlackoutWindows (type)
        if (ec.Includes("blackoutWindows",false))
        {
            if(this.BlackoutWindows == null) {

                this.BlackoutWindows = new BlackoutWindows();
                this.BlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindows"));

            } else {

                this.BlackoutWindows.ApplyExploratoryFieldSpec(ec.NewChild("blackoutWindows"));

            }
        }
        else if (this.BlackoutWindows != null && ec.Excludes("blackoutWindows",false))
        {
            this.BlackoutWindows = null;
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (ec.Includes("currentBackupTaskInfo",false))
        {
            if(this.CurrentBackupTaskInfo == null) {

                this.CurrentBackupTaskInfo = new BackupTaskDiagnosticInfo();
                this.CurrentBackupTaskInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentBackupTaskInfo"));

            } else {

                this.CurrentBackupTaskInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentBackupTaskInfo"));

            }
        }
        else if (this.CurrentBackupTaskInfo != null && ec.Excludes("currentBackupTaskInfo",false))
        {
            this.CurrentBackupTaskInfo = null;
        }
        //      C# -> List<DataGuardGroupMember>? DataGuardGroupMembers
        // GraphQL -> dataGuardGroupMembers: [DataGuardGroupMember!]! (type)
        if (ec.Includes("dataGuardGroupMembers",false))
        {
            if(this.DataGuardGroupMembers == null) {

                this.DataGuardGroupMembers = new List<DataGuardGroupMember>();
                this.DataGuardGroupMembers.ApplyExploratoryFieldSpec(ec.NewChild("dataGuardGroupMembers"));

            } else {

                this.DataGuardGroupMembers.ApplyExploratoryFieldSpec(ec.NewChild("dataGuardGroupMembers"));

            }
        }
        else if (this.DataGuardGroupMembers != null && ec.Excludes("dataGuardGroupMembers",false))
        {
            this.DataGuardGroupMembers = null;
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (ec.Includes("infraPath",false))
        {
            if(this.InfraPath == null) {

                this.InfraPath = new List<ManagedHierarchyObjectAncestor>();
                this.InfraPath.ApplyExploratoryFieldSpec(ec.NewChild("infraPath"));

            } else {

                this.InfraPath.ApplyExploratoryFieldSpec(ec.NewChild("infraPath"));

            }
        }
        else if (this.InfraPath != null && ec.Excludes("infraPath",false))
        {
            this.InfraPath = null;
        }
        //      C# -> List<OracleInstanceProperties>? Instances
        // GraphQL -> instances: [OracleInstanceProperties!]! (type)
        if (ec.Includes("instances",false))
        {
            if(this.Instances == null) {

                this.Instances = new List<OracleInstanceProperties>();
                this.Instances.ApplyExploratoryFieldSpec(ec.NewChild("instances"));

            } else {

                this.Instances.ApplyExploratoryFieldSpec(ec.NewChild("instances"));

            }
        }
        else if (this.Instances != null && ec.Excludes("instances",false))
        {
            this.Instances = null;
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            } else {

                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
    }


    #endregion

    } // class OracleDbSummary
    
    #endregion

    public static class ListOracleDbSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<OracleDbSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleDbSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleDbSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleDbSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleDbSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types