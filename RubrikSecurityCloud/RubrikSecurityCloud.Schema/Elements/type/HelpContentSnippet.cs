// HelpContentSnippet.cs
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
    #region HelpContentSnippet
    public class HelpContentSnippet: IFragment
    {
        #region members
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Link
        // GraphQL -> link: URL (scalar)
        [JsonProperty("link")]
        public System.String? Link { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> HelpContentSource? Source
        // GraphQL -> source: HelpContentSource! (enum)
        [JsonProperty("source")]
        public HelpContentSource? Source { get; set; }

        #endregion

    #region methods

    public HelpContentSnippet Set(
        System.String? Description = null,
        System.String? Id = null,
        System.String? Link = null,
        System.String? Title = null,
        HelpContentSource? Source = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Link != null ) {
            this.Link = Link;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( Source != null ) {
            this.Source = Source;
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
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Link
            // GraphQL -> link: URL (scalar)
            if (this.Link != null)
            {
                 s += ind + "link\n";

            }
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title != null)
            {
                 s += ind + "title\n";

            }
            //      C# -> HelpContentSource? Source
            // GraphQL -> source: HelpContentSource! (enum)
            if (this.Source != null)
            {
                 s += ind + "source\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Link
            // GraphQL -> link: URL (scalar)
            if (this.Link == null && Exploration.Includes(parent + ".link$"))
            {
                this.Link = new System.String("FETCH");
            }
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title == null && Exploration.Includes(parent + ".title$"))
            {
                this.Title = new System.String("FETCH");
            }
            //      C# -> HelpContentSource? Source
            // GraphQL -> source: HelpContentSource! (enum)
            if (this.Source == null && Exploration.Includes(parent + ".source$"))
            {
                this.Source = new HelpContentSource();
            }
        }


    #endregion

    } // class HelpContentSnippet
    #endregion

    public static class ListHelpContentSnippetExtensions
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
            this List<HelpContentSnippet> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HelpContentSnippet> list, 
            String parent = "")
        {
            var item = new HelpContentSnippet();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types