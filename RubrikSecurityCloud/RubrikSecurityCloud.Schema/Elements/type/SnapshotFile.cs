// SnapshotFile.cs
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
    #region SnapshotFile
    public class SnapshotFile: BaseType
    {
        #region members

        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        [JsonProperty("fileMode")]
        public FileModeEnum? FileMode { get; set; }

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

        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        [JsonProperty("statusMessage")]
        public System.String? StatusMessage { get; set; }

        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        [JsonProperty("quarantineInfo")]
        public QuarantineInfo? QuarantineInfo { get; set; }

        //      C# -> WorkloadFields? WorkloadFields
        // GraphQL -> workloadFields: WorkloadFields (type)
        [JsonProperty("workloadFields")]
        public WorkloadFields? WorkloadFields { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotFile";
    }

    public SnapshotFile Set(
        FileModeEnum? FileMode = null,
        System.String? AbsolutePath = null,
        System.String? DisplayPath = null,
        System.String? Filename = null,
        DateTime? LastModified = null,
        System.String? Path = null,
        System.Int64? Size = null,
        System.String? StatusMessage = null,
        QuarantineInfo? QuarantineInfo = null,
        WorkloadFields? WorkloadFields = null
    ) 
    {
        if ( FileMode != null ) {
            this.FileMode = FileMode;
        }
        if ( AbsolutePath != null ) {
            this.AbsolutePath = AbsolutePath;
        }
        if ( DisplayPath != null ) {
            this.DisplayPath = DisplayPath;
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
        if ( QuarantineInfo != null ) {
            this.QuarantineInfo = QuarantineInfo;
        }
        if ( WorkloadFields != null ) {
            this.WorkloadFields = WorkloadFields;
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
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode != null) {
            s += ind + "fileMode\n" ;
        }
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
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified != null) {
            s += ind + "lastModified\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage != null) {
            s += ind + "statusMessage\n" ;
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (this.QuarantineInfo != null) {
            var fspec = this.QuarantineInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "quarantineInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> WorkloadFields? WorkloadFields
        // GraphQL -> workloadFields: WorkloadFields (type)
        if (this.WorkloadFields != null) {
            var fspec = this.WorkloadFields.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "workloadFields {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode == null && ec.Includes("fileMode",true))
        {
            this.FileMode = new FileModeEnum();
        }
        //      C# -> System.String? AbsolutePath
        // GraphQL -> absolutePath: String! (scalar)
        if (this.AbsolutePath == null && ec.Includes("absolutePath",true))
        {
            this.AbsolutePath = "FETCH";
        }
        //      C# -> System.String? DisplayPath
        // GraphQL -> displayPath: String! (scalar)
        if (this.DisplayPath == null && ec.Includes("displayPath",true))
        {
            this.DisplayPath = "FETCH";
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename == null && ec.Includes("filename",true))
        {
            this.Filename = "FETCH";
        }
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified == null && ec.Includes("lastModified",true))
        {
            this.LastModified = new DateTime();
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && ec.Includes("path",true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && ec.Includes("size",true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage == null && ec.Includes("statusMessage",true))
        {
            this.StatusMessage = "FETCH";
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (this.QuarantineInfo == null && ec.Includes("quarantineInfo",false))
        {
            this.QuarantineInfo = new QuarantineInfo();
            this.QuarantineInfo.ApplyExploratoryFieldSpec(ec.NewChild("quarantineInfo"));
        }
        //      C# -> WorkloadFields? WorkloadFields
        // GraphQL -> workloadFields: WorkloadFields (type)
        if (this.WorkloadFields == null && ec.Includes("workloadFields",false))
        {
            this.WorkloadFields = new WorkloadFields();
            this.WorkloadFields.ApplyExploratoryFieldSpec(ec.NewChild("workloadFields"));
        }
    }


    #endregion

    } // class SnapshotFile
    
    #endregion

    public static class ListSnapshotFileExtensions
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
            this List<SnapshotFile> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFile> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFile());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SnapshotFile> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types