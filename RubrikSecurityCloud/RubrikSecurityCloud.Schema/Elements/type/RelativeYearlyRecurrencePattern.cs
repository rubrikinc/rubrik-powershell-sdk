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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? DayOfWeekIndex
        // GraphQL -> dayOfWeekIndex: String! (scalar)
        if (this.DayOfWeekIndex != null) {
            s += ind + "dayOfWeekIndex\n" ;
        }
        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        if (this.DaysOfWeek != null) {
            s += ind + "daysOfWeek\n" ;
        }
        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        if (this.Month != null) {
            s += ind + "month\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DayOfWeekIndex
        // GraphQL -> dayOfWeekIndex: String! (scalar)
        if (this.DayOfWeekIndex == null && Exploration.Includes(parent + ".dayOfWeekIndex", true))
        {
            this.DayOfWeekIndex = "FETCH";
        }
        //      C# -> List<System.String>? DaysOfWeek
        // GraphQL -> daysOfWeek: [String!]! (scalar)
        if (this.DaysOfWeek == null && Exploration.Includes(parent + ".daysOfWeek", true))
        {
            this.DaysOfWeek = new List<System.String>();
        }
        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        if (this.Month == null && Exploration.Includes(parent + ".month", true))
        {
            this.Month = "FETCH";
        }
    }


    #endregion

    } // class RelativeYearlyRecurrencePattern
    
    #endregion

    public static class ListRelativeYearlyRecurrencePatternExtensions
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
            this List<RelativeYearlyRecurrencePattern> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RelativeYearlyRecurrencePattern> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RelativeYearlyRecurrencePattern());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types