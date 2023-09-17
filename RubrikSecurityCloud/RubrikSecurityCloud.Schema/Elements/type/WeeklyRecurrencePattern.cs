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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        if (this.DaysOfWeek != null) {
            s += ind + "daysOfWeek\n" ;
        }
        //      C# -> System.String? FirstDayOfWeek
        // GraphQL -> firstDayOfWeek: String! (scalar)
        if (this.FirstDayOfWeek != null) {
            s += ind + "firstDayOfWeek\n" ;
        }
        //      C# -> System.Int32? Interval
        // GraphQL -> interval: Int! (scalar)
        if (this.Interval != null) {
            s += ind + "interval\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        if (this.DaysOfWeek == null && ec.Includes("daysOfWeek",true))
        {
            this.DaysOfWeek = new List<System.String>();
        }
        //      C# -> System.String? FirstDayOfWeek
        // GraphQL -> firstDayOfWeek: String! (scalar)
        if (this.FirstDayOfWeek == null && ec.Includes("firstDayOfWeek",true))
        {
            this.FirstDayOfWeek = "FETCH";
        }
        //      C# -> System.Int32? Interval
        // GraphQL -> interval: Int! (scalar)
        if (this.Interval == null && ec.Includes("interval",true))
        {
            this.Interval = Int32.MinValue;
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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