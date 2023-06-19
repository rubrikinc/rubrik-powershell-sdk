// DownloadJobInfo.cs
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
    #region DownloadJobInfo
    public class DownloadJobInfo: BaseType
    {
        #region members

        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        [JsonProperty("eventId")]
        public System.String? EventId { get; set; }

        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        [JsonProperty("jobInstanceId")]
        public System.String? JobInstanceId { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.Int64? RemainingTimeEstimateInSeconds
        // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
        [JsonProperty("remainingTimeEstimateInSeconds")]
        public System.Int64? RemainingTimeEstimateInSeconds { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public DownloadJobInfo Set(
        System.String? EventId = null,
        System.String? JobInstanceId = null,
        System.Single? Progress = null,
        System.Int64? RemainingTimeEstimateInSeconds = null,
        System.String? Status = null
    ) 
    {
        if ( EventId != null ) {
            this.EventId = EventId;
        }
        if ( JobInstanceId != null ) {
            this.JobInstanceId = JobInstanceId;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( RemainingTimeEstimateInSeconds != null ) {
            this.RemainingTimeEstimateInSeconds = RemainingTimeEstimateInSeconds;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId != null) {
            s += ind + "eventId\n" ;
        }
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (this.JobInstanceId != null) {
            s += ind + "jobInstanceId\n" ;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        //      C# -> System.Int64? RemainingTimeEstimateInSeconds
        // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
        if (this.RemainingTimeEstimateInSeconds != null) {
            s += ind + "remainingTimeEstimateInSeconds\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId == null && Exploration.Includes(parent + ".eventId", true))
        {
            this.EventId = "FETCH";
        }
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (this.JobInstanceId == null && Exploration.Includes(parent + ".jobInstanceId", true))
        {
            this.JobInstanceId = "FETCH";
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = new System.Single();
        }
        //      C# -> System.Int64? RemainingTimeEstimateInSeconds
        // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
        if (this.RemainingTimeEstimateInSeconds == null && Exploration.Includes(parent + ".remainingTimeEstimateInSeconds", true))
        {
            this.RemainingTimeEstimateInSeconds = new System.Int64();
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
    }


    #endregion

    } // class DownloadJobInfo
    
    #endregion

    public static class ListDownloadJobInfoExtensions
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
            this List<DownloadJobInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DownloadJobInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadJobInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types