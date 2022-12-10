// ActivityTable.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:38.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region ActivityTable
 
    public class ActivityTable: IFragment, ReportTableType
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

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

        #endregion

    #region methods

    public ActivityTable Set(
        System.String? Name = null,
        ReportFocusEnum? Focus = null,
        List<ActivitySeriesGroupByEnum>? GroupBy = null,
        List<ActivityTableColumnEnum>? SelectedColumns = null,
        ActivitySeriesSortByEnum? SortBy = null,
        SortOrder? SortOrder = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> ReportFocusEnum? Focus
            // GraphQL -> focus: ReportFocusEnum! (enum)
            if (this.Focus != null)
            {
                 s += ind + "focus\n";

            }
            //      C# -> List<ActivitySeriesGroupByEnum>? GroupBy
            // GraphQL -> groupBy: [ActivitySeriesGroupByEnum!] (enum)
            if (this.GroupBy != null)
            {
                 s += ind + "groupBy\n";

            }
            //      C# -> List<ActivityTableColumnEnum>? SelectedColumns
            // GraphQL -> selectedColumns: [ActivityTableColumnEnum!]! (enum)
            if (this.SelectedColumns != null)
            {
                 s += ind + "selectedColumns\n";

            }
            //      C# -> ActivitySeriesSortByEnum? SortBy
            // GraphQL -> sortBy: ActivitySeriesSortByEnum (enum)
            if (this.SortBy != null)
            {
                 s += ind + "sortBy\n";

            }
            //      C# -> SortOrder? SortOrder
            // GraphQL -> sortOrder: SortOrder (enum)
            if (this.SortOrder != null)
            {
                 s += ind + "sortOrder\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> ReportFocusEnum? Focus
            // GraphQL -> focus: ReportFocusEnum! (enum)
            if (this.Focus == null && Exploration.Includes(parent + ".focus$"))
            {
                this.Focus = new ReportFocusEnum();
            }
            //      C# -> List<ActivitySeriesGroupByEnum>? GroupBy
            // GraphQL -> groupBy: [ActivitySeriesGroupByEnum!] (enum)
            if (this.GroupBy == null && Exploration.Includes(parent + ".groupBy$"))
            {
                this.GroupBy = new List<ActivitySeriesGroupByEnum>();
            }
            //      C# -> List<ActivityTableColumnEnum>? SelectedColumns
            // GraphQL -> selectedColumns: [ActivityTableColumnEnum!]! (enum)
            if (this.SelectedColumns == null && Exploration.Includes(parent + ".selectedColumns$"))
            {
                this.SelectedColumns = new List<ActivityTableColumnEnum>();
            }
            //      C# -> ActivitySeriesSortByEnum? SortBy
            // GraphQL -> sortBy: ActivitySeriesSortByEnum (enum)
            if (this.SortBy == null && Exploration.Includes(parent + ".sortBy$"))
            {
                this.SortBy = new ActivitySeriesSortByEnum();
            }
            //      C# -> SortOrder? SortOrder
            // GraphQL -> sortOrder: SortOrder (enum)
            if (this.SortOrder == null && Exploration.Includes(parent + ".sortOrder$"))
            {
                this.SortOrder = new SortOrder();
            }
        }


    #endregion

    } // class ActivityTable
    #endregion

    public static class ListActivityTableExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ActivityTable> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ActivityTable> list, 
            String parent = "")
        {
            var item = new ActivityTable();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types