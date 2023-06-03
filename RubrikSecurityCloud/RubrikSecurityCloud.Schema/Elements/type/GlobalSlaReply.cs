// GlobalSlaReply.cs
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
    #region GlobalSlaReply
 
    public class GlobalSlaReply: BaseType, SlaDomain, TaskSummaryGroupByInfo
    {
        #region members

        //      C# -> List<SlaObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [SlaObjectType!]! (enum)
        [JsonProperty("objectTypes")]
        public List<SlaObjectType>? ObjectTypes { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        [JsonProperty("isDefault")]
        public System.Boolean? IsDefault { get; set; }

        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        [JsonProperty("isRetentionLockedSla")]
        public System.Boolean? IsRetentionLockedSla { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OwnerOrgName
        // GraphQL -> ownerOrgName: String! (scalar)
        [JsonProperty("ownerOrgName")]
        public System.String? OwnerOrgName { get; set; }

        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        [JsonProperty("protectedObjectCount")]
        public System.Int32? ProtectedObjectCount { get; set; }

        //      C# -> DateTime? SnapshotScheduleLastUpdatedAt
        // GraphQL -> snapshotScheduleLastUpdatedAt: DateTime (scalar)
        [JsonProperty("snapshotScheduleLastUpdatedAt")]
        public DateTime? SnapshotScheduleLastUpdatedAt { get; set; }

        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        [JsonProperty("stateVersion")]
        public System.Int64? StateVersion { get; set; }

        //      C# -> System.String? UiColor
        // GraphQL -> uiColor: String! (scalar)
        [JsonProperty("uiColor")]
        public System.String? UiColor { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<SlaAssociatedOrganization>? AllOrgsHavingAccess
        // GraphQL -> allOrgsHavingAccess: [SlaAssociatedOrganization!]! (type)
        [JsonProperty("allOrgsHavingAccess")]
        public List<SlaAssociatedOrganization>? AllOrgsHavingAccess { get; set; }

        //      C# -> List<Org>? AllOrgsWithAccess
        // GraphQL -> allOrgsWithAccess: [Org!]! (type)
        [JsonProperty("allOrgsWithAccess")]
        public List<Org>? AllOrgsWithAccess { get; set; }

        //      C# -> ArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ArchivalSpec (type)
        [JsonProperty("archivalSpec")]
        public ArchivalSpec? ArchivalSpec { get; set; }

        //      C# -> List<ArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpec!]! (type)
        [JsonProperty("archivalSpecs")]
        public List<ArchivalSpec>? ArchivalSpecs { get; set; }

        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        [JsonProperty("backupWindows")]
        public List<BackupWindow>? BackupWindows { get; set; }

        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        [JsonProperty("baseFrequency")]
        public Duration? BaseFrequency { get; set; }

        //      C# -> List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap
        // GraphQL -> clusterToSyncStatusMap: [GlobalSlaSyncStatus!]! (type)
        [JsonProperty("clusterToSyncStatusMap")]
        public List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap { get; set; }

        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        [JsonProperty("firstFullBackupWindows")]
        public List<BackupWindow>? FirstFullBackupWindows { get; set; }

        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        [JsonProperty("localRetentionLimit")]
        public Duration? LocalRetentionLimit { get; set; }

        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        [JsonProperty("logConfig")]
        public LogConfigResult? LogConfig { get; set; }

        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        [JsonProperty("objectSpecificConfigs")]
        public ObjectSpecificConfigs? ObjectSpecificConfigs { get; set; }

        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        [JsonProperty("ownerOrg")]
        public SlaAssociatedOrganization? OwnerOrg { get; set; }

        //      C# -> PausedClustersInfo? PausedClustersInfo
        // GraphQL -> pausedClustersInfo: PausedClustersInfo (type)
        [JsonProperty("pausedClustersInfo")]
        public PausedClustersInfo? PausedClustersInfo { get; set; }

        //      C# -> ReplicationSpec? ReplicationSpec
        // GraphQL -> replicationSpec: ReplicationSpec (type)
        [JsonProperty("replicationSpec")]
        public ReplicationSpec? ReplicationSpec { get; set; }

        //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
        [JsonProperty("replicationSpecsV2")]
        public List<ReplicationSpecV2>? ReplicationSpecsV2 { get; set; }

        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        [JsonProperty("snapshotSchedule")]
        public SnapshotSchedule? SnapshotSchedule { get; set; }

        //      C# -> SlaUpgradeInfo? UpgradeInfo
        // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
        [JsonProperty("upgradeInfo")]
        public SlaUpgradeInfo? UpgradeInfo { get; set; }


        #endregion

    #region methods

    public GlobalSlaReply Set(
        List<SlaObjectType>? ObjectTypes = null,
        System.String? ClusterUuid = null,
        System.String? Description = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsDefault = null,
        System.Boolean? IsRetentionLockedSla = null,
        System.String? Name = null,
        System.String? OwnerOrgName = null,
        System.Int32? ProtectedObjectCount = null,
        DateTime? SnapshotScheduleLastUpdatedAt = null,
        System.Int64? StateVersion = null,
        System.String? UiColor = null,
        System.String? Version = null,
        List<SlaAssociatedOrganization>? AllOrgsHavingAccess = null,
        List<Org>? AllOrgsWithAccess = null,
        ArchivalSpec? ArchivalSpec = null,
        List<ArchivalSpec>? ArchivalSpecs = null,
        List<BackupWindow>? BackupWindows = null,
        Duration? BaseFrequency = null,
        List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap = null,
        List<BackupWindow>? FirstFullBackupWindows = null,
        Duration? LocalRetentionLimit = null,
        LogConfigResult? LogConfig = null,
        ObjectSpecificConfigs? ObjectSpecificConfigs = null,
        SlaAssociatedOrganization? OwnerOrg = null,
        PausedClustersInfo? PausedClustersInfo = null,
        ReplicationSpec? ReplicationSpec = null,
        List<ReplicationSpecV2>? ReplicationSpecsV2 = null,
        SnapshotSchedule? SnapshotSchedule = null,
        SlaUpgradeInfo? UpgradeInfo = null
    ) 
    {
        if ( ObjectTypes != null ) {
            this.ObjectTypes = ObjectTypes;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsDefault != null ) {
            this.IsDefault = IsDefault;
        }
        if ( IsRetentionLockedSla != null ) {
            this.IsRetentionLockedSla = IsRetentionLockedSla;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OwnerOrgName != null ) {
            this.OwnerOrgName = OwnerOrgName;
        }
        if ( ProtectedObjectCount != null ) {
            this.ProtectedObjectCount = ProtectedObjectCount;
        }
        if ( SnapshotScheduleLastUpdatedAt != null ) {
            this.SnapshotScheduleLastUpdatedAt = SnapshotScheduleLastUpdatedAt;
        }
        if ( StateVersion != null ) {
            this.StateVersion = StateVersion;
        }
        if ( UiColor != null ) {
            this.UiColor = UiColor;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( AllOrgsHavingAccess != null ) {
            this.AllOrgsHavingAccess = AllOrgsHavingAccess;
        }
        if ( AllOrgsWithAccess != null ) {
            this.AllOrgsWithAccess = AllOrgsWithAccess;
        }
        if ( ArchivalSpec != null ) {
            this.ArchivalSpec = ArchivalSpec;
        }
        if ( ArchivalSpecs != null ) {
            this.ArchivalSpecs = ArchivalSpecs;
        }
        if ( BackupWindows != null ) {
            this.BackupWindows = BackupWindows;
        }
        if ( BaseFrequency != null ) {
            this.BaseFrequency = BaseFrequency;
        }
        if ( ClusterToSyncStatusMap != null ) {
            this.ClusterToSyncStatusMap = ClusterToSyncStatusMap;
        }
        if ( FirstFullBackupWindows != null ) {
            this.FirstFullBackupWindows = FirstFullBackupWindows;
        }
        if ( LocalRetentionLimit != null ) {
            this.LocalRetentionLimit = LocalRetentionLimit;
        }
        if ( LogConfig != null ) {
            this.LogConfig = LogConfig;
        }
        if ( ObjectSpecificConfigs != null ) {
            this.ObjectSpecificConfigs = ObjectSpecificConfigs;
        }
        if ( OwnerOrg != null ) {
            this.OwnerOrg = OwnerOrg;
        }
        if ( PausedClustersInfo != null ) {
            this.PausedClustersInfo = PausedClustersInfo;
        }
        if ( ReplicationSpec != null ) {
            this.ReplicationSpec = ReplicationSpec;
        }
        if ( ReplicationSpecsV2 != null ) {
            this.ReplicationSpecsV2 = ReplicationSpecsV2;
        }
        if ( SnapshotSchedule != null ) {
            this.SnapshotSchedule = SnapshotSchedule;
        }
        if ( UpgradeInfo != null ) {
            this.UpgradeInfo = UpgradeInfo;
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
        //      C# -> List<SlaObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [SlaObjectType!]! (enum)
        if (this.ObjectTypes != null) {
            s += ind + "objectTypes\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (this.IsDefault != null) {
            s += ind + "isDefault\n" ;
        }
        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        if (this.IsRetentionLockedSla != null) {
            s += ind + "isRetentionLockedSla\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OwnerOrgName
        // GraphQL -> ownerOrgName: String! (scalar)
        if (this.OwnerOrgName != null) {
            s += ind + "ownerOrgName\n" ;
        }
        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        if (this.ProtectedObjectCount != null) {
            s += ind + "protectedObjectCount\n" ;
        }
        //      C# -> DateTime? SnapshotScheduleLastUpdatedAt
        // GraphQL -> snapshotScheduleLastUpdatedAt: DateTime (scalar)
        if (this.SnapshotScheduleLastUpdatedAt != null) {
            s += ind + "snapshotScheduleLastUpdatedAt\n" ;
        }
        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        if (this.StateVersion != null) {
            s += ind + "stateVersion\n" ;
        }
        //      C# -> System.String? UiColor
        // GraphQL -> uiColor: String! (scalar)
        if (this.UiColor != null) {
            s += ind + "uiColor\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> List<SlaAssociatedOrganization>? AllOrgsHavingAccess
        // GraphQL -> allOrgsHavingAccess: [SlaAssociatedOrganization!]! (type)
        if (this.AllOrgsHavingAccess != null) {
            s += ind + "allOrgsHavingAccess {\n" + this.AllOrgsHavingAccess.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<Org>? AllOrgsWithAccess
        // GraphQL -> allOrgsWithAccess: [Org!]! (type)
        if (this.AllOrgsWithAccess != null) {
            s += ind + "allOrgsWithAccess {\n" + this.AllOrgsWithAccess.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ArchivalSpec (type)
        if (this.ArchivalSpec != null) {
            s += ind + "archivalSpec {\n" + this.ArchivalSpec.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpec!]! (type)
        if (this.ArchivalSpecs != null) {
            s += ind + "archivalSpecs {\n" + this.ArchivalSpecs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (this.BackupWindows != null) {
            s += ind + "backupWindows {\n" + this.BackupWindows.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        if (this.BaseFrequency != null) {
            s += ind + "baseFrequency {\n" + this.BaseFrequency.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap
        // GraphQL -> clusterToSyncStatusMap: [GlobalSlaSyncStatus!]! (type)
        if (this.ClusterToSyncStatusMap != null) {
            s += ind + "clusterToSyncStatusMap {\n" + this.ClusterToSyncStatusMap.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (this.FirstFullBackupWindows != null) {
            s += ind + "firstFullBackupWindows {\n" + this.FirstFullBackupWindows.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        if (this.LocalRetentionLimit != null) {
            s += ind + "localRetentionLimit {\n" + this.LocalRetentionLimit.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (this.LogConfig != null) {
            s += ind + "logConfig {\n" + this.LogConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (this.ObjectSpecificConfigs != null) {
            s += ind + "objectSpecificConfigs {\n" + this.ObjectSpecificConfigs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        if (this.OwnerOrg != null) {
            s += ind + "ownerOrg {\n" + this.OwnerOrg.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PausedClustersInfo? PausedClustersInfo
        // GraphQL -> pausedClustersInfo: PausedClustersInfo (type)
        if (this.PausedClustersInfo != null) {
            s += ind + "pausedClustersInfo {\n" + this.PausedClustersInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ReplicationSpec? ReplicationSpec
        // GraphQL -> replicationSpec: ReplicationSpec (type)
        if (this.ReplicationSpec != null) {
            s += ind + "replicationSpec {\n" + this.ReplicationSpec.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
        if (this.ReplicationSpecsV2 != null) {
            s += ind + "replicationSpecsV2 {\n" + this.ReplicationSpecsV2.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (this.SnapshotSchedule != null) {
            s += ind + "snapshotSchedule {\n" + this.SnapshotSchedule.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaUpgradeInfo? UpgradeInfo
        // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
        if (this.UpgradeInfo != null) {
            s += ind + "upgradeInfo {\n" + this.UpgradeInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<SlaObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [SlaObjectType!]! (enum)
        if (this.ObjectTypes == null && Exploration.Includes(parent + ".objectTypes", true))
        {
            this.ObjectTypes = new List<SlaObjectType>();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (this.IsDefault == null && Exploration.Includes(parent + ".isDefault", true))
        {
            this.IsDefault = true;
        }
        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        if (this.IsRetentionLockedSla == null && Exploration.Includes(parent + ".isRetentionLockedSla", true))
        {
            this.IsRetentionLockedSla = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.String? OwnerOrgName
        // GraphQL -> ownerOrgName: String! (scalar)
        if (this.OwnerOrgName == null && Exploration.Includes(parent + ".ownerOrgName", true))
        {
            this.OwnerOrgName = new System.String("FETCH");
        }
        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        if (this.ProtectedObjectCount == null && Exploration.Includes(parent + ".protectedObjectCount", true))
        {
            this.ProtectedObjectCount = new System.Int32();
        }
        //      C# -> DateTime? SnapshotScheduleLastUpdatedAt
        // GraphQL -> snapshotScheduleLastUpdatedAt: DateTime (scalar)
        if (this.SnapshotScheduleLastUpdatedAt == null && Exploration.Includes(parent + ".snapshotScheduleLastUpdatedAt", true))
        {
            this.SnapshotScheduleLastUpdatedAt = new DateTime();
        }
        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        if (this.StateVersion == null && Exploration.Includes(parent + ".stateVersion", true))
        {
            this.StateVersion = new System.Int64();
        }
        //      C# -> System.String? UiColor
        // GraphQL -> uiColor: String! (scalar)
        if (this.UiColor == null && Exploration.Includes(parent + ".uiColor", true))
        {
            this.UiColor = new System.String("FETCH");
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.String("FETCH");
        }
        //      C# -> List<SlaAssociatedOrganization>? AllOrgsHavingAccess
        // GraphQL -> allOrgsHavingAccess: [SlaAssociatedOrganization!]! (type)
        if (this.AllOrgsHavingAccess == null && Exploration.Includes(parent + ".allOrgsHavingAccess"))
        {
            this.AllOrgsHavingAccess = new List<SlaAssociatedOrganization>();
            this.AllOrgsHavingAccess.ApplyExploratoryFieldSpec(parent + ".allOrgsHavingAccess");
        }
        //      C# -> List<Org>? AllOrgsWithAccess
        // GraphQL -> allOrgsWithAccess: [Org!]! (type)
        if (this.AllOrgsWithAccess == null && Exploration.Includes(parent + ".allOrgsWithAccess"))
        {
            this.AllOrgsWithAccess = new List<Org>();
            this.AllOrgsWithAccess.ApplyExploratoryFieldSpec(parent + ".allOrgsWithAccess");
        }
        //      C# -> ArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ArchivalSpec (type)
        if (this.ArchivalSpec == null && Exploration.Includes(parent + ".archivalSpec"))
        {
            this.ArchivalSpec = new ArchivalSpec();
            this.ArchivalSpec.ApplyExploratoryFieldSpec(parent + ".archivalSpec");
        }
        //      C# -> List<ArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpec!]! (type)
        if (this.ArchivalSpecs == null && Exploration.Includes(parent + ".archivalSpecs"))
        {
            this.ArchivalSpecs = new List<ArchivalSpec>();
            this.ArchivalSpecs.ApplyExploratoryFieldSpec(parent + ".archivalSpecs");
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (this.BackupWindows == null && Exploration.Includes(parent + ".backupWindows"))
        {
            this.BackupWindows = new List<BackupWindow>();
            this.BackupWindows.ApplyExploratoryFieldSpec(parent + ".backupWindows");
        }
        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        if (this.BaseFrequency == null && Exploration.Includes(parent + ".baseFrequency"))
        {
            this.BaseFrequency = new Duration();
            this.BaseFrequency.ApplyExploratoryFieldSpec(parent + ".baseFrequency");
        }
        //      C# -> List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap
        // GraphQL -> clusterToSyncStatusMap: [GlobalSlaSyncStatus!]! (type)
        if (this.ClusterToSyncStatusMap == null && Exploration.Includes(parent + ".clusterToSyncStatusMap"))
        {
            this.ClusterToSyncStatusMap = new List<GlobalSlaSyncStatus>();
            this.ClusterToSyncStatusMap.ApplyExploratoryFieldSpec(parent + ".clusterToSyncStatusMap");
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (this.FirstFullBackupWindows == null && Exploration.Includes(parent + ".firstFullBackupWindows"))
        {
            this.FirstFullBackupWindows = new List<BackupWindow>();
            this.FirstFullBackupWindows.ApplyExploratoryFieldSpec(parent + ".firstFullBackupWindows");
        }
        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        if (this.LocalRetentionLimit == null && Exploration.Includes(parent + ".localRetentionLimit"))
        {
            this.LocalRetentionLimit = new Duration();
            this.LocalRetentionLimit.ApplyExploratoryFieldSpec(parent + ".localRetentionLimit");
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (this.LogConfig == null && Exploration.Includes(parent + ".logConfig"))
        {
            this.LogConfig = new LogConfigResult();
            this.LogConfig.ApplyExploratoryFieldSpec(parent + ".logConfig");
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (this.ObjectSpecificConfigs == null && Exploration.Includes(parent + ".objectSpecificConfigs"))
        {
            this.ObjectSpecificConfigs = new ObjectSpecificConfigs();
            this.ObjectSpecificConfigs.ApplyExploratoryFieldSpec(parent + ".objectSpecificConfigs");
        }
        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        if (this.OwnerOrg == null && Exploration.Includes(parent + ".ownerOrg"))
        {
            this.OwnerOrg = new SlaAssociatedOrganization();
            this.OwnerOrg.ApplyExploratoryFieldSpec(parent + ".ownerOrg");
        }
        //      C# -> PausedClustersInfo? PausedClustersInfo
        // GraphQL -> pausedClustersInfo: PausedClustersInfo (type)
        if (this.PausedClustersInfo == null && Exploration.Includes(parent + ".pausedClustersInfo"))
        {
            this.PausedClustersInfo = new PausedClustersInfo();
            this.PausedClustersInfo.ApplyExploratoryFieldSpec(parent + ".pausedClustersInfo");
        }
        //      C# -> ReplicationSpec? ReplicationSpec
        // GraphQL -> replicationSpec: ReplicationSpec (type)
        if (this.ReplicationSpec == null && Exploration.Includes(parent + ".replicationSpec"))
        {
            this.ReplicationSpec = new ReplicationSpec();
            this.ReplicationSpec.ApplyExploratoryFieldSpec(parent + ".replicationSpec");
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
        if (this.ReplicationSpecsV2 == null && Exploration.Includes(parent + ".replicationSpecsV2"))
        {
            this.ReplicationSpecsV2 = new List<ReplicationSpecV2>();
            this.ReplicationSpecsV2.ApplyExploratoryFieldSpec(parent + ".replicationSpecsV2");
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (this.SnapshotSchedule == null && Exploration.Includes(parent + ".snapshotSchedule"))
        {
            this.SnapshotSchedule = new SnapshotSchedule();
            this.SnapshotSchedule.ApplyExploratoryFieldSpec(parent + ".snapshotSchedule");
        }
        //      C# -> SlaUpgradeInfo? UpgradeInfo
        // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
        if (this.UpgradeInfo == null && Exploration.Includes(parent + ".upgradeInfo"))
        {
            this.UpgradeInfo = new SlaUpgradeInfo();
            this.UpgradeInfo.ApplyExploratoryFieldSpec(parent + ".upgradeInfo");
        }
    }


    #endregion

    } // class GlobalSlaReply
    
    #endregion

    public static class ListGlobalSlaReplyExtensions
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
            this List<GlobalSlaReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GlobalSlaReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalSlaReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types