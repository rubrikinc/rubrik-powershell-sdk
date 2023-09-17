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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DayOfYear? DayOfYear
        // GraphQL -> dayOfYear: DayOfYear! (enum)
        if (this.DayOfYear != null) {
            s += ind + "dayOfYear\n" ;
        }
        //      C# -> Month? YearStartMonth
        // GraphQL -> yearStartMonth: Month! (enum)
        if (this.YearStartMonth != null) {
            s += ind + "yearStartMonth\n" ;
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule != null) {
            var fspec = this.BasicSchedule.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "basicSchedule {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DayOfYear? DayOfYear
        // GraphQL -> dayOfYear: DayOfYear! (enum)
        if (this.DayOfYear == null && ec.Includes("dayOfYear",true))
        {
            this.DayOfYear = new DayOfYear();
        }
        //      C# -> Month? YearStartMonth
        // GraphQL -> yearStartMonth: Month! (enum)
        if (this.YearStartMonth == null && ec.Includes("yearStartMonth",true))
        {
            this.YearStartMonth = new Month();
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule == null && ec.Includes("basicSchedule",false))
        {
            this.BasicSchedule = new BasicSnapshotSchedule();
            this.BasicSchedule.ApplyExploratoryFieldSpec(ec.NewChild("basicSchedule"));
        }
    }


    #endregion

    } // class YearlySnapshotSchedule
    
    #endregion

    public static class ListYearlySnapshotScheduleExtensions
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
            this List<YearlySnapshotSchedule> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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