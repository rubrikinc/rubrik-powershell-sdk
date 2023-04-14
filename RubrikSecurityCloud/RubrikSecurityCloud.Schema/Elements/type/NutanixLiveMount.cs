// NutanixLiveMount.cs
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
    #region NutanixLiveMount
    public class NutanixLiveMount: IFragment
    {
        #region members
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsMigrationDisabled
        // GraphQL -> isMigrationDisabled: Boolean! (scalar)
        [JsonProperty("isMigrationDisabled")]
        public System.Boolean? IsMigrationDisabled { get; set; }

        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        [JsonProperty("isVmReady")]
        public System.Boolean? IsVmReady { get; set; }

        //      C# -> System.String? MigrationJobInstanceId
        // GraphQL -> migrationJobInstanceId: String (scalar)
        [JsonProperty("migrationJobInstanceId")]
        public System.String? MigrationJobInstanceId { get; set; }

        //      C# -> System.String? MigrationJobStatus
        // GraphQL -> migrationJobStatus: String (scalar)
        [JsonProperty("migrationJobStatus")]
        public System.String? MigrationJobStatus { get; set; }

        //      C# -> System.String? MountJobInstanceId
        // GraphQL -> mountJobInstanceId: String! (scalar)
        [JsonProperty("mountJobInstanceId")]
        public System.String? MountJobInstanceId { get; set; }

        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        [JsonProperty("mountSpec")]
        public System.String? MountSpec { get; set; }

        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        [JsonProperty("mountedDate")]
        public DateTime? MountedDate { get; set; }

        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: String (scalar)
        [JsonProperty("mountedVmFid")]
        public System.String? MountedVmFid { get; set; }

        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        [JsonProperty("mountedVmId")]
        public System.String? MountedVmId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NutanixClusterFid
        // GraphQL -> nutanixClusterFid: String! (scalar)
        [JsonProperty("nutanixClusterFid")]
        public System.String? NutanixClusterFid { get; set; }

        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: String! (scalar)
        [JsonProperty("nutanixClusterId")]
        public System.String? NutanixClusterId { get; set; }

        //      C# -> System.String? NutanixClusterName
        // GraphQL -> nutanixClusterName: String! (scalar)
        [JsonProperty("nutanixClusterName")]
        public System.String? NutanixClusterName { get; set; }

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }

        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        [JsonProperty("ownerId")]
        public System.String? OwnerId { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String! (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: String! (scalar)
        [JsonProperty("sourceVmFid")]
        public System.String? SourceVmFid { get; set; }

        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        [JsonProperty("sourceVmId")]
        public System.String? SourceVmId { get; set; }

        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        [JsonProperty("sourceVmName")]
        public System.String? SourceVmName { get; set; }

        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        [JsonProperty("storageContainerName")]
        public System.String? StorageContainerName { get; set; }

        //      C# -> System.String? UnmountJobInstanceId
        // GraphQL -> unmountJobInstanceId: String! (scalar)
        [JsonProperty("unmountJobInstanceId")]
        public System.String? UnmountJobInstanceId { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        #endregion

    #region methods

    public NutanixLiveMount Set(
        System.String? CdmId = null,
        System.String? Id = null,
        System.Boolean? IsMigrationDisabled = null,
        System.Boolean? IsVmReady = null,
        System.String? MigrationJobInstanceId = null,
        System.String? MigrationJobStatus = null,
        System.String? MountJobInstanceId = null,
        System.String? MountSpec = null,
        DateTime? MountedDate = null,
        System.String? MountedVmFid = null,
        System.String? MountedVmId = null,
        System.String? Name = null,
        System.String? NutanixClusterFid = null,
        System.String? NutanixClusterId = null,
        System.String? NutanixClusterName = null,
        System.String? OrganizationId = null,
        System.String? OwnerId = null,
        System.String? PowerStatus = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotId = null,
        System.String? SourceVmFid = null,
        System.String? SourceVmId = null,
        System.String? SourceVmName = null,
        System.String? StorageContainerName = null,
        System.String? UnmountJobInstanceId = null,
        Cluster? Cluster = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsMigrationDisabled != null ) {
            this.IsMigrationDisabled = IsMigrationDisabled;
        }
        if ( IsVmReady != null ) {
            this.IsVmReady = IsVmReady;
        }
        if ( MigrationJobInstanceId != null ) {
            this.MigrationJobInstanceId = MigrationJobInstanceId;
        }
        if ( MigrationJobStatus != null ) {
            this.MigrationJobStatus = MigrationJobStatus;
        }
        if ( MountJobInstanceId != null ) {
            this.MountJobInstanceId = MountJobInstanceId;
        }
        if ( MountSpec != null ) {
            this.MountSpec = MountSpec;
        }
        if ( MountedDate != null ) {
            this.MountedDate = MountedDate;
        }
        if ( MountedVmFid != null ) {
            this.MountedVmFid = MountedVmFid;
        }
        if ( MountedVmId != null ) {
            this.MountedVmId = MountedVmId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NutanixClusterFid != null ) {
            this.NutanixClusterFid = NutanixClusterFid;
        }
        if ( NutanixClusterId != null ) {
            this.NutanixClusterId = NutanixClusterId;
        }
        if ( NutanixClusterName != null ) {
            this.NutanixClusterName = NutanixClusterName;
        }
        if ( OrganizationId != null ) {
            this.OrganizationId = OrganizationId;
        }
        if ( OwnerId != null ) {
            this.OwnerId = OwnerId;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SourceVmFid != null ) {
            this.SourceVmFid = SourceVmFid;
        }
        if ( SourceVmId != null ) {
            this.SourceVmId = SourceVmId;
        }
        if ( SourceVmName != null ) {
            this.SourceVmName = SourceVmName;
        }
        if ( StorageContainerName != null ) {
            this.StorageContainerName = StorageContainerName;
        }
        if ( UnmountJobInstanceId != null ) {
            this.UnmountJobInstanceId = UnmountJobInstanceId;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
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
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsMigrationDisabled
            // GraphQL -> isMigrationDisabled: Boolean! (scalar)
            if (this.IsMigrationDisabled != null)
            {
                 s += ind + "isMigrationDisabled\n";

            }
            //      C# -> System.Boolean? IsVmReady
            // GraphQL -> isVmReady: Boolean! (scalar)
            if (this.IsVmReady != null)
            {
                 s += ind + "isVmReady\n";

            }
            //      C# -> System.String? MigrationJobInstanceId
            // GraphQL -> migrationJobInstanceId: String (scalar)
            if (this.MigrationJobInstanceId != null)
            {
                 s += ind + "migrationJobInstanceId\n";

            }
            //      C# -> System.String? MigrationJobStatus
            // GraphQL -> migrationJobStatus: String (scalar)
            if (this.MigrationJobStatus != null)
            {
                 s += ind + "migrationJobStatus\n";

            }
            //      C# -> System.String? MountJobInstanceId
            // GraphQL -> mountJobInstanceId: String! (scalar)
            if (this.MountJobInstanceId != null)
            {
                 s += ind + "mountJobInstanceId\n";

            }
            //      C# -> System.String? MountSpec
            // GraphQL -> mountSpec: String! (scalar)
            if (this.MountSpec != null)
            {
                 s += ind + "mountSpec\n";

            }
            //      C# -> DateTime? MountedDate
            // GraphQL -> mountedDate: DateTime (scalar)
            if (this.MountedDate != null)
            {
                 s += ind + "mountedDate\n";

            }
            //      C# -> System.String? MountedVmFid
            // GraphQL -> mountedVmFid: String (scalar)
            if (this.MountedVmFid != null)
            {
                 s += ind + "mountedVmFid\n";

            }
            //      C# -> System.String? MountedVmId
            // GraphQL -> mountedVmId: String (scalar)
            if (this.MountedVmId != null)
            {
                 s += ind + "mountedVmId\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NutanixClusterFid
            // GraphQL -> nutanixClusterFid: String! (scalar)
            if (this.NutanixClusterFid != null)
            {
                 s += ind + "nutanixClusterFid\n";

            }
            //      C# -> System.String? NutanixClusterId
            // GraphQL -> nutanixClusterId: String! (scalar)
            if (this.NutanixClusterId != null)
            {
                 s += ind + "nutanixClusterId\n";

            }
            //      C# -> System.String? NutanixClusterName
            // GraphQL -> nutanixClusterName: String! (scalar)
            if (this.NutanixClusterName != null)
            {
                 s += ind + "nutanixClusterName\n";

            }
            //      C# -> System.String? OrganizationId
            // GraphQL -> organizationId: String! (scalar)
            if (this.OrganizationId != null)
            {
                 s += ind + "organizationId\n";

            }
            //      C# -> System.String? OwnerId
            // GraphQL -> ownerId: String! (scalar)
            if (this.OwnerId != null)
            {
                 s += ind + "ownerId\n";

            }
            //      C# -> System.String? PowerStatus
            // GraphQL -> powerStatus: String! (scalar)
            if (this.PowerStatus != null)
            {
                 s += ind + "powerStatus\n";

            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate != null)
            {
                 s += ind + "snapshotDate\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> System.String? SourceVmFid
            // GraphQL -> sourceVmFid: String! (scalar)
            if (this.SourceVmFid != null)
            {
                 s += ind + "sourceVmFid\n";

            }
            //      C# -> System.String? SourceVmId
            // GraphQL -> sourceVmId: String! (scalar)
            if (this.SourceVmId != null)
            {
                 s += ind + "sourceVmId\n";

            }
            //      C# -> System.String? SourceVmName
            // GraphQL -> sourceVmName: String! (scalar)
            if (this.SourceVmName != null)
            {
                 s += ind + "sourceVmName\n";

            }
            //      C# -> System.String? StorageContainerName
            // GraphQL -> storageContainerName: String (scalar)
            if (this.StorageContainerName != null)
            {
                 s += ind + "storageContainerName\n";

            }
            //      C# -> System.String? UnmountJobInstanceId
            // GraphQL -> unmountJobInstanceId: String! (scalar)
            if (this.UnmountJobInstanceId != null)
            {
                 s += ind + "unmountJobInstanceId\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot != null)
            {
                 s += ind + "sourceSnapshot\n";

                 s += ind + "{\n" + 
                 this.SourceSnapshot.AsFragment(indent+1) + 
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
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsMigrationDisabled
            // GraphQL -> isMigrationDisabled: Boolean! (scalar)
            if (this.IsMigrationDisabled == null && Exploration.Includes(parent + ".isMigrationDisabled$"))
            {
                this.IsMigrationDisabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsVmReady
            // GraphQL -> isVmReady: Boolean! (scalar)
            if (this.IsVmReady == null && Exploration.Includes(parent + ".isVmReady$"))
            {
                this.IsVmReady = new System.Boolean();
            }
            //      C# -> System.String? MigrationJobInstanceId
            // GraphQL -> migrationJobInstanceId: String (scalar)
            if (this.MigrationJobInstanceId == null && Exploration.Includes(parent + ".migrationJobInstanceId$"))
            {
                this.MigrationJobInstanceId = new System.String("FETCH");
            }
            //      C# -> System.String? MigrationJobStatus
            // GraphQL -> migrationJobStatus: String (scalar)
            if (this.MigrationJobStatus == null && Exploration.Includes(parent + ".migrationJobStatus$"))
            {
                this.MigrationJobStatus = new System.String("FETCH");
            }
            //      C# -> System.String? MountJobInstanceId
            // GraphQL -> mountJobInstanceId: String! (scalar)
            if (this.MountJobInstanceId == null && Exploration.Includes(parent + ".mountJobInstanceId$"))
            {
                this.MountJobInstanceId = new System.String("FETCH");
            }
            //      C# -> System.String? MountSpec
            // GraphQL -> mountSpec: String! (scalar)
            if (this.MountSpec == null && Exploration.Includes(parent + ".mountSpec$"))
            {
                this.MountSpec = new System.String("FETCH");
            }
            //      C# -> DateTime? MountedDate
            // GraphQL -> mountedDate: DateTime (scalar)
            if (this.MountedDate == null && Exploration.Includes(parent + ".mountedDate$"))
            {
                this.MountedDate = new DateTime();
            }
            //      C# -> System.String? MountedVmFid
            // GraphQL -> mountedVmFid: String (scalar)
            if (this.MountedVmFid == null && Exploration.Includes(parent + ".mountedVmFid$"))
            {
                this.MountedVmFid = new System.String("FETCH");
            }
            //      C# -> System.String? MountedVmId
            // GraphQL -> mountedVmId: String (scalar)
            if (this.MountedVmId == null && Exploration.Includes(parent + ".mountedVmId$"))
            {
                this.MountedVmId = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NutanixClusterFid
            // GraphQL -> nutanixClusterFid: String! (scalar)
            if (this.NutanixClusterFid == null && Exploration.Includes(parent + ".nutanixClusterFid$"))
            {
                this.NutanixClusterFid = new System.String("FETCH");
            }
            //      C# -> System.String? NutanixClusterId
            // GraphQL -> nutanixClusterId: String! (scalar)
            if (this.NutanixClusterId == null && Exploration.Includes(parent + ".nutanixClusterId$"))
            {
                this.NutanixClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? NutanixClusterName
            // GraphQL -> nutanixClusterName: String! (scalar)
            if (this.NutanixClusterName == null && Exploration.Includes(parent + ".nutanixClusterName$"))
            {
                this.NutanixClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? OrganizationId
            // GraphQL -> organizationId: String! (scalar)
            if (this.OrganizationId == null && Exploration.Includes(parent + ".organizationId$"))
            {
                this.OrganizationId = new System.String("FETCH");
            }
            //      C# -> System.String? OwnerId
            // GraphQL -> ownerId: String! (scalar)
            if (this.OwnerId == null && Exploration.Includes(parent + ".ownerId$"))
            {
                this.OwnerId = new System.String("FETCH");
            }
            //      C# -> System.String? PowerStatus
            // GraphQL -> powerStatus: String! (scalar)
            if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus$"))
            {
                this.PowerStatus = new System.String("FETCH");
            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate$"))
            {
                this.SnapshotDate = new DateTime();
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> System.String? SourceVmFid
            // GraphQL -> sourceVmFid: String! (scalar)
            if (this.SourceVmFid == null && Exploration.Includes(parent + ".sourceVmFid$"))
            {
                this.SourceVmFid = new System.String("FETCH");
            }
            //      C# -> System.String? SourceVmId
            // GraphQL -> sourceVmId: String! (scalar)
            if (this.SourceVmId == null && Exploration.Includes(parent + ".sourceVmId$"))
            {
                this.SourceVmId = new System.String("FETCH");
            }
            //      C# -> System.String? SourceVmName
            // GraphQL -> sourceVmName: String! (scalar)
            if (this.SourceVmName == null && Exploration.Includes(parent + ".sourceVmName$"))
            {
                this.SourceVmName = new System.String("FETCH");
            }
            //      C# -> System.String? StorageContainerName
            // GraphQL -> storageContainerName: String (scalar)
            if (this.StorageContainerName == null && Exploration.Includes(parent + ".storageContainerName$"))
            {
                this.StorageContainerName = new System.String("FETCH");
            }
            //      C# -> System.String? UnmountJobInstanceId
            // GraphQL -> unmountJobInstanceId: String! (scalar)
            if (this.UnmountJobInstanceId == null && Exploration.Includes(parent + ".unmountJobInstanceId$"))
            {
                this.UnmountJobInstanceId = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
            if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
            {
                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFragment(parent + ".sourceSnapshot");
            }
        }


    #endregion

    } // class NutanixLiveMount
    #endregion

    public static class ListNutanixLiveMountExtensions
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
            this List<NutanixLiveMount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NutanixLiveMount> list, 
            String parent = "")
        {
            var item = new NutanixLiveMount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types