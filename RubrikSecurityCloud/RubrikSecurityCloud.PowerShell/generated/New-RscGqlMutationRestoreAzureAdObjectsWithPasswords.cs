// New-RscGqlMutationRestoreAzureAdObjectsWithPasswords.cs
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
    /// Create new GraphQL Mutation restoreAzureAdObjectsWithPasswords
    /// restoreAzureAdObjectsWithPasswords(input: RestoreAzureAdObjectsWithPasswordsInput!): RestoreAzureAdObjectsWithPasswordsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRestoreAzureAdObjectsWithPasswords")
    ]
    public class New_RscGqlMutationRestoreAzureAdObjectsWithPasswords : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("restoreAzureAdObjectsWithPasswords");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation restoreAzureAdObjectsWithPasswords
        /// restoreAzureAdObjectsWithPasswords(input: RestoreAzureAdObjectsWithPasswordsInput!): RestoreAzureAdObjectsWithPasswordsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_restoreAzureAdObjectsWithPasswords();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_restoreAzureAdObjectsWithPasswords()
        {
            this._logger.name += " -restoreAzureAdObjectsWithPasswords";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreAzureAdObjectsWithPasswordsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreAzureAdObjectsWithPasswords",
                "($input: RestoreAzureAdObjectsWithPasswordsInput!)",
                "RestoreAzureAdObjectsWithPasswordsReply",
                Mutation.RestoreAzureAdObjectsWithPasswords_ObjectFieldSpec,
                Mutation.RestoreAzureAdObjectsWithPasswordsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	workloadFid = <System.String>
	# REQUIRED
	snapshotFid = <System.String>
	# REQUIRED
	passwordByUserIdMap = @(
		@{
			# REQUIRED
			userId = <System.String>
			# REQUIRED
			password = <System.String>
		}
	)
	# REQUIRED
	objectTypeToIdMap = @(
		@{
			# REQUIRED
			objectId = <System.String>
			# REQUIRED
			azureAdObjectType = <AzureAdObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
		}
	)
	# REQUIRED
	forceChangePasswordWithMfa = <System.Boolean>
}"
            );
        }

    } // class New-RscGqlMutationRestoreAzureAdObjectsWithPasswords
}