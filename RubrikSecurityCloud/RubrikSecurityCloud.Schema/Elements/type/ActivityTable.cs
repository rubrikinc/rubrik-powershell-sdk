// ActivityTable.cs
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
    #region ActivityTable
 
    public class ActivityTable: BaseType, ReportTableType
    {
        #region members

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> List<ActivitySeriesGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [ActivitySeriesGroupByEnum!] (enum)
        [JsonProperty("groupBy")]
        public List<ActivitySeriesGroupByEnum>? GroupBy { get; set; }

        //      C# -> List<ActivityTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [ActivityTableColumnEnum!]! (enum)
        [JsonProperty("selectedColumns")]
        public List<ActivityTableColumnEnum>? SelectedColumns { get; set; }

        //      C# -> ActivitySeriesSortByEnum? SortBy
        // GraphQL -> sortBy: ActivitySeriesSortByEnum (enum)
        [JsonProperty("sortBy")]
        public ActivitySeriesSortByEnum? SortBy { get; set; }

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

    public ActivityTable Set(
        ReportFocusEnum? Focus = null,
        List<ActivitySeriesGroupByEnum>? GroupBy = null,
        List<ActivityTableColumnEnum>? SelectedColumns = null,
        ActivitySeriesSortByEnum? SortBy = null,
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus != null) {
            s += ind + "focus\n" ;
        }
        //      C# -> List<ActivitySeriesGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [ActivitySeriesGroupByEnum!] (enum)
        if (this.GroupBy != null) {
            s += ind + "groupBy\n" ;
        }
        //      C# -> List<ActivityTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [ActivityTableColumnEnum!]! (enum)
        if (this.SelectedColumns != null) {
            s += ind + "selectedColumns\n" ;
        }
        //      C# -> ActivitySeriesSortByEnum? SortBy
        // GraphQL -> sortBy: ActivitySeriesSortByEnum (enum)
        if (this.SortBy != null) {
            s += ind + "sortBy\n" ;
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder != null) {
            s += ind + "sortOrder\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        if (this.Focus == null && Exploration.Includes(parent + ".focus", true))
        {
            this.Focus = new ReportFocusEnum();
        }
        //      C# -> List<ActivitySeriesGroupByEnum>? GroupBy
        // GraphQL -> groupBy: [ActivitySeriesGroupByEnum!] (enum)
        if (this.GroupBy == null && Exploration.Includes(parent + ".groupBy", true))
        {
            this.GroupBy = new List<ActivitySeriesGroupByEnum>();
        }
        //      C# -> List<ActivityTableColumnEnum>? SelectedColumns
        // GraphQL -> selectedColumns: [ActivityTableColumnEnum!]! (enum)
        if (this.SelectedColumns == null && Exploration.Includes(parent + ".selectedColumns", true))
        {
            this.SelectedColumns = new List<ActivityTableColumnEnum>();
        }
        //      C# -> ActivitySeriesSortByEnum? SortBy
        // GraphQL -> sortBy: ActivitySeriesSortByEnum (enum)
        if (this.SortBy == null && Exploration.Includes(parent + ".sortBy", true))
        {
            this.SortBy = new ActivitySeriesSortByEnum();
        }
        //      C# -> SortOrder? SortOrder
        // GraphQL -> sortOrder: SortOrder (enum)
        if (this.SortOrder == null && Exploration.Includes(parent + ".sortOrder", true))
        {
            this.SortOrder = new SortOrder();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
    }


    #endregion

    } // class ActivityTable
    
    #endregion

    public static class ListActivityTableExtensions
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
            this List<ActivityTable> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActivityTable> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityTable());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types