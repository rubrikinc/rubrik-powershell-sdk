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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? BlobCapacityStats
        // GraphQL -> blobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.BlobCapacityStats != null) {
            s += ind + "blobCapacityStats {\n" + this.BlobCapacityStats.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? EgressStats
        // GraphQL -> egressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.EgressStats != null) {
            s += ind + "egressStats {\n" + this.EgressStats.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats
        // GraphQL -> forecastedBlobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.ForecastedBlobCapacityStats != null) {
            s += ind + "forecastedBlobCapacityStats {\n" + this.ForecastedBlobCapacityStats.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? IngressStats
        // GraphQL -> ingressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.IngressStats != null) {
            s += ind + "ingressStats {\n" + this.IngressStats.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && Exploration.Includes(parent + ".locationId", true))
        {
            this.LocationId = new System.String("FETCH");
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? BlobCapacityStats
        // GraphQL -> blobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.BlobCapacityStats == null && Exploration.Includes(parent + ".blobCapacityStats"))
        {
            this.BlobCapacityStats = new List<RcsArchivalLocationStatsRecord>();
            this.BlobCapacityStats.ApplyExploratoryFieldSpec(parent + ".blobCapacityStats");
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? EgressStats
        // GraphQL -> egressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.EgressStats == null && Exploration.Includes(parent + ".egressStats"))
        {
            this.EgressStats = new List<RcsArchivalLocationStatsRecord>();
            this.EgressStats.ApplyExploratoryFieldSpec(parent + ".egressStats");
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats
        // GraphQL -> forecastedBlobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.ForecastedBlobCapacityStats == null && Exploration.Includes(parent + ".forecastedBlobCapacityStats"))
        {
            this.ForecastedBlobCapacityStats = new List<RcsArchivalLocationStatsRecord>();
            this.ForecastedBlobCapacityStats.ApplyExploratoryFieldSpec(parent + ".forecastedBlobCapacityStats");
        }
        //      C# -> List<RcsArchivalLocationStatsRecord>? IngressStats
        // GraphQL -> ingressStats: [RcsArchivalLocationStatsRecord!]! (type)
        if (this.IngressStats == null && Exploration.Includes(parent + ".ingressStats"))
        {
            this.IngressStats = new List<RcsArchivalLocationStatsRecord>();
            this.IngressStats.ApplyExploratoryFieldSpec(parent + ".ingressStats");
        }
    }


    #endregion

    } // class RcsArchivalLocationConsumptionStats
    
    #endregion

    public static class ListRcsArchivalLocationConsumptionStatsExtensions
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
            this List<RcsArchivalLocationConsumptionStats> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RcsArchivalLocationConsumptionStats> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RcsArchivalLocationConsumptionStats());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types