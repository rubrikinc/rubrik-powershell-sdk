// BatchAsyncRequestStatus.cs
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
    #region BatchAsyncRequestStatus
    public class BatchAsyncRequestStatus: IFragment
    {
        #region members
        //      C# -> List<AsyncRequestStatus>? Responses
        // GraphQL -> responses: [AsyncRequestStatus!]! (type)
        [JsonProperty("responses")]
        public List<AsyncRequestStatus>? Responses { get; set; }

        #endregion

    #region methods

    public BatchAsyncRequestStatus Set(
        List<AsyncRequestStatus>? Responses = null
    ) 
    {
        if ( Responses != null ) {
            this.Responses = Responses;
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
            //      C# -> List<AsyncRequestStatus>? Responses
            // GraphQL -> responses: [AsyncRequestStatus!]! (type)
            if (this.Responses != null)
            {
                 s += ind + "responses\n";

                 s += ind + "{\n" + 
                 this.Responses.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<AsyncRequestStatus>? Responses
            // GraphQL -> responses: [AsyncRequestStatus!]! (type)
            if (this.Responses == null && Exploration.Includes(parent + ".responses"))
            {
                this.Responses = new List<AsyncRequestStatus>();
                this.Responses.ApplyExploratoryFragment(parent + ".responses");
            }
        }


    #endregion

    } // class BatchAsyncRequestStatus
    #endregion

    public static class ListBatchAsyncRequestStatusExtensions
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
            this List<BatchAsyncRequestStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BatchAsyncRequestStatus> list, 
            String parent = "")
        {
            var item = new BatchAsyncRequestStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types