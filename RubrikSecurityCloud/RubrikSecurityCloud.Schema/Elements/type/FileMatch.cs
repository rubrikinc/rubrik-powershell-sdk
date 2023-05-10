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

namespace Rubrik.SecurityCloud.Types
{
    #region FileMatch
    public class FileMatch: IFragment
    {
        #region members
        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        [JsonProperty("detectedTime")]
        public DateTime? DetectedTime { get; set; }

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

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        #endregion

    #region methods

    public FileMatch Set(
        DateTime? DetectedTime = null,
        System.String? Filepath = null,
        DateTime? FirstMatchedSnapshotDate = null,
        System.Boolean? IsQuarantined = null,
        IndicatorOfCompromiseKind? MatchType = null
    ) 
    {
        if ( DetectedTime != null ) {
            this.DetectedTime = DetectedTime;
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
        if ( MatchType != null ) {
            this.MatchType = MatchType;
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
            //      C# -> DateTime? DetectedTime
            // GraphQL -> detectedTime: DateTime (scalar)
            if (this.DetectedTime != null)
            {
                 s += ind + "detectedTime\n";

            }
            //      C# -> System.String? Filepath
            // GraphQL -> filepath: String! (scalar)
            if (this.Filepath != null)
            {
                 s += ind + "filepath\n";

            }
            //      C# -> DateTime? FirstMatchedSnapshotDate
            // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
            if (this.FirstMatchedSnapshotDate != null)
            {
                 s += ind + "firstMatchedSnapshotDate\n";

            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined != null)
            {
                 s += ind + "isQuarantined\n";

            }
            //      C# -> IndicatorOfCompromiseKind? MatchType
            // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
            if (this.MatchType != null)
            {
                 s += ind + "matchType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? DetectedTime
            // GraphQL -> detectedTime: DateTime (scalar)
            if (this.DetectedTime == null && Exploration.Includes(parent + ".detectedTime$"))
            {
                this.DetectedTime = new DateTime();
            }
            //      C# -> System.String? Filepath
            // GraphQL -> filepath: String! (scalar)
            if (this.Filepath == null && Exploration.Includes(parent + ".filepath$"))
            {
                this.Filepath = new System.String("FETCH");
            }
            //      C# -> DateTime? FirstMatchedSnapshotDate
            // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
            if (this.FirstMatchedSnapshotDate == null && Exploration.Includes(parent + ".firstMatchedSnapshotDate$"))
            {
                this.FirstMatchedSnapshotDate = new DateTime();
            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined$"))
            {
                this.IsQuarantined = new System.Boolean();
            }
            //      C# -> IndicatorOfCompromiseKind? MatchType
            // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
            if (this.MatchType == null && Exploration.Includes(parent + ".matchType$"))
            {
                this.MatchType = new IndicatorOfCompromiseKind();
            }
        }


    #endregion

    } // class FileMatch
    #endregion

    public static class ListFileMatchExtensions
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
            this List<FileMatch> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FileMatch> list, 
            String parent = "")
        {
            var item = new FileMatch();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types