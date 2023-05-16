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
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateVcenter",
        DefaultParameterSetName = "Create")
    ]
    public class Invoke_RscMutateVcenter : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Create parameter set
        //
        // GraphQL operation: createVsphereVcenter(input: CreateVsphereVcenterInput!):CreateVsphereVcenterReply!
        //
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Add a vCenter server.
                GraphQL operation: createVsphereVcenter(input: CreateVsphereVcenterInput!):CreateVsphereVcenterReply!
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
                Input for V2CreateVcenterV2.
                GraphQL argument input: CreateVsphereVcenterInput!
                "
        )]
        public CreateVsphereVcenterInput? Input { get; set; }
        
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

        
        // -------------------------------------------------------------------
        // Refresh parameter set
        //
        // GraphQL operation: refreshVsphereVcenter(input: RefreshVsphereVcenterInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "Refresh",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Refresh vCenter Server metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified vCenter Server.
                GraphQL operation: refreshVsphereVcenter(input: RefreshVsphereVcenterInput!):AsyncRequestStatus!
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
        // createVsphereVcenter.
        protected void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Invoke graphql operation createVsphereVcenter
            InvokeMutationCreateVsphereVcenter();
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
        // refreshVsphereVcenter.
        protected void ProcessRecord_Refresh()
        {
            this._logger.name += " -Refresh";
            // Invoke graphql operation refreshVsphereVcenter
            InvokeMutationRefreshVsphereVcenter();
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
        // createVsphereVcenter(input: CreateVsphereVcenterInput!): CreateVsphereVcenterReply!
        protected void InvokeMutationCreateVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereVcenterInput!"),
            };
            CreateVsphereVcenterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateVsphereVcenterReply)psObject.BaseObject;
                } else {
                    fields = (CreateVsphereVcenterReply)this.Field;
                }
            }
            string document = Mutation.CreateVsphereVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateVsphereVcenter");
            string parameters = "($input: CreateVsphereVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateVsphereVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationCreateVsphereVcenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateVsphereVcenterReply> task = this._rbkClient.InvokeGenericCallAsync<CreateVsphereVcenterReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereDeleteVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereDeleteVcenter");
            string parameters = "($input: VsphereDeleteVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereDeleteVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereDeleteVcenter",
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

        // Invoke GraphQL Mutation:
        // refreshVsphereVcenter(input: RefreshVsphereVcenterInput!): AsyncRequestStatus!
        protected void InvokeMutationRefreshVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshVsphereVcenterInput!"),
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
            string document = Mutation.RefreshVsphereVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshVsphereVcenter");
            string parameters = "($input: RefreshVsphereVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshVsphereVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshVsphereVcenter",
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateVcenterReply)psObject.BaseObject;
                } else {
                    fields = (UpdateVcenterReply)this.Field;
                }
            }
            string document = Mutation.UpdateVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVcenter");
            string parameters = "($input: UpdateVcenterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVcenter" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVcenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateVcenterReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateVcenterReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.UpdateVcenterHotAddNetwork(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVcenterHotAddNetwork");
            string parameters = "($input: UpdateVcenterHotAddNetworkInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVcenterHotAddNetwork" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVcenterHotAddNetwork",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.UpdateVcenterHotAddBandwidth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVcenterHotAddBandwidth");
            string parameters = "($input: UpdateVcenterHotAddBandwidthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVcenterHotAddBandwidth" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVcenterHotAddBandwidth",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestSuccess> task = this._rbkClient.InvokeGenericCallAsync<RequestSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateVcenter
}