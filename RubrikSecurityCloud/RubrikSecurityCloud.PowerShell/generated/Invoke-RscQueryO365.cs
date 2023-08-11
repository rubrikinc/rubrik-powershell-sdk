// Invoke-RscQueryO365.cs
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
        "RscQueryO365",
        DefaultParameterSetName = "Org")
    ]
    public class Invoke_RscQueryO365 : RscPSCmdlet
    {
        
        /// <summary>
        /// Org parameter set
        ///
        /// [GraphQL: o365Org]
        /// </summary>
        [Parameter(
            ParameterSetName = "Org",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the O365Org.
[GraphQL: o365Org]",
            Position = 0
        )]
        public SwitchParameter Org { get; set; }

        
        /// <summary>
        /// OrgAtSnappableLevel parameter set
        ///
        /// [GraphQL: o365OrgAtSnappableLevel]
        /// </summary>
        [Parameter(
            ParameterSetName = "OrgAtSnappableLevel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the O365Org at snappable level, given the snappable type.
[GraphQL: o365OrgAtSnappableLevel]",
            Position = 0
        )]
        public SwitchParameter OrgAtSnappableLevel { get; set; }

        
        /// <summary>
        /// AllAdGroups parameter set
        ///
        /// [GraphQL: allO365AdGroups]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllAdGroups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All AD Groups belonging to the O365 organization.
[GraphQL: allO365AdGroups]",
            Position = 0
        )]
        public SwitchParameter AllAdGroups { get; set; }

        
        /// <summary>
        /// User parameter set
        ///
        /// [GraphQL: o365User]
        /// </summary>
        [Parameter(
            ParameterSetName = "User",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the O365 user corresponding to the ID.
[GraphQL: o365User]",
            Position = 0
        )]
        public SwitchParameter User { get; set; }

        
        /// <summary>
        /// Mailbox parameter set
        ///
        /// [GraphQL: o365Mailbox]
        /// </summary>
        [Parameter(
            ParameterSetName = "Mailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the Exchange mailbox corresponding to the snappable ID.
[GraphQL: o365Mailbox]",
            Position = 0
        )]
        public SwitchParameter Mailbox { get; set; }

        
        /// <summary>
        /// Groups parameter set
        ///
        /// [GraphQL: o365Groups]
        /// </summary>
        [Parameter(
            ParameterSetName = "Groups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of O365 Groups in the O365Org.
[GraphQL: o365Groups]",
            Position = 0
        )]
        public SwitchParameter Groups { get; set; }

        
        /// <summary>
        /// Mailboxes parameter set
        ///
        /// [GraphQL: o365Mailboxes]
        /// </summary>
        [Parameter(
            ParameterSetName = "Mailboxes",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Mailboxes in the O365Org.
[GraphQL: o365Mailboxes]",
            Position = 0
        )]
        public SwitchParameter Mailboxes { get; set; }

        
        /// <summary>
        /// Onedrive parameter set
        ///
        /// [GraphQL: o365Onedrive]
        /// </summary>
        [Parameter(
            ParameterSetName = "Onedrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the OneDrive corresponding to the snappable ID.
[GraphQL: o365Onedrive]",
            Position = 0
        )]
        public SwitchParameter Onedrive { get; set; }

        
        /// <summary>
        /// Onedrives parameter set
        ///
        /// [GraphQL: o365Onedrives]
        /// </summary>
        [Parameter(
            ParameterSetName = "Onedrives",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Onedrives in the O365Org.
[GraphQL: o365Onedrives]",
            Position = 0
        )]
        public SwitchParameter Onedrives { get; set; }

        
        /// <summary>
        /// Site parameter set
        ///
        /// [GraphQL: o365Site]
        /// </summary>
        [Parameter(
            ParameterSetName = "Site",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the SharePoint site corresponding to the snappable ID.
[GraphQL: o365Site]",
            Position = 0
        )]
        public SwitchParameter Site { get; set; }

        
        /// <summary>
        /// Sites parameter set
        ///
        /// [GraphQL: o365Sites]
        /// </summary>
        [Parameter(
            ParameterSetName = "Sites",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of sites in the O365Org.
[GraphQL: o365Sites]",
            Position = 0
        )]
        public SwitchParameter Sites { get; set; }

        
        /// <summary>
        /// SharepointDrive parameter set
        ///
        /// [GraphQL: o365SharepointDrive]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointDrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the SharePoint drive corresponding to the snappable ID.
[GraphQL: o365SharepointDrive]",
            Position = 0
        )]
        public SwitchParameter SharepointDrive { get; set; }

        
        /// <summary>
        /// SharepointDrives parameter set
        ///
        /// [GraphQL: o365SharepointDrives]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointDrives",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of sharepoint drives (document libraries) in the O365Org.
[GraphQL: o365SharepointDrives]",
            Position = 0
        )]
        public SwitchParameter SharepointDrives { get; set; }

        
        /// <summary>
        /// SharepointList parameter set
        ///
        /// [GraphQL: o365SharepointList]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the SharePoint list corresponding to the snappable ID.
[GraphQL: o365SharepointList]",
            Position = 0
        )]
        public SwitchParameter SharepointList { get; set; }

        
        /// <summary>
        /// SharepointLists parameter set
        ///
        /// [GraphQL: o365SharepointLists]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointLists",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of sharepoint lists in the O365Org.
[GraphQL: o365SharepointLists]",
            Position = 0
        )]
        public SwitchParameter SharepointLists { get; set; }

        
        /// <summary>
        /// SharepointSite parameter set
        ///
        /// [GraphQL: o365SharepointSite]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointSite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the SharePoint site corresponding to the site ID.
[GraphQL: o365SharepointSite]",
            Position = 0
        )]
        public SwitchParameter SharepointSite { get; set; }

        
        /// <summary>
        /// SharepointSites parameter set
        ///
        /// [GraphQL: o365SharepointSites]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointSites",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of sharepoint sites in the O365Org.
[GraphQL: o365SharepointSites]",
            Position = 0
        )]
        public SwitchParameter SharepointSites { get; set; }

        
        /// <summary>
        /// Team parameter set
        ///
        /// [GraphQL: o365Team]
        /// </summary>
        [Parameter(
            ParameterSetName = "Team",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the team corresponding to the snappable ID.
[GraphQL: o365Team]",
            Position = 0
        )]
        public SwitchParameter Team { get; set; }

        
        /// <summary>
        /// Teams parameter set
        ///
        /// [GraphQL: o365Teams]
        /// </summary>
        [Parameter(
            ParameterSetName = "Teams",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of O365 Teams in the O365Org.
[GraphQL: o365Teams]",
            Position = 0
        )]
        public SwitchParameter Teams { get; set; }

        
        /// <summary>
        /// TeamChannels parameter set
        ///
        /// [GraphQL: o365TeamChannels]
        /// </summary>
        [Parameter(
            ParameterSetName = "TeamChannels",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Channels for the O365Team.
[GraphQL: o365TeamChannels]",
            Position = 0
        )]
        public SwitchParameter TeamChannels { get; set; }

        
        /// <summary>
        /// TeamConversationsFolderID parameter set
        ///
        /// [GraphQL: o365TeamConversationsFolderID]
        /// </summary>
        [Parameter(
            ParameterSetName = "TeamConversationsFolderID",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"ID for the conversations folder in the Team's Group Mailbox.
[GraphQL: o365TeamConversationsFolderID]",
            Position = 0
        )]
        public SwitchParameter TeamConversationsFolderID { get; set; }

        
        /// <summary>
        /// TeamPostedBy parameter set
        ///
        /// [GraphQL: o365TeamPostedBy]
        /// </summary>
        [Parameter(
            ParameterSetName = "TeamPostedBy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Users who have posted in a team.
[GraphQL: o365TeamPostedBy]",
            Position = 0
        )]
        public SwitchParameter TeamPostedBy { get; set; }

        
        /// <summary>
        /// Calendar parameter set
        ///
        /// [GraphQL: o365Calendar]
        /// </summary>
        [Parameter(
            ParameterSetName = "Calendar",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the Exchange calendar pertaining to the snappable ID.
[GraphQL: o365Calendar]",
            Position = 0
        )]
        public SwitchParameter Calendar { get; set; }

        
        /// <summary>
        /// Orgs parameter set
        ///
        /// [GraphQL: o365Orgs]
        /// </summary>
        [Parameter(
            ParameterSetName = "Orgs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All O365 orgs for the account.
[GraphQL: o365Orgs]",
            Position = 0
        )]
        public SwitchParameter Orgs { get; set; }

        
        /// <summary>
        /// SharepointObjectList parameter set
        ///
        /// [GraphQL: o365SharepointObjectList]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointObjectList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the sharepoint objects after filtering on the object types and includeEntireHierarchy.
[GraphQL: o365SharepointObjectList]",
            Position = 0
        )]
        public SwitchParameter SharepointObjectList { get; set; }

        
        /// <summary>
        /// SharepointObjects parameter set
        ///
        /// [GraphQL: o365SharepointObjects]
        /// </summary>
        [Parameter(
            ParameterSetName = "SharepointObjects",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365SharepointObjects]",
            Position = 0
        )]
        public SwitchParameter SharepointObjects { get; set; }

        
        /// <summary>
        /// UserObjects parameter set
        ///
        /// [GraphQL: o365UserObjects]
        /// </summary>
        [Parameter(
            ParameterSetName = "UserObjects",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Name, id, object type, and mail address of user descendant object.
[GraphQL: o365UserObjects]",
            Position = 0
        )]
        public SwitchParameter UserObjects { get; set; }

        
        /// <summary>
        /// OrgSummaries parameter set
        ///
        /// [GraphQL: o365OrgSummaries]
        /// </summary>
        [Parameter(
            ParameterSetName = "OrgSummaries",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365OrgSummaries]",
            Position = 0
        )]
        public SwitchParameter OrgSummaries { get; set; }

        
        /// <summary>
        /// ObjectAncestors parameter set
        ///
        /// [GraphQL: o365ObjectAncestors]
        /// </summary>
        [Parameter(
            ParameterSetName = "ObjectAncestors",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365ObjectAncestors]",
            Position = 0
        )]
        public SwitchParameter ObjectAncestors { get; set; }

        
        /// <summary>
        /// BrowseTeamConvChannels parameter set
        ///
        /// [GraphQL: browseO365TeamConvChannels]
        /// </summary>
        [Parameter(
            ParameterSetName = "BrowseTeamConvChannels",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Browse channels in a Teams conversations snapshot.
[GraphQL: browseO365TeamConvChannels]",
            Position = 0
        )]
        public SwitchParameter BrowseTeamConvChannels { get; set; }

        
        /// <summary>
        /// ServiceAccount parameter set
        ///
        /// [GraphQL: o365ServiceAccount]
        /// </summary>
        [Parameter(
            ParameterSetName = "ServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the service account for the given org.
[GraphQL: o365ServiceAccount]",
            Position = 0
        )]
        public SwitchParameter ServiceAccount { get; set; }

        
        /// <summary>
        /// AllOrgStatuses parameter set
        ///
        /// [GraphQL: allO365OrgStatuses]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllOrgStatuses",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the status of each org in the account.
[GraphQL: allO365OrgStatuses]",
            Position = 0
        )]
        public SwitchParameter AllOrgStatuses { get; set; }

        
        /// <summary>
        /// License parameter set
        ///
        /// [GraphQL: o365License]
        /// </summary>
        [Parameter(
            ParameterSetName = "License",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Retrieve o365 licence details.
[GraphQL: o365License]",
            Position = 0
        )]
        public SwitchParameter License { get; set; }

        
        /// <summary>
        /// ListApps parameter set
        ///
        /// [GraphQL: listO365Apps]
        /// </summary>
        [Parameter(
            ParameterSetName = "ListApps",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Lists the O365 apps.
[GraphQL: listO365Apps]",
            Position = 0
        )]
        public SwitchParameter ListApps { get; set; }

        
        /// <summary>
        /// AllSubscriptionsAppTypeCounts parameter set
        ///
        /// [GraphQL: allO365SubscriptionsAppTypeCounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "AllSubscriptionsAppTypeCounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the total number of apps of each type, for each O365 org.
[GraphQL: allO365SubscriptionsAppTypeCounts]",
            Position = 0
        )]
        public SwitchParameter AllSubscriptionsAppTypeCounts { get; set; }

        
        /// <summary>
        /// StorageStats parameter set
        ///
        /// [GraphQL: o365StorageStats]
        /// </summary>
        [Parameter(
            ParameterSetName = "StorageStats",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the storage stats of an O365 org.
[GraphQL: o365StorageStats]",
            Position = 0
        )]
        public SwitchParameter StorageStats { get; set; }

        
        /// <summary>
        /// ServiceStatus parameter set
        ///
        /// [GraphQL: o365ServiceStatus]
        /// </summary>
        [Parameter(
            ParameterSetName = "ServiceStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the service status of the O365 service running on MSFT server.
[GraphQL: o365ServiceStatus]",
            Position = 0
        )]
        public SwitchParameter ServiceStatus { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Org":
                        this.ProcessRecord_Org();
                        break;
                    case "OrgAtSnappableLevel":
                        this.ProcessRecord_OrgAtSnappableLevel();
                        break;
                    case "AllAdGroups":
                        this.ProcessRecord_AllAdGroups();
                        break;
                    case "User":
                        this.ProcessRecord_User();
                        break;
                    case "Mailbox":
                        this.ProcessRecord_Mailbox();
                        break;
                    case "Groups":
                        this.ProcessRecord_Groups();
                        break;
                    case "Mailboxes":
                        this.ProcessRecord_Mailboxes();
                        break;
                    case "Onedrive":
                        this.ProcessRecord_Onedrive();
                        break;
                    case "Onedrives":
                        this.ProcessRecord_Onedrives();
                        break;
                    case "Site":
                        this.ProcessRecord_Site();
                        break;
                    case "Sites":
                        this.ProcessRecord_Sites();
                        break;
                    case "SharepointDrive":
                        this.ProcessRecord_SharepointDrive();
                        break;
                    case "SharepointDrives":
                        this.ProcessRecord_SharepointDrives();
                        break;
                    case "SharepointList":
                        this.ProcessRecord_SharepointList();
                        break;
                    case "SharepointLists":
                        this.ProcessRecord_SharepointLists();
                        break;
                    case "SharepointSite":
                        this.ProcessRecord_SharepointSite();
                        break;
                    case "SharepointSites":
                        this.ProcessRecord_SharepointSites();
                        break;
                    case "Team":
                        this.ProcessRecord_Team();
                        break;
                    case "Teams":
                        this.ProcessRecord_Teams();
                        break;
                    case "TeamChannels":
                        this.ProcessRecord_TeamChannels();
                        break;
                    case "TeamConversationsFolderID":
                        this.ProcessRecord_TeamConversationsFolderID();
                        break;
                    case "TeamPostedBy":
                        this.ProcessRecord_TeamPostedBy();
                        break;
                    case "Calendar":
                        this.ProcessRecord_Calendar();
                        break;
                    case "Orgs":
                        this.ProcessRecord_Orgs();
                        break;
                    case "SharepointObjectList":
                        this.ProcessRecord_SharepointObjectList();
                        break;
                    case "SharepointObjects":
                        this.ProcessRecord_SharepointObjects();
                        break;
                    case "UserObjects":
                        this.ProcessRecord_UserObjects();
                        break;
                    case "OrgSummaries":
                        this.ProcessRecord_OrgSummaries();
                        break;
                    case "ObjectAncestors":
                        this.ProcessRecord_ObjectAncestors();
                        break;
                    case "BrowseTeamConvChannels":
                        this.ProcessRecord_BrowseTeamConvChannels();
                        break;
                    case "ServiceAccount":
                        this.ProcessRecord_ServiceAccount();
                        break;
                    case "AllOrgStatuses":
                        this.ProcessRecord_AllOrgStatuses();
                        break;
                    case "License":
                        this.ProcessRecord_License();
                        break;
                    case "ListApps":
                        this.ProcessRecord_ListApps();
                        break;
                    case "AllSubscriptionsAppTypeCounts":
                        this.ProcessRecord_AllSubscriptionsAppTypeCounts();
                        break;
                    case "StorageStats":
                        this.ProcessRecord_StorageStats();
                        break;
                    case "ServiceStatus":
                        this.ProcessRecord_ServiceStatus();
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
        // o365Org.
        internal void ProcessRecord_Org()
        {
            this._logger.name += " -Org";
            // Invoke graphql operation o365Org
            InvokeQueryO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // o365OrgAtSnappableLevel.
        internal void ProcessRecord_OrgAtSnappableLevel()
        {
            this._logger.name += " -OrgAtSnappableLevel";
            // Invoke graphql operation o365OrgAtSnappableLevel
            InvokeQueryO365OrgAtSnappableLevel();
        }

        // This parameter set invokes a single graphql operation:
        // allO365AdGroups.
        internal void ProcessRecord_AllAdGroups()
        {
            this._logger.name += " -AllAdGroups";
            // Invoke graphql operation allO365AdGroups
            InvokeQueryAllO365AdGroups();
        }

        // This parameter set invokes a single graphql operation:
        // o365User.
        internal void ProcessRecord_User()
        {
            this._logger.name += " -User";
            // Invoke graphql operation o365User
            InvokeQueryO365User();
        }

        // This parameter set invokes a single graphql operation:
        // o365Mailbox.
        internal void ProcessRecord_Mailbox()
        {
            this._logger.name += " -Mailbox";
            // Invoke graphql operation o365Mailbox
            InvokeQueryO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // o365Groups.
        internal void ProcessRecord_Groups()
        {
            this._logger.name += " -Groups";
            // Invoke graphql operation o365Groups
            InvokeQueryO365Groups();
        }

        // This parameter set invokes a single graphql operation:
        // o365Mailboxes.
        internal void ProcessRecord_Mailboxes()
        {
            this._logger.name += " -Mailboxes";
            // Invoke graphql operation o365Mailboxes
            InvokeQueryO365Mailboxes();
        }

        // This parameter set invokes a single graphql operation:
        // o365Onedrive.
        internal void ProcessRecord_Onedrive()
        {
            this._logger.name += " -Onedrive";
            // Invoke graphql operation o365Onedrive
            InvokeQueryO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // o365Onedrives.
        internal void ProcessRecord_Onedrives()
        {
            this._logger.name += " -Onedrives";
            // Invoke graphql operation o365Onedrives
            InvokeQueryO365Onedrives();
        }

        // This parameter set invokes a single graphql operation:
        // o365Site.
        internal void ProcessRecord_Site()
        {
            this._logger.name += " -Site";
            // Invoke graphql operation o365Site
            InvokeQueryO365Site();
        }

        // This parameter set invokes a single graphql operation:
        // o365Sites.
        internal void ProcessRecord_Sites()
        {
            this._logger.name += " -Sites";
            // Invoke graphql operation o365Sites
            InvokeQueryO365Sites();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointDrive.
        internal void ProcessRecord_SharepointDrive()
        {
            this._logger.name += " -SharepointDrive";
            // Invoke graphql operation o365SharepointDrive
            InvokeQueryO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointDrives.
        internal void ProcessRecord_SharepointDrives()
        {
            this._logger.name += " -SharepointDrives";
            // Invoke graphql operation o365SharepointDrives
            InvokeQueryO365SharepointDrives();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointList.
        internal void ProcessRecord_SharepointList()
        {
            this._logger.name += " -SharepointList";
            // Invoke graphql operation o365SharepointList
            InvokeQueryO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointLists.
        internal void ProcessRecord_SharepointLists()
        {
            this._logger.name += " -SharepointLists";
            // Invoke graphql operation o365SharepointLists
            InvokeQueryO365SharepointLists();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointSite.
        internal void ProcessRecord_SharepointSite()
        {
            this._logger.name += " -SharepointSite";
            // Invoke graphql operation o365SharepointSite
            InvokeQueryO365SharepointSite();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointSites.
        internal void ProcessRecord_SharepointSites()
        {
            this._logger.name += " -SharepointSites";
            // Invoke graphql operation o365SharepointSites
            InvokeQueryO365SharepointSites();
        }

        // This parameter set invokes a single graphql operation:
        // o365Team.
        internal void ProcessRecord_Team()
        {
            this._logger.name += " -Team";
            // Invoke graphql operation o365Team
            InvokeQueryO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // o365Teams.
        internal void ProcessRecord_Teams()
        {
            this._logger.name += " -Teams";
            // Invoke graphql operation o365Teams
            InvokeQueryO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamChannels.
        internal void ProcessRecord_TeamChannels()
        {
            this._logger.name += " -TeamChannels";
            // Invoke graphql operation o365TeamChannels
            InvokeQueryO365TeamChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamConversationsFolderID.
        internal void ProcessRecord_TeamConversationsFolderID()
        {
            this._logger.name += " -TeamConversationsFolderID";
            // Invoke graphql operation o365TeamConversationsFolderID
            InvokeQueryO365TeamConversationsFolderId();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamPostedBy.
        internal void ProcessRecord_TeamPostedBy()
        {
            this._logger.name += " -TeamPostedBy";
            // Invoke graphql operation o365TeamPostedBy
            InvokeQueryO365TeamPostedBy();
        }

        // This parameter set invokes a single graphql operation:
        // o365Calendar.
        internal void ProcessRecord_Calendar()
        {
            this._logger.name += " -Calendar";
            // Invoke graphql operation o365Calendar
            InvokeQueryO365Calendar();
        }

        // This parameter set invokes a single graphql operation:
        // o365Orgs.
        internal void ProcessRecord_Orgs()
        {
            this._logger.name += " -Orgs";
            // Invoke graphql operation o365Orgs
            InvokeQueryO365Orgs();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointObjectList.
        internal void ProcessRecord_SharepointObjectList()
        {
            this._logger.name += " -SharepointObjectList";
            // Invoke graphql operation o365SharepointObjectList
            InvokeQueryO365SharepointObjectList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointObjects.
        internal void ProcessRecord_SharepointObjects()
        {
            this._logger.name += " -SharepointObjects";
            // Invoke graphql operation o365SharepointObjects
            InvokeQueryO365SharepointObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365UserObjects.
        internal void ProcessRecord_UserObjects()
        {
            this._logger.name += " -UserObjects";
            // Invoke graphql operation o365UserObjects
            InvokeQueryO365UserObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365OrgSummaries.
        internal void ProcessRecord_OrgSummaries()
        {
            this._logger.name += " -OrgSummaries";
            // Invoke graphql operation o365OrgSummaries
            InvokeQueryO365OrgSummaries();
        }

        // This parameter set invokes a single graphql operation:
        // o365ObjectAncestors.
        internal void ProcessRecord_ObjectAncestors()
        {
            this._logger.name += " -ObjectAncestors";
            // Invoke graphql operation o365ObjectAncestors
            InvokeQueryO365ObjectAncestors();
        }

        // This parameter set invokes a single graphql operation:
        // browseO365TeamConvChannels.
        internal void ProcessRecord_BrowseTeamConvChannels()
        {
            this._logger.name += " -BrowseTeamConvChannels";
            // Invoke graphql operation browseO365TeamConvChannels
            InvokeQueryBrowseO365TeamConvChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceAccount.
        internal void ProcessRecord_ServiceAccount()
        {
            this._logger.name += " -ServiceAccount";
            // Invoke graphql operation o365ServiceAccount
            InvokeQueryO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allO365OrgStatuses.
        internal void ProcessRecord_AllOrgStatuses()
        {
            this._logger.name += " -AllOrgStatuses";
            // Invoke graphql operation allO365OrgStatuses
            InvokeQueryAllO365OrgStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // o365License.
        internal void ProcessRecord_License()
        {
            this._logger.name += " -License";
            // Invoke graphql operation o365License
            InvokeQueryO365License();
        }

        // This parameter set invokes a single graphql operation:
        // listO365Apps.
        internal void ProcessRecord_ListApps()
        {
            this._logger.name += " -ListApps";
            // Invoke graphql operation listO365Apps
            InvokeQueryListO365Apps();
        }

        // This parameter set invokes a single graphql operation:
        // allO365SubscriptionsAppTypeCounts.
        internal void ProcessRecord_AllSubscriptionsAppTypeCounts()
        {
            this._logger.name += " -AllSubscriptionsAppTypeCounts";
            // Invoke graphql operation allO365SubscriptionsAppTypeCounts
            InvokeQueryAllO365SubscriptionsAppTypeCounts();
        }

        // This parameter set invokes a single graphql operation:
        // o365StorageStats.
        internal void ProcessRecord_StorageStats()
        {
            this._logger.name += " -StorageStats";
            // Invoke graphql operation o365StorageStats
            InvokeQueryO365StorageStats();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceStatus.
        internal void ProcessRecord_ServiceStatus()
        {
            this._logger.name += " -ServiceStatus";
            // Invoke graphql operation o365ServiceStatus
            InvokeQueryO365ServiceStatus();
        }


        // Invoke GraphQL Query:
        // o365Org(fid: UUID!): O365Org!
        internal void InvokeQueryO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            O365Org? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Org)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Org)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Org(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Org",
                "($fid: UUID!)",
                fieldSpecDoc,
                "O365Org"
            );
        }

        // Invoke GraphQL Query:
        // o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!): O365Org!
        internal void InvokeQueryO365OrgAtSnappableLevel()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("snappableType", "SnappableType!"),
            };
            O365Org? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Org)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Org)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365OrgAtSnappableLevel(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365OrgAtSnappableLevel",
                "($fid: UUID!,$snappableType: SnappableType!)",
                fieldSpecDoc,
                "O365Org"
            );
        }

        // Invoke GraphQL Query:
        // allO365AdGroups(orgId: UUID!, adGroupSearchFilter: String!): [AdGroup!]!
        internal void InvokeQueryAllO365AdGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("adGroupSearchFilter", "String!"),
            };
            List<AdGroup>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<AdGroup>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<AdGroup>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllO365AdGroups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllO365AdGroups",
                "($orgId: UUID!,$adGroupSearchFilter: String!)",
                fieldSpecDoc,
                "List<AdGroup>"
            );
        }

        // Invoke GraphQL Query:
        // o365User(fid: UUID!): O365User!
        internal void InvokeQueryO365User()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            O365User? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365User)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365User)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365User(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365User",
                "($fid: UUID!)",
                fieldSpecDoc,
                "O365User"
            );
        }

        // Invoke GraphQL Query:
        // o365Mailbox(snappableFid: UUID!): O365Mailbox!
        internal void InvokeQueryO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Mailbox? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Mailbox)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Mailbox)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Mailbox(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Mailbox",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "O365Mailbox"
            );
        }

        // Invoke GraphQL Query:
        // o365Groups(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //     snappableType: SnappableType!
        //   ): O365GroupConnection!
        internal void InvokeQueryO365Groups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
                Tuple.Create("snappableType", "SnappableType!"),
            };
            O365GroupConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365GroupConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365GroupConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Groups(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Groups",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!,$snappableType: SnappableType!)",
                fieldSpecDoc,
                "O365GroupConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365Mailboxes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365MailboxConnection!
        internal void InvokeQueryO365Mailboxes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            O365MailboxConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365MailboxConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365MailboxConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Mailboxes(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Mailboxes",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                fieldSpecDoc,
                "O365MailboxConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365Onedrive(snappableFid: UUID!): O365Onedrive!
        internal void InvokeQueryO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Onedrive? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Onedrive)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Onedrive)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Onedrive(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Onedrive",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "O365Onedrive"
            );
        }

        // Invoke GraphQL Query:
        // o365Onedrives(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365OnedriveConnection!
        internal void InvokeQueryO365Onedrives()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            O365OnedriveConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365OnedriveConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365OnedriveConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Onedrives(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Onedrives",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                fieldSpecDoc,
                "O365OnedriveConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365Site(snappableFid: UUID!): O365Site!
        internal void InvokeQueryO365Site()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Site? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Site)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Site)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Site(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Site",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "O365Site"
            );
        }

        // Invoke GraphQL Query:
        // o365Sites(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //     excludeChildSites: Boolean
        //   ): O365SiteConnection!
        internal void InvokeQueryO365Sites()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
                Tuple.Create("excludeChildSites", "Boolean"),
            };
            O365SiteConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SiteConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SiteConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Sites(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Sites",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!,$excludeChildSites: Boolean)",
                fieldSpecDoc,
                "O365SiteConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointDrive(snappableFid: UUID!): O365SharepointDrive!
        internal void InvokeQueryO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365SharepointDrive? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SharepointDrive)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SharepointDrive)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointDrive(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointDrive",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "O365SharepointDrive"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointDrives(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365SharepointDriveConnection!
        internal void InvokeQueryO365SharepointDrives()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            O365SharepointDriveConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SharepointDriveConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SharepointDriveConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointDrives(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointDrives",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                fieldSpecDoc,
                "O365SharepointDriveConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointList(snappableFid: UUID!): O365SharepointList!
        internal void InvokeQueryO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365SharepointList? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SharepointList)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SharepointList)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointList(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointList",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "O365SharepointList"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointLists(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365SharepointListConnection!
        internal void InvokeQueryO365SharepointLists()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            O365SharepointListConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SharepointListConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SharepointListConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointLists(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointLists",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                fieldSpecDoc,
                "O365SharepointListConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointSite(siteFid: UUID!): O365Site!
        internal void InvokeQueryO365SharepointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("siteFid", "UUID!"),
            };
            O365Site? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Site)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Site)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointSite(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointSite",
                "($siteFid: UUID!)",
                fieldSpecDoc,
                "O365Site"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointSites(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365SiteConnection!
        internal void InvokeQueryO365SharepointSites()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            O365SiteConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SiteConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SiteConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointSites(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointSites",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                fieldSpecDoc,
                "O365SiteConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365Team(snappableFid: UUID!): O365Teams!
        internal void InvokeQueryO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Teams? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Teams)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Teams)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Team(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Team",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "O365Teams"
            );
        }

        // Invoke GraphQL Query:
        // o365Teams(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365TeamsConnection!
        internal void InvokeQueryO365Teams()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            O365TeamsConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365TeamsConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365TeamsConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Teams(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Teams",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                fieldSpecDoc,
                "O365TeamsConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365TeamChannels(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     excludeArchived: Boolean!
        //     channelMembershipTypeFilter: ChannelMembershipType!
        //     nameFilter: String
        //   ): O365TeamsChannelConnection!
        internal void InvokeQueryO365TeamChannels()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("excludeArchived", "Boolean!"),
                Tuple.Create("channelMembershipTypeFilter", "ChannelMembershipType!"),
                Tuple.Create("nameFilter", "String"),
            };
            O365TeamsChannelConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365TeamsChannelConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365TeamsChannelConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365TeamChannels(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365TeamChannels",
                "($first: Int,$after: String,$snappableFid: UUID!,$excludeArchived: Boolean!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)",
                fieldSpecDoc,
                "O365TeamsChannelConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365TeamConversationsFolderID(snappableFid: UUID!, snapshotFid: UUID!, o365OrgId: UUID!): String!
        internal void InvokeQueryO365TeamConversationsFolderId()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            System.String? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.String)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.String)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365TeamConversationsFolderId(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365TeamConversationsFolderId",
                "($snappableFid: UUID!,$snapshotFid: UUID!,$o365OrgId: UUID!)",
                fieldSpecDoc,
                "System.String"
            );
        }

        // Invoke GraphQL Query:
        // o365TeamPostedBy(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     o365OrgId: UUID!
        //     nameFilter: String
        //   ): O365TeamConversationsSenderConnection!
        internal void InvokeQueryO365TeamPostedBy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
                Tuple.Create("nameFilter", "String"),
            };
            O365TeamConversationsSenderConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365TeamConversationsSenderConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365TeamConversationsSenderConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365TeamPostedBy(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365TeamPostedBy",
                "($first: Int,$after: String,$snappableFid: UUID!,$o365OrgId: UUID!,$nameFilter: String)",
                fieldSpecDoc,
                "O365TeamConversationsSenderConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365Calendar(snappableFid: UUID!): O365Calendar!
        internal void InvokeQueryO365Calendar()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Calendar? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365Calendar)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365Calendar)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Calendar(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Calendar",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "O365Calendar"
            );
        }

        // Invoke GraphQL Query:
        // o365Orgs(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     workloadHierarchy: WorkloadLevelHierarchy
        //   ): O365OrgConnection!
        internal void InvokeQueryO365Orgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
            };
            O365OrgConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365OrgConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365OrgConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365Orgs(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365Orgs",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$workloadHierarchy: WorkloadLevelHierarchy)",
                fieldSpecDoc,
                "O365OrgConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointObjectList(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     objectTypeFilter: [String!]
        //     includeEntireHierarchy: Boolean!
        //     fid: UUID!
        //   ): O365SharepointObjectConnection!
        internal void InvokeQueryO365SharepointObjectList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("objectTypeFilter", "[String!]"),
                Tuple.Create("includeEntireHierarchy", "Boolean!"),
                Tuple.Create("fid", "UUID!"),
            };
            O365SharepointObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SharepointObjectConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SharepointObjectConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointObjectList(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointObjectList",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$objectTypeFilter: [String!],$includeEntireHierarchy: Boolean!,$fid: UUID!)",
                fieldSpecDoc,
                "O365SharepointObjectConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365SharepointObjects(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     fid: UUID!
        //   ): O365SharepointObjectConnection!
        internal void InvokeQueryO365SharepointObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("fid", "UUID!"),
            };
            O365SharepointObjectConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365SharepointObjectConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365SharepointObjectConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365SharepointObjects(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365SharepointObjects",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)",
                fieldSpecDoc,
                "O365SharepointObjectConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365UserObjects(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     fid: UUID!
        //   ): O365UserDescendantMetadataConnection!
        internal void InvokeQueryO365UserObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("fid", "UUID!"),
            };
            O365UserDescendantMetadataConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365UserDescendantMetadataConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365UserDescendantMetadataConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365UserObjects(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365UserObjects",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)",
                fieldSpecDoc,
                "O365UserDescendantMetadataConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse!
        internal void InvokeQueryO365OrgSummaries()
        {
            Tuple<string, string>[] argDefs = {
            };
            GetImplicitlyAuthorizedObjectSummariesResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetImplicitlyAuthorizedObjectSummariesResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetImplicitlyAuthorizedObjectSummariesResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365OrgSummaries(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365OrgSummaries",
                "",
                fieldSpecDoc,
                "GetImplicitlyAuthorizedObjectSummariesResponse"
            );
        }

        // Invoke GraphQL Query:
        // o365ObjectAncestors(snappableFid: UUID!): GetImplicitlyAuthorizedAncestorSummariesResponse!
        internal void InvokeQueryO365ObjectAncestors()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            GetImplicitlyAuthorizedAncestorSummariesResponse? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetImplicitlyAuthorizedAncestorSummariesResponse)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetImplicitlyAuthorizedAncestorSummariesResponse)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365ObjectAncestors(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365ObjectAncestors",
                "($snappableFid: UUID!)",
                fieldSpecDoc,
                "GetImplicitlyAuthorizedAncestorSummariesResponse"
            );
        }

        // Invoke GraphQL Query:
        // browseO365TeamConvChannels(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     snapshotFidOpt: UUID
        //     excludeArchived: Boolean!
        //     orgId: UUID!
        //     channelMembershipTypeFilter: ChannelMembershipType!
        //     nameFilter: String
        //   ): O365TeamConvChannelConnection!
        internal void InvokeQueryBrowseO365TeamConvChannels()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFidOpt", "UUID"),
                Tuple.Create("excludeArchived", "Boolean!"),
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("channelMembershipTypeFilter", "ChannelMembershipType!"),
                Tuple.Create("nameFilter", "String"),
            };
            O365TeamConvChannelConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365TeamConvChannelConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365TeamConvChannelConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.BrowseO365TeamConvChannels(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryBrowseO365TeamConvChannels",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFidOpt: UUID,$excludeArchived: Boolean!,$orgId: UUID!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)",
                fieldSpecDoc,
                "O365TeamConvChannelConnection"
            );
        }

        // Invoke GraphQL Query:
        // o365ServiceAccount(orgId: UUID!): O365ServiceAccountStatusResp!
        internal void InvokeQueryO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            O365ServiceAccountStatusResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365ServiceAccountStatusResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365ServiceAccountStatusResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365ServiceAccount(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365ServiceAccount",
                "($orgId: UUID!)",
                fieldSpecDoc,
                "O365ServiceAccountStatusResp"
            );
        }

        // Invoke GraphQL Query:
        // allO365OrgStatuses: [O365OrgInfo!]!
        internal void InvokeQueryAllO365OrgStatuses()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<O365OrgInfo>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<O365OrgInfo>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<O365OrgInfo>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllO365OrgStatuses(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllO365OrgStatuses",
                "",
                fieldSpecDoc,
                "List<O365OrgInfo>"
            );
        }

        // Invoke GraphQL Query:
        // o365License: O365License!
        internal void InvokeQueryO365License()
        {
            Tuple<string, string>[] argDefs = {
            };
            O365License? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365License)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365License)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365License(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365License",
                "",
                fieldSpecDoc,
                "O365License"
            );
        }

        // Invoke GraphQL Query:
        // listO365Apps(
        //     first: Int
        //     after: String
        //     o365AppFilters: [AppFilter!]!
        //     o365AppSortByParam: AppSortByParam
        //   ): O365AppConnection!
        internal void InvokeQueryListO365Apps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("o365AppFilters", "[AppFilter!]!"),
                Tuple.Create("o365AppSortByParam", "AppSortByParam"),
            };
            O365AppConnection? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (O365AppConnection)psObject.BaseObject;
                } else {
                    fieldSpecObj = (O365AppConnection)this.Field;
                }
            }
            string fieldSpecDoc = Query.ListO365Apps(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryListO365Apps",
                "($first: Int,$after: String,$o365AppFilters: [AppFilter!]!,$o365AppSortByParam: AppSortByParam)",
                fieldSpecDoc,
                "O365AppConnection"
            );
        }

        // Invoke GraphQL Query:
        // allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]!
        internal void InvokeQueryAllO365SubscriptionsAppTypeCounts()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<O365SubscriptionAppTypeCounts>? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (List<O365SubscriptionAppTypeCounts>)psObject.BaseObject;
                } else {
                    fieldSpecObj = (List<O365SubscriptionAppTypeCounts>)this.Field;
                }
            }
            string fieldSpecDoc = Query.AllO365SubscriptionsAppTypeCounts(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryAllO365SubscriptionsAppTypeCounts",
                "",
                fieldSpecDoc,
                "List<O365SubscriptionAppTypeCounts>"
            );
        }

        // Invoke GraphQL Query:
        // o365StorageStats(orgID: UUID): GetO365StorageStatsResp!
        internal void InvokeQueryO365StorageStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            GetO365StorageStatsResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetO365StorageStatsResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetO365StorageStatsResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365StorageStats(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365StorageStats",
                "($orgID: UUID)",
                fieldSpecDoc,
                "GetO365StorageStatsResp"
            );
        }

        // Invoke GraphQL Query:
        // o365ServiceStatus(orgID: UUID): GetO365ServiceStatusResp!
        internal void InvokeQueryO365ServiceStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            GetO365ServiceStatusResp? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (GetO365ServiceStatusResp)psObject.BaseObject;
                } else {
                    fieldSpecObj = (GetO365ServiceStatusResp)this.Field;
                }
            }
            string fieldSpecDoc = Query.O365ServiceStatus(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "query",
                "QueryO365ServiceStatus",
                "($orgID: UUID)",
                fieldSpecDoc,
                "GetO365ServiceStatusResp"
            );
        }


    } // class Invoke_RscQueryO365
}