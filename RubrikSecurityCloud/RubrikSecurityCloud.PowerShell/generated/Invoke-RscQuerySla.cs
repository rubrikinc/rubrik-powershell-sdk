// Invoke-RscQuerySla.cs
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
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQuerySla",
        DefaultParameterSetName = "Domain")
    ]
    public class Invoke_RscQuerySla : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Domain parameter set
        //
        // GraphQL operation: slaDomains(,   first: Int,   after: String,   last: Int,   before: String,   sortBy: SlaQuerySortByField,   sortOrder: SortOrder,   filter: [GlobalSlaFilterInput!],   contextFilter: ContextFilterTypeEnum,   contextFilterInput: [ContextFilterInputField!],   shouldShowSyncStatus: Boolean = false,   shouldShowProtectedObjectCount: Boolean = false,   shouldShowUpgradeInfo: Boolean = false,   showRemoteSlas: Boolean,   shouldShowPausedClusters: Boolean = false, ):SlaDomainConnection!
        //
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: slaDomains(,   first: Int,   after: String,   last: Int,   before: String,   sortBy: SlaQuerySortByField,   sortOrder: SortOrder,   filter: [GlobalSlaFilterInput!],   contextFilter: ContextFilterTypeEnum,   contextFilterInput: [ContextFilterInputField!],   shouldShowSyncStatus: Boolean = false,   shouldShowProtectedObjectCount: Boolean = false,   shouldShowUpgradeInfo: Boolean = false,   showRemoteSlas: Boolean,   shouldShowPausedClusters: Boolean = false, ):SlaDomainConnection!",
            Position = 0
        )]
        public SwitchParameter Domain { get; set; }

        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: SlaQuerySortByField"
        )]
        public SlaQuerySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filter: [GlobalSlaFilterInput!]"
        )]
        public List<GlobalSlaFilterInput>? Filter { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument contextFilter: ContextFilterTypeEnum"
        )]
        public ContextFilterTypeEnum? ContextFilter { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument contextFilterInput: [ContextFilterInputField!]"
        )]
        public List<ContextFilterInputField>? ContextFilterInput { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument shouldShowSyncStatus: Boolean"
        )]
        public System.Boolean? ShouldShowSyncStatus { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument shouldShowProtectedObjectCount: Boolean"
        )]
        public System.Boolean? ShouldShowProtectedObjectCount { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument shouldShowUpgradeInfo: Boolean"
        )]
        public System.Boolean? ShouldShowUpgradeInfo { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument showRemoteSlas: Boolean"
        )]
        public System.Boolean? ShowRemoteSlas { get; set; }
        [Parameter(
            ParameterSetName = "Domain",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument shouldShowPausedClusters: Boolean"
        )]
        public System.Boolean? ShouldShowPausedClusters { get; set; }
        
        // -------------------------------------------------------------------
        // countOfObjectsProtected parameter set
        //
        // GraphQL operation: countOfObjectsProtectedBySlas(,   rootOptionalFid: UUID,   slaIds: [UUID!]!,   filter: [Filter!],   typeFilter: [HierarchyObjectTypeEnum!], ):CountOfObjectsProtectedBySLAsResult!
        //
        [Parameter(
            ParameterSetName = "countOfObjectsProtected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: countOfObjectsProtectedBySlas(,   rootOptionalFid: UUID,   slaIds: [UUID!]!,   filter: [Filter!],   typeFilter: [HierarchyObjectTypeEnum!], ):CountOfObjectsProtectedBySLAsResult!",
            Position = 0
        )]
        public SwitchParameter countOfObjectsProtected { get; set; }

        [Parameter(
            ParameterSetName = "countOfObjectsProtected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument rootOptionalFid: UUID"
        )]
        public System.String? RootOptionalFid { get; set; }
        [Parameter(
            ParameterSetName = "countOfObjectsProtected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument slaIds: [UUID!]!"
        )]
        public List<System.String>? SlaIds { get; set; }
        [Parameter(
            ParameterSetName = "countOfObjectsProtected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]"
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        
        // -------------------------------------------------------------------
        // AuditDetail parameter set
        //
        // GraphQL operation: slaAuditDetail(,   first: Int,   after: String,   last: Int,   before: String,   SlaId: UUID!,   filter: [SLAAuditDetailFilterInput!],   timezone: String, ):[SlaAuditDetail!]!
        //
        [Parameter(
            ParameterSetName = "AuditDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: slaAuditDetail(,   first: Int,   after: String,   last: Int,   before: String,   SlaId: UUID!,   filter: [SLAAuditDetailFilterInput!],   timezone: String, ):[SlaAuditDetail!]!",
            Position = 0
        )]
        public SwitchParameter AuditDetail { get; set; }

        [Parameter(
            ParameterSetName = "AuditDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument SlaId: UUID!"
        )]
        public System.String? SlaId { get; set; }
        [Parameter(
            ParameterSetName = "AuditDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument timezone: String"
        )]
        public System.String? Timezone { get; set; }
        
        // -------------------------------------------------------------------
        // ConflictObject parameter set
        //
        // GraphQL operation: slaConflictObjects(fids: [UUID!]!):[HierarchyObject!]!
        //
        [Parameter(
            ParameterSetName = "ConflictObject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: slaConflictObjects(fids: [UUID!]!):[HierarchyObject!]!",
            Position = 0
        )]
        public SwitchParameter ConflictObject { get; set; }

        [Parameter(
            ParameterSetName = "ConflictObject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument fids: [UUID!]!"
        )]
        public List<System.String>? Fids { get; set; }
        
        // -------------------------------------------------------------------
        // ManagedVolume parameter set
        //
        // GraphQL operation: slaManagedVolumes(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):ManagedVolumeConnection!
        //
        [Parameter(
            ParameterSetName = "ManagedVolume",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: slaManagedVolumes(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):ManagedVolumeConnection!",
            Position = 0
        )]
        public SwitchParameter ManagedVolume { get; set; }

        
        // -------------------------------------------------------------------
        // allClusterGlobal parameter set
        //
        // GraphQL operation: allClusterGlobalSlas(cdmClusterUUID: UUID!):[SlaInfo!]!
        //
        [Parameter(
            ParameterSetName = "allClusterGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allClusterGlobalSlas(cdmClusterUUID: UUID!):[SlaInfo!]!",
            Position = 0
        )]
        public SwitchParameter allClusterGlobal { get; set; }

        [Parameter(
            ParameterSetName = "allClusterGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cdmClusterUUID: UUID!"
        )]
        public System.String? CdmClusterUuid { get; set; }
        
        // -------------------------------------------------------------------
        // allNcdComplianceData parameter set
        //
        // GraphQL operation: allNcdSlaComplianceData(clusters: [UUID!]!):[NcdSlaComplianceData!]!
        //
        [Parameter(
            ParameterSetName = "allNcdComplianceData",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allNcdSlaComplianceData(clusters: [UUID!]!):[NcdSlaComplianceData!]!",
            Position = 0
        )]
        public SwitchParameter allNcdComplianceData { get; set; }

        [Parameter(
            ParameterSetName = "allNcdComplianceData",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument clusters: [UUID!]!"
        )]
        public List<System.String>? Clusters { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "countOfObjectsProtected":
                        this.ProcessRecord_countOfObjectsProtected();
                        break;
                    case "AuditDetail":
                        this.ProcessRecord_AuditDetail();
                        break;
                    case "ConflictObject":
                        this.ProcessRecord_ConflictObject();
                        break;
                    case "ManagedVolume":
                        this.ProcessRecord_ManagedVolume();
                        break;
                    case "allClusterGlobal":
                        this.ProcessRecord_allClusterGlobal();
                        break;
                    case "allNcdComplianceData":
                        this.ProcessRecord_allNcdComplianceData();
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
                    "Invoke-RscQuerySla",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // slaDomains.
        protected void ProcessRecord_Domain()
        {
            this._logger.name += " -Domain";
            // Invoke graphql operation slaDomains
            InvokeQuerySlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // countOfObjectsProtectedBySlas.
        protected void ProcessRecord_countOfObjectsProtected()
        {
            this._logger.name += " -countOfObjectsProtected";
            // Invoke graphql operation countOfObjectsProtectedBySlas
            InvokeQueryCountOfObjectsProtectedBySlas();
        }

        // This parameter set invokes a single graphql operation:
        // slaAuditDetail.
        protected void ProcessRecord_AuditDetail()
        {
            this._logger.name += " -AuditDetail";
            // Invoke graphql operation slaAuditDetail
            InvokeQuerySlaAuditDetail();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjects.
        protected void ProcessRecord_ConflictObject()
        {
            this._logger.name += " -ConflictObject";
            // Invoke graphql operation slaConflictObjects
            InvokeQuerySlaConflictObjects();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolumes.
        protected void ProcessRecord_ManagedVolume()
        {
            this._logger.name += " -ManagedVolume";
            // Invoke graphql operation slaManagedVolumes
            InvokeQuerySlaManagedVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        protected void ProcessRecord_allClusterGlobal()
        {
            this._logger.name += " -allClusterGlobal";
            // Invoke graphql operation allClusterGlobalSlas
            InvokeQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdSlaComplianceData.
        protected void ProcessRecord_allNcdComplianceData()
        {
            this._logger.name += " -allNcdComplianceData";
            // Invoke graphql operation allNcdSlaComplianceData
            InvokeQueryAllNcdSlaComplianceData();
        }


        // Invoke GraphQL Query:
        // slaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomainConnection!
        protected void InvokeQuerySlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            SlaDomainConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (SlaDomainConnection)psObject.BaseObject;
                } else {
                    fields = (SlaDomainConnection)this.Field;
                }
            }
            string document = Query.SlaDomains(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaDomains");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaDomains" + parameters + "{" + document + "}",
                OperationName = "QuerySlaDomains",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<SlaDomainConnection> task = this._rbkClient.InvokeGenericCallAsync<SlaDomainConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // countOfObjectsProtectedBySlas(
        //     rootOptionalFid: UUID
        //     slaIds: [UUID!]!
        //     filter: [Filter!]
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //   ): CountOfObjectsProtectedBySLAsResult!
        protected void InvokeQueryCountOfObjectsProtectedBySlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootOptionalFid", "UUID"),
                Tuple.Create("slaIds", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
            };
            CountOfObjectsProtectedBySlAsResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CountOfObjectsProtectedBySlAsResult)psObject.BaseObject;
                } else {
                    fields = (CountOfObjectsProtectedBySlAsResult)this.Field;
                }
            }
            string document = Query.CountOfObjectsProtectedBySlas(ref fields);
            this._input.Initialize(argDefs, fields, "Query.CountOfObjectsProtectedBySlas");
            string parameters = "($rootOptionalFid: UUID,$slaIds: [UUID!]!,$filter: [Filter!],$typeFilter: [HierarchyObjectTypeEnum!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCountOfObjectsProtectedBySlas" + parameters + "{" + document + "}",
                OperationName = "QueryCountOfObjectsProtectedBySlas",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CountOfObjectsProtectedBySlAsResult> task = this._rbkClient.InvokeGenericCallAsync<CountOfObjectsProtectedBySlAsResult>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // slaAuditDetail(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     SlaId: UUID!
        //     filter: [SLAAuditDetailFilterInput!]
        //     timezone: String
        //   ): [SlaAuditDetail!]!
        protected void InvokeQuerySlaAuditDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("SlaId", "UUID!"),
                Tuple.Create("filter", "[SLAAuditDetailFilterInput!]"),
                Tuple.Create("timezone", "String"),
            };
            List<SlaAuditDetail>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<SlaAuditDetail>)psObject.BaseObject;
                } else {
                    fields = (List<SlaAuditDetail>)this.Field;
                }
            }
            string document = Query.SlaAuditDetail(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaAuditDetail");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$SlaId: UUID!,$filter: [SLAAuditDetailFilterInput!],$timezone: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaAuditDetail" + parameters + "{" + document + "}",
                OperationName = "QuerySlaAuditDetail",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<SlaAuditDetail>> task = this._rbkClient.InvokeGenericCallAsync<List<SlaAuditDetail>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
        protected void InvokeQuerySlaConflictObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            List<HierarchyObject>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<HierarchyObject>)psObject.BaseObject;
                } else {
                    fields = (List<HierarchyObject>)this.Field;
                }
            }
            string document = Query.SlaConflictObjects(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaConflictObjects");
            string parameters = "($fids: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaConflictObjects" + parameters + "{" + document + "}",
                OperationName = "QuerySlaConflictObjects",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<HierarchyObject>> task = this._rbkClient.InvokeGenericCallAsync<List<HierarchyObject>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // slaManagedVolumes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ManagedVolumeConnection!
        protected void InvokeQuerySlaManagedVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            ManagedVolumeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ManagedVolumeConnection)psObject.BaseObject;
                } else {
                    fields = (ManagedVolumeConnection)this.Field;
                }
            }
            string document = Query.SlaManagedVolumes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.SlaManagedVolumes");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QuerySlaManagedVolumes" + parameters + "{" + document + "}",
                OperationName = "QuerySlaManagedVolumes",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ManagedVolumeConnection> task = this._rbkClient.InvokeGenericCallAsync<ManagedVolumeConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        protected void InvokeQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            List<SlaInfo>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<SlaInfo>)psObject.BaseObject;
                } else {
                    fields = (List<SlaInfo>)this.Field;
                }
            }
            string document = Query.AllClusterGlobalSlas(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClusterGlobalSlas");
            string parameters = "($cdmClusterUUID: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClusterGlobalSlas" + parameters + "{" + document + "}",
                OperationName = "QueryAllClusterGlobalSlas",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<SlaInfo>> task = this._rbkClient.InvokeGenericCallAsync<List<SlaInfo>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
        protected void InvokeQueryAllNcdSlaComplianceData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            List<NcdSlaComplianceData>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<NcdSlaComplianceData>)psObject.BaseObject;
                } else {
                    fields = (List<NcdSlaComplianceData>)this.Field;
                }
            }
            string document = Query.AllNcdSlaComplianceData(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllNcdSlaComplianceData");
            string parameters = "($clusters: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllNcdSlaComplianceData" + parameters + "{" + document + "}",
                OperationName = "QueryAllNcdSlaComplianceData",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<NcdSlaComplianceData>> task = this._rbkClient.InvokeGenericCallAsync<List<NcdSlaComplianceData>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQuerySla
}