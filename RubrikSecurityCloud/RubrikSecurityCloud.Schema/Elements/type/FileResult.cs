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

namespace Rubrik.SecurityCloud.Types
{
    #region FileResult
    public class FileResult: IFragment
    {
        #region members
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

        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        [JsonProperty("analyzerGroupResults")]
        public List<AnalyzerGroupResult>? AnalyzerGroupResults { get; set; }

        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        [JsonProperty("analyzerResults")]
        public List<AnalyzerResult>? AnalyzerResults { get; set; }

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

        //      C# -> Hits? StaleFiles
        // GraphQL -> staleFiles: Hits (type)
        [JsonProperty("staleFiles")]
        public Hits? StaleFiles { get; set; }

        //      C# -> Hits? StaleFilesWithHits
        // GraphQL -> staleFilesWithHits: Hits (type)
        [JsonProperty("staleFilesWithHits")]
        public Hits? StaleFilesWithHits { get; set; }

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

        #endregion

    #region methods

    public FileResult Set(
        System.String? AccessibleBySidsRepresentation = null,
        System.String? AccessibleBySidsRepresentationShortForm = null,
        System.String? Directory = null,
        System.String? Filename = null,
        System.Int64? LastAccessTime = null,
        System.Int64? LastModifiedTime = null,
        System.String? NativePath = null,
        System.Int64? NumActivities = null,
        System.Int64? NumActivitiesDelta = null,
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
        List<AnalyzerGroupResult>? AnalyzerGroupResults = null,
        List<AnalyzerResult>? AnalyzerResults = null,
        Hits? FilesWithHits = null,
        Hits? Hits = null,
        List<ActivityResult>? NumActivitiesBreakdown = null,
        Hits? OpenAccessFiles = null,
        Hits? OpenAccessFilesWithHits = null,
        Hits? OpenAccessFolders = null,
        Hits? OpenAccessStaleFiles = null,
        Hits? StaleFiles = null,
        Hits? StaleFilesWithHits = null,
        AnalyzerErrorCode? ErrorCode = null,
        DataGovFileMode? Mode = null,
        OpenAccessType? OpenAccessType = null,
        StalenessType? StalenessType = null,
        UserAccessType? UserAccessType = null,
        HierarchyObject? Snappable = null
    ) 
    {
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
        if ( AnalyzerGroupResults != null ) {
            this.AnalyzerGroupResults = AnalyzerGroupResults;
        }
        if ( AnalyzerResults != null ) {
            this.AnalyzerResults = AnalyzerResults;
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
        if ( StaleFiles != null ) {
            this.StaleFiles = StaleFiles;
        }
        if ( StaleFilesWithHits != null ) {
            this.StaleFilesWithHits = StaleFilesWithHits;
        }
        if ( ErrorCode != null ) {
            this.ErrorCode = ErrorCode;
        }
        if ( Mode != null ) {
            this.Mode = Mode;
        }
        if ( OpenAccessType != null ) {
            this.OpenAccessType = OpenAccessType;
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AccessibleBySidsRepresentation
            // GraphQL -> accessibleBySidsRepresentation: String! (scalar)
            if (this.AccessibleBySidsRepresentation != null)
            {
                 s += ind + "accessibleBySidsRepresentation\n";

            }
            //      C# -> System.String? AccessibleBySidsRepresentationShortForm
            // GraphQL -> accessibleBySidsRepresentationShortForm: String! (scalar)
            if (this.AccessibleBySidsRepresentationShortForm != null)
            {
                 s += ind + "accessibleBySidsRepresentationShortForm\n";

            }
            //      C# -> System.String? Directory
            // GraphQL -> directory: String! (scalar)
            if (this.Directory != null)
            {
                 s += ind + "directory\n";

            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename != null)
            {
                 s += ind + "filename\n";

            }
            //      C# -> System.Int64? LastAccessTime
            // GraphQL -> lastAccessTime: Long! (scalar)
            if (this.LastAccessTime != null)
            {
                 s += ind + "lastAccessTime\n";

            }
            //      C# -> System.Int64? LastModifiedTime
            // GraphQL -> lastModifiedTime: Long! (scalar)
            if (this.LastModifiedTime != null)
            {
                 s += ind + "lastModifiedTime\n";

            }
            //      C# -> System.String? NativePath
            // GraphQL -> nativePath: String! (scalar)
            if (this.NativePath != null)
            {
                 s += ind + "nativePath\n";

            }
            //      C# -> System.Int64? NumActivities
            // GraphQL -> numActivities: Long! (scalar)
            if (this.NumActivities != null)
            {
                 s += ind + "numActivities\n";

            }
            //      C# -> System.Int64? NumActivitiesDelta
            // GraphQL -> numActivitiesDelta: Long! (scalar)
            if (this.NumActivitiesDelta != null)
            {
                 s += ind + "numActivitiesDelta\n";

            }
            //      C# -> System.Int64? NumDescendantErrorFiles
            // GraphQL -> numDescendantErrorFiles: Long! (scalar)
            if (this.NumDescendantErrorFiles != null)
            {
                 s += ind + "numDescendantErrorFiles\n";

            }
            //      C# -> System.Int32? NumDescendantFiles
            // GraphQL -> numDescendantFiles: Int! (scalar)
            if (this.NumDescendantFiles != null)
            {
                 s += ind + "numDescendantFiles\n";

            }
            //      C# -> System.Int64? NumDescendantFolders
            // GraphQL -> numDescendantFolders: Long! (scalar)
            if (this.NumDescendantFolders != null)
            {
                 s += ind + "numDescendantFolders\n";

            }
            //      C# -> System.Int64? NumDescendantSkippedExtFiles
            // GraphQL -> numDescendantSkippedExtFiles: Long! (scalar)
            if (this.NumDescendantSkippedExtFiles != null)
            {
                 s += ind + "numDescendantSkippedExtFiles\n";

            }
            //      C# -> System.Int64? NumDescendantSkippedSizeFiles
            // GraphQL -> numDescendantSkippedSizeFiles: Long! (scalar)
            if (this.NumDescendantSkippedSizeFiles != null)
            {
                 s += ind + "numDescendantSkippedSizeFiles\n";

            }
            //      C# -> System.String? Owner
            // GraphQL -> owner: String! (scalar)
            if (this.Owner != null)
            {
                 s += ind + "owner\n";

            }
            //      C# -> System.String? PaginationId
            // GraphQL -> paginationId: String! (scalar)
            if (this.PaginationId != null)
            {
                 s += ind + "paginationId\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid != null)
            {
                 s += ind + "snapshotFid\n";

            }
            //      C# -> System.Int64? SnapshotTimestamp
            // GraphQL -> snapshotTimestamp: Long! (scalar)
            if (this.SnapshotTimestamp != null)
            {
                 s += ind + "snapshotTimestamp\n";

            }
            //      C# -> System.String? StdPath
            // GraphQL -> stdPath: String! (scalar)
            if (this.StdPath != null)
            {
                 s += ind + "stdPath\n";

            }
            //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
            // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
            if (this.AnalyzerGroupResults != null)
            {
                 s += ind + "analyzerGroupResults\n";

                 s += ind + "{\n" + 
                 this.AnalyzerGroupResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AnalyzerResult>? AnalyzerResults
            // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
            if (this.AnalyzerResults != null)
            {
                 s += ind + "analyzerResults\n";

                 s += ind + "{\n" + 
                 this.AnalyzerResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? FilesWithHits
            // GraphQL -> filesWithHits: Hits (type)
            if (this.FilesWithHits != null)
            {
                 s += ind + "filesWithHits\n";

                 s += ind + "{\n" + 
                 this.FilesWithHits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits! (type)
            if (this.Hits != null)
            {
                 s += ind + "hits\n";

                 s += ind + "{\n" + 
                 this.Hits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ActivityResult>? NumActivitiesBreakdown
            // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
            if (this.NumActivitiesBreakdown != null)
            {
                 s += ind + "numActivitiesBreakdown\n";

                 s += ind + "{\n" + 
                 this.NumActivitiesBreakdown.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? OpenAccessFiles
            // GraphQL -> openAccessFiles: Hits (type)
            if (this.OpenAccessFiles != null)
            {
                 s += ind + "openAccessFiles\n";

                 s += ind + "{\n" + 
                 this.OpenAccessFiles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? OpenAccessFilesWithHits
            // GraphQL -> openAccessFilesWithHits: Hits (type)
            if (this.OpenAccessFilesWithHits != null)
            {
                 s += ind + "openAccessFilesWithHits\n";

                 s += ind + "{\n" + 
                 this.OpenAccessFilesWithHits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? OpenAccessFolders
            // GraphQL -> openAccessFolders: Hits (type)
            if (this.OpenAccessFolders != null)
            {
                 s += ind + "openAccessFolders\n";

                 s += ind + "{\n" + 
                 this.OpenAccessFolders.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? OpenAccessStaleFiles
            // GraphQL -> openAccessStaleFiles: Hits (type)
            if (this.OpenAccessStaleFiles != null)
            {
                 s += ind + "openAccessStaleFiles\n";

                 s += ind + "{\n" + 
                 this.OpenAccessStaleFiles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? StaleFiles
            // GraphQL -> staleFiles: Hits (type)
            if (this.StaleFiles != null)
            {
                 s += ind + "staleFiles\n";

                 s += ind + "{\n" + 
                 this.StaleFiles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Hits? StaleFilesWithHits
            // GraphQL -> staleFilesWithHits: Hits (type)
            if (this.StaleFilesWithHits != null)
            {
                 s += ind + "staleFilesWithHits\n";

                 s += ind + "{\n" + 
                 this.StaleFilesWithHits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AnalyzerErrorCode? ErrorCode
            // GraphQL -> errorCode: AnalyzerErrorCode! (enum)
            if (this.ErrorCode != null)
            {
                 s += ind + "errorCode\n";

            }
            //      C# -> DataGovFileMode? Mode
            // GraphQL -> mode: DataGovFileMode! (enum)
            if (this.Mode != null)
            {
                 s += ind + "mode\n";

            }
            //      C# -> OpenAccessType? OpenAccessType
            // GraphQL -> openAccessType: OpenAccessType! (enum)
            if (this.OpenAccessType != null)
            {
                 s += ind + "openAccessType\n";

            }
            //      C# -> StalenessType? StalenessType
            // GraphQL -> stalenessType: StalenessType! (enum)
            if (this.StalenessType != null)
            {
                 s += ind + "stalenessType\n";

            }
            //      C# -> UserAccessType? UserAccessType
            // GraphQL -> userAccessType: UserAccessType! (enum)
            if (this.UserAccessType != null)
            {
                 s += ind + "userAccessType\n";

            }
                        //      C# -> HierarchyObject? Snappable
            // GraphQL -> snappable: HierarchyObject! (interface)
            if (this.Snappable != null)
            {
                s += ind + "snappable\n";
                s += ind + "{\n";

                string typename = this.Snappable.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.Snappable.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccessibleBySidsRepresentation
            // GraphQL -> accessibleBySidsRepresentation: String! (scalar)
            if (this.AccessibleBySidsRepresentation == null && Exploration.Includes(parent + ".accessibleBySidsRepresentation$"))
            {
                this.AccessibleBySidsRepresentation = new System.String("FETCH");
            }
            //      C# -> System.String? AccessibleBySidsRepresentationShortForm
            // GraphQL -> accessibleBySidsRepresentationShortForm: String! (scalar)
            if (this.AccessibleBySidsRepresentationShortForm == null && Exploration.Includes(parent + ".accessibleBySidsRepresentationShortForm$"))
            {
                this.AccessibleBySidsRepresentationShortForm = new System.String("FETCH");
            }
            //      C# -> System.String? Directory
            // GraphQL -> directory: String! (scalar)
            if (this.Directory == null && Exploration.Includes(parent + ".directory$"))
            {
                this.Directory = new System.String("FETCH");
            }
            //      C# -> System.String? Filename
            // GraphQL -> filename: String! (scalar)
            if (this.Filename == null && Exploration.Includes(parent + ".filename$"))
            {
                this.Filename = new System.String("FETCH");
            }
            //      C# -> System.Int64? LastAccessTime
            // GraphQL -> lastAccessTime: Long! (scalar)
            if (this.LastAccessTime == null && Exploration.Includes(parent + ".lastAccessTime$"))
            {
                this.LastAccessTime = new System.Int64();
            }
            //      C# -> System.Int64? LastModifiedTime
            // GraphQL -> lastModifiedTime: Long! (scalar)
            if (this.LastModifiedTime == null && Exploration.Includes(parent + ".lastModifiedTime$"))
            {
                this.LastModifiedTime = new System.Int64();
            }
            //      C# -> System.String? NativePath
            // GraphQL -> nativePath: String! (scalar)
            if (this.NativePath == null && Exploration.Includes(parent + ".nativePath$"))
            {
                this.NativePath = new System.String("FETCH");
            }
            //      C# -> System.Int64? NumActivities
            // GraphQL -> numActivities: Long! (scalar)
            if (this.NumActivities == null && Exploration.Includes(parent + ".numActivities$"))
            {
                this.NumActivities = new System.Int64();
            }
            //      C# -> System.Int64? NumActivitiesDelta
            // GraphQL -> numActivitiesDelta: Long! (scalar)
            if (this.NumActivitiesDelta == null && Exploration.Includes(parent + ".numActivitiesDelta$"))
            {
                this.NumActivitiesDelta = new System.Int64();
            }
            //      C# -> System.Int64? NumDescendantErrorFiles
            // GraphQL -> numDescendantErrorFiles: Long! (scalar)
            if (this.NumDescendantErrorFiles == null && Exploration.Includes(parent + ".numDescendantErrorFiles$"))
            {
                this.NumDescendantErrorFiles = new System.Int64();
            }
            //      C# -> System.Int32? NumDescendantFiles
            // GraphQL -> numDescendantFiles: Int! (scalar)
            if (this.NumDescendantFiles == null && Exploration.Includes(parent + ".numDescendantFiles$"))
            {
                this.NumDescendantFiles = new System.Int32();
            }
            //      C# -> System.Int64? NumDescendantFolders
            // GraphQL -> numDescendantFolders: Long! (scalar)
            if (this.NumDescendantFolders == null && Exploration.Includes(parent + ".numDescendantFolders$"))
            {
                this.NumDescendantFolders = new System.Int64();
            }
            //      C# -> System.Int64? NumDescendantSkippedExtFiles
            // GraphQL -> numDescendantSkippedExtFiles: Long! (scalar)
            if (this.NumDescendantSkippedExtFiles == null && Exploration.Includes(parent + ".numDescendantSkippedExtFiles$"))
            {
                this.NumDescendantSkippedExtFiles = new System.Int64();
            }
            //      C# -> System.Int64? NumDescendantSkippedSizeFiles
            // GraphQL -> numDescendantSkippedSizeFiles: Long! (scalar)
            if (this.NumDescendantSkippedSizeFiles == null && Exploration.Includes(parent + ".numDescendantSkippedSizeFiles$"))
            {
                this.NumDescendantSkippedSizeFiles = new System.Int64();
            }
            //      C# -> System.String? Owner
            // GraphQL -> owner: String! (scalar)
            if (this.Owner == null && Exploration.Includes(parent + ".owner$"))
            {
                this.Owner = new System.String("FETCH");
            }
            //      C# -> System.String? PaginationId
            // GraphQL -> paginationId: String! (scalar)
            if (this.PaginationId == null && Exploration.Includes(parent + ".paginationId$"))
            {
                this.PaginationId = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid$"))
            {
                this.SnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.Int64? SnapshotTimestamp
            // GraphQL -> snapshotTimestamp: Long! (scalar)
            if (this.SnapshotTimestamp == null && Exploration.Includes(parent + ".snapshotTimestamp$"))
            {
                this.SnapshotTimestamp = new System.Int64();
            }
            //      C# -> System.String? StdPath
            // GraphQL -> stdPath: String! (scalar)
            if (this.StdPath == null && Exploration.Includes(parent + ".stdPath$"))
            {
                this.StdPath = new System.String("FETCH");
            }
            //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
            // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
            if (this.AnalyzerGroupResults == null && Exploration.Includes(parent + ".analyzerGroupResults"))
            {
                this.AnalyzerGroupResults = new List<AnalyzerGroupResult>();
                this.AnalyzerGroupResults.ApplyExploratoryFragment(parent + ".analyzerGroupResults");
            }
            //      C# -> List<AnalyzerResult>? AnalyzerResults
            // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
            if (this.AnalyzerResults == null && Exploration.Includes(parent + ".analyzerResults"))
            {
                this.AnalyzerResults = new List<AnalyzerResult>();
                this.AnalyzerResults.ApplyExploratoryFragment(parent + ".analyzerResults");
            }
            //      C# -> Hits? FilesWithHits
            // GraphQL -> filesWithHits: Hits (type)
            if (this.FilesWithHits == null && Exploration.Includes(parent + ".filesWithHits"))
            {
                this.FilesWithHits = new Hits();
                this.FilesWithHits.ApplyExploratoryFragment(parent + ".filesWithHits");
            }
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits! (type)
            if (this.Hits == null && Exploration.Includes(parent + ".hits"))
            {
                this.Hits = new Hits();
                this.Hits.ApplyExploratoryFragment(parent + ".hits");
            }
            //      C# -> List<ActivityResult>? NumActivitiesBreakdown
            // GraphQL -> numActivitiesBreakdown: [ActivityResult!]! (type)
            if (this.NumActivitiesBreakdown == null && Exploration.Includes(parent + ".numActivitiesBreakdown"))
            {
                this.NumActivitiesBreakdown = new List<ActivityResult>();
                this.NumActivitiesBreakdown.ApplyExploratoryFragment(parent + ".numActivitiesBreakdown");
            }
            //      C# -> Hits? OpenAccessFiles
            // GraphQL -> openAccessFiles: Hits (type)
            if (this.OpenAccessFiles == null && Exploration.Includes(parent + ".openAccessFiles"))
            {
                this.OpenAccessFiles = new Hits();
                this.OpenAccessFiles.ApplyExploratoryFragment(parent + ".openAccessFiles");
            }
            //      C# -> Hits? OpenAccessFilesWithHits
            // GraphQL -> openAccessFilesWithHits: Hits (type)
            if (this.OpenAccessFilesWithHits == null && Exploration.Includes(parent + ".openAccessFilesWithHits"))
            {
                this.OpenAccessFilesWithHits = new Hits();
                this.OpenAccessFilesWithHits.ApplyExploratoryFragment(parent + ".openAccessFilesWithHits");
            }
            //      C# -> Hits? OpenAccessFolders
            // GraphQL -> openAccessFolders: Hits (type)
            if (this.OpenAccessFolders == null && Exploration.Includes(parent + ".openAccessFolders"))
            {
                this.OpenAccessFolders = new Hits();
                this.OpenAccessFolders.ApplyExploratoryFragment(parent + ".openAccessFolders");
            }
            //      C# -> Hits? OpenAccessStaleFiles
            // GraphQL -> openAccessStaleFiles: Hits (type)
            if (this.OpenAccessStaleFiles == null && Exploration.Includes(parent + ".openAccessStaleFiles"))
            {
                this.OpenAccessStaleFiles = new Hits();
                this.OpenAccessStaleFiles.ApplyExploratoryFragment(parent + ".openAccessStaleFiles");
            }
            //      C# -> Hits? StaleFiles
            // GraphQL -> staleFiles: Hits (type)
            if (this.StaleFiles == null && Exploration.Includes(parent + ".staleFiles"))
            {
                this.StaleFiles = new Hits();
                this.StaleFiles.ApplyExploratoryFragment(parent + ".staleFiles");
            }
            //      C# -> Hits? StaleFilesWithHits
            // GraphQL -> staleFilesWithHits: Hits (type)
            if (this.StaleFilesWithHits == null && Exploration.Includes(parent + ".staleFilesWithHits"))
            {
                this.StaleFilesWithHits = new Hits();
                this.StaleFilesWithHits.ApplyExploratoryFragment(parent + ".staleFilesWithHits");
            }
            //      C# -> AnalyzerErrorCode? ErrorCode
            // GraphQL -> errorCode: AnalyzerErrorCode! (enum)
            if (this.ErrorCode == null && Exploration.Includes(parent + ".errorCode$"))
            {
                this.ErrorCode = new AnalyzerErrorCode();
            }
            //      C# -> DataGovFileMode? Mode
            // GraphQL -> mode: DataGovFileMode! (enum)
            if (this.Mode == null && Exploration.Includes(parent + ".mode$"))
            {
                this.Mode = new DataGovFileMode();
            }
            //      C# -> OpenAccessType? OpenAccessType
            // GraphQL -> openAccessType: OpenAccessType! (enum)
            if (this.OpenAccessType == null && Exploration.Includes(parent + ".openAccessType$"))
            {
                this.OpenAccessType = new OpenAccessType();
            }
            //      C# -> StalenessType? StalenessType
            // GraphQL -> stalenessType: StalenessType! (enum)
            if (this.StalenessType == null && Exploration.Includes(parent + ".stalenessType$"))
            {
                this.StalenessType = new StalenessType();
            }
            //      C# -> UserAccessType? UserAccessType
            // GraphQL -> userAccessType: UserAccessType! (enum)
            if (this.UserAccessType == null && Exploration.Includes(parent + ".userAccessType$"))
            {
                this.UserAccessType = new UserAccessType();
            }
            //      C# -> HierarchyObject? Snappable
            // GraphQL -> snappable: HierarchyObject! (interface)
            if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
            {
                this.Snappable = (HierarchyObject)InterfaceHelper.CreateInstanceOfFirstType(typeof(HierarchyObject));
                this.Snappable.ApplyExploratoryFragment(parent + ".snappable");
            }
        }


    #endregion

    } // class FileResult
    #endregion

    public static class ListFileResultExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<FileResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FileResult> list, 
            String parent = "")
        {
            var item = new FileResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types