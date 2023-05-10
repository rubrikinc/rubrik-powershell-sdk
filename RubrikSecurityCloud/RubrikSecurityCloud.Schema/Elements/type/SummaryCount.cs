// SummaryCount.cs
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
    #region SummaryCount
    public class SummaryCount: IFragment
    {
        #region members
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        [JsonProperty("totalCount")]
        public System.Int64? TotalCount { get; set; }

        //      C# -> System.Int64? ViolatedCount
        // GraphQL -> violatedCount: Long! (scalar)
        [JsonProperty("violatedCount")]
        public System.Int64? ViolatedCount { get; set; }

        #endregion

    #region methods

    public SummaryCount Set(
        System.Int64? TotalCount = null,
        System.Int64? ViolatedCount = null
    ) 
    {
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        if ( ViolatedCount != null ) {
            this.ViolatedCount = ViolatedCount;
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
            //      C# -> System.Int64? TotalCount
            // GraphQL -> totalCount: Long! (scalar)
            if (this.TotalCount != null)
            {
                 s += ind + "totalCount\n";

            }
            //      C# -> System.Int64? ViolatedCount
            // GraphQL -> violatedCount: Long! (scalar)
            if (this.ViolatedCount != null)
            {
                 s += ind + "violatedCount\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? TotalCount
            // GraphQL -> totalCount: Long! (scalar)
            if (this.TotalCount == null && Exploration.Includes(parent + ".totalCount$"))
            {
                this.TotalCount = new System.Int64();
            }
            //      C# -> System.Int64? ViolatedCount
            // GraphQL -> violatedCount: Long! (scalar)
            if (this.ViolatedCount == null && Exploration.Includes(parent + ".violatedCount$"))
            {
                this.ViolatedCount = new System.Int64();
            }
        }


    #endregion

    } // class SummaryCount
    #endregion

    public static class ListSummaryCountExtensions
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
            this List<SummaryCount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SummaryCount> list, 
            String parent = "")
        {
            var item = new SummaryCount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types