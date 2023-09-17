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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region GlobalSlaReply
 
    public class GlobalSlaReply: BaseType, SlaDomain
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

    public override string GetGqlTypeName() {
        return "GlobalSlaReply";
    }

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
            var fspec = this.AllOrgsHavingAccess.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgsHavingAccess {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgsWithAccess
        // GraphQL -> allOrgsWithAccess: [Org!]! (type)
        if (this.AllOrgsWithAccess != null) {
            var fspec = this.AllOrgsWithAccess.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgsWithAccess {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ArchivalSpec (type)
        if (this.ArchivalSpec != null) {
            var fspec = this.ArchivalSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpec!]! (type)
        if (this.ArchivalSpecs != null) {
            var fspec = this.ArchivalSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (this.BackupWindows != null) {
            var fspec = this.BackupWindows.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "backupWindows {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        if (this.BaseFrequency != null) {
            var fspec = this.BaseFrequency.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "baseFrequency {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap
        // GraphQL -> clusterToSyncStatusMap: [GlobalSlaSyncStatus!]! (type)
        if (this.ClusterToSyncStatusMap != null) {
            var fspec = this.ClusterToSyncStatusMap.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterToSyncStatusMap {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (this.FirstFullBackupWindows != null) {
            var fspec = this.FirstFullBackupWindows.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "firstFullBackupWindows {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        if (this.LocalRetentionLimit != null) {
            var fspec = this.LocalRetentionLimit.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "localRetentionLimit {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (this.LogConfig != null) {
            var fspec = this.LogConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (this.ObjectSpecificConfigs != null) {
            var fspec = this.ObjectSpecificConfigs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objectSpecificConfigs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        if (this.OwnerOrg != null) {
            var fspec = this.OwnerOrg.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ownerOrg {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PausedClustersInfo? PausedClustersInfo
        // GraphQL -> pausedClustersInfo: PausedClustersInfo (type)
        if (this.PausedClustersInfo != null) {
            var fspec = this.PausedClustersInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pausedClustersInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ReplicationSpec? ReplicationSpec
        // GraphQL -> replicationSpec: ReplicationSpec (type)
        if (this.ReplicationSpec != null) {
            var fspec = this.ReplicationSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
        if (this.ReplicationSpecsV2 != null) {
            var fspec = this.ReplicationSpecsV2.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationSpecsV2 {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (this.SnapshotSchedule != null) {
            var fspec = this.SnapshotSchedule.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotSchedule {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaUpgradeInfo? UpgradeInfo
        // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
        if (this.UpgradeInfo != null) {
            var fspec = this.UpgradeInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "upgradeInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [SlaObjectType!]! (enum)
        if (this.ObjectTypes == null && ec.Includes("objectTypes",true))
        {
            this.ObjectTypes = new List<SlaObjectType>();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && ec.Includes("isArchived",true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (this.IsDefault == null && ec.Includes("isDefault",true))
        {
            this.IsDefault = true;
        }
        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        if (this.IsRetentionLockedSla == null && ec.Includes("isRetentionLockedSla",true))
        {
            this.IsRetentionLockedSla = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OwnerOrgName
        // GraphQL -> ownerOrgName: String! (scalar)
        if (this.OwnerOrgName == null && ec.Includes("ownerOrgName",true))
        {
            this.OwnerOrgName = "FETCH";
        }
        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        if (this.ProtectedObjectCount == null && ec.Includes("protectedObjectCount",true))
        {
            this.ProtectedObjectCount = Int32.MinValue;
        }
        //      C# -> DateTime? SnapshotScheduleLastUpdatedAt
        // GraphQL -> snapshotScheduleLastUpdatedAt: DateTime (scalar)
        if (this.SnapshotScheduleLastUpdatedAt == null && ec.Includes("snapshotScheduleLastUpdatedAt",true))
        {
            this.SnapshotScheduleLastUpdatedAt = new DateTime();
        }
        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        if (this.StateVersion == null && ec.Includes("stateVersion",true))
        {
            this.StateVersion = new System.Int64();
        }
        //      C# -> System.String? UiColor
        // GraphQL -> uiColor: String! (scalar)
        if (this.UiColor == null && ec.Includes("uiColor",true))
        {
            this.UiColor = "FETCH";
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && ec.Includes("version",true))
        {
            this.Version = "FETCH";
        }
        //      C# -> List<SlaAssociatedOrganization>? AllOrgsHavingAccess
        // GraphQL -> allOrgsHavingAccess: [SlaAssociatedOrganization!]! (type)
        if (this.AllOrgsHavingAccess == null && ec.Includes("allOrgsHavingAccess",false))
        {
            this.AllOrgsHavingAccess = new List<SlaAssociatedOrganization>();
            this.AllOrgsHavingAccess.ApplyExploratoryFieldSpec(ec.NewChild("allOrgsHavingAccess"));
        }
        //      C# -> List<Org>? AllOrgsWithAccess
        // GraphQL -> allOrgsWithAccess: [Org!]! (type)
        if (this.AllOrgsWithAccess == null && ec.Includes("allOrgsWithAccess",false))
        {
            this.AllOrgsWithAccess = new List<Org>();
            this.AllOrgsWithAccess.ApplyExploratoryFieldSpec(ec.NewChild("allOrgsWithAccess"));
        }
        //      C# -> ArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ArchivalSpec (type)
        if (this.ArchivalSpec == null && ec.Includes("archivalSpec",false))
        {
            this.ArchivalSpec = new ArchivalSpec();
            this.ArchivalSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpec"));
        }
        //      C# -> List<ArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpec!]! (type)
        if (this.ArchivalSpecs == null && ec.Includes("archivalSpecs",false))
        {
            this.ArchivalSpecs = new List<ArchivalSpec>();
            this.ArchivalSpecs.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpecs"));
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (this.BackupWindows == null && ec.Includes("backupWindows",false))
        {
            this.BackupWindows = new List<BackupWindow>();
            this.BackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("backupWindows"));
        }
        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        if (this.BaseFrequency == null && ec.Includes("baseFrequency",false))
        {
            this.BaseFrequency = new Duration();
            this.BaseFrequency.ApplyExploratoryFieldSpec(ec.NewChild("baseFrequency"));
        }
        //      C# -> List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap
        // GraphQL -> clusterToSyncStatusMap: [GlobalSlaSyncStatus!]! (type)
        if (this.ClusterToSyncStatusMap == null && ec.Includes("clusterToSyncStatusMap",false))
        {
            this.ClusterToSyncStatusMap = new List<GlobalSlaSyncStatus>();
            this.ClusterToSyncStatusMap.ApplyExploratoryFieldSpec(ec.NewChild("clusterToSyncStatusMap"));
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (this.FirstFullBackupWindows == null && ec.Includes("firstFullBackupWindows",false))
        {
            this.FirstFullBackupWindows = new List<BackupWindow>();
            this.FirstFullBackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("firstFullBackupWindows"));
        }
        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        if (this.LocalRetentionLimit == null && ec.Includes("localRetentionLimit",false))
        {
            this.LocalRetentionLimit = new Duration();
            this.LocalRetentionLimit.ApplyExploratoryFieldSpec(ec.NewChild("localRetentionLimit"));
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (this.LogConfig == null && ec.Includes("logConfig",false))
        {
            this.LogConfig = new LogConfigResult();
            this.LogConfig.ApplyExploratoryFieldSpec(ec.NewChild("logConfig"));
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (this.ObjectSpecificConfigs == null && ec.Includes("objectSpecificConfigs",false))
        {
            this.ObjectSpecificConfigs = new ObjectSpecificConfigs();
            this.ObjectSpecificConfigs.ApplyExploratoryFieldSpec(ec.NewChild("objectSpecificConfigs"));
        }
        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        if (this.OwnerOrg == null && ec.Includes("ownerOrg",false))
        {
            this.OwnerOrg = new SlaAssociatedOrganization();
            this.OwnerOrg.ApplyExploratoryFieldSpec(ec.NewChild("ownerOrg"));
        }
        //      C# -> PausedClustersInfo? PausedClustersInfo
        // GraphQL -> pausedClustersInfo: PausedClustersInfo (type)
        if (this.PausedClustersInfo == null && ec.Includes("pausedClustersInfo",false))
        {
            this.PausedClustersInfo = new PausedClustersInfo();
            this.PausedClustersInfo.ApplyExploratoryFieldSpec(ec.NewChild("pausedClustersInfo"));
        }
        //      C# -> ReplicationSpec? ReplicationSpec
        // GraphQL -> replicationSpec: ReplicationSpec (type)
        if (this.ReplicationSpec == null && ec.Includes("replicationSpec",false))
        {
            this.ReplicationSpec = new ReplicationSpec();
            this.ReplicationSpec.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec"));
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
        if (this.ReplicationSpecsV2 == null && ec.Includes("replicationSpecsV2",false))
        {
            this.ReplicationSpecsV2 = new List<ReplicationSpecV2>();
            this.ReplicationSpecsV2.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpecsV2"));
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (this.SnapshotSchedule == null && ec.Includes("snapshotSchedule",false))
        {
            this.SnapshotSchedule = new SnapshotSchedule();
            this.SnapshotSchedule.ApplyExploratoryFieldSpec(ec.NewChild("snapshotSchedule"));
        }
        //      C# -> SlaUpgradeInfo? UpgradeInfo
        // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
        if (this.UpgradeInfo == null && ec.Includes("upgradeInfo",false))
        {
            this.UpgradeInfo = new SlaUpgradeInfo();
            this.UpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("upgradeInfo"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GlobalSlaReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalSlaReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalSlaReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types