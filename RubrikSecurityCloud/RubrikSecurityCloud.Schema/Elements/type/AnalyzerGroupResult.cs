// AnalyzerGroupResult.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    #region AnalyzerGroupResult
    public class AnalyzerGroupResult: IFragment
    {
        #region members
        //      C# -> AnalyzerGroup? AnalyzerGroup
        // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
        [JsonProperty("analyzerGroup")]
        public AnalyzerGroup? AnalyzerGroup { get; set; }

        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        [JsonProperty("analyzerResults")]
        public List<AnalyzerResult>? AnalyzerResults { get; set; }

        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        [JsonProperty("hits")]
        public Hits? Hits { get; set; }

        #endregion

    #region methods

    public AnalyzerGroupResult Set(
        AnalyzerGroup? AnalyzerGroup = null,
        List<AnalyzerResult>? AnalyzerResults = null,
        Hits? Hits = null
    ) 
    {
        if ( AnalyzerGroup != null ) {
            this.AnalyzerGroup = AnalyzerGroup;
        }
        if ( AnalyzerResults != null ) {
            this.AnalyzerResults = AnalyzerResults;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
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
            //      C# -> AnalyzerGroup? AnalyzerGroup
            // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
            if (this.AnalyzerGroup != null)
            {
                 s += ind + "analyzerGroup\n";

                 s += ind + "{\n" + 
                 this.AnalyzerGroup.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AnalyzerResult>? AnalyzerResults
            // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
            if (this.AnalyzerResults != null)
            {
                 s += ind + "analyzerResults\n";

                 s += ind + "{\n" + 
                 this.AnalyzerResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits! (type)
            if (this.Hits != null)
            {
                 s += ind + "hits\n";

                 s += ind + "{\n" + 
                 this.Hits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AnalyzerGroup? AnalyzerGroup
            // GraphQL -> analyzerGroup: AnalyzerGroup! (type)
            if (this.AnalyzerGroup == null && Exploration.Includes(parent + ".analyzerGroup"))
            {
                this.AnalyzerGroup = new AnalyzerGroup();
                this.AnalyzerGroup.ApplyExploratoryFragment(parent + ".analyzerGroup");
            }
            //      C# -> List<AnalyzerResult>? AnalyzerResults
            // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
            if (this.AnalyzerResults == null && Exploration.Includes(parent + ".analyzerResults"))
            {
                this.AnalyzerResults = new List<AnalyzerResult>();
                this.AnalyzerResults.ApplyExploratoryFragment(parent + ".analyzerResults");
            }
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits! (type)
            if (this.Hits == null && Exploration.Includes(parent + ".hits"))
            {
                this.Hits = new Hits();
                this.Hits.ApplyExploratoryFragment(parent + ".hits");
            }
        }


    #endregion

    } // class AnalyzerGroupResult
    #endregion

    public static class ListAnalyzerGroupResultExtensions
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
            this List<AnalyzerGroupResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnalyzerGroupResult> list, 
            String parent = "")
        {
            var item = new AnalyzerGroupResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types