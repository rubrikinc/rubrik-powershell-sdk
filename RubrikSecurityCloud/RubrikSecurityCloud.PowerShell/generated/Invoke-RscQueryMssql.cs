// Invoke-RscQueryMssql.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryMssql",
        DefaultParameterSetName = "Database")
    ]
    public class Invoke_RscQueryMssql : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // TopLevelDescendant parameter set
        //
        // GraphQL operation: mssqlTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):MssqlTopLevelDescendantTypeConnection!
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):MssqlTopLevelDescendantTypeConnection!",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendant { get; set; }

        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]"
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Database parameter set
        //
        // GraphQL operation: mssqlDatabases(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):MssqlDatabaseConnection!
        //
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlDatabases(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):MssqlDatabaseConnection!",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        // -------------------------------------------------------------------
        // AvailabilityGroup parameter set
        //
        // GraphQL operation: mssqlAvailabilityGroup(fid: UUID!):MssqlAvailabilityGroup!
        //
        [Parameter(
            ParameterSetName = "AvailabilityGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlAvailabilityGroup(fid: UUID!):MssqlAvailabilityGroup!",
            Position = 0
        )]
        public SwitchParameter AvailabilityGroup { get; set; }

        [Parameter(
            ParameterSetName = "AvailabilityGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Instance parameter set
        //
        // GraphQL operation: mssqlInstance(fid: UUID!):MssqlInstance!
        //
        [Parameter(
            ParameterSetName = "Instance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlInstance(fid: UUID!):MssqlInstance!",
            Position = 0
        )]
        public SwitchParameter Instance { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverableRange parameter set
        //
        // GraphQL operation: mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!):MssqlRecoverableRangeListResponse!
        //
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!):MssqlRecoverableRangeListResponse!",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: GetMssqlDbRecoverableRangesInput!"
        )]
        public GetMssqlDbRecoverableRangesInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // DatabaseMissedSnapshot parameter set
        //
        // GraphQL operation: mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!):MissedSnapshotListResponse!
        //
        [Parameter(
            ParameterSetName = "DatabaseMissedSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!):MissedSnapshotListResponse!",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // CompatibleInstance parameter set
        //
        // GraphQL operation: mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!):MssqlInstanceSummaryListResponse!
        //
        [Parameter(
            ParameterSetName = "CompatibleInstance",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!):MssqlInstanceSummaryListResponse!",
            Position = 0
        )]
        public SwitchParameter CompatibleInstance { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseMissedRecoverableRange parameter set
        //
        // GraphQL operation: mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!):MssqlMissedRecoverableRangeListResponse!
        //
        [Parameter(
            ParameterSetName = "DatabaseMissedRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!):MssqlMissedRecoverableRangeListResponse!",
            Position = 0
        )]
        public SwitchParameter DatabaseMissedRecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // allDatabaseRestoreFile parameter set
        //
        // GraphQL operation: allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!):V1MssqlGetRestoreFilesV1Response!
        //
        [Parameter(
            ParameterSetName = "allDatabaseRestoreFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!):V1MssqlGetRestoreFilesV1Response!",
            Position = 0
        )]
        public SwitchParameter allDatabaseRestoreFile { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseLiveMount parameter set
        //
        // GraphQL operation: mssqlDatabaseLiveMounts(,   first: Int,   after: String,   sortBy: MssqlDatabaseLiveMountSortByInput,   filters: [MssqlDatabaseLiveMountFilterInput!], ):MssqlDatabaseLiveMountConnection!
        //
        [Parameter(
            ParameterSetName = "DatabaseLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlDatabaseLiveMounts(,   first: Int,   after: String,   sortBy: MssqlDatabaseLiveMountSortByInput,   filters: [MssqlDatabaseLiveMountFilterInput!], ):MssqlDatabaseLiveMountConnection!",
            Position = 0
        )]
        public SwitchParameter DatabaseLiveMount { get; set; }

        [Parameter(
            ParameterSetName = "DatabaseLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filters: [MssqlDatabaseLiveMountFilterInput!]"
        )]
        public List<MssqlDatabaseLiveMountFilterInput>? Filters { get; set; }
        
        // -------------------------------------------------------------------
        // DefaultPropertie parameter set
        //
        // GraphQL operation: mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!):UpdateMssqlDefaultPropertiesReply!
        //
        [Parameter(
            ParameterSetName = "DefaultPropertie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!):UpdateMssqlDefaultPropertiesReply!",
            Position = 0
        )]
        public SwitchParameter DefaultPropertie { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseRestoreEstimate parameter set
        //
        // GraphQL operation: mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!):MssqlRestoreEstimateResult!
        //
        [Parameter(
            ParameterSetName = "DatabaseRestoreEstimate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!):MssqlRestoreEstimateResult!",
            Position = 0
        )]
        public SwitchParameter DatabaseRestoreEstimate { get; set; }

        
        // -------------------------------------------------------------------
        // cdmLogShippingTarget parameter set
        //
        // GraphQL operation: cdmMssqlLogShippingTargets(,   first: Int,   after: String,   sortBy: MssqlLogShippingTargetSortByInput,   filters: [MssqlLogShippingTargetFilterInput!], ):MssqlLogShippingTargetConnection!
        //
        [Parameter(
            ParameterSetName = "cdmLogShippingTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: cdmMssqlLogShippingTargets(,   first: Int,   after: String,   sortBy: MssqlLogShippingTargetSortByInput,   filters: [MssqlLogShippingTargetFilterInput!], ):MssqlLogShippingTargetConnection!",
            Position = 0
        )]
        public SwitchParameter cdmLogShippingTarget { get; set; }

        
        // -------------------------------------------------------------------
        // LogShippingTarget parameter set
        //
        // GraphQL operation: mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!):MssqlLogShippingSummaryV2ListResponse
        //
        [Parameter(
            ParameterSetName = "LogShippingTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!):MssqlLogShippingSummaryV2ListResponse",
            Position = 0
        )]
        public SwitchParameter LogShippingTarget { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendant":
                        this.ProcessRecord_TopLevelDescendant();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "AvailabilityGroup":
                        this.ProcessRecord_AvailabilityGroup();
                        break;
                    case "Instance":
                        this.ProcessRecord_Instance();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "DatabaseMissedSnapshot":
                        this.ProcessRecord_DatabaseMissedSnapshot();
                        break;
                    case "CompatibleInstance":
                        this.ProcessRecord_CompatibleInstance();
                        break;
                    case "DatabaseMissedRecoverableRange":
                        this.ProcessRecord_DatabaseMissedRecoverableRange();
                        break;
                    case "allDatabaseRestoreFile":
                        this.ProcessRecord_allDatabaseRestoreFile();
                        break;
                    case "DatabaseLiveMount":
                        this.ProcessRecord_DatabaseLiveMount();
                        break;
                    case "DefaultPropertie":
                        this.ProcessRecord_DefaultPropertie();
                        break;
                    case "DatabaseRestoreEstimate":
                        this.ProcessRecord_DatabaseRestoreEstimate();
                        break;
                    case "cdmLogShippingTarget":
                        this.ProcessRecord_cdmLogShippingTarget();
                        break;
                    case "LogShippingTarget":
                        this.ProcessRecord_LogShippingTarget();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryMssql",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // mssqlTopLevelDescendants.
        protected void ProcessRecord_TopLevelDescendant()
        {
            this._logger.name += " -TopLevelDescendant";
            // Invoke graphql operation mssqlTopLevelDescendants
            InvokeQueryMssqlTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabases.
        protected void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
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
        // mssqlRecoverableRanges.
        protected void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Invoke graphql operation mssqlRecoverableRanges
            InvokeQueryMssqlRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedSnapshots.
        protected void ProcessRecord_DatabaseMissedSnapshot()
        {
            this._logger.name += " -DatabaseMissedSnapshot";
            // Invoke graphql operation mssqlDatabaseMissedSnapshots
            InvokeQueryMssqlDatabaseMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlCompatibleInstances.
        protected void ProcessRecord_CompatibleInstance()
        {
            this._logger.name += " -CompatibleInstance";
            // Invoke graphql operation mssqlCompatibleInstances
            InvokeQueryMssqlCompatibleInstances();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseMissedRecoverableRanges.
        protected void ProcessRecord_DatabaseMissedRecoverableRange()
        {
            this._logger.name += " -DatabaseMissedRecoverableRange";
            // Invoke graphql operation mssqlDatabaseMissedRecoverableRanges
            InvokeQueryMssqlDatabaseMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // allMssqlDatabaseRestoreFiles.
        protected void ProcessRecord_allDatabaseRestoreFile()
        {
            this._logger.name += " -allDatabaseRestoreFile";
            // Invoke graphql operation allMssqlDatabaseRestoreFiles
            InvokeQueryAllMssqlDatabaseRestoreFiles();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDatabaseLiveMounts.
        protected void ProcessRecord_DatabaseLiveMount()
        {
            this._logger.name += " -DatabaseLiveMount";
            // Invoke graphql operation mssqlDatabaseLiveMounts
            InvokeQueryMssqlDatabaseLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlDefaultProperties.
        protected void ProcessRecord_DefaultPropertie()
        {
            this._logger.name += " -DefaultPropertie";
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
        protected void ProcessRecord_cdmLogShippingTarget()
        {
            this._logger.name += " -cdmLogShippingTarget";
            // Invoke graphql operation cdmMssqlLogShippingTargets
            InvokeQueryCdmMssqlLogShippingTargets();
        }

        // This parameter set invokes a single graphql operation:
        // mssqlLogShippingTargets.
        protected void ProcessRecord_LogShippingTarget()
        {
            this._logger.name += " -LogShippingTarget";
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
            MssqlTopLevelDescendantTypeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string document = Query.MssqlTopLevelDescendants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlTopLevelDescendants");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlTopLevelDescendants" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlTopLevelDescendants",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlTopLevelDescendantTypeConnection> task = this._rbkClient.InvokeGenericCallAsync<MssqlTopLevelDescendantTypeConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
            MssqlDatabaseConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlDatabaseConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlDatabaseConnection)this.Field;
                }
            }
            string document = Query.MssqlDatabases(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabases");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabases" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabases",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlDatabaseConnection> task = this._rbkClient.InvokeGenericCallAsync<MssqlDatabaseConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlAvailabilityGroup(fid: UUID!): MssqlAvailabilityGroup!
        protected void InvokeQueryMssqlAvailabilityGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlAvailabilityGroup? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlAvailabilityGroup)psObject.BaseObject;
                } else {
                    fields = (MssqlAvailabilityGroup)this.Field;
                }
            }
            string document = Query.MssqlAvailabilityGroup(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlAvailabilityGroup");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlAvailabilityGroup" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlAvailabilityGroup",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlAvailabilityGroup> task = this._rbkClient.InvokeGenericCallAsync<MssqlAvailabilityGroup>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlInstance(fid: UUID!): MssqlInstance!
        protected void InvokeQueryMssqlInstance()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            MssqlInstance? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlInstance)psObject.BaseObject;
                } else {
                    fields = (MssqlInstance)this.Field;
                }
            }
            string document = Query.MssqlInstance(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlInstance");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlInstance" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlInstance",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlInstance> task = this._rbkClient.InvokeGenericCallAsync<MssqlInstance>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlRecoverableRanges(input: GetMssqlDbRecoverableRangesInput!): MssqlRecoverableRangeListResponse!
        protected void InvokeQueryMssqlRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbRecoverableRangesInput!"),
            };
            MssqlRecoverableRangeListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlRecoverableRangeListResponse)this.Field;
                }
            }
            string document = Query.MssqlRecoverableRanges(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlRecoverableRanges");
            string parameters = "($input: GetMssqlDbRecoverableRangesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlRecoverableRanges" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlRecoverableRanges",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlRecoverableRangeListResponse> task = this._rbkClient.InvokeGenericCallAsync<MssqlRecoverableRangeListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseMissedSnapshots(input: GetMissedMssqlDbSnapshotsInput!): MissedSnapshotListResponse!
        protected void InvokeQueryMssqlDatabaseMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedMssqlDbSnapshotsInput!"),
            };
            MissedSnapshotListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MissedSnapshotListResponse)psObject.BaseObject;
                } else {
                    fields = (MissedSnapshotListResponse)this.Field;
                }
            }
            string document = Query.MssqlDatabaseMissedSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseMissedSnapshots");
            string parameters = "($input: GetMissedMssqlDbSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseMissedSnapshots" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseMissedSnapshots",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MissedSnapshotListResponse> task = this._rbkClient.InvokeGenericCallAsync<MissedSnapshotListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!): MssqlInstanceSummaryListResponse!
        protected void InvokeQueryMssqlCompatibleInstances()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCompatibleMssqlInstancesV1Input!"),
            };
            MssqlInstanceSummaryListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlInstanceSummaryListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlInstanceSummaryListResponse)this.Field;
                }
            }
            string document = Query.MssqlCompatibleInstances(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlCompatibleInstances");
            string parameters = "($input: GetCompatibleMssqlInstancesV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlCompatibleInstances" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlCompatibleInstances",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlInstanceSummaryListResponse> task = this._rbkClient.InvokeGenericCallAsync<MssqlInstanceSummaryListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!): MssqlMissedRecoverableRangeListResponse!
        protected void InvokeQueryMssqlDatabaseMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbMissedRecoverableRangesInput!"),
            };
            MssqlMissedRecoverableRangeListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlMissedRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlMissedRecoverableRangeListResponse)this.Field;
                }
            }
            string document = Query.MssqlDatabaseMissedRecoverableRanges(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseMissedRecoverableRanges");
            string parameters = "($input: GetMssqlDbMissedRecoverableRangesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseMissedRecoverableRanges" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseMissedRecoverableRanges",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlMissedRecoverableRangeListResponse> task = this._rbkClient.InvokeGenericCallAsync<MssqlMissedRecoverableRangeListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allMssqlDatabaseRestoreFiles(input: MssqlGetRestoreFilesV1Input!): V1MssqlGetRestoreFilesV1Response!
        protected void InvokeQueryAllMssqlDatabaseRestoreFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlGetRestoreFilesV1Input!"),
            };
            V1MssqlGetRestoreFilesV1Response? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (V1MssqlGetRestoreFilesV1Response)psObject.BaseObject;
                } else {
                    fields = (V1MssqlGetRestoreFilesV1Response)this.Field;
                }
            }
            string document = Query.AllMssqlDatabaseRestoreFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllMssqlDatabaseRestoreFiles");
            string parameters = "($input: MssqlGetRestoreFilesV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllMssqlDatabaseRestoreFiles" + parameters + "{" + document + "}",
                OperationName = "QueryAllMssqlDatabaseRestoreFiles",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<V1MssqlGetRestoreFilesV1Response> task = this._rbkClient.InvokeGenericCallAsync<V1MssqlGetRestoreFilesV1Response>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
            MssqlDatabaseLiveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlDatabaseLiveMountConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlDatabaseLiveMountConnection)this.Field;
                }
            }
            string document = Query.MssqlDatabaseLiveMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseLiveMounts");
            string parameters = "($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseLiveMounts" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseLiveMounts",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlDatabaseLiveMountConnection> task = this._rbkClient.InvokeGenericCallAsync<MssqlDatabaseLiveMountConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDefaultProperties(input: GetDefaultDbPropertiesV1Input!): UpdateMssqlDefaultPropertiesReply!
        protected void InvokeQueryMssqlDefaultProperties()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultDbPropertiesV1Input!"),
            };
            UpdateMssqlDefaultPropertiesReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateMssqlDefaultPropertiesReply)psObject.BaseObject;
                } else {
                    fields = (UpdateMssqlDefaultPropertiesReply)this.Field;
                }
            }
            string document = Query.MssqlDefaultProperties(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDefaultProperties");
            string parameters = "($input: GetDefaultDbPropertiesV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDefaultProperties" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDefaultProperties",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateMssqlDefaultPropertiesReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateMssqlDefaultPropertiesReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlDatabaseRestoreEstimate(input: MssqlRestoreEstimateV1Input!): MssqlRestoreEstimateResult!
        protected void InvokeQueryMssqlDatabaseRestoreEstimate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MssqlRestoreEstimateV1Input!"),
            };
            MssqlRestoreEstimateResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlRestoreEstimateResult)psObject.BaseObject;
                } else {
                    fields = (MssqlRestoreEstimateResult)this.Field;
                }
            }
            string document = Query.MssqlDatabaseRestoreEstimate(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlDatabaseRestoreEstimate");
            string parameters = "($input: MssqlRestoreEstimateV1Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlDatabaseRestoreEstimate" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlDatabaseRestoreEstimate",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlRestoreEstimateResult> task = this._rbkClient.InvokeGenericCallAsync<MssqlRestoreEstimateResult>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
            MssqlLogShippingTargetConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlLogShippingTargetConnection)psObject.BaseObject;
                } else {
                    fields = (MssqlLogShippingTargetConnection)this.Field;
                }
            }
            string document = Query.CdmMssqlLogShippingTargets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CdmMssqlLogShippingTargets");
            string parameters = "($first: Int,$after: String,$sortBy: MssqlLogShippingTargetSortByInput,$filters: [MssqlLogShippingTargetFilterInput!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCdmMssqlLogShippingTargets" + parameters + "{" + document + "}",
                OperationName = "QueryCdmMssqlLogShippingTargets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlLogShippingTargetConnection> task = this._rbkClient.InvokeGenericCallAsync<MssqlLogShippingTargetConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // mssqlLogShippingTargets(input: QueryLogShippingConfigurationsV2Input!): MssqlLogShippingSummaryV2ListResponse
        protected void InvokeQueryMssqlLogShippingTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryLogShippingConfigurationsV2Input!"),
            };
            MssqlLogShippingSummaryV2ListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MssqlLogShippingSummaryV2ListResponse)psObject.BaseObject;
                } else {
                    fields = (MssqlLogShippingSummaryV2ListResponse)this.Field;
                }
            }
            string document = Query.MssqlLogShippingTargets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.MssqlLogShippingTargets");
            string parameters = "($input: QueryLogShippingConfigurationsV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryMssqlLogShippingTargets" + parameters + "{" + document + "}",
                OperationName = "QueryMssqlLogShippingTargets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MssqlLogShippingSummaryV2ListResponse> task = this._rbkClient.InvokeGenericCallAsync<MssqlLogShippingSummaryV2ListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryMssql
}