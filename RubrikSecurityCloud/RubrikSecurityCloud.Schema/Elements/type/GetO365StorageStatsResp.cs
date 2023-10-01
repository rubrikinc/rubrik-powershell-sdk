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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? DailyGrowthInBytes
        // GraphQL -> dailyGrowthInBytes: Long! (scalar)
        if (this.DailyGrowthInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dailyGrowthInBytes\n" ;
            } else {
                s += ind + "dailyGrowthInBytes\n" ;
            }
        }
        //      C# -> System.Int64? EstimatedThirtyDaysStorageInBytes
        // GraphQL -> estimatedThirtyDaysStorageInBytes: Long! (scalar)
        if (this.EstimatedThirtyDaysStorageInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "estimatedThirtyDaysStorageInBytes\n" ;
            } else {
                s += ind + "estimatedThirtyDaysStorageInBytes\n" ;
            }
        }
        //      C# -> System.Int64? LiveDataSizeInBytes
        // GraphQL -> liveDataSizeInBytes: Long! (scalar)
        if (this.LiveDataSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "liveDataSizeInBytes\n" ;
            } else {
                s += ind + "liveDataSizeInBytes\n" ;
            }
        }
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (this.PhysicalDataSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalDataSizeInBytes\n" ;
            } else {
                s += ind + "physicalDataSizeInBytes\n" ;
            }
        }
        //      C# -> System.Int64? StorageEfficiencyPercent
        // GraphQL -> storageEfficiencyPercent: Long! (scalar)
        if (this.StorageEfficiencyPercent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageEfficiencyPercent\n" ;
            } else {
                s += ind + "storageEfficiencyPercent\n" ;
            }
        }
        //      C# -> List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries
        // GraphQL -> physicalDataSizeTimeSeries: [O365PhysicalDataSizeTimeStamp!]! (type)
        if (this.PhysicalDataSizeTimeSeries != null) {
            var fspec = this.PhysicalDataSizeTimeSeries.AsFieldSpec(conf.Child("physicalDataSizeTimeSeries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalDataSizeTimeSeries {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? DailyGrowthInBytes
        // GraphQL -> dailyGrowthInBytes: Long! (scalar)
        if (ec.Includes("dailyGrowthInBytes",true))
        {
            if(this.DailyGrowthInBytes == null) {

                this.DailyGrowthInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.DailyGrowthInBytes != null && ec.Excludes("dailyGrowthInBytes",true))
        {
            this.DailyGrowthInBytes = null;
        }
        //      C# -> System.Int64? EstimatedThirtyDaysStorageInBytes
        // GraphQL -> estimatedThirtyDaysStorageInBytes: Long! (scalar)
        if (ec.Includes("estimatedThirtyDaysStorageInBytes",true))
        {
            if(this.EstimatedThirtyDaysStorageInBytes == null) {

                this.EstimatedThirtyDaysStorageInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.EstimatedThirtyDaysStorageInBytes != null && ec.Excludes("estimatedThirtyDaysStorageInBytes",true))
        {
            this.EstimatedThirtyDaysStorageInBytes = null;
        }
        //      C# -> System.Int64? LiveDataSizeInBytes
        // GraphQL -> liveDataSizeInBytes: Long! (scalar)
        if (ec.Includes("liveDataSizeInBytes",true))
        {
            if(this.LiveDataSizeInBytes == null) {

                this.LiveDataSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LiveDataSizeInBytes != null && ec.Excludes("liveDataSizeInBytes",true))
        {
            this.LiveDataSizeInBytes = null;
        }
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (ec.Includes("physicalDataSizeInBytes",true))
        {
            if(this.PhysicalDataSizeInBytes == null) {

                this.PhysicalDataSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalDataSizeInBytes != null && ec.Excludes("physicalDataSizeInBytes",true))
        {
            this.PhysicalDataSizeInBytes = null;
        }
        //      C# -> System.Int64? StorageEfficiencyPercent
        // GraphQL -> storageEfficiencyPercent: Long! (scalar)
        if (ec.Includes("storageEfficiencyPercent",true))
        {
            if(this.StorageEfficiencyPercent == null) {

                this.StorageEfficiencyPercent = new System.Int64();

            } else {


            }
        }
        else if (this.StorageEfficiencyPercent != null && ec.Excludes("storageEfficiencyPercent",true))
        {
            this.StorageEfficiencyPercent = null;
        }
        //      C# -> List<O365PhysicalDataSizeTimeStamp>? PhysicalDataSizeTimeSeries
        // GraphQL -> physicalDataSizeTimeSeries: [O365PhysicalDataSizeTimeStamp!]! (type)
        if (ec.Includes("physicalDataSizeTimeSeries",false))
        {
            if(this.PhysicalDataSizeTimeSeries == null) {

                this.PhysicalDataSizeTimeSeries = new List<O365PhysicalDataSizeTimeStamp>();
                this.PhysicalDataSizeTimeSeries.ApplyExploratoryFieldSpec(ec.NewChild("physicalDataSizeTimeSeries"));

            } else {

                this.PhysicalDataSizeTimeSeries.ApplyExploratoryFieldSpec(ec.NewChild("physicalDataSizeTimeSeries"));

            }
        }
        else if (this.PhysicalDataSizeTimeSeries != null && ec.Excludes("physicalDataSizeTimeSeries",false))
        {
            this.PhysicalDataSizeTimeSeries = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GetO365StorageStatsResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetO365StorageStatsResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetO365StorageStatsResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetO365StorageStatsResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types