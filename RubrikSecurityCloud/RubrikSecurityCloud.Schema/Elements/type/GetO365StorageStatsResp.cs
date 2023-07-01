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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region GetO365StorageStatsResp
    public class GetO365StorageStatsResp: BaseType
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

    public override string GetGqlTypeName() {
        return "GetO365StorageStatsResp";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? DailyGrowthInBytes
        // GraphQL -> dailyGrowthInBytes: Long! (scalar)
        if (this.DailyGrowthInBytes != null) {
            s += ind + "dailyGrowthInBytes\n" ;
        }
        //      C# -> System.Int64? EstimatedThirtyDaysStorageInBytes
        // GraphQL -> estimatedThirtyDaysStorageInBytes: Long! (scalar)
        if (this.EstimatedThirtyDaysStorageInBytes != null) {
            s += ind + "estimatedThirtyDaysStorageInBytes\n" ;
        }
        //      C# -> System.Int64? LiveDataSizeInBytes
        // GraphQL -> liveDataSizeInBytes: Long! (scalar)
        if (this.LiveDataSizeInBytes != null) {
            s += ind + "liveDataSizeInBytes\n" ;
        }
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (this.PhysicalDataSizeInBytes != null) {
            s += ind + "physicalDataSizeInBytes\n" ;
        }
        //      C# -> System.Int64? StorageEfficiencyPercent
        // GraphQL -> storageEfficiencyPercent: Long! (scalar)
        if (this.StorageEfficiencyPercent != null) {
            s += ind + "storageEfficiencyPercent\n" ;
        }
        //      C# -> List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries
        // GraphQL -> physicalDataSizeTimeSeries: [O365PhysicalDataSizeTimeStamp!]! (type)
        if (this.PhysicalDataSizeTimeSeries != null) {
            var fspec = this.PhysicalDataSizeTimeSeries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalDataSizeTimeSeries {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? DailyGrowthInBytes
        // GraphQL -> dailyGrowthInBytes: Long! (scalar)
        if (this.DailyGrowthInBytes == null && Exploration.Includes(parent + ".dailyGrowthInBytes", true))
        {
            this.DailyGrowthInBytes = new System.Int64();
        }
        //      C# -> System.Int64? EstimatedThirtyDaysStorageInBytes
        // GraphQL -> estimatedThirtyDaysStorageInBytes: Long! (scalar)
        if (this.EstimatedThirtyDaysStorageInBytes == null && Exploration.Includes(parent + ".estimatedThirtyDaysStorageInBytes", true))
        {
            this.EstimatedThirtyDaysStorageInBytes = new System.Int64();
        }
        //      C# -> System.Int64? LiveDataSizeInBytes
        // GraphQL -> liveDataSizeInBytes: Long! (scalar)
        if (this.LiveDataSizeInBytes == null && Exploration.Includes(parent + ".liveDataSizeInBytes", true))
        {
            this.LiveDataSizeInBytes = new System.Int64();
        }
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (this.PhysicalDataSizeInBytes == null && Exploration.Includes(parent + ".physicalDataSizeInBytes", true))
        {
            this.PhysicalDataSizeInBytes = new System.Int64();
        }
        //      C# -> System.Int64? StorageEfficiencyPercent
        // GraphQL -> storageEfficiencyPercent: Long! (scalar)
        if (this.StorageEfficiencyPercent == null && Exploration.Includes(parent + ".storageEfficiencyPercent", true))
        {
            this.StorageEfficiencyPercent = new System.Int64();
        }
        //      C# -> List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries
        // GraphQL -> physicalDataSizeTimeSeries: [O365PhysicalDataSizeTimeStamp!]! (type)
        if (this.PhysicalDataSizeTimeSeries == null && Exploration.Includes(parent + ".physicalDataSizeTimeSeries"))
        {
            this.PhysicalDataSizeTimeSeries = new List<O365PhysicalDataSizeTimeStamp>();
            this.PhysicalDataSizeTimeSeries.ApplyExploratoryFieldSpec(parent + ".physicalDataSizeTimeSeries");
        }
    }


    #endregion

    } // class GetO365StorageStatsResp
    
    #endregion

    public static class ListGetO365StorageStatsRespExtensions
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
            this List<GetO365StorageStatsResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetO365StorageStatsResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetO365StorageStatsResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types