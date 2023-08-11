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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? CustomAttributes
        // GraphQL -> customAttributes: String! (scalar)
        if (this.CustomAttributes != null) {
            s += ind + "customAttributes\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LastInteracted
        // GraphQL -> lastInteracted: DateTime (scalar)
        if (this.LastInteracted != null) {
            s += ind + "lastInteracted\n" ;
        }
        //      C# -> System.String? Link
        // GraphQL -> link: String! (scalar)
        if (this.Link != null) {
            s += ind + "link\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CustomAttributes
        // GraphQL -> customAttributes: String! (scalar)
        if (this.CustomAttributes == null && Exploration.Includes(parent + ".customAttributes", true))
        {
            this.CustomAttributes = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? LastInteracted
        // GraphQL -> lastInteracted: DateTime (scalar)
        if (this.LastInteracted == null && Exploration.Includes(parent + ".lastInteracted", true))
        {
            this.LastInteracted = new DateTime();
        }
        //      C# -> System.String? Link
        // GraphQL -> link: String! (scalar)
        if (this.Link == null && Exploration.Includes(parent + ".link", true))
        {
            this.Link = "FETCH";
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && Exploration.Includes(parent + ".title", true))
        {
            this.Title = "FETCH";
        }
    }


    #endregion

    } // class RecentlyViewedItem
    
    #endregion

    public static class ListRecentlyViewedItemExtensions
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
            this List<RecentlyViewedItem> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecentlyViewedItem> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RecentlyViewedItem());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types