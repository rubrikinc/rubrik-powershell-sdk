// DiskInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:17.
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
    #region DiskInfo
    public class DiskInfo: IFragment
    {
        #region members
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        [JsonProperty("capacityBytes")]
        public System.Int64? CapacityBytes { get; set; }

        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean (scalar)
        [JsonProperty("isResizable")]
        public System.Boolean? IsResizable { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        [JsonProperty("unallocatedBytes")]
        public System.Int64? UnallocatedBytes { get; set; }

        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        [JsonProperty("usableBytes")]
        public System.Int64? UsableBytes { get; set; }

        //      C# -> DiskStatus? DiskStatus
        // GraphQL -> diskStatus: DiskStatus (type)
        [JsonProperty("diskStatus")]
        public DiskStatus? DiskStatus { get; set; }

        #endregion

    #region methods

    public DiskInfo Set(
        System.Int64? CapacityBytes = null,
        System.Boolean? IsResizable = null,
        System.String? Path = null,
        System.Int64? UnallocatedBytes = null,
        System.Int64? UsableBytes = null,
        DiskStatus? DiskStatus = null
    ) 
    {
        if ( CapacityBytes != null ) {
            this.CapacityBytes = CapacityBytes;
        }
        if ( IsResizable != null ) {
            this.IsResizable = IsResizable;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( UnallocatedBytes != null ) {
            this.UnallocatedBytes = UnallocatedBytes;
        }
        if ( UsableBytes != null ) {
            this.UsableBytes = UsableBytes;
        }
        if ( DiskStatus != null ) {
            this.DiskStatus = DiskStatus;
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
            //      C# -> System.Boolean? IsResizable
            // GraphQL -> isResizable: Boolean (scalar)
            if (this.IsResizable != null)
            {
                 s += ind + "isResizable\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

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
            //      C# -> DiskStatus? DiskStatus
            // GraphQL -> diskStatus: DiskStatus (type)
            if (this.DiskStatus != null)
            {
                 s += ind + "diskStatus\n";

                 s += ind + "{\n" + 
                 this.DiskStatus.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> System.Boolean? IsResizable
            // GraphQL -> isResizable: Boolean (scalar)
            if (this.IsResizable == null && Exploration.Includes(parent + ".isResizable$"))
            {
                this.IsResizable = new System.Boolean();
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
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
            //      C# -> DiskStatus? DiskStatus
            // GraphQL -> diskStatus: DiskStatus (type)
            if (this.DiskStatus == null && Exploration.Includes(parent + ".diskStatus"))
            {
                this.DiskStatus = new DiskStatus();
                this.DiskStatus.ApplyExploratoryFragment(parent + ".diskStatus");
            }
        }


    #endregion

    } // class DiskInfo
    #endregion

    public static class ListDiskInfoExtensions
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
            this List<DiskInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DiskInfo> list, 
            String parent = "")
        {
            var item = new DiskInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types