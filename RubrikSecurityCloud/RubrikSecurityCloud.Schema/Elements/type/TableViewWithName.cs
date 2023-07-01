// TableViewWithName.cs
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
    #region TableViewWithName
    public class TableViewWithName: BaseType
    {
        #region members

        //      C# -> TableViewType? TableViewType
        // GraphQL -> tableViewType: TableViewType! (enum)
        [JsonProperty("tableViewType")]
        public TableViewType? TableViewType { get; set; }

        //      C# -> System.String? TableName
        // GraphQL -> tableName: String! (scalar)
        [JsonProperty("tableName")]
        public System.String? TableName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TableViewWithName";
    }

    public TableViewWithName Set(
        TableViewType? TableViewType = null,
        System.String? TableName = null
    ) 
    {
        if ( TableViewType != null ) {
            this.TableViewType = TableViewType;
        }
        if ( TableName != null ) {
            this.TableName = TableName;
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
        //      C# -> TableViewType? TableViewType
        // GraphQL -> tableViewType: TableViewType! (enum)
        if (this.TableViewType != null) {
            s += ind + "tableViewType\n" ;
        }
        //      C# -> System.String? TableName
        // GraphQL -> tableName: String! (scalar)
        if (this.TableName != null) {
            s += ind + "tableName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TableViewType? TableViewType
        // GraphQL -> tableViewType: TableViewType! (enum)
        if (this.TableViewType == null && Exploration.Includes(parent + ".tableViewType", true))
        {
            this.TableViewType = new TableViewType();
        }
        //      C# -> System.String? TableName
        // GraphQL -> tableName: String! (scalar)
        if (this.TableName == null && Exploration.Includes(parent + ".tableName", true))
        {
            this.TableName = "FETCH";
        }
    }


    #endregion

    } // class TableViewWithName
    
    #endregion

    public static class ListTableViewWithNameExtensions
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
            this List<TableViewWithName> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TableViewWithName> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TableViewWithName());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types