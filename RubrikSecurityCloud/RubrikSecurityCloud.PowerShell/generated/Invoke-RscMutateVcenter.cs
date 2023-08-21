// Invoke-RscMutateVcenter.cs
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
    /// vSphere vCenter mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateVcenter is a master cmdlet for Vcenter work that can invoke any of the following subcommands: Create, Delete, Edit, Refresh, Update, UpdateHotAddNetwork, UpdateHotAddBandwidth.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateVcenter -Create [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVcenter -Delete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVcenter -Edit [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVcenter -Refresh [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVcenter -Update [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVcenter -UpdateHotAddNetwork [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateVcenter -UpdateHotAddBandwidth [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscMutateVcenter",
        DefaultParameterSetName = "Edit")
    ]
    public class Invoke_RscMutateVcenter : RscPSCmdlet
    {
        
        /// <summary>
        /// Create parameter set
        ///
        /// [GraphQL: vsphereCreateVCenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereCreateVCenter]",
            Position = 0
        )]
        public SwitchParameter Create { get; set; }

        
        /// <summary>
        /// Delete parameter set
        ///
        /// [GraphQL: vsphereDeleteVcenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Delete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.
[GraphQL: vsphereDeleteVcenter]",
            Position = 0
        )]
        public SwitchParameter Delete { get; set; }

        
        /// <summary>
        /// Edit parameter set
        ///
        /// [GraphQL: vsphereEditVCenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Edit",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereEditVCenter]",
            Position = 0
        )]
        public SwitchParameter Edit { get; set; }

        
        /// <summary>
        /// Refresh parameter set
        ///
        /// [GraphQL: vsphereRefreshVCenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Refresh",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereRefreshVCenter]",
            Position = 0
        )]
        public SwitchParameter Refresh { get; set; }

        
        /// <summary>
        /// Update parameter set
        ///
        /// [GraphQL: updateVcenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.
[GraphQL: updateVcenter]",
            Position = 0
        )]
        public SwitchParameter Update { get; set; }

        
        /// <summary>
        /// UpdateHotAddNetwork parameter set
        ///
        /// [GraphQL: updateVcenterHotAddNetwork]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateHotAddNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
[GraphQL: updateVcenterHotAddNetwork]",
            Position = 0
        )]
        public SwitchParameter UpdateHotAddNetwork { get; set; }

        
        /// <summary>
        /// UpdateHotAddBandwidth parameter set
        ///
        /// [GraphQL: updateVcenterHotAddBandwidth]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateHotAddBandwidth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
[GraphQL: updateVcenterHotAddBandwidth]",
            Position = 0
        )]
        public SwitchParameter UpdateHotAddBandwidth { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Create":
                        this.ProcessRecord_Create();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "Edit":
                        this.ProcessRecord_Edit();
                        break;
                    case "Refresh":
                        this.ProcessRecord_Refresh();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "UpdateHotAddNetwork":
                        this.ProcessRecord_UpdateHotAddNetwork();
                        break;
                    case "UpdateHotAddBandwidth":
                        this.ProcessRecord_UpdateHotAddBandwidth();
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
        // vsphereCreateVCenter.
        internal void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Invoke graphql operation vsphereCreateVCenter
            InvokeMutationVsphereCreateVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereDeleteVcenter.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Invoke graphql operation vsphereDeleteVcenter
            InvokeMutationVsphereDeleteVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereEditVCenter.
        internal void ProcessRecord_Edit()
        {
            this._logger.name += " -Edit";
            // Invoke graphql operation vsphereEditVCenter
            InvokeMutationVsphereEditVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereRefreshVCenter.
        internal void ProcessRecord_Refresh()
        {
            this._logger.name += " -Refresh";
            // Invoke graphql operation vsphereRefreshVCenter
            InvokeMutationVsphereRefreshVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenter.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Invoke graphql operation updateVcenter
            InvokeMutationUpdateVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddNetwork.
        internal void ProcessRecord_UpdateHotAddNetwork()
        {
            this._logger.name += " -UpdateHotAddNetwork";
            // Invoke graphql operation updateVcenterHotAddNetwork
            InvokeMutationUpdateVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddBandwidth.
        internal void ProcessRecord_UpdateHotAddBandwidth()
        {
            this._logger.name += " -UpdateHotAddBandwidth";
            // Invoke graphql operation updateVcenterHotAddBandwidth
            InvokeMutationUpdateVcenterHotAddBandwidth();
        }


        // Invoke GraphQL Mutation:
        // vsphereCreateVCenter(
        //     clusterUuid: UUID!
        //     hostname: String!
        //     username: String!
        //     password: String!
        //     conflictResolutionAuthz: ConflictResolutionAuthzEnum!
        //     caCert: String
        //   ): VsphereAsyncRequestStatus!
        internal void InvokeMutationVsphereCreateVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("hostname", "String!"),
                Tuple.Create("username", "String!"),
                Tuple.Create("password", "String!"),
                Tuple.Create("conflictResolutionAuthz", "ConflictResolutionAuthzEnum!"),
                Tuple.Create("caCert", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereCreateVcenter",
                "($clusterUuid: UUID!,$hostname: String!,$username: String!,$password: String!,$conflictResolutionAuthz: ConflictResolutionAuthzEnum!,$caCert: String)",
                "VsphereAsyncRequestStatus"
                );
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereCreateVcenter(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!): AsyncRequestStatus!
        internal void InvokeMutationVsphereDeleteVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereDeleteVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereDeleteVcenter",
                "($input: VsphereDeleteVcenterInput!)",
                "AsyncRequestStatus"
                );
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereDeleteVcenter(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereEditVCenter(
        //     vcenterId: UUID!
        //     hostname: String!
        //     username: String!
        //     password: String!
        //     conflictResolutionAuthz: ConflictResolutionAuthzEnum!
        //     caCert: String
        //   ): RequestSuccess!
        internal void InvokeMutationVsphereEditVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vcenterId", "UUID!"),
                Tuple.Create("hostname", "String!"),
                Tuple.Create("username", "String!"),
                Tuple.Create("password", "String!"),
                Tuple.Create("conflictResolutionAuthz", "ConflictResolutionAuthzEnum!"),
                Tuple.Create("caCert", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereEditVcenter",
                "($vcenterId: UUID!,$hostname: String!,$username: String!,$password: String!,$conflictResolutionAuthz: ConflictResolutionAuthzEnum!,$caCert: String)",
                "RequestSuccess"
                );
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereEditVcenter(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // vsphereRefreshVCenter(vcenterId: UUID!): VsphereAsyncRequestStatus!
        internal void InvokeMutationVsphereRefreshVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vcenterId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereRefreshVcenter",
                "($vcenterId: UUID!)",
                "VsphereAsyncRequestStatus"
                );
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.VsphereRefreshVcenter(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateVcenter(input: UpdateVcenterInput!): UpdateVcenterReply!
        internal void InvokeMutationUpdateVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcenter",
                "($input: UpdateVcenterInput!)",
                "UpdateVcenterReply"
                );
            UpdateVcenterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (UpdateVcenterReply)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateVcenter(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!): RequestSuccess!
        internal void InvokeMutationUpdateVcenterHotAddNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddNetworkInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcenterHotAddNetwork",
                "($input: UpdateVcenterHotAddNetworkInput!)",
                "RequestSuccess"
                );
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateVcenterHotAddNetwork(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!): RequestSuccess!
        internal void InvokeMutationUpdateVcenterHotAddBandwidth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddBandwidthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcenterHotAddBandwidth",
                "($input: UpdateVcenterHotAddBandwidthInput!)",
                "RequestSuccess"
                );
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestSuccess)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateVcenterHotAddBandwidth(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateVcenter
}