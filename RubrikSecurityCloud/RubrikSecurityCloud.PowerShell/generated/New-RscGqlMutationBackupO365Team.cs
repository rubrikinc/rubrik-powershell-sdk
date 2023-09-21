// New-RscGqlMutationBackupO365Team.cs
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
    /// Create new GraphQL Mutation backupO365Team
    /// backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBackupO365Team")
    ]
    public class New_RscGqlMutationBackupO365Team : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("backupO365Team");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation backupO365Team
        /// backupO365Team(input: BackupO365TeamInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_backupO365Team();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_backupO365Team()
        {
            this._logger.name += " -backupO365Team";
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

    } // class New-RscGqlMutationBackupO365Team
}