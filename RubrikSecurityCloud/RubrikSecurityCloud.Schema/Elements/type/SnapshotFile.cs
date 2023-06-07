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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "quarantineInfo {\n" + this.QuarantineInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> WorkloadFields? WorkloadFields
        // GraphQL -> workloadFields: WorkloadFields (type)
        if (this.WorkloadFields != null) {
            s += ind + "workloadFields {\n" + this.WorkloadFields.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FileModeEnum? FileMode
        // GraphQL -> fileMode: FileModeEnum! (enum)
        if (this.FileMode == null && Exploration.Includes(parent + ".fileMode", true))
        {
            this.FileMode = new FileModeEnum();
        }
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
        //      C# -> DateTime? LastModified
        // GraphQL -> lastModified: DateTime! (scalar)
        if (this.LastModified == null && Exploration.Includes(parent + ".lastModified", true))
        {
            this.LastModified = new DateTime();
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? StatusMessage
        // GraphQL -> statusMessage: String! (scalar)
        if (this.StatusMessage == null && Exploration.Includes(parent + ".statusMessage", true))
        {
            this.StatusMessage = "FETCH";
        }
        //      C# -> QuarantineInfo? QuarantineInfo
        // GraphQL -> quarantineInfo: QuarantineInfo (type)
        if (this.QuarantineInfo == null && Exploration.Includes(parent + ".quarantineInfo"))
        {
            this.QuarantineInfo = new QuarantineInfo();
            this.QuarantineInfo.ApplyExploratoryFieldSpec(parent + ".quarantineInfo");
        }
        //      C# -> WorkloadFields? WorkloadFields
        // GraphQL -> workloadFields: WorkloadFields (type)
        if (this.WorkloadFields == null && Exploration.Includes(parent + ".workloadFields"))
        {
            this.WorkloadFields = new WorkloadFields();
            this.WorkloadFields.ApplyExploratoryFieldSpec(parent + ".workloadFields");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotFile> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotFile());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types