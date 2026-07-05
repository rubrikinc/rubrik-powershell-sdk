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

        //      C# -> System.String? NextDocId
        // GraphQL -> nextDocId: String! (scalar)
        [JsonProperty("nextDocId")]
        public System.String? NextDocId { get; set; }

        //      C# -> System.String? NextDocTitle
        // GraphQL -> nextDocTitle: String! (scalar)
        [JsonProperty("nextDocTitle")]
        public System.String? NextDocTitle { get; set; }

        //      C# -> System.String? PrevDocId
        // GraphQL -> prevDocId: String! (scalar)
        [JsonProperty("prevDocId")]
        public System.String? PrevDocId { get; set; }

        //      C# -> System.String? PrevDocTitle
        // GraphQL -> prevDocTitle: String! (scalar)
        [JsonProperty("prevDocTitle")]
        public System.String? PrevDocTitle { get; set; }

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
        System.String? NextDocId = null,
        System.String? NextDocTitle = null,
        System.String? PrevDocId = null,
        System.String? PrevDocTitle = null,
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
        if ( NextDocId != null ) {
            this.NextDocId = NextDocId;
        }
        if ( NextDocTitle != null ) {
            this.NextDocTitle = NextDocTitle;
        }
        if ( PrevDocId != null ) {
            this.PrevDocId = PrevDocId;
        }
        if ( PrevDocTitle != null ) {
            this.PrevDocTitle = PrevDocTitle;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ProductDocumentationType? Type
        // GraphQL -> type: ProductDocumentationType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Language
        // GraphQL -> language: String! (scalar)
        if (this.Language != null) {
            if (conf.Flat) {
                s += conf.Prefix + "language\n" ;
            } else {
                s += ind + "language\n" ;
            }
        }
        //      C# -> System.String? NextDocId
        // GraphQL -> nextDocId: String! (scalar)
        if (this.NextDocId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextDocId\n" ;
            } else {
                s += ind + "nextDocId\n" ;
            }
        }
        //      C# -> System.String? NextDocTitle
        // GraphQL -> nextDocTitle: String! (scalar)
        if (this.NextDocTitle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextDocTitle\n" ;
            } else {
                s += ind + "nextDocTitle\n" ;
            }
        }
        //      C# -> System.String? PrevDocId
        // GraphQL -> prevDocId: String! (scalar)
        if (this.PrevDocId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "prevDocId\n" ;
            } else {
                s += ind + "prevDocId\n" ;
            }
        }
        //      C# -> System.String? PrevDocTitle
        // GraphQL -> prevDocTitle: String! (scalar)
        if (this.PrevDocTitle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "prevDocTitle\n" ;
            } else {
                s += ind + "prevDocTitle\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> List<ContentNode>? Contents
        // GraphQL -> contents: [ContentNode!]! (type)
        if (this.Contents != null) {
            var fspec = this.Contents.AsFieldSpec(conf.Child("contents"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "contents" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RelatedContent>? Related
        // GraphQL -> related: [RelatedContent!]! (type)
        if (this.Related != null) {
            var fspec = this.Related.AsFieldSpec(conf.Child("related"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "related" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ProductDocumentationType? Type
        // GraphQL -> type: ProductDocumentationType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ProductDocumentationType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Language
        // GraphQL -> language: String! (scalar)
        if (ec.Includes("language",true))
        {
            if(this.Language == null) {

                this.Language = "FETCH";

            } else {


            }
        }
        else if (this.Language != null && ec.Excludes("language",true))
        {
            this.Language = null;
        }
        //      C# -> System.String? NextDocId
        // GraphQL -> nextDocId: String! (scalar)
        if (ec.Includes("nextDocId",true))
        {
            if(this.NextDocId == null) {

                this.NextDocId = "FETCH";

            } else {


            }
        }
        else if (this.NextDocId != null && ec.Excludes("nextDocId",true))
        {
            this.NextDocId = null;
        }
        //      C# -> System.String? NextDocTitle
        // GraphQL -> nextDocTitle: String! (scalar)
        if (ec.Includes("nextDocTitle",true))
        {
            if(this.NextDocTitle == null) {

                this.NextDocTitle = "FETCH";

            } else {


            }
        }
        else if (this.NextDocTitle != null && ec.Excludes("nextDocTitle",true))
        {
            this.NextDocTitle = null;
        }
        //      C# -> System.String? PrevDocId
        // GraphQL -> prevDocId: String! (scalar)
        if (ec.Includes("prevDocId",true))
        {
            if(this.PrevDocId == null) {

                this.PrevDocId = "FETCH";

            } else {


            }
        }
        else if (this.PrevDocId != null && ec.Excludes("prevDocId",true))
        {
            this.PrevDocId = null;
        }
        //      C# -> System.String? PrevDocTitle
        // GraphQL -> prevDocTitle: String! (scalar)
        if (ec.Includes("prevDocTitle",true))
        {
            if(this.PrevDocTitle == null) {

                this.PrevDocTitle = "FETCH";

            } else {


            }
        }
        else if (this.PrevDocTitle != null && ec.Excludes("prevDocTitle",true))
        {
            this.PrevDocTitle = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> List<ContentNode>? Contents
        // GraphQL -> contents: [ContentNode!]! (type)
        if (ec.Includes("contents",false))
        {
            if(this.Contents == null) {

                this.Contents = new List<ContentNode>();
                this.Contents.ApplyExploratoryFieldSpec(ec.NewChild("contents"));

            } else {

                this.Contents.ApplyExploratoryFieldSpec(ec.NewChild("contents"));

            }
        }
        else if (this.Contents != null && ec.Excludes("contents",false))
        {
            this.Contents = null;
        }
        //      C# -> List<RelatedContent>? Related
        // GraphQL -> related: [RelatedContent!]! (type)
        if (ec.Includes("related",false))
        {
            if(this.Related == null) {

                this.Related = new List<RelatedContent>();
                this.Related.ApplyExploratoryFieldSpec(ec.NewChild("related"));

            } else {

                this.Related.ApplyExploratoryFieldSpec(ec.NewChild("related"));

            }
        }
        else if (this.Related != null && ec.Excludes("related",false))
        {
            this.Related = null;
        }
    }


    #endregion

    } // class ProductDocumentation
    
    #endregion

    public static class ListProductDocumentationExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ProductDocumentation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProductDocumentation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProductDocumentation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProductDocumentation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProductDocumentation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types