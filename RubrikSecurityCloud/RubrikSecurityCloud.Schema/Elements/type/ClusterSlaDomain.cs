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

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterSlaDomain
 
    public class ClusterSlaDomain: IFragment, SlaDomain, SnappableGroupByInfo
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

    public ClusterSlaDomain Set(
        System.String? CdmId = null,
        System.String? Fid = null,
        System.String? Id = null,
        System.Boolean? IsRetentionLockedSla = null,
        System.String? Name = null,
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid != null)
            {
                 s += ind + "fid\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsRetentionLockedSla
            // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
            if (this.IsRetentionLockedSla != null)
            {
                 s += ind + "isRetentionLockedSla\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? PolarisManagedId
            // GraphQL -> polarisManagedId: String (scalar)
            if (this.PolarisManagedId != null)
            {
                 s += ind + "polarisManagedId\n";

            }
            //      C# -> System.Int32? ProtectedObjectCount
            // GraphQL -> protectedObjectCount: Int! (scalar)
            if (this.ProtectedObjectCount != null)
            {
                 s += ind + "protectedObjectCount\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> ClusterArchivalSpec? ArchivalSpec
            // GraphQL -> archivalSpec: ClusterArchivalSpec (type)
            if (this.ArchivalSpec != null)
            {
                 s += ind + "archivalSpec\n";

                 s += ind + "{\n" + 
                 this.ArchivalSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClusterArchivalSpec>? ArchivalSpecs
            // GraphQL -> archivalSpecs: [ClusterArchivalSpec!]! (type)
            if (this.ArchivalSpecs != null)
            {
                 s += ind + "archivalSpecs\n";

                 s += ind + "{\n" + 
                 this.ArchivalSpecs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<BackupWindow>? BackupWindows
            // GraphQL -> backupWindows: [BackupWindow!]! (type)
            if (this.BackupWindows != null)
            {
                 s += ind + "backupWindows\n";

                 s += ind + "{\n" + 
                 this.BackupWindows.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Duration? BaseFrequency
            // GraphQL -> baseFrequency: Duration (type)
            if (this.BaseFrequency != null)
            {
                 s += ind + "baseFrequency\n";

                 s += ind + "{\n" + 
                 this.BaseFrequency.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<BackupWindow>? FirstFullBackupWindows
            // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
            if (this.FirstFullBackupWindows != null)
            {
                 s += ind + "firstFullBackupWindows\n";

                 s += ind + "{\n" + 
                 this.FirstFullBackupWindows.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Duration? LocalRetentionLimit
            // GraphQL -> localRetentionLimit: Duration (type)
            if (this.LocalRetentionLimit != null)
            {
                 s += ind + "localRetentionLimit\n";

                 s += ind + "{\n" + 
                 this.LocalRetentionLimit.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
            // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
            if (this.ObjectSpecificConfigs != null)
            {
                 s += ind + "objectSpecificConfigs\n";

                 s += ind + "{\n" + 
                 this.ObjectSpecificConfigs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReplicationSpec? ReplicationSpec
            // GraphQL -> replicationSpec: ReplicationSpec (type)
            if (this.ReplicationSpec != null)
            {
                 s += ind + "replicationSpec\n";

                 s += ind + "{\n" + 
                 this.ReplicationSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
            // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
            if (this.ReplicationSpecsV2 != null)
            {
                 s += ind + "replicationSpecsV2\n";

                 s += ind + "{\n" + 
                 this.ReplicationSpecsV2.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotSchedule? SnapshotSchedule
            // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
            if (this.SnapshotSchedule != null)
            {
                 s += ind + "snapshotSchedule\n";

                 s += ind + "{\n" + 
                 this.SnapshotSchedule.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaUpgradeInfo? UpgradeInfo
            // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
            if (this.UpgradeInfo != null)
            {
                 s += ind + "upgradeInfo\n";

                 s += ind + "{\n" + 
                 this.UpgradeInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid == null && Exploration.Includes(parent + ".fid$"))
            {
                this.Fid = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsRetentionLockedSla
            // GraphQL -> isRetentionLockedSla: Boolean! (scalar)
            if (this.IsRetentionLockedSla == null && Exploration.Includes(parent + ".isRetentionLockedSla$"))
            {
                this.IsRetentionLockedSla = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? PolarisManagedId
            // GraphQL -> polarisManagedId: String (scalar)
            if (this.PolarisManagedId == null && Exploration.Includes(parent + ".polarisManagedId$"))
            {
                this.PolarisManagedId = new System.String("FETCH");
            }
            //      C# -> System.Int32? ProtectedObjectCount
            // GraphQL -> protectedObjectCount: Int! (scalar)
            if (this.ProtectedObjectCount == null && Exploration.Includes(parent + ".protectedObjectCount$"))
            {
                this.ProtectedObjectCount = new System.Int32();
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> ClusterArchivalSpec? ArchivalSpec
            // GraphQL -> archivalSpec: ClusterArchivalSpec (type)
            if (this.ArchivalSpec == null && Exploration.Includes(parent + ".archivalSpec"))
            {
                this.ArchivalSpec = new ClusterArchivalSpec();
                this.ArchivalSpec.ApplyExploratoryFragment(parent + ".archivalSpec");
            }
            //      C# -> List<ClusterArchivalSpec>? ArchivalSpecs
            // GraphQL -> archivalSpecs: [ClusterArchivalSpec!]! (type)
            if (this.ArchivalSpecs == null && Exploration.Includes(parent + ".archivalSpecs"))
            {
                this.ArchivalSpecs = new List<ClusterArchivalSpec>();
                this.ArchivalSpecs.ApplyExploratoryFragment(parent + ".archivalSpecs");
            }
            //      C# -> List<BackupWindow>? BackupWindows
            // GraphQL -> backupWindows: [BackupWindow!]! (type)
            if (this.BackupWindows == null && Exploration.Includes(parent + ".backupWindows"))
            {
                this.BackupWindows = new List<BackupWindow>();
                this.BackupWindows.ApplyExploratoryFragment(parent + ".backupWindows");
            }
            //      C# -> Duration? BaseFrequency
            // GraphQL -> baseFrequency: Duration (type)
            if (this.BaseFrequency == null && Exploration.Includes(parent + ".baseFrequency"))
            {
                this.BaseFrequency = new Duration();
                this.BaseFrequency.ApplyExploratoryFragment(parent + ".baseFrequency");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> List<BackupWindow>? FirstFullBackupWindows
            // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
            if (this.FirstFullBackupWindows == null && Exploration.Includes(parent + ".firstFullBackupWindows"))
            {
                this.FirstFullBackupWindows = new List<BackupWindow>();
                this.FirstFullBackupWindows.ApplyExploratoryFragment(parent + ".firstFullBackupWindows");
            }
            //      C# -> Duration? LocalRetentionLimit
            // GraphQL -> localRetentionLimit: Duration (type)
            if (this.LocalRetentionLimit == null && Exploration.Includes(parent + ".localRetentionLimit"))
            {
                this.LocalRetentionLimit = new Duration();
                this.LocalRetentionLimit.ApplyExploratoryFragment(parent + ".localRetentionLimit");
            }
            //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
            // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
            if (this.ObjectSpecificConfigs == null && Exploration.Includes(parent + ".objectSpecificConfigs"))
            {
                this.ObjectSpecificConfigs = new ObjectSpecificConfigs();
                this.ObjectSpecificConfigs.ApplyExploratoryFragment(parent + ".objectSpecificConfigs");
            }
            //      C# -> ReplicationSpec? ReplicationSpec
            // GraphQL -> replicationSpec: ReplicationSpec (type)
            if (this.ReplicationSpec == null && Exploration.Includes(parent + ".replicationSpec"))
            {
                this.ReplicationSpec = new ReplicationSpec();
                this.ReplicationSpec.ApplyExploratoryFragment(parent + ".replicationSpec");
            }
            //      C# -> List<ReplicationSpecV2>? ReplicationSpecsV2
            // GraphQL -> replicationSpecsV2: [ReplicationSpecV2!]! (type)
            if (this.ReplicationSpecsV2 == null && Exploration.Includes(parent + ".replicationSpecsV2"))
            {
                this.ReplicationSpecsV2 = new List<ReplicationSpecV2>();
                this.ReplicationSpecsV2.ApplyExploratoryFragment(parent + ".replicationSpecsV2");
            }
            //      C# -> SnapshotSchedule? SnapshotSchedule
            // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
            if (this.SnapshotSchedule == null && Exploration.Includes(parent + ".snapshotSchedule"))
            {
                this.SnapshotSchedule = new SnapshotSchedule();
                this.SnapshotSchedule.ApplyExploratoryFragment(parent + ".snapshotSchedule");
            }
            //      C# -> SlaUpgradeInfo? UpgradeInfo
            // GraphQL -> upgradeInfo: SlaUpgradeInfo (type)
            if (this.UpgradeInfo == null && Exploration.Includes(parent + ".upgradeInfo"))
            {
                this.UpgradeInfo = new SlaUpgradeInfo();
                this.UpgradeInfo.ApplyExploratoryFragment(parent + ".upgradeInfo");
            }
        }


    #endregion

    } // class ClusterSlaDomain
    #endregion

    public static class ListClusterSlaDomainExtensions
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
            this List<ClusterSlaDomain> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterSlaDomain> list, 
            String parent = "")
        {
            var item = new ClusterSlaDomain();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types