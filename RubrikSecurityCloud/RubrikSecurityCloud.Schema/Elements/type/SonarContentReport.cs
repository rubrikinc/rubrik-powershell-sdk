// SonarContentReport.cs
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
    #region SonarContentReport
    public class SonarContentReport: BaseType
    {
        #region members

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        [JsonProperty("analyzerId")]
        public System.String? AnalyzerId { get; set; }

        //      C# -> System.String? Cluster
        // GraphQL -> cluster: String! (scalar)
        [JsonProperty("cluster")]
        public System.String? Cluster { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> System.Int32? FilesWithHits
        // GraphQL -> filesWithHits: Int! (scalar)
        [JsonProperty("filesWithHits")]
        public System.Int32? FilesWithHits { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        [JsonProperty("snappableFid")]
        public System.String? SnappableFid { get; set; }

        //      C# -> System.Int64? SnapshotTimestamp
        // GraphQL -> snapshotTimestamp: Long! (scalar)
        [JsonProperty("snapshotTimestamp")]
        public System.Int64? SnapshotTimestamp { get; set; }

        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        [JsonProperty("analyzerGroupResults")]
        public List<AnalyzerGroupResult>? AnalyzerGroupResults { get; set; }

        //      C# -> List<AnalyzerResult>? AnalyzerResults
        // GraphQL -> analyzerResults: [AnalyzerResult!]! (type)
        [JsonProperty("analyzerResults")]
        public List<AnalyzerResult>? AnalyzerResults { get; set; }

        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits (type)
        [JsonProperty("hits")]
        public Hits? Hits { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SonarContentReport";
    }

    public SonarContentReport Set(
        HierarchyObjectTypeEnum? ObjectType = null,
        System.String? AnalyzerId = null,
        System.String? Cluster = null,
        System.String? FileName = null,
        System.Int32? FilesWithHits = null,
        System.String? Id = null,
        System.String? Location = null,
        System.String? ObjectName = null,
        System.String? Path = null,
        System.String? PolicyId = null,
        System.Int64? Size = null,
        System.String? SlaDomainId = null,
        System.String? SnappableFid = null,
        System.Int64? SnapshotTimestamp = null,
        List<AnalyzerGroupResult>? AnalyzerGroupResults = null,
        List<AnalyzerResult>? AnalyzerResults = null,
        Hits? Hits = null,
        List<PathNode>? LogicalPath = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( AnalyzerId != null ) {
            this.AnalyzerId = AnalyzerId;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( FileName != null ) {
            this.FileName = FileName;
        }
        if ( FilesWithHits != null ) {
            this.FilesWithHits = FilesWithHits;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SlaDomainId != null ) {
            this.SlaDomainId = SlaDomainId;
        }
        if ( SnappableFid != null ) {
            this.SnappableFid = SnappableFid;
        }
        if ( SnapshotTimestamp != null ) {
            this.SnapshotTimestamp = SnapshotTimestamp;
        }
        if ( AnalyzerGroupResults != null ) {
            this.AnalyzerGroupResults = AnalyzerGroupResults;
        }
        if ( AnalyzerResults != null ) {
            this.AnalyzerResults = AnalyzerResults;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
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
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (this.AnalyzerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzerId\n" ;
            } else {
                s += ind + "analyzerId\n" ;
            }
        }
        //      C# -> System.String? Cluster
        // GraphQL -> cluster: String! (scalar)
        if (this.Cluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cluster\n" ;
            } else {
                s += ind + "cluster\n" ;
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
        //      C# -> System.Int32? FilesWithHits
        // GraphQL -> filesWithHits: Int! (scalar)
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
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
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
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
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
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainId\n" ;
            } else {
                s += ind + "slaDomainId\n" ;
            }
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (this.SnappableFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableFid\n" ;
            } else {
                s += ind + "snappableFid\n" ;
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
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (this.AnalyzerGroupResults != null) {
            var fspec = this.AnalyzerGroupResults.AsFieldSpec(conf.Child("analyzerGroupResults"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
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
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits (type)
        if (this.Hits != null) {
            var fspec = this.Hits.AsFieldSpec(conf.Child("hits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(conf.Child("logicalPath"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
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
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (ec.Includes("analyzerId",true))
        {
            if(this.AnalyzerId == null) {

                this.AnalyzerId = "FETCH";

            } else {


            }
        }
        else if (this.AnalyzerId != null && ec.Excludes("analyzerId",true))
        {
            this.AnalyzerId = null;
        }
        //      C# -> System.String? Cluster
        // GraphQL -> cluster: String! (scalar)
        if (ec.Includes("cluster",true))
        {
            if(this.Cluster == null) {

                this.Cluster = "FETCH";

            } else {


            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",true))
        {
            this.Cluster = null;
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
        //      C# -> System.Int32? FilesWithHits
        // GraphQL -> filesWithHits: Int! (scalar)
        if (ec.Includes("filesWithHits",true))
        {
            if(this.FilesWithHits == null) {

                this.FilesWithHits = Int32.MinValue;

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
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
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
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
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
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (ec.Includes("slaDomainId",true))
        {
            if(this.SlaDomainId == null) {

                this.SlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomainId != null && ec.Excludes("slaDomainId",true))
        {
            this.SlaDomainId = null;
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (ec.Includes("snappableFid",true))
        {
            if(this.SnappableFid == null) {

                this.SnappableFid = "FETCH";

            } else {


            }
        }
        else if (this.SnappableFid != null && ec.Excludes("snappableFid",true))
        {
            this.SnappableFid = null;
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
        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits (type)
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
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (ec.Includes("logicalPath",false))
        {
            if(this.LogicalPath == null) {

                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            } else {

                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            }
        }
        else if (this.LogicalPath != null && ec.Excludes("logicalPath",false))
        {
            this.LogicalPath = null;
        }
    }


    #endregion

    } // class SonarContentReport
    
    #endregion

    public static class ListSonarContentReportExtensions
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
            this List<SonarContentReport> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SonarContentReport> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SonarContentReport> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SonarContentReport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SonarContentReport> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types