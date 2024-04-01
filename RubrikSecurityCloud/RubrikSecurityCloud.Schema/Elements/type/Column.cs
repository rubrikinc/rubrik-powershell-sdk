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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "Column";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DataTypeEnum? Type
        // GraphQL -> type: DataTypeEnum! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.Boolean? Aggregate
        // GraphQL -> aggregate: Boolean! (scalar)
        if (this.Aggregate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregate\n" ;
            } else {
                s += ind + "aggregate\n" ;
            }
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (this.Default != null) {
            if (conf.Flat) {
                s += conf.Prefix + "default\n" ;
            } else {
                s += ind + "default\n" ;
            }
        }
        //      C# -> System.Boolean? Dimensional
        // GraphQL -> dimensional: Boolean! (scalar)
        if (this.Dimensional != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dimensional\n" ;
            } else {
                s += ind + "dimensional\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Boolean? Nullable
        // GraphQL -> nullable: Boolean! (scalar)
        if (this.Nullable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nullable\n" ;
            } else {
                s += ind + "nullable\n" ;
            }
        }
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (this.Sortable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sortable\n" ;
            } else {
                s += ind + "sortable\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DataTypeEnum? Type
        // GraphQL -> type: DataTypeEnum! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new DataTypeEnum();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.Boolean? Aggregate
        // GraphQL -> aggregate: Boolean! (scalar)
        if (ec.Includes("aggregate",true))
        {
            if(this.Aggregate == null) {

                this.Aggregate = true;

            } else {


            }
        }
        else if (this.Aggregate != null && ec.Excludes("aggregate",true))
        {
            this.Aggregate = null;
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (ec.Includes("default",true))
        {
            if(this.Default == null) {

                this.Default = true;

            } else {


            }
        }
        else if (this.Default != null && ec.Excludes("default",true))
        {
            this.Default = null;
        }
        //      C# -> System.Boolean? Dimensional
        // GraphQL -> dimensional: Boolean! (scalar)
        if (ec.Includes("dimensional",true))
        {
            if(this.Dimensional == null) {

                this.Dimensional = true;

            } else {


            }
        }
        else if (this.Dimensional != null && ec.Excludes("dimensional",true))
        {
            this.Dimensional = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Boolean? Nullable
        // GraphQL -> nullable: Boolean! (scalar)
        if (ec.Includes("nullable",true))
        {
            if(this.Nullable == null) {

                this.Nullable = true;

            } else {


            }
        }
        else if (this.Nullable != null && ec.Excludes("nullable",true))
        {
            this.Nullable = null;
        }
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (ec.Includes("sortable",true))
        {
            if(this.Sortable == null) {

                this.Sortable = true;

            } else {


            }
        }
        else if (this.Sortable != null && ec.Excludes("sortable",true))
        {
            this.Sortable = null;
        }
    }


    #endregion

    } // class Column
    
    #endregion

    public static class ListColumnExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<Column> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Column> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Column> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Column());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Column> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types