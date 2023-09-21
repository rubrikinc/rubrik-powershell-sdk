// New-RscGqlMutationBulkCreateOnDemandMssqlBackup.cs
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
    /// Create new GraphQL Mutation bulkCreateOnDemandMssqlBackup
    /// bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBulkCreateOnDemandMssqlBackup")
    ]
    public class New_RscGqlMutationBulkCreateOnDemandMssqlBackup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkCreateOnDemandMssqlBackup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation bulkCreateOnDemandMssqlBackup
        /// bulkCreateOnDemandMssqlBackup(input: BulkCreateOnDemandMssqlBackupInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkCreateOnDemandMssqlBackup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkCreateOnDemandMssqlBackup()
        {
            this._logger.name += " -bulkCreateOnDemandMssqlBackup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkCreateOnDemandMssqlBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkCreateOnDemandMssqlBackup",
                "($input: BulkCreateOnDemandMssqlBackupInput!)",
                "AsyncRequestStatus",
                Mutation.BulkCreateOnDemandMssqlBackup_ObjectFieldSpec,
                Mutation.BulkCreateOnDemandMssqlBackupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		availabilityGroupIds = @(
			<System.String>
		)
		# OPTIONAL
		databaseIds = @(
			<System.String>
		)
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		hostIds = @(
			<System.String>
		)
		# OPTIONAL
		instanceIds = @(
			<System.String>
		)
		# OPTIONAL
		windowsClusterIds = @(
			<System.String>
		)
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationBulkCreateOnDemandMssqlBackup
}