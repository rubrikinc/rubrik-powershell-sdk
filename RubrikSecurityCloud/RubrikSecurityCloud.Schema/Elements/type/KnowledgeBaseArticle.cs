// KnowledgeBaseArticle.cs
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
    #region KnowledgeBaseArticle
    public class KnowledgeBaseArticle: BaseType
    {
        #region members

        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        [JsonProperty("articleNumber")]
        public System.String? ArticleNumber { get; set; }

        //      C# -> System.String? Author
        // GraphQL -> author: String! (scalar)
        [JsonProperty("author")]
        public System.String? Author { get; set; }

        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> System.String? RecordType
        // GraphQL -> recordType: String! (scalar)
        [JsonProperty("recordType")]
        public System.String? RecordType { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> System.Int32? ViewCount
        // GraphQL -> viewCount: Int! (scalar)
        [JsonProperty("viewCount")]
        public System.Int32? ViewCount { get; set; }

        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        [JsonProperty("cause")]
        public List<ContentNode>? Cause { get; set; }

        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        [JsonProperty("environment")]
        public List<ContentNode>? Environment { get; set; }

        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        [JsonProperty("notes")]
        public List<ContentNode>? Notes { get; set; }

        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        [JsonProperty("resolution")]
        public List<ContentNode>? Resolution { get; set; }

        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        [JsonProperty("summary")]
        public List<ContentNode>? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KnowledgeBaseArticle";
    }

    public KnowledgeBaseArticle Set(
        System.String? ArticleNumber = null,
        System.String? Author = null,
        DateTime? CreatedDate = null,
        System.String? Description = null,
        System.String? Id = null,
        DateTime? LastModified = null,
        System.String? RecordType = null,
        System.String? Title = null,
        System.Int32? ViewCount = null,
        List<ContentNode>? Cause = null,
        List<ContentNode>? Environment = null,
        List<ContentNode>? Notes = null,
        List<ContentNode>? Resolution = null,
        List<ContentNode>? Summary = null
    ) 
    {
        if ( ArticleNumber != null ) {
            this.ArticleNumber = ArticleNumber;
        }
        if ( Author != null ) {
            this.Author = Author;
        }
        if ( CreatedDate != null ) {
            this.CreatedDate = CreatedDate;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( RecordType != null ) {
            this.RecordType = RecordType;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( ViewCount != null ) {
            this.ViewCount = ViewCount;
        }
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( Environment != null ) {
            this.Environment = Environment;
        }
        if ( Notes != null ) {
            this.Notes = Notes;
        }
        if ( Resolution != null ) {
            this.Resolution = Resolution;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        if (this.ArticleNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "articleNumber\n" ;
            } else {
                s += ind + "articleNumber\n" ;
            }
        }
        //      C# -> System.String? Author
        // GraphQL -> author: String! (scalar)
        if (this.Author != null) {
            if (conf.Flat) {
                s += conf.Prefix + "author\n" ;
            } else {
                s += ind + "author\n" ;
            }
        }
        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        if (this.CreatedDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDate\n" ;
            } else {
                s += ind + "createdDate\n" ;
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
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (this.LastModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModified\n" ;
            } else {
                s += ind + "lastModified\n" ;
            }
        }
        //      C# -> System.String? RecordType
        // GraphQL -> recordType: String! (scalar)
        if (this.RecordType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recordType\n" ;
            } else {
                s += ind + "recordType\n" ;
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
        //      C# -> System.Int32? ViewCount
        // GraphQL -> viewCount: Int! (scalar)
        if (this.ViewCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "viewCount\n" ;
            } else {
                s += ind + "viewCount\n" ;
            }
        }
        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        if (this.Cause != null) {
            var fspec = this.Cause.AsFieldSpec(conf.Child("cause"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cause" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        if (this.Environment != null) {
            var fspec = this.Environment.AsFieldSpec(conf.Child("environment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "environment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        if (this.Notes != null) {
            var fspec = this.Notes.AsFieldSpec(conf.Child("notes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "notes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        if (this.Resolution != null) {
            var fspec = this.Resolution.AsFieldSpec(conf.Child("resolution"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resolution" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(conf.Child("summary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "summary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        if (ec.Includes("articleNumber",true))
        {
            if(this.ArticleNumber == null) {

                this.ArticleNumber = "FETCH";

            } else {


            }
        }
        else if (this.ArticleNumber != null && ec.Excludes("articleNumber",true))
        {
            this.ArticleNumber = null;
        }
        //      C# -> System.String? Author
        // GraphQL -> author: String! (scalar)
        if (ec.Includes("author",true))
        {
            if(this.Author == null) {

                this.Author = "FETCH";

            } else {


            }
        }
        else if (this.Author != null && ec.Excludes("author",true))
        {
            this.Author = null;
        }
        //      C# -> DateTime? CreatedDate
        // GraphQL -> createdDate: DateTime (scalar)
        if (ec.Includes("createdDate",true))
        {
            if(this.CreatedDate == null) {

                this.CreatedDate = new DateTime();

            } else {


            }
        }
        else if (this.CreatedDate != null && ec.Excludes("createdDate",true))
        {
            this.CreatedDate = null;
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
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime (scalar)
        if (ec.Includes("lastModified",true))
        {
            if(this.LastModified == null) {

                this.LastModified = new DateTime();

            } else {


            }
        }
        else if (this.LastModified != null && ec.Excludes("lastModified",true))
        {
            this.LastModified = null;
        }
        //      C# -> System.String? RecordType
        // GraphQL -> recordType: String! (scalar)
        if (ec.Includes("recordType",true))
        {
            if(this.RecordType == null) {

                this.RecordType = "FETCH";

            } else {


            }
        }
        else if (this.RecordType != null && ec.Excludes("recordType",true))
        {
            this.RecordType = null;
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
        //      C# -> System.Int32? ViewCount
        // GraphQL -> viewCount: Int! (scalar)
        if (ec.Includes("viewCount",true))
        {
            if(this.ViewCount == null) {

                this.ViewCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ViewCount != null && ec.Excludes("viewCount",true))
        {
            this.ViewCount = null;
        }
        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        if (ec.Includes("cause",false))
        {
            if(this.Cause == null) {

                this.Cause = new List<ContentNode>();
                this.Cause.ApplyExploratoryFieldSpec(ec.NewChild("cause"));

            } else {

                this.Cause.ApplyExploratoryFieldSpec(ec.NewChild("cause"));

            }
        }
        else if (this.Cause != null && ec.Excludes("cause",false))
        {
            this.Cause = null;
        }
        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        if (ec.Includes("environment",false))
        {
            if(this.Environment == null) {

                this.Environment = new List<ContentNode>();
                this.Environment.ApplyExploratoryFieldSpec(ec.NewChild("environment"));

            } else {

                this.Environment.ApplyExploratoryFieldSpec(ec.NewChild("environment"));

            }
        }
        else if (this.Environment != null && ec.Excludes("environment",false))
        {
            this.Environment = null;
        }
        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        if (ec.Includes("notes",false))
        {
            if(this.Notes == null) {

                this.Notes = new List<ContentNode>();
                this.Notes.ApplyExploratoryFieldSpec(ec.NewChild("notes"));

            } else {

                this.Notes.ApplyExploratoryFieldSpec(ec.NewChild("notes"));

            }
        }
        else if (this.Notes != null && ec.Excludes("notes",false))
        {
            this.Notes = null;
        }
        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        if (ec.Includes("resolution",false))
        {
            if(this.Resolution == null) {

                this.Resolution = new List<ContentNode>();
                this.Resolution.ApplyExploratoryFieldSpec(ec.NewChild("resolution"));

            } else {

                this.Resolution.ApplyExploratoryFieldSpec(ec.NewChild("resolution"));

            }
        }
        else if (this.Resolution != null && ec.Excludes("resolution",false))
        {
            this.Resolution = null;
        }
        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        if (ec.Includes("summary",false))
        {
            if(this.Summary == null) {

                this.Summary = new List<ContentNode>();
                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            } else {

                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            }
        }
        else if (this.Summary != null && ec.Excludes("summary",false))
        {
            this.Summary = null;
        }
    }


    #endregion

    } // class KnowledgeBaseArticle
    
    #endregion

    public static class ListKnowledgeBaseArticleExtensions
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
            this List<KnowledgeBaseArticle> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<KnowledgeBaseArticle> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<KnowledgeBaseArticle> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KnowledgeBaseArticle());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<KnowledgeBaseArticle> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types