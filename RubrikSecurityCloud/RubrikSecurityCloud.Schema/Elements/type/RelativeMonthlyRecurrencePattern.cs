// RelativeMonthlyRecurrencePattern.cs
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
    #region RelativeMonthlyRecurrencePattern
    public class RelativeMonthlyRecurrencePattern: BaseType
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

        //      C# -> System.Int32? Interval
        // GraphQL -> interval: Int! (scalar)
        [JsonProperty("interval")]
        public System.Int32? Interval { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RelativeMonthlyRecurrencePattern";
    }

    public RelativeMonthlyRecurrencePattern Set(
        System.String? DayOfWeekIndex = null,
        List<System.String>? DaysOfWeek = null,
        System.Int32? Interval = null
    ) 
    {
        if ( DayOfWeekIndex != null ) {
            this.DayOfWeekIndex = DayOfWeekIndex;
        }
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
        }
        if ( Interval != null ) {
            this.Interval = Interval;
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
        //      C# -> System.Int32? Interval
        // GraphQL -> interval: Int! (scalar)
        if (this.Interval != null) {
            if (conf.Flat) {
                s += conf.Prefix + "interval\n" ;
            } else {
                s += ind + "interval\n" ;
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
        //      C# -> System.Int32? Interval
        // GraphQL -> interval: Int! (scalar)
        if (ec.Includes("interval",true))
        {
            if(this.Interval == null) {

                this.Interval = Int32.MinValue;

            } else {


            }
        }
        else if (this.Interval != null && ec.Excludes("interval",true))
        {
            this.Interval = null;
        }
    }


    #endregion

    } // class RelativeMonthlyRecurrencePattern
    
    #endregion

    public static class ListRelativeMonthlyRecurrencePatternExtensions
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
            this List<RelativeMonthlyRecurrencePattern> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RelativeMonthlyRecurrencePattern> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RelativeMonthlyRecurrencePattern> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RelativeMonthlyRecurrencePattern());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RelativeMonthlyRecurrencePattern> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types