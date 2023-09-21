// New-RscGqlMutationUpdateAwsAccount.cs
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
    /// Create new GraphQL Mutation updateAwsAccount
    /// updateAwsAccount(input: UpdateAwsAccountInput!): CloudAccount!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateAwsAccount")
    ]
    public class New_RscGqlMutationUpdateAwsAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateAwsAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateAwsAccount
        /// updateAwsAccount(input: UpdateAwsAccountInput!): CloudAccount!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateAwsAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateAwsAccount()
        {
            this._logger.name += " -updateAwsAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsAccount",
                "($input: UpdateAwsAccountInput!)",
                "CloudAccount",
                Mutation.UpdateAwsAccount_ObjectFieldSpec,
                Mutation.UpdateAwsAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	secretKey = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateAwsAccount
}