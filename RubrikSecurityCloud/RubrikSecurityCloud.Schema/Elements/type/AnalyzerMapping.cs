// AnalyzerMapping.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
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
    #region AnalyzerMapping
    public class AnalyzerMapping: IFragment
    {
        #region members
        //      C# -> AnalyzerResult? AnalyzerResult
        // GraphQL -> analyzerResult: AnalyzerResult! (type)
        [JsonProperty("analyzerResult")]
        public AnalyzerResult? AnalyzerResult { get; set; }

        //      C# -> List<AnalyzerGroup>? Groups
        // GraphQL -> groups: [AnalyzerGroup!]! (type)
        [JsonProperty("groups")]
        public List<AnalyzerGroup>? Groups { get; set; }

        #endregion

    #region methods

    public AnalyzerMapping Set(
        AnalyzerResult? AnalyzerResult = null,
        List<AnalyzerGroup>? Groups = null
    ) 
    {
        if ( AnalyzerResult != null ) {
            this.AnalyzerResult = AnalyzerResult;
        }
        if ( Groups != null ) {
            this.Groups = Groups;
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
            //      C# -> AnalyzerResult? AnalyzerResult
            // GraphQL -> analyzerResult: AnalyzerResult! (type)
            if (this.AnalyzerResult != null)
            {
                 s += ind + "analyzerResult\n";

                 s += ind + "{\n" + 
                 this.AnalyzerResult.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AnalyzerGroup>? Groups
            // GraphQL -> groups: [AnalyzerGroup!]! (type)
            if (this.Groups != null)
            {
                 s += ind + "groups\n";

                 s += ind + "{\n" + 
                 this.Groups.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AnalyzerResult? AnalyzerResult
            // GraphQL -> analyzerResult: AnalyzerResult! (type)
            if (this.AnalyzerResult == null && Exploration.Includes(parent + ".analyzerResult"))
            {
                this.AnalyzerResult = new AnalyzerResult();
                this.AnalyzerResult.ApplyExploratoryFragment(parent + ".analyzerResult");
            }
            //      C# -> List<AnalyzerGroup>? Groups
            // GraphQL -> groups: [AnalyzerGroup!]! (type)
            if (this.Groups == null && Exploration.Includes(parent + ".groups"))
            {
                this.Groups = new List<AnalyzerGroup>();
                this.Groups.ApplyExploratoryFragment(parent + ".groups");
            }
        }


    #endregion

    } // class AnalyzerMapping
    #endregion

    public static class ListAnalyzerMappingExtensions
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
            this List<AnalyzerMapping> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnalyzerMapping> list, 
            String parent = "")
        {
            var item = new AnalyzerMapping();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types