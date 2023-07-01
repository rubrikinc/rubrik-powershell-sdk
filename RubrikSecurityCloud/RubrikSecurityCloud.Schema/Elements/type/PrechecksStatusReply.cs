// PrechecksStatusReply.cs
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
    #region PrechecksStatusReply
    public class PrechecksStatusReply: BaseType
    {
        #region members

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? NumPrechecks
        // GraphQL -> numPrechecks: Int! (scalar)
        [JsonProperty("numPrechecks")]
        public System.Int32? NumPrechecks { get; set; }

        //      C# -> System.Int32? RunPeriodInMinutes
        // GraphQL -> runPeriodInMinutes: Int! (scalar)
        [JsonProperty("runPeriodInMinutes")]
        public System.Int32? RunPeriodInMinutes { get; set; }

        //      C# -> List<PrecheckFailure>? FailureResults
        // GraphQL -> failureResults: [PrecheckFailure!]! (type)
        [JsonProperty("failureResults")]
        public List<PrecheckFailure>? FailureResults { get; set; }

        //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
        // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
        [JsonProperty("nextRunInfo")]
        public PrecheckStatusNextRunInfo? NextRunInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrechecksStatusReply";
    }

    public PrechecksStatusReply Set(
        System.Int64? EndTime = null,
        System.Int32? NumPrechecks = null,
        System.Int32? RunPeriodInMinutes = null,
        List<PrecheckFailure>? FailureResults = null,
        PrecheckStatusNextRunInfo? NextRunInfo = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( NumPrechecks != null ) {
            this.NumPrechecks = NumPrechecks;
        }
        if ( RunPeriodInMinutes != null ) {
            this.RunPeriodInMinutes = RunPeriodInMinutes;
        }
        if ( FailureResults != null ) {
            this.FailureResults = FailureResults;
        }
        if ( NextRunInfo != null ) {
            this.NextRunInfo = NextRunInfo;
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
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Int32? NumPrechecks
        // GraphQL -> numPrechecks: Int! (scalar)
        if (this.NumPrechecks != null) {
            s += ind + "numPrechecks\n" ;
        }
        //      C# -> System.Int32? RunPeriodInMinutes
        // GraphQL -> runPeriodInMinutes: Int! (scalar)
        if (this.RunPeriodInMinutes != null) {
            s += ind + "runPeriodInMinutes\n" ;
        }
        //      C# -> List<PrecheckFailure>? FailureResults
        // GraphQL -> failureResults: [PrecheckFailure!]! (type)
        if (this.FailureResults != null) {
            var fspec = this.FailureResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failureResults {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
        // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
        if (this.NextRunInfo != null) {
            var fspec = this.NextRunInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nextRunInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.Int32? NumPrechecks
        // GraphQL -> numPrechecks: Int! (scalar)
        if (this.NumPrechecks == null && Exploration.Includes(parent + ".numPrechecks", true))
        {
            this.NumPrechecks = Int32.MinValue;
        }
        //      C# -> System.Int32? RunPeriodInMinutes
        // GraphQL -> runPeriodInMinutes: Int! (scalar)
        if (this.RunPeriodInMinutes == null && Exploration.Includes(parent + ".runPeriodInMinutes", true))
        {
            this.RunPeriodInMinutes = Int32.MinValue;
        }
        //      C# -> List<PrecheckFailure>? FailureResults
        // GraphQL -> failureResults: [PrecheckFailure!]! (type)
        if (this.FailureResults == null && Exploration.Includes(parent + ".failureResults"))
        {
            this.FailureResults = new List<PrecheckFailure>();
            this.FailureResults.ApplyExploratoryFieldSpec(parent + ".failureResults");
        }
        //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
        // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
        if (this.NextRunInfo == null && Exploration.Includes(parent + ".nextRunInfo"))
        {
            this.NextRunInfo = new PrecheckStatusNextRunInfo();
            this.NextRunInfo.ApplyExploratoryFieldSpec(parent + ".nextRunInfo");
        }
    }


    #endregion

    } // class PrechecksStatusReply
    
    #endregion

    public static class ListPrechecksStatusReplyExtensions
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
            this List<PrechecksStatusReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrechecksStatusReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrechecksStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types