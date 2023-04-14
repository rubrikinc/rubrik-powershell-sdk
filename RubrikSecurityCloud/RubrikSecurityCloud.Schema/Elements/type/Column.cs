// Column.cs
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
    #region Column
    public class Column: IFragment
    {
        #region members
        //      C# -> System.Boolean? Aggregate
        // GraphQL -> aggregate: Boolean! (scalar)
        [JsonProperty("aggregate")]
        public System.Boolean? Aggregate { get; set; }

        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        [JsonProperty("default")]
        public System.Boolean? Default { get; set; }

        //      C# -> System.Boolean? Dimensional
        // GraphQL -> dimensional: Boolean! (scalar)
        [JsonProperty("dimensional")]
        public System.Boolean? Dimensional { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Boolean? Nullable
        // GraphQL -> nullable: Boolean! (scalar)
        [JsonProperty("nullable")]
        public System.Boolean? Nullable { get; set; }

        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        [JsonProperty("sortable")]
        public System.Boolean? Sortable { get; set; }

        //      C# -> DataTypeEnum? Type
        // GraphQL -> type: DataTypeEnum! (enum)
        [JsonProperty("type")]
        public DataTypeEnum? Type { get; set; }

        #endregion

    #region methods

    public Column Set(
        System.Boolean? Aggregate = null,
        System.Boolean? Default = null,
        System.Boolean? Dimensional = null,
        System.String? DisplayName = null,
        System.String? Name = null,
        System.Boolean? Nullable = null,
        System.Boolean? Sortable = null,
        DataTypeEnum? Type = null
    ) 
    {
        if ( Aggregate != null ) {
            this.Aggregate = Aggregate;
        }
        if ( Default != null ) {
            this.Default = Default;
        }
        if ( Dimensional != null ) {
            this.Dimensional = Dimensional;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Nullable != null ) {
            this.Nullable = Nullable;
        }
        if ( Sortable != null ) {
            this.Sortable = Sortable;
        }
        if ( Type != null ) {
            this.Type = Type;
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
            //      C# -> System.Boolean? Aggregate
            // GraphQL -> aggregate: Boolean! (scalar)
            if (this.Aggregate != null)
            {
                 s += ind + "aggregate\n";

            }
            //      C# -> System.Boolean? Default
            // GraphQL -> default: Boolean! (scalar)
            if (this.Default != null)
            {
                 s += ind + "default\n";

            }
            //      C# -> System.Boolean? Dimensional
            // GraphQL -> dimensional: Boolean! (scalar)
            if (this.Dimensional != null)
            {
                 s += ind + "dimensional\n";

            }
            //      C# -> System.String? DisplayName
            // GraphQL -> displayName: String! (scalar)
            if (this.DisplayName != null)
            {
                 s += ind + "displayName\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Boolean? Nullable
            // GraphQL -> nullable: Boolean! (scalar)
            if (this.Nullable != null)
            {
                 s += ind + "nullable\n";

            }
            //      C# -> System.Boolean? Sortable
            // GraphQL -> sortable: Boolean! (scalar)
            if (this.Sortable != null)
            {
                 s += ind + "sortable\n";

            }
            //      C# -> DataTypeEnum? Type
            // GraphQL -> type: DataTypeEnum! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? Aggregate
            // GraphQL -> aggregate: Boolean! (scalar)
            if (this.Aggregate == null && Exploration.Includes(parent + ".aggregate$"))
            {
                this.Aggregate = new System.Boolean();
            }
            //      C# -> System.Boolean? Default
            // GraphQL -> default: Boolean! (scalar)
            if (this.Default == null && Exploration.Includes(parent + ".default$"))
            {
                this.Default = new System.Boolean();
            }
            //      C# -> System.Boolean? Dimensional
            // GraphQL -> dimensional: Boolean! (scalar)
            if (this.Dimensional == null && Exploration.Includes(parent + ".dimensional$"))
            {
                this.Dimensional = new System.Boolean();
            }
            //      C# -> System.String? DisplayName
            // GraphQL -> displayName: String! (scalar)
            if (this.DisplayName == null && Exploration.Includes(parent + ".displayName$"))
            {
                this.DisplayName = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Boolean? Nullable
            // GraphQL -> nullable: Boolean! (scalar)
            if (this.Nullable == null && Exploration.Includes(parent + ".nullable$"))
            {
                this.Nullable = new System.Boolean();
            }
            //      C# -> System.Boolean? Sortable
            // GraphQL -> sortable: Boolean! (scalar)
            if (this.Sortable == null && Exploration.Includes(parent + ".sortable$"))
            {
                this.Sortable = new System.Boolean();
            }
            //      C# -> DataTypeEnum? Type
            // GraphQL -> type: DataTypeEnum! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new DataTypeEnum();
            }
        }


    #endregion

    } // class Column
    #endregion

    public static class ListColumnExtensions
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
            this List<Column> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Column> list, 
            String parent = "")
        {
            var item = new Column();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types