// New-RscGqlQueryAwsTrustPolicy.cs
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
    /// Create new GraphQL Query awsTrustPolicy
    /// awsTrustPolicy(input: AwsTrustPolicyInput!): AwsTrustPolicy!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsTrustPolicy")
    ]
    public class New_RscGqlQueryAwsTrustPolicy : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsTrustPolicy");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsTrustPolicy
        /// awsTrustPolicy(input: AwsTrustPolicyInput!): AwsTrustPolicy!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsTrustPolicy();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsTrustPolicy()
        {
            this._logger.name += " -awsTrustPolicy";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsTrustPolicyInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsTrustPolicy",
                "($input: AwsTrustPolicyInput!)",
                "AwsTrustPolicy",
                Query.AwsTrustPolicy_ObjectFieldSpec,
                Query.AwsTrustPolicyFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	awsNativeAccounts = @(
		@{
			# OPTIONAL
			externalId = <System.String>
			# REQUIRED
			id = <System.String>
		}
	)
}"
            );
        }

    } // class New-RscGqlQueryAwsTrustPolicy
}