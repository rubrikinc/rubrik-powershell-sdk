// ReportSchema.cs
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
    #region ReportSchema
    public class ReportSchema: BaseType
    {
        #region members

        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder! (enum)
        [JsonProperty("sortOrder")]
        public SortOrder? SortOrder { get; set; }

        //      C# -> List<Column>? AggregateColumns
        // GraphQL -> aggregateColumns: [Column!]! (type)
        [JsonProperty("aggregateColumns")]
        public List<Column>? AggregateColumns { get; set; }

        //      C# -> List<Column>? AllColumns
        // GraphQL -> allColumns: [Column!]! (type)
        [JsonProperty("allColumns")]
        public List<Column>? AllColumns { get; set; }

        //      C# -> List<ChartConfig>? ChartConfigs
        // GraphQL -> chartConfigs: [ChartConfig!]! (type)
        [JsonProperty("chartConfigs")]
        public List<ChartConfig>? ChartConfigs { get; set; }

        //      C# -> List<ReportFilterDetail>? Filters
        // GraphQL -> filters: [ReportFilterDetail!]! (type)
        [JsonProperty("filters")]
        public List<ReportFilterDetail>? Filters { get; set; }

        //      C# -> List<ReportGroupByDetail>? GroupBys
        // GraphQL -> groupBys: [ReportGroupByDetail!]! (type)
        [JsonProperty("groupBys")]
        public List<ReportGroupByDetail>? GroupBys { get; set; }

        //      C# -> Column? SortBy
        // GraphQL -> sortBy: Column! (type)
        [JsonProperty("sortBy")]
        public Column? SortBy { get; set; }

        //      C# -> List<Column>? TableColumns
        // GraphQL -> tableColumns: [Column!]! (type)
        [JsonProperty("tableColumns")]
        public List<Column>? TableColumns { get; set; }


        #endregion

    #region methods

    public ReportSchema Set(
        SortOrder? SortOrder = null,
        List<Column>? AggregateColumns = null,
        List<Column>? AllColumns = null,
        List<ChartConfig>? ChartConfigs = null,
        List<ReportFilterDetail>? Filters = null,
        List<ReportGroupByDetail>? GroupBys = null,
        Column? SortBy = null,
        List<Column>? TableColumns = null
    ) 
    {
        if ( SortOrder != null ) {
            this.SortOrder = SortOrder;
        }
        if ( AggregateColumns != null ) {
            this.AggregateColumns = AggregateColumns;
        }
        if ( AllColumns != null ) {
            this.AllColumns = AllColumns;
        }
        if ( ChartConfigs != null ) {
            this.ChartConfigs = ChartConfigs;
        }
        if ( Filters != null ) {
            this.Filters = Filters;
        }
        if ( GroupBys != null ) {
            this.GroupBys = GroupBys;
        }
        if ( SortBy != null ) {
            this.SortBy = SortBy;
        }
        if ( TableColumns != null ) {
            this.TableColumns = TableColumns;
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
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder! (enum)
        if (this.SortOrder != null) {
            s += ind + "sortOrder\n" ;
        }
        //      C# -> List<Column>? AggregateColumns
        // GraphQL -> aggregateColumns: [Column!]! (type)
        if (this.AggregateColumns != null) {
            var fspec = this.AggregateColumns.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "aggregateColumns {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Column>? AllColumns
        // GraphQL -> allColumns: [Column!]! (type)
        if (this.AllColumns != null) {
            var fspec = this.AllColumns.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allColumns {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ChartConfig>? ChartConfigs
        // GraphQL -> chartConfigs: [ChartConfig!]! (type)
        if (this.ChartConfigs != null) {
            var fspec = this.ChartConfigs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "chartConfigs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ReportFilterDetail>? Filters
        // GraphQL -> filters: [ReportFilterDetail!]! (type)
        if (this.Filters != null) {
            var fspec = this.Filters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filters {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ReportGroupByDetail>? GroupBys
        // GraphQL -> groupBys: [ReportGroupByDetail!]! (type)
        if (this.GroupBys != null) {
            var fspec = this.GroupBys.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupBys {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Column? SortBy
        // GraphQL -> sortBy: Column! (type)
        if (this.SortBy != null) {
            var fspec = this.SortBy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sortBy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Column>? TableColumns
        // GraphQL -> tableColumns: [Column!]! (type)
        if (this.TableColumns != null) {
            var fspec = this.TableColumns.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tableColumns {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder! (enum)
        if (this.SortOrder == null && Exploration.Includes(parent + ".sortOrder", true))
        {
            this.SortOrder = new SortOrder();
        }
        //      C# -> List<Column>? AggregateColumns
        // GraphQL -> aggregateColumns: [Column!]! (type)
        if (this.AggregateColumns == null && Exploration.Includes(parent + ".aggregateColumns"))
        {
            this.AggregateColumns = new List<Column>();
            this.AggregateColumns.ApplyExploratoryFieldSpec(parent + ".aggregateColumns");
        }
        //      C# -> List<Column>? AllColumns
        // GraphQL -> allColumns: [Column!]! (type)
        if (this.AllColumns == null && Exploration.Includes(parent + ".allColumns"))
        {
            this.AllColumns = new List<Column>();
            this.AllColumns.ApplyExploratoryFieldSpec(parent + ".allColumns");
        }
        //      C# -> List<ChartConfig>? ChartConfigs
        // GraphQL -> chartConfigs: [ChartConfig!]! (type)
        if (this.ChartConfigs == null && Exploration.Includes(parent + ".chartConfigs"))
        {
            this.ChartConfigs = new List<ChartConfig>();
            this.ChartConfigs.ApplyExploratoryFieldSpec(parent + ".chartConfigs");
        }
        //      C# -> List<ReportFilterDetail>? Filters
        // GraphQL -> filters: [ReportFilterDetail!]! (type)
        if (this.Filters == null && Exploration.Includes(parent + ".filters"))
        {
            this.Filters = new List<ReportFilterDetail>();
            this.Filters.ApplyExploratoryFieldSpec(parent + ".filters");
        }
        //      C# -> List<ReportGroupByDetail>? GroupBys
        // GraphQL -> groupBys: [ReportGroupByDetail!]! (type)
        if (this.GroupBys == null && Exploration.Includes(parent + ".groupBys"))
        {
            this.GroupBys = new List<ReportGroupByDetail>();
            this.GroupBys.ApplyExploratoryFieldSpec(parent + ".groupBys");
        }
        //      C# -> Column? SortBy
        // GraphQL -> sortBy: Column! (type)
        if (this.SortBy == null && Exploration.Includes(parent + ".sortBy"))
        {
            this.SortBy = new Column();
            this.SortBy.ApplyExploratoryFieldSpec(parent + ".sortBy");
        }
        //      C# -> List<Column>? TableColumns
        // GraphQL -> tableColumns: [Column!]! (type)
        if (this.TableColumns == null && Exploration.Includes(parent + ".tableColumns"))
        {
            this.TableColumns = new List<Column>();
            this.TableColumns.ApplyExploratoryFieldSpec(parent + ".tableColumns");
        }
    }


    #endregion

    } // class ReportSchema
    
    #endregion

    public static class ListReportSchemaExtensions
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
            this List<ReportSchema> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportSchema> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportSchema());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types