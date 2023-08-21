// FileResult.cs
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
    #region FileResult
    public class FileResult: BaseType
    {
        #region members

        //      C# -> AnalyzerErrorCode? ErrorCode
        // GraphQL -> errorCode: AnalyzerErrorCode! (enum)
        [JsonProperty("errorCode")]
        public AnalyzerErrorCode? ErrorCode { get; set; }

        //      C# -> DataGovFileMode? Mode
        // GraphQL -> mode: DataGovFileMode! (enum)
        [JsonProperty("mode")]
        public DataGovFileMode? Mode { get; set; }

        //      C# -> OpenAccessType? OpenAccessType
        // GraphQL -> openAccessType: OpenAccessType! (enum)
        [JsonProperty("openAccessType")]
        public OpenAccessType? OpenAccessType { get; set; }

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> List<RiskReason>? RiskReasons
        // GraphQL -> riskReasons: [RiskReason!]! (enum)
        [JsonProperty("riskReasons")]
        public List<RiskReason>? RiskReasons { get; set; }

        //      C# -> StalenessType? StalenessType
        // GraphQL -> stalenessType: StalenessType! (enum)
        [JsonProperty("stalenessType")]
        public StalenessType? StalenessType { get; set; }

        //      C# -> UserAccessType? UserAccessType
        // GraphQL -> userAccessType: UserAccessType! (enum)
        [JsonProperty("userAccessType")]
        public UserAccessType? UserAccessType { get; set; }

        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        [JsonProperty("snappable")]
        public HierarchyObject? Snappable { get; set; }

        //      C# -> System.String? AccessibleBySidsRepresentation
        // GraphQL -> accessibleBySidsRepresentation: String! (scalar)
        [JsonProperty("accessibleBySidsRepresentation")]
        public System.String? AccessibleBySidsRepresentation { get; set; }

        //      C# -> System.String? AccessibleBySidsRepresentationShortForm
        // GraphQL -> accessibleBySidsRepresentationShortForm: String! (scalar)
        [JsonProperty("accessibleBySidsRepresentationShortForm")]
        public System.String? AccessibleBySidsRepresentationShortForm { get; set; }

        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        [JsonProperty("directory")]
        public System.String? Directory { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.Boolean? IsDirectAcl
        // GraphQL -> isDirectAcl: Boolean! (scalar)
        [JsonProperty("isDirectAcl")]
        public System.Boolean? IsDirectAcl { get; set; }

        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        [JsonProperty("lastAccessTime")]
        public System.Int64? LastAccessTime { get; set; }

        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        [JsonProperty("lastModifiedTime")]
        public System.Int64? LastModifiedTime { get; set; }

        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        [JsonProperty("nativePath")]
        public System.String? NativePath { get; set; }

        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        [JsonProperty("numActivities")]
        public System.Int64? NumActivities { get; set; }

        //      C# -> System.Int64? NumActivitiesDelta
        // GraphQL -> numActivitiesDelta: Long! (scalar)
        [JsonProperty("numActivitiesDelta")]
        public System.Int64? NumActivitiesDelta { get; set; }

        //      C# -> System.Int64? NumChildren
        // GraphQL -> numChildren: Long! (scalar)
        [JsonProperty("numChildren")]
        public System.Int64? NumChildren { get; set; }

        //      C# -> System.Int64? NumDescendantErrorFiles
        // GraphQL -> numDescendantErrorFiles: Long! (scalar)
        [JsonProperty("numDescendantErrorFiles")]
        public System.Int64? NumDescendantErrorFiles { get; set; }

        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        [JsonProperty("numDescendantFiles")]
        public System.Int32? NumDescendantFiles { get; set; }

        //      C# -> System.Int64? NumDescendantFolders
        // GraphQL -> numDescendantFolders: Long! (scalar)
        [JsonProperty("numDescendantFolders")]
        public System.Int64? NumDescendantFolders { get; set; }

        //      C# -> System.Int64? NumDescendantSkippedExtFiles
        // GraphQL -> numDescendantSkippedExtFiles: Long! (scalar)
        [JsonProperty("numDescendantSkippedExtFiles")]
        public System.Int64? NumDescendantSkippedExtFiles { get; set; }

        //      C# -> System.Int64? NumDescendantSkippedSizeFiles
        // GraphQL -> numDescendantSkippedSizeFiles: Long! (scalar)
        [JsonProperty("numDescendantSkippedSizeFiles")]
        public System.Int64? NumDescendantSkippedSizeFiles { get; set; }

        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        [JsonProperty("owner")]
        public System.String? Owner { get; set; }

        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        [JsonProperty("paginationId")]
        public System.String? PaginationId { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? SnapshotTimestamp
        // GraphQL -> snapshotTimestamp: Long! (scalar)
        [JsonProperty("snapshotTimestamp")]
        public System.Int64? SnapshotTimestamp { get; set; }

        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        [JsonProperty("stdPath")]
        public System.String? StdPath { get; set; }

        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        [JsonProperty("type")]
        public System.String? Type { get; set; }

        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        [JsonProperty("analyzerGroupResults")]
        public List<AnalyzerGroupResult>? AnalyzerGroupResults { get; set; }

        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        [JsonProperty("analyzerResults")]
        public List<AnalyzerResult>? AnalyzerResults { get; set; }

        //      C# -> AnalyzerHits? AnalyzerRiskHits
        // GraphQL -> analyzerRiskHits: AnalyzerHits (type)
        [JsonProperty("analyzerRiskHits")]
        public AnalyzerHits? AnalyzerRiskHits { get; set; }

        //      C# -> Hits? FilesWithHits
        // GraphQL -> filesWithHits: Hits (type)
        [JsonProperty("filesWithHits")]
        public Hits? FilesWithHits { get; set; }

        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        [JsonProperty("hits")]
        public Hits? Hits { get; set; }

        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        [JsonProperty("numActivitiesBreakdown")]
        public List<ActivityResult>? NumActivitiesBreakdown { get; set; }

        //      C# -> Hits? OpenAccessFiles
        // GraphQL -> openAccessFiles: Hits (type)
        [JsonProperty("openAccessFiles")]
        public Hits? OpenAccessFiles { get; set; }

        //      C# -> Hits? OpenAccessFilesWithHits
        // GraphQL -> openAccessFilesWithHits: Hits (type)
        [JsonProperty("openAccessFilesWithHits")]
        public Hits? OpenAccessFilesWithHits { get; set; }

        //      C# -> Hits? OpenAccessFolders
        // GraphQL -> openAccessFolders: Hits (type)
        [JsonProperty("openAccessFolders")]
        public Hits? OpenAccessFolders { get; set; }

        //      C# -> Hits? OpenAccessStaleFiles
        // GraphQL -> openAccessStaleFiles: Hits (type)
        [JsonProperty("openAccessStaleFiles")]
        public Hits? OpenAccessStaleFiles { get; set; }

        //      C# -> PrincipalAccessInfo? PrincipalAccessInfo
        // GraphQL -> principalAccessInfo: PrincipalAccessInfo (type)
        [JsonProperty("principalAccessInfo")]
        public PrincipalAccessInfo? PrincipalAccessInfo { get; set; }

        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sensitiveFiles")]
        public SensitiveFiles? SensitiveFiles { get; set; }

        //      C# -> Hits? StaleFiles
        // GraphQL -> staleFiles: Hits (type)
        [JsonProperty("staleFiles")]
        public Hits? StaleFiles { get; set; }

        //      C# -> Hits? StaleFilesWithHits
        // GraphQL -> staleFilesWithHits: Hits (type)
        [JsonProperty("staleFilesWithHits")]
        public Hits? StaleFilesWithHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FileResult";
    }

    public FileResult Set(
        AnalyzerErrorCode? ErrorCode = null,
        DataGovFileMode? Mode = null,
        OpenAccessType? OpenAccessType = null,
        RiskLevelType? RiskLevel = null,
        List<RiskReason>? RiskReasons = null,
        StalenessType? StalenessType = null,
        UserAccessType? UserAccessType = null,
        HierarchyObject? Snappable = null,
        System.String? AccessibleBySidsRepresentation = null,
        System.String? AccessibleBySidsRepresentationShortForm = null,
        System.String? Directory = null,
        System.String? Filename = null,
        System.Boolean? IsDirectAcl = null,
        System.Int64? LastAccessTime = null,
        System.Int64? LastModifiedTime = null,
        System.String? NativePath = null,
        System.Int64? NumActivities = null,
        System.Int64? NumActivitiesDelta = null,
        System.Int64? NumChildren = null,
        System.Int64? NumDescendantErrorFiles = null,
        System.Int32? NumDescendantFiles = null,
        System.Int64? NumDescendantFolders = null,
        System.Int64? NumDescendantSkippedExtFiles = null,
        System.Int64? NumDescendantSkippedSizeFiles = null,
        System.String? Owner = null,
        System.String? PaginationId = null,
        System.Int64? Size = null,
        System.String? SnapshotFid = null,
        System.Int64? SnapshotTimestamp = null,
        System.String? StdPath = null,
        System.String? Type = null,
        List<AnalyzerGroupResult>? AnalyzerGroupResults = null,
        List<AnalyzerResult>? AnalyzerResults = null,
        AnalyzerHits? AnalyzerRiskHits = null,
        Hits? FilesWithHits = null,
        Hits? Hits = null,
        List<ActivityResult>? NumActivitiesBreakdown = null,
        Hits? OpenAccessFiles = null,
        Hits? OpenAccessFilesWithHits = null,
        Hits? OpenAccessFolders = null,
        Hits? OpenAccessStaleFiles = null,
        PrincipalAccessInfo? PrincipalAccessInfo = null,
        SensitiveFiles? SensitiveFiles = null,
        Hits? StaleFiles = null,
        Hits? StaleFilesWithHits = null
    ) 
    {
        if ( ErrorCode != null ) {
            this.ErrorCode = ErrorCode;
        }
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( OpenAccessType != null ) {
            this.OpenAccessType = OpenAccessType;
        }
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( RiskReasons != null ) {
            this.RiskReasons = RiskReasons;
        }
        if ( StalenessType != null ) {
            this.StalenessType = StalenessType;
        }
        if ( UserAccessType != null ) {
            this.UserAccessType = UserAccessType;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
        }
        if ( AccessibleBySidsRepresentation != null ) {
            this.AccessibleBySidsRepresentation = AccessibleBySidsRepresentation;
        }
        if ( AccessibleBySidsRepresentationShortForm != null ) {
            this.AccessibleBySidsRepresentationShortForm = AccessibleBySidsRepresentationShortForm;
        }
        if ( Directory != null ) {
            this.Directory = Directory;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( IsDirectAcl != null ) {
            this.IsDirectAcl = IsDirectAcl;
        }
        if ( LastAccessTime != null ) {
            this.LastAccessTime = LastAccessTime;
        }
        if ( LastModifiedTime != null ) {
            this.LastModifiedTime = LastModifiedTime;
        }
        if ( NativePath != null ) {
            this.NativePath = NativePath;
        }
        if ( NumActivities != null ) {
            this.NumActivities = NumActivities;
        }
        if ( NumActivitiesDelta != null ) {
            this.NumActivitiesDelta = NumActivitiesDelta;
        }
        if ( NumChildren != null ) {
            this.NumChildren = NumChildren;
        }
        if ( NumDescendantErrorFiles != null ) {
            this.NumDescendantErrorFiles = NumDescendantErrorFiles;
        }
        if ( NumDescendantFiles != null ) {
            this.NumDescendantFiles = NumDescendantFiles;
        }
        if ( NumDescendantFolders != null ) {
            this.NumDescendantFolders = NumDescendantFolders;
        }
        if ( NumDescendantSkippedExtFiles != null ) {
            this.NumDescendantSkippedExtFiles = NumDescendantSkippedExtFiles;
        }
        if ( NumDescendantSkippedSizeFiles != null ) {
            this.NumDescendantSkippedSizeFiles = NumDescendantSkippedSizeFiles;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( PaginationId != null ) {
            this.PaginationId = PaginationId;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotTimestamp != null ) {
            this.SnapshotTimestamp = SnapshotTimestamp;
        }
        if ( StdPath != null ) {
            this.StdPath = StdPath;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( AnalyzerGroupResults != null ) {
            this.AnalyzerGroupResults = AnalyzerGroupResults;
        }
        if ( AnalyzerResults != null ) {
            this.AnalyzerResults = AnalyzerResults;
        }
        if ( AnalyzerRiskHits != null ) {
            this.AnalyzerRiskHits = AnalyzerRiskHits;
        }
        if ( FilesWithHits != null ) {
            this.FilesWithHits = FilesWithHits;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
        }
        if ( NumActivitiesBreakdown != null ) {
            this.NumActivitiesBreakdown = NumActivitiesBreakdown;
        }
        if ( OpenAccessFiles != null ) {
            this.OpenAccessFiles = OpenAccessFiles;
        }
        if ( OpenAccessFilesWithHits != null ) {
            this.OpenAccessFilesWithHits = OpenAccessFilesWithHits;
        }
        if ( OpenAccessFolders != null ) {
            this.OpenAccessFolders = OpenAccessFolders;
        }
        if ( OpenAccessStaleFiles != null ) {
            this.OpenAccessStaleFiles = OpenAccessStaleFiles;
        }
        if ( PrincipalAccessInfo != null ) {
            this.PrincipalAccessInfo = PrincipalAccessInfo;
        }
        if ( SensitiveFiles != null ) {
            this.SensitiveFiles = SensitiveFiles;
        }
        if ( StaleFiles != null ) {
            this.StaleFiles = StaleFiles;
        }
        if ( StaleFilesWithHits != null ) {
            this.StaleFilesWithHits = StaleFilesWithHits;
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
        //      C# -> AnalyzerErrorCode? ErrorCode
        // GraphQL -> errorCode: AnalyzerErrorCode! (enum)
        if (this.ErrorCode != null) {
            s += ind + "errorCode\n" ;
        }
        //      C# -> DataGovFileMode? Mode
        // GraphQL -> mode: DataGovFileMode! (enum)
        if (this.Mode != null) {
            s += ind + "mode\n" ;
        }
        //      C# -> OpenAccessType? OpenAccessType
        // GraphQL -> openAccessType: OpenAccessType! (enum)
        if (this.OpenAccessType != null) {
            s += ind + "openAccessType\n" ;
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            s += ind + "riskLevel\n" ;
        }
        //      C# -> List<RiskReason>? RiskReasons
        // GraphQL -> riskReasons: [RiskReason!]! (enum)
        if (this.RiskReasons != null) {
            s += ind + "riskReasons\n" ;
        }
        //      C# -> StalenessType? StalenessType
        // GraphQL -> stalenessType: StalenessType! (enum)
        if (this.StalenessType != null) {
            s += ind + "stalenessType\n" ;
        }
        //      C# -> UserAccessType? UserAccessType
        // GraphQL -> userAccessType: UserAccessType! (enum)
        if (this.UserAccessType != null) {
            s += ind + "userAccessType\n" ;
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (this.Snappable != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Snappable).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? AccessibleBySidsRepresentation
        // GraphQL -> accessibleBySidsRepresentation: String! (scalar)
        if (this.AccessibleBySidsRepresentation != null) {
            s += ind + "accessibleBySidsRepresentation\n" ;
        }
        //      C# -> System.String? AccessibleBySidsRepresentationShortForm
        // GraphQL -> accessibleBySidsRepresentationShortForm: String! (scalar)
        if (this.AccessibleBySidsRepresentationShortForm != null) {
            s += ind + "accessibleBySidsRepresentationShortForm\n" ;
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (this.Directory != null) {
            s += ind + "directory\n" ;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            s += ind + "filename\n" ;
        }
        //      C# -> System.Boolean? IsDirectAcl
        // GraphQL -> isDirectAcl: Boolean! (scalar)
        if (this.IsDirectAcl != null) {
            s += ind + "isDirectAcl\n" ;
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime != null) {
            s += ind + "lastAccessTime\n" ;
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (this.LastModifiedTime != null) {
            s += ind + "lastModifiedTime\n" ;
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath != null) {
            s += ind + "nativePath\n" ;
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities != null) {
            s += ind + "numActivities\n" ;
        }
        //      C# -> System.Int64? NumActivitiesDelta
        // GraphQL -> numActivitiesDelta: Long! (scalar)
        if (this.NumActivitiesDelta != null) {
            s += ind + "numActivitiesDelta\n" ;
        }
        //      C# -> System.Int64? NumChildren
        // GraphQL -> numChildren: Long! (scalar)
        if (this.NumChildren != null) {
            s += ind + "numChildren\n" ;
        }
        //      C# -> System.Int64? NumDescendantErrorFiles
        // GraphQL -> numDescendantErrorFiles: Long! (scalar)
        if (this.NumDescendantErrorFiles != null) {
            s += ind + "numDescendantErrorFiles\n" ;
        }
        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        if (this.NumDescendantFiles != null) {
            s += ind + "numDescendantFiles\n" ;
        }
        //      C# -> System.Int64? NumDescendantFolders
        // GraphQL -> numDescendantFolders: Long! (scalar)
        if (this.NumDescendantFolders != null) {
            s += ind + "numDescendantFolders\n" ;
        }
        //      C# -> System.Int64? NumDescendantSkippedExtFiles
        // GraphQL -> numDescendantSkippedExtFiles: Long! (scalar)
        if (this.NumDescendantSkippedExtFiles != null) {
            s += ind + "numDescendantSkippedExtFiles\n" ;
        }
        //      C# -> System.Int64? NumDescendantSkippedSizeFiles
        // GraphQL -> numDescendantSkippedSizeFiles: Long! (scalar)
        if (this.NumDescendantSkippedSizeFiles != null) {
            s += ind + "numDescendantSkippedSizeFiles\n" ;
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner != null) {
            s += ind + "owner\n" ;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            s += ind + "paginationId\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            s += ind + "snapshotFid\n" ;
        }
        //      C# -> System.Int64? SnapshotTimestamp
        // GraphQL -> snapshotTimestamp: Long! (scalar)
        if (this.SnapshotTimestamp != null) {
            s += ind + "snapshotTimestamp\n" ;
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (this.StdPath != null) {
            s += ind + "stdPath\n" ;
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (this.AnalyzerGroupResults != null) {
            var fspec = this.AnalyzerGroupResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerGroupResults {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults != null) {
            var fspec = this.AnalyzerResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerResults {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AnalyzerHits? AnalyzerRiskHits
        // GraphQL -> analyzerRiskHits: AnalyzerHits (type)
        if (this.AnalyzerRiskHits != null) {
            var fspec = this.AnalyzerRiskHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerRiskHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? FilesWithHits
        // GraphQL -> filesWithHits: Hits (type)
        if (this.FilesWithHits != null) {
            var fspec = this.FilesWithHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filesWithHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits != null) {
            var fspec = this.Hits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (this.NumActivitiesBreakdown != null) {
            var fspec = this.NumActivitiesBreakdown.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "numActivitiesBreakdown {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? OpenAccessFiles
        // GraphQL -> openAccessFiles: Hits (type)
        if (this.OpenAccessFiles != null) {
            var fspec = this.OpenAccessFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "openAccessFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? OpenAccessFilesWithHits
        // GraphQL -> openAccessFilesWithHits: Hits (type)
        if (this.OpenAccessFilesWithHits != null) {
            var fspec = this.OpenAccessFilesWithHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "openAccessFilesWithHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? OpenAccessFolders
        // GraphQL -> openAccessFolders: Hits (type)
        if (this.OpenAccessFolders != null) {
            var fspec = this.OpenAccessFolders.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "openAccessFolders {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? OpenAccessStaleFiles
        // GraphQL -> openAccessStaleFiles: Hits (type)
        if (this.OpenAccessStaleFiles != null) {
            var fspec = this.OpenAccessStaleFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "openAccessStaleFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrincipalAccessInfo? PrincipalAccessInfo
        // GraphQL -> principalAccessInfo: PrincipalAccessInfo (type)
        if (this.PrincipalAccessInfo != null) {
            var fspec = this.PrincipalAccessInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "principalAccessInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sensitiveFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? StaleFiles
        // GraphQL -> staleFiles: Hits (type)
        if (this.StaleFiles != null) {
            var fspec = this.StaleFiles.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "staleFiles {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Hits? StaleFilesWithHits
        // GraphQL -> staleFilesWithHits: Hits (type)
        if (this.StaleFilesWithHits != null) {
            var fspec = this.StaleFilesWithHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "staleFilesWithHits {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AnalyzerErrorCode? ErrorCode
        // GraphQL -> errorCode: AnalyzerErrorCode! (enum)
        if (this.ErrorCode == null && Exploration.Includes(parent + ".errorCode", true))
        {
            this.ErrorCode = new AnalyzerErrorCode();
        }
        //      C# -> DataGovFileMode? Mode
        // GraphQL -> mode: DataGovFileMode! (enum)
        if (this.Mode == null && Exploration.Includes(parent + ".mode", true))
        {
            this.Mode = new DataGovFileMode();
        }
        //      C# -> OpenAccessType? OpenAccessType
        // GraphQL -> openAccessType: OpenAccessType! (enum)
        if (this.OpenAccessType == null && Exploration.Includes(parent + ".openAccessType", true))
        {
            this.OpenAccessType = new OpenAccessType();
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel == null && Exploration.Includes(parent + ".riskLevel", true))
        {
            this.RiskLevel = new RiskLevelType();
        }
        //      C# -> List<RiskReason>? RiskReasons
        // GraphQL -> riskReasons: [RiskReason!]! (enum)
        if (this.RiskReasons == null && Exploration.Includes(parent + ".riskReasons", true))
        {
            this.RiskReasons = new List<RiskReason>();
        }
        //      C# -> StalenessType? StalenessType
        // GraphQL -> stalenessType: StalenessType! (enum)
        if (this.StalenessType == null && Exploration.Includes(parent + ".stalenessType", true))
        {
            this.StalenessType = new StalenessType();
        }
        //      C# -> UserAccessType? UserAccessType
        // GraphQL -> userAccessType: UserAccessType! (enum)
        if (this.UserAccessType == null && Exploration.Includes(parent + ".userAccessType", true))
        {
            this.UserAccessType = new UserAccessType();
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
        {
            var impls = new List<HierarchyObject>();
            impls.ApplyExploratoryFieldSpec(parent + ".snappable");
            this.Snappable = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? AccessibleBySidsRepresentation
        // GraphQL -> accessibleBySidsRepresentation: String! (scalar)
        if (this.AccessibleBySidsRepresentation == null && Exploration.Includes(parent + ".accessibleBySidsRepresentation", true))
        {
            this.AccessibleBySidsRepresentation = "FETCH";
        }
        //      C# -> System.String? AccessibleBySidsRepresentationShortForm
        // GraphQL -> accessibleBySidsRepresentationShortForm: String! (scalar)
        if (this.AccessibleBySidsRepresentationShortForm == null && Exploration.Includes(parent + ".accessibleBySidsRepresentationShortForm", true))
        {
            this.AccessibleBySidsRepresentationShortForm = "FETCH";
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (this.Directory == null && Exploration.Includes(parent + ".directory", true))
        {
            this.Directory = "FETCH";
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename == null && Exploration.Includes(parent + ".filename", true))
        {
            this.Filename = "FETCH";
        }
        //      C# -> System.Boolean? IsDirectAcl
        // GraphQL -> isDirectAcl: Boolean! (scalar)
        if (this.IsDirectAcl == null && Exploration.Includes(parent + ".isDirectAcl", true))
        {
            this.IsDirectAcl = true;
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime == null && Exploration.Includes(parent + ".lastAccessTime", true))
        {
            this.LastAccessTime = new System.Int64();
        }
        //      C# -> System.Int64? LastModifiedTime
        // GraphQL -> lastModifiedTime: Long! (scalar)
        if (this.LastModifiedTime == null && Exploration.Includes(parent + ".lastModifiedTime", true))
        {
            this.LastModifiedTime = new System.Int64();
        }
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath == null && Exploration.Includes(parent + ".nativePath", true))
        {
            this.NativePath = "FETCH";
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities == null && Exploration.Includes(parent + ".numActivities", true))
        {
            this.NumActivities = new System.Int64();
        }
        //      C# -> System.Int64? NumActivitiesDelta
        // GraphQL -> numActivitiesDelta: Long! (scalar)
        if (this.NumActivitiesDelta == null && Exploration.Includes(parent + ".numActivitiesDelta", true))
        {
            this.NumActivitiesDelta = new System.Int64();
        }
        //      C# -> System.Int64? NumChildren
        // GraphQL -> numChildren: Long! (scalar)
        if (this.NumChildren == null && Exploration.Includes(parent + ".numChildren", true))
        {
            this.NumChildren = new System.Int64();
        }
        //      C# -> System.Int64? NumDescendantErrorFiles
        // GraphQL -> numDescendantErrorFiles: Long! (scalar)
        if (this.NumDescendantErrorFiles == null && Exploration.Includes(parent + ".numDescendantErrorFiles", true))
        {
            this.NumDescendantErrorFiles = new System.Int64();
        }
        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        if (this.NumDescendantFiles == null && Exploration.Includes(parent + ".numDescendantFiles", true))
        {
            this.NumDescendantFiles = Int32.MinValue;
        }
        //      C# -> System.Int64? NumDescendantFolders
        // GraphQL -> numDescendantFolders: Long! (scalar)
        if (this.NumDescendantFolders == null && Exploration.Includes(parent + ".numDescendantFolders", true))
        {
            this.NumDescendantFolders = new System.Int64();
        }
        //      C# -> System.Int64? NumDescendantSkippedExtFiles
        // GraphQL -> numDescendantSkippedExtFiles: Long! (scalar)
        if (this.NumDescendantSkippedExtFiles == null && Exploration.Includes(parent + ".numDescendantSkippedExtFiles", true))
        {
            this.NumDescendantSkippedExtFiles = new System.Int64();
        }
        //      C# -> System.Int64? NumDescendantSkippedSizeFiles
        // GraphQL -> numDescendantSkippedSizeFiles: Long! (scalar)
        if (this.NumDescendantSkippedSizeFiles == null && Exploration.Includes(parent + ".numDescendantSkippedSizeFiles", true))
        {
            this.NumDescendantSkippedSizeFiles = new System.Int64();
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner == null && Exploration.Includes(parent + ".owner", true))
        {
            this.Owner = "FETCH";
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId == null && Exploration.Includes(parent + ".paginationId", true))
        {
            this.PaginationId = "FETCH";
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid", true))
        {
            this.SnapshotFid = "FETCH";
        }
        //      C# -> System.Int64? SnapshotTimestamp
        // GraphQL -> snapshotTimestamp: Long! (scalar)
        if (this.SnapshotTimestamp == null && Exploration.Includes(parent + ".snapshotTimestamp", true))
        {
            this.SnapshotTimestamp = new System.Int64();
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (this.StdPath == null && Exploration.Includes(parent + ".stdPath", true))
        {
            this.StdPath = "FETCH";
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = "FETCH";
        }
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (this.AnalyzerGroupResults == null && Exploration.Includes(parent + ".analyzerGroupResults"))
        {
            this.AnalyzerGroupResults = new List<AnalyzerGroupResult>();
            this.AnalyzerGroupResults.ApplyExploratoryFieldSpec(parent + ".analyzerGroupResults");
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults == null && Exploration.Includes(parent + ".analyzerResults"))
        {
            this.AnalyzerResults = new List<AnalyzerResult>();
            this.AnalyzerResults.ApplyExploratoryFieldSpec(parent + ".analyzerResults");
        }
        //      C# -> AnalyzerHits? AnalyzerRiskHits
        // GraphQL -> analyzerRiskHits: AnalyzerHits (type)
        if (this.AnalyzerRiskHits == null && Exploration.Includes(parent + ".analyzerRiskHits"))
        {
            this.AnalyzerRiskHits = new AnalyzerHits();
            this.AnalyzerRiskHits.ApplyExploratoryFieldSpec(parent + ".analyzerRiskHits");
        }
        //      C# -> Hits? FilesWithHits
        // GraphQL -> filesWithHits: Hits (type)
        if (this.FilesWithHits == null && Exploration.Includes(parent + ".filesWithHits"))
        {
            this.FilesWithHits = new Hits();
            this.FilesWithHits.ApplyExploratoryFieldSpec(parent + ".filesWithHits");
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits == null && Exploration.Includes(parent + ".hits"))
        {
            this.Hits = new Hits();
            this.Hits.ApplyExploratoryFieldSpec(parent + ".hits");
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (this.NumActivitiesBreakdown == null && Exploration.Includes(parent + ".numActivitiesBreakdown"))
        {
            this.NumActivitiesBreakdown = new List<ActivityResult>();
            this.NumActivitiesBreakdown.ApplyExploratoryFieldSpec(parent + ".numActivitiesBreakdown");
        }
        //      C# -> Hits? OpenAccessFiles
        // GraphQL -> openAccessFiles: Hits (type)
        if (this.OpenAccessFiles == null && Exploration.Includes(parent + ".openAccessFiles"))
        {
            this.OpenAccessFiles = new Hits();
            this.OpenAccessFiles.ApplyExploratoryFieldSpec(parent + ".openAccessFiles");
        }
        //      C# -> Hits? OpenAccessFilesWithHits
        // GraphQL -> openAccessFilesWithHits: Hits (type)
        if (this.OpenAccessFilesWithHits == null && Exploration.Includes(parent + ".openAccessFilesWithHits"))
        {
            this.OpenAccessFilesWithHits = new Hits();
            this.OpenAccessFilesWithHits.ApplyExploratoryFieldSpec(parent + ".openAccessFilesWithHits");
        }
        //      C# -> Hits? OpenAccessFolders
        // GraphQL -> openAccessFolders: Hits (type)
        if (this.OpenAccessFolders == null && Exploration.Includes(parent + ".openAccessFolders"))
        {
            this.OpenAccessFolders = new Hits();
            this.OpenAccessFolders.ApplyExploratoryFieldSpec(parent + ".openAccessFolders");
        }
        //      C# -> Hits? OpenAccessStaleFiles
        // GraphQL -> openAccessStaleFiles: Hits (type)
        if (this.OpenAccessStaleFiles == null && Exploration.Includes(parent + ".openAccessStaleFiles"))
        {
            this.OpenAccessStaleFiles = new Hits();
            this.OpenAccessStaleFiles.ApplyExploratoryFieldSpec(parent + ".openAccessStaleFiles");
        }
        //      C# -> PrincipalAccessInfo? PrincipalAccessInfo
        // GraphQL -> principalAccessInfo: PrincipalAccessInfo (type)
        if (this.PrincipalAccessInfo == null && Exploration.Includes(parent + ".principalAccessInfo"))
        {
            this.PrincipalAccessInfo = new PrincipalAccessInfo();
            this.PrincipalAccessInfo.ApplyExploratoryFieldSpec(parent + ".principalAccessInfo");
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles == null && Exploration.Includes(parent + ".sensitiveFiles"))
        {
            this.SensitiveFiles = new SensitiveFiles();
            this.SensitiveFiles.ApplyExploratoryFieldSpec(parent + ".sensitiveFiles");
        }
        //      C# -> Hits? StaleFiles
        // GraphQL -> staleFiles: Hits (type)
        if (this.StaleFiles == null && Exploration.Includes(parent + ".staleFiles"))
        {
            this.StaleFiles = new Hits();
            this.StaleFiles.ApplyExploratoryFieldSpec(parent + ".staleFiles");
        }
        //      C# -> Hits? StaleFilesWithHits
        // GraphQL -> staleFilesWithHits: Hits (type)
        if (this.StaleFilesWithHits == null && Exploration.Includes(parent + ".staleFilesWithHits"))
        {
            this.StaleFilesWithHits = new Hits();
            this.StaleFilesWithHits.ApplyExploratoryFieldSpec(parent + ".staleFilesWithHits");
        }
    }


    #endregion

    } // class FileResult
    
    #endregion

    public static class ListFileResultExtensions
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
            this List<FileResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FileResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FileResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types