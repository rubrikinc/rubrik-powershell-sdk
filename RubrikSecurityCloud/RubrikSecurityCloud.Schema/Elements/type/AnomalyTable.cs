// AnomalyTable.cs
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
    #region AnomalyTable
 
    public class AnomalyTable: BaseType, ReportTableType
    {
        #region members

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> List<AnomalyResultGroupBy>? GroupBy
        // GraphQL -> groupBy: [AnomalyResultGroupBy!] (enum)
        [JsonProperty("groupBy")]
        public List<AnomalyResultGroupBy>? GroupBy { get; set; }

        //      C# -> List<AnomalyTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [AnomalyTableColumnEnum!]! (enum)
        [JsonProperty("selectedColumns")]
        public List<AnomalyTableColumnEnum>? SelectedColumns { get; set; }

        //      C# -> AnomalyResultSortBy? SortBy
        // GraphQL -> sortBy: AnomalyResultSortBy (enum)
        [JsonProperty("sortBy")]
        public AnomalyResultSortBy? SortBy { get; set; }

        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        [JsonProperty("sortOrder")]
        public SortOrder? SortOrder { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnomalyTable";
    }

    public AnomalyTable Set(
        ReportFocusEnum? Focus = null,
        List<AnomalyResultGroupBy>? GroupBy = null,
        List<AnomalyTableColumnEnum>? SelectedColumns = null,
        AnomalyResultSortBy? SortBy = null,
        SortOrder? SortOrder = null,
        System.String? Name = null
    ) 
    {
        if ( Focus != null ) {
            this.Focus = Focus;
        }
        if ( GroupBy != null ) {
            this.GroupBy = GroupBy;
        }
        if ( SelectedColumns != null ) {
            this.SelectedColumns = SelectedColumns;
        }
        if ( SortBy != null ) {
            this.SortBy = SortBy;
        }
        if ( SortOrder != null ) {
            this.SortOrder = SortOrder;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "focus\n" ;
            } else {
                s += ind + "focus\n" ;
            }
        }
        //      C# -> List<AnomalyResultGroupBy>? GroupBy
        // GraphQL -> groupBy: [AnomalyResultGroupBy!] (enum)
        if (this.GroupBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupBy\n" ;
            } else {
                s += ind + "groupBy\n" ;
            }
        }
        //      C# -> List<AnomalyTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [AnomalyTableColumnEnum!]! (enum)
        if (this.SelectedColumns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "selectedColumns\n" ;
            } else {
                s += ind + "selectedColumns\n" ;
            }
        }
        //      C# -> AnomalyResultSortBy? SortBy
        // GraphQL -> sortBy: AnomalyResultSortBy (enum)
        if (this.SortBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sortBy\n" ;
            } else {
                s += ind + "sortBy\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (ec.Includes("focus",true))
        {
            if(this.Focus == null) {

                this.Focus = new ReportFocusEnum();

            } else {


            }
        }
        else if (this.Focus != null && ec.Excludes("focus",true))
        {
            this.Focus = null;
        }
        //      C# -> List<AnomalyResultGroupBy>? GroupBy
        // GraphQL -> groupBy: [AnomalyResultGroupBy!] (enum)
        if (ec.Includes("groupBy",true))
        {
            if(this.GroupBy == null) {

                this.GroupBy = new List<AnomalyResultGroupBy>();

            } else {


            }
        }
        else if (this.GroupBy != null && ec.Excludes("groupBy",true))
        {
            this.GroupBy = null;
        }
        //      C# -> List<AnomalyTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [AnomalyTableColumnEnum!]! (enum)
        if (ec.Includes("selectedColumns",true))
        {
            if(this.SelectedColumns == null) {

                this.SelectedColumns = new List<AnomalyTableColumnEnum>();

            } else {


            }
        }
        else if (this.SelectedColumns != null && ec.Excludes("selectedColumns",true))
        {
            this.SelectedColumns = null;
        }
        //      C# -> AnomalyResultSortBy? SortBy
        // GraphQL -> sortBy: AnomalyResultSortBy (enum)
        if (ec.Includes("sortBy",true))
        {
            if(this.SortBy == null) {

                this.SortBy = new AnomalyResultSortBy();

            } else {


            }
        }
        else if (this.SortBy != null && ec.Excludes("sortBy",true))
        {
            this.SortBy = null;
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
    }


    #endregion

    } // class AnomalyTable
    
    #endregion

    public static class ListAnomalyTableExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AnomalyTable> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnomalyTable> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyTable> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyTable());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnomalyTable> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types