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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
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
        // GraphQL operation: vSphereVmNew(fid: UUID!):VsphereVm!
        //
        [Parameter(
            ParameterSetName = "New",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vSphereVmNew(fid: UUID!):VsphereVm!
                ",
            Position = 0
        )]
        public SwitchParameter New { get; set; }

        [Parameter(
            ParameterSetName = "New",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The Rubrik UUID for the object.
                GraphQL argument fid: UUID!
                "
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // NewList parameter set
        //
        // GraphQL operation: vSphereVmNewConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVmConnection!
        //
        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vSphereVmNewConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVmConnection!
                ",
            Position = 0
        )]
        public SwitchParameter NewList { get; set; }

        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the first n elements from the list.
                GraphQL argument first: Int
                "
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come after the specified cursor.
                GraphQL argument after: String
                "
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sort hierarchy objects by hierarchy field.
                GraphQL argument sortBy: HierarchySortByField
                "
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sorting order for the results.
                GraphQL argument sortOrder: SortOrder
                "
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The hierarchy object filter.
                GraphQL argument filter: [Filter!]
                "
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // RecoverableRange parameter set
        //
        // GraphQL operation: vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!
        //
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!
                ",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument snappableFid: UUID!
                "
        )]
        public System.String? SnappableFid { get; set; }
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument beforeTime: DateTime
                "
        )]
        public DateTime? BeforeTime { get; set; }
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument afterTime: DateTime
                "
        )]
        public DateTime? AfterTime { get; set; }
        
        // -------------------------------------------------------------------
        // RecoverableRangeInBatch parameter set
        //
        // GraphQL operation: vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!):BatchVmwareVmRecoverableRanges!
        //
        [Parameter(
            ParameterSetName = "RecoverableRangeInBatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!):BatchVmwareVmRecoverableRanges!
                ",
            Position = 0
        )]
        public SwitchParameter RecoverableRangeInBatch { get; set; }

        [Parameter(
            ParameterSetName = "RecoverableRangeInBatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The batch request, which includes the ID of each CDP-enabled virtual machine for which recoverable ranges are being retrieved, and optionally the date ranges as a filter.
                GraphQL argument requestInfo: BatchVmwareVmRecoverableRangesRequestInput!
                "
        )]
        public BatchVmwareVmRecoverableRangesRequestInput? RequestInfo { get; set; }
        
        // -------------------------------------------------------------------
        // MissedRecoverableRange parameter set
        //
        // GraphQL operation: vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!
        //
        [Parameter(
            ParameterSetName = "MissedRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!
                ",
            Position = 0
        )]
        public SwitchParameter MissedRecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // AsyncRequestStatus parameter set
        //
        // GraphQL operation: vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "AsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter AsyncRequestStatus { get; set; }

        [Parameter(
            ParameterSetName = "AsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument clusterUuid: UUID!
                "
        )]
        public System.String? ClusterUuid { get; set; }
        [Parameter(
            ParameterSetName = "AsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                ID of an asynchronous request.
                GraphQL argument id: String!
                "
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
                    case "NewList":
                        this.ProcessRecord_NewList();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "RecoverableRangeInBatch":
                        this.ProcessRecord_RecoverableRangeInBatch();
                        break;
                    case "MissedRecoverableRange":
                        this.ProcessRecord_MissedRecoverableRange();
                        break;
                    case "AsyncRequestStatus":
                        this.ProcessRecord_AsyncRequestStatus();
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
                    "Invoke-RscQueryVsphereVm",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
        protected void ProcessRecord_NewList()
        {
            this._logger.name += " -NewList";
            // Invoke graphql operation vSphereVmNewConnection
            InvokeQueryVsphereVmNewConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRange.
        protected void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Invoke graphql operation vsphereVMRecoverableRange
            InvokeQueryVsphereVmRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRangeInBatch.
        protected void ProcessRecord_RecoverableRangeInBatch()
        {
            this._logger.name += " -RecoverableRangeInBatch";
            // Invoke graphql operation vsphereVMRecoverableRangeInBatch
            InvokeQueryVsphereVmRecoverableRangeInBatch();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMMissedRecoverableRange.
        protected void ProcessRecord_MissedRecoverableRange()
        {
            this._logger.name += " -MissedRecoverableRange";
            // Invoke graphql operation vsphereVMMissedRecoverableRange
            InvokeQueryVsphereVmMissedRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVMAsyncRequestStatus.
        protected void ProcessRecord_AsyncRequestStatus()
        {
            this._logger.name += " -AsyncRequestStatus";
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVm)psObject.BaseObject;
                } else {
                    fields = (VsphereVm)this.Field;
                }
            }
            string document = Query.VsphereVmNew(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmNew");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmNew" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmNew",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVm> task = this._rbkClient.InvokeGenericCallAsync<VsphereVm>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVmConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereVmConnection)this.Field;
                }
            }
            string document = Query.VsphereVmNewConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmNewConnection");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmNewConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmNewConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVmConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereVmConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fields = (RecoverableRangeResponse)this.Field;
                }
            }
            string document = Query.VsphereVmRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmRecoverableRange");
            string parameters = "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmRecoverableRange",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RecoverableRangeResponse> task = this._rbkClient.InvokeGenericCallAsync<RecoverableRangeResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchVmwareVmRecoverableRanges)psObject.BaseObject;
                } else {
                    fields = (BatchVmwareVmRecoverableRanges)this.Field;
                }
            }
            string document = Query.VsphereVmRecoverableRangeInBatch(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmRecoverableRangeInBatch");
            string parameters = "($requestInfo: BatchVmwareVmRecoverableRangesRequestInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmRecoverableRangeInBatch" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmRecoverableRangeInBatch",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchVmwareVmRecoverableRanges> task = this._rbkClient.InvokeGenericCallAsync<BatchVmwareVmRecoverableRanges>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fields = (RecoverableRangeResponse)this.Field;
                }
            }
            string document = Query.VsphereVmMissedRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmMissedRecoverableRange");
            string parameters = "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmMissedRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmMissedRecoverableRange",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RecoverableRangeResponse> task = this._rbkClient.InvokeGenericCallAsync<RecoverableRangeResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.VsphereVmAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmAsyncRequestStatus");
            string parameters = "($clusterUuid: UUID!,$id: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmAsyncRequestStatus",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryVsphereVm
}