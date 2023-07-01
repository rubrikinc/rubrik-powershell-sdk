// BrowseResponse.cs
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
    #region BrowseResponse
    public class BrowseResponse: BaseType
    {
        #region members

        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        [JsonProperty("fileMode")]
        public System.String? FileMode { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        [JsonProperty("lastModified")]
        public System.String? LastModified { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> System.Int32? Unreadable
        // GraphQL -> unreadable: Int (scalar)
        [JsonProperty("unreadable")]
        public System.Int32? Unreadable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BrowseResponse";
    }

    public BrowseResponse Set(
        System.String? FileMode = null,
        System.String? Filename = null,
        System.String? LastModified = null,
        System.String? Path = null,
        System.Int64? Size = null,
        System.String? StatusMessage = null,
        System.Int32? Unreadable = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( StatusMessage != null ) {
            this.StatusMessage = StatusMessage;
        }
        if ( Unreadable != null ) {
            this.Unreadable = Unreadable;
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
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        if (this.FileMode != null) {
            s += ind + "fileMode\n" ;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        if (this.Filename != null) {
            s += ind + "filename\n" ;
        }
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (this.StatusMessage != null) {
            s += ind + "statusMessage\n" ;
        }
        //      C# -> System.Int32? Unreadable
        // GraphQL -> unreadable: Int (scalar)
        if (this.Unreadable != null) {
            s += ind + "unreadable\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        if (this.FileMode == null && Exploration.Includes(parent + ".fileMode", true))
        {
            this.FileMode = "FETCH";
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String (scalar)
        if (this.Filename == null && Exploration.Includes(parent + ".filename", true))
        {
            this.Filename = "FETCH";
        }
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        if (this.LastModified == null && Exploration.Includes(parent + ".lastModified", true))
        {
            this.LastModified = "FETCH";
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String (scalar)
        if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage", true))
        {
            this.StatusMessage = "FETCH";
        }
        //      C# -> System.Int32? Unreadable
        // GraphQL -> unreadable: Int (scalar)
        if (this.Unreadable == null && Exploration.Includes(parent + ".unreadable", true))
        {
            this.Unreadable = Int32.MinValue;
        }
    }


    #endregion

    } // class BrowseResponse
    
    #endregion

    public static class ListBrowseResponseExtensions
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
            this List<BrowseResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BrowseResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BrowseResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types