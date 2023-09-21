// New-RscGqlMutationBackupO365SharepointDrive.cs
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
    /// Create new GraphQL Mutation backupO365SharepointDrive
    /// backupO365SharepointDrive(input: BackupO365SharepointDriveInput!): BatchAsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBackupO365SharepointDrive")
    ]
    public class New_RscGqlMutationBackupO365SharepointDrive : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("backupO365SharepointDrive");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation backupO365SharepointDrive
        /// backupO365SharepointDrive(input: BackupO365SharepointDriveInput!): BatchAsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_backupO365SharepointDrive();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_backupO365SharepointDrive()
        {
            this._logger.name += " -backupO365SharepointDrive";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BackupO365SharepointDriveInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBackupO365SharepointDrive",
                "($input: BackupO365SharepointDriveInput!)",
                "BatchAsyncJobStatus",
                Mutation.BackupO365SharepointDrive_ObjectFieldSpec,
                Mutation.BackupO365SharepointDriveFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlMutationBackupO365SharepointDrive
}