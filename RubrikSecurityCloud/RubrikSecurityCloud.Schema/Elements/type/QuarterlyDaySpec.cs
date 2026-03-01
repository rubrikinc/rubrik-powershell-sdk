// QuarterlyDaySpec.cs
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
    #region QuarterlyDaySpec
    public class QuarterlyDaySpec: BaseType
    {
        #region members

        //      C# -> SlaMonth? FirstQuarterStartMonth
        // GraphQL -> firstQuarterStartMonth: SlaMonth! (enum)
        [JsonProperty("firstQuarterStartMonth")]
        public SlaMonth? FirstQuarterStartMonth { get; set; }

        //      C# -> System.Int32? MonthInQuarter
        // GraphQL -> monthInQuarter: Int! (scalar)
        [JsonProperty("monthInQuarter")]
        public System.Int32? MonthInQuarter { get; set; }

        //      C# -> CdmMonthlyDaySpecification? DayInMonth
        // GraphQL -> dayInMonth: CdmMonthlyDaySpecification (type)
        [JsonProperty("dayInMonth")]
        public CdmMonthlyDaySpecification? DayInMonth { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "QuarterlyDaySpec";
    }

    public QuarterlyDaySpec Set(
        SlaMonth? FirstQuarterStartMonth = null,
        System.Int32? MonthInQuarter = null,
        CdmMonthlyDaySpecification? DayInMonth = null
    ) 
    {
        if ( FirstQuarterStartMonth != null ) {
            this.FirstQuarterStartMonth = FirstQuarterStartMonth;
        }
        if ( MonthInQuarter != null ) {
            this.MonthInQuarter = MonthInQuarter;
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
        //      C# -> SlaMonth? FirstQuarterStartMonth
        // GraphQL -> firstQuarterStartMonth: SlaMonth! (enum)
        if (this.FirstQuarterStartMonth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstQuarterStartMonth\n" ;
            } else {
                s += ind + "firstQuarterStartMonth\n" ;
            }
        }
        //      C# -> System.Int32? MonthInQuarter
        // GraphQL -> monthInQuarter: Int! (scalar)
        if (this.MonthInQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "monthInQuarter\n" ;
            } else {
                s += ind + "monthInQuarter\n" ;
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
        //      C# -> SlaMonth? FirstQuarterStartMonth
        // GraphQL -> firstQuarterStartMonth: SlaMonth! (enum)
        if (ec.Includes("firstQuarterStartMonth",true))
        {
            if(this.FirstQuarterStartMonth == null) {

                this.FirstQuarterStartMonth = new SlaMonth();

            } else {


            }
        }
        else if (this.FirstQuarterStartMonth != null && ec.Excludes("firstQuarterStartMonth",true))
        {
            this.FirstQuarterStartMonth = null;
        }
        //      C# -> System.Int32? MonthInQuarter
        // GraphQL -> monthInQuarter: Int! (scalar)
        if (ec.Includes("monthInQuarter",true))
        {
            if(this.MonthInQuarter == null) {

                this.MonthInQuarter = Int32.MinValue;

            } else {


            }
        }
        else if (this.MonthInQuarter != null && ec.Excludes("monthInQuarter",true))
        {
            this.MonthInQuarter = null;
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

    } // class QuarterlyDaySpec
    
    #endregion

    public static class ListQuarterlyDaySpecExtensions
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
            this List<QuarterlyDaySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<QuarterlyDaySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<QuarterlyDaySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new QuarterlyDaySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<QuarterlyDaySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types