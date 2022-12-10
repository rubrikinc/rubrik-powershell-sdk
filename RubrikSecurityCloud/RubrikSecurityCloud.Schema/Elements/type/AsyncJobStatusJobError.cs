// AsyncJobStatusJobError.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:14.
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
    #region AsyncJobStatusJobError
    public class AsyncJobStatusJobError: IFragment
    {
        #region members
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.String? RubrikObjectId
        // GraphQL -> rubrikObjectId: String! (scalar)
        [JsonProperty("rubrikObjectId")]
        public System.String? RubrikObjectId { get; set; }

        #endregion

    #region methods

    public AsyncJobStatusJobError Set(
        System.String? Error = null,
        System.String? RubrikObjectId = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( RubrikObjectId != null ) {
            this.RubrikObjectId = RubrikObjectId;
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
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error != null)
            {
                 s += ind + "error\n";

            }
            //      C# -> System.String? RubrikObjectId
            // GraphQL -> rubrikObjectId: String! (scalar)
            if (this.RubrikObjectId != null)
            {
                 s += ind + "rubrikObjectId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error == null && Exploration.Includes(parent + ".error$"))
            {
                this.Error = new System.String("FETCH");
            }
            //      C# -> System.String? RubrikObjectId
            // GraphQL -> rubrikObjectId: String! (scalar)
            if (this.RubrikObjectId == null && Exploration.Includes(parent + ".rubrikObjectId$"))
            {
                this.RubrikObjectId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AsyncJobStatusJobError
    #endregion

    public static class ListAsyncJobStatusJobErrorExtensions
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
            this List<AsyncJobStatusJobError> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AsyncJobStatusJobError> list, 
            String parent = "")
        {
            var item = new AsyncJobStatusJobError();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types