// New-RscGqlQueryAllAwsPermissionPolicies.cs
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
    /// Create new GraphQL Query allAwsPermissionPolicies
    /// allAwsPermissionPolicies(input: AwsGetPermissionPoliciesInput!): [PermissionPolicy!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAwsPermissionPolicies")
    ]
    public class New_RscGqlQueryAllAwsPermissionPolicies : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAwsPermissionPolicies");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAwsPermissionPolicies
        /// allAwsPermissionPolicies(input: AwsGetPermissionPoliciesInput!): [PermissionPolicy!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAwsPermissionPolicies();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAwsPermissionPolicies()
        {
            this._logger.name += " -allAwsPermissionPolicies";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsGetPermissionPoliciesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsPermissionPolicies",
                "($input: AwsGetPermissionPoliciesInput!)",
                "List<PermissionPolicy>",
                Query.AllAwsPermissionPolicies_ObjectFieldSpec,
                Query.AllAwsPermissionPoliciesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featureSpecificDetails = @{
		# OPTIONAL
		ec2RecoveryRolePath = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlQueryAllAwsPermissionPolicies
}