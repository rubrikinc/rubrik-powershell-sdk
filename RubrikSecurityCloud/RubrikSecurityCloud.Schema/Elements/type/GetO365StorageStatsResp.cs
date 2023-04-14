// GetO365StorageStatsResp.cs
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
    #region GetO365StorageStatsResp
    public class GetO365StorageStatsResp: IFragment
    {
        #region members
        //      C# -> System.Int64? DailyGrowthInBytes
        // GraphQL -> dailyGrowthInBytes: Long! (scalar)
        [JsonProperty("dailyGrowthInBytes")]
        public System.Int64? DailyGrowthInBytes { get; set; }

        //      C# -> System.Int64? EstimatedThirtyDaysStorageInBytes
        // GraphQL -> estimatedThirtyDaysStorageInBytes: Long! (scalar)
        [JsonProperty("estimatedThirtyDaysStorageInBytes")]
        public System.Int64? EstimatedThirtyDaysStorageInBytes { get; set; }

        //      C# -> System.Int64? LiveDataSizeInBytes
        // GraphQL -> liveDataSizeInBytes: Long! (scalar)
        [JsonProperty("liveDataSizeInBytes")]
        public System.Int64? LiveDataSizeInBytes { get; set; }

        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        [JsonProperty("physicalDataSizeInBytes")]
        public System.Int64? PhysicalDataSizeInBytes { get; set; }

        //      C# -> System.Int64? StorageEfficiencyPercent
        // GraphQL -> storageEfficiencyPercent: Long! (scalar)
        [JsonProperty("storageEfficiencyPercent")]
        public System.Int64? StorageEfficiencyPercent { get; set; }

        //      C# -> List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries
        // GraphQL -> physicalDataSizeTimeSeries: [O365PhysicalDataSizeTimeStamp!]! (type)
        [JsonProperty("physicalDataSizeTimeSeries")]
        public List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries { get; set; }

        #endregion

    #region methods

    public GetO365StorageStatsResp Set(
        System.Int64? DailyGrowthInBytes = null,
        System.Int64? EstimatedThirtyDaysStorageInBytes = null,
        System.Int64? LiveDataSizeInBytes = null,
        System.Int64? PhysicalDataSizeInBytes = null,
        System.Int64? StorageEfficiencyPercent = null,
        List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries = null
    ) 
    {
        if ( DailyGrowthInBytes != null ) {
            this.DailyGrowthInBytes = DailyGrowthInBytes;
        }
        if ( EstimatedThirtyDaysStorageInBytes != null ) {
            this.EstimatedThirtyDaysStorageInBytes = EstimatedThirtyDaysStorageInBytes;
        }
        if ( LiveDataSizeInBytes != null ) {
            this.LiveDataSizeInBytes = LiveDataSizeInBytes;
        }
        if ( PhysicalDataSizeInBytes != null ) {
            this.PhysicalDataSizeInBytes = PhysicalDataSizeInBytes;
        }
        if ( StorageEfficiencyPercent != null ) {
            this.StorageEfficiencyPercent = StorageEfficiencyPercent;
        }
        if ( PhysicalDataSizeTimeSeries != null ) {
            this.PhysicalDataSizeTimeSeries = PhysicalDataSizeTimeSeries;
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
            //      C# -> System.Int64? DailyGrowthInBytes
            // GraphQL -> dailyGrowthInBytes: Long! (scalar)
            if (this.DailyGrowthInBytes != null)
            {
                 s += ind + "dailyGrowthInBytes\n";

            }
            //      C# -> System.Int64? EstimatedThirtyDaysStorageInBytes
            // GraphQL -> estimatedThirtyDaysStorageInBytes: Long! (scalar)
            if (this.EstimatedThirtyDaysStorageInBytes != null)
            {
                 s += ind + "estimatedThirtyDaysStorageInBytes\n";

            }
            //      C# -> System.Int64? LiveDataSizeInBytes
            // GraphQL -> liveDataSizeInBytes: Long! (scalar)
            if (this.LiveDataSizeInBytes != null)
            {
                 s += ind + "liveDataSizeInBytes\n";

            }
            //      C# -> System.Int64? PhysicalDataSizeInBytes
            // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
            if (this.PhysicalDataSizeInBytes != null)
            {
                 s += ind + "physicalDataSizeInBytes\n";

            }
            //      C# -> System.Int64? StorageEfficiencyPercent
            // GraphQL -> storageEfficiencyPercent: Long! (scalar)
            if (this.StorageEfficiencyPercent != null)
            {
                 s += ind + "storageEfficiencyPercent\n";

            }
            //      C# -> List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries
            // GraphQL -> physicalDataSizeTimeSeries: [O365PhysicalDataSizeTimeStamp!]! (type)
            if (this.PhysicalDataSizeTimeSeries != null)
            {
                 s += ind + "physicalDataSizeTimeSeries\n";

                 s += ind + "{\n" + 
                 this.PhysicalDataSizeTimeSeries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? DailyGrowthInBytes
            // GraphQL -> dailyGrowthInBytes: Long! (scalar)
            if (this.DailyGrowthInBytes == null && Exploration.Includes(parent + ".dailyGrowthInBytes$"))
            {
                this.DailyGrowthInBytes = new System.Int64();
            }
            //      C# -> System.Int64? EstimatedThirtyDaysStorageInBytes
            // GraphQL -> estimatedThirtyDaysStorageInBytes: Long! (scalar)
            if (this.EstimatedThirtyDaysStorageInBytes == null && Exploration.Includes(parent + ".estimatedThirtyDaysStorageInBytes$"))
            {
                this.EstimatedThirtyDaysStorageInBytes = new System.Int64();
            }
            //      C# -> System.Int64? LiveDataSizeInBytes
            // GraphQL -> liveDataSizeInBytes: Long! (scalar)
            if (this.LiveDataSizeInBytes == null && Exploration.Includes(parent + ".liveDataSizeInBytes$"))
            {
                this.LiveDataSizeInBytes = new System.Int64();
            }
            //      C# -> System.Int64? PhysicalDataSizeInBytes
            // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
            if (this.PhysicalDataSizeInBytes == null && Exploration.Includes(parent + ".physicalDataSizeInBytes$"))
            {
                this.PhysicalDataSizeInBytes = new System.Int64();
            }
            //      C# -> System.Int64? StorageEfficiencyPercent
            // GraphQL -> storageEfficiencyPercent: Long! (scalar)
            if (this.StorageEfficiencyPercent == null && Exploration.Includes(parent + ".storageEfficiencyPercent$"))
            {
                this.StorageEfficiencyPercent = new System.Int64();
            }
            //      C# -> List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries
            // GraphQL -> physicalDataSizeTimeSeries: [O365PhysicalDataSizeTimeStamp!]! (type)
            if (this.PhysicalDataSizeTimeSeries == null && Exploration.Includes(parent + ".physicalDataSizeTimeSeries"))
            {
                this.PhysicalDataSizeTimeSeries = new List<O365PhysicalDataSizeTimeStamp>();
                this.PhysicalDataSizeTimeSeries.ApplyExploratoryFragment(parent + ".physicalDataSizeTimeSeries");
            }
        }


    #endregion

    } // class GetO365StorageStatsResp
    #endregion

    public static class ListGetO365StorageStatsRespExtensions
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
            this List<GetO365StorageStatsResp> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetO365StorageStatsResp> list, 
            String parent = "")
        {
            var item = new GetO365StorageStatsResp();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types