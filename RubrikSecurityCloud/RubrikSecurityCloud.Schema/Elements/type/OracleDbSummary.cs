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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CdmDataGuardType? DataGuardType
        // GraphQL -> dataGuardType: CdmDataGuardType (enum)
        if (this.DataGuardType != null) {
            s += ind + "dataGuardType\n" ;
        }
        //      C# -> List<System.String>? ArchiveLogDestinations
        // GraphQL -> archiveLogDestinations: [String!]! (scalar)
        if (this.ArchiveLogDestinations != null) {
            s += ind + "archiveLogDestinations\n" ;
        }
        //      C# -> System.String? DataGuardGroupId
        // GraphQL -> dataGuardGroupId: String (scalar)
        if (this.DataGuardGroupId != null) {
            s += ind + "dataGuardGroupId\n" ;
        }
        //      C# -> System.String? DataGuardGroupName
        // GraphQL -> dataGuardGroupName: String (scalar)
        if (this.DataGuardGroupName != null) {
            s += ind + "dataGuardGroupName\n" ;
        }
        //      C# -> System.String? DatabaseRole
        // GraphQL -> databaseRole: String (scalar)
        if (this.DatabaseRole != null) {
            s += ind + "databaseRole\n" ;
        }
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (this.DbUniqueName != null) {
            s += ind + "dbUniqueName\n" ;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            s += ind + "hasLogConfigFromSla\n" ;
        }
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (this.HostLogRetentionHours != null) {
            s += ind + "hostLogRetentionHours\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (this.IncludeBackupTaskInfo != null) {
            s += ind + "includeBackupTaskInfo\n" ;
        }
        //      C# -> System.Boolean? IsArchiveLogModeEnabled
        // GraphQL -> isArchiveLogModeEnabled: Boolean (scalar)
        if (this.IsArchiveLogModeEnabled != null) {
            s += ind + "isArchiveLogModeEnabled\n" ;
        }
        //      C# -> System.Boolean? IsDbLocalToTheCluster
        // GraphQL -> isDbLocalToTheCluster: Boolean (scalar)
        if (this.IsDbLocalToTheCluster != null) {
            s += ind + "isDbLocalToTheCluster\n" ;
        }
        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean (scalar)
        if (this.IsPrimary != null) {
            s += ind + "isPrimary\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime != null) {
            s += ind + "lastSnapshotTime\n" ;
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
        if (this.LogBackupFrequencyInMinutes != null) {
            s += ind + "logBackupFrequencyInMinutes\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int (scalar)
        if (this.NumInstances != null) {
            s += ind + "numInstances\n" ;
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (this.NumMissedSnapshot != null) {
            s += ind + "numMissedSnapshot\n" ;
        }
        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        if (this.NumTablespaces != null) {
            s += ind + "numTablespaces\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (this.RacId != null) {
            s += ind + "racId\n" ;
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (this.RacName != null) {
            s += ind + "racName\n" ;
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String (scalar)
        if (this.Sid != null) {
            s += ind + "sid\n" ;
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (this.StandaloneHostId != null) {
            s += ind + "standaloneHostId\n" ;
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (this.StandaloneHostName != null) {
            s += ind + "standaloneHostName\n" ;
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (this.CurrentBackupTaskInfo != null) {
            var fspec = this.CurrentBackupTaskInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "currentBackupTaskInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<DataGuardGroupMember>? DataGuardGroupMembers
        // GraphQL -> dataGuardGroupMembers: [DataGuardGroupMember!]! (type)
        if (this.DataGuardGroupMembers != null) {
            var fspec = this.DataGuardGroupMembers.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "dataGuardGroupMembers {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (this.InfraPath != null) {
            var fspec = this.InfraPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "infraPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<OracleInstanceProperties>? Instances
        // GraphQL -> instances: [OracleInstanceProperties!]! (type)
        if (this.Instances != null) {
            var fspec = this.Instances.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "instances {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdmDataGuardType? DataGuardType
        // GraphQL -> dataGuardType: CdmDataGuardType (enum)
        if (this.DataGuardType == null && ec.Includes("dataGuardType",true))
        {
            this.DataGuardType = new CdmDataGuardType();
        }
        //      C# -> List<System.String>? ArchiveLogDestinations
        // GraphQL -> archiveLogDestinations: [String!]! (scalar)
        if (this.ArchiveLogDestinations == null && ec.Includes("archiveLogDestinations",true))
        {
            this.ArchiveLogDestinations = new List<System.String>();
        }
        //      C# -> System.String? DataGuardGroupId
        // GraphQL -> dataGuardGroupId: String (scalar)
        if (this.DataGuardGroupId == null && ec.Includes("dataGuardGroupId",true))
        {
            this.DataGuardGroupId = "FETCH";
        }
        //      C# -> System.String? DataGuardGroupName
        // GraphQL -> dataGuardGroupName: String (scalar)
        if (this.DataGuardGroupName == null && ec.Includes("dataGuardGroupName",true))
        {
            this.DataGuardGroupName = "FETCH";
        }
        //      C# -> System.String? DatabaseRole
        // GraphQL -> databaseRole: String (scalar)
        if (this.DatabaseRole == null && ec.Includes("databaseRole",true))
        {
            this.DatabaseRole = "FETCH";
        }
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String (scalar)
        if (this.DbUniqueName == null && ec.Includes("dbUniqueName",true))
        {
            this.DbUniqueName = "FETCH";
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla == null && ec.Includes("hasLogConfigFromSla",true))
        {
            this.HasLogConfigFromSla = true;
        }
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        if (this.HostLogRetentionHours == null && ec.Includes("hostLogRetentionHours",true))
        {
            this.HostLogRetentionHours = Int32.MinValue;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (this.IncludeBackupTaskInfo == null && ec.Includes("includeBackupTaskInfo",true))
        {
            this.IncludeBackupTaskInfo = true;
        }
        //      C# -> System.Boolean? IsArchiveLogModeEnabled
        // GraphQL -> isArchiveLogModeEnabled: Boolean (scalar)
        if (this.IsArchiveLogModeEnabled == null && ec.Includes("isArchiveLogModeEnabled",true))
        {
            this.IsArchiveLogModeEnabled = true;
        }
        //      C# -> System.Boolean? IsDbLocalToTheCluster
        // GraphQL -> isDbLocalToTheCluster: Boolean (scalar)
        if (this.IsDbLocalToTheCluster == null && ec.Includes("isDbLocalToTheCluster",true))
        {
            this.IsDbLocalToTheCluster = true;
        }
        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean (scalar)
        if (this.IsPrimary == null && ec.Includes("isPrimary",true))
        {
            this.IsPrimary = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && ec.Includes("isRelic",true))
        {
            this.IsRelic = true;
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime == null && ec.Includes("lastSnapshotTime",true))
        {
            this.LastSnapshotTime = new DateTime();
        }
        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
        if (this.LogBackupFrequencyInMinutes == null && ec.Includes("logBackupFrequencyInMinutes",true))
        {
            this.LogBackupFrequencyInMinutes = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int (scalar)
        if (this.NumInstances == null && ec.Includes("numInstances",true))
        {
            this.NumInstances = Int32.MinValue;
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (this.NumMissedSnapshot == null && ec.Includes("numMissedSnapshot",true))
        {
            this.NumMissedSnapshot = Int32.MinValue;
        }
        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        if (this.NumTablespaces == null && ec.Includes("numTablespaces",true))
        {
            this.NumTablespaces = Int32.MinValue;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && ec.Includes("primaryClusterId",true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        if (this.RacId == null && ec.Includes("racId",true))
        {
            this.RacId = "FETCH";
        }
        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        if (this.RacName == null && ec.Includes("racName",true))
        {
            this.RacName = "FETCH";
        }
        //      C# -> System.String? Sid
        // GraphQL -> sid: String (scalar)
        if (this.Sid == null && ec.Includes("sid",true))
        {
            this.Sid = "FETCH";
        }
        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        if (this.StandaloneHostId == null && ec.Includes("standaloneHostId",true))
        {
            this.StandaloneHostId = "FETCH";
        }
        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        if (this.StandaloneHostName == null && ec.Includes("standaloneHostName",true))
        {
            this.StandaloneHostName = "FETCH";
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (this.CurrentBackupTaskInfo == null && ec.Includes("currentBackupTaskInfo",false))
        {
            this.CurrentBackupTaskInfo = new BackupTaskDiagnosticInfo();
            this.CurrentBackupTaskInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentBackupTaskInfo"));
        }
        //      C# -> List<DataGuardGroupMember>? DataGuardGroupMembers
        // GraphQL -> dataGuardGroupMembers: [DataGuardGroupMember!]! (type)
        if (this.DataGuardGroupMembers == null && ec.Includes("dataGuardGroupMembers",false))
        {
            this.DataGuardGroupMembers = new List<DataGuardGroupMember>();
            this.DataGuardGroupMembers.ApplyExploratoryFieldSpec(ec.NewChild("dataGuardGroupMembers"));
        }
        //      C# -> List<ManagedHierarchyObjectAncestor>? InfraPath
        // GraphQL -> infraPath: [ManagedHierarchyObjectAncestor!]! (type)
        if (this.InfraPath == null && ec.Includes("infraPath",false))
        {
            this.InfraPath = new List<ManagedHierarchyObjectAncestor>();
            this.InfraPath.ApplyExploratoryFieldSpec(ec.NewChild("infraPath"));
        }
        //      C# -> List<OracleInstanceProperties>? Instances
        // GraphQL -> instances: [OracleInstanceProperties!]! (type)
        if (this.Instances == null && ec.Includes("instances",false))
        {
            this.Instances = new List<OracleInstanceProperties>();
            this.Instances.ApplyExploratoryFieldSpec(ec.NewChild("instances"));
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable == null && ec.Includes("snappable",false))
        {
            this.Snappable = new CdmWorkload();
            this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
        }
    }


    #endregion

    } // class OracleDbSummary
    
    #endregion

    public static class ListOracleDbSummaryExtensions
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
            this List<OracleDbSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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