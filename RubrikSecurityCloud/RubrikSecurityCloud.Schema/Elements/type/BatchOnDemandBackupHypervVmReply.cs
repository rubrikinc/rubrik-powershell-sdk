// BatchOnDemandBackupHypervVmReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:27.
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
    #region BatchOnDemandBackupHypervVmReply
    public class BatchOnDemandBackupHypervVmReply: IFragment
    {
        #region members
        //      C# -> List<HypervAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [HypervAsyncRequestFailureSummary!]! (type)
        [JsonProperty("failedRequests")]
        public List<HypervAsyncRequestFailureSummary>? FailedRequests { get; set; }

        //      C# -> List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [HypervAsyncRequestSuccessSummary!]! (type)
        [JsonProperty("successfulRequests")]
        public List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests { get; set; }

        #endregion

    #region methods

    public BatchOnDemandBackupHypervVmReply Set(
        List<HypervAsyncRequestFailureSummary>? FailedRequests = null,
        List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests = null
    ) 
    {
        if ( FailedRequests != null ) {
            this.FailedRequests = FailedRequests;
        }
        if ( SuccessfulRequests != null ) {
            this.SuccessfulRequests = SuccessfulRequests;
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
            //      C# -> List<HypervAsyncRequestFailureSummary>? FailedRequests
            // GraphQL -> failedRequests: [HypervAsyncRequestFailureSummary!]! (type)
            if (this.FailedRequests != null)
            {
                 s += ind + "failedRequests\n";

                 s += ind + "{\n" + 
                 this.FailedRequests.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests
            // GraphQL -> successfulRequests: [HypervAsyncRequestSuccessSummary!]! (type)
            if (this.SuccessfulRequests != null)
            {
                 s += ind + "successfulRequests\n";

                 s += ind + "{\n" + 
                 this.SuccessfulRequests.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<HypervAsyncRequestFailureSummary>? FailedRequests
            // GraphQL -> failedRequests: [HypervAsyncRequestFailureSummary!]! (type)
            if (this.FailedRequests == null && Exploration.Includes(parent + ".failedRequests"))
            {
                this.FailedRequests = new List<HypervAsyncRequestFailureSummary>();
                this.FailedRequests.ApplyExploratoryFragment(parent + ".failedRequests");
            }
            //      C# -> List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests
            // GraphQL -> successfulRequests: [HypervAsyncRequestSuccessSummary!]! (type)
            if (this.SuccessfulRequests == null && Exploration.Includes(parent + ".successfulRequests"))
            {
                this.SuccessfulRequests = new List<HypervAsyncRequestSuccessSummary>();
                this.SuccessfulRequests.ApplyExploratoryFragment(parent + ".successfulRequests");
            }
        }


    #endregion

    } // class BatchOnDemandBackupHypervVmReply
    #endregion

    public static class ListBatchOnDemandBackupHypervVmReplyExtensions
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
            this List<BatchOnDemandBackupHypervVmReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BatchOnDemandBackupHypervVmReply> list, 
            String parent = "")
        {
            var item = new BatchOnDemandBackupHypervVmReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types