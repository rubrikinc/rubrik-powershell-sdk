// Query-RscO365.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:44.
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
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Query",
        "RscO365",
        DefaultParameterSetName = "Org")
    ]
    public class Query_RscO365 : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Org parameter set
        //
        // GraphQL operation: o365Org(fid: UUID!):O365Org!
        //
        [Parameter(
            ParameterSetName = "Org",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Org(fid: UUID!):O365Org!",
            Position = 0
        )]
        public SwitchParameter Org { get; set; }

        [Parameter(
            ParameterSetName = "Org",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // OrgAtSnappableLevel parameter set
        //
        // GraphQL operation: o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!):O365Org!
        //
        [Parameter(
            ParameterSetName = "OrgAtSnappableLevel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365OrgAtSnappableLevel(fid: UUID!, snappableType: SnappableType!):O365Org!",
            Position = 0
        )]
        public SwitchParameter OrgAtSnappableLevel { get; set; }

        [Parameter(
            ParameterSetName = "OrgAtSnappableLevel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument snappableType: SnappableType!"
        )]
        public SnappableType? SnappableType { get; set; }
        
        // -------------------------------------------------------------------
        // allAdGroup parameter set
        //
        // GraphQL operation: allO365AdGroups(orgId: UUID!, adGroupSearchFilter: String!):[AdGroup!]!
        //
        [Parameter(
            ParameterSetName = "allAdGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allO365AdGroups(orgId: UUID!, adGroupSearchFilter: String!):[AdGroup!]!",
            Position = 0
        )]
        public SwitchParameter allAdGroup { get; set; }

        [Parameter(
            ParameterSetName = "allAdGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument orgId: UUID!"
        )]
        public System.String? OrgId { get; set; }
        [Parameter(
            ParameterSetName = "allAdGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument adGroupSearchFilter: String!"
        )]
        public System.String? AdGroupSearchFilter { get; set; }
        
        // -------------------------------------------------------------------
        // User parameter set
        //
        // GraphQL operation: o365User(fid: UUID!):O365User!
        //
        [Parameter(
            ParameterSetName = "User",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365User(fid: UUID!):O365User!",
            Position = 0
        )]
        public SwitchParameter User { get; set; }

        
        // -------------------------------------------------------------------
        // Mailbox parameter set
        //
        // GraphQL operation: o365Mailbox(snappableFid: UUID!):O365Mailbox!
        //
        [Parameter(
            ParameterSetName = "Mailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Mailbox(snappableFid: UUID!):O365Mailbox!",
            Position = 0
        )]
        public SwitchParameter Mailbox { get; set; }

        [Parameter(
            ParameterSetName = "Mailbox",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument snappableFid: UUID!"
        )]
        public System.String? SnappableFid { get; set; }
        
        // -------------------------------------------------------------------
        // Group parameter set
        //
        // GraphQL operation: o365Groups(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   o365OrgId: UUID!,   snappableType: SnappableType!, ):O365GroupConnection!
        //
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Groups(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   o365OrgId: UUID!,   snappableType: SnappableType!, ):O365GroupConnection!",
            Position = 0
        )]
        public SwitchParameter Group { get; set; }

        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        [Parameter(
            ParameterSetName = "Group",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument o365OrgId: UUID!"
        )]
        public System.String? O365OrgId { get; set; }
        
        // -------------------------------------------------------------------
        // Mailboxe parameter set
        //
        // GraphQL operation: o365Mailboxes(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   o365OrgId: UUID!, ):O365MailboxConnection!
        //
        [Parameter(
            ParameterSetName = "Mailboxe",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Mailboxes(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   o365OrgId: UUID!, ):O365MailboxConnection!",
            Position = 0
        )]
        public SwitchParameter Mailboxe { get; set; }

        
        // -------------------------------------------------------------------
        // Onedrive parameter set
        //
        // GraphQL operation: o365Onedrive(snappableFid: UUID!):O365Onedrive!
        //
        [Parameter(
            ParameterSetName = "Onedrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Onedrive(snappableFid: UUID!):O365Onedrive!",
            Position = 0
        )]
        public SwitchParameter Onedrive { get; set; }

        
        // -------------------------------------------------------------------
        // Site parameter set
        //
        // GraphQL operation: o365Site(snappableFid: UUID!):O365Site!
        //
        [Parameter(
            ParameterSetName = "Site",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Site(snappableFid: UUID!):O365Site!",
            Position = 0
        )]
        public SwitchParameter Site { get; set; }

        
        // -------------------------------------------------------------------
        // SharepointDrive parameter set
        //
        // GraphQL operation: o365SharepointDrive(snappableFid: UUID!):O365SharepointDrive!
        //
        [Parameter(
            ParameterSetName = "SharepointDrive",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365SharepointDrive(snappableFid: UUID!):O365SharepointDrive!",
            Position = 0
        )]
        public SwitchParameter SharepointDrive { get; set; }

        
        // -------------------------------------------------------------------
        // SharepointList parameter set
        //
        // GraphQL operation: o365SharepointList(snappableFid: UUID!):O365SharepointList!
        //
        [Parameter(
            ParameterSetName = "SharepointList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365SharepointList(snappableFid: UUID!):O365SharepointList!",
            Position = 0
        )]
        public SwitchParameter SharepointList { get; set; }

        
        // -------------------------------------------------------------------
        // SharepointSite parameter set
        //
        // GraphQL operation: o365SharepointSite(siteFid: UUID!):O365Site!
        //
        [Parameter(
            ParameterSetName = "SharepointSite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365SharepointSite(siteFid: UUID!):O365Site!",
            Position = 0
        )]
        public SwitchParameter SharepointSite { get; set; }

        [Parameter(
            ParameterSetName = "SharepointSite",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument siteFid: UUID!"
        )]
        public System.String? SiteFid { get; set; }
        
        // -------------------------------------------------------------------
        // Team parameter set
        //
        // GraphQL operation: o365Team(snappableFid: UUID!):O365Teams!
        //
        [Parameter(
            ParameterSetName = "Team",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Team(snappableFid: UUID!):O365Teams!",
            Position = 0
        )]
        public SwitchParameter Team { get; set; }

        
        // -------------------------------------------------------------------
        // TeamChannel parameter set
        //
        // GraphQL operation: o365TeamChannels(,   first: Int,   after: String,   snappableFid: UUID!,   excludeArchived: Boolean!,   channelMembershipTypeFilter: ChannelMembershipType!,   nameFilter: String, ):O365TeamsChannelConnection!
        //
        [Parameter(
            ParameterSetName = "TeamChannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365TeamChannels(,   first: Int,   after: String,   snappableFid: UUID!,   excludeArchived: Boolean!,   channelMembershipTypeFilter: ChannelMembershipType!,   nameFilter: String, ):O365TeamsChannelConnection!",
            Position = 0
        )]
        public SwitchParameter TeamChannel { get; set; }

        [Parameter(
            ParameterSetName = "TeamChannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument excludeArchived: Boolean!"
        )]
        public System.Boolean? ExcludeArchived { get; set; }
        [Parameter(
            ParameterSetName = "TeamChannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument channelMembershipTypeFilter: ChannelMembershipType!"
        )]
        public ChannelMembershipType? ChannelMembershipTypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "TeamChannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument nameFilter: String"
        )]
        public System.String? NameFilter { get; set; }
        
        // -------------------------------------------------------------------
        // TeamConversationsFolderID parameter set
        //
        // GraphQL operation: o365TeamConversationsFolderID(snappableFid: UUID!, snapshotFid: UUID!, o365OrgId: UUID!):String!
        //
        [Parameter(
            ParameterSetName = "TeamConversationsFolderID",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365TeamConversationsFolderID(snappableFid: UUID!, snapshotFid: UUID!, o365OrgId: UUID!):String!",
            Position = 0
        )]
        public SwitchParameter TeamConversationsFolderID { get; set; }

        [Parameter(
            ParameterSetName = "TeamConversationsFolderID",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument snapshotFid: UUID!"
        )]
        public System.String? SnapshotFid { get; set; }
        
        // -------------------------------------------------------------------
        // TeamPostedBy parameter set
        //
        // GraphQL operation: o365TeamPostedBy(,   first: Int,   after: String,   snappableFid: UUID!,   o365OrgId: UUID!,   nameFilter: String, ):O365TeamConversationsSenderConnection!
        //
        [Parameter(
            ParameterSetName = "TeamPostedBy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365TeamPostedBy(,   first: Int,   after: String,   snappableFid: UUID!,   o365OrgId: UUID!,   nameFilter: String, ):O365TeamConversationsSenderConnection!",
            Position = 0
        )]
        public SwitchParameter TeamPostedBy { get; set; }

        
        // -------------------------------------------------------------------
        // Calendar parameter set
        //
        // GraphQL operation: o365Calendar(snappableFid: UUID!):O365Calendar!
        //
        [Parameter(
            ParameterSetName = "Calendar",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365Calendar(snappableFid: UUID!):O365Calendar!",
            Position = 0
        )]
        public SwitchParameter Calendar { get; set; }

        
        // -------------------------------------------------------------------
        // SharepointObjectList parameter set
        //
        // GraphQL operation: o365SharepointObjectList(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   objectTypeFilter: [String!],   includeEntireHierarchy: Boolean!,   fid: UUID!, ):O365SharepointObjectConnection!
        //
        [Parameter(
            ParameterSetName = "SharepointObjectList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365SharepointObjectList(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   objectTypeFilter: [String!],   includeEntireHierarchy: Boolean!,   fid: UUID!, ):O365SharepointObjectConnection!",
            Position = 0
        )]
        public SwitchParameter SharepointObjectList { get; set; }

        [Parameter(
            ParameterSetName = "SharepointObjectList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument objectTypeFilter: [String!]"
        )]
        public List<System.String>? ObjectTypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "SharepointObjectList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument includeEntireHierarchy: Boolean!"
        )]
        public System.Boolean? IncludeEntireHierarchy { get; set; }
        
        // -------------------------------------------------------------------
        // SharepointObject parameter set
        //
        // GraphQL operation: o365SharepointObjects(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   fid: UUID!, ):O365SharepointObjectConnection!
        //
        [Parameter(
            ParameterSetName = "SharepointObject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365SharepointObjects(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   fid: UUID!, ):O365SharepointObjectConnection!",
            Position = 0
        )]
        public SwitchParameter SharepointObject { get; set; }

        
        // -------------------------------------------------------------------
        // UserObject parameter set
        //
        // GraphQL operation: o365UserObjects(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   fid: UUID!, ):O365UserDescendantMetadataConnection!
        //
        [Parameter(
            ParameterSetName = "UserObject",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365UserObjects(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!],   fid: UUID!, ):O365UserDescendantMetadataConnection!",
            Position = 0
        )]
        public SwitchParameter UserObject { get; set; }

        
        // -------------------------------------------------------------------
        // OrgSummarie parameter set
        //
        // GraphQL operation: o365OrgSummaries:GetImplicitlyAuthorizedObjectSummariesResponse!
        //
        [Parameter(
            ParameterSetName = "OrgSummarie",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365OrgSummaries:GetImplicitlyAuthorizedObjectSummariesResponse!",
            Position = 0
        )]
        public SwitchParameter OrgSummarie { get; set; }

        
        // -------------------------------------------------------------------
        // ObjectAncestor parameter set
        //
        // GraphQL operation: o365ObjectAncestors(snappableFid: UUID!):GetImplicitlyAuthorizedAncestorSummariesResponse!
        //
        [Parameter(
            ParameterSetName = "ObjectAncestor",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365ObjectAncestors(snappableFid: UUID!):GetImplicitlyAuthorizedAncestorSummariesResponse!",
            Position = 0
        )]
        public SwitchParameter ObjectAncestor { get; set; }

        
        // -------------------------------------------------------------------
        // browseTeamConvChannel parameter set
        //
        // GraphQL operation: browseO365TeamConvChannels(,   first: Int,   after: String,   snappableFid: UUID!,   snapshotFidOpt: UUID,   excludeArchived: Boolean!,   orgId: UUID!,   channelMembershipTypeFilter: ChannelMembershipType!,   nameFilter: String, ):O365TeamConvChannelConnection!
        //
        [Parameter(
            ParameterSetName = "browseTeamConvChannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: browseO365TeamConvChannels(,   first: Int,   after: String,   snappableFid: UUID!,   snapshotFidOpt: UUID,   excludeArchived: Boolean!,   orgId: UUID!,   channelMembershipTypeFilter: ChannelMembershipType!,   nameFilter: String, ):O365TeamConvChannelConnection!",
            Position = 0
        )]
        public SwitchParameter browseTeamConvChannel { get; set; }

        [Parameter(
            ParameterSetName = "browseTeamConvChannel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument snapshotFidOpt: UUID"
        )]
        public System.String? SnapshotFidOpt { get; set; }
        
        // -------------------------------------------------------------------
        // ServiceAccount parameter set
        //
        // GraphQL operation: o365ServiceAccount(orgId: UUID!):O365ServiceAccountStatusResp!
        //
        [Parameter(
            ParameterSetName = "ServiceAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365ServiceAccount(orgId: UUID!):O365ServiceAccountStatusResp!",
            Position = 0
        )]
        public SwitchParameter ServiceAccount { get; set; }

        
        // -------------------------------------------------------------------
        // allOrgStatus parameter set
        //
        // GraphQL operation: allO365OrgStatuses:[O365OrgInfo!]!
        //
        [Parameter(
            ParameterSetName = "allOrgStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allO365OrgStatuses:[O365OrgInfo!]!",
            Position = 0
        )]
        public SwitchParameter allOrgStatus { get; set; }

        
        // -------------------------------------------------------------------
        // License parameter set
        //
        // GraphQL operation: o365License:O365License!
        //
        [Parameter(
            ParameterSetName = "License",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365License:O365License!",
            Position = 0
        )]
        public SwitchParameter License { get; set; }

        
        // -------------------------------------------------------------------
        // azureExocompute parameter set
        //
        // GraphQL operation: azureO365Exocompute(orgId: UUID!, exocomputeClusterId: String!):GetAzureO365ExocomputeResp!
        //
        [Parameter(
            ParameterSetName = "azureExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365Exocompute(orgId: UUID!, exocomputeClusterId: String!):GetAzureO365ExocomputeResp!",
            Position = 0
        )]
        public SwitchParameter azureExocompute { get; set; }

        [Parameter(
            ParameterSetName = "azureExocompute",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument exocomputeClusterId: String!"
        )]
        public System.String? ExocomputeClusterId { get; set; }
        
        // -------------------------------------------------------------------
        // azureCheckStorageAccountName parameter set
        //
        // GraphQL operation: azureO365CheckStorageAccountName(tenantId: String!, subscriptionId: UUID!, storage_account_name: String!):AzureResourceAvailabilityResp!
        //
        [Parameter(
            ParameterSetName = "azureCheckStorageAccountName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365CheckStorageAccountName(tenantId: String!, subscriptionId: UUID!, storage_account_name: String!):AzureResourceAvailabilityResp!",
            Position = 0
        )]
        public SwitchParameter azureCheckStorageAccountName { get; set; }

        [Parameter(
            ParameterSetName = "azureCheckStorageAccountName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument tenantId: String!"
        )]
        public System.String? TenantId { get; set; }
        [Parameter(
            ParameterSetName = "azureCheckStorageAccountName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subscriptionId: UUID!"
        )]
        public System.String? SubscriptionId { get; set; }
        [Parameter(
            ParameterSetName = "azureCheckStorageAccountName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument storage_account_name: String!"
        )]
        public System.String? StorageAccountName { get; set; }
        
        // -------------------------------------------------------------------
        // azureCheckStorageAccountAccessibility parameter set
        //
        // GraphQL operation: azureO365CheckStorageAccountAccessibility(,   tenantId: String!,   subscriptionId: UUID!,   storage_account_name: String!,   groupName: String!, ):AzureResourceAvailabilityResp!
        //
        [Parameter(
            ParameterSetName = "azureCheckStorageAccountAccessibility",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365CheckStorageAccountAccessibility(,   tenantId: String!,   subscriptionId: UUID!,   storage_account_name: String!,   groupName: String!, ):AzureResourceAvailabilityResp!",
            Position = 0
        )]
        public SwitchParameter azureCheckStorageAccountAccessibility { get; set; }

        [Parameter(
            ParameterSetName = "azureCheckStorageAccountAccessibility",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument groupName: String!"
        )]
        public System.String? GroupName { get; set; }
        
        // -------------------------------------------------------------------
        // azureCheckSubscriptionQuota parameter set
        //
        // GraphQL operation: azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!):AzureResourceAvailabilityResp!
        //
        [Parameter(
            ParameterSetName = "azureCheckSubscriptionQuota",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!):AzureResourceAvailabilityResp!",
            Position = 0
        )]
        public SwitchParameter azureCheckSubscriptionQuota { get; set; }

        [Parameter(
            ParameterSetName = "azureCheckSubscriptionQuota",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument regionName: String!"
        )]
        public System.String? RegionName { get; set; }
        
        // -------------------------------------------------------------------
        // azureCheckResourceGroupName parameter set
        //
        // GraphQL operation: azureO365CheckResourceGroupName(tenantId: String!, subscriptionId: UUID!, groupName: String!):AzureResourceAvailabilityResp!
        //
        [Parameter(
            ParameterSetName = "azureCheckResourceGroupName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365CheckResourceGroupName(tenantId: String!, subscriptionId: UUID!, groupName: String!):AzureResourceAvailabilityResp!",
            Position = 0
        )]
        public SwitchParameter azureCheckResourceGroupName { get; set; }

        
        // -------------------------------------------------------------------
        // azureCheckVirtualNetworkName parameter set
        //
        // GraphQL operation: azureO365CheckVirtualNetworkName(,   tenantId: String!,   subscriptionId: UUID!,   groupName: String!,   vnet_name: String!, ):AzureResourceAvailabilityResp!
        //
        [Parameter(
            ParameterSetName = "azureCheckVirtualNetworkName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365CheckVirtualNetworkName(,   tenantId: String!,   subscriptionId: UUID!,   groupName: String!,   vnet_name: String!, ):AzureResourceAvailabilityResp!",
            Position = 0
        )]
        public SwitchParameter azureCheckVirtualNetworkName { get; set; }

        [Parameter(
            ParameterSetName = "azureCheckVirtualNetworkName",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument vnet_name: String!"
        )]
        public System.String? VnetName { get; set; }
        
        // -------------------------------------------------------------------
        // azureValidateUserRole parameter set
        //
        // GraphQL operation: azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!):AzureUserRoleResp!
        //
        [Parameter(
            ParameterSetName = "azureValidateUserRole",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!):AzureUserRoleResp!",
            Position = 0
        )]
        public SwitchParameter azureValidateUserRole { get; set; }

        
        // -------------------------------------------------------------------
        // azureCheckNSGOutboundRule parameter set
        //
        // GraphQL operation: azureO365CheckNSGOutboundRules(,   tenantId: String!,   subscriptionId: UUID!,   resourceGroupName: String!,   vnet_name: String!,   subnet_name: String!, ):AzureNetworkSecurityGroupResp!
        //
        [Parameter(
            ParameterSetName = "azureCheckNSGOutboundRule",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365CheckNSGOutboundRules(,   tenantId: String!,   subscriptionId: UUID!,   resourceGroupName: String!,   vnet_name: String!,   subnet_name: String!, ):AzureNetworkSecurityGroupResp!",
            Position = 0
        )]
        public SwitchParameter azureCheckNSGOutboundRule { get; set; }

        [Parameter(
            ParameterSetName = "azureCheckNSGOutboundRule",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument resourceGroupName: String!"
        )]
        public System.String? ResourceGroupName { get; set; }
        [Parameter(
            ParameterSetName = "azureCheckNSGOutboundRule",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument subnet_name: String!"
        )]
        public System.String? SubnetName { get; set; }
        
        // -------------------------------------------------------------------
        // azureCheckNetworkSubnet parameter set
        //
        // GraphQL operation: azureO365CheckNetworkSubnet(,   tenantId: String!,   subscriptionId: UUID!,   resourceGroupName: String!,   vnet_name: String!,   subnet_name: String!,   strict_addr_check: Boolean!, ):AzureNetworkSubnetResp!
        //
        [Parameter(
            ParameterSetName = "azureCheckNetworkSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365CheckNetworkSubnet(,   tenantId: String!,   subscriptionId: UUID!,   resourceGroupName: String!,   vnet_name: String!,   subnet_name: String!,   strict_addr_check: Boolean!, ):AzureNetworkSubnetResp!",
            Position = 0
        )]
        public SwitchParameter azureCheckNetworkSubnet { get; set; }

        [Parameter(
            ParameterSetName = "azureCheckNetworkSubnet",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument strict_addr_check: Boolean!"
        )]
        public System.Boolean? StrictAddrCheck { get; set; }
        
        // -------------------------------------------------------------------
        // azureGetNetworkSubnetUnusedAddr parameter set
        //
        // GraphQL operation: azureO365GetNetworkSubnetUnusedAddr(,   tenantId: String!,   subscriptionId: UUID!,   resourceGroupName: String!,   vnet_name: String!,   subnet_name: String!,   strict_addr_check: Boolean!, ):AzureNetworkSubnetUnusedAddrResp!
        //
        [Parameter(
            ParameterSetName = "azureGetNetworkSubnetUnusedAddr",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365GetNetworkSubnetUnusedAddr(,   tenantId: String!,   subscriptionId: UUID!,   resourceGroupName: String!,   vnet_name: String!,   subnet_name: String!,   strict_addr_check: Boolean!, ):AzureNetworkSubnetUnusedAddrResp!",
            Position = 0
        )]
        public SwitchParameter azureGetNetworkSubnetUnusedAddr { get; set; }

        
        // -------------------------------------------------------------------
        // azureGetAzureHostType parameter set
        //
        // GraphQL operation: azureO365GetAzureHostType:GetAzureHostTypeResp!
        //
        [Parameter(
            ParameterSetName = "azureGetAzureHostType",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureO365GetAzureHostType:GetAzureHostTypeResp!",
            Position = 0
        )]
        public SwitchParameter azureGetAzureHostType { get; set; }

        
        // -------------------------------------------------------------------
        // listApp parameter set
        //
        // GraphQL operation: listO365Apps(,   first: Int,   after: String,   o365AppFilters: [AppFilter!]!,   o365AppSortByParam: AppSortByParam, ):O365AppConnection!
        //
        [Parameter(
            ParameterSetName = "listApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: listO365Apps(,   first: Int,   after: String,   o365AppFilters: [AppFilter!]!,   o365AppSortByParam: AppSortByParam, ):O365AppConnection!",
            Position = 0
        )]
        public SwitchParameter listApp { get; set; }

        [Parameter(
            ParameterSetName = "listApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument o365AppFilters: [AppFilter!]!"
        )]
        public List<AppFilter>? O365AppFilters { get; set; }
        [Parameter(
            ParameterSetName = "listApp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument o365AppSortByParam: AppSortByParam"
        )]
        public AppSortByParam? O365AppSortByParam { get; set; }
        
        // -------------------------------------------------------------------
        // allSubscriptionsAppTypeCount parameter set
        //
        // GraphQL operation: allO365SubscriptionsAppTypeCounts:[O365SubscriptionAppTypeCounts!]!
        //
        [Parameter(
            ParameterSetName = "allSubscriptionsAppTypeCount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allO365SubscriptionsAppTypeCounts:[O365SubscriptionAppTypeCounts!]!",
            Position = 0
        )]
        public SwitchParameter allSubscriptionsAppTypeCount { get; set; }

        
        // -------------------------------------------------------------------
        // StorageStat parameter set
        //
        // GraphQL operation: o365StorageStats(orgID: UUID):GetO365StorageStatsResp!
        //
        [Parameter(
            ParameterSetName = "StorageStat",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365StorageStats(orgID: UUID):GetO365StorageStatsResp!",
            Position = 0
        )]
        public SwitchParameter StorageStat { get; set; }

        
        // -------------------------------------------------------------------
        // ServiceStatus parameter set
        //
        // GraphQL operation: o365ServiceStatus(orgID: UUID):GetO365ServiceStatusResp!
        //
        [Parameter(
            ParameterSetName = "ServiceStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: o365ServiceStatus(orgID: UUID):GetO365ServiceStatusResp!",
            Position = 0
        )]
        public SwitchParameter ServiceStatus { get; set; }


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
                    case "allAdGroup":
                        this.ProcessRecord_allAdGroup();
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
                    case "SharepointDrive":
                        this.ProcessRecord_SharepointDrive();
                        break;
                    case "SharepointList":
                        this.ProcessRecord_SharepointList();
                        break;
                    case "SharepointSite":
                        this.ProcessRecord_SharepointSite();
                        break;
                    case "Team":
                        this.ProcessRecord_Team();
                        break;
                    case "TeamChannel":
                        this.ProcessRecord_TeamChannel();
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
                    case "SharepointObjectList":
                        this.ProcessRecord_SharepointObjectList();
                        break;
                    case "SharepointObject":
                        this.ProcessRecord_SharepointObject();
                        break;
                    case "UserObject":
                        this.ProcessRecord_UserObject();
                        break;
                    case "OrgSummarie":
                        this.ProcessRecord_OrgSummarie();
                        break;
                    case "ObjectAncestor":
                        this.ProcessRecord_ObjectAncestor();
                        break;
                    case "browseTeamConvChannel":
                        this.ProcessRecord_browseTeamConvChannel();
                        break;
                    case "ServiceAccount":
                        this.ProcessRecord_ServiceAccount();
                        break;
                    case "allOrgStatus":
                        this.ProcessRecord_allOrgStatus();
                        break;
                    case "License":
                        this.ProcessRecord_License();
                        break;
                    case "azureExocompute":
                        this.ProcessRecord_azureExocompute();
                        break;
                    case "azureCheckStorageAccountName":
                        this.ProcessRecord_azureCheckStorageAccountName();
                        break;
                    case "azureCheckStorageAccountAccessibility":
                        this.ProcessRecord_azureCheckStorageAccountAccessibility();
                        break;
                    case "azureCheckSubscriptionQuota":
                        this.ProcessRecord_azureCheckSubscriptionQuota();
                        break;
                    case "azureCheckResourceGroupName":
                        this.ProcessRecord_azureCheckResourceGroupName();
                        break;
                    case "azureCheckVirtualNetworkName":
                        this.ProcessRecord_azureCheckVirtualNetworkName();
                        break;
                    case "azureValidateUserRole":
                        this.ProcessRecord_azureValidateUserRole();
                        break;
                    case "azureCheckNSGOutboundRule":
                        this.ProcessRecord_azureCheckNSGOutboundRule();
                        break;
                    case "azureCheckNetworkSubnet":
                        this.ProcessRecord_azureCheckNetworkSubnet();
                        break;
                    case "azureGetNetworkSubnetUnusedAddr":
                        this.ProcessRecord_azureGetNetworkSubnetUnusedAddr();
                        break;
                    case "azureGetAzureHostType":
                        this.ProcessRecord_azureGetAzureHostType();
                        break;
                    case "listApp":
                        this.ProcessRecord_listApp();
                        break;
                    case "allSubscriptionsAppTypeCount":
                        this.ProcessRecord_allSubscriptionsAppTypeCount();
                        break;
                    case "StorageStat":
                        this.ProcessRecord_StorageStat();
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
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Query-RscO365",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
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
        protected void ProcessRecord_OrgAtSnappableLevel()
        {
            this._logger.name += " -OrgAtSnappableLevel";
            // Invoke graphql operation o365OrgAtSnappableLevel
            InvokeQueryO365OrgAtSnappableLevel();
        }

        // This parameter set invokes a single graphql operation:
        // allO365AdGroups.
        protected void ProcessRecord_allAdGroup()
        {
            this._logger.name += " -allAdGroup";
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
        protected void ProcessRecord_SharepointDrive()
        {
            this._logger.name += " -SharepointDrive";
            // Invoke graphql operation o365SharepointDrive
            InvokeQueryO365SharepointDrive();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointList.
        protected void ProcessRecord_SharepointList()
        {
            this._logger.name += " -SharepointList";
            // Invoke graphql operation o365SharepointList
            InvokeQueryO365SharepointList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointSite.
        protected void ProcessRecord_SharepointSite()
        {
            this._logger.name += " -SharepointSite";
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
        protected void ProcessRecord_TeamChannel()
        {
            this._logger.name += " -TeamChannel";
            // Invoke graphql operation o365TeamChannels
            InvokeQueryO365TeamChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamConversationsFolderID.
        protected void ProcessRecord_TeamConversationsFolderID()
        {
            this._logger.name += " -TeamConversationsFolderID";
            // Invoke graphql operation o365TeamConversationsFolderID
            InvokeQueryO365TeamConversationsFolderId();
        }

        // This parameter set invokes a single graphql operation:
        // o365TeamPostedBy.
        protected void ProcessRecord_TeamPostedBy()
        {
            this._logger.name += " -TeamPostedBy";
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
        protected void ProcessRecord_SharepointObjectList()
        {
            this._logger.name += " -SharepointObjectList";
            // Invoke graphql operation o365SharepointObjectList
            InvokeQueryO365SharepointObjectList();
        }

        // This parameter set invokes a single graphql operation:
        // o365SharepointObjects.
        protected void ProcessRecord_SharepointObject()
        {
            this._logger.name += " -SharepointObject";
            // Invoke graphql operation o365SharepointObjects
            InvokeQueryO365SharepointObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365UserObjects.
        protected void ProcessRecord_UserObject()
        {
            this._logger.name += " -UserObject";
            // Invoke graphql operation o365UserObjects
            InvokeQueryO365UserObjects();
        }

        // This parameter set invokes a single graphql operation:
        // o365OrgSummaries.
        protected void ProcessRecord_OrgSummarie()
        {
            this._logger.name += " -OrgSummarie";
            // Invoke graphql operation o365OrgSummaries
            InvokeQueryO365OrgSummaries();
        }

        // This parameter set invokes a single graphql operation:
        // o365ObjectAncestors.
        protected void ProcessRecord_ObjectAncestor()
        {
            this._logger.name += " -ObjectAncestor";
            // Invoke graphql operation o365ObjectAncestors
            InvokeQueryO365ObjectAncestors();
        }

        // This parameter set invokes a single graphql operation:
        // browseO365TeamConvChannels.
        protected void ProcessRecord_browseTeamConvChannel()
        {
            this._logger.name += " -browseTeamConvChannel";
            // Invoke graphql operation browseO365TeamConvChannels
            InvokeQueryBrowseO365TeamConvChannels();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceAccount.
        protected void ProcessRecord_ServiceAccount()
        {
            this._logger.name += " -ServiceAccount";
            // Invoke graphql operation o365ServiceAccount
            InvokeQueryO365ServiceAccount();
        }

        // This parameter set invokes a single graphql operation:
        // allO365OrgStatuses.
        protected void ProcessRecord_allOrgStatus()
        {
            this._logger.name += " -allOrgStatus";
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
        // azureO365Exocompute.
        protected void ProcessRecord_azureExocompute()
        {
            this._logger.name += " -azureExocompute";
            // Invoke graphql operation azureO365Exocompute
            InvokeQueryAzureO365Exocompute();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountName.
        protected void ProcessRecord_azureCheckStorageAccountName()
        {
            this._logger.name += " -azureCheckStorageAccountName";
            // Invoke graphql operation azureO365CheckStorageAccountName
            InvokeQueryAzureO365CheckStorageAccountName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckStorageAccountAccessibility.
        protected void ProcessRecord_azureCheckStorageAccountAccessibility()
        {
            this._logger.name += " -azureCheckStorageAccountAccessibility";
            // Invoke graphql operation azureO365CheckStorageAccountAccessibility
            InvokeQueryAzureO365CheckStorageAccountAccessibility();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckSubscriptionQuota.
        protected void ProcessRecord_azureCheckSubscriptionQuota()
        {
            this._logger.name += " -azureCheckSubscriptionQuota";
            // Invoke graphql operation azureO365CheckSubscriptionQuota
            InvokeQueryAzureO365CheckSubscriptionQuota();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckResourceGroupName.
        protected void ProcessRecord_azureCheckResourceGroupName()
        {
            this._logger.name += " -azureCheckResourceGroupName";
            // Invoke graphql operation azureO365CheckResourceGroupName
            InvokeQueryAzureO365CheckResourceGroupName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckVirtualNetworkName.
        protected void ProcessRecord_azureCheckVirtualNetworkName()
        {
            this._logger.name += " -azureCheckVirtualNetworkName";
            // Invoke graphql operation azureO365CheckVirtualNetworkName
            InvokeQueryAzureO365CheckVirtualNetworkName();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365ValidateUserRoles.
        protected void ProcessRecord_azureValidateUserRole()
        {
            this._logger.name += " -azureValidateUserRole";
            // Invoke graphql operation azureO365ValidateUserRoles
            InvokeQueryAzureO365ValidateUserRoles();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNSGOutboundRules.
        protected void ProcessRecord_azureCheckNSGOutboundRule()
        {
            this._logger.name += " -azureCheckNSGOutboundRule";
            // Invoke graphql operation azureO365CheckNSGOutboundRules
            InvokeQueryAzureO365CheckNsgOutboundRules();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365CheckNetworkSubnet.
        protected void ProcessRecord_azureCheckNetworkSubnet()
        {
            this._logger.name += " -azureCheckNetworkSubnet";
            // Invoke graphql operation azureO365CheckNetworkSubnet
            InvokeQueryAzureO365CheckNetworkSubnet();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetNetworkSubnetUnusedAddr.
        protected void ProcessRecord_azureGetNetworkSubnetUnusedAddr()
        {
            this._logger.name += " -azureGetNetworkSubnetUnusedAddr";
            // Invoke graphql operation azureO365GetNetworkSubnetUnusedAddr
            InvokeQueryAzureO365GetNetworkSubnetUnusedAddr();
        }

        // This parameter set invokes a single graphql operation:
        // azureO365GetAzureHostType.
        protected void ProcessRecord_azureGetAzureHostType()
        {
            this._logger.name += " -azureGetAzureHostType";
            // Invoke graphql operation azureO365GetAzureHostType
            InvokeQueryAzureO365GetAzureHostType();
        }

        // This parameter set invokes a single graphql operation:
        // listO365Apps.
        protected void ProcessRecord_listApp()
        {
            this._logger.name += " -listApp";
            // Invoke graphql operation listO365Apps
            InvokeQueryListO365Apps();
        }

        // This parameter set invokes a single graphql operation:
        // allO365SubscriptionsAppTypeCounts.
        protected void ProcessRecord_allSubscriptionsAppTypeCount()
        {
            this._logger.name += " -allSubscriptionsAppTypeCount";
            // Invoke graphql operation allO365SubscriptionsAppTypeCounts
            InvokeQueryAllO365SubscriptionsAppTypeCounts();
        }

        // This parameter set invokes a single graphql operation:
        // o365StorageStats.
        protected void ProcessRecord_StorageStat()
        {
            this._logger.name += " -StorageStat";
            // Invoke graphql operation o365StorageStats
            InvokeQueryO365StorageStats();
        }

        // This parameter set invokes a single graphql operation:
        // o365ServiceStatus.
        protected void ProcessRecord_ServiceStatus()
        {
            this._logger.name += " -ServiceStatus";
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Org)psObject.BaseObject;
                } else {
                    fields = (O365Org)this.Field;
                }
            }
            string document = Query.O365Org(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Org");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Org" + parameters + "{" + document + "}",
                OperationName = "QueryO365Org",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Org> task = this._rbkClient.InvokeGenericCallAsync<O365Org>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Org)psObject.BaseObject;
                } else {
                    fields = (O365Org)this.Field;
                }
            }
            string document = Query.O365OrgAtSnappableLevel(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365OrgAtSnappableLevel");
            string parameters = "($fid: UUID!,$snappableType: SnappableType!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365OrgAtSnappableLevel" + parameters + "{" + document + "}",
                OperationName = "QueryO365OrgAtSnappableLevel",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Org> task = this._rbkClient.InvokeGenericCallAsync<O365Org>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<AdGroup>)psObject.BaseObject;
                } else {
                    fields = (List<AdGroup>)this.Field;
                }
            }
            string document = Query.AllO365AdGroups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllO365AdGroups");
            string parameters = "($orgId: UUID!,$adGroupSearchFilter: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllO365AdGroups" + parameters + "{" + document + "}",
                OperationName = "QueryAllO365AdGroups",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<AdGroup>> task = this._rbkClient.InvokeGenericCallAsync<List<AdGroup>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365User)psObject.BaseObject;
                } else {
                    fields = (O365User)this.Field;
                }
            }
            string document = Query.O365User(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365User");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365User" + parameters + "{" + document + "}",
                OperationName = "QueryO365User",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365User> task = this._rbkClient.InvokeGenericCallAsync<O365User>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Mailbox)psObject.BaseObject;
                } else {
                    fields = (O365Mailbox)this.Field;
                }
            }
            string document = Query.O365Mailbox(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Mailbox");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Mailbox" + parameters + "{" + document + "}",
                OperationName = "QueryO365Mailbox",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Mailbox> task = this._rbkClient.InvokeGenericCallAsync<O365Mailbox>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365GroupConnection)psObject.BaseObject;
                } else {
                    fields = (O365GroupConnection)this.Field;
                }
            }
            string document = Query.O365Groups(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Groups");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!,$snappableType: SnappableType!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Groups" + parameters + "{" + document + "}",
                OperationName = "QueryO365Groups",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365GroupConnection> task = this._rbkClient.InvokeGenericCallAsync<O365GroupConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365MailboxConnection)psObject.BaseObject;
                } else {
                    fields = (O365MailboxConnection)this.Field;
                }
            }
            string document = Query.O365Mailboxes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Mailboxes");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$o365OrgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Mailboxes" + parameters + "{" + document + "}",
                OperationName = "QueryO365Mailboxes",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365MailboxConnection> task = this._rbkClient.InvokeGenericCallAsync<O365MailboxConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Onedrive)psObject.BaseObject;
                } else {
                    fields = (O365Onedrive)this.Field;
                }
            }
            string document = Query.O365Onedrive(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Onedrive");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Onedrive" + parameters + "{" + document + "}",
                OperationName = "QueryO365Onedrive",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Onedrive> task = this._rbkClient.InvokeGenericCallAsync<O365Onedrive>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Site)psObject.BaseObject;
                } else {
                    fields = (O365Site)this.Field;
                }
            }
            string document = Query.O365Site(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Site");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Site" + parameters + "{" + document + "}",
                OperationName = "QueryO365Site",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Site> task = this._rbkClient.InvokeGenericCallAsync<O365Site>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365SharepointDrive)psObject.BaseObject;
                } else {
                    fields = (O365SharepointDrive)this.Field;
                }
            }
            string document = Query.O365SharepointDrive(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointDrive");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointDrive" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointDrive",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365SharepointDrive> task = this._rbkClient.InvokeGenericCallAsync<O365SharepointDrive>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365SharepointList)psObject.BaseObject;
                } else {
                    fields = (O365SharepointList)this.Field;
                }
            }
            string document = Query.O365SharepointList(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointList");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointList" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointList",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365SharepointList> task = this._rbkClient.InvokeGenericCallAsync<O365SharepointList>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Site)psObject.BaseObject;
                } else {
                    fields = (O365Site)this.Field;
                }
            }
            string document = Query.O365SharepointSite(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointSite");
            string parameters = "($siteFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointSite" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointSite",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Site> task = this._rbkClient.InvokeGenericCallAsync<O365Site>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Teams)psObject.BaseObject;
                } else {
                    fields = (O365Teams)this.Field;
                }
            }
            string document = Query.O365Team(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Team");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Team" + parameters + "{" + document + "}",
                OperationName = "QueryO365Team",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Teams> task = this._rbkClient.InvokeGenericCallAsync<O365Teams>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365TeamsChannelConnection)psObject.BaseObject;
                } else {
                    fields = (O365TeamsChannelConnection)this.Field;
                }
            }
            string document = Query.O365TeamChannels(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365TeamChannels");
            string parameters = "($first: Int,$after: String,$snappableFid: UUID!,$excludeArchived: Boolean!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365TeamChannels" + parameters + "{" + document + "}",
                OperationName = "QueryO365TeamChannels",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365TeamsChannelConnection> task = this._rbkClient.InvokeGenericCallAsync<O365TeamsChannelConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Query.O365TeamConversationsFolderId(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365TeamConversationsFolderId");
            string parameters = "($snappableFid: UUID!,$snapshotFid: UUID!,$o365OrgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365TeamConversationsFolderId" + parameters + "{" + document + "}",
                OperationName = "QueryO365TeamConversationsFolderId",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365TeamConversationsSenderConnection)psObject.BaseObject;
                } else {
                    fields = (O365TeamConversationsSenderConnection)this.Field;
                }
            }
            string document = Query.O365TeamPostedBy(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365TeamPostedBy");
            string parameters = "($first: Int,$after: String,$snappableFid: UUID!,$o365OrgId: UUID!,$nameFilter: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365TeamPostedBy" + parameters + "{" + document + "}",
                OperationName = "QueryO365TeamPostedBy",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365TeamConversationsSenderConnection> task = this._rbkClient.InvokeGenericCallAsync<O365TeamConversationsSenderConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365Calendar)psObject.BaseObject;
                } else {
                    fields = (O365Calendar)this.Field;
                }
            }
            string document = Query.O365Calendar(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365Calendar");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365Calendar" + parameters + "{" + document + "}",
                OperationName = "QueryO365Calendar",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365Calendar> task = this._rbkClient.InvokeGenericCallAsync<O365Calendar>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365SharepointObjectConnection)psObject.BaseObject;
                } else {
                    fields = (O365SharepointObjectConnection)this.Field;
                }
            }
            string document = Query.O365SharepointObjectList(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointObjectList");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$objectTypeFilter: [String!],$includeEntireHierarchy: Boolean!,$fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointObjectList" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointObjectList",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365SharepointObjectConnection> task = this._rbkClient.InvokeGenericCallAsync<O365SharepointObjectConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365SharepointObjectConnection)psObject.BaseObject;
                } else {
                    fields = (O365SharepointObjectConnection)this.Field;
                }
            }
            string document = Query.O365SharepointObjects(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365SharepointObjects");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365SharepointObjects" + parameters + "{" + document + "}",
                OperationName = "QueryO365SharepointObjects",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365SharepointObjectConnection> task = this._rbkClient.InvokeGenericCallAsync<O365SharepointObjectConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365UserDescendantMetadataConnection)psObject.BaseObject;
                } else {
                    fields = (O365UserDescendantMetadataConnection)this.Field;
                }
            }
            string document = Query.O365UserObjects(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365UserObjects");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!],$fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365UserObjects" + parameters + "{" + document + "}",
                OperationName = "QueryO365UserObjects",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365UserDescendantMetadataConnection> task = this._rbkClient.InvokeGenericCallAsync<O365UserDescendantMetadataConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GetImplicitlyAuthorizedObjectSummariesResponse)psObject.BaseObject;
                } else {
                    fields = (GetImplicitlyAuthorizedObjectSummariesResponse)this.Field;
                }
            }
            string document = Query.O365OrgSummaries(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365OrgSummaries");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365OrgSummaries" + parameters + "{" + document + "}",
                OperationName = "QueryO365OrgSummaries",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<GetImplicitlyAuthorizedObjectSummariesResponse> task = this._rbkClient.InvokeGenericCallAsync<GetImplicitlyAuthorizedObjectSummariesResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GetImplicitlyAuthorizedAncestorSummariesResponse)psObject.BaseObject;
                } else {
                    fields = (GetImplicitlyAuthorizedAncestorSummariesResponse)this.Field;
                }
            }
            string document = Query.O365ObjectAncestors(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365ObjectAncestors");
            string parameters = "($snappableFid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365ObjectAncestors" + parameters + "{" + document + "}",
                OperationName = "QueryO365ObjectAncestors",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<GetImplicitlyAuthorizedAncestorSummariesResponse> task = this._rbkClient.InvokeGenericCallAsync<GetImplicitlyAuthorizedAncestorSummariesResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365TeamConvChannelConnection)psObject.BaseObject;
                } else {
                    fields = (O365TeamConvChannelConnection)this.Field;
                }
            }
            string document = Query.BrowseO365TeamConvChannels(ref fields);
            this._input.Initialize(argDefs, fields, "Query.BrowseO365TeamConvChannels");
            string parameters = "($first: Int,$after: String,$snappableFid: UUID!,$snapshotFidOpt: UUID,$excludeArchived: Boolean!,$orgId: UUID!,$channelMembershipTypeFilter: ChannelMembershipType!,$nameFilter: String)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryBrowseO365TeamConvChannels" + parameters + "{" + document + "}",
                OperationName = "QueryBrowseO365TeamConvChannels",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365TeamConvChannelConnection> task = this._rbkClient.InvokeGenericCallAsync<O365TeamConvChannelConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365ServiceAccountStatusResp)psObject.BaseObject;
                } else {
                    fields = (O365ServiceAccountStatusResp)this.Field;
                }
            }
            string document = Query.O365ServiceAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365ServiceAccount");
            string parameters = "($orgId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365ServiceAccount" + parameters + "{" + document + "}",
                OperationName = "QueryO365ServiceAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365ServiceAccountStatusResp> task = this._rbkClient.InvokeGenericCallAsync<O365ServiceAccountStatusResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<O365OrgInfo>)psObject.BaseObject;
                } else {
                    fields = (List<O365OrgInfo>)this.Field;
                }
            }
            string document = Query.AllO365OrgStatuses(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllO365OrgStatuses");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllO365OrgStatuses" + parameters + "{" + document + "}",
                OperationName = "QueryAllO365OrgStatuses",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<List<O365OrgInfo>> task = this._rbkClient.InvokeGenericCallAsync<List<O365OrgInfo>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365License)psObject.BaseObject;
                } else {
                    fields = (O365License)this.Field;
                }
            }
            string document = Query.O365License(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365License");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365License" + parameters + "{" + document + "}",
                OperationName = "QueryO365License",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<O365License> task = this._rbkClient.InvokeGenericCallAsync<O365License>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365Exocompute(orgId: UUID!, exocomputeClusterId: String!): GetAzureO365ExocomputeResp!
        protected void InvokeQueryAzureO365Exocompute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("exocomputeClusterId", "String!"),
            };
            GetAzureO365ExocomputeResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GetAzureO365ExocomputeResp)psObject.BaseObject;
                } else {
                    fields = (GetAzureO365ExocomputeResp)this.Field;
                }
            }
            string document = Query.AzureO365Exocompute(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365Exocompute");
            string parameters = "($orgId: UUID!,$exocomputeClusterId: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365Exocompute" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365Exocompute",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<GetAzureO365ExocomputeResp> task = this._rbkClient.InvokeGenericCallAsync<GetAzureO365ExocomputeResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365CheckStorageAccountName(tenantId: String!, subscriptionId: UUID!, storage_account_name: String!): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckStorageAccountName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
            };
            AzureResourceAvailabilityResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fields = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string document = Query.AzureO365CheckStorageAccountName(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365CheckStorageAccountName");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365CheckStorageAccountName" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365CheckStorageAccountName",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureResourceAvailabilityResp> task = this._rbkClient.InvokeGenericCallAsync<AzureResourceAvailabilityResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365CheckStorageAccountAccessibility(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     storage_account_name: String!
        //     groupName: String!
        //   ): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckStorageAccountAccessibility()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("storage_account_name", "String!"),
                Tuple.Create("groupName", "String!"),
            };
            AzureResourceAvailabilityResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fields = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string document = Query.AzureO365CheckStorageAccountAccessibility(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365CheckStorageAccountAccessibility");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$storage_account_name: String!,$groupName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365CheckStorageAccountAccessibility" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365CheckStorageAccountAccessibility",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureResourceAvailabilityResp> task = this._rbkClient.InvokeGenericCallAsync<AzureResourceAvailabilityResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365CheckSubscriptionQuota(tenantId: String!, subscriptionId: UUID!, regionName: String!): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckSubscriptionQuota()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("regionName", "String!"),
            };
            AzureResourceAvailabilityResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fields = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string document = Query.AzureO365CheckSubscriptionQuota(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365CheckSubscriptionQuota");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$regionName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365CheckSubscriptionQuota" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365CheckSubscriptionQuota",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureResourceAvailabilityResp> task = this._rbkClient.InvokeGenericCallAsync<AzureResourceAvailabilityResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365CheckResourceGroupName(tenantId: String!, subscriptionId: UUID!, groupName: String!): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckResourceGroupName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
            };
            AzureResourceAvailabilityResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fields = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string document = Query.AzureO365CheckResourceGroupName(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365CheckResourceGroupName");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365CheckResourceGroupName" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365CheckResourceGroupName",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureResourceAvailabilityResp> task = this._rbkClient.InvokeGenericCallAsync<AzureResourceAvailabilityResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365CheckVirtualNetworkName(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     groupName: String!
        //     vnet_name: String!
        //   ): AzureResourceAvailabilityResp!
        protected void InvokeQueryAzureO365CheckVirtualNetworkName()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("groupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
            };
            AzureResourceAvailabilityResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureResourceAvailabilityResp)psObject.BaseObject;
                } else {
                    fields = (AzureResourceAvailabilityResp)this.Field;
                }
            }
            string document = Query.AzureO365CheckVirtualNetworkName(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365CheckVirtualNetworkName");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$groupName: String!,$vnet_name: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365CheckVirtualNetworkName" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365CheckVirtualNetworkName",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureResourceAvailabilityResp> task = this._rbkClient.InvokeGenericCallAsync<AzureResourceAvailabilityResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!): AzureUserRoleResp!
        protected void InvokeQueryAzureO365ValidateUserRoles()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            AzureUserRoleResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureUserRoleResp)psObject.BaseObject;
                } else {
                    fields = (AzureUserRoleResp)this.Field;
                }
            }
            string document = Query.AzureO365ValidateUserRoles(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365ValidateUserRoles");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365ValidateUserRoles" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365ValidateUserRoles",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureUserRoleResp> task = this._rbkClient.InvokeGenericCallAsync<AzureUserRoleResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365CheckNSGOutboundRules(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //   ): AzureNetworkSecurityGroupResp!
        protected void InvokeQueryAzureO365CheckNsgOutboundRules()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
            };
            AzureNetworkSecurityGroupResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNetworkSecurityGroupResp)psObject.BaseObject;
                } else {
                    fields = (AzureNetworkSecurityGroupResp)this.Field;
                }
            }
            string document = Query.AzureO365CheckNsgOutboundRules(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365CheckNsgOutboundRules");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365CheckNsgOutboundRules" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365CheckNsgOutboundRules",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNetworkSecurityGroupResp> task = this._rbkClient.InvokeGenericCallAsync<AzureNetworkSecurityGroupResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365CheckNetworkSubnet(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetResp!
        protected void InvokeQueryAzureO365CheckNetworkSubnet()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            AzureNetworkSubnetResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNetworkSubnetResp)psObject.BaseObject;
                } else {
                    fields = (AzureNetworkSubnetResp)this.Field;
                }
            }
            string document = Query.AzureO365CheckNetworkSubnet(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365CheckNetworkSubnet");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365CheckNetworkSubnet" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365CheckNetworkSubnet",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNetworkSubnetResp> task = this._rbkClient.InvokeGenericCallAsync<AzureNetworkSubnetResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365GetNetworkSubnetUnusedAddr(
        //     tenantId: String!
        //     subscriptionId: UUID!
        //     resourceGroupName: String!
        //     vnet_name: String!
        //     subnet_name: String!
        //     strict_addr_check: Boolean!
        //   ): AzureNetworkSubnetUnusedAddrResp!
        protected void InvokeQueryAzureO365GetNetworkSubnetUnusedAddr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
                Tuple.Create("resourceGroupName", "String!"),
                Tuple.Create("vnet_name", "String!"),
                Tuple.Create("subnet_name", "String!"),
                Tuple.Create("strict_addr_check", "Boolean!"),
            };
            AzureNetworkSubnetUnusedAddrResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureNetworkSubnetUnusedAddrResp)psObject.BaseObject;
                } else {
                    fields = (AzureNetworkSubnetUnusedAddrResp)this.Field;
                }
            }
            string document = Query.AzureO365GetNetworkSubnetUnusedAddr(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365GetNetworkSubnetUnusedAddr");
            string parameters = "($tenantId: String!,$subscriptionId: UUID!,$resourceGroupName: String!,$vnet_name: String!,$subnet_name: String!,$strict_addr_check: Boolean!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365GetNetworkSubnetUnusedAddr" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365GetNetworkSubnetUnusedAddr",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AzureNetworkSubnetUnusedAddrResp> task = this._rbkClient.InvokeGenericCallAsync<AzureNetworkSubnetUnusedAddrResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // azureO365GetAzureHostType: GetAzureHostTypeResp!
        protected void InvokeQueryAzureO365GetAzureHostType()
        {
            Tuple<string, string>[] argDefs = {
            };
            GetAzureHostTypeResp? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GetAzureHostTypeResp)psObject.BaseObject;
                } else {
                    fields = (GetAzureHostTypeResp)this.Field;
                }
            }
            string document = Query.AzureO365GetAzureHostType(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AzureO365GetAzureHostType");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAzureO365GetAzureHostType" + parameters + "{" + document + "}",
                OperationName = "QueryAzureO365GetAzureHostType",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<GetAzureHostTypeResp> task = this._rbkClient.InvokeGenericCallAsync<GetAzureHostTypeResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (O365AppConnection)psObject.BaseObject;
                } else {
                    fields = (O365AppConnection)this.Field;
                }
            }
            string document = Query.ListO365Apps(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ListO365Apps");
            string parameters = "($first: Int,$after: String,$o365AppFilters: [AppFilter!]!,$o365AppSortByParam: AppSortByParam)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryListO365Apps" + parameters + "{" + document + "}",
                OperationName = "QueryListO365Apps",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<O365AppConnection> task = this._rbkClient.InvokeGenericCallAsync<O365AppConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<O365SubscriptionAppTypeCounts>)psObject.BaseObject;
                } else {
                    fields = (List<O365SubscriptionAppTypeCounts>)this.Field;
                }
            }
            string document = Query.AllO365SubscriptionsAppTypeCounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllO365SubscriptionsAppTypeCounts");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllO365SubscriptionsAppTypeCounts" + parameters + "{" + document + "}",
                OperationName = "QueryAllO365SubscriptionsAppTypeCounts",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<List<O365SubscriptionAppTypeCounts>> task = this._rbkClient.InvokeGenericCallAsync<List<O365SubscriptionAppTypeCounts>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GetO365StorageStatsResp)psObject.BaseObject;
                } else {
                    fields = (GetO365StorageStatsResp)this.Field;
                }
            }
            string document = Query.O365StorageStats(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365StorageStats");
            string parameters = "($orgID: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365StorageStats" + parameters + "{" + document + "}",
                OperationName = "QueryO365StorageStats",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<GetO365StorageStatsResp> task = this._rbkClient.InvokeGenericCallAsync<GetO365StorageStatsResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
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
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (GetO365ServiceStatusResp)psObject.BaseObject;
                } else {
                    fields = (GetO365ServiceStatusResp)this.Field;
                }
            }
            string document = Query.O365ServiceStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.O365ServiceStatus");
            string parameters = "($orgID: UUID)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryO365ServiceStatus" + parameters + "{" + document + "}",
                OperationName = "QueryO365ServiceStatus",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<GetO365ServiceStatusResp> task = this._rbkClient.InvokeGenericCallAsync<GetO365ServiceStatusResp>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Query_RscO365
}