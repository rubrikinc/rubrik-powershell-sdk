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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SnapshotFileDeltaConnection
    public class SnapshotFileDeltaConnection: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> CdmSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: CdmSnapshot! (type)
        if (this.CurrentSnapshot != null) {
            s += ind + "currentSnapshot {\n" + this.CurrentSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<SnapshotFileDeltaEdge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
        if (this.Edges != null) {
            s += ind + "edges {\n" + this.Edges.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<SnapshotFileDelta>? Nodes
        // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
        if (this.Nodes != null) {
            s += ind + "nodes {\n" + this.Nodes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            s += ind + "pageInfo {\n" + this.PageInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: CdmSnapshot (type)
        if (this.PreviousSnapshot != null) {
            s += ind + "previousSnapshot {\n" + this.PreviousSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> CdmSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: CdmSnapshot! (type)
        if (this.CurrentSnapshot == null && Exploration.Includes(parent + ".currentSnapshot"))
        {
            this.CurrentSnapshot = new CdmSnapshot();
            this.CurrentSnapshot.ApplyExploratoryFieldSpec(parent + ".currentSnapshot");
        }
        //      C# -> List<SnapshotFileDeltaEdge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<SnapshotFileDeltaEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> List<SnapshotFileDelta>? Nodes
        // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<SnapshotFileDelta>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(parent + ".pageInfo");
        }
        //      C# -> CdmSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: CdmSnapshot (type)
        if (this.PreviousSnapshot == null && Exploration.Includes(parent + ".previousSnapshot"))
        {
            this.PreviousSnapshot = new CdmSnapshot();
            this.PreviousSnapshot.ApplyExploratoryFieldSpec(parent + ".previousSnapshot");
        }
    }


    #endregion

    } // class SnapshotFileDeltaConnection
    
    #endregion

    public static class ListSnapshotFileDeltaConnectionExtensions
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
            this List<SnapshotFileDeltaConnection> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFileDeltaConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFileDeltaConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types