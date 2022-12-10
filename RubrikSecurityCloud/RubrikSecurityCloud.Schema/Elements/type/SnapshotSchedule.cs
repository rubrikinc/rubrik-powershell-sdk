// SnapshotSchedule.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    #region SnapshotSchedule
    public class SnapshotSchedule: IFragment
    {
        #region members
        //      C# -> DailySnapshotSchedule? Daily
        // GraphQL -> daily: DailySnapshotSchedule (type)
        [JsonProperty("daily")]
        public DailySnapshotSchedule? Daily { get; set; }

        //      C# -> HourlySnapshotSchedule? Hourly
        // GraphQL -> hourly: HourlySnapshotSchedule (type)
        [JsonProperty("hourly")]
        public HourlySnapshotSchedule? Hourly { get; set; }

        //      C# -> MinuteSnapshotSchedule? Minute
        // GraphQL -> minute: MinuteSnapshotSchedule (type)
        [JsonProperty("minute")]
        public MinuteSnapshotSchedule? Minute { get; set; }

        //      C# -> MonthlySnapshotSchedule? Monthly
        // GraphQL -> monthly: MonthlySnapshotSchedule (type)
        [JsonProperty("monthly")]
        public MonthlySnapshotSchedule? Monthly { get; set; }

        //      C# -> QuarterlySnapshotSchedule? Quarterly
        // GraphQL -> quarterly: QuarterlySnapshotSchedule (type)
        [JsonProperty("quarterly")]
        public QuarterlySnapshotSchedule? Quarterly { get; set; }

        //      C# -> WeeklySnapshotSchedule? Weekly
        // GraphQL -> weekly: WeeklySnapshotSchedule (type)
        [JsonProperty("weekly")]
        public WeeklySnapshotSchedule? Weekly { get; set; }

        //      C# -> YearlySnapshotSchedule? Yearly
        // GraphQL -> yearly: YearlySnapshotSchedule (type)
        [JsonProperty("yearly")]
        public YearlySnapshotSchedule? Yearly { get; set; }

        #endregion

    #region methods

    public SnapshotSchedule Set(
        DailySnapshotSchedule? Daily = null,
        HourlySnapshotSchedule? Hourly = null,
        MinuteSnapshotSchedule? Minute = null,
        MonthlySnapshotSchedule? Monthly = null,
        QuarterlySnapshotSchedule? Quarterly = null,
        WeeklySnapshotSchedule? Weekly = null,
        YearlySnapshotSchedule? Yearly = null
    ) 
    {
        if ( Daily != null ) {
            this.Daily = Daily;
        }
        if ( Hourly != null ) {
            this.Hourly = Hourly;
        }
        if ( Minute != null ) {
            this.Minute = Minute;
        }
        if ( Monthly != null ) {
            this.Monthly = Monthly;
        }
        if ( Quarterly != null ) {
            this.Quarterly = Quarterly;
        }
        if ( Weekly != null ) {
            this.Weekly = Weekly;
        }
        if ( Yearly != null ) {
            this.Yearly = Yearly;
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
            //      C# -> DailySnapshotSchedule? Daily
            // GraphQL -> daily: DailySnapshotSchedule (type)
            if (this.Daily != null)
            {
                 s += ind + "daily\n";

                 s += ind + "{\n" + 
                 this.Daily.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HourlySnapshotSchedule? Hourly
            // GraphQL -> hourly: HourlySnapshotSchedule (type)
            if (this.Hourly != null)
            {
                 s += ind + "hourly\n";

                 s += ind + "{\n" + 
                 this.Hourly.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MinuteSnapshotSchedule? Minute
            // GraphQL -> minute: MinuteSnapshotSchedule (type)
            if (this.Minute != null)
            {
                 s += ind + "minute\n";

                 s += ind + "{\n" + 
                 this.Minute.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MonthlySnapshotSchedule? Monthly
            // GraphQL -> monthly: MonthlySnapshotSchedule (type)
            if (this.Monthly != null)
            {
                 s += ind + "monthly\n";

                 s += ind + "{\n" + 
                 this.Monthly.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> QuarterlySnapshotSchedule? Quarterly
            // GraphQL -> quarterly: QuarterlySnapshotSchedule (type)
            if (this.Quarterly != null)
            {
                 s += ind + "quarterly\n";

                 s += ind + "{\n" + 
                 this.Quarterly.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> WeeklySnapshotSchedule? Weekly
            // GraphQL -> weekly: WeeklySnapshotSchedule (type)
            if (this.Weekly != null)
            {
                 s += ind + "weekly\n";

                 s += ind + "{\n" + 
                 this.Weekly.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> YearlySnapshotSchedule? Yearly
            // GraphQL -> yearly: YearlySnapshotSchedule (type)
            if (this.Yearly != null)
            {
                 s += ind + "yearly\n";

                 s += ind + "{\n" + 
                 this.Yearly.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DailySnapshotSchedule? Daily
            // GraphQL -> daily: DailySnapshotSchedule (type)
            if (this.Daily == null && Exploration.Includes(parent + ".daily"))
            {
                this.Daily = new DailySnapshotSchedule();
                this.Daily.ApplyExploratoryFragment(parent + ".daily");
            }
            //      C# -> HourlySnapshotSchedule? Hourly
            // GraphQL -> hourly: HourlySnapshotSchedule (type)
            if (this.Hourly == null && Exploration.Includes(parent + ".hourly"))
            {
                this.Hourly = new HourlySnapshotSchedule();
                this.Hourly.ApplyExploratoryFragment(parent + ".hourly");
            }
            //      C# -> MinuteSnapshotSchedule? Minute
            // GraphQL -> minute: MinuteSnapshotSchedule (type)
            if (this.Minute == null && Exploration.Includes(parent + ".minute"))
            {
                this.Minute = new MinuteSnapshotSchedule();
                this.Minute.ApplyExploratoryFragment(parent + ".minute");
            }
            //      C# -> MonthlySnapshotSchedule? Monthly
            // GraphQL -> monthly: MonthlySnapshotSchedule (type)
            if (this.Monthly == null && Exploration.Includes(parent + ".monthly"))
            {
                this.Monthly = new MonthlySnapshotSchedule();
                this.Monthly.ApplyExploratoryFragment(parent + ".monthly");
            }
            //      C# -> QuarterlySnapshotSchedule? Quarterly
            // GraphQL -> quarterly: QuarterlySnapshotSchedule (type)
            if (this.Quarterly == null && Exploration.Includes(parent + ".quarterly"))
            {
                this.Quarterly = new QuarterlySnapshotSchedule();
                this.Quarterly.ApplyExploratoryFragment(parent + ".quarterly");
            }
            //      C# -> WeeklySnapshotSchedule? Weekly
            // GraphQL -> weekly: WeeklySnapshotSchedule (type)
            if (this.Weekly == null && Exploration.Includes(parent + ".weekly"))
            {
                this.Weekly = new WeeklySnapshotSchedule();
                this.Weekly.ApplyExploratoryFragment(parent + ".weekly");
            }
            //      C# -> YearlySnapshotSchedule? Yearly
            // GraphQL -> yearly: YearlySnapshotSchedule (type)
            if (this.Yearly == null && Exploration.Includes(parent + ".yearly"))
            {
                this.Yearly = new YearlySnapshotSchedule();
                this.Yearly.ApplyExploratoryFragment(parent + ".yearly");
            }
        }


    #endregion

    } // class SnapshotSchedule
    #endregion

    public static class ListSnapshotScheduleExtensions
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
            this List<SnapshotSchedule> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotSchedule> list, 
            String parent = "")
        {
            var item = new SnapshotSchedule();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types