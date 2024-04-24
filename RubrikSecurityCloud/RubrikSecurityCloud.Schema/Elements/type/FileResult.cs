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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AnalyzerErrorCode? ErrorCode
        // GraphQL -> errorCode: AnalyzerErrorCode! (enum)
        if (this.ErrorCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorCode\n" ;
            } else {
                s += ind + "errorCode\n" ;
            }
        }
        //      C# -> DataGovFileMode? Mode
        // GraphQL -> mode: DataGovFileMode! (enum)
        if (this.Mode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mode\n" ;
            } else {
                s += ind + "mode\n" ;
            }
        }
        //      C# -> OpenAccessType? OpenAccessType
        // GraphQL -> openAccessType: OpenAccessType! (enum)
        if (this.OpenAccessType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "openAccessType\n" ;
            } else {
                s += ind + "openAccessType\n" ;
            }
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskLevel\n" ;
            } else {
                s += ind + "riskLevel\n" ;
            }
        }
        //      C# -> List<RiskReason>? RiskReasons
        // GraphQL -> riskReasons: [RiskReason!]! (enum)
        if (this.RiskReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskReasons\n" ;
            } else {
                s += ind + "riskReasons\n" ;
            }
        }
        //      C# -> StalenessType? StalenessType
        // GraphQL -> stalenessType: StalenessType! (enum)
        if (this.StalenessType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stalenessType\n" ;
            } else {
                s += ind + "stalenessType\n" ;
            }
        }
        //      C# -> UserAccessType? UserAccessType
        // GraphQL -> userAccessType: UserAccessType! (enum)
        if (this.UserAccessType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userAccessType\n" ;
            } else {
                s += ind + "userAccessType\n" ;
            }
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (this.Snappable != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.Snappable, conf.Child("snappable"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? AccessibleBySidsRepresentation
        // GraphQL -> accessibleBySidsRepresentation: String! (scalar)
        if (this.AccessibleBySidsRepresentation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessibleBySidsRepresentation\n" ;
            } else {
                s += ind + "accessibleBySidsRepresentation\n" ;
            }
        }
        //      C# -> System.String? AccessibleBySidsRepresentationShortForm
        // GraphQL -> accessibleBySidsRepresentationShortForm: String! (scalar)
        if (this.AccessibleBySidsRepresentationShortForm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessibleBySidsRepresentationShortForm\n" ;
            } else {
                s += ind + "accessibleBySidsRepresentationShortForm\n" ;
            }
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (this.Directory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directory\n" ;
            } else {
                s += ind + "directory\n" ;
            }
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filename\n" ;
            } else {
                s += ind + "filename\n" ;
            }
        }
        //      C# -> System.Boolean? IsDirectAcl
        // GraphQL -> isDirectAcl: Boolean! (scalar)
        if (this.IsDirectAcl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDirectAcl\n" ;
            } else {
                s += ind + "isDirectAcl\n" ;
            }
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (this.LastAccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastAccessTime\n" ;
            } else {
                s += ind + "lastAccessTime\n" ;
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
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (this.NativePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativePath\n" ;
            } else {
                s += ind + "nativePath\n" ;
            }
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (this.NumActivities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numActivities\n" ;
            } else {
                s += ind + "numActivities\n" ;
            }
        }
        //      C# -> System.Int64? NumActivitiesDelta
        // GraphQL -> numActivitiesDelta: Long! (scalar)
        if (this.NumActivitiesDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numActivitiesDelta\n" ;
            } else {
                s += ind + "numActivitiesDelta\n" ;
            }
        }
        //      C# -> System.Int64? NumChildren
        // GraphQL -> numChildren: Long! (scalar)
        if (this.NumChildren != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numChildren\n" ;
            } else {
                s += ind + "numChildren\n" ;
            }
        }
        //      C# -> System.Int64? NumDescendantErrorFiles
        // GraphQL -> numDescendantErrorFiles: Long! (scalar)
        if (this.NumDescendantErrorFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendantErrorFiles\n" ;
            } else {
                s += ind + "numDescendantErrorFiles\n" ;
            }
        }
        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        if (this.NumDescendantFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendantFiles\n" ;
            } else {
                s += ind + "numDescendantFiles\n" ;
            }
        }
        //      C# -> System.Int64? NumDescendantFolders
        // GraphQL -> numDescendantFolders: Long! (scalar)
        if (this.NumDescendantFolders != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendantFolders\n" ;
            } else {
                s += ind + "numDescendantFolders\n" ;
            }
        }
        //      C# -> System.Int64? NumDescendantSkippedExtFiles
        // GraphQL -> numDescendantSkippedExtFiles: Long! (scalar)
        if (this.NumDescendantSkippedExtFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendantSkippedExtFiles\n" ;
            } else {
                s += ind + "numDescendantSkippedExtFiles\n" ;
            }
        }
        //      C# -> System.Int64? NumDescendantSkippedSizeFiles
        // GraphQL -> numDescendantSkippedSizeFiles: Long! (scalar)
        if (this.NumDescendantSkippedSizeFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendantSkippedSizeFiles\n" ;
            } else {
                s += ind + "numDescendantSkippedSizeFiles\n" ;
            }
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (this.Owner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "owner\n" ;
            } else {
                s += ind + "owner\n" ;
            }
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (this.PaginationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "paginationId\n" ;
            } else {
                s += ind + "paginationId\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotTimestamp
        // GraphQL -> snapshotTimestamp: Long! (scalar)
        if (this.SnapshotTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTimestamp\n" ;
            } else {
                s += ind + "snapshotTimestamp\n" ;
            }
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (this.StdPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stdPath\n" ;
            } else {
                s += ind + "stdPath\n" ;
            }
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (this.AnalyzerGroupResults != null) {
            var fspec = this.AnalyzerGroupResults.AsFieldSpec(conf.Child("analyzerGroupResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerGroupResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (this.AnalyzerResults != null) {
            var fspec = this.AnalyzerResults.AsFieldSpec(conf.Child("analyzerResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AnalyzerHits? AnalyzerRiskHits
        // GraphQL -> analyzerRiskHits: AnalyzerHits (type)
        if (this.AnalyzerRiskHits != null) {
            var fspec = this.AnalyzerRiskHits.AsFieldSpec(conf.Child("analyzerRiskHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerRiskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? FilesWithHits
        // GraphQL -> filesWithHits: Hits (type)
        if (this.FilesWithHits != null) {
            var fspec = this.FilesWithHits.AsFieldSpec(conf.Child("filesWithHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesWithHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (this.Hits != null) {
            var fspec = this.Hits.AsFieldSpec(conf.Child("hits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (this.NumActivitiesBreakdown != null) {
            var fspec = this.NumActivitiesBreakdown.AsFieldSpec(conf.Child("numActivitiesBreakdown"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "numActivitiesBreakdown" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? OpenAccessFiles
        // GraphQL -> openAccessFiles: Hits (type)
        if (this.OpenAccessFiles != null) {
            var fspec = this.OpenAccessFiles.AsFieldSpec(conf.Child("openAccessFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "openAccessFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? OpenAccessFilesWithHits
        // GraphQL -> openAccessFilesWithHits: Hits (type)
        if (this.OpenAccessFilesWithHits != null) {
            var fspec = this.OpenAccessFilesWithHits.AsFieldSpec(conf.Child("openAccessFilesWithHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "openAccessFilesWithHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? OpenAccessFolders
        // GraphQL -> openAccessFolders: Hits (type)
        if (this.OpenAccessFolders != null) {
            var fspec = this.OpenAccessFolders.AsFieldSpec(conf.Child("openAccessFolders"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "openAccessFolders" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? OpenAccessStaleFiles
        // GraphQL -> openAccessStaleFiles: Hits (type)
        if (this.OpenAccessStaleFiles != null) {
            var fspec = this.OpenAccessStaleFiles.AsFieldSpec(conf.Child("openAccessStaleFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "openAccessStaleFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalAccessInfo? PrincipalAccessInfo
        // GraphQL -> principalAccessInfo: PrincipalAccessInfo (type)
        if (this.PrincipalAccessInfo != null) {
            var fspec = this.PrincipalAccessInfo.AsFieldSpec(conf.Child("principalAccessInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "principalAccessInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(conf.Child("sensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? StaleFiles
        // GraphQL -> staleFiles: Hits (type)
        if (this.StaleFiles != null) {
            var fspec = this.StaleFiles.AsFieldSpec(conf.Child("staleFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "staleFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? StaleFilesWithHits
        // GraphQL -> staleFilesWithHits: Hits (type)
        if (this.StaleFilesWithHits != null) {
            var fspec = this.StaleFilesWithHits.AsFieldSpec(conf.Child("staleFilesWithHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "staleFilesWithHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AnalyzerErrorCode? ErrorCode
        // GraphQL -> errorCode: AnalyzerErrorCode! (enum)
        if (ec.Includes("errorCode",true))
        {
            if(this.ErrorCode == null) {

                this.ErrorCode = new AnalyzerErrorCode();

            } else {


            }
        }
        else if (this.ErrorCode != null && ec.Excludes("errorCode",true))
        {
            this.ErrorCode = null;
        }
        //      C# -> DataGovFileMode? Mode
        // GraphQL -> mode: DataGovFileMode! (enum)
        if (ec.Includes("mode",true))
        {
            if(this.Mode == null) {

                this.Mode = new DataGovFileMode();

            } else {


            }
        }
        else if (this.Mode != null && ec.Excludes("mode",true))
        {
            this.Mode = null;
        }
        //      C# -> OpenAccessType? OpenAccessType
        // GraphQL -> openAccessType: OpenAccessType! (enum)
        if (ec.Includes("openAccessType",true))
        {
            if(this.OpenAccessType == null) {

                this.OpenAccessType = new OpenAccessType();

            } else {


            }
        }
        else if (this.OpenAccessType != null && ec.Excludes("openAccessType",true))
        {
            this.OpenAccessType = null;
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (ec.Includes("riskLevel",true))
        {
            if(this.RiskLevel == null) {

                this.RiskLevel = new RiskLevelType();

            } else {


            }
        }
        else if (this.RiskLevel != null && ec.Excludes("riskLevel",true))
        {
            this.RiskLevel = null;
        }
        //      C# -> List<RiskReason>? RiskReasons
        // GraphQL -> riskReasons: [RiskReason!]! (enum)
        if (ec.Includes("riskReasons",true))
        {
            if(this.RiskReasons == null) {

                this.RiskReasons = new List<RiskReason>();

            } else {


            }
        }
        else if (this.RiskReasons != null && ec.Excludes("riskReasons",true))
        {
            this.RiskReasons = null;
        }
        //      C# -> StalenessType? StalenessType
        // GraphQL -> stalenessType: StalenessType! (enum)
        if (ec.Includes("stalenessType",true))
        {
            if(this.StalenessType == null) {

                this.StalenessType = new StalenessType();

            } else {


            }
        }
        else if (this.StalenessType != null && ec.Excludes("stalenessType",true))
        {
            this.StalenessType = null;
        }
        //      C# -> UserAccessType? UserAccessType
        // GraphQL -> userAccessType: UserAccessType! (enum)
        if (ec.Includes("userAccessType",true))
        {
            if(this.UserAccessType == null) {

                this.UserAccessType = new UserAccessType();

            } else {


            }
        }
        else if (this.UserAccessType != null && ec.Excludes("userAccessType",true))
        {
            this.UserAccessType = null;
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                var impls = new RscInterface<HierarchyObject>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
                this.Snappable = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<HierarchyObject>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
                this.Snappable = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
        //      C# -> System.String? AccessibleBySidsRepresentation
        // GraphQL -> accessibleBySidsRepresentation: String! (scalar)
        if (ec.Includes("accessibleBySidsRepresentation",true))
        {
            if(this.AccessibleBySidsRepresentation == null) {

                this.AccessibleBySidsRepresentation = "FETCH";

            } else {


            }
        }
        else if (this.AccessibleBySidsRepresentation != null && ec.Excludes("accessibleBySidsRepresentation",true))
        {
            this.AccessibleBySidsRepresentation = null;
        }
        //      C# -> System.String? AccessibleBySidsRepresentationShortForm
        // GraphQL -> accessibleBySidsRepresentationShortForm: String! (scalar)
        if (ec.Includes("accessibleBySidsRepresentationShortForm",true))
        {
            if(this.AccessibleBySidsRepresentationShortForm == null) {

                this.AccessibleBySidsRepresentationShortForm = "FETCH";

            } else {


            }
        }
        else if (this.AccessibleBySidsRepresentationShortForm != null && ec.Excludes("accessibleBySidsRepresentationShortForm",true))
        {
            this.AccessibleBySidsRepresentationShortForm = null;
        }
        //      C# -> System.String? Directory
        // GraphQL -> directory: String! (scalar)
        if (ec.Includes("directory",true))
        {
            if(this.Directory == null) {

                this.Directory = "FETCH";

            } else {


            }
        }
        else if (this.Directory != null && ec.Excludes("directory",true))
        {
            this.Directory = null;
        }
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (ec.Includes("filename",true))
        {
            if(this.Filename == null) {

                this.Filename = "FETCH";

            } else {


            }
        }
        else if (this.Filename != null && ec.Excludes("filename",true))
        {
            this.Filename = null;
        }
        //      C# -> System.Boolean? IsDirectAcl
        // GraphQL -> isDirectAcl: Boolean! (scalar)
        if (ec.Includes("isDirectAcl",true))
        {
            if(this.IsDirectAcl == null) {

                this.IsDirectAcl = true;

            } else {


            }
        }
        else if (this.IsDirectAcl != null && ec.Excludes("isDirectAcl",true))
        {
            this.IsDirectAcl = null;
        }
        //      C# -> System.Int64? LastAccessTime
        // GraphQL -> lastAccessTime: Long! (scalar)
        if (ec.Includes("lastAccessTime",true))
        {
            if(this.LastAccessTime == null) {

                this.LastAccessTime = new System.Int64();

            } else {


            }
        }
        else if (this.LastAccessTime != null && ec.Excludes("lastAccessTime",true))
        {
            this.LastAccessTime = null;
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
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        if (ec.Includes("nativePath",true))
        {
            if(this.NativePath == null) {

                this.NativePath = "FETCH";

            } else {


            }
        }
        else if (this.NativePath != null && ec.Excludes("nativePath",true))
        {
            this.NativePath = null;
        }
        //      C# -> System.Int64? NumActivities
        // GraphQL -> numActivities: Long! (scalar)
        if (ec.Includes("numActivities",true))
        {
            if(this.NumActivities == null) {

                this.NumActivities = new System.Int64();

            } else {


            }
        }
        else if (this.NumActivities != null && ec.Excludes("numActivities",true))
        {
            this.NumActivities = null;
        }
        //      C# -> System.Int64? NumActivitiesDelta
        // GraphQL -> numActivitiesDelta: Long! (scalar)
        if (ec.Includes("numActivitiesDelta",true))
        {
            if(this.NumActivitiesDelta == null) {

                this.NumActivitiesDelta = new System.Int64();

            } else {


            }
        }
        else if (this.NumActivitiesDelta != null && ec.Excludes("numActivitiesDelta",true))
        {
            this.NumActivitiesDelta = null;
        }
        //      C# -> System.Int64? NumChildren
        // GraphQL -> numChildren: Long! (scalar)
        if (ec.Includes("numChildren",true))
        {
            if(this.NumChildren == null) {

                this.NumChildren = new System.Int64();

            } else {


            }
        }
        else if (this.NumChildren != null && ec.Excludes("numChildren",true))
        {
            this.NumChildren = null;
        }
        //      C# -> System.Int64? NumDescendantErrorFiles
        // GraphQL -> numDescendantErrorFiles: Long! (scalar)
        if (ec.Includes("numDescendantErrorFiles",true))
        {
            if(this.NumDescendantErrorFiles == null) {

                this.NumDescendantErrorFiles = new System.Int64();

            } else {


            }
        }
        else if (this.NumDescendantErrorFiles != null && ec.Excludes("numDescendantErrorFiles",true))
        {
            this.NumDescendantErrorFiles = null;
        }
        //      C# -> System.Int32? NumDescendantFiles
        // GraphQL -> numDescendantFiles: Int! (scalar)
        if (ec.Includes("numDescendantFiles",true))
        {
            if(this.NumDescendantFiles == null) {

                this.NumDescendantFiles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDescendantFiles != null && ec.Excludes("numDescendantFiles",true))
        {
            this.NumDescendantFiles = null;
        }
        //      C# -> System.Int64? NumDescendantFolders
        // GraphQL -> numDescendantFolders: Long! (scalar)
        if (ec.Includes("numDescendantFolders",true))
        {
            if(this.NumDescendantFolders == null) {

                this.NumDescendantFolders = new System.Int64();

            } else {


            }
        }
        else if (this.NumDescendantFolders != null && ec.Excludes("numDescendantFolders",true))
        {
            this.NumDescendantFolders = null;
        }
        //      C# -> System.Int64? NumDescendantSkippedExtFiles
        // GraphQL -> numDescendantSkippedExtFiles: Long! (scalar)
        if (ec.Includes("numDescendantSkippedExtFiles",true))
        {
            if(this.NumDescendantSkippedExtFiles == null) {

                this.NumDescendantSkippedExtFiles = new System.Int64();

            } else {


            }
        }
        else if (this.NumDescendantSkippedExtFiles != null && ec.Excludes("numDescendantSkippedExtFiles",true))
        {
            this.NumDescendantSkippedExtFiles = null;
        }
        //      C# -> System.Int64? NumDescendantSkippedSizeFiles
        // GraphQL -> numDescendantSkippedSizeFiles: Long! (scalar)
        if (ec.Includes("numDescendantSkippedSizeFiles",true))
        {
            if(this.NumDescendantSkippedSizeFiles == null) {

                this.NumDescendantSkippedSizeFiles = new System.Int64();

            } else {


            }
        }
        else if (this.NumDescendantSkippedSizeFiles != null && ec.Excludes("numDescendantSkippedSizeFiles",true))
        {
            this.NumDescendantSkippedSizeFiles = null;
        }
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        if (ec.Includes("owner",true))
        {
            if(this.Owner == null) {

                this.Owner = "FETCH";

            } else {


            }
        }
        else if (this.Owner != null && ec.Excludes("owner",true))
        {
            this.Owner = null;
        }
        //      C# -> System.String? PaginationId
        // GraphQL -> paginationId: String! (scalar)
        if (ec.Includes("paginationId",true))
        {
            if(this.PaginationId == null) {

                this.PaginationId = "FETCH";

            } else {


            }
        }
        else if (this.PaginationId != null && ec.Excludes("paginationId",true))
        {
            this.PaginationId = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
        }
        //      C# -> System.Int64? SnapshotTimestamp
        // GraphQL -> snapshotTimestamp: Long! (scalar)
        if (ec.Includes("snapshotTimestamp",true))
        {
            if(this.SnapshotTimestamp == null) {

                this.SnapshotTimestamp = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotTimestamp != null && ec.Excludes("snapshotTimestamp",true))
        {
            this.SnapshotTimestamp = null;
        }
        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        if (ec.Includes("stdPath",true))
        {
            if(this.StdPath == null) {

                this.StdPath = "FETCH";

            } else {


            }
        }
        else if (this.StdPath != null && ec.Excludes("stdPath",true))
        {
            this.StdPath = null;
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = "FETCH";

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (ec.Includes("analyzerGroupResults",false))
        {
            if(this.AnalyzerGroupResults == null) {

                this.AnalyzerGroupResults = new List<AnalyzerGroupResult>();
                this.AnalyzerGroupResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroupResults"));

            } else {

                this.AnalyzerGroupResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroupResults"));

            }
        }
        else if (this.AnalyzerGroupResults != null && ec.Excludes("analyzerGroupResults",false))
        {
            this.AnalyzerGroupResults = null;
        }
        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        if (ec.Includes("analyzerResults",false))
        {
            if(this.AnalyzerResults == null) {

                this.AnalyzerResults = new List<AnalyzerResult>();
                this.AnalyzerResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResults"));

            } else {

                this.AnalyzerResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerResults"));

            }
        }
        else if (this.AnalyzerResults != null && ec.Excludes("analyzerResults",false))
        {
            this.AnalyzerResults = null;
        }
        //      C# -> AnalyzerHits? AnalyzerRiskHits
        // GraphQL -> analyzerRiskHits: AnalyzerHits (type)
        if (ec.Includes("analyzerRiskHits",false))
        {
            if(this.AnalyzerRiskHits == null) {

                this.AnalyzerRiskHits = new AnalyzerHits();
                this.AnalyzerRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("analyzerRiskHits"));

            } else {

                this.AnalyzerRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("analyzerRiskHits"));

            }
        }
        else if (this.AnalyzerRiskHits != null && ec.Excludes("analyzerRiskHits",false))
        {
            this.AnalyzerRiskHits = null;
        }
        //      C# -> Hits? FilesWithHits
        // GraphQL -> filesWithHits: Hits (type)
        if (ec.Includes("filesWithHits",false))
        {
            if(this.FilesWithHits == null) {

                this.FilesWithHits = new Hits();
                this.FilesWithHits.ApplyExploratoryFieldSpec(ec.NewChild("filesWithHits"));

            } else {

                this.FilesWithHits.ApplyExploratoryFieldSpec(ec.NewChild("filesWithHits"));

            }
        }
        else if (this.FilesWithHits != null && ec.Excludes("filesWithHits",false))
        {
            this.FilesWithHits = null;
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        if (ec.Includes("hits",false))
        {
            if(this.Hits == null) {

                this.Hits = new Hits();
                this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));

            } else {

                this.Hits.ApplyExploratoryFieldSpec(ec.NewChild("hits"));

            }
        }
        else if (this.Hits != null && ec.Excludes("hits",false))
        {
            this.Hits = null;
        }
        //      C# -> List<ActivityResult>? NumActivitiesBreakdown
        // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
        if (ec.Includes("numActivitiesBreakdown",false))
        {
            if(this.NumActivitiesBreakdown == null) {

                this.NumActivitiesBreakdown = new List<ActivityResult>();
                this.NumActivitiesBreakdown.ApplyExploratoryFieldSpec(ec.NewChild("numActivitiesBreakdown"));

            } else {

                this.NumActivitiesBreakdown.ApplyExploratoryFieldSpec(ec.NewChild("numActivitiesBreakdown"));

            }
        }
        else if (this.NumActivitiesBreakdown != null && ec.Excludes("numActivitiesBreakdown",false))
        {
            this.NumActivitiesBreakdown = null;
        }
        //      C# -> Hits? OpenAccessFiles
        // GraphQL -> openAccessFiles: Hits (type)
        if (ec.Includes("openAccessFiles",false))
        {
            if(this.OpenAccessFiles == null) {

                this.OpenAccessFiles = new Hits();
                this.OpenAccessFiles.ApplyExploratoryFieldSpec(ec.NewChild("openAccessFiles"));

            } else {

                this.OpenAccessFiles.ApplyExploratoryFieldSpec(ec.NewChild("openAccessFiles"));

            }
        }
        else if (this.OpenAccessFiles != null && ec.Excludes("openAccessFiles",false))
        {
            this.OpenAccessFiles = null;
        }
        //      C# -> Hits? OpenAccessFilesWithHits
        // GraphQL -> openAccessFilesWithHits: Hits (type)
        if (ec.Includes("openAccessFilesWithHits",false))
        {
            if(this.OpenAccessFilesWithHits == null) {

                this.OpenAccessFilesWithHits = new Hits();
                this.OpenAccessFilesWithHits.ApplyExploratoryFieldSpec(ec.NewChild("openAccessFilesWithHits"));

            } else {

                this.OpenAccessFilesWithHits.ApplyExploratoryFieldSpec(ec.NewChild("openAccessFilesWithHits"));

            }
        }
        else if (this.OpenAccessFilesWithHits != null && ec.Excludes("openAccessFilesWithHits",false))
        {
            this.OpenAccessFilesWithHits = null;
        }
        //      C# -> Hits? OpenAccessFolders
        // GraphQL -> openAccessFolders: Hits (type)
        if (ec.Includes("openAccessFolders",false))
        {
            if(this.OpenAccessFolders == null) {

                this.OpenAccessFolders = new Hits();
                this.OpenAccessFolders.ApplyExploratoryFieldSpec(ec.NewChild("openAccessFolders"));

            } else {

                this.OpenAccessFolders.ApplyExploratoryFieldSpec(ec.NewChild("openAccessFolders"));

            }
        }
        else if (this.OpenAccessFolders != null && ec.Excludes("openAccessFolders",false))
        {
            this.OpenAccessFolders = null;
        }
        //      C# -> Hits? OpenAccessStaleFiles
        // GraphQL -> openAccessStaleFiles: Hits (type)
        if (ec.Includes("openAccessStaleFiles",false))
        {
            if(this.OpenAccessStaleFiles == null) {

                this.OpenAccessStaleFiles = new Hits();
                this.OpenAccessStaleFiles.ApplyExploratoryFieldSpec(ec.NewChild("openAccessStaleFiles"));

            } else {

                this.OpenAccessStaleFiles.ApplyExploratoryFieldSpec(ec.NewChild("openAccessStaleFiles"));

            }
        }
        else if (this.OpenAccessStaleFiles != null && ec.Excludes("openAccessStaleFiles",false))
        {
            this.OpenAccessStaleFiles = null;
        }
        //      C# -> PrincipalAccessInfo? PrincipalAccessInfo
        // GraphQL -> principalAccessInfo: PrincipalAccessInfo (type)
        if (ec.Includes("principalAccessInfo",false))
        {
            if(this.PrincipalAccessInfo == null) {

                this.PrincipalAccessInfo = new PrincipalAccessInfo();
                this.PrincipalAccessInfo.ApplyExploratoryFieldSpec(ec.NewChild("principalAccessInfo"));

            } else {

                this.PrincipalAccessInfo.ApplyExploratoryFieldSpec(ec.NewChild("principalAccessInfo"));

            }
        }
        else if (this.PrincipalAccessInfo != null && ec.Excludes("principalAccessInfo",false))
        {
            this.PrincipalAccessInfo = null;
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("sensitiveFiles",false))
        {
            if(this.SensitiveFiles == null) {

                this.SensitiveFiles = new SensitiveFiles();
                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            } else {

                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            }
        }
        else if (this.SensitiveFiles != null && ec.Excludes("sensitiveFiles",false))
        {
            this.SensitiveFiles = null;
        }
        //      C# -> Hits? StaleFiles
        // GraphQL -> staleFiles: Hits (type)
        if (ec.Includes("staleFiles",false))
        {
            if(this.StaleFiles == null) {

                this.StaleFiles = new Hits();
                this.StaleFiles.ApplyExploratoryFieldSpec(ec.NewChild("staleFiles"));

            } else {

                this.StaleFiles.ApplyExploratoryFieldSpec(ec.NewChild("staleFiles"));

            }
        }
        else if (this.StaleFiles != null && ec.Excludes("staleFiles",false))
        {
            this.StaleFiles = null;
        }
        //      C# -> Hits? StaleFilesWithHits
        // GraphQL -> staleFilesWithHits: Hits (type)
        if (ec.Includes("staleFilesWithHits",false))
        {
            if(this.StaleFilesWithHits == null) {

                this.StaleFilesWithHits = new Hits();
                this.StaleFilesWithHits.ApplyExploratoryFieldSpec(ec.NewChild("staleFilesWithHits"));

            } else {

                this.StaleFilesWithHits.ApplyExploratoryFieldSpec(ec.NewChild("staleFilesWithHits"));

            }
        }
        else if (this.StaleFilesWithHits != null && ec.Excludes("staleFilesWithHits",false))
        {
            this.StaleFilesWithHits = null;
        }
    }


    #endregion

    } // class FileResult
    
    #endregion

    public static class ListFileResultExtensions
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
            this List<FileResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FileResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FileResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FileResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FileResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types