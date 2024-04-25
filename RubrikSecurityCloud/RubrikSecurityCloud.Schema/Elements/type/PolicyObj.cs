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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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
        public RscInterface<HierarchyObject> Snappable { get; set; }

        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        [JsonProperty("hasInsights")]
        public System.Boolean? HasInsights { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsUserAccessEnabledObject
        // GraphQL -> isUserAccessEnabledObject: Boolean! (scalar)
        [JsonProperty("isUserAccessEnabledObject")]
        public System.Boolean? IsUserAccessEnabledObject { get; set; }

        //      C# -> System.Boolean? IsUserActivityEnabled
        // GraphQL -> isUserActivityEnabled: Boolean! (scalar)
        [JsonProperty("isUserActivityEnabled")]
        public System.Boolean? IsUserActivityEnabled { get; set; }

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

        //      C# -> PrincipalCounts? DeltaUserCounts
        // GraphQL -> deltaUserCounts: PrincipalCounts (type)
        [JsonProperty("deltaUserCounts")]
        public PrincipalCounts? DeltaUserCounts { get; set; }

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

        //      C# -> SensitiveFiles? UnusedSensitiveFiles
        // GraphQL -> unusedSensitiveFiles: SensitiveFiles (type)
        [JsonProperty("unusedSensitiveFiles")]
        public SensitiveFiles? UnusedSensitiveFiles { get; set; }

        //      C# -> PrincipalCounts? UserCounts
        // GraphQL -> userCounts: PrincipalCounts (type)
        [JsonProperty("userCounts")]
        public PrincipalCounts? UserCounts { get; set; }

        //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
        // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
        [JsonProperty("whitelistedAnalyzerList")]
        public List<WhitelistedAnalyzer>? WhitelistedAnalyzerList { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars AllAnalyzerMappings { get; set; }

        public RscGqlVars FileResultConnection { get; set; }

        public RscGqlVars FolderChildConnection { get; set; }

        public RscGqlVars WhitelistedAnalyzerList { get; set; }


        public InlineVars() {
            Tuple<string, string>[] allAnalyzerMappingsArgs = {
                    Tuple.Create("stdPath", "String!"),
                };
            this.AllAnalyzerMappings =
                new RscGqlVars(null, allAnalyzerMappingsArgs, null, true);
            Tuple<string, string>[] fileResultConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "ListFileResultFiltersInput"),
                    Tuple.Create("sort", "FileResultSortInput"),
                    Tuple.Create("timezone", "String!"),
                };
            this.FileResultConnection =
                new RscGqlVars(null, fileResultConnectionArgs, null, true);
            Tuple<string, string>[] folderChildConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "BrowseDirectoryFiltersInput"),
                    Tuple.Create("sort", "FileResultSortInput"),
                    Tuple.Create("stdPath", "String!"),
                    Tuple.Create("timezone", "String!"),
                };
            this.FolderChildConnection =
                new RscGqlVars(null, folderChildConnectionArgs, null, true);
            Tuple<string, string>[] whitelistedAnalyzerListArgs = {
                    Tuple.Create("stdPath", "String!"),
                };
            this.WhitelistedAnalyzerList =
                new RscGqlVars(null, whitelistedAnalyzerListArgs, null, true);
        }
    }

    public PolicyObj()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "PolicyObj";
    }

    public PolicyObj Set(
        List<RiskReason>? AccessRiskReasons = null,
        AnalysisStatus? AnalysisStatus = null,
        DataGovOsType? OsType = null,
        RiskLevelType? RiskLevel = null,
        DataGovShareType? ShareType = null,
        RscInterface<HierarchyObject> Snappable = null,
        System.Boolean? HasInsights = null,
        System.String? Id = null,
        System.Boolean? IsUserAccessEnabledObject = null,
        System.Boolean? IsUserActivityEnabled = null,
        System.String? SnapshotFid = null,
        System.Int64? SnapshotTimestamp = null,
        System.String? TimeContext = null,
        List<AnalyzerMapping>? AllAnalyzerMappings = null,
        AnalyzerHits? AnalyzerHits = null,
        PrincipalCounts? DeltaUserCounts = null,
        FileResultConnection? FileResultConnection = null,
        FileResultConnection? FolderChildConnection = null,
        ObjectStatus? ObjectStatus = null,
        List<ClassificationPolicySummary>? PolicySummaries = null,
        SensitiveHits? RiskHits = null,
        FileResult? RootFileResult = null,
        SensitiveFiles? SensitiveFiles = null,
        SummaryHits? TotalSensitiveHits = null,
        SensitiveFiles? UnusedSensitiveFiles = null,
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
        if ( HasInsights != null ) {
            this.HasInsights = HasInsights;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsUserAccessEnabledObject != null ) {
            this.IsUserAccessEnabledObject = IsUserAccessEnabledObject;
        }
        if ( IsUserActivityEnabled != null ) {
            this.IsUserActivityEnabled = IsUserActivityEnabled;
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
        if ( DeltaUserCounts != null ) {
            this.DeltaUserCounts = DeltaUserCounts;
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
        if ( UnusedSensitiveFiles != null ) {
            this.UnusedSensitiveFiles = UnusedSensitiveFiles;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (this.AccessRiskReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessRiskReasons\n" ;
            } else {
                s += ind + "accessRiskReasons\n" ;
            }
        }
        //      C# -> AnalysisStatus? AnalysisStatus
        // GraphQL -> analysisStatus: AnalysisStatus! (enum)
        if (this.AnalysisStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analysisStatus\n" ;
            } else {
                s += ind + "analysisStatus\n" ;
            }
        }
        //      C# -> DataGovOsType? OsType
        // GraphQL -> osType: DataGovOsType! (enum)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
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
        //      C# -> DataGovShareType? ShareType
        // GraphQL -> shareType: DataGovShareType! (enum)
        if (this.ShareType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareType\n" ;
            } else {
                s += ind + "shareType\n" ;
            }
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject (interface)
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
        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        if (this.HasInsights != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasInsights\n" ;
            } else {
                s += ind + "hasInsights\n" ;
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
        //      C# -> System.Boolean? IsUserAccessEnabledObject
        // GraphQL -> isUserAccessEnabledObject: Boolean! (scalar)
        if (this.IsUserAccessEnabledObject != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUserAccessEnabledObject\n" ;
            } else {
                s += ind + "isUserAccessEnabledObject\n" ;
            }
        }
        //      C# -> System.Boolean? IsUserActivityEnabled
        // GraphQL -> isUserActivityEnabled: Boolean! (scalar)
        if (this.IsUserActivityEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUserActivityEnabled\n" ;
            } else {
                s += ind + "isUserActivityEnabled\n" ;
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
        //      C# -> System.String? TimeContext
        // GraphQL -> timeContext: String! (scalar)
        if (this.TimeContext != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timeContext\n" ;
            } else {
                s += ind + "timeContext\n" ;
            }
        }
        //      C# -> List<AnalyzerMapping>? AllAnalyzerMappings
        // GraphQL -> allAnalyzerMappings: [AnalyzerMapping!]! (type)
        if (this.AllAnalyzerMappings != null) {
            var fspec = this.AllAnalyzerMappings.AsFieldSpec(conf.Child("allAnalyzerMappings"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allAnalyzerMappings" + "\n(" + this.Vars.AllAnalyzerMappings.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (this.AnalyzerHits != null) {
            var fspec = this.AnalyzerHits.AsFieldSpec(conf.Child("analyzerHits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalCounts? DeltaUserCounts
        // GraphQL -> deltaUserCounts: PrincipalCounts (type)
        if (this.DeltaUserCounts != null) {
            var fspec = this.DeltaUserCounts.AsFieldSpec(conf.Child("deltaUserCounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaUserCounts" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> FileResultConnection? FolderChildConnection
        // GraphQL -> folderChildConnection: FileResultConnection! (type)
        if (this.FolderChildConnection != null) {
            var fspec = this.FolderChildConnection.AsFieldSpec(conf.Child("folderChildConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "folderChildConnection" + "\n(" + this.Vars.FolderChildConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectStatus? ObjectStatus
        // GraphQL -> objectStatus: ObjectStatus! (type)
        if (this.ObjectStatus != null) {
            var fspec = this.ObjectStatus.AsFieldSpec(conf.Child("objectStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (this.PolicySummaries != null) {
            var fspec = this.PolicySummaries.AsFieldSpec(conf.Child("policySummaries"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policySummaries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? RiskHits
        // GraphQL -> riskHits: SensitiveHits (type)
        if (this.RiskHits != null) {
            var fspec = this.RiskHits.AsFieldSpec(conf.Child("riskHits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "riskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> FileResult? RootFileResult
        // GraphQL -> rootFileResult: FileResult! (type)
        if (this.RootFileResult != null) {
            var fspec = this.RootFileResult.AsFieldSpec(conf.Child("rootFileResult"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rootFileResult" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(conf.Child("sensitiveFiles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits != null) {
            var fspec = this.TotalSensitiveHits.AsFieldSpec(conf.Child("totalSensitiveHits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalSensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? UnusedSensitiveFiles
        // GraphQL -> unusedSensitiveFiles: SensitiveFiles (type)
        if (this.UnusedSensitiveFiles != null) {
            var fspec = this.UnusedSensitiveFiles.AsFieldSpec(conf.Child("unusedSensitiveFiles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "unusedSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalCounts? UserCounts
        // GraphQL -> userCounts: PrincipalCounts (type)
        if (this.UserCounts != null) {
            var fspec = this.UserCounts.AsFieldSpec(conf.Child("userCounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "userCounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
        // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
        if (this.WhitelistedAnalyzerList != null) {
            var fspec = this.WhitelistedAnalyzerList.AsFieldSpec(conf.Child("whitelistedAnalyzerList"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "whitelistedAnalyzerList" + "\n(" + this.Vars.WhitelistedAnalyzerList.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RiskReason>? AccessRiskReasons
        // GraphQL -> accessRiskReasons: [RiskReason!]! (enum)
        if (ec.Includes("accessRiskReasons",true))
        {
            if(this.AccessRiskReasons == null) {

                this.AccessRiskReasons = new List<RiskReason>();

            } else {


            }
        }
        else if (this.AccessRiskReasons != null && ec.Excludes("accessRiskReasons",true))
        {
            this.AccessRiskReasons = null;
        }
        //      C# -> AnalysisStatus? AnalysisStatus
        // GraphQL -> analysisStatus: AnalysisStatus! (enum)
        if (ec.Includes("analysisStatus",true))
        {
            if(this.AnalysisStatus == null) {

                this.AnalysisStatus = new AnalysisStatus();

            } else {


            }
        }
        else if (this.AnalysisStatus != null && ec.Excludes("analysisStatus",true))
        {
            this.AnalysisStatus = null;
        }
        //      C# -> DataGovOsType? OsType
        // GraphQL -> osType: DataGovOsType! (enum)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = new DataGovOsType();

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
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
        //      C# -> DataGovShareType? ShareType
        // GraphQL -> shareType: DataGovShareType! (enum)
        if (ec.Includes("shareType",true))
        {
            if(this.ShareType == null) {

                this.ShareType = new DataGovShareType();

            } else {


            }
        }
        else if (this.ShareType != null && ec.Excludes("shareType",true))
        {
            this.ShareType = null;
        }
        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject (interface)
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
        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        if (ec.Includes("hasInsights",true))
        {
            if(this.HasInsights == null) {

                this.HasInsights = true;

            } else {


            }
        }
        else if (this.HasInsights != null && ec.Excludes("hasInsights",true))
        {
            this.HasInsights = null;
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
        //      C# -> System.Boolean? IsUserAccessEnabledObject
        // GraphQL -> isUserAccessEnabledObject: Boolean! (scalar)
        if (ec.Includes("isUserAccessEnabledObject",true))
        {
            if(this.IsUserAccessEnabledObject == null) {

                this.IsUserAccessEnabledObject = true;

            } else {


            }
        }
        else if (this.IsUserAccessEnabledObject != null && ec.Excludes("isUserAccessEnabledObject",true))
        {
            this.IsUserAccessEnabledObject = null;
        }
        //      C# -> System.Boolean? IsUserActivityEnabled
        // GraphQL -> isUserActivityEnabled: Boolean! (scalar)
        if (ec.Includes("isUserActivityEnabled",true))
        {
            if(this.IsUserActivityEnabled == null) {

                this.IsUserActivityEnabled = true;

            } else {


            }
        }
        else if (this.IsUserActivityEnabled != null && ec.Excludes("isUserActivityEnabled",true))
        {
            this.IsUserActivityEnabled = null;
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
        //      C# -> System.String? TimeContext
        // GraphQL -> timeContext: String! (scalar)
        if (ec.Includes("timeContext",true))
        {
            if(this.TimeContext == null) {

                this.TimeContext = "FETCH";

            } else {


            }
        }
        else if (this.TimeContext != null && ec.Excludes("timeContext",true))
        {
            this.TimeContext = null;
        }
        //      C# -> List<AnalyzerMapping>? AllAnalyzerMappings
        // GraphQL -> allAnalyzerMappings: [AnalyzerMapping!]! (type)
        if (ec.Includes("allAnalyzerMappings",false))
        {
            if(this.AllAnalyzerMappings == null) {

                this.AllAnalyzerMappings = new List<AnalyzerMapping>();
                this.AllAnalyzerMappings.ApplyExploratoryFieldSpec(ec.NewChild("allAnalyzerMappings"));

            } else {

                this.AllAnalyzerMappings.ApplyExploratoryFieldSpec(ec.NewChild("allAnalyzerMappings"));

            }
        }
        else if (this.AllAnalyzerMappings != null && ec.Excludes("allAnalyzerMappings",false))
        {
            this.AllAnalyzerMappings = null;
        }
        //      C# -> AnalyzerHits? AnalyzerHits
        // GraphQL -> analyzerHits: AnalyzerHits (type)
        if (ec.Includes("analyzerHits",false))
        {
            if(this.AnalyzerHits == null) {

                this.AnalyzerHits = new AnalyzerHits();
                this.AnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("analyzerHits"));

            } else {

                this.AnalyzerHits.ApplyExploratoryFieldSpec(ec.NewChild("analyzerHits"));

            }
        }
        else if (this.AnalyzerHits != null && ec.Excludes("analyzerHits",false))
        {
            this.AnalyzerHits = null;
        }
        //      C# -> PrincipalCounts? DeltaUserCounts
        // GraphQL -> deltaUserCounts: PrincipalCounts (type)
        if (ec.Includes("deltaUserCounts",false))
        {
            if(this.DeltaUserCounts == null) {

                this.DeltaUserCounts = new PrincipalCounts();
                this.DeltaUserCounts.ApplyExploratoryFieldSpec(ec.NewChild("deltaUserCounts"));

            } else {

                this.DeltaUserCounts.ApplyExploratoryFieldSpec(ec.NewChild("deltaUserCounts"));

            }
        }
        else if (this.DeltaUserCounts != null && ec.Excludes("deltaUserCounts",false))
        {
            this.DeltaUserCounts = null;
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
        //      C# -> FileResultConnection? FolderChildConnection
        // GraphQL -> folderChildConnection: FileResultConnection! (type)
        if (ec.Includes("folderChildConnection",false))
        {
            if(this.FolderChildConnection == null) {

                this.FolderChildConnection = new FileResultConnection();
                this.FolderChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("folderChildConnection"));

            } else {

                this.FolderChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("folderChildConnection"));

            }
        }
        else if (this.FolderChildConnection != null && ec.Excludes("folderChildConnection",false))
        {
            this.FolderChildConnection = null;
        }
        //      C# -> ObjectStatus? ObjectStatus
        // GraphQL -> objectStatus: ObjectStatus! (type)
        if (ec.Includes("objectStatus",false))
        {
            if(this.ObjectStatus == null) {

                this.ObjectStatus = new ObjectStatus();
                this.ObjectStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectStatus"));

            } else {

                this.ObjectStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectStatus"));

            }
        }
        else if (this.ObjectStatus != null && ec.Excludes("objectStatus",false))
        {
            this.ObjectStatus = null;
        }
        //      C# -> List<ClassificationPolicySummary>? PolicySummaries
        // GraphQL -> policySummaries: [ClassificationPolicySummary!]! (type)
        if (ec.Includes("policySummaries",false))
        {
            if(this.PolicySummaries == null) {

                this.PolicySummaries = new List<ClassificationPolicySummary>();
                this.PolicySummaries.ApplyExploratoryFieldSpec(ec.NewChild("policySummaries"));

            } else {

                this.PolicySummaries.ApplyExploratoryFieldSpec(ec.NewChild("policySummaries"));

            }
        }
        else if (this.PolicySummaries != null && ec.Excludes("policySummaries",false))
        {
            this.PolicySummaries = null;
        }
        //      C# -> SensitiveHits? RiskHits
        // GraphQL -> riskHits: SensitiveHits (type)
        if (ec.Includes("riskHits",false))
        {
            if(this.RiskHits == null) {

                this.RiskHits = new SensitiveHits();
                this.RiskHits.ApplyExploratoryFieldSpec(ec.NewChild("riskHits"));

            } else {

                this.RiskHits.ApplyExploratoryFieldSpec(ec.NewChild("riskHits"));

            }
        }
        else if (this.RiskHits != null && ec.Excludes("riskHits",false))
        {
            this.RiskHits = null;
        }
        //      C# -> FileResult? RootFileResult
        // GraphQL -> rootFileResult: FileResult! (type)
        if (ec.Includes("rootFileResult",false))
        {
            if(this.RootFileResult == null) {

                this.RootFileResult = new FileResult();
                this.RootFileResult.ApplyExploratoryFieldSpec(ec.NewChild("rootFileResult"));

            } else {

                this.RootFileResult.ApplyExploratoryFieldSpec(ec.NewChild("rootFileResult"));

            }
        }
        else if (this.RootFileResult != null && ec.Excludes("rootFileResult",false))
        {
            this.RootFileResult = null;
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
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (ec.Includes("totalSensitiveHits",false))
        {
            if(this.TotalSensitiveHits == null) {

                this.TotalSensitiveHits = new SummaryHits();
                this.TotalSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("totalSensitiveHits"));

            } else {

                this.TotalSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("totalSensitiveHits"));

            }
        }
        else if (this.TotalSensitiveHits != null && ec.Excludes("totalSensitiveHits",false))
        {
            this.TotalSensitiveHits = null;
        }
        //      C# -> SensitiveFiles? UnusedSensitiveFiles
        // GraphQL -> unusedSensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("unusedSensitiveFiles",false))
        {
            if(this.UnusedSensitiveFiles == null) {

                this.UnusedSensitiveFiles = new SensitiveFiles();
                this.UnusedSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("unusedSensitiveFiles"));

            } else {

                this.UnusedSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("unusedSensitiveFiles"));

            }
        }
        else if (this.UnusedSensitiveFiles != null && ec.Excludes("unusedSensitiveFiles",false))
        {
            this.UnusedSensitiveFiles = null;
        }
        //      C# -> PrincipalCounts? UserCounts
        // GraphQL -> userCounts: PrincipalCounts (type)
        if (ec.Includes("userCounts",false))
        {
            if(this.UserCounts == null) {

                this.UserCounts = new PrincipalCounts();
                this.UserCounts.ApplyExploratoryFieldSpec(ec.NewChild("userCounts"));

            } else {

                this.UserCounts.ApplyExploratoryFieldSpec(ec.NewChild("userCounts"));

            }
        }
        else if (this.UserCounts != null && ec.Excludes("userCounts",false))
        {
            this.UserCounts = null;
        }
        //      C# -> List<WhitelistedAnalyzer>? WhitelistedAnalyzerList
        // GraphQL -> whitelistedAnalyzerList: [WhitelistedAnalyzer!]! (type)
        if (ec.Includes("whitelistedAnalyzerList",false))
        {
            if(this.WhitelistedAnalyzerList == null) {

                this.WhitelistedAnalyzerList = new List<WhitelistedAnalyzer>();
                this.WhitelistedAnalyzerList.ApplyExploratoryFieldSpec(ec.NewChild("whitelistedAnalyzerList"));

            } else {

                this.WhitelistedAnalyzerList.ApplyExploratoryFieldSpec(ec.NewChild("whitelistedAnalyzerList"));

            }
        }
        else if (this.WhitelistedAnalyzerList != null && ec.Excludes("whitelistedAnalyzerList",false))
        {
            this.WhitelistedAnalyzerList = null;
        }
    }


    #endregion

    } // class PolicyObj
    
    #endregion

    public static class ListPolicyObjExtensions
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
            this List<PolicyObj> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyObj> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyObj> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyObj());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyObj> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types