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

namespace Rubrik.SecurityCloud.Types
{
    #region CassandraSchemaObject
    public class CassandraSchemaObject: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? PrimaryKeys
            // GraphQL -> primaryKeys: [String!]! (scalar)
            if (this.PrimaryKeys != null)
            {
                 s += ind + "primaryKeys\n";

            }
            //      C# -> List<CassandraColumnObject>? Columns
            // GraphQL -> columns: [CassandraColumnObject!]! (type)
            if (this.Columns != null)
            {
                 s += ind + "columns\n";

                 s += ind + "{\n" + 
                 this.Columns.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? PrimaryKeys
            // GraphQL -> primaryKeys: [String!]! (scalar)
            if (this.PrimaryKeys == null && Exploration.Includes(parent + ".primaryKeys$"))
            {
                this.PrimaryKeys = new List<System.String>();
            }
            //      C# -> List<CassandraColumnObject>? Columns
            // GraphQL -> columns: [CassandraColumnObject!]! (type)
            if (this.Columns == null && Exploration.Includes(parent + ".columns"))
            {
                this.Columns = new List<CassandraColumnObject>();
                this.Columns.ApplyExploratoryFragment(parent + ".columns");
            }
        }


    #endregion

    } // class CassandraSchemaObject
    #endregion

    public static class ListCassandraSchemaObjectExtensions
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
            this List<CassandraSchemaObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CassandraSchemaObject> list, 
            String parent = "")
        {
            var item = new CassandraSchemaObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types