// YearlyDaySpec.cs
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
    #region YearlyDaySpec
    public class YearlyDaySpec: BaseType
    {
        #region members

        //      C# -> SlaMonth? YearStartMonth
        // GraphQL -> yearStartMonth: SlaMonth! (enum)
        [JsonProperty("yearStartMonth")]
        public SlaMonth? YearStartMonth { get; set; }

        //      C# -> System.Int32? MonthInYear
        // GraphQL -> monthInYear: Int! (scalar)
        [JsonProperty("monthInYear")]
        public System.Int32? MonthInYear { get; set; }

        //      C# -> CdmMonthlyDaySpecification? DayInMonth
        // GraphQL -> dayInMonth: CdmMonthlyDaySpecification (type)
        [JsonProperty("dayInMonth")]
        public CdmMonthlyDaySpecification? DayInMonth { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "YearlyDaySpec";
    }

    public YearlyDaySpec Set(
        SlaMonth? YearStartMonth = null,
        System.Int32? MonthInYear = null,
        CdmMonthlyDaySpecification? DayInMonth = null
    ) 
    {
        if ( YearStartMonth != null ) {
            this.YearStartMonth = YearStartMonth;
        }
        if ( MonthInYear != null ) {
            this.MonthInYear = MonthInYear;
        }
        if ( DayInMonth != null ) {
            this.DayInMonth = DayInMonth;
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
        //      C# -> SlaMonth? YearStartMonth
        // GraphQL -> yearStartMonth: SlaMonth! (enum)
        if (this.YearStartMonth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "yearStartMonth\n" ;
            } else {
                s += ind + "yearStartMonth\n" ;
            }
        }
        //      C# -> System.Int32? MonthInYear
        // GraphQL -> monthInYear: Int! (scalar)
        if (this.MonthInYear != null) {
            if (conf.Flat) {
                s += conf.Prefix + "monthInYear\n" ;
            } else {
                s += ind + "monthInYear\n" ;
            }
        }
        //      C# -> CdmMonthlyDaySpecification? DayInMonth
        // GraphQL -> dayInMonth: CdmMonthlyDaySpecification (type)
        if (this.DayInMonth != null) {
            var fspec = this.DayInMonth.AsFieldSpec(conf.Child("dayInMonth"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dayInMonth" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SlaMonth? YearStartMonth
        // GraphQL -> yearStartMonth: SlaMonth! (enum)
        if (ec.Includes("yearStartMonth",true))
        {
            if(this.YearStartMonth == null) {

                this.YearStartMonth = new SlaMonth();

            } else {


            }
        }
        else if (this.YearStartMonth != null && ec.Excludes("yearStartMonth",true))
        {
            this.YearStartMonth = null;
        }
        //      C# -> System.Int32? MonthInYear
        // GraphQL -> monthInYear: Int! (scalar)
        if (ec.Includes("monthInYear",true))
        {
            if(this.MonthInYear == null) {

                this.MonthInYear = Int32.MinValue;

            } else {


            }
        }
        else if (this.MonthInYear != null && ec.Excludes("monthInYear",true))
        {
            this.MonthInYear = null;
        }
        //      C# -> CdmMonthlyDaySpecification? DayInMonth
        // GraphQL -> dayInMonth: CdmMonthlyDaySpecification (type)
        if (ec.Includes("dayInMonth",false))
        {
            if(this.DayInMonth == null) {

                this.DayInMonth = new CdmMonthlyDaySpecification();
                this.DayInMonth.ApplyExploratoryFieldSpec(ec.NewChild("dayInMonth"));

            } else {

                this.DayInMonth.ApplyExploratoryFieldSpec(ec.NewChild("dayInMonth"));

            }
        }
        else if (this.DayInMonth != null && ec.Excludes("dayInMonth",false))
        {
            this.DayInMonth = null;
        }
    }


    #endregion

    } // class YearlyDaySpec
    
    #endregion

    public static class ListYearlyDaySpecExtensions
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
            this List<YearlyDaySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<YearlyDaySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<YearlyDaySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new YearlyDaySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<YearlyDaySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types