// VmwareVmMountSummaryV1.cs
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
    #region VmwareVmMountSummaryV1
    public class VmwareVmMountSummaryV1: IFragment
    {
        #region members
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        [JsonProperty("attachingDiskCount")]
        public System.Int32? AttachingDiskCount { get; set; }

        //      C# -> System.Boolean? CreateDatastoreOnlyMount
        // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
        [JsonProperty("createDatastoreOnlyMount")]
        public System.Boolean? CreateDatastoreOnlyMount { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String (scalar)
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }

        //      C# -> System.Boolean? DatastoreReady
        // GraphQL -> datastoreReady: Boolean (scalar)
        [JsonProperty("datastoreReady")]
        public System.Boolean? DatastoreReady { get; set; }

        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        [JsonProperty("hasAttachingDisk")]
        public System.Boolean? HasAttachingDisk { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        [JsonProperty("mountTimestamp")]
        public DateTime? MountTimestamp { get; set; }

        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        [JsonProperty("mountedVmId")]
        public System.String? MountedVmId { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        #endregion

    #region methods

    public VmwareVmMountSummaryV1 Set(
        System.Int32? AttachingDiskCount = null,
        System.Boolean? CreateDatastoreOnlyMount = null,
        System.String? DatastoreName = null,
        System.Boolean? DatastoreReady = null,
        System.Boolean? HasAttachingDisk = null,
        System.String? HostId = null,
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MountRequestId = null,
        DateTime? MountTimestamp = null,
        System.String? MountedVmId = null,
        DateTime? SnapshotDate = null,
        System.String? UnmountRequestId = null,
        System.String? VmId = null
    ) 
    {
        if ( AttachingDiskCount != null ) {
            this.AttachingDiskCount = AttachingDiskCount;
        }
        if ( CreateDatastoreOnlyMount != null ) {
            this.CreateDatastoreOnlyMount = CreateDatastoreOnlyMount;
        }
        if ( DatastoreName != null ) {
            this.DatastoreName = DatastoreName;
        }
        if ( DatastoreReady != null ) {
            this.DatastoreReady = DatastoreReady;
        }
        if ( HasAttachingDisk != null ) {
            this.HasAttachingDisk = HasAttachingDisk;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( MountedVmId != null ) {
            this.MountedVmId = MountedVmId;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
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
            //      C# -> System.Int32? AttachingDiskCount
            // GraphQL -> attachingDiskCount: Int (scalar)
            if (this.AttachingDiskCount != null)
            {
                 s += ind + "attachingDiskCount\n";

            }
            //      C# -> System.Boolean? CreateDatastoreOnlyMount
            // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
            if (this.CreateDatastoreOnlyMount != null)
            {
                 s += ind + "createDatastoreOnlyMount\n";

            }
            //      C# -> System.String? DatastoreName
            // GraphQL -> datastoreName: String (scalar)
            if (this.DatastoreName != null)
            {
                 s += ind + "datastoreName\n";

            }
            //      C# -> System.Boolean? DatastoreReady
            // GraphQL -> datastoreReady: Boolean (scalar)
            if (this.DatastoreReady != null)
            {
                 s += ind + "datastoreReady\n";

            }
            //      C# -> System.Boolean? HasAttachingDisk
            // GraphQL -> hasAttachingDisk: Boolean (scalar)
            if (this.HasAttachingDisk != null)
            {
                 s += ind + "hasAttachingDisk\n";

            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady != null)
            {
                 s += ind + "isReady\n";

            }
            //      C# -> System.String? MountRequestId
            // GraphQL -> mountRequestId: String (scalar)
            if (this.MountRequestId != null)
            {
                 s += ind + "mountRequestId\n";

            }
            //      C# -> DateTime? MountTimestamp
            // GraphQL -> mountTimestamp: DateTime (scalar)
            if (this.MountTimestamp != null)
            {
                 s += ind + "mountTimestamp\n";

            }
            //      C# -> System.String? MountedVmId
            // GraphQL -> mountedVmId: String (scalar)
            if (this.MountedVmId != null)
            {
                 s += ind + "mountedVmId\n";

            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate != null)
            {
                 s += ind + "snapshotDate\n";

            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId != null)
            {
                 s += ind + "unmountRequestId\n";

            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId != null)
            {
                 s += ind + "vmId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? AttachingDiskCount
            // GraphQL -> attachingDiskCount: Int (scalar)
            if (this.AttachingDiskCount == null && Exploration.Includes(parent + ".attachingDiskCount$"))
            {
                this.AttachingDiskCount = new System.Int32();
            }
            //      C# -> System.Boolean? CreateDatastoreOnlyMount
            // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
            if (this.CreateDatastoreOnlyMount == null && Exploration.Includes(parent + ".createDatastoreOnlyMount$"))
            {
                this.CreateDatastoreOnlyMount = new System.Boolean();
            }
            //      C# -> System.String? DatastoreName
            // GraphQL -> datastoreName: String (scalar)
            if (this.DatastoreName == null && Exploration.Includes(parent + ".datastoreName$"))
            {
                this.DatastoreName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? DatastoreReady
            // GraphQL -> datastoreReady: Boolean (scalar)
            if (this.DatastoreReady == null && Exploration.Includes(parent + ".datastoreReady$"))
            {
                this.DatastoreReady = new System.Boolean();
            }
            //      C# -> System.Boolean? HasAttachingDisk
            // GraphQL -> hasAttachingDisk: Boolean (scalar)
            if (this.HasAttachingDisk == null && Exploration.Includes(parent + ".hasAttachingDisk$"))
            {
                this.HasAttachingDisk = new System.Boolean();
            }
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady == null && Exploration.Includes(parent + ".isReady$"))
            {
                this.IsReady = new System.Boolean();
            }
            //      C# -> System.String? MountRequestId
            // GraphQL -> mountRequestId: String (scalar)
            if (this.MountRequestId == null && Exploration.Includes(parent + ".mountRequestId$"))
            {
                this.MountRequestId = new System.String("FETCH");
            }
            //      C# -> DateTime? MountTimestamp
            // GraphQL -> mountTimestamp: DateTime (scalar)
            if (this.MountTimestamp == null && Exploration.Includes(parent + ".mountTimestamp$"))
            {
                this.MountTimestamp = new DateTime();
            }
            //      C# -> System.String? MountedVmId
            // GraphQL -> mountedVmId: String (scalar)
            if (this.MountedVmId == null && Exploration.Includes(parent + ".mountedVmId$"))
            {
                this.MountedVmId = new System.String("FETCH");
            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate$"))
            {
                this.SnapshotDate = new DateTime();
            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId$"))
            {
                this.UnmountRequestId = new System.String("FETCH");
            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId == null && Exploration.Includes(parent + ".vmId$"))
            {
                this.VmId = new System.String("FETCH");
            }
        }


    #endregion

    } // class VmwareVmMountSummaryV1
    #endregion

    public static class ListVmwareVmMountSummaryV1Extensions
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
            this List<VmwareVmMountSummaryV1> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareVmMountSummaryV1> list, 
            String parent = "")
        {
            var item = new VmwareVmMountSummaryV1();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types