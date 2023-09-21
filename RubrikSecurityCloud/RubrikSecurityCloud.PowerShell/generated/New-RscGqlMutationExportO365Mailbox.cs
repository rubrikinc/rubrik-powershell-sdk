// New-RscGqlMutationExportO365Mailbox.cs
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
    /// Create new GraphQL Mutation exportO365Mailbox
    /// exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExportO365Mailbox")
    ]
    public class New_RscGqlMutationExportO365Mailbox : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("exportO365Mailbox");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation exportO365Mailbox
        /// exportO365Mailbox(exportConfig: ExportO365MailboxInput!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_exportO365Mailbox();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_exportO365Mailbox()
        {
            this._logger.name += " -exportO365Mailbox";
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

    } // class New-RscGqlMutationExportO365Mailbox
}