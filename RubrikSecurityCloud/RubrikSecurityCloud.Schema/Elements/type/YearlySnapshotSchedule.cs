// YearlySnapshotSchedule.cs
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
    #region YearlySnapshotSchedule
    public class YearlySnapshotSchedule: BaseType
    {
        #region members

        //      C# -> DayOfYear? DayOfYear
        // GraphQL -> dayOfYear: DayOfYear! (enum)
        [JsonProperty("dayOfYear")]
        public DayOfYear? DayOfYear { get; set; }

        //      C# -> Month? YearStartMonth
        // GraphQL -> yearStartMonth: Month! (enum)
        [JsonProperty("yearStartMonth")]
        public Month? YearStartMonth { get; set; }

        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        [JsonProperty("basicSchedule")]
        public BasicSnapshotSchedule? BasicSchedule { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "YearlySnapshotSchedule";
    }

    public YearlySnapshotSchedule Set(
        DayOfYear? DayOfYear = null,
        Month? YearStartMonth = null,
        BasicSnapshotSchedule? BasicSchedule = null
    ) 
    {
        if ( DayOfYear != null ) {
            this.DayOfYear = DayOfYear;
        }
        if ( YearStartMonth != null ) {
            this.YearStartMonth = YearStartMonth;
        }
        if ( BasicSchedule != null ) {
            this.BasicSchedule = BasicSchedule;
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
        //      C# -> DayOfYear? DayOfYear
        // GraphQL -> dayOfYear: DayOfYear! (enum)
        if (this.DayOfYear != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dayOfYear\n" ;
            } else {
                s += ind + "dayOfYear\n" ;
            }
        }
        //      C# -> Month? YearStartMonth
        // GraphQL -> yearStartMonth: Month! (enum)
        if (this.YearStartMonth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "yearStartMonth\n" ;
            } else {
                s += ind + "yearStartMonth\n" ;
            }
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule != null) {
            var fspec = this.BasicSchedule.AsFieldSpec(conf.Child("basicSchedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "basicSchedule {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DayOfYear? DayOfYear
        // GraphQL -> dayOfYear: DayOfYear! (enum)
        if (ec.Includes("dayOfYear",true))
        {
            if(this.DayOfYear == null) {

                this.DayOfYear = new DayOfYear();

            } else {


            }
        }
        else if (this.DayOfYear != null && ec.Excludes("dayOfYear",true))
        {
            this.DayOfYear = null;
        }
        //      C# -> Month? YearStartMonth
        // GraphQL -> yearStartMonth: Month! (enum)
        if (ec.Includes("yearStartMonth",true))
        {
            if(this.YearStartMonth == null) {

                this.YearStartMonth = new Month();

            } else {


            }
        }
        else if (this.YearStartMonth != null && ec.Excludes("yearStartMonth",true))
        {
            this.YearStartMonth = null;
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (ec.Includes("basicSchedule",false))
        {
            if(this.BasicSchedule == null) {

                this.BasicSchedule = new BasicSnapshotSchedule();
                this.BasicSchedule.ApplyExploratoryFieldSpec(ec.NewChild("basicSchedule"));

            } else {

                this.BasicSchedule.ApplyExploratoryFieldSpec(ec.NewChild("basicSchedule"));

            }
        }
        else if (this.BasicSchedule != null && ec.Excludes("basicSchedule",false))
        {
            this.BasicSchedule = null;
        }
    }


    #endregion

    } // class YearlySnapshotSchedule
    
    #endregion

    public static class ListYearlySnapshotScheduleExtensions
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
            this List<YearlySnapshotSchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<YearlySnapshotSchedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<YearlySnapshotSchedule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new YearlySnapshotSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<YearlySnapshotSchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types