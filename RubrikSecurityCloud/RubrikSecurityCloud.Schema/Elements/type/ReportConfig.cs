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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

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

    public override string GetGqlTypeName() {
        return "ReportConfig";
    }

    public ReportConfig Set(
        DataViewTypeEnum? DataViewType = null,
        SortOrder? SortOrder = null,
        List<System.String>? Aggregations = null,
        List<System.String>? Columns = null,
        System.String? Fid = null,
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
        if ( Fid != null ) {
            this.Fid = Fid;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        if (this.DataViewType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataViewType\n" ;
            } else {
                s += ind + "dataViewType\n" ;
            }
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sortOrder\n" ;
            } else {
                s += ind + "sortOrder\n" ;
            }
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregations\n" ;
            } else {
                s += ind + "aggregations\n" ;
            }
        }
        //      C# -> List<System.String>? Columns
        // GraphQL -> columns: [String!]! (scalar)
        if (this.Columns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "columns\n" ;
            } else {
                s += ind + "columns\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.String? SortBy
        // GraphQL -> sortBy: String! (scalar)
        if (this.SortBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sortBy\n" ;
            } else {
                s += ind + "sortBy\n" ;
            }
        }
        //      C# -> List<ConfigFilter>? Filters
        // GraphQL -> filters: [ConfigFilter!]! (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(conf.Child("filters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigGroupBy? GroupBy
        // GraphQL -> groupBy: configGroupBy! (type)
        if (this.GroupBy != null) {
            var fspec = this.GroupBy.AsFieldSpec(conf.Child("groupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupBy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DataViewTypeEnum? DataViewType
        // GraphQL -> dataViewType: DataViewTypeEnum! (enum)
        if (ec.Includes("dataViewType",true))
        {
            if(this.DataViewType == null) {

                this.DataViewType = new DataViewTypeEnum();

            } else {


            }
        }
        else if (this.DataViewType != null && ec.Excludes("dataViewType",true))
        {
            this.DataViewType = null;
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (ec.Includes("sortOrder",true))
        {
            if(this.SortOrder == null) {

                this.SortOrder = new SortOrder();

            } else {


            }
        }
        else if (this.SortOrder != null && ec.Excludes("sortOrder",true))
        {
            this.SortOrder = null;
        }
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (ec.Includes("aggregations",true))
        {
            if(this.Aggregations == null) {

                this.Aggregations = new List<System.String>();

            } else {


            }
        }
        else if (this.Aggregations != null && ec.Excludes("aggregations",true))
        {
            this.Aggregations = null;
        }
        //      C# -> List<System.String>? Columns
        // GraphQL -> columns: [String!]! (scalar)
        if (ec.Includes("columns",true))
        {
            if(this.Columns == null) {

                this.Columns = new List<System.String>();

            } else {


            }
        }
        else if (this.Columns != null && ec.Excludes("columns",true))
        {
            this.Columns = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> System.String? SortBy
        // GraphQL -> sortBy: String! (scalar)
        if (ec.Includes("sortBy",true))
        {
            if(this.SortBy == null) {

                this.SortBy = "FETCH";

            } else {


            }
        }
        else if (this.SortBy != null && ec.Excludes("sortBy",true))
        {
            this.SortBy = null;
        }
        //      C# -> List<ConfigFilter>? Filters
        // GraphQL -> filters: [ConfigFilter!]! (type)
        if (ec.Includes("filters",false))
        {
            if(this.Filters == null) {

                this.Filters = new List<ConfigFilter>();
                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            } else {

                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            }
        }
        else if (this.Filters != null && ec.Excludes("filters",false))
        {
            this.Filters = null;
        }
        //      C# -> ConfigGroupBy? GroupBy
        // GraphQL -> groupBy: configGroupBy! (type)
        if (ec.Includes("groupBy",false))
        {
            if(this.GroupBy == null) {

                this.GroupBy = new ConfigGroupBy();
                this.GroupBy.ApplyExploratoryFieldSpec(ec.NewChild("groupBy"));

            } else {

                this.GroupBy.ApplyExploratoryFieldSpec(ec.NewChild("groupBy"));

            }
        }
        else if (this.GroupBy != null && ec.Excludes("groupBy",false))
        {
            this.GroupBy = null;
        }
    }


    #endregion

    } // class ReportConfig
    
    #endregion

    public static class ListReportConfigExtensions
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
            this List<ReportConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReportConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReportConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReportConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types