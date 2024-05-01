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

    } // class AbsoluteYearlyRecurrencePattern
    
    #endregion

    public static class ListAbsoluteYearlyRecurrencePatternExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AbsoluteYearlyRecurrencePattern> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AbsoluteYearlyRecurrencePattern> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<AbsoluteYearlyRecurrencePattern> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types