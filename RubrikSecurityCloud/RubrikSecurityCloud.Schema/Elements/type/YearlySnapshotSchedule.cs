// YearlySnapshotSchedule.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region YearlySnapshotSchedule
    public class YearlySnapshotSchedule: IFragment
    {
        #region members
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        [JsonProperty("basicSchedule")]
        public BasicSnapshotSchedule? BasicSchedule { get; set; }

        //      C# -> DayOfYear? DayOfYear
        // GraphQL -> dayOfYear: DayOfYear! (enum)
        [JsonProperty("dayOfYear")]
        public DayOfYear? DayOfYear { get; set; }

        //      C# -> Month? YearStartMonth
        // GraphQL -> yearStartMonth: Month! (enum)
        [JsonProperty("yearStartMonth")]
        public Month? YearStartMonth { get; set; }

        #endregion

    #region methods

    public YearlySnapshotSchedule Set(
        BasicSnapshotSchedule? BasicSchedule = null,
        DayOfYear? DayOfYear = null,
        Month? YearStartMonth = null
    ) 
    {
        if ( BasicSchedule != null ) {
            this.BasicSchedule = BasicSchedule;
        }
        if ( DayOfYear != null ) {
            this.DayOfYear = DayOfYear;
        }
        if ( YearStartMonth != null ) {
            this.YearStartMonth = YearStartMonth;
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
            //      C# -> BasicSnapshotSchedule? BasicSchedule
            // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
            if (this.BasicSchedule != null)
            {
                 s += ind + "basicSchedule\n";

                 s += ind + "{\n" + 
                 this.BasicSchedule.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> DayOfYear? DayOfYear
            // GraphQL -> dayOfYear: DayOfYear! (enum)
            if (this.DayOfYear != null)
            {
                 s += ind + "dayOfYear\n";

            }
            //      C# -> Month? YearStartMonth
            // GraphQL -> yearStartMonth: Month! (enum)
            if (this.YearStartMonth != null)
            {
                 s += ind + "yearStartMonth\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> BasicSnapshotSchedule? BasicSchedule
            // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
            if (this.BasicSchedule == null && Exploration.Includes(parent + ".basicSchedule"))
            {
                this.BasicSchedule = new BasicSnapshotSchedule();
                this.BasicSchedule.ApplyExploratoryFragment(parent + ".basicSchedule");
            }
            //      C# -> DayOfYear? DayOfYear
            // GraphQL -> dayOfYear: DayOfYear! (enum)
            if (this.DayOfYear == null && Exploration.Includes(parent + ".dayOfYear$"))
            {
                this.DayOfYear = new DayOfYear();
            }
            //      C# -> Month? YearStartMonth
            // GraphQL -> yearStartMonth: Month! (enum)
            if (this.YearStartMonth == null && Exploration.Includes(parent + ".yearStartMonth$"))
            {
                this.YearStartMonth = new Month();
            }
        }


    #endregion

    } // class YearlySnapshotSchedule
    #endregion

    public static class ListYearlySnapshotScheduleExtensions
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
            this List<YearlySnapshotSchedule> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<YearlySnapshotSchedule> list, 
            String parent = "")
        {
            var item = new YearlySnapshotSchedule();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types