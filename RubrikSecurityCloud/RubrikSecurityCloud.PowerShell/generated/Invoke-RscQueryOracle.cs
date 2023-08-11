// Invoke-RscQueryOracle.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryOracle",
        DefaultParameterSetName = "Host")
    ]
    public class Invoke_RscQueryOracle : RscPSCmdlet
    {
        
        /// <summary>
        /// TopLevelDescendants parameter set
        ///
        /// [GraphQL: oracleTopLevelDescendants]
        /// </summary>
        [Parameter(
            ParameterSetName = "TopLevelDescendants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level Oracle Objects accessible by the current user.
[GraphQL: oracleTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendants { get; set; }

        
        /// <summary>
        /// Databases parameter set
        ///
        /// [GraphQL: oracleDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "Databases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Oracle Databases.
[GraphQL: oracleDatabases]",
            Position = 0
        )]
        public SwitchParameter Databases { get; set; }

        
        /// <summary>
        /// Host parameter set
        ///
        /// [GraphQL: oracleHost]
        /// </summary>
        [Parameter(
            ParameterSetName = "Host",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Host.
[GraphQL: oracleHost]",
            Position = 0
        )]
        public new SwitchParameter Host { get; set; }

        
        /// <summary>
        /// Rac parameter set
        ///
        /// [GraphQL: oracleRac]
        /// </summary>
        [Parameter(
            ParameterSetName = "Rac",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Real Application Cluster.
[GraphQL: oracleRac]",
            Position = 0
        )]
        public SwitchParameter Rac { get; set; }

        
        /// <summary>
        /// DataGuardGroup parameter set
        ///
        /// [GraphQL: oracleDataGuardGroup]
        /// </summary>
        [Parameter(
            ParameterSetName = "DataGuardGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Data Guard Group.
[GraphQL: oracleDataGuardGroup]",
            Position = 0
        )]
        public SwitchParameter DataGuardGroup { get; set; }

        
        /// <summary>
        /// Database parameter set
        ///
        /// [GraphQL: oracleDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Database.
[GraphQL: oracleDatabase]",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        /// <summary>
        /// LiveMounts parameter set
        ///
        /// [GraphQL: oracleLiveMounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "LiveMounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Oracle Live Mounts.
[GraphQL: oracleLiveMounts]",
            Position = 0
        )]
        public SwitchParameter LiveMounts { get; set; }

        
        /// <summary>
        /// AcoParameters parameter set
        ///
        /// [GraphQL: oracleAcoParameters]
        /// </summary>
        [Parameter(
            ParameterSetName = "AcoParameters",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of supported Advanced Cloning Options

Supported in v6.0+
Get the list of supported Advanced Cloning Options (ACO) parameters.
[GraphQL: oracleAcoParameters]",
            Position = 0
        )]
        public SwitchParameter AcoParameters { get; set; }

        
        /// <summary>
        /// RecoverableRanges parameter set
        ///
        /// [GraphQL: oracleRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window.
[GraphQL: oracleRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter RecoverableRanges { get; set; }

        
        /// <summary>
        /// MissedRecoverableRanges parameter set
        ///
        /// [GraphQL: oracleMissedRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "MissedRecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get missed recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given.
[GraphQL: oracleMissedRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter MissedRecoverableRanges { get; set; }

        
        /// <summary>
        /// MissedSnapshots parameter set
        ///
        /// [GraphQL: oracleMissedSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "MissedSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get missed snapshots for an Oracle database

Supported in v5.0+
Retrieve summary information about the missed snapshots of an Oracle database.
[GraphQL: oracleMissedSnapshots]",
            Position = 0
        )]
        public SwitchParameter MissedSnapshots { get; set; }

        
        /// <summary>
        /// AcoExampleDownloadLink parameter set
        ///
        /// [GraphQL: oracleAcoExampleDownloadLink]
        /// </summary>
        [Parameter(
            ParameterSetName = "AcoExampleDownloadLink",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Link to download the Advanced Recovery Options example file

Supported in v5.3+
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries.
[GraphQL: oracleAcoExampleDownloadLink]",
            Position = 0
        )]
        public SwitchParameter AcoExampleDownloadLink { get; set; }

        
        /// <summary>
        /// PdbDetails parameter set
        ///
        /// [GraphQL: oraclePdbDetails]
        /// </summary>
        [Parameter(
            ParameterSetName = "PdbDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get PDB details

Supported in v8.0+
Retrieves information about available pluggable databases (PDBs) for a given recovery point.
[GraphQL: oraclePdbDetails]",
            Position = 0
        )]
        public SwitchParameter PdbDetails { get; set; }

        
        /// <summary>
        /// HostLogBackupConfig parameter set
        ///
        /// [GraphQL: oracleHostLogBackupConfig]
        /// </summary>
        [Parameter(
            ParameterSetName = "HostLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Oracle Log backup configuration for Oracle Host.
[GraphQL: oracleHostLogBackupConfig]",
            Position = 0
        )]
        public SwitchParameter HostLogBackupConfig { get; set; }

        
        /// <summary>
        /// DatabaseLogBackupConfig parameter set
        ///
        /// [GraphQL: oracleDatabaseLogBackupConfig]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Oracle log backup configuration for an Oracle Database.
[GraphQL: oracleDatabaseLogBackupConfig]",
            Position = 0
        )]
        public SwitchParameter DatabaseLogBackupConfig { get; set; }

        
        /// <summary>
        /// RacLogBackupConfig parameter set
        ///
        /// [GraphQL: oracleRacLogBackupConfig]
        /// </summary>
        [Parameter(
            ParameterSetName = "RacLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Oracle log backup configuration for an Oracle RAC.
[GraphQL: oracleRacLogBackupConfig]",
            Position = 0
        )]
        public SwitchParameter RacLogBackupConfig { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendants":
                        this.ProcessRecord_TopLevelDescendants();
                        break;
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "Rac":
                        this.ProcessRecord_Rac();
                        break;
                    case "DataGuardGroup":
                        this.ProcessRecord_DataGuardGroup();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "LiveMounts":
                        this.ProcessRecord_LiveMounts();
                        break;
                    case "AcoParameters":
                        this.ProcessRecord_AcoParameters();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
                        break;
                    case "MissedRecoverableRanges":
                        this.ProcessRecord_MissedRecoverableRanges();
                        break;
                    case "MissedSnapshots":
                        this.ProcessRecord_MissedSnapshots();
                        break;
                    case "AcoExampleDownloadLink":
                        this.ProcessRecord_AcoExampleDownloadLink();
                        break;
                    case "PdbDetails":
                        this.ProcessRecord_PdbDetails();
                        break;
                    case "HostLogBackupConfig":
                        this.ProcessRecord_HostLogBackupConfig();
                        break;
                    case "DatabaseLogBackupConfig":
                        this.ProcessRecord_DatabaseLogBackupConfig();
                        break;
                    case "RacLogBackupConfig":
                        this.ProcessRecord_RacLogBackupConfig();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // oracleTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Invoke graphql operation oracleTopLevelDescendants
            InvokeQueryOracleTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Invoke graphql operation oracleDatabases
            InvokeQueryOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHost.
        internal void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Invoke graphql operation oracleHost
            InvokeQueryOracleHost();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRac.
        internal void ProcessRecord_Rac()
        {
            this._logger.name += " -Rac";
            // Invoke graphql operation oracleRac
            InvokeQueryOracleRac();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDataGuardGroup.
        internal void ProcessRecord_DataGuardGroup()
        {
            this._logger.name += " -DataGuardGroup";
            // Invoke graphql operation oracleDataGuardGroup
            InvokeQueryOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabase.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Invoke graphql operation oracleDatabase
            InvokeQueryOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // oracleLiveMounts.
        internal void ProcessRecord_LiveMounts()
        {
            this._logger.name += " -LiveMounts";
            // Invoke graphql operation oracleLiveMounts
            InvokeQueryOracleLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // oracleAcoParameters.
        internal void ProcessRecord_AcoParameters()
        {
            this._logger.name += " -AcoParameters";
            // Invoke graphql operation oracleAcoParameters
            InvokeQueryOracleAcoParameters();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Invoke graphql operation oracleRecoverableRanges
            InvokeQueryOracleRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedRecoverableRanges.
        internal void ProcessRecord_MissedRecoverableRanges()
        {
            this._logger.name += " -MissedRecoverableRanges";
            // Invoke graphql operation oracleMissedRecoverableRanges
            InvokeQueryOracleMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedSnapshots.
        internal void ProcessRecord_MissedSnapshots()
        {
            this._logger.name += " -MissedSnapshots";
            // Invoke graphql operation oracleMissedSnapshots
            InvokeQueryOracleMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // oracleAcoExampleDownloadLink.
        internal void ProcessRecord_AcoExampleDownloadLink()
        {
            this._logger.name += " -AcoExampleDownloadLink";
            // Invoke graphql operation oracleAcoExampleDownloadLink
            InvokeQueryOracleAcoExampleDownloadLink();
        }

        // This parameter set invokes a single graphql operation:
        // oraclePdbDetails.
        internal void ProcessRecord_PdbDetails()
        {
            this._logger.name += " -PdbDetails";
            // Invoke graphql operation oraclePdbDetails
            InvokeQueryOraclePdbDetails();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHostLogBackupConfig.
        internal void ProcessRecord_HostLogBackupConfig()
        {
            this._logger.name += " -HostLogBackupConfig";
            // Invoke graphql operation oracleHostLogBackupConfig
            InvokeQueryOracleHostLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabaseLogBackupConfig.
        internal void ProcessRecord_DatabaseLogBackupConfig()
        {
            this._logger.name += " -DatabaseLogBackupConfig";
            // Invoke graphql operation oracleDatabaseLogBackupConfig
            InvokeQueryOracleDatabaseLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRacLogBackupConfig.
        internal void ProcessRecord_RacLogBackupConfig()
        {
            this._logger.name += " -RacLogBackupConfig";
            // Invoke graphql operation oracleRacLogBackupConfig
            InvokeQueryOracleRacLogBackupConfig();
        }


        // Invoke GraphQL Query:
        // oracleTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): OracleTopLevelDescendantTypeConnection!
        internal void InvokeQueryOracleTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            OracleTopLevelDescendantTypeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleTopLevelDescendants(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                fieldSpecDoc,
                "OracleTopLevelDescendantTypeConnection"
            );
        }

        // Invoke GraphQL Query:
        // oracleDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): OracleDatabaseConnection!
        internal void InvokeQueryOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            OracleDatabaseConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleDatabaseConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleDatabaseConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleDatabases(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "OracleDatabaseConnection"
            );
        }

        // Invoke GraphQL Query:
        // oracleHost(fid: UUID!): OracleHost!
        internal void InvokeQueryOracleHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            OracleHost? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleHost)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleHost)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleHost(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleHost",
                "($fid: UUID!)",
                fieldSpecDoc,
                "OracleHost"
            );
        }

        // Invoke GraphQL Query:
        // oracleRac(fid: UUID!): OracleRac!
        internal void InvokeQueryOracleRac()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            OracleRac? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleRac)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleRac)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleRac(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleRac",
                "($fid: UUID!)",
                fieldSpecDoc,
                "OracleRac"
            );
        }

        // Invoke GraphQL Query:
        // oracleDataGuardGroup(fid: UUID!): OracleDataGuardGroup!
        internal void InvokeQueryOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            OracleDataGuardGroup? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleDataGuardGroup)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleDataGuardGroup)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleDataGuardGroup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleDataGuardGroup",
                "($fid: UUID!)",
                fieldSpecDoc,
                "OracleDataGuardGroup"
            );
        }

        // Invoke GraphQL Query:
        // oracleDatabase(fid: UUID!): OracleDatabase!
        internal void InvokeQueryOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            OracleDatabase? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleDatabase)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleDatabase)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleDatabase",
                "($fid: UUID!)",
                fieldSpecDoc,
                "OracleDatabase"
            );
        }

        // Invoke GraphQL Query:
        // oracleLiveMounts(
        //     first: Int
        //     after: String
        //     filters: [OracleLiveMountFilterInput!]
        //     sortBy: OracleLiveMountSortBy
        //   ): OracleLiveMountConnection!
        internal void InvokeQueryOracleLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[OracleLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "OracleLiveMountSortBy"),
            };
            OracleLiveMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleLiveMountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleLiveMountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleLiveMounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleLiveMounts",
                "($first: Int,$after: String,$filters: [OracleLiveMountFilterInput!],$sortBy: OracleLiveMountSortBy)",
                fieldSpecDoc,
                "OracleLiveMountConnection"
            );
        }

        // Invoke GraphQL Query:
        // oracleAcoParameters(input: ClusterUuidWithDbIdInput!): OracleAcoParameterList!
        internal void InvokeQueryOracleAcoParameters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            OracleAcoParameterList? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleAcoParameterList)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleAcoParameterList)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleAcoParameters(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleAcoParameters",
                "($input: ClusterUuidWithDbIdInput!)",
                fieldSpecDoc,
                "OracleAcoParameterList"
            );
        }

        // Invoke GraphQL Query:
        // oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!): OracleRecoverableRangeListResponse!
        internal void InvokeQueryOracleRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbRecoverableRangesInput!"),
            };
            OracleRecoverableRangeListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleRecoverableRangeListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleRecoverableRanges(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleRecoverableRanges",
                "($input: GetOracleDbRecoverableRangesInput!)",
                fieldSpecDoc,
                "OracleRecoverableRangeListResponse"
            );
        }

        // Invoke GraphQL Query:
        // oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!): OracleMissedRecoverableRangeListResponse!
        internal void InvokeQueryOracleMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbMissedRecoverableRangesInput!"),
            };
            OracleMissedRecoverableRangeListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleMissedRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleMissedRecoverableRangeListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleMissedRecoverableRanges(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleMissedRecoverableRanges",
                "($input: GetOracleDbMissedRecoverableRangesInput!)",
                fieldSpecDoc,
                "OracleMissedRecoverableRangeListResponse"
            );
        }

        // Invoke GraphQL Query:
        // oracleMissedSnapshots(input: GetMissedOracleDbSnapshotsInput!): MissedSnapshotListResponse!
        internal void InvokeQueryOracleMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedOracleDbSnapshotsInput!"),
            };
            MissedSnapshotListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MissedSnapshotListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MissedSnapshotListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleMissedSnapshots(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleMissedSnapshots",
                "($input: GetMissedOracleDbSnapshotsInput!)",
                fieldSpecDoc,
                "MissedSnapshotListResponse"
            );
        }

        // Invoke GraphQL Query:
        // oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!): OracleFileDownloadLink!
        internal void InvokeQueryOracleAcoExampleDownloadLink()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            OracleFileDownloadLink? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleFileDownloadLink)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleFileDownloadLink)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleAcoExampleDownloadLink(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleAcoExampleDownloadLink",
                "($input: ClusterUuidWithDbIdInput!)",
                fieldSpecDoc,
                "OracleFileDownloadLink"
            );
        }

        // Invoke GraphQL Query:
        // oraclePdbDetails(input: OraclePdbDetailsInput!): OraclePdbDetails!
        internal void InvokeQueryOraclePdbDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OraclePdbDetailsInput!"),
            };
            OraclePdbDetails? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OraclePdbDetails)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OraclePdbDetails)this.Field;
                }
            }
            string fieldSpecDoc = Query.OraclePdbDetails(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOraclePdbDetails",
                "($input: OraclePdbDetailsInput!)",
                fieldSpecDoc,
                "OraclePdbDetails"
            );
        }

        // Invoke GraphQL Query:
        // oracleHostLogBackupConfig(input: OracleHostInput!): OracleLogBackupConfig!
        internal void InvokeQueryOracleHostLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleHostInput!"),
            };
            OracleLogBackupConfig? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleLogBackupConfig)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleLogBackupConfig)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleHostLogBackupConfig(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleHostLogBackupConfig",
                "($input: OracleHostInput!)",
                fieldSpecDoc,
                "OracleLogBackupConfig"
            );
        }

        // Invoke GraphQL Query:
        // oracleDatabaseLogBackupConfig(input: OracleDbInput!): OracleLogBackupConfig!
        internal void InvokeQueryOracleDatabaseLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleDbInput!"),
            };
            OracleLogBackupConfig? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleLogBackupConfig)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleLogBackupConfig)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleDatabaseLogBackupConfig(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleDatabaseLogBackupConfig",
                "($input: OracleDbInput!)",
                fieldSpecDoc,
                "OracleLogBackupConfig"
            );
        }

        // Invoke GraphQL Query:
        // oracleRacLogBackupConfig(input: OracleRacInput!): OracleLogBackupConfig!
        internal void InvokeQueryOracleRacLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleRacInput!"),
            };
            OracleLogBackupConfig? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (OracleLogBackupConfig)psObject.BaseObject;
                } else {
                    fieldSpecObj = (OracleLogBackupConfig)this.Field;
                }
            }
            string fieldSpecDoc = Query.OracleRacLogBackupConfig(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryOracleRacLogBackupConfig",
                "($input: OracleRacInput!)",
                fieldSpecDoc,
                "OracleLogBackupConfig"
            );
        }


    } // class Invoke_RscQueryOracle
}