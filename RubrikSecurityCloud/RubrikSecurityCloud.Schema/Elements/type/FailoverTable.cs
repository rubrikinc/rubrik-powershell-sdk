// FailoverTable.cs
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
    #region FailoverTable
 
    public class FailoverTable: BaseType, ReportTableType
    {
        #region members

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> List<FailoverGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [FailoverGroupByEnum!] (enum)
        [JsonProperty("groupBy")]
        public List<FailoverGroupByEnum>? GroupBy { get; set; }

        //      C# -> List<FailoverTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [FailoverTableColumnEnum!]! (enum)
        [JsonProperty("selectedColumns")]
        public List<FailoverTableColumnEnum>? SelectedColumns { get; set; }

        //      C# -> FailoverSortByEnum? SortBy
        // GraphQL -> sortBy: FailoverSortByEnum (enum)
        [JsonProperty("sortBy")]
        public FailoverSortByEnum? SortBy { get; set; }

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
        return "FailoverTable";
    }

    public FailoverTable Set(
        ReportFocusEnum? Focus = null,
        List<FailoverGroupByEnum>? GroupBy = null,
        List<FailoverTableColumnEnum>? SelectedColumns = null,
        FailoverSortByEnum? SortBy = null,
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
        //      C# -> List<FailoverGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [FailoverGroupByEnum!] (enum)
        if (this.GroupBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupBy\n" ;
            } else {
                s += ind + "groupBy\n" ;
            }
        }
        //      C# -> List<FailoverTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [FailoverTableColumnEnum!]! (enum)
        if (this.SelectedColumns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "selectedColumns\n" ;
            } else {
                s += ind + "selectedColumns\n" ;
            }
        }
        //      C# -> FailoverSortByEnum? SortBy
        // GraphQL -> sortBy: FailoverSortByEnum (enum)
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
        //      C# -> List<FailoverGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [FailoverGroupByEnum!] (enum)
        if (ec.Includes("groupBy",true))
        {
            if(this.GroupBy == null) {

                this.GroupBy = new List<FailoverGroupByEnum>();

            } else {


            }
        }
        else if (this.GroupBy != null && ec.Excludes("groupBy",true))
        {
            this.GroupBy = null;
        }
        //      C# -> List<FailoverTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [FailoverTableColumnEnum!]! (enum)
        if (ec.Includes("selectedColumns",true))
        {
            if(this.SelectedColumns == null) {

                this.SelectedColumns = new List<FailoverTableColumnEnum>();

            } else {


            }
        }
        else if (this.SelectedColumns != null && ec.Excludes("selectedColumns",true))
        {
            this.SelectedColumns = null;
        }
        //      C# -> FailoverSortByEnum? SortBy
        // GraphQL -> sortBy: FailoverSortByEnum (enum)
        if (ec.Includes("sortBy",true))
        {
            if(this.SortBy == null) {

                this.SortBy = new FailoverSortByEnum();

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

    } // class FailoverTable
    
    #endregion

    public static class ListFailoverTableExtensions
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
            this List<FailoverTable> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<FailoverTable> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailoverTable> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailoverTable());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailoverTable> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types