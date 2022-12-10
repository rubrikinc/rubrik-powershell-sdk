// TagRuleTag.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:18.
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
    #region TagRuleTag
    public class TagRuleTag: IFragment
    {
        #region members
        //      C# -> System.Boolean? MatchAllValues
        // GraphQL -> matchAllValues: Boolean! (scalar)
        [JsonProperty("matchAllValues")]
        public System.Boolean? MatchAllValues { get; set; }

        //      C# -> System.String? TagKey
        // GraphQL -> tagKey: String! (scalar)
        [JsonProperty("tagKey")]
        public System.String? TagKey { get; set; }

        //      C# -> System.String? TagValue
        // GraphQL -> tagValue: String! (scalar)
        [JsonProperty("tagValue")]
        public System.String? TagValue { get; set; }

        #endregion

    #region methods

    public TagRuleTag Set(
        System.Boolean? MatchAllValues = null,
        System.String? TagKey = null,
        System.String? TagValue = null
    ) 
    {
        if ( MatchAllValues != null ) {
            this.MatchAllValues = MatchAllValues;
        }
        if ( TagKey != null ) {
            this.TagKey = TagKey;
        }
        if ( TagValue != null ) {
            this.TagValue = TagValue;
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
            //      C# -> System.Boolean? MatchAllValues
            // GraphQL -> matchAllValues: Boolean! (scalar)
            if (this.MatchAllValues != null)
            {
                 s += ind + "matchAllValues\n";

            }
            //      C# -> System.String? TagKey
            // GraphQL -> tagKey: String! (scalar)
            if (this.TagKey != null)
            {
                 s += ind + "tagKey\n";

            }
            //      C# -> System.String? TagValue
            // GraphQL -> tagValue: String! (scalar)
            if (this.TagValue != null)
            {
                 s += ind + "tagValue\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? MatchAllValues
            // GraphQL -> matchAllValues: Boolean! (scalar)
            if (this.MatchAllValues == null && Exploration.Includes(parent + ".matchAllValues$"))
            {
                this.MatchAllValues = new System.Boolean();
            }
            //      C# -> System.String? TagKey
            // GraphQL -> tagKey: String! (scalar)
            if (this.TagKey == null && Exploration.Includes(parent + ".tagKey$"))
            {
                this.TagKey = new System.String("FETCH");
            }
            //      C# -> System.String? TagValue
            // GraphQL -> tagValue: String! (scalar)
            if (this.TagValue == null && Exploration.Includes(parent + ".tagValue$"))
            {
                this.TagValue = new System.String("FETCH");
            }
        }


    #endregion

    } // class TagRuleTag
    #endregion

    public static class ListTagRuleTagExtensions
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
            this List<TagRuleTag> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TagRuleTag> list, 
            String parent = "")
        {
            var item = new TagRuleTag();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types