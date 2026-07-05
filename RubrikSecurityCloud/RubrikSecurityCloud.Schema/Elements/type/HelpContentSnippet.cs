// HelpContentSnippet.cs
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
    #region HelpContentSnippet
    public class HelpContentSnippet: BaseType
    {
        #region members

        //      C# -> HelpContentSource? Source
        // GraphQL -> source: HelpContentSource! (enum)
        [JsonProperty("source")]
        public HelpContentSource? Source { get; set; }

        //      C# -> System.String? Category
        // GraphQL -> category: String! (scalar)
        [JsonProperty("category")]
        public System.String? Category { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        [JsonProperty("lastUpdated")]
        public DateTime? LastUpdated { get; set; }

        //      C# -> System.String? Link
        // GraphQL -> link: URL (scalar)
        [JsonProperty("link")]
        public System.String? Link { get; set; }

        //      C# -> System.String? SourceLabel
        // GraphQL -> sourceLabel: String! (scalar)
        [JsonProperty("sourceLabel")]
        public System.String? SourceLabel { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HelpContentSnippet";
    }

    public HelpContentSnippet Set(
        HelpContentSource? Source = null,
        System.String? Category = null,
        System.String? Description = null,
        System.String? Id = null,
        DateTime? LastUpdated = null,
        System.String? Link = null,
        System.String? SourceLabel = null,
        System.String? Title = null
    ) 
    {
        if ( Source != null ) {
            this.Source = Source;
        }
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastUpdated != null ) {
            this.LastUpdated = LastUpdated;
        }
        if ( Link != null ) {
            this.Link = Link;
        }
        if ( SourceLabel != null ) {
            this.SourceLabel = SourceLabel;
        }
        if ( Title != null ) {
            this.Title = Title;
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
        //      C# -> HelpContentSource? Source
        // GraphQL -> source: HelpContentSource! (enum)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        //      C# -> System.String? Category
        // GraphQL -> category: String! (scalar)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
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
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (this.LastUpdated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdated\n" ;
            } else {
                s += ind + "lastUpdated\n" ;
            }
        }
        //      C# -> System.String? Link
        // GraphQL -> link: URL (scalar)
        if (this.Link != null) {
            if (conf.Flat) {
                s += conf.Prefix + "link\n" ;
            } else {
                s += ind + "link\n" ;
            }
        }
        //      C# -> System.String? SourceLabel
        // GraphQL -> sourceLabel: String! (scalar)
        if (this.SourceLabel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceLabel\n" ;
            } else {
                s += ind + "sourceLabel\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HelpContentSource? Source
        // GraphQL -> source: HelpContentSource! (enum)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = new HelpContentSource();

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
        //      C# -> System.String? Category
        // GraphQL -> category: String! (scalar)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = "FETCH";

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
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
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (ec.Includes("lastUpdated",true))
        {
            if(this.LastUpdated == null) {

                this.LastUpdated = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdated != null && ec.Excludes("lastUpdated",true))
        {
            this.LastUpdated = null;
        }
        //      C# -> System.String? Link
        // GraphQL -> link: URL (scalar)
        if (ec.Includes("link",true))
        {
            if(this.Link == null) {

                this.Link = "FETCH";

            } else {


            }
        }
        else if (this.Link != null && ec.Excludes("link",true))
        {
            this.Link = null;
        }
        //      C# -> System.String? SourceLabel
        // GraphQL -> sourceLabel: String! (scalar)
        if (ec.Includes("sourceLabel",true))
        {
            if(this.SourceLabel == null) {

                this.SourceLabel = "FETCH";

            } else {


            }
        }
        else if (this.SourceLabel != null && ec.Excludes("sourceLabel",true))
        {
            this.SourceLabel = null;
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
    }


    #endregion

    } // class HelpContentSnippet
    
    #endregion

    public static class ListHelpContentSnippetExtensions
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
            this List<HelpContentSnippet> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HelpContentSnippet> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HelpContentSnippet> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HelpContentSnippet());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HelpContentSnippet> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types