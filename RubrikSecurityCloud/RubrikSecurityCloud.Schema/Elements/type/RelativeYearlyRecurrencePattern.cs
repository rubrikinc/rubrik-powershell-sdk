// RelativeYearlyRecurrencePattern.cs
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
    #region RelativeYearlyRecurrencePattern
    public class RelativeYearlyRecurrencePattern: BaseType
    {
        #region members

        //      C# -> System.String? DayOfWeekIndex
        // GraphQL -> dayOfWeekIndex: String! (scalar)
        [JsonProperty("dayOfWeekIndex")]
        public System.String? DayOfWeekIndex { get; set; }

        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        [JsonProperty("daysOfWeek")]
        public List<System.String>? DaysOfWeek { get; set; }

        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        [JsonProperty("month")]
        public System.String? Month { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RelativeYearlyRecurrencePattern";
    }

    public RelativeYearlyRecurrencePattern Set(
        System.String? DayOfWeekIndex = null,
        List<System.String>? DaysOfWeek = null,
        System.String? Month = null
    ) 
    {
        if ( DayOfWeekIndex != null ) {
            this.DayOfWeekIndex = DayOfWeekIndex;
        }
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
        }
        if ( Month != null ) {
            this.Month = Month;
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
        //      C# -> System.String? DayOfWeekIndex
        // GraphQL -> dayOfWeekIndex: String! (scalar)
        if (this.DayOfWeekIndex != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dayOfWeekIndex\n" ;
            } else {
                s += ind + "dayOfWeekIndex\n" ;
            }
        }
        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        if (this.DaysOfWeek != null) {
            if (conf.Flat) {
                s += conf.Prefix + "daysOfWeek\n" ;
            } else {
                s += ind + "daysOfWeek\n" ;
            }
        }
        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        if (this.Month != null) {
            if (conf.Flat) {
                s += conf.Prefix + "month\n" ;
            } else {
                s += ind + "month\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DayOfWeekIndex
        // GraphQL -> dayOfWeekIndex: String! (scalar)
        if (ec.Includes("dayOfWeekIndex",true))
        {
            if(this.DayOfWeekIndex == null) {

                this.DayOfWeekIndex = "FETCH";

            } else {


            }
        }
        else if (this.DayOfWeekIndex != null && ec.Excludes("dayOfWeekIndex",true))
        {
            this.DayOfWeekIndex = null;
        }
        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        if (ec.Includes("daysOfWeek",true))
        {
            if(this.DaysOfWeek == null) {

                this.DaysOfWeek = new List<System.String>();

            } else {


            }
        }
        else if (this.DaysOfWeek != null && ec.Excludes("daysOfWeek",true))
        {
            this.DaysOfWeek = null;
        }
        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        if (ec.Includes("month",true))
        {
            if(this.Month == null) {

                this.Month = "FETCH";

            } else {


            }
        }
        else if (this.Month != null && ec.Excludes("month",true))
        {
            this.Month = null;
        }
    }


    #endregion

    } // class RelativeYearlyRecurrencePattern
    
    #endregion

    public static class ListRelativeYearlyRecurrencePatternExtensions
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
            this List<RelativeYearlyRecurrencePattern> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RelativeYearlyRecurrencePattern> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RelativeYearlyRecurrencePattern> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RelativeYearlyRecurrencePattern());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RelativeYearlyRecurrencePattern> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types