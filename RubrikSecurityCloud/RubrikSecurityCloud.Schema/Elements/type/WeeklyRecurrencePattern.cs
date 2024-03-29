// WeeklyRecurrencePattern.cs
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
    #region WeeklyRecurrencePattern
    public class WeeklyRecurrencePattern: BaseType
    {
        #region members

        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        [JsonProperty("daysOfWeek")]
        public List<System.String>? DaysOfWeek { get; set; }

        //      C# -> System.String? FirstDayOfWeek
        // GraphQL -> firstDayOfWeek: String! (scalar)
        [JsonProperty("firstDayOfWeek")]
        public System.String? FirstDayOfWeek { get; set; }

        //      C# -> System.Int32? Interval
        // GraphQL -> interval: Int! (scalar)
        [JsonProperty("interval")]
        public System.Int32? Interval { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WeeklyRecurrencePattern";
    }

    public WeeklyRecurrencePattern Set(
        List<System.String>? DaysOfWeek = null,
        System.String? FirstDayOfWeek = null,
        System.Int32? Interval = null
    ) 
    {
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
        }
        if ( FirstDayOfWeek != null ) {
            this.FirstDayOfWeek = FirstDayOfWeek;
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
        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        if (this.DaysOfWeek != null) {
            if (conf.Flat) {
                s += conf.Prefix + "daysOfWeek\n" ;
            } else {
                s += ind + "daysOfWeek\n" ;
            }
        }
        //      C# -> System.String? FirstDayOfWeek
        // GraphQL -> firstDayOfWeek: String! (scalar)
        if (this.FirstDayOfWeek != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstDayOfWeek\n" ;
            } else {
                s += ind + "firstDayOfWeek\n" ;
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
        //      C# -> System.String? FirstDayOfWeek
        // GraphQL -> firstDayOfWeek: String! (scalar)
        if (ec.Includes("firstDayOfWeek",true))
        {
            if(this.FirstDayOfWeek == null) {

                this.FirstDayOfWeek = "FETCH";

            } else {


            }
        }
        else if (this.FirstDayOfWeek != null && ec.Excludes("firstDayOfWeek",true))
        {
            this.FirstDayOfWeek = null;
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

    } // class WeeklyRecurrencePattern
    
    #endregion

    public static class ListWeeklyRecurrencePatternExtensions
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
            this List<WeeklyRecurrencePattern> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<WeeklyRecurrencePattern> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WeeklyRecurrencePattern> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WeeklyRecurrencePattern());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WeeklyRecurrencePattern> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types