// Link.cs
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
    #region Link
    public class Link: IFragment
    {
        #region members
        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        [JsonProperty("href")]
        public System.String? Href { get; set; }

        //      C# -> System.String? Rel
        // GraphQL -> rel: String! (scalar)
        [JsonProperty("rel")]
        public System.String? Rel { get; set; }

        #endregion

    #region methods

    public Link Set(
        System.String? Href = null,
        System.String? Rel = null
    ) 
    {
        if ( Href != null ) {
            this.Href = Href;
        }
        if ( Rel != null ) {
            this.Rel = Rel;
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
            //      C# -> System.String? Href
            // GraphQL -> href: String! (scalar)
            if (this.Href != null)
            {
                 s += ind + "href\n";

            }
            //      C# -> System.String? Rel
            // GraphQL -> rel: String! (scalar)
            if (this.Rel != null)
            {
                 s += ind + "rel\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Href
            // GraphQL -> href: String! (scalar)
            if (this.Href == null && Exploration.Includes(parent + ".href$"))
            {
                this.Href = new System.String("FETCH");
            }
            //      C# -> System.String? Rel
            // GraphQL -> rel: String! (scalar)
            if (this.Rel == null && Exploration.Includes(parent + ".rel$"))
            {
                this.Rel = new System.String("FETCH");
            }
        }


    #endregion

    } // class Link
    #endregion

    public static class ListLinkExtensions
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
            this List<Link> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Link> list, 
            String parent = "")
        {
            var item = new Link();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types