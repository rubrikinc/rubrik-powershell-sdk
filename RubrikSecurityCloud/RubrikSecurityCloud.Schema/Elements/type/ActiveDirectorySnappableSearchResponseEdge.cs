// ActiveDirectorySnappableSearchResponseEdge.cs
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
    #region ActiveDirectorySnappableSearchResponseEdge
    public class ActiveDirectorySnappableSearchResponseEdge: BaseType
    {
        #region members

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }

        //      C# -> ActiveDirectorySnappableSearchResponse? Node
        // GraphQL -> node: ActiveDirectorySnappableSearchResponse! (type)
        [JsonProperty("node")]
        public ActiveDirectorySnappableSearchResponse? Node { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectorySnappableSearchResponseEdge";
    }

    public ActiveDirectorySnappableSearchResponseEdge Set(
        System.String? Cursor = null,
        ActiveDirectorySnappableSearchResponse? Node = null
    ) 
    {
        if ( Cursor != null ) {
            this.Cursor = Cursor;
        }
        if ( Node != null ) {
            this.Node = Node;
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
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cursor\n" ;
            } else {
                s += ind + "cursor\n" ;
            }
        }
        //      C# -> ActiveDirectorySnappableSearchResponse? Node
        // GraphQL -> node: ActiveDirectorySnappableSearchResponse! (type)
        if (this.Node != null) {
            var fspec = this.Node.AsFieldSpec(conf.Child("node"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "node {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (ec.Includes("cursor",true))
        {
            if(this.Cursor == null) {

                this.Cursor = "FETCH";

            } else {


            }
        }
        else if (this.Cursor != null && ec.Excludes("cursor",true))
        {
            this.Cursor = null;
        }
        //      C# -> ActiveDirectorySnappableSearchResponse? Node
        // GraphQL -> node: ActiveDirectorySnappableSearchResponse! (type)
        if (ec.Includes("node",false))
        {
            if(this.Node == null) {

                this.Node = new ActiveDirectorySnappableSearchResponse();
                this.Node.ApplyExploratoryFieldSpec(ec.NewChild("node"));

            } else {

                this.Node.ApplyExploratoryFieldSpec(ec.NewChild("node"));

            }
        }
        else if (this.Node != null && ec.Excludes("node",false))
        {
            this.Node = null;
        }
    }


    #endregion

    } // class ActiveDirectorySnappableSearchResponseEdge
    
    #endregion

    public static class ListActiveDirectorySnappableSearchResponseEdgeExtensions
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
            this List<ActiveDirectorySnappableSearchResponseEdge> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ActiveDirectorySnappableSearchResponseEdge> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectorySnappableSearchResponseEdge> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectorySnappableSearchResponseEdge());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectorySnappableSearchResponseEdge> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types