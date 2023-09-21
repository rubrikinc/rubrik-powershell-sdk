// New-RscGqlMutationUpgradeAwsIamUserBasedCloudAccountPermissions.cs
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
    /// Create new GraphQL Mutation upgradeAwsIamUserBasedCloudAccountPermissions
    /// upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpgradeAwsIamUserBasedCloudAccountPermissions")
    ]
    public class New_RscGqlMutationUpgradeAwsIamUserBasedCloudAccountPermissions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("upgradeAwsIamUserBasedCloudAccountPermissions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation upgradeAwsIamUserBasedCloudAccountPermissions
        /// upgradeAwsIamUserBasedCloudAccountPermissions(input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_upgradeAwsIamUserBasedCloudAccountPermissions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_upgradeAwsIamUserBasedCloudAccountPermissions()
        {
            this._logger.name += " -upgradeAwsIamUserBasedCloudAccountPermissions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAwsIamUserBasedCloudAccountPermissionsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpgradeAwsIamUserBasedCloudAccountPermissions",
                "($input: UpgradeAwsIamUserBasedCloudAccountPermissionsInput!)",
                "System.Boolean",
                Mutation.UpgradeAwsIamUserBasedCloudAccountPermissions_ObjectFieldSpec,
                Mutation.UpgradeAwsIamUserBasedCloudAccountPermissionsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsCloudAccountId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

    } // class New-RscGqlMutationUpgradeAwsIamUserBasedCloudAccountPermissions
}