// New-RscGqlMutationBulkDeleteAwsCloudAccountWithoutCft.cs
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
    /// Create new GraphQL Mutation bulkDeleteAwsCloudAccountWithoutCft
    /// bulkDeleteAwsCloudAccountWithoutCft(input: BulkDeleteAwsCloudAccountWithoutCftInput!): BulkDeleteAwsCloudAccountWithoutCftReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBulkDeleteAwsCloudAccountWithoutCft")
    ]
    public class New_RscGqlMutationBulkDeleteAwsCloudAccountWithoutCft : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkDeleteAwsCloudAccountWithoutCft");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation bulkDeleteAwsCloudAccountWithoutCft
        /// bulkDeleteAwsCloudAccountWithoutCft(input: BulkDeleteAwsCloudAccountWithoutCftInput!): BulkDeleteAwsCloudAccountWithoutCftReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkDeleteAwsCloudAccountWithoutCft();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkDeleteAwsCloudAccountWithoutCft()
        {
            this._logger.name += " -bulkDeleteAwsCloudAccountWithoutCft";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteAwsCloudAccountWithoutCftInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteAwsCloudAccountWithoutCft",
                "($input: BulkDeleteAwsCloudAccountWithoutCftInput!)",
                "BulkDeleteAwsCloudAccountWithoutCftReply",
                Mutation.BulkDeleteAwsCloudAccountWithoutCft_ObjectFieldSpec,
                Mutation.BulkDeleteAwsCloudAccountWithoutCftFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsNativeId = <System.String>
	# OPTIONAL
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

    } // class New-RscGqlMutationBulkDeleteAwsCloudAccountWithoutCft
}