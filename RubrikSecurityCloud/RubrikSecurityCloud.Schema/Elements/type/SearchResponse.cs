// SearchResponse.cs
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
    #region SearchResponse
    public class SearchResponse: BaseType
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

        //      C# -> List<FileVersion>? FileVersions
        // GraphQL -> fileVersions: [FileVersion!]! (type)
        [JsonProperty("fileVersions")]
        public List<FileVersion>? FileVersions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SearchResponse";
    }

    public SearchResponse Set(
        System.String? Filename = null,
        System.String? Path = null,
        List<FileVersion>? FileVersions = null
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
        //      C# -> List<FileVersion>? FileVersions
        // GraphQL -> fileVersions: [FileVersion!]! (type)
        if (this.FileVersions != null) {
            var fspec = this.FileVersions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "fileVersions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        if (this.Filename == null && Exploration.Includes(parent + ".filename", true))
        {
            this.Filename = "FETCH";
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = "FETCH";
        }
        //      C# -> List<FileVersion>? FileVersions
        // GraphQL -> fileVersions: [FileVersion!]! (type)
        if (this.FileVersions == null && Exploration.Includes(parent + ".fileVersions"))
        {
            this.FileVersions = new List<FileVersion>();
            this.FileVersions.ApplyExploratoryFieldSpec(parent + ".fileVersions");
        }
    }


    #endregion

    } // class SearchResponse
    
    #endregion

    public static class ListSearchResponseExtensions
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
            this List<SearchResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SearchResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SearchResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types