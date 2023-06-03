// AppSearchResponse.cs
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
    #region AppSearchResponse
    public class AppSearchResponse: BaseType
    {
        #region members

        //      C# -> System.String? ChildObjectId
        // GraphQL -> childObjectId: String! (scalar)
        [JsonProperty("childObjectId")]
        public System.String? ChildObjectId { get; set; }

        //      C# -> System.String? ChildObjectName
        // GraphQL -> childObjectName: String! (scalar)
        [JsonProperty("childObjectName")]
        public System.String? ChildObjectName { get; set; }

        //      C# -> SearchResultResponse? SearchResponse
        // GraphQL -> searchResponse: SearchResultResponse (type)
        [JsonProperty("searchResponse")]
        public SearchResultResponse? SearchResponse { get; set; }


        #endregion

    #region methods

    public AppSearchResponse Set(
        System.String? ChildObjectId = null,
        System.String? ChildObjectName = null,
        SearchResultResponse? SearchResponse = null
    ) 
    {
        if ( ChildObjectId != null ) {
            this.ChildObjectId = ChildObjectId;
        }
        if ( ChildObjectName != null ) {
            this.ChildObjectName = ChildObjectName;
        }
        if ( SearchResponse != null ) {
            this.SearchResponse = SearchResponse;
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
        //      C# -> System.String? ChildObjectId
        // GraphQL -> childObjectId: String! (scalar)
        if (this.ChildObjectId != null) {
            s += ind + "childObjectId\n" ;
        }
        //      C# -> System.String? ChildObjectName
        // GraphQL -> childObjectName: String! (scalar)
        if (this.ChildObjectName != null) {
            s += ind + "childObjectName\n" ;
        }
        //      C# -> SearchResultResponse? SearchResponse
        // GraphQL -> searchResponse: SearchResultResponse (type)
        if (this.SearchResponse != null) {
            s += ind + "searchResponse {\n" + this.SearchResponse.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ChildObjectId
        // GraphQL -> childObjectId: String! (scalar)
        if (this.ChildObjectId == null && Exploration.Includes(parent + ".childObjectId", true))
        {
            this.ChildObjectId = new System.String("FETCH");
        }
        //      C# -> System.String? ChildObjectName
        // GraphQL -> childObjectName: String! (scalar)
        if (this.ChildObjectName == null && Exploration.Includes(parent + ".childObjectName", true))
        {
            this.ChildObjectName = new System.String("FETCH");
        }
        //      C# -> SearchResultResponse? SearchResponse
        // GraphQL -> searchResponse: SearchResultResponse (type)
        if (this.SearchResponse == null && Exploration.Includes(parent + ".searchResponse"))
        {
            this.SearchResponse = new SearchResultResponse();
            this.SearchResponse.ApplyExploratoryFieldSpec(parent + ".searchResponse");
        }
    }


    #endregion

    } // class AppSearchResponse
    
    #endregion

    public static class ListAppSearchResponseExtensions
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
            this List<AppSearchResponse> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AppSearchResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AppSearchResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types