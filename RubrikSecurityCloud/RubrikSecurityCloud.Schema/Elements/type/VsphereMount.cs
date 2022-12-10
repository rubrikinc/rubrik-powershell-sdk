// VsphereMount.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:07.
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
    #region VsphereMount
    public class VsphereMount: IFragment
    {
        #region members
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        [JsonProperty("attachingDiskCount")]
        public System.Int32? AttachingDiskCount { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        [JsonProperty("hasAttachingDisk")]
        public System.Boolean? HasAttachingDisk { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MigrateDatastoreRequestId
        // GraphQL -> migrateDatastoreRequestId: String (scalar)
        [JsonProperty("migrateDatastoreRequestId")]
        public System.String? MigrateDatastoreRequestId { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        [JsonProperty("mountTimestamp")]
        public DateTime? MountTimestamp { get; set; }

        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        [JsonProperty("newVmName")]
        public System.String? NewVmName { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> VsphereHost? Host
        // GraphQL -> host: VsphereHost (type)
        [JsonProperty("host")]
        public VsphereHost? Host { get; set; }

        //      C# -> VsphereVm? NewVm
        // GraphQL -> newVm: VsphereVm (type)
        [JsonProperty("newVm")]
        public VsphereVm? NewVm { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        //      C# -> VsphereVm? SourceVm
        // GraphQL -> sourceVm: VsphereVm (type)
        [JsonProperty("sourceVm")]
        public VsphereVm? SourceVm { get; set; }

        //      C# -> VsphereMountStatus? Status
        // GraphQL -> status: VsphereMountStatus! (enum)
        [JsonProperty("status")]
        public VsphereMountStatus? Status { get; set; }

        #endregion

    #region methods

    public VsphereMount Set(
        System.Int32? AttachingDiskCount = null,
        System.String? CdmId = null,
        System.String? ClusterName = null,
        System.Boolean? HasAttachingDisk = null,
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MigrateDatastoreRequestId = null,
        System.String? MountRequestId = null,
        DateTime? MountTimestamp = null,
        System.String? NewVmName = null,
        System.String? UnmountRequestId = null,
        AuthorizedOperations? AuthorizedOperations = null,
        Cluster? Cluster = null,
        VsphereHost? Host = null,
        VsphereVm? NewVm = null,
        CdmSnapshot? SourceSnapshot = null,
        VsphereVm? SourceVm = null,
        VsphereMountStatus? Status = null
    ) 
    {
        if ( AttachingDiskCount != null ) {
            this.AttachingDiskCount = AttachingDiskCount;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( HasAttachingDisk != null ) {
            this.HasAttachingDisk = HasAttachingDisk;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MigrateDatastoreRequestId != null ) {
            this.MigrateDatastoreRequestId = MigrateDatastoreRequestId;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( NewVmName != null ) {
            this.NewVmName = NewVmName;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( NewVm != null ) {
            this.NewVm = NewVm;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
        }
        if ( SourceVm != null ) {
            this.SourceVm = SourceVm;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName != null)
            {
                 s += ind + "clusterName\n";

            }
            //      C# -> System.Boolean? HasAttachingDisk
            // GraphQL -> hasAttachingDisk: Boolean (scalar)
            if (this.HasAttachingDisk != null)
            {
                 s += ind + "hasAttachingDisk\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
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
            //      C# -> System.String? MigrateDatastoreRequestId
            // GraphQL -> migrateDatastoreRequestId: String (scalar)
            if (this.MigrateDatastoreRequestId != null)
            {
                 s += ind + "migrateDatastoreRequestId\n";

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
            //      C# -> System.String? NewVmName
            // GraphQL -> newVmName: String (scalar)
            if (this.NewVmName != null)
            {
                 s += ind + "newVmName\n";

            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId != null)
            {
                 s += ind + "unmountRequestId\n";

            }
            //      C# -> AuthorizedOperations? AuthorizedOperations
            // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

                 s += ind + "{\n" + 
                 this.AuthorizedOperations.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> VsphereHost? Host
            // GraphQL -> host: VsphereHost (type)
            if (this.Host != null)
            {
                 s += ind + "host\n";

                 s += ind + "{\n" + 
                 this.Host.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VsphereVm? NewVm
            // GraphQL -> newVm: VsphereVm (type)
            if (this.NewVm != null)
            {
                 s += ind + "newVm\n";

                 s += ind + "{\n" + 
                 this.NewVm.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot (type)
            if (this.SourceSnapshot != null)
            {
                 s += ind + "sourceSnapshot\n";

                 s += ind + "{\n" + 
                 this.SourceSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VsphereVm? SourceVm
            // GraphQL -> sourceVm: VsphereVm (type)
            if (this.SourceVm != null)
            {
                 s += ind + "sourceVm\n";

                 s += ind + "{\n" + 
                 this.SourceVm.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VsphereMountStatus? Status
            // GraphQL -> status: VsphereMountStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

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
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName$"))
            {
                this.ClusterName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasAttachingDisk
            // GraphQL -> hasAttachingDisk: Boolean (scalar)
            if (this.HasAttachingDisk == null && Exploration.Includes(parent + ".hasAttachingDisk$"))
            {
                this.HasAttachingDisk = new System.Boolean();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
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
            //      C# -> System.String? MigrateDatastoreRequestId
            // GraphQL -> migrateDatastoreRequestId: String (scalar)
            if (this.MigrateDatastoreRequestId == null && Exploration.Includes(parent + ".migrateDatastoreRequestId$"))
            {
                this.MigrateDatastoreRequestId = new System.String("FETCH");
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
            //      C# -> System.String? NewVmName
            // GraphQL -> newVmName: String (scalar)
            if (this.NewVmName == null && Exploration.Includes(parent + ".newVmName$"))
            {
                this.NewVmName = new System.String("FETCH");
            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId$"))
            {
                this.UnmountRequestId = new System.String("FETCH");
            }
            //      C# -> AuthorizedOperations? AuthorizedOperations
            // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations"))
            {
                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFragment(parent + ".authorizedOperations");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> VsphereHost? Host
            // GraphQL -> host: VsphereHost (type)
            if (this.Host == null && Exploration.Includes(parent + ".host"))
            {
                this.Host = new VsphereHost();
                this.Host.ApplyExploratoryFragment(parent + ".host");
            }
            //      C# -> VsphereVm? NewVm
            // GraphQL -> newVm: VsphereVm (type)
            if (this.NewVm == null && Exploration.Includes(parent + ".newVm"))
            {
                this.NewVm = new VsphereVm();
                this.NewVm.ApplyExploratoryFragment(parent + ".newVm");
            }
            //      C# -> CdmSnapshot? SourceSnapshot
            // GraphQL -> sourceSnapshot: CdmSnapshot (type)
            if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
            {
                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFragment(parent + ".sourceSnapshot");
            }
            //      C# -> VsphereVm? SourceVm
            // GraphQL -> sourceVm: VsphereVm (type)
            if (this.SourceVm == null && Exploration.Includes(parent + ".sourceVm"))
            {
                this.SourceVm = new VsphereVm();
                this.SourceVm.ApplyExploratoryFragment(parent + ".sourceVm");
            }
            //      C# -> VsphereMountStatus? Status
            // GraphQL -> status: VsphereMountStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new VsphereMountStatus();
            }
        }


    #endregion

    } // class VsphereMount
    #endregion

    public static class ListVsphereMountExtensions
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
            this List<VsphereMount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VsphereMount> list, 
            String parent = "")
        {
            var item = new VsphereMount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types