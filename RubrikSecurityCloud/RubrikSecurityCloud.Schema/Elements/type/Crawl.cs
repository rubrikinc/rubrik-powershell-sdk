// Crawl.cs
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
    #region Crawl
    public class Crawl: BaseType
    {
        #region members

        //      C# -> CrawlStatusEnum? Status
        // GraphQL -> status: CrawlStatusEnum! (enum)
        [JsonProperty("status")]
        public CrawlStatusEnum? Status { get; set; }

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

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars CrawlObj { get; set; }

        public RscGqlVars FileResultConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] crawlObjArgs = {
                    Tuple.Create("snappableFid", "String!"),
                };
            this.CrawlObj =
                new RscGqlVars(null, crawlObjArgs, null, true);
            Tuple<string, string>[] fileResultConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "ListFileResultFiltersInput"),
                    Tuple.Create("sort", "FileResultSortInput"),
                };
            this.FileResultConnection =
                new RscGqlVars(null, fileResultConnectionArgs, null, true);
        }
    }

    public Crawl()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "Crawl";
    }

    public Crawl Set(
        CrawlStatusEnum? Status = null,
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
        User? User = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
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
        //      C# -> CrawlStatusEnum? Status
        // GraphQL -> status: CrawlStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
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
        //      C# -> System.Int32? FailedObjectCount
        // GraphQL -> failedObjectCount: Int! (scalar)
        if (this.FailedObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedObjectCount\n" ;
            } else {
                s += ind + "failedObjectCount\n" ;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        //      C# -> CrawlObj? CrawlObj
        // GraphQL -> crawlObj: CrawlObj! (type)
        if (this.CrawlObj != null) {
            var fspec = this.CrawlObj.AsFieldSpec(conf.Child("crawlObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crawlObj" + "\n(" + this.Vars.CrawlObj.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CrawlObjConnection? CrawlObjConnection
        // GraphQL -> crawlObjConnection: CrawlObjConnection! (type)
        if (this.CrawlObjConnection != null) {
            var fspec = this.CrawlObjConnection.AsFieldSpec(conf.Child("crawlObjConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crawlObjConnection" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        if (this.FileResultConnection != null) {
            var fspec = this.FileResultConnection.AsFieldSpec(conf.Child("fileResultConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileResultConnection" + "\n(" + this.Vars.FileResultConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SnappableTypeSummary>? SnappableTypeSummaries
        // GraphQL -> snappableTypeSummaries: [SnappableTypeSummary!]! (type)
        if (this.SnappableTypeSummaries != null) {
            var fspec = this.SnappableTypeSummaries.AsFieldSpec(conf.Child("snappableTypeSummaries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappableTypeSummaries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> User? User
        // GraphQL -> user: User (type)
        if (this.User != null) {
            var fspec = this.User.AsFieldSpec(conf.Child("user"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "user" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CrawlStatusEnum? Status
        // GraphQL -> status: CrawlStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new CrawlStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
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
        //      C# -> System.Int32? FailedObjectCount
        // GraphQL -> failedObjectCount: Int! (scalar)
        if (ec.Includes("failedObjectCount",true))
        {
            if(this.FailedObjectCount == null) {

                this.FailedObjectCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.FailedObjectCount != null && ec.Excludes("failedObjectCount",true))
        {
            this.FailedObjectCount = null;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
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
        //      C# -> CrawlObj? CrawlObj
        // GraphQL -> crawlObj: CrawlObj! (type)
        if (ec.Includes("crawlObj",false))
        {
            if(this.CrawlObj == null) {

                this.CrawlObj = new CrawlObj();
                this.CrawlObj.ApplyExploratoryFieldSpec(ec.NewChild("crawlObj"));

            } else {

                this.CrawlObj.ApplyExploratoryFieldSpec(ec.NewChild("crawlObj"));

            }
        }
        else if (this.CrawlObj != null && ec.Excludes("crawlObj",false))
        {
            this.CrawlObj = null;
        }
        //      C# -> CrawlObjConnection? CrawlObjConnection
        // GraphQL -> crawlObjConnection: CrawlObjConnection! (type)
        if (ec.Includes("crawlObjConnection",false))
        {
            if(this.CrawlObjConnection == null) {

                this.CrawlObjConnection = new CrawlObjConnection();
                this.CrawlObjConnection.ApplyExploratoryFieldSpec(ec.NewChild("crawlObjConnection"));

            } else {

                this.CrawlObjConnection.ApplyExploratoryFieldSpec(ec.NewChild("crawlObjConnection"));

            }
        }
        else if (this.CrawlObjConnection != null && ec.Excludes("crawlObjConnection",false))
        {
            this.CrawlObjConnection = null;
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
        //      C# -> List<SnappableTypeSummary>? SnappableTypeSummaries
        // GraphQL -> snappableTypeSummaries: [SnappableTypeSummary!]! (type)
        if (ec.Includes("snappableTypeSummaries",false))
        {
            if(this.SnappableTypeSummaries == null) {

                this.SnappableTypeSummaries = new List<SnappableTypeSummary>();
                this.SnappableTypeSummaries.ApplyExploratoryFieldSpec(ec.NewChild("snappableTypeSummaries"));

            } else {

                this.SnappableTypeSummaries.ApplyExploratoryFieldSpec(ec.NewChild("snappableTypeSummaries"));

            }
        }
        else if (this.SnappableTypeSummaries != null && ec.Excludes("snappableTypeSummaries",false))
        {
            this.SnappableTypeSummaries = null;
        }
        //      C# -> User? User
        // GraphQL -> user: User (type)
        if (ec.Includes("user",false))
        {
            if(this.User == null) {

                this.User = new User();
                this.User.ApplyExploratoryFieldSpec(ec.NewChild("user"));

            } else {

                this.User.ApplyExploratoryFieldSpec(ec.NewChild("user"));

            }
        }
        else if (this.User != null && ec.Excludes("user",false))
        {
            this.User = null;
        }
    }


    #endregion

    } // class Crawl
    
    #endregion

    public static class ListCrawlExtensions
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
            this List<Crawl> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Crawl> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Crawl> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Crawl());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Crawl> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types