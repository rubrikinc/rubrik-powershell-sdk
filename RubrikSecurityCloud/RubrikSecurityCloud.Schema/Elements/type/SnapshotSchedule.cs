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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DailySnapshotSchedule? Daily
        // GraphQL -> daily: DailySnapshotSchedule (type)
        if (this.Daily != null) {
            var fspec = this.Daily.AsFieldSpec(conf.Child("daily"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "daily" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HourlySnapshotSchedule? Hourly
        // GraphQL -> hourly: HourlySnapshotSchedule (type)
        if (this.Hourly != null) {
            var fspec = this.Hourly.AsFieldSpec(conf.Child("hourly"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hourly" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MinuteSnapshotSchedule? Minute
        // GraphQL -> minute: MinuteSnapshotSchedule (type)
        if (this.Minute != null) {
            var fspec = this.Minute.AsFieldSpec(conf.Child("minute"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "minute" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MonthlySnapshotSchedule? Monthly
        // GraphQL -> monthly: MonthlySnapshotSchedule (type)
        if (this.Monthly != null) {
            var fspec = this.Monthly.AsFieldSpec(conf.Child("monthly"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "monthly" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> QuarterlySnapshotSchedule? Quarterly
        // GraphQL -> quarterly: QuarterlySnapshotSchedule (type)
        if (this.Quarterly != null) {
            var fspec = this.Quarterly.AsFieldSpec(conf.Child("quarterly"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "quarterly" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WeeklySnapshotSchedule? Weekly
        // GraphQL -> weekly: WeeklySnapshotSchedule (type)
        if (this.Weekly != null) {
            var fspec = this.Weekly.AsFieldSpec(conf.Child("weekly"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "weekly" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> YearlySnapshotSchedule? Yearly
        // GraphQL -> yearly: YearlySnapshotSchedule (type)
        if (this.Yearly != null) {
            var fspec = this.Yearly.AsFieldSpec(conf.Child("yearly"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "yearly" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DailySnapshotSchedule? Daily
        // GraphQL -> daily: DailySnapshotSchedule (type)
        if (ec.Includes("daily",false))
        {
            if(this.Daily == null) {

                this.Daily = new DailySnapshotSchedule();
                this.Daily.ApplyExploratoryFieldSpec(ec.NewChild("daily"));

            } else {

                this.Daily.ApplyExploratoryFieldSpec(ec.NewChild("daily"));

            }
        }
        else if (this.Daily != null && ec.Excludes("daily",false))
        {
            this.Daily = null;
        }
        //      C# -> HourlySnapshotSchedule? Hourly
        // GraphQL -> hourly: HourlySnapshotSchedule (type)
        if (ec.Includes("hourly",false))
        {
            if(this.Hourly == null) {

                this.Hourly = new HourlySnapshotSchedule();
                this.Hourly.ApplyExploratoryFieldSpec(ec.NewChild("hourly"));

            } else {

                this.Hourly.ApplyExploratoryFieldSpec(ec.NewChild("hourly"));

            }
        }
        else if (this.Hourly != null && ec.Excludes("hourly",false))
        {
            this.Hourly = null;
        }
        //      C# -> MinuteSnapshotSchedule? Minute
        // GraphQL -> minute: MinuteSnapshotSchedule (type)
        if (ec.Includes("minute",false))
        {
            if(this.Minute == null) {

                this.Minute = new MinuteSnapshotSchedule();
                this.Minute.ApplyExploratoryFieldSpec(ec.NewChild("minute"));

            } else {

                this.Minute.ApplyExploratoryFieldSpec(ec.NewChild("minute"));

            }
        }
        else if (this.Minute != null && ec.Excludes("minute",false))
        {
            this.Minute = null;
        }
        //      C# -> MonthlySnapshotSchedule? Monthly
        // GraphQL -> monthly: MonthlySnapshotSchedule (type)
        if (ec.Includes("monthly",false))
        {
            if(this.Monthly == null) {

                this.Monthly = new MonthlySnapshotSchedule();
                this.Monthly.ApplyExploratoryFieldSpec(ec.NewChild("monthly"));

            } else {

                this.Monthly.ApplyExploratoryFieldSpec(ec.NewChild("monthly"));

            }
        }
        else if (this.Monthly != null && ec.Excludes("monthly",false))
        {
            this.Monthly = null;
        }
        //      C# -> QuarterlySnapshotSchedule? Quarterly
        // GraphQL -> quarterly: QuarterlySnapshotSchedule (type)
        if (ec.Includes("quarterly",false))
        {
            if(this.Quarterly == null) {

                this.Quarterly = new QuarterlySnapshotSchedule();
                this.Quarterly.ApplyExploratoryFieldSpec(ec.NewChild("quarterly"));

            } else {

                this.Quarterly.ApplyExploratoryFieldSpec(ec.NewChild("quarterly"));

            }
        }
        else if (this.Quarterly != null && ec.Excludes("quarterly",false))
        {
            this.Quarterly = null;
        }
        //      C# -> WeeklySnapshotSchedule? Weekly
        // GraphQL -> weekly: WeeklySnapshotSchedule (type)
        if (ec.Includes("weekly",false))
        {
            if(this.Weekly == null) {

                this.Weekly = new WeeklySnapshotSchedule();
                this.Weekly.ApplyExploratoryFieldSpec(ec.NewChild("weekly"));

            } else {

                this.Weekly.ApplyExploratoryFieldSpec(ec.NewChild("weekly"));

            }
        }
        else if (this.Weekly != null && ec.Excludes("weekly",false))
        {
            this.Weekly = null;
        }
        //      C# -> YearlySnapshotSchedule? Yearly
        // GraphQL -> yearly: YearlySnapshotSchedule (type)
        if (ec.Includes("yearly",false))
        {
            if(this.Yearly == null) {

                this.Yearly = new YearlySnapshotSchedule();
                this.Yearly.ApplyExploratoryFieldSpec(ec.NewChild("yearly"));

            } else {

                this.Yearly.ApplyExploratoryFieldSpec(ec.NewChild("yearly"));

            }
        }
        else if (this.Yearly != null && ec.Excludes("yearly",false))
        {
            this.Yearly = null;
        }
    }


    #endregion

    } // class SnapshotSchedule
    
    #endregion

    public static class ListSnapshotScheduleExtensions
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
            this List<SnapshotSchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotSchedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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