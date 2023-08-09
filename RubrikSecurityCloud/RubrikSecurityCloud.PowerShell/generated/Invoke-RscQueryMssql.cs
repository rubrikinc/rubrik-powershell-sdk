// Invoke-RscQueryMssql.cs
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
        "RscQueryMssql",
        DefaultParameterSetName = "Instance")
    ]
    public class Invoke_RscQueryMssql : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // TopLevelDescendants parameter set
        //
        // [GraphQL: mssqlTopLevelDescendants]
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.
[GraphQL: mssqlTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendants { get; set; }

        
        // -------------------------------------------------------------------
        // Databases parameter set
        //
        // [GraphQL: mssqlDatabases]
        //
        [Parameter(
            ParameterSetName = "Databases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Microsoft SQL Databases.
[GraphQL: mssqlDatabases]",
            Position = 0
        )]
        public SwitchParameter Databases { get; set; }

        
        // -------------------------------------------------------------------
        // AvailabilityGroup parameter set
        //
        // [GraphQL: mssqlAvailabilityGroup]
        //
        [Parameter(
            ParameterSetName = "AvailabilityGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Microsoft SQL Availability Group.
[GraphQL: mssqlAvailabilityGroup]",
            Position = 0
        )]
        public SwitchParameter AvailabilityGroup { get; set; }

        
        // -------------------------------------------------------------------
        // Instance parameter set
        //
        // [GraphQL: mssqlInstance]
        //
        [Parameter(
            ParameterSetName = "Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Microsoft SQL Instance.
[GraphQL: mssqlInstance]",
            Position = 0
        )]
        public SwitchParameter Instance { get; set; }

        
        // -------------------------------------------------------------------
        // Database parameter set
        //
        // [GraphQL: mssqlDatabase]
        //
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A Microsoft SQL Database.
[GraphQL: mssqlDatabase]",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverableRanges parameter set
        //
        // [GraphQL: mssqlRecoverableRanges]
        //
        [Parameter(
            ParameterSetName = "RecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of recoverable ranges for a Microsoft SQL Database.
[GraphQL: mssqlRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter RecoverableRanges { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseMissedSnapshots parameter set
        //
        // [GraphQL: mssqlDatabaseMissedSnapshots]
        //
        [Parameter(
            ParameterSetName = "DatabaseMissedSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of missed snapshots for a Microsoft SQL Database.
[GraphQL: mssqlDatabaseMissedSnapshots]",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedSnapshots { get; set; }

        
        // -------------------------------------------------------------------
        // CompatibleInstances parameter set
        //
        // [GraphQL: mssqlCompatibleInstances]
        //
        [Parameter(
            ParameterSetName = "CompatibleInstances",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns all compatible instances for export for the specified recovery time.
[GraphQL: mssqlCompatibleInstances]",
            Position = 0
        )]
        public SwitchParameter CompatibleInstances { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseMissedRecoverableRanges parameter set
        //
        // [GraphQL: mssqlDatabaseMissedRecoverableRanges]
        //
        [Parameter(
            ParameterSetName = "DatabaseMissedRecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of missed recoverable ranges for a Microsoft SQL Database.
[GraphQL: mssqlDatabaseMissedRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedRecoverableRanges { get; set; }

        
        // -------------------------------------------------------------------
        // AllDatabaseRestoreFiles parameter set
        //
        // [GraphQL: allMssqlDatabaseRestoreFiles]
        //
        [Parameter(
            ParameterSetName = "AllDatabaseRestoreFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Provides a list of database files to be restored for the specified restore or export operation.
[GraphQL: allMssqlDatabaseRestoreFiles]",
            Position = 0
        )]
        public SwitchParameter AllDatabaseRestoreFiles { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseLiveMounts parameter set
        //
        // [GraphQL: mssqlDatabaseLiveMounts]
        //
        [Parameter(
            ParameterSetName = "DatabaseLiveMounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Microsoft SQL Database live mounts.
[GraphQL: mssqlDatabaseLiveMounts]",
            Position = 0
        )]
        public SwitchParameter DatabaseLiveMounts { get; set; }

        
        // -------------------------------------------------------------------
        // DefaultProperties parameter set
        //
        // [GraphQL: mssqlDefaultProperties]
        //
        [Parameter(
            ParameterSetName = "DefaultProperties",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The current default properties for Microsoft SQL databases.
[GraphQL: mssqlDefaultProperties]",
            Position = 0
        )]
        public SwitchParameter DefaultProperties { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseRestoreEstimate parameter set
        //
        // [GraphQL: mssqlDatabaseRestoreEstimate]
        //
        [Parameter(
            ParameterSetName = "DatabaseRestoreEstimate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns a size estimate for a restore, export, or mount.
[GraphQL: mssqlDatabaseRestoreEstimate]",
            Position = 0
        )]
        public SwitchParameter DatabaseRestoreEstimate { get; set; }

        
        // -------------------------------------------------------------------
        // CdmLogShippingTargets parameter set
        //
        // [GraphQL: cdmMssqlLogShippingTargets]
        //
        [Parameter(
            ParameterSetName = "CdmLogShippingTargets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Microsoft SQL log shipping target.
[GraphQL: cdmMssqlLogShippingTargets]",
            Position = 0
        )]
        public SwitchParameter CdmLogShippingTargets { get; set; }

        
        // -------------------------------------------------------------------
        // CdmLogShippingTarget parameter set
        //
        // [GraphQL: cdmMssqlLogShippingTarget]
        //
        [Parameter(
            ParameterSetName = "CdmLogShippingTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"A single Microsoft SQL log shipping target.
[GraphQL: cdmMssqlLogShippingTarget]",
            Position = 0
        )]
        public SwitchParameter CdmLogShippingTarget { get; set; }

        
        // -------------------------------------------------------------------
        // LogShippingTargets parameter set
        //
        // [GraphQL: mssqlLogShippingTargets]
        //
        [Parameter(
            ParameterSetName = "LogShippingTargets",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of filtered Microsoft SQL log shipping targets.
[GraphQL: mssqlLogShippingTargets]",
            Position = 0
        )]
        public SwitchParameter LogShippingTargets { get; set; }


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
                    case "AvailabilityGroup":
                        this.ProcessRecord_AvailabilityGroup();
                        break;
                    case "Instance":
                        this.ProcessRecord_Instance();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
                        break;
                    case "DatabaseMissedSnapshots":
                        this.ProcessRecord_DatabaseMissedSnapshots();
                        break;
                    case "CompatibleInstances":
                        this.ProcessRecord_CompatibleInstances();
                        break;
                    case "DatabaseMissedRecoverableRanges":
                        this.ProcessRecord_DatabaseMissedRecoverableRanges();
                        break;
                    case "AllDatabaseRestoreFiles":
                        this.ProcessRecord_AllDatabaseRestoreFiles();
                        break;
                    case "DatabaseLiveMounts":
                        this.ProcessRecord_DatabaseLiveMounts();
                        break;
                    case "DefaultProperties":
                        this.ProcessRecord_DefaultProperties();
                        break;
                    case "DatabaseRestoreEstimate":
                        this.ProcessRecord_DatabaseRestoreEstimate();
                        break;
                    case "CdmLogShippingTargets":
                        this.ProcessRecord_CdmLogShippingTargets();
                        break;
                    case "CdmLogShippingTarget":
                        this.ProcessRecord_CdmLogShippingTarget();
                        break;
                    case "LogShippingTargets":
                        this.ProcessRecord_LogShippingTargets();
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

        // This parameter set invokes a single graphql operation:
        // mssqlTopLevelDescendants.
        protected void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Invoke graphql operation mssqlTopLevelDescendants
            InvokeQueryMssqlTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabases.
        protected void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Invoke graphql operation mssqlDatabases
            InvokeQueryMssqlDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlAvailabilityGroup.
        protected void ProcessRecord_AvailabilityGroup()
        {
            this._logger.name += " -AvailabilityGroup";
            // Invoke graphql operation mssqlAvailabilityGroup
            InvokeQueryMssqlAvailabilityGroup();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlInstance.
        protected void ProcessRecord_Instance()
        {
            this._logger.name += " -Instance";
            // Invoke graphql operation mssqlInstance
            InvokeQueryMssqlInstance();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabase.
        protected void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Invoke graphql operation mssqlDatabase
            InvokeQueryMssqlDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlRecoverableRanges.
        protected void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Invoke graphql operation mssqlRecoverableRanges
            InvokeQueryMssqlRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedSnapshots.
        protected void ProcessRecord_DatabaseMissedSnapshots()
        {
            this._logger.name += " -DatabaseMissedSnapshots";
            // Invoke graphql operation mssqlDatabaseMissedSnapshots
            InvokeQueryMssqlDatabaseMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlCompatibleInstances.
        protected void ProcessRecord_CompatibleInstances()
        {
            this._logger.name += " -CompatibleInstances";
            // Invoke graphql operation mssqlCompatibleInstances
            InvokeQueryMssqlCompatibleInstances();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedRecoverableRanges.
        protected void ProcessRecord_DatabaseMissedRecoverableRanges()
        {
            this._logger.name += " -DatabaseMissedRecoverableRanges";
            // Invoke graphql operation mssqlDatabaseMissedRecoverableRanges
            InvokeQueryMssqlDatabaseMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // allMssqlDatabaseRestoreFiles.
        protected void ProcessRecord_AllDatabaseRestoreFiles()
        {
            this._logger.name += " -AllDatabaseRestoreFiles";
            // Invoke graphql operation allMssqlDatabaseRestoreFiles
            InvokeQueryAllMssqlDatabaseRestoreFiles();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseLiveMounts.
        protected void ProcessRecord_DatabaseLiveMounts()
        {
            this._logger.name += " -DatabaseLiveMounts";
            // Invoke graphql operation mssqlDatabaseLiveMounts
            InvokeQueryMssqlDatabaseLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDefaultProperties.
        protected void ProcessRecord_DefaultProperties()
        {
            this._logger.name += " -DefaultProperties";
            // Invoke graphql operation mssqlDefaultProperties
            InvokeQueryMssqlDefaultProperties();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseRestoreEstimate.
        protected void ProcessRecord_DatabaseRestoreEstimate()
        {
            this._logger.name += " -DatabaseRestoreEstimate";
            // Invoke graphql operation mssqlDatabaseRestoreEstimate
            InvokeQueryMssqlDatabaseRestoreEstimate();
        }

        // This parameter set invokes a single graphql operation:
        // cdmMssqlLogShippingTargets.
        protected void ProcessRecord_CdmLogShippingTargets()
        {
            this._logger.name += " -CdmLogShippingTargets";
            // Invoke graphql operation cdmMssqlLogShippingTargets
            InvokeQueryCdmMssqlLogShippingTargets();
        }

        // This parameter set invokes a single graphql operation:
        // cdmMssqlLogShippingTarget.
        protected void ProcessRecord_CdmLogShippingTarget()
        {
            this._logger.name += " -CdmLogShippingTarget";
            // Invoke graphql operation cdmMssqlLogShippingTarget
            InvokeQueryCdmMssqlLogShippingTarget();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlLogShippingTargets.
        protected void ProcessRecord_LogShippingTargets()
        {
            this._logger.name += " -LogShippingTargets";
            // Invoke graphql operation mssqlLogShippingTargets
            InvokeQueryMssqlLogShippingTargets();
        }


        // Invoke GraphQL Query:
        // mssqlTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): MssqlTopLevelDescendantTypeConnection!
        protected void InvokeQueryMssqlTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MssqlTopLevelDescendantTypeConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlTopLevelDescendants(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                fieldSpecDoc,
                "MssqlTopLevelDescendantTypeConnection"
            );
        }

        // Invoke GraphQL Query:
        // mssqlDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): MssqlDatabaseConnection!
        protected void InvokeQueryMssqlDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            MssqlDatabaseConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlDatabaseConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlDatabaseConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlDatabases(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "MssqlDatabaseConnection"
            );
        }

        // Invoke GraphQL Query:
        // mssqlAvailabilityGroup(fid: UUID!): MssqlAvailabilityGroup!
        protected void InvokeQueryMssqlAvailabilityGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlAvailabilityGroup? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlAvailabilityGroup)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlAvailabilityGroup)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlAvailabilityGroup(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlAvailabilityGroup",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MssqlAvailabilityGroup"
            );
        }

        // Invoke GraphQL Query:
        // mssqlInstance(fid: UUID!): MssqlInstance!
        protected void InvokeQueryMssqlInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlInstance? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlInstance)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlInstance)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlInstance(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlInstance",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MssqlInstance"
            );
        }

        // Invoke GraphQL Query:
        // mssqlDatabase(fid: UUID!): MssqlDatabase!
        protected void InvokeQueryMssqlDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlDatabase? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlDatabase)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlDatabase)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlDatabase(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlDatabase",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MssqlDatabase"
            );
        }

        // Invoke GraphQL Query:
        // mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!): MssqlRecoverableRangeListResponse!
        protected void InvokeQueryMssqlRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbRecoverableRangesInput!"),
            };
            MssqlRecoverableRangeListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlRecoverableRangeListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlRecoverableRanges(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlRecoverableRanges",
                "($input: GetMssqlDbRecoverableRangesInput!)",
                fieldSpecDoc,
                "MssqlRecoverableRangeListResponse"
            );
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!): MissedSnapshotListResponse!
        protected void InvokeQueryMssqlDatabaseMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedMssqlDbSnapshotsInput!"),
            };
            MissedSnapshotListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MissedSnapshotListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MissedSnapshotListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlDatabaseMissedSnapshots(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlDatabaseMissedSnapshots",
                "($input: GetMissedMssqlDbSnapshotsInput!)",
                fieldSpecDoc,
                "MissedSnapshotListResponse"
            );
        }

        // Invoke GraphQL Query:
        // mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!): MssqlInstanceSummaryListResponse!
        protected void InvokeQueryMssqlCompatibleInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCompatibleMssqlInstancesV1Input!"),
            };
            MssqlInstanceSummaryListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlInstanceSummaryListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlInstanceSummaryListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlCompatibleInstances(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlCompatibleInstances",
                "($input: GetCompatibleMssqlInstancesV1Input!)",
                fieldSpecDoc,
                "MssqlInstanceSummaryListResponse"
            );
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!): MssqlMissedRecoverableRangeListResponse!
        protected void InvokeQueryMssqlDatabaseMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbMissedRecoverableRangesInput!"),
            };
            MssqlMissedRecoverableRangeListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlMissedRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlMissedRecoverableRangeListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlDatabaseMissedRecoverableRanges(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlDatabaseMissedRecoverableRanges",
                "($input: GetMssqlDbMissedRecoverableRangesInput!)",
                fieldSpecDoc,
                "MssqlMissedRecoverableRangeListResponse"
            );
        }

        // Invoke GraphQL Query:
        // allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!): V1MssqlGetRestoreFilesV1Response!
        protected void InvokeQueryAllMssqlDatabaseRestoreFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlGetRestoreFilesV1Input!"),
            };
            V1MssqlGetRestoreFilesV1Response? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (V1MssqlGetRestoreFilesV1Response)psObject.BaseObject;
                } else {
                    fieldSpecObj = (V1MssqlGetRestoreFilesV1Response)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllMssqlDatabaseRestoreFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllMssqlDatabaseRestoreFiles",
                "($input: MssqlGetRestoreFilesV1Input!)",
                fieldSpecDoc,
                "V1MssqlGetRestoreFilesV1Response"
            );
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseLiveMounts(
        //     first: Int
        //     after: String
        //     sortBy: MssqlDatabaseLiveMountSortByInput
        //     filters: [MssqlDatabaseLiveMountFilterInput!]
        //   ): MssqlDatabaseLiveMountConnection!
        protected void InvokeQueryMssqlDatabaseLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlDatabaseLiveMountSortByInput"),
                Tuple.Create("filters", "[MssqlDatabaseLiveMountFilterInput!]"),
            };
            MssqlDatabaseLiveMountConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlDatabaseLiveMountConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlDatabaseLiveMountConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlDatabaseLiveMounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlDatabaseLiveMounts",
                "($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])",
                fieldSpecDoc,
                "MssqlDatabaseLiveMountConnection"
            );
        }

        // Invoke GraphQL Query:
        // mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!): UpdateMssqlDefaultPropertiesReply!
        protected void InvokeQueryMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultDbPropertiesV1Input!"),
            };
            UpdateMssqlDefaultPropertiesReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateMssqlDefaultPropertiesReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateMssqlDefaultPropertiesReply)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlDefaultProperties(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlDefaultProperties",
                "($input: GetDefaultDbPropertiesV1Input!)",
                fieldSpecDoc,
                "UpdateMssqlDefaultPropertiesReply"
            );
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!): MssqlRestoreEstimateResult!
        protected void InvokeQueryMssqlDatabaseRestoreEstimate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlRestoreEstimateV1Input!"),
            };
            MssqlRestoreEstimateResult? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlRestoreEstimateResult)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlRestoreEstimateResult)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlDatabaseRestoreEstimate(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlDatabaseRestoreEstimate",
                "($input: MssqlRestoreEstimateV1Input!)",
                fieldSpecDoc,
                "MssqlRestoreEstimateResult"
            );
        }

        // Invoke GraphQL Query:
        // cdmMssqlLogShippingTargets(
        //     first: Int
        //     after: String
        //     sortBy: MssqlLogShippingTargetSortByInput
        //     filters: [MssqlLogShippingTargetFilterInput!]
        //   ): MssqlLogShippingTargetConnection!
        protected void InvokeQueryCdmMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlLogShippingTargetSortByInput"),
                Tuple.Create("filters", "[MssqlLogShippingTargetFilterInput!]"),
            };
            MssqlLogShippingTargetConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlLogShippingTargetConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlLogShippingTargetConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.CdmMssqlLogShippingTargets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCdmMssqlLogShippingTargets",
                "($first: Int,$after: String,$sortBy: MssqlLogShippingTargetSortByInput,$filters: [MssqlLogShippingTargetFilterInput!])",
                fieldSpecDoc,
                "MssqlLogShippingTargetConnection"
            );
        }

        // Invoke GraphQL Query:
        // cdmMssqlLogShippingTarget(fid: UUID!): MssqlLogShippingTarget
        protected void InvokeQueryCdmMssqlLogShippingTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlLogShippingTarget? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlLogShippingTarget)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlLogShippingTarget)this.Field;
                }
            }
            string fieldSpecDoc = Query.CdmMssqlLogShippingTarget(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryCdmMssqlLogShippingTarget",
                "($fid: UUID!)",
                fieldSpecDoc,
                "MssqlLogShippingTarget"
            );
        }

        // Invoke GraphQL Query:
        // mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!): MssqlLogShippingSummaryV2ListResponse
        protected void InvokeQueryMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogShippingConfigurationsV2Input!"),
            };
            MssqlLogShippingSummaryV2ListResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (MssqlLogShippingSummaryV2ListResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (MssqlLogShippingSummaryV2ListResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.MssqlLogShippingTargets(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryMssqlLogShippingTargets",
                "($input: QueryLogShippingConfigurationsV2Input!)",
                fieldSpecDoc,
                "MssqlLogShippingSummaryV2ListResponse"
            );
        }


    } // class Invoke_RscQueryMssql
}