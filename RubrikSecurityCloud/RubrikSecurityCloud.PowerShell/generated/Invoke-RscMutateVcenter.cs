// Invoke-RscMutateVcenter.cs
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
        "RscMutateVcenter",
        DefaultParameterSetName = "Edit")
    ]
    public class Invoke_RscMutateVcenter : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Create parameter set
        //
        // GraphQL operation: vsphereCreateVCenter(,   clusterUuid: UUID!,   hostname: String!,   username: String!,   password: String!,   conflictResolutionAuthz: ConflictResolutionAuthzEnum!,   caCert: String, ):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereCreateVCenter(,   clusterUuid: UUID!,   hostname: String!,   username: String!,   password: String!,   conflictResolutionAuthz: ConflictResolutionAuthzEnum!,   caCert: String, ):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter Create { get; set; }

        [Parameter(
            ParameterSetName = "Create",
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
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument hostname: String!
                "
        )]
        public System.String? Hostname { get; set; }
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument username: String!
                "
        )]
        public System.String? Username { get; set; }
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument password: String!
                "
        )]
        public System.String? Password { get; set; }
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument conflictResolutionAuthz: ConflictResolutionAuthzEnum!
                "
        )]
        public ConflictResolutionAuthzEnum? ConflictResolutionAuthz { get; set; }
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument caCert: String
                "
        )]
        public System.String? CaCert { get; set; }
        
        // -------------------------------------------------------------------
        // Delete parameter set
        //
        // GraphQL operation: vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "Delete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.
                GraphQL operation: vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!):AsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter Delete { get; set; }

        [Parameter(
            ParameterSetName = "Delete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Input for V1DeleteVcenter.
                GraphQL argument input: VsphereDeleteVcenterInput!
                "
        )]
        public VsphereDeleteVcenterInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Edit parameter set
        //
        // GraphQL operation: vsphereEditVCenter(,   vcenterId: UUID!,   hostname: String!,   username: String!,   password: String!,   conflictResolutionAuthz: ConflictResolutionAuthzEnum!,   caCert: String, ):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "Edit",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereEditVCenter(,   vcenterId: UUID!,   hostname: String!,   username: String!,   password: String!,   conflictResolutionAuthz: ConflictResolutionAuthzEnum!,   caCert: String, ):RequestSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter Edit { get; set; }

        [Parameter(
            ParameterSetName = "Edit",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument vcenterId: UUID!
                "
        )]
        public System.String? VcenterId { get; set; }
        
        // -------------------------------------------------------------------
        // Refresh parameter set
        //
        // GraphQL operation: vsphereRefreshVCenter(vcenterId: UUID!):VsphereAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "Refresh",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: vsphereRefreshVCenter(vcenterId: UUID!):VsphereAsyncRequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter Refresh { get; set; }

        
        // -------------------------------------------------------------------
        // update parameter set
        //
        // GraphQL operation: updateVcenter(input: UpdateVcenterInput!):UpdateVcenterReply!
        //
        [Parameter(
            ParameterSetName = "update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.
                GraphQL operation: updateVcenter(input: UpdateVcenterInput!):UpdateVcenterReply!
                ",
            Position = 0
        )]
        public SwitchParameter update { get; set; }

        
        // -------------------------------------------------------------------
        // updateHotAddNetwork parameter set
        //
        // GraphQL operation: updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "updateHotAddNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
                GraphQL operation: updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!):RequestSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter updateHotAddNetwork { get; set; }

        
        // -------------------------------------------------------------------
        // updateHotAddBandwidth parameter set
        //
        // GraphQL operation: updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "updateHotAddBandwidth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
                GraphQL operation: updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!):RequestSuccess!
                ",
            Position = 0
        )]
        public SwitchParameter updateHotAddBandwidth { get; set; }


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
                    case "update":
                        this.ProcessRecord_update();
                        break;
                    case "updateHotAddNetwork":
                        this.ProcessRecord_updateHotAddNetwork();
                        break;
                    case "updateHotAddBandwidth":
                        this.ProcessRecord_updateHotAddBandwidth();
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
                    "Invoke-RscMutateVcenter",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
        protected void ProcessRecord_update()
        {
            this._logger.name += " -update";
            // Invoke graphql operation updateVcenter
            InvokeMutationUpdateVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddNetwork.
        protected void ProcessRecord_updateHotAddNetwork()
        {
            this._logger.name += " -updateHotAddNetwork";
            // Invoke graphql operation updateVcenterHotAddNetwork
            InvokeMutationUpdateVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddBandwidth.
        protected void ProcessRecord_updateHotAddBandwidth()
        {
            this._logger.name += " -updateHotAddBandwidth";
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
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereCreateVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereCreateVcenter");
            var parameters = "($clusterUuid: UUID!,$hostname: String!,$username: String!,$password: String!,$conflictResolutionAuthz: ConflictResolutionAuthzEnum!,$caCert: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereCreateVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereCreateVcenter",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereDeleteVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereDeleteVcenterInput!"),
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
            string document = Mutation.VsphereDeleteVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereDeleteVcenter");
            var parameters = "($input: VsphereDeleteVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereDeleteVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereDeleteVcenter",
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
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.VsphereEditVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereEditVcenter");
            var parameters = "($vcenterId: UUID!,$hostname: String!,$username: String!,$password: String!,$conflictResolutionAuthz: ConflictResolutionAuthzEnum!,$caCert: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereEditVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereEditVcenter",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // vsphereRefreshVCenter(vcenterId: UUID!): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereRefreshVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("vcenterId", "UUID!"),
            };
            VsphereAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (VsphereAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (VsphereAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereRefreshVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereRefreshVcenter");
            var parameters = "($vcenterId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereRefreshVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereRefreshVcenter",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "VsphereAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateVcenter(input: UpdateVcenterInput!): UpdateVcenterReply!
        protected void InvokeMutationUpdateVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterInput!"),
            };
            UpdateVcenterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateVcenterReply)psObject.BaseObject;
                } else {
                    fields = (UpdateVcenterReply)this.Field;
                }
            }
            string document = Mutation.UpdateVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVcenter");
            var parameters = "($input: UpdateVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVcenter",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateVcenterReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!): RequestSuccess!
        protected void InvokeMutationUpdateVcenterHotAddNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddNetworkInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.UpdateVcenterHotAddNetwork(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVcenterHotAddNetwork");
            var parameters = "($input: UpdateVcenterHotAddNetworkInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVcenterHotAddNetwork" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVcenterHotAddNetwork",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!): RequestSuccess!
        protected void InvokeMutationUpdateVcenterHotAddBandwidth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddBandwidthInput!"),
            };
            RequestSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.UpdateVcenterHotAddBandwidth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVcenterHotAddBandwidth");
            var parameters = "($input: UpdateVcenterHotAddBandwidthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVcenterHotAddBandwidth" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVcenterHotAddBandwidth",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateVcenter
}