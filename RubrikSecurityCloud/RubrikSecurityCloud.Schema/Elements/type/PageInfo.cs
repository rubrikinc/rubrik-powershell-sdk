// PageInfo.cs
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
    #region PageInfo
    public class PageInfo: BaseType
    {
        #region members

        //      C# -> System.String? EndCursor
        // GraphQL -> endCursor: String! (scalar)
        [JsonProperty("endCursor")]
        public System.String? EndCursor { get; set; }

        //      C# -> System.Boolean? HasNextPage
        // GraphQL -> hasNextPage: Boolean! (scalar)
        [JsonProperty("hasNextPage")]
        public System.Boolean? HasNextPage { get; set; }

        //      C# -> System.Boolean? HasPreviousPage
        // GraphQL -> hasPreviousPage: Boolean! (scalar)
        [JsonProperty("hasPreviousPage")]
        public System.Boolean? HasPreviousPage { get; set; }

        //      C# -> System.String? StartCursor
        // GraphQL -> startCursor: String! (scalar)
        [JsonProperty("startCursor")]
        public System.String? StartCursor { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PageInfo";
    }

    public PageInfo Set(
        System.String? EndCursor = null,
        System.Boolean? HasNextPage = null,
        System.Boolean? HasPreviousPage = null,
        System.String? StartCursor = null
    ) 
    {
        if ( EndCursor != null ) {
            this.EndCursor = EndCursor;
        }
        if ( HasNextPage != null ) {
            this.HasNextPage = HasNextPage;
        }
        if ( HasPreviousPage != null ) {
            this.HasPreviousPage = HasPreviousPage;
        }
        if ( StartCursor != null ) {
            this.StartCursor = StartCursor;
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
        //      C# -> System.String? EndCursor
        // GraphQL -> endCursor: String! (scalar)
        if (this.EndCursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endCursor\n" ;
            } else {
                s += ind + "endCursor\n" ;
            }
        }
        //      C# -> System.Boolean? HasNextPage
        // GraphQL -> hasNextPage: Boolean! (scalar)
        if (this.HasNextPage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasNextPage\n" ;
            } else {
                s += ind + "hasNextPage\n" ;
            }
        }
        //      C# -> System.Boolean? HasPreviousPage
        // GraphQL -> hasPreviousPage: Boolean! (scalar)
        if (this.HasPreviousPage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPreviousPage\n" ;
            } else {
                s += ind + "hasPreviousPage\n" ;
            }
        }
        //      C# -> System.String? StartCursor
        // GraphQL -> startCursor: String! (scalar)
        if (this.StartCursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startCursor\n" ;
            } else {
                s += ind + "startCursor\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EndCursor
        // GraphQL -> endCursor: String! (scalar)
        if (ec.Includes("endCursor",true))
        {
            if(this.EndCursor == null) {

                this.EndCursor = "FETCH";

            } else {


            }
        }
        else if (this.EndCursor != null && ec.Excludes("endCursor",true))
        {
            this.EndCursor = null;
        }
        //      C# -> System.Boolean? HasNextPage
        // GraphQL -> hasNextPage: Boolean! (scalar)
        if (ec.Includes("hasNextPage",true))
        {
            if(this.HasNextPage == null) {

                this.HasNextPage = true;

            } else {


            }
        }
        else if (this.HasNextPage != null && ec.Excludes("hasNextPage",true))
        {
            this.HasNextPage = null;
        }
        //      C# -> System.Boolean? HasPreviousPage
        // GraphQL -> hasPreviousPage: Boolean! (scalar)
        if (ec.Includes("hasPreviousPage",true))
        {
            if(this.HasPreviousPage == null) {

                this.HasPreviousPage = true;

            } else {


            }
        }
        else if (this.HasPreviousPage != null && ec.Excludes("hasPreviousPage",true))
        {
            this.HasPreviousPage = null;
        }
        //      C# -> System.String? StartCursor
        // GraphQL -> startCursor: String! (scalar)
        if (ec.Includes("startCursor",true))
        {
            if(this.StartCursor == null) {

                this.StartCursor = "FETCH";

            } else {


            }
        }
        else if (this.StartCursor != null && ec.Excludes("startCursor",true))
        {
            this.StartCursor = null;
        }
    }


    #endregion

    } // class PageInfo
    
    #endregion

    public static class ListPageInfoExtensions
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
            this List<PageInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PageInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PageInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PageInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PageInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types