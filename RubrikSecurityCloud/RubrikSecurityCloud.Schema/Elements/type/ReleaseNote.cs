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

        //      C# -> List<System.String>? CdmDependencies
        // GraphQL -> cdmDependencies: [String!]! (scalar)
        [JsonProperty("cdmDependencies")]
        public List<System.String>? CdmDependencies { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<System.String>? FeatureLimitations
        // GraphQL -> featureLimitations: [String!]! (scalar)
        [JsonProperty("featureLimitations")]
        public List<System.String>? FeatureLimitations { get; set; }

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
        List<System.String>? CdmDependencies = null,
        System.String? Description = null,
        List<System.String>? FeatureLimitations = null,
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
        if ( CdmDependencies != null ) {
            this.CdmDependencies = CdmDependencies;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( FeatureLimitations != null ) {
            this.FeatureLimitations = FeatureLimitations;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ReleaseNoteTypeType? Type
        // GraphQL -> type: ReleaseNoteTypeType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> List<System.String>? CdmDependencies
        // GraphQL -> cdmDependencies: [String!]! (scalar)
        if (this.CdmDependencies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmDependencies\n" ;
            } else {
                s += ind + "cdmDependencies\n" ;
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
        //      C# -> List<System.String>? FeatureLimitations
        // GraphQL -> featureLimitations: [String!]! (scalar)
        if (this.FeatureLimitations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "featureLimitations\n" ;
            } else {
                s += ind + "featureLimitations\n" ;
            }
        }
        //      C# -> System.String? HelpUrl
        // GraphQL -> helpUrl: URL (scalar)
        if (this.HelpUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "helpUrl\n" ;
            } else {
                s += ind + "helpUrl\n" ;
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
        //      C# -> System.String? JiraKey
        // GraphQL -> jiraKey: String! (scalar)
        if (this.JiraKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jiraKey\n" ;
            } else {
                s += ind + "jiraKey\n" ;
            }
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "releaseDate\n" ;
            } else {
                s += ind + "releaseDate\n" ;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(conf.Child("tags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tags" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ReleaseNoteTypeType? Type
        // GraphQL -> type: ReleaseNoteTypeType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ReleaseNoteTypeType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> List<System.String>? CdmDependencies
        // GraphQL -> cdmDependencies: [String!]! (scalar)
        if (ec.Includes("cdmDependencies",true))
        {
            if(this.CdmDependencies == null) {

                this.CdmDependencies = new List<System.String>();

            } else {


            }
        }
        else if (this.CdmDependencies != null && ec.Excludes("cdmDependencies",true))
        {
            this.CdmDependencies = null;
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
        //      C# -> List<System.String>? FeatureLimitations
        // GraphQL -> featureLimitations: [String!]! (scalar)
        if (ec.Includes("featureLimitations",true))
        {
            if(this.FeatureLimitations == null) {

                this.FeatureLimitations = new List<System.String>();

            } else {


            }
        }
        else if (this.FeatureLimitations != null && ec.Excludes("featureLimitations",true))
        {
            this.FeatureLimitations = null;
        }
        //      C# -> System.String? HelpUrl
        // GraphQL -> helpUrl: URL (scalar)
        if (ec.Includes("helpUrl",true))
        {
            if(this.HelpUrl == null) {

                this.HelpUrl = "FETCH";

            } else {


            }
        }
        else if (this.HelpUrl != null && ec.Excludes("helpUrl",true))
        {
            this.HelpUrl = null;
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
        //      C# -> System.String? JiraKey
        // GraphQL -> jiraKey: String! (scalar)
        if (ec.Includes("jiraKey",true))
        {
            if(this.JiraKey == null) {

                this.JiraKey = "FETCH";

            } else {


            }
        }
        else if (this.JiraKey != null && ec.Excludes("jiraKey",true))
        {
            this.JiraKey = null;
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (ec.Includes("releaseDate",true))
        {
            if(this.ReleaseDate == null) {

                this.ReleaseDate = new DateTime();

            } else {


            }
        }
        else if (this.ReleaseDate != null && ec.Excludes("releaseDate",true))
        {
            this.ReleaseDate = null;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<ReleaseNoteTag>? Tags
        // GraphQL -> tags: [ReleaseNoteTag!]! (type)
        if (ec.Includes("tags",false))
        {
            if(this.Tags == null) {

                this.Tags = new List<ReleaseNoteTag>();
                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            } else {

                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            }
        }
        else if (this.Tags != null && ec.Excludes("tags",false))
        {
            this.Tags = null;
        }
    }


    #endregion

    } // class ReleaseNote
    
    #endregion

    public static class ListReleaseNoteExtensions
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
            this List<ReleaseNote> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReleaseNote> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<ReleaseNote> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types