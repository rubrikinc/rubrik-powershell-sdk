// ReleaseNote.cs
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
    #region ReleaseNote
    public class ReleaseNote: BaseType
    {
        #region members

        //      C# -> ReleaseNoteTypeType? Type
        // GraphQL -> type: ReleaseNoteTypeType! (enum)
        [JsonProperty("type")]
        public ReleaseNoteTypeType? Type { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? HelpUrl
        // GraphQL -> helpUrl: URL (scalar)
        [JsonProperty("helpUrl")]
        public System.String? HelpUrl { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? JiraKey
        // GraphQL -> jiraKey: String! (scalar)
        [JsonProperty("jiraKey")]
        public System.String? JiraKey { get; set; }

        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        [JsonProperty("releaseDate")]
        public DateTime? ReleaseDate { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        [JsonProperty("tags")]
        public List<ReleaseNoteTag>? Tags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReleaseNote";
    }

    public ReleaseNote Set(
        ReleaseNoteTypeType? Type = null,
        System.String? Description = null,
        System.String? HelpUrl = null,
        System.String? Id = null,
        System.String? JiraKey = null,
        DateTime? ReleaseDate = null,
        System.String? Title = null,
        System.String? Version = null,
        List<ReleaseNoteTag>? Tags = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( HelpUrl != null ) {
            this.HelpUrl = HelpUrl;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( JiraKey != null ) {
            this.JiraKey = JiraKey;
        }
        if ( ReleaseDate != null ) {
            this.ReleaseDate = ReleaseDate;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
        //      C# -> ReleaseNoteTypeType? Type
        // GraphQL -> type: ReleaseNoteTypeType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? HelpUrl
        // GraphQL -> helpUrl: URL (scalar)
        if (this.HelpUrl != null) {
            s += ind + "helpUrl\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? JiraKey
        // GraphQL -> jiraKey: String! (scalar)
        if (this.JiraKey != null) {
            s += ind + "jiraKey\n" ;
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate != null) {
            s += ind + "releaseDate\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "tags {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReleaseNoteTypeType? Type
        // GraphQL -> type: ReleaseNoteTypeType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new ReleaseNoteTypeType();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? HelpUrl
        // GraphQL -> helpUrl: URL (scalar)
        if (this.HelpUrl == null && ec.Includes("helpUrl",true))
        {
            this.HelpUrl = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? JiraKey
        // GraphQL -> jiraKey: String! (scalar)
        if (this.JiraKey == null && ec.Includes("jiraKey",true))
        {
            this.JiraKey = "FETCH";
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate == null && ec.Includes("releaseDate",true))
        {
            this.ReleaseDate = new DateTime();
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && ec.Includes("title",true))
        {
            this.Title = "FETCH";
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && ec.Includes("version",true))
        {
            this.Version = "FETCH";
        }
        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        if (this.Tags == null && ec.Includes("tags",false))
        {
            this.Tags = new List<ReleaseNoteTag>();
            this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));
        }
    }


    #endregion

    } // class ReleaseNote
    
    #endregion

    public static class ListReleaseNoteExtensions
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
            this List<ReleaseNote> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReleaseNote> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReleaseNote());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ReleaseNote> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types