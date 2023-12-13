// ClusterSlaDomain.cs
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
    #region ClusterSlaDomain
 
    public class ClusterSlaDomain: BaseType, SlaDomain, SnappableGroupByInfo
    {
        #region members

        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        [JsonProperty("retentionLockMode")]
        public RetentionLockMode? RetentionLockMode { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

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

        //      C# -> System.String? PolarisManagedId
        // GraphQL -> polarisManagedId: String (scalar)
        [JsonProperty("polarisManagedId")]
        public System.String? PolarisManagedId { get; set; }

        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        [JsonProperty("protectedObjectCount")]
        public System.Int32? ProtectedObjectCount { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<ArchivalLocationUpgradeInfo>? ArchivalLocationsUpgradeInfo
        // GraphQL -> archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!] (type)
        [JsonProperty("archivalLocationsUpgradeInfo")]
        public List<ArchivalLocationUpgradeInfo>? ArchivalLocationsUpgradeInfo { get; set; }

        //      C# -> ClusterArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ClusterArchivalSpec (type)
        [JsonProperty("archivalSpec")]
        public ClusterArchivalSpec? ArchivalSpec { get; set; }

        //      C# -> List<ClusterArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ClusterArchivalSpec!]! (type)
        [JsonProperty("archivalSpecs")]
        public List<ClusterArchivalSpec>? ArchivalSpecs { get; set; }

        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        [JsonProperty("backupWindows")]
        public List<BackupWindow>? BackupWindows { get; set; }

        //      C# -> Duration? BaseFrequency
        // GraphQL -> baseFrequency: Duration (type)
        [JsonProperty("baseFrequency")]
        public Duration? BaseFrequency { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        [JsonProperty("firstFullBackupWindows")]
        public List<BackupWindow>? FirstFullBackupWindows { get; set; }

        //      C# -> Duration? LocalRetentionLimit
        // GraphQL -> localRetentionLimit: Duration (type)
        [JsonProperty("localRetentionLimit")]
        public Duration? LocalRetentionLimit { get; set; }

        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        [JsonProperty("objectSpecificConfigs")]
        public ObjectSpecificConfigs? ObjectSpecificConfigs { get; set; }

        //      C# -> SlaAssociatedOrganization? OwnerOrg
        // GraphQL -> ownerOrg: SlaAssociatedOrganization! (type)
        [JsonProperty("ownerOrg")]
        public SlaAssociatedOrganization? OwnerOrg { get; set; }

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
        return "ClusterSlaDomain";
    }

    public ClusterSlaDomain Set(
        RetentionLockMode? RetentionLockMode = null,
        System.String? CdmId = null,
        System.String? Fid = null,
        System.String? Id = null,
        System.Boolean? IsRetentionLockedSla = null,
        System.String? Name = null,
        System.String? OwnerOrgName = null,
        System.String? PolarisManagedId = null,
        System.Int32? ProtectedObjectCount = null,
        System.String? Version = null,
        List<ArchivalLocationUpgradeInfo>? ArchivalLocationsUpgradeInfo = null,
        ClusterArchivalSpec? ArchivalSpec = null,
        List<ClusterArchivalSpec>? ArchivalSpecs = null,
        List<BackupWindow>? BackupWindows = null,
        Duration? BaseFrequency = null,
        Cluster? Cluster = null,
        List<BackupWindow>? FirstFullBackupWindows = null,
        Duration? LocalRetentionLimit = null,
        ObjectSpecificConfigs? ObjectSpecificConfigs = null,
        SlaAssociatedOrganization? OwnerOrg = null,
        ReplicationSpec? ReplicationSpec = null,
        List<ReplicationSpecV2>? ReplicationSpecsV2 = null,
        SnapshotSchedule? SnapshotSchedule = null,
        SlaUpgradeInfo? UpgradeInfo = null
    ) 
    {
        if ( RetentionLockMode != null ) {
            this.RetentionLockMode = RetentionLockMode;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        if ( PolarisManagedId != null ) {
            this.PolarisManagedId = PolarisManagedId;
        }
        if ( ProtectedObjectCount != null ) {
            this.ProtectedObjectCount = ProtectedObjectCount;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ArchivalLocationsUpgradeInfo != null ) {
            this.ArchivalLocationsUpgradeInfo = ArchivalLocationsUpgradeInfo;
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
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( FirstFullBackupWindows != null ) {
            this.FirstFullBackupWindows = FirstFullBackupWindows;
        }
        if ( LocalRetentionLimit != null ) {
            this.LocalRetentionLimit = LocalRetentionLimit;
        }
        if ( ObjectSpecificConfigs != null ) {
            this.ObjectSpecificConfigs = ObjectSpecificConfigs;
        }
        if ( OwnerOrg != null ) {
            this.OwnerOrg = OwnerOrg;
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
        //      C# -> RetentionLockMode? RetentionLockMode
        // GraphQL -> retentionLockMode: RetentionLockMode! (enum)
        if (this.RetentionLockMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionLockMode\n" ;
            } else {
                s += ind + "retentionLockMode\n" ;
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
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
        //      C# -> System.String? PolarisManagedId
        // GraphQL -> polarisManagedId: String (scalar)
        if (this.PolarisManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "polarisManagedId\n" ;
            } else {
                s += ind + "polarisManagedId\n" ;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<ArchivalLocationUpgradeInfo>? ArchivalLocationsUpgradeInfo
        // GraphQL -> archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!] (type)
        if (this.ArchivalLocationsUpgradeInfo != null) {
            var fspec = this.ArchivalLocationsUpgradeInfo.AsFieldSpec(conf.Child("archivalLocationsUpgradeInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalLocationsUpgradeInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ClusterArchivalSpec (type)
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
        //      C# -> List<ClusterArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ClusterArchivalSpec!]! (type)
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
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
        //      C# -> System.String? PolarisManagedId
        // GraphQL -> polarisManagedId: String (scalar)
        if (ec.Includes("polarisManagedId",true))
        {
            if(this.PolarisManagedId == null) {

                this.PolarisManagedId = "FETCH";

            } else {


            }
        }
        else if (this.PolarisManagedId != null && ec.Excludes("polarisManagedId",true))
        {
            this.PolarisManagedId = null;
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
        //      C# -> List<ArchivalLocationUpgradeInfo>? ArchivalLocationsUpgradeInfo
        // GraphQL -> archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!] (type)
        if (ec.Includes("archivalLocationsUpgradeInfo",false))
        {
            if(this.ArchivalLocationsUpgradeInfo == null) {

                this.ArchivalLocationsUpgradeInfo = new List<ArchivalLocationUpgradeInfo>();
                this.ArchivalLocationsUpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationsUpgradeInfo"));

            } else {

                this.ArchivalLocationsUpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationsUpgradeInfo"));

            }
        }
        else if (this.ArchivalLocationsUpgradeInfo != null && ec.Excludes("archivalLocationsUpgradeInfo",false))
        {
            this.ArchivalLocationsUpgradeInfo = null;
        }
        //      C# -> ClusterArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ClusterArchivalSpec (type)
        if (ec.Includes("archivalSpec",false))
        {
            if(this.ArchivalSpec == null) {

                this.ArchivalSpec = new ClusterArchivalSpec();
                this.ArchivalSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpec"));

            } else {

                this.ArchivalSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalSpec"));

            }
        }
        else if (this.ArchivalSpec != null && ec.Excludes("archivalSpec",false))
        {
            this.ArchivalSpec = null;
        }
        //      C# -> List<ClusterArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ClusterArchivalSpec!]! (type)
        if (ec.Includes("archivalSpecs",false))
        {
            if(this.ArchivalSpecs == null) {

                this.ArchivalSpecs = new List<ClusterArchivalSpec>();
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
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

    } // class ClusterSlaDomain
    
    #endregion

    public static class ListClusterSlaDomainExtensions
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
            this List<ClusterSlaDomain> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterSlaDomain> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterSlaDomain> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterSlaDomain());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterSlaDomain> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types