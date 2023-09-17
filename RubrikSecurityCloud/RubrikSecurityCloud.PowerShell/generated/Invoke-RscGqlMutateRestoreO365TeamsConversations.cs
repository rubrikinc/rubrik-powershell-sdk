// Invoke-RscGqlMutateRestoreO365TeamsConversations.cs
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
    /// Invoke GraphQL Mutation restoreO365TeamsConversations
    /// restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateRestoreO365TeamsConversations")
    ]
    public class Invoke_RscGqlMutateRestoreO365TeamsConversations : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreO365TeamsConversations");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation restoreO365TeamsConversations
        /// restoreO365TeamsConversations(input: RestoreO365TeamsConversationsInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreO365TeamsConversations();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreO365TeamsConversations()
        {
            this._logger.name += " -restoreO365TeamsConversations";
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

    } // class Invoke-RscGqlMutateRestoreO365TeamsConversations
}