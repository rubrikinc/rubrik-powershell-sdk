// VsphereLink.cs
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
    #region VsphereLink
    public class VsphereLink: BaseType
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
        return "VsphereLink";
    }

    public VsphereLink Set(
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

    } // class VsphereLink
    
    #endregion

    public static class ListVsphereLinkExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VsphereLink> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereLink> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereLink> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereLink());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereLink> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types