// CassandraColumnObject.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:17.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region CassandraColumnObject
    public class CassandraColumnObject: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ColumnName
            // GraphQL -> columnName: String (scalar)
            if (this.ColumnName != null)
            {
                 s += ind + "columnName\n";

            }
            //      C# -> System.String? ColumnType
            // GraphQL -> columnType: String (scalar)
            if (this.ColumnType != null)
            {
                 s += ind + "columnType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ColumnName
            // GraphQL -> columnName: String (scalar)
            if (this.ColumnName == null && Exploration.Includes(parent + ".columnName$"))
            {
                this.ColumnName = new System.String("FETCH");
            }
            //      C# -> System.String? ColumnType
            // GraphQL -> columnType: String (scalar)
            if (this.ColumnType == null && Exploration.Includes(parent + ".columnType$"))
            {
                this.ColumnType = new System.String("FETCH");
            }
        }


    #endregion

    } // class CassandraColumnObject
    #endregion

    public static class ListCassandraColumnObjectExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CassandraColumnObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CassandraColumnObject> list, 
            String parent = "")
        {
            var item = new CassandraColumnObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types