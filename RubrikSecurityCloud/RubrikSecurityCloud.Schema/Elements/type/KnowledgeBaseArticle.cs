// KnowledgeBaseArticle.cs
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
    #region KnowledgeBaseArticle
    public class KnowledgeBaseArticle: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ArticleNumber
            // GraphQL -> articleNumber: String! (scalar)
            if (this.ArticleNumber != null)
            {
                 s += ind + "articleNumber\n";

            }
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
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title != null)
            {
                 s += ind + "title\n";

            }
            //      C# -> List<ContentNode>? Cause
            // GraphQL -> cause: [ContentNode!]! (type)
            if (this.Cause != null)
            {
                 s += ind + "cause\n";

                 s += ind + "{\n" + 
                 this.Cause.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ContentNode>? Environment
            // GraphQL -> environment: [ContentNode!]! (type)
            if (this.Environment != null)
            {
                 s += ind + "environment\n";

                 s += ind + "{\n" + 
                 this.Environment.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ContentNode>? Notes
            // GraphQL -> notes: [ContentNode!]! (type)
            if (this.Notes != null)
            {
                 s += ind + "notes\n";

                 s += ind + "{\n" + 
                 this.Notes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ContentNode>? Resolution
            // GraphQL -> resolution: [ContentNode!]! (type)
            if (this.Resolution != null)
            {
                 s += ind + "resolution\n";

                 s += ind + "{\n" + 
                 this.Resolution.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ContentNode>? Summary
            // GraphQL -> summary: [ContentNode!]! (type)
            if (this.Summary != null)
            {
                 s += ind + "summary\n";

                 s += ind + "{\n" + 
                 this.Summary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ArticleNumber
            // GraphQL -> articleNumber: String! (scalar)
            if (this.ArticleNumber == null && Exploration.Includes(parent + ".articleNumber$"))
            {
                this.ArticleNumber = new System.String("FETCH");
            }
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
            //      C# -> System.String? Title
            // GraphQL -> title: String! (scalar)
            if (this.Title == null && Exploration.Includes(parent + ".title$"))
            {
                this.Title = new System.String("FETCH");
            }
            //      C# -> List<ContentNode>? Cause
            // GraphQL -> cause: [ContentNode!]! (type)
            if (this.Cause == null && Exploration.Includes(parent + ".cause"))
            {
                this.Cause = new List<ContentNode>();
                this.Cause.ApplyExploratoryFragment(parent + ".cause");
            }
            //      C# -> List<ContentNode>? Environment
            // GraphQL -> environment: [ContentNode!]! (type)
            if (this.Environment == null && Exploration.Includes(parent + ".environment"))
            {
                this.Environment = new List<ContentNode>();
                this.Environment.ApplyExploratoryFragment(parent + ".environment");
            }
            //      C# -> List<ContentNode>? Notes
            // GraphQL -> notes: [ContentNode!]! (type)
            if (this.Notes == null && Exploration.Includes(parent + ".notes"))
            {
                this.Notes = new List<ContentNode>();
                this.Notes.ApplyExploratoryFragment(parent + ".notes");
            }
            //      C# -> List<ContentNode>? Resolution
            // GraphQL -> resolution: [ContentNode!]! (type)
            if (this.Resolution == null && Exploration.Includes(parent + ".resolution"))
            {
                this.Resolution = new List<ContentNode>();
                this.Resolution.ApplyExploratoryFragment(parent + ".resolution");
            }
            //      C# -> List<ContentNode>? Summary
            // GraphQL -> summary: [ContentNode!]! (type)
            if (this.Summary == null && Exploration.Includes(parent + ".summary"))
            {
                this.Summary = new List<ContentNode>();
                this.Summary.ApplyExploratoryFragment(parent + ".summary");
            }
        }


    #endregion

    } // class KnowledgeBaseArticle
    #endregion

    public static class ListKnowledgeBaseArticleExtensions
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
            this List<KnowledgeBaseArticle> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<KnowledgeBaseArticle> list, 
            String parent = "")
        {
            var item = new KnowledgeBaseArticle();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types