// SnapshotFileDeltaConnection.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region SnapshotFileDeltaConnection
    public class SnapshotFileDeltaConnection: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> CdmSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: CdmSnapshot! (type)
        [JsonProperty("currentSnapshot")]
        public CdmSnapshot? CurrentSnapshot { get; set; }

        //      C# -> List<SnapshotFileDeltaEdge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
        [JsonProperty("edges")]
        public List<SnapshotFileDeltaEdge>? Edges { get; set; }

        //      C# -> List<SnapshotFileDelta>? Nodes
        // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
        [JsonProperty("nodes")]
        public List<SnapshotFileDelta>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        //      C# -> CdmSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: CdmSnapshot (type)
        [JsonProperty("previousSnapshot")]
        public CdmSnapshot? PreviousSnapshot { get; set; }

        #endregion

    #region methods

    public SnapshotFileDeltaConnection Set(
        System.Int32? Count = null,
        CdmSnapshot? CurrentSnapshot = null,
        List<SnapshotFileDeltaEdge>? Edges = null,
        List<SnapshotFileDelta>? Nodes = null,
        PageInfo? PageInfo = null,
        CdmSnapshot? PreviousSnapshot = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( CurrentSnapshot != null ) {
            this.CurrentSnapshot = CurrentSnapshot;
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
            //      C# -> CdmSnapshot? CurrentSnapshot
            // GraphQL -> currentSnapshot: CdmSnapshot! (type)
            if (this.CurrentSnapshot != null)
            {
                 s += ind + "currentSnapshot\n";

                 s += ind + "{\n" + 
                 this.CurrentSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnapshotFileDeltaEdge>? Edges
            // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
            if (this.Edges != null)
            {
                 s += ind + "edges\n";

                 s += ind + "{\n" + 
                 this.Edges.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnapshotFileDelta>? Nodes
            // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
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
            //      C# -> CdmSnapshot? PreviousSnapshot
            // GraphQL -> previousSnapshot: CdmSnapshot (type)
            if (this.PreviousSnapshot != null)
            {
                 s += ind + "previousSnapshot\n";

                 s += ind + "{\n" + 
                 this.PreviousSnapshot.AsFragment(indent+1) + 
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
            //      C# -> CdmSnapshot? CurrentSnapshot
            // GraphQL -> currentSnapshot: CdmSnapshot! (type)
            if (this.CurrentSnapshot == null && Exploration.Includes(parent + ".currentSnapshot"))
            {
                this.CurrentSnapshot = new CdmSnapshot();
                this.CurrentSnapshot.ApplyExploratoryFragment(parent + ".currentSnapshot");
            }
            //      C# -> List<SnapshotFileDeltaEdge>? Edges
            // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
            if (this.Edges == null && Exploration.Includes(parent + ".edges"))
            {
                this.Edges = new List<SnapshotFileDeltaEdge>();
                this.Edges.ApplyExploratoryFragment(parent + ".edges");
            }
            //      C# -> List<SnapshotFileDelta>? Nodes
            // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
            if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
            {
                this.Nodes = new List<SnapshotFileDelta>();
                this.Nodes.ApplyExploratoryFragment(parent + ".nodes");
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
            {
                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFragment(parent + ".pageInfo");
            }
            //      C# -> CdmSnapshot? PreviousSnapshot
            // GraphQL -> previousSnapshot: CdmSnapshot (type)
            if (this.PreviousSnapshot == null && Exploration.Includes(parent + ".previousSnapshot"))
            {
                this.PreviousSnapshot = new CdmSnapshot();
                this.PreviousSnapshot.ApplyExploratoryFragment(parent + ".previousSnapshot");
            }
        }


    #endregion

    } // class SnapshotFileDeltaConnection
    #endregion

    public static class ListSnapshotFileDeltaConnectionExtensions
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
            this List<SnapshotFileDeltaConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotFileDeltaConnection> list, 
            String parent = "")
        {
            var item = new SnapshotFileDeltaConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types