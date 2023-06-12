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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region Column
    public class Column: BaseType
    {
        #region members

        //      C# -> DataTypeEnum? Type
        // GraphQL -> type: DataTypeEnum! (enum)
        [JsonProperty("type")]
        public DataTypeEnum? Type { get; set; }

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


        #endregion

    #region methods

    public Column Set(
        DataTypeEnum? Type = null,
        System.Boolean? Aggregate = null,
        System.Boolean? Default = null,
        System.Boolean? Dimensional = null,
        System.String? DisplayName = null,
        System.String? Name = null,
        System.Boolean? Nullable = null,
        System.Boolean? Sortable = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DataTypeEnum? Type
        // GraphQL -> type: DataTypeEnum! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.Boolean? Aggregate
        // GraphQL -> aggregate: Boolean! (scalar)
        if (this.Aggregate != null) {
            s += ind + "aggregate\n" ;
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (this.Default != null) {
            s += ind + "default\n" ;
        }
        //      C# -> System.Boolean? Dimensional
        // GraphQL -> dimensional: Boolean! (scalar)
        if (this.Dimensional != null) {
            s += ind + "dimensional\n" ;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            s += ind + "displayName\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Boolean? Nullable
        // GraphQL -> nullable: Boolean! (scalar)
        if (this.Nullable != null) {
            s += ind + "nullable\n" ;
        }
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (this.Sortable != null) {
            s += ind + "sortable\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DataTypeEnum? Type
        // GraphQL -> type: DataTypeEnum! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new DataTypeEnum();
        }
        //      C# -> System.Boolean? Aggregate
        // GraphQL -> aggregate: Boolean! (scalar)
        if (this.Aggregate == null && Exploration.Includes(parent + ".aggregate", true))
        {
            this.Aggregate = true;
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (this.Default == null && Exploration.Includes(parent + ".default", true))
        {
            this.Default = true;
        }
        //      C# -> System.Boolean? Dimensional
        // GraphQL -> dimensional: Boolean! (scalar)
        if (this.Dimensional == null && Exploration.Includes(parent + ".dimensional", true))
        {
            this.Dimensional = true;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName == null && Exploration.Includes(parent + ".displayName", true))
        {
            this.DisplayName = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Boolean? Nullable
        // GraphQL -> nullable: Boolean! (scalar)
        if (this.Nullable == null && Exploration.Includes(parent + ".nullable", true))
        {
            this.Nullable = true;
        }
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (this.Sortable == null && Exploration.Includes(parent + ".sortable", true))
        {
            this.Sortable = true;
        }
    }


    #endregion

    } // class Column
    
    #endregion

    public static class ListColumnExtensions
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
            this List<Column> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Column> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Column());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types