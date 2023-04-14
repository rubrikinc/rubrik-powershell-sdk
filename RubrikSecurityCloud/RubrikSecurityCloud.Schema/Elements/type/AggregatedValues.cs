// AggregatedValues.cs
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
    #region AggregatedValues
    public class AggregatedValues: IFragment
    {
        #region members
        //      C# -> System.Int64? MaxCreatedFileCount
        // GraphQL -> maxCreatedFileCount: Long! (scalar)
        [JsonProperty("maxCreatedFileCount")]
        public System.Int64? MaxCreatedFileCount { get; set; }

        //      C# -> System.Int64? MaxDeletedFileCount
        // GraphQL -> maxDeletedFileCount: Long! (scalar)
        [JsonProperty("maxDeletedFileCount")]
        public System.Int64? MaxDeletedFileCount { get; set; }

        //      C# -> System.Int64? MaxModifiedFileCount
        // GraphQL -> maxModifiedFileCount: Long! (scalar)
        [JsonProperty("maxModifiedFileCount")]
        public System.Int64? MaxModifiedFileCount { get; set; }

        //      C# -> System.Int64? MaxSuspiciousFileCount
        // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
        [JsonProperty("maxSuspiciousFileCount")]
        public System.Int64? MaxSuspiciousFileCount { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }

        #endregion

    #region methods

    public AggregatedValues Set(
        System.Int64? MaxCreatedFileCount = null,
        System.Int64? MaxDeletedFileCount = null,
        System.Int64? MaxModifiedFileCount = null,
        System.Int64? MaxSuspiciousFileCount = null,
        System.Int64? Total = null
    ) 
    {
        if ( MaxCreatedFileCount != null ) {
            this.MaxCreatedFileCount = MaxCreatedFileCount;
        }
        if ( MaxDeletedFileCount != null ) {
            this.MaxDeletedFileCount = MaxDeletedFileCount;
        }
        if ( MaxModifiedFileCount != null ) {
            this.MaxModifiedFileCount = MaxModifiedFileCount;
        }
        if ( MaxSuspiciousFileCount != null ) {
            this.MaxSuspiciousFileCount = MaxSuspiciousFileCount;
        }
        if ( Total != null ) {
            this.Total = Total;
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
            //      C# -> System.Int64? MaxCreatedFileCount
            // GraphQL -> maxCreatedFileCount: Long! (scalar)
            if (this.MaxCreatedFileCount != null)
            {
                 s += ind + "maxCreatedFileCount\n";

            }
            //      C# -> System.Int64? MaxDeletedFileCount
            // GraphQL -> maxDeletedFileCount: Long! (scalar)
            if (this.MaxDeletedFileCount != null)
            {
                 s += ind + "maxDeletedFileCount\n";

            }
            //      C# -> System.Int64? MaxModifiedFileCount
            // GraphQL -> maxModifiedFileCount: Long! (scalar)
            if (this.MaxModifiedFileCount != null)
            {
                 s += ind + "maxModifiedFileCount\n";

            }
            //      C# -> System.Int64? MaxSuspiciousFileCount
            // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
            if (this.MaxSuspiciousFileCount != null)
            {
                 s += ind + "maxSuspiciousFileCount\n";

            }
            //      C# -> System.Int64? Total
            // GraphQL -> total: Long! (scalar)
            if (this.Total != null)
            {
                 s += ind + "total\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? MaxCreatedFileCount
            // GraphQL -> maxCreatedFileCount: Long! (scalar)
            if (this.MaxCreatedFileCount == null && Exploration.Includes(parent + ".maxCreatedFileCount$"))
            {
                this.MaxCreatedFileCount = new System.Int64();
            }
            //      C# -> System.Int64? MaxDeletedFileCount
            // GraphQL -> maxDeletedFileCount: Long! (scalar)
            if (this.MaxDeletedFileCount == null && Exploration.Includes(parent + ".maxDeletedFileCount$"))
            {
                this.MaxDeletedFileCount = new System.Int64();
            }
            //      C# -> System.Int64? MaxModifiedFileCount
            // GraphQL -> maxModifiedFileCount: Long! (scalar)
            if (this.MaxModifiedFileCount == null && Exploration.Includes(parent + ".maxModifiedFileCount$"))
            {
                this.MaxModifiedFileCount = new System.Int64();
            }
            //      C# -> System.Int64? MaxSuspiciousFileCount
            // GraphQL -> maxSuspiciousFileCount: Long! (scalar)
            if (this.MaxSuspiciousFileCount == null && Exploration.Includes(parent + ".maxSuspiciousFileCount$"))
            {
                this.MaxSuspiciousFileCount = new System.Int64();
            }
            //      C# -> System.Int64? Total
            // GraphQL -> total: Long! (scalar)
            if (this.Total == null && Exploration.Includes(parent + ".total$"))
            {
                this.Total = new System.Int64();
            }
        }


    #endregion

    } // class AggregatedValues
    #endregion

    public static class ListAggregatedValuesExtensions
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
            this List<AggregatedValues> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AggregatedValues> list, 
            String parent = "")
        {
            var item = new AggregatedValues();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types