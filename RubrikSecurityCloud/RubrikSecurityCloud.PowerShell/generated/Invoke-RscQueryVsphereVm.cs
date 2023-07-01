// Invoke-RscQueryVsphereVm.cs
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

        
        // -------------------------------------------------------------------
        // NewList parameter set
        //
        // [GraphQL: vSphereVmNewConnection]
        //
        [Parameter(
            ParameterSetName = "NewList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVmNewConnection]",
            Position = 0
        )]
        public SwitchParameter NewList { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverableRange parameter set
        //
        // [GraphQL: vsphereVMRecoverableRange]
        //
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverableRangeInBatch parameter set
        //
        // [GraphQL: vsphereVMRecoverableRangeInBatch]
        //
        [Parameter(
            ParameterSetName = "RecoverableRangeInBatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMRecoverableRangeInBatch]",
            Position = 0
        )]
        public SwitchParameter RecoverableRangeInBatch { get; set; }

        
        // -------------------------------------------------------------------
        // MissedRecoverableRange parameter set
        //
        // [GraphQL: vsphereVMMissedRecoverableRange]
        //
        [Parameter(
            ParameterSetName = "MissedRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereVMMissedRecoverableRange]",
            Position = 0
        )]
        public SwitchParameter MissedRecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // AsyncRequestStatus parameter set
        //
        // [GraphQL: vSphereVMAsyncRequestStatus]
        //
        [Parameter(
            ParameterSetName = "AsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vSphereVMAsyncRequestStatus]",
            Position = 0
        )]
        public SwitchParameter AsyncRequestStatus { get; set; }


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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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
            var vars = new OperationVariableSet();
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