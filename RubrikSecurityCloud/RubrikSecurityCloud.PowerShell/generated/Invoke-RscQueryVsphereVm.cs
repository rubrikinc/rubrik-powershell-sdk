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
    /// <summary>
    /// vSphere VM queries
    /// </summary>
    /// <description>
    /// Invoke-RscQueryVsphereVm is a master cmdlet for VsphereVm work that can invoke any of the following subcommands: New, NewList, AsyncRequestStatus, RecoverableRange, RecoverableRangeInBatch, MissedRecoverableRange.
    /// </description>
    /// <example>
    /// <code>Invoke-RscQueryVsphereVm -New [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphereVm -NewList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphereVm -AsyncRequestStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphereVm -RecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphereVm -RecoverableRangeInBatch [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscQueryVsphereVm -MissedRecoverableRange [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscQueryVsphereVm",
        DefaultParameterSetName = "New")
    ]
    public class Invoke_RscQueryVsphereVm : RscPSCmdlet
    {
        
        /// <summary>
        /// New parameter set
        ///
        /// [GraphQL: vSphereVmNew]
        /// </summary>
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

        
        /// <summary>
        /// NewList parameter set
        ///
        /// [GraphQL: vSphereVmNewConnection]
        /// </summary>
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

        
        /// <summary>
        /// AsyncRequestStatus parameter set
        ///
        /// [GraphQL: vSphereVMAsyncRequestStatus]
        /// </summary>
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

        
        /// <summary>
        /// RecoverableRange parameter set
        ///
        /// [GraphQL: vsphereVMRecoverableRange]
        /// </summary>
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

        
        /// <summary>
        /// RecoverableRangeInBatch parameter set
        ///
        /// [GraphQL: vsphereVMRecoverableRangeInBatch]
        /// </summary>
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

        
        /// <summary>
        /// MissedRecoverableRange parameter set
        ///
        /// [GraphQL: vsphereVMMissedRecoverableRange]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
                    case "AsyncRequestStatus":
                        this.ProcessRecord_AsyncRequestStatus();
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
        // vSphereVmNew.
        internal void ProcessRecord_New()
        {
            this._logger.name += " -New";
            // Invoke graphql operation vSphereVmNew
            InvokeQueryVsphereVmNew();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVmNewConnection.
        internal void ProcessRecord_NewList()
        {
            this._logger.name += " -NewList";
            // Invoke graphql operation vSphereVmNewConnection
            InvokeQueryVsphereVmNewConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVMAsyncRequestStatus.
        internal void ProcessRecord_AsyncRequestStatus()
        {
            this._logger.name += " -AsyncRequestStatus";
            // Invoke graphql operation vSphereVMAsyncRequestStatus
            InvokeQueryVsphereVmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRange.
        internal void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Invoke graphql operation vsphereVMRecoverableRange
            InvokeQueryVsphereVmRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRangeInBatch.
        internal void ProcessRecord_RecoverableRangeInBatch()
        {
            this._logger.name += " -RecoverableRangeInBatch";
            // Invoke graphql operation vsphereVMRecoverableRangeInBatch
            InvokeQueryVsphereVmRecoverableRangeInBatch();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMMissedRecoverableRange.
        internal void ProcessRecord_MissedRecoverableRange()
        {
            this._logger.name += " -MissedRecoverableRange";
            // Invoke graphql operation vsphereVMMissedRecoverableRange
            InvokeQueryVsphereVmMissedRecoverableRange();
        }


        // Invoke GraphQL Query:
        // vSphereVmNew(fid: UUID!): VsphereVm!
        internal void InvokeQueryVsphereVmNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmNew",
                "($fid: UUID!)",
                "VsphereVm"
                );
            VsphereVm? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereVm)this.Field;
            }
            string fieldSpecDoc = Query.VsphereVmNew(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereVmNewConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVmConnection!
        internal void InvokeQueryVsphereVmNewConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmNewConnection",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "VsphereVmConnection"
                );
            VsphereVmConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereVmConnection)this.Field;
            }
            string fieldSpecDoc = Query.VsphereVmNewConnection(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!): AsyncRequestStatus!
        internal void InvokeQueryVsphereVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("id", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmAsyncRequestStatus",
                "($clusterUuid: UUID!,$id: String!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Query.VsphereVmAsyncRequestStatus(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        internal void InvokeQueryVsphereVmRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                "RecoverableRangeResponse"
                );
            RecoverableRangeResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RecoverableRangeResponse)this.Field;
            }
            string fieldSpecDoc = Query.VsphereVmRecoverableRange(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!): BatchVmwareVmRecoverableRanges!
        internal void InvokeQueryVsphereVmRecoverableRangeInBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("requestInfo", "BatchVmwareVmRecoverableRangesRequestInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmRecoverableRangeInBatch",
                "($requestInfo: BatchVmwareVmRecoverableRangesRequestInput!)",
                "BatchVmwareVmRecoverableRanges"
                );
            BatchVmwareVmRecoverableRanges? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchVmwareVmRecoverableRanges)this.Field;
            }
            string fieldSpecDoc = Query.VsphereVmRecoverableRangeInBatch(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Query:
        // vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        internal void InvokeQueryVsphereVmMissedRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereVmMissedRecoverableRange",
                "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)",
                "RecoverableRangeResponse"
                );
            RecoverableRangeResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RecoverableRangeResponse)this.Field;
            }
            string fieldSpecDoc = Query.VsphereVmMissedRecoverableRange(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscQueryVsphereVm
}