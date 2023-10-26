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

    public override string GetGqlTypeName() {
        return "SnapshotFileDeltaV2Connection";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> GenericSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
        if (this.CurrentSnapshot != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CurrentSnapshot).AsFieldSpec(conf.Child("currentSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentSnapshot {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> GenericSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: GenericSnapshot (interface)
        if (this.PreviousSnapshot != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PreviousSnapshot).AsFieldSpec(conf.Child("previousSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "previousSnapshot {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> List<SnapshotFileDeltaV2Edge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaV2Edge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(conf.Child("edges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "edges {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnapshotFileDeltaV2>? Nodes
        // GraphQL -> nodes: [SnapshotFileDeltaV2!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nodes {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> GenericSnapshot? CurrentSnapshot
        // GraphQL -> currentSnapshot: GenericSnapshot! (interface)
        if (ec.Includes("currentSnapshot",false))
        {
            if(this.CurrentSnapshot == null) {

                var impls = new List<GenericSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("currentSnapshot"));
                this.CurrentSnapshot = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<GenericSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("currentSnapshot"));
                this.CurrentSnapshot = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.CurrentSnapshot != null && ec.Excludes("currentSnapshot",false))
        {
            this.CurrentSnapshot = null;
        }
        //      C# -> GenericSnapshot? PreviousSnapshot
        // GraphQL -> previousSnapshot: GenericSnapshot (interface)
        if (ec.Includes("previousSnapshot",false))
        {
            if(this.PreviousSnapshot == null) {

                var impls = new List<GenericSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshot"));
                this.PreviousSnapshot = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<GenericSnapshot>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("previousSnapshot"));
                this.PreviousSnapshot = (GenericSnapshot)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.PreviousSnapshot != null && ec.Excludes("previousSnapshot",false))
        {
            this.PreviousSnapshot = null;
        }
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
        //      C# -> List<SnapshotFileDeltaV2Edge>? Edges
        // GraphQL -> edges: [SnapshotFileDeltaV2Edge!]! (type)
        if (ec.Includes("edges",false))
        {
            if(this.Edges == null) {

                this.Edges = new List<SnapshotFileDeltaV2Edge>();
                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            } else {

                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            }
        }
        else if (this.Edges != null && ec.Excludes("edges",false))
        {
            this.Edges = null;
        }
        //      C# -> List<SnapshotFileDeltaV2>? Nodes
        // GraphQL -> nodes: [SnapshotFileDeltaV2!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<SnapshotFileDeltaV2>();
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SnapshotFileDeltaV2Connection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFileDeltaV2Connection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFileDeltaV2Connection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotFileDeltaV2Connection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types