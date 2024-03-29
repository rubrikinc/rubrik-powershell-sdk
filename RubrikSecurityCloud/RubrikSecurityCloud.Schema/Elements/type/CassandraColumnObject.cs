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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "CassandraColumnObject";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String (scalar)
        if (this.ColumnName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "columnName\n" ;
            } else {
                s += ind + "columnName\n" ;
            }
        }
        //      C# -> System.String? ColumnType
        // GraphQL -> columnType: String (scalar)
        if (this.ColumnType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "columnType\n" ;
            } else {
                s += ind + "columnType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ColumnName
        // GraphQL -> columnName: String (scalar)
        if (ec.Includes("columnName",true))
        {
            if(this.ColumnName == null) {

                this.ColumnName = "FETCH";

            } else {


            }
        }
        else if (this.ColumnName != null && ec.Excludes("columnName",true))
        {
            this.ColumnName = null;
        }
        //      C# -> System.String? ColumnType
        // GraphQL -> columnType: String (scalar)
        if (ec.Includes("columnType",true))
        {
            if(this.ColumnType == null) {

                this.ColumnType = "FETCH";

            } else {


            }
        }
        else if (this.ColumnType != null && ec.Excludes("columnType",true))
        {
            this.ColumnType = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CassandraColumnObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CassandraColumnObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CassandraColumnObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CassandraColumnObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types