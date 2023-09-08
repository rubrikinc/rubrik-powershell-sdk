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

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

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
        System.String? Description = null,
        System.String? Id = null,
        System.String? Title = null,
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
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Title != null ) {
            this.Title = Title;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        if (this.ArticleNumber != null) {
            s += ind + "articleNumber\n" ;
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
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        if (this.Cause != null) {
            var fspec = this.Cause.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cause {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        if (this.Environment != null) {
            var fspec = this.Environment.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "environment {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        if (this.Notes != null) {
            var fspec = this.Notes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "notes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        if (this.Resolution != null) {
            var fspec = this.Resolution.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "resolution {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "summary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        if (this.ArticleNumber == null && ec.Includes("articleNumber",true))
        {
            this.ArticleNumber = "FETCH";
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
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && ec.Includes("title",true))
        {
            this.Title = "FETCH";
        }
        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        if (this.Cause == null && ec.Includes("cause",false))
        {
            this.Cause = new List<ContentNode>();
            this.Cause.ApplyExploratoryFieldSpec(ec.NewChild("cause"));
        }
        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        if (this.Environment == null && ec.Includes("environment",false))
        {
            this.Environment = new List<ContentNode>();
            this.Environment.ApplyExploratoryFieldSpec(ec.NewChild("environment"));
        }
        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        if (this.Notes == null && ec.Includes("notes",false))
        {
            this.Notes = new List<ContentNode>();
            this.Notes.ApplyExploratoryFieldSpec(ec.NewChild("notes"));
        }
        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        if (this.Resolution == null && ec.Includes("resolution",false))
        {
            this.Resolution = new List<ContentNode>();
            this.Resolution.ApplyExploratoryFieldSpec(ec.NewChild("resolution"));
        }
        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        if (this.Summary == null && ec.Includes("summary",false))
        {
            this.Summary = new List<ContentNode>();
            this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));
        }
    }


    #endregion

    } // class KnowledgeBaseArticle
    
    #endregion

    public static class ListKnowledgeBaseArticleExtensions
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
            this List<KnowledgeBaseArticle> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KnowledgeBaseArticle> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KnowledgeBaseArticle());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<KnowledgeBaseArticle> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types