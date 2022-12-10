// ContentNode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:01.
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
    #region ContentNode
    public class ContentNode: IFragment
    {
        #region members
        //      C# -> System.Int32? Index
        // GraphQL -> index: Int (scalar)
        [JsonProperty("index")]
        public System.Int32? Index { get; set; }

        //      C# -> System.Int32? ParentIndex
        // GraphQL -> parentIndex: Int (scalar)
        [JsonProperty("parentIndex")]
        public System.Int32? ParentIndex { get; set; }

        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        [JsonProperty("tag")]
        public System.String? Tag { get; set; }

        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        [JsonProperty("text")]
        public System.String? Text { get; set; }

        //      C# -> List<ContentNodeAttribute>? Attributes
        // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
        [JsonProperty("attributes")]
        public List<ContentNodeAttribute>? Attributes { get; set; }

        #endregion

    #region methods

    public ContentNode Set(
        System.Int32? Index = null,
        System.Int32? ParentIndex = null,
        System.String? Tag = null,
        System.String? Text = null,
        List<ContentNodeAttribute>? Attributes = null
    ) 
    {
        if ( Index != null ) {
            this.Index = Index;
        }
        if ( ParentIndex != null ) {
            this.ParentIndex = ParentIndex;
        }
        if ( Tag != null ) {
            this.Tag = Tag;
        }
        if ( Text != null ) {
            this.Text = Text;
        }
        if ( Attributes != null ) {
            this.Attributes = Attributes;
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
            //      C# -> System.Int32? Index
            // GraphQL -> index: Int (scalar)
            if (this.Index != null)
            {
                 s += ind + "index\n";

            }
            //      C# -> System.Int32? ParentIndex
            // GraphQL -> parentIndex: Int (scalar)
            if (this.ParentIndex != null)
            {
                 s += ind + "parentIndex\n";

            }
            //      C# -> System.String? Tag
            // GraphQL -> tag: String! (scalar)
            if (this.Tag != null)
            {
                 s += ind + "tag\n";

            }
            //      C# -> System.String? Text
            // GraphQL -> text: String! (scalar)
            if (this.Text != null)
            {
                 s += ind + "text\n";

            }
            //      C# -> List<ContentNodeAttribute>? Attributes
            // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
            if (this.Attributes != null)
            {
                 s += ind + "attributes\n";

                 s += ind + "{\n" + 
                 this.Attributes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Index
            // GraphQL -> index: Int (scalar)
            if (this.Index == null && Exploration.Includes(parent + ".index$"))
            {
                this.Index = new System.Int32();
            }
            //      C# -> System.Int32? ParentIndex
            // GraphQL -> parentIndex: Int (scalar)
            if (this.ParentIndex == null && Exploration.Includes(parent + ".parentIndex$"))
            {
                this.ParentIndex = new System.Int32();
            }
            //      C# -> System.String? Tag
            // GraphQL -> tag: String! (scalar)
            if (this.Tag == null && Exploration.Includes(parent + ".tag$"))
            {
                this.Tag = new System.String("FETCH");
            }
            //      C# -> System.String? Text
            // GraphQL -> text: String! (scalar)
            if (this.Text == null && Exploration.Includes(parent + ".text$"))
            {
                this.Text = new System.String("FETCH");
            }
            //      C# -> List<ContentNodeAttribute>? Attributes
            // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
            if (this.Attributes == null && Exploration.Includes(parent + ".attributes"))
            {
                this.Attributes = new List<ContentNodeAttribute>();
                this.Attributes.ApplyExploratoryFragment(parent + ".attributes");
            }
        }


    #endregion

    } // class ContentNode
    #endregion

    public static class ListContentNodeExtensions
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
            this List<ContentNode> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ContentNode> list, 
            String parent = "")
        {
            var item = new ContentNode();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types