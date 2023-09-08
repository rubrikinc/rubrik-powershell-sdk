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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "SnapshotFileDeltaConnection";
    }

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
            var fspec = this.CurrentSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "currentSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SnapshotFileDeltaEdge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SnapshotFileDelta>? Nodes
        // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: CdmSnapshot (type)
        if (this.PreviousSnapshot != null) {
            var fspec = this.PreviousSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "previousSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && ec.Includes("count",true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> CdmSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: CdmSnapshot! (type)
        if (this.CurrentSnapshot == null && ec.Includes("currentSnapshot",false))
        {
            this.CurrentSnapshot = new CdmSnapshot();
            this.CurrentSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("currentSnapshot"));
        }
        //      C# -> List<SnapshotFileDeltaEdge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
        if (this.Edges == null && ec.Includes("edges",false))
        {
            this.Edges = new List<SnapshotFileDeltaEdge>();
            this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));
        }
        //      C# -> List<SnapshotFileDelta>? Nodes
        // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
        if (this.Nodes == null && ec.Includes("nodes",false))
        {
            this.Nodes = new List<SnapshotFileDelta>();
            this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && ec.Includes("pageInfo",false))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));
        }
        //      C# -> CdmSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: CdmSnapshot (type)
        if (this.PreviousSnapshot == null && ec.Includes("previousSnapshot",false))
        {
            this.PreviousSnapshot = new CdmSnapshot();
            this.PreviousSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshot"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFileDeltaConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFileDeltaConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SnapshotFileDeltaConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types