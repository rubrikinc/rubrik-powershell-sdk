// Invoke-RscMutateSla.cs
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
        "RscMutateSla",
        DefaultParameterSetName = "assign")
    ]
    public class Invoke_RscMutateSla : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // createGlobal parameter set
        //
        // GraphQL operation: createGlobalSla(input: CreateGlobalSlaInput!):GlobalSlaReply!
        //
        [Parameter(
            ParameterSetName = "createGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createGlobalSla(input: CreateGlobalSlaInput!):GlobalSlaReply!",
            Position = 0
        )]
        public SwitchParameter createGlobal { get; set; }

        [Parameter(
            ParameterSetName = "createGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: CreateGlobalSlaInput!"
        )]
        public CreateGlobalSlaInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // updateGlobal parameter set
        //
        // GraphQL operation: updateGlobalSla(input: UpdateGlobalSlaInput!):GlobalSlaReply!
        //
        [Parameter(
            ParameterSetName = "updateGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateGlobalSla(input: UpdateGlobalSlaInput!):GlobalSlaReply!",
            Position = 0
        )]
        public SwitchParameter updateGlobal { get; set; }

        
        // -------------------------------------------------------------------
        // assign parameter set
        //
        // GraphQL operation: assignSla(input: AssignSlaInput!):SlaAssignResult!
        //
        [Parameter(
            ParameterSetName = "assign",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: assignSla(input: AssignSlaInput!):SlaAssignResult!",
            Position = 0
        )]
        public SwitchParameter assign { get; set; }

        
        // -------------------------------------------------------------------
        // exportManagedVolumeSnapshot parameter set
        //
        // GraphQL operation: exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "exportManagedVolumeSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter exportManagedVolumeSnapshot { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "createGlobal":
                        this.ProcessRecord_createGlobal();
                        break;
                    case "updateGlobal":
                        this.ProcessRecord_updateGlobal();
                        break;
                    case "assign":
                        this.ProcessRecord_assign();
                        break;
                    case "exportManagedVolumeSnapshot":
                        this.ProcessRecord_exportManagedVolumeSnapshot();
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
                    "Invoke-RscMutateSla",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // createGlobalSla.
        protected void ProcessRecord_createGlobal()
        {
            this._logger.name += " -createGlobal";
            // Invoke graphql operation createGlobalSla
            InvokeMutationCreateGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // updateGlobalSla.
        protected void ProcessRecord_updateGlobal()
        {
            this._logger.name += " -updateGlobal";
            // Invoke graphql operation updateGlobalSla
            InvokeMutationUpdateGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // assignSla.
        protected void ProcessRecord_assign()
        {
            this._logger.name += " -assign";
            // Invoke graphql operation assignSla
            InvokeMutationAssignSla();
        }

        // This parameter set invokes a single graphql operation:
        // exportSlaManagedVolumeSnapshot.
        protected void ProcessRecord_exportManagedVolumeSnapshot()
        {
            this._logger.name += " -exportManagedVolumeSnapshot";
            // Invoke graphql operation exportSlaManagedVolumeSnapshot
            InvokeMutationExportSlaManagedVolumeSnapshot();
        }


        // Invoke GraphQL Mutation:
        // createGlobalSla(input: CreateGlobalSlaInput!): GlobalSlaReply!
        protected void InvokeMutationCreateGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGlobalSlaInput!"),
            };
            GlobalSlaReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fields = (GlobalSlaReply)this.Field;
                }
            }
            string document = Mutation.CreateGlobalSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateGlobalSla");
            string parameters = "($input: CreateGlobalSlaInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateGlobalSla" + parameters + "{" + document + "}",
                OperationName = "MutationCreateGlobalSla",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<GlobalSlaReply> task = this._rbkClient.InvokeGenericCallAsync<GlobalSlaReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateGlobalSla(input: UpdateGlobalSlaInput!): GlobalSlaReply!
        protected void InvokeMutationUpdateGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGlobalSlaInput!"),
            };
            GlobalSlaReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fields = (GlobalSlaReply)this.Field;
                }
            }
            string document = Mutation.UpdateGlobalSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateGlobalSla");
            string parameters = "($input: UpdateGlobalSlaInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateGlobalSla" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateGlobalSla",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<GlobalSlaReply> task = this._rbkClient.InvokeGenericCallAsync<GlobalSlaReply>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // assignSla(input: AssignSlaInput!): SlaAssignResult!
        protected void InvokeMutationAssignSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaInput!"),
            };
            SlaAssignResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (SlaAssignResult)psObject.BaseObject;
                } else {
                    fields = (SlaAssignResult)this.Field;
                }
            }
            string document = Mutation.AssignSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignSla");
            string parameters = "($input: AssignSlaInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignSla" + parameters + "{" + document + "}",
                OperationName = "MutationAssignSla",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<SlaAssignResult> task = this._rbkClient.InvokeGenericCallAsync<SlaAssignResult>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationExportSlaManagedVolumeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportSlaManagedVolumeSnapshotInput!"),
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
            string document = Mutation.ExportSlaManagedVolumeSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportSlaManagedVolumeSnapshot");
            string parameters = "($input: ExportSlaManagedVolumeSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportSlaManagedVolumeSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExportSlaManagedVolumeSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateSla
}