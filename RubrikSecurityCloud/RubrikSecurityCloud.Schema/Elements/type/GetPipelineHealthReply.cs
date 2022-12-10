// GetPipelineHealthReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:38.
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
    #region GetPipelineHealthReply
    public class GetPipelineHealthReply: IFragment
    {
        #region members
        //      C# -> System.Int64? FailedAnalysis
        // GraphQL -> failedAnalysis: Long! (scalar)
        [JsonProperty("failedAnalysis")]
        public System.Int64? FailedAnalysis { get; set; }

        //      C# -> System.Int64? FailedBackup
        // GraphQL -> failedBackup: Long! (scalar)
        [JsonProperty("failedBackup")]
        public System.Int64? FailedBackup { get; set; }

        //      C# -> System.Int64? FailedIndexing
        // GraphQL -> failedIndexing: Long! (scalar)
        [JsonProperty("failedIndexing")]
        public System.Int64? FailedIndexing { get; set; }

        //      C# -> System.Int64? TotalAnalysis
        // GraphQL -> totalAnalysis: Long! (scalar)
        [JsonProperty("totalAnalysis")]
        public System.Int64? TotalAnalysis { get; set; }

        //      C# -> System.Int64? TotalBackup
        // GraphQL -> totalBackup: Long! (scalar)
        [JsonProperty("totalBackup")]
        public System.Int64? TotalBackup { get; set; }

        //      C# -> System.Int64? TotalIndexing
        // GraphQL -> totalIndexing: Long! (scalar)
        [JsonProperty("totalIndexing")]
        public System.Int64? TotalIndexing { get; set; }

        #endregion

    #region methods

    public GetPipelineHealthReply Set(
        System.Int64? FailedAnalysis = null,
        System.Int64? FailedBackup = null,
        System.Int64? FailedIndexing = null,
        System.Int64? TotalAnalysis = null,
        System.Int64? TotalBackup = null,
        System.Int64? TotalIndexing = null
    ) 
    {
        if ( FailedAnalysis != null ) {
            this.FailedAnalysis = FailedAnalysis;
        }
        if ( FailedBackup != null ) {
            this.FailedBackup = FailedBackup;
        }
        if ( FailedIndexing != null ) {
            this.FailedIndexing = FailedIndexing;
        }
        if ( TotalAnalysis != null ) {
            this.TotalAnalysis = TotalAnalysis;
        }
        if ( TotalBackup != null ) {
            this.TotalBackup = TotalBackup;
        }
        if ( TotalIndexing != null ) {
            this.TotalIndexing = TotalIndexing;
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
            //      C# -> System.Int64? FailedAnalysis
            // GraphQL -> failedAnalysis: Long! (scalar)
            if (this.FailedAnalysis != null)
            {
                 s += ind + "failedAnalysis\n";

            }
            //      C# -> System.Int64? FailedBackup
            // GraphQL -> failedBackup: Long! (scalar)
            if (this.FailedBackup != null)
            {
                 s += ind + "failedBackup\n";

            }
            //      C# -> System.Int64? FailedIndexing
            // GraphQL -> failedIndexing: Long! (scalar)
            if (this.FailedIndexing != null)
            {
                 s += ind + "failedIndexing\n";

            }
            //      C# -> System.Int64? TotalAnalysis
            // GraphQL -> totalAnalysis: Long! (scalar)
            if (this.TotalAnalysis != null)
            {
                 s += ind + "totalAnalysis\n";

            }
            //      C# -> System.Int64? TotalBackup
            // GraphQL -> totalBackup: Long! (scalar)
            if (this.TotalBackup != null)
            {
                 s += ind + "totalBackup\n";

            }
            //      C# -> System.Int64? TotalIndexing
            // GraphQL -> totalIndexing: Long! (scalar)
            if (this.TotalIndexing != null)
            {
                 s += ind + "totalIndexing\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? FailedAnalysis
            // GraphQL -> failedAnalysis: Long! (scalar)
            if (this.FailedAnalysis == null && Exploration.Includes(parent + ".failedAnalysis$"))
            {
                this.FailedAnalysis = new System.Int64();
            }
            //      C# -> System.Int64? FailedBackup
            // GraphQL -> failedBackup: Long! (scalar)
            if (this.FailedBackup == null && Exploration.Includes(parent + ".failedBackup$"))
            {
                this.FailedBackup = new System.Int64();
            }
            //      C# -> System.Int64? FailedIndexing
            // GraphQL -> failedIndexing: Long! (scalar)
            if (this.FailedIndexing == null && Exploration.Includes(parent + ".failedIndexing$"))
            {
                this.FailedIndexing = new System.Int64();
            }
            //      C# -> System.Int64? TotalAnalysis
            // GraphQL -> totalAnalysis: Long! (scalar)
            if (this.TotalAnalysis == null && Exploration.Includes(parent + ".totalAnalysis$"))
            {
                this.TotalAnalysis = new System.Int64();
            }
            //      C# -> System.Int64? TotalBackup
            // GraphQL -> totalBackup: Long! (scalar)
            if (this.TotalBackup == null && Exploration.Includes(parent + ".totalBackup$"))
            {
                this.TotalBackup = new System.Int64();
            }
            //      C# -> System.Int64? TotalIndexing
            // GraphQL -> totalIndexing: Long! (scalar)
            if (this.TotalIndexing == null && Exploration.Includes(parent + ".totalIndexing$"))
            {
                this.TotalIndexing = new System.Int64();
            }
        }


    #endregion

    } // class GetPipelineHealthReply
    #endregion

    public static class ListGetPipelineHealthReplyExtensions
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
            this List<GetPipelineHealthReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetPipelineHealthReply> list, 
            String parent = "")
        {
            var item = new GetPipelineHealthReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types