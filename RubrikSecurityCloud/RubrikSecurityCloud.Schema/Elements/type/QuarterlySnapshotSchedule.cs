// QuarterlySnapshotSchedule.cs
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
    #region QuarterlySnapshotSchedule
    public class QuarterlySnapshotSchedule: BaseType
    {
        #region members

        //      C# -> DayOfQuarter? DayOfQuarter
        // GraphQL -> dayOfQuarter: DayOfQuarter! (enum)
        [JsonProperty("dayOfQuarter")]
        public DayOfQuarter? DayOfQuarter { get; set; }

        //      C# -> Month? QuarterStartMonth
        // GraphQL -> quarterStartMonth: Month! (enum)
        [JsonProperty("quarterStartMonth")]
        public Month? QuarterStartMonth { get; set; }

        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        [JsonProperty("basicSchedule")]
        public BasicSnapshotSchedule? BasicSchedule { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "QuarterlySnapshotSchedule";
    }

    public QuarterlySnapshotSchedule Set(
        DayOfQuarter? DayOfQuarter = null,
        Month? QuarterStartMonth = null,
        BasicSnapshotSchedule? BasicSchedule = null
    ) 
    {
        if ( DayOfQuarter != null ) {
            this.DayOfQuarter = DayOfQuarter;
        }
        if ( QuarterStartMonth != null ) {
            this.QuarterStartMonth = QuarterStartMonth;
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
        //      C# -> DayOfQuarter? DayOfQuarter
        // GraphQL -> dayOfQuarter: DayOfQuarter! (enum)
        if (this.DayOfQuarter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dayOfQuarter\n" ;
            } else {
                s += ind + "dayOfQuarter\n" ;
            }
        }
        //      C# -> Month? QuarterStartMonth
        // GraphQL -> quarterStartMonth: Month! (enum)
        if (this.QuarterStartMonth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "quarterStartMonth\n" ;
            } else {
                s += ind + "quarterStartMonth\n" ;
            }
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule != null) {
            var fspec = this.BasicSchedule.AsFieldSpec(conf.Child("basicSchedule"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "basicSchedule" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DayOfQuarter? DayOfQuarter
        // GraphQL -> dayOfQuarter: DayOfQuarter! (enum)
        if (ec.Includes("dayOfQuarter",true))
        {
            if(this.DayOfQuarter == null) {

                this.DayOfQuarter = new DayOfQuarter();

            } else {


            }
        }
        else if (this.DayOfQuarter != null && ec.Excludes("dayOfQuarter",true))
        {
            this.DayOfQuarter = null;
        }
        //      C# -> Month? QuarterStartMonth
        // GraphQL -> quarterStartMonth: Month! (enum)
        if (ec.Includes("quarterStartMonth",true))
        {
            if(this.QuarterStartMonth == null) {

                this.QuarterStartMonth = new Month();

            } else {


            }
        }
        else if (this.QuarterStartMonth != null && ec.Excludes("quarterStartMonth",true))
        {
            this.QuarterStartMonth = null;
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

    } // class QuarterlySnapshotSchedule
    
    #endregion

    public static class ListQuarterlySnapshotScheduleExtensions
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
            this List<QuarterlySnapshotSchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<QuarterlySnapshotSchedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<QuarterlySnapshotSchedule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new QuarterlySnapshotSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<QuarterlySnapshotSchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types