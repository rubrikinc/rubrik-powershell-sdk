// FailoverClusterDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
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
    #region FailoverClusterDetail
    public class FailoverClusterDetail: IFragment
    {
        #region members
        //      C# -> System.Int32? NumApps
        // GraphQL -> numApps: Int! (scalar)
        [JsonProperty("numApps")]
        public System.Int32? NumApps { get; set; }

        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int! (scalar)
        [JsonProperty("numNodes")]
        public System.Int32? NumNodes { get; set; }

        //      C# -> FailoverClusterSummary? FailoverClusterSummary
        // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
        [JsonProperty("failoverClusterSummary")]
        public FailoverClusterSummary? FailoverClusterSummary { get; set; }

        #endregion

    #region methods

    public FailoverClusterDetail Set(
        System.Int32? NumApps = null,
        System.Int32? NumNodes = null,
        FailoverClusterSummary? FailoverClusterSummary = null
    ) 
    {
        if ( NumApps != null ) {
            this.NumApps = NumApps;
        }
        if ( NumNodes != null ) {
            this.NumNodes = NumNodes;
        }
        if ( FailoverClusterSummary != null ) {
            this.FailoverClusterSummary = FailoverClusterSummary;
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
            //      C# -> System.Int32? NumApps
            // GraphQL -> numApps: Int! (scalar)
            if (this.NumApps != null)
            {
                 s += ind + "numApps\n";

            }
            //      C# -> System.Int32? NumNodes
            // GraphQL -> numNodes: Int! (scalar)
            if (this.NumNodes != null)
            {
                 s += ind + "numNodes\n";

            }
            //      C# -> FailoverClusterSummary? FailoverClusterSummary
            // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
            if (this.FailoverClusterSummary != null)
            {
                 s += ind + "failoverClusterSummary\n";

                 s += ind + "{\n" + 
                 this.FailoverClusterSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? NumApps
            // GraphQL -> numApps: Int! (scalar)
            if (this.NumApps == null && Exploration.Includes(parent + ".numApps$"))
            {
                this.NumApps = new System.Int32();
            }
            //      C# -> System.Int32? NumNodes
            // GraphQL -> numNodes: Int! (scalar)
            if (this.NumNodes == null && Exploration.Includes(parent + ".numNodes$"))
            {
                this.NumNodes = new System.Int32();
            }
            //      C# -> FailoverClusterSummary? FailoverClusterSummary
            // GraphQL -> failoverClusterSummary: FailoverClusterSummary (type)
            if (this.FailoverClusterSummary == null && Exploration.Includes(parent + ".failoverClusterSummary"))
            {
                this.FailoverClusterSummary = new FailoverClusterSummary();
                this.FailoverClusterSummary.ApplyExploratoryFragment(parent + ".failoverClusterSummary");
            }
        }


    #endregion

    } // class FailoverClusterDetail
    #endregion

    public static class ListFailoverClusterDetailExtensions
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
            this List<FailoverClusterDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FailoverClusterDetail> list, 
            String parent = "")
        {
            var item = new FailoverClusterDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types