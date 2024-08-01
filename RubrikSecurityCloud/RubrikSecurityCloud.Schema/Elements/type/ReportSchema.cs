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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "ReportSchema";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder! (enum)
        if (this.SortOrder != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sortOrder\n" ;
            } else {
                s += ind + "sortOrder\n" ;
            }
        }
        //      C# -> List<Column>? AggregateColumns
        // GraphQL -> aggregateColumns: [Column!]! (type)
        if (this.AggregateColumns != null) {
            var fspec = this.AggregateColumns.AsFieldSpec(conf.Child("aggregateColumns"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "aggregateColumns" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Column>? AllColumns
        // GraphQL -> allColumns: [Column!]! (type)
        if (this.AllColumns != null) {
            var fspec = this.AllColumns.AsFieldSpec(conf.Child("allColumns"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allColumns" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ChartConfig>? ChartConfigs
        // GraphQL -> chartConfigs: [ChartConfig!]! (type)
        if (this.ChartConfigs != null) {
            var fspec = this.ChartConfigs.AsFieldSpec(conf.Child("chartConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "chartConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReportFilterDetail>? Filters
        // GraphQL -> filters: [ReportFilterDetail!]! (type)
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
        //      C# -> List<ReportGroupByDetail>? GroupBys
        // GraphQL -> groupBys: [ReportGroupByDetail!]! (type)
        if (this.GroupBys != null) {
            var fspec = this.GroupBys.AsFieldSpec(conf.Child("groupBys"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupBys" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Column? SortBy
        // GraphQL -> sortBy: Column! (type)
        if (this.SortBy != null) {
            var fspec = this.SortBy.AsFieldSpec(conf.Child("sortBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sortBy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Column>? TableColumns
        // GraphQL -> tableColumns: [Column!]! (type)
        if (this.TableColumns != null) {
            var fspec = this.TableColumns.AsFieldSpec(conf.Child("tableColumns"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tableColumns" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder! (enum)
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
        //      C# -> List<Column>? AggregateColumns
        // GraphQL -> aggregateColumns: [Column!]! (type)
        if (ec.Includes("aggregateColumns",false))
        {
            if(this.AggregateColumns == null) {

                this.AggregateColumns = new List<Column>();
                this.AggregateColumns.ApplyExploratoryFieldSpec(ec.NewChild("aggregateColumns"));

            } else {

                this.AggregateColumns.ApplyExploratoryFieldSpec(ec.NewChild("aggregateColumns"));

            }
        }
        else if (this.AggregateColumns != null && ec.Excludes("aggregateColumns",false))
        {
            this.AggregateColumns = null;
        }
        //      C# -> List<Column>? AllColumns
        // GraphQL -> allColumns: [Column!]! (type)
        if (ec.Includes("allColumns",false))
        {
            if(this.AllColumns == null) {

                this.AllColumns = new List<Column>();
                this.AllColumns.ApplyExploratoryFieldSpec(ec.NewChild("allColumns"));

            } else {

                this.AllColumns.ApplyExploratoryFieldSpec(ec.NewChild("allColumns"));

            }
        }
        else if (this.AllColumns != null && ec.Excludes("allColumns",false))
        {
            this.AllColumns = null;
        }
        //      C# -> List<ChartConfig>? ChartConfigs
        // GraphQL -> chartConfigs: [ChartConfig!]! (type)
        if (ec.Includes("chartConfigs",false))
        {
            if(this.ChartConfigs == null) {

                this.ChartConfigs = new List<ChartConfig>();
                this.ChartConfigs.ApplyExploratoryFieldSpec(ec.NewChild("chartConfigs"));

            } else {

                this.ChartConfigs.ApplyExploratoryFieldSpec(ec.NewChild("chartConfigs"));

            }
        }
        else if (this.ChartConfigs != null && ec.Excludes("chartConfigs",false))
        {
            this.ChartConfigs = null;
        }
        //      C# -> List<ReportFilterDetail>? Filters
        // GraphQL -> filters: [ReportFilterDetail!]! (type)
        if (ec.Includes("filters",false))
        {
            if(this.Filters == null) {

                this.Filters = new List<ReportFilterDetail>();
                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            } else {

                this.Filters.ApplyExploratoryFieldSpec(ec.NewChild("filters"));

            }
        }
        else if (this.Filters != null && ec.Excludes("filters",false))
        {
            this.Filters = null;
        }
        //      C# -> List<ReportGroupByDetail>? GroupBys
        // GraphQL -> groupBys: [ReportGroupByDetail!]! (type)
        if (ec.Includes("groupBys",false))
        {
            if(this.GroupBys == null) {

                this.GroupBys = new List<ReportGroupByDetail>();
                this.GroupBys.ApplyExploratoryFieldSpec(ec.NewChild("groupBys"));

            } else {

                this.GroupBys.ApplyExploratoryFieldSpec(ec.NewChild("groupBys"));

            }
        }
        else if (this.GroupBys != null && ec.Excludes("groupBys",false))
        {
            this.GroupBys = null;
        }
        //      C# -> Column? SortBy
        // GraphQL -> sortBy: Column! (type)
        if (ec.Includes("sortBy",false))
        {
            if(this.SortBy == null) {

                this.SortBy = new Column();
                this.SortBy.ApplyExploratoryFieldSpec(ec.NewChild("sortBy"));

            } else {

                this.SortBy.ApplyExploratoryFieldSpec(ec.NewChild("sortBy"));

            }
        }
        else if (this.SortBy != null && ec.Excludes("sortBy",false))
        {
            this.SortBy = null;
        }
        //      C# -> List<Column>? TableColumns
        // GraphQL -> tableColumns: [Column!]! (type)
        if (ec.Includes("tableColumns",false))
        {
            if(this.TableColumns == null) {

                this.TableColumns = new List<Column>();
                this.TableColumns.ApplyExploratoryFieldSpec(ec.NewChild("tableColumns"));

            } else {

                this.TableColumns.ApplyExploratoryFieldSpec(ec.NewChild("tableColumns"));

            }
        }
        else if (this.TableColumns != null && ec.Excludes("tableColumns",false))
        {
            this.TableColumns = null;
        }
    }


    #endregion

    } // class ReportSchema
    
    #endregion

    public static class ListReportSchemaExtensions
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
            this List<ReportSchema> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReportSchema> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReportSchema> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportSchema());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReportSchema> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types