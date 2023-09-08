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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region NutanixBatchAsyncApiResponse
    public class NutanixBatchAsyncApiResponse: BaseType
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

    public override string GetGqlTypeName() {
        return "NutanixBatchAsyncApiResponse";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        if (this.FailedRequests != null) {
            var fspec = this.FailedRequests.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failedRequests {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        if (this.SuccessfulRequests != null) {
            var fspec = this.SuccessfulRequests.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "successfulRequests {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        if (this.FailedRequests == null && ec.Includes("failedRequests",false))
        {
            this.FailedRequests = new List<NutanixAsyncRequestFailureSummary>();
            this.FailedRequests.ApplyExploratoryFieldSpec(ec.NewChild("failedRequests"));
        }
        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        if (this.SuccessfulRequests == null && ec.Includes("successfulRequests",false))
        {
            this.SuccessfulRequests = new List<NutanixAsyncRequestSuccessSummary>();
            this.SuccessfulRequests.ApplyExploratoryFieldSpec(ec.NewChild("successfulRequests"));
        }
    }


    #endregion

    } // class NutanixBatchAsyncApiResponse
    
    #endregion

    public static class ListNutanixBatchAsyncApiResponseExtensions
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
            this List<NutanixBatchAsyncApiResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixBatchAsyncApiResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixBatchAsyncApiResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NutanixBatchAsyncApiResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types