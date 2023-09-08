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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "DiffData";
    }

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
            var fspec = this.AnomalyInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "anomalyInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BytesCreated
        // GraphQL -> bytesCreated: Long! (scalar)
        if (this.BytesCreated == null && ec.Includes("bytesCreated",true))
        {
            this.BytesCreated = new System.Int64();
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (this.BytesDeleted == null && ec.Includes("bytesDeleted",true))
        {
            this.BytesDeleted = new System.Int64();
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (this.BytesModified == null && ec.Includes("bytesModified",true))
        {
            this.BytesModified = new System.Int64();
        }
        //      C# -> System.Int64? FilesCreated
        // GraphQL -> filesCreated: Long! (scalar)
        if (this.FilesCreated == null && ec.Includes("filesCreated",true))
        {
            this.FilesCreated = new System.Int64();
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (this.FilesDeleted == null && ec.Includes("filesDeleted",true))
        {
            this.FilesDeleted = new System.Int64();
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (this.FilesModified == null && ec.Includes("filesModified",true))
        {
            this.FilesModified = new System.Int64();
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted == null && ec.Includes("isDeleted",true))
        {
            this.IsDeleted = true;
        }
        //      C# -> System.Boolean? IsFolder
        // GraphQL -> isFolder: Boolean! (scalar)
        if (this.IsFolder == null && ec.Includes("isFolder",true))
        {
            this.IsFolder = true;
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (this.LastModifiedTime == null && ec.Includes("lastModifiedTime",true))
        {
            this.LastModifiedTime = new System.Int64();
        }
        //      C# -> System.Int32? Mode
        // GraphQL -> mode: Int! (scalar)
        if (this.Mode == null && ec.Includes("mode",true))
        {
            this.Mode = Int32.MinValue;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && ec.Includes("path",true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.Int64? SuspiciousFilesAdded
        // GraphQL -> suspiciousFilesAdded: Long! (scalar)
        if (this.SuspiciousFilesAdded == null && ec.Includes("suspiciousFilesAdded",true))
        {
            this.SuspiciousFilesAdded = new System.Int64();
        }
        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        if (this.TotalSize == null && ec.Includes("totalSize",true))
        {
            this.TotalSize = new System.Int64();
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (this.AnomalyInfo == null && ec.Includes("anomalyInfo",false))
        {
            this.AnomalyInfo = new AnomalyInfo();
            this.AnomalyInfo.ApplyExploratoryFieldSpec(ec.NewChild("anomalyInfo"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DiffData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DiffData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<DiffData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types