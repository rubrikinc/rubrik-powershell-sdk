// FilesetSnapshotSummary.cs
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
    #region FilesetSnapshotSummary
    public class FilesetSnapshotSummary: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? ErrorsCollected
        // GraphQL -> errorsCollected: Long (scalar)
        if (this.ErrorsCollected != null) {
            s += ind + "errorsCollected\n" ;
        }
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long (scalar)
        if (this.FileCount != null) {
            s += ind + "fileCount\n" ;
        }
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (this.FilesetName != null) {
            s += ind + "filesetName\n" ;
        }
        //      C# -> System.Boolean? SnapdiffUsed
        // GraphQL -> snapdiffUsed: Boolean (scalar)
        if (this.SnapdiffUsed != null) {
            s += ind + "snapdiffUsed\n" ;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary != null) {
            var fspec = this.BaseSnapshotSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "baseSnapshotSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ErrorsCollected
        // GraphQL -> errorsCollected: Long (scalar)
        if (this.ErrorsCollected == null && Exploration.Includes(parent + ".errorsCollected", true))
        {
            this.ErrorsCollected = new System.Int64();
        }
        //      C# -> System.Int64? FileCount
        // GraphQL -> fileCount: Long (scalar)
        if (this.FileCount == null && Exploration.Includes(parent + ".fileCount", true))
        {
            this.FileCount = new System.Int64();
        }
        //      C# -> System.String? FilesetName
        // GraphQL -> filesetName: String! (scalar)
        if (this.FilesetName == null && Exploration.Includes(parent + ".filesetName", true))
        {
            this.FilesetName = "FETCH";
        }
        //      C# -> System.Boolean? SnapdiffUsed
        // GraphQL -> snapdiffUsed: Boolean (scalar)
        if (this.SnapdiffUsed == null && Exploration.Includes(parent + ".snapdiffUsed", true))
        {
            this.SnapdiffUsed = true;
        }
        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
        {
            this.BaseSnapshotSummary = new BaseSnapshotSummary();
            this.BaseSnapshotSummary.ApplyExploratoryFieldSpec(parent + ".baseSnapshotSummary");
        }
    }


    #endregion

    } // class FilesetSnapshotSummary
    
    #endregion

    public static class ListFilesetSnapshotSummaryExtensions
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
            this List<FilesetSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSnapshotSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types