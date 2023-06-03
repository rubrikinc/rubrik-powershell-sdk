// CassandraColumnObject.cs
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
    #region CassandraColumnObject
    public class CassandraColumnObject: BaseType
    {
        #region members

        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String (scalar)
        [JsonProperty("columnName")]
        public System.String? ColumnName { get; set; }

        //      C# -> System.String? ColumnType
        // GraphQL -> columnType: String (scalar)
        [JsonProperty("columnType")]
        public System.String? ColumnType { get; set; }


        #endregion

    #region methods

    public CassandraColumnObject Set(
        System.String? ColumnName = null,
        System.String? ColumnType = null
    ) 
    {
        if ( ColumnName != null ) {
            this.ColumnName = ColumnName;
        }
        if ( ColumnType != null ) {
            this.ColumnType = ColumnType;
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
        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String (scalar)
        if (this.ColumnName != null) {
            s += ind + "columnName\n" ;
        }
        //      C# -> System.String? ColumnType
        // GraphQL -> columnType: String (scalar)
        if (this.ColumnType != null) {
            s += ind + "columnType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String (scalar)
        if (this.ColumnName == null && Exploration.Includes(parent + ".columnName", true))
        {
            this.ColumnName = new System.String("FETCH");
        }
        //      C# -> System.String? ColumnType
        // GraphQL -> columnType: String (scalar)
        if (this.ColumnType == null && Exploration.Includes(parent + ".columnType", true))
        {
            this.ColumnType = new System.String("FETCH");
        }
    }


    #endregion

    } // class CassandraColumnObject
    
    #endregion

    public static class ListCassandraColumnObjectExtensions
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
            this List<CassandraColumnObject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CassandraColumnObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CassandraColumnObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types