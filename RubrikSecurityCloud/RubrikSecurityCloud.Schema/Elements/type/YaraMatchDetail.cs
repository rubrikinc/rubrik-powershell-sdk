// YaraMatchDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:40.
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
    #region YaraMatchDetail
    public class YaraMatchDetail: IFragment
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? Tags
        // GraphQL -> tags: [String!]! (scalar)
        [JsonProperty("tags")]
        public List<System.String>? Tags { get; set; }

        #endregion

    #region methods

    public YaraMatchDetail Set(
        System.String? Name = null,
        List<System.String>? Tags = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> List<System.String>? Tags
            // GraphQL -> tags: [String!]! (scalar)
            if (this.Tags != null)
            {
                 s += ind + "tags\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> List<System.String>? Tags
            // GraphQL -> tags: [String!]! (scalar)
            if (this.Tags == null && Exploration.Includes(parent + ".tags$"))
            {
                this.Tags = new List<System.String>();
            }
        }


    #endregion

    } // class YaraMatchDetail
    #endregion

    public static class ListYaraMatchDetailExtensions
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
            this List<YaraMatchDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<YaraMatchDetail> list, 
            String parent = "")
        {
            var item = new YaraMatchDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types