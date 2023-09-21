// New-RscGqlMutationCreateAwsAccount.cs
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
    /// Create new GraphQL Mutation createAwsAccount
    /// createAwsAccount(input: CreateAwsAccountInput!): CloudAccount!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateAwsAccount")
    ]
    public class New_RscGqlMutationCreateAwsAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAwsAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createAwsAccount
        /// createAwsAccount(input: CreateAwsAccountInput!): CloudAccount!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAwsAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAwsAccount()
        {
            this._logger.name += " -createAwsAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsAccountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsAccount",
                "($input: CreateAwsAccountInput!)",
                "CloudAccount",
                Mutation.CreateAwsAccount_ObjectFieldSpec,
                Mutation.CreateAwsAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
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

    } // class New-RscGqlMutationCreateAwsAccount
}