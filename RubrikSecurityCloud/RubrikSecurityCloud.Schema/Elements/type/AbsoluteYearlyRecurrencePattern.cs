// AbsoluteYearlyRecurrencePattern.cs
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
    #region AbsoluteYearlyRecurrencePattern
    public class AbsoluteYearlyRecurrencePattern: BaseType
    {
        #region members

        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int! (scalar)
        [JsonProperty("dayOfMonth")]
        public System.Int32? DayOfMonth { get; set; }

        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        [JsonProperty("month")]
        public System.String? Month { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AbsoluteYearlyRecurrencePattern";
    }

    public AbsoluteYearlyRecurrencePattern Set(
        System.Int32? DayOfMonth = null,
        System.String? Month = null
    ) 
    {
        if ( DayOfMonth != null ) {
            this.DayOfMonth = DayOfMonth;
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
        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int! (scalar)
        if (this.DayOfMonth != null) {
            s += ind + "dayOfMonth\n" ;
        }
        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        if (this.Month != null) {
            s += ind + "month\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int! (scalar)
        if (this.DayOfMonth == null && ec.Includes("dayOfMonth",true))
        {
            this.DayOfMonth = Int32.MinValue;
        }
        //      C# -> System.String? Month
        // GraphQL -> month: String! (scalar)
        if (this.Month == null && ec.Includes("month",true))
        {
            this.Month = "FETCH";
        }
    }


    #endregion

    } // class AbsoluteYearlyRecurrencePattern
    
    #endregion

    public static class ListAbsoluteYearlyRecurrencePatternExtensions
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
            this List<AbsoluteYearlyRecurrencePattern> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AbsoluteYearlyRecurrencePattern> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AbsoluteYearlyRecurrencePattern());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AbsoluteYearlyRecurrencePattern> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types