// CustomAnalyzerMatch.cs
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
    #region CustomAnalyzerMatch
    public class CustomAnalyzerMatch: IFragment
    {
        #region members
        //      C# -> System.Int32? EndIndex
        // GraphQL -> endIndex: Int! (scalar)
        [JsonProperty("endIndex")]
        public System.Int32? EndIndex { get; set; }

        //      C# -> System.Int32? StartIndex
        // GraphQL -> startIndex: Int! (scalar)
        [JsonProperty("startIndex")]
        public System.Int32? StartIndex { get; set; }

        #endregion

    #region methods

    public CustomAnalyzerMatch Set(
        System.Int32? EndIndex = null,
        System.Int32? StartIndex = null
    ) 
    {
        if ( EndIndex != null ) {
            this.EndIndex = EndIndex;
        }
        if ( StartIndex != null ) {
            this.StartIndex = StartIndex;
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
            //      C# -> System.Int32? EndIndex
            // GraphQL -> endIndex: Int! (scalar)
            if (this.EndIndex != null)
            {
                 s += ind + "endIndex\n";

            }
            //      C# -> System.Int32? StartIndex
            // GraphQL -> startIndex: Int! (scalar)
            if (this.StartIndex != null)
            {
                 s += ind + "startIndex\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? EndIndex
            // GraphQL -> endIndex: Int! (scalar)
            if (this.EndIndex == null && Exploration.Includes(parent + ".endIndex$"))
            {
                this.EndIndex = new System.Int32();
            }
            //      C# -> System.Int32? StartIndex
            // GraphQL -> startIndex: Int! (scalar)
            if (this.StartIndex == null && Exploration.Includes(parent + ".startIndex$"))
            {
                this.StartIndex = new System.Int32();
            }
        }


    #endregion

    } // class CustomAnalyzerMatch
    #endregion

    public static class ListCustomAnalyzerMatchExtensions
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
            this List<CustomAnalyzerMatch> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CustomAnalyzerMatch> list, 
            String parent = "")
        {
            var item = new CustomAnalyzerMatch();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types