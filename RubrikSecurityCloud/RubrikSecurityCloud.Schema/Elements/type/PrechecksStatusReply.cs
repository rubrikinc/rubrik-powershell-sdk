// PrechecksStatusReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region PrechecksStatusReply
    public class PrechecksStatusReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.Int32? NumPrechecks
            // GraphQL -> numPrechecks: Int! (scalar)
            if (this.NumPrechecks != null)
            {
                 s += ind + "numPrechecks\n";

            }
            //      C# -> System.Int32? RunPeriodInMinutes
            // GraphQL -> runPeriodInMinutes: Int! (scalar)
            if (this.RunPeriodInMinutes != null)
            {
                 s += ind + "runPeriodInMinutes\n";

            }
            //      C# -> List<PrecheckFailure>? FailureResults
            // GraphQL -> failureResults: [PrecheckFailure!]! (type)
            if (this.FailureResults != null)
            {
                 s += ind + "failureResults\n";

                 s += ind + "{\n" + 
                 this.FailureResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
            // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
            if (this.NextRunInfo != null)
            {
                 s += ind + "nextRunInfo\n";

                 s += ind + "{\n" + 
                 this.NextRunInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new System.Int64();
            }
            //      C# -> System.Int32? NumPrechecks
            // GraphQL -> numPrechecks: Int! (scalar)
            if (this.NumPrechecks == null && Exploration.Includes(parent + ".numPrechecks$"))
            {
                this.NumPrechecks = new System.Int32();
            }
            //      C# -> System.Int32? RunPeriodInMinutes
            // GraphQL -> runPeriodInMinutes: Int! (scalar)
            if (this.RunPeriodInMinutes == null && Exploration.Includes(parent + ".runPeriodInMinutes$"))
            {
                this.RunPeriodInMinutes = new System.Int32();
            }
            //      C# -> List<PrecheckFailure>? FailureResults
            // GraphQL -> failureResults: [PrecheckFailure!]! (type)
            if (this.FailureResults == null && Exploration.Includes(parent + ".failureResults"))
            {
                this.FailureResults = new List<PrecheckFailure>();
                this.FailureResults.ApplyExploratoryFragment(parent + ".failureResults");
            }
            //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
            // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
            if (this.NextRunInfo == null && Exploration.Includes(parent + ".nextRunInfo"))
            {
                this.NextRunInfo = new PrecheckStatusNextRunInfo();
                this.NextRunInfo.ApplyExploratoryFragment(parent + ".nextRunInfo");
            }
        }


    #endregion

    } // class PrechecksStatusReply
    #endregion

    public static class ListPrechecksStatusReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<PrechecksStatusReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PrechecksStatusReply> list, 
            String parent = "")
        {
            var item = new PrechecksStatusReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types