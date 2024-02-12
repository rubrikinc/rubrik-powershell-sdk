// PaginationMarker.cs
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
    #region PaginationMarker
    public class PaginationMarker: BaseType
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> List<System.Int64>? SortKey
        // GraphQL -> sortKey: [Long!]! (scalar)
        [JsonProperty("sortKey")]
        public List<System.Int64>? SortKey { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PaginationMarker";
    }

    public PaginationMarker Set(
        System.String? Key = null,
        List<System.Int64>? SortKey = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( SortKey != null ) {
            this.SortKey = SortKey;
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
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> List<System.Int64>? SortKey
        // GraphQL -> sortKey: [Long!]! (scalar)
        if (this.SortKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sortKey\n" ;
            } else {
                s += ind + "sortKey\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = "FETCH";

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> List<System.Int64>? SortKey
        // GraphQL -> sortKey: [Long!]! (scalar)
        if (ec.Includes("sortKey",true))
        {
            if(this.SortKey == null) {

                this.SortKey = new List<System.Int64>();

            } else {


            }
        }
        else if (this.SortKey != null && ec.Excludes("sortKey",true))
        {
            this.SortKey = null;
        }
    }


    #endregion

    } // class PaginationMarker
    
    #endregion

    public static class ListPaginationMarkerExtensions
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
            this List<PaginationMarker> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PaginationMarker> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PaginationMarker> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PaginationMarker());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PaginationMarker> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types