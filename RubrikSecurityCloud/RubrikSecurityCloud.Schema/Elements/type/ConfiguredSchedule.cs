// ConfiguredSchedule.cs
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
    #region ConfiguredSchedule
    public class ConfiguredSchedule: BaseType
    {
        #region members

        //      C# -> List<CdmMonthlyDaySpecification>? DaysOfMonth
        // GraphQL -> daysOfMonth: [CdmMonthlyDaySpecification!]! (type)
        [JsonProperty("daysOfMonth")]
        public List<CdmMonthlyDaySpecification>? DaysOfMonth { get; set; }

        //      C# -> List<QuarterlyDaySpec>? DaysOfQuarter
        // GraphQL -> daysOfQuarter: [QuarterlyDaySpec!]! (type)
        [JsonProperty("daysOfQuarter")]
        public List<QuarterlyDaySpec>? DaysOfQuarter { get; set; }

        //      C# -> List<WeeklyDaySpecification>? DaysOfWeek
        // GraphQL -> daysOfWeek: [WeeklyDaySpecification!]! (type)
        [JsonProperty("daysOfWeek")]
        public List<WeeklyDaySpecification>? DaysOfWeek { get; set; }

        //      C# -> List<YearlyDaySpec>? DaysOfYear
        // GraphQL -> daysOfYear: [YearlyDaySpec!]! (type)
        [JsonProperty("daysOfYear")]
        public List<YearlyDaySpec>? DaysOfYear { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfiguredSchedule";
    }

    public ConfiguredSchedule Set(
        List<CdmMonthlyDaySpecification>? DaysOfMonth = null,
        List<QuarterlyDaySpec>? DaysOfQuarter = null,
        List<WeeklyDaySpecification>? DaysOfWeek = null,
        List<YearlyDaySpec>? DaysOfYear = null
    ) 
    {
        if ( DaysOfMonth != null ) {
            this.DaysOfMonth = DaysOfMonth;
        }
        if ( DaysOfQuarter != null ) {
            this.DaysOfQuarter = DaysOfQuarter;
        }
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
        }
        if ( DaysOfYear != null ) {
            this.DaysOfYear = DaysOfYear;
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
        //      C# -> List<CdmMonthlyDaySpecification>? DaysOfMonth
        // GraphQL -> daysOfMonth: [CdmMonthlyDaySpecification!]! (type)
        if (this.DaysOfMonth != null) {
            var fspec = this.DaysOfMonth.AsFieldSpec(conf.Child("daysOfMonth"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "daysOfMonth" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<QuarterlyDaySpec>? DaysOfQuarter
        // GraphQL -> daysOfQuarter: [QuarterlyDaySpec!]! (type)
        if (this.DaysOfQuarter != null) {
            var fspec = this.DaysOfQuarter.AsFieldSpec(conf.Child("daysOfQuarter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "daysOfQuarter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WeeklyDaySpecification>? DaysOfWeek
        // GraphQL -> daysOfWeek: [WeeklyDaySpecification!]! (type)
        if (this.DaysOfWeek != null) {
            var fspec = this.DaysOfWeek.AsFieldSpec(conf.Child("daysOfWeek"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "daysOfWeek" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<YearlyDaySpec>? DaysOfYear
        // GraphQL -> daysOfYear: [YearlyDaySpec!]! (type)
        if (this.DaysOfYear != null) {
            var fspec = this.DaysOfYear.AsFieldSpec(conf.Child("daysOfYear"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "daysOfYear" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<CdmMonthlyDaySpecification>? DaysOfMonth
        // GraphQL -> daysOfMonth: [CdmMonthlyDaySpecification!]! (type)
        if (ec.Includes("daysOfMonth",false))
        {
            if(this.DaysOfMonth == null) {

                this.DaysOfMonth = new List<CdmMonthlyDaySpecification>();
                this.DaysOfMonth.ApplyExploratoryFieldSpec(ec.NewChild("daysOfMonth"));

            } else {

                this.DaysOfMonth.ApplyExploratoryFieldSpec(ec.NewChild("daysOfMonth"));

            }
        }
        else if (this.DaysOfMonth != null && ec.Excludes("daysOfMonth",false))
        {
            this.DaysOfMonth = null;
        }
        //      C# -> List<QuarterlyDaySpec>? DaysOfQuarter
        // GraphQL -> daysOfQuarter: [QuarterlyDaySpec!]! (type)
        if (ec.Includes("daysOfQuarter",false))
        {
            if(this.DaysOfQuarter == null) {

                this.DaysOfQuarter = new List<QuarterlyDaySpec>();
                this.DaysOfQuarter.ApplyExploratoryFieldSpec(ec.NewChild("daysOfQuarter"));

            } else {

                this.DaysOfQuarter.ApplyExploratoryFieldSpec(ec.NewChild("daysOfQuarter"));

            }
        }
        else if (this.DaysOfQuarter != null && ec.Excludes("daysOfQuarter",false))
        {
            this.DaysOfQuarter = null;
        }
        //      C# -> List<WeeklyDaySpecification>? DaysOfWeek
        // GraphQL -> daysOfWeek: [WeeklyDaySpecification!]! (type)
        if (ec.Includes("daysOfWeek",false))
        {
            if(this.DaysOfWeek == null) {

                this.DaysOfWeek = new List<WeeklyDaySpecification>();
                this.DaysOfWeek.ApplyExploratoryFieldSpec(ec.NewChild("daysOfWeek"));

            } else {

                this.DaysOfWeek.ApplyExploratoryFieldSpec(ec.NewChild("daysOfWeek"));

            }
        }
        else if (this.DaysOfWeek != null && ec.Excludes("daysOfWeek",false))
        {
            this.DaysOfWeek = null;
        }
        //      C# -> List<YearlyDaySpec>? DaysOfYear
        // GraphQL -> daysOfYear: [YearlyDaySpec!]! (type)
        if (ec.Includes("daysOfYear",false))
        {
            if(this.DaysOfYear == null) {

                this.DaysOfYear = new List<YearlyDaySpec>();
                this.DaysOfYear.ApplyExploratoryFieldSpec(ec.NewChild("daysOfYear"));

            } else {

                this.DaysOfYear.ApplyExploratoryFieldSpec(ec.NewChild("daysOfYear"));

            }
        }
        else if (this.DaysOfYear != null && ec.Excludes("daysOfYear",false))
        {
            this.DaysOfYear = null;
        }
    }


    #endregion

    } // class ConfiguredSchedule
    
    #endregion

    public static class ListConfiguredScheduleExtensions
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
            this List<ConfiguredSchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfiguredSchedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfiguredSchedule> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfiguredSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfiguredSchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types