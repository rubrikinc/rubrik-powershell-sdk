// New-RscGqlMutationUpdateAzureAccount.cs
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
    /// Create new GraphQL Mutation updateAzureAccount
    /// updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateAzureAccount")
    ]
    public class New_RscGqlMutationUpdateAzureAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateAzureAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateAzureAccount
        /// updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateAzureAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateAzureAccount()
        {
            this._logger.name += " -updateAzureAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureAccount",
                "($input: UpdateAzureAccountInput!)",
                "CloudAccount",
                Mutation.UpdateAzureAccount_ObjectFieldSpec,
                Mutation.UpdateAzureAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	subscriptionId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateAzureAccount
}