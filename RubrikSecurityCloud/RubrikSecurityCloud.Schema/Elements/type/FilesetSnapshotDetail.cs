// FilesetSnapshotDetail.cs
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
    #region FilesetSnapshotDetail
    public class FilesetSnapshotDetail: IFragment
    {
        #region members
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String! (scalar)
        [JsonProperty("lastModified")]
        public System.String? LastModified { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
        // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
        [JsonProperty("filesetSnapshotSummary")]
        public FilesetSnapshotSummary? FilesetSnapshotSummary { get; set; }

        //      C# -> FilesetSnapshotVerbose? Verbose
        // GraphQL -> verbose: FilesetSnapshotVerbose (type)
        [JsonProperty("verbose")]
        public FilesetSnapshotVerbose? Verbose { get; set; }

        #endregion

    #region methods

    public FilesetSnapshotDetail Set(
        System.String? LastModified = null,
        System.Int64? Size = null,
        FilesetSnapshotSummary? FilesetSnapshotSummary = null,
        FilesetSnapshotVerbose? Verbose = null
    ) 
    {
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( FilesetSnapshotSummary != null ) {
            this.FilesetSnapshotSummary = FilesetSnapshotSummary;
        }
        if ( Verbose != null ) {
            this.Verbose = Verbose;
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
            //      C# -> System.String? LastModified
            // GraphQL -> lastModified: String! (scalar)
            if (this.LastModified != null)
            {
                 s += ind + "lastModified\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
            // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
            if (this.FilesetSnapshotSummary != null)
            {
                 s += ind + "filesetSnapshotSummary\n";

                 s += ind + "{\n" + 
                 this.FilesetSnapshotSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FilesetSnapshotVerbose? Verbose
            // GraphQL -> verbose: FilesetSnapshotVerbose (type)
            if (this.Verbose != null)
            {
                 s += ind + "verbose\n";

                 s += ind + "{\n" + 
                 this.Verbose.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? LastModified
            // GraphQL -> lastModified: String! (scalar)
            if (this.LastModified == null && Exploration.Includes(parent + ".lastModified$"))
            {
                this.LastModified = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
            // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
            if (this.FilesetSnapshotSummary == null && Exploration.Includes(parent + ".filesetSnapshotSummary"))
            {
                this.FilesetSnapshotSummary = new FilesetSnapshotSummary();
                this.FilesetSnapshotSummary.ApplyExploratoryFragment(parent + ".filesetSnapshotSummary");
            }
            //      C# -> FilesetSnapshotVerbose? Verbose
            // GraphQL -> verbose: FilesetSnapshotVerbose (type)
            if (this.Verbose == null && Exploration.Includes(parent + ".verbose"))
            {
                this.Verbose = new FilesetSnapshotVerbose();
                this.Verbose.ApplyExploratoryFragment(parent + ".verbose");
            }
        }


    #endregion

    } // class FilesetSnapshotDetail
    #endregion

    public static class ListFilesetSnapshotDetailExtensions
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
            this List<FilesetSnapshotDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetSnapshotDetail> list, 
            String parent = "")
        {
            var item = new FilesetSnapshotDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types