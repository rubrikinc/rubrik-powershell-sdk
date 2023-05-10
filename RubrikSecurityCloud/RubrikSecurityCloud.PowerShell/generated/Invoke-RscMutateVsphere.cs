// Invoke-RscMutateVsphere.cs
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
        "RscMutateVsphere",
        DefaultParameterSetName = "deleteLiveMount")
    ]
    public class Invoke_RscMutateVsphere : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // OnDemandSnapshot parameter set
        //
        // GraphQL operation: vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: VsphereOnDemandSnapshotInput!"
        )]
        public VsphereOnDemandSnapshotInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // BulkOnDemandSnapshot parameter set
        //
        // GraphQL operation: vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!):BatchAsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!):BatchAsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // deleteLiveMount parameter set
        //
        // GraphQL operation: deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter deleteLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotToStandaloneHostV2 parameter set
        //
        // GraphQL operation: vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHostV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHostV2 { get; set; }

        
        // -------------------------------------------------------------------
        // downloadVirtualMachineFile parameter set
        //
        // GraphQL operation: downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "downloadVirtualMachineFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter downloadVirtualMachineFile { get; set; }

        
        // -------------------------------------------------------------------
        // createAdvancedTag parameter set
        //
        // GraphQL operation: createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!):CreateVsphereAdvancedTagReply!
        //
        [Parameter(
            ParameterSetName = "createAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!):CreateVsphereAdvancedTagReply!",
            Position = 0
        )]
        public SwitchParameter createAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // deleteAdvancedTag parameter set
        //
        // GraphQL operation: deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!):RequestSuccess!
        //
        [Parameter(
            ParameterSetName = "deleteAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!):RequestSuccess!",
            Position = 0
        )]
        public SwitchParameter deleteAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // updateAdvancedTag parameter set
        //
        // GraphQL operation: updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!):UpdateVsphereAdvancedTagReply!
        //
        [Parameter(
            ParameterSetName = "updateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!):UpdateVsphereAdvancedTagReply!",
            Position = 0
        )]
        public SwitchParameter updateAdvancedTag { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "OnDemandSnapshot":
                        this.ProcessRecord_OnDemandSnapshot();
                        break;
                    case "BulkOnDemandSnapshot":
                        this.ProcessRecord_BulkOnDemandSnapshot();
                        break;
                    case "deleteLiveMount":
                        this.ProcessRecord_deleteLiveMount();
                        break;
                    case "ExportSnapshotToStandaloneHostV2":
                        this.ProcessRecord_ExportSnapshotToStandaloneHostV2();
                        break;
                    case "downloadVirtualMachineFile":
                        this.ProcessRecord_downloadVirtualMachineFile();
                        break;
                    case "createAdvancedTag":
                        this.ProcessRecord_createAdvancedTag();
                        break;
                    case "deleteAdvancedTag":
                        this.ProcessRecord_deleteAdvancedTag();
                        break;
                    case "updateAdvancedTag":
                        this.ProcessRecord_updateAdvancedTag();
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
                    "Invoke-RscMutateVsphere",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // vsphereOnDemandSnapshot.
        protected void ProcessRecord_OnDemandSnapshot()
        {
            this._logger.name += " -OnDemandSnapshot";
            // Invoke graphql operation vsphereOnDemandSnapshot
            InvokeMutationVsphereOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereBulkOnDemandSnapshot.
        protected void ProcessRecord_BulkOnDemandSnapshot()
        {
            this._logger.name += " -BulkOnDemandSnapshot";
            // Invoke graphql operation vsphereBulkOnDemandSnapshot
            InvokeMutationVsphereBulkOnDemandSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereLiveMount.
        protected void ProcessRecord_deleteLiveMount()
        {
            this._logger.name += " -deleteLiveMount";
            // Invoke graphql operation deleteVsphereLiveMount
            InvokeMutationDeleteVsphereLiveMount();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereExportSnapshotToStandaloneHostV2.
        protected void ProcessRecord_ExportSnapshotToStandaloneHostV2()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHostV2";
            // Invoke graphql operation vsphereExportSnapshotToStandaloneHostV2
            InvokeMutationVsphereExportSnapshotToStandaloneHostV2();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVsphereVirtualMachineFiles.
        protected void ProcessRecord_downloadVirtualMachineFile()
        {
            this._logger.name += " -downloadVirtualMachineFile";
            // Invoke graphql operation downloadVsphereVirtualMachineFiles
            InvokeMutationDownloadVsphereVirtualMachineFiles();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereAdvancedTag.
        protected void ProcessRecord_createAdvancedTag()
        {
            this._logger.name += " -createAdvancedTag";
            // Invoke graphql operation createVsphereAdvancedTag
            InvokeMutationCreateVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereAdvancedTag.
        protected void ProcessRecord_deleteAdvancedTag()
        {
            this._logger.name += " -deleteAdvancedTag";
            // Invoke graphql operation deleteVsphereAdvancedTag
            InvokeMutationDeleteVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereAdvancedTag.
        protected void ProcessRecord_updateAdvancedTag()
        {
            this._logger.name += " -updateAdvancedTag";
            // Invoke graphql operation updateVsphereAdvancedTag
            InvokeMutationUpdateVsphereAdvancedTag();
        }


        // Invoke GraphQL Mutation:
        // vsphereOnDemandSnapshot(input: VsphereOnDemandSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationVsphereOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereOnDemandSnapshotInput!"),
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
            string document = Mutation.VsphereOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereOnDemandSnapshot");
            string parameters = "($input: VsphereOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereOnDemandSnapshot",
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
        // vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereBulkOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereBulkOnDemandSnapshotInput!"),
            };
            BatchAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereBulkOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereBulkOnDemandSnapshot");
            string parameters = "($input: VsphereBulkOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereBulkOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereBulkOnDemandSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncRequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereLiveMount(input: DeleteVsphereLiveMountInput!): AsyncRequestStatus!
        protected void InvokeMutationDeleteVsphereLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereLiveMountInput!"),
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
            string document = Mutation.DeleteVsphereLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereLiveMount");
            string parameters = "($input: DeleteVsphereLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereLiveMount",
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
        // vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereExportSnapshotToStandaloneHostV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
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
            string document = Mutation.VsphereExportSnapshotToStandaloneHostV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExportSnapshotToStandaloneHostV2");
            string parameters = "($input: VsphereExportSnapshotToStandaloneHostV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExportSnapshotToStandaloneHostV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExportSnapshotToStandaloneHostV2",
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
        // downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadVsphereVirtualMachineFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVsphereVirtualMachineFilesInput!"),
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
            string document = Mutation.DownloadVsphereVirtualMachineFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadVsphereVirtualMachineFiles");
            string parameters = "($input: DownloadVsphereVirtualMachineFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadVsphereVirtualMachineFiles" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadVsphereVirtualMachineFiles",
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
        // createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        protected void InvokeMutationCreateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            CreateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (CreateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.CreateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateVsphereAdvancedTag");
            string parameters = "($input: CreateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationCreateVsphereAdvancedTag",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateVsphereAdvancedTagReply> task = this._rbkClient.InvokeGenericCallAsync<CreateVsphereAdvancedTagReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteVsphereAdvancedTag(input: DeleteVsphereAdvancedTagInput!): RequestSuccess!
        protected void InvokeMutationDeleteVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteVsphereAdvancedTagInput!"),
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
            string document = Mutation.DeleteVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereAdvancedTag");
            string parameters = "($input: DeleteVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereAdvancedTag",
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
        // updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        protected void InvokeMutationUpdateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            UpdateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (UpdateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.UpdateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVsphereAdvancedTag");
            string parameters = "($input: UpdateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVsphereAdvancedTag",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateVsphereAdvancedTagReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateVsphereAdvancedTagReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateVsphere
}