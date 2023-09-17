// CassandraSchemaObject.cs
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
    #region CassandraSchemaObject
    public class CassandraSchemaObject: BaseType
    {
        #region members

        //      C# -> List<System.String>? PrimaryKeys
        // GraphQL -> primaryKeys: [String!]! (scalar)
        [JsonProperty("primaryKeys")]
        public List<System.String>? PrimaryKeys { get; set; }

        //      C# -> List<CassandraColumnObject>? Columns
        // GraphQL -> columns: [CassandraColumnObject!]! (type)
        [JsonProperty("columns")]
        public List<CassandraColumnObject>? Columns { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CassandraSchemaObject";
    }

    public CassandraSchemaObject Set(
        List<System.String>? PrimaryKeys = null,
        List<CassandraColumnObject>? Columns = null
    ) 
    {
        if ( PrimaryKeys != null ) {
            this.PrimaryKeys = PrimaryKeys;
        }
        if ( Columns != null ) {
            this.Columns = Columns;
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
        //      C# -> List<System.String>? PrimaryKeys
        // GraphQL -> primaryKeys: [String!]! (scalar)
        if (this.PrimaryKeys != null) {
            s += ind + "primaryKeys\n" ;
        }
        //      C# -> List<CassandraColumnObject>? Columns
        // GraphQL -> columns: [CassandraColumnObject!]! (type)
        if (this.Columns != null) {
            var fspec = this.Columns.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "columns {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? PrimaryKeys
        // GraphQL -> primaryKeys: [String!]! (scalar)
        if (this.PrimaryKeys == null && ec.Includes("primaryKeys",true))
        {
            this.PrimaryKeys = new List<System.String>();
        }
        //      C# -> List<CassandraColumnObject>? Columns
        // GraphQL -> columns: [CassandraColumnObject!]! (type)
        if (this.Columns == null && ec.Includes("columns",false))
        {
            this.Columns = new List<CassandraColumnObject>();
            this.Columns.ApplyExploratoryFieldSpec(ec.NewChild("columns"));
        }
    }


    #endregion

    } // class CassandraSchemaObject
    
    #endregion

    public static class ListCassandraSchemaObjectExtensions
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
            this List<CassandraSchemaObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CassandraSchemaObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CassandraSchemaObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CassandraSchemaObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types