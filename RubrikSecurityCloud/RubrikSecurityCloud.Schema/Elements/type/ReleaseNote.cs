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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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

        //      C# -> ReleaseNoteFeatureFlag? FeatureFlag
        // GraphQL -> featureFlag: ReleaseNoteFeatureFlag (type)
        [JsonProperty("featureFlag")]
        public ReleaseNoteFeatureFlag? FeatureFlag { get; set; }

        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        [JsonProperty("tags")]
        public List<ReleaseNoteTag>? Tags { get; set; }


        #endregion

    #region methods

    public ReleaseNote Set(
        ReleaseNoteTypeType? Type = null,
        System.String? Description = null,
        System.String? HelpUrl = null,
        System.String? Id = null,
        DateTime? ReleaseDate = null,
        System.String? Title = null,
        System.String? Version = null,
        ReleaseNoteFeatureFlag? FeatureFlag = null,
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
        if ( ReleaseDate != null ) {
            this.ReleaseDate = ReleaseDate;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( FeatureFlag != null ) {
            this.FeatureFlag = FeatureFlag;
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
        //      C# -> ReleaseNoteFeatureFlag? FeatureFlag
        // GraphQL -> featureFlag: ReleaseNoteFeatureFlag (type)
        if (this.FeatureFlag != null) {
            s += ind + "featureFlag {\n" + this.FeatureFlag.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        if (this.Tags != null) {
            s += ind + "tags {\n" + this.Tags.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ReleaseNoteTypeType? Type
        // GraphQL -> type: ReleaseNoteTypeType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new ReleaseNoteTypeType();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = new System.String("FETCH");
        }
        //      C# -> System.String? HelpUrl
        // GraphQL -> helpUrl: URL (scalar)
        if (this.HelpUrl == null && Exploration.Includes(parent + ".helpUrl", true))
        {
            this.HelpUrl = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate == null && Exploration.Includes(parent + ".releaseDate", true))
        {
            this.ReleaseDate = new DateTime();
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && Exploration.Includes(parent + ".title", true))
        {
            this.Title = new System.String("FETCH");
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.String("FETCH");
        }
        //      C# -> ReleaseNoteFeatureFlag? FeatureFlag
        // GraphQL -> featureFlag: ReleaseNoteFeatureFlag (type)
        if (this.FeatureFlag == null && Exploration.Includes(parent + ".featureFlag"))
        {
            this.FeatureFlag = new ReleaseNoteFeatureFlag();
            this.FeatureFlag.ApplyExploratoryFieldSpec(parent + ".featureFlag");
        }
        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        if (this.Tags == null && Exploration.Includes(parent + ".tags"))
        {
            this.Tags = new List<ReleaseNoteTag>();
            this.Tags.ApplyExploratoryFieldSpec(parent + ".tags");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReleaseNote> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReleaseNote());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types