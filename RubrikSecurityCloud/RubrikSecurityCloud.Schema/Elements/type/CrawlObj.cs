// CrawlObj.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    #region CrawlObj
    public class CrawlObj: IFragment
    {
        #region members
        //      C# -> System.String? CrawlId
        // GraphQL -> crawlId: String! (scalar)
        [JsonProperty("crawlId")]
        public System.String? CrawlId { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

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

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long! (scalar)
        [JsonProperty("snapshotTime")]
        public System.Int64? SnapshotTime { get; set; }

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

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        [JsonProperty("fileResultConnection")]
        public FileResultConnection? FileResultConnection { get; set; }

        //      C# -> SnappableCrawlStatus? Status
        // GraphQL -> status: SnappableCrawlStatus! (enum)
        [JsonProperty("status")]
        public SnappableCrawlStatus? Status { get; set; }

        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        [JsonProperty("snappable")]
        public HierarchyObject? Snappable { get; set; }

        #endregion

    #region methods

    public CrawlObj Set(
        System.String? CrawlId = null,
        System.Int64? EndTime = null,
        System.String? Error = null,
        System.Int64? FilesAnalyzeable = null,
        System.Int64? FilesAnalyzed = null,
        System.Int64? FilesTotal = null,
        System.Int64? FilesWithHits = null,
        System.Single? Progress = null,
        System.String? SnapshotFid = null,
        System.Int64? SnapshotTime = null,
        System.Int64? StartTime = null,
        System.Int32? TotalHits = null,
        List<AnalyzerGroupResult>? AnalyzerGroupResults = null,
        List<AnalyzerResult>? AnalyzerResults = null,
        Cluster? Cluster = null,
        FileResultConnection? FileResultConnection = null,
        SnappableCrawlStatus? Status = null,
        HierarchyObject? Snappable = null
    ) 
    {
        if ( CrawlId != null ) {
            this.CrawlId = CrawlId;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Error != null ) {
            this.Error = Error;
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
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( FileResultConnection != null ) {
            this.FileResultConnection = FileResultConnection;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? CrawlId
            // GraphQL -> crawlId: String! (scalar)
            if (this.CrawlId != null)
            {
                 s += ind + "crawlId\n";

            }
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error != null)
            {
                 s += ind + "error\n";

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
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid != null)
            {
                 s += ind + "snapshotFid\n";

            }
            //      C# -> System.Int64? SnapshotTime
            // GraphQL -> snapshotTime: Long! (scalar)
            if (this.SnapshotTime != null)
            {
                 s += ind + "snapshotTime\n";

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
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
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
            //      C# -> SnappableCrawlStatus? Status
            // GraphQL -> status: SnappableCrawlStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

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
            //      C# -> System.String? CrawlId
            // GraphQL -> crawlId: String! (scalar)
            if (this.CrawlId == null && Exploration.Includes(parent + ".crawlId$"))
            {
                this.CrawlId = new System.String("FETCH");
            }
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new System.Int64();
            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error == null && Exploration.Includes(parent + ".error$"))
            {
                this.Error = new System.String("FETCH");
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
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.Single();
            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid$"))
            {
                this.SnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.Int64? SnapshotTime
            // GraphQL -> snapshotTime: Long! (scalar)
            if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime$"))
            {
                this.SnapshotTime = new System.Int64();
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
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> FileResultConnection? FileResultConnection
            // GraphQL -> fileResultConnection: FileResultConnection! (type)
            if (this.FileResultConnection == null && Exploration.Includes(parent + ".fileResultConnection"))
            {
                this.FileResultConnection = new FileResultConnection();
                this.FileResultConnection.ApplyExploratoryFragment(parent + ".fileResultConnection");
            }
            //      C# -> SnappableCrawlStatus? Status
            // GraphQL -> status: SnappableCrawlStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new SnappableCrawlStatus();
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

    } // class CrawlObj
    #endregion

    public static class ListCrawlObjExtensions
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
            this List<CrawlObj> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CrawlObj> list, 
            String parent = "")
        {
            var item = new CrawlObj();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types