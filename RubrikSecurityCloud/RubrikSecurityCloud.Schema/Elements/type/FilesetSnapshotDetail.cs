// FilesetSnapshotDetail.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region FilesetSnapshotDetail
    public class FilesetSnapshotDetail: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String! (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
        // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
        if (this.FilesetSnapshotSummary != null) {
            s += ind + "filesetSnapshotSummary {\n" + this.FilesetSnapshotSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> FilesetSnapshotVerbose? Verbose
        // GraphQL -> verbose: FilesetSnapshotVerbose (type)
        if (this.Verbose != null) {
            s += ind + "verbose {\n" + this.Verbose.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String! (scalar)
        if (this.LastModified == null && Exploration.Includes(parent + ".lastModified", true))
        {
            this.LastModified = new System.String("FETCH");
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
        // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
        if (this.FilesetSnapshotSummary == null && Exploration.Includes(parent + ".filesetSnapshotSummary"))
        {
            this.FilesetSnapshotSummary = new FilesetSnapshotSummary();
            this.FilesetSnapshotSummary.ApplyExploratoryFieldSpec(parent + ".filesetSnapshotSummary");
        }
        //      C# -> FilesetSnapshotVerbose? Verbose
        // GraphQL -> verbose: FilesetSnapshotVerbose (type)
        if (this.Verbose == null && Exploration.Includes(parent + ".verbose"))
        {
            this.Verbose = new FilesetSnapshotVerbose();
            this.Verbose.ApplyExploratoryFieldSpec(parent + ".verbose");
        }
    }


    #endregion

    } // class FilesetSnapshotDetail
    
    #endregion

    public static class ListFilesetSnapshotDetailExtensions
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
            this List<FilesetSnapshotDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSnapshotDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSnapshotDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types