// DayOfWeekOpt.cs
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
    #region DayOfWeekOpt
    public class DayOfWeekOpt: BaseType
    {
        #region members

        //      C# -> DayOfWeek? Day
        // GraphQL -> day: DayOfWeek! (enum)
        [JsonProperty("day")]
        public DayOfWeek? Day { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DayOfWeekOpt";
    }

    public DayOfWeekOpt Set(
        DayOfWeek? Day = null
    ) 
    {
        if ( Day != null ) {
            this.Day = Day;
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
        //      C# -> DayOfWeek? Day
        // GraphQL -> day: DayOfWeek! (enum)
        if (this.Day != null) {
            if (conf.Flat) {
                s += conf.Prefix + "day\n" ;
            } else {
                s += ind + "day\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DayOfWeek? Day
        // GraphQL -> day: DayOfWeek! (enum)
        if (ec.Includes("day",true))
        {
            if(this.Day == null) {

                this.Day = new DayOfWeek();

            } else {


            }
        }
        else if (this.Day != null && ec.Excludes("day",true))
        {
            this.Day = null;
        }
    }


    #endregion

    } // class DayOfWeekOpt
    
    #endregion

    public static class ListDayOfWeekOptExtensions
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
            this List<DayOfWeekOpt> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DayOfWeekOpt> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DayOfWeekOpt());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DayOfWeekOpt> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types