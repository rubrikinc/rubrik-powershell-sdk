// ManagedVolumeSnapshotStats.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:06.
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
    #region ManagedVolumeSnapshotStats
    public class ManagedVolumeSnapshotStats: IFragment
    {
        #region members
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long! (scalar)
        [JsonProperty("logicalBytes")]
        public System.Int64? LogicalBytes { get; set; }

        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long! (scalar)
        [JsonProperty("physicalBytes")]
        public System.Int64? PhysicalBytes { get; set; }

        //      C# -> System.Int64? TotalInodes
        // GraphQL -> totalInodes: Long (scalar)
        [JsonProperty("totalInodes")]
        public System.Int64? TotalInodes { get; set; }

        //      C# -> System.Int64? UsedInodes
        // GraphQL -> usedInodes: Long (scalar)
        [JsonProperty("usedInodes")]
        public System.Int64? UsedInodes { get; set; }

        #endregion

    #region methods

    public ManagedVolumeSnapshotStats Set(
        System.Int64? LogicalBytes = null,
        System.Int64? PhysicalBytes = null,
        System.Int64? TotalInodes = null,
        System.Int64? UsedInodes = null
    ) 
    {
        if ( LogicalBytes != null ) {
            this.LogicalBytes = LogicalBytes;
        }
        if ( PhysicalBytes != null ) {
            this.PhysicalBytes = PhysicalBytes;
        }
        if ( TotalInodes != null ) {
            this.TotalInodes = TotalInodes;
        }
        if ( UsedInodes != null ) {
            this.UsedInodes = UsedInodes;
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
            //      C# -> System.Int64? LogicalBytes
            // GraphQL -> logicalBytes: Long! (scalar)
            if (this.LogicalBytes != null)
            {
                 s += ind + "logicalBytes\n";

            }
            //      C# -> System.Int64? PhysicalBytes
            // GraphQL -> physicalBytes: Long! (scalar)
            if (this.PhysicalBytes != null)
            {
                 s += ind + "physicalBytes\n";

            }
            //      C# -> System.Int64? TotalInodes
            // GraphQL -> totalInodes: Long (scalar)
            if (this.TotalInodes != null)
            {
                 s += ind + "totalInodes\n";

            }
            //      C# -> System.Int64? UsedInodes
            // GraphQL -> usedInodes: Long (scalar)
            if (this.UsedInodes != null)
            {
                 s += ind + "usedInodes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? LogicalBytes
            // GraphQL -> logicalBytes: Long! (scalar)
            if (this.LogicalBytes == null && Exploration.Includes(parent + ".logicalBytes$"))
            {
                this.LogicalBytes = new System.Int64();
            }
            //      C# -> System.Int64? PhysicalBytes
            // GraphQL -> physicalBytes: Long! (scalar)
            if (this.PhysicalBytes == null && Exploration.Includes(parent + ".physicalBytes$"))
            {
                this.PhysicalBytes = new System.Int64();
            }
            //      C# -> System.Int64? TotalInodes
            // GraphQL -> totalInodes: Long (scalar)
            if (this.TotalInodes == null && Exploration.Includes(parent + ".totalInodes$"))
            {
                this.TotalInodes = new System.Int64();
            }
            //      C# -> System.Int64? UsedInodes
            // GraphQL -> usedInodes: Long (scalar)
            if (this.UsedInodes == null && Exploration.Includes(parent + ".usedInodes$"))
            {
                this.UsedInodes = new System.Int64();
            }
        }


    #endregion

    } // class ManagedVolumeSnapshotStats
    #endregion

    public static class ListManagedVolumeSnapshotStatsExtensions
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
            this List<ManagedVolumeSnapshotStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeSnapshotStats> list, 
            String parent = "")
        {
            var item = new ManagedVolumeSnapshotStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types