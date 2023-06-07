// DiffData.cs
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
    #region DiffData
    public class DiffData: BaseType
    {
        #region members

        //      C# -> System.Int64? BytesCreated
        // GraphQL -> bytesCreated: Long! (scalar)
        [JsonProperty("bytesCreated")]
        public System.Int64? BytesCreated { get; set; }

        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        [JsonProperty("bytesDeleted")]
        public System.Int64? BytesDeleted { get; set; }

        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        [JsonProperty("bytesModified")]
        public System.Int64? BytesModified { get; set; }

        //      C# -> System.Int64? FilesCreated
        // GraphQL -> filesCreated: Long! (scalar)
        [JsonProperty("filesCreated")]
        public System.Int64? FilesCreated { get; set; }

        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        [JsonProperty("filesDeleted")]
        public System.Int64? FilesDeleted { get; set; }

        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        [JsonProperty("filesModified")]
        public System.Int64? FilesModified { get; set; }

        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        [JsonProperty("isDeleted")]
        public System.Boolean? IsDeleted { get; set; }

        //      C# -> System.Boolean? IsFolder
        // GraphQL -> isFolder: Boolean! (scalar)
        [JsonProperty("isFolder")]
        public System.Boolean? IsFolder { get; set; }

        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        [JsonProperty("lastModifiedTime")]
        public System.Int64? LastModifiedTime { get; set; }

        //      C# -> System.Int32? Mode
        // GraphQL -> mode: Int! (scalar)
        [JsonProperty("mode")]
        public System.Int32? Mode { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.Int64? SuspiciousFilesAdded
        // GraphQL -> suspiciousFilesAdded: Long! (scalar)
        [JsonProperty("suspiciousFilesAdded")]
        public System.Int64? SuspiciousFilesAdded { get; set; }

        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        [JsonProperty("totalSize")]
        public System.Int64? TotalSize { get; set; }

        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        [JsonProperty("anomalyInfo")]
        public AnomalyInfo? AnomalyInfo { get; set; }


        #endregion

    #region methods

    public DiffData Set(
        System.Int64? BytesCreated = null,
        System.Int64? BytesDeleted = null,
        System.Int64? BytesModified = null,
        System.Int64? FilesCreated = null,
        System.Int64? FilesDeleted = null,
        System.Int64? FilesModified = null,
        System.Boolean? IsDeleted = null,
        System.Boolean? IsFolder = null,
        System.Int64? LastModifiedTime = null,
        System.Int32? Mode = null,
        System.String? Path = null,
        System.Int64? SuspiciousFilesAdded = null,
        System.Int64? TotalSize = null,
        AnomalyInfo? AnomalyInfo = null
    ) 
    {
        if ( BytesCreated != null ) {
            this.BytesCreated = BytesCreated;
        }
        if ( BytesDeleted != null ) {
            this.BytesDeleted = BytesDeleted;
        }
        if ( BytesModified != null ) {
            this.BytesModified = BytesModified;
        }
        if ( FilesCreated != null ) {
            this.FilesCreated = FilesCreated;
        }
        if ( FilesDeleted != null ) {
            this.FilesDeleted = FilesDeleted;
        }
        if ( FilesModified != null ) {
            this.FilesModified = FilesModified;
        }
        if ( IsDeleted != null ) {
            this.IsDeleted = IsDeleted;
        }
        if ( IsFolder != null ) {
            this.IsFolder = IsFolder;
        }
        if ( LastModifiedTime != null ) {
            this.LastModifiedTime = LastModifiedTime;
        }
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( SuspiciousFilesAdded != null ) {
            this.SuspiciousFilesAdded = SuspiciousFilesAdded;
        }
        if ( TotalSize != null ) {
            this.TotalSize = TotalSize;
        }
        if ( AnomalyInfo != null ) {
            this.AnomalyInfo = AnomalyInfo;
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
        //      C# -> System.Int64? BytesCreated
        // GraphQL -> bytesCreated: Long! (scalar)
        if (this.BytesCreated != null) {
            s += ind + "bytesCreated\n" ;
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (this.BytesDeleted != null) {
            s += ind + "bytesDeleted\n" ;
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (this.BytesModified != null) {
            s += ind + "bytesModified\n" ;
        }
        //      C# -> System.Int64? FilesCreated
        // GraphQL -> filesCreated: Long! (scalar)
        if (this.FilesCreated != null) {
            s += ind + "filesCreated\n" ;
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (this.FilesDeleted != null) {
            s += ind + "filesDeleted\n" ;
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (this.FilesModified != null) {
            s += ind + "filesModified\n" ;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            s += ind + "isDeleted\n" ;
        }
        //      C# -> System.Boolean? IsFolder
        // GraphQL -> isFolder: Boolean! (scalar)
        if (this.IsFolder != null) {
            s += ind + "isFolder\n" ;
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (this.LastModifiedTime != null) {
            s += ind + "lastModifiedTime\n" ;
        }
        //      C# -> System.Int32? Mode
        // GraphQL -> mode: Int! (scalar)
        if (this.Mode != null) {
            s += ind + "mode\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> System.Int64? SuspiciousFilesAdded
        // GraphQL -> suspiciousFilesAdded: Long! (scalar)
        if (this.SuspiciousFilesAdded != null) {
            s += ind + "suspiciousFilesAdded\n" ;
        }
        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        if (this.TotalSize != null) {
            s += ind + "totalSize\n" ;
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (this.AnomalyInfo != null) {
            s += ind + "anomalyInfo {\n" + this.AnomalyInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? BytesCreated
        // GraphQL -> bytesCreated: Long! (scalar)
        if (this.BytesCreated == null && Exploration.Includes(parent + ".bytesCreated", true))
        {
            this.BytesCreated = new System.Int64();
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (this.BytesDeleted == null && Exploration.Includes(parent + ".bytesDeleted", true))
        {
            this.BytesDeleted = new System.Int64();
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (this.BytesModified == null && Exploration.Includes(parent + ".bytesModified", true))
        {
            this.BytesModified = new System.Int64();
        }
        //      C# -> System.Int64? FilesCreated
        // GraphQL -> filesCreated: Long! (scalar)
        if (this.FilesCreated == null && Exploration.Includes(parent + ".filesCreated", true))
        {
            this.FilesCreated = new System.Int64();
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (this.FilesDeleted == null && Exploration.Includes(parent + ".filesDeleted", true))
        {
            this.FilesDeleted = new System.Int64();
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (this.FilesModified == null && Exploration.Includes(parent + ".filesModified", true))
        {
            this.FilesModified = new System.Int64();
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted == null && Exploration.Includes(parent + ".isDeleted", true))
        {
            this.IsDeleted = true;
        }
        //      C# -> System.Boolean? IsFolder
        // GraphQL -> isFolder: Boolean! (scalar)
        if (this.IsFolder == null && Exploration.Includes(parent + ".isFolder", true))
        {
            this.IsFolder = true;
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (this.LastModifiedTime == null && Exploration.Includes(parent + ".lastModifiedTime", true))
        {
            this.LastModifiedTime = new System.Int64();
        }
        //      C# -> System.Int32? Mode
        // GraphQL -> mode: Int! (scalar)
        if (this.Mode == null && Exploration.Includes(parent + ".mode", true))
        {
            this.Mode = Int32.MinValue;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.Int64? SuspiciousFilesAdded
        // GraphQL -> suspiciousFilesAdded: Long! (scalar)
        if (this.SuspiciousFilesAdded == null && Exploration.Includes(parent + ".suspiciousFilesAdded", true))
        {
            this.SuspiciousFilesAdded = new System.Int64();
        }
        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        if (this.TotalSize == null && Exploration.Includes(parent + ".totalSize", true))
        {
            this.TotalSize = new System.Int64();
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (this.AnomalyInfo == null && Exploration.Includes(parent + ".anomalyInfo"))
        {
            this.AnomalyInfo = new AnomalyInfo();
            this.AnomalyInfo.ApplyExploratoryFieldSpec(parent + ".anomalyInfo");
        }
    }


    #endregion

    } // class DiffData
    
    #endregion

    public static class ListDiffDataExtensions
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
            this List<DiffData> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DiffData> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DiffData());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types