// Crawl.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:28.
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
    #region Crawl
    public class Crawl: IFragment
    {
        #region members
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? FailedObjectCount
        // GraphQL -> failedObjectCount: Int! (scalar)
        [JsonProperty("failedObjectCount")]
        public System.Int32? FailedObjectCount { get; set; }

        //      C# -> System.Int64? FilesAnalyzeable
        // GraphQL -> filesAnalyzeable: Long! (scalar)
        [JsonProperty("filesAnalyzeable")]
        public System.Int64? FilesAnalyzeable { get; set; }

        //      C# -> System.Int64? FilesAnalyzed
        // GraphQL -> filesAnalyzed: Long! (scalar)
        [JsonProperty("filesAnalyzed")]
        public System.Int64? FilesAnalyzed { get; set; }

        //      C# -> System.Int64? FilesTotal
        // GraphQL -> filesTotal: Long! (scalar)
        [JsonProperty("filesTotal")]
        public System.Int64? FilesTotal { get; set; }

        //      C# -> System.Int64? FilesWithHits
        // GraphQL -> filesWithHits: Long! (scalar)
        [JsonProperty("filesWithHits")]
        public System.Int64? FilesWithHits { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        [JsonProperty("totalHits")]
        public System.Int32? TotalHits { get; set; }

        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        [JsonProperty("analyzerGroupResults")]
        public List<AnalyzerGroupResult>? AnalyzerGroupResults { get; set; }

        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        [JsonProperty("analyzerResults")]
        public List<AnalyzerResult>? AnalyzerResults { get; set; }

        //      C# -> CrawlObj? CrawlObj
        // GraphQL -> crawlObj: CrawlObj! (type)
        [JsonProperty("crawlObj")]
        public CrawlObj? CrawlObj { get; set; }

        //      C# -> CrawlObjConnection? CrawlObjConnection
        // GraphQL -> crawlObjConnection: CrawlObjConnection! (type)
        [JsonProperty("crawlObjConnection")]
        public CrawlObjConnection? CrawlObjConnection { get; set; }

        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        [JsonProperty("fileResultConnection")]
        public FileResultConnection? FileResultConnection { get; set; }

        //      C# -> List<SnappableTypeSummary>? SnappableTypeSummaries
        // GraphQL -> snappableTypeSummaries: [SnappableTypeSummary!]! (type)
        [JsonProperty("snappableTypeSummaries")]
        public List<SnappableTypeSummary>? SnappableTypeSummaries { get; set; }

        //      C# -> User? User
        // GraphQL -> user: User (type)
        [JsonProperty("user")]
        public User? User { get; set; }

        //      C# -> CrawlStatusEnum? Status
        // GraphQL -> status: CrawlStatusEnum! (enum)
        [JsonProperty("status")]
        public CrawlStatusEnum? Status { get; set; }

        #endregion

    #region methods

    public Crawl Set(
        System.Int64? EndTime = null,
        System.Int32? FailedObjectCount = null,
        System.Int64? FilesAnalyzeable = null,
        System.Int64? FilesAnalyzed = null,
        System.Int64? FilesTotal = null,
        System.Int64? FilesWithHits = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Single? Progress = null,
        System.Int64? StartTime = null,
        System.Int32? TotalHits = null,
        List<AnalyzerGroupResult>? AnalyzerGroupResults = null,
        List<AnalyzerResult>? AnalyzerResults = null,
        CrawlObj? CrawlObj = null,
        CrawlObjConnection? CrawlObjConnection = null,
        FileResultConnection? FileResultConnection = null,
        List<SnappableTypeSummary>? SnappableTypeSummaries = null,
        User? User = null,
        CrawlStatusEnum? Status = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( FailedObjectCount != null ) {
            this.FailedObjectCount = FailedObjectCount;
        }
        if ( FilesAnalyzeable != null ) {
            this.FilesAnalyzeable = FilesAnalyzeable;
        }
        if ( FilesAnalyzed != null ) {
            this.FilesAnalyzed = FilesAnalyzed;
        }
        if ( FilesTotal != null ) {
            this.FilesTotal = FilesTotal;
        }
        if ( FilesWithHits != null ) {
            this.FilesWithHits = FilesWithHits;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
        }
        if ( AnalyzerGroupResults != null ) {
            this.AnalyzerGroupResults = AnalyzerGroupResults;
        }
        if ( AnalyzerResults != null ) {
            this.AnalyzerResults = AnalyzerResults;
        }
        if ( CrawlObj != null ) {
            this.CrawlObj = CrawlObj;
        }
        if ( CrawlObjConnection != null ) {
            this.CrawlObjConnection = CrawlObjConnection;
        }
        if ( FileResultConnection != null ) {
            this.FileResultConnection = FileResultConnection;
        }
        if ( SnappableTypeSummaries != null ) {
            this.SnappableTypeSummaries = SnappableTypeSummaries;
        }
        if ( User != null ) {
            this.User = User;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.Int32? FailedObjectCount
            // GraphQL -> failedObjectCount: Int! (scalar)
            if (this.FailedObjectCount != null)
            {
                 s += ind + "failedObjectCount\n";

            }
            //      C# -> System.Int64? FilesAnalyzeable
            // GraphQL -> filesAnalyzeable: Long! (scalar)
            if (this.FilesAnalyzeable != null)
            {
                 s += ind + "filesAnalyzeable\n";

            }
            //      C# -> System.Int64? FilesAnalyzed
            // GraphQL -> filesAnalyzed: Long! (scalar)
            if (this.FilesAnalyzed != null)
            {
                 s += ind + "filesAnalyzed\n";

            }
            //      C# -> System.Int64? FilesTotal
            // GraphQL -> filesTotal: Long! (scalar)
            if (this.FilesTotal != null)
            {
                 s += ind + "filesTotal\n";

            }
            //      C# -> System.Int64? FilesWithHits
            // GraphQL -> filesWithHits: Long! (scalar)
            if (this.FilesWithHits != null)
            {
                 s += ind + "filesWithHits\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> System.Int64? StartTime
            // GraphQL -> startTime: Long! (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> System.Int32? TotalHits
            // GraphQL -> totalHits: Int! (scalar)
            if (this.TotalHits != null)
            {
                 s += ind + "totalHits\n";

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
            //      C# -> CrawlObj? CrawlObj
            // GraphQL -> crawlObj: CrawlObj! (type)
            if (this.CrawlObj != null)
            {
                 s += ind + "crawlObj\n";

                 s += ind + "{\n" + 
                 this.CrawlObj.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CrawlObjConnection? CrawlObjConnection
            // GraphQL -> crawlObjConnection: CrawlObjConnection! (type)
            if (this.CrawlObjConnection != null)
            {
                 s += ind + "crawlObjConnection\n";

                 s += ind + "{\n" + 
                 this.CrawlObjConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FileResultConnection? FileResultConnection
            // GraphQL -> fileResultConnection: FileResultConnection! (type)
            if (this.FileResultConnection != null)
            {
                 s += ind + "fileResultConnection\n";

                 s += ind + "{\n" + 
                 this.FileResultConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnappableTypeSummary>? SnappableTypeSummaries
            // GraphQL -> snappableTypeSummaries: [SnappableTypeSummary!]! (type)
            if (this.SnappableTypeSummaries != null)
            {
                 s += ind + "snappableTypeSummaries\n";

                 s += ind + "{\n" + 
                 this.SnappableTypeSummaries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> User? User
            // GraphQL -> user: User (type)
            if (this.User != null)
            {
                 s += ind + "user\n";

                 s += ind + "{\n" + 
                 this.User.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CrawlStatusEnum? Status
            // GraphQL -> status: CrawlStatusEnum! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new System.Int64();
            }
            //      C# -> System.Int32? FailedObjectCount
            // GraphQL -> failedObjectCount: Int! (scalar)
            if (this.FailedObjectCount == null && Exploration.Includes(parent + ".failedObjectCount$"))
            {
                this.FailedObjectCount = new System.Int32();
            }
            //      C# -> System.Int64? FilesAnalyzeable
            // GraphQL -> filesAnalyzeable: Long! (scalar)
            if (this.FilesAnalyzeable == null && Exploration.Includes(parent + ".filesAnalyzeable$"))
            {
                this.FilesAnalyzeable = new System.Int64();
            }
            //      C# -> System.Int64? FilesAnalyzed
            // GraphQL -> filesAnalyzed: Long! (scalar)
            if (this.FilesAnalyzed == null && Exploration.Includes(parent + ".filesAnalyzed$"))
            {
                this.FilesAnalyzed = new System.Int64();
            }
            //      C# -> System.Int64? FilesTotal
            // GraphQL -> filesTotal: Long! (scalar)
            if (this.FilesTotal == null && Exploration.Includes(parent + ".filesTotal$"))
            {
                this.FilesTotal = new System.Int64();
            }
            //      C# -> System.Int64? FilesWithHits
            // GraphQL -> filesWithHits: Long! (scalar)
            if (this.FilesWithHits == null && Exploration.Includes(parent + ".filesWithHits$"))
            {
                this.FilesWithHits = new System.Int64();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.Single();
            }
            //      C# -> System.Int64? StartTime
            // GraphQL -> startTime: Long! (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new System.Int64();
            }
            //      C# -> System.Int32? TotalHits
            // GraphQL -> totalHits: Int! (scalar)
            if (this.TotalHits == null && Exploration.Includes(parent + ".totalHits$"))
            {
                this.TotalHits = new System.Int32();
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
            //      C# -> CrawlObj? CrawlObj
            // GraphQL -> crawlObj: CrawlObj! (type)
            if (this.CrawlObj == null && Exploration.Includes(parent + ".crawlObj"))
            {
                this.CrawlObj = new CrawlObj();
                this.CrawlObj.ApplyExploratoryFragment(parent + ".crawlObj");
            }
            //      C# -> CrawlObjConnection? CrawlObjConnection
            // GraphQL -> crawlObjConnection: CrawlObjConnection! (type)
            if (this.CrawlObjConnection == null && Exploration.Includes(parent + ".crawlObjConnection"))
            {
                this.CrawlObjConnection = new CrawlObjConnection();
                this.CrawlObjConnection.ApplyExploratoryFragment(parent + ".crawlObjConnection");
            }
            //      C# -> FileResultConnection? FileResultConnection
            // GraphQL -> fileResultConnection: FileResultConnection! (type)
            if (this.FileResultConnection == null && Exploration.Includes(parent + ".fileResultConnection"))
            {
                this.FileResultConnection = new FileResultConnection();
                this.FileResultConnection.ApplyExploratoryFragment(parent + ".fileResultConnection");
            }
            //      C# -> List<SnappableTypeSummary>? SnappableTypeSummaries
            // GraphQL -> snappableTypeSummaries: [SnappableTypeSummary!]! (type)
            if (this.SnappableTypeSummaries == null && Exploration.Includes(parent + ".snappableTypeSummaries"))
            {
                this.SnappableTypeSummaries = new List<SnappableTypeSummary>();
                this.SnappableTypeSummaries.ApplyExploratoryFragment(parent + ".snappableTypeSummaries");
            }
            //      C# -> User? User
            // GraphQL -> user: User (type)
            if (this.User == null && Exploration.Includes(parent + ".user"))
            {
                this.User = new User();
                this.User.ApplyExploratoryFragment(parent + ".user");
            }
            //      C# -> CrawlStatusEnum? Status
            // GraphQL -> status: CrawlStatusEnum! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new CrawlStatusEnum();
            }
        }


    #endregion

    } // class Crawl
    #endregion

    public static class ListCrawlExtensions
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
            this List<Crawl> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Crawl> list, 
            String parent = "")
        {
            var item = new Crawl();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types