// PolarisReportConfig.cs
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
    #region PolarisReportConfig
    public class PolarisReportConfig: BaseType
    {
        #region members

        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        [JsonProperty("charts")]
        public List<ChartViewType>? Charts { get; set; }

        //      C# -> ReportRoomType? ReportRoom
        // GraphQL -> reportRoom: ReportRoomType! (enum)
        [JsonProperty("reportRoom")]
        public ReportRoomType? ReportRoom { get; set; }

        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        [JsonProperty("reportViewType")]
        public PolarisReportViewType? ReportViewType { get; set; }

        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        [JsonProperty("sortOrder")]
        public SortOrder? SortOrder { get; set; }

        //      C# -> TableViewType? Table
        // GraphQL -> table: TableViewType! (enum)
        [JsonProperty("table")]
        public TableViewType? Table { get; set; }

        //      C# -> List<System.String>? DisplayableColumns
        // GraphQL -> displayableColumns: [String!]! (scalar)
        [JsonProperty("displayableColumns")]
        public List<System.String>? DisplayableColumns { get; set; }

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

        //      C# -> List<ReportFilter>? Filters
        // GraphQL -> filters: [ReportFilter!]! (type)
        [JsonProperty("filters")]
        public List<ReportFilter>? Filters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportConfig";
    }

    public PolarisReportConfig Set(
        List<ChartViewType>? Charts = null,
        ReportRoomType? ReportRoom = null,
        PolarisReportViewType? ReportViewType = null,
        SortOrder? SortOrder = null,
        TableViewType? Table = null,
        List<System.String>? DisplayableColumns = null,
        System.String? Fid = null,
        System.Int64? Id = null,
        System.String? Name = null,
        System.String? SortBy = null,
        List<ReportFilter>? Filters = null
    ) 
    {
        if ( Charts != null ) {
            this.Charts = Charts;
        }
        if ( ReportRoom != null ) {
            this.ReportRoom = ReportRoom;
        }
        if ( ReportViewType != null ) {
            this.ReportViewType = ReportViewType;
        }
        if ( SortOrder != null ) {
            this.SortOrder = SortOrder;
        }
        if ( Table != null ) {
            this.Table = Table;
        }
        if ( DisplayableColumns != null ) {
            this.DisplayableColumns = DisplayableColumns;
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
        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        if (this.Charts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "charts\n" ;
            } else {
                s += ind + "charts\n" ;
            }
        }
        //      C# -> ReportRoomType? ReportRoom
        // GraphQL -> reportRoom: ReportRoomType! (enum)
        if (this.ReportRoom != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportRoom\n" ;
            } else {
                s += ind + "reportRoom\n" ;
            }
        }
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (this.ReportViewType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportViewType\n" ;
            } else {
                s += ind + "reportViewType\n" ;
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
        //      C# -> TableViewType? Table
        // GraphQL -> table: TableViewType! (enum)
        if (this.Table != null) {
            if (conf.Flat) {
                s += conf.Prefix + "table\n" ;
            } else {
                s += ind + "table\n" ;
            }
        }
        //      C# -> List<System.String>? DisplayableColumns
        // GraphQL -> displayableColumns: [String!]! (scalar)
        if (this.DisplayableColumns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayableColumns\n" ;
            } else {
                s += ind + "displayableColumns\n" ;
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
        //      C# -> List<ReportFilter>? Filters
        // GraphQL -> filters: [ReportFilter!]! (type)
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        if (ec.Includes("charts",true))
        {
            if(this.Charts == null) {

                this.Charts = new List<ChartViewType>();

            } else {


            }
        }
        else if (this.Charts != null && ec.Excludes("charts",true))
        {
            this.Charts = null;
        }
        //      C# -> ReportRoomType? ReportRoom
        // GraphQL -> reportRoom: ReportRoomType! (enum)
        if (ec.Includes("reportRoom",true))
        {
            if(this.ReportRoom == null) {

                this.ReportRoom = new ReportRoomType();

            } else {


            }
        }
        else if (this.ReportRoom != null && ec.Excludes("reportRoom",true))
        {
            this.ReportRoom = null;
        }
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (ec.Includes("reportViewType",true))
        {
            if(this.ReportViewType == null) {

                this.ReportViewType = new PolarisReportViewType();

            } else {


            }
        }
        else if (this.ReportViewType != null && ec.Excludes("reportViewType",true))
        {
            this.ReportViewType = null;
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
        //      C# -> TableViewType? Table
        // GraphQL -> table: TableViewType! (enum)
        if (ec.Includes("table",true))
        {
            if(this.Table == null) {

                this.Table = new TableViewType();

            } else {


            }
        }
        else if (this.Table != null && ec.Excludes("table",true))
        {
            this.Table = null;
        }
        //      C# -> List<System.String>? DisplayableColumns
        // GraphQL -> displayableColumns: [String!]! (scalar)
        if (ec.Includes("displayableColumns",true))
        {
            if(this.DisplayableColumns == null) {

                this.DisplayableColumns = new List<System.String>();

            } else {


            }
        }
        else if (this.DisplayableColumns != null && ec.Excludes("displayableColumns",true))
        {
            this.DisplayableColumns = null;
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
        //      C# -> List<ReportFilter>? Filters
        // GraphQL -> filters: [ReportFilter!]! (type)
        if (ec.Includes("filters",false))
        {
            if(this.Filters == null) {

                this.Filters = new List<ReportFilter>();
                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            } else {

                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            }
        }
        else if (this.Filters != null && ec.Excludes("filters",false))
        {
            this.Filters = null;
        }
    }


    #endregion

    } // class PolarisReportConfig
    
    #endregion

    public static class ListPolarisReportConfigExtensions
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
            this List<PolarisReportConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisReportConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisReportConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types