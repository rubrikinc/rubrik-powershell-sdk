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
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateO365",
        DefaultParameterSetName = "Addorg")
    ]
    public class Invoke_RscMutateO365 : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Saassetupkickoff parameter set
        //
        // [GraphQL: o365SaaSSetupKickoff]
        //
        [Parameter(
            ParameterSetName = "Saassetupkickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365SaaSSetupKickoff]",
            Position = 0
        )]
        public SwitchParameter Saassetupkickoff { get; set; }

        
        // -------------------------------------------------------------------
        // Pdlgroup parameter set
        //
        // [GraphQL: o365PdlGroups]
        //
        [Parameter(
            ParameterSetName = "Pdlgroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.
[GraphQL: o365PdlGroups]",
            Position = 0
        )]
        public SwitchParameter Pdlgroup { get; set; }

        [Parameter(
            ParameterSetName = "Pdlgroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The input for the O365PdlGroups mutation.
GraphQL argument input: O365PdlGroupsInput!"
        )]
        public O365PdlGroupsInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // Saassetupcomplete parameter set
        //
        // [GraphQL: o365SaasSetupComplete]
        //
        [Parameter(
            ParameterSetName = "Saassetupcomplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes a Rubrik-Hosted setup flow.
[GraphQL: o365SaasSetupComplete]",
            Position = 0
        )]
        public SwitchParameter Saassetupcomplete { get; set; }

        
        // -------------------------------------------------------------------
        // Setupkickoff parameter set
        //
        // [GraphQL: o365SetupKickoff]
        //
        [Parameter(
            ParameterSetName = "Setupkickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off an O365 subscription setup flow.
[GraphQL: o365SetupKickoff]",
            Position = 0
        )]
        public SwitchParameter Setupkickoff { get; set; }

        
        // -------------------------------------------------------------------
        // Addorg parameter set
        //
        // [GraphQL: addO365Org]
        //
        [Parameter(
            ParameterSetName = "Addorg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Adds an O365 org to the account.
[GraphQL: addO365Org]",
            Position = 0
        )]
        public SwitchParameter Addorg { get; set; }

        
        // -------------------------------------------------------------------
        // Oauthconsentkickoff parameter set
        //
        // [GraphQL: o365OauthConsentKickoff]
        //
        [Parameter(
            ParameterSetName = "Oauthconsentkickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off the OAuth consent flow for an O365 Azure AD App.
[GraphQL: o365OauthConsentKickoff]",
            Position = 0
        )]
        public SwitchParameter Oauthconsentkickoff { get; set; }

        
        // -------------------------------------------------------------------
        // Oauthconsentcomplete parameter set
        //
        // [GraphQL: o365OauthConsentComplete]
        //
        [Parameter(
            ParameterSetName = "Oauthconsentcomplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes the OAuth consent flow for an O365 Azure AD App.
[GraphQL: o365OauthConsentComplete]",
            Position = 0
        )]
        public SwitchParameter Oauthconsentcomplete { get; set; }

        
        // -------------------------------------------------------------------
        // Createappkickoff parameter set
        //
        // [GraphQL: createO365AppKickoff]
        //
        [Parameter(
            ParameterSetName = "Createappkickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Kicks off the creation flow for an O365 Azure AD App.
[GraphQL: createO365AppKickoff]",
            Position = 0
        )]
        public SwitchParameter Createappkickoff { get; set; }

        
        // -------------------------------------------------------------------
        // Createappcomplete parameter set
        //
        // [GraphQL: createO365AppComplete]
        //
        [Parameter(
            ParameterSetName = "Createappcomplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Completes the creation flow for an O365 Azure AD App.
[GraphQL: createO365AppComplete]",
            Position = 0
        )]
        public SwitchParameter Createappcomplete { get; set; }

        
        // -------------------------------------------------------------------
        // Insertcustomerapp parameter set
        //
        // [GraphQL: insertCustomerO365App]
        //
        [Parameter(
            ParameterSetName = "Insertcustomerapp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Inserts a Customer-hosted O365 Azure AD App.
[GraphQL: insertCustomerO365App]",
            Position = 0
        )]
        public SwitchParameter Insertcustomerapp { get; set; }

        
        // -------------------------------------------------------------------
        // Updateappauthstatus parameter set
        //
        // [GraphQL: updateO365AppAuthStatus]
        //
        [Parameter(
            ParameterSetName = "Updateappauthstatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update O365 App authentication status to applicable app version.
[GraphQL: updateO365AppAuthStatus]",
            Position = 0
        )]
        public SwitchParameter Updateappauthstatus { get; set; }

        
        // -------------------------------------------------------------------
        // Updateapppermission parameter set
        //
        // [GraphQL: updateO365AppPermissions]
        //
        [Parameter(
            ParameterSetName = "Updateapppermission",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update O365 Azure app permission in Azure AD portal.
[GraphQL: updateO365AppPermissions]",
            Position = 0
        )]
        public SwitchParameter Updateapppermission { get; set; }

        
        // -------------------------------------------------------------------
        // Deleteazureapp parameter set
        //
        // [GraphQL: deleteO365AzureApp]
        //
        [Parameter(
            ParameterSetName = "Deleteazureapp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes an O365 Azure AD App from the account.
[GraphQL: deleteO365AzureApp]",
            Position = 0
        )]
        public SwitchParameter Deleteazureapp { get; set; }

        [Parameter(
            ParameterSetName = "Deleteazureapp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument o365AppClientId: String!"
        )]
        public System.String? O365AppClientId { get; set; }
        [Parameter(
            ParameterSetName = "Deleteazureapp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument o365AppType: String!"
        )]
        public System.String? O365AppType { get; set; }
        
        // -------------------------------------------------------------------
        // Backupmailbox parameter set
        //
        // [GraphQL: backupO365Mailbox]
        //
        [Parameter(
            ParameterSetName = "Backupmailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Backup mailbox workload.
[GraphQL: backupO365Mailbox]",
            Position = 0
        )]
        public SwitchParameter Backupmailbox { get; set; }

        [Parameter(
            ParameterSetName = "Backupmailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The list of mailbox UUIDs to backup.
GraphQL argument mailboxIds: [UUID!]!"
        )]
        public List<System.String>? MailboxIds { get; set; }
        
        // -------------------------------------------------------------------
        // Backuponedrive parameter set
        //
        // [GraphQL: backupO365Onedrive]
        //
        [Parameter(
            ParameterSetName = "Backuponedrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for Onedrive.
[GraphQL: backupO365Onedrive]",
            Position = 0
        )]
        public SwitchParameter Backuponedrive { get; set; }

        
        // -------------------------------------------------------------------
        // Backupsharepointdrive parameter set
        //
        // [GraphQL: backupO365SharepointDrive]
        //
        [Parameter(
            ParameterSetName = "Backupsharepointdrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for Sharepoint drive.
[GraphQL: backupO365SharepointDrive]",
            Position = 0
        )]
        public SwitchParameter Backupsharepointdrive { get; set; }

        
        // -------------------------------------------------------------------
        // Backupsharepointlist parameter set
        //
        // [GraphQL: backupO365SharepointList]
        //
        [Parameter(
            ParameterSetName = "Backupsharepointlist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for SharePoint list.
[GraphQL: backupO365SharepointList]",
            Position = 0
        )]
        public SwitchParameter Backupsharepointlist { get; set; }

        
        // -------------------------------------------------------------------
        // Backupsharepointsite parameter set
        //
        // [GraphQL: backupO365SharePointSite]
        //
        [Parameter(
            ParameterSetName = "Backupsharepointsite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for a SharePoint site.
[GraphQL: backupO365SharePointSite]",
            Position = 0
        )]
        public SwitchParameter Backupsharepointsite { get; set; }

        
        // -------------------------------------------------------------------
        // Backupteam parameter set
        //
        // [GraphQL: backupO365Team]
        //
        [Parameter(
            ParameterSetName = "Backupteam",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Take on-demand snapshot for Teams.
[GraphQL: backupO365Team]",
            Position = 0
        )]
        public SwitchParameter Backupteam { get; set; }

        
        // -------------------------------------------------------------------
        // Restoreteamsfile parameter set
        //
        // [GraphQL: restoreO365TeamsFiles]
        //
        [Parameter(
            ParameterSetName = "Restoreteamsfile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore Team files.
[GraphQL: restoreO365TeamsFiles]",
            Position = 0
        )]
        public SwitchParameter Restoreteamsfile { get; set; }

        
        // -------------------------------------------------------------------
        // Restoreteamsconversation parameter set
        //
        // [GraphQL: restoreO365TeamsConversations]
        //
        [Parameter(
            ParameterSetName = "Restoreteamsconversation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore Team conversations.
[GraphQL: restoreO365TeamsConversations]",
            Position = 0
        )]
        public SwitchParameter Restoreteamsconversation { get; set; }

        
        // -------------------------------------------------------------------
        // Restoresnappable parameter set
        //
        // [GraphQL: restoreO365Snappable]
        //
        [Parameter(
            ParameterSetName = "Restoresnappable",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restores an O365 snappable.
[GraphQL: restoreO365Snappable]",
            Position = 0
        )]
        public SwitchParameter Restoresnappable { get; set; }

        
        // -------------------------------------------------------------------
        // Refreshorg parameter set
        //
        // [GraphQL: refreshO365Org]
        //
        [Parameter(
            ParameterSetName = "Refreshorg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refreshes an O365 org.
[GraphQL: refreshO365Org]",
            Position = 0
        )]
        public SwitchParameter Refreshorg { get; set; }

        [Parameter(
            ParameterSetName = "Refreshorg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Org UUID.
GraphQL argument orgId: UUID!"
        )]
        public System.String? OrgId { get; set; }
        
        // -------------------------------------------------------------------
        // Deleteorg parameter set
        //
        // [GraphQL: deleteO365Org]
        //
        [Parameter(
            ParameterSetName = "Deleteorg",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes an O365 org from the account.
[GraphQL: deleteO365Org]",
            Position = 0
        )]
        public SwitchParameter Deleteorg { get; set; }

        
        // -------------------------------------------------------------------
        // Restoremailbox parameter set
        //
        // [GraphQL: restoreO365Mailbox]
        //
        [Parameter(
            ParameterSetName = "Restoremailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restores an Exchange mailbox.
[GraphQL: restoreO365Mailbox]",
            Position = 0
        )]
        public SwitchParameter Restoremailbox { get; set; }

        [Parameter(
            ParameterSetName = "Restoremailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument restoreConfig: RestoreO365MailboxInput!"
        )]
        public RestoreO365MailboxInput? RestoreConfig { get; set; }
        
        // -------------------------------------------------------------------
        // Exportmailbox parameter set
        //
        // [GraphQL: exportO365Mailbox]
        //
        [Parameter(
            ParameterSetName = "Exportmailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Exports an Exchange mailbox.
[GraphQL: exportO365Mailbox]",
            Position = 0
        )]
        public SwitchParameter Exportmailbox { get; set; }

        [Parameter(
            ParameterSetName = "Exportmailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument exportConfig: ExportO365MailboxInput!"
        )]
        public ExportO365MailboxInput? ExportConfig { get; set; }
        
        // -------------------------------------------------------------------
        // Setserviceaccount parameter set
        //
        // [GraphQL: setO365ServiceAccount]
        //
        [Parameter(
            ParameterSetName = "Setserviceaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sets the service account for the org.
[GraphQL: setO365ServiceAccount]",
            Position = 0
        )]
        public SwitchParameter Setserviceaccount { get; set; }

        [Parameter(
            ParameterSetName = "Setserviceaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument username: String!"
        )]
        public System.String? Username { get; set; }
        [Parameter(
            ParameterSetName = "Setserviceaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument appPassword: String!"
        )]
        public System.String? AppPassword { get; set; }
        
        // -------------------------------------------------------------------
        // Enablesharepoint parameter set
        //
        // [GraphQL: enableO365SharePoint]
        //
        [Parameter(
            ParameterSetName = "Enablesharepoint",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Enables SharePoint protection in the exocompute cluster.
[GraphQL: enableO365SharePoint]",
            Position = 0
        )]
        public SwitchParameter Enablesharepoint { get; set; }

        
        // -------------------------------------------------------------------
        // Enableteam parameter set
        //
        // [GraphQL: enableO365Teams]
        //
        [Parameter(
            ParameterSetName = "Enableteam",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Enables Teams protection in the exocompute cluster.
[GraphQL: enableO365Teams]",
            Position = 0
        )]
        public SwitchParameter Enableteam { get; set; }

        [Parameter(
            ParameterSetName = "Enableteam",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument exocomputeClusterId: String!"
        )]
        public System.String? ExocomputeClusterId { get; set; }
        
        // -------------------------------------------------------------------
        // Deleteserviceaccount parameter set
        //
        // [GraphQL: deleteO365ServiceAccount]
        //
        [Parameter(
            ParameterSetName = "Deleteserviceaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Deletes the service account for an org.
[GraphQL: deleteO365ServiceAccount]",
            Position = 0
        )]
        public SwitchParameter Deleteserviceaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Updateorgcustomname parameter set
        //
        // [GraphQL: updateO365OrgCustomName]
        //
        [Parameter(
            ParameterSetName = "Updateorgcustomname",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update the custom name for an O365 Organization.
[GraphQL: updateO365OrgCustomName]",
            Position = 0
        )]
        public SwitchParameter Updateorgcustomname { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Saassetupkickoff":
                        this.ProcessRecord_Saassetupkickoff();
                        break;
                    case "Pdlgroup":
                        this.ProcessRecord_Pdlgroup();
                        break;
                    case "Saassetupcomplete":
                        this.ProcessRecord_Saassetupcomplete();
                        break;
                    case "Setupkickoff":
                        this.ProcessRecord_Setupkickoff();
                        break;
                    case "Addorg":
                        this.ProcessRecord_Addorg();
                        break;
                    case "Oauthconsentkickoff":
                        this.ProcessRecord_Oauthconsentkickoff();
                        break;
                    case "Oauthconsentcomplete":
                        this.ProcessRecord_Oauthconsentcomplete();
                        break;
                    case "Createappkickoff":
                        this.ProcessRecord_Createappkickoff();
                        break;
                    case "Createappcomplete":
                        this.ProcessRecord_Createappcomplete();
                        break;
                    case "Insertcustomerapp":
                        this.ProcessRecord_Insertcustomerapp();
                        break;
                    case "Updateappauthstatus":
                        this.ProcessRecord_Updateappauthstatus();
                        break;
                    case "Updateapppermission":
                        this.ProcessRecord_Updateapppermission();
                        break;
                    case "Deleteazureapp":
                        this.ProcessRecord_Deleteazureapp();
                        break;
                    case "Backupmailbox":
                        this.ProcessRecord_Backupmailbox();
                        break;
                    case "Backuponedrive":
                        this.ProcessRecord_Backuponedrive();
                        break;
                    case "Backupsharepointdrive":
                        this.ProcessRecord_Backupsharepointdrive();
                        break;
                    case "Backupsharepointlist":
                        this.ProcessRecord_Backupsharepointlist();
                        break;
                    case "Backupsharepointsite":
                        this.ProcessRecord_Backupsharepointsite();
                        break;
                    case "Backupteam":
                        this.ProcessRecord_Backupteam();
                        break;
                    case "Restoreteamsfile":
                        this.ProcessRecord_Restoreteamsfile();
                        break;
                    case "Restoreteamsconversation":
                        this.ProcessRecord_Restoreteamsconversation();
                        break;
                    case "Restoresnappable":
                        this.ProcessRecord_Restoresnappable();
                        break;
                    case "Refreshorg":
                        this.ProcessRecord_Refreshorg();
                        break;
                    case "Deleteorg":
                        this.ProcessRecord_Deleteorg();
                        break;
                    case "Restoremailbox":
                        this.ProcessRecord_Restoremailbox();
                        break;
                    case "Exportmailbox":
                        this.ProcessRecord_Exportmailbox();
                        break;
                    case "Setserviceaccount":
                        this.ProcessRecord_Setserviceaccount();
                        break;
                    case "Enablesharepoint":
                        this.ProcessRecord_Enablesharepoint();
                        break;
                    case "Enableteam":
                        this.ProcessRecord_Enableteam();
                        break;
                    case "Deleteserviceaccount":
                        this.ProcessRecord_Deleteserviceaccount();
                        break;
                    case "Updateorgcustomname":
                        this.ProcessRecord_Updateorgcustomname();
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
        protected void ProcessRecord_Saassetupkickoff()
        {
            this._logger.name += " -Saassetupkickoff";
            // Invoke graphql operation o365SaaSSetupKickoff
            InvokeMutationO365SaaSsetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365PdlGroups.
        protected void ProcessRecord_Pdlgroup()
        {
            this._logger.name += " -Pdlgroup";
            // Invoke graphql operation o365PdlGroups
            InvokeMutationO365PdlGroups();
        }

        // This parameter set invokes a single graphql operation:
        // o365SaasSetupComplete.
        protected void ProcessRecord_Saassetupcomplete()
        {
            this._logger.name += " -Saassetupcomplete";
            // Invoke graphql operation o365SaasSetupComplete
            InvokeMutationO365SaasSetupComplete();
        }

        // This parameter set invokes a single graphql operation:
        // o365SetupKickoff.
        protected void ProcessRecord_Setupkickoff()
        {
            this._logger.name += " -Setupkickoff";
            // Invoke graphql operation o365SetupKickoff
            InvokeMutationO365SetupKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // addO365Org.
        protected void ProcessRecord_Addorg()
        {
            this._logger.name += " -Addorg";
            // Invoke graphql operation addO365Org
            InvokeMutationAddO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentKickoff.
        protected void ProcessRecord_Oauthconsentkickoff()
        {
            this._logger.name += " -Oauthconsentkickoff";
            // Invoke graphql operation o365OauthConsentKickoff
            InvokeMutationO365OauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // o365OauthConsentComplete.
        protected void ProcessRecord_Oauthconsentcomplete()
        {
            this._logger.name += " -Oauthconsentcomplete";
            // Invoke graphql operation o365OauthConsentComplete
            InvokeMutationO365OauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppKickoff.
        protected void ProcessRecord_Createappkickoff()
        {
            this._logger.name += " -Createappkickoff";
            // Invoke graphql operation createO365AppKickoff
            InvokeMutationCreateO365AppKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // createO365AppComplete.
        protected void ProcessRecord_Createappcomplete()
        {
            this._logger.name += " -Createappcomplete";
            // Invoke graphql operation createO365AppComplete
            InvokeMutationCreateO365AppComplete();
        }

        // This parameter set invokes a single graphql operation:
        // insertCustomerO365App.
        protected void ProcessRecord_Insertcustomerapp()
        {
            this._logger.name += " -Insertcustomerapp";
            // Invoke graphql operation insertCustomerO365App
            InvokeMutationInsertCustomerO365App();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppAuthStatus.
        protected void ProcessRecord_Updateappauthstatus()
        {
            this._logger.name += " -Updateappauthstatus";
            // Invoke graphql operation updateO365AppAuthStatus
            InvokeMutationUpdateO365AppAuthStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365AppPermissions.
        protected void ProcessRecord_Updateapppermission()
        {
            this._logger.name += " -Updateapppermission";
            // Invoke graphql operation updateO365AppPermissions
            InvokeMutationUpdateO365AppPermissions();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365AzureApp.
        protected void ProcessRecord_Deleteazureapp()
        {
            this._logger.name += " -Deleteazureapp";
            // Invoke graphql operation deleteO365AzureApp
            InvokeMutationDeleteO365AzureApp();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Mailbox.
        protected void ProcessRecord_Backupmailbox()
        {
            this._logger.name += " -Backupmailbox";
            // Invoke graphql operation backupO365Mailbox
            InvokeMutationBackupO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Onedrive.
        protected void ProcessRecord_Backuponedrive()
        {
            this._logger.name += " -Backuponedrive";
            // Invoke graphql operation backupO365Onedrive
            InvokeMutationBackupO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointDrive.
        protected void ProcessRecord_Backupsharepointdrive()
        {
            this._logger.name += " -Backupsharepointdrive";
            // Invoke graphql operation backupO365SharepointDrive
            InvokeMutationBackupO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharepointList.
        protected void ProcessRecord_Backupsharepointlist()
        {
            this._logger.name += " -Backupsharepointlist";
            // Invoke graphql operation backupO365SharepointList
            InvokeMutationBackupO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365SharePointSite.
        protected void ProcessRecord_Backupsharepointsite()
        {
            this._logger.name += " -Backupsharepointsite";
            // Invoke graphql operation backupO365SharePointSite
            InvokeMutationBackupO365SharePointSite();
        }

        // This parameter set invokes a single graphql operation:
        // backupO365Team.
        protected void ProcessRecord_Backupteam()
        {
            this._logger.name += " -Backupteam";
            // Invoke graphql operation backupO365Team
            InvokeMutationBackupO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsFiles.
        protected void ProcessRecord_Restoreteamsfile()
        {
            this._logger.name += " -Restoreteamsfile";
            // Invoke graphql operation restoreO365TeamsFiles
            InvokeMutationRestoreO365TeamsFiles();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365TeamsConversations.
        protected void ProcessRecord_Restoreteamsconversation()
        {
            this._logger.name += " -Restoreteamsconversation";
            // Invoke graphql operation restoreO365TeamsConversations
            InvokeMutationRestoreO365TeamsConversations();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Snappable.
        protected void ProcessRecord_Restoresnappable()
        {
            this._logger.name += " -Restoresnappable";
            // Invoke graphql operation restoreO365Snappable
            InvokeMutationRestoreO365Snappable();
        }

        // This parameter set invokes a single graphql operation:
        // refreshO365Org.
        protected void ProcessRecord_Refreshorg()
        {
            this._logger.name += " -Refreshorg";
            // Invoke graphql operation refreshO365Org
            InvokeMutationRefreshO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365Org.
        protected void ProcessRecord_Deleteorg()
        {
            this._logger.name += " -Deleteorg";
            // Invoke graphql operation deleteO365Org
            InvokeMutationDeleteO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // restoreO365Mailbox.
        protected void ProcessRecord_Restoremailbox()
        {
            this._logger.name += " -Restoremailbox";
            // Invoke graphql operation restoreO365Mailbox
            InvokeMutationRestoreO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // exportO365Mailbox.
        protected void ProcessRecord_Exportmailbox()
        {
            this._logger.name += " -Exportmailbox";
            // Invoke graphql operation exportO365Mailbox
            InvokeMutationExportO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // setO365ServiceAccount.
        protected void ProcessRecord_Setserviceaccount()
        {
            this._logger.name += " -Setserviceaccount";
            // Invoke graphql operation setO365ServiceAccount
            InvokeMutationSetO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365SharePoint.
        protected void ProcessRecord_Enablesharepoint()
        {
            this._logger.name += " -Enablesharepoint";
            // Invoke graphql operation enableO365SharePoint
            InvokeMutationEnableO365SharePoint();
        }

        // This parameter set invokes a single graphql operation:
        // enableO365Teams.
        protected void ProcessRecord_Enableteam()
        {
            this._logger.name += " -Enableteam";
            // Invoke graphql operation enableO365Teams
            InvokeMutationEnableO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // deleteO365ServiceAccount.
        protected void ProcessRecord_Deleteserviceaccount()
        {
            this._logger.name += " -Deleteserviceaccount";
            // Invoke graphql operation deleteO365ServiceAccount
            InvokeMutationDeleteO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateO365OrgCustomName.
        protected void ProcessRecord_Updateorgcustomname()
        {
            this._logger.name += " -Updateorgcustomname";
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
                if (this.Field is PSObject psObject) {
                    fields = (O365SaasSetupKickoffReply)psObject.BaseObject;
                } else {
                    fields = (O365SaasSetupKickoffReply)this.Field;
                }
            }
            string document = Mutation.O365SaaSsetupKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365SaaSsetupKickoff");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365SaaSsetupKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationO365SaaSsetupKickoff",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "O365SaasSetupKickoffReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (O365PdlGroupsReply)psObject.BaseObject;
                } else {
                    fields = (O365PdlGroupsReply)this.Field;
                }
            }
            string document = Mutation.O365PdlGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365PdlGroups");
            var parameters = "($input: O365PdlGroupsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365PdlGroups" + parameters + "{" + document + "}",
                OperationName = "MutationO365PdlGroups",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365PdlGroupsReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AddO365OrgResponse)psObject.BaseObject;
                } else {
                    fields = (AddO365OrgResponse)this.Field;
                }
            }
            string document = Mutation.O365SaasSetupComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365SaasSetupComplete");
            var parameters = "($input: O365SaasSetupCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365SaasSetupComplete" + parameters + "{" + document + "}",
                OperationName = "MutationO365SaasSetupComplete",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddO365OrgResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (O365SetupKickoffResp)psObject.BaseObject;
                } else {
                    fields = (O365SetupKickoffResp)this.Field;
                }
            }
            string document = Mutation.O365SetupKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365SetupKickoff");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365SetupKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationO365SetupKickoff",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "O365SetupKickoffResp", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (AddO365OrgResponse)psObject.BaseObject;
                } else {
                    fields = (AddO365OrgResponse)this.Field;
                }
            }
            string document = Mutation.AddO365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddO365Org");
            var parameters = "($input: AddO365OrgInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddO365Org" + parameters + "{" + document + "}",
                OperationName = "MutationAddO365Org",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "AddO365OrgResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (O365OauthConsentKickoffReply)psObject.BaseObject;
                } else {
                    fields = (O365OauthConsentKickoffReply)this.Field;
                }
            }
            string document = Mutation.O365OauthConsentKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365OauthConsentKickoff");
            var parameters = "($input: O365OauthConsentKickoffInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365OauthConsentKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationO365OauthConsentKickoff",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365OauthConsentKickoffReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (O365OauthConsentCompleteReply)psObject.BaseObject;
                } else {
                    fields = (O365OauthConsentCompleteReply)this.Field;
                }
            }
            string document = Mutation.O365OauthConsentComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.O365OauthConsentComplete");
            var parameters = "($input: O365OauthConsentCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationO365OauthConsentComplete" + parameters + "{" + document + "}",
                OperationName = "MutationO365OauthConsentComplete",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365OauthConsentCompleteReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (CreateO365AppKickoffResp)psObject.BaseObject;
                } else {
                    fields = (CreateO365AppKickoffResp)this.Field;
                }
            }
            string document = Mutation.CreateO365AppKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateO365AppKickoff");
            var parameters = "($input: CreateO365AppKickoffInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateO365AppKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationCreateO365AppKickoff",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "CreateO365AppKickoffResp", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.CreateO365AppComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateO365AppComplete");
            var parameters = "($input: CreateO365AppCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateO365AppComplete" + parameters + "{" + document + "}",
                OperationName = "MutationCreateO365AppComplete",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.InsertCustomerO365App(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.InsertCustomerO365App");
            var parameters = "($input: InsertCustomerO365AppInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationInsertCustomerO365App" + parameters + "{" + document + "}",
                OperationName = "MutationInsertCustomerO365App",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (UpdateO365AppAuthStatusReply)psObject.BaseObject;
                } else {
                    fields = (UpdateO365AppAuthStatusReply)this.Field;
                }
            }
            string document = Mutation.UpdateO365AppAuthStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateO365AppAuthStatus");
            var parameters = "($input: UpdateO365AppAuthStatusInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateO365AppAuthStatus" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateO365AppAuthStatus",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateO365AppAuthStatusReply", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateO365AppPermissions(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateO365AppPermissions");
            var parameters = "($input: UpdateO365AppPermissionsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateO365AppPermissions" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateO365AppPermissions",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "System.String", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteO365AzureApp(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteO365AzureApp");
            var parameters = "($o365AppClientId: String!,$o365AppType: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteO365AzureApp" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteO365AzureApp",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365Mailbox");
            var parameters = "($mailboxIds: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365Mailbox",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365Onedrive(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365Onedrive");
            var parameters = "($input: BackupO365OnedriveInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365Onedrive" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365Onedrive",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365SharepointDrive(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365SharepointDrive");
            var parameters = "($input: BackupO365SharepointDriveInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365SharepointDrive" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365SharepointDrive",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fields = (CreateOnDemandJobReply)this.Field;
                }
            }
            string document = Mutation.BackupO365SharepointList(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365SharepointList");
            var parameters = "($input: BackupO365SharePointListInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365SharepointList" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365SharepointList",
            };
            OperationVariableSet vars = new();
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
        // backupO365SharePointSite(input: BackupO365SharePointSiteInput!): CreateOnDemandJobReply!
        protected void InvokeMutationBackupO365SharePointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharePointSiteInput!"),
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
            string document = Mutation.BackupO365SharePointSite(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365SharePointSite");
            var parameters = "($input: BackupO365SharePointSiteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365SharePointSite" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365SharePointSite",
            };
            OperationVariableSet vars = new();
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
        // backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
        protected void InvokeMutationBackupO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365TeamInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.BackupO365Team(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.BackupO365Team");
            var parameters = "($input: BackupO365TeamInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationBackupO365Team" + parameters + "{" + document + "}",
                OperationName = "MutationBackupO365Team",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "BatchAsyncJobStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (CreateOnDemandJobReply)psObject.BaseObject;
                } else {
                    fields = (CreateOnDemandJobReply)this.Field;
                }
            }
            string document = Mutation.RestoreO365TeamsFiles(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365TeamsFiles");
            var parameters = "($input: RestoreO365TeamsFilesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365TeamsFiles" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365TeamsFiles",
            };
            OperationVariableSet vars = new();
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
        // restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365TeamsConversations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365TeamsConversationsInput!"),
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
            string document = Mutation.RestoreO365TeamsConversations(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365TeamsConversations");
            var parameters = "($input: RestoreO365TeamsConversationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365TeamsConversations" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365TeamsConversations",
            };
            OperationVariableSet vars = new();
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
        // restoreO365Snappable(input: RestoreO365SnappableInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365Snappable()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreO365SnappableInput!"),
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
            string document = Mutation.RestoreO365Snappable(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365Snappable");
            var parameters = "($input: RestoreO365SnappableInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365Snappable" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365Snappable",
            };
            OperationVariableSet vars = new();
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
        // refreshO365Org(orgId: UUID!): CreateOnDemandJobReply!
        protected void InvokeMutationRefreshO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
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
            string document = Mutation.RefreshO365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RefreshO365Org");
            var parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRefreshO365Org" + parameters + "{" + document + "}",
                OperationName = "MutationRefreshO365Org",
            };
            OperationVariableSet vars = new();
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
        // deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
        protected void InvokeMutationDeleteO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
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
            string document = Mutation.DeleteO365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteO365Org");
            var parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteO365Org" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteO365Org",
            };
            OperationVariableSet vars = new();
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
        // restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
        protected void InvokeMutationRestoreO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("restoreConfig", "RestoreO365MailboxInput!"),
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
            string document = Mutation.RestoreO365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.RestoreO365Mailbox");
            var parameters = "($restoreConfig: RestoreO365MailboxInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationRestoreO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "MutationRestoreO365Mailbox",
            };
            OperationVariableSet vars = new();
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
        // exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
        protected void InvokeMutationExportO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("exportConfig", "ExportO365MailboxInput!"),
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
            string document = Mutation.ExportO365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExportO365Mailbox");
            var parameters = "($exportConfig: ExportO365MailboxInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExportO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "MutationExportO365Mailbox",
            };
            OperationVariableSet vars = new();
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.SetO365ServiceAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.SetO365ServiceAccount");
            var parameters = "($username: String!,$appPassword: String!,$orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationSetO365ServiceAccount" + parameters + "{" + document + "}",
                OperationName = "MutationSetO365ServiceAccount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.EnableO365SharePoint(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.EnableO365SharePoint");
            var parameters = "($input: EnableO365SharePointInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationEnableO365SharePoint" + parameters + "{" + document + "}",
                OperationName = "MutationEnableO365SharePoint",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.EnableO365Teams(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.EnableO365Teams");
            var parameters = "($exocomputeClusterId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationEnableO365Teams" + parameters + "{" + document + "}",
                OperationName = "MutationEnableO365Teams",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.DeleteO365ServiceAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteO365ServiceAccount");
            var parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteO365ServiceAccount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteO365ServiceAccount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "RequestStatus", this._logger, GetMetricTags());
            WriteObject(result, true);
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
                if (this.Field is PSObject psObject) {
                    fields = (UpdateO365OrgCustomNameReply)psObject.BaseObject;
                } else {
                    fields = (UpdateO365OrgCustomNameReply)this.Field;
                }
            }
            string document = Mutation.UpdateO365OrgCustomName(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateO365OrgCustomName");
            var parameters = "($input: UpdateO365OrgCustomNameInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateO365OrgCustomName" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateO365OrgCustomName",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "UpdateO365OrgCustomNameReply", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscMutateO365
}