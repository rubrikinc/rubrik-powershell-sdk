// YearlyDaySpecification.cs
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
    #region YearlyDaySpecification
    public class YearlyDaySpecification: BaseType
    {
        #region members

        //      C# -> Month? MonthInYear
        // GraphQL -> monthInYear: Month! (enum)
        [JsonProperty("monthInYear")]
        public Month? MonthInYear { get; set; }

        //      C# -> MonthlyDaySpec? DayOfMonthSpecification
        // GraphQL -> dayOfMonthSpecification: MonthlyDaySpec (type)
        [JsonProperty("dayOfMonthSpecification")]
        public MonthlyDaySpec? DayOfMonthSpecification { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "YearlyDaySpecification";
    }

    public YearlyDaySpecification Set(
        Month? MonthInYear = null,
        MonthlyDaySpec? DayOfMonthSpecification = null
    ) 
    {
        if ( MonthInYear != null ) {
            this.MonthInYear = MonthInYear;
        }
        if ( DayOfMonthSpecification != null ) {
            this.DayOfMonthSpecification = DayOfMonthSpecification;
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
        //      C# -> Month? MonthInYear
        // GraphQL -> monthInYear: Month! (enum)
        if (this.MonthInYear != null) {
            if (conf.Flat) {
                s += conf.Prefix + "monthInYear\n" ;
            } else {
                s += ind + "monthInYear\n" ;
            }
        }
        //      C# -> MonthlyDaySpec? DayOfMonthSpecification
        // GraphQL -> dayOfMonthSpecification: MonthlyDaySpec (type)
        if (this.DayOfMonthSpecification != null) {
            var fspec = this.DayOfMonthSpecification.AsFieldSpec(conf.Child("dayOfMonthSpecification"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dayOfMonthSpecification" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Month? MonthInYear
        // GraphQL -> monthInYear: Month! (enum)
        if (ec.Includes("monthInYear",true))
        {
            if(this.MonthInYear == null) {

                this.MonthInYear = new Month();

            } else {


            }
        }
        else if (this.MonthInYear != null && ec.Excludes("monthInYear",true))
        {
            this.MonthInYear = null;
        }
        //      C# -> MonthlyDaySpec? DayOfMonthSpecification
        // GraphQL -> dayOfMonthSpecification: MonthlyDaySpec (type)
        if (ec.Includes("dayOfMonthSpecification",false))
        {
            if(this.DayOfMonthSpecification == null) {

                this.DayOfMonthSpecification = new MonthlyDaySpec();
                this.DayOfMonthSpecification.ApplyExploratoryFieldSpec(ec.NewChild("dayOfMonthSpecification"));

            } else {

                this.DayOfMonthSpecification.ApplyExploratoryFieldSpec(ec.NewChild("dayOfMonthSpecification"));

            }
        }
        else if (this.DayOfMonthSpecification != null && ec.Excludes("dayOfMonthSpecification",false))
        {
            this.DayOfMonthSpecification = null;
        }
    }


    #endregion

    } // class YearlyDaySpecification
    
    #endregion

    public static class ListYearlyDaySpecificationExtensions
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
            this List<YearlyDaySpecification> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<YearlyDaySpecification> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<YearlyDaySpecification> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new YearlyDaySpecification());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<YearlyDaySpecification> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types