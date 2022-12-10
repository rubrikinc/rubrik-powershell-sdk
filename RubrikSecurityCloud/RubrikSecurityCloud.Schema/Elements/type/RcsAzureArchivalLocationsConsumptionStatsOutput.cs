// RcsAzureArchivalLocationsConsumptionStatsOutput.cs
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
    #region RcsAzureArchivalLocationsConsumptionStatsOutput
    public class RcsAzureArchivalLocationsConsumptionStatsOutput: IFragment
    {
        #region members
        //      C# -> List<RcsArchivalLocationConsumptionStats>? RcsAzureConsumptionStats
        // GraphQL -> rcsAzureConsumptionStats: [RcsArchivalLocationConsumptionStats!]! (type)
        [JsonProperty("rcsAzureConsumptionStats")]
        public List<RcsArchivalLocationConsumptionStats>? RcsAzureConsumptionStats { get; set; }

        #endregion

    #region methods

    public RcsAzureArchivalLocationsConsumptionStatsOutput Set(
        List<RcsArchivalLocationConsumptionStats>? RcsAzureConsumptionStats = null
    ) 
    {
        if ( RcsAzureConsumptionStats != null ) {
            this.RcsAzureConsumptionStats = RcsAzureConsumptionStats;
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
            //      C# -> List<RcsArchivalLocationConsumptionStats>? RcsAzureConsumptionStats
            // GraphQL -> rcsAzureConsumptionStats: [RcsArchivalLocationConsumptionStats!]! (type)
            if (this.RcsAzureConsumptionStats != null)
            {
                 s += ind + "rcsAzureConsumptionStats\n";

                 s += ind + "{\n" + 
                 this.RcsAzureConsumptionStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<RcsArchivalLocationConsumptionStats>? RcsAzureConsumptionStats
            // GraphQL -> rcsAzureConsumptionStats: [RcsArchivalLocationConsumptionStats!]! (type)
            if (this.RcsAzureConsumptionStats == null && Exploration.Includes(parent + ".rcsAzureConsumptionStats"))
            {
                this.RcsAzureConsumptionStats = new List<RcsArchivalLocationConsumptionStats>();
                this.RcsAzureConsumptionStats.ApplyExploratoryFragment(parent + ".rcsAzureConsumptionStats");
            }
        }


    #endregion

    } // class RcsAzureArchivalLocationsConsumptionStatsOutput
    #endregion

    public static class ListRcsAzureArchivalLocationsConsumptionStatsOutputExtensions
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
            this List<RcsAzureArchivalLocationsConsumptionStatsOutput> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RcsAzureArchivalLocationsConsumptionStatsOutput> list, 
            String parent = "")
        {
            var item = new RcsAzureArchivalLocationsConsumptionStatsOutput();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types