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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? BytesCreated
        // GraphQL -> bytesCreated: Long! (scalar)
        if (this.BytesCreated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesCreated\n" ;
            } else {
                s += ind + "bytesCreated\n" ;
            }
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (this.BytesDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesDeleted\n" ;
            } else {
                s += ind + "bytesDeleted\n" ;
            }
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (this.BytesModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesModified\n" ;
            } else {
                s += ind + "bytesModified\n" ;
            }
        }
        //      C# -> System.Int64? FilesCreated
        // GraphQL -> filesCreated: Long! (scalar)
        if (this.FilesCreated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesCreated\n" ;
            } else {
                s += ind + "filesCreated\n" ;
            }
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (this.FilesDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesDeleted\n" ;
            } else {
                s += ind + "filesDeleted\n" ;
            }
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (this.FilesModified != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesModified\n" ;
            } else {
                s += ind + "filesModified\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeleted\n" ;
            } else {
                s += ind + "isDeleted\n" ;
            }
        }
        //      C# -> System.Boolean? IsFolder
        // GraphQL -> isFolder: Boolean! (scalar)
        if (this.IsFolder != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFolder\n" ;
            } else {
                s += ind + "isFolder\n" ;
            }
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (this.LastModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModifiedTime\n" ;
            } else {
                s += ind + "lastModifiedTime\n" ;
            }
        }
        //      C# -> System.Int32? Mode
        // GraphQL -> mode: Int! (scalar)
        if (this.Mode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mode\n" ;
            } else {
                s += ind + "mode\n" ;
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
        //      C# -> System.Int64? SuspiciousFilesAdded
        // GraphQL -> suspiciousFilesAdded: Long! (scalar)
        if (this.SuspiciousFilesAdded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "suspiciousFilesAdded\n" ;
            } else {
                s += ind + "suspiciousFilesAdded\n" ;
            }
        }
        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        if (this.TotalSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSize\n" ;
            } else {
                s += ind + "totalSize\n" ;
            }
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (this.AnomalyInfo != null) {
            var fspec = this.AnomalyInfo.AsFieldSpec(conf.Child("anomalyInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "anomalyInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? BytesCreated
        // GraphQL -> bytesCreated: Long! (scalar)
        if (ec.Includes("bytesCreated",true))
        {
            if(this.BytesCreated == null) {

                this.BytesCreated = new System.Int64();

            } else {


            }
        }
        else if (this.BytesCreated != null && ec.Excludes("bytesCreated",true))
        {
            this.BytesCreated = null;
        }
        //      C# -> System.Int64? BytesDeleted
        // GraphQL -> bytesDeleted: Long! (scalar)
        if (ec.Includes("bytesDeleted",true))
        {
            if(this.BytesDeleted == null) {

                this.BytesDeleted = new System.Int64();

            } else {


            }
        }
        else if (this.BytesDeleted != null && ec.Excludes("bytesDeleted",true))
        {
            this.BytesDeleted = null;
        }
        //      C# -> System.Int64? BytesModified
        // GraphQL -> bytesModified: Long! (scalar)
        if (ec.Includes("bytesModified",true))
        {
            if(this.BytesModified == null) {

                this.BytesModified = new System.Int64();

            } else {


            }
        }
        else if (this.BytesModified != null && ec.Excludes("bytesModified",true))
        {
            this.BytesModified = null;
        }
        //      C# -> System.Int64? FilesCreated
        // GraphQL -> filesCreated: Long! (scalar)
        if (ec.Includes("filesCreated",true))
        {
            if(this.FilesCreated == null) {

                this.FilesCreated = new System.Int64();

            } else {


            }
        }
        else if (this.FilesCreated != null && ec.Excludes("filesCreated",true))
        {
            this.FilesCreated = null;
        }
        //      C# -> System.Int64? FilesDeleted
        // GraphQL -> filesDeleted: Long! (scalar)
        if (ec.Includes("filesDeleted",true))
        {
            if(this.FilesDeleted == null) {

                this.FilesDeleted = new System.Int64();

            } else {


            }
        }
        else if (this.FilesDeleted != null && ec.Excludes("filesDeleted",true))
        {
            this.FilesDeleted = null;
        }
        //      C# -> System.Int64? FilesModified
        // GraphQL -> filesModified: Long! (scalar)
        if (ec.Includes("filesModified",true))
        {
            if(this.FilesModified == null) {

                this.FilesModified = new System.Int64();

            } else {


            }
        }
        else if (this.FilesModified != null && ec.Excludes("filesModified",true))
        {
            this.FilesModified = null;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (ec.Includes("isDeleted",true))
        {
            if(this.IsDeleted == null) {

                this.IsDeleted = true;

            } else {


            }
        }
        else if (this.IsDeleted != null && ec.Excludes("isDeleted",true))
        {
            this.IsDeleted = null;
        }
        //      C# -> System.Boolean? IsFolder
        // GraphQL -> isFolder: Boolean! (scalar)
        if (ec.Includes("isFolder",true))
        {
            if(this.IsFolder == null) {

                this.IsFolder = true;

            } else {


            }
        }
        else if (this.IsFolder != null && ec.Excludes("isFolder",true))
        {
            this.IsFolder = null;
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (ec.Includes("lastModifiedTime",true))
        {
            if(this.LastModifiedTime == null) {

                this.LastModifiedTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastModifiedTime != null && ec.Excludes("lastModifiedTime",true))
        {
            this.LastModifiedTime = null;
        }
        //      C# -> System.Int32? Mode
        // GraphQL -> mode: Int! (scalar)
        if (ec.Includes("mode",true))
        {
            if(this.Mode == null) {

                this.Mode = Int32.MinValue;

            } else {


            }
        }
        else if (this.Mode != null && ec.Excludes("mode",true))
        {
            this.Mode = null;
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
        //      C# -> System.Int64? SuspiciousFilesAdded
        // GraphQL -> suspiciousFilesAdded: Long! (scalar)
        if (ec.Includes("suspiciousFilesAdded",true))
        {
            if(this.SuspiciousFilesAdded == null) {

                this.SuspiciousFilesAdded = new System.Int64();

            } else {


            }
        }
        else if (this.SuspiciousFilesAdded != null && ec.Excludes("suspiciousFilesAdded",true))
        {
            this.SuspiciousFilesAdded = null;
        }
        //      C# -> System.Int64? TotalSize
        // GraphQL -> totalSize: Long! (scalar)
        if (ec.Includes("totalSize",true))
        {
            if(this.TotalSize == null) {

                this.TotalSize = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSize != null && ec.Excludes("totalSize",true))
        {
            this.TotalSize = null;
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (ec.Includes("anomalyInfo",false))
        {
            if(this.AnomalyInfo == null) {

                this.AnomalyInfo = new AnomalyInfo();
                this.AnomalyInfo.ApplyExploratoryFieldSpec(ec.NewChild("anomalyInfo"));

            } else {

                this.AnomalyInfo.ApplyExploratoryFieldSpec(ec.NewChild("anomalyInfo"));

            }
        }
        else if (this.AnomalyInfo != null && ec.Excludes("anomalyInfo",false))
        {
            this.AnomalyInfo = null;
        }
    }


    #endregion

    } // class DiffData
    
    #endregion

    public static class ListDiffDataExtensions
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
            this List<DiffData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DiffData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<DiffData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types