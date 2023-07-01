// Invoke-RscMutateCluster.cs
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
        "RscMutateCluster",
        DefaultParameterSetName = "CreateK8s")
    ]
    public class Invoke_RscMutateCluster : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // AddNodesToCloud parameter set
        //
        // [GraphQL: addNodesToCloudCluster]
        //
        [Parameter(
            ParameterSetName = "AddNodesToCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add nodes to cloud cluster.
[GraphQL: addNodesToCloudCluster]",
            Position = 0
        )]
        public SwitchParameter AddNodesToCloud { get; set; }

        
        // -------------------------------------------------------------------
        // RegisterCloud parameter set
        //
        // [GraphQL: registerCloudCluster]
        //
        [Parameter(
            ParameterSetName = "RegisterCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register a cloud cluster.
[GraphQL: registerCloudCluster]",
            Position = 0
        )]
        public SwitchParameter RegisterCloud { get; set; }

        
        // -------------------------------------------------------------------
        // CreateFailover parameter set
        //
        // [GraphQL: createFailoverCluster]
        //
        [Parameter(
            ParameterSetName = "CreateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a failover cluster

Supported in v5.2+
Create a failover cluster.
[GraphQL: createFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter CreateFailover { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateFailover parameter set
        //
        // [GraphQL: updateFailoverCluster]
        //
        [Parameter(
            ParameterSetName = "UpdateFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.
[GraphQL: updateFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter UpdateFailover { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteFailover parameter set
        //
        // [GraphQL: deleteFailoverCluster]
        //
        [Parameter(
            ParameterSetName = "DeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.
[GraphQL: deleteFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter DeleteFailover { get; set; }

        
        // -------------------------------------------------------------------
        // BulkDeleteFailover parameter set
        //
        // [GraphQL: bulkDeleteFailoverCluster]
        //
        [Parameter(
            ParameterSetName = "BulkDeleteFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.
[GraphQL: bulkDeleteFailoverCluster]",
            Position = 0
        )]
        public SwitchParameter BulkDeleteFailover { get; set; }

        
        // -------------------------------------------------------------------
        // CreateK8s parameter set
        //
        // [GraphQL: createK8sCluster]
        //
        [Parameter(
            ParameterSetName = "CreateK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add a Kubernetes cluster.
[GraphQL: createK8sCluster]",
            Position = 0
        )]
        public SwitchParameter CreateK8s { get; set; }

        
        // -------------------------------------------------------------------
        // RefreshK8s parameter set
        //
        // [GraphQL: refreshK8sCluster]
        //
        [Parameter(
            ParameterSetName = "RefreshK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh resources of a Kubernetes cluster.
[GraphQL: refreshK8sCluster]",
            Position = 0
        )]
        public SwitchParameter RefreshK8s { get; set; }

        
        // -------------------------------------------------------------------
        // ArchiveK8s parameter set
        //
        // [GraphQL: archiveK8sCluster]
        //
        [Parameter(
            ParameterSetName = "ArchiveK8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Archive a Kubernetes cluster.
[GraphQL: archiveK8sCluster]",
            Position = 0
        )]
        public SwitchParameter ArchiveK8s { get; set; }

        
        // -------------------------------------------------------------------
        // RemoveCdm parameter set
        //
        // [GraphQL: removeCdmCluster]
        //
        [Parameter(
            ParameterSetName = "RemoveCdm",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: removeCdmCluster]",
            Position = 0
        )]
        public SwitchParameter RemoveCdm { get; set; }

        
        // -------------------------------------------------------------------
        // RecoverCloud parameter set
        //
        // [GraphQL: recoverCloudCluster]
        //
        [Parameter(
            ParameterSetName = "RecoverCloud",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a Rubrik Cloud Cluster.
[GraphQL: recoverCloudCluster]",
            Position = 0
        )]
        public SwitchParameter RecoverCloud { get; set; }


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
                    case "RecoverCloud":
                        this.ProcessRecord_RecoverCloud();
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

        // This parameter set invokes a single graphql operation:
        // recoverCloudCluster.
        protected void ProcessRecord_RecoverCloud()
        {
            this._logger.name += " -RecoverCloud";
            // Invoke graphql operation recoverCloudCluster
            InvokeMutationRecoverCloudCluster();
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
                if (this.Field is PSObject psObject) {
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.AddNodesToCloudCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddNodesToCloudCluster");
            var parameters = "($input: AddNodesToCloudClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddNodesToCloudCluster" + parameters + "{" + document + "}",
                OperationName = "MutationAddNodesToCloudCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CcProvisionJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RegisterCloudClusterReply)psObject.BaseObject;
                } else {
                    fields = (RegisterCloudClusterReply)this.Field;
                }
            }
            string document = Mutation.RegisterCloudCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RegisterCloudCluster");
            var parameters = "($input: RegisterCloudClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRegisterCloudCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRegisterCloudCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RegisterCloudClusterReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (CreateFailoverClusterReply)psObject.BaseObject;
                } else {
                    fields = (CreateFailoverClusterReply)this.Field;
                }
            }
            string document = Mutation.CreateFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateFailoverCluster");
            var parameters = "($input: CreateFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateFailoverCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateFailoverClusterReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (UpdateFailoverClusterReply)psObject.BaseObject;
                } else {
                    fields = (UpdateFailoverClusterReply)this.Field;
                }
            }
            string document = Mutation.UpdateFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateFailoverCluster");
            var parameters = "($input: UpdateFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateFailoverCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateFailoverClusterReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteFailoverCluster");
            var parameters = "($input: DeleteFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteFailoverCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ResponseSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (ResponseSuccess)psObject.BaseObject;
                } else {
                    fields = (ResponseSuccess)this.Field;
                }
            }
            string document = Mutation.BulkDeleteFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BulkDeleteFailoverCluster");
            var parameters = "($input: BulkDeleteFailoverClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBulkDeleteFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "MutationBulkDeleteFailoverCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ResponseSuccess", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (CreateK8sClusterReply)psObject.BaseObject;
                } else {
                    fields = (CreateK8sClusterReply)this.Field;
                }
            }
            string document = Mutation.CreateK8sCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateK8sCluster");
            var parameters = "($input: CreateK8sClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateK8sCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateK8sCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateK8sClusterReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fields = (CreateOnDemandJobReply)this.Field;
                }
            }
            string document = Mutation.RefreshK8sCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshK8sCluster");
            var parameters = "($input: RefreshK8sClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshK8sCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshK8sCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateOnDemandJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (ArchiveK8sClusterReply)psObject.BaseObject;
                } else {
                    fields = (ArchiveK8sClusterReply)this.Field;
                }
            }
            string document = Mutation.ArchiveK8sCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ArchiveK8sCluster");
            var parameters = "($input: ArchiveK8sClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationArchiveK8sCluster" + parameters + "{" + document + "}",
                OperationName = "MutationArchiveK8sCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "ArchiveK8sClusterReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.RemoveCdmCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RemoveCdmCluster");
            var parameters = "($clusterUUID: UUID!,$isForce: Boolean!,$expireInDays: Long)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRemoveCdmCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRemoveCdmCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.Boolean", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // recoverCloudCluster(input: RecoverCloudClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationRecoverCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.RecoverCloudCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RecoverCloudCluster");
            var parameters = "($input: RecoverCloudClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRecoverCloudCluster" + parameters + "{" + document + "}",
                OperationName = "MutationRecoverCloudCluster",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CcProvisionJobReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateCluster
}