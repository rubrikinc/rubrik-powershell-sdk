// SnapshotFileDeltaV2Connection.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:03.
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
    #region SnapshotFileDeltaV2Connection
    public class SnapshotFileDeltaV2Connection: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<SnapshotFileDeltaV2Edge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaV2Edge!]! (type)
        [JsonProperty("edges")]
        public List<SnapshotFileDeltaV2Edge>? Edges { get; set; }

        //      C# -> List<SnapshotFileDeltaV2>? Nodes
        // GraphQL -> nodes: [SnapshotFileDeltaV2!]! (type)
        [JsonProperty("nodes")]
        public List<SnapshotFileDeltaV2>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        //      C# -> GenericSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
        [JsonProperty("currentSnapshot")]
        public GenericSnapshot? CurrentSnapshot { get; set; }

        //      C# -> GenericSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: GenericSnapshot (interface)
        [JsonProperty("previousSnapshot")]
        public GenericSnapshot? PreviousSnapshot { get; set; }

        #endregion

    #region methods

    public SnapshotFileDeltaV2Connection Set(
        System.Int32? Count = null,
        List<SnapshotFileDeltaV2Edge>? Edges = null,
        List<SnapshotFileDeltaV2>? Nodes = null,
        PageInfo? PageInfo = null,
        GenericSnapshot? CurrentSnapshot = null,
        GenericSnapshot? PreviousSnapshot = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
        }
        if ( CurrentSnapshot != null ) {
            this.CurrentSnapshot = CurrentSnapshot;
        }
        if ( PreviousSnapshot != null ) {
            this.PreviousSnapshot = PreviousSnapshot;
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
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> List<SnapshotFileDeltaV2Edge>? Edges
            // GraphQL -> edges: [SnapshotFileDeltaV2Edge!]! (type)
            if (this.Edges != null)
            {
                 s += ind + "edges\n";

                 s += ind + "{\n" + 
                 this.Edges.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnapshotFileDeltaV2>? Nodes
            // GraphQL -> nodes: [SnapshotFileDeltaV2!]! (type)
            if (this.Nodes != null)
            {
                 s += ind + "nodes\n";

                 s += ind + "{\n" + 
                 this.Nodes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo != null)
            {
                 s += ind + "pageInfo\n";

                 s += ind + "{\n" + 
                 this.PageInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> GenericSnapshot? CurrentSnapshot
            // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
            if (this.CurrentSnapshot != null)
            {
                s += ind + "currentSnapshot\n";
                s += ind + "{\n";

                string typename = this.CurrentSnapshot.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.CurrentSnapshot.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> GenericSnapshot? PreviousSnapshot
            // GraphQL -> previousSnapshot: GenericSnapshot (interface)
            if (this.PreviousSnapshot != null)
            {
                s += ind + "previousSnapshot\n";
                s += ind + "{\n";

                string typename = this.PreviousSnapshot.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.PreviousSnapshot.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> List<SnapshotFileDeltaV2Edge>? Edges
            // GraphQL -> edges: [SnapshotFileDeltaV2Edge!]! (type)
            if (this.Edges == null && Exploration.Includes(parent + ".edges"))
            {
                this.Edges = new List<SnapshotFileDeltaV2Edge>();
                this.Edges.ApplyExploratoryFragment(parent + ".edges");
            }
            //      C# -> List<SnapshotFileDeltaV2>? Nodes
            // GraphQL -> nodes: [SnapshotFileDeltaV2!]! (type)
            if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
            {
                this.Nodes = new List<SnapshotFileDeltaV2>();
                this.Nodes.ApplyExploratoryFragment(parent + ".nodes");
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
            {
                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFragment(parent + ".pageInfo");
            }
            //      C# -> GenericSnapshot? CurrentSnapshot
            // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
            if (this.CurrentSnapshot == null && Exploration.Includes(parent + ".currentSnapshot"))
            {
                this.CurrentSnapshot = (GenericSnapshot)InterfaceHelper.CreateInstanceOfFirstType(typeof(GenericSnapshot));
                this.CurrentSnapshot.ApplyExploratoryFragment(parent + ".currentSnapshot");
            }
            //      C# -> GenericSnapshot? PreviousSnapshot
            // GraphQL -> previousSnapshot: GenericSnapshot (interface)
            if (this.PreviousSnapshot == null && Exploration.Includes(parent + ".previousSnapshot"))
            {
                this.PreviousSnapshot = (GenericSnapshot)InterfaceHelper.CreateInstanceOfFirstType(typeof(GenericSnapshot));
                this.PreviousSnapshot.ApplyExploratoryFragment(parent + ".previousSnapshot");
            }
        }


    #endregion

    } // class SnapshotFileDeltaV2Connection
    #endregion

    public static class ListSnapshotFileDeltaV2ConnectionExtensions
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
            this List<SnapshotFileDeltaV2Connection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotFileDeltaV2Connection> list, 
            String parent = "")
        {
            var item = new SnapshotFileDeltaV2Connection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types