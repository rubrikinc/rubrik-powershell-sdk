// Invoke-RscMutateSla.cs
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
        "RscMutateSla",
        DefaultParameterSetName = "Pause")
    ]
    public class Invoke_RscMutateSla : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // CreateGlobal parameter set
        //
        // [GraphQL: createGlobalSla]
        //
        [Parameter(
            ParameterSetName = "CreateGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create SLA Domain.
[GraphQL: createGlobalSla]",
            Position = 0
        )]
        public SwitchParameter CreateGlobal { get; set; }

        
        // -------------------------------------------------------------------
        // EditGlobal parameter set
        //
        // [GraphQL: editGlobalSla]
        //
        [Parameter(
            ParameterSetName = "EditGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: editGlobalSla]",
            Position = 0
        )]
        public SwitchParameter EditGlobal { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateGlobal parameter set
        //
        // [GraphQL: updateGlobalSla]
        //
        [Parameter(
            ParameterSetName = "UpdateGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update SLA Domain.
[GraphQL: updateGlobalSla]",
            Position = 0
        )]
        public SwitchParameter UpdateGlobal { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteGlobal parameter set
        //
        // [GraphQL: deleteGlobalSla]
        //
        [Parameter(
            ParameterSetName = "DeleteGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: deleteGlobalSla]",
            Position = 0
        )]
        public SwitchParameter DeleteGlobal { get; set; }

        
        // -------------------------------------------------------------------
        // Assign parameter set
        //
        // [GraphQL: assignSla]
        //
        [Parameter(
            ParameterSetName = "Assign",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Endpoint to assign SLA Domain.
[GraphQL: assignSla]",
            Position = 0
        )]
        public SwitchParameter Assign { get; set; }

        
        // -------------------------------------------------------------------
        // AssignsForSnappableHierarchies parameter set
        //
        // [GraphQL: assignSlasForSnappableHierarchies]
        //
        [Parameter(
            ParameterSetName = "AssignsForSnappableHierarchies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: assignSlasForSnappableHierarchies]",
            Position = 0
        )]
        public SwitchParameter AssignsForSnappableHierarchies { get; set; }

        
        // -------------------------------------------------------------------
        // AssignRetentionToSnappables parameter set
        //
        // [GraphQL: assignRetentionSLAToSnappables]
        //
        [Parameter(
            ParameterSetName = "AssignRetentionToSnappables",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: assignRetentionSLAToSnappables]",
            Position = 0
        )]
        public SwitchParameter AssignRetentionToSnappables { get; set; }

        
        // -------------------------------------------------------------------
        // AssignRetentionToSnapshots parameter set
        //
        // [GraphQL: assignRetentionSLAToSnapshots]
        //
        [Parameter(
            ParameterSetName = "AssignRetentionToSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: assignRetentionSLAToSnapshots]",
            Position = 0
        )]
        public SwitchParameter AssignRetentionToSnapshots { get; set; }

        
        // -------------------------------------------------------------------
        // Pause parameter set
        //
        // [GraphQL: pauseSla]
        //
        [Parameter(
            ParameterSetName = "Pause",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Pause or resume SLA Domain on the given Rubrik clusters.
[GraphQL: pauseSla]",
            Position = 0
        )]
        public SwitchParameter Pause { get; set; }

        
        // -------------------------------------------------------------------
        // Upgrades parameter set
        //
        // [GraphQL: upgradeSlas]
        //
        [Parameter(
            ParameterSetName = "Upgrades",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Upgrade SLA Domains from the Rubrik clusters.
[GraphQL: upgradeSlas]",
            Position = 0
        )]
        public SwitchParameter Upgrades { get; set; }

        
        // -------------------------------------------------------------------
        // GetPendingAssignments parameter set
        //
        // [GraphQL: getPendingSlaAssignments]
        //
        [Parameter(
            ParameterSetName = "GetPendingAssignments",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get pending SLA Domain assignments on selected managed objects

Supported in v5.2+
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs.
[GraphQL: getPendingSlaAssignments]",
            Position = 0
        )]
        public SwitchParameter GetPendingAssignments { get; set; }

        
        // -------------------------------------------------------------------
        // ExportManagedVolumeSnapshot parameter set
        //
        // [GraphQL: exportSlaManagedVolumeSnapshot]
        //
        [Parameter(
            ParameterSetName = "ExportManagedVolumeSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to export a snapshot and mount it on a host

Supported in v5.3+
Export a managed volume snapshot as a share and mount it on a given host.
[GraphQL: exportSlaManagedVolumeSnapshot]",
            Position = 0
        )]
        public SwitchParameter ExportManagedVolumeSnapshot { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "CreateGlobal":
                        this.ProcessRecord_CreateGlobal();
                        break;
                    case "EditGlobal":
                        this.ProcessRecord_EditGlobal();
                        break;
                    case "UpdateGlobal":
                        this.ProcessRecord_UpdateGlobal();
                        break;
                    case "DeleteGlobal":
                        this.ProcessRecord_DeleteGlobal();
                        break;
                    case "Assign":
                        this.ProcessRecord_Assign();
                        break;
                    case "AssignsForSnappableHierarchies":
                        this.ProcessRecord_AssignsForSnappableHierarchies();
                        break;
                    case "AssignRetentionToSnappables":
                        this.ProcessRecord_AssignRetentionToSnappables();
                        break;
                    case "AssignRetentionToSnapshots":
                        this.ProcessRecord_AssignRetentionToSnapshots();
                        break;
                    case "Pause":
                        this.ProcessRecord_Pause();
                        break;
                    case "Upgrades":
                        this.ProcessRecord_Upgrades();
                        break;
                    case "GetPendingAssignments":
                        this.ProcessRecord_GetPendingAssignments();
                        break;
                    case "ExportManagedVolumeSnapshot":
                        this.ProcessRecord_ExportManagedVolumeSnapshot();
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
        // createGlobalSla.
        protected void ProcessRecord_CreateGlobal()
        {
            this._logger.name += " -CreateGlobal";
            // Invoke graphql operation createGlobalSla
            InvokeMutationCreateGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // editGlobalSla.
        protected void ProcessRecord_EditGlobal()
        {
            this._logger.name += " -EditGlobal";
            // Invoke graphql operation editGlobalSla
            InvokeMutationEditGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // updateGlobalSla.
        protected void ProcessRecord_UpdateGlobal()
        {
            this._logger.name += " -UpdateGlobal";
            // Invoke graphql operation updateGlobalSla
            InvokeMutationUpdateGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // deleteGlobalSla.
        protected void ProcessRecord_DeleteGlobal()
        {
            this._logger.name += " -DeleteGlobal";
            // Invoke graphql operation deleteGlobalSla
            InvokeMutationDeleteGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // assignSla.
        protected void ProcessRecord_Assign()
        {
            this._logger.name += " -Assign";
            // Invoke graphql operation assignSla
            InvokeMutationAssignSla();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlasForSnappableHierarchies.
        protected void ProcessRecord_AssignsForSnappableHierarchies()
        {
            this._logger.name += " -AssignsForSnappableHierarchies";
            // Invoke graphql operation assignSlasForSnappableHierarchies
            InvokeMutationAssignSlasForSnappableHierarchies();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnappables.
        protected void ProcessRecord_AssignRetentionToSnappables()
        {
            this._logger.name += " -AssignRetentionToSnappables";
            // Invoke graphql operation assignRetentionSLAToSnappables
            InvokeMutationAssignRetentionSlaToSnappables();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnapshots.
        protected void ProcessRecord_AssignRetentionToSnapshots()
        {
            this._logger.name += " -AssignRetentionToSnapshots";
            // Invoke graphql operation assignRetentionSLAToSnapshots
            InvokeMutationAssignRetentionSlaToSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // pauseSla.
        protected void ProcessRecord_Pause()
        {
            this._logger.name += " -Pause";
            // Invoke graphql operation pauseSla
            InvokeMutationPauseSla();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeSlas.
        protected void ProcessRecord_Upgrades()
        {
            this._logger.name += " -Upgrades";
            // Invoke graphql operation upgradeSlas
            InvokeMutationUpgradeSlas();
        }

        // This parameter set invokes a single graphql operation:
        // getPendingSlaAssignments.
        protected void ProcessRecord_GetPendingAssignments()
        {
            this._logger.name += " -GetPendingAssignments";
            // Invoke graphql operation getPendingSlaAssignments
            InvokeMutationGetPendingSlaAssignments();
        }

        // This parameter set invokes a single graphql operation:
        // exportSlaManagedVolumeSnapshot.
        protected void ProcessRecord_ExportManagedVolumeSnapshot()
        {
            this._logger.name += " -ExportManagedVolumeSnapshot";
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
            GlobalSlaReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GlobalSlaReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateGlobalSla(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateGlobalSla",
                "($input: CreateGlobalSlaInput!)",
                fieldSpecDoc,
                "GlobalSlaReply"
            );
        }

        // Invoke GraphQL Mutation:
        // editGlobalSla(globalSlaEditRequest: GlobalSlaEditRequest!): GlobalSlaReply!
        protected void InvokeMutationEditGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaEditRequest", "GlobalSlaEditRequest!"),
            };
            GlobalSlaReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GlobalSlaReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.EditGlobalSla(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationEditGlobalSla",
                "($globalSlaEditRequest: GlobalSlaEditRequest!)",
                fieldSpecDoc,
                "GlobalSlaReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateGlobalSla(input: UpdateGlobalSlaInput!): GlobalSlaReply!
        protected void InvokeMutationUpdateGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGlobalSlaInput!"),
            };
            GlobalSlaReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GlobalSlaReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GlobalSlaReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateGlobalSla(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateGlobalSla",
                "($input: UpdateGlobalSlaInput!)",
                fieldSpecDoc,
                "GlobalSlaReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteGlobalSla(id: UUID!, userNote: String): SlaResult!
        protected void InvokeMutationDeleteGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("userNote", "String"),
            };
            SlaResult? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (SlaResult)psObject.BaseObject;
                } else {
                    fieldSpecObj = (SlaResult)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteGlobalSla(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteGlobalSla",
                "($id: UUID!,$userNote: String)",
                fieldSpecDoc,
                "SlaResult"
            );
        }

        // Invoke GraphQL Mutation:
        // assignSla(input: AssignSlaInput!): SlaAssignResult!
        protected void InvokeMutationAssignSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaInput!"),
            };
            SlaAssignResult? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (SlaAssignResult)psObject.BaseObject;
                } else {
                    fieldSpecObj = (SlaAssignResult)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AssignSla(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAssignSla",
                "($input: AssignSlaInput!)",
                fieldSpecDoc,
                "SlaAssignResult"
            );
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
            List<SlaAssignResult>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<SlaAssignResult>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<SlaAssignResult>)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AssignSlasForSnappableHierarchies(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAssignSlasForSnappableHierarchies",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!],$shouldApplyToExistingSnapshots: Boolean,$shouldApplyToNonPolicySnapshots: Boolean,$globalExistingSnapshotRetention: GlobalExistingSnapshotRetention,$userNote: String)",
                fieldSpecDoc,
                "List<SlaAssignResult>"
            );
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
            SlaAssignResult? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (SlaAssignResult)psObject.BaseObject;
                } else {
                    fieldSpecObj = (SlaAssignResult)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AssignRetentionSlaToSnappables(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAssignRetentionSlaToSnappables",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableType: WorkloadLevelHierarchy,$shouldApplyToNonPolicySnapshots: Boolean,$userNote: String)",
                fieldSpecDoc,
                "SlaAssignResult"
            );
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
            SlaAssignResult? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (SlaAssignResult)psObject.BaseObject;
                } else {
                    fieldSpecObj = (SlaAssignResult)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AssignRetentionSlaToSnapshots(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAssignRetentionSlaToSnapshots",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$snapshotFids: [UUID!]!,$userNote: String)",
                fieldSpecDoc,
                "SlaAssignResult"
            );
        }

        // Invoke GraphQL Mutation:
        // pauseSla(input: PauseSlaInput!): PauseSlaReply!
        protected void InvokeMutationPauseSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseSlaInput!"),
            };
            PauseSlaReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (PauseSlaReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (PauseSlaReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.PauseSla(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationPauseSla",
                "($input: PauseSlaInput!)",
                fieldSpecDoc,
                "PauseSlaReply"
            );
        }

        // Invoke GraphQL Mutation:
        // upgradeSlas(input: UpgradeSlasInput!): UpgradeSlasReply!
        protected void InvokeMutationUpgradeSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeSlasInput!"),
            };
            UpgradeSlasReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpgradeSlasReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpgradeSlasReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpgradeSlas(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpgradeSlas",
                "($input: UpgradeSlasInput!)",
                fieldSpecDoc,
                "UpgradeSlasReply"
            );
        }

        // Invoke GraphQL Mutation:
        // getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!): PendingSlaOperations!
        protected void InvokeMutationGetPendingSlaAssignments()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetPendingSlaAssignmentsInput!"),
            };
            PendingSlaOperations? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (PendingSlaOperations)psObject.BaseObject;
                } else {
                    fieldSpecObj = (PendingSlaOperations)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.GetPendingSlaAssignments(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationGetPendingSlaAssignments",
                "($input: GetPendingSlaAssignmentsInput!)",
                fieldSpecDoc,
                "PendingSlaOperations"
            );
        }

        // Invoke GraphQL Mutation:
        // exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!): AsyncRequestStatus!
        protected void InvokeMutationExportSlaManagedVolumeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportSlaManagedVolumeSnapshotInput!"),
            };
            AsyncRequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AsyncRequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportSlaManagedVolumeSnapshot(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportSlaManagedVolumeSnapshot",
                "($input: ExportSlaManagedVolumeSnapshotInput!)",
                fieldSpecDoc,
                "AsyncRequestStatus"
            );
        }


    } // class Invoke_RscMutateSla
}