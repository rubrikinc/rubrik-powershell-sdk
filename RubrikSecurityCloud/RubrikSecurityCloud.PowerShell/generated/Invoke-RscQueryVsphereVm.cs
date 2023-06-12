// Invoke-RscQueryVsphereVm.cs
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
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryVsphereVm",
        DefaultParameterSetName = "New")
    ]
    public class Invoke_RscQueryVsphereVm : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // New parameter set
        //
        // [GraphQL: vSphereVmNew]
        //
        [Parameter(
            ParameterSetName = "New",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVmNew]",
            Position = 0
        )]
        public SwitchParameter New { get; set; }

        [Parameter(
            ParameterSetName = "New",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik UUID for the object.
GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Newconnection parameter set
        //
        // [GraphQL: vSphereVmNewConnection]
        //
        [Parameter(
            ParameterSetName = "Newconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVmNewConnection]",
            Position = 0
        )]
        public SwitchParameter Newconnection { get; set; }

        [Parameter(
            ParameterSetName = "Newconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Newconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Newconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort hierarchy objects by hierarchy field.
GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Newconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Newconnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The hierarchy object filter.
GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Recoverablerange parameter set
        //
        // [GraphQL: vsphereVMRecoverableRange]
        //
        [Parameter(
            ParameterSetName = "Recoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter Recoverablerange { get; set; }

        [Parameter(
            ParameterSetName = "Recoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument snappableFid: UUID!"
        )]
        public System.String? SnappableFid { get; set; }
        [Parameter(
            ParameterSetName = "Recoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument beforeTime: DateTime"
        )]
        public DateTime? BeforeTime { get; set; }
        [Parameter(
            ParameterSetName = "Recoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument afterTime: DateTime"
        )]
        public DateTime? AfterTime { get; set; }
        
        // -------------------------------------------------------------------
        // Recoverablerangeinbatch parameter set
        //
        // [GraphQL: vsphereVMRecoverableRangeInBatch]
        //
        [Parameter(
            ParameterSetName = "Recoverablerangeinbatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMRecoverableRangeInBatch]",
            Position = 0
        )]
        public SwitchParameter Recoverablerangeinbatch { get; set; }

        [Parameter(
            ParameterSetName = "Recoverablerangeinbatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The batch request, which includes the ID of each CDP-enabled virtual machine for which recoverable ranges are being retrieved, and optionally the date ranges as a filter.
GraphQL argument requestInfo: BatchVmwareVmRecoverableRangesRequestInput!"
        )]
        public BatchVmwareVmRecoverableRangesRequestInput? RequestInfo { get; set; }
        
        // -------------------------------------------------------------------
        // Missedrecoverablerange parameter set
        //
        // [GraphQL: vsphereVMMissedRecoverableRange]
        //
        [Parameter(
            ParameterSetName = "Missedrecoverablerange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMMissedRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter Missedrecoverablerange { get; set; }

        
        // -------------------------------------------------------------------
        // Asyncrequeststatus parameter set
        //
        // [GraphQL: vSphereVMAsyncRequestStatus]
        //
        [Parameter(
            ParameterSetName = "Asyncrequeststatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVMAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter Asyncrequeststatus { get; set; }

        [Parameter(
            ParameterSetName = "Asyncrequeststatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument clusterUuid: UUID!"
        )]
        public System.String? ClusterUuid { get; set; }
        [Parameter(
            ParameterSetName = "Asyncrequeststatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"ID of an asynchronous request.
GraphQL argument id: String!"
        )]
        public System.String? Id { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "New":
                        this.ProcessRecord_New();
                        break;
                    case "Newconnection":
                        this.ProcessRecord_Newconnection();
                        break;
                    case "Recoverablerange":
                        this.ProcessRecord_Recoverablerange();
                        break;
                    case "Recoverablerangeinbatch":
                        this.ProcessRecord_Recoverablerangeinbatch();
                        break;
                    case "Missedrecoverablerange":
                        this.ProcessRecord_Missedrecoverablerange();
                        break;
                    case "Asyncrequeststatus":
                        this.ProcessRecord_Asyncrequeststatus();
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
        // vSphereVmNew.
        protected void ProcessRecord_New()
        {
            this._logger.name += " -New";
            // Invoke graphql operation vSphereVmNew
            InvokeQueryVsphereVmNew();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVmNewConnection.
        protected void ProcessRecord_Newconnection()
        {
            this._logger.name += " -Newconnection";
            // Invoke graphql operation vSphereVmNewConnection
            InvokeQueryVsphereVmNewConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRange.
        protected void ProcessRecord_Recoverablerange()
        {
            this._logger.name += " -Recoverablerange";
            // Invoke graphql operation vsphereVMRecoverableRange
            InvokeQueryVsphereVmRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRangeInBatch.
        protected void ProcessRecord_Recoverablerangeinbatch()
        {
            this._logger.name += " -Recoverablerangeinbatch";
            // Invoke graphql operation vsphereVMRecoverableRangeInBatch
            InvokeQueryVsphereVmRecoverableRangeInBatch();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMMissedRecoverableRange.
        protected void ProcessRecord_Missedrecoverablerange()
        {
            this._logger.name += " -Missedrecoverablerange";
            // Invoke graphql operation vsphereVMMissedRecoverableRange
            InvokeQueryVsphereVmMissedRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVMAsyncRequestStatus.
        protected void ProcessRecord_Asyncrequeststatus()
        {
            this._logger.name += " -Asyncrequeststatus";
            // Invoke graphql operation vSphereVMAsyncRequestStatus
            InvokeQueryVsphereVmAsyncRequestStatus();
        }


        // Invoke GraphQL Query:
        // vSphereVmNew(fid: UUID!): VsphereVm!
        protected void InvokeQueryVsphereVmNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereVm? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereVm)psObject.BaseObject;
                } else {
                    fields = (VsphereVm)this.Field;
                }
            }
            string document = Query.VsphereVmNew(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmNew");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmNew" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmNew",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereVm", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereVmNewConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVmConnection!
        protected void InvokeQueryVsphereVmNewConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereVmConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereVmConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereVmConnection)this.Field;
                }
            }
            string document = Query.VsphereVmNewConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmNewConnection");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmNewConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmNewConnection",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereVmConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        protected void InvokeQueryVsphereVmRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            RecoverableRangeResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fields = (RecoverableRangeResponse)this.Field;
                }
            }
            string document = Query.VsphereVmRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmRecoverableRange");
            var parameters = "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmRecoverableRange",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RecoverableRangeResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!): BatchVmwareVmRecoverableRanges!
        protected void InvokeQueryVsphereVmRecoverableRangeInBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("requestInfo", "BatchVmwareVmRecoverableRangesRequestInput!"),
            };
            BatchVmwareVmRecoverableRanges? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchVmwareVmRecoverableRanges)psObject.BaseObject;
                } else {
                    fields = (BatchVmwareVmRecoverableRanges)this.Field;
                }
            }
            string document = Query.VsphereVmRecoverableRangeInBatch(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmRecoverableRangeInBatch");
            var parameters = "($requestInfo: BatchVmwareVmRecoverableRangesRequestInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmRecoverableRangeInBatch" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmRecoverableRangeInBatch",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchVmwareVmRecoverableRanges", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        protected void InvokeQueryVsphereVmMissedRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            RecoverableRangeResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fields = (RecoverableRangeResponse)this.Field;
                }
            }
            string document = Query.VsphereVmMissedRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmMissedRecoverableRange");
            var parameters = "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmMissedRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmMissedRecoverableRange",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RecoverableRangeResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!): AsyncRequestStatus!
        protected void InvokeQueryVsphereVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("id", "String!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.VsphereVmAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmAsyncRequestStatus");
            var parameters = "($clusterUuid: UUID!,$id: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmAsyncRequestStatus",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryVsphereVm
}