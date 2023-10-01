// MssqlRestoreFile.cs
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
    #region MssqlRestoreFile
    public class MssqlRestoreFile: BaseType
    {
        #region members

        //      C# -> MssqlDatabaseFileType? FileType
        // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
        [JsonProperty("fileType")]
        public MssqlDatabaseFileType? FileType { get; set; }

        //      C# -> System.Int64? FileId
        // GraphQL -> fileId: Long! (scalar)
        [JsonProperty("fileId")]
        public System.Int64? FileId { get; set; }

        //      C# -> System.String? LogicalName
        // GraphQL -> logicalName: String! (scalar)
        [JsonProperty("logicalName")]
        public System.String? LogicalName { get; set; }

        //      C# -> System.String? OriginalName
        // GraphQL -> originalName: String! (scalar)
        [JsonProperty("originalName")]
        public System.String? OriginalName { get; set; }

        //      C# -> System.String? OriginalPath
        // GraphQL -> originalPath: String! (scalar)
        [JsonProperty("originalPath")]
        public System.String? OriginalPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlRestoreFile";
    }

    public MssqlRestoreFile Set(
        MssqlDatabaseFileType? FileType = null,
        System.Int64? FileId = null,
        System.String? LogicalName = null,
        System.String? OriginalName = null,
        System.String? OriginalPath = null
    ) 
    {
        if ( FileType != null ) {
            this.FileType = FileType;
        }
        if ( FileId != null ) {
            this.FileId = FileId;
        }
        if ( LogicalName != null ) {
            this.LogicalName = LogicalName;
        }
        if ( OriginalName != null ) {
            this.OriginalName = OriginalName;
        }
        if ( OriginalPath != null ) {
            this.OriginalPath = OriginalPath;
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
        //      C# -> MssqlDatabaseFileType? FileType
        // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
        if (this.FileType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileType\n" ;
            } else {
                s += ind + "fileType\n" ;
            }
        }
        //      C# -> System.Int64? FileId
        // GraphQL -> fileId: Long! (scalar)
        if (this.FileId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileId\n" ;
            } else {
                s += ind + "fileId\n" ;
            }
        }
        //      C# -> System.String? LogicalName
        // GraphQL -> logicalName: String! (scalar)
        if (this.LogicalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalName\n" ;
            } else {
                s += ind + "logicalName\n" ;
            }
        }
        //      C# -> System.String? OriginalName
        // GraphQL -> originalName: String! (scalar)
        if (this.OriginalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "originalName\n" ;
            } else {
                s += ind + "originalName\n" ;
            }
        }
        //      C# -> System.String? OriginalPath
        // GraphQL -> originalPath: String! (scalar)
        if (this.OriginalPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "originalPath\n" ;
            } else {
                s += ind + "originalPath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlDatabaseFileType? FileType
        // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
        if (ec.Includes("fileType",true))
        {
            if(this.FileType == null) {

                this.FileType = new MssqlDatabaseFileType();

            } else {


            }
        }
        else if (this.FileType != null && ec.Excludes("fileType",true))
        {
            this.FileType = null;
        }
        //      C# -> System.Int64? FileId
        // GraphQL -> fileId: Long! (scalar)
        if (ec.Includes("fileId",true))
        {
            if(this.FileId == null) {

                this.FileId = new System.Int64();

            } else {


            }
        }
        else if (this.FileId != null && ec.Excludes("fileId",true))
        {
            this.FileId = null;
        }
        //      C# -> System.String? LogicalName
        // GraphQL -> logicalName: String! (scalar)
        if (ec.Includes("logicalName",true))
        {
            if(this.LogicalName == null) {

                this.LogicalName = "FETCH";

            } else {


            }
        }
        else if (this.LogicalName != null && ec.Excludes("logicalName",true))
        {
            this.LogicalName = null;
        }
        //      C# -> System.String? OriginalName
        // GraphQL -> originalName: String! (scalar)
        if (ec.Includes("originalName",true))
        {
            if(this.OriginalName == null) {

                this.OriginalName = "FETCH";

            } else {


            }
        }
        else if (this.OriginalName != null && ec.Excludes("originalName",true))
        {
            this.OriginalName = null;
        }
        //      C# -> System.String? OriginalPath
        // GraphQL -> originalPath: String! (scalar)
        if (ec.Includes("originalPath",true))
        {
            if(this.OriginalPath == null) {

                this.OriginalPath = "FETCH";

            } else {


            }
        }
        else if (this.OriginalPath != null && ec.Excludes("originalPath",true))
        {
            this.OriginalPath = null;
        }
    }


    #endregion

    } // class MssqlRestoreFile
    
    #endregion

    public static class ListMssqlRestoreFileExtensions
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
            this List<MssqlRestoreFile> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MssqlRestoreFile> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlRestoreFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlRestoreFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlRestoreFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types