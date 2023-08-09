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
    [Cmdlet(
        "Invoke",
        "RscMutateVcenter",
        DefaultParameterSetName = "Edit")
    ]
    public class Invoke_RscMutateVcenter : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Create parameter set
        //
        // [GraphQL: vsphereCreateVCenter]
        //
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

        
        // -------------------------------------------------------------------
        // Delete parameter set
        //
        // [GraphQL: vsphereDeleteVcenter]
        //
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

        
        // -------------------------------------------------------------------
        // Edit parameter set
        //
        // [GraphQL: vsphereEditVCenter]
        //
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

        
        // -------------------------------------------------------------------
        // Refresh parameter set
        //
        // [GraphQL: vsphereRefreshVCenter]
        //
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

        
        // -------------------------------------------------------------------
        // Update parameter set
        //
        // [GraphQL: updateVcenter]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateHotAddNetwork parameter set
        //
        // [GraphQL: updateVcenterHotAddNetwork]
        //
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

        
        // -------------------------------------------------------------------
        // UpdateHotAddBandwidth parameter set
        //
        // [GraphQL: updateVcenterHotAddBandwidth]
        //
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

        // This parameter set invokes a single graphql operation:
        // vsphereCreateVCenter.
        protected void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Invoke graphql operation vsphereCreateVCenter
            InvokeMutationVsphereCreateVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereDeleteVcenter.
        protected void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Invoke graphql operation vsphereDeleteVcenter
            InvokeMutationVsphereDeleteVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereEditVCenter.
        protected void ProcessRecord_Edit()
        {
            this._logger.name += " -Edit";
            // Invoke graphql operation vsphereEditVCenter
            InvokeMutationVsphereEditVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereRefreshVCenter.
        protected void ProcessRecord_Refresh()
        {
            this._logger.name += " -Refresh";
            // Invoke graphql operation vsphereRefreshVCenter
            InvokeMutationVsphereRefreshVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenter.
        protected void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Invoke graphql operation updateVcenter
            InvokeMutationUpdateVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddNetwork.
        protected void ProcessRecord_UpdateHotAddNetwork()
        {
            this._logger.name += " -UpdateHotAddNetwork";
            // Invoke graphql operation updateVcenterHotAddNetwork
            InvokeMutationUpdateVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddBandwidth.
        protected void ProcessRecord_UpdateHotAddBandwidth()
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
        protected void InvokeMutationVsphereCreateVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("hostname", "String!"),
                Tuple.Create("username", "String!"),
                Tuple.Create("password", "String!"),
                Tuple.Create("conflictResolutionAuthz", "ConflictResolutionAuthzEnum!"),
                Tuple.Create("caCert", "String"),
            };
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereCreateVcenter(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereCreateVcenter",
                "($clusterUuid: UUID!,$hostname: String!,$username: String!,$password: String!,$conflictResolutionAuthz: ConflictResolutionAuthzEnum!,$caCert: String)",
                fieldSpecDoc,
                "VsphereAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereDeleteVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereDeleteVcenterInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereDeleteVcenter(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereDeleteVcenter",
                "($input: VsphereDeleteVcenterInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
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
        protected void InvokeMutationVsphereEditVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vcenterId", "UUID!"),
                Tuple.Create("hostname", "String!"),
                Tuple.Create("username", "String!"),
                Tuple.Create("password", "String!"),
                Tuple.Create("conflictResolutionAuthz", "ConflictResolutionAuthzEnum!"),
                Tuple.Create("caCert", "String"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereEditVcenter(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereEditVcenter",
                "($vcenterId: UUID!,$hostname: String!,$username: String!,$password: String!,$conflictResolutionAuthz: ConflictResolutionAuthzEnum!,$caCert: String)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // vsphereRefreshVCenter(vcenterId: UUID!): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereRefreshVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vcenterId", "UUID!"),
            };
            VsphereAsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.VsphereRefreshVcenter(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationVsphereRefreshVcenter",
                "($vcenterId: UUID!)",
                fieldSpecDoc,
                "VsphereAsyncRequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // updateVcenter(input: UpdateVcenterInput!): UpdateVcenterReply!
        protected void InvokeMutationUpdateVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterInput!"),
            };
            UpdateVcenterReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateVcenterReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateVcenterReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateVcenter(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateVcenter",
                "($input: UpdateVcenterInput!)",
                fieldSpecDoc,
                "UpdateVcenterReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!): RequestSuccess!
        protected void InvokeMutationUpdateVcenterHotAddNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddNetworkInput!"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateVcenterHotAddNetwork(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateVcenterHotAddNetwork",
                "($input: UpdateVcenterHotAddNetworkInput!)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }

        // Invoke GraphQL Mutation:
        // updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!): RequestSuccess!
        protected void InvokeMutationUpdateVcenterHotAddBandwidth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddBandwidthInput!"),
            };
            RequestSuccess? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestSuccess)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestSuccess)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateVcenterHotAddBandwidth(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateVcenterHotAddBandwidth",
                "($input: UpdateVcenterHotAddBandwidthInput!)",
                fieldSpecDoc,
                "RequestSuccess"
            );
        }


    } // class Invoke_RscMutateVcenter
}