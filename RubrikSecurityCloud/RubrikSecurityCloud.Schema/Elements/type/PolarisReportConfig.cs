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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PolarisReportConfig
    public class PolarisReportConfig: BaseType
    {
        #region members

        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        [JsonProperty("charts")]
        public List<ChartViewType>? Charts { get; set; }

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

    public PolarisReportConfig Set(
        List<ChartViewType>? Charts = null,
        PolarisReportViewType? ReportViewType = null,
        SortOrder? SortOrder = null,
        TableViewType? Table = null,
        System.Int64? Id = null,
        System.String? Name = null,
        System.String? SortBy = null,
        List<ReportFilter>? Filters = null
    ) 
    {
        if ( Charts != null ) {
            this.Charts = Charts;
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


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<ChartViewType>? Charts
        // GraphQL -> charts: [ChartViewType!]! (enum)
        if (this.Charts == null && Exploration.Includes(parent + ".charts", true))
        {
            this.Charts = new List<ChartViewType>();
        }
        //      C# -> PolarisReportViewType? ReportViewType
        // GraphQL -> reportViewType: PolarisReportViewType! (enum)
        if (this.ReportViewType == null && Exploration.Includes(parent + ".reportViewType", true))
        {
            this.ReportViewType = new PolarisReportViewType();
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder == null && Exploration.Includes(parent + ".sortOrder", true))
        {
            this.SortOrder = new SortOrder();
        }
        //      C# -> TableViewType? Table
        // GraphQL -> table: TableViewType! (enum)
        if (this.Table == null && Exploration.Includes(parent + ".table", true))
        {
            this.Table = new TableViewType();
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
        //      C# -> List<ReportFilter>? Filters
        // GraphQL -> filters: [ReportFilter!]! (type)
        if (this.Filters == null && Exploration.Includes(parent + ".filters"))
        {
            this.Filters = new List<ReportFilter>();
            this.Filters.ApplyExploratoryFieldSpec(parent + ".filters");
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
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types