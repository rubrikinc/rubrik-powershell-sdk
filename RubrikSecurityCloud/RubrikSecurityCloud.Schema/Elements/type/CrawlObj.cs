// CrawlObj.cs
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
    #region CrawlObj
    public class CrawlObj: BaseType
    {
        #region members

        //      C# -> SnappableCrawlStatus? Status
        // GraphQL -> status: SnappableCrawlStatus! (enum)
        [JsonProperty("status")]
        public SnappableCrawlStatus? Status { get; set; }

        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        [JsonProperty("snappable")]
        public RscInterface<HierarchyObject> Snappable { get; set; }

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

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars FileResultConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] fileResultConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "BrowseDirectoryFiltersInput"),
                    Tuple.Create("sort", "FileResultSortInput"),
                    Tuple.Create("stdPath", "String!"),
                };
            this.FileResultConnection =
                new RscGqlVars(null, fileResultConnectionArgs, null, true);
        }
    }

    public CrawlObj()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "CrawlObj";
    }

    public CrawlObj Set(
        SnappableCrawlStatus? Status = null,
        RscInterface<HierarchyObject> Snappable = null,
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
        FileResultConnection? FileResultConnection = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
        }
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
        //      C# -> SnappableCrawlStatus? Status
        // GraphQL -> status: SnappableCrawlStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? CrawlId
        // GraphQL -> crawlId: String! (scalar)
        if (this.CrawlId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "crawlId\n" ;
            } else {
                s += ind + "crawlId\n" ;
            }
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.Int64? FilesAnalyzeable
        // GraphQL -> filesAnalyzeable: Long! (scalar)
        if (this.FilesAnalyzeable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesAnalyzeable\n" ;
            } else {
                s += ind + "filesAnalyzeable\n" ;
            }
        }
        //      C# -> System.Int64? FilesAnalyzed
        // GraphQL -> filesAnalyzed: Long! (scalar)
        if (this.FilesAnalyzed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesAnalyzed\n" ;
            } else {
                s += ind + "filesAnalyzed\n" ;
            }
        }
        //      C# -> System.Int64? FilesTotal
        // GraphQL -> filesTotal: Long! (scalar)
        if (this.FilesTotal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesTotal\n" ;
            } else {
                s += ind + "filesTotal\n" ;
            }
        }
        //      C# -> System.Int64? FilesWithHits
        // GraphQL -> filesWithHits: Long! (scalar)
        if (this.FilesWithHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesWithHits\n" ;
            } else {
                s += ind + "filesWithHits\n" ;
            }
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
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
        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long! (scalar)
        if (this.SnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotTime\n" ;
            } else {
                s += ind + "snapshotTime\n" ;
            }
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        if (this.TotalHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHits\n" ;
            } else {
                s += ind + "totalHits\n" ;
            }
        }
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (this.AnalyzerGroupResults != null) {
            var fspec = this.AnalyzerGroupResults.AsFieldSpec(conf.Child("analyzerGroupResults"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        if (this.FileResultConnection != null) {
            var fspec = this.FileResultConnection.AsFieldSpec(conf.Child("fileResultConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileResultConnection" + "\n(" + this.Vars.FileResultConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnappableCrawlStatus? Status
        // GraphQL -> status: SnappableCrawlStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new SnappableCrawlStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                this.Snappable = new RscInterface<HierarchyObject>();
                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            } else {

                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
        //      C# -> System.String? CrawlId
        // GraphQL -> crawlId: String! (scalar)
        if (ec.Includes("crawlId",true))
        {
            if(this.CrawlId == null) {

                this.CrawlId = "FETCH";

            } else {


            }
        }
        else if (this.CrawlId != null && ec.Excludes("crawlId",true))
        {
            this.CrawlId = null;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new System.Int64();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.Int64? FilesAnalyzeable
        // GraphQL -> filesAnalyzeable: Long! (scalar)
        if (ec.Includes("filesAnalyzeable",true))
        {
            if(this.FilesAnalyzeable == null) {

                this.FilesAnalyzeable = new System.Int64();

            } else {


            }
        }
        else if (this.FilesAnalyzeable != null && ec.Excludes("filesAnalyzeable",true))
        {
            this.FilesAnalyzeable = null;
        }
        //      C# -> System.Int64? FilesAnalyzed
        // GraphQL -> filesAnalyzed: Long! (scalar)
        if (ec.Includes("filesAnalyzed",true))
        {
            if(this.FilesAnalyzed == null) {

                this.FilesAnalyzed = new System.Int64();

            } else {


            }
        }
        else if (this.FilesAnalyzed != null && ec.Excludes("filesAnalyzed",true))
        {
            this.FilesAnalyzed = null;
        }
        //      C# -> System.Int64? FilesTotal
        // GraphQL -> filesTotal: Long! (scalar)
        if (ec.Includes("filesTotal",true))
        {
            if(this.FilesTotal == null) {

                this.FilesTotal = new System.Int64();

            } else {


            }
        }
        else if (this.FilesTotal != null && ec.Excludes("filesTotal",true))
        {
            this.FilesTotal = null;
        }
        //      C# -> System.Int64? FilesWithHits
        // GraphQL -> filesWithHits: Long! (scalar)
        if (ec.Includes("filesWithHits",true))
        {
            if(this.FilesWithHits == null) {

                this.FilesWithHits = new System.Int64();

            } else {


            }
        }
        else if (this.FilesWithHits != null && ec.Excludes("filesWithHits",true))
        {
            this.FilesWithHits = null;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Single();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
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
        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long! (scalar)
        if (ec.Includes("snapshotTime",true))
        {
            if(this.SnapshotTime == null) {

                this.SnapshotTime = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotTime != null && ec.Excludes("snapshotTime",true))
        {
            this.SnapshotTime = null;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new System.Int64();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        if (ec.Includes("totalHits",true))
        {
            if(this.TotalHits == null) {

                this.TotalHits = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalHits != null && ec.Excludes("totalHits",true))
        {
            this.TotalHits = null;
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        if (ec.Includes("fileResultConnection",false))
        {
            if(this.FileResultConnection == null) {

                this.FileResultConnection = new FileResultConnection();
                this.FileResultConnection.ApplyExploratoryFieldSpec(ec.NewChild("fileResultConnection"));

            } else {

                this.FileResultConnection.ApplyExploratoryFieldSpec(ec.NewChild("fileResultConnection"));

            }
        }
        else if (this.FileResultConnection != null && ec.Excludes("fileResultConnection",false))
        {
            this.FileResultConnection = null;
        }
    }


    #endregion

    } // class CrawlObj
    
    #endregion

    public static class ListCrawlObjExtensions
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
            this List<CrawlObj> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CrawlObj> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CrawlObj> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CrawlObj());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CrawlObj> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types