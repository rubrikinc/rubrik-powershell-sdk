// SnapshotSchedule.cs
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
    #region SnapshotSchedule
    public class SnapshotSchedule: BaseType
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

    public override string GetGqlTypeName() {
        return "SnapshotSchedule";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DailySnapshotSchedule? Daily
        // GraphQL -> daily: DailySnapshotSchedule (type)
        if (this.Daily != null) {
            var fspec = this.Daily.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "daily {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> HourlySnapshotSchedule? Hourly
        // GraphQL -> hourly: HourlySnapshotSchedule (type)
        if (this.Hourly != null) {
            var fspec = this.Hourly.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hourly {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MinuteSnapshotSchedule? Minute
        // GraphQL -> minute: MinuteSnapshotSchedule (type)
        if (this.Minute != null) {
            var fspec = this.Minute.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "minute {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MonthlySnapshotSchedule? Monthly
        // GraphQL -> monthly: MonthlySnapshotSchedule (type)
        if (this.Monthly != null) {
            var fspec = this.Monthly.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "monthly {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> QuarterlySnapshotSchedule? Quarterly
        // GraphQL -> quarterly: QuarterlySnapshotSchedule (type)
        if (this.Quarterly != null) {
            var fspec = this.Quarterly.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "quarterly {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> WeeklySnapshotSchedule? Weekly
        // GraphQL -> weekly: WeeklySnapshotSchedule (type)
        if (this.Weekly != null) {
            var fspec = this.Weekly.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "weekly {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> YearlySnapshotSchedule? Yearly
        // GraphQL -> yearly: YearlySnapshotSchedule (type)
        if (this.Yearly != null) {
            var fspec = this.Yearly.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "yearly {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DailySnapshotSchedule? Daily
        // GraphQL -> daily: DailySnapshotSchedule (type)
        if (this.Daily == null && ec.Includes("daily",false))
        {
            this.Daily = new DailySnapshotSchedule();
            this.Daily.ApplyExploratoryFieldSpec(ec.NewChild("daily"));
        }
        //      C# -> HourlySnapshotSchedule? Hourly
        // GraphQL -> hourly: HourlySnapshotSchedule (type)
        if (this.Hourly == null && ec.Includes("hourly",false))
        {
            this.Hourly = new HourlySnapshotSchedule();
            this.Hourly.ApplyExploratoryFieldSpec(ec.NewChild("hourly"));
        }
        //      C# -> MinuteSnapshotSchedule? Minute
        // GraphQL -> minute: MinuteSnapshotSchedule (type)
        if (this.Minute == null && ec.Includes("minute",false))
        {
            this.Minute = new MinuteSnapshotSchedule();
            this.Minute.ApplyExploratoryFieldSpec(ec.NewChild("minute"));
        }
        //      C# -> MonthlySnapshotSchedule? Monthly
        // GraphQL -> monthly: MonthlySnapshotSchedule (type)
        if (this.Monthly == null && ec.Includes("monthly",false))
        {
            this.Monthly = new MonthlySnapshotSchedule();
            this.Monthly.ApplyExploratoryFieldSpec(ec.NewChild("monthly"));
        }
        //      C# -> QuarterlySnapshotSchedule? Quarterly
        // GraphQL -> quarterly: QuarterlySnapshotSchedule (type)
        if (this.Quarterly == null && ec.Includes("quarterly",false))
        {
            this.Quarterly = new QuarterlySnapshotSchedule();
            this.Quarterly.ApplyExploratoryFieldSpec(ec.NewChild("quarterly"));
        }
        //      C# -> WeeklySnapshotSchedule? Weekly
        // GraphQL -> weekly: WeeklySnapshotSchedule (type)
        if (this.Weekly == null && ec.Includes("weekly",false))
        {
            this.Weekly = new WeeklySnapshotSchedule();
            this.Weekly.ApplyExploratoryFieldSpec(ec.NewChild("weekly"));
        }
        //      C# -> YearlySnapshotSchedule? Yearly
        // GraphQL -> yearly: YearlySnapshotSchedule (type)
        if (this.Yearly == null && ec.Includes("yearly",false))
        {
            this.Yearly = new YearlySnapshotSchedule();
            this.Yearly.ApplyExploratoryFieldSpec(ec.NewChild("yearly"));
        }
    }


    #endregion

    } // class SnapshotSchedule
    
    #endregion

    public static class ListSnapshotScheduleExtensions
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
            this List<SnapshotSchedule> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSchedule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotSchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types