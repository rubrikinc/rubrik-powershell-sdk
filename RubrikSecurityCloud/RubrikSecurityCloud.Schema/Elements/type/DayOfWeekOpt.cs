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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<DayOfWeekOpt> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DayOfWeekOpt> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DayOfWeekOpt> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DayOfWeekOpt());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DayOfWeekOpt> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types