// New-RscMutationO365.cs
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
    /// Mutations for the 'O365' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationO365 is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationO365 -SaaSSetupKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -PdlGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -SaasSetupComplete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -SetupKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -AddOrg [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -OauthConsentKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -OauthConsentComplete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -CreateAppKickoff [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -CreateAppComplete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -InsertCustomerApp [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -UpdateAppAuthStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -UpdateAppPermissions [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -DeleteAzureApp [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -BackupMailbox [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -BackupOnedrive [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -BackupSharepointDrive [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -BackupSharepointList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -BackupSharePointSite [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -BackupTeam [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -RestoreTeamsFiles [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -RestoreTeamsConversations [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -RestoreSnappable [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -RefreshOrg [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -DeleteOrg [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -RestoreMailbox [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -ExportMailbox [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -SetServiceAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -EnableSharePoint [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -EnableTeams [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -DeleteServiceAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationO365 -UpdateOrgCustomName [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationO365",
        DefaultParameterSetName = "AddOrg")
    ]
    public class New_RscMutationO365 : RscGqlPSCmdlet
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
            base.ProcessRecord();
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
                    case "RestoreTeamsConversations":
                        this.ProcessRecord_RestoreTeamsConversations();
                        break;
                    case "RestoreSnappable":
                        this.ProcessRecord_RestoreSnappable();
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
            // Create new graphql operation o365SaaSSetupKickoff
            InitMutationO365SaaSsetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365PdlGroups.
        internal void ProcessRecord_PdlGroups()
        {
            this._logger.name += " -PdlGroups";
            // Create new graphql operation o365PdlGroups
            InitMutationO365PdlGroups();
        }

        // This parameter set invokes a single graphql operation:
        // o365SaasSetupComplete.
        internal void ProcessRecord_SaasSetupComplete()
        {
            this._logger.name += " -SaasSetupComplete";
            // Create new graphql operation o365SaasSetupComplete
            InitMutationO365SaasSetupComplete();
        }

        // This parameter set invokes a single graphql operation:
        // o365SetupKickoff.
        internal void ProcessRecord_SetupKickoff()
        {
            this._logger.name += " -SetupKickoff";
            // Create new graphql operation o365SetupKickoff
            InitMutationO365SetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // addO365Org.
        internal void ProcessRecord_AddOrg()
        {
            this._logger.name += " -AddOrg";
            // Create new graphql operation addO365Org
            InitMutationAddO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentKickoff.
        internal void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Create new graphql operation o365OauthConsentKickoff
            InitMutationO365OauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentComplete.
        internal void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Create new graphql operation o365OauthConsentComplete
            InitMutationO365OauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppKickoff.
        internal void ProcessRecord_CreateAppKickoff()
        {
            this._logger.name += " -CreateAppKickoff";
            // Create new graphql operation createO365AppKickoff
            InitMutationCreateO365AppKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppComplete.
        internal void ProcessRecord_CreateAppComplete()
        {
            this._logger.name += " -CreateAppComplete";
            // Create new graphql operation createO365AppComplete
            InitMutationCreateO365AppComplete();
        }

        // This parameter set invokes a single graphql operation:
        // insertCustomerO365App.
        internal void ProcessRecord_InsertCustomerApp()
        {
            this._logger.name += " -InsertCustomerApp";
            // Create new graphql operation insertCustomerO365App
            InitMutationInsertCustomerO365App();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppAuthStatus.
        internal void ProcessRecord_UpdateAppAuthStatus()
        {
            this._logger.name += " -UpdateAppAuthStatus";
            // Create new graphql operation updateO365AppAuthStatus
            InitMutationUpdateO365AppAuthStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppPermissions.
        internal void ProcessRecord_UpdateAppPermissions()
        {
            this._logger.name += " -UpdateAppPermissions";
            // Create new graphql operation updateO365AppPermissions
            InitMutationUpdateO365AppPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365AzureApp.
        internal void ProcessRecord_DeleteAzureApp()
        {
            this._logger.name += " -DeleteAzureApp";
            // Create new graphql operation deleteO365AzureApp
            InitMutationDeleteO365AzureApp();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Mailbox.
        internal void ProcessRecord_BackupMailbox()
        {
            this._logger.name += " -BackupMailbox";
            // Create new graphql operation backupO365Mailbox
            InitMutationBackupO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Onedrive.
        internal void ProcessRecord_BackupOnedrive()
        {
            this._logger.name += " -BackupOnedrive";
            // Create new graphql operation backupO365Onedrive
            InitMutationBackupO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointDrive.
        internal void ProcessRecord_BackupSharepointDrive()
        {
            this._logger.name += " -BackupSharepointDrive";
            // Create new graphql operation backupO365SharepointDrive
            InitMutationBackupO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointList.
        internal void ProcessRecord_BackupSharepointList()
        {
            this._logger.name += " -BackupSharepointList";
            // Create new graphql operation backupO365SharepointList
            InitMutationBackupO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharePointSite.
        internal void ProcessRecord_BackupSharePointSite()
        {
            this._logger.name += " -BackupSharePointSite";
            // Create new graphql operation backupO365SharePointSite
            InitMutationBackupO365SharePointSite();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Team.
        internal void ProcessRecord_BackupTeam()
        {
            this._logger.name += " -BackupTeam";
            // Create new graphql operation backupO365Team
            InitMutationBackupO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsFiles.
        internal void ProcessRecord_RestoreTeamsFiles()
        {
            this._logger.name += " -RestoreTeamsFiles";
            // Create new graphql operation restoreO365TeamsFiles
            InitMutationRestoreO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsConversations.
        internal void ProcessRecord_RestoreTeamsConversations()
        {
            this._logger.name += " -RestoreTeamsConversations";
            // Create new graphql operation restoreO365TeamsConversations
            InitMutationRestoreO365TeamsConversations();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Snappable.
        internal void ProcessRecord_RestoreSnappable()
        {
            this._logger.name += " -RestoreSnappable";
            // Create new graphql operation restoreO365Snappable
            InitMutationRestoreO365Snappable();
        }

        // This parameter set invokes a single graphql operation:
        // refreshO365Org.
        internal void ProcessRecord_RefreshOrg()
        {
            this._logger.name += " -RefreshOrg";
            // Create new graphql operation refreshO365Org
            InitMutationRefreshO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365Org.
        internal void ProcessRecord_DeleteOrg()
        {
            this._logger.name += " -DeleteOrg";
            // Create new graphql operation deleteO365Org
            InitMutationDeleteO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Mailbox.
        internal void ProcessRecord_RestoreMailbox()
        {
            this._logger.name += " -RestoreMailbox";
            // Create new graphql operation restoreO365Mailbox
            InitMutationRestoreO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Mailbox.
        internal void ProcessRecord_ExportMailbox()
        {
            this._logger.name += " -ExportMailbox";
            // Create new graphql operation exportO365Mailbox
            InitMutationExportO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // setO365ServiceAccount.
        internal void ProcessRecord_SetServiceAccount()
        {
            this._logger.name += " -SetServiceAccount";
            // Create new graphql operation setO365ServiceAccount
            InitMutationSetO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365SharePoint.
        internal void ProcessRecord_EnableSharePoint()
        {
            this._logger.name += " -EnableSharePoint";
            // Create new graphql operation enableO365SharePoint
            InitMutationEnableO365SharePoint();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365Teams.
        internal void ProcessRecord_EnableTeams()
        {
            this._logger.name += " -EnableTeams";
            // Create new graphql operation enableO365Teams
            InitMutationEnableO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365ServiceAccount.
        internal void ProcessRecord_DeleteServiceAccount()
        {
            this._logger.name += " -DeleteServiceAccount";
            // Create new graphql operation deleteO365ServiceAccount
            InitMutationDeleteO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365OrgCustomName.
        internal void ProcessRecord_UpdateOrgCustomName()
        {
            this._logger.name += " -UpdateOrgCustomName";
            // Create new graphql operation updateO365OrgCustomName
            InitMutationUpdateO365OrgCustomName();
        }


        // Create new GraphQL Mutation:
        // o365SaaSSetupKickoff: O365SaasSetupKickoffReply!
        internal void InitMutationO365SaaSsetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaaSsetupKickoff",
                "",
                "O365SaasSetupKickoffReply",
                Mutation.O365SaaSsetupKickoff_ObjectFieldSpec,
                Mutation.O365SaaSsetupKickoffFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // o365PdlGroups(input: O365PdlGroupsInput!): O365PdlGroupsReply!
        internal void InitMutationO365PdlGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365PdlGroupsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365PdlGroups",
                "($input: O365PdlGroupsInput!)",
                "O365PdlGroupsReply",
                Mutation.O365PdlGroups_ObjectFieldSpec,
                Mutation.O365PdlGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	pdlAndWorkloadPairs = @(
		@{
			# REQUIRED
			pdl = <System.String>
			# REQUIRED
			workload = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365SaasSetupComplete(input: O365SaasSetupCompleteInput!): AddO365OrgResponse!
        internal void InitMutationO365SaasSetupComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365SaasSetupCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SaasSetupComplete",
                "($input: O365SaasSetupCompleteInput!)",
                "AddO365OrgResponse",
                Mutation.O365SaasSetupComplete_ObjectFieldSpec,
                Mutation.O365SaasSetupCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	regionName = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	appTypes = @(
		<System.String>
	)
	# OPTIONAL
	kmsSpec = @{
		# OPTIONAL
		cloudType = <O365AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
		# OPTIONAL
		tenantId = <System.String>
		# OPTIONAL
		kmsId = <System.String>
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecret = <System.String>
		# OPTIONAL
		keyName = <System.String>
		# OPTIONAL
		kekNameColossus = <System.String>
	}
	# REQUIRED
	storeBackupInSameRegionAsData = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365SetupKickoff: O365SetupKickoffResp!
        internal void InitMutationO365SetupKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365SetupKickoff",
                "",
                "O365SetupKickoffResp",
                Mutation.O365SetupKickoff_ObjectFieldSpec,
                Mutation.O365SetupKickoffFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // addO365Org(input: AddO365OrgInput!): AddO365OrgResponse!
        internal void InitMutationAddO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddO365OrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddO365Org",
                "($input: AddO365OrgInput!)",
                "AddO365OrgResponse",
                Mutation.AddO365Org_ObjectFieldSpec,
                Mutation.AddO365OrgFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	exocomputeClusterId = <System.String>
	# REQUIRED
	appTypes = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365OauthConsentKickoff(input: O365OauthConsentKickoffInput!): O365OauthConsentKickoffReply!
        internal void InitMutationO365OauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentKickoff",
                "($input: O365OauthConsentKickoffInput!)",
                "O365OauthConsentKickoffReply",
                Mutation.O365OauthConsentKickoff_ObjectFieldSpec,
                Mutation.O365OauthConsentKickoffFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // o365OauthConsentComplete(input: O365OauthConsentCompleteInput!): O365OauthConsentCompleteReply!
        internal void InitMutationO365OauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentComplete",
                "($input: O365OauthConsentCompleteInput!)",
                "O365OauthConsentCompleteReply",
                Mutation.O365OauthConsentComplete_ObjectFieldSpec,
                Mutation.O365OauthConsentCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	code = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# REQUIRED
	resourceNaturalId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createO365AppKickoff(input: CreateO365AppKickoffInput!): CreateO365AppKickoffResp!
        internal void InitMutationCreateO365AppKickoff()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppKickoffInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppKickoff",
                "($input: CreateO365AppKickoffInput!)",
                "CreateO365AppKickoffResp",
                Mutation.CreateO365AppKickoff_ObjectFieldSpec,
                Mutation.CreateO365AppKickoffFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // createO365AppComplete(input: CreateO365AppCompleteInput!): RequestStatus!
        internal void InitMutationCreateO365AppComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppComplete",
                "($input: CreateO365AppCompleteInput!)",
                "RequestStatus",
                Mutation.CreateO365AppComplete_ObjectFieldSpec,
                Mutation.CreateO365AppCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appClientId = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	tenantId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // insertCustomerO365App(input: InsertCustomerO365AppInput!): RequestStatus!
        internal void InitMutationInsertCustomerO365App()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InsertCustomerO365AppInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInsertCustomerO365App",
                "($input: InsertCustomerO365AppInput!)",
                "RequestStatus",
                Mutation.InsertCustomerO365App_ObjectFieldSpec,
                Mutation.InsertCustomerO365AppFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appType = <System.String>
	# REQUIRED
	appClientId = <System.String>
	# REQUIRED
	appClientSecret = <System.String>
	# REQUIRED
	subscriptionId = <System.String>
	# OPTIONAL
	base64AppCertificate = <System.String>
	# OPTIONAL
	base64AppPrivateKey = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!): UpdateO365AppAuthStatusReply!
        internal void InitMutationUpdateO365AppAuthStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppAuthStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppAuthStatus",
                "($input: UpdateO365AppAuthStatusInput!)",
                "UpdateO365AppAuthStatusReply",
                Mutation.UpdateO365AppAuthStatus_ObjectFieldSpec,
                Mutation.UpdateO365AppAuthStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365OrgId = <System.String>
	# REQUIRED
	o365AppId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateO365AppPermissions(input: UpdateO365AppPermissionsInput!): Void
        internal void InitMutationUpdateO365AppPermissions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppPermissionsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppPermissions",
                "($input: UpdateO365AppPermissionsInput!)",
                "System.String",
                Mutation.UpdateO365AppPermissions_ObjectFieldSpec,
                Mutation.UpdateO365AppPermissionsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365AppType = <O365AppType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AppType]) for enum values.
	# REQUIRED
	o365AppId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!): RequestStatus!
        internal void InitMutationDeleteO365AzureApp()
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
                "RequestStatus",
                Mutation.DeleteO365AzureApp_ObjectFieldSpec,
                Mutation.DeleteO365AzureAppFieldSpec,
                @"# REQUIRED
$inputs.Var.o365AppClientId = <System.String>
# REQUIRED
$inputs.Var.o365AppType = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365Mailbox(mailboxIds: [UUID!]!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("mailboxIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Mailbox",
                "($mailboxIds: [UUID!]!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Mailbox_ObjectFieldSpec,
                Mutation.BackupO365MailboxFieldSpec,
                @"# REQUIRED
$inputs.Var.mailboxIds = @(
	<System.String>
)"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365Onedrive(input: BackupO365OnedriveInput!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365OnedriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Onedrive",
                "($input: BackupO365OnedriveInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Onedrive_ObjectFieldSpec,
                Mutation.BackupO365OnedriveFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365SharepointDrive(input: BackupO365SharepointDriveInput!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharepointDriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointDrive",
                "($input: BackupO365SharepointDriveInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365SharepointDrive_ObjectFieldSpec,
                Mutation.BackupO365SharepointDriveFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365SharepointList(input: BackupO365SharePointListInput!): CreateOnDemandJobReply!
        internal void InitMutationBackupO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointListInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointList",
                "($input: BackupO365SharePointListInput!)",
                "CreateOnDemandJobReply",
                Mutation.BackupO365SharepointList_ObjectFieldSpec,
                Mutation.BackupO365SharepointListFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuid = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
        internal void InitMutationBackupO365SharePointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointSiteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharePointSite",
                "($input: BackupO365SharePointSiteInput!)",
                "CreateOnDemandJobReply",
                Mutation.BackupO365SharePointSite_ObjectFieldSpec,
                Mutation.BackupO365SharePointSiteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	siteFid = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
        internal void InitMutationBackupO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365TeamInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Team",
                "($input: BackupO365TeamInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Team_ObjectFieldSpec,
                Mutation.BackupO365TeamFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365TeamsFiles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365TeamsFiles",
                "($input: RestoreO365TeamsFilesInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365TeamsFiles_ObjectFieldSpec,
                Mutation.RestoreO365TeamsFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filesToRestore = @(
		@{
			# REQUIRED
			fileId = <System.String>
			# REQUIRED
			fileName = <System.String>
			# REQUIRED
			fileSnapshotsToRestore = @(
				@{
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# REQUIRED
					fileSize = <System.Int64>
				}
			)
			# OPTIONAL
			channelInfo = @{
				# REQUIRED
				TeamID = <System.String>
				# OPTIONAL
				ChannelID = <System.String>
				# OPTIONAL
				ChannelName = <System.String>
				# OPTIONAL
				ChannelFolderName = <System.String>
				# OPTIONAL
				ChannelNaturalId = <System.String>
				# REQUIRED
				channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
		}
	)
	# REQUIRED
	foldersToRestore = @(
		@{
			# REQUIRED
			folderId = <System.String>
			# REQUIRED
			folderName = <System.String>
			# REQUIRED
			folderSize = <System.Int64>
			# REQUIRED
			snapshotId = <System.String>
			# REQUIRED
			snapshotNum = <System.Int32>
			# OPTIONAL
			channelInfo = @{
				# REQUIRED
				TeamID = <System.String>
				# OPTIONAL
				ChannelID = <System.String>
				# OPTIONAL
				ChannelName = <System.String>
				# OPTIONAL
				ChannelFolderName = <System.String>
				# OPTIONAL
				ChannelNaturalId = <System.String>
				# REQUIRED
				channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
		}
	)
	# OPTIONAL
	destTeamsChannelInfo = @{
		# REQUIRED
		TeamID = <System.String>
		# OPTIONAL
		ChannelID = <System.String>
		# OPTIONAL
		ChannelName = <System.String>
		# OPTIONAL
		ChannelFolderName = <System.String>
		# OPTIONAL
		ChannelNaturalId = <System.String>
		# REQUIRED
		channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldCreateDestChannel = <System.Boolean>
	# REQUIRED
	actionType = <O365RestoreActionType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# REQUIRED
	channelRecoveryType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# REQUIRED
	recoverWithLatestPermissions = <System.Boolean>
	# REQUIRED
	snapshotSequenceNum = <System.Int32>
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365TeamsConversations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsConversationsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365TeamsConversations",
                "($input: RestoreO365TeamsConversationsInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365TeamsConversations_ObjectFieldSpec,
                Mutation.RestoreO365TeamsConversationsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	teamUuid = <System.String>
	# OPTIONAL
	destTeamsChannelInfo = @{
		# REQUIRED
		TeamID = <System.String>
		# OPTIONAL
		ChannelID = <System.String>
		# OPTIONAL
		ChannelName = <System.String>
		# OPTIONAL
		ChannelFolderName = <System.String>
		# OPTIONAL
		ChannelNaturalId = <System.String>
		# REQUIRED
		channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldCreateDestChannel = <System.Boolean>
	# OPTIONAL
	channelInfoForFullRestore = @{
		# REQUIRED
		naturalId = <System.String>
		# REQUIRED
		name = <System.String>
		# REQUIRED
		folderId = <System.String>
		# REQUIRED
		membershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldRestoreFileAttachments = <System.Boolean>
	# REQUIRED
	teamChannels = @(
		@{
			# REQUIRED
			naturalId = <System.String>
			# REQUIRED
			name = <System.String>
			# REQUIRED
			folderId = <System.String>
			# REQUIRED
			membershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
		}
	)
	# OPTIONAL
	teamsConversationsSearchFilter = @{
		# OPTIONAL
		postedTime = @{
			# OPTIONAL
			fromTime = <DateTime>
			# OPTIONAL
			untilTime = <DateTime>
		}
		# OPTIONAL
		channelNaturalId = <System.String>
		# OPTIONAL
		postedBy = <System.String>
		# OPTIONAL
		snapshotId = <System.String>
		# OPTIONAL
		parentId = <System.String>
		# OPTIONAL
		convId = <System.String>
		# OPTIONAL
		snapshotNum = <System.Int32>
		# OPTIONAL
		includeArchived = <System.Boolean>
		# OPTIONAL
		fetchAllPostSenders = <System.String>
		# OPTIONAL
		skipPostsAttachments = <System.Boolean>
	}
	# REQUIRED
	refreshTokenEncrypted = <System.String>
	# REQUIRED
	o365AppId = <System.String>
	# REQUIRED
	channelRecoveryType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# REQUIRED
	recoverWithLatestPermissions = <System.Boolean>
	# REQUIRED
	snapshotSequenceNum = <System.Int32>
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365Snappable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365Snappable",
                "($input: RestoreO365SnappableInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365Snappable_ObjectFieldSpec,
                Mutation.RestoreO365SnappableFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
	# REQUIRED
	sourceSnappableUuid = <System.String>
	# REQUIRED
	destinationSnappableUuid = <System.String>
	# REQUIRED
	restoreConfig = @{
		# OPTIONAL
		SharePointDriveRestoreConfig = @{
			# REQUIRED
			driveRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = <System.String>
			}
			# OPTIONAL
			docLibName = <System.String>
			# OPTIONAL
			parentSiteUuid = <System.String>
		}
		# OPTIONAL
		sharePointListRestoreConfig = @{
			# REQUIRED
			itemsToRestore = @(
				@{
					# REQUIRED
					itemId = <System.String>
					# REQUIRED
					itemName = <System.String>
					# REQUIRED
					itemSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = <System.String>
							# REQUIRED
							snapshotNum = <System.Int32>
						}
					)
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = <System.String>
					# REQUIRED
					folderName = <System.String>
					# REQUIRED
					folderSize = <System.Int64>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = <System.String>
			# OPTIONAL
			listName = <System.String>
			# OPTIONAL
			parentSiteUuid = <System.String>
		}
		# OPTIONAL
		sharePointFullRestoreConfig = @{
			# OPTIONAL
			spObjectToRestore = @{
				# REQUIRED
				objectSharepointId = <System.String>
				# REQUIRED
				objectName = <System.String>
				# OPTIONAL
				objectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				snapshotId = <System.String>
				# REQUIRED
				snapshotNum = <System.Int32>
			}
			# OPTIONAL
			spItemsToRestore = @{
				# REQUIRED
				sharepointId = <System.String>
				# OPTIONAL
				snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				listItems = @(
					@{
						# REQUIRED
						itemId = <System.String>
						# REQUIRED
						itemName = <System.String>
						# REQUIRED
						itemSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
							}
						)
					}
				)
				# REQUIRED
				folderItems = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				fileItems = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				arePageLibraryItems = <System.Boolean>
			}
			# OPTIONAL
			targetObjectUuid = <System.String>
			# OPTIONAL
			targetObjectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# REQUIRED
			shouldCreateNewObject = <System.Boolean>
			# OPTIONAL
			newObjectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# OPTIONAL
			newObjectName = <System.String>
		}
		# OPTIONAL
		OneDriveRestoreConfig = @{
			# REQUIRED
			filesToRestore = @(
				@{
					# REQUIRED
					fileId = <System.String>
					# REQUIRED
					fileName = <System.String>
					# REQUIRED
					fileSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = <System.String>
							# REQUIRED
							snapshotNum = <System.Int32>
							# REQUIRED
							fileSize = <System.Int64>
						}
					)
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = <System.String>
					# REQUIRED
					folderName = <System.String>
					# REQUIRED
					folderSize = <System.Int64>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = <System.String>
		}
		# OPTIONAL
		TeamsRestoreConfig = @{
			# OPTIONAL
			filesRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = <System.String>
			}
			# OPTIONAL
			conversationsRestoreConfig = @{
				# OPTIONAL
				SearchFilter = @{
					# OPTIONAL
					PostedTime = @{
						# OPTIONAL
						FromTime = <System.Int64>
						# OPTIONAL
						UntilTime = <System.Int64>
					}
					# OPTIONAL
					PostedBy = <System.String>
					# OPTIONAL
					SnapshotId = <System.String>
				}
				# OPTIONAL
				ChannelInfoForFullRestore = @{
					# REQUIRED
					TeamID = <System.String>
					# OPTIONAL
					ChannelID = <System.String>
					# OPTIONAL
					ChannelName = <System.String>
					# OPTIONAL
					ChannelFolderName = <System.String>
					# OPTIONAL
					ChannelFolderId = <System.String>
					# OPTIONAL
					ChannelNaturalId = <System.String>
				}
				# REQUIRED
				RefreshTokenEncrypted = <System.String>
				# REQUIRED
				O365AppID = <System.String>
				# REQUIRED
				ChannelsToRestore = @(
					@{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelFolderId = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
					}
				)
				# REQUIRED
				ShouldRestoreFileAttachments = <System.Boolean>
			}
			# OPTIONAL
			destChannelInfo = @{
				# REQUIRED
				TeamID = <System.String>
				# OPTIONAL
				ChannelID = <System.String>
				# OPTIONAL
				ChannelName = <System.String>
				# OPTIONAL
				ChannelFolderName = <System.String>
				# OPTIONAL
				ChannelNaturalId = <System.String>
				# REQUIRED
				channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
			# REQUIRED
			shouldCreateDestChannel = <System.Boolean>
			# REQUIRED
			channelType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			# REQUIRED
			restoreLatestPermissions = <System.Boolean>
			# REQUIRED
			snapshotSequenceNum = <System.Int32>
		}
		# OPTIONAL
		MailboxRestoreConfig = @{
			# OPTIONAL
			SnapshotUUID = <System.String>
			# REQUIRED
			RestoreConfigs = @(
				@{
					# REQUIRED
					SnapshotUUID = <System.String>
					# OPTIONAL
					EmailID = <System.String>
					# OPTIONAL
					FolderID = <System.String>
				}
			)
		}
		# OPTIONAL
		calendarRestoreConfig = @{
			# REQUIRED
			eventsToRestore = @(
				@{
					# REQUIRED
					eventId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
			# REQUIRED
			calendarsToRestore = @(
				@{
					# REQUIRED
					calendarId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
			# REQUIRED
			calendarGroupsToRestore = @(
				@{
					# REQUIRED
					calendarGroupId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
		}
		# OPTIONAL
		contactsRestoreConfig = @{
			# REQUIRED
			contactsToRestore = @(
				@{
					# REQUIRED
					contactId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
				}
			)
			# REQUIRED
			contactFoldersToRestore = @(
				@{
					# REQUIRED
					contactFolderId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
				}
			)
		}
	}
	# REQUIRED
	actionType = <O365RestoreActionType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshO365Org(orgId: UUID!): CreateOnDemandJobReply!
        internal void InitMutationRefreshO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshO365Org",
                "($orgId: UUID!)",
                "CreateOnDemandJobReply",
                Mutation.RefreshO365Org_ObjectFieldSpec,
                Mutation.RefreshO365OrgFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
        internal void InitMutationDeleteO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365Org",
                "($orgId: UUID!)",
                "CreateOnDemandJobReply",
                Mutation.DeleteO365Org_ObjectFieldSpec,
                Mutation.DeleteO365OrgFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
        internal void InitMutationRestoreO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("restoreConfig", "RestoreO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreO365Mailbox",
                "($restoreConfig: RestoreO365MailboxInput!)",
                "CreateOnDemandJobReply",
                Mutation.RestoreO365Mailbox_ObjectFieldSpec,
                Mutation.RestoreO365MailboxFieldSpec,
                @"# REQUIRED
$inputs.Var.restoreConfig = @{
	# OPTIONAL
	orgUuid = <System.String>
	# REQUIRED
	mailboxUuid = <System.String>
	# OPTIONAL
	snapshotUuid = <System.String>
	# REQUIRED
	restoreConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = <System.String>
			# OPTIONAL
			EmailID = <System.String>
			# OPTIONAL
			FolderID = <System.String>
		}
	)
	# REQUIRED
	actionType = <O365RestoreActionType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
        internal void InitMutationExportO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exportConfig", "ExportO365MailboxInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportO365Mailbox",
                "($exportConfig: ExportO365MailboxInput!)",
                "CreateOnDemandJobReply",
                Mutation.ExportO365Mailbox_ObjectFieldSpec,
                Mutation.ExportO365MailboxFieldSpec,
                @"# REQUIRED
$inputs.Var.exportConfig = @{
	# OPTIONAL
	orgUuid = <System.String>
	# REQUIRED
	fromMailboxUuid = <System.String>
	# REQUIRED
	toMailboxUuid = <System.String>
	# OPTIONAL
	snapshotUuid = <System.String>
	# REQUIRED
	exportConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = <System.String>
			# OPTIONAL
			EmailID = <System.String>
			# OPTIONAL
			FolderID = <System.String>
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // setO365ServiceAccount(username: String!, appPassword: String!, orgId: UUID!): RequestStatus!
        internal void InitMutationSetO365ServiceAccount()
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
                "RequestStatus",
                Mutation.SetO365ServiceAccount_ObjectFieldSpec,
                Mutation.SetO365ServiceAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.username = <System.String>
# REQUIRED
$inputs.Var.appPassword = <System.String>
# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // enableO365SharePoint(input: EnableO365SharePointInput!): RequestStatus!
        internal void InitMutationEnableO365SharePoint()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "EnableO365SharePointInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365SharePoint",
                "($input: EnableO365SharePointInput!)",
                "RequestStatus",
                Mutation.EnableO365SharePoint_ObjectFieldSpec,
                Mutation.EnableO365SharePointFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	exocomputeClusterId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // enableO365Teams(exocomputeClusterId: String!): RequestStatus!
        internal void InitMutationEnableO365Teams()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationEnableO365Teams",
                "($exocomputeClusterId: String!)",
                "RequestStatus",
                Mutation.EnableO365Teams_ObjectFieldSpec,
                Mutation.EnableO365TeamsFieldSpec,
                @"# REQUIRED
$inputs.Var.exocomputeClusterId = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // deleteO365ServiceAccount(orgId: UUID!): RequestStatus!
        internal void InitMutationDeleteO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365ServiceAccount",
                "($orgId: UUID!)",
                "RequestStatus",
                Mutation.DeleteO365ServiceAccount_ObjectFieldSpec,
                Mutation.DeleteO365ServiceAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // updateO365OrgCustomName(input: UpdateO365OrgCustomNameInput!): UpdateO365OrgCustomNameReply!
        internal void InitMutationUpdateO365OrgCustomName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365OrgCustomNameInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365OrgCustomName",
                "($input: UpdateO365OrgCustomNameInput!)",
                "UpdateO365OrgCustomNameReply",
                Mutation.UpdateO365OrgCustomName_ObjectFieldSpec,
                Mutation.UpdateO365OrgCustomNameFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgUuid = <System.String>
	# REQUIRED
	customName = <System.String>
}"
            );
        }


    } // class New_RscMutationO365
}