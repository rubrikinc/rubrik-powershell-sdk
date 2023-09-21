// New-RscGqlQueryAllAwsCloudAccountConfigs.cs
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
    /// Create new GraphQL Query allAwsCloudAccountConfigs
    /// allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!): [AwsFeatureConfig!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAwsCloudAccountConfigs")
    ]
    public class New_RscGqlQueryAllAwsCloudAccountConfigs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAwsCloudAccountConfigs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAwsCloudAccountConfigs
        /// allAwsCloudAccountConfigs(awsCloudAccountsArg: AwsCloudAccountConfigsInput!): [AwsFeatureConfig!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAwsCloudAccountConfigs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAwsCloudAccountConfigs()
        {
            this._logger.name += " -allAwsCloudAccountConfigs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsCloudAccountsArg", "AwsCloudAccountConfigsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsCloudAccountConfigs",
                "($awsCloudAccountsArg: AwsCloudAccountConfigsInput!)",
                "List<AwsFeatureConfig>",
                Query.AllAwsCloudAccountConfigs_ObjectFieldSpec,
                Query.AllAwsCloudAccountConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsCloudAccountsArg = @{
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	statusFilters = @(
		<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
	)
	# OPTIONAL
	awsAdminAccountFilter = <System.String>
	# OPTIONAL
	columnSearchFilter = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAwsCloudAccountConfigs
}