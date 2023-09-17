// BatchAsyncJobStatus.cs
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
    #region BatchAsyncJobStatus
    public class BatchAsyncJobStatus: BaseType
    {
        #region members

        //      C# -> List<AsyncJobStatusJobError>? Errors
        // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
        [JsonProperty("errors")]
        public List<AsyncJobStatusJobError>? Errors { get; set; }

        //      C# -> List<AsyncJobStatusJobId>? JobIds
        // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
        [JsonProperty("jobIds")]
        public List<AsyncJobStatusJobId>? JobIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BatchAsyncJobStatus";
    }

    public BatchAsyncJobStatus Set(
        List<AsyncJobStatusJobError>? Errors = null,
        List<AsyncJobStatusJobId>? JobIds = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( JobIds != null ) {
            this.JobIds = JobIds;
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
        //      C# -> List<AsyncJobStatusJobError>? Errors
        // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "errors {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AsyncJobStatusJobId>? JobIds
        // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
        if (this.JobIds != null) {
            var fspec = this.JobIds.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "jobIds {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AsyncJobStatusJobError>? Errors
        // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
        if (this.Errors == null && ec.Includes("errors",false))
        {
            this.Errors = new List<AsyncJobStatusJobError>();
            this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));
        }
        //      C# -> List<AsyncJobStatusJobId>? JobIds
        // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
        if (this.JobIds == null && ec.Includes("jobIds",false))
        {
            this.JobIds = new List<AsyncJobStatusJobId>();
            this.JobIds.ApplyExploratoryFieldSpec(ec.NewChild("jobIds"));
        }
    }


    #endregion

    } // class BatchAsyncJobStatus
    
    #endregion

    public static class ListBatchAsyncJobStatusExtensions
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
            this List<BatchAsyncJobStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BatchAsyncJobStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchAsyncJobStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BatchAsyncJobStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types