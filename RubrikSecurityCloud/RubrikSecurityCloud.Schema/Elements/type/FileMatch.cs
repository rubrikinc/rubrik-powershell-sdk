// FileMatch.cs
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
    #region FileMatch
    public class FileMatch: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        [JsonProperty("detectedTime")]
        public DateTime? DetectedTime { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        [JsonProperty("fileSize")]
        public System.Int64? FileSize { get; set; }

        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        [JsonProperty("filepath")]
        public System.String? Filepath { get; set; }

        //      C# -> DateTime? FirstMatchedSnapshotDate
        // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("firstMatchedSnapshotDate")]
        public DateTime? FirstMatchedSnapshotDate { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }


        #endregion

    #region methods

    public FileMatch Set(
        IndicatorOfCompromiseKind? MatchType = null,
        DateTime? DetectedTime = null,
        System.String? FileName = null,
        System.Int64? FileSize = null,
        System.String? Filepath = null,
        DateTime? FirstMatchedSnapshotDate = null,
        System.Boolean? IsQuarantined = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( DetectedTime != null ) {
            this.DetectedTime = DetectedTime;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FileSize != null ) {
            this.FileSize = FileSize;
        }
        if ( Filepath != null ) {
            this.Filepath = Filepath;
        }
        if ( FirstMatchedSnapshotDate != null ) {
            this.FirstMatchedSnapshotDate = FirstMatchedSnapshotDate;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
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
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            s += ind + "matchType\n" ;
        }
        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        if (this.DetectedTime != null) {
            s += ind + "detectedTime\n" ;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            s += ind + "fileName\n" ;
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (this.FileSize != null) {
            s += ind + "fileSize\n" ;
        }
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (this.Filepath != null) {
            s += ind + "filepath\n" ;
        }
        //      C# -> DateTime? FirstMatchedSnapshotDate
        // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
        if (this.FirstMatchedSnapshotDate != null) {
            s += ind + "firstMatchedSnapshotDate\n" ;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            s += ind + "isQuarantined\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType == null && Exploration.Includes(parent + ".matchType", true))
        {
            this.MatchType = new IndicatorOfCompromiseKind();
        }
        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        if (this.DetectedTime == null && Exploration.Includes(parent + ".detectedTime", true))
        {
            this.DetectedTime = new DateTime();
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName == null && Exploration.Includes(parent + ".fileName", true))
        {
            this.FileName = "FETCH";
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (this.FileSize == null && Exploration.Includes(parent + ".fileSize", true))
        {
            this.FileSize = new System.Int64();
        }
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (this.Filepath == null && Exploration.Includes(parent + ".filepath", true))
        {
            this.Filepath = "FETCH";
        }
        //      C# -> DateTime? FirstMatchedSnapshotDate
        // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
        if (this.FirstMatchedSnapshotDate == null && Exploration.Includes(parent + ".firstMatchedSnapshotDate", true))
        {
            this.FirstMatchedSnapshotDate = new DateTime();
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined", true))
        {
            this.IsQuarantined = true;
        }
    }


    #endregion

    } // class FileMatch
    
    #endregion

    public static class ListFileMatchExtensions
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
            this List<FileMatch> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FileMatch> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FileMatch());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types