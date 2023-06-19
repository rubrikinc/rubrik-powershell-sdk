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
        
        // -------------------------------------------------------------------
        // Org parameter set
        //
        // [GraphQL: o365Org]
        //
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

        [Parameter(
            ParameterSetName = "Org",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The Rubrik UUID for the object.
GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Orgatsnappablelevel parameter set
        //
        // [GraphQL: o365OrgAtSnappableLevel]
        //
        [Parameter(
            ParameterSetName = "Orgatsnappablelevel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details of the O365Org at snappable level, given the snappable type.
[GraphQL: o365OrgAtSnappableLevel]",
            Position = 0
        )]
        public SwitchParameter Orgatsnappablelevel { get; set; }

        [Parameter(
            ParameterSetName = "Orgatsnappablelevel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument snappableType: SnappableType!"
        )]
        public SnappableType? SnappableType { get; set; }
        
        // -------------------------------------------------------------------
        // Alladgroup parameter set
        //
        // [GraphQL: allO365AdGroups]
        //
        [Parameter(
            ParameterSetName = "Alladgroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"All AD Groups belonging to the O365 organization.
[GraphQL: allO365AdGroups]",
            Position = 0
        )]
        public SwitchParameter Alladgroup { get; set; }

        [Parameter(
            ParameterSetName = "Alladgroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Org UUID.
GraphQL argument orgId: UUID!"
        )]
        public System.String? OrgId { get; set; }
        [Parameter(
            ParameterSetName = "Alladgroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"AD group search filter.
GraphQL argument adGroupSearchFilter: String!"
        )]
        public System.String? AdGroupSearchFilter { get; set; }
        
        // -------------------------------------------------------------------
        // User parameter set
        //
        // [GraphQL: o365User]
        //
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

        
        // -------------------------------------------------------------------
        // Mailbox parameter set
        //
        // [GraphQL: o365Mailbox]
        //
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

        [Parameter(
            ParameterSetName = "Mailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The fid for the workload.
GraphQL argument snappableFid: UUID!"
        )]
        public System.String? SnappableFid { get; set; }
        
        // -------------------------------------------------------------------
        // Group parameter set
        //
        // [GraphQL: o365Groups]
        //
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of O365 Groups in the O365Org.
[GraphQL: o365Groups]",
            Position = 0
        )]
        public SwitchParameter Group { get; set; }

        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the first n elements from the list.
GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the elements in the list that come after the specified cursor.
GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sort hierarchy objects by hierarchy field.
GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Sorting order for the results.
GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The hierarchy object filter.
GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The fid for the O365 organization.
GraphQL argument o365OrgId: UUID!"
        )]
        public System.String? O365OrgId { get; set; }
        
        // -------------------------------------------------------------------
        // Mailboxe parameter set
        //
        // [GraphQL: o365Mailboxes]
        //
        [Parameter(
            ParameterSetName = "Mailboxe",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Mailboxes in the O365Org.
[GraphQL: o365Mailboxes]",
            Position = 0
        )]
        public SwitchParameter Mailboxe { get; set; }

        
        // -------------------------------------------------------------------
        // Onedrive parameter set
        //
        // [GraphQL: o365Onedrive]
        //
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

        
        // -------------------------------------------------------------------
        // Site parameter set
        //
        // [GraphQL: o365Site]
        //
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

        
        // -------------------------------------------------------------------
        // Sharepointdrive parameter set
        //
        // [GraphQL: o365SharepointDrive]
        //
        [Parameter(
            ParameterSetName = "Sharepointdrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the SharePoint drive corresponding to the snappable ID.
[GraphQL: o365SharepointDrive]",
            Position = 0
        )]
        public SwitchParameter Sharepointdrive { get; set; }

        
        // -------------------------------------------------------------------
        // Sharepointlist parameter set
        //
        // [GraphQL: o365SharepointList]
        //
        [Parameter(
            ParameterSetName = "Sharepointlist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the SharePoint list corresponding to the snappable ID.
[GraphQL: o365SharepointList]",
            Position = 0
        )]
        public SwitchParameter Sharepointlist { get; set; }

        
        // -------------------------------------------------------------------
        // Sharepointsite parameter set
        //
        // [GraphQL: o365SharepointSite]
        //
        [Parameter(
            ParameterSetName = "Sharepointsite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Details for the SharePoint site corresponding to the site ID.
[GraphQL: o365SharepointSite]",
            Position = 0
        )]
        public SwitchParameter Sharepointsite { get; set; }

        [Parameter(
            ParameterSetName = "Sharepointsite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The fid for the site.
GraphQL argument siteFid: UUID!"
        )]
        public System.String? SiteFid { get; set; }
        
        // -------------------------------------------------------------------
        // Team parameter set
        //
        // [GraphQL: o365Team]
        //
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

        
        // -------------------------------------------------------------------
        // Teamchannel parameter set
        //
        // [GraphQL: o365TeamChannels]
        //
        [Parameter(
            ParameterSetName = "Teamchannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of Channels for the O365Team.
[GraphQL: o365TeamChannels]",
            Position = 0
        )]
        public SwitchParameter Teamchannel { get; set; }

        [Parameter(
            ParameterSetName = "Teamchannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument excludeArchived: Boolean!"
        )]
        public System.Boolean? ExcludeArchived { get; set; }
        [Parameter(
            ParameterSetName = "Teamchannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Filter on channel membership type.
GraphQL argument channelMembershipTypeFilter: ChannelMembershipType!"
        )]
        public ChannelMembershipType? ChannelMembershipTypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "Teamchannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument nameFilter: String"
        )]
        public System.String? NameFilter { get; set; }
        
        // -------------------------------------------------------------------
        // Teamconversationsfolderid parameter set
        //
        // [GraphQL: o365TeamConversationsFolderID]
        //
        [Parameter(
            ParameterSetName = "Teamconversationsfolderid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"ID for the conversations folder in the Team's Group Mailbox.
[GraphQL: o365TeamConversationsFolderID]",
            Position = 0
        )]
        public SwitchParameter Teamconversationsfolderid { get; set; }

        [Parameter(
            ParameterSetName = "Teamconversationsfolderid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"The ID of the snapshot.
GraphQL argument snapshotFid: UUID!"
        )]
        public System.String? SnapshotFid { get; set; }
        
        // -------------------------------------------------------------------
        // Teampostedby parameter set
        //
        // [GraphQL: o365TeamPostedBy]
        //
        [Parameter(
            ParameterSetName = "Teampostedby",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Users who have posted in a team.
[GraphQL: o365TeamPostedBy]",
            Position = 0
        )]
        public SwitchParameter Teampostedby { get; set; }

        
        // -------------------------------------------------------------------
        // Calendar parameter set
        //
        // [GraphQL: o365Calendar]
        //
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

        
        // -------------------------------------------------------------------
        // Sharepointobjectlist parameter set
        //
        // [GraphQL: o365SharepointObjectList]
        //
        [Parameter(
            ParameterSetName = "Sharepointobjectlist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the sharepoint objects after filtering on the object types and includeEntireHierarchy.
[GraphQL: o365SharepointObjectList]",
            Position = 0
        )]
        public SwitchParameter Sharepointobjectlist { get; set; }

        [Parameter(
            ParameterSetName = "Sharepointobjectlist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Types of objects to include.
GraphQL argument objectTypeFilter: [String!]"
        )]
        public List<System.String>? ObjectTypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "Sharepointobjectlist",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"If true, the entire hierarchy will be searched.
GraphQL argument includeEntireHierarchy: Boolean!"
        )]
        public System.Boolean? IncludeEntireHierarchy { get; set; }
        
        // -------------------------------------------------------------------
        // Sharepointobject parameter set
        //
        // [GraphQL: o365SharepointObjects]
        //
        [Parameter(
            ParameterSetName = "Sharepointobject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365SharepointObjects]",
            Position = 0
        )]
        public SwitchParameter Sharepointobject { get; set; }

        
        // -------------------------------------------------------------------
        // Userobject parameter set
        //
        // [GraphQL: o365UserObjects]
        //
        [Parameter(
            ParameterSetName = "Userobject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Name, id, object type, and mail address of user descendant object.
[GraphQL: o365UserObjects]",
            Position = 0
        )]
        public SwitchParameter Userobject { get; set; }

        
        // -------------------------------------------------------------------
        // Orgsummarie parameter set
        //
        // [GraphQL: o365OrgSummaries]
        //
        [Parameter(
            ParameterSetName = "Orgsummarie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365OrgSummaries]",
            Position = 0
        )]
        public SwitchParameter Orgsummarie { get; set; }

        
        // -------------------------------------------------------------------
        // Objectancestor parameter set
        //
        // [GraphQL: o365ObjectAncestors]
        //
        [Parameter(
            ParameterSetName = "Objectancestor",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
[GraphQL: o365ObjectAncestors]",
            Position = 0
        )]
        public SwitchParameter Objectancestor { get; set; }

        
        // -------------------------------------------------------------------
        // Browseteamconvchannel parameter set
        //
        // [GraphQL: browseO365TeamConvChannels]
        //
        [Parameter(
            ParameterSetName = "Browseteamconvchannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Browse channels in a Teams conversations snapshot.
[GraphQL: browseO365TeamConvChannels]",
            Position = 0
        )]
        public SwitchParameter Browseteamconvchannel { get; set; }

        [Parameter(
            ParameterSetName = "Browseteamconvchannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"snapshotFid arg which is of optional type
GraphQL argument snapshotFidOpt: UUID"
        )]
        public System.String? SnapshotFidOpt { get; set; }
        
        // -------------------------------------------------------------------
        // Serviceaccount parameter set
        //
        // [GraphQL: o365ServiceAccount]
        //
        [Parameter(
            ParameterSetName = "Serviceaccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the service account for the given org.
[GraphQL: o365ServiceAccount]",
            Position = 0
        )]
        public SwitchParameter Serviceaccount { get; set; }

        
        // -------------------------------------------------------------------
        // Allorgstatus parameter set
        //
        // [GraphQL: allO365OrgStatuses]
        //
        [Parameter(
            ParameterSetName = "Allorgstatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Gets the status of each org in the account.
[GraphQL: allO365OrgStatuses]",
            Position = 0
        )]
        public SwitchParameter Allorgstatus { get; set; }

        
        // -------------------------------------------------------------------
        // License parameter set
        //
        // [GraphQL: o365License]
        //
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

        
        // -------------------------------------------------------------------
        // Listapp parameter set
        //
        // [GraphQL: listO365Apps]
        //
        [Parameter(
            ParameterSetName = "Listapp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Lists the O365 apps.
[GraphQL: listO365Apps]",
            Position = 0
        )]
        public SwitchParameter Listapp { get; set; }

        [Parameter(
            ParameterSetName = "Listapp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument o365AppFilters: [AppFilter!]!"
        )]
        public List<AppFilter>? O365AppFilters { get; set; }
        [Parameter(
            ParameterSetName = "Listapp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"
GraphQL argument o365AppSortByParam: AppSortByParam"
        )]
        public AppSortByParam? O365AppSortByParam { get; set; }
        
        // -------------------------------------------------------------------
        // Allsubscriptionsapptypecount parameter set
        //
        // [GraphQL: allO365SubscriptionsAppTypeCounts]
        //
        [Parameter(
            ParameterSetName = "Allsubscriptionsapptypecount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the total number of apps of each type, for each O365 org.
[GraphQL: allO365SubscriptionsAppTypeCounts]",
            Position = 0
        )]
        public SwitchParameter Allsubscriptionsapptypecount { get; set; }

        
        // -------------------------------------------------------------------
        // Storagestat parameter set
        //
        // [GraphQL: o365StorageStats]
        //
        [Parameter(
            ParameterSetName = "Storagestat",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the storage stats of an O365 org.
[GraphQL: o365StorageStats]",
            Position = 0
        )]
        public SwitchParameter Storagestat { get; set; }

        
        // -------------------------------------------------------------------
        // Servicestatus parameter set
        //
        // [GraphQL: o365ServiceStatus]
        //
        [Parameter(
            ParameterSetName = "Servicestatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Returns the service status of the O365 service running on MSFT server.
[GraphQL: o365ServiceStatus]",
            Position = 0
        )]
        public SwitchParameter Servicestatus { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Org":
                        this.ProcessRecord_Org();
                        break;
                    case "Orgatsnappablelevel":
                        this.ProcessRecord_Orgatsnappablelevel();
                        break;
                    case "Alladgroup":
                        this.ProcessRecord_Alladgroup();
                        break;
                    case "User":
                        this.ProcessRecord_User();
                        break;
                    case "Mailbox":
                        this.ProcessRecord_Mailbox();
                        break;
                    case "Group":
                        this.ProcessRecord_Group();
                        break;
                    case "Mailboxe":
                        this.ProcessRecord_Mailboxe();
                        break;
                    case "Onedrive":
                        this.ProcessRecord_Onedrive();
                        break;
                    case "Site":
                        this.ProcessRecord_Site();
                        break;
                    case "Sharepointdrive":
                        this.ProcessRecord_Sharepointdrive();
                        break;
                    case "Sharepointlist":
                        this.ProcessRecord_Sharepointlist();
                        break;
                    case "Sharepointsite":
                        this.ProcessRecord_Sharepointsite();
                        break;
                    case "Team":
                        this.ProcessRecord_Team();
                        break;
                    case "Teamchannel":
                        this.ProcessRecord_Teamchannel();
                        break;
                    case "Teamconversationsfolderid":
                        this.ProcessRecord_Teamconversationsfolderid();
                        break;
                    case "Teampostedby":
                        this.ProcessRecord_Teampostedby();
                        break;
                    case "Calendar":
                        this.ProcessRecord_Calendar();
                        break;
                    case "Sharepointobjectlist":
                        this.ProcessRecord_Sharepointobjectlist();
                        break;
                    case "Sharepointobject":
                        this.ProcessRecord_Sharepointobject();
                        break;
                    case "Userobject":
                        this.ProcessRecord_Userobject();
                        break;
                    case "Orgsummarie":
                        this.ProcessRecord_Orgsummarie();
                        break;
                    case "Objectancestor":
                        this.ProcessRecord_Objectancestor();
                        break;
                    case "Browseteamconvchannel":
                        this.ProcessRecord_Browseteamconvchannel();
                        break;
                    case "Serviceaccount":
                        this.ProcessRecord_Serviceaccount();
                        break;
                    case "Allorgstatus":
                        this.ProcessRecord_Allorgstatus();
                        break;
                    case "License":
                        this.ProcessRecord_License();
                        break;
                    case "Listapp":
                        this.ProcessRecord_Listapp();
                        break;
                    case "Allsubscriptionsapptypecount":
                        this.ProcessRecord_Allsubscriptionsapptypecount();
                        break;
                    case "Storagestat":
                        this.ProcessRecord_Storagestat();
                        break;
                    case "Servicestatus":
                        this.ProcessRecord_Servicestatus();
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
        // o365Org.
        protected void ProcessRecord_Org()
        {
            this._logger.name += " -Org";
            // Invoke graphql operation o365Org
            InvokeQueryO365Org();
        }

        // This parameter set invokes a single graphql operation:
        // o365OrgAtSnappableLevel.
        protected void ProcessRecord_Orgatsnappablelevel()
        {
            this._logger.name += " -Orgatsnappablelevel";
            // Invoke graphql operation o365OrgAtSnappableLevel
            InvokeQueryO365OrgAtSnappableLevel();
        }

        // This parameter set invokes a single graphql operation:
        // allO365AdGroups.
        protected void ProcessRecord_Alladgroup()
        {
            this._logger.name += " -Alladgroup";
            // Invoke graphql operation allO365AdGroups
            InvokeQueryAllO365AdGroups();
        }

        // This parameter set invokes a single graphql operation:
        // o365User.
        protected void ProcessRecord_User()
        {
            this._logger.name += " -User";
            // Invoke graphql operation o365User
            InvokeQueryO365User();
        }

        // This parameter set invokes a single graphql operation:
        // o365Mailbox.
        protected void ProcessRecord_Mailbox()
        {
            this._logger.name += " -Mailbox";
            // Invoke graphql operation o365Mailbox
            InvokeQueryO365Mailbox();
        }

        // This parameter set invokes a single graphql operation:
        // o365Groups.
        protected void ProcessRecord_Group()
        {
            this._logger.name += " -Group";
            // Invoke graphql operation o365Groups
            InvokeQueryO365Groups();
        }

        // This parameter set invokes a single graphql operation:
        // o365Mailboxes.
        protected void ProcessRecord_Mailboxe()
        {
            this._logger.name += " -Mailboxe";
            // Invoke graphql operation o365Mailboxes
            InvokeQueryO365Mailboxes();
        }

        // This parameter set invokes a single graphql operation:
        // o365Onedrive.
        protected void ProcessRecord_Onedrive()
        {
            this._logger.name += " -Onedrive";
            // Invoke graphql operation o365Onedrive
            InvokeQueryO365Onedrive();
        }

        // This parameter set invokes a single graphql operation:
        // o365Site.
        protected void ProcessRecord_Site()
        {
            this._logger.name += " -Site";
            // Invoke graphql operation o365Site
            InvokeQueryO365Site();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointDrive.
        protected void ProcessRecord_Sharepointdrive()
        {
            this._logger.name += " -Sharepointdrive";
            // Invoke graphql operation o365SharepointDrive
            InvokeQueryO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointList.
        protected void ProcessRecord_Sharepointlist()
        {
            this._logger.name += " -Sharepointlist";
            // Invoke graphql operation o365SharepointList
            InvokeQueryO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointSite.
        protected void ProcessRecord_Sharepointsite()
        {
            this._logger.name += " -Sharepointsite";
            // Invoke graphql operation o365SharepointSite
            InvokeQueryO365SharepointSite();
        }

        // This parameter set invokes a single graphql operation:
        // o365Team.
        protected void ProcessRecord_Team()
        {
            this._logger.name += " -Team";
            // Invoke graphql operation o365Team
            InvokeQueryO365Team();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamChannels.
        protected void ProcessRecord_Teamchannel()
        {
            this._logger.name += " -Teamchannel";
            // Invoke graphql operation o365TeamChannels
            InvokeQueryO365TeamChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamConversationsFolderID.
        protected void ProcessRecord_Teamconversationsfolderid()
        {
            this._logger.name += " -Teamconversationsfolderid";
            // Invoke graphql operation o365TeamConversationsFolderID
            InvokeQueryO365TeamConversationsFolderId();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamPostedBy.
        protected void ProcessRecord_Teampostedby()
        {
            this._logger.name += " -Teampostedby";
            // Invoke graphql operation o365TeamPostedBy
            InvokeQueryO365TeamPostedBy();
        }

        // This parameter set invokes a single graphql operation:
        // o365Calendar.
        protected void ProcessRecord_Calendar()
        {
            this._logger.name += " -Calendar";
            // Invoke graphql operation o365Calendar
            InvokeQueryO365Calendar();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointObjectList.
        protected void ProcessRecord_Sharepointobjectlist()
        {
            this._logger.name += " -Sharepointobjectlist";
            // Invoke graphql operation o365SharepointObjectList
            InvokeQueryO365SharepointObjectList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointObjects.
        protected void ProcessRecord_Sharepointobject()
        {
            this._logger.name += " -Sharepointobject";
            // Invoke graphql operation o365SharepointObjects
            InvokeQueryO365SharepointObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365UserObjects.
        protected void ProcessRecord_Userobject()
        {
            this._logger.name += " -Userobject";
            // Invoke graphql operation o365UserObjects
            InvokeQueryO365UserObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365OrgSummaries.
        protected void ProcessRecord_Orgsummarie()
        {
            this._logger.name += " -Orgsummarie";
            // Invoke graphql operation o365OrgSummaries
            InvokeQueryO365OrgSummaries();
        }

        // This parameter set invokes a single graphql operation:
        // o365ObjectAncestors.
        protected void ProcessRecord_Objectancestor()
        {
            this._logger.name += " -Objectancestor";
            // Invoke graphql operation o365ObjectAncestors
            InvokeQueryO365ObjectAncestors();
        }

        // This parameter set invokes a single graphql operation:
        // browseO365TeamConvChannels.
        protected void ProcessRecord_Browseteamconvchannel()
        {
            this._logger.name += " -Browseteamconvchannel";
            // Invoke graphql operation browseO365TeamConvChannels
            InvokeQueryBrowseO365TeamConvChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceAccount.
        protected void ProcessRecord_Serviceaccount()
        {
            this._logger.name += " -Serviceaccount";
            // Invoke graphql operation o365ServiceAccount
            InvokeQueryO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allO365OrgStatuses.
        protected void ProcessRecord_Allorgstatus()
        {
            this._logger.name += " -Allorgstatus";
            // Invoke graphql operation allO365OrgStatuses
            InvokeQueryAllO365OrgStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // o365License.
        protected void ProcessRecord_License()
        {
            this._logger.name += " -License";
            // Invoke graphql operation o365License
            InvokeQueryO365License();
        }

        // This parameter set invokes a single graphql operation:
        // listO365Apps.
        protected void ProcessRecord_Listapp()
        {
            this._logger.name += " -Listapp";
            // Invoke graphql operation listO365Apps
            InvokeQueryListO365Apps();
        }

        // This parameter set invokes a single graphql operation:
        // allO365SubscriptionsAppTypeCounts.
        protected void ProcessRecord_Allsubscriptionsapptypecount()
        {
            this._logger.name += " -Allsubscriptionsapptypecount";
            // Invoke graphql operation allO365SubscriptionsAppTypeCounts
            InvokeQueryAllO365SubscriptionsAppTypeCounts();
        }

        // This parameter set invokes a single graphql operation:
        // o365StorageStats.
        protected void ProcessRecord_Storagestat()
        {
            this._logger.name += " -Storagestat";
            // Invoke graphql operation o365StorageStats
            InvokeQueryO365StorageStats();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceStatus.
        protected void ProcessRecord_Servicestatus()
        {
            this._logger.name += " -Servicestatus";
            // Invoke graphql operation o365ServiceStatus
            InvokeQueryO365ServiceStatus();
        }


        // Invoke GraphQL Query:
        // o365Org(fid: UUID!): O365Org!
        protected void InvokeQueryO365Org()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            O365Org? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Org)psObject.BaseObject;
                } else {
                    fields = (O365Org)this.Field;
                }
            }
            string document = Query.O365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Org");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Org" + parameters + "{" + document + "}",
                OperationName = "QueryO365Org",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Org", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!): O365Org!
        protected void InvokeQueryO365OrgAtSnappableLevel()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
                Tuple.Create("snappableType", "SnappableType!"),
            };
            O365Org? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Org)psObject.BaseObject;
                } else {
                    fields = (O365Org)this.Field;
                }
            }
            string document = Query.O365OrgAtSnappableLevel(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365OrgAtSnappableLevel");
            var parameters = "($fid: UUID!,$snappableType: SnappableType!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365OrgAtSnappableLevel" + parameters + "{" + document + "}",
                OperationName = "QueryO365OrgAtSnappableLevel",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Org", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allO365AdGroups(orgId: UUID!, adGroupSearchFilter: String!): [AdGroup!]!
        protected void InvokeQueryAllO365AdGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("adGroupSearchFilter", "String!"),
            };
            List<AdGroup>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<AdGroup>)psObject.BaseObject;
                } else {
                    fields = (List<AdGroup>)this.Field;
                }
            }
            string document = Query.AllO365AdGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllO365AdGroups");
            var parameters = "($orgId: UUID!,$adGroupSearchFilter: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllO365AdGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAllO365AdGroups",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "List<AdGroup>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365User(fid: UUID!): O365User!
        protected void InvokeQueryO365User()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            O365User? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365User)psObject.BaseObject;
                } else {
                    fields = (O365User)this.Field;
                }
            }
            string document = Query.O365User(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365User");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365User" + parameters + "{" + document + "}",
                OperationName = "QueryO365User",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365User", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365Mailbox(snappableFid: UUID!): O365Mailbox!
        protected void InvokeQueryO365Mailbox()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Mailbox? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Mailbox)psObject.BaseObject;
                } else {
                    fields = (O365Mailbox)this.Field;
                }
            }
            string document = Query.O365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Mailbox");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "QueryO365Mailbox",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Mailbox", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryO365Groups()
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
            O365GroupConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365GroupConnection)psObject.BaseObject;
                } else {
                    fields = (O365GroupConnection)this.Field;
                }
            }
            string document = Query.O365Groups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Groups");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!,$snappableType: SnappableType!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Groups" + parameters + "{" + document + "}",
                OperationName = "QueryO365Groups",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365GroupConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryO365Mailboxes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("o365OrgId", "UUID!"),
            };
            O365MailboxConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365MailboxConnection)psObject.BaseObject;
                } else {
                    fields = (O365MailboxConnection)this.Field;
                }
            }
            string document = Query.O365Mailboxes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Mailboxes");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Mailboxes" + parameters + "{" + document + "}",
                OperationName = "QueryO365Mailboxes",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365MailboxConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365Onedrive(snappableFid: UUID!): O365Onedrive!
        protected void InvokeQueryO365Onedrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Onedrive? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Onedrive)psObject.BaseObject;
                } else {
                    fields = (O365Onedrive)this.Field;
                }
            }
            string document = Query.O365Onedrive(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Onedrive");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Onedrive" + parameters + "{" + document + "}",
                OperationName = "QueryO365Onedrive",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Onedrive", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365Site(snappableFid: UUID!): O365Site!
        protected void InvokeQueryO365Site()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Site? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Site)psObject.BaseObject;
                } else {
                    fields = (O365Site)this.Field;
                }
            }
            string document = Query.O365Site(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Site");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Site" + parameters + "{" + document + "}",
                OperationName = "QueryO365Site",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Site", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365SharepointDrive(snappableFid: UUID!): O365SharepointDrive!
        protected void InvokeQueryO365SharepointDrive()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365SharepointDrive? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365SharepointDrive)psObject.BaseObject;
                } else {
                    fields = (O365SharepointDrive)this.Field;
                }
            }
            string document = Query.O365SharepointDrive(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointDrive");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointDrive" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointDrive",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365SharepointDrive", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365SharepointList(snappableFid: UUID!): O365SharepointList!
        protected void InvokeQueryO365SharepointList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365SharepointList? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365SharepointList)psObject.BaseObject;
                } else {
                    fields = (O365SharepointList)this.Field;
                }
            }
            string document = Query.O365SharepointList(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointList");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointList" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointList",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365SharepointList", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365SharepointSite(siteFid: UUID!): O365Site!
        protected void InvokeQueryO365SharepointSite()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("siteFid", "UUID!"),
            };
            O365Site? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Site)psObject.BaseObject;
                } else {
                    fields = (O365Site)this.Field;
                }
            }
            string document = Query.O365SharepointSite(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointSite");
            var parameters = "($siteFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointSite" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointSite",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Site", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365Team(snappableFid: UUID!): O365Teams!
        protected void InvokeQueryO365Team()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Teams? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Teams)psObject.BaseObject;
                } else {
                    fields = (O365Teams)this.Field;
                }
            }
            string document = Query.O365Team(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Team");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Team" + parameters + "{" + document + "}",
                OperationName = "QueryO365Team",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Teams", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryO365TeamChannels()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("excludeArchived", "Boolean!"),
                Tuple.Create("channelMembershipTypeFilter", "ChannelMembershipType!"),
                Tuple.Create("nameFilter", "String"),
            };
            O365TeamsChannelConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365TeamsChannelConnection)psObject.BaseObject;
                } else {
                    fields = (O365TeamsChannelConnection)this.Field;
                }
            }
            string document = Query.O365TeamChannels(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365TeamChannels");
            var parameters = "($first: Int,$after: String,$snappableFid: UUID!,$excludeArchived: Boolean!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365TeamChannels" + parameters + "{" + document + "}",
                OperationName = "QueryO365TeamChannels",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365TeamsChannelConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365TeamConversationsFolderID(snappableFid: UUID!, snapshotFid: UUID!, o365OrgId: UUID!): String!
        protected void InvokeQueryO365TeamConversationsFolderId()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("snapshotFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
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
            string document = Query.O365TeamConversationsFolderId(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365TeamConversationsFolderId");
            var parameters = "($snappableFid: UUID!,$snapshotFid: UUID!,$o365OrgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365TeamConversationsFolderId" + parameters + "{" + document + "}",
                OperationName = "QueryO365TeamConversationsFolderId",
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

        // Invoke GraphQL Query:
        // o365TeamPostedBy(
        //     first: Int
        //     after: String
        //     snappableFid: UUID!
        //     o365OrgId: UUID!
        //     nameFilter: String
        //   ): O365TeamConversationsSenderConnection!
        protected void InvokeQueryO365TeamPostedBy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("o365OrgId", "UUID!"),
                Tuple.Create("nameFilter", "String"),
            };
            O365TeamConversationsSenderConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365TeamConversationsSenderConnection)psObject.BaseObject;
                } else {
                    fields = (O365TeamConversationsSenderConnection)this.Field;
                }
            }
            string document = Query.O365TeamPostedBy(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365TeamPostedBy");
            var parameters = "($first: Int,$after: String,$snappableFid: UUID!,$o365OrgId: UUID!,$nameFilter: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365TeamPostedBy" + parameters + "{" + document + "}",
                OperationName = "QueryO365TeamPostedBy",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365TeamConversationsSenderConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365Calendar(snappableFid: UUID!): O365Calendar!
        protected void InvokeQueryO365Calendar()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            O365Calendar? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365Calendar)psObject.BaseObject;
                } else {
                    fields = (O365Calendar)this.Field;
                }
            }
            string document = Query.O365Calendar(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Calendar");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Calendar" + parameters + "{" + document + "}",
                OperationName = "QueryO365Calendar",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365Calendar", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryO365SharepointObjectList()
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
            O365SharepointObjectConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365SharepointObjectConnection)psObject.BaseObject;
                } else {
                    fields = (O365SharepointObjectConnection)this.Field;
                }
            }
            string document = Query.O365SharepointObjectList(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointObjectList");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$objectTypeFilter: [String!],$includeEntireHierarchy: Boolean!,$fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointObjectList" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointObjectList",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365SharepointObjectConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryO365SharepointObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("fid", "UUID!"),
            };
            O365SharepointObjectConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365SharepointObjectConnection)psObject.BaseObject;
                } else {
                    fields = (O365SharepointObjectConnection)this.Field;
                }
            }
            string document = Query.O365SharepointObjects(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointObjects");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointObjects" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointObjects",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365SharepointObjectConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryO365UserObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("fid", "UUID!"),
            };
            O365UserDescendantMetadataConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365UserDescendantMetadataConnection)psObject.BaseObject;
                } else {
                    fields = (O365UserDescendantMetadataConnection)this.Field;
                }
            }
            string document = Query.O365UserObjects(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365UserObjects");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365UserObjects" + parameters + "{" + document + "}",
                OperationName = "QueryO365UserObjects",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365UserDescendantMetadataConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365OrgSummaries: GetImplicitlyAuthorizedObjectSummariesResponse!
        protected void InvokeQueryO365OrgSummaries()
        {
            Tuple<string, string>[] argDefs = {
            };
            GetImplicitlyAuthorizedObjectSummariesResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GetImplicitlyAuthorizedObjectSummariesResponse)psObject.BaseObject;
                } else {
                    fields = (GetImplicitlyAuthorizedObjectSummariesResponse)this.Field;
                }
            }
            string document = Query.O365OrgSummaries(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365OrgSummaries");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365OrgSummaries" + parameters + "{" + document + "}",
                OperationName = "QueryO365OrgSummaries",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "GetImplicitlyAuthorizedObjectSummariesResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365ObjectAncestors(snappableFid: UUID!): GetImplicitlyAuthorizedAncestorSummariesResponse!
        protected void InvokeQueryO365ObjectAncestors()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
            };
            GetImplicitlyAuthorizedAncestorSummariesResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GetImplicitlyAuthorizedAncestorSummariesResponse)psObject.BaseObject;
                } else {
                    fields = (GetImplicitlyAuthorizedAncestorSummariesResponse)this.Field;
                }
            }
            string document = Query.O365ObjectAncestors(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365ObjectAncestors");
            var parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365ObjectAncestors" + parameters + "{" + document + "}",
                OperationName = "QueryO365ObjectAncestors",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GetImplicitlyAuthorizedAncestorSummariesResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
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
        protected void InvokeQueryBrowseO365TeamConvChannels()
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
            O365TeamConvChannelConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365TeamConvChannelConnection)psObject.BaseObject;
                } else {
                    fields = (O365TeamConvChannelConnection)this.Field;
                }
            }
            string document = Query.BrowseO365TeamConvChannels(ref fields);
            this._input.Initialize(argDefs, fields, "Query.BrowseO365TeamConvChannels");
            var parameters = "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFidOpt: UUID,$excludeArchived: Boolean!,$orgId: UUID!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryBrowseO365TeamConvChannels" + parameters + "{" + document + "}",
                OperationName = "QueryBrowseO365TeamConvChannels",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365TeamConvChannelConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365ServiceAccount(orgId: UUID!): O365ServiceAccountStatusResp!
        protected void InvokeQueryO365ServiceAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            O365ServiceAccountStatusResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365ServiceAccountStatusResp)psObject.BaseObject;
                } else {
                    fields = (O365ServiceAccountStatusResp)this.Field;
                }
            }
            string document = Query.O365ServiceAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365ServiceAccount");
            var parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365ServiceAccount" + parameters + "{" + document + "}",
                OperationName = "QueryO365ServiceAccount",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365ServiceAccountStatusResp", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allO365OrgStatuses: [O365OrgInfo!]!
        protected void InvokeQueryAllO365OrgStatuses()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<O365OrgInfo>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<O365OrgInfo>)psObject.BaseObject;
                } else {
                    fields = (List<O365OrgInfo>)this.Field;
                }
            }
            string document = Query.AllO365OrgStatuses(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllO365OrgStatuses");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllO365OrgStatuses" + parameters + "{" + document + "}",
                OperationName = "QueryAllO365OrgStatuses",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "List<O365OrgInfo>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365License: O365License!
        protected void InvokeQueryO365License()
        {
            Tuple<string, string>[] argDefs = {
            };
            O365License? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365License)psObject.BaseObject;
                } else {
                    fields = (O365License)this.Field;
                }
            }
            string document = Query.O365License(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365License");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365License" + parameters + "{" + document + "}",
                OperationName = "QueryO365License",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "O365License", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // listO365Apps(
        //     first: Int
        //     after: String
        //     o365AppFilters: [AppFilter!]!
        //     o365AppSortByParam: AppSortByParam
        //   ): O365AppConnection!
        protected void InvokeQueryListO365Apps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("o365AppFilters", "[AppFilter!]!"),
                Tuple.Create("o365AppSortByParam", "AppSortByParam"),
            };
            O365AppConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (O365AppConnection)psObject.BaseObject;
                } else {
                    fields = (O365AppConnection)this.Field;
                }
            }
            string document = Query.ListO365Apps(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ListO365Apps");
            var parameters = "($first: Int,$after: String,$o365AppFilters: [AppFilter!]!,$o365AppSortByParam: AppSortByParam)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryListO365Apps" + parameters + "{" + document + "}",
                OperationName = "QueryListO365Apps",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "O365AppConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // allO365SubscriptionsAppTypeCounts: [O365SubscriptionAppTypeCounts!]!
        protected void InvokeQueryAllO365SubscriptionsAppTypeCounts()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<O365SubscriptionAppTypeCounts>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (List<O365SubscriptionAppTypeCounts>)psObject.BaseObject;
                } else {
                    fields = (List<O365SubscriptionAppTypeCounts>)this.Field;
                }
            }
            string document = Query.AllO365SubscriptionsAppTypeCounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllO365SubscriptionsAppTypeCounts");
            var parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllO365SubscriptionsAppTypeCounts" + parameters + "{" + document + "}",
                OperationName = "QueryAllO365SubscriptionsAppTypeCounts",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            var result = this._rbkClient.Invoke(
                request, vars, "List<O365SubscriptionAppTypeCounts>", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365StorageStats(orgID: UUID): GetO365StorageStatsResp!
        protected void InvokeQueryO365StorageStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            GetO365StorageStatsResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GetO365StorageStatsResp)psObject.BaseObject;
                } else {
                    fields = (GetO365StorageStatsResp)this.Field;
                }
            }
            string document = Query.O365StorageStats(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365StorageStats");
            var parameters = "($orgID: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365StorageStats" + parameters + "{" + document + "}",
                OperationName = "QueryO365StorageStats",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GetO365StorageStatsResp", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // o365ServiceStatus(orgID: UUID): GetO365ServiceStatusResp!
        protected void InvokeQueryO365ServiceStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            GetO365ServiceStatusResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (GetO365ServiceStatusResp)psObject.BaseObject;
                } else {
                    fields = (GetO365ServiceStatusResp)this.Field;
                }
            }
            string document = Query.O365ServiceStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365ServiceStatus");
            var parameters = "($orgID: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365ServiceStatus" + parameters + "{" + document + "}",
                OperationName = "QueryO365ServiceStatus",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "GetO365ServiceStatusResp", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryO365
}