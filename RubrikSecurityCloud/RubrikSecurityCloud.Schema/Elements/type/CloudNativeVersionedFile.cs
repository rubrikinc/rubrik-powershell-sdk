// CloudNativeVersionedFile.cs
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
    #region CloudNativeVersionedFile
    public class CloudNativeVersionedFile: BaseType
    {
        #region members

        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        [JsonProperty("absolutePath")]
        public System.String? AbsolutePath { get; set; }

        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        [JsonProperty("displayPath")]
        public System.String? DisplayPath { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<CloudNativeFileVersion>? FileVersions
        // GraphQL -> fileVersions: [CloudNativeFileVersion!]! (type)
        [JsonProperty("fileVersions")]
        public List<CloudNativeFileVersion>? FileVersions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeVersionedFile";
    }

    public CloudNativeVersionedFile Set(
        System.String? AbsolutePath = null,
        System.String? DisplayPath = null,
        System.String? Filename = null,
        System.String? Path = null,
        List<CloudNativeFileVersion>? FileVersions = null
    ) 
    {
        if ( AbsolutePath != null ) {
            this.AbsolutePath = AbsolutePath;
        }
        if ( DisplayPath != null ) {
            this.DisplayPath = DisplayPath;
        }
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
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        if (this.AbsolutePath != null) {
            s += ind + "absolutePath\n" ;
        }
        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        if (this.DisplayPath != null) {
            s += ind + "displayPath\n" ;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            s += ind + "filename\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> List<CloudNativeFileVersion>? FileVersions
        // GraphQL -> fileVersions: [CloudNativeFileVersion!]! (type)
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
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        if (this.AbsolutePath == null && Exploration.Includes(parent + ".absolutePath", true))
        {
            this.AbsolutePath = "FETCH";
        }
        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        if (this.DisplayPath == null && Exploration.Includes(parent + ".displayPath", true))
        {
            this.DisplayPath = "FETCH";
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename == null && Exploration.Includes(parent + ".filename", true))
        {
            this.Filename = "FETCH";
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = "FETCH";
        }
        //      C# -> List<CloudNativeFileVersion>? FileVersions
        // GraphQL -> fileVersions: [CloudNativeFileVersion!]! (type)
        if (this.FileVersions == null && Exploration.Includes(parent + ".fileVersions"))
        {
            this.FileVersions = new List<CloudNativeFileVersion>();
            this.FileVersions.ApplyExploratoryFieldSpec(parent + ".fileVersions");
        }
    }


    #endregion

    } // class CloudNativeVersionedFile
    
    #endregion

    public static class ListCloudNativeVersionedFileExtensions
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
            this List<CloudNativeVersionedFile> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeVersionedFile> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeVersionedFile());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types