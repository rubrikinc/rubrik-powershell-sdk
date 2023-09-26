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

        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        [JsonProperty("retentionLockMode")]
        public RetentionLockMode? RetentionLockMode { get; set; }

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
        RetentionLockMode? RetentionLockMode = null,
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
        if ( RetentionLockMode != null ) {
            this.RetentionLockMode = RetentionLockMode;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<SlaObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [SlaObjectType!]! (enum)
        if (this.ObjectTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectTypes\n" ;
            } else {
                s += ind + "objectTypes\n" ;
            }
        }
        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        if (this.RetentionLockMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionLockMode\n" ;
            } else {
                s += ind + "retentionLockMode\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (this.IsDefault != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDefault\n" ;
            } else {
                s += ind + "isDefault\n" ;
            }
        }
        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        if (this.IsRetentionLockedSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRetentionLockedSla\n" ;
            } else {
                s += ind + "isRetentionLockedSla\n" ;
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
        //      C# -> System.String? OwnerOrgName
        // GraphQL -> ownerOrgName: String! (scalar)
        if (this.OwnerOrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ownerOrgName\n" ;
            } else {
                s += ind + "ownerOrgName\n" ;
            }
        }
        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        if (this.ProtectedObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedObjectCount\n" ;
            } else {
                s += ind + "protectedObjectCount\n" ;
            }
        }
        //      C# -> DateTime? SnapshotScheduleLastUpdatedAt
        // GraphQL -> snapshotScheduleLastUpdatedAt: DateTime (scalar)
        if (this.SnapshotScheduleLastUpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotScheduleLastUpdatedAt\n" ;
            } else {
                s += ind + "snapshotScheduleLastUpdatedAt\n" ;
            }
        }
        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        if (this.StateVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stateVersion\n" ;
            } else {
                s += ind + "stateVersion\n" ;
            }
        }
        //      C# -> System.String? UiColor
        // GraphQL -> uiColor: String! (scalar)
        if (this.UiColor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uiColor\n" ;
            } else {
                s += ind + "uiColor\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<SlaAssociatedOrganization>? AllOrgsHavingAccess
        // GraphQL -> allOrgsHavingAccess: [SlaAssociatedOrganization!]! (type)
        if (this.AllOrgsHavingAccess != null) {
            var fspec = this.AllOrgsHavingAccess.AsFieldSpec(conf.Child("allOrgsHavingAccess"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgsHavingAccess {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Org>? AllOrgsWithAccess
        // GraphQL -> allOrgsWithAccess: [Org!]! (type)
        if (this.AllOrgsWithAccess != null) {
            var fspec = this.AllOrgsWithAccess.AsFieldSpec(conf.Child("allOrgsWithAccess"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgsWithAccess {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ArchivalSpec (type)
        if (this.ArchivalSpec != null) {
            var fspec = this.ArchivalSpec.AsFieldSpec(conf.Child("archivalSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalSpec {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpec!]! (type)
        if (this.ArchivalSpecs != null) {
            var fspec = this.ArchivalSpecs.AsFieldSpec(conf.Child("archivalSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalSpecs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (this.BackupWindows != null) {
            var fspec = this.BackupWindows.AsFieldSpec(conf.Child("backupWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupWindows {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        if (this.BaseFrequency != null) {
            var fspec = this.BaseFrequency.AsFieldSpec(conf.Child("baseFrequency"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseFrequency {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap
        // GraphQL -> clusterToSyncStatusMap: [GlobalSlaSyncStatus!]! (type)
        if (this.ClusterToSyncStatusMap != null) {
            var fspec = this.ClusterToSyncStatusMap.AsFieldSpec(conf.Child("clusterToSyncStatusMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterToSyncStatusMap {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (this.FirstFullBackupWindows != null) {
            var fspec = this.FirstFullBackupWindows.AsFieldSpec(conf.Child("firstFullBackupWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "firstFullBackupWindows {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        if (this.LocalRetentionLimit != null) {
            var fspec = this.LocalRetentionLimit.AsFieldSpec(conf.Child("localRetentionLimit"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "localRetentionLimit {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (this.LogConfig != null) {
            var fspec = this.LogConfig.AsFieldSpec(conf.Child("logConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (this.ObjectSpecificConfigs != null) {
            var fspec = this.ObjectSpecificConfigs.AsFieldSpec(conf.Child("objectSpecificConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectSpecificConfigs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        if (this.OwnerOrg != null) {
            var fspec = this.OwnerOrg.AsFieldSpec(conf.Child("ownerOrg"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ownerOrg {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PausedClustersInfo? PausedClustersInfo
        // GraphQL -> pausedClustersInfo: PausedClustersInfo (type)
        if (this.PausedClustersInfo != null) {
            var fspec = this.PausedClustersInfo.AsFieldSpec(conf.Child("pausedClustersInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pausedClustersInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ReplicationSpec? ReplicationSpec
        // GraphQL -> replicationSpec: ReplicationSpec (type)
        if (this.ReplicationSpec != null) {
            var fspec = this.ReplicationSpec.AsFieldSpec(conf.Child("replicationSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationSpec {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
        if (this.ReplicationSpecsV2 != null) {
            var fspec = this.ReplicationSpecsV2.AsFieldSpec(conf.Child("replicationSpecsV2"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationSpecsV2 {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (this.SnapshotSchedule != null) {
            var fspec = this.SnapshotSchedule.AsFieldSpec(conf.Child("snapshotSchedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotSchedule {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaUpgradeInfo? UpgradeInfo
        // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
        if (this.UpgradeInfo != null) {
            var fspec = this.UpgradeInfo.AsFieldSpec(conf.Child("upgradeInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "upgradeInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [SlaObjectType!]! (enum)
        if (ec.Includes("objectTypes",true))
        {
            if(this.ObjectTypes == null) {

                this.ObjectTypes = new List<SlaObjectType>();

            } else {


            }
        }
        else if (this.ObjectTypes != null && ec.Excludes("objectTypes",true))
        {
            this.ObjectTypes = null;
        }
        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        if (ec.Includes("retentionLockMode",true))
        {
            if(this.RetentionLockMode == null) {

                this.RetentionLockMode = new RetentionLockMode();

            } else {


            }
        }
        else if (this.RetentionLockMode != null && ec.Excludes("retentionLockMode",true))
        {
            this.RetentionLockMode = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
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
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsDefault
        // GraphQL -> isDefault: Boolean! (scalar)
        if (ec.Includes("isDefault",true))
        {
            if(this.IsDefault == null) {

                this.IsDefault = true;

            } else {


            }
        }
        else if (this.IsDefault != null && ec.Excludes("isDefault",true))
        {
            this.IsDefault = null;
        }
        //      C# -> System.Boolean? IsRetentionLockedSla
        // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
        if (ec.Includes("isRetentionLockedSla",true))
        {
            if(this.IsRetentionLockedSla == null) {

                this.IsRetentionLockedSla = true;

            } else {


            }
        }
        else if (this.IsRetentionLockedSla != null && ec.Excludes("isRetentionLockedSla",true))
        {
            this.IsRetentionLockedSla = null;
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
        //      C# -> System.String? OwnerOrgName
        // GraphQL -> ownerOrgName: String! (scalar)
        if (ec.Includes("ownerOrgName",true))
        {
            if(this.OwnerOrgName == null) {

                this.OwnerOrgName = "FETCH";

            } else {


            }
        }
        else if (this.OwnerOrgName != null && ec.Excludes("ownerOrgName",true))
        {
            this.OwnerOrgName = null;
        }
        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        if (ec.Includes("protectedObjectCount",true))
        {
            if(this.ProtectedObjectCount == null) {

                this.ProtectedObjectCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ProtectedObjectCount != null && ec.Excludes("protectedObjectCount",true))
        {
            this.ProtectedObjectCount = null;
        }
        //      C# -> DateTime? SnapshotScheduleLastUpdatedAt
        // GraphQL -> snapshotScheduleLastUpdatedAt: DateTime (scalar)
        if (ec.Includes("snapshotScheduleLastUpdatedAt",true))
        {
            if(this.SnapshotScheduleLastUpdatedAt == null) {

                this.SnapshotScheduleLastUpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotScheduleLastUpdatedAt != null && ec.Excludes("snapshotScheduleLastUpdatedAt",true))
        {
            this.SnapshotScheduleLastUpdatedAt = null;
        }
        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        if (ec.Includes("stateVersion",true))
        {
            if(this.StateVersion == null) {

                this.StateVersion = new System.Int64();

            } else {


            }
        }
        else if (this.StateVersion != null && ec.Excludes("stateVersion",true))
        {
            this.StateVersion = null;
        }
        //      C# -> System.String? UiColor
        // GraphQL -> uiColor: String! (scalar)
        if (ec.Includes("uiColor",true))
        {
            if(this.UiColor == null) {

                this.UiColor = "FETCH";

            } else {


            }
        }
        else if (this.UiColor != null && ec.Excludes("uiColor",true))
        {
            this.UiColor = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<SlaAssociatedOrganization>? AllOrgsHavingAccess
        // GraphQL -> allOrgsHavingAccess: [SlaAssociatedOrganization!]! (type)
        if (ec.Includes("allOrgsHavingAccess",false))
        {
            if(this.AllOrgsHavingAccess == null) {

                this.AllOrgsHavingAccess = new List<SlaAssociatedOrganization>();
                this.AllOrgsHavingAccess.ApplyExploratoryFieldSpec(ec.NewChild("allOrgsHavingAccess"));

            } else {

                this.AllOrgsHavingAccess.ApplyExploratoryFieldSpec(ec.NewChild("allOrgsHavingAccess"));

            }
        }
        else if (this.AllOrgsHavingAccess != null && ec.Excludes("allOrgsHavingAccess",false))
        {
            this.AllOrgsHavingAccess = null;
        }
        //      C# -> List<Org>? AllOrgsWithAccess
        // GraphQL -> allOrgsWithAccess: [Org!]! (type)
        if (ec.Includes("allOrgsWithAccess",false))
        {
            if(this.AllOrgsWithAccess == null) {

                this.AllOrgsWithAccess = new List<Org>();
                this.AllOrgsWithAccess.ApplyExploratoryFieldSpec(ec.NewChild("allOrgsWithAccess"));

            } else {

                this.AllOrgsWithAccess.ApplyExploratoryFieldSpec(ec.NewChild("allOrgsWithAccess"));

            }
        }
        else if (this.AllOrgsWithAccess != null && ec.Excludes("allOrgsWithAccess",false))
        {
            this.AllOrgsWithAccess = null;
        }
        //      C# -> ArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ArchivalSpec (type)
        if (ec.Includes("archivalSpec",false))
        {
            if(this.ArchivalSpec == null) {

                this.ArchivalSpec = new ArchivalSpec();
                this.ArchivalSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpec"));

            } else {

                this.ArchivalSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpec"));

            }
        }
        else if (this.ArchivalSpec != null && ec.Excludes("archivalSpec",false))
        {
            this.ArchivalSpec = null;
        }
        //      C# -> List<ArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ArchivalSpec!]! (type)
        if (ec.Includes("archivalSpecs",false))
        {
            if(this.ArchivalSpecs == null) {

                this.ArchivalSpecs = new List<ArchivalSpec>();
                this.ArchivalSpecs.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpecs"));

            } else {

                this.ArchivalSpecs.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpecs"));

            }
        }
        else if (this.ArchivalSpecs != null && ec.Excludes("archivalSpecs",false))
        {
            this.ArchivalSpecs = null;
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (ec.Includes("backupWindows",false))
        {
            if(this.BackupWindows == null) {

                this.BackupWindows = new List<BackupWindow>();
                this.BackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("backupWindows"));

            } else {

                this.BackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("backupWindows"));

            }
        }
        else if (this.BackupWindows != null && ec.Excludes("backupWindows",false))
        {
            this.BackupWindows = null;
        }
        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        if (ec.Includes("baseFrequency",false))
        {
            if(this.BaseFrequency == null) {

                this.BaseFrequency = new Duration();
                this.BaseFrequency.ApplyExploratoryFieldSpec(ec.NewChild("baseFrequency"));

            } else {

                this.BaseFrequency.ApplyExploratoryFieldSpec(ec.NewChild("baseFrequency"));

            }
        }
        else if (this.BaseFrequency != null && ec.Excludes("baseFrequency",false))
        {
            this.BaseFrequency = null;
        }
        //      C# -> List<GlobalSlaSyncStatus>? ClusterToSyncStatusMap
        // GraphQL -> clusterToSyncStatusMap: [GlobalSlaSyncStatus!]! (type)
        if (ec.Includes("clusterToSyncStatusMap",false))
        {
            if(this.ClusterToSyncStatusMap == null) {

                this.ClusterToSyncStatusMap = new List<GlobalSlaSyncStatus>();
                this.ClusterToSyncStatusMap.ApplyExploratoryFieldSpec(ec.NewChild("clusterToSyncStatusMap"));

            } else {

                this.ClusterToSyncStatusMap.ApplyExploratoryFieldSpec(ec.NewChild("clusterToSyncStatusMap"));

            }
        }
        else if (this.ClusterToSyncStatusMap != null && ec.Excludes("clusterToSyncStatusMap",false))
        {
            this.ClusterToSyncStatusMap = null;
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (ec.Includes("firstFullBackupWindows",false))
        {
            if(this.FirstFullBackupWindows == null) {

                this.FirstFullBackupWindows = new List<BackupWindow>();
                this.FirstFullBackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("firstFullBackupWindows"));

            } else {

                this.FirstFullBackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("firstFullBackupWindows"));

            }
        }
        else if (this.FirstFullBackupWindows != null && ec.Excludes("firstFullBackupWindows",false))
        {
            this.FirstFullBackupWindows = null;
        }
        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        if (ec.Includes("localRetentionLimit",false))
        {
            if(this.LocalRetentionLimit == null) {

                this.LocalRetentionLimit = new Duration();
                this.LocalRetentionLimit.ApplyExploratoryFieldSpec(ec.NewChild("localRetentionLimit"));

            } else {

                this.LocalRetentionLimit.ApplyExploratoryFieldSpec(ec.NewChild("localRetentionLimit"));

            }
        }
        else if (this.LocalRetentionLimit != null && ec.Excludes("localRetentionLimit",false))
        {
            this.LocalRetentionLimit = null;
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (ec.Includes("logConfig",false))
        {
            if(this.LogConfig == null) {

                this.LogConfig = new LogConfigResult();
                this.LogConfig.ApplyExploratoryFieldSpec(ec.NewChild("logConfig"));

            } else {

                this.LogConfig.ApplyExploratoryFieldSpec(ec.NewChild("logConfig"));

            }
        }
        else if (this.LogConfig != null && ec.Excludes("logConfig",false))
        {
            this.LogConfig = null;
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (ec.Includes("objectSpecificConfigs",false))
        {
            if(this.ObjectSpecificConfigs == null) {

                this.ObjectSpecificConfigs = new ObjectSpecificConfigs();
                this.ObjectSpecificConfigs.ApplyExploratoryFieldSpec(ec.NewChild("objectSpecificConfigs"));

            } else {

                this.ObjectSpecificConfigs.ApplyExploratoryFieldSpec(ec.NewChild("objectSpecificConfigs"));

            }
        }
        else if (this.ObjectSpecificConfigs != null && ec.Excludes("objectSpecificConfigs",false))
        {
            this.ObjectSpecificConfigs = null;
        }
        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        if (ec.Includes("ownerOrg",false))
        {
            if(this.OwnerOrg == null) {

                this.OwnerOrg = new SlaAssociatedOrganization();
                this.OwnerOrg.ApplyExploratoryFieldSpec(ec.NewChild("ownerOrg"));

            } else {

                this.OwnerOrg.ApplyExploratoryFieldSpec(ec.NewChild("ownerOrg"));

            }
        }
        else if (this.OwnerOrg != null && ec.Excludes("ownerOrg",false))
        {
            this.OwnerOrg = null;
        }
        //      C# -> PausedClustersInfo? PausedClustersInfo
        // GraphQL -> pausedClustersInfo: PausedClustersInfo (type)
        if (ec.Includes("pausedClustersInfo",false))
        {
            if(this.PausedClustersInfo == null) {

                this.PausedClustersInfo = new PausedClustersInfo();
                this.PausedClustersInfo.ApplyExploratoryFieldSpec(ec.NewChild("pausedClustersInfo"));

            } else {

                this.PausedClustersInfo.ApplyExploratoryFieldSpec(ec.NewChild("pausedClustersInfo"));

            }
        }
        else if (this.PausedClustersInfo != null && ec.Excludes("pausedClustersInfo",false))
        {
            this.PausedClustersInfo = null;
        }
        //      C# -> ReplicationSpec? ReplicationSpec
        // GraphQL -> replicationSpec: ReplicationSpec (type)
        if (ec.Includes("replicationSpec",false))
        {
            if(this.ReplicationSpec == null) {

                this.ReplicationSpec = new ReplicationSpec();
                this.ReplicationSpec.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec"));

            } else {

                this.ReplicationSpec.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpec"));

            }
        }
        else if (this.ReplicationSpec != null && ec.Excludes("replicationSpec",false))
        {
            this.ReplicationSpec = null;
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
        // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
        if (ec.Includes("replicationSpecsV2",false))
        {
            if(this.ReplicationSpecsV2 == null) {

                this.ReplicationSpecsV2 = new List<ReplicationSpecV2>();
                this.ReplicationSpecsV2.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpecsV2"));

            } else {

                this.ReplicationSpecsV2.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpecsV2"));

            }
        }
        else if (this.ReplicationSpecsV2 != null && ec.Excludes("replicationSpecsV2",false))
        {
            this.ReplicationSpecsV2 = null;
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (ec.Includes("snapshotSchedule",false))
        {
            if(this.SnapshotSchedule == null) {

                this.SnapshotSchedule = new SnapshotSchedule();
                this.SnapshotSchedule.ApplyExploratoryFieldSpec(ec.NewChild("snapshotSchedule"));

            } else {

                this.SnapshotSchedule.ApplyExploratoryFieldSpec(ec.NewChild("snapshotSchedule"));

            }
        }
        else if (this.SnapshotSchedule != null && ec.Excludes("snapshotSchedule",false))
        {
            this.SnapshotSchedule = null;
        }
        //      C# -> SlaUpgradeInfo? UpgradeInfo
        // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
        if (ec.Includes("upgradeInfo",false))
        {
            if(this.UpgradeInfo == null) {

                this.UpgradeInfo = new SlaUpgradeInfo();
                this.UpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("upgradeInfo"));

            } else {

                this.UpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("upgradeInfo"));

            }
        }
        else if (this.UpgradeInfo != null && ec.Excludes("upgradeInfo",false))
        {
            this.UpgradeInfo = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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