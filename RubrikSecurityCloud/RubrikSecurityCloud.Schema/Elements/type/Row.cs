// Row.cs
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
    #region Row
    public class Row: BaseType
    {
        #region members

        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }

        //      C# -> List<CellData>? Values
        // GraphQL -> values: [CellData!]! (type)
        [JsonProperty("values")]
        public List<CellData>? Values { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Row";
    }

    public Row Set(
        List<Metadata>? Metadata = null,
        List<CellData>? Values = null
    ) 
    {
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( Values != null ) {
            this.Values = Values;
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
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "metadata {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CellData>? Values
        // GraphQL -> values: [CellData!]! (type)
        if (this.Values != null) {
            var fspec = this.Values.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "values {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata == null && Exploration.Includes(parent + ".metadata"))
        {
            this.Metadata = new List<Metadata>();
            this.Metadata.ApplyExploratoryFieldSpec(parent + ".metadata");
        }
        //      C# -> List<CellData>? Values
        // GraphQL -> values: [CellData!]! (type)
        if (this.Values == null && Exploration.Includes(parent + ".values"))
        {
            this.Values = new List<CellData>();
            this.Values.ApplyExploratoryFieldSpec(parent + ".values");
        }
    }


    #endregion

    } // class Row
    
    #endregion

    public static class ListRowExtensions
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
            this List<Row> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Row> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Row());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types