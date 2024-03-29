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
                    s += ind + "workloadTypeToFailureCount {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "workloadTypeToWarningCount {\n" + fspec + ind + "}\n" ;
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
            this List<FailuresAndWarningsStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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