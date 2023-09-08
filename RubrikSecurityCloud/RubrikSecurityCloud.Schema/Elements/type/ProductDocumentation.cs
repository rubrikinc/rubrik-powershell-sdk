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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ProductDocumentation
    public class ProductDocumentation: BaseType
    {
        #region members

        //      C# -> ProductDocumentationType? Type
        // GraphQL -> type: ProductDocumentationType! (enum)
        [JsonProperty("type")]
        public ProductDocumentationType? Type { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProductDocumentation";
    }

    public ProductDocumentation Set(
        ProductDocumentationType? Type = null,
        System.String? Description = null,
        System.String? Id = null,
        System.String? Language = null,
        System.String? Title = null,
        List<ContentNode>? Contents = null,
        List<RelatedContent>? Related = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ProductDocumentationType? Type
        // GraphQL -> type: ProductDocumentationType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Language
        // GraphQL -> language: String! (scalar)
        if (this.Language != null) {
            s += ind + "language\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        //      C# -> List<ContentNode>? Contents
        // GraphQL -> contents: [ContentNode!]! (type)
        if (this.Contents != null) {
            var fspec = this.Contents.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "contents {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<RelatedContent>? Related
        // GraphQL -> related: [RelatedContent!]! (type)
        if (this.Related != null) {
            var fspec = this.Related.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "related {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ProductDocumentationType? Type
        // GraphQL -> type: ProductDocumentationType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new ProductDocumentationType();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Language
        // GraphQL -> language: String! (scalar)
        if (this.Language == null && ec.Includes("language",true))
        {
            this.Language = "FETCH";
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && ec.Includes("title",true))
        {
            this.Title = "FETCH";
        }
        //      C# -> List<ContentNode>? Contents
        // GraphQL -> contents: [ContentNode!]! (type)
        if (this.Contents == null && ec.Includes("contents",false))
        {
            this.Contents = new List<ContentNode>();
            this.Contents.ApplyExploratoryFieldSpec(ec.NewChild("contents"));
        }
        //      C# -> List<RelatedContent>? Related
        // GraphQL -> related: [RelatedContent!]! (type)
        if (this.Related == null && ec.Includes("related",false))
        {
            this.Related = new List<RelatedContent>();
            this.Related.ApplyExploratoryFieldSpec(ec.NewChild("related"));
        }
    }


    #endregion

    } // class ProductDocumentation
    
    #endregion

    public static class ListProductDocumentationExtensions
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
            this List<ProductDocumentation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ProductDocumentation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProductDocumentation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ProductDocumentation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types