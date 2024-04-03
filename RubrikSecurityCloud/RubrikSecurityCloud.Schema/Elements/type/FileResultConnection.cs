// FileResultConnection.cs
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
    #region FileResultConnection
    public class FileResultConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.Boolean? HasLatestData
        // GraphQL -> hasLatestData: Boolean! (scalar)
        [JsonProperty("hasLatestData")]
        public System.Boolean? HasLatestData { get; set; }

        //      C# -> System.Int32? IndexingVersion
        // GraphQL -> indexingVersion: Int! (scalar)
        [JsonProperty("indexingVersion")]
        public System.Int32? IndexingVersion { get; set; }

        //      C# -> List<FileResultEdge>? Edges
        // GraphQL -> edges: [FileResultEdge!]! (type)
        [JsonProperty("edges")]
        public List<FileResultEdge>? Edges { get; set; }

        //      C# -> List<FileResult>? Nodes
        // GraphQL -> nodes: [FileResult!]! (type)
        [JsonProperty("nodes")]
        public List<FileResult>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FileResultConnection";
    }

    public FileResultConnection Set(
        System.Int32? Count = null,
        System.Boolean? HasLatestData = null,
        System.Int32? IndexingVersion = null,
        List<FileResultEdge>? Edges = null,
        List<FileResult>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( HasLatestData != null ) {
            this.HasLatestData = HasLatestData;
        }
        if ( IndexingVersion != null ) {
            this.IndexingVersion = IndexingVersion;
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
        //      C# -> System.Boolean? HasLatestData
        // GraphQL -> hasLatestData: Boolean! (scalar)
        if (this.HasLatestData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasLatestData\n" ;
            } else {
                s += ind + "hasLatestData\n" ;
            }
        }
        //      C# -> System.Int32? IndexingVersion
        // GraphQL -> indexingVersion: Int! (scalar)
        if (this.IndexingVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexingVersion\n" ;
            } else {
                s += ind + "indexingVersion\n" ;
            }
        }
        //      C# -> List<FileResultEdge>? Edges
        // GraphQL -> edges: [FileResultEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(conf.Child("edges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "edges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FileResult>? Nodes
        // GraphQL -> nodes: [FileResult!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(conf.Child("nodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> System.Boolean? HasLatestData
        // GraphQL -> hasLatestData: Boolean! (scalar)
        if (ec.Includes("hasLatestData",true))
        {
            if(this.HasLatestData == null) {

                this.HasLatestData = true;

            } else {


            }
        }
        else if (this.HasLatestData != null && ec.Excludes("hasLatestData",true))
        {
            this.HasLatestData = null;
        }
        //      C# -> System.Int32? IndexingVersion
        // GraphQL -> indexingVersion: Int! (scalar)
        if (ec.Includes("indexingVersion",true))
        {
            if(this.IndexingVersion == null) {

                this.IndexingVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.IndexingVersion != null && ec.Excludes("indexingVersion",true))
        {
            this.IndexingVersion = null;
        }
        //      C# -> List<FileResultEdge>? Edges
        // GraphQL -> edges: [FileResultEdge!]! (type)
        if (ec.Includes("edges",false))
        {
            if(this.Edges == null) {

                this.Edges = new List<FileResultEdge>();
                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            } else {

                this.Edges.ApplyExploratoryFieldSpec(ec.NewChild("edges"));

            }
        }
        else if (this.Edges != null && ec.Excludes("edges",false))
        {
            this.Edges = null;
        }
        //      C# -> List<FileResult>? Nodes
        // GraphQL -> nodes: [FileResult!]! (type)
        if (ec.Includes("nodes",false))
        {
            if(this.Nodes == null) {

                this.Nodes = new List<FileResult>();
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

    } // class FileResultConnection
    
    #endregion

    public static class ListFileResultConnectionExtensions
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
            this List<FileResultConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FileResultConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FileResultConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileResultConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileResultConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types