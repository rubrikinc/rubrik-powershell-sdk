// AbsoluteMonthlyRecurrencePattern.cs
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
    #region AbsoluteMonthlyRecurrencePattern
    public class AbsoluteMonthlyRecurrencePattern: BaseType
    {
        #region members

        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int! (scalar)
        [JsonProperty("dayOfMonth")]
        public System.Int32? DayOfMonth { get; set; }

        //      C# -> System.Int32? Interval
        // GraphQL -> interval: Int! (scalar)
        [JsonProperty("interval")]
        public System.Int32? Interval { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AbsoluteMonthlyRecurrencePattern";
    }

    public AbsoluteMonthlyRecurrencePattern Set(
        System.Int32? DayOfMonth = null,
        System.Int32? Interval = null
    ) 
    {
        if ( DayOfMonth != null ) {
            this.DayOfMonth = DayOfMonth;
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
        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int! (scalar)
        if (this.DayOfMonth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dayOfMonth\n" ;
            } else {
                s += ind + "dayOfMonth\n" ;
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
        //      C# -> System.Int32? DayOfMonth
        // GraphQL -> dayOfMonth: Int! (scalar)
        if (ec.Includes("dayOfMonth",true))
        {
            if(this.DayOfMonth == null) {

                this.DayOfMonth = Int32.MinValue;

            } else {


            }
        }
        else if (this.DayOfMonth != null && ec.Excludes("dayOfMonth",true))
        {
            this.DayOfMonth = null;
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

    } // class AbsoluteMonthlyRecurrencePattern
    
    #endregion

    public static class ListAbsoluteMonthlyRecurrencePatternExtensions
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
            this List<AbsoluteMonthlyRecurrencePattern> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AbsoluteMonthlyRecurrencePattern> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AbsoluteMonthlyRecurrencePattern());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AbsoluteMonthlyRecurrencePattern> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types