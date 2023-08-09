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
            VsphereVm? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereVm)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereVm)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVmNew(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVmNew",
                "($fid: UUID!)",
                fieldSpecDoc,
                "VsphereVm"
            );
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
            VsphereVmConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereVmConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereVmConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVmNewConnection(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVmNewConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                fieldSpecDoc,
                "VsphereVmConnection"
            );
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
            RecoverableRangeResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RecoverableRangeResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVmRecoverableRange(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVmRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                fieldSpecDoc,
                "RecoverableRangeResponse"
            );
        }

        // Invoke GraphQL Query:
        // vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!): BatchVmwareVmRecoverableRanges!
        protected void InvokeQueryVsphereVmRecoverableRangeInBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("requestInfo", "BatchVmwareVmRecoverableRangesRequestInput!"),
            };
            BatchVmwareVmRecoverableRanges? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchVmwareVmRecoverableRanges)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchVmwareVmRecoverableRanges)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVmRecoverableRangeInBatch(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVmRecoverableRangeInBatch",
                "($requestInfo: BatchVmwareVmRecoverableRangesRequestInput!)",
                fieldSpecDoc,
                "BatchVmwareVmRecoverableRanges"
            );
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
            RecoverableRangeResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RecoverableRangeResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVmMissedRecoverableRange(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVmMissedRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                fieldSpecDoc,
                "RecoverableRangeResponse"
            );
        }

        // Invoke GraphQL Query:
        // vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!): AsyncRequestStatus!
        protected void InvokeQueryVsphereVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("id", "String!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Query.VsphereVmAsyncRequestStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryVsphereVmAsyncRequestStatus",
                "($clusterUuid: UUID!,$id: String!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }


    } // class Invoke_RscQueryVsphereVm
}