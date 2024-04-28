// VersionedFile.cs
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
    #region VersionedFile
    public class VersionedFile: BaseType
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

        //      C# -> List<HierarchySnappableFileVersion>? FileVersions
        // GraphQL -> fileVersions: [HierarchySnappableFileVersion!]! (type)
        [JsonProperty("fileVersions")]
        public List<HierarchySnappableFileVersion>? FileVersions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VersionedFile";
    }

    public VersionedFile Set(
        System.String? AbsolutePath = null,
        System.String? DisplayPath = null,
        System.String? Filename = null,
        System.String? Path = null,
        List<HierarchySnappableFileVersion>? FileVersions = null
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> List<HierarchySnappableFileVersion>? FileVersions
        // GraphQL -> fileVersions: [HierarchySnappableFileVersion!]! (type)
        if (this.FileVersions != null) {
            var fspec = this.FileVersions.AsFieldSpec(conf.Child("fileVersions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileVersions" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<HierarchySnappableFileVersion>? FileVersions
        // GraphQL -> fileVersions: [HierarchySnappableFileVersion!]! (type)
        if (ec.Includes("fileVersions",false))
        {
            if(this.FileVersions == null) {

                this.FileVersions = new List<HierarchySnappableFileVersion>();
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

    } // class VersionedFile
    
    #endregion

    public static class ListVersionedFileExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VersionedFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VersionedFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VersionedFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VersionedFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VersionedFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types