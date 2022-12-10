// FilesetSnapshotSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:33.
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
    #region FilesetSnapshotSummary
    public class FilesetSnapshotSummary: IFragment
    {
        #region members
        //      C# -> System.Int64? ErrorsCollected
        // GraphQL -> errorsCollected: Long (scalar)
        [JsonProperty("errorsCollected")]
        public System.Int64? ErrorsCollected { get; set; }

        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long (scalar)
        [JsonProperty("fileCount")]
        public System.Int64? FileCount { get; set; }

        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        [JsonProperty("filesetName")]
        public System.String? FilesetName { get; set; }

        //      C# -> System.Boolean? SnapdiffUsed
        // GraphQL -> snapdiffUsed: Boolean (scalar)
        [JsonProperty("snapdiffUsed")]
        public System.Boolean? SnapdiffUsed { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }

        #endregion

    #region methods

    public FilesetSnapshotSummary Set(
        System.Int64? ErrorsCollected = null,
        System.Int64? FileCount = null,
        System.String? FilesetName = null,
        System.Boolean? SnapdiffUsed = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( ErrorsCollected != null ) {
            this.ErrorsCollected = ErrorsCollected;
        }
        if ( FileCount != null ) {
            this.FileCount = FileCount;
        }
        if ( FilesetName != null ) {
            this.FilesetName = FilesetName;
        }
        if ( SnapdiffUsed != null ) {
            this.SnapdiffUsed = SnapdiffUsed;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
            //      C# -> System.Int64? ErrorsCollected
            // GraphQL -> errorsCollected: Long (scalar)
            if (this.ErrorsCollected != null)
            {
                 s += ind + "errorsCollected\n";

            }
            //      C# -> System.Int64? FileCount
            // GraphQL -> fileCount: Long (scalar)
            if (this.FileCount != null)
            {
                 s += ind + "fileCount\n";

            }
            //      C# -> System.String? FilesetName
            // GraphQL -> filesetName: String! (scalar)
            if (this.FilesetName != null)
            {
                 s += ind + "filesetName\n";

            }
            //      C# -> System.Boolean? SnapdiffUsed
            // GraphQL -> snapdiffUsed: Boolean (scalar)
            if (this.SnapdiffUsed != null)
            {
                 s += ind + "snapdiffUsed\n";

            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary != null)
            {
                 s += ind + "baseSnapshotSummary\n";

                 s += ind + "{\n" + 
                 this.BaseSnapshotSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ErrorsCollected
            // GraphQL -> errorsCollected: Long (scalar)
            if (this.ErrorsCollected == null && Exploration.Includes(parent + ".errorsCollected$"))
            {
                this.ErrorsCollected = new System.Int64();
            }
            //      C# -> System.Int64? FileCount
            // GraphQL -> fileCount: Long (scalar)
            if (this.FileCount == null && Exploration.Includes(parent + ".fileCount$"))
            {
                this.FileCount = new System.Int64();
            }
            //      C# -> System.String? FilesetName
            // GraphQL -> filesetName: String! (scalar)
            if (this.FilesetName == null && Exploration.Includes(parent + ".filesetName$"))
            {
                this.FilesetName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SnapdiffUsed
            // GraphQL -> snapdiffUsed: Boolean (scalar)
            if (this.SnapdiffUsed == null && Exploration.Includes(parent + ".snapdiffUsed$"))
            {
                this.SnapdiffUsed = new System.Boolean();
            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
            {
                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFragment(parent + ".baseSnapshotSummary");
            }
        }


    #endregion

    } // class FilesetSnapshotSummary
    #endregion

    public static class ListFilesetSnapshotSummaryExtensions
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
            this List<FilesetSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetSnapshotSummary> list, 
            String parent = "")
        {
            var item = new FilesetSnapshotSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types