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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        if (this.AbsolutePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "absolutePath\n" ;
            } else {
                s += ind + "absolutePath\n" ;
            }
        }
        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        if (this.DisplayPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayPath\n" ;
            } else {
                s += ind + "displayPath\n" ;
            }
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filename\n" ;
            } else {
                s += ind + "filename\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> List<CloudNativeFileVersion>? FileVersions
        // GraphQL -> fileVersions: [CloudNativeFileVersion!]! (type)
        if (this.FileVersions != null) {
            var fspec = this.FileVersions.AsFieldSpec(conf.Child("fileVersions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileVersions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        if (ec.Includes("absolutePath",true))
        {
            if(this.AbsolutePath == null) {

                this.AbsolutePath = "FETCH";

            } else {


            }
        }
        else if (this.AbsolutePath != null && ec.Excludes("absolutePath",true))
        {
            this.AbsolutePath = null;
        }
        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        if (ec.Includes("displayPath",true))
        {
            if(this.DisplayPath == null) {

                this.DisplayPath = "FETCH";

            } else {


            }
        }
        else if (this.DisplayPath != null && ec.Excludes("displayPath",true))
        {
            this.DisplayPath = null;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (ec.Includes("filename",true))
        {
            if(this.Filename == null) {

                this.Filename = "FETCH";

            } else {


            }
        }
        else if (this.Filename != null && ec.Excludes("filename",true))
        {
            this.Filename = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> List<CloudNativeFileVersion>? FileVersions
        // GraphQL -> fileVersions: [CloudNativeFileVersion!]! (type)
        if (ec.Includes("fileVersions",false))
        {
            if(this.FileVersions == null) {

                this.FileVersions = new List<CloudNativeFileVersion>();
                this.FileVersions.ApplyExploratoryFieldSpec(ec.NewChild("fileVersions"));

            } else {

                this.FileVersions.ApplyExploratoryFieldSpec(ec.NewChild("fileVersions"));

            }
        }
        else if (this.FileVersions != null && ec.Excludes("fileVersions",false))
        {
            this.FileVersions = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CloudNativeVersionedFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeVersionedFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeVersionedFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeVersionedFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types