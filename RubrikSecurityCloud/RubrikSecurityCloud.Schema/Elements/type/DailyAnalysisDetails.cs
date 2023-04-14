// DailyAnalysisDetails.cs
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
    #region DailyAnalysisDetails
    public class DailyAnalysisDetails: IFragment
    {
        #region members
        //      C# -> System.Int64? AnomalyEventCount
        // GraphQL -> anomalyEventCount: Long! (scalar)
        [JsonProperty("anomalyEventCount")]
        public System.Int64? AnomalyEventCount { get; set; }

        //      C# -> System.Int64? CreatedDataBytes
        // GraphQL -> createdDataBytes: Long! (scalar)
        [JsonProperty("createdDataBytes")]
        public System.Int64? CreatedDataBytes { get; set; }

        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        [JsonProperty("createdFileCount")]
        public System.Int64? CreatedFileCount { get; set; }

        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        [JsonProperty("day")]
        public System.String? Day { get; set; }

        //      C# -> System.Int64? DeletedDataBytes
        // GraphQL -> deletedDataBytes: Long! (scalar)
        [JsonProperty("deletedDataBytes")]
        public System.Int64? DeletedDataBytes { get; set; }

        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        [JsonProperty("deletedFileCount")]
        public System.Int64? DeletedFileCount { get; set; }

        //      C# -> System.Int64? ModifiedDataBytes
        // GraphQL -> modifiedDataBytes: Long! (scalar)
        [JsonProperty("modifiedDataBytes")]
        public System.Int64? ModifiedDataBytes { get; set; }

        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        [JsonProperty("modifiedFileCount")]
        public System.Int64? ModifiedFileCount { get; set; }

        //      C# -> System.Int64? SuspiciousDataBytes
        // GraphQL -> suspiciousDataBytes: Long! (scalar)
        [JsonProperty("suspiciousDataBytes")]
        public System.Int64? SuspiciousDataBytes { get; set; }

        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        [JsonProperty("suspiciousFileCount")]
        public System.Int64? SuspiciousFileCount { get; set; }

        #endregion

    #region methods

    public DailyAnalysisDetails Set(
        System.Int64? AnomalyEventCount = null,
        System.Int64? CreatedDataBytes = null,
        System.Int64? CreatedFileCount = null,
        System.String? Day = null,
        System.Int64? DeletedDataBytes = null,
        System.Int64? DeletedFileCount = null,
        System.Int64? ModifiedDataBytes = null,
        System.Int64? ModifiedFileCount = null,
        System.Int64? SuspiciousDataBytes = null,
        System.Int64? SuspiciousFileCount = null
    ) 
    {
        if ( AnomalyEventCount != null ) {
            this.AnomalyEventCount = AnomalyEventCount;
        }
        if ( CreatedDataBytes != null ) {
            this.CreatedDataBytes = CreatedDataBytes;
        }
        if ( CreatedFileCount != null ) {
            this.CreatedFileCount = CreatedFileCount;
        }
        if ( Day != null ) {
            this.Day = Day;
        }
        if ( DeletedDataBytes != null ) {
            this.DeletedDataBytes = DeletedDataBytes;
        }
        if ( DeletedFileCount != null ) {
            this.DeletedFileCount = DeletedFileCount;
        }
        if ( ModifiedDataBytes != null ) {
            this.ModifiedDataBytes = ModifiedDataBytes;
        }
        if ( ModifiedFileCount != null ) {
            this.ModifiedFileCount = ModifiedFileCount;
        }
        if ( SuspiciousDataBytes != null ) {
            this.SuspiciousDataBytes = SuspiciousDataBytes;
        }
        if ( SuspiciousFileCount != null ) {
            this.SuspiciousFileCount = SuspiciousFileCount;
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
            //      C# -> System.Int64? AnomalyEventCount
            // GraphQL -> anomalyEventCount: Long! (scalar)
            if (this.AnomalyEventCount != null)
            {
                 s += ind + "anomalyEventCount\n";

            }
            //      C# -> System.Int64? CreatedDataBytes
            // GraphQL -> createdDataBytes: Long! (scalar)
            if (this.CreatedDataBytes != null)
            {
                 s += ind + "createdDataBytes\n";

            }
            //      C# -> System.Int64? CreatedFileCount
            // GraphQL -> createdFileCount: Long! (scalar)
            if (this.CreatedFileCount != null)
            {
                 s += ind + "createdFileCount\n";

            }
            //      C# -> System.String? Day
            // GraphQL -> day: String! (scalar)
            if (this.Day != null)
            {
                 s += ind + "day\n";

            }
            //      C# -> System.Int64? DeletedDataBytes
            // GraphQL -> deletedDataBytes: Long! (scalar)
            if (this.DeletedDataBytes != null)
            {
                 s += ind + "deletedDataBytes\n";

            }
            //      C# -> System.Int64? DeletedFileCount
            // GraphQL -> deletedFileCount: Long! (scalar)
            if (this.DeletedFileCount != null)
            {
                 s += ind + "deletedFileCount\n";

            }
            //      C# -> System.Int64? ModifiedDataBytes
            // GraphQL -> modifiedDataBytes: Long! (scalar)
            if (this.ModifiedDataBytes != null)
            {
                 s += ind + "modifiedDataBytes\n";

            }
            //      C# -> System.Int64? ModifiedFileCount
            // GraphQL -> modifiedFileCount: Long! (scalar)
            if (this.ModifiedFileCount != null)
            {
                 s += ind + "modifiedFileCount\n";

            }
            //      C# -> System.Int64? SuspiciousDataBytes
            // GraphQL -> suspiciousDataBytes: Long! (scalar)
            if (this.SuspiciousDataBytes != null)
            {
                 s += ind + "suspiciousDataBytes\n";

            }
            //      C# -> System.Int64? SuspiciousFileCount
            // GraphQL -> suspiciousFileCount: Long! (scalar)
            if (this.SuspiciousFileCount != null)
            {
                 s += ind + "suspiciousFileCount\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? AnomalyEventCount
            // GraphQL -> anomalyEventCount: Long! (scalar)
            if (this.AnomalyEventCount == null && Exploration.Includes(parent + ".anomalyEventCount$"))
            {
                this.AnomalyEventCount = new System.Int64();
            }
            //      C# -> System.Int64? CreatedDataBytes
            // GraphQL -> createdDataBytes: Long! (scalar)
            if (this.CreatedDataBytes == null && Exploration.Includes(parent + ".createdDataBytes$"))
            {
                this.CreatedDataBytes = new System.Int64();
            }
            //      C# -> System.Int64? CreatedFileCount
            // GraphQL -> createdFileCount: Long! (scalar)
            if (this.CreatedFileCount == null && Exploration.Includes(parent + ".createdFileCount$"))
            {
                this.CreatedFileCount = new System.Int64();
            }
            //      C# -> System.String? Day
            // GraphQL -> day: String! (scalar)
            if (this.Day == null && Exploration.Includes(parent + ".day$"))
            {
                this.Day = new System.String("FETCH");
            }
            //      C# -> System.Int64? DeletedDataBytes
            // GraphQL -> deletedDataBytes: Long! (scalar)
            if (this.DeletedDataBytes == null && Exploration.Includes(parent + ".deletedDataBytes$"))
            {
                this.DeletedDataBytes = new System.Int64();
            }
            //      C# -> System.Int64? DeletedFileCount
            // GraphQL -> deletedFileCount: Long! (scalar)
            if (this.DeletedFileCount == null && Exploration.Includes(parent + ".deletedFileCount$"))
            {
                this.DeletedFileCount = new System.Int64();
            }
            //      C# -> System.Int64? ModifiedDataBytes
            // GraphQL -> modifiedDataBytes: Long! (scalar)
            if (this.ModifiedDataBytes == null && Exploration.Includes(parent + ".modifiedDataBytes$"))
            {
                this.ModifiedDataBytes = new System.Int64();
            }
            //      C# -> System.Int64? ModifiedFileCount
            // GraphQL -> modifiedFileCount: Long! (scalar)
            if (this.ModifiedFileCount == null && Exploration.Includes(parent + ".modifiedFileCount$"))
            {
                this.ModifiedFileCount = new System.Int64();
            }
            //      C# -> System.Int64? SuspiciousDataBytes
            // GraphQL -> suspiciousDataBytes: Long! (scalar)
            if (this.SuspiciousDataBytes == null && Exploration.Includes(parent + ".suspiciousDataBytes$"))
            {
                this.SuspiciousDataBytes = new System.Int64();
            }
            //      C# -> System.Int64? SuspiciousFileCount
            // GraphQL -> suspiciousFileCount: Long! (scalar)
            if (this.SuspiciousFileCount == null && Exploration.Includes(parent + ".suspiciousFileCount$"))
            {
                this.SuspiciousFileCount = new System.Int64();
            }
        }


    #endregion

    } // class DailyAnalysisDetails
    #endregion

    public static class ListDailyAnalysisDetailsExtensions
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
            this List<DailyAnalysisDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DailyAnalysisDetails> list, 
            String parent = "")
        {
            var item = new DailyAnalysisDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types