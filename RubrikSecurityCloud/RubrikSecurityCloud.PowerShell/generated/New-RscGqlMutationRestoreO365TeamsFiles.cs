// New-RscGqlMutationRestoreO365TeamsFiles.cs
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
    /// Create new GraphQL Mutation restoreO365TeamsFiles
    /// restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRestoreO365TeamsFiles")
    ]
    public class New_RscGqlMutationRestoreO365TeamsFiles : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreO365TeamsFiles");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation restoreO365TeamsFiles
        /// restoreO365TeamsFiles(input: RestoreO365TeamsFilesInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreO365TeamsFiles();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreO365TeamsFiles()
        {
            this._logger.name += " -restoreO365TeamsFiles";
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

    } // class New-RscGqlMutationRestoreO365TeamsFiles
}