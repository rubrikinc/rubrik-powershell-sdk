// ReportConfig.cs
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
    #region ReportConfig
    public class ReportConfig: BaseType
    {
        #region members

        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        [JsonProperty("dataViewType")]
        public DataViewTypeEnum? DataViewType { get; set; }

        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        [JsonProperty("sortOrder")]
        public SortOrder? SortOrder { get; set; }

        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        [JsonProperty("aggregations")]
        public List<System.String>? Aggregations { get; set; }

        //      C# -> List<System.String>? Columns
        // GraphQL -> columns: [String!]! (scalar)
        [JsonProperty("columns")]
        public List<System.String>? Columns { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SortBy
        // GraphQL -> sortBy: String! (scalar)
        [JsonProperty("sortBy")]
        public System.String? SortBy { get; set; }

        //      C# -> List<ConfigFilter>? Filters
        // GraphQL -> filters: [ConfigFilter!]! (type)
        [JsonProperty("filters")]
        public List<ConfigFilter>? Filters { get; set; }

        //      C# -> ConfigGroupBy? GroupBy
        // GraphQL -> groupBy: configGroupBy! (type)
        [JsonProperty("groupBy")]
        public ConfigGroupBy? GroupBy { get; set; }


        #endregion

    #region methods

    public ReportConfig Set(
        DataViewTypeEnum? DataViewType = null,
        SortOrder? SortOrder = null,
        List<System.String>? Aggregations = null,
        List<System.String>? Columns = null,
        System.Int64? Id = null,
        System.String? Name = null,
        System.String? SortBy = null,
        List<ConfigFilter>? Filters = null,
        ConfigGroupBy? GroupBy = null
    ) 
    {
        if ( DataViewType != null ) {
            this.DataViewType = DataViewType;
        }
        if ( SortOrder != null ) {
            this.SortOrder = SortOrder;
        }
        if ( Aggregations != null ) {
            this.Aggregations = Aggregations;
        }
        if ( Columns != null ) {
            this.Columns = Columns;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SortBy != null ) {
            this.SortBy = SortBy;
        }
        if ( Filters != null ) {
            this.Filters = Filters;
        }
        if ( GroupBy != null ) {
            this.GroupBy = GroupBy;
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
        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        if (this.DataViewType != null) {
            s += ind + "dataViewType\n" ;
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder != null) {
            s += ind + "sortOrder\n" ;
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations != null) {
            s += ind + "aggregations\n" ;
        }
        //      C# -> List<System.String>? Columns
        // GraphQL -> columns: [String!]! (scalar)
        if (this.Columns != null) {
            s += ind + "columns\n" ;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? SortBy
        // GraphQL -> sortBy: String! (scalar)
        if (this.SortBy != null) {
            s += ind + "sortBy\n" ;
        }
        //      C# -> List<ConfigFilter>? Filters
        // GraphQL -> filters: [ConfigFilter!]! (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filters {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ConfigGroupBy? GroupBy
        // GraphQL -> groupBy: configGroupBy! (type)
        if (this.GroupBy != null) {
            var fspec = this.GroupBy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        if (this.DataViewType == null && Exploration.Includes(parent + ".dataViewType", true))
        {
            this.DataViewType = new DataViewTypeEnum();
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder == null && Exploration.Includes(parent + ".sortOrder", true))
        {
            this.SortOrder = new SortOrder();
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations == null && Exploration.Includes(parent + ".aggregations", true))
        {
            this.Aggregations = new List<System.String>();
        }
        //      C# -> List<System.String>? Columns
        // GraphQL -> columns: [String!]! (scalar)
        if (this.Columns == null && Exploration.Includes(parent + ".columns", true))
        {
            this.Columns = new List<System.String>();
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SortBy
        // GraphQL -> sortBy: String! (scalar)
        if (this.SortBy == null && Exploration.Includes(parent + ".sortBy", true))
        {
            this.SortBy = "FETCH";
        }
        //      C# -> List<ConfigFilter>? Filters
        // GraphQL -> filters: [ConfigFilter!]! (type)
        if (this.Filters == null && Exploration.Includes(parent + ".filters"))
        {
            this.Filters = new List<ConfigFilter>();
            this.Filters.ApplyExploratoryFieldSpec(parent + ".filters");
        }
        //      C# -> ConfigGroupBy? GroupBy
        // GraphQL -> groupBy: configGroupBy! (type)
        if (this.GroupBy == null && Exploration.Includes(parent + ".groupBy"))
        {
            this.GroupBy = new ConfigGroupBy();
            this.GroupBy.ApplyExploratoryFieldSpec(parent + ".groupBy");
        }
    }


    #endregion

    } // class ReportConfig
    
    #endregion

    public static class ListReportConfigExtensions
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
            this List<ReportConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types