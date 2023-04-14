// ProductDocumentation.cs
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
    #region ProductDocumentation
    public class ProductDocumentation: IFragment
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

        //      C# -> System.String? Language
        // GraphQL -> language: String! (scalar)
        [JsonProperty("language")]
        public System.String? Language { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> List<ContentNode>? Contents
        // GraphQL -> contents: [ContentNode!]! (type)
        [JsonProperty("contents")]
        public List<ContentNode>? Contents { get; set; }

        //      C# -> List<RelatedContent>? Related
        // GraphQL -> related: [RelatedContent!]! (type)
        [JsonProperty("related")]
        public List<RelatedContent>? Related { get; set; }

        //      C# -> ProductDocumentationType? Type
        // GraphQL -> type: ProductDocumentationType! (enum)
        [JsonProperty("type")]
        public ProductDocumentationType? Type { get; set; }

        #endregion

    #region methods

    public ProductDocumentation Set(
        System.String? Description = null,
        System.String? Id = null,
        System.String? Language = null,
        System.String? Title = null,
        List<ContentNode>? Contents = null,
        List<RelatedContent>? Related = null,
        ProductDocumentationType? Type = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Language != null ) {
            this.Language = Language;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( Contents != null ) {
            this.Contents = Contents;
        }
        if ( Related != null ) {
            this.Related = Related;
        }
        if ( Type != null ) {
            this.Type = Type;
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
            //      C# -> System.String? Language
            // GraphQL -> language: String! (scalar)
            if (this.Language != null)
            {
                 s += ind + "language\n";

            }
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title != null)
            {
                 s += ind + "title\n";

            }
            //      C# -> List<ContentNode>? Contents
            // GraphQL -> contents: [ContentNode!]! (type)
            if (this.Contents != null)
            {
                 s += ind + "contents\n";

                 s += ind + "{\n" + 
                 this.Contents.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RelatedContent>? Related
            // GraphQL -> related: [RelatedContent!]! (type)
            if (this.Related != null)
            {
                 s += ind + "related\n";

                 s += ind + "{\n" + 
                 this.Related.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ProductDocumentationType? Type
            // GraphQL -> type: ProductDocumentationType! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

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
            //      C# -> System.String? Language
            // GraphQL -> language: String! (scalar)
            if (this.Language == null && Exploration.Includes(parent + ".language$"))
            {
                this.Language = new System.String("FETCH");
            }
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title == null && Exploration.Includes(parent + ".title$"))
            {
                this.Title = new System.String("FETCH");
            }
            //      C# -> List<ContentNode>? Contents
            // GraphQL -> contents: [ContentNode!]! (type)
            if (this.Contents == null && Exploration.Includes(parent + ".contents"))
            {
                this.Contents = new List<ContentNode>();
                this.Contents.ApplyExploratoryFragment(parent + ".contents");
            }
            //      C# -> List<RelatedContent>? Related
            // GraphQL -> related: [RelatedContent!]! (type)
            if (this.Related == null && Exploration.Includes(parent + ".related"))
            {
                this.Related = new List<RelatedContent>();
                this.Related.ApplyExploratoryFragment(parent + ".related");
            }
            //      C# -> ProductDocumentationType? Type
            // GraphQL -> type: ProductDocumentationType! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new ProductDocumentationType();
            }
        }


    #endregion

    } // class ProductDocumentation
    #endregion

    public static class ListProductDocumentationExtensions
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
            this List<ProductDocumentation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ProductDocumentation> list, 
            String parent = "")
        {
            var item = new ProductDocumentation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types