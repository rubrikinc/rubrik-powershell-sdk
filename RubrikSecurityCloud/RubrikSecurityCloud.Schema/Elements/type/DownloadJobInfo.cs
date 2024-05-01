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

    public override string GetGqlTypeName() {
        return "DownloadJobInfo";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (this.EventId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventId\n" ;
            } else {
                s += ind + "eventId\n" ;
            }
        }
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (this.JobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobInstanceId\n" ;
            } else {
                s += ind + "jobInstanceId\n" ;
            }
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> System.Int64? RemainingTimeEstimateInSeconds
        // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
        if (this.RemainingTimeEstimateInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remainingTimeEstimateInSeconds\n" ;
            } else {
                s += ind + "remainingTimeEstimateInSeconds\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        if (ec.Includes("eventId",true))
        {
            if(this.EventId == null) {

                this.EventId = "FETCH";

            } else {


            }
        }
        else if (this.EventId != null && ec.Excludes("eventId",true))
        {
            this.EventId = null;
        }
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (ec.Includes("jobInstanceId",true))
        {
            if(this.JobInstanceId == null) {

                this.JobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.JobInstanceId != null && ec.Excludes("jobInstanceId",true))
        {
            this.JobInstanceId = null;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Single();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> System.Int64? RemainingTimeEstimateInSeconds
        // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
        if (ec.Includes("remainingTimeEstimateInSeconds",true))
        {
            if(this.RemainingTimeEstimateInSeconds == null) {

                this.RemainingTimeEstimateInSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.RemainingTimeEstimateInSeconds != null && ec.Excludes("remainingTimeEstimateInSeconds",true))
        {
            this.RemainingTimeEstimateInSeconds = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class DownloadJobInfo
    
    #endregion

    public static class ListDownloadJobInfoExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<DownloadJobInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DownloadJobInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DownloadJobInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadJobInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DownloadJobInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types