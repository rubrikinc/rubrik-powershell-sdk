// Link.cs
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
    #region Link
    public class Link: BaseType
    {
        #region members

        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        [JsonProperty("href")]
        public System.String? Href { get; set; }

        //      C# -> System.String? Rel
        // GraphQL -> rel: String! (scalar)
        [JsonProperty("rel")]
        public System.String? Rel { get; set; }


        #endregion

    #region methods

    public Link Set(
        System.String? Href = null,
        System.String? Rel = null
    ) 
    {
        if ( Href != null ) {
            this.Href = Href;
        }
        if ( Rel != null ) {
            this.Rel = Rel;
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
        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        if (this.Href != null) {
            s += ind + "href\n" ;
        }
        //      C# -> System.String? Rel
        // GraphQL -> rel: String! (scalar)
        if (this.Rel != null) {
            s += ind + "rel\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        if (this.Href == null && Exploration.Includes(parent + ".href", true))
        {
            this.Href = "FETCH";
        }
        //      C# -> System.String? Rel
        // GraphQL -> rel: String! (scalar)
        if (this.Rel == null && Exploration.Includes(parent + ".rel", true))
        {
            this.Rel = "FETCH";
        }
    }


    #endregion

    } // class Link
    
    #endregion

    public static class ListLinkExtensions
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
            this List<Link> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Link> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Link());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types