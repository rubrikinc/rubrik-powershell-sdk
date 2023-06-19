// SnapshotFileDeltaV2Connection.cs
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
    #region SnapshotFileDeltaV2Connection
    public class SnapshotFileDeltaV2Connection: BaseType
    {
        #region members

        //      C# -> GenericSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
        [JsonProperty("currentSnapshot")]
        public GenericSnapshot? CurrentSnapshot { get; set; }

        //      C# -> GenericSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: GenericSnapshot (interface)
        [JsonProperty("previousSnapshot")]
        public GenericSnapshot? PreviousSnapshot { get; set; }

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


        #endregion

    #region methods

    public SnapshotFileDeltaV2Connection Set(
        GenericSnapshot? CurrentSnapshot = null,
        GenericSnapshot? PreviousSnapshot = null,
        System.Int32? Count = null,
        List<SnapshotFileDeltaV2Edge>? Edges = null,
        List<SnapshotFileDeltaV2>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( CurrentSnapshot != null ) {
            this.CurrentSnapshot = CurrentSnapshot;
        }
        if ( PreviousSnapshot != null ) {
            this.PreviousSnapshot = PreviousSnapshot;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> GenericSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
        if (this.CurrentSnapshot != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CurrentSnapshot).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "currentSnapshot {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> GenericSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: GenericSnapshot (interface)
        if (this.PreviousSnapshot != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PreviousSnapshot).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "previousSnapshot {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<SnapshotFileDeltaV2Edge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaV2Edge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SnapshotFileDeltaV2>? Nodes
        // GraphQL -> nodes: [SnapshotFileDeltaV2!]! (type)
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
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> GenericSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
        if (this.CurrentSnapshot == null && Exploration.Includes(parent + ".currentSnapshot"))
        {
            var impls = new List<GenericSnapshot>();
            impls.ApplyExploratoryFieldSpec(parent + ".currentSnapshot");
            this.CurrentSnapshot = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> GenericSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: GenericSnapshot (interface)
        if (this.PreviousSnapshot == null && Exploration.Includes(parent + ".previousSnapshot"))
        {
            var impls = new List<GenericSnapshot>();
            impls.ApplyExploratoryFieldSpec(parent + ".previousSnapshot");
            this.PreviousSnapshot = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<SnapshotFileDeltaV2Edge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaV2Edge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<SnapshotFileDeltaV2Edge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> List<SnapshotFileDeltaV2>? Nodes
        // GraphQL -> nodes: [SnapshotFileDeltaV2!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<SnapshotFileDeltaV2>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(parent + ".pageInfo");
        }
    }


    #endregion

    } // class SnapshotFileDeltaV2Connection
    
    #endregion

    public static class ListSnapshotFileDeltaV2ConnectionExtensions
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
            this List<SnapshotFileDeltaV2Connection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFileDeltaV2Connection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFileDeltaV2Connection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types