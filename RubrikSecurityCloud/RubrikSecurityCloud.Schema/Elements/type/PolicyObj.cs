// PolicyObj.cs
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
    #region PolicyObj
    public class PolicyObj: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? SnapshotTimestamp
        // GraphQL -> snapshotTimestamp: Long! (scalar)
        [JsonProperty("snapshotTimestamp")]
        public System.Int64? SnapshotTimestamp { get; set; }

        //      C# -> System.String? TimeContext
        // GraphQL -> timeContext: String! (scalar)
        [JsonProperty("timeContext")]
        public System.String? TimeContext { get; set; }

        //      C# -> List<AnalyzerMapping>? AllAnalyzerMappings
        // GraphQL -> allAnalyzerMappings: [AnalyzerMapping!]! (type)
        [JsonProperty("allAnalyzerMappings")]
        public List<AnalyzerMapping>? AllAnalyzerMappings { get; set; }

        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        [JsonProperty("fileResultConnection")]
        public FileResultConnection? FileResultConnection { get; set; }

        //      C# -> FileResultConnection? FolderChildConnection
        // GraphQL -> folderChildConnection: FileResultConnection! (type)
        [JsonProperty("folderChildConnection")]
        public FileResultConnection? FolderChildConnection { get; set; }

        //      C# -> ObjectStatus? ObjectStatus
        // GraphQL -> objectStatus: ObjectStatus! (type)
        [JsonProperty("objectStatus")]
        public ObjectStatus? ObjectStatus { get; set; }

        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        [JsonProperty("policySummaries")]
        public List<ClassificationPolicySummary>? PolicySummaries { get; set; }

        //      C# -> FileResult? RootFileResult
        // GraphQL -> rootFileResult: FileResult! (type)
        [JsonProperty("rootFileResult")]
        public FileResult? RootFileResult { get; set; }

        //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
        // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
        [JsonProperty("whitelistedAnalyzerList")]
        public List<WhitelistedAnalyzer>? WhitelistedAnalyzerList { get; set; }

        //      C# -> AnalysisStatus? AnalysisStatus
        // GraphQL -> analysisStatus: AnalysisStatus! (enum)
        [JsonProperty("analysisStatus")]
        public AnalysisStatus? AnalysisStatus { get; set; }

        //      C# -> DataGovOsType? OsType
        // GraphQL -> osType: DataGovOsType! (enum)
        [JsonProperty("osType")]
        public DataGovOsType? OsType { get; set; }

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> DataGovShareType? ShareType
        // GraphQL -> shareType: DataGovShareType! (enum)
        [JsonProperty("shareType")]
        public DataGovShareType? ShareType { get; set; }

        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject (interface)
        [JsonProperty("snappable")]
        public HierarchyObject? Snappable { get; set; }

        #endregion

    #region methods

    public PolicyObj Set(
        System.String? Id = null,
        System.String? SnapshotFid = null,
        System.Int64? SnapshotTimestamp = null,
        System.String? TimeContext = null,
        List<AnalyzerMapping>? AllAnalyzerMappings = null,
        FileResultConnection? FileResultConnection = null,
        FileResultConnection? FolderChildConnection = null,
        ObjectStatus? ObjectStatus = null,
        List<ClassificationPolicySummary>? PolicySummaries = null,
        FileResult? RootFileResult = null,
        List<WhitelistedAnalyzer>? WhitelistedAnalyzerList = null,
        AnalysisStatus? AnalysisStatus = null,
        DataGovOsType? OsType = null,
        RiskLevelType? RiskLevel = null,
        DataGovShareType? ShareType = null,
        HierarchyObject? Snappable = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotTimestamp != null ) {
            this.SnapshotTimestamp = SnapshotTimestamp;
        }
        if ( TimeContext != null ) {
            this.TimeContext = TimeContext;
        }
        if ( AllAnalyzerMappings != null ) {
            this.AllAnalyzerMappings = AllAnalyzerMappings;
        }
        if ( FileResultConnection != null ) {
            this.FileResultConnection = FileResultConnection;
        }
        if ( FolderChildConnection != null ) {
            this.FolderChildConnection = FolderChildConnection;
        }
        if ( ObjectStatus != null ) {
            this.ObjectStatus = ObjectStatus;
        }
        if ( PolicySummaries != null ) {
            this.PolicySummaries = PolicySummaries;
        }
        if ( RootFileResult != null ) {
            this.RootFileResult = RootFileResult;
        }
        if ( WhitelistedAnalyzerList != null ) {
            this.WhitelistedAnalyzerList = WhitelistedAnalyzerList;
        }
        if ( AnalysisStatus != null ) {
            this.AnalysisStatus = AnalysisStatus;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

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
            //      C# -> System.String? TimeContext
            // GraphQL -> timeContext: String! (scalar)
            if (this.TimeContext != null)
            {
                 s += ind + "timeContext\n";

            }
            //      C# -> List<AnalyzerMapping>? AllAnalyzerMappings
            // GraphQL -> allAnalyzerMappings: [AnalyzerMapping!]! (type)
            if (this.AllAnalyzerMappings != null)
            {
                 s += ind + "allAnalyzerMappings\n";

                 s += ind + "{\n" + 
                 this.AllAnalyzerMappings.AsFragment(indent+1) + 
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
            //      C# -> FileResultConnection? FolderChildConnection
            // GraphQL -> folderChildConnection: FileResultConnection! (type)
            if (this.FolderChildConnection != null)
            {
                 s += ind + "folderChildConnection\n";

                 s += ind + "{\n" + 
                 this.FolderChildConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ObjectStatus? ObjectStatus
            // GraphQL -> objectStatus: ObjectStatus! (type)
            if (this.ObjectStatus != null)
            {
                 s += ind + "objectStatus\n";

                 s += ind + "{\n" + 
                 this.ObjectStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClassificationPolicySummary>? PolicySummaries
            // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
            if (this.PolicySummaries != null)
            {
                 s += ind + "policySummaries\n";

                 s += ind + "{\n" + 
                 this.PolicySummaries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FileResult? RootFileResult
            // GraphQL -> rootFileResult: FileResult! (type)
            if (this.RootFileResult != null)
            {
                 s += ind + "rootFileResult\n";

                 s += ind + "{\n" + 
                 this.RootFileResult.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
            // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
            if (this.WhitelistedAnalyzerList != null)
            {
                 s += ind + "whitelistedAnalyzerList\n";

                 s += ind + "{\n" + 
                 this.WhitelistedAnalyzerList.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AnalysisStatus? AnalysisStatus
            // GraphQL -> analysisStatus: AnalysisStatus! (enum)
            if (this.AnalysisStatus != null)
            {
                 s += ind + "analysisStatus\n";

            }
            //      C# -> DataGovOsType? OsType
            // GraphQL -> osType: DataGovOsType! (enum)
            if (this.OsType != null)
            {
                 s += ind + "osType\n";

            }
            //      C# -> RiskLevelType? RiskLevel
            // GraphQL -> riskLevel: RiskLevelType! (enum)
            if (this.RiskLevel != null)
            {
                 s += ind + "riskLevel\n";

            }
            //      C# -> DataGovShareType? ShareType
            // GraphQL -> shareType: DataGovShareType! (enum)
            if (this.ShareType != null)
            {
                 s += ind + "shareType\n";

            }
                        //      C# -> HierarchyObject? Snappable
            // GraphQL -> snappable: HierarchyObject (interface)
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
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
            //      C# -> System.String? TimeContext
            // GraphQL -> timeContext: String! (scalar)
            if (this.TimeContext == null && Exploration.Includes(parent + ".timeContext$"))
            {
                this.TimeContext = new System.String("FETCH");
            }
            //      C# -> List<AnalyzerMapping>? AllAnalyzerMappings
            // GraphQL -> allAnalyzerMappings: [AnalyzerMapping!]! (type)
            if (this.AllAnalyzerMappings == null && Exploration.Includes(parent + ".allAnalyzerMappings"))
            {
                this.AllAnalyzerMappings = new List<AnalyzerMapping>();
                this.AllAnalyzerMappings.ApplyExploratoryFragment(parent + ".allAnalyzerMappings");
            }
            //      C# -> FileResultConnection? FileResultConnection
            // GraphQL -> fileResultConnection: FileResultConnection! (type)
            if (this.FileResultConnection == null && Exploration.Includes(parent + ".fileResultConnection"))
            {
                this.FileResultConnection = new FileResultConnection();
                this.FileResultConnection.ApplyExploratoryFragment(parent + ".fileResultConnection");
            }
            //      C# -> FileResultConnection? FolderChildConnection
            // GraphQL -> folderChildConnection: FileResultConnection! (type)
            if (this.FolderChildConnection == null && Exploration.Includes(parent + ".folderChildConnection"))
            {
                this.FolderChildConnection = new FileResultConnection();
                this.FolderChildConnection.ApplyExploratoryFragment(parent + ".folderChildConnection");
            }
            //      C# -> ObjectStatus? ObjectStatus
            // GraphQL -> objectStatus: ObjectStatus! (type)
            if (this.ObjectStatus == null && Exploration.Includes(parent + ".objectStatus"))
            {
                this.ObjectStatus = new ObjectStatus();
                this.ObjectStatus.ApplyExploratoryFragment(parent + ".objectStatus");
            }
            //      C# -> List<ClassificationPolicySummary>? PolicySummaries
            // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
            if (this.PolicySummaries == null && Exploration.Includes(parent + ".policySummaries"))
            {
                this.PolicySummaries = new List<ClassificationPolicySummary>();
                this.PolicySummaries.ApplyExploratoryFragment(parent + ".policySummaries");
            }
            //      C# -> FileResult? RootFileResult
            // GraphQL -> rootFileResult: FileResult! (type)
            if (this.RootFileResult == null && Exploration.Includes(parent + ".rootFileResult"))
            {
                this.RootFileResult = new FileResult();
                this.RootFileResult.ApplyExploratoryFragment(parent + ".rootFileResult");
            }
            //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
            // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
            if (this.WhitelistedAnalyzerList == null && Exploration.Includes(parent + ".whitelistedAnalyzerList"))
            {
                this.WhitelistedAnalyzerList = new List<WhitelistedAnalyzer>();
                this.WhitelistedAnalyzerList.ApplyExploratoryFragment(parent + ".whitelistedAnalyzerList");
            }
            //      C# -> AnalysisStatus? AnalysisStatus
            // GraphQL -> analysisStatus: AnalysisStatus! (enum)
            if (this.AnalysisStatus == null && Exploration.Includes(parent + ".analysisStatus$"))
            {
                this.AnalysisStatus = new AnalysisStatus();
            }
            //      C# -> DataGovOsType? OsType
            // GraphQL -> osType: DataGovOsType! (enum)
            if (this.OsType == null && Exploration.Includes(parent + ".osType$"))
            {
                this.OsType = new DataGovOsType();
            }
            //      C# -> RiskLevelType? RiskLevel
            // GraphQL -> riskLevel: RiskLevelType! (enum)
            if (this.RiskLevel == null && Exploration.Includes(parent + ".riskLevel$"))
            {
                this.RiskLevel = new RiskLevelType();
            }
            //      C# -> DataGovShareType? ShareType
            // GraphQL -> shareType: DataGovShareType! (enum)
            if (this.ShareType == null && Exploration.Includes(parent + ".shareType$"))
            {
                this.ShareType = new DataGovShareType();
            }
            //      C# -> HierarchyObject? Snappable
            // GraphQL -> snappable: HierarchyObject (interface)
            if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
            {
                this.Snappable = (HierarchyObject)InterfaceHelper.CreateInstanceOfFirstType(typeof(HierarchyObject));
                this.Snappable.ApplyExploratoryFragment(parent + ".snappable");
            }
        }


    #endregion

    } // class PolicyObj
    #endregion

    public static class ListPolicyObjExtensions
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
            this List<PolicyObj> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PolicyObj> list, 
            String parent = "")
        {
            var item = new PolicyObj();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types