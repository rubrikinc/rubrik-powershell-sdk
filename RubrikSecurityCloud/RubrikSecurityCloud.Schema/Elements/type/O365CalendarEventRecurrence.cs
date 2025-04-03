// O365CalendarEventRecurrence.cs
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
    #region O365CalendarEventRecurrence
    public class O365CalendarEventRecurrence: BaseType
    {
        #region members

        //      C# -> AbsoluteMonthlyRecurrencePattern? AbsoluteMonthlyRecurrence
        // GraphQL -> absoluteMonthlyRecurrence: AbsoluteMonthlyRecurrencePattern (type)
        [JsonProperty("absoluteMonthlyRecurrence")]
        public AbsoluteMonthlyRecurrencePattern? AbsoluteMonthlyRecurrence { get; set; }

        //      C# -> AbsoluteYearlyRecurrencePattern? AbsoluteYearlyRecurrence
        // GraphQL -> absoluteYearlyRecurrence: AbsoluteYearlyRecurrencePattern (type)
        [JsonProperty("absoluteYearlyRecurrence")]
        public AbsoluteYearlyRecurrencePattern? AbsoluteYearlyRecurrence { get; set; }

        //      C# -> DailyRecurrencePattern? DailyRecurrence
        // GraphQL -> dailyRecurrence: DailyRecurrencePattern (type)
        [JsonProperty("dailyRecurrence")]
        public DailyRecurrencePattern? DailyRecurrence { get; set; }

        //      C# -> EndDateRecurrenceRange? EndDateRecurrenceRange
        // GraphQL -> endDateRecurrenceRange: EndDateRecurrenceRange (type)
        [JsonProperty("endDateRecurrenceRange")]
        public EndDateRecurrenceRange? EndDateRecurrenceRange { get; set; }

        //      C# -> NoEndRecurrenceRange? NoEndRecurrenceRange
        // GraphQL -> noEndRecurrenceRange: NoEndRecurrenceRange (type)
        [JsonProperty("noEndRecurrenceRange")]
        public NoEndRecurrenceRange? NoEndRecurrenceRange { get; set; }

        //      C# -> NumberedRecurrenceRange? NumberedRecurrenceRange
        // GraphQL -> numberedRecurrenceRange: NumberedRecurrenceRange (type)
        [JsonProperty("numberedRecurrenceRange")]
        public NumberedRecurrenceRange? NumberedRecurrenceRange { get; set; }

        //      C# -> RelativeMonthlyRecurrencePattern? RelativeMonthlyRecurrence
        // GraphQL -> relativeMonthlyRecurrence: RelativeMonthlyRecurrencePattern (type)
        [JsonProperty("relativeMonthlyRecurrence")]
        public RelativeMonthlyRecurrencePattern? RelativeMonthlyRecurrence { get; set; }

        //      C# -> RelativeYearlyRecurrencePattern? RelativeYearlyRecurrence
        // GraphQL -> relativeYearlyRecurrence: RelativeYearlyRecurrencePattern (type)
        [JsonProperty("relativeYearlyRecurrence")]
        public RelativeYearlyRecurrencePattern? RelativeYearlyRecurrence { get; set; }

        //      C# -> WeeklyRecurrencePattern? WeeklyRecurrence
        // GraphQL -> weeklyRecurrence: WeeklyRecurrencePattern (type)
        [JsonProperty("weeklyRecurrence")]
        public WeeklyRecurrencePattern? WeeklyRecurrence { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365CalendarEventRecurrence";
    }

    public O365CalendarEventRecurrence Set(
        AbsoluteMonthlyRecurrencePattern? AbsoluteMonthlyRecurrence = null,
        AbsoluteYearlyRecurrencePattern? AbsoluteYearlyRecurrence = null,
        DailyRecurrencePattern? DailyRecurrence = null,
        EndDateRecurrenceRange? EndDateRecurrenceRange = null,
        NoEndRecurrenceRange? NoEndRecurrenceRange = null,
        NumberedRecurrenceRange? NumberedRecurrenceRange = null,
        RelativeMonthlyRecurrencePattern? RelativeMonthlyRecurrence = null,
        RelativeYearlyRecurrencePattern? RelativeYearlyRecurrence = null,
        WeeklyRecurrencePattern? WeeklyRecurrence = null
    ) 
    {
        if ( AbsoluteMonthlyRecurrence != null ) {
            this.AbsoluteMonthlyRecurrence = AbsoluteMonthlyRecurrence;
        }
        if ( AbsoluteYearlyRecurrence != null ) {
            this.AbsoluteYearlyRecurrence = AbsoluteYearlyRecurrence;
        }
        if ( DailyRecurrence != null ) {
            this.DailyRecurrence = DailyRecurrence;
        }
        if ( EndDateRecurrenceRange != null ) {
            this.EndDateRecurrenceRange = EndDateRecurrenceRange;
        }
        if ( NoEndRecurrenceRange != null ) {
            this.NoEndRecurrenceRange = NoEndRecurrenceRange;
        }
        if ( NumberedRecurrenceRange != null ) {
            this.NumberedRecurrenceRange = NumberedRecurrenceRange;
        }
        if ( RelativeMonthlyRecurrence != null ) {
            this.RelativeMonthlyRecurrence = RelativeMonthlyRecurrence;
        }
        if ( RelativeYearlyRecurrence != null ) {
            this.RelativeYearlyRecurrence = RelativeYearlyRecurrence;
        }
        if ( WeeklyRecurrence != null ) {
            this.WeeklyRecurrence = WeeklyRecurrence;
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
        //      C# -> AbsoluteMonthlyRecurrencePattern? AbsoluteMonthlyRecurrence
        // GraphQL -> absoluteMonthlyRecurrence: AbsoluteMonthlyRecurrencePattern (type)
        if (this.AbsoluteMonthlyRecurrence != null) {
            var fspec = this.AbsoluteMonthlyRecurrence.AsFieldSpec(conf.Child("absoluteMonthlyRecurrence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "absoluteMonthlyRecurrence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AbsoluteYearlyRecurrencePattern? AbsoluteYearlyRecurrence
        // GraphQL -> absoluteYearlyRecurrence: AbsoluteYearlyRecurrencePattern (type)
        if (this.AbsoluteYearlyRecurrence != null) {
            var fspec = this.AbsoluteYearlyRecurrence.AsFieldSpec(conf.Child("absoluteYearlyRecurrence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "absoluteYearlyRecurrence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DailyRecurrencePattern? DailyRecurrence
        // GraphQL -> dailyRecurrence: DailyRecurrencePattern (type)
        if (this.DailyRecurrence != null) {
            var fspec = this.DailyRecurrence.AsFieldSpec(conf.Child("dailyRecurrence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dailyRecurrence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> EndDateRecurrenceRange? EndDateRecurrenceRange
        // GraphQL -> endDateRecurrenceRange: EndDateRecurrenceRange (type)
        if (this.EndDateRecurrenceRange != null) {
            var fspec = this.EndDateRecurrenceRange.AsFieldSpec(conf.Child("endDateRecurrenceRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "endDateRecurrenceRange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NoEndRecurrenceRange? NoEndRecurrenceRange
        // GraphQL -> noEndRecurrenceRange: NoEndRecurrenceRange (type)
        if (this.NoEndRecurrenceRange != null) {
            var fspec = this.NoEndRecurrenceRange.AsFieldSpec(conf.Child("noEndRecurrenceRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "noEndRecurrenceRange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NumberedRecurrenceRange? NumberedRecurrenceRange
        // GraphQL -> numberedRecurrenceRange: NumberedRecurrenceRange (type)
        if (this.NumberedRecurrenceRange != null) {
            var fspec = this.NumberedRecurrenceRange.AsFieldSpec(conf.Child("numberedRecurrenceRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "numberedRecurrenceRange" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RelativeMonthlyRecurrencePattern? RelativeMonthlyRecurrence
        // GraphQL -> relativeMonthlyRecurrence: RelativeMonthlyRecurrencePattern (type)
        if (this.RelativeMonthlyRecurrence != null) {
            var fspec = this.RelativeMonthlyRecurrence.AsFieldSpec(conf.Child("relativeMonthlyRecurrence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "relativeMonthlyRecurrence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RelativeYearlyRecurrencePattern? RelativeYearlyRecurrence
        // GraphQL -> relativeYearlyRecurrence: RelativeYearlyRecurrencePattern (type)
        if (this.RelativeYearlyRecurrence != null) {
            var fspec = this.RelativeYearlyRecurrence.AsFieldSpec(conf.Child("relativeYearlyRecurrence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "relativeYearlyRecurrence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WeeklyRecurrencePattern? WeeklyRecurrence
        // GraphQL -> weeklyRecurrence: WeeklyRecurrencePattern (type)
        if (this.WeeklyRecurrence != null) {
            var fspec = this.WeeklyRecurrence.AsFieldSpec(conf.Child("weeklyRecurrence"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "weeklyRecurrence" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AbsoluteMonthlyRecurrencePattern? AbsoluteMonthlyRecurrence
        // GraphQL -> absoluteMonthlyRecurrence: AbsoluteMonthlyRecurrencePattern (type)
        if (ec.Includes("absoluteMonthlyRecurrence",false))
        {
            if(this.AbsoluteMonthlyRecurrence == null) {

                this.AbsoluteMonthlyRecurrence = new AbsoluteMonthlyRecurrencePattern();
                this.AbsoluteMonthlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("absoluteMonthlyRecurrence"));

            } else {

                this.AbsoluteMonthlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("absoluteMonthlyRecurrence"));

            }
        }
        else if (this.AbsoluteMonthlyRecurrence != null && ec.Excludes("absoluteMonthlyRecurrence",false))
        {
            this.AbsoluteMonthlyRecurrence = null;
        }
        //      C# -> AbsoluteYearlyRecurrencePattern? AbsoluteYearlyRecurrence
        // GraphQL -> absoluteYearlyRecurrence: AbsoluteYearlyRecurrencePattern (type)
        if (ec.Includes("absoluteYearlyRecurrence",false))
        {
            if(this.AbsoluteYearlyRecurrence == null) {

                this.AbsoluteYearlyRecurrence = new AbsoluteYearlyRecurrencePattern();
                this.AbsoluteYearlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("absoluteYearlyRecurrence"));

            } else {

                this.AbsoluteYearlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("absoluteYearlyRecurrence"));

            }
        }
        else if (this.AbsoluteYearlyRecurrence != null && ec.Excludes("absoluteYearlyRecurrence",false))
        {
            this.AbsoluteYearlyRecurrence = null;
        }
        //      C# -> DailyRecurrencePattern? DailyRecurrence
        // GraphQL -> dailyRecurrence: DailyRecurrencePattern (type)
        if (ec.Includes("dailyRecurrence",false))
        {
            if(this.DailyRecurrence == null) {

                this.DailyRecurrence = new DailyRecurrencePattern();
                this.DailyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("dailyRecurrence"));

            } else {

                this.DailyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("dailyRecurrence"));

            }
        }
        else if (this.DailyRecurrence != null && ec.Excludes("dailyRecurrence",false))
        {
            this.DailyRecurrence = null;
        }
        //      C# -> EndDateRecurrenceRange? EndDateRecurrenceRange
        // GraphQL -> endDateRecurrenceRange: EndDateRecurrenceRange (type)
        if (ec.Includes("endDateRecurrenceRange",false))
        {
            if(this.EndDateRecurrenceRange == null) {

                this.EndDateRecurrenceRange = new EndDateRecurrenceRange();
                this.EndDateRecurrenceRange.ApplyExploratoryFieldSpec(ec.NewChild("endDateRecurrenceRange"));

            } else {

                this.EndDateRecurrenceRange.ApplyExploratoryFieldSpec(ec.NewChild("endDateRecurrenceRange"));

            }
        }
        else if (this.EndDateRecurrenceRange != null && ec.Excludes("endDateRecurrenceRange",false))
        {
            this.EndDateRecurrenceRange = null;
        }
        //      C# -> NoEndRecurrenceRange? NoEndRecurrenceRange
        // GraphQL -> noEndRecurrenceRange: NoEndRecurrenceRange (type)
        if (ec.Includes("noEndRecurrenceRange",false))
        {
            if(this.NoEndRecurrenceRange == null) {

                this.NoEndRecurrenceRange = new NoEndRecurrenceRange();
                this.NoEndRecurrenceRange.ApplyExploratoryFieldSpec(ec.NewChild("noEndRecurrenceRange"));

            } else {

                this.NoEndRecurrenceRange.ApplyExploratoryFieldSpec(ec.NewChild("noEndRecurrenceRange"));

            }
        }
        else if (this.NoEndRecurrenceRange != null && ec.Excludes("noEndRecurrenceRange",false))
        {
            this.NoEndRecurrenceRange = null;
        }
        //      C# -> NumberedRecurrenceRange? NumberedRecurrenceRange
        // GraphQL -> numberedRecurrenceRange: NumberedRecurrenceRange (type)
        if (ec.Includes("numberedRecurrenceRange",false))
        {
            if(this.NumberedRecurrenceRange == null) {

                this.NumberedRecurrenceRange = new NumberedRecurrenceRange();
                this.NumberedRecurrenceRange.ApplyExploratoryFieldSpec(ec.NewChild("numberedRecurrenceRange"));

            } else {

                this.NumberedRecurrenceRange.ApplyExploratoryFieldSpec(ec.NewChild("numberedRecurrenceRange"));

            }
        }
        else if (this.NumberedRecurrenceRange != null && ec.Excludes("numberedRecurrenceRange",false))
        {
            this.NumberedRecurrenceRange = null;
        }
        //      C# -> RelativeMonthlyRecurrencePattern? RelativeMonthlyRecurrence
        // GraphQL -> relativeMonthlyRecurrence: RelativeMonthlyRecurrencePattern (type)
        if (ec.Includes("relativeMonthlyRecurrence",false))
        {
            if(this.RelativeMonthlyRecurrence == null) {

                this.RelativeMonthlyRecurrence = new RelativeMonthlyRecurrencePattern();
                this.RelativeMonthlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("relativeMonthlyRecurrence"));

            } else {

                this.RelativeMonthlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("relativeMonthlyRecurrence"));

            }
        }
        else if (this.RelativeMonthlyRecurrence != null && ec.Excludes("relativeMonthlyRecurrence",false))
        {
            this.RelativeMonthlyRecurrence = null;
        }
        //      C# -> RelativeYearlyRecurrencePattern? RelativeYearlyRecurrence
        // GraphQL -> relativeYearlyRecurrence: RelativeYearlyRecurrencePattern (type)
        if (ec.Includes("relativeYearlyRecurrence",false))
        {
            if(this.RelativeYearlyRecurrence == null) {

                this.RelativeYearlyRecurrence = new RelativeYearlyRecurrencePattern();
                this.RelativeYearlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("relativeYearlyRecurrence"));

            } else {

                this.RelativeYearlyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("relativeYearlyRecurrence"));

            }
        }
        else if (this.RelativeYearlyRecurrence != null && ec.Excludes("relativeYearlyRecurrence",false))
        {
            this.RelativeYearlyRecurrence = null;
        }
        //      C# -> WeeklyRecurrencePattern? WeeklyRecurrence
        // GraphQL -> weeklyRecurrence: WeeklyRecurrencePattern (type)
        if (ec.Includes("weeklyRecurrence",false))
        {
            if(this.WeeklyRecurrence == null) {

                this.WeeklyRecurrence = new WeeklyRecurrencePattern();
                this.WeeklyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("weeklyRecurrence"));

            } else {

                this.WeeklyRecurrence.ApplyExploratoryFieldSpec(ec.NewChild("weeklyRecurrence"));

            }
        }
        else if (this.WeeklyRecurrence != null && ec.Excludes("weeklyRecurrence",false))
        {
            this.WeeklyRecurrence = null;
        }
    }


    #endregion

    } // class O365CalendarEventRecurrence
    
    #endregion

    public static class ListO365CalendarEventRecurrenceExtensions
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
            this List<O365CalendarEventRecurrence> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365CalendarEventRecurrence> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365CalendarEventRecurrence> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365CalendarEventRecurrence());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365CalendarEventRecurrence> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types