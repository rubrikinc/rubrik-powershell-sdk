// New-RscGqlMutationBackupO365Onedrive.cs
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
    /// Create new GraphQL Mutation backupO365Onedrive
    /// backupO365Onedrive(input: BackupO365OnedriveInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBackupO365Onedrive")
    ]
    public class New_RscGqlMutationBackupO365Onedrive : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("backupO365Onedrive");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation backupO365Onedrive
        /// backupO365Onedrive(input: BackupO365OnedriveInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_backupO365Onedrive();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_backupO365Onedrive()
        {
            this._logger.name += " -backupO365Onedrive";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365OnedriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365Onedrive",
                "($input: BackupO365OnedriveInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365Onedrive_ObjectFieldSpec,
                Mutation.BackupO365OnedriveFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlMutationBackupO365Onedrive
}