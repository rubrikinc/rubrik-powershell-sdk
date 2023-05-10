// SensitiveFiles.cs
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
    #region SensitiveFiles
    public class SensitiveFiles: IFragment
    {
        #region members
        //      C# -> SummaryCount? HighRiskFileCount
        // GraphQL -> highRiskFileCount: SummaryCount (type)
        [JsonProperty("highRiskFileCount")]
        public SummaryCount? HighRiskFileCount { get; set; }

        //      C# -> SummaryCount? LowRiskFileCount
        // GraphQL -> lowRiskFileCount: SummaryCount (type)
        [JsonProperty("lowRiskFileCount")]
        public SummaryCount? LowRiskFileCount { get; set; }

        //      C# -> SummaryCount? MediumRiskFileCount
        // GraphQL -> mediumRiskFileCount: SummaryCount (type)
        [JsonProperty("mediumRiskFileCount")]
        public SummaryCount? MediumRiskFileCount { get; set; }

        //      C# -> SummaryCount? TotalFileCount
        // GraphQL -> totalFileCount: SummaryCount (type)
        [JsonProperty("totalFileCount")]
        public SummaryCount? TotalFileCount { get; set; }

        #endregion

    #region methods

    public SensitiveFiles Set(
        SummaryCount? HighRiskFileCount = null,
        SummaryCount? LowRiskFileCount = null,
        SummaryCount? MediumRiskFileCount = null,
        SummaryCount? TotalFileCount = null
    ) 
    {
        if ( HighRiskFileCount != null ) {
            this.HighRiskFileCount = HighRiskFileCount;
        }
        if ( LowRiskFileCount != null ) {
            this.LowRiskFileCount = LowRiskFileCount;
        }
        if ( MediumRiskFileCount != null ) {
            this.MediumRiskFileCount = MediumRiskFileCount;
        }
        if ( TotalFileCount != null ) {
            this.TotalFileCount = TotalFileCount;
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
            //      C# -> SummaryCount? HighRiskFileCount
            // GraphQL -> highRiskFileCount: SummaryCount (type)
            if (this.HighRiskFileCount != null)
            {
                 s += ind + "highRiskFileCount\n";

                 s += ind + "{\n" + 
                 this.HighRiskFileCount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SummaryCount? LowRiskFileCount
            // GraphQL -> lowRiskFileCount: SummaryCount (type)
            if (this.LowRiskFileCount != null)
            {
                 s += ind + "lowRiskFileCount\n";

                 s += ind + "{\n" + 
                 this.LowRiskFileCount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SummaryCount? MediumRiskFileCount
            // GraphQL -> mediumRiskFileCount: SummaryCount (type)
            if (this.MediumRiskFileCount != null)
            {
                 s += ind + "mediumRiskFileCount\n";

                 s += ind + "{\n" + 
                 this.MediumRiskFileCount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SummaryCount? TotalFileCount
            // GraphQL -> totalFileCount: SummaryCount (type)
            if (this.TotalFileCount != null)
            {
                 s += ind + "totalFileCount\n";

                 s += ind + "{\n" + 
                 this.TotalFileCount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> SummaryCount? HighRiskFileCount
            // GraphQL -> highRiskFileCount: SummaryCount (type)
            if (this.HighRiskFileCount == null && Exploration.Includes(parent + ".highRiskFileCount"))
            {
                this.HighRiskFileCount = new SummaryCount();
                this.HighRiskFileCount.ApplyExploratoryFragment(parent + ".highRiskFileCount");
            }
            //      C# -> SummaryCount? LowRiskFileCount
            // GraphQL -> lowRiskFileCount: SummaryCount (type)
            if (this.LowRiskFileCount == null && Exploration.Includes(parent + ".lowRiskFileCount"))
            {
                this.LowRiskFileCount = new SummaryCount();
                this.LowRiskFileCount.ApplyExploratoryFragment(parent + ".lowRiskFileCount");
            }
            //      C# -> SummaryCount? MediumRiskFileCount
            // GraphQL -> mediumRiskFileCount: SummaryCount (type)
            if (this.MediumRiskFileCount == null && Exploration.Includes(parent + ".mediumRiskFileCount"))
            {
                this.MediumRiskFileCount = new SummaryCount();
                this.MediumRiskFileCount.ApplyExploratoryFragment(parent + ".mediumRiskFileCount");
            }
            //      C# -> SummaryCount? TotalFileCount
            // GraphQL -> totalFileCount: SummaryCount (type)
            if (this.TotalFileCount == null && Exploration.Includes(parent + ".totalFileCount"))
            {
                this.TotalFileCount = new SummaryCount();
                this.TotalFileCount.ApplyExploratoryFragment(parent + ".totalFileCount");
            }
        }


    #endregion

    } // class SensitiveFiles
    #endregion

    public static class ListSensitiveFilesExtensions
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
            this List<SensitiveFiles> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SensitiveFiles> list, 
            String parent = "")
        {
            var item = new SensitiveFiles();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types