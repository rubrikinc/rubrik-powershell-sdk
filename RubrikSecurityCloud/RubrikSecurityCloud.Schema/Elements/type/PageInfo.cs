// PageInfo.cs
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
    #region PageInfo
    public class PageInfo: IFragment
    {
        #region members
        //      C# -> System.String? EndCursor
        // GraphQL -> endCursor: String! (scalar)
        [JsonProperty("endCursor")]
        public System.String? EndCursor { get; set; }

        //      C# -> System.Boolean? HasNextPage
        // GraphQL -> hasNextPage: Boolean! (scalar)
        [JsonProperty("hasNextPage")]
        public System.Boolean? HasNextPage { get; set; }

        //      C# -> System.Boolean? HasPreviousPage
        // GraphQL -> hasPreviousPage: Boolean! (scalar)
        [JsonProperty("hasPreviousPage")]
        public System.Boolean? HasPreviousPage { get; set; }

        //      C# -> System.String? StartCursor
        // GraphQL -> startCursor: String! (scalar)
        [JsonProperty("startCursor")]
        public System.String? StartCursor { get; set; }

        #endregion

    #region methods

    public PageInfo Set(
        System.String? EndCursor = null,
        System.Boolean? HasNextPage = null,
        System.Boolean? HasPreviousPage = null,
        System.String? StartCursor = null
    ) 
    {
        if ( EndCursor != null ) {
            this.EndCursor = EndCursor;
        }
        if ( HasNextPage != null ) {
            this.HasNextPage = HasNextPage;
        }
        if ( HasPreviousPage != null ) {
            this.HasPreviousPage = HasPreviousPage;
        }
        if ( StartCursor != null ) {
            this.StartCursor = StartCursor;
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
            //      C# -> System.String? EndCursor
            // GraphQL -> endCursor: String! (scalar)
            if (this.EndCursor != null)
            {
                 s += ind + "endCursor\n";

            }
            //      C# -> System.Boolean? HasNextPage
            // GraphQL -> hasNextPage: Boolean! (scalar)
            if (this.HasNextPage != null)
            {
                 s += ind + "hasNextPage\n";

            }
            //      C# -> System.Boolean? HasPreviousPage
            // GraphQL -> hasPreviousPage: Boolean! (scalar)
            if (this.HasPreviousPage != null)
            {
                 s += ind + "hasPreviousPage\n";

            }
            //      C# -> System.String? StartCursor
            // GraphQL -> startCursor: String! (scalar)
            if (this.StartCursor != null)
            {
                 s += ind + "startCursor\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EndCursor
            // GraphQL -> endCursor: String! (scalar)
            if (this.EndCursor == null && Exploration.Includes(parent + ".endCursor$"))
            {
                this.EndCursor = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasNextPage
            // GraphQL -> hasNextPage: Boolean! (scalar)
            if (this.HasNextPage == null && Exploration.Includes(parent + ".hasNextPage$"))
            {
                this.HasNextPage = new System.Boolean();
            }
            //      C# -> System.Boolean? HasPreviousPage
            // GraphQL -> hasPreviousPage: Boolean! (scalar)
            if (this.HasPreviousPage == null && Exploration.Includes(parent + ".hasPreviousPage$"))
            {
                this.HasPreviousPage = new System.Boolean();
            }
            //      C# -> System.String? StartCursor
            // GraphQL -> startCursor: String! (scalar)
            if (this.StartCursor == null && Exploration.Includes(parent + ".startCursor$"))
            {
                this.StartCursor = new System.String("FETCH");
            }
        }


    #endregion

    } // class PageInfo
    #endregion

    public static class ListPageInfoExtensions
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
            this List<PageInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PageInfo> list, 
            String parent = "")
        {
            var item = new PageInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types