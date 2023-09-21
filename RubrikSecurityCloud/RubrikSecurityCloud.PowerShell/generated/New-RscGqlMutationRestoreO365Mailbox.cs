// New-RscGqlMutationRestoreO365Mailbox.cs
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
    /// Create new GraphQL Mutation restoreO365Mailbox
    /// restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRestoreO365Mailbox")
    ]
    public class New_RscGqlMutationRestoreO365Mailbox : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreO365Mailbox");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation restoreO365Mailbox
        /// restoreO365Mailbox(restoreConfig: RestoreO365MailboxInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreO365Mailbox();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreO365Mailbox()
        {
            this._logger.name += " -restoreO365Mailbox";
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

    } // class New-RscGqlMutationRestoreO365Mailbox
}