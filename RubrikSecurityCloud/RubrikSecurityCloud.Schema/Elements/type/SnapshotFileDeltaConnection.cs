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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> CdmSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: CdmSnapshot! (type)
        if (this.CurrentSnapshot != null) {
            var fspec = this.CurrentSnapshot.AsFieldSpec(conf.Child("currentSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotFileDeltaEdge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(conf.Child("edges"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "edges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotFileDelta>? Nodes
        // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: CdmSnapshot (type)
        if (this.PreviousSnapshot != null) {
            var fspec = this.PreviousSnapshot.AsFieldSpec(conf.Child("previousSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "previousSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> CdmSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: CdmSnapshot! (type)
        if (ec.Includes("currentSnapshot",false))
        {
            if(this.CurrentSnapshot == null) {

                this.CurrentSnapshot = new CdmSnapshot();
                this.CurrentSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("currentSnapshot"));

            } else {

                this.CurrentSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("currentSnapshot"));

            }
        }
        else if (this.CurrentSnapshot != null && ec.Excludes("currentSnapshot",false))
        {
            this.CurrentSnapshot = null;
        }
        //      C# -> List<SnapshotFileDeltaEdge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaEdge!]! (type)
        if (ec.Includes("edges",false))
        {
            if(this.Edges == null) {

                this.Edges = new List<SnapshotFileDeltaEdge>();
                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            } else {

                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            }
        }
        else if (this.Edges != null && ec.Excludes("edges",false))
        {
            this.Edges = null;
        }
        //      C# -> List<SnapshotFileDelta>? Nodes
        // GraphQL -> nodes: [SnapshotFileDelta!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<SnapshotFileDelta>();
                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            } else {

                this.Nodes.ApplyExploratoryFieldSpec(ec.NewChild("nodes"));

            }
        }
        else if (this.Nodes != null && ec.Excludes("nodes",false))
        {
            this.Nodes = null;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (ec.Includes("pageInfo",false))
        {
            if(this.PageInfo == null) {

                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            } else {

                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            }
        }
        else if (this.PageInfo != null && ec.Excludes("pageInfo",false))
        {
            this.PageInfo = null;
        }
        //      C# -> CdmSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: CdmSnapshot (type)
        if (ec.Includes("previousSnapshot",false))
        {
            if(this.PreviousSnapshot == null) {

                this.PreviousSnapshot = new CdmSnapshot();
                this.PreviousSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshot"));

            } else {

                this.PreviousSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshot"));

            }
        }
        else if (this.PreviousSnapshot != null && ec.Excludes("previousSnapshot",false))
        {
            this.PreviousSnapshot = null;
        }
    }


    #endregion

    } // class SnapshotFileDeltaConnection
    
    #endregion

    public static class ListSnapshotFileDeltaConnectionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SnapshotFileDeltaConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotFileDeltaConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SnapshotFileDeltaConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types