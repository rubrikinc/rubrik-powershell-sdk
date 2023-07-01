// Invoke-RscMutateVsphere.cs
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
        "RscMutateVsphere",
        DefaultParameterSetName = "DeleteLiveMount")
    ]
    public class Invoke_RscMutateVsphere : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // OnDemandSnapshot parameter set
        //
        // [GraphQL: vsphereOnDemandSnapshot]
        //
        [Parameter(
            ParameterSetName = "OnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereOnDemandSnapshot]",
            Position = 0
        )]
        public SwitchParameter OnDemandSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // BulkOnDemandSnapshot parameter set
        //
        // [GraphQL: vsphereBulkOnDemandSnapshot]
        //
        [Parameter(
            ParameterSetName = "BulkOnDemandSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Trigger a bulk on demand snapshot.
[GraphQL: vsphereBulkOnDemandSnapshot]",
            Position = 0
        )]
        public SwitchParameter BulkOnDemandSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteLiveMount parameter set
        //
        // [GraphQL: deleteVsphereLiveMount]
        //
        [Parameter(
            ParameterSetName = "DeleteLiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.
[GraphQL: deleteVsphereLiveMount]",
            Position = 0
        )]
        public SwitchParameter DeleteLiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotToStandaloneHostV2 parameter set
        //
        // [GraphQL: vsphereExportSnapshotToStandaloneHostV2]
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHostV2",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export snapshot of a virtual machine to standalone ESXi server.
[GraphQL: vsphereExportSnapshotToStandaloneHostV2]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHostV2 { get; set; }

        
        // -------------------------------------------------------------------
        // ExportSnapshotToStandaloneHost parameter set
        //
        // [GraphQL: vsphereExportSnapshotToStandaloneHost]
        //
        [Parameter(
            ParameterSetName = "ExportSnapshotToStandaloneHost",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: vsphereExportSnapshotToStandaloneHost]",
            Position = 0
        )]
        public SwitchParameter ExportSnapshotToStandaloneHost { get; set; }

        
        // -------------------------------------------------------------------
        // DownloadVirtualMachineFile parameter set
        //
        // [GraphQL: downloadVsphereVirtualMachineFiles]
        //
        [Parameter(
            ParameterSetName = "DownloadVirtualMachineFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Virtual Machine files from a snapshot

Supported in v9.0
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.
[GraphQL: downloadVsphereVirtualMachineFiles]",
            Position = 0
        )]
        public SwitchParameter DownloadVirtualMachineFile { get; set; }

        
        // -------------------------------------------------------------------
        // CreateAdvancedTag parameter set
        //
        // [GraphQL: createVsphereAdvancedTag]
        //
        [Parameter(
            ParameterSetName = "CreateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.
[GraphQL: createVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter CreateAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteAdvancedTag parameter set
        //
        // [GraphQL: deleteVsphereAdvancedTag]
        //
        [Parameter(
            ParameterSetName = "DeleteAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.
[GraphQL: deleteVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter DeleteAdvancedTag { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateAdvancedTag parameter set
        //
        // [GraphQL: updateVsphereAdvancedTag]
        //
        [Parameter(
            ParameterSetName = "UpdateAdvancedTag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.
[GraphQL: updateVsphereAdvancedTag]",
            Position = 0
        )]
        public SwitchParameter UpdateAdvancedTag { get; set; }


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
                    case "DeleteLiveMount":
                        this.ProcessRecord_DeleteLiveMount();
                        break;
                    case "ExportSnapshotToStandaloneHostV2":
                        this.ProcessRecord_ExportSnapshotToStandaloneHostV2();
                        break;
                    case "ExportSnapshotToStandaloneHost":
                        this.ProcessRecord_ExportSnapshotToStandaloneHost();
                        break;
                    case "DownloadVirtualMachineFile":
                        this.ProcessRecord_DownloadVirtualMachineFile();
                        break;
                    case "CreateAdvancedTag":
                        this.ProcessRecord_CreateAdvancedTag();
                        break;
                    case "DeleteAdvancedTag":
                        this.ProcessRecord_DeleteAdvancedTag();
                        break;
                    case "UpdateAdvancedTag":
                        this.ProcessRecord_UpdateAdvancedTag();
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
        protected void ProcessRecord_DeleteLiveMount()
        {
            this._logger.name += " -DeleteLiveMount";
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
        // vsphereExportSnapshotToStandaloneHost.
        protected void ProcessRecord_ExportSnapshotToStandaloneHost()
        {
            this._logger.name += " -ExportSnapshotToStandaloneHost";
            // Invoke graphql operation vsphereExportSnapshotToStandaloneHost
            InvokeMutationVsphereExportSnapshotToStandaloneHost();
        }

        // This parameter set invokes a single graphql operation:
        // downloadVsphereVirtualMachineFiles.
        protected void ProcessRecord_DownloadVirtualMachineFile()
        {
            this._logger.name += " -DownloadVirtualMachineFile";
            // Invoke graphql operation downloadVsphereVirtualMachineFiles
            InvokeMutationDownloadVsphereVirtualMachineFiles();
        }

        // This parameter set invokes a single graphql operation:
        // createVsphereAdvancedTag.
        protected void ProcessRecord_CreateAdvancedTag()
        {
            this._logger.name += " -CreateAdvancedTag";
            // Invoke graphql operation createVsphereAdvancedTag
            InvokeMutationCreateVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // deleteVsphereAdvancedTag.
        protected void ProcessRecord_DeleteAdvancedTag()
        {
            this._logger.name += " -DeleteAdvancedTag";
            // Invoke graphql operation deleteVsphereAdvancedTag
            InvokeMutationDeleteVsphereAdvancedTag();
        }

        // This parameter set invokes a single graphql operation:
        // updateVsphereAdvancedTag.
        protected void ProcessRecord_UpdateAdvancedTag()
        {
            this._logger.name += " -UpdateAdvancedTag";
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereOnDemandSnapshot");
            var parameters = "($input: VsphereOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereOnDemandSnapshot",
            };
            var vars = new OperationVariableSet();
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
        // vsphereBulkOnDemandSnapshot(input: VsphereBulkOnDemandSnapshotInput!): BatchAsyncRequestStatus!
        protected void InvokeMutationVsphereBulkOnDemandSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereBulkOnDemandSnapshotInput!"),
            };
            BatchAsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.VsphereBulkOnDemandSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereBulkOnDemandSnapshot");
            var parameters = "($input: VsphereBulkOnDemandSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereBulkOnDemandSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereBulkOnDemandSnapshot",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncRequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteVsphereLiveMount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereLiveMount");
            var parameters = "($input: DeleteVsphereLiveMountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereLiveMount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereLiveMount",
            };
            var vars = new OperationVariableSet();
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
        // vsphereExportSnapshotToStandaloneHostV2(input: VsphereExportSnapshotToStandaloneHostV2Input!): AsyncRequestStatus!
        protected void InvokeMutationVsphereExportSnapshotToStandaloneHostV2()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereExportSnapshotToStandaloneHostV2Input!"),
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
            string document = Mutation.VsphereExportSnapshotToStandaloneHostV2(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExportSnapshotToStandaloneHostV2");
            var parameters = "($input: VsphereExportSnapshotToStandaloneHostV2Input!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExportSnapshotToStandaloneHostV2" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExportSnapshotToStandaloneHostV2",
            };
            var vars = new OperationVariableSet();
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
        // vsphereExportSnapshotToStandaloneHost(
        //     snapshotFid: UUID!
        //     vmName: String
        //     disableNetwork: Boolean
        //     removeNetworkDevices: Boolean
        //     powerOn: Boolean
        //     keepMacAddresses: Boolean
        //     hostIpAddress: String!
        //     datastoreName: String!
        //     hostUsername: String!
        //     hostPassword: String!
        //   ): VsphereAsyncRequestStatus!
        protected void InvokeMutationVsphereExportSnapshotToStandaloneHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("vmName", "String"),
                Tuple.Create("disableNetwork", "Boolean"),
                Tuple.Create("removeNetworkDevices", "Boolean"),
                Tuple.Create("powerOn", "Boolean"),
                Tuple.Create("keepMacAddresses", "Boolean"),
                Tuple.Create("hostIpAddress", "String!"),
                Tuple.Create("datastoreName", "String!"),
                Tuple.Create("hostUsername", "String!"),
                Tuple.Create("hostPassword", "String!"),
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
            string document = Mutation.VsphereExportSnapshotToStandaloneHost(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.VsphereExportSnapshotToStandaloneHost");
            var parameters = "($snapshotFid: UUID!,$vmName: String,$disableNetwork: Boolean,$removeNetworkDevices: Boolean,$powerOn: Boolean,$keepMacAddresses: Boolean,$hostIpAddress: String!,$datastoreName: String!,$hostUsername: String!,$hostPassword: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationVsphereExportSnapshotToStandaloneHost" + parameters + "{" + document + "}",
                OperationName = "MutationVsphereExportSnapshotToStandaloneHost",
            };
            var vars = new OperationVariableSet();
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
        // downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
        protected void InvokeMutationDownloadVsphereVirtualMachineFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVsphereVirtualMachineFilesInput!"),
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
            string document = Mutation.DownloadVsphereVirtualMachineFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DownloadVsphereVirtualMachineFiles");
            var parameters = "($input: DownloadVsphereVirtualMachineFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDownloadVsphereVirtualMachineFiles" + parameters + "{" + document + "}",
                OperationName = "MutationDownloadVsphereVirtualMachineFiles",
            };
            var vars = new OperationVariableSet();
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
        // createVsphereAdvancedTag(input: CreateVsphereAdvancedTagInput!): CreateVsphereAdvancedTagReply!
        protected void InvokeMutationCreateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereAdvancedTagInput!"),
            };
            CreateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (CreateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (CreateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.CreateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateVsphereAdvancedTag");
            var parameters = "($input: CreateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationCreateVsphereAdvancedTag",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateVsphereAdvancedTagReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestSuccess)psObject.BaseObject;
                } else {
                    fields = (RequestSuccess)this.Field;
                }
            }
            string document = Mutation.DeleteVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteVsphereAdvancedTag");
            var parameters = "($input: DeleteVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteVsphereAdvancedTag",
            };
            var vars = new OperationVariableSet();
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
        // updateVsphereAdvancedTag(input: UpdateVsphereAdvancedTagInput!): UpdateVsphereAdvancedTagReply!
        protected void InvokeMutationUpdateVsphereAdvancedTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVsphereAdvancedTagInput!"),
            };
            UpdateVsphereAdvancedTagReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpdateVsphereAdvancedTagReply)psObject.BaseObject;
                } else {
                    fields = (UpdateVsphereAdvancedTagReply)this.Field;
                }
            }
            string document = Mutation.UpdateVsphereAdvancedTag(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateVsphereAdvancedTag");
            var parameters = "($input: UpdateVsphereAdvancedTagInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateVsphereAdvancedTag" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateVsphereAdvancedTag",
            };
            var vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateVsphereAdvancedTagReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateVsphere
}