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

        //      C# -> System.String? AnalyzedSnapshotFid
        // GraphQL -> analyzedSnapshotFid: UUID! (scalar)
        [JsonProperty("analyzedSnapshotFid")]
        public System.String? AnalyzedSnapshotFid { get; set; }

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

        //      C# -> DateTime? FirstMatchedSnapshotDate
        // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("firstMatchedSnapshotDate")]
        public DateTime? FirstMatchedSnapshotDate { get; set; }

        //      C# -> System.String? FirstMatchedSnapshotFid
        // GraphQL -> firstMatchedSnapshotFid: UUID! (scalar)
        [JsonProperty("firstMatchedSnapshotFid")]
        public System.String? FirstMatchedSnapshotFid { get; set; }

        //      C# -> System.Boolean? IsFirstMatchedSnapshotExpired
        // GraphQL -> isFirstMatchedSnapshotExpired: Boolean! (scalar)
        [JsonProperty("isFirstMatchedSnapshotExpired")]
        public System.Boolean? IsFirstMatchedSnapshotExpired { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        [JsonProperty("matchId")]
        public System.Int64? MatchId { get; set; }

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
        System.String? AnalyzedSnapshotFid = null,
        DateTime? DetectedTime = null,
        System.String? FileName = null,
        System.Int64? FileSize = null,
        System.String? Filepath = null,
        DateTime? FirstMatchedSnapshotDate = null,
        System.String? FirstMatchedSnapshotFid = null,
        System.Boolean? IsFirstMatchedSnapshotExpired = null,
        System.Boolean? IsQuarantined = null,
        System.Int64? MatchId = null,
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
        if ( AnalyzedSnapshotFid != null ) {
            this.AnalyzedSnapshotFid = AnalyzedSnapshotFid;
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
        if ( FirstMatchedSnapshotDate != null ) {
            this.FirstMatchedSnapshotDate = FirstMatchedSnapshotDate;
        }
        if ( FirstMatchedSnapshotFid != null ) {
            this.FirstMatchedSnapshotFid = FirstMatchedSnapshotFid;
        }
        if ( IsFirstMatchedSnapshotExpired != null ) {
            this.IsFirstMatchedSnapshotExpired = IsFirstMatchedSnapshotExpired;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( MatchId != null ) {
            this.MatchId = MatchId;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            s += ind + "matchType\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.String? AnalyzedSnapshotFid
        // GraphQL -> analyzedSnapshotFid: UUID! (scalar)
        if (this.AnalyzedSnapshotFid != null) {
            s += ind + "analyzedSnapshotFid\n" ;
        }
        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        if (this.DetectedTime != null) {
            s += ind + "detectedTime\n" ;
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName != null) {
            s += ind + "fileName\n" ;
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (this.FileSize != null) {
            s += ind + "fileSize\n" ;
        }
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (this.Filepath != null) {
            s += ind + "filepath\n" ;
        }
        //      C# -> DateTime? FirstMatchedSnapshotDate
        // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
        if (this.FirstMatchedSnapshotDate != null) {
            s += ind + "firstMatchedSnapshotDate\n" ;
        }
        //      C# -> System.String? FirstMatchedSnapshotFid
        // GraphQL -> firstMatchedSnapshotFid: UUID! (scalar)
        if (this.FirstMatchedSnapshotFid != null) {
            s += ind + "firstMatchedSnapshotFid\n" ;
        }
        //      C# -> System.Boolean? IsFirstMatchedSnapshotExpired
        // GraphQL -> isFirstMatchedSnapshotExpired: Boolean! (scalar)
        if (this.IsFirstMatchedSnapshotExpired != null) {
            s += ind + "isFirstMatchedSnapshotExpired\n" ;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            s += ind + "isQuarantined\n" ;
        }
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (this.MatchId != null) {
            s += ind + "matchId\n" ;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            s += ind + "objectFid\n" ;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            s += ind + "objectName\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType == null && ec.Includes("matchType",true))
        {
            this.MatchType = new IndicatorOfCompromiseKind();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> System.String? AnalyzedSnapshotFid
        // GraphQL -> analyzedSnapshotFid: UUID! (scalar)
        if (this.AnalyzedSnapshotFid == null && ec.Includes("analyzedSnapshotFid",true))
        {
            this.AnalyzedSnapshotFid = "FETCH";
        }
        //      C# -> DateTime? DetectedTime
        // GraphQL -> detectedTime: DateTime (scalar)
        if (this.DetectedTime == null && ec.Includes("detectedTime",true))
        {
            this.DetectedTime = new DateTime();
        }
        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        if (this.FileName == null && ec.Includes("fileName",true))
        {
            this.FileName = "FETCH";
        }
        //      C# -> System.Int64? FileSize
        // GraphQL -> fileSize: Long! (scalar)
        if (this.FileSize == null && ec.Includes("fileSize",true))
        {
            this.FileSize = new System.Int64();
        }
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (this.Filepath == null && ec.Includes("filepath",true))
        {
            this.Filepath = "FETCH";
        }
        //      C# -> DateTime? FirstMatchedSnapshotDate
        // GraphQL -> firstMatchedSnapshotDate: DateTime (scalar)
        if (this.FirstMatchedSnapshotDate == null && ec.Includes("firstMatchedSnapshotDate",true))
        {
            this.FirstMatchedSnapshotDate = new DateTime();
        }
        //      C# -> System.String? FirstMatchedSnapshotFid
        // GraphQL -> firstMatchedSnapshotFid: UUID! (scalar)
        if (this.FirstMatchedSnapshotFid == null && ec.Includes("firstMatchedSnapshotFid",true))
        {
            this.FirstMatchedSnapshotFid = "FETCH";
        }
        //      C# -> System.Boolean? IsFirstMatchedSnapshotExpired
        // GraphQL -> isFirstMatchedSnapshotExpired: Boolean! (scalar)
        if (this.IsFirstMatchedSnapshotExpired == null && ec.Includes("isFirstMatchedSnapshotExpired",true))
        {
            this.IsFirstMatchedSnapshotExpired = true;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && ec.Includes("isQuarantined",true))
        {
            this.IsQuarantined = true;
        }
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (this.MatchId == null && ec.Includes("matchId",true))
        {
            this.MatchId = new System.Int64();
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid == null && ec.Includes("objectFid",true))
        {
            this.ObjectFid = "FETCH";
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName == null && ec.Includes("objectName",true))
        {
            this.ObjectName = "FETCH";
        }
    }


    #endregion

    } // class FileMatch
    
    #endregion

    public static class ListFileMatchExtensions
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
            this List<FileMatch> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FileMatch> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileMatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<FileMatch> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types