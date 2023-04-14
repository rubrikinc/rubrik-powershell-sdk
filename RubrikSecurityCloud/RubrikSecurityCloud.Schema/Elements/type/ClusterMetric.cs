// ClusterMetric.cs
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
    #region ClusterMetric
    public class ClusterMetric: IFragment
    {
        #region members
        //      C# -> System.Int64? AvailableCapacity
        // GraphQL -> availableCapacity: Long! (scalar)
        [JsonProperty("availableCapacity")]
        public System.Int64? AvailableCapacity { get; set; }

        //      C# -> System.Int64? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Long! (scalar)
        [JsonProperty("ingestedArchivalStorage")]
        public System.Int64? IngestedArchivalStorage { get; set; }

        //      C# -> System.Int64? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
        [JsonProperty("ingestedSnapshotStorage")]
        public System.Int64? IngestedSnapshotStorage { get; set; }

        //      C# -> DateTime? LastUpdateTime
        // GraphQL -> lastUpdateTime: DateTime! (scalar)
        [JsonProperty("lastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; }

        //      C# -> System.Int64? LiveMountCapacity
        // GraphQL -> liveMountCapacity: Long! (scalar)
        [JsonProperty("liveMountCapacity")]
        public System.Int64? LiveMountCapacity { get; set; }

        //      C# -> System.Int64? MiscellaneousCapacity
        // GraphQL -> miscellaneousCapacity: Long! (scalar)
        [JsonProperty("miscellaneousCapacity")]
        public System.Int64? MiscellaneousCapacity { get; set; }

        //      C# -> System.Int64? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Long! (scalar)
        [JsonProperty("physicalArchivalStorage")]
        public System.Int64? PhysicalArchivalStorage { get; set; }

        //      C# -> System.Int64? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Long! (scalar)
        [JsonProperty("physicalSnapshotStorage")]
        public System.Int64? PhysicalSnapshotStorage { get; set; }

        //      C# -> System.Int64? SnapshotCapacity
        // GraphQL -> snapshotCapacity: Long! (scalar)
        [JsonProperty("snapshotCapacity")]
        public System.Int64? SnapshotCapacity { get; set; }

        //      C# -> System.Int64? TotalCapacity
        // GraphQL -> totalCapacity: Long! (scalar)
        [JsonProperty("totalCapacity")]
        public System.Int64? TotalCapacity { get; set; }

        //      C# -> System.Int64? UsedCapacity
        // GraphQL -> usedCapacity: Long! (scalar)
        [JsonProperty("usedCapacity")]
        public System.Int64? UsedCapacity { get; set; }

        #endregion

    #region methods

    public ClusterMetric Set(
        System.Int64? AvailableCapacity = null,
        System.Int64? IngestedArchivalStorage = null,
        System.Int64? IngestedSnapshotStorage = null,
        DateTime? LastUpdateTime = null,
        System.Int64? LiveMountCapacity = null,
        System.Int64? MiscellaneousCapacity = null,
        System.Int64? PhysicalArchivalStorage = null,
        System.Int64? PhysicalSnapshotStorage = null,
        System.Int64? SnapshotCapacity = null,
        System.Int64? TotalCapacity = null,
        System.Int64? UsedCapacity = null
    ) 
    {
        if ( AvailableCapacity != null ) {
            this.AvailableCapacity = AvailableCapacity;
        }
        if ( IngestedArchivalStorage != null ) {
            this.IngestedArchivalStorage = IngestedArchivalStorage;
        }
        if ( IngestedSnapshotStorage != null ) {
            this.IngestedSnapshotStorage = IngestedSnapshotStorage;
        }
        if ( LastUpdateTime != null ) {
            this.LastUpdateTime = LastUpdateTime;
        }
        if ( LiveMountCapacity != null ) {
            this.LiveMountCapacity = LiveMountCapacity;
        }
        if ( MiscellaneousCapacity != null ) {
            this.MiscellaneousCapacity = MiscellaneousCapacity;
        }
        if ( PhysicalArchivalStorage != null ) {
            this.PhysicalArchivalStorage = PhysicalArchivalStorage;
        }
        if ( PhysicalSnapshotStorage != null ) {
            this.PhysicalSnapshotStorage = PhysicalSnapshotStorage;
        }
        if ( SnapshotCapacity != null ) {
            this.SnapshotCapacity = SnapshotCapacity;
        }
        if ( TotalCapacity != null ) {
            this.TotalCapacity = TotalCapacity;
        }
        if ( UsedCapacity != null ) {
            this.UsedCapacity = UsedCapacity;
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
            //      C# -> System.Int64? AvailableCapacity
            // GraphQL -> availableCapacity: Long! (scalar)
            if (this.AvailableCapacity != null)
            {
                 s += ind + "availableCapacity\n";

            }
            //      C# -> System.Int64? IngestedArchivalStorage
            // GraphQL -> ingestedArchivalStorage: Long! (scalar)
            if (this.IngestedArchivalStorage != null)
            {
                 s += ind + "ingestedArchivalStorage\n";

            }
            //      C# -> System.Int64? IngestedSnapshotStorage
            // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
            if (this.IngestedSnapshotStorage != null)
            {
                 s += ind + "ingestedSnapshotStorage\n";

            }
            //      C# -> DateTime? LastUpdateTime
            // GraphQL -> lastUpdateTime: DateTime! (scalar)
            if (this.LastUpdateTime != null)
            {
                 s += ind + "lastUpdateTime\n";

            }
            //      C# -> System.Int64? LiveMountCapacity
            // GraphQL -> liveMountCapacity: Long! (scalar)
            if (this.LiveMountCapacity != null)
            {
                 s += ind + "liveMountCapacity\n";

            }
            //      C# -> System.Int64? MiscellaneousCapacity
            // GraphQL -> miscellaneousCapacity: Long! (scalar)
            if (this.MiscellaneousCapacity != null)
            {
                 s += ind + "miscellaneousCapacity\n";

            }
            //      C# -> System.Int64? PhysicalArchivalStorage
            // GraphQL -> physicalArchivalStorage: Long! (scalar)
            if (this.PhysicalArchivalStorage != null)
            {
                 s += ind + "physicalArchivalStorage\n";

            }
            //      C# -> System.Int64? PhysicalSnapshotStorage
            // GraphQL -> physicalSnapshotStorage: Long! (scalar)
            if (this.PhysicalSnapshotStorage != null)
            {
                 s += ind + "physicalSnapshotStorage\n";

            }
            //      C# -> System.Int64? SnapshotCapacity
            // GraphQL -> snapshotCapacity: Long! (scalar)
            if (this.SnapshotCapacity != null)
            {
                 s += ind + "snapshotCapacity\n";

            }
            //      C# -> System.Int64? TotalCapacity
            // GraphQL -> totalCapacity: Long! (scalar)
            if (this.TotalCapacity != null)
            {
                 s += ind + "totalCapacity\n";

            }
            //      C# -> System.Int64? UsedCapacity
            // GraphQL -> usedCapacity: Long! (scalar)
            if (this.UsedCapacity != null)
            {
                 s += ind + "usedCapacity\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? AvailableCapacity
            // GraphQL -> availableCapacity: Long! (scalar)
            if (this.AvailableCapacity == null && Exploration.Includes(parent + ".availableCapacity$"))
            {
                this.AvailableCapacity = new System.Int64();
            }
            //      C# -> System.Int64? IngestedArchivalStorage
            // GraphQL -> ingestedArchivalStorage: Long! (scalar)
            if (this.IngestedArchivalStorage == null && Exploration.Includes(parent + ".ingestedArchivalStorage$"))
            {
                this.IngestedArchivalStorage = new System.Int64();
            }
            //      C# -> System.Int64? IngestedSnapshotStorage
            // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
            if (this.IngestedSnapshotStorage == null && Exploration.Includes(parent + ".ingestedSnapshotStorage$"))
            {
                this.IngestedSnapshotStorage = new System.Int64();
            }
            //      C# -> DateTime? LastUpdateTime
            // GraphQL -> lastUpdateTime: DateTime! (scalar)
            if (this.LastUpdateTime == null && Exploration.Includes(parent + ".lastUpdateTime$"))
            {
                this.LastUpdateTime = new DateTime();
            }
            //      C# -> System.Int64? LiveMountCapacity
            // GraphQL -> liveMountCapacity: Long! (scalar)
            if (this.LiveMountCapacity == null && Exploration.Includes(parent + ".liveMountCapacity$"))
            {
                this.LiveMountCapacity = new System.Int64();
            }
            //      C# -> System.Int64? MiscellaneousCapacity
            // GraphQL -> miscellaneousCapacity: Long! (scalar)
            if (this.MiscellaneousCapacity == null && Exploration.Includes(parent + ".miscellaneousCapacity$"))
            {
                this.MiscellaneousCapacity = new System.Int64();
            }
            //      C# -> System.Int64? PhysicalArchivalStorage
            // GraphQL -> physicalArchivalStorage: Long! (scalar)
            if (this.PhysicalArchivalStorage == null && Exploration.Includes(parent + ".physicalArchivalStorage$"))
            {
                this.PhysicalArchivalStorage = new System.Int64();
            }
            //      C# -> System.Int64? PhysicalSnapshotStorage
            // GraphQL -> physicalSnapshotStorage: Long! (scalar)
            if (this.PhysicalSnapshotStorage == null && Exploration.Includes(parent + ".physicalSnapshotStorage$"))
            {
                this.PhysicalSnapshotStorage = new System.Int64();
            }
            //      C# -> System.Int64? SnapshotCapacity
            // GraphQL -> snapshotCapacity: Long! (scalar)
            if (this.SnapshotCapacity == null && Exploration.Includes(parent + ".snapshotCapacity$"))
            {
                this.SnapshotCapacity = new System.Int64();
            }
            //      C# -> System.Int64? TotalCapacity
            // GraphQL -> totalCapacity: Long! (scalar)
            if (this.TotalCapacity == null && Exploration.Includes(parent + ".totalCapacity$"))
            {
                this.TotalCapacity = new System.Int64();
            }
            //      C# -> System.Int64? UsedCapacity
            // GraphQL -> usedCapacity: Long! (scalar)
            if (this.UsedCapacity == null && Exploration.Includes(parent + ".usedCapacity$"))
            {
                this.UsedCapacity = new System.Int64();
            }
        }


    #endregion

    } // class ClusterMetric
    #endregion

    public static class ListClusterMetricExtensions
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
            this List<ClusterMetric> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterMetric> list, 
            String parent = "")
        {
            var item = new ClusterMetric();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types