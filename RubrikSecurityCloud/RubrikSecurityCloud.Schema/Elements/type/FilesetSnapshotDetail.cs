// FilesetSnapshotDetail.cs
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
    #region FilesetSnapshotDetail
    public class FilesetSnapshotDetail: BaseType
    {
        #region members

        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String! (scalar)
        [JsonProperty("lastModified")]
        public System.String? LastModified { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
        // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
        [JsonProperty("filesetSnapshotSummary")]
        public FilesetSnapshotSummary? FilesetSnapshotSummary { get; set; }

        //      C# -> FilesetSnapshotVerbose? Verbose
        // GraphQL -> verbose: FilesetSnapshotVerbose (type)
        [JsonProperty("verbose")]
        public FilesetSnapshotVerbose? Verbose { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetSnapshotDetail";
    }

    public FilesetSnapshotDetail Set(
        System.String? LastModified = null,
        System.Int64? Size = null,
        FilesetSnapshotSummary? FilesetSnapshotSummary = null,
        FilesetSnapshotVerbose? Verbose = null
    ) 
    {
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( FilesetSnapshotSummary != null ) {
            this.FilesetSnapshotSummary = FilesetSnapshotSummary;
        }
        if ( Verbose != null ) {
            this.Verbose = Verbose;
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
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String! (scalar)
        if (this.LastModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModified\n" ;
            } else {
                s += ind + "lastModified\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
        // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
        if (this.FilesetSnapshotSummary != null) {
            var fspec = this.FilesetSnapshotSummary.AsFieldSpec(conf.Child("filesetSnapshotSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesetSnapshotSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FilesetSnapshotVerbose? Verbose
        // GraphQL -> verbose: FilesetSnapshotVerbose (type)
        if (this.Verbose != null) {
            var fspec = this.Verbose.AsFieldSpec(conf.Child("verbose"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "verbose" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String! (scalar)
        if (ec.Includes("lastModified",true))
        {
            if(this.LastModified == null) {

                this.LastModified = "FETCH";

            } else {


            }
        }
        else if (this.LastModified != null && ec.Excludes("lastModified",true))
        {
            this.LastModified = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> FilesetSnapshotSummary? FilesetSnapshotSummary
        // GraphQL -> filesetSnapshotSummary: FilesetSnapshotSummary (type)
        if (ec.Includes("filesetSnapshotSummary",false))
        {
            if(this.FilesetSnapshotSummary == null) {

                this.FilesetSnapshotSummary = new FilesetSnapshotSummary();
                this.FilesetSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("filesetSnapshotSummary"));

            } else {

                this.FilesetSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("filesetSnapshotSummary"));

            }
        }
        else if (this.FilesetSnapshotSummary != null && ec.Excludes("filesetSnapshotSummary",false))
        {
            this.FilesetSnapshotSummary = null;
        }
        //      C# -> FilesetSnapshotVerbose? Verbose
        // GraphQL -> verbose: FilesetSnapshotVerbose (type)
        if (ec.Includes("verbose",false))
        {
            if(this.Verbose == null) {

                this.Verbose = new FilesetSnapshotVerbose();
                this.Verbose.ApplyExploratoryFieldSpec(ec.NewChild("verbose"));

            } else {

                this.Verbose.ApplyExploratoryFieldSpec(ec.NewChild("verbose"));

            }
        }
        else if (this.Verbose != null && ec.Excludes("verbose",false))
        {
            this.Verbose = null;
        }
    }


    #endregion

    } // class FilesetSnapshotDetail
    
    #endregion

    public static class ListFilesetSnapshotDetailExtensions
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
            this List<FilesetSnapshotDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilesetSnapshotDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetSnapshotDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetSnapshotDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetSnapshotDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types