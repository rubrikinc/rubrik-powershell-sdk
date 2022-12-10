// ArchivalLocationToClusterMapping.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    #region ArchivalLocationToClusterMapping
    public class ArchivalLocationToClusterMapping: IFragment
    {
        #region members
        //      C# -> SlaArchivalCluster? Cluster
        // GraphQL -> cluster: SlaArchivalCluster (type)
        [JsonProperty("cluster")]
        public SlaArchivalCluster? Cluster { get; set; }

        //      C# -> DlsArchivalLocation? Location
        // GraphQL -> location: DlsArchivalLocation (type)
        [JsonProperty("location")]
        public DlsArchivalLocation? Location { get; set; }

        #endregion

    #region methods

    public ArchivalLocationToClusterMapping Set(
        SlaArchivalCluster? Cluster = null,
        DlsArchivalLocation? Location = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Location != null ) {
            this.Location = Location;
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
            //      C# -> SlaArchivalCluster? Cluster
            // GraphQL -> cluster: SlaArchivalCluster (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> DlsArchivalLocation? Location
            // GraphQL -> location: DlsArchivalLocation (type)
            if (this.Location != null)
            {
                 s += ind + "location\n";

                 s += ind + "{\n" + 
                 this.Location.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> SlaArchivalCluster? Cluster
            // GraphQL -> cluster: SlaArchivalCluster (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new SlaArchivalCluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> DlsArchivalLocation? Location
            // GraphQL -> location: DlsArchivalLocation (type)
            if (this.Location == null && Exploration.Includes(parent + ".location"))
            {
                this.Location = new DlsArchivalLocation();
                this.Location.ApplyExploratoryFragment(parent + ".location");
            }
        }


    #endregion

    } // class ArchivalLocationToClusterMapping
    #endregion

    public static class ListArchivalLocationToClusterMappingExtensions
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
            this List<ArchivalLocationToClusterMapping> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ArchivalLocationToClusterMapping> list, 
            String parent = "")
        {
            var item = new ArchivalLocationToClusterMapping();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types