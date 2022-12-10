// RcsArchivalLocationConsumptionStats.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
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
    #region RcsArchivalLocationConsumptionStats
    public class RcsArchivalLocationConsumptionStats: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? LocationId
            // GraphQL -> locationId: String! (scalar)
            if (this.LocationId != null)
            {
                 s += ind + "locationId\n";

            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? BlobCapacityStats
            // GraphQL -> blobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.BlobCapacityStats != null)
            {
                 s += ind + "blobCapacityStats\n";

                 s += ind + "{\n" + 
                 this.BlobCapacityStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? EgressStats
            // GraphQL -> egressStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.EgressStats != null)
            {
                 s += ind + "egressStats\n";

                 s += ind + "{\n" + 
                 this.EgressStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats
            // GraphQL -> forecastedBlobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.ForecastedBlobCapacityStats != null)
            {
                 s += ind + "forecastedBlobCapacityStats\n";

                 s += ind + "{\n" + 
                 this.ForecastedBlobCapacityStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? IngressStats
            // GraphQL -> ingressStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.IngressStats != null)
            {
                 s += ind + "ingressStats\n";

                 s += ind + "{\n" + 
                 this.IngressStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? LocationId
            // GraphQL -> locationId: String! (scalar)
            if (this.LocationId == null && Exploration.Includes(parent + ".locationId$"))
            {
                this.LocationId = new System.String("FETCH");
            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? BlobCapacityStats
            // GraphQL -> blobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.BlobCapacityStats == null && Exploration.Includes(parent + ".blobCapacityStats"))
            {
                this.BlobCapacityStats = new List<RcsArchivalLocationStatsRecord>();
                this.BlobCapacityStats.ApplyExploratoryFragment(parent + ".blobCapacityStats");
            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? EgressStats
            // GraphQL -> egressStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.EgressStats == null && Exploration.Includes(parent + ".egressStats"))
            {
                this.EgressStats = new List<RcsArchivalLocationStatsRecord>();
                this.EgressStats.ApplyExploratoryFragment(parent + ".egressStats");
            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? ForecastedBlobCapacityStats
            // GraphQL -> forecastedBlobCapacityStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.ForecastedBlobCapacityStats == null && Exploration.Includes(parent + ".forecastedBlobCapacityStats"))
            {
                this.ForecastedBlobCapacityStats = new List<RcsArchivalLocationStatsRecord>();
                this.ForecastedBlobCapacityStats.ApplyExploratoryFragment(parent + ".forecastedBlobCapacityStats");
            }
            //      C# -> List<RcsArchivalLocationStatsRecord>? IngressStats
            // GraphQL -> ingressStats: [RcsArchivalLocationStatsRecord!]! (type)
            if (this.IngressStats == null && Exploration.Includes(parent + ".ingressStats"))
            {
                this.IngressStats = new List<RcsArchivalLocationStatsRecord>();
                this.IngressStats.ApplyExploratoryFragment(parent + ".ingressStats");
            }
        }


    #endregion

    } // class RcsArchivalLocationConsumptionStats
    #endregion

    public static class ListRcsArchivalLocationConsumptionStatsExtensions
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
            this List<RcsArchivalLocationConsumptionStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RcsArchivalLocationConsumptionStats> list, 
            String parent = "")
        {
            var item = new RcsArchivalLocationConsumptionStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types