// PausedClustersInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:13.
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
    #region PausedClustersInfo
    public class PausedClustersInfo: IFragment
    {
        #region members
        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        [JsonProperty("pausedClustersCount")]
        public System.Int32? PausedClustersCount { get; set; }

        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        [JsonProperty("pausedClusters")]
        public List<Cluster>? PausedClusters { get; set; }

        #endregion

    #region methods

    public PausedClustersInfo Set(
        System.Int32? PausedClustersCount = null,
        List<Cluster>? PausedClusters = null
    ) 
    {
        if ( PausedClustersCount != null ) {
            this.PausedClustersCount = PausedClustersCount;
        }
        if ( PausedClusters != null ) {
            this.PausedClusters = PausedClusters;
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
            //      C# -> System.Int32? PausedClustersCount
            // GraphQL -> pausedClustersCount: Int! (scalar)
            if (this.PausedClustersCount != null)
            {
                 s += ind + "pausedClustersCount\n";

            }
            //      C# -> List<Cluster>? PausedClusters
            // GraphQL -> pausedClusters: [Cluster!] (type)
            if (this.PausedClusters != null)
            {
                 s += ind + "pausedClusters\n";

                 s += ind + "{\n" + 
                 this.PausedClusters.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? PausedClustersCount
            // GraphQL -> pausedClustersCount: Int! (scalar)
            if (this.PausedClustersCount == null && Exploration.Includes(parent + ".pausedClustersCount$"))
            {
                this.PausedClustersCount = new System.Int32();
            }
            //      C# -> List<Cluster>? PausedClusters
            // GraphQL -> pausedClusters: [Cluster!] (type)
            if (this.PausedClusters == null && Exploration.Includes(parent + ".pausedClusters"))
            {
                this.PausedClusters = new List<Cluster>();
                this.PausedClusters.ApplyExploratoryFragment(parent + ".pausedClusters");
            }
        }


    #endregion

    } // class PausedClustersInfo
    #endregion

    public static class ListPausedClustersInfoExtensions
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
            this List<PausedClustersInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PausedClustersInfo> list, 
            String parent = "")
        {
            var item = new PausedClustersInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types