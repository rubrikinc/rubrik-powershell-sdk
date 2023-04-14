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

namespace Rubrik.SecurityCloud.Types
{
    #region SonarContentReport
    public class SonarContentReport: IFragment
    {
        #region members
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

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        #endregion

    #region methods

    public SonarContentReport Set(
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
        List<PathNode>? LogicalPath = null,
        HierarchyObjectTypeEnum? ObjectType = null
    ) 
    {
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
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
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
            //      C# -> System.String? AnalyzerId
            // GraphQL -> analyzerId: String! (scalar)
            if (this.AnalyzerId != null)
            {
                 s += ind + "analyzerId\n";

            }
            //      C# -> System.String? Cluster
            // GraphQL -> cluster: String! (scalar)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

            }
            //      C# -> System.String? FileName
            // GraphQL -> fileName: String! (scalar)
            if (this.FileName != null)
            {
                 s += ind + "fileName\n";

            }
            //      C# -> System.Int32? FilesWithHits
            // GraphQL -> filesWithHits: Int! (scalar)
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
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location != null)
            {
                 s += ind + "location\n";

            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String! (scalar)
            if (this.ObjectName != null)
            {
                 s += ind + "objectName\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId != null)
            {
                 s += ind + "policyId\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? SlaDomainId
            // GraphQL -> slaDomainId: String! (scalar)
            if (this.SlaDomainId != null)
            {
                 s += ind + "slaDomainId\n";

            }
            //      C# -> System.String? SnappableFid
            // GraphQL -> snappableFid: String! (scalar)
            if (this.SnappableFid != null)
            {
                 s += ind + "snappableFid\n";

            }
            //      C# -> System.Int64? SnapshotTimestamp
            // GraphQL -> snapshotTimestamp: Long! (scalar)
            if (this.SnapshotTimestamp != null)
            {
                 s += ind + "snapshotTimestamp\n";

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
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits (type)
            if (this.Hits != null)
            {
                 s += ind + "hits\n";

                 s += ind + "{\n" + 
                 this.Hits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath != null)
            {
                 s += ind + "logicalPath\n";

                 s += ind + "{\n" + 
                 this.LogicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AnalyzerId
            // GraphQL -> analyzerId: String! (scalar)
            if (this.AnalyzerId == null && Exploration.Includes(parent + ".analyzerId$"))
            {
                this.AnalyzerId = new System.String("FETCH");
            }
            //      C# -> System.String? Cluster
            // GraphQL -> cluster: String! (scalar)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster$"))
            {
                this.Cluster = new System.String("FETCH");
            }
            //      C# -> System.String? FileName
            // GraphQL -> fileName: String! (scalar)
            if (this.FileName == null && Exploration.Includes(parent + ".fileName$"))
            {
                this.FileName = new System.String("FETCH");
            }
            //      C# -> System.Int32? FilesWithHits
            // GraphQL -> filesWithHits: Int! (scalar)
            if (this.FilesWithHits == null && Exploration.Includes(parent + ".filesWithHits$"))
            {
                this.FilesWithHits = new System.Int32();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location == null && Exploration.Includes(parent + ".location$"))
            {
                this.Location = new System.String("FETCH");
            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String! (scalar)
            if (this.ObjectName == null && Exploration.Includes(parent + ".objectName$"))
            {
                this.ObjectName = new System.String("FETCH");
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId == null && Exploration.Includes(parent + ".policyId$"))
            {
                this.PolicyId = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? SlaDomainId
            // GraphQL -> slaDomainId: String! (scalar)
            if (this.SlaDomainId == null && Exploration.Includes(parent + ".slaDomainId$"))
            {
                this.SlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? SnappableFid
            // GraphQL -> snappableFid: String! (scalar)
            if (this.SnappableFid == null && Exploration.Includes(parent + ".snappableFid$"))
            {
                this.SnappableFid = new System.String("FETCH");
            }
            //      C# -> System.Int64? SnapshotTimestamp
            // GraphQL -> snapshotTimestamp: Long! (scalar)
            if (this.SnapshotTimestamp == null && Exploration.Includes(parent + ".snapshotTimestamp$"))
            {
                this.SnapshotTimestamp = new System.Int64();
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
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits (type)
            if (this.Hits == null && Exploration.Includes(parent + ".hits"))
            {
                this.Hits = new Hits();
                this.Hits.ApplyExploratoryFragment(parent + ".hits");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
        }


    #endregion

    } // class SonarContentReport
    #endregion

    public static class ListSonarContentReportExtensions
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
            this List<SonarContentReport> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SonarContentReport> list, 
            String parent = "")
        {
            var item = new SonarContentReport();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types