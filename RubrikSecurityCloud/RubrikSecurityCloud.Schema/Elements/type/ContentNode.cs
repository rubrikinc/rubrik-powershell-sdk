// ContentNode.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ContentNode
    public class ContentNode: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? Index
        // GraphQL -> index: Int (scalar)
        if (this.Index != null) {
            s += ind + "index\n" ;
        }
        //      C# -> System.Int32? ParentIndex
        // GraphQL -> parentIndex: Int (scalar)
        if (this.ParentIndex != null) {
            s += ind + "parentIndex\n" ;
        }
        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        if (this.Tag != null) {
            s += ind + "tag\n" ;
        }
        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        if (this.Text != null) {
            s += ind + "text\n" ;
        }
        //      C# -> List<ContentNodeAttribute>? Attributes
        // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
        if (this.Attributes != null) {
            var fspec = this.Attributes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "attributes {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Index
        // GraphQL -> index: Int (scalar)
        if (this.Index == null && Exploration.Includes(parent + ".index", true))
        {
            this.Index = Int32.MinValue;
        }
        //      C# -> System.Int32? ParentIndex
        // GraphQL -> parentIndex: Int (scalar)
        if (this.ParentIndex == null && Exploration.Includes(parent + ".parentIndex", true))
        {
            this.ParentIndex = Int32.MinValue;
        }
        //      C# -> System.String? Tag
        // GraphQL -> tag: String! (scalar)
        if (this.Tag == null && Exploration.Includes(parent + ".tag", true))
        {
            this.Tag = "FETCH";
        }
        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        if (this.Text == null && Exploration.Includes(parent + ".text", true))
        {
            this.Text = "FETCH";
        }
        //      C# -> List<ContentNodeAttribute>? Attributes
        // GraphQL -> attributes: [ContentNodeAttribute!]! (type)
        if (this.Attributes == null && Exploration.Includes(parent + ".attributes"))
        {
            this.Attributes = new List<ContentNodeAttribute>();
            this.Attributes.ApplyExploratoryFieldSpec(parent + ".attributes");
        }
    }


    #endregion

    } // class ContentNode
    
    #endregion

    public static class ListContentNodeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ContentNode> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ContentNode> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ContentNode());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types