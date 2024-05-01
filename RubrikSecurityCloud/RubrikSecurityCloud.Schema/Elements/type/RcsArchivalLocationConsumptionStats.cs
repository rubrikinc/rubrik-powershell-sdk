// RcsArchivalLocationConsumptionStats.cs
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
    #region RcsArchivalLocationConsumptionStats
    public class RcsArchivalLocationConsumptionStats: BaseType
    {
        #region members

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> List<RcsArchivalLocationStatsRecord>? BlobCapacityStats
        // GraphQL -> blobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        [JsonProperty("blobCapacityStats")]
        public List<RcsArchivalLocationStatsRecord>? BlobCapacityStats { get; set; }

        //      C# -> List<RcsArchivalLocationStatsRecord>? EgressStats
        // GraphQL -> egressStats: [RcsArchivalLocationStatsRecord!]! (type)
        [JsonProperty("egressStats")]
        public List<RcsArchivalLocationStatsRecord>? EgressStats { get; set; }

        //      C# -> List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats
        // GraphQL -> forecastedBlobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        [JsonProperty("forecastedBlobCapacityStats")]
        public List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats { get; set; }

        //      C# -> List<RcsArchivalLocationStatsRecord>? IngressStats
        // GraphQL -> ingressStats: [RcsArchivalLocationStatsRecord!]! (type)
        [JsonProperty("ingressStats")]
        public List<RcsArchivalLocationStatsRecord>? IngressStats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcsArchivalLocationConsumptionStats";
    }

    public RcsArchivalLocationConsumptionStats Set(
        System.String? LocationId = null,
        List<RcsArchivalLocationStatsRecord>? BlobCapacityStats = null,
        List<RcsArchivalLocationStatsRecord>? EgressStats = null,
        List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats = null,
        List<RcsArchivalLocationStatsRecord>? IngressStats = null
    ) 
    {
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( BlobCapacityStats != null ) {
            this.BlobCapacityStats = BlobCapacityStats;
        }
        if ( EgressStats != null ) {
            this.EgressStats = EgressStats;
        }
        if ( ForecastedBlobCapacityStats != null ) {
            this.ForecastedBlobCapacityStats = ForecastedBlobCapacityStats;
        }
        if ( IngressStats != null ) {
            this.IngressStats = IngressStats;
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
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? BlobCapacityStats
        // GraphQL -> blobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.BlobCapacityStats != null) {
            var fspec = this.BlobCapacityStats.AsFieldSpec(conf.Child("blobCapacityStats"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blobCapacityStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? EgressStats
        // GraphQL -> egressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.EgressStats != null) {
            var fspec = this.EgressStats.AsFieldSpec(conf.Child("egressStats"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "egressStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats
        // GraphQL -> forecastedBlobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.ForecastedBlobCapacityStats != null) {
            var fspec = this.ForecastedBlobCapacityStats.AsFieldSpec(conf.Child("forecastedBlobCapacityStats"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "forecastedBlobCapacityStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? IngressStats
        // GraphQL -> ingressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.IngressStats != null) {
            var fspec = this.IngressStats.AsFieldSpec(conf.Child("ingressStats"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ingressStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? BlobCapacityStats
        // GraphQL -> blobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (ec.Includes("blobCapacityStats",false))
        {
            if(this.BlobCapacityStats == null) {

                this.BlobCapacityStats = new List<RcsArchivalLocationStatsRecord>();
                this.BlobCapacityStats.ApplyExploratoryFieldSpec(ec.NewChild("blobCapacityStats"));

            } else {

                this.BlobCapacityStats.ApplyExploratoryFieldSpec(ec.NewChild("blobCapacityStats"));

            }
        }
        else if (this.BlobCapacityStats != null && ec.Excludes("blobCapacityStats",false))
        {
            this.BlobCapacityStats = null;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? EgressStats
        // GraphQL -> egressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (ec.Includes("egressStats",false))
        {
            if(this.EgressStats == null) {

                this.EgressStats = new List<RcsArchivalLocationStatsRecord>();
                this.EgressStats.ApplyExploratoryFieldSpec(ec.NewChild("egressStats"));

            } else {

                this.EgressStats.ApplyExploratoryFieldSpec(ec.NewChild("egressStats"));

            }
        }
        else if (this.EgressStats != null && ec.Excludes("egressStats",false))
        {
            this.EgressStats = null;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats
        // GraphQL -> forecastedBlobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (ec.Includes("forecastedBlobCapacityStats",false))
        {
            if(this.ForecastedBlobCapacityStats == null) {

                this.ForecastedBlobCapacityStats = new List<RcsArchivalLocationStatsRecord>();
                this.ForecastedBlobCapacityStats.ApplyExploratoryFieldSpec(ec.NewChild("forecastedBlobCapacityStats"));

            } else {

                this.ForecastedBlobCapacityStats.ApplyExploratoryFieldSpec(ec.NewChild("forecastedBlobCapacityStats"));

            }
        }
        else if (this.ForecastedBlobCapacityStats != null && ec.Excludes("forecastedBlobCapacityStats",false))
        {
            this.ForecastedBlobCapacityStats = null;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? IngressStats
        // GraphQL -> ingressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (ec.Includes("ingressStats",false))
        {
            if(this.IngressStats == null) {

                this.IngressStats = new List<RcsArchivalLocationStatsRecord>();
                this.IngressStats.ApplyExploratoryFieldSpec(ec.NewChild("ingressStats"));

            } else {

                this.IngressStats.ApplyExploratoryFieldSpec(ec.NewChild("ingressStats"));

            }
        }
        else if (this.IngressStats != null && ec.Excludes("ingressStats",false))
        {
            this.IngressStats = null;
        }
    }


    #endregion

    } // class RcsArchivalLocationConsumptionStats
    
    #endregion

    public static class ListRcsArchivalLocationConsumptionStatsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RcsArchivalLocationConsumptionStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcsArchivalLocationConsumptionStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcsArchivalLocationConsumptionStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcsArchivalLocationConsumptionStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcsArchivalLocationConsumptionStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types