// New-RscQueryO365.cs
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
    /// Queries for the 'O365' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryO365 is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscQueryO365 -Org [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -OrgAtSnappableLevel [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -AllAdGroups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -User [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Mailbox [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Groups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Mailboxes [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Onedrive [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Onedrives [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Site [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Sites [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointDrive [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointDrives [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointLists [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointSite [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointSites [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Team [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Teams [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -TeamChannels [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -TeamConversationsFolderID [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -TeamPostedBy [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Calendar [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -Orgs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointObjectList [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -SharepointObjects [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -UserObjects [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -OrgSummaries [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -ObjectAncestors [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -BrowseTeamConvChannels [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -ServiceAccount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -AllOrgStatuses [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -License [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -ListApps [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -AllSubscriptionsAppTypeCounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -StorageStats [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryO365 -ServiceStatus [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryO365",
        DefaultParameterSetName = "Org")
    ]
    public class New_RscQueryO365 : RscGqlPSCmdlet
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
            base.ProcessRecord();
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
            // Create new graphql operation o365Org
            InitQueryO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // o365OrgAtSnappableLevel.
        internal void ProcessRecord_OrgAtSnappableLevel()
        {
            this._logger.name += " -OrgAtSnappableLevel";
            // Create new graphql operation o365OrgAtSnappableLevel
            InitQueryO365OrgAtSnappableLevel();
        }

        // This parameter set invokes a single graphql operation:
        // allO365AdGroups.
        internal void ProcessRecord_AllAdGroups()
        {
            this._logger.name += " -AllAdGroups";
            // Create new graphql operation allO365AdGroups
            InitQueryAllO365AdGroups();
        }

        // This parameter set invokes a single graphql operation:
        // o365User.
        internal void ProcessRecord_User()
        {
            this._logger.name += " -User";
            // Create new graphql operation o365User
            InitQueryO365User();
        }

        // This parameter set invokes a single graphql operation:
        // o365Mailbox.
        internal void ProcessRecord_Mailbox()
        {
            this._logger.name += " -Mailbox";
            // Create new graphql operation o365Mailbox
            InitQueryO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // o365Groups.
        internal void ProcessRecord_Groups()
        {
            this._logger.name += " -Groups";
            // Create new graphql operation o365Groups
            InitQueryO365Groups();
        }

        // This parameter set invokes a single graphql operation:
        // o365Mailboxes.
        internal void ProcessRecord_Mailboxes()
        {
            this._logger.name += " -Mailboxes";
            // Create new graphql operation o365Mailboxes
            InitQueryO365Mailboxes();
        }

        // This parameter set invokes a single graphql operation:
        // o365Onedrive.
        internal void ProcessRecord_Onedrive()
        {
            this._logger.name += " -Onedrive";
            // Create new graphql operation o365Onedrive
            InitQueryO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // o365Onedrives.
        internal void ProcessRecord_Onedrives()
        {
            this._logger.name += " -Onedrives";
            // Create new graphql operation o365Onedrives
            InitQueryO365Onedrives();
        }

        // This parameter set invokes a single graphql operation:
        // o365Site.
        internal void ProcessRecord_Site()
        {
            this._logger.name += " -Site";
            // Create new graphql operation o365Site
            InitQueryO365Site();
        }

        // This parameter set invokes a single graphql operation:
        // o365Sites.
        internal void ProcessRecord_Sites()
        {
            this._logger.name += " -Sites";
            // Create new graphql operation o365Sites
            InitQueryO365Sites();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointDrive.
        internal void ProcessRecord_SharepointDrive()
        {
            this._logger.name += " -SharepointDrive";
            // Create new graphql operation o365SharepointDrive
            InitQueryO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointDrives.
        internal void ProcessRecord_SharepointDrives()
        {
            this._logger.name += " -SharepointDrives";
            // Create new graphql operation o365SharepointDrives
            InitQueryO365SharepointDrives();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointList.
        internal void ProcessRecord_SharepointList()
        {
            this._logger.name += " -SharepointList";
            // Create new graphql operation o365SharepointList
            InitQueryO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointLists.
        internal void ProcessRecord_SharepointLists()
        {
            this._logger.name += " -SharepointLists";
            // Create new graphql operation o365SharepointLists
            InitQueryO365SharepointLists();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointSite.
        internal void ProcessRecord_SharepointSite()
        {
            this._logger.name += " -SharepointSite";
            // Create new graphql operation o365SharepointSite
            InitQueryO365SharepointSite();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointSites.
        internal void ProcessRecord_SharepointSites()
        {
            this._logger.name += " -SharepointSites";
            // Create new graphql operation o365SharepointSites
            InitQueryO365SharepointSites();
        }

        // This parameter set invokes a single graphql operation:
        // o365Team.
        internal void ProcessRecord_Team()
        {
            this._logger.name += " -Team";
            // Create new graphql operation o365Team
            InitQueryO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // o365Teams.
        internal void ProcessRecord_Teams()
        {
            this._logger.name += " -Teams";
            // Create new graphql operation o365Teams
            InitQueryO365Teams();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamChannels.
        internal void ProcessRecord_TeamChannels()
        {
            this._logger.name += " -TeamChannels";
            // Create new graphql operation o365TeamChannels
            InitQueryO365TeamChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamConversationsFolderID.
        internal void ProcessRecord_TeamConversationsFolderID()
        {
            this._logger.name += " -TeamConversationsFolderID";
            // Create new graphql operation o365TeamConversationsFolderID
            InitQueryO365TeamConversationsFolderId();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamPostedBy.
        internal void ProcessRecord_TeamPostedBy()
        {
            this._logger.name += " -TeamPostedBy";
            // Create new graphql operation o365TeamPostedBy
            InitQueryO365TeamPostedBy();
        }

        // This parameter set invokes a single graphql operation:
        // o365Calendar.
        internal void ProcessRecord_Calendar()
        {
            this._logger.name += " -Calendar";
            // Create new graphql operation o365Calendar
            InitQueryO365Calendar();
        }

        // This parameter set invokes a single graphql operation:
        // o365Orgs.
        internal void ProcessRecord_Orgs()
        {
            this._logger.name += " -Orgs";
            // Create new graphql operation o365Orgs
            InitQueryO365Orgs();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointObjectList.
        internal void ProcessRecord_SharepointObjectList()
        {
            this._logger.name += " -SharepointObjectList";
            // Create new graphql operation o365SharepointObjectList
            InitQueryO365SharepointObjectList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointObjects.
        internal void ProcessRecord_SharepointObjects()
        {
            this._logger.name += " -SharepointObjects";
            // Create new graphql operation o365SharepointObjects
            InitQueryO365SharepointObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365UserObjects.
        internal void ProcessRecord_UserObjects()
        {
            this._logger.name += " -UserObjects";
            // Create new graphql operation o365UserObjects
            InitQueryO365UserObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365OrgSummaries.
        internal void ProcessRecord_OrgSummaries()
        {
            this._logger.name += " -OrgSummaries";
            // Create new graphql operation o365OrgSummaries
            InitQueryO365OrgSummaries();
        }

        // This parameter set invokes a single graphql operation:
        // o365ObjectAncestors.
        internal void ProcessRecord_ObjectAncestors()
        {
            this._logger.name += " -ObjectAncestors";
            // Create new graphql operation o365ObjectAncestors
            InitQueryO365ObjectAncestors();
        }

        // This parameter set invokes a single graphql operation:
        // browseO365TeamConvChannels.
        internal void ProcessRecord_BrowseTeamConvChannels()
        {
            this._logger.name += " -BrowseTeamConvChannels";
            // Create new graphql operation browseO365TeamConvChannels
            InitQueryBrowseO365TeamConvChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceAccount.
        internal void ProcessRecord_ServiceAccount()
        {
            this._logger.name += " -ServiceAccount";
            // Create new graphql operation o365ServiceAccount
            InitQueryO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allO365OrgStatuses.
        internal void ProcessRecord_AllOrgStatuses()
        {
            this._logger.name += " -AllOrgStatuses";
            // Create new graphql operation allO365OrgStatuses
            InitQueryAllO365OrgStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // o365License.
        internal void ProcessRecord_License()
        {
            this._logger.name += " -License";
            // Create new graphql operation o365License
            InitQueryO365License();
        }

        // This parameter set invokes a single graphql operation:
        // listO365Apps.
        internal void ProcessRecord_ListApps()
        {
            this._logger.name += " -ListApps";
            // Create new graphql operation listO365Apps
            InitQueryListO365Apps();
        }

        // This parameter set invokes a single graphql operation:
        // allO365SubscriptionsAppTypeCounts.
        internal void ProcessRecord_AllSubscriptionsAppTypeCounts()
        {
            this._logger.name += " -AllSubscriptionsAppTypeCounts";
            // Create new graphql operation allO365SubscriptionsAppTypeCounts
            InitQueryAllO365SubscriptionsAppTypeCounts();
        }

        // This parameter set invokes a single graphql operation:
        // o365StorageStats.
        internal void ProcessRecord_StorageStats()
        {
            this._logger.name += " -StorageStats";
            // Create new graphql operation o365StorageStats
            InitQueryO365StorageStats();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceStatus.
        internal void ProcessRecord_ServiceStatus()
        {
            this._logger.name += " -ServiceStatus";
            // Create new graphql operation o365ServiceStatus
            InitQueryO365ServiceStatus();
        }


        // Create new GraphQL Query:
        // o365Org(fid: UUID!): O365Org!
        internal void InitQueryO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Org",
                "($fid: UUID!)",
                "O365Org",
                Query.O365Org_ObjectFieldSpec,
                Query.O365OrgFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!): O365Org!
        internal void InitQueryO365OrgAtSnappableLevel()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("snappableType", "SnappableType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365OrgAtSnappableLevel",
                "($fid: UUID!,$snappableType: SnappableType!)",
                "O365Org",
                Query.O365OrgAtSnappableLevel_ObjectFieldSpec,
                Query.O365OrgAtSnappableLevelFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>
# REQUIRED
$inputs.Var.snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allO365AdGroups(orgId: UUID!, adGroupSearchFilter: String!): [AdGroup!]!
        internal void InitQueryAllO365AdGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("adGroupSearchFilter", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllO365AdGroups",
                "($orgId: UUID!,$adGroupSearchFilter: String!)",
                "List<AdGroup>",
                Query.AllO365AdGroups_ObjectFieldSpec,
                Query.AllO365AdGroupsFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.adGroupSearchFilter = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365User(fid: UUID!): O365User!
        internal void InitQueryO365User()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365User",
                "($fid: UUID!)",
                "O365User",
                Query.O365User_ObjectFieldSpec,
                Query.O365UserFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Mailbox(snappableFid: UUID!): O365Mailbox!
        internal void InitQueryO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Mailbox",
                "($snappableFid: UUID!)",
                "O365Mailbox",
                Query.O365Mailbox_ObjectFieldSpec,
                Query.O365MailboxFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Groups(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //     snappableType: SnappableType!
        //   ): O365GroupConnection!
        internal void InitQueryO365Groups()
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
            Initialize(
                argDefs,
                "query",
                "QueryO365Groups",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!,$snappableType: SnappableType!)",
                "O365GroupConnection",
                Query.O365Groups_ObjectFieldSpec,
                Query.O365GroupsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
# REQUIRED
$inputs.Var.snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // o365Mailboxes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365MailboxConnection!
        internal void InitQueryO365Mailboxes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Mailboxes",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                "O365MailboxConnection",
                Query.O365Mailboxes_ObjectFieldSpec,
                Query.O365MailboxesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Onedrive(snappableFid: UUID!): O365Onedrive!
        internal void InitQueryO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Onedrive",
                "($snappableFid: UUID!)",
                "O365Onedrive",
                Query.O365Onedrive_ObjectFieldSpec,
                Query.O365OnedriveFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Onedrives(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365OnedriveConnection!
        internal void InitQueryO365Onedrives()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Onedrives",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                "O365OnedriveConnection",
                Query.O365Onedrives_ObjectFieldSpec,
                Query.O365OnedrivesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Site(snappableFid: UUID!): O365Site!
        internal void InitQueryO365Site()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Site",
                "($snappableFid: UUID!)",
                "O365Site",
                Query.O365Site_ObjectFieldSpec,
                Query.O365SiteFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Sites(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //     excludeChildSites: Boolean
        //   ): O365SiteConnection!
        internal void InitQueryO365Sites()
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
            Initialize(
                argDefs,
                "query",
                "QueryO365Sites",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!,$excludeChildSites: Boolean)",
                "O365SiteConnection",
                Query.O365Sites_ObjectFieldSpec,
                Query.O365SitesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
# OPTIONAL
$inputs.Var.excludeChildSites = <System.Boolean>"
            );
        }

        // Create new GraphQL Query:
        // o365SharepointDrive(snappableFid: UUID!): O365SharepointDrive!
        internal void InitQueryO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointDrive",
                "($snappableFid: UUID!)",
                "O365SharepointDrive",
                Query.O365SharepointDrive_ObjectFieldSpec,
                Query.O365SharepointDriveFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365SharepointDrives(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365SharepointDriveConnection!
        internal void InitQueryO365SharepointDrives()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointDrives",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                "O365SharepointDriveConnection",
                Query.O365SharepointDrives_ObjectFieldSpec,
                Query.O365SharepointDrivesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365SharepointList(snappableFid: UUID!): O365SharepointList!
        internal void InitQueryO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointList",
                "($snappableFid: UUID!)",
                "O365SharepointList",
                Query.O365SharepointList_ObjectFieldSpec,
                Query.O365SharepointListFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365SharepointLists(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365SharepointListConnection!
        internal void InitQueryO365SharepointLists()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointLists",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                "O365SharepointListConnection",
                Query.O365SharepointLists_ObjectFieldSpec,
                Query.O365SharepointListsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365SharepointSite(siteFid: UUID!): O365Site!
        internal void InitQueryO365SharepointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("siteFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointSite",
                "($siteFid: UUID!)",
                "O365Site",
                Query.O365SharepointSite_ObjectFieldSpec,
                Query.O365SharepointSiteFieldSpec,
                @"# REQUIRED
$inputs.Var.siteFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365SharepointSites(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365SiteConnection!
        internal void InitQueryO365SharepointSites()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointSites",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                "O365SiteConnection",
                Query.O365SharepointSites_ObjectFieldSpec,
                Query.O365SharepointSitesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Team(snappableFid: UUID!): O365Teams!
        internal void InitQueryO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Team",
                "($snappableFid: UUID!)",
                "O365Teams",
                Query.O365Team_ObjectFieldSpec,
                Query.O365TeamFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Teams(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     o365OrgId: UUID!
        //   ): O365TeamsConnection!
        internal void InitQueryO365Teams()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Teams",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)",
                "O365TeamsConnection",
                Query.O365Teams_ObjectFieldSpec,
                Query.O365TeamsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365TeamChannels(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     excludeArchived: Boolean!
        //     channelMembershipTypeFilter: ChannelMembershipType!
        //     nameFilter: String
        //   ): O365TeamsChannelConnection!
        internal void InitQueryO365TeamChannels()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("excludeArchived", "Boolean!"),
                Tuple.Create("channelMembershipTypeFilter", "ChannelMembershipType!"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365TeamChannels",
                "($first: Int,$after: String,$snappableFid: UUID!,$excludeArchived: Boolean!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)",
                "O365TeamsChannelConnection",
                Query.O365TeamChannels_ObjectFieldSpec,
                Query.O365TeamChannelsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.excludeArchived = <System.Boolean>
# REQUIRED
$inputs.Var.channelMembershipTypeFilter = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
# OPTIONAL
$inputs.Var.nameFilter = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365TeamConversationsFolderID(snappableFid: UUID!, snapshotFid: UUID!, o365OrgId: UUID!): String!
        internal void InitQueryO365TeamConversationsFolderId()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365TeamConversationsFolderId",
                "($snappableFid: UUID!,$snapshotFid: UUID!,$o365OrgId: UUID!)",
                "System.String",
                Query.O365TeamConversationsFolderId_ObjectFieldSpec,
                Query.O365TeamConversationsFolderIdFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.snapshotFid = <System.String>
# REQUIRED
$inputs.Var.o365OrgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365TeamPostedBy(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     o365OrgId: UUID!
        //     nameFilter: String
        //   ): O365TeamConversationsSenderConnection!
        internal void InitQueryO365TeamPostedBy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
                Tuple.Create("nameFilter", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365TeamPostedBy",
                "($first: Int,$after: String,$snappableFid: UUID!,$o365OrgId: UUID!,$nameFilter: String)",
                "O365TeamConversationsSenderConnection",
                Query.O365TeamPostedBy_ObjectFieldSpec,
                Query.O365TeamPostedByFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
# OPTIONAL
$inputs.Var.nameFilter = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Calendar(snappableFid: UUID!): O365Calendar!
        internal void InitQueryO365Calendar()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Calendar",
                "($snappableFid: UUID!)",
                "O365Calendar",
                Query.O365Calendar_ObjectFieldSpec,
                Query.O365CalendarFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365Orgs(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     workloadHierarchy: WorkloadLevelHierarchy
        //   ): O365OrgConnection!
        internal void InitQueryO365Orgs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365Orgs",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$workloadHierarchy: WorkloadLevelHierarchy)",
                "O365OrgConnection",
                Query.O365Orgs_ObjectFieldSpec,
                Query.O365OrgsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$inputs.Var.workloadHierarchy = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values."
            );
        }

        // Create new GraphQL Query:
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
        internal void InitQueryO365SharepointObjectList()
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
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointObjectList",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$objectTypeFilter: [String!],$includeEntireHierarchy: Boolean!,$fid: UUID!)",
                "O365SharepointObjectConnection",
                Query.O365SharepointObjectList_ObjectFieldSpec,
                Query.O365SharepointObjectListFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$inputs.Var.objectTypeFilter = @(
	<System.String>
)
# REQUIRED
$inputs.Var.includeEntireHierarchy = <System.Boolean>
# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365SharepointObjects(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     fid: UUID!
        //   ): O365SharepointObjectConnection!
        internal void InitQueryO365SharepointObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365SharepointObjects",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)",
                "O365SharepointObjectConnection",
                Query.O365SharepointObjects_ObjectFieldSpec,
                Query.O365SharepointObjectsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365UserObjects(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //     fid: UUID!
        //   ): O365UserDescendantMetadataConnection!
        internal void InitQueryO365UserObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365UserObjects",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)",
                "O365UserDescendantMetadataConnection",
                Query.O365UserObjects_ObjectFieldSpec,
                Query.O365UserObjectsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse!
        internal void InitQueryO365OrgSummaries()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365OrgSummaries",
                "",
                "GetImplicitlyAuthorizedObjectSummariesResponse",
                Query.O365OrgSummaries_ObjectFieldSpec,
                Query.O365OrgSummariesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // o365ObjectAncestors(snappableFid: UUID!): GetImplicitlyAuthorizedAncestorSummariesResponse!
        internal void InitQueryO365ObjectAncestors()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365ObjectAncestors",
                "($snappableFid: UUID!)",
                "GetImplicitlyAuthorizedAncestorSummariesResponse",
                Query.O365ObjectAncestors_ObjectFieldSpec,
                Query.O365ObjectAncestorsFieldSpec,
                @"# REQUIRED
$inputs.Var.snappableFid = <System.String>"
            );
        }

        // Create new GraphQL Query:
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
        internal void InitQueryBrowseO365TeamConvChannels()
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
            Initialize(
                argDefs,
                "query",
                "QueryBrowseO365TeamConvChannels",
                "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFidOpt: UUID,$excludeArchived: Boolean!,$orgId: UUID!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)",
                "O365TeamConvChannelConnection",
                Query.BrowseO365TeamConvChannels_ObjectFieldSpec,
                Query.BrowseO365TeamConvChannelsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.snapshotFidOpt = <System.String>
# REQUIRED
$inputs.Var.excludeArchived = <System.Boolean>
# REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.channelMembershipTypeFilter = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
# OPTIONAL
$inputs.Var.nameFilter = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365ServiceAccount(orgId: UUID!): O365ServiceAccountStatusResp!
        internal void InitQueryO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365ServiceAccount",
                "($orgId: UUID!)",
                "O365ServiceAccountStatusResp",
                Query.O365ServiceAccount_ObjectFieldSpec,
                Query.O365ServiceAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // allO365OrgStatuses: [O365OrgInfo!]!
        internal void InitQueryAllO365OrgStatuses()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllO365OrgStatuses",
                "",
                "List<O365OrgInfo>",
                Query.AllO365OrgStatuses_ObjectFieldSpec,
                Query.AllO365OrgStatusesFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // o365License: O365License!
        internal void InitQueryO365License()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365License",
                "",
                "O365License",
                Query.O365License_ObjectFieldSpec,
                Query.O365LicenseFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // listO365Apps(
        //     first: Int
        //     after: String
        //     o365AppFilters: [AppFilter!]!
        //     o365AppSortByParam: AppSortByParam
        //   ): O365AppConnection!
        internal void InitQueryListO365Apps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("o365AppFilters", "[AppFilter!]!"),
                Tuple.Create("o365AppSortByParam", "AppSortByParam"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryListO365Apps",
                "($first: Int,$after: String,$o365AppFilters: [AppFilter!]!,$o365AppSortByParam: AppSortByParam)",
                "O365AppConnection",
                Query.ListO365Apps_ObjectFieldSpec,
                Query.ListO365AppsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.o365AppFilters = @(
	@{
		# OPTIONAL
		field = <AppFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AppFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.o365AppSortByParam = @{
	# OPTIONAL
	field = <AppSortByParamField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AppSortByParamField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]!
        internal void InitQueryAllO365SubscriptionsAppTypeCounts()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllO365SubscriptionsAppTypeCounts",
                "",
                "List<O365SubscriptionAppTypeCounts>",
                Query.AllO365SubscriptionsAppTypeCounts_ObjectFieldSpec,
                Query.AllO365SubscriptionsAppTypeCountsFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // o365StorageStats(orgID: UUID): GetO365StorageStatsResp!
        internal void InitQueryO365StorageStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365StorageStats",
                "($orgID: UUID)",
                "GetO365StorageStatsResp",
                Query.O365StorageStats_ObjectFieldSpec,
                Query.O365StorageStatsFieldSpec,
                @"# OPTIONAL
$inputs.Var.orgID = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // o365ServiceStatus(orgID: UUID): GetO365ServiceStatusResp!
        internal void InitQueryO365ServiceStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryO365ServiceStatus",
                "($orgID: UUID)",
                "GetO365ServiceStatusResp",
                Query.O365ServiceStatus_ObjectFieldSpec,
                Query.O365ServiceStatusFieldSpec,
                @"# OPTIONAL
$inputs.Var.orgID = <System.String>"
            );
        }


    } // class New_RscQueryO365
}