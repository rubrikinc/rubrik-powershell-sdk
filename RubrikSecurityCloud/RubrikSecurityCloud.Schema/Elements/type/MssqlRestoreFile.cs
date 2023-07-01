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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> MssqlDatabaseFileType? FileType
        // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
        if (this.FileType != null) {
            s += ind + "fileType\n" ;
        }
        //      C# -> System.Int64? FileId
        // GraphQL -> fileId: Long! (scalar)
        if (this.FileId != null) {
            s += ind + "fileId\n" ;
        }
        //      C# -> System.String? LogicalName
        // GraphQL -> logicalName: String! (scalar)
        if (this.LogicalName != null) {
            s += ind + "logicalName\n" ;
        }
        //      C# -> System.String? OriginalName
        // GraphQL -> originalName: String! (scalar)
        if (this.OriginalName != null) {
            s += ind + "originalName\n" ;
        }
        //      C# -> System.String? OriginalPath
        // GraphQL -> originalPath: String! (scalar)
        if (this.OriginalPath != null) {
            s += ind + "originalPath\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MssqlDatabaseFileType? FileType
        // GraphQL -> fileType: MssqlDatabaseFileType! (enum)
        if (this.FileType == null && Exploration.Includes(parent + ".fileType", true))
        {
            this.FileType = new MssqlDatabaseFileType();
        }
        //      C# -> System.Int64? FileId
        // GraphQL -> fileId: Long! (scalar)
        if (this.FileId == null && Exploration.Includes(parent + ".fileId", true))
        {
            this.FileId = new System.Int64();
        }
        //      C# -> System.String? LogicalName
        // GraphQL -> logicalName: String! (scalar)
        if (this.LogicalName == null && Exploration.Includes(parent + ".logicalName", true))
        {
            this.LogicalName = "FETCH";
        }
        //      C# -> System.String? OriginalName
        // GraphQL -> originalName: String! (scalar)
        if (this.OriginalName == null && Exploration.Includes(parent + ".originalName", true))
        {
            this.OriginalName = "FETCH";
        }
        //      C# -> System.String? OriginalPath
        // GraphQL -> originalPath: String! (scalar)
        if (this.OriginalPath == null && Exploration.Includes(parent + ".originalPath", true))
        {
            this.OriginalPath = "FETCH";
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlRestoreFile> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlRestoreFile());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types