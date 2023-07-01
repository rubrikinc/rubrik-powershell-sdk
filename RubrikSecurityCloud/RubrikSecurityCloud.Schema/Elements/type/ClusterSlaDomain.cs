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
        System.String? CdmId = null,
        System.String? Fid = null,
        System.String? Id = null,
        System.Boolean? IsRetentionLockedSla = null,
        System.String? Name = null,
        System.String? OwnerOrgName = null,
        System.String? PolarisManagedId = null,
        System.Int32? ProtectedObjectCount = null,
        System.String? Version = null,
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
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
        //      C# -> System.String? PolarisManagedId
        // GraphQL -> polarisManagedId: String (scalar)
        if (this.PolarisManagedId != null) {
            s += ind + "polarisManagedId\n" ;
        }
        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        if (this.ProtectedObjectCount != null) {
            s += ind + "protectedObjectCount\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> ClusterArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ClusterArchivalSpec (type)
        if (this.ArchivalSpec != null) {
            var fspec = this.ArchivalSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClusterArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ClusterArchivalSpec!]! (type)
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && Exploration.Includes(parent + ".fid", true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
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
            this.Name = "FETCH";
        }
        //      C# -> System.String? OwnerOrgName
        // GraphQL -> ownerOrgName: String! (scalar)
        if (this.OwnerOrgName == null && Exploration.Includes(parent + ".ownerOrgName", true))
        {
            this.OwnerOrgName = "FETCH";
        }
        //      C# -> System.String? PolarisManagedId
        // GraphQL -> polarisManagedId: String (scalar)
        if (this.PolarisManagedId == null && Exploration.Includes(parent + ".polarisManagedId", true))
        {
            this.PolarisManagedId = "FETCH";
        }
        //      C# -> System.Int32? ProtectedObjectCount
        // GraphQL -> protectedObjectCount: Int! (scalar)
        if (this.ProtectedObjectCount == null && Exploration.Includes(parent + ".protectedObjectCount", true))
        {
            this.ProtectedObjectCount = Int32.MinValue;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = "FETCH";
        }
        //      C# -> ClusterArchivalSpec? ArchivalSpec
        // GraphQL -> archivalSpec: ClusterArchivalSpec (type)
        if (this.ArchivalSpec == null && Exploration.Includes(parent + ".archivalSpec"))
        {
            this.ArchivalSpec = new ClusterArchivalSpec();
            this.ArchivalSpec.ApplyExploratoryFieldSpec(parent + ".archivalSpec");
        }
        //      C# -> List<ClusterArchivalSpec>? ArchivalSpecs
        // GraphQL -> archivalSpecs: [ClusterArchivalSpec!]! (type)
        if (this.ArchivalSpecs == null && Exploration.Includes(parent + ".archivalSpecs"))
        {
            this.ArchivalSpecs = new List<ClusterArchivalSpec>();
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterSlaDomain> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterSlaDomain());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types