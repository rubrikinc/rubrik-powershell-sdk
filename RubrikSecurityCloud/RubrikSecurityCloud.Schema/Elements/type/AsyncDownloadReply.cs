// AsyncDownloadReply.cs
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
    #region AsyncDownloadReply
    public class AsyncDownloadReply: IFragment
    {
        #region members
        //      C# -> System.Int64? DownloadId
        // GraphQL -> downloadId: Long! (scalar)
        [JsonProperty("downloadId")]
        public System.Int64? DownloadId { get; set; }

        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        [JsonProperty("jobId")]
        public System.Int64? JobId { get; set; }

        //      C# -> System.String? ReferenceId
        // GraphQL -> referenceId: String! (scalar)
        [JsonProperty("referenceId")]
        public System.String? ReferenceId { get; set; }

        #endregion

    #region methods

    public AsyncDownloadReply Set(
        System.Int64? DownloadId = null,
        System.Int64? JobId = null,
        System.String? ReferenceId = null
    ) 
    {
        if ( DownloadId != null ) {
            this.DownloadId = DownloadId;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( ReferenceId != null ) {
            this.ReferenceId = ReferenceId;
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
            //      C# -> System.Int64? DownloadId
            // GraphQL -> downloadId: Long! (scalar)
            if (this.DownloadId != null)
            {
                 s += ind + "downloadId\n";

            }
            //      C# -> System.Int64? JobId
            // GraphQL -> jobId: Long! (scalar)
            if (this.JobId != null)
            {
                 s += ind + "jobId\n";

            }
            //      C# -> System.String? ReferenceId
            // GraphQL -> referenceId: String! (scalar)
            if (this.ReferenceId != null)
            {
                 s += ind + "referenceId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? DownloadId
            // GraphQL -> downloadId: Long! (scalar)
            if (this.DownloadId == null && Exploration.Includes(parent + ".downloadId$"))
            {
                this.DownloadId = new System.Int64();
            }
            //      C# -> System.Int64? JobId
            // GraphQL -> jobId: Long! (scalar)
            if (this.JobId == null && Exploration.Includes(parent + ".jobId$"))
            {
                this.JobId = new System.Int64();
            }
            //      C# -> System.String? ReferenceId
            // GraphQL -> referenceId: String! (scalar)
            if (this.ReferenceId == null && Exploration.Includes(parent + ".referenceId$"))
            {
                this.ReferenceId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AsyncDownloadReply
    #endregion

    public static class ListAsyncDownloadReplyExtensions
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
            this List<AsyncDownloadReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AsyncDownloadReply> list, 
            String parent = "")
        {
            var item = new AsyncDownloadReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types