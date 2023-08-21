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
    /// <summary>
    /// O365 mutations
    /// </summary>
    /// <description>
    /// Invoke-RscMutateO365 is a master cmdlet for O365 work that can invoke any of the following subcommands: SaaSSetupKickoff, PdlGroups, SaasSetupComplete, SetupKickoff, AddOrg, OauthConsentKickoff, OauthConsentComplete, CreateAppKickoff, CreateAppComplete, InsertCustomerApp, UpdateAppAuthStatus, UpdateAppPermissions, DeleteAzureApp, BackupMailbox, BackupOnedrive, BackupSharepointDrive, BackupSharepointList, BackupSharePointSite, BackupTeam, RestoreTeamsFiles, ExportTeamsFiles, RestoreTeamsConversations, RestoreSnappable, ExportWorkload, RefreshOrg, DeleteOrg, RestoreMailbox, ExportMailbox, SetServiceAccount, EnableSharePoint, EnableTeams, DeleteServiceAccount, UpdateOrgCustomName.
    /// </description>
    /// <example>
    /// <code>Invoke-RscMutateO365 -SaaSSetupKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -PdlGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -SaasSetupComplete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -SetupKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -AddOrg [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -OauthConsentKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -OauthConsentComplete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -CreateAppKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -CreateAppComplete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -InsertCustomerApp [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -UpdateAppAuthStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -UpdateAppPermissions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -DeleteAzureApp [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -BackupMailbox [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -BackupOnedrive [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -BackupSharepointDrive [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -BackupSharepointList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -BackupSharePointSite [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -BackupTeam [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -RestoreTeamsFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -ExportTeamsFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -RestoreTeamsConversations [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -RestoreSnappable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -ExportWorkload [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -RefreshOrg [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -DeleteOrg [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -RestoreMailbox [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -ExportMailbox [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -SetServiceAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -EnableSharePoint [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -EnableTeams [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -DeleteServiceAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>Invoke-RscMutateO365 -UpdateOrgCustomName [-Arg ..] [-Field ..]</code>
    /// </example>
    [Cmdlet(
        "Invoke",
        "RscMutateO365",
        DefaultParameterSetName = "AddOrg")
    ]
    public class Invoke_RscMutateO365 : RscPSCmdlet
    {
        
        /// <summary>
        /// SaaSSetupKickoff parameter set
        ///
        /// [GraphQL: o365SaaSSetupKickoff]
        /// </summary>
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

        
        /// <summary>
        /// PdlGroups parameter set
        ///
        /// [GraphQL: o365PdlGroups]
        /// </summary>
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

        
        /// <summary>
        /// SaasSetupComplete parameter set
        ///
        /// [GraphQL: o365SaasSetupComplete]
        /// </summary>
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

        
        /// <summary>
        /// SetupKickoff parameter set
        ///
        /// [GraphQL: o365SetupKickoff]
        /// </summary>
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

        
        /// <summary>
        /// AddOrg parameter set
        ///
        /// [GraphQL: addO365Org]
        /// </summary>
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

        
        /// <summary>
        /// OauthConsentKickoff parameter set
        ///
        /// [GraphQL: o365OauthConsentKickoff]
        /// </summary>
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

        
        /// <summary>
        /// OauthConsentComplete parameter set
        ///
        /// [GraphQL: o365OauthConsentComplete]
        /// </summary>
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

        
        /// <summary>
        /// CreateAppKickoff parameter set
        ///
        /// [GraphQL: createO365AppKickoff]
        /// </summary>
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

        
        /// <summary>
        /// CreateAppComplete parameter set
        ///
        /// [GraphQL: createO365AppComplete]
        /// </summary>
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

        
        /// <summary>
        /// InsertCustomerApp parameter set
        ///
        /// [GraphQL: insertCustomerO365App]
        /// </summary>
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

        
        /// <summary>
        /// UpdateAppAuthStatus parameter set
        ///
        /// [GraphQL: updateO365AppAuthStatus]
        /// </summary>
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

        
        /// <summary>
        /// UpdateAppPermissions parameter set
        ///
        /// [GraphQL: updateO365AppPermissions]
        /// </summary>
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

        
        /// <summary>
        /// DeleteAzureApp parameter set
        ///
        /// [GraphQL: deleteO365AzureApp]
        /// </summary>
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

        
        /// <summary>
        /// BackupMailbox parameter set
        ///
        /// [GraphQL: backupO365Mailbox]
        /// </summary>
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

        
        /// <summary>
        /// BackupOnedrive parameter set
        ///
        /// [GraphQL: backupO365Onedrive]
        /// </summary>
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

        
        /// <summary>
        /// BackupSharepointDrive parameter set
        ///
        /// [GraphQL: backupO365SharepointDrive]
        /// </summary>
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

        
        /// <summary>
        /// BackupSharepointList parameter set
        ///
        /// [GraphQL: backupO365SharepointList]
        /// </summary>
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

        
        /// <summary>
        /// BackupSharePointSite parameter set
        ///
        /// [GraphQL: backupO365SharePointSite]
        /// </summary>
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

        
        /// <summary>
        /// BackupTeam parameter set
        ///
        /// [GraphQL: backupO365Team]
        /// </summary>
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

        
        /// <summary>
        /// RestoreTeamsFiles parameter set
        ///
        /// [GraphQL: restoreO365TeamsFiles]
        /// </summary>
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

        
        /// <summary>
        /// ExportTeamsFiles parameter set
        ///
        /// [GraphQL: exportO365TeamsFiles]
        /// </summary>
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

        
        /// <summary>
        /// RestoreTeamsConversations parameter set
        ///
        /// [GraphQL: restoreO365TeamsConversations]
        /// </summary>
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

        
        /// <summary>
        /// RestoreSnappable parameter set
        ///
        /// [GraphQL: restoreO365Snappable]
        /// </summary>
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

        
        /// <summary>
        /// ExportWorkload parameter set
        ///
        /// [GraphQL: exportO365Workload]
        /// </summary>
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

        
        /// <summary>
        /// RefreshOrg parameter set
        ///
        /// [GraphQL: refreshO365Org]
        /// </summary>
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

        
        /// <summary>
        /// DeleteOrg parameter set
        ///
        /// [GraphQL: deleteO365Org]
        /// </summary>
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

        
        /// <summary>
        /// RestoreMailbox parameter set
        ///
        /// [GraphQL: restoreO365Mailbox]
        /// </summary>
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

        
        /// <summary>
        /// ExportMailbox parameter set
        ///
        /// [GraphQL: exportO365Mailbox]
        /// </summary>
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

        
        /// <summary>
        /// SetServiceAccount parameter set
        ///
        /// [GraphQL: setO365ServiceAccount]
        /// </summary>
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

        
        /// <summary>
        /// EnableSharePoint parameter set
        ///
        /// [GraphQL: enableO365SharePoint]
        /// </summary>
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

        
        /// <summary>
        /// EnableTeams parameter set
        ///
        /// [GraphQL: enableO365Teams]
        /// </summary>
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

        
        /// <summary>
        /// DeleteServiceAccount parameter set
        ///
        /// [GraphQL: deleteO365ServiceAccount]
        /// </summary>
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

        
        /// <summary>
        /// UpdateOrgCustomName parameter set
        ///
        /// [GraphQL: updateO365OrgCustomName]
        /// </summary>
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


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
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
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // o365SaaSSetupKickoff.
        internal void ProcessRecord_SaaSSetupKickoff()
        {
            this._logger.name += " -SaaSSetupKickoff";
            // Invoke graphql operation o365SaaSSetupKickoff
            InvokeMutationO365SaaSsetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365PdlGroups.
        internal void ProcessRecord_PdlGroups()
        {
            this._logger.name += " -PdlGroups";
            // Invoke graphql operation o365PdlGroups
            InvokeMutationO365PdlGroups();
        }

        // This parameter set invokes a single graphql operation:
        // o365SaasSetupComplete.
        internal void ProcessRecord_SaasSetupComplete()
        {
            this._logger.name += " -SaasSetupComplete";
            // Invoke graphql operation o365SaasSetupComplete
            InvokeMutationO365SaasSetupComplete();
        }

        // This parameter set invokes a single graphql operation:
        // o365SetupKickoff.
        internal void ProcessRecord_SetupKickoff()
        {
            this._logger.name += " -SetupKickoff";
            // Invoke graphql operation o365SetupKickoff
            InvokeMutationO365SetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // addO365Org.
        internal void ProcessRecord_AddOrg()
        {
            this._logger.name += " -AddOrg";
            // Invoke graphql operation addO365Org
            InvokeMutationAddO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentKickoff.
        internal void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Invoke graphql operation o365OauthConsentKickoff
            InvokeMutationO365OauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentComplete.
        internal void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Invoke graphql operation o365OauthConsentComplete
            InvokeMutationO365OauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppKickoff.
        internal void ProcessRecord_CreateAppKickoff()
        {
            this._logger.name += " -CreateAppKickoff";
            // Invoke graphql operation createO365AppKickoff
            InvokeMutationCreateO365AppKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppComplete.
        internal void ProcessRecord_CreateAppComplete()
        {
            this._logger.name += " -CreateAppComplete";
            // Invoke graphql operation createO365AppComplete
            InvokeMutationCreateO365AppComplete();
        }

        // This parameter set invokes a single graphql operation:
        // insertCustomerO365App.
        internal void ProcessRecord_InsertCustomerApp()
        {
            this._logger.name += " -InsertCustomerApp";
            // Invoke graphql operation insertCustomerO365App
            InvokeMutationInsertCustomerO365App();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppAuthStatus.
        internal void ProcessRecord_UpdateAppAuthStatus()
        {
            this._logger.name += " -UpdateAppAuthStatus";
            // Invoke graphql operation updateO365AppAuthStatus
            InvokeMutationUpdateO365AppAuthStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppPermissions.
        internal void ProcessRecord_UpdateAppPermissions()
        {
            this._logger.name += " -UpdateAppPermissions";
            // Invoke graphql operation updateO365AppPermissions
            InvokeMutationUpdateO365AppPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365AzureApp.
        internal void ProcessRecord_DeleteAzureApp()
        {
            this._logger.name += " -DeleteAzureApp";
            // Invoke graphql operation deleteO365AzureApp
            InvokeMutationDeleteO365AzureApp();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Mailbox.
        internal void ProcessRecord_BackupMailbox()
        {
            this._logger.name += " -BackupMailbox";
            // Invoke graphql operation backupO365Mailbox
            InvokeMutationBackupO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Onedrive.
        internal void ProcessRecord_BackupOnedrive()
        {
            this._logger.name += " -BackupOnedrive";
            // Invoke graphql operation backupO365Onedrive
            InvokeMutationBackupO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointDrive.
        internal void ProcessRecord_BackupSharepointDrive()
        {
            this._logger.name += " -BackupSharepointDrive";
            // Invoke graphql operation backupO365SharepointDrive
            InvokeMutationBackupO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointList.
        internal void ProcessRecord_BackupSharepointList()
        {
            this._logger.name += " -BackupSharepointList";
            // Invoke graphql operation backupO365SharepointList
            InvokeMutationBackupO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharePointSite.
        internal void ProcessRecord_BackupSharePointSite()
        {
            this._logger.name += " -BackupSharePointSite";
            // Invoke graphql operation backupO365SharePointSite
            InvokeMutationBackupO365SharePointSite();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Team.
        internal void ProcessRecord_BackupTeam()
        {
            this._logger.name += " -BackupTeam";
            // Invoke graphql operation backupO365Team
            InvokeMutationBackupO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsFiles.
        internal void ProcessRecord_RestoreTeamsFiles()
        {
            this._logger.name += " -RestoreTeamsFiles";
            // Invoke graphql operation restoreO365TeamsFiles
            InvokeMutationRestoreO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365TeamsFiles.
        internal void ProcessRecord_ExportTeamsFiles()
        {
            this._logger.name += " -ExportTeamsFiles";
            // Invoke graphql operation exportO365TeamsFiles
            InvokeMutationExportO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsConversations.
        internal void ProcessRecord_RestoreTeamsConversations()
        {
            this._logger.name += " -RestoreTeamsConversations";
            // Invoke graphql operation restoreO365TeamsConversations
            InvokeMutationRestoreO365TeamsConversations();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Snappable.
        internal void ProcessRecord_RestoreSnappable()
        {
            this._logger.name += " -RestoreSnappable";
            // Invoke graphql operation restoreO365Snappable
            InvokeMutationRestoreO365Snappable();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Workload.
        internal void ProcessRecord_ExportWorkload()
        {
            this._logger.name += " -ExportWorkload";
            // Invoke graphql operation exportO365Workload
            InvokeMutationExportO365Workload();
        }

        // This parameter set invokes a single graphql operation:
        // refreshO365Org.
        internal void ProcessRecord_RefreshOrg()
        {
            this._logger.name += " -RefreshOrg";
            // Invoke graphql operation refreshO365Org
            InvokeMutationRefreshO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365Org.
        internal void ProcessRecord_DeleteOrg()
        {
            this._logger.name += " -DeleteOrg";
            // Invoke graphql operation deleteO365Org
            InvokeMutationDeleteO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Mailbox.
        internal void ProcessRecord_RestoreMailbox()
        {
            this._logger.name += " -RestoreMailbox";
            // Invoke graphql operation restoreO365Mailbox
            InvokeMutationRestoreO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Mailbox.
        internal void ProcessRecord_ExportMailbox()
        {
            this._logger.name += " -ExportMailbox";
            // Invoke graphql operation exportO365Mailbox
            InvokeMutationExportO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // setO365ServiceAccount.
        internal void ProcessRecord_SetServiceAccount()
        {
            this._logger.name += " -SetServiceAccount";
            // Invoke graphql operation setO365ServiceAccount
            InvokeMutationSetO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365SharePoint.
        internal void ProcessRecord_EnableSharePoint()
        {
            this._logger.name += " -EnableSharePoint";
            // Invoke graphql operation enableO365SharePoint
            InvokeMutationEnableO365SharePoint();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365Teams.
        internal void ProcessRecord_EnableTeams()
        {
            this._logger.name += " -EnableTeams";
            // Invoke graphql operation enableO365Teams
            InvokeMutationEnableO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365ServiceAccount.
        internal void ProcessRecord_DeleteServiceAccount()
        {
            this._logger.name += " -DeleteServiceAccount";
            // Invoke graphql operation deleteO365ServiceAccount
            InvokeMutationDeleteO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365OrgCustomName.
        internal void ProcessRecord_UpdateOrgCustomName()
        {
            this._logger.name += " -UpdateOrgCustomName";
            // Invoke graphql operation updateO365OrgCustomName
            InvokeMutationUpdateO365OrgCustomName();
        }


        // Invoke GraphQL Mutation:
        // o365SaaSSetupKickoff: O365SaasSetupKickoffReply!
        internal void InvokeMutationO365SaaSsetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaaSsetupKickoff",
                "",
                "O365SaasSetupKickoffReply"
                );
            O365SaasSetupKickoffReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (O365SaasSetupKickoffReply)this.Field;
            }
            string fieldSpecDoc = Mutation.O365SaaSsetupKickoff(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // o365PdlGroups(input: O365PdlGroupsInput!): O365PdlGroupsReply!
        internal void InvokeMutationO365PdlGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365PdlGroupsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365PdlGroups",
                "($input: O365PdlGroupsInput!)",
                "O365PdlGroupsReply"
                );
            O365PdlGroupsReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (O365PdlGroupsReply)this.Field;
            }
            string fieldSpecDoc = Mutation.O365PdlGroups(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // o365SaasSetupComplete(input: O365SaasSetupCompleteInput!): AddO365OrgResponse!
        internal void InvokeMutationO365SaasSetupComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365SaasSetupCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaasSetupComplete",
                "($input: O365SaasSetupCompleteInput!)",
                "AddO365OrgResponse"
                );
            AddO365OrgResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AddO365OrgResponse)this.Field;
            }
            string fieldSpecDoc = Mutation.O365SaasSetupComplete(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // o365SetupKickoff: O365SetupKickoffResp!
        internal void InvokeMutationO365SetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SetupKickoff",
                "",
                "O365SetupKickoffResp"
                );
            O365SetupKickoffResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (O365SetupKickoffResp)this.Field;
            }
            string fieldSpecDoc = Mutation.O365SetupKickoff(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // addO365Org(input: AddO365OrgInput!): AddO365OrgResponse!
        internal void InvokeMutationAddO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddO365OrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddO365Org",
                "($input: AddO365OrgInput!)",
                "AddO365OrgResponse"
                );
            AddO365OrgResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (AddO365OrgResponse)this.Field;
            }
            string fieldSpecDoc = Mutation.AddO365Org(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!): O365OauthConsentKickoffReply!
        internal void InvokeMutationO365OauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentKickoff",
                "($input: O365OauthConsentKickoffInput!)",
                "O365OauthConsentKickoffReply"
                );
            O365OauthConsentKickoffReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (O365OauthConsentKickoffReply)this.Field;
            }
            string fieldSpecDoc = Mutation.O365OauthConsentKickoff(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // o365OauthConsentComplete(input: O365OauthConsentCompleteInput!): O365OauthConsentCompleteReply!
        internal void InvokeMutationO365OauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentComplete",
                "($input: O365OauthConsentCompleteInput!)",
                "O365OauthConsentCompleteReply"
                );
            O365OauthConsentCompleteReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (O365OauthConsentCompleteReply)this.Field;
            }
            string fieldSpecDoc = Mutation.O365OauthConsentComplete(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // createO365AppKickoff(input: CreateO365AppKickoffInput!): CreateO365AppKickoffResp!
        internal void InvokeMutationCreateO365AppKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppKickoff",
                "($input: CreateO365AppKickoffInput!)",
                "CreateO365AppKickoffResp"
                );
            CreateO365AppKickoffResp? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateO365AppKickoffResp)this.Field;
            }
            string fieldSpecDoc = Mutation.CreateO365AppKickoff(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // createO365AppComplete(input: CreateO365AppCompleteInput!): RequestStatus!
        internal void InvokeMutationCreateO365AppComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppComplete",
                "($input: CreateO365AppCompleteInput!)",
                "RequestStatus"
                );
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.CreateO365AppComplete(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // insertCustomerO365App(input: InsertCustomerO365AppInput!): RequestStatus!
        internal void InvokeMutationInsertCustomerO365App()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InsertCustomerO365AppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInsertCustomerO365App",
                "($input: InsertCustomerO365AppInput!)",
                "RequestStatus"
                );
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.InsertCustomerO365App(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!): UpdateO365AppAuthStatusReply!
        internal void InvokeMutationUpdateO365AppAuthStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppAuthStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppAuthStatus",
                "($input: UpdateO365AppAuthStatusInput!)",
                "UpdateO365AppAuthStatusReply"
                );
            UpdateO365AppAuthStatusReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (UpdateO365AppAuthStatusReply)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateO365AppAuthStatus(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateO365AppPermissions(input: UpdateO365AppPermissionsInput!): Void
        internal void InvokeMutationUpdateO365AppPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppPermissionsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppPermissions",
                "($input: UpdateO365AppPermissionsInput!)",
                "System.String"
                );
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (System.String)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateO365AppPermissions(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!): RequestStatus!
        internal void InvokeMutationDeleteO365AzureApp()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("o365AppClientId", "String!"),
                Tuple.Create("o365AppType", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365AzureApp",
                "($o365AppClientId: String!,$o365AppType: String!)",
                "RequestStatus"
                );
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteO365AzureApp(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // backupO365Mailbox(mailboxIds: [UUID!]!): BatchAsyncJobStatus!
        internal void InvokeMutationBackupO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("mailboxIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Mailbox",
                "($mailboxIds: [UUID!]!)",
                "BatchAsyncJobStatus"
                );
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncJobStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.BackupO365Mailbox(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // backupO365Onedrive(input: BackupO365OnedriveInput!): BatchAsyncJobStatus!
        internal void InvokeMutationBackupO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365OnedriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Onedrive",
                "($input: BackupO365OnedriveInput!)",
                "BatchAsyncJobStatus"
                );
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncJobStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.BackupO365Onedrive(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // backupO365SharepointDrive(input: BackupO365SharepointDriveInput!): BatchAsyncJobStatus!
        internal void InvokeMutationBackupO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharepointDriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointDrive",
                "($input: BackupO365SharepointDriveInput!)",
                "BatchAsyncJobStatus"
                );
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncJobStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.BackupO365SharepointDrive(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // backupO365SharepointList(input: BackupO365SharePointListInput!): CreateOnDemandJobReply!
        internal void InvokeMutationBackupO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointListInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointList",
                "($input: BackupO365SharePointListInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.BackupO365SharepointList(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
        internal void InvokeMutationBackupO365SharePointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointSiteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharePointSite",
                "($input: BackupO365SharePointSiteInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.BackupO365SharePointSite(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
        internal void InvokeMutationBackupO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365TeamInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Team",
                "($input: BackupO365TeamInput!)",
                "BatchAsyncJobStatus"
                );
            BatchAsyncJobStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (BatchAsyncJobStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.BackupO365Team(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        internal void InvokeMutationRestoreO365TeamsFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365TeamsFiles",
                "($input: RestoreO365TeamsFilesInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RestoreO365TeamsFiles(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // exportO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        internal void InvokeMutationExportO365TeamsFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportO365TeamsFiles",
                "($input: RestoreO365TeamsFilesInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.ExportO365TeamsFiles(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
        internal void InvokeMutationRestoreO365TeamsConversations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsConversationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365TeamsConversations",
                "($input: RestoreO365TeamsConversationsInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RestoreO365TeamsConversations(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        internal void InvokeMutationRestoreO365Snappable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365Snappable",
                "($input: RestoreO365SnappableInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RestoreO365Snappable(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // exportO365Workload(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        internal void InvokeMutationExportO365Workload()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportO365Workload",
                "($input: RestoreO365SnappableInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.ExportO365Workload(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // refreshO365Org(orgId: UUID!): CreateOnDemandJobReply!
        internal void InvokeMutationRefreshO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshO365Org",
                "($orgId: UUID!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RefreshO365Org(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
        internal void InvokeMutationDeleteO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365Org",
                "($orgId: UUID!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteO365Org(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
        internal void InvokeMutationRestoreO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("restoreConfig", "RestoreO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365Mailbox",
                "($restoreConfig: RestoreO365MailboxInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.RestoreO365Mailbox(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
        internal void InvokeMutationExportO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exportConfig", "ExportO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportO365Mailbox",
                "($exportConfig: ExportO365MailboxInput!)",
                "CreateOnDemandJobReply"
                );
            CreateOnDemandJobReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (CreateOnDemandJobReply)this.Field;
            }
            string fieldSpecDoc = Mutation.ExportO365Mailbox(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!): RequestStatus!
        internal void InvokeMutationSetO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("username", "String!"),
                Tuple.Create("appPassword", "String!"),
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetO365ServiceAccount",
                "($username: String!,$appPassword: String!,$orgId: UUID!)",
                "RequestStatus"
                );
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.SetO365ServiceAccount(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // enableO365SharePoint(input: EnableO365SharePointInput!): RequestStatus!
        internal void InvokeMutationEnableO365SharePoint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableO365SharePointInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365SharePoint",
                "($input: EnableO365SharePointInput!)",
                "RequestStatus"
                );
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.EnableO365SharePoint(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // enableO365Teams(exocomputeClusterId: String!): RequestStatus!
        internal void InvokeMutationEnableO365Teams()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365Teams",
                "($exocomputeClusterId: String!)",
                "RequestStatus"
                );
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.EnableO365Teams(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // deleteO365ServiceAccount(orgId: UUID!): RequestStatus!
        internal void InvokeMutationDeleteO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365ServiceAccount",
                "($orgId: UUID!)",
                "RequestStatus"
                );
            RequestStatus? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (RequestStatus)this.Field;
            }
            string fieldSpecDoc = Mutation.DeleteO365ServiceAccount(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }

        // Invoke GraphQL Mutation:
        // updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!): UpdateO365OrgCustomNameReply!
        internal void InvokeMutationUpdateO365OrgCustomName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365OrgCustomNameInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365OrgCustomName",
                "($input: UpdateO365OrgCustomNameInput!)",
                "UpdateO365OrgCustomNameReply"
                );
            UpdateO365OrgCustomNameReply? fieldSpecObj = null ;
            if (this.Field != null) {
                fieldSpecObj = (UpdateO365OrgCustomNameReply)this.Field;
            }
            string fieldSpecDoc = Mutation.UpdateO365OrgCustomName(ref fieldSpecObj);
            BuildInput(fieldSpecObj);
            BuildRequest(fieldSpecDoc);
        }


    } // class Invoke_RscMutateO365
}