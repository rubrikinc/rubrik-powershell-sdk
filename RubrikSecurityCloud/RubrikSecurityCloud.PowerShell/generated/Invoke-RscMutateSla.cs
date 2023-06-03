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
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateSla",
        DefaultParameterSetName = "pause")
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
            HelpMessage =
                @"
                Create SLA Domain.
                GraphQL operation: createGlobalSla(input: CreateGlobalSlaInput!):GlobalSlaReply!
                ",
            Position = 0
        )]
        public SwitchParameter createGlobal { get; set; }

        [Parameter(
            ParameterSetName = "createGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument input: CreateGlobalSlaInput!
                "
        )]
        public CreateGlobalSlaInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // editGlobal parameter set
        //
        // GraphQL operation: editGlobalSla(globalSlaEditRequest: GlobalSlaEditRequest!):GlobalSlaReply!
        //
        [Parameter(
            ParameterSetName = "editGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: editGlobalSla(globalSlaEditRequest: GlobalSlaEditRequest!):GlobalSlaReply!
                ",
            Position = 0
        )]
        public SwitchParameter editGlobal { get; set; }

        [Parameter(
            ParameterSetName = "editGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument globalSlaEditRequest: GlobalSlaEditRequest!
                "
        )]
        public GlobalSlaEditRequest? GlobalSlaEditRequest { get; set; }
        
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
            HelpMessage =
                @"
                Update SLA Domain.
                GraphQL operation: updateGlobalSla(input: UpdateGlobalSlaInput!):GlobalSlaReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateGlobal { get; set; }

        
        // -------------------------------------------------------------------
        // deleteGlobal parameter set
        //
        // GraphQL operation: deleteGlobalSla(id: UUID!, userNote: String):SlaResult!
        //
        [Parameter(
            ParameterSetName = "deleteGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: deleteGlobalSla(id: UUID!, userNote: String):SlaResult!
                ",
            Position = 0
        )]
        public SwitchParameter deleteGlobal { get; set; }

        [Parameter(
            ParameterSetName = "deleteGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                SLA Domain ID.
                GraphQL argument id: UUID!
                "
        )]
        public System.String? Id { get; set; }
        [Parameter(
            ParameterSetName = "deleteGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Optional User note.
                GraphQL argument userNote: String
                "
        )]
        public System.String? UserNote { get; set; }
        
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
            HelpMessage =
                @"
                Endpoint to assign SLA Domain.
                GraphQL operation: assignSla(input: AssignSlaInput!):SlaAssignResult!
                ",
            Position = 0
        )]
        public SwitchParameter assign { get; set; }

        
        // -------------------------------------------------------------------
        // assignsForSnappableHierarchie parameter set
        //
        // GraphQL operation: assignSlasForSnappableHierarchies(,   globalSlaOptionalFid: UUID,   globalSlaAssignType: SlaAssignTypeEnum!,   objectIds: [UUID!]!,   applicableSnappableTypes: [WorkloadLevelHierarchy!],   shouldApplyToExistingSnapshots: Boolean,   shouldApplyToNonPolicySnapshots: Boolean,   globalExistingSnapshotRetention: GlobalExistingSnapshotRetention,   userNote: String, ):[SlaAssignResult!]!
        //
        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: assignSlasForSnappableHierarchies(,   globalSlaOptionalFid: UUID,   globalSlaAssignType: SlaAssignTypeEnum!,   objectIds: [UUID!]!,   applicableSnappableTypes: [WorkloadLevelHierarchy!],   shouldApplyToExistingSnapshots: Boolean,   shouldApplyToNonPolicySnapshots: Boolean,   globalExistingSnapshotRetention: GlobalExistingSnapshotRetention,   userNote: String, ):[SlaAssignResult!]!
                ",
            Position = 0
        )]
        public SwitchParameter assignsForSnappableHierarchie { get; set; }

        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Global SLA Domain forever UUID.
                GraphQL argument globalSlaOptionalFid: UUID
                "
        )]
        public System.String? GlobalSlaOptionalFid { get; set; }
        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Corresponds to the assignment type for the global SLA
                GraphQL argument globalSlaAssignType: SlaAssignTypeEnum!
                "
        )]
        public SlaAssignTypeEnum? GlobalSlaAssignType { get; set; }
        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                A list of object forever UUIDs to assign to the global SLA Domain.
                GraphQL argument objectIds: [UUID!]!
                "
        )]
        public List<System.String>? ObjectIds { get; set; }
        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Provide optional snappable types under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. See 'applicableSnappableType' for more details. If more than one is provided, the SLA will be assigned to all.
                GraphQL argument applicableSnappableTypes: [WorkloadLevelHierarchy!]
                "
        )]
        public List<WorkloadLevelHierarchy>? ApplicableSnappableTypes { get; set; }
        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Boolean value to indicate whether to apply changes made to the SLA to existing snapshots.
                GraphQL argument shouldApplyToExistingSnapshots: Boolean
                "
        )]
        public System.Boolean? ShouldApplyToExistingSnapshots { get; set; }
        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Boolean value to indicate if the new configuration keeps existing, non-policy snapshots of data sources retained by this SLA Domain.
                GraphQL argument shouldApplyToNonPolicySnapshots: Boolean
                "
        )]
        public System.Boolean? ShouldApplyToNonPolicySnapshots { get; set; }
        [Parameter(
            ParameterSetName = "assignsForSnappableHierarchie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Choose what to do with existing snapshot in case of do not protect slas
                GraphQL argument globalExistingSnapshotRetention: GlobalExistingSnapshotRetention
                "
        )]
        public GlobalExistingSnapshotRetention? GlobalExistingSnapshotRetention { get; set; }
        
        // -------------------------------------------------------------------
        // assignRetentionToSnappable parameter set
        //
        // GraphQL operation: assignRetentionSLAToSnappables(,   globalSlaOptionalFid: UUID,   globalSlaAssignType: SlaAssignTypeEnum!,   objectIds: [UUID!]!,   applicableSnappableType: WorkloadLevelHierarchy,   shouldApplyToNonPolicySnapshots: Boolean,   userNote: String, ):SlaAssignResult!
        //
        [Parameter(
            ParameterSetName = "assignRetentionToSnappable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: assignRetentionSLAToSnappables(,   globalSlaOptionalFid: UUID,   globalSlaAssignType: SlaAssignTypeEnum!,   objectIds: [UUID!]!,   applicableSnappableType: WorkloadLevelHierarchy,   shouldApplyToNonPolicySnapshots: Boolean,   userNote: String, ):SlaAssignResult!
                ",
            Position = 0
        )]
        public SwitchParameter assignRetentionToSnappable { get; set; }

        [Parameter(
            ParameterSetName = "assignRetentionToSnappable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Provide optional snappable type under the object for SLA assignment. This is meant to be used only for objects that support multiple snappable hierarchies. This allows an SLA to be set for one/more specific snappable types under the object, instead of applying the SLA for all the snappable types. For example, an AWS account object can potentially have 2 different snappable types under it - AwsNativeEc2Instance and AwsNativeRdsInstance. This field can be set with the appropriate type so that the SLA only gets applied to snappables of the selected type under that account. If the SLA must be applicable for all the snappable types under the object, then this field can be set to `AllSubHierarchyType` or left blank. This field must either be left blank or set to `AllSubHierarchyType` when assigning SLA to a snappable or to an object that does not support multiple snappable types.
                GraphQL argument applicableSnappableType: WorkloadLevelHierarchy
                "
        )]
        public WorkloadLevelHierarchy? ApplicableSnappableType { get; set; }
        
        // -------------------------------------------------------------------
        // assignRetentionToSnapshot parameter set
        //
        // GraphQL operation: assignRetentionSLAToSnapshots(,   globalSlaOptionalFid: UUID,   globalSlaAssignType: SlaAssignTypeEnum!,   snapshotFids: [UUID!]!,   userNote: String, ):SlaAssignResult!
        //
        [Parameter(
            ParameterSetName = "assignRetentionToSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: assignRetentionSLAToSnapshots(,   globalSlaOptionalFid: UUID,   globalSlaAssignType: SlaAssignTypeEnum!,   snapshotFids: [UUID!]!,   userNote: String, ):SlaAssignResult!
                ",
            Position = 0
        )]
        public SwitchParameter assignRetentionToSnapshot { get; set; }

        [Parameter(
            ParameterSetName = "assignRetentionToSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of UUIDs of objects.
                GraphQL argument snapshotFids: [UUID!]!
                "
        )]
        public List<System.String>? SnapshotFids { get; set; }
        
        // -------------------------------------------------------------------
        // pause parameter set
        //
        // GraphQL operation: pauseSla(input: PauseSlaRequest!):SlaResult!
        //
        [Parameter(
            ParameterSetName = "pause",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Pause/Resume Global SLA on the given clusters.
                GraphQL operation: pauseSla(input: PauseSlaRequest!):SlaResult!
                ",
            Position = 0
        )]
        public SwitchParameter pause { get; set; }

        
        // -------------------------------------------------------------------
        // upgrade parameter set
        //
        // GraphQL operation: upgradeSlas(input: UpgradeSlasInput!):UpgradeSlasReply!
        //
        [Parameter(
            ParameterSetName = "upgrade",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Upgrade SLA Domains from the Rubrik clusters.
                GraphQL operation: upgradeSlas(input: UpgradeSlasInput!):UpgradeSlasReply!
                ",
            Position = 0
        )]
        public SwitchParameter upgrade { get; set; }

        
        // -------------------------------------------------------------------
        // getPendingAssignment parameter set
        //
        // GraphQL operation: getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!):PendingSlaOperations!
        //
        [Parameter(
            ParameterSetName = "getPendingAssignment",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get pending SLA Domain assignments on selected managed objects

Supported in v5.2+
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs.
                GraphQL operation: getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!):PendingSlaOperations!
                ",
            Position = 0
        )]
        public SwitchParameter getPendingAssignment { get; set; }

        
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
            HelpMessage =
                @"
                Create a request to export a snapshot and mount it on a host

Supported in v5.3+
Export a managed volume snapshot as a share and mount it on a given host.
                GraphQL operation: exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!):AsyncRequestStatus!
                ",
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
                    case "editGlobal":
                        this.ProcessRecord_editGlobal();
                        break;
                    case "updateGlobal":
                        this.ProcessRecord_updateGlobal();
                        break;
                    case "deleteGlobal":
                        this.ProcessRecord_deleteGlobal();
                        break;
                    case "assign":
                        this.ProcessRecord_assign();
                        break;
                    case "assignsForSnappableHierarchie":
                        this.ProcessRecord_assignsForSnappableHierarchie();
                        break;
                    case "assignRetentionToSnappable":
                        this.ProcessRecord_assignRetentionToSnappable();
                        break;
                    case "assignRetentionToSnapshot":
                        this.ProcessRecord_assignRetentionToSnapshot();
                        break;
                    case "pause":
                        this.ProcessRecord_pause();
                        break;
                    case "upgrade":
                        this.ProcessRecord_upgrade();
                        break;
                    case "getPendingAssignment":
                        this.ProcessRecord_getPendingAssignment();
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
        // editGlobalSla.
        protected void ProcessRecord_editGlobal()
        {
            this._logger.name += " -editGlobal";
            // Invoke graphql operation editGlobalSla
            InvokeMutationEditGlobalSla();
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
        // deleteGlobalSla.
        protected void ProcessRecord_deleteGlobal()
        {
            this._logger.name += " -deleteGlobal";
            // Invoke graphql operation deleteGlobalSla
            InvokeMutationDeleteGlobalSla();
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
        // assignSlasForSnappableHierarchies.
        protected void ProcessRecord_assignsForSnappableHierarchie()
        {
            this._logger.name += " -assignsForSnappableHierarchie";
            // Invoke graphql operation assignSlasForSnappableHierarchies
            InvokeMutationAssignSlasForSnappableHierarchies();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnappables.
        protected void ProcessRecord_assignRetentionToSnappable()
        {
            this._logger.name += " -assignRetentionToSnappable";
            // Invoke graphql operation assignRetentionSLAToSnappables
            InvokeMutationAssignRetentionSlaToSnappables();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnapshots.
        protected void ProcessRecord_assignRetentionToSnapshot()
        {
            this._logger.name += " -assignRetentionToSnapshot";
            // Invoke graphql operation assignRetentionSLAToSnapshots
            InvokeMutationAssignRetentionSlaToSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // pauseSla.
        protected void ProcessRecord_pause()
        {
            this._logger.name += " -pause";
            // Invoke graphql operation pauseSla
            InvokeMutationPauseSla();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeSlas.
        protected void ProcessRecord_upgrade()
        {
            this._logger.name += " -upgrade";
            // Invoke graphql operation upgradeSlas
            InvokeMutationUpgradeSlas();
        }

        // This parameter set invokes a single graphql operation:
        // getPendingSlaAssignments.
        protected void ProcessRecord_getPendingAssignment()
        {
            this._logger.name += " -getPendingAssignment";
            // Invoke graphql operation getPendingSlaAssignments
            InvokeMutationGetPendingSlaAssignments();
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
                if (this.Field is PSObject psObject) {
                    fields = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fields = (GlobalSlaReply)this.Field;
                }
            }
            string document = Mutation.CreateGlobalSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateGlobalSla");
            var parameters = "($input: CreateGlobalSlaInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateGlobalSla" + parameters + "{" + document + "}",
                OperationName = "MutationCreateGlobalSla",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GlobalSlaReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // editGlobalSla(globalSlaEditRequest: GlobalSlaEditRequest!): GlobalSlaReply!
        protected void InvokeMutationEditGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaEditRequest", "GlobalSlaEditRequest!"),
            };
            GlobalSlaReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fields = (GlobalSlaReply)this.Field;
                }
            }
            string document = Mutation.EditGlobalSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.EditGlobalSla");
            var parameters = "($globalSlaEditRequest: GlobalSlaEditRequest!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationEditGlobalSla" + parameters + "{" + document + "}",
                OperationName = "MutationEditGlobalSla",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GlobalSlaReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fields = (GlobalSlaReply)this.Field;
                }
            }
            string document = Mutation.UpdateGlobalSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateGlobalSla");
            var parameters = "($input: UpdateGlobalSlaInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateGlobalSla" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateGlobalSla",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GlobalSlaReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteGlobalSla(id: UUID!, userNote: String): SlaResult!
        protected void InvokeMutationDeleteGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("userNote", "String"),
            };
            SlaResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SlaResult)psObject.BaseObject;
                } else {
                    fields = (SlaResult)this.Field;
                }
            }
            string document = Mutation.DeleteGlobalSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteGlobalSla");
            var parameters = "($id: UUID!,$userNote: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteGlobalSla" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteGlobalSla",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaResult", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (SlaAssignResult)psObject.BaseObject;
                } else {
                    fields = (SlaAssignResult)this.Field;
                }
            }
            string document = Mutation.AssignSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignSla");
            var parameters = "($input: AssignSlaInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignSla" + parameters + "{" + document + "}",
                OperationName = "MutationAssignSla",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaAssignResult", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // assignSlasForSnappableHierarchies(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     objectIds: [UUID!]!
        //     applicableSnappableTypes: [WorkloadLevelHierarchy!]
        //     shouldApplyToExistingSnapshots: Boolean
        //     shouldApplyToNonPolicySnapshots: Boolean
        //     globalExistingSnapshotRetention: GlobalExistingSnapshotRetention
        //     userNote: String
        //   ): [SlaAssignResult!]!
        protected void InvokeMutationAssignSlasForSnappableHierarchies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("shouldApplyToExistingSnapshots", "Boolean"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("globalExistingSnapshotRetention", "GlobalExistingSnapshotRetention"),
                Tuple.Create("userNote", "String"),
            };
            List<SlaAssignResult>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<SlaAssignResult>)psObject.BaseObject;
                } else {
                    fields = (List<SlaAssignResult>)this.Field;
                }
            }
            string document = Mutation.AssignSlasForSnappableHierarchies(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignSlasForSnappableHierarchies");
            var parameters = "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!],$shouldApplyToExistingSnapshots: Boolean,$shouldApplyToNonPolicySnapshots: Boolean,$globalExistingSnapshotRetention: GlobalExistingSnapshotRetention,$userNote: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignSlasForSnappableHierarchies" + parameters + "{" + document + "}",
                OperationName = "MutationAssignSlasForSnappableHierarchies",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<SlaAssignResult>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // assignRetentionSLAToSnappables(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     objectIds: [UUID!]!
        //     applicableSnappableType: WorkloadLevelHierarchy
        //     shouldApplyToNonPolicySnapshots: Boolean
        //     userNote: String
        //   ): SlaAssignResult!
        protected void InvokeMutationAssignRetentionSlaToSnappables()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableType", "WorkloadLevelHierarchy"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("userNote", "String"),
            };
            SlaAssignResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SlaAssignResult)psObject.BaseObject;
                } else {
                    fields = (SlaAssignResult)this.Field;
                }
            }
            string document = Mutation.AssignRetentionSlaToSnappables(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignRetentionSlaToSnappables");
            var parameters = "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableType: WorkloadLevelHierarchy,$shouldApplyToNonPolicySnapshots: Boolean,$userNote: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignRetentionSlaToSnappables" + parameters + "{" + document + "}",
                OperationName = "MutationAssignRetentionSlaToSnappables",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaAssignResult", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // assignRetentionSLAToSnapshots(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     snapshotFids: [UUID!]!
        //     userNote: String
        //   ): SlaAssignResult!
        protected void InvokeMutationAssignRetentionSlaToSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("snapshotFids", "[UUID!]!"),
                Tuple.Create("userNote", "String"),
            };
            SlaAssignResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SlaAssignResult)psObject.BaseObject;
                } else {
                    fields = (SlaAssignResult)this.Field;
                }
            }
            string document = Mutation.AssignRetentionSlaToSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AssignRetentionSlaToSnapshots");
            var parameters = "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$snapshotFids: [UUID!]!,$userNote: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAssignRetentionSlaToSnapshots" + parameters + "{" + document + "}",
                OperationName = "MutationAssignRetentionSlaToSnapshots",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaAssignResult", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // pauseSla(input: PauseSlaRequest!): SlaResult!
        protected void InvokeMutationPauseSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseSlaRequest!"),
            };
            SlaResult? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (SlaResult)psObject.BaseObject;
                } else {
                    fields = (SlaResult)this.Field;
                }
            }
            string document = Mutation.PauseSla(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.PauseSla");
            var parameters = "($input: PauseSlaRequest!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationPauseSla" + parameters + "{" + document + "}",
                OperationName = "MutationPauseSla",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "SlaResult", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // upgradeSlas(input: UpgradeSlasInput!): UpgradeSlasReply!
        protected void InvokeMutationUpgradeSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeSlasInput!"),
            };
            UpgradeSlasReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (UpgradeSlasReply)psObject.BaseObject;
                } else {
                    fields = (UpgradeSlasReply)this.Field;
                }
            }
            string document = Mutation.UpgradeSlas(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeSlas");
            var parameters = "($input: UpgradeSlasInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeSlas" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeSlas",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpgradeSlasReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Mutation:
        // getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!): PendingSlaOperations!
        protected void InvokeMutationGetPendingSlaAssignments()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetPendingSlaAssignmentsInput!"),
            };
            PendingSlaOperations? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (PendingSlaOperations)psObject.BaseObject;
                } else {
                    fields = (PendingSlaOperations)this.Field;
                }
            }
            string document = Mutation.GetPendingSlaAssignments(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.GetPendingSlaAssignments");
            var parameters = "($input: GetPendingSlaAssignmentsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationGetPendingSlaAssignments" + parameters + "{" + document + "}",
                OperationName = "MutationGetPendingSlaAssignments",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "PendingSlaOperations", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Mutation.ExportSlaManagedVolumeSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportSlaManagedVolumeSnapshot");
            var parameters = "($input: ExportSlaManagedVolumeSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportSlaManagedVolumeSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExportSlaManagedVolumeSnapshot",
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


    } // class Invoke_RscMutateSla
}