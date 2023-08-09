// Invoke-RscMutateO365.cs
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
        "RscMutateO365",
        DefaultParameterSetName = "AddOrg")
    ]
    public class Invoke_RscMutateO365 : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // SaaSSetupKickoff parameter set
        //
        // [GraphQL: o365SaaSSetupKickoff]
        //
        [Parameter(
            ParameterSetName = "SaaSSetupKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365SaaSSetupKickoff]",
            Position = 0
        )]
        public SwitchParameter SaaSSetupKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // PdlGroups parameter set
        //
        // [GraphQL: o365PdlGroups]
        //
        [Parameter(
            ParameterSetName = "PdlGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.
[GraphQL: o365PdlGroups]",
            Position = 0
        )]
        public SwitchParameter PdlGroups { get; set; }

        
        // -------------------------------------------------------------------
        // SaasSetupComplete parameter set
        //
        // [GraphQL: o365SaasSetupComplete]
        //
        [Parameter(
            ParameterSetName = "SaasSetupComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes a Rubrik-Hosted setup flow.
[GraphQL: o365SaasSetupComplete]",
            Position = 0
        )]
        public SwitchParameter SaasSetupComplete { get; set; }

        
        // -------------------------------------------------------------------
        // SetupKickoff parameter set
        //
        // [GraphQL: o365SetupKickoff]
        //
        [Parameter(
            ParameterSetName = "SetupKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off an O365 subscription setup flow.
[GraphQL: o365SetupKickoff]",
            Position = 0
        )]
        public SwitchParameter SetupKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // AddOrg parameter set
        //
        // [GraphQL: addO365Org]
        //
        [Parameter(
            ParameterSetName = "AddOrg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Adds an O365 org to the account.
[GraphQL: addO365Org]",
            Position = 0
        )]
        public SwitchParameter AddOrg { get; set; }

        
        // -------------------------------------------------------------------
        // OauthConsentKickoff parameter set
        //
        // [GraphQL: o365OauthConsentKickoff]
        //
        [Parameter(
            ParameterSetName = "OauthConsentKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off the OAuth consent flow for an O365 Azure AD App.
[GraphQL: o365OauthConsentKickoff]",
            Position = 0
        )]
        public SwitchParameter OauthConsentKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // OauthConsentComplete parameter set
        //
        // [GraphQL: o365OauthConsentComplete]
        //
        [Parameter(
            ParameterSetName = "OauthConsentComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes the OAuth consent flow for an O365 Azure AD App.
[GraphQL: o365OauthConsentComplete]",
            Position = 0
        )]
        public SwitchParameter OauthConsentComplete { get; set; }

        
        // -------------------------------------------------------------------
        // CreateAppKickoff parameter set
        //
        // [GraphQL: createO365AppKickoff]
        //
        [Parameter(
            ParameterSetName = "CreateAppKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off the creation flow for an O365 Azure AD App.
[GraphQL: createO365AppKickoff]",
            Position = 0
        )]
        public SwitchParameter CreateAppKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // CreateAppComplete parameter set
        //
        // [GraphQL: createO365AppComplete]
        //
        [Parameter(
            ParameterSetName = "CreateAppComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes the creation flow for an O365 Azure AD App.
[GraphQL: createO365AppComplete]",
            Position = 0
        )]
        public SwitchParameter CreateAppComplete { get; set; }

        
        // -------------------------------------------------------------------
        // InsertCustomerApp parameter set
        //
        // [GraphQL: insertCustomerO365App]
        //
        [Parameter(
            ParameterSetName = "InsertCustomerApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Inserts a Customer-hosted O365 Azure AD App.
[GraphQL: insertCustomerO365App]",
            Position = 0
        )]
        public SwitchParameter InsertCustomerApp { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateAppAuthStatus parameter set
        //
        // [GraphQL: updateO365AppAuthStatus]
        //
        [Parameter(
            ParameterSetName = "UpdateAppAuthStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update O365 App authentication status to applicable app version.
[GraphQL: updateO365AppAuthStatus]",
            Position = 0
        )]
        public SwitchParameter UpdateAppAuthStatus { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateAppPermissions parameter set
        //
        // [GraphQL: updateO365AppPermissions]
        //
        [Parameter(
            ParameterSetName = "UpdateAppPermissions",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update O365 Azure app permission in Azure AD portal.
[GraphQL: updateO365AppPermissions]",
            Position = 0
        )]
        public SwitchParameter UpdateAppPermissions { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteAzureApp parameter set
        //
        // [GraphQL: deleteO365AzureApp]
        //
        [Parameter(
            ParameterSetName = "DeleteAzureApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes an O365 Azure AD App from the account.
[GraphQL: deleteO365AzureApp]",
            Position = 0
        )]
        public SwitchParameter DeleteAzureApp { get; set; }

        
        // -------------------------------------------------------------------
        // BackupMailbox parameter set
        //
        // [GraphQL: backupO365Mailbox]
        //
        [Parameter(
            ParameterSetName = "BackupMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Backup mailbox workload.
[GraphQL: backupO365Mailbox]",
            Position = 0
        )]
        public SwitchParameter BackupMailbox { get; set; }

        
        // -------------------------------------------------------------------
        // BackupOnedrive parameter set
        //
        // [GraphQL: backupO365Onedrive]
        //
        [Parameter(
            ParameterSetName = "BackupOnedrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for Onedrive.
[GraphQL: backupO365Onedrive]",
            Position = 0
        )]
        public SwitchParameter BackupOnedrive { get; set; }

        
        // -------------------------------------------------------------------
        // BackupSharepointDrive parameter set
        //
        // [GraphQL: backupO365SharepointDrive]
        //
        [Parameter(
            ParameterSetName = "BackupSharepointDrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for Sharepoint drive.
[GraphQL: backupO365SharepointDrive]",
            Position = 0
        )]
        public SwitchParameter BackupSharepointDrive { get; set; }

        
        // -------------------------------------------------------------------
        // BackupSharepointList parameter set
        //
        // [GraphQL: backupO365SharepointList]
        //
        [Parameter(
            ParameterSetName = "BackupSharepointList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for SharePoint list.
[GraphQL: backupO365SharepointList]",
            Position = 0
        )]
        public SwitchParameter BackupSharepointList { get; set; }

        
        // -------------------------------------------------------------------
        // BackupSharePointSite parameter set
        //
        // [GraphQL: backupO365SharePointSite]
        //
        [Parameter(
            ParameterSetName = "BackupSharePointSite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for a SharePoint site.
[GraphQL: backupO365SharePointSite]",
            Position = 0
        )]
        public SwitchParameter BackupSharePointSite { get; set; }

        
        // -------------------------------------------------------------------
        // BackupTeam parameter set
        //
        // [GraphQL: backupO365Team]
        //
        [Parameter(
            ParameterSetName = "BackupTeam",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for Teams.
[GraphQL: backupO365Team]",
            Position = 0
        )]
        public SwitchParameter BackupTeam { get; set; }

        
        // -------------------------------------------------------------------
        // RestoreTeamsFiles parameter set
        //
        // [GraphQL: restoreO365TeamsFiles]
        //
        [Parameter(
            ParameterSetName = "RestoreTeamsFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore Team files.
[GraphQL: restoreO365TeamsFiles]",
            Position = 0
        )]
        public SwitchParameter RestoreTeamsFiles { get; set; }

        
        // -------------------------------------------------------------------
        // ExportTeamsFiles parameter set
        //
        // [GraphQL: exportO365TeamsFiles]
        //
        [Parameter(
            ParameterSetName = "ExportTeamsFiles",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export Team files.
[GraphQL: exportO365TeamsFiles]",
            Position = 0
        )]
        public SwitchParameter ExportTeamsFiles { get; set; }

        
        // -------------------------------------------------------------------
        // RestoreTeamsConversations parameter set
        //
        // [GraphQL: restoreO365TeamsConversations]
        //
        [Parameter(
            ParameterSetName = "RestoreTeamsConversations",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore Team conversations.
[GraphQL: restoreO365TeamsConversations]",
            Position = 0
        )]
        public SwitchParameter RestoreTeamsConversations { get; set; }

        
        // -------------------------------------------------------------------
        // RestoreSnappable parameter set
        //
        // [GraphQL: restoreO365Snappable]
        //
        [Parameter(
            ParameterSetName = "RestoreSnappable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restores an O365 snappable.
[GraphQL: restoreO365Snappable]",
            Position = 0
        )]
        public SwitchParameter RestoreSnappable { get; set; }

        
        // -------------------------------------------------------------------
        // ExportWorkload parameter set
        //
        // [GraphQL: exportO365Workload]
        //
        [Parameter(
            ParameterSetName = "ExportWorkload",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export an O365 workload.
[GraphQL: exportO365Workload]",
            Position = 0
        )]
        public SwitchParameter ExportWorkload { get; set; }

        
        // -------------------------------------------------------------------
        // RefreshOrg parameter set
        //
        // [GraphQL: refreshO365Org]
        //
        [Parameter(
            ParameterSetName = "RefreshOrg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refreshes an O365 org.
[GraphQL: refreshO365Org]",
            Position = 0
        )]
        public SwitchParameter RefreshOrg { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteOrg parameter set
        //
        // [GraphQL: deleteO365Org]
        //
        [Parameter(
            ParameterSetName = "DeleteOrg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes an O365 org from the account.
[GraphQL: deleteO365Org]",
            Position = 0
        )]
        public SwitchParameter DeleteOrg { get; set; }

        
        // -------------------------------------------------------------------
        // RestoreMailbox parameter set
        //
        // [GraphQL: restoreO365Mailbox]
        //
        [Parameter(
            ParameterSetName = "RestoreMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restores an Exchange mailbox.
[GraphQL: restoreO365Mailbox]",
            Position = 0
        )]
        public SwitchParameter RestoreMailbox { get; set; }

        
        // -------------------------------------------------------------------
        // ExportMailbox parameter set
        //
        // [GraphQL: exportO365Mailbox]
        //
        [Parameter(
            ParameterSetName = "ExportMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Exports an Exchange mailbox.
[GraphQL: exportO365Mailbox]",
            Position = 0
        )]
        public SwitchParameter ExportMailbox { get; set; }

        
        // -------------------------------------------------------------------
        // SetServiceAccount parameter set
        //
        // [GraphQL: setO365ServiceAccount]
        //
        [Parameter(
            ParameterSetName = "SetServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sets the service account for the org.
[GraphQL: setO365ServiceAccount]",
            Position = 0
        )]
        public SwitchParameter SetServiceAccount { get; set; }

        
        // -------------------------------------------------------------------
        // EnableSharePoint parameter set
        //
        // [GraphQL: enableO365SharePoint]
        //
        [Parameter(
            ParameterSetName = "EnableSharePoint",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Enables SharePoint protection in the exocompute cluster.
[GraphQL: enableO365SharePoint]",
            Position = 0
        )]
        public SwitchParameter EnableSharePoint { get; set; }

        
        // -------------------------------------------------------------------
        // EnableTeams parameter set
        //
        // [GraphQL: enableO365Teams]
        //
        [Parameter(
            ParameterSetName = "EnableTeams",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Enables Teams protection in the exocompute cluster.
[GraphQL: enableO365Teams]",
            Position = 0
        )]
        public SwitchParameter EnableTeams { get; set; }

        
        // -------------------------------------------------------------------
        // DeleteServiceAccount parameter set
        //
        // [GraphQL: deleteO365ServiceAccount]
        //
        [Parameter(
            ParameterSetName = "DeleteServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes the service account for an org.
[GraphQL: deleteO365ServiceAccount]",
            Position = 0
        )]
        public SwitchParameter DeleteServiceAccount { get; set; }

        
        // -------------------------------------------------------------------
        // UpdateOrgCustomName parameter set
        //
        // [GraphQL: updateO365OrgCustomName]
        //
        [Parameter(
            ParameterSetName = "UpdateOrgCustomName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the custom name for an O365 Organization.
[GraphQL: updateO365OrgCustomName]",
            Position = 0
        )]
        public SwitchParameter UpdateOrgCustomName { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "SaaSSetupKickoff":
                        this.ProcessRecord_SaaSSetupKickoff();
                        break;
                    case "PdlGroups":
                        this.ProcessRecord_PdlGroups();
                        break;
                    case "SaasSetupComplete":
                        this.ProcessRecord_SaasSetupComplete();
                        break;
                    case "SetupKickoff":
                        this.ProcessRecord_SetupKickoff();
                        break;
                    case "AddOrg":
                        this.ProcessRecord_AddOrg();
                        break;
                    case "OauthConsentKickoff":
                        this.ProcessRecord_OauthConsentKickoff();
                        break;
                    case "OauthConsentComplete":
                        this.ProcessRecord_OauthConsentComplete();
                        break;
                    case "CreateAppKickoff":
                        this.ProcessRecord_CreateAppKickoff();
                        break;
                    case "CreateAppComplete":
                        this.ProcessRecord_CreateAppComplete();
                        break;
                    case "InsertCustomerApp":
                        this.ProcessRecord_InsertCustomerApp();
                        break;
                    case "UpdateAppAuthStatus":
                        this.ProcessRecord_UpdateAppAuthStatus();
                        break;
                    case "UpdateAppPermissions":
                        this.ProcessRecord_UpdateAppPermissions();
                        break;
                    case "DeleteAzureApp":
                        this.ProcessRecord_DeleteAzureApp();
                        break;
                    case "BackupMailbox":
                        this.ProcessRecord_BackupMailbox();
                        break;
                    case "BackupOnedrive":
                        this.ProcessRecord_BackupOnedrive();
                        break;
                    case "BackupSharepointDrive":
                        this.ProcessRecord_BackupSharepointDrive();
                        break;
                    case "BackupSharepointList":
                        this.ProcessRecord_BackupSharepointList();
                        break;
                    case "BackupSharePointSite":
                        this.ProcessRecord_BackupSharePointSite();
                        break;
                    case "BackupTeam":
                        this.ProcessRecord_BackupTeam();
                        break;
                    case "RestoreTeamsFiles":
                        this.ProcessRecord_RestoreTeamsFiles();
                        break;
                    case "ExportTeamsFiles":
                        this.ProcessRecord_ExportTeamsFiles();
                        break;
                    case "RestoreTeamsConversations":
                        this.ProcessRecord_RestoreTeamsConversations();
                        break;
                    case "RestoreSnappable":
                        this.ProcessRecord_RestoreSnappable();
                        break;
                    case "ExportWorkload":
                        this.ProcessRecord_ExportWorkload();
                        break;
                    case "RefreshOrg":
                        this.ProcessRecord_RefreshOrg();
                        break;
                    case "DeleteOrg":
                        this.ProcessRecord_DeleteOrg();
                        break;
                    case "RestoreMailbox":
                        this.ProcessRecord_RestoreMailbox();
                        break;
                    case "ExportMailbox":
                        this.ProcessRecord_ExportMailbox();
                        break;
                    case "SetServiceAccount":
                        this.ProcessRecord_SetServiceAccount();
                        break;
                    case "EnableSharePoint":
                        this.ProcessRecord_EnableSharePoint();
                        break;
                    case "EnableTeams":
                        this.ProcessRecord_EnableTeams();
                        break;
                    case "DeleteServiceAccount":
                        this.ProcessRecord_DeleteServiceAccount();
                        break;
                    case "UpdateOrgCustomName":
                        this.ProcessRecord_UpdateOrgCustomName();
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
        // o365SaaSSetupKickoff.
        protected void ProcessRecord_SaaSSetupKickoff()
        {
            this._logger.name += " -SaaSSetupKickoff";
            // Invoke graphql operation o365SaaSSetupKickoff
            InvokeMutationO365SaaSsetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365PdlGroups.
        protected void ProcessRecord_PdlGroups()
        {
            this._logger.name += " -PdlGroups";
            // Invoke graphql operation o365PdlGroups
            InvokeMutationO365PdlGroups();
        }

        // This parameter set invokes a single graphql operation:
        // o365SaasSetupComplete.
        protected void ProcessRecord_SaasSetupComplete()
        {
            this._logger.name += " -SaasSetupComplete";
            // Invoke graphql operation o365SaasSetupComplete
            InvokeMutationO365SaasSetupComplete();
        }

        // This parameter set invokes a single graphql operation:
        // o365SetupKickoff.
        protected void ProcessRecord_SetupKickoff()
        {
            this._logger.name += " -SetupKickoff";
            // Invoke graphql operation o365SetupKickoff
            InvokeMutationO365SetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // addO365Org.
        protected void ProcessRecord_AddOrg()
        {
            this._logger.name += " -AddOrg";
            // Invoke graphql operation addO365Org
            InvokeMutationAddO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentKickoff.
        protected void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Invoke graphql operation o365OauthConsentKickoff
            InvokeMutationO365OauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentComplete.
        protected void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Invoke graphql operation o365OauthConsentComplete
            InvokeMutationO365OauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppKickoff.
        protected void ProcessRecord_CreateAppKickoff()
        {
            this._logger.name += " -CreateAppKickoff";
            // Invoke graphql operation createO365AppKickoff
            InvokeMutationCreateO365AppKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppComplete.
        protected void ProcessRecord_CreateAppComplete()
        {
            this._logger.name += " -CreateAppComplete";
            // Invoke graphql operation createO365AppComplete
            InvokeMutationCreateO365AppComplete();
        }

        // This parameter set invokes a single graphql operation:
        // insertCustomerO365App.
        protected void ProcessRecord_InsertCustomerApp()
        {
            this._logger.name += " -InsertCustomerApp";
            // Invoke graphql operation insertCustomerO365App
            InvokeMutationInsertCustomerO365App();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppAuthStatus.
        protected void ProcessRecord_UpdateAppAuthStatus()
        {
            this._logger.name += " -UpdateAppAuthStatus";
            // Invoke graphql operation updateO365AppAuthStatus
            InvokeMutationUpdateO365AppAuthStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppPermissions.
        protected void ProcessRecord_UpdateAppPermissions()
        {
            this._logger.name += " -UpdateAppPermissions";
            // Invoke graphql operation updateO365AppPermissions
            InvokeMutationUpdateO365AppPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365AzureApp.
        protected void ProcessRecord_DeleteAzureApp()
        {
            this._logger.name += " -DeleteAzureApp";
            // Invoke graphql operation deleteO365AzureApp
            InvokeMutationDeleteO365AzureApp();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Mailbox.
        protected void ProcessRecord_BackupMailbox()
        {
            this._logger.name += " -BackupMailbox";
            // Invoke graphql operation backupO365Mailbox
            InvokeMutationBackupO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Onedrive.
        protected void ProcessRecord_BackupOnedrive()
        {
            this._logger.name += " -BackupOnedrive";
            // Invoke graphql operation backupO365Onedrive
            InvokeMutationBackupO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointDrive.
        protected void ProcessRecord_BackupSharepointDrive()
        {
            this._logger.name += " -BackupSharepointDrive";
            // Invoke graphql operation backupO365SharepointDrive
            InvokeMutationBackupO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointList.
        protected void ProcessRecord_BackupSharepointList()
        {
            this._logger.name += " -BackupSharepointList";
            // Invoke graphql operation backupO365SharepointList
            InvokeMutationBackupO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharePointSite.
        protected void ProcessRecord_BackupSharePointSite()
        {
            this._logger.name += " -BackupSharePointSite";
            // Invoke graphql operation backupO365SharePointSite
            InvokeMutationBackupO365SharePointSite();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Team.
        protected void ProcessRecord_BackupTeam()
        {
            this._logger.name += " -BackupTeam";
            // Invoke graphql operation backupO365Team
            InvokeMutationBackupO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsFiles.
        protected void ProcessRecord_RestoreTeamsFiles()
        {
            this._logger.name += " -RestoreTeamsFiles";
            // Invoke graphql operation restoreO365TeamsFiles
            InvokeMutationRestoreO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365TeamsFiles.
        protected void ProcessRecord_ExportTeamsFiles()
        {
            this._logger.name += " -ExportTeamsFiles";
            // Invoke graphql operation exportO365TeamsFiles
            InvokeMutationExportO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsConversations.
        protected void ProcessRecord_RestoreTeamsConversations()
        {
            this._logger.name += " -RestoreTeamsConversations";
            // Invoke graphql operation restoreO365TeamsConversations
            InvokeMutationRestoreO365TeamsConversations();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Snappable.
        protected void ProcessRecord_RestoreSnappable()
        {
            this._logger.name += " -RestoreSnappable";
            // Invoke graphql operation restoreO365Snappable
            InvokeMutationRestoreO365Snappable();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Workload.
        protected void ProcessRecord_ExportWorkload()
        {
            this._logger.name += " -ExportWorkload";
            // Invoke graphql operation exportO365Workload
            InvokeMutationExportO365Workload();
        }

        // This parameter set invokes a single graphql operation:
        // refreshO365Org.
        protected void ProcessRecord_RefreshOrg()
        {
            this._logger.name += " -RefreshOrg";
            // Invoke graphql operation refreshO365Org
            InvokeMutationRefreshO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365Org.
        protected void ProcessRecord_DeleteOrg()
        {
            this._logger.name += " -DeleteOrg";
            // Invoke graphql operation deleteO365Org
            InvokeMutationDeleteO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Mailbox.
        protected void ProcessRecord_RestoreMailbox()
        {
            this._logger.name += " -RestoreMailbox";
            // Invoke graphql operation restoreO365Mailbox
            InvokeMutationRestoreO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Mailbox.
        protected void ProcessRecord_ExportMailbox()
        {
            this._logger.name += " -ExportMailbox";
            // Invoke graphql operation exportO365Mailbox
            InvokeMutationExportO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // setO365ServiceAccount.
        protected void ProcessRecord_SetServiceAccount()
        {
            this._logger.name += " -SetServiceAccount";
            // Invoke graphql operation setO365ServiceAccount
            InvokeMutationSetO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365SharePoint.
        protected void ProcessRecord_EnableSharePoint()
        {
            this._logger.name += " -EnableSharePoint";
            // Invoke graphql operation enableO365SharePoint
            InvokeMutationEnableO365SharePoint();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365Teams.
        protected void ProcessRecord_EnableTeams()
        {
            this._logger.name += " -EnableTeams";
            // Invoke graphql operation enableO365Teams
            InvokeMutationEnableO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365ServiceAccount.
        protected void ProcessRecord_DeleteServiceAccount()
        {
            this._logger.name += " -DeleteServiceAccount";
            // Invoke graphql operation deleteO365ServiceAccount
            InvokeMutationDeleteO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365OrgCustomName.
        protected void ProcessRecord_UpdateOrgCustomName()
        {
            this._logger.name += " -UpdateOrgCustomName";
            // Invoke graphql operation updateO365OrgCustomName
            InvokeMutationUpdateO365OrgCustomName();
        }


        // Invoke GraphQL Mutation:
        // o365SaaSSetupKickoff: O365SaasSetupKickoffReply!
        protected void InvokeMutationO365SaaSsetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            O365SaasSetupKickoffReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SaasSetupKickoffReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SaasSetupKickoffReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.O365SaaSsetupKickoff(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationO365SaaSsetupKickoff",
                "",
                fieldSpecDoc,
                "O365SaasSetupKickoffReply"
            );
        }

        // Invoke GraphQL Mutation:
        // o365PdlGroups(input: O365PdlGroupsInput!): O365PdlGroupsReply!
        protected void InvokeMutationO365PdlGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365PdlGroupsInput!"),
            };
            O365PdlGroupsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365PdlGroupsReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365PdlGroupsReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.O365PdlGroups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationO365PdlGroups",
                "($input: O365PdlGroupsInput!)",
                fieldSpecDoc,
                "O365PdlGroupsReply"
            );
        }

        // Invoke GraphQL Mutation:
        // o365SaasSetupComplete(input: O365SaasSetupCompleteInput!): AddO365OrgResponse!
        protected void InvokeMutationO365SaasSetupComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365SaasSetupCompleteInput!"),
            };
            AddO365OrgResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddO365OrgResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddO365OrgResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.O365SaasSetupComplete(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationO365SaasSetupComplete",
                "($input: O365SaasSetupCompleteInput!)",
                fieldSpecDoc,
                "AddO365OrgResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // o365SetupKickoff: O365SetupKickoffResp!
        protected void InvokeMutationO365SetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            O365SetupKickoffResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SetupKickoffResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SetupKickoffResp)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.O365SetupKickoff(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationO365SetupKickoff",
                "",
                fieldSpecDoc,
                "O365SetupKickoffResp"
            );
        }

        // Invoke GraphQL Mutation:
        // addO365Org(input: AddO365OrgInput!): AddO365OrgResponse!
        protected void InvokeMutationAddO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddO365OrgInput!"),
            };
            AddO365OrgResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (AddO365OrgResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (AddO365OrgResponse)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.AddO365Org(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationAddO365Org",
                "($input: AddO365OrgInput!)",
                fieldSpecDoc,
                "AddO365OrgResponse"
            );
        }

        // Invoke GraphQL Mutation:
        // o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!): O365OauthConsentKickoffReply!
        protected void InvokeMutationO365OauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentKickoffInput!"),
            };
            O365OauthConsentKickoffReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365OauthConsentKickoffReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365OauthConsentKickoffReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.O365OauthConsentKickoff(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationO365OauthConsentKickoff",
                "($input: O365OauthConsentKickoffInput!)",
                fieldSpecDoc,
                "O365OauthConsentKickoffReply"
            );
        }

        // Invoke GraphQL Mutation:
        // o365OauthConsentComplete(input: O365OauthConsentCompleteInput!): O365OauthConsentCompleteReply!
        protected void InvokeMutationO365OauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentCompleteInput!"),
            };
            O365OauthConsentCompleteReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365OauthConsentCompleteReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365OauthConsentCompleteReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.O365OauthConsentComplete(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationO365OauthConsentComplete",
                "($input: O365OauthConsentCompleteInput!)",
                fieldSpecDoc,
                "O365OauthConsentCompleteReply"
            );
        }

        // Invoke GraphQL Mutation:
        // createO365AppKickoff(input: CreateO365AppKickoffInput!): CreateO365AppKickoffResp!
        protected void InvokeMutationCreateO365AppKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppKickoffInput!"),
            };
            CreateO365AppKickoffResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateO365AppKickoffResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateO365AppKickoffResp)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateO365AppKickoff(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateO365AppKickoff",
                "($input: CreateO365AppKickoffInput!)",
                fieldSpecDoc,
                "CreateO365AppKickoffResp"
            );
        }

        // Invoke GraphQL Mutation:
        // createO365AppComplete(input: CreateO365AppCompleteInput!): RequestStatus!
        protected void InvokeMutationCreateO365AppComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppCompleteInput!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CreateO365AppComplete(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCreateO365AppComplete",
                "($input: CreateO365AppCompleteInput!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // insertCustomerO365App(input: InsertCustomerO365AppInput!): RequestStatus!
        protected void InvokeMutationInsertCustomerO365App()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InsertCustomerO365AppInput!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.InsertCustomerO365App(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationInsertCustomerO365App",
                "($input: InsertCustomerO365AppInput!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!): UpdateO365AppAuthStatusReply!
        protected void InvokeMutationUpdateO365AppAuthStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppAuthStatusInput!"),
            };
            UpdateO365AppAuthStatusReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateO365AppAuthStatusReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateO365AppAuthStatusReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateO365AppAuthStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateO365AppAuthStatus",
                "($input: UpdateO365AppAuthStatusInput!)",
                fieldSpecDoc,
                "UpdateO365AppAuthStatusReply"
            );
        }

        // Invoke GraphQL Mutation:
        // updateO365AppPermissions(input: UpdateO365AppPermissionsInput!): Void
        protected void InvokeMutationUpdateO365AppPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppPermissionsInput!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateO365AppPermissions(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateO365AppPermissions",
                "($input: UpdateO365AppPermissionsInput!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!): RequestStatus!
        protected void InvokeMutationDeleteO365AzureApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("o365AppClientId", "String!"),
                Tuple.Create("o365AppType", "String!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteO365AzureApp(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteO365AzureApp",
                "($o365AppClientId: String!,$o365AppType: String!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // backupO365Mailbox(mailboxIds: [UUID!]!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("mailboxIds", "[UUID!]!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BackupO365Mailbox(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBackupO365Mailbox",
                "($mailboxIds: [UUID!]!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // backupO365Onedrive(input: BackupO365OnedriveInput!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365OnedriveInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BackupO365Onedrive(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBackupO365Onedrive",
                "($input: BackupO365OnedriveInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // backupO365SharepointDrive(input: BackupO365SharepointDriveInput!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharepointDriveInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BackupO365SharepointDrive(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBackupO365SharepointDrive",
                "($input: BackupO365SharepointDriveInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // backupO365SharepointList(input: BackupO365SharePointListInput!): CreateOnDemandJobReply!
        protected void InvokeMutationBackupO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointListInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BackupO365SharepointList(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBackupO365SharepointList",
                "($input: BackupO365SharePointListInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
        protected void InvokeMutationBackupO365SharePointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointSiteInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BackupO365SharePointSite(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBackupO365SharePointSite",
                "($input: BackupO365SharePointSiteInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365TeamInput!"),
            };
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (BatchAsyncJobStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.BackupO365Team(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationBackupO365Team",
                "($input: BackupO365TeamInput!)",
                fieldSpecDoc,
                "BatchAsyncJobStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365TeamsFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsFilesInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreO365TeamsFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreO365TeamsFiles",
                "($input: RestoreO365TeamsFilesInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // exportO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        protected void InvokeMutationExportO365TeamsFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsFilesInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportO365TeamsFiles(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportO365TeamsFiles",
                "($input: RestoreO365TeamsFilesInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365TeamsConversations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsConversationsInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreO365TeamsConversations(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreO365TeamsConversations",
                "($input: RestoreO365TeamsConversationsInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365Snappable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreO365Snappable(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreO365Snappable",
                "($input: RestoreO365SnappableInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // exportO365Workload(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        protected void InvokeMutationExportO365Workload()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportO365Workload(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportO365Workload",
                "($input: RestoreO365SnappableInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // refreshO365Org(orgId: UUID!): CreateOnDemandJobReply!
        protected void InvokeMutationRefreshO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RefreshO365Org(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRefreshO365Org",
                "($orgId: UUID!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
        protected void InvokeMutationDeleteO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteO365Org(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteO365Org",
                "($orgId: UUID!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("restoreConfig", "RestoreO365MailboxInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.RestoreO365Mailbox(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationRestoreO365Mailbox",
                "($restoreConfig: RestoreO365MailboxInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
        protected void InvokeMutationExportO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exportConfig", "ExportO365MailboxInput!"),
            };
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (CreateOnDemandJobReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.ExportO365Mailbox(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationExportO365Mailbox",
                "($exportConfig: ExportO365MailboxInput!)",
                fieldSpecDoc,
                "CreateOnDemandJobReply"
            );
        }

        // Invoke GraphQL Mutation:
        // setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!): RequestStatus!
        protected void InvokeMutationSetO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("username", "String!"),
                Tuple.Create("appPassword", "String!"),
                Tuple.Create("orgId", "UUID!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.SetO365ServiceAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationSetO365ServiceAccount",
                "($username: String!,$appPassword: String!,$orgId: UUID!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // enableO365SharePoint(input: EnableO365SharePointInput!): RequestStatus!
        protected void InvokeMutationEnableO365SharePoint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableO365SharePointInput!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.EnableO365SharePoint(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationEnableO365SharePoint",
                "($input: EnableO365SharePointInput!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // enableO365Teams(exocomputeClusterId: String!): RequestStatus!
        protected void InvokeMutationEnableO365Teams()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.EnableO365Teams(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationEnableO365Teams",
                "($exocomputeClusterId: String!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // deleteO365ServiceAccount(orgId: UUID!): RequestStatus!
        protected void InvokeMutationDeleteO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (RequestStatus)psObject.BaseObject;
                } else {
                    fieldSpecObj = (RequestStatus)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.DeleteO365ServiceAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationDeleteO365ServiceAccount",
                "($orgId: UUID!)",
                fieldSpecDoc,
                "RequestStatus"
            );
        }

        // Invoke GraphQL Mutation:
        // updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!): UpdateO365OrgCustomNameReply!
        protected void InvokeMutationUpdateO365OrgCustomName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365OrgCustomNameInput!"),
            };
            UpdateO365OrgCustomNameReply? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (UpdateO365OrgCustomNameReply)psObject.BaseObject;
                } else {
                    fieldSpecObj = (UpdateO365OrgCustomNameReply)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.UpdateO365OrgCustomName(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationUpdateO365OrgCustomName",
                "($input: UpdateO365OrgCustomNameInput!)",
                fieldSpecDoc,
                "UpdateO365OrgCustomNameReply"
            );
        }


    } // class Invoke_RscMutateO365
}