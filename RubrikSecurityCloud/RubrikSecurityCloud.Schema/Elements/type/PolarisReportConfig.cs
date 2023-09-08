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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        if (this.Charts != null) {
            s += ind + "charts\n" ;
        }
        //      C# -> ReportRoomType? ReportRoom
        // GraphQL -> reportRoom: ReportRoomType! (enum)
        if (this.ReportRoom != null) {
            s += ind + "reportRoom\n" ;
        }
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (this.ReportViewType != null) {
            s += ind + "reportViewType\n" ;
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder != null) {
            s += ind + "sortOrder\n" ;
        }
        //      C# -> TableViewType? Table
        // GraphQL -> table: TableViewType! (enum)
        if (this.Table != null) {
            s += ind + "table\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
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
        //      C# -> List<ReportFilter>? Filters
        // GraphQL -> filters: [ReportFilter!]! (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filters {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        if (this.Charts == null && ec.Includes("charts",true))
        {
            this.Charts = new List<ChartViewType>();
        }
        //      C# -> ReportRoomType? ReportRoom
        // GraphQL -> reportRoom: ReportRoomType! (enum)
        if (this.ReportRoom == null && ec.Includes("reportRoom",true))
        {
            this.ReportRoom = new ReportRoomType();
        }
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (this.ReportViewType == null && ec.Includes("reportViewType",true))
        {
            this.ReportViewType = new PolarisReportViewType();
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder == null && ec.Includes("sortOrder",true))
        {
            this.SortOrder = new SortOrder();
        }
        //      C# -> TableViewType? Table
        // GraphQL -> table: TableViewType! (enum)
        if (this.Table == null && ec.Includes("table",true))
        {
            this.Table = new TableViewType();
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid == null && ec.Includes("fid",true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SortBy
        // GraphQL -> sortBy: String! (scalar)
        if (this.SortBy == null && ec.Includes("sortBy",true))
        {
            this.SortBy = "FETCH";
        }
        //      C# -> List<ReportFilter>? Filters
        // GraphQL -> filters: [ReportFilter!]! (type)
        if (this.Filters == null && ec.Includes("filters",false))
        {
            this.Filters = new List<ReportFilter>();
            this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));
        }
    }


    #endregion

    } // class PolarisReportConfig
    
    #endregion

    public static class ListPolarisReportConfigExtensions
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
            this List<PolarisReportConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<PolarisReportConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types