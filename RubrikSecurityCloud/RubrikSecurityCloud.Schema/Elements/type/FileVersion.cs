// FileVersion.cs
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
    #region FileVersion
    public class FileVersion: BaseType
    {
        #region members

        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        [JsonProperty("fileMode")]
        public System.String? FileMode { get; set; }

        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        [JsonProperty("lastModified")]
        public System.String? LastModified { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? Source
        // GraphQL -> source: String (scalar)
        [JsonProperty("source")]
        public System.String? Source { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FileVersion";
    }

    public FileVersion Set(
        System.String? FileMode = null,
        System.String? LastModified = null,
        System.Int64? Size = null,
        System.String? SnapshotId = null,
        System.String? Source = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( LastModified != null ) {
            this.LastModified = LastModified;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( Source != null ) {
            this.Source = Source;
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
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        if (this.FileMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileMode\n" ;
            } else {
                s += ind + "fileMode\n" ;
            }
        }
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
        if (this.LastModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModified\n" ;
            } else {
                s += ind + "lastModified\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String (scalar)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FileMode
        // GraphQL -> fileMode: String (scalar)
        if (ec.Includes("fileMode",true))
        {
            if(this.FileMode == null) {

                this.FileMode = "FETCH";

            } else {


            }
        }
        else if (this.FileMode != null && ec.Excludes("fileMode",true))
        {
            this.FileMode = null;
        }
        //      C# -> System.String? LastModified
        // GraphQL -> lastModified: String (scalar)
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
        // GraphQL -> size: Long (scalar)
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? Source
        // GraphQL -> source: String (scalar)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = "FETCH";

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
    }


    #endregion

    } // class FileVersion
    
    #endregion

    public static class ListFileVersionExtensions
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
            this List<FileVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FileVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FileVersion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types