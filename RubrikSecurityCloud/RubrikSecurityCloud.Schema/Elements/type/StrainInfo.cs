// StrainInfo.cs
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
    #region StrainInfo
    public class StrainInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? SampleAffectedFiles
        // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
        [JsonProperty("sampleAffectedFiles")]
        public List<System.String>? SampleAffectedFiles { get; set; }

        //      C# -> List<System.String>? SampleRansomwareNotes
        // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
        [JsonProperty("sampleRansomwareNotes")]
        public List<System.String>? SampleRansomwareNotes { get; set; }

        //      C# -> System.String? StrainId
        // GraphQL -> strainId: String! (scalar)
        [JsonProperty("strainId")]
        public System.String? StrainId { get; set; }

        //      C# -> System.Int64? TotalAffectedFiles
        // GraphQL -> totalAffectedFiles: Long! (scalar)
        [JsonProperty("totalAffectedFiles")]
        public System.Int64? TotalAffectedFiles { get; set; }

        //      C# -> System.Int64? TotalRansomwareNotes
        // GraphQL -> totalRansomwareNotes: Long! (scalar)
        [JsonProperty("totalRansomwareNotes")]
        public System.Int64? TotalRansomwareNotes { get; set; }

        //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
        // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
        [JsonProperty("sampleAffectedFilesInfo")]
        public List<SuspiciousFileInfo>? SampleAffectedFilesInfo { get; set; }

        //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
        // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
        [JsonProperty("sampleRansomwareNoteFilesInfo")]
        public List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo { get; set; }


        #endregion

    #region methods

    public StrainInfo Set(
        List<System.String>? SampleAffectedFiles = null,
        List<System.String>? SampleRansomwareNotes = null,
        System.String? StrainId = null,
        System.Int64? TotalAffectedFiles = null,
        System.Int64? TotalRansomwareNotes = null,
        List<SuspiciousFileInfo>? SampleAffectedFilesInfo = null,
        List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo = null
    ) 
    {
        if ( SampleAffectedFiles != null ) {
            this.SampleAffectedFiles = SampleAffectedFiles;
        }
        if ( SampleRansomwareNotes != null ) {
            this.SampleRansomwareNotes = SampleRansomwareNotes;
        }
        if ( StrainId != null ) {
            this.StrainId = StrainId;
        }
        if ( TotalAffectedFiles != null ) {
            this.TotalAffectedFiles = TotalAffectedFiles;
        }
        if ( TotalRansomwareNotes != null ) {
            this.TotalRansomwareNotes = TotalRansomwareNotes;
        }
        if ( SampleAffectedFilesInfo != null ) {
            this.SampleAffectedFilesInfo = SampleAffectedFilesInfo;
        }
        if ( SampleRansomwareNoteFilesInfo != null ) {
            this.SampleRansomwareNoteFilesInfo = SampleRansomwareNoteFilesInfo;
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
        //      C# -> List<System.String>? SampleAffectedFiles
        // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
        if (this.SampleAffectedFiles != null) {
            s += ind + "sampleAffectedFiles\n" ;
        }
        //      C# -> List<System.String>? SampleRansomwareNotes
        // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
        if (this.SampleRansomwareNotes != null) {
            s += ind + "sampleRansomwareNotes\n" ;
        }
        //      C# -> System.String? StrainId
        // GraphQL -> strainId: String! (scalar)
        if (this.StrainId != null) {
            s += ind + "strainId\n" ;
        }
        //      C# -> System.Int64? TotalAffectedFiles
        // GraphQL -> totalAffectedFiles: Long! (scalar)
        if (this.TotalAffectedFiles != null) {
            s += ind + "totalAffectedFiles\n" ;
        }
        //      C# -> System.Int64? TotalRansomwareNotes
        // GraphQL -> totalRansomwareNotes: Long! (scalar)
        if (this.TotalRansomwareNotes != null) {
            s += ind + "totalRansomwareNotes\n" ;
        }
        //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
        // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
        if (this.SampleAffectedFilesInfo != null) {
            var fspec = this.SampleAffectedFilesInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sampleAffectedFilesInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
        // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
        if (this.SampleRansomwareNoteFilesInfo != null) {
            var fspec = this.SampleRansomwareNoteFilesInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sampleRansomwareNoteFilesInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? SampleAffectedFiles
        // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
        if (this.SampleAffectedFiles == null && Exploration.Includes(parent + ".sampleAffectedFiles", true))
        {
            this.SampleAffectedFiles = new List<System.String>();
        }
        //      C# -> List<System.String>? SampleRansomwareNotes
        // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
        if (this.SampleRansomwareNotes == null && Exploration.Includes(parent + ".sampleRansomwareNotes", true))
        {
            this.SampleRansomwareNotes = new List<System.String>();
        }
        //      C# -> System.String? StrainId
        // GraphQL -> strainId: String! (scalar)
        if (this.StrainId == null && Exploration.Includes(parent + ".strainId", true))
        {
            this.StrainId = "FETCH";
        }
        //      C# -> System.Int64? TotalAffectedFiles
        // GraphQL -> totalAffectedFiles: Long! (scalar)
        if (this.TotalAffectedFiles == null && Exploration.Includes(parent + ".totalAffectedFiles", true))
        {
            this.TotalAffectedFiles = new System.Int64();
        }
        //      C# -> System.Int64? TotalRansomwareNotes
        // GraphQL -> totalRansomwareNotes: Long! (scalar)
        if (this.TotalRansomwareNotes == null && Exploration.Includes(parent + ".totalRansomwareNotes", true))
        {
            this.TotalRansomwareNotes = new System.Int64();
        }
        //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
        // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
        if (this.SampleAffectedFilesInfo == null && Exploration.Includes(parent + ".sampleAffectedFilesInfo"))
        {
            this.SampleAffectedFilesInfo = new List<SuspiciousFileInfo>();
            this.SampleAffectedFilesInfo.ApplyExploratoryFieldSpec(parent + ".sampleAffectedFilesInfo");
        }
        //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
        // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
        if (this.SampleRansomwareNoteFilesInfo == null && Exploration.Includes(parent + ".sampleRansomwareNoteFilesInfo"))
        {
            this.SampleRansomwareNoteFilesInfo = new List<SuspiciousFileInfo>();
            this.SampleRansomwareNoteFilesInfo.ApplyExploratoryFieldSpec(parent + ".sampleRansomwareNoteFilesInfo");
        }
    }


    #endregion

    } // class StrainInfo
    
    #endregion

    public static class ListStrainInfoExtensions
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
            this List<StrainInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StrainInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new StrainInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types