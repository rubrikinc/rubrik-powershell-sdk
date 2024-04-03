// FailuresAndWarningsStats.cs
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
    #region FailuresAndWarningsStats
    public class FailuresAndWarningsStats: BaseType
    {
        #region members

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> List<WorkloadTypeToEventCount>? WorkloadTypeToFailureCount
        // GraphQL -> workloadTypeToFailureCount: [WorkloadTypeToEventCount!]! (type)
        [JsonProperty("workloadTypeToFailureCount")]
        public List<WorkloadTypeToEventCount>? WorkloadTypeToFailureCount { get; set; }

        //      C# -> List<WorkloadTypeToEventCount>? WorkloadTypeToWarningCount
        // GraphQL -> workloadTypeToWarningCount: [WorkloadTypeToEventCount!]! (type)
        [JsonProperty("workloadTypeToWarningCount")]
        public List<WorkloadTypeToEventCount>? WorkloadTypeToWarningCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailuresAndWarningsStats";
    }

    public FailuresAndWarningsStats Set(
        DateTime? EndTime = null,
        DateTime? StartTime = null,
        List<WorkloadTypeToEventCount>? WorkloadTypeToFailureCount = null,
        List<WorkloadTypeToEventCount>? WorkloadTypeToWarningCount = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( WorkloadTypeToFailureCount != null ) {
            this.WorkloadTypeToFailureCount = WorkloadTypeToFailureCount;
        }
        if ( WorkloadTypeToWarningCount != null ) {
            this.WorkloadTypeToWarningCount = WorkloadTypeToWarningCount;
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
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> List<WorkloadTypeToEventCount>? WorkloadTypeToFailureCount
        // GraphQL -> workloadTypeToFailureCount: [WorkloadTypeToEventCount!]! (type)
        if (this.WorkloadTypeToFailureCount != null) {
            var fspec = this.WorkloadTypeToFailureCount.AsFieldSpec(conf.Child("workloadTypeToFailureCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadTypeToFailureCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WorkloadTypeToEventCount>? WorkloadTypeToWarningCount
        // GraphQL -> workloadTypeToWarningCount: [WorkloadTypeToEventCount!]! (type)
        if (this.WorkloadTypeToWarningCount != null) {
            var fspec = this.WorkloadTypeToWarningCount.AsFieldSpec(conf.Child("workloadTypeToWarningCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadTypeToWarningCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> List<WorkloadTypeToEventCount>? WorkloadTypeToFailureCount
        // GraphQL -> workloadTypeToFailureCount: [WorkloadTypeToEventCount!]! (type)
        if (ec.Includes("workloadTypeToFailureCount",false))
        {
            if(this.WorkloadTypeToFailureCount == null) {

                this.WorkloadTypeToFailureCount = new List<WorkloadTypeToEventCount>();
                this.WorkloadTypeToFailureCount.ApplyExploratoryFieldSpec(ec.NewChild("workloadTypeToFailureCount"));

            } else {

                this.WorkloadTypeToFailureCount.ApplyExploratoryFieldSpec(ec.NewChild("workloadTypeToFailureCount"));

            }
        }
        else if (this.WorkloadTypeToFailureCount != null && ec.Excludes("workloadTypeToFailureCount",false))
        {
            this.WorkloadTypeToFailureCount = null;
        }
        //      C# -> List<WorkloadTypeToEventCount>? WorkloadTypeToWarningCount
        // GraphQL -> workloadTypeToWarningCount: [WorkloadTypeToEventCount!]! (type)
        if (ec.Includes("workloadTypeToWarningCount",false))
        {
            if(this.WorkloadTypeToWarningCount == null) {

                this.WorkloadTypeToWarningCount = new List<WorkloadTypeToEventCount>();
                this.WorkloadTypeToWarningCount.ApplyExploratoryFieldSpec(ec.NewChild("workloadTypeToWarningCount"));

            } else {

                this.WorkloadTypeToWarningCount.ApplyExploratoryFieldSpec(ec.NewChild("workloadTypeToWarningCount"));

            }
        }
        else if (this.WorkloadTypeToWarningCount != null && ec.Excludes("workloadTypeToWarningCount",false))
        {
            this.WorkloadTypeToWarningCount = null;
        }
    }


    #endregion

    } // class FailuresAndWarningsStats
    
    #endregion

    public static class ListFailuresAndWarningsStatsExtensions
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
            this List<FailuresAndWarningsStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FailuresAndWarningsStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailuresAndWarningsStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailuresAndWarningsStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailuresAndWarningsStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types