// StrainInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    #region StrainInfo
    public class StrainInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? SampleAffectedFiles
            // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
            if (this.SampleAffectedFiles != null)
            {
                 s += ind + "sampleAffectedFiles\n";

            }
            //      C# -> List<System.String>? SampleRansomwareNotes
            // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
            if (this.SampleRansomwareNotes != null)
            {
                 s += ind + "sampleRansomwareNotes\n";

            }
            //      C# -> System.String? StrainId
            // GraphQL -> strainId: String! (scalar)
            if (this.StrainId != null)
            {
                 s += ind + "strainId\n";

            }
            //      C# -> System.Int64? TotalAffectedFiles
            // GraphQL -> totalAffectedFiles: Long! (scalar)
            if (this.TotalAffectedFiles != null)
            {
                 s += ind + "totalAffectedFiles\n";

            }
            //      C# -> System.Int64? TotalRansomwareNotes
            // GraphQL -> totalRansomwareNotes: Long! (scalar)
            if (this.TotalRansomwareNotes != null)
            {
                 s += ind + "totalRansomwareNotes\n";

            }
            //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
            // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
            if (this.SampleAffectedFilesInfo != null)
            {
                 s += ind + "sampleAffectedFilesInfo\n";

                 s += ind + "{\n" + 
                 this.SampleAffectedFilesInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
            // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
            if (this.SampleRansomwareNoteFilesInfo != null)
            {
                 s += ind + "sampleRansomwareNoteFilesInfo\n";

                 s += ind + "{\n" + 
                 this.SampleRansomwareNoteFilesInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? SampleAffectedFiles
            // GraphQL -> sampleAffectedFiles: [String!]! (scalar)
            if (this.SampleAffectedFiles == null && Exploration.Includes(parent + ".sampleAffectedFiles$"))
            {
                this.SampleAffectedFiles = new List<System.String>();
            }
            //      C# -> List<System.String>? SampleRansomwareNotes
            // GraphQL -> sampleRansomwareNotes: [String!]! (scalar)
            if (this.SampleRansomwareNotes == null && Exploration.Includes(parent + ".sampleRansomwareNotes$"))
            {
                this.SampleRansomwareNotes = new List<System.String>();
            }
            //      C# -> System.String? StrainId
            // GraphQL -> strainId: String! (scalar)
            if (this.StrainId == null && Exploration.Includes(parent + ".strainId$"))
            {
                this.StrainId = new System.String("FETCH");
            }
            //      C# -> System.Int64? TotalAffectedFiles
            // GraphQL -> totalAffectedFiles: Long! (scalar)
            if (this.TotalAffectedFiles == null && Exploration.Includes(parent + ".totalAffectedFiles$"))
            {
                this.TotalAffectedFiles = new System.Int64();
            }
            //      C# -> System.Int64? TotalRansomwareNotes
            // GraphQL -> totalRansomwareNotes: Long! (scalar)
            if (this.TotalRansomwareNotes == null && Exploration.Includes(parent + ".totalRansomwareNotes$"))
            {
                this.TotalRansomwareNotes = new System.Int64();
            }
            //      C# -> List<SuspiciousFileInfo>? SampleAffectedFilesInfo
            // GraphQL -> sampleAffectedFilesInfo: [SuspiciousFileInfo!]! (type)
            if (this.SampleAffectedFilesInfo == null && Exploration.Includes(parent + ".sampleAffectedFilesInfo"))
            {
                this.SampleAffectedFilesInfo = new List<SuspiciousFileInfo>();
                this.SampleAffectedFilesInfo.ApplyExploratoryFragment(parent + ".sampleAffectedFilesInfo");
            }
            //      C# -> List<SuspiciousFileInfo>? SampleRansomwareNoteFilesInfo
            // GraphQL -> sampleRansomwareNoteFilesInfo: [SuspiciousFileInfo!]! (type)
            if (this.SampleRansomwareNoteFilesInfo == null && Exploration.Includes(parent + ".sampleRansomwareNoteFilesInfo"))
            {
                this.SampleRansomwareNoteFilesInfo = new List<SuspiciousFileInfo>();
                this.SampleRansomwareNoteFilesInfo.ApplyExploratoryFragment(parent + ".sampleRansomwareNoteFilesInfo");
            }
        }


    #endregion

    } // class StrainInfo
    #endregion

    public static class ListStrainInfoExtensions
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
            this List<StrainInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<StrainInfo> list, 
            String parent = "")
        {
            var item = new StrainInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types