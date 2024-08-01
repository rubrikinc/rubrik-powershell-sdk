// RecentlyViewedItem.cs
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
    #region RecentlyViewedItem
    public class RecentlyViewedItem: BaseType
    {
        #region members

        //      C# -> System.String? CustomAttributes
        // GraphQL -> customAttributes: String! (scalar)
        [JsonProperty("customAttributes")]
        public System.String? CustomAttributes { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastInteracted
        // GraphQL -> lastInteracted: DateTime (scalar)
        [JsonProperty("lastInteracted")]
        public DateTime? LastInteracted { get; set; }

        //      C# -> System.String? Link
        // GraphQL -> link: String! (scalar)
        [JsonProperty("link")]
        public System.String? Link { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecentlyViewedItem";
    }

    public RecentlyViewedItem Set(
        System.String? CustomAttributes = null,
        System.String? Id = null,
        DateTime? LastInteracted = null,
        System.String? Link = null,
        System.String? Title = null
    ) 
    {
        if ( CustomAttributes != null ) {
            this.CustomAttributes = CustomAttributes;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastInteracted != null ) {
            this.LastInteracted = LastInteracted;
        }
        if ( Link != null ) {
            this.Link = Link;
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
        //      C# -> System.String? CustomAttributes
        // GraphQL -> customAttributes: String! (scalar)
        if (this.CustomAttributes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customAttributes\n" ;
            } else {
                s += ind + "customAttributes\n" ;
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
        //      C# -> DateTime? LastInteracted
        // GraphQL -> lastInteracted: DateTime (scalar)
        if (this.LastInteracted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastInteracted\n" ;
            } else {
                s += ind + "lastInteracted\n" ;
            }
        }
        //      C# -> System.String? Link
        // GraphQL -> link: String! (scalar)
        if (this.Link != null) {
            if (conf.Flat) {
                s += conf.Prefix + "link\n" ;
            } else {
                s += ind + "link\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CustomAttributes
        // GraphQL -> customAttributes: String! (scalar)
        if (ec.Includes("customAttributes",true))
        {
            if(this.CustomAttributes == null) {

                this.CustomAttributes = "FETCH";

            } else {


            }
        }
        else if (this.CustomAttributes != null && ec.Excludes("customAttributes",true))
        {
            this.CustomAttributes = null;
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
        //      C# -> DateTime? LastInteracted
        // GraphQL -> lastInteracted: DateTime (scalar)
        if (ec.Includes("lastInteracted",true))
        {
            if(this.LastInteracted == null) {

                this.LastInteracted = new DateTime();

            } else {


            }
        }
        else if (this.LastInteracted != null && ec.Excludes("lastInteracted",true))
        {
            this.LastInteracted = null;
        }
        //      C# -> System.String? Link
        // GraphQL -> link: String! (scalar)
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

    } // class RecentlyViewedItem
    
    #endregion

    public static class ListRecentlyViewedItemExtensions
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
            this List<RecentlyViewedItem> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecentlyViewedItem> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecentlyViewedItem> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecentlyViewedItem());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecentlyViewedItem> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types