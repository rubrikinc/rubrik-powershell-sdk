// GlobalSearchFile.cs
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
    #region GlobalSearchFile
    public class GlobalSearchFile: BaseType
    {
        #region members

        //      C# -> List<System.String>? Dirs
        // GraphQL -> dirs: [String!]! (scalar)
        [JsonProperty("dirs")]
        public List<System.String>? Dirs { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.Boolean? IsFile
        // GraphQL -> isFile: Boolean! (scalar)
        [JsonProperty("isFile")]
        public System.Boolean? IsFile { get; set; }

        //      C# -> System.Int64? ModifiedTime
        // GraphQL -> modifiedTime: Long (scalar)
        [JsonProperty("modifiedTime")]
        public System.Int64? ModifiedTime { get; set; }

        //      C# -> System.Int32? NumSnapshots
        // GraphQL -> numSnapshots: Int (scalar)
        [JsonProperty("numSnapshots")]
        public System.Int32? NumSnapshots { get; set; }

        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long (scalar)
        [JsonProperty("sizeInBytes")]
        public System.Int64? SizeInBytes { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        [JsonProperty("snappableName")]
        public System.String? SnappableName { get; set; }

        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long (scalar)
        [JsonProperty("snapshotTime")]
        public System.Int64? SnapshotTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlobalSearchFile";
    }

    public GlobalSearchFile Set(
        List<System.String>? Dirs = null,
        System.String? Filename = null,
        System.Boolean? IsFile = null,
        System.Int64? ModifiedTime = null,
        System.Int32? NumSnapshots = null,
        System.Int64? SizeInBytes = null,
        System.String? SnappableId = null,
        System.String? SnappableName = null,
        System.Int64? SnapshotTime = null
    ) 
    {
        if ( Dirs != null ) {
            this.Dirs = Dirs;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( IsFile != null ) {
            this.IsFile = IsFile;
        }
        if ( ModifiedTime != null ) {
            this.ModifiedTime = ModifiedTime;
        }
        if ( NumSnapshots != null ) {
            this.NumSnapshots = NumSnapshots;
        }
        if ( SizeInBytes != null ) {
            this.SizeInBytes = SizeInBytes;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( SnappableName != null ) {
            this.SnappableName = SnappableName;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> List<System.String>? Dirs
        // GraphQL -> dirs: [String!]! (scalar)
        if (this.Dirs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dirs\n" ;
            } else {
                s += ind + "dirs\n" ;
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
        //      C# -> System.Boolean? IsFile
        // GraphQL -> isFile: Boolean! (scalar)
        if (this.IsFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFile\n" ;
            } else {
                s += ind + "isFile\n" ;
            }
        }
        //      C# -> System.Int64? ModifiedTime
        // GraphQL -> modifiedTime: Long (scalar)
        if (this.ModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedTime\n" ;
            } else {
                s += ind + "modifiedTime\n" ;
            }
        }
        //      C# -> System.Int32? NumSnapshots
        // GraphQL -> numSnapshots: Int (scalar)
        if (this.NumSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSnapshots\n" ;
            } else {
                s += ind + "numSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long (scalar)
        if (this.SizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeInBytes\n" ;
            } else {
                s += ind + "sizeInBytes\n" ;
            }
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (this.SnappableName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableName\n" ;
            } else {
                s += ind + "snappableName\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Dirs
        // GraphQL -> dirs: [String!]! (scalar)
        if (ec.Includes("dirs",true))
        {
            if(this.Dirs == null) {

                this.Dirs = new List<System.String>();

            } else {


            }
        }
        else if (this.Dirs != null && ec.Excludes("dirs",true))
        {
            this.Dirs = null;
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
        //      C# -> System.Boolean? IsFile
        // GraphQL -> isFile: Boolean! (scalar)
        if (ec.Includes("isFile",true))
        {
            if(this.IsFile == null) {

                this.IsFile = true;

            } else {


            }
        }
        else if (this.IsFile != null && ec.Excludes("isFile",true))
        {
            this.IsFile = null;
        }
        //      C# -> System.Int64? ModifiedTime
        // GraphQL -> modifiedTime: Long (scalar)
        if (ec.Includes("modifiedTime",true))
        {
            if(this.ModifiedTime == null) {

                this.ModifiedTime = new System.Int64();

            } else {


            }
        }
        else if (this.ModifiedTime != null && ec.Excludes("modifiedTime",true))
        {
            this.ModifiedTime = null;
        }
        //      C# -> System.Int32? NumSnapshots
        // GraphQL -> numSnapshots: Int (scalar)
        if (ec.Includes("numSnapshots",true))
        {
            if(this.NumSnapshots == null) {

                this.NumSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSnapshots != null && ec.Excludes("numSnapshots",true))
        {
            this.NumSnapshots = null;
        }
        //      C# -> System.Int64? SizeInBytes
        // GraphQL -> sizeInBytes: Long (scalar)
        if (ec.Includes("sizeInBytes",true))
        {
            if(this.SizeInBytes == null) {

                this.SizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.SizeInBytes != null && ec.Excludes("sizeInBytes",true))
        {
            this.SizeInBytes = null;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String! (scalar)
        if (ec.Includes("snappableName",true))
        {
            if(this.SnappableName == null) {

                this.SnappableName = "FETCH";

            } else {


            }
        }
        else if (this.SnappableName != null && ec.Excludes("snappableName",true))
        {
            this.SnappableName = null;
        }
        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
    }


    #endregion

    } // class GlobalSearchFile
    
    #endregion

    public static class ListGlobalSearchFileExtensions
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
            this List<GlobalSearchFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GlobalSearchFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GlobalSearchFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalSearchFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalSearchFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types