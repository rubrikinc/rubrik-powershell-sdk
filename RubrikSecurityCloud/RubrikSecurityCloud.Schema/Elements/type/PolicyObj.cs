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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PolicyObj
    public class PolicyObj: BaseType
    {
        #region members

        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        [JsonProperty("accessRiskReasons")]
        public List<RiskReason>? AccessRiskReasons { get; set; }

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

        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        [JsonProperty("analyzerHits")]
        public AnalyzerHits? AnalyzerHits { get; set; }

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

        //      C# -> SensitiveHits? RiskHits
        // GraphQL -> riskHits: SensitiveHits (type)
        [JsonProperty("riskHits")]
        public SensitiveHits? RiskHits { get; set; }

        //      C# -> FileResult? RootFileResult
        // GraphQL -> rootFileResult: FileResult! (type)
        [JsonProperty("rootFileResult")]
        public FileResult? RootFileResult { get; set; }

        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sensitiveFiles")]
        public SensitiveFiles? SensitiveFiles { get; set; }

        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        [JsonProperty("totalSensitiveHits")]
        public SummaryHits? TotalSensitiveHits { get; set; }

        //      C# -> PrincipalCounts? UserCounts
        // GraphQL -> userCounts: PrincipalCounts (type)
        [JsonProperty("userCounts")]
        public PrincipalCounts? UserCounts { get; set; }

        //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
        // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
        [JsonProperty("whitelistedAnalyzerList")]
        public List<WhitelistedAnalyzer>? WhitelistedAnalyzerList { get; set; }


        #endregion

    #region methods

    public PolicyObj Set(
        List<RiskReason>? AccessRiskReasons = null,
        AnalysisStatus? AnalysisStatus = null,
        DataGovOsType? OsType = null,
        RiskLevelType? RiskLevel = null,
        DataGovShareType? ShareType = null,
        HierarchyObject? Snappable = null,
        System.String? Id = null,
        System.String? SnapshotFid = null,
        System.Int64? SnapshotTimestamp = null,
        System.String? TimeContext = null,
        List<AnalyzerMapping>? AllAnalyzerMappings = null,
        AnalyzerHits? AnalyzerHits = null,
        FileResultConnection? FileResultConnection = null,
        FileResultConnection? FolderChildConnection = null,
        ObjectStatus? ObjectStatus = null,
        List<ClassificationPolicySummary>? PolicySummaries = null,
        SensitiveHits? RiskHits = null,
        FileResult? RootFileResult = null,
        SensitiveFiles? SensitiveFiles = null,
        SummaryHits? TotalSensitiveHits = null,
        PrincipalCounts? UserCounts = null,
        List<WhitelistedAnalyzer>? WhitelistedAnalyzerList = null
    ) 
    {
        if ( AccessRiskReasons != null ) {
            this.AccessRiskReasons = AccessRiskReasons;
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
        if ( AnalyzerHits != null ) {
            this.AnalyzerHits = AnalyzerHits;
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
        if ( RiskHits != null ) {
            this.RiskHits = RiskHits;
        }
        if ( RootFileResult != null ) {
            this.RootFileResult = RootFileResult;
        }
        if ( SensitiveFiles != null ) {
            this.SensitiveFiles = SensitiveFiles;
        }
        if ( TotalSensitiveHits != null ) {
            this.TotalSensitiveHits = TotalSensitiveHits;
        }
        if ( UserCounts != null ) {
            this.UserCounts = UserCounts;
        }
        if ( WhitelistedAnalyzerList != null ) {
            this.WhitelistedAnalyzerList = WhitelistedAnalyzerList;
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
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (this.AccessRiskReasons != null) {
            s += ind + "accessRiskReasons\n" ;
        }
        //      C# -> AnalysisStatus? AnalysisStatus
        // GraphQL -> analysisStatus: AnalysisStatus! (enum)
        if (this.AnalysisStatus != null) {
            s += ind + "analysisStatus\n" ;
        }
        //      C# -> DataGovOsType? OsType
        // GraphQL -> osType: DataGovOsType! (enum)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            s += ind + "riskLevel\n" ;
        }
        //      C# -> DataGovShareType? ShareType
        // GraphQL -> shareType: DataGovShareType! (enum)
        if (this.ShareType != null) {
            s += ind + "shareType\n" ;
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject (interface)
        if (this.Snappable != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Snappable).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
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
        //      C# -> System.String? TimeContext
        // GraphQL -> timeContext: String! (scalar)
        if (this.TimeContext != null) {
            s += ind + "timeContext\n" ;
        }
        //      C# -> List<AnalyzerMapping>? AllAnalyzerMappings
        // GraphQL -> allAnalyzerMappings: [AnalyzerMapping!]! (type)
        if (this.AllAnalyzerMappings != null) {
            var fspec = this.AllAnalyzerMappings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allAnalyzerMappings {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (this.AnalyzerHits != null) {
            var fspec = this.AnalyzerHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "analyzerHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        if (this.FileResultConnection != null) {
            var fspec = this.FileResultConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "fileResultConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> FileResultConnection? FolderChildConnection
        // GraphQL -> folderChildConnection: FileResultConnection! (type)
        if (this.FolderChildConnection != null) {
            var fspec = this.FolderChildConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "folderChildConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ObjectStatus? ObjectStatus
        // GraphQL -> objectStatus: ObjectStatus! (type)
        if (this.ObjectStatus != null) {
            var fspec = this.ObjectStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "objectStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (this.PolicySummaries != null) {
            var fspec = this.PolicySummaries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policySummaries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SensitiveHits? RiskHits
        // GraphQL -> riskHits: SensitiveHits (type)
        if (this.RiskHits != null) {
            var fspec = this.RiskHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "riskHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> FileResult? RootFileResult
        // GraphQL -> rootFileResult: FileResult! (type)
        if (this.RootFileResult != null) {
            var fspec = this.RootFileResult.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "rootFileResult {\n" + fspec + ind + "}\n" ;
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
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits != null) {
            var fspec = this.TotalSensitiveHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalSensitiveHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrincipalCounts? UserCounts
        // GraphQL -> userCounts: PrincipalCounts (type)
        if (this.UserCounts != null) {
            var fspec = this.UserCounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "userCounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
        // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
        if (this.WhitelistedAnalyzerList != null) {
            var fspec = this.WhitelistedAnalyzerList.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "whitelistedAnalyzerList {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (this.AccessRiskReasons == null && Exploration.Includes(parent + ".accessRiskReasons", true))
        {
            this.AccessRiskReasons = new List<RiskReason>();
        }
        //      C# -> AnalysisStatus? AnalysisStatus
        // GraphQL -> analysisStatus: AnalysisStatus! (enum)
        if (this.AnalysisStatus == null && Exploration.Includes(parent + ".analysisStatus", true))
        {
            this.AnalysisStatus = new AnalysisStatus();
        }
        //      C# -> DataGovOsType? OsType
        // GraphQL -> osType: DataGovOsType! (enum)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = new DataGovOsType();
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel == null && Exploration.Includes(parent + ".riskLevel", true))
        {
            this.RiskLevel = new RiskLevelType();
        }
        //      C# -> DataGovShareType? ShareType
        // GraphQL -> shareType: DataGovShareType! (enum)
        if (this.ShareType == null && Exploration.Includes(parent + ".shareType", true))
        {
            this.ShareType = new DataGovShareType();
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject (interface)
        if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
        {
            var impls = new List<HierarchyObject>();
            impls.ApplyExploratoryFieldSpec(parent + ".snappable");
            this.Snappable = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
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
        //      C# -> System.String? TimeContext
        // GraphQL -> timeContext: String! (scalar)
        if (this.TimeContext == null && Exploration.Includes(parent + ".timeContext", true))
        {
            this.TimeContext = "FETCH";
        }
        //      C# -> List<AnalyzerMapping>? AllAnalyzerMappings
        // GraphQL -> allAnalyzerMappings: [AnalyzerMapping!]! (type)
        if (this.AllAnalyzerMappings == null && Exploration.Includes(parent + ".allAnalyzerMappings"))
        {
            this.AllAnalyzerMappings = new List<AnalyzerMapping>();
            this.AllAnalyzerMappings.ApplyExploratoryFieldSpec(parent + ".allAnalyzerMappings");
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (this.AnalyzerHits == null && Exploration.Includes(parent + ".analyzerHits"))
        {
            this.AnalyzerHits = new AnalyzerHits();
            this.AnalyzerHits.ApplyExploratoryFieldSpec(parent + ".analyzerHits");
        }
        //      C# -> FileResultConnection? FileResultConnection
        // GraphQL -> fileResultConnection: FileResultConnection! (type)
        if (this.FileResultConnection == null && Exploration.Includes(parent + ".fileResultConnection"))
        {
            this.FileResultConnection = new FileResultConnection();
            this.FileResultConnection.ApplyExploratoryFieldSpec(parent + ".fileResultConnection");
        }
        //      C# -> FileResultConnection? FolderChildConnection
        // GraphQL -> folderChildConnection: FileResultConnection! (type)
        if (this.FolderChildConnection == null && Exploration.Includes(parent + ".folderChildConnection"))
        {
            this.FolderChildConnection = new FileResultConnection();
            this.FolderChildConnection.ApplyExploratoryFieldSpec(parent + ".folderChildConnection");
        }
        //      C# -> ObjectStatus? ObjectStatus
        // GraphQL -> objectStatus: ObjectStatus! (type)
        if (this.ObjectStatus == null && Exploration.Includes(parent + ".objectStatus"))
        {
            this.ObjectStatus = new ObjectStatus();
            this.ObjectStatus.ApplyExploratoryFieldSpec(parent + ".objectStatus");
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (this.PolicySummaries == null && Exploration.Includes(parent + ".policySummaries"))
        {
            this.PolicySummaries = new List<ClassificationPolicySummary>();
            this.PolicySummaries.ApplyExploratoryFieldSpec(parent + ".policySummaries");
        }
        //      C# -> SensitiveHits? RiskHits
        // GraphQL -> riskHits: SensitiveHits (type)
        if (this.RiskHits == null && Exploration.Includes(parent + ".riskHits"))
        {
            this.RiskHits = new SensitiveHits();
            this.RiskHits.ApplyExploratoryFieldSpec(parent + ".riskHits");
        }
        //      C# -> FileResult? RootFileResult
        // GraphQL -> rootFileResult: FileResult! (type)
        if (this.RootFileResult == null && Exploration.Includes(parent + ".rootFileResult"))
        {
            this.RootFileResult = new FileResult();
            this.RootFileResult.ApplyExploratoryFieldSpec(parent + ".rootFileResult");
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles == null && Exploration.Includes(parent + ".sensitiveFiles"))
        {
            this.SensitiveFiles = new SensitiveFiles();
            this.SensitiveFiles.ApplyExploratoryFieldSpec(parent + ".sensitiveFiles");
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits == null && Exploration.Includes(parent + ".totalSensitiveHits"))
        {
            this.TotalSensitiveHits = new SummaryHits();
            this.TotalSensitiveHits.ApplyExploratoryFieldSpec(parent + ".totalSensitiveHits");
        }
        //      C# -> PrincipalCounts? UserCounts
        // GraphQL -> userCounts: PrincipalCounts (type)
        if (this.UserCounts == null && Exploration.Includes(parent + ".userCounts"))
        {
            this.UserCounts = new PrincipalCounts();
            this.UserCounts.ApplyExploratoryFieldSpec(parent + ".userCounts");
        }
        //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
        // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
        if (this.WhitelistedAnalyzerList == null && Exploration.Includes(parent + ".whitelistedAnalyzerList"))
        {
            this.WhitelistedAnalyzerList = new List<WhitelistedAnalyzer>();
            this.WhitelistedAnalyzerList.ApplyExploratoryFieldSpec(parent + ".whitelistedAnalyzerList");
        }
    }


    #endregion

    } // class PolicyObj
    
    #endregion

    public static class ListPolicyObjExtensions
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
            this List<PolicyObj> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolicyObj> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyObj());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types