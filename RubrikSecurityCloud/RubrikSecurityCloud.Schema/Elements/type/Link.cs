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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "Link";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        if (this.Href != null) {
            if (conf.Flat) {
                s += conf.Prefix + "href\n" ;
            } else {
                s += ind + "href\n" ;
            }
        }
        //      C# -> System.String? Rel
        // GraphQL -> rel: String! (scalar)
        if (this.Rel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rel\n" ;
            } else {
                s += ind + "rel\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        if (ec.Includes("href",true))
        {
            if(this.Href == null) {

                this.Href = "FETCH";

            } else {


            }
        }
        else if (this.Href != null && ec.Excludes("href",true))
        {
            this.Href = null;
        }
        //      C# -> System.String? Rel
        // GraphQL -> rel: String! (scalar)
        if (ec.Includes("rel",true))
        {
            if(this.Rel == null) {

                this.Rel = "FETCH";

            } else {


            }
        }
        else if (this.Rel != null && ec.Excludes("rel",true))
        {
            this.Rel = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Link> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Link> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Link());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Link> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types