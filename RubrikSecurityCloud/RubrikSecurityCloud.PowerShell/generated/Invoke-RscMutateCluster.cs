// Invoke-RscMutateCluster.cs
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
        "RscMutateCluster",
        DefaultParameterSetName = "CreateK8s")
    ]
    public class Invoke_RscMutateCluster : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // AddNodesToCloud parameter set
        //
        // GraphQL operation: addNodesToCloudCluster(input: AddNodesToCloudClusterInput!):CcProvisionJobReply!
        //
        [Parameter(
            ParameterSetName = "AddNodesToCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: addNodesToCloudCluster(input: AddNodesToCloudClusterInput!):CcProvisionJobReply!",
            Position = 0
        )]
        public SwitchParameter AddNodesToCloud { get; set; }

        [Parameter(
            ParameterSetName = "AddNodesToCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: AddNodesToCloudClusterInput!"
        )]
        public AddNodesToCloudClusterInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // RegisterCloud parameter set
        //
        // GraphQL operation: registerCloudCluster(input: RegisterCloudClusterInput!):RegisterCloudClusterReply!
        //
        [Parameter(
            ParameterSetName = "RegisterCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: registerCloudCluster(input: RegisterCloudClusterInput!):RegisterCloudClusterReply!",
            Position = 0
        )]
        public SwitchParameter RegisterCloud { get; set; }

        
        // -------------------------------------------------------------------
        // CreateFailover parameter set
        //
        // GraphQL operation: createFailoverCluster(input: CreateFailoverClusterInput!):CreateFailoverClusterReply!
        //
        [Parameter(
            ParameterSetName = "CreateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createFailoverCluster(input: CreateFailoverClusterInput!):CreateFailoverClusterReply!",
            Position = 0
        )]
        public SwitchParameter CreateFailover { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateFailover parameter set
        //
        // GraphQL operation: updateFailoverCluster(input: UpdateFailoverClusterInput!):UpdateFailoverClusterReply!
        //
        [Parameter(
            ParameterSetName = "UpdateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateFailoverCluster(input: UpdateFailoverClusterInput!):UpdateFailoverClusterReply!",
            Position = 0
        )]
        public SwitchParameter UpdateFailover { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteFailover parameter set
        //
        // GraphQL operation: deleteFailoverCluster(input: DeleteFailoverClusterInput!):ResponseSuccess!
        //
        [Parameter(
            ParameterSetName = "DeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteFailoverCluster(input: DeleteFailoverClusterInput!):ResponseSuccess!",
            Position = 0
        )]
        public SwitchParameter DeleteFailover { get; set; }

        
        // -------------------------------------------------------------------
        // BulkDeleteFailover parameter set
        //
        // GraphQL operation: bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!):ResponseSuccess!
        //
        [Parameter(
            ParameterSetName = "BulkDeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!):ResponseSuccess!",
            Position = 0
        )]
        public SwitchParameter BulkDeleteFailover { get; set; }

        
        // -------------------------------------------------------------------
        // CreateK8s parameter set
        //
        // GraphQL operation: createK8sCluster(input: CreateK8sClusterInput!):CreateK8sClusterReply!
        //
        [Parameter(
            ParameterSetName = "CreateK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createK8sCluster(input: CreateK8sClusterInput!):CreateK8sClusterReply!",
            Position = 0
        )]
        public SwitchParameter CreateK8s { get; set; }

        
        // -------------------------------------------------------------------
        // RefreshK8s parameter set
        //
        // GraphQL operation: refreshK8sCluster(input: RefreshK8sClusterInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "RefreshK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: refreshK8sCluster(input: RefreshK8sClusterInput!):CreateOnDemandJobReply!",
            Position = 0
        )]
        public SwitchParameter RefreshK8s { get; set; }

        
        // -------------------------------------------------------------------
        // ArchiveK8s parameter set
        //
        // GraphQL operation: archiveK8sCluster(input: ArchiveK8sClusterInput!):ArchiveK8sClusterReply!
        //
        [Parameter(
            ParameterSetName = "ArchiveK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: archiveK8sCluster(input: ArchiveK8sClusterInput!):ArchiveK8sClusterReply!",
            Position = 0
        )]
        public SwitchParameter ArchiveK8s { get; set; }

        
        // -------------------------------------------------------------------
        // RemoveCdm parameter set
        //
        // GraphQL operation: removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long):Boolean!
        //
        [Parameter(
            ParameterSetName = "RemoveCdm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long):Boolean!",
            Position = 0
        )]
        public SwitchParameter RemoveCdm { get; set; }

        [Parameter(
            ParameterSetName = "RemoveCdm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument clusterUUID: UUID!"
        )]
        public System.String? ClusterUuid { get; set; }
        [Parameter(
            ParameterSetName = "RemoveCdm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument isForce: Boolean!"
        )]
        public System.Boolean? IsForce { get; set; }
        [Parameter(
            ParameterSetName = "RemoveCdm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument expireInDays: Long"
        )]
        public System.Int64? ExpireInDays { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "AddNodesToCloud":
                        this.ProcessRecord_AddNodesToCloud();
                        break;
                    case "RegisterCloud":
                        this.ProcessRecord_RegisterCloud();
                        break;
                    case "CreateFailover":
                        this.ProcessRecord_CreateFailover();
                        break;
                    case "UpdateFailover":
                        this.ProcessRecord_UpdateFailover();
                        break;
                    case "DeleteFailover":
                        this.ProcessRecord_DeleteFailover();
                        break;
                    case "BulkDeleteFailover":
                        this.ProcessRecord_BulkDeleteFailover();
                        break;
                    case "CreateK8s":
                        this.ProcessRecord_CreateK8s();
                        break;
                    case "RefreshK8s":
                        this.ProcessRecord_RefreshK8s();
                        break;
                    case "ArchiveK8s":
                        this.ProcessRecord_ArchiveK8s();
                        break;
                    case "RemoveCdm":
                        this.ProcessRecord_RemoveCdm();
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
                    "Invoke-RscMutateCluster",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // addNodesToCloudCluster.
        protected void ProcessRecord_AddNodesToCloud()
        {
            this._logger.name += " -AddNodesToCloud";
            // Invoke graphql operation addNodesToCloudCluster
            InvokeMutationAddNodesToCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // registerCloudCluster.
        protected void ProcessRecord_RegisterCloud()
        {
            this._logger.name += " -RegisterCloud";
            // Invoke graphql operation registerCloudCluster
            InvokeMutationRegisterCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createFailoverCluster.
        protected void ProcessRecord_CreateFailover()
        {
            this._logger.name += " -CreateFailover";
            // Invoke graphql operation createFailoverCluster
            InvokeMutationCreateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateFailoverCluster.
        protected void ProcessRecord_UpdateFailover()
        {
            this._logger.name += " -UpdateFailover";
            // Invoke graphql operation updateFailoverCluster
            InvokeMutationUpdateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteFailoverCluster.
        protected void ProcessRecord_DeleteFailover()
        {
            this._logger.name += " -DeleteFailover";
            // Invoke graphql operation deleteFailoverCluster
            InvokeMutationDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteFailoverCluster.
        protected void ProcessRecord_BulkDeleteFailover()
        {
            this._logger.name += " -BulkDeleteFailover";
            // Invoke graphql operation bulkDeleteFailoverCluster
            InvokeMutationBulkDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createK8sCluster.
        protected void ProcessRecord_CreateK8s()
        {
            this._logger.name += " -CreateK8s";
            // Invoke graphql operation createK8sCluster
            InvokeMutationCreateK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // refreshK8sCluster.
        protected void ProcessRecord_RefreshK8s()
        {
            this._logger.name += " -RefreshK8s";
            // Invoke graphql operation refreshK8sCluster
            InvokeMutationRefreshK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // archiveK8sCluster.
        protected void ProcessRecord_ArchiveK8s()
        {
            this._logger.name += " -ArchiveK8s";
            // Invoke graphql operation archiveK8sCluster
            InvokeMutationArchiveK8sCluster();
        }

        // This parameter set invokes a single graphql operation:
        // removeCdmCluster.
        protected void ProcessRecord_RemoveCdm()
        {
            this._logger.name += " -RemoveCdm";
            // Invoke graphql operation removeCdmCluster
            InvokeMutationRemoveCdmCluster();
        }


        // Invoke GraphQL Mutation:
        // addNodesToCloudCluster(input: AddNodesToCloudClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationAddNodesToCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddNodesToCloudClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.AddNodesToCloudCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddNodesToCloudCluster");
            string parameters = "($input: AddNodesToCloudClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddNodesToCloudCluster" + parameters + "{" + document + "}",
                OperationName = "MutationAddNodesToCloudCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CcProvisionJobReply> task = this._rbkClient.InvokeGenericCallAsync<CcProvisionJobReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // registerCloudCluster(input: RegisterCloudClusterInput!): RegisterCloudClusterReply!
        protected void InvokeMutationRegisterCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterCloudClusterInput!"),
            };
            RegisterCloudClusterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RegisterCloudClusterReply)psObject.BaseObject;
                } else {
                    fields = (RegisterCloudClusterReply)this.Field;
                }
            }
            string document = Mutation.RegisterCloudCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterCloudCluster");
            string parameters = "($input: RegisterCloudClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterCloudCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterCloudCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RegisterCloudClusterReply> task = this._rbkClient.InvokeGenericCallAsync<RegisterCloudClusterReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
        protected void InvokeMutationCreateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterInput!"),
            };
            CreateFailoverClusterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateFailoverClusterReply)psObject.BaseObject;
                } else {
                    fields = (CreateFailoverClusterReply)this.Field;
                }
            }
            string document = Mutation.CreateFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateFailoverCluster");
            string parameters = "($input: CreateFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateFailoverCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateFailoverClusterReply> task = this._rbkClient.InvokeGenericCallAsync<CreateFailoverClusterReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
        protected void InvokeMutationUpdateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterInput!"),
            };
            UpdateFailoverClusterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateFailoverClusterReply)psObject.BaseObject;
                } else {
                    fields = (UpdateFailoverClusterReply)this.Field;
                }
            }
            string document = Mutation.UpdateFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateFailoverCluster");
            string parameters = "($input: UpdateFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateFailoverCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateFailoverClusterReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateFailoverClusterReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteFailoverCluster(input: DeleteFailoverClusterInput!): ResponseSuccess!
        protected void InvokeMutationDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterInput!"),
            };
            ResponseSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteFailoverCluster");
            string parameters = "($input: DeleteFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteFailoverCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ResponseSuccess> task = this._rbkClient.InvokeGenericCallAsync<ResponseSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
        protected void InvokeMutationBulkDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterInput!"),
            };
            ResponseSuccess? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.BulkDeleteFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkDeleteFailoverCluster");
            string parameters = "($input: BulkDeleteFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkDeleteFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationBulkDeleteFailoverCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ResponseSuccess> task = this._rbkClient.InvokeGenericCallAsync<ResponseSuccess>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createK8sCluster(input: CreateK8sClusterInput!): CreateK8sClusterReply!
        protected void InvokeMutationCreateK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sClusterInput!"),
            };
            CreateK8sClusterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateK8sClusterReply)psObject.BaseObject;
                } else {
                    fields = (CreateK8sClusterReply)this.Field;
                }
            }
            string document = Mutation.CreateK8sCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateK8sCluster");
            string parameters = "($input: CreateK8sClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateK8sCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateK8sCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateK8sClusterReply> task = this._rbkClient.InvokeGenericCallAsync<CreateK8sClusterReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // refreshK8sCluster(input: RefreshK8sClusterInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRefreshK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshK8sClusterInput!"),
            };
            CreateOnDemandJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fields = (CreateOnDemandJobReply)this.Field;
                }
            }
            string document = Mutation.RefreshK8sCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshK8sCluster");
            string parameters = "($input: RefreshK8sClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshK8sCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshK8sCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateOnDemandJobReply> task = this._rbkClient.InvokeGenericCallAsync<CreateOnDemandJobReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // archiveK8sCluster(input: ArchiveK8sClusterInput!): ArchiveK8sClusterReply!
        protected void InvokeMutationArchiveK8sCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ArchiveK8sClusterInput!"),
            };
            ArchiveK8sClusterReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ArchiveK8sClusterReply)psObject.BaseObject;
                } else {
                    fields = (ArchiveK8sClusterReply)this.Field;
                }
            }
            string document = Mutation.ArchiveK8sCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ArchiveK8sCluster");
            string parameters = "($input: ArchiveK8sClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationArchiveK8sCluster" + parameters + "{" + document + "}",
                OperationName = "MutationArchiveK8sCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ArchiveK8sClusterReply> task = this._rbkClient.InvokeGenericCallAsync<ArchiveK8sClusterReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long): Boolean!
        protected void InvokeMutationRemoveCdmCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUUID", "UUID!"),
                Tuple.Create("isForce", "Boolean!"),
                Tuple.Create("expireInDays", "Long"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.RemoveCdmCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RemoveCdmCluster");
            string parameters = "($clusterUUID: UUID!,$isForce: Boolean!,$expireInDays: Long)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRemoveCdmCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRemoveCdmCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateCluster
}