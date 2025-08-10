// FileMatch.cs
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
    #region FileMatch
    public class FileMatch: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        [JsonProperty("detectedTime")]
        public DateTime? DetectedTime { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        [JsonProperty("fileSize")]
        public System.Int64? FileSize { get; set; }

        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        [JsonProperty("filepath")]
        public System.String? Filepath { get; set; }

        //      C# -> DateTime? FirstObservedSnapshotDate
        // GraphQL -> firstObservedSnapshotDate: DateTime (scalar)
        [JsonProperty("firstObservedSnapshotDate")]
        public DateTime? FirstObservedSnapshotDate { get; set; }

        //      C# -> System.String? FirstObservedSnapshotFid
        // GraphQL -> firstObservedSnapshotFid: UUID! (scalar)
        [JsonProperty("firstObservedSnapshotFid")]
        public System.String? FirstObservedSnapshotFid { get; set; }

        //      C# -> System.Boolean? IsFirstObservedSnapshotExpired
        // GraphQL -> isFirstObservedSnapshotExpired: Boolean! (scalar)
        [JsonProperty("isFirstObservedSnapshotExpired")]
        public System.Boolean? IsFirstObservedSnapshotExpired { get; set; }

        //      C# -> System.Boolean? IsMatchedSnapshotExpired
        // GraphQL -> isMatchedSnapshotExpired: Boolean! (scalar)
        [JsonProperty("isMatchedSnapshotExpired")]
        public System.Boolean? IsMatchedSnapshotExpired { get; set; }

        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        [JsonProperty("isQuarantinedInFirstObservedSnapshot")]
        public System.Boolean? IsQuarantinedInFirstObservedSnapshot { get; set; }

        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        [JsonProperty("matchId")]
        public System.Int64? MatchId { get; set; }

        //      C# -> DateTime? MatchedSnapshotDate
        // GraphQL -> matchedSnapshotDate: DateTime (scalar)
        [JsonProperty("matchedSnapshotDate")]
        public DateTime? MatchedSnapshotDate { get; set; }

        //      C# -> System.String? MatchedSnapshotFid
        // GraphQL -> matchedSnapshotFid: UUID! (scalar)
        [JsonProperty("matchedSnapshotFid")]
        public System.String? MatchedSnapshotFid { get; set; }

        //      C# -> DateTime? Mtime
        // GraphQL -> mtime: DateTime (scalar)
        [JsonProperty("mtime")]
        public DateTime? Mtime { get; set; }

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FileMatch";
    }

    public FileMatch Set(
        IndicatorOfCompromiseKind? MatchType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        DateTime? DetectedTime = null,
        System.String? FileName = null,
        System.Int64? FileSize = null,
        System.String? Filepath = null,
        DateTime? FirstObservedSnapshotDate = null,
        System.String? FirstObservedSnapshotFid = null,
        System.Boolean? IsFirstObservedSnapshotExpired = null,
        System.Boolean? IsMatchedSnapshotExpired = null,
        System.Boolean? IsQuarantinedInFirstObservedSnapshot = null,
        System.Int64? MatchId = null,
        DateTime? MatchedSnapshotDate = null,
        System.String? MatchedSnapshotFid = null,
        DateTime? Mtime = null,
        System.String? ObjectFid = null,
        System.String? ObjectName = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( DetectedTime != null ) {
            this.DetectedTime = DetectedTime;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FileSize != null ) {
            this.FileSize = FileSize;
        }
        if ( Filepath != null ) {
            this.Filepath = Filepath;
        }
        if ( FirstObservedSnapshotDate != null ) {
            this.FirstObservedSnapshotDate = FirstObservedSnapshotDate;
        }
        if ( FirstObservedSnapshotFid != null ) {
            this.FirstObservedSnapshotFid = FirstObservedSnapshotFid;
        }
        if ( IsFirstObservedSnapshotExpired != null ) {
            this.IsFirstObservedSnapshotExpired = IsFirstObservedSnapshotExpired;
        }
        if ( IsMatchedSnapshotExpired != null ) {
            this.IsMatchedSnapshotExpired = IsMatchedSnapshotExpired;
        }
        if ( IsQuarantinedInFirstObservedSnapshot != null ) {
            this.IsQuarantinedInFirstObservedSnapshot = IsQuarantinedInFirstObservedSnapshot;
        }
        if ( MatchId != null ) {
            this.MatchId = MatchId;
        }
        if ( MatchedSnapshotDate != null ) {
            this.MatchedSnapshotDate = MatchedSnapshotDate;
        }
        if ( MatchedSnapshotFid != null ) {
            this.MatchedSnapshotFid = MatchedSnapshotFid;
        }
        if ( Mtime != null ) {
            this.Mtime = Mtime;
        }
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
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
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchType\n" ;
            } else {
                s += ind + "matchType\n" ;
            }
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        if (this.DetectedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectedTime\n" ;
            } else {
                s += ind + "detectedTime\n" ;
            }
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileName\n" ;
            } else {
                s += ind + "fileName\n" ;
            }
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (this.FileSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileSize\n" ;
            } else {
                s += ind + "fileSize\n" ;
            }
        }
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (this.Filepath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filepath\n" ;
            } else {
                s += ind + "filepath\n" ;
            }
        }
        //      C# -> DateTime? FirstObservedSnapshotDate
        // GraphQL -> firstObservedSnapshotDate: DateTime (scalar)
        if (this.FirstObservedSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstObservedSnapshotDate\n" ;
            } else {
                s += ind + "firstObservedSnapshotDate\n" ;
            }
        }
        //      C# -> System.String? FirstObservedSnapshotFid
        // GraphQL -> firstObservedSnapshotFid: UUID! (scalar)
        if (this.FirstObservedSnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "firstObservedSnapshotFid\n" ;
            } else {
                s += ind + "firstObservedSnapshotFid\n" ;
            }
        }
        //      C# -> System.Boolean? IsFirstObservedSnapshotExpired
        // GraphQL -> isFirstObservedSnapshotExpired: Boolean! (scalar)
        if (this.IsFirstObservedSnapshotExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFirstObservedSnapshotExpired\n" ;
            } else {
                s += ind + "isFirstObservedSnapshotExpired\n" ;
            }
        }
        //      C# -> System.Boolean? IsMatchedSnapshotExpired
        // GraphQL -> isMatchedSnapshotExpired: Boolean! (scalar)
        if (this.IsMatchedSnapshotExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMatchedSnapshotExpired\n" ;
            } else {
                s += ind + "isMatchedSnapshotExpired\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        if (this.IsQuarantinedInFirstObservedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantinedInFirstObservedSnapshot\n" ;
            } else {
                s += ind + "isQuarantinedInFirstObservedSnapshot\n" ;
            }
        }
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (this.MatchId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchId\n" ;
            } else {
                s += ind + "matchId\n" ;
            }
        }
        //      C# -> DateTime? MatchedSnapshotDate
        // GraphQL -> matchedSnapshotDate: DateTime (scalar)
        if (this.MatchedSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedSnapshotDate\n" ;
            } else {
                s += ind + "matchedSnapshotDate\n" ;
            }
        }
        //      C# -> System.String? MatchedSnapshotFid
        // GraphQL -> matchedSnapshotFid: UUID! (scalar)
        if (this.MatchedSnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedSnapshotFid\n" ;
            } else {
                s += ind + "matchedSnapshotFid\n" ;
            }
        }
        //      C# -> DateTime? Mtime
        // GraphQL -> mtime: DateTime (scalar)
        if (this.Mtime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mtime\n" ;
            } else {
                s += ind + "mtime\n" ;
            }
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFid\n" ;
            } else {
                s += ind + "objectFid\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (ec.Includes("matchType",true))
        {
            if(this.MatchType == null) {

                this.MatchType = new IndicatorOfCompromiseKind();

            } else {


            }
        }
        else if (this.MatchType != null && ec.Excludes("matchType",true))
        {
            this.MatchType = null;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new HierarchyObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        if (ec.Includes("detectedTime",true))
        {
            if(this.DetectedTime == null) {

                this.DetectedTime = new DateTime();

            } else {


            }
        }
        else if (this.DetectedTime != null && ec.Excludes("detectedTime",true))
        {
            this.DetectedTime = null;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (ec.Includes("fileName",true))
        {
            if(this.FileName == null) {

                this.FileName = "FETCH";

            } else {


            }
        }
        else if (this.FileName != null && ec.Excludes("fileName",true))
        {
            this.FileName = null;
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (ec.Includes("fileSize",true))
        {
            if(this.FileSize == null) {

                this.FileSize = new System.Int64();

            } else {


            }
        }
        else if (this.FileSize != null && ec.Excludes("fileSize",true))
        {
            this.FileSize = null;
        }
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (ec.Includes("filepath",true))
        {
            if(this.Filepath == null) {

                this.Filepath = "FETCH";

            } else {


            }
        }
        else if (this.Filepath != null && ec.Excludes("filepath",true))
        {
            this.Filepath = null;
        }
        //      C# -> DateTime? FirstObservedSnapshotDate
        // GraphQL -> firstObservedSnapshotDate: DateTime (scalar)
        if (ec.Includes("firstObservedSnapshotDate",true))
        {
            if(this.FirstObservedSnapshotDate == null) {

                this.FirstObservedSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.FirstObservedSnapshotDate != null && ec.Excludes("firstObservedSnapshotDate",true))
        {
            this.FirstObservedSnapshotDate = null;
        }
        //      C# -> System.String? FirstObservedSnapshotFid
        // GraphQL -> firstObservedSnapshotFid: UUID! (scalar)
        if (ec.Includes("firstObservedSnapshotFid",true))
        {
            if(this.FirstObservedSnapshotFid == null) {

                this.FirstObservedSnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.FirstObservedSnapshotFid != null && ec.Excludes("firstObservedSnapshotFid",true))
        {
            this.FirstObservedSnapshotFid = null;
        }
        //      C# -> System.Boolean? IsFirstObservedSnapshotExpired
        // GraphQL -> isFirstObservedSnapshotExpired: Boolean! (scalar)
        if (ec.Includes("isFirstObservedSnapshotExpired",true))
        {
            if(this.IsFirstObservedSnapshotExpired == null) {

                this.IsFirstObservedSnapshotExpired = true;

            } else {


            }
        }
        else if (this.IsFirstObservedSnapshotExpired != null && ec.Excludes("isFirstObservedSnapshotExpired",true))
        {
            this.IsFirstObservedSnapshotExpired = null;
        }
        //      C# -> System.Boolean? IsMatchedSnapshotExpired
        // GraphQL -> isMatchedSnapshotExpired: Boolean! (scalar)
        if (ec.Includes("isMatchedSnapshotExpired",true))
        {
            if(this.IsMatchedSnapshotExpired == null) {

                this.IsMatchedSnapshotExpired = true;

            } else {


            }
        }
        else if (this.IsMatchedSnapshotExpired != null && ec.Excludes("isMatchedSnapshotExpired",true))
        {
            this.IsMatchedSnapshotExpired = null;
        }
        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        if (ec.Includes("isQuarantinedInFirstObservedSnapshot",true))
        {
            if(this.IsQuarantinedInFirstObservedSnapshot == null) {

                this.IsQuarantinedInFirstObservedSnapshot = true;

            } else {


            }
        }
        else if (this.IsQuarantinedInFirstObservedSnapshot != null && ec.Excludes("isQuarantinedInFirstObservedSnapshot",true))
        {
            this.IsQuarantinedInFirstObservedSnapshot = null;
        }
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (ec.Includes("matchId",true))
        {
            if(this.MatchId == null) {

                this.MatchId = new System.Int64();

            } else {


            }
        }
        else if (this.MatchId != null && ec.Excludes("matchId",true))
        {
            this.MatchId = null;
        }
        //      C# -> DateTime? MatchedSnapshotDate
        // GraphQL -> matchedSnapshotDate: DateTime (scalar)
        if (ec.Includes("matchedSnapshotDate",true))
        {
            if(this.MatchedSnapshotDate == null) {

                this.MatchedSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.MatchedSnapshotDate != null && ec.Excludes("matchedSnapshotDate",true))
        {
            this.MatchedSnapshotDate = null;
        }
        //      C# -> System.String? MatchedSnapshotFid
        // GraphQL -> matchedSnapshotFid: UUID! (scalar)
        if (ec.Includes("matchedSnapshotFid",true))
        {
            if(this.MatchedSnapshotFid == null) {

                this.MatchedSnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.MatchedSnapshotFid != null && ec.Excludes("matchedSnapshotFid",true))
        {
            this.MatchedSnapshotFid = null;
        }
        //      C# -> DateTime? Mtime
        // GraphQL -> mtime: DateTime (scalar)
        if (ec.Includes("mtime",true))
        {
            if(this.Mtime == null) {

                this.Mtime = new DateTime();

            } else {


            }
        }
        else if (this.Mtime != null && ec.Excludes("mtime",true))
        {
            this.Mtime = null;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (ec.Includes("objectFid",true))
        {
            if(this.ObjectFid == null) {

                this.ObjectFid = "FETCH";

            } else {


            }
        }
        else if (this.ObjectFid != null && ec.Excludes("objectFid",true))
        {
            this.ObjectFid = null;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
        }
    }


    #endregion

    } // class FileMatch
    
    #endregion

    public static class ListFileMatchExtensions
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
            this List<FileMatch> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FileMatch> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FileMatch> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileMatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileMatch> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types