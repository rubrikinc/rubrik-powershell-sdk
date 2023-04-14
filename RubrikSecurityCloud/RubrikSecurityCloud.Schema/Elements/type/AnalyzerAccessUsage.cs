// AnalyzerAccessUsage.cs
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
    #region AnalyzerAccessUsage
    public class AnalyzerAccessUsage: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.Int32? CountDelta
        // GraphQL -> countDelta: Int! (scalar)
        [JsonProperty("countDelta")]
        public System.Int32? CountDelta { get; set; }

        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer (type)
        [JsonProperty("analyzer")]
        public Analyzer? Analyzer { get; set; }

        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        [JsonProperty("topFiles")]
        public List<FileAccessResult>? TopFiles { get; set; }

        #endregion

    #region methods

    public AnalyzerAccessUsage Set(
        System.Int32? Count = null,
        System.Int32? CountDelta = null,
        Analyzer? Analyzer = null,
        List<FileAccessResult>? TopFiles = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( CountDelta != null ) {
            this.CountDelta = CountDelta;
        }
        if ( Analyzer != null ) {
            this.Analyzer = Analyzer;
        }
        if ( TopFiles != null ) {
            this.TopFiles = TopFiles;
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
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> System.Int32? CountDelta
            // GraphQL -> countDelta: Int! (scalar)
            if (this.CountDelta != null)
            {
                 s += ind + "countDelta\n";

            }
            //      C# -> Analyzer? Analyzer
            // GraphQL -> analyzer: Analyzer (type)
            if (this.Analyzer != null)
            {
                 s += ind + "analyzer\n";

                 s += ind + "{\n" + 
                 this.Analyzer.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FileAccessResult>? TopFiles
            // GraphQL -> topFiles: [FileAccessResult!]! (type)
            if (this.TopFiles != null)
            {
                 s += ind + "topFiles\n";

                 s += ind + "{\n" + 
                 this.TopFiles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> System.Int32? CountDelta
            // GraphQL -> countDelta: Int! (scalar)
            if (this.CountDelta == null && Exploration.Includes(parent + ".countDelta$"))
            {
                this.CountDelta = new System.Int32();
            }
            //      C# -> Analyzer? Analyzer
            // GraphQL -> analyzer: Analyzer (type)
            if (this.Analyzer == null && Exploration.Includes(parent + ".analyzer"))
            {
                this.Analyzer = new Analyzer();
                this.Analyzer.ApplyExploratoryFragment(parent + ".analyzer");
            }
            //      C# -> List<FileAccessResult>? TopFiles
            // GraphQL -> topFiles: [FileAccessResult!]! (type)
            if (this.TopFiles == null && Exploration.Includes(parent + ".topFiles"))
            {
                this.TopFiles = new List<FileAccessResult>();
                this.TopFiles.ApplyExploratoryFragment(parent + ".topFiles");
            }
        }


    #endregion

    } // class AnalyzerAccessUsage
    #endregion

    public static class ListAnalyzerAccessUsageExtensions
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
            this List<AnalyzerAccessUsage> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnalyzerAccessUsage> list, 
            String parent = "")
        {
            var item = new AnalyzerAccessUsage();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types