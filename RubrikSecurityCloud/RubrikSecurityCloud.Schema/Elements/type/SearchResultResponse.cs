// SearchResultResponse.cs
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
    #region SearchResultResponse
    public class SearchResultResponse: BaseType
    {
        #region members

        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<VappFileVersion>? FileVersions
        // GraphQL -> fileVersions: [VappFileVersion!]! (type)
        [JsonProperty("fileVersions")]
        public List<VappFileVersion>? FileVersions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SearchResultResponse";
    }

    public SearchResultResponse Set(
        System.String? Filename = null,
        System.String? Path = null,
        List<VappFileVersion>? FileVersions = null
    ) 
    {
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( FileVersions != null ) {
            this.FileVersions = FileVersions;
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
        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        if (this.Filename != null) {
            s += ind + "filename\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> List<VappFileVersion>? FileVersions
        // GraphQL -> fileVersions: [VappFileVersion!]! (type)
        if (this.FileVersions != null) {
            var fspec = this.FileVersions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "fileVersions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        if (this.Filename == null && ec.Includes("filename",true))
        {
            this.Filename = "FETCH";
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        if (this.Path == null && ec.Includes("path",true))
        {
            this.Path = "FETCH";
        }
        //      C# -> List<VappFileVersion>? FileVersions
        // GraphQL -> fileVersions: [VappFileVersion!]! (type)
        if (this.FileVersions == null && ec.Includes("fileVersions",false))
        {
            this.FileVersions = new List<VappFileVersion>();
            this.FileVersions.ApplyExploratoryFieldSpec(ec.NewChild("fileVersions"));
        }
    }


    #endregion

    } // class SearchResultResponse
    
    #endregion

    public static class ListSearchResultResponseExtensions
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
            this List<SearchResultResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SearchResultResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SearchResultResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SearchResultResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types