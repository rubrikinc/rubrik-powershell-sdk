// Invoke-RscMutateO365.cs
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
        "RscMutateO365",
        DefaultParameterSetName = "addOrg")
    ]
    public class Invoke_RscMutateO365 : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // SaaSSetupKickoff parameter set
        //
        // GraphQL operation: o365SaaSSetupKickoff:O365SaasSetupKickoffReply!
        //
        [Parameter(
            ParameterSetName = "SaaSSetupKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL operation: o365SaaSSetupKickoff:O365SaasSetupKickoffReply!
                ",
            Position = 0
        )]
        public SwitchParameter SaaSSetupKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // PdlGroup parameter set
        //
        // GraphQL operation: o365PdlGroups(input: O365PdlGroupsInput!):O365PdlGroupsReply!
        //
        [Parameter(
            ParameterSetName = "PdlGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.
                GraphQL operation: o365PdlGroups(input: O365PdlGroupsInput!):O365PdlGroupsReply!
                ",
            Position = 0
        )]
        public SwitchParameter PdlGroup { get; set; }

        [Parameter(
            ParameterSetName = "PdlGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The input for the O365PdlGroups mutation.
                GraphQL argument input: O365PdlGroupsInput!
                "
        )]
        public O365PdlGroupsInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // SaasSetupComplete parameter set
        //
        // GraphQL operation: o365SaasSetupComplete(input: O365SaasSetupCompleteInput!):AddO365OrgResponse!
        //
        [Parameter(
            ParameterSetName = "SaasSetupComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Completes a Rubrik-Hosted setup flow.
                GraphQL operation: o365SaasSetupComplete(input: O365SaasSetupCompleteInput!):AddO365OrgResponse!
                ",
            Position = 0
        )]
        public SwitchParameter SaasSetupComplete { get; set; }

        
        // -------------------------------------------------------------------
        // SetupKickoff parameter set
        //
        // GraphQL operation: o365SetupKickoff:O365SetupKickoffResp!
        //
        [Parameter(
            ParameterSetName = "SetupKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Kicks off an O365 subscription setup flow.
                GraphQL operation: o365SetupKickoff:O365SetupKickoffResp!
                ",
            Position = 0
        )]
        public SwitchParameter SetupKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // addOrg parameter set
        //
        // GraphQL operation: addO365Org(input: AddO365OrgInput!):AddO365OrgResponse!
        //
        [Parameter(
            ParameterSetName = "addOrg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Adds an O365 org to the account.
                GraphQL operation: addO365Org(input: AddO365OrgInput!):AddO365OrgResponse!
                ",
            Position = 0
        )]
        public SwitchParameter addOrg { get; set; }

        
        // -------------------------------------------------------------------
        // OauthConsentKickoff parameter set
        //
        // GraphQL operation: o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!):O365OauthConsentKickoffReply!
        //
        [Parameter(
            ParameterSetName = "OauthConsentKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Kicks off the OAuth consent flow for an O365 Azure AD App.
                GraphQL operation: o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!):O365OauthConsentKickoffReply!
                ",
            Position = 0
        )]
        public SwitchParameter OauthConsentKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // OauthConsentComplete parameter set
        //
        // GraphQL operation: o365OauthConsentComplete(input: O365OauthConsentCompleteInput!):O365OauthConsentCompleteReply!
        //
        [Parameter(
            ParameterSetName = "OauthConsentComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Completes the OAuth consent flow for an O365 Azure AD App.
                GraphQL operation: o365OauthConsentComplete(input: O365OauthConsentCompleteInput!):O365OauthConsentCompleteReply!
                ",
            Position = 0
        )]
        public SwitchParameter OauthConsentComplete { get; set; }

        
        // -------------------------------------------------------------------
        // createAppKickoff parameter set
        //
        // GraphQL operation: createO365AppKickoff(input: CreateO365AppKickoffInput!):CreateO365AppKickoffResp!
        //
        [Parameter(
            ParameterSetName = "createAppKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Kicks off the creation flow for an O365 Azure AD App.
                GraphQL operation: createO365AppKickoff(input: CreateO365AppKickoffInput!):CreateO365AppKickoffResp!
                ",
            Position = 0
        )]
        public SwitchParameter createAppKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // createAppComplete parameter set
        //
        // GraphQL operation: createO365AppComplete(input: CreateO365AppCompleteInput!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "createAppComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Completes the creation flow for an O365 Azure AD App.
                GraphQL operation: createO365AppComplete(input: CreateO365AppCompleteInput!):RequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter createAppComplete { get; set; }

        
        // -------------------------------------------------------------------
        // insertCustomerApp parameter set
        //
        // GraphQL operation: insertCustomerO365App(input: InsertCustomerO365AppInput!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "insertCustomerApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Inserts a Customer-hosted O365 Azure AD App.
                GraphQL operation: insertCustomerO365App(input: InsertCustomerO365AppInput!):RequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter insertCustomerApp { get; set; }

        
        // -------------------------------------------------------------------
        // updateAppAuthStatus parameter set
        //
        // GraphQL operation: updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!):UpdateO365AppAuthStatusReply!
        //
        [Parameter(
            ParameterSetName = "updateAppAuthStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update O365 App authentication status to applicable app version.
                GraphQL operation: updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!):UpdateO365AppAuthStatusReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateAppAuthStatus { get; set; }

        
        // -------------------------------------------------------------------
        // updateAppPermission parameter set
        //
        // GraphQL operation: updateO365AppPermissions(input: UpdateO365AppPermissionsInput!):Void
        //
        [Parameter(
            ParameterSetName = "updateAppPermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update O365 Azure app permission in Azure AD portal.
                GraphQL operation: updateO365AppPermissions(input: UpdateO365AppPermissionsInput!):Void
                ",
            Position = 0
        )]
        public SwitchParameter updateAppPermission { get; set; }

        
        // -------------------------------------------------------------------
        // deleteAzureApp parameter set
        //
        // GraphQL operation: deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteAzureApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Deletes an O365 Azure AD App from the account.
                GraphQL operation: deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!):RequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter deleteAzureApp { get; set; }

        [Parameter(
            ParameterSetName = "deleteAzureApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument o365AppClientId: String!
                "
        )]
        public System.String? O365AppClientId { get; set; }
        [Parameter(
            ParameterSetName = "deleteAzureApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument o365AppType: String!
                "
        )]
        public System.String? O365AppType { get; set; }
        
        // -------------------------------------------------------------------
        // backupMailbox parameter set
        //
        // GraphQL operation: backupO365Mailbox(mailboxIds: [UUID!]!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "backupMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Backup mailbox workload.
                GraphQL operation: backupO365Mailbox(mailboxIds: [UUID!]!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter backupMailbox { get; set; }

        [Parameter(
            ParameterSetName = "backupMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The list of mailbox UUIDs to backup.
                GraphQL argument mailboxIds: [UUID!]!
                "
        )]
        public List<System.String>? MailboxIds { get; set; }
        
        // -------------------------------------------------------------------
        // backupOnedrive parameter set
        //
        // GraphQL operation: backupO365Onedrive(input: BackupO365OnedriveInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "backupOnedrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take on-demand snapshot for Onedrive.
                GraphQL operation: backupO365Onedrive(input: BackupO365OnedriveInput!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter backupOnedrive { get; set; }

        
        // -------------------------------------------------------------------
        // backupSharepointDrive parameter set
        //
        // GraphQL operation: backupO365SharepointDrive(input: BackupO365SharepointDriveInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "backupSharepointDrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take on-demand snapshot for Sharepoint drive.
                GraphQL operation: backupO365SharepointDrive(input: BackupO365SharepointDriveInput!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter backupSharepointDrive { get; set; }

        
        // -------------------------------------------------------------------
        // backupSharepointList parameter set
        //
        // GraphQL operation: backupO365SharepointList(input: BackupO365SharePointListInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "backupSharepointList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take on-demand snapshot for SharePoint list.
                GraphQL operation: backupO365SharepointList(input: BackupO365SharePointListInput!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter backupSharepointList { get; set; }

        
        // -------------------------------------------------------------------
        // backupSharePointSite parameter set
        //
        // GraphQL operation: backupO365SharePointSite(input: BackupO365SharePointSiteInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "backupSharePointSite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take on-demand snapshot for a SharePoint site.
                GraphQL operation: backupO365SharePointSite(input: BackupO365SharePointSiteInput!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter backupSharePointSite { get; set; }

        
        // -------------------------------------------------------------------
        // backupTeam parameter set
        //
        // GraphQL operation: backupO365Team(input: BackupO365TeamInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "backupTeam",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Take on-demand snapshot for Teams.
                GraphQL operation: backupO365Team(input: BackupO365TeamInput!):BatchAsyncJobStatus!
                ",
            Position = 0
        )]
        public SwitchParameter backupTeam { get; set; }

        
        // -------------------------------------------------------------------
        // restoreTeamsFile parameter set
        //
        // GraphQL operation: restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "restoreTeamsFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Restore Team files.
                GraphQL operation: restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter restoreTeamsFile { get; set; }

        
        // -------------------------------------------------------------------
        // restoreTeamsConversation parameter set
        //
        // GraphQL operation: restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "restoreTeamsConversation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Restore Team conversations.
                GraphQL operation: restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter restoreTeamsConversation { get; set; }

        
        // -------------------------------------------------------------------
        // restoreSnappable parameter set
        //
        // GraphQL operation: restoreO365Snappable(input: RestoreO365SnappableInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "restoreSnappable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Restores an O365 snappable.
                GraphQL operation: restoreO365Snappable(input: RestoreO365SnappableInput!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter restoreSnappable { get; set; }

        
        // -------------------------------------------------------------------
        // refreshOrg parameter set
        //
        // GraphQL operation: refreshO365Org(orgId: UUID!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "refreshOrg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Refreshes an O365 org.
                GraphQL operation: refreshO365Org(orgId: UUID!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter refreshOrg { get; set; }

        [Parameter(
            ParameterSetName = "refreshOrg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Org UUID.
                GraphQL argument orgId: UUID!
                "
        )]
        public System.String? OrgId { get; set; }
        
        // -------------------------------------------------------------------
        // deleteOrg parameter set
        //
        // GraphQL operation: deleteO365Org(orgId: UUID!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "deleteOrg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Deletes an O365 org from the account.
                GraphQL operation: deleteO365Org(orgId: UUID!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter deleteOrg { get; set; }

        
        // -------------------------------------------------------------------
        // restoreMailbox parameter set
        //
        // GraphQL operation: restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "restoreMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Restores an Exchange mailbox.
                GraphQL operation: restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter restoreMailbox { get; set; }

        [Parameter(
            ParameterSetName = "restoreMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument restoreConfig: RestoreO365MailboxInput!
                "
        )]
        public RestoreO365MailboxInput? RestoreConfig { get; set; }
        
        // -------------------------------------------------------------------
        // exportMailbox parameter set
        //
        // GraphQL operation: exportO365Mailbox(exportConfig: ExportO365MailboxInput!):CreateOnDemandJobReply!
        //
        [Parameter(
            ParameterSetName = "exportMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Exports an Exchange mailbox.
                GraphQL operation: exportO365Mailbox(exportConfig: ExportO365MailboxInput!):CreateOnDemandJobReply!
                ",
            Position = 0
        )]
        public SwitchParameter exportMailbox { get; set; }

        [Parameter(
            ParameterSetName = "exportMailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument exportConfig: ExportO365MailboxInput!
                "
        )]
        public ExportO365MailboxInput? ExportConfig { get; set; }
        
        // -------------------------------------------------------------------
        // setServiceAccount parameter set
        //
        // GraphQL operation: setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "setServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sets the service account for the org.
                GraphQL operation: setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!):RequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter setServiceAccount { get; set; }

        [Parameter(
            ParameterSetName = "setServiceAccount",
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
            ParameterSetName = "setServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument appPassword: String!
                "
        )]
        public System.String? AppPassword { get; set; }
        
        // -------------------------------------------------------------------
        // enableSharePoint parameter set
        //
        // GraphQL operation: enableO365SharePoint(input: EnableO365SharePointInput!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "enableSharePoint",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Enables SharePoint protection in the exocompute cluster.
                GraphQL operation: enableO365SharePoint(input: EnableO365SharePointInput!):RequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter enableSharePoint { get; set; }

        
        // -------------------------------------------------------------------
        // enableTeam parameter set
        //
        // GraphQL operation: enableO365Teams(exocomputeClusterId: String!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "enableTeam",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Enables Teams protection in the exocompute cluster.
                GraphQL operation: enableO365Teams(exocomputeClusterId: String!):RequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter enableTeam { get; set; }

        [Parameter(
            ParameterSetName = "enableTeam",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                
                GraphQL argument exocomputeClusterId: String!
                "
        )]
        public System.String? ExocomputeClusterId { get; set; }
        
        // -------------------------------------------------------------------
        // deleteServiceAccount parameter set
        //
        // GraphQL operation: deleteO365ServiceAccount(orgId: UUID!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "deleteServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Deletes the service account for an org.
                GraphQL operation: deleteO365ServiceAccount(orgId: UUID!):RequestStatus!
                ",
            Position = 0
        )]
        public SwitchParameter deleteServiceAccount { get; set; }

        
        // -------------------------------------------------------------------
        // updateOrgCustomName parameter set
        //
        // GraphQL operation: updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!):UpdateO365OrgCustomNameReply!
        //
        [Parameter(
            ParameterSetName = "updateOrgCustomName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Update the custom name for an O365 Organization.
                GraphQL operation: updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!):UpdateO365OrgCustomNameReply!
                ",
            Position = 0
        )]
        public SwitchParameter updateOrgCustomName { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "SaaSSetupKickoff":
                        this.ProcessRecord_SaaSSetupKickoff();
                        break;
                    case "PdlGroup":
                        this.ProcessRecord_PdlGroup();
                        break;
                    case "SaasSetupComplete":
                        this.ProcessRecord_SaasSetupComplete();
                        break;
                    case "SetupKickoff":
                        this.ProcessRecord_SetupKickoff();
                        break;
                    case "addOrg":
                        this.ProcessRecord_addOrg();
                        break;
                    case "OauthConsentKickoff":
                        this.ProcessRecord_OauthConsentKickoff();
                        break;
                    case "OauthConsentComplete":
                        this.ProcessRecord_OauthConsentComplete();
                        break;
                    case "createAppKickoff":
                        this.ProcessRecord_createAppKickoff();
                        break;
                    case "createAppComplete":
                        this.ProcessRecord_createAppComplete();
                        break;
                    case "insertCustomerApp":
                        this.ProcessRecord_insertCustomerApp();
                        break;
                    case "updateAppAuthStatus":
                        this.ProcessRecord_updateAppAuthStatus();
                        break;
                    case "updateAppPermission":
                        this.ProcessRecord_updateAppPermission();
                        break;
                    case "deleteAzureApp":
                        this.ProcessRecord_deleteAzureApp();
                        break;
                    case "backupMailbox":
                        this.ProcessRecord_backupMailbox();
                        break;
                    case "backupOnedrive":
                        this.ProcessRecord_backupOnedrive();
                        break;
                    case "backupSharepointDrive":
                        this.ProcessRecord_backupSharepointDrive();
                        break;
                    case "backupSharepointList":
                        this.ProcessRecord_backupSharepointList();
                        break;
                    case "backupSharePointSite":
                        this.ProcessRecord_backupSharePointSite();
                        break;
                    case "backupTeam":
                        this.ProcessRecord_backupTeam();
                        break;
                    case "restoreTeamsFile":
                        this.ProcessRecord_restoreTeamsFile();
                        break;
                    case "restoreTeamsConversation":
                        this.ProcessRecord_restoreTeamsConversation();
                        break;
                    case "restoreSnappable":
                        this.ProcessRecord_restoreSnappable();
                        break;
                    case "refreshOrg":
                        this.ProcessRecord_refreshOrg();
                        break;
                    case "deleteOrg":
                        this.ProcessRecord_deleteOrg();
                        break;
                    case "restoreMailbox":
                        this.ProcessRecord_restoreMailbox();
                        break;
                    case "exportMailbox":
                        this.ProcessRecord_exportMailbox();
                        break;
                    case "setServiceAccount":
                        this.ProcessRecord_setServiceAccount();
                        break;
                    case "enableSharePoint":
                        this.ProcessRecord_enableSharePoint();
                        break;
                    case "enableTeam":
                        this.ProcessRecord_enableTeam();
                        break;
                    case "deleteServiceAccount":
                        this.ProcessRecord_deleteServiceAccount();
                        break;
                    case "updateOrgCustomName":
                        this.ProcessRecord_updateOrgCustomName();
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
                    "Invoke-RscMutateO365",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
        protected void ProcessRecord_PdlGroup()
        {
            this._logger.name += " -PdlGroup";
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
        protected void ProcessRecord_addOrg()
        {
            this._logger.name += " -addOrg";
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
        protected void ProcessRecord_createAppKickoff()
        {
            this._logger.name += " -createAppKickoff";
            // Invoke graphql operation createO365AppKickoff
            InvokeMutationCreateO365AppKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppComplete.
        protected void ProcessRecord_createAppComplete()
        {
            this._logger.name += " -createAppComplete";
            // Invoke graphql operation createO365AppComplete
            InvokeMutationCreateO365AppComplete();
        }

        // This parameter set invokes a single graphql operation:
        // insertCustomerO365App.
        protected void ProcessRecord_insertCustomerApp()
        {
            this._logger.name += " -insertCustomerApp";
            // Invoke graphql operation insertCustomerO365App
            InvokeMutationInsertCustomerO365App();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppAuthStatus.
        protected void ProcessRecord_updateAppAuthStatus()
        {
            this._logger.name += " -updateAppAuthStatus";
            // Invoke graphql operation updateO365AppAuthStatus
            InvokeMutationUpdateO365AppAuthStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppPermissions.
        protected void ProcessRecord_updateAppPermission()
        {
            this._logger.name += " -updateAppPermission";
            // Invoke graphql operation updateO365AppPermissions
            InvokeMutationUpdateO365AppPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365AzureApp.
        protected void ProcessRecord_deleteAzureApp()
        {
            this._logger.name += " -deleteAzureApp";
            // Invoke graphql operation deleteO365AzureApp
            InvokeMutationDeleteO365AzureApp();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Mailbox.
        protected void ProcessRecord_backupMailbox()
        {
            this._logger.name += " -backupMailbox";
            // Invoke graphql operation backupO365Mailbox
            InvokeMutationBackupO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Onedrive.
        protected void ProcessRecord_backupOnedrive()
        {
            this._logger.name += " -backupOnedrive";
            // Invoke graphql operation backupO365Onedrive
            InvokeMutationBackupO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointDrive.
        protected void ProcessRecord_backupSharepointDrive()
        {
            this._logger.name += " -backupSharepointDrive";
            // Invoke graphql operation backupO365SharepointDrive
            InvokeMutationBackupO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointList.
        protected void ProcessRecord_backupSharepointList()
        {
            this._logger.name += " -backupSharepointList";
            // Invoke graphql operation backupO365SharepointList
            InvokeMutationBackupO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharePointSite.
        protected void ProcessRecord_backupSharePointSite()
        {
            this._logger.name += " -backupSharePointSite";
            // Invoke graphql operation backupO365SharePointSite
            InvokeMutationBackupO365SharePointSite();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Team.
        protected void ProcessRecord_backupTeam()
        {
            this._logger.name += " -backupTeam";
            // Invoke graphql operation backupO365Team
            InvokeMutationBackupO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsFiles.
        protected void ProcessRecord_restoreTeamsFile()
        {
            this._logger.name += " -restoreTeamsFile";
            // Invoke graphql operation restoreO365TeamsFiles
            InvokeMutationRestoreO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsConversations.
        protected void ProcessRecord_restoreTeamsConversation()
        {
            this._logger.name += " -restoreTeamsConversation";
            // Invoke graphql operation restoreO365TeamsConversations
            InvokeMutationRestoreO365TeamsConversations();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Snappable.
        protected void ProcessRecord_restoreSnappable()
        {
            this._logger.name += " -restoreSnappable";
            // Invoke graphql operation restoreO365Snappable
            InvokeMutationRestoreO365Snappable();
        }

        // This parameter set invokes a single graphql operation:
        // refreshO365Org.
        protected void ProcessRecord_refreshOrg()
        {
            this._logger.name += " -refreshOrg";
            // Invoke graphql operation refreshO365Org
            InvokeMutationRefreshO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365Org.
        protected void ProcessRecord_deleteOrg()
        {
            this._logger.name += " -deleteOrg";
            // Invoke graphql operation deleteO365Org
            InvokeMutationDeleteO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Mailbox.
        protected void ProcessRecord_restoreMailbox()
        {
            this._logger.name += " -restoreMailbox";
            // Invoke graphql operation restoreO365Mailbox
            InvokeMutationRestoreO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Mailbox.
        protected void ProcessRecord_exportMailbox()
        {
            this._logger.name += " -exportMailbox";
            // Invoke graphql operation exportO365Mailbox
            InvokeMutationExportO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // setO365ServiceAccount.
        protected void ProcessRecord_setServiceAccount()
        {
            this._logger.name += " -setServiceAccount";
            // Invoke graphql operation setO365ServiceAccount
            InvokeMutationSetO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365SharePoint.
        protected void ProcessRecord_enableSharePoint()
        {
            this._logger.name += " -enableSharePoint";
            // Invoke graphql operation enableO365SharePoint
            InvokeMutationEnableO365SharePoint();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365Teams.
        protected void ProcessRecord_enableTeam()
        {
            this._logger.name += " -enableTeam";
            // Invoke graphql operation enableO365Teams
            InvokeMutationEnableO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365ServiceAccount.
        protected void ProcessRecord_deleteServiceAccount()
        {
            this._logger.name += " -deleteServiceAccount";
            // Invoke graphql operation deleteO365ServiceAccount
            InvokeMutationDeleteO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365OrgCustomName.
        protected void ProcessRecord_updateOrgCustomName()
        {
            this._logger.name += " -updateOrgCustomName";
            // Invoke graphql operation updateO365OrgCustomName
            InvokeMutationUpdateO365OrgCustomName();
        }


        // Invoke GraphQL Mutation:
        // o365SaaSSetupKickoff: O365SaasSetupKickoffReply!
        protected void InvokeMutationO365SaaSsetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            O365SaasSetupKickoffReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365SaasSetupKickoffReply)psObject.BaseObject;
                } else {
                    fields = (O365SaasSetupKickoffReply)this.Field;
                }
            }
            string document = Mutation.O365SaaSsetupKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365SaaSsetupKickoff");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365SaaSsetupKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationO365SaaSsetupKickoff",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<O365SaasSetupKickoffReply> task = this._rbkClient.InvokeGenericCallAsync<O365SaasSetupKickoffReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // o365PdlGroups(input: O365PdlGroupsInput!): O365PdlGroupsReply!
        protected void InvokeMutationO365PdlGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365PdlGroupsInput!"),
            };
            O365PdlGroupsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365PdlGroupsReply)psObject.BaseObject;
                } else {
                    fields = (O365PdlGroupsReply)this.Field;
                }
            }
            string document = Mutation.O365PdlGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365PdlGroups");
            string parameters = "($input: O365PdlGroupsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365PdlGroups" + parameters + "{" + document + "}",
                OperationName = "MutationO365PdlGroups",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365PdlGroupsReply> task = this._rbkClient.InvokeGenericCallAsync<O365PdlGroupsReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // o365SaasSetupComplete(input: O365SaasSetupCompleteInput!): AddO365OrgResponse!
        protected void InvokeMutationO365SaasSetupComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365SaasSetupCompleteInput!"),
            };
            AddO365OrgResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddO365OrgResponse)psObject.BaseObject;
                } else {
                    fields = (AddO365OrgResponse)this.Field;
                }
            }
            string document = Mutation.O365SaasSetupComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365SaasSetupComplete");
            string parameters = "($input: O365SaasSetupCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365SaasSetupComplete" + parameters + "{" + document + "}",
                OperationName = "MutationO365SaasSetupComplete",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddO365OrgResponse> task = this._rbkClient.InvokeGenericCallAsync<AddO365OrgResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // o365SetupKickoff: O365SetupKickoffResp!
        protected void InvokeMutationO365SetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            O365SetupKickoffResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365SetupKickoffResp)psObject.BaseObject;
                } else {
                    fields = (O365SetupKickoffResp)this.Field;
                }
            }
            string document = Mutation.O365SetupKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365SetupKickoff");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365SetupKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationO365SetupKickoff",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<O365SetupKickoffResp> task = this._rbkClient.InvokeGenericCallAsync<O365SetupKickoffResp>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // addO365Org(input: AddO365OrgInput!): AddO365OrgResponse!
        protected void InvokeMutationAddO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddO365OrgInput!"),
            };
            AddO365OrgResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddO365OrgResponse)psObject.BaseObject;
                } else {
                    fields = (AddO365OrgResponse)this.Field;
                }
            }
            string document = Mutation.AddO365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddO365Org");
            string parameters = "($input: AddO365OrgInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddO365Org" + parameters + "{" + document + "}",
                OperationName = "MutationAddO365Org",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddO365OrgResponse> task = this._rbkClient.InvokeGenericCallAsync<AddO365OrgResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!): O365OauthConsentKickoffReply!
        protected void InvokeMutationO365OauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentKickoffInput!"),
            };
            O365OauthConsentKickoffReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365OauthConsentKickoffReply)psObject.BaseObject;
                } else {
                    fields = (O365OauthConsentKickoffReply)this.Field;
                }
            }
            string document = Mutation.O365OauthConsentKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365OauthConsentKickoff");
            string parameters = "($input: O365OauthConsentKickoffInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365OauthConsentKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationO365OauthConsentKickoff",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365OauthConsentKickoffReply> task = this._rbkClient.InvokeGenericCallAsync<O365OauthConsentKickoffReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // o365OauthConsentComplete(input: O365OauthConsentCompleteInput!): O365OauthConsentCompleteReply!
        protected void InvokeMutationO365OauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentCompleteInput!"),
            };
            O365OauthConsentCompleteReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365OauthConsentCompleteReply)psObject.BaseObject;
                } else {
                    fields = (O365OauthConsentCompleteReply)this.Field;
                }
            }
            string document = Mutation.O365OauthConsentComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365OauthConsentComplete");
            string parameters = "($input: O365OauthConsentCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365OauthConsentComplete" + parameters + "{" + document + "}",
                OperationName = "MutationO365OauthConsentComplete",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365OauthConsentCompleteReply> task = this._rbkClient.InvokeGenericCallAsync<O365OauthConsentCompleteReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createO365AppKickoff(input: CreateO365AppKickoffInput!): CreateO365AppKickoffResp!
        protected void InvokeMutationCreateO365AppKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppKickoffInput!"),
            };
            CreateO365AppKickoffResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateO365AppKickoffResp)psObject.BaseObject;
                } else {
                    fields = (CreateO365AppKickoffResp)this.Field;
                }
            }
            string document = Mutation.CreateO365AppKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateO365AppKickoff");
            string parameters = "($input: CreateO365AppKickoffInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateO365AppKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationCreateO365AppKickoff",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateO365AppKickoffResp> task = this._rbkClient.InvokeGenericCallAsync<CreateO365AppKickoffResp>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createO365AppComplete(input: CreateO365AppCompleteInput!): RequestStatus!
        protected void InvokeMutationCreateO365AppComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppCompleteInput!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateO365AppComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateO365AppComplete");
            string parameters = "($input: CreateO365AppCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateO365AppComplete" + parameters + "{" + document + "}",
                OperationName = "MutationCreateO365AppComplete",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // insertCustomerO365App(input: InsertCustomerO365AppInput!): RequestStatus!
        protected void InvokeMutationInsertCustomerO365App()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InsertCustomerO365AppInput!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.InsertCustomerO365App(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.InsertCustomerO365App");
            string parameters = "($input: InsertCustomerO365AppInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationInsertCustomerO365App" + parameters + "{" + document + "}",
                OperationName = "MutationInsertCustomerO365App",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!): UpdateO365AppAuthStatusReply!
        protected void InvokeMutationUpdateO365AppAuthStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppAuthStatusInput!"),
            };
            UpdateO365AppAuthStatusReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateO365AppAuthStatusReply)psObject.BaseObject;
                } else {
                    fields = (UpdateO365AppAuthStatusReply)this.Field;
                }
            }
            string document = Mutation.UpdateO365AppAuthStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateO365AppAuthStatus");
            string parameters = "($input: UpdateO365AppAuthStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateO365AppAuthStatus" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateO365AppAuthStatus",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateO365AppAuthStatusReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateO365AppAuthStatusReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateO365AppPermissions(input: UpdateO365AppPermissionsInput!): Void
        protected void InvokeMutationUpdateO365AppPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppPermissionsInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateO365AppPermissions(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateO365AppPermissions");
            string parameters = "($input: UpdateO365AppPermissionsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateO365AppPermissions" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateO365AppPermissions",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!): RequestStatus!
        protected void InvokeMutationDeleteO365AzureApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("o365AppClientId", "String!"),
                Tuple.Create("o365AppType", "String!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteO365AzureApp(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteO365AzureApp");
            string parameters = "($o365AppClientId: String!,$o365AppType: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteO365AzureApp" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteO365AzureApp",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // backupO365Mailbox(mailboxIds: [UUID!]!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("mailboxIds", "[UUID!]!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365Mailbox");
            string parameters = "($mailboxIds: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365Mailbox",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // backupO365Onedrive(input: BackupO365OnedriveInput!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365OnedriveInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365Onedrive(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365Onedrive");
            string parameters = "($input: BackupO365OnedriveInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365Onedrive" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365Onedrive",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // backupO365SharepointDrive(input: BackupO365SharepointDriveInput!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharepointDriveInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365SharepointDrive(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365SharepointDrive");
            string parameters = "($input: BackupO365SharepointDriveInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365SharepointDrive" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365SharepointDrive",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // backupO365SharepointList(input: BackupO365SharePointListInput!): CreateOnDemandJobReply!
        protected void InvokeMutationBackupO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointListInput!"),
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
            string document = Mutation.BackupO365SharepointList(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365SharepointList");
            string parameters = "($input: BackupO365SharePointListInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365SharepointList" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365SharepointList",
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
        // backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
        protected void InvokeMutationBackupO365SharePointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointSiteInput!"),
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
            string document = Mutation.BackupO365SharePointSite(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365SharePointSite");
            string parameters = "($input: BackupO365SharePointSiteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365SharePointSite" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365SharePointSite",
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
        // backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365TeamInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365Team(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365Team");
            string parameters = "($input: BackupO365TeamInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365Team" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365Team",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365TeamsFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsFilesInput!"),
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
            string document = Mutation.RestoreO365TeamsFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365TeamsFiles");
            string parameters = "($input: RestoreO365TeamsFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365TeamsFiles" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365TeamsFiles",
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
        // restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365TeamsConversations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsConversationsInput!"),
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
            string document = Mutation.RestoreO365TeamsConversations(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365TeamsConversations");
            string parameters = "($input: RestoreO365TeamsConversationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365TeamsConversations" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365TeamsConversations",
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
        // restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365Snappable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
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
            string document = Mutation.RestoreO365Snappable(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365Snappable");
            string parameters = "($input: RestoreO365SnappableInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365Snappable" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365Snappable",
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
        // refreshO365Org(orgId: UUID!): CreateOnDemandJobReply!
        protected void InvokeMutationRefreshO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
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
            string document = Mutation.RefreshO365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshO365Org");
            string parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshO365Org" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshO365Org",
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
        // deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
        protected void InvokeMutationDeleteO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
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
            string document = Mutation.DeleteO365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteO365Org");
            string parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteO365Org" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteO365Org",
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
        // restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("restoreConfig", "RestoreO365MailboxInput!"),
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
            string document = Mutation.RestoreO365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365Mailbox");
            string parameters = "($restoreConfig: RestoreO365MailboxInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365Mailbox",
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
        // exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
        protected void InvokeMutationExportO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exportConfig", "ExportO365MailboxInput!"),
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
            string document = Mutation.ExportO365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportO365Mailbox");
            string parameters = "($exportConfig: ExportO365MailboxInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "MutationExportO365Mailbox",
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
        // setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!): RequestStatus!
        protected void InvokeMutationSetO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("username", "String!"),
                Tuple.Create("appPassword", "String!"),
                Tuple.Create("orgId", "UUID!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.SetO365ServiceAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.SetO365ServiceAccount");
            string parameters = "($username: String!,$appPassword: String!,$orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationSetO365ServiceAccount" + parameters + "{" + document + "}",
                OperationName = "MutationSetO365ServiceAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // enableO365SharePoint(input: EnableO365SharePointInput!): RequestStatus!
        protected void InvokeMutationEnableO365SharePoint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableO365SharePointInput!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.EnableO365SharePoint(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.EnableO365SharePoint");
            string parameters = "($input: EnableO365SharePointInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationEnableO365SharePoint" + parameters + "{" + document + "}",
                OperationName = "MutationEnableO365SharePoint",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // enableO365Teams(exocomputeClusterId: String!): RequestStatus!
        protected void InvokeMutationEnableO365Teams()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.EnableO365Teams(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.EnableO365Teams");
            string parameters = "($exocomputeClusterId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationEnableO365Teams" + parameters + "{" + document + "}",
                OperationName = "MutationEnableO365Teams",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteO365ServiceAccount(orgId: UUID!): RequestStatus!
        protected void InvokeMutationDeleteO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteO365ServiceAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteO365ServiceAccount");
            string parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteO365ServiceAccount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteO365ServiceAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!): UpdateO365OrgCustomNameReply!
        protected void InvokeMutationUpdateO365OrgCustomName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365OrgCustomNameInput!"),
            };
            UpdateO365OrgCustomNameReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateO365OrgCustomNameReply)psObject.BaseObject;
                } else {
                    fields = (UpdateO365OrgCustomNameReply)this.Field;
                }
            }
            string document = Mutation.UpdateO365OrgCustomName(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateO365OrgCustomName");
            string parameters = "($input: UpdateO365OrgCustomNameInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateO365OrgCustomName" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateO365OrgCustomName",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateO365OrgCustomNameReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateO365OrgCustomNameReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateO365
}