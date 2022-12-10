// ClusterDisk.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    #region ClusterDisk
    public class ClusterDisk: IFragment
    {
        #region members
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        [JsonProperty("capacityBytes")]
        public System.Int64? CapacityBytes { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean! (scalar)
        [JsonProperty("isResizable")]
        public System.Boolean? IsResizable { get; set; }

        //      C# -> System.Boolean? LedStatus
        // GraphQL -> ledStatus: Boolean (scalar)
        [JsonProperty("ledStatus")]
        public System.Boolean? LedStatus { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        [JsonProperty("serial")]
        public System.String? Serial { get; set; }

        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        [JsonProperty("unallocatedBytes")]
        public System.Int64? UnallocatedBytes { get; set; }

        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        [JsonProperty("usableBytes")]
        public System.Int64? UsableBytes { get; set; }

        //      C# -> ClusterDiskType? DiskType
        // GraphQL -> diskType: ClusterDiskType! (enum)
        [JsonProperty("diskType")]
        public ClusterDiskType? DiskType { get; set; }

        //      C# -> ClusterDiskStatus? Status
        // GraphQL -> status: ClusterDiskStatus! (enum)
        [JsonProperty("status")]
        public ClusterDiskStatus? Status { get; set; }

        #endregion

    #region methods

    public ClusterDisk Set(
        System.Int64? CapacityBytes = null,
        System.String? ClusterId = null,
        System.String? DiskId = null,
        System.String? Id = null,
        System.Boolean? IsEncrypted = null,
        System.Boolean? IsResizable = null,
        System.Boolean? LedStatus = null,
        System.String? NodeId = null,
        System.String? Path = null,
        System.String? Serial = null,
        System.Int64? UnallocatedBytes = null,
        System.Int64? UsableBytes = null,
        ClusterDiskType? DiskType = null,
        ClusterDiskStatus? Status = null
    ) 
    {
        if ( CapacityBytes != null ) {
            this.CapacityBytes = CapacityBytes;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( IsResizable != null ) {
            this.IsResizable = IsResizable;
        }
        if ( LedStatus != null ) {
            this.LedStatus = LedStatus;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Serial != null ) {
            this.Serial = Serial;
        }
        if ( UnallocatedBytes != null ) {
            this.UnallocatedBytes = UnallocatedBytes;
        }
        if ( UsableBytes != null ) {
            this.UsableBytes = UsableBytes;
        }
        if ( DiskType != null ) {
            this.DiskType = DiskType;
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
            //      C# -> System.Int64? CapacityBytes
            // GraphQL -> capacityBytes: Long! (scalar)
            if (this.CapacityBytes != null)
            {
                 s += ind + "capacityBytes\n";

            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.String? DiskId
            // GraphQL -> diskId: String! (scalar)
            if (this.DiskId != null)
            {
                 s += ind + "diskId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsEncrypted
            // GraphQL -> isEncrypted: Boolean! (scalar)
            if (this.IsEncrypted != null)
            {
                 s += ind + "isEncrypted\n";

            }
            //      C# -> System.Boolean? IsResizable
            // GraphQL -> isResizable: Boolean! (scalar)
            if (this.IsResizable != null)
            {
                 s += ind + "isResizable\n";

            }
            //      C# -> System.Boolean? LedStatus
            // GraphQL -> ledStatus: Boolean (scalar)
            if (this.LedStatus != null)
            {
                 s += ind + "ledStatus\n";

            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> System.String? Serial
            // GraphQL -> serial: String (scalar)
            if (this.Serial != null)
            {
                 s += ind + "serial\n";

            }
            //      C# -> System.Int64? UnallocatedBytes
            // GraphQL -> unallocatedBytes: Long (scalar)
            if (this.UnallocatedBytes != null)
            {
                 s += ind + "unallocatedBytes\n";

            }
            //      C# -> System.Int64? UsableBytes
            // GraphQL -> usableBytes: Long (scalar)
            if (this.UsableBytes != null)
            {
                 s += ind + "usableBytes\n";

            }
            //      C# -> ClusterDiskType? DiskType
            // GraphQL -> diskType: ClusterDiskType! (enum)
            if (this.DiskType != null)
            {
                 s += ind + "diskType\n";

            }
            //      C# -> ClusterDiskStatus? Status
            // GraphQL -> status: ClusterDiskStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? CapacityBytes
            // GraphQL -> capacityBytes: Long! (scalar)
            if (this.CapacityBytes == null && Exploration.Includes(parent + ".capacityBytes$"))
            {
                this.CapacityBytes = new System.Int64();
            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? DiskId
            // GraphQL -> diskId: String! (scalar)
            if (this.DiskId == null && Exploration.Includes(parent + ".diskId$"))
            {
                this.DiskId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsEncrypted
            // GraphQL -> isEncrypted: Boolean! (scalar)
            if (this.IsEncrypted == null && Exploration.Includes(parent + ".isEncrypted$"))
            {
                this.IsEncrypted = new System.Boolean();
            }
            //      C# -> System.Boolean? IsResizable
            // GraphQL -> isResizable: Boolean! (scalar)
            if (this.IsResizable == null && Exploration.Includes(parent + ".isResizable$"))
            {
                this.IsResizable = new System.Boolean();
            }
            //      C# -> System.Boolean? LedStatus
            // GraphQL -> ledStatus: Boolean (scalar)
            if (this.LedStatus == null && Exploration.Includes(parent + ".ledStatus$"))
            {
                this.LedStatus = new System.Boolean();
            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> System.String? Serial
            // GraphQL -> serial: String (scalar)
            if (this.Serial == null && Exploration.Includes(parent + ".serial$"))
            {
                this.Serial = new System.String("FETCH");
            }
            //      C# -> System.Int64? UnallocatedBytes
            // GraphQL -> unallocatedBytes: Long (scalar)
            if (this.UnallocatedBytes == null && Exploration.Includes(parent + ".unallocatedBytes$"))
            {
                this.UnallocatedBytes = new System.Int64();
            }
            //      C# -> System.Int64? UsableBytes
            // GraphQL -> usableBytes: Long (scalar)
            if (this.UsableBytes == null && Exploration.Includes(parent + ".usableBytes$"))
            {
                this.UsableBytes = new System.Int64();
            }
            //      C# -> ClusterDiskType? DiskType
            // GraphQL -> diskType: ClusterDiskType! (enum)
            if (this.DiskType == null && Exploration.Includes(parent + ".diskType$"))
            {
                this.DiskType = new ClusterDiskType();
            }
            //      C# -> ClusterDiskStatus? Status
            // GraphQL -> status: ClusterDiskStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ClusterDiskStatus();
            }
        }


    #endregion

    } // class ClusterDisk
    #endregion

    public static class ListClusterDiskExtensions
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
            this List<ClusterDisk> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterDisk> list, 
            String parent = "")
        {
            var item = new ClusterDisk();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types