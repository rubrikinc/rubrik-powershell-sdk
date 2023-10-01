// TimeRangeWithUnit.cs
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
    #region TimeRangeWithUnit
 
    public class TimeRangeWithUnit: BaseType, AnomalyResultGroupByInfo, CdmSnapshotGroupByInfo, ClusterGroupByInfo, ClusterMetricGroupByInfo, ManagedVolumeQueuedSnapshotGroupByInfo, MissedSnapshotGroupByInfo, MongoSnapshotGroupByInfo, MosaicSnapshotGroupByInfo, NfAnomalyResultGroupByInfo, PolarisSnapshotGroupByInfo, RansomwareResultGroupByInfo, SnappableGroupByInfo, TaskDetailGroupByInfo
    {
        #region members

        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        [JsonProperty("unit")]
        public TimeUnitEnum? Unit { get; set; }

        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        [JsonProperty("end")]
        public DateTime? End { get; set; }

        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        [JsonProperty("start")]
        public DateTime? Start { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TimeRangeWithUnit";
    }

    public TimeRangeWithUnit Set(
        TimeUnitEnum? Unit = null,
        DateTime? End = null,
        DateTime? Start = null
    ) 
    {
        if ( Unit != null ) {
            this.Unit = Unit;
        }
        if ( End != null ) {
            this.End = End;
        }
        if ( Start != null ) {
            this.Start = Start;
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
        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        if (this.Unit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unit\n" ;
            } else {
                s += ind + "unit\n" ;
            }
        }
        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        if (this.End != null) {
            if (conf.Flat) {
                s += conf.Prefix + "end\n" ;
            } else {
                s += ind + "end\n" ;
            }
        }
        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        if (this.Start != null) {
            if (conf.Flat) {
                s += conf.Prefix + "start\n" ;
            } else {
                s += ind + "start\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TimeUnitEnum? Unit
        // GraphQL -> unit: TimeUnitEnum! (enum)
        if (ec.Includes("unit",true))
        {
            if(this.Unit == null) {

                this.Unit = new TimeUnitEnum();

            } else {


            }
        }
        else if (this.Unit != null && ec.Excludes("unit",true))
        {
            this.Unit = null;
        }
        //      C# -> DateTime? End
        // GraphQL -> end: DateTime! (scalar)
        if (ec.Includes("end",true))
        {
            if(this.End == null) {

                this.End = new DateTime();

            } else {


            }
        }
        else if (this.End != null && ec.Excludes("end",true))
        {
            this.End = null;
        }
        //      C# -> DateTime? Start
        // GraphQL -> start: DateTime! (scalar)
        if (ec.Includes("start",true))
        {
            if(this.Start == null) {

                this.Start = new DateTime();

            } else {


            }
        }
        else if (this.Start != null && ec.Excludes("start",true))
        {
            this.Start = null;
        }
    }


    #endregion

    } // class TimeRangeWithUnit
    
    #endregion

    public static class ListTimeRangeWithUnitExtensions
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
            this List<TimeRangeWithUnit> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<TimeRangeWithUnit> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TimeRangeWithUnit> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TimeRangeWithUnit());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TimeRangeWithUnit> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types