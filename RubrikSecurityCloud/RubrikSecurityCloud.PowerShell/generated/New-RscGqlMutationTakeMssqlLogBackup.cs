// New-RscGqlMutationTakeMssqlLogBackup.cs
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
    /// Create new GraphQL Mutation takeMssqlLogBackup
    /// takeMssqlLogBackup(input: TakeMssqlLogBackupInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationTakeMssqlLogBackup")
    ]
    public class New_RscGqlMutationTakeMssqlLogBackup : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("takeMssqlLogBackup");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation takeMssqlLogBackup
        /// takeMssqlLogBackup(input: TakeMssqlLogBackupInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_takeMssqlLogBackup();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_takeMssqlLogBackup()
        {
            this._logger.name += " -takeMssqlLogBackup";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeMssqlLogBackupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeMssqlLogBackup",
                "($input: TakeMssqlLogBackupInput!)",
                "AsyncRequestStatus",
                Mutation.TakeMssqlLogBackup_ObjectFieldSpec,
                Mutation.TakeMssqlLogBackupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationTakeMssqlLogBackup
}