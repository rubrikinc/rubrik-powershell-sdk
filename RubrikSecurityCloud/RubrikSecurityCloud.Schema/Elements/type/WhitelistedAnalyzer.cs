// WhitelistedAnalyzer.cs
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
    #region WhitelistedAnalyzer
    public class WhitelistedAnalyzer: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsExplicit
        // GraphQL -> isExplicit: Boolean! (scalar)
        [JsonProperty("isExplicit")]
        public System.Boolean? IsExplicit { get; set; }

        //      C# -> System.String? WhitelistedAnalyzerId
        // GraphQL -> whitelistedAnalyzerId: String! (scalar)
        [JsonProperty("whitelistedAnalyzerId")]
        public System.String? WhitelistedAnalyzerId { get; set; }

        //      C# -> System.String? WhitelistedPath
        // GraphQL -> whitelistedPath: String! (scalar)
        [JsonProperty("whitelistedPath")]
        public System.String? WhitelistedPath { get; set; }

        #endregion

    #region methods

    public WhitelistedAnalyzer Set(
        System.Boolean? IsExplicit = null,
        System.String? WhitelistedAnalyzerId = null,
        System.String? WhitelistedPath = null
    ) 
    {
        if ( IsExplicit != null ) {
            this.IsExplicit = IsExplicit;
        }
        if ( WhitelistedAnalyzerId != null ) {
            this.WhitelistedAnalyzerId = WhitelistedAnalyzerId;
        }
        if ( WhitelistedPath != null ) {
            this.WhitelistedPath = WhitelistedPath;
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
            //      C# -> System.Boolean? IsExplicit
            // GraphQL -> isExplicit: Boolean! (scalar)
            if (this.IsExplicit != null)
            {
                 s += ind + "isExplicit\n";

            }
            //      C# -> System.String? WhitelistedAnalyzerId
            // GraphQL -> whitelistedAnalyzerId: String! (scalar)
            if (this.WhitelistedAnalyzerId != null)
            {
                 s += ind + "whitelistedAnalyzerId\n";

            }
            //      C# -> System.String? WhitelistedPath
            // GraphQL -> whitelistedPath: String! (scalar)
            if (this.WhitelistedPath != null)
            {
                 s += ind + "whitelistedPath\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsExplicit
            // GraphQL -> isExplicit: Boolean! (scalar)
            if (this.IsExplicit == null && Exploration.Includes(parent + ".isExplicit$"))
            {
                this.IsExplicit = new System.Boolean();
            }
            //      C# -> System.String? WhitelistedAnalyzerId
            // GraphQL -> whitelistedAnalyzerId: String! (scalar)
            if (this.WhitelistedAnalyzerId == null && Exploration.Includes(parent + ".whitelistedAnalyzerId$"))
            {
                this.WhitelistedAnalyzerId = new System.String("FETCH");
            }
            //      C# -> System.String? WhitelistedPath
            // GraphQL -> whitelistedPath: String! (scalar)
            if (this.WhitelistedPath == null && Exploration.Includes(parent + ".whitelistedPath$"))
            {
                this.WhitelistedPath = new System.String("FETCH");
            }
        }


    #endregion

    } // class WhitelistedAnalyzer
    #endregion

    public static class ListWhitelistedAnalyzerExtensions
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
            this List<WhitelistedAnalyzer> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<WhitelistedAnalyzer> list, 
            String parent = "")
        {
            var item = new WhitelistedAnalyzer();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types