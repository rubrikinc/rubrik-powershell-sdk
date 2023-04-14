// NutanixBatchAsyncApiResponse.cs
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
    #region NutanixBatchAsyncApiResponse
    public class NutanixBatchAsyncApiResponse: IFragment
    {
        #region members
        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        [JsonProperty("failedRequests")]
        public List<NutanixAsyncRequestFailureSummary>? FailedRequests { get; set; }

        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        [JsonProperty("successfulRequests")]
        public List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests { get; set; }

        #endregion

    #region methods

    public NutanixBatchAsyncApiResponse Set(
        List<NutanixAsyncRequestFailureSummary>? FailedRequests = null,
        List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests = null
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
            //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
            // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
            if (this.FailedRequests != null)
            {
                 s += ind + "failedRequests\n";

                 s += ind + "{\n" + 
                 this.FailedRequests.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
            // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
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
            //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
            // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
            if (this.FailedRequests == null && Exploration.Includes(parent + ".failedRequests"))
            {
                this.FailedRequests = new List<NutanixAsyncRequestFailureSummary>();
                this.FailedRequests.ApplyExploratoryFragment(parent + ".failedRequests");
            }
            //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
            // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
            if (this.SuccessfulRequests == null && Exploration.Includes(parent + ".successfulRequests"))
            {
                this.SuccessfulRequests = new List<NutanixAsyncRequestSuccessSummary>();
                this.SuccessfulRequests.ApplyExploratoryFragment(parent + ".successfulRequests");
            }
        }


    #endregion

    } // class NutanixBatchAsyncApiResponse
    #endregion

    public static class ListNutanixBatchAsyncApiResponseExtensions
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
            this List<NutanixBatchAsyncApiResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NutanixBatchAsyncApiResponse> list, 
            String parent = "")
        {
            var item = new NutanixBatchAsyncApiResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types