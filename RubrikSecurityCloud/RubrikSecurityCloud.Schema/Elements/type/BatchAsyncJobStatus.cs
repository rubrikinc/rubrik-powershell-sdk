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

namespace Rubrik.SecurityCloud.Types
{
    #region BatchAsyncJobStatus
    public class BatchAsyncJobStatus: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<AsyncJobStatusJobError>? Errors
            // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
            if (this.Errors != null)
            {
                 s += ind + "errors\n";

                 s += ind + "{\n" + 
                 this.Errors.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AsyncJobStatusJobId>? JobIds
            // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
            if (this.JobIds != null)
            {
                 s += ind + "jobIds\n";

                 s += ind + "{\n" + 
                 this.JobIds.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<AsyncJobStatusJobError>? Errors
            // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
            if (this.Errors == null && Exploration.Includes(parent + ".errors"))
            {
                this.Errors = new List<AsyncJobStatusJobError>();
                this.Errors.ApplyExploratoryFragment(parent + ".errors");
            }
            //      C# -> List<AsyncJobStatusJobId>? JobIds
            // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
            if (this.JobIds == null && Exploration.Includes(parent + ".jobIds"))
            {
                this.JobIds = new List<AsyncJobStatusJobId>();
                this.JobIds.ApplyExploratoryFragment(parent + ".jobIds");
            }
        }


    #endregion

    } // class BatchAsyncJobStatus
    #endregion

    public static class ListBatchAsyncJobStatusExtensions
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
            this List<BatchAsyncJobStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BatchAsyncJobStatus> list, 
            String parent = "")
        {
            var item = new BatchAsyncJobStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types