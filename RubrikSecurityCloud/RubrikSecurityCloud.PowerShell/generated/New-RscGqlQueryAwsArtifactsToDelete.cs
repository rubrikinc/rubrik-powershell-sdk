// New-RscGqlQueryAwsArtifactsToDelete.cs
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
    /// Create new GraphQL Query awsArtifactsToDelete
    /// awsArtifactsToDelete(input: AwsArtifactsToDeleteInput!): AwsArtifactsToDelete!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsArtifactsToDelete")
    ]
    public class New_RscGqlQueryAwsArtifactsToDelete : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsArtifactsToDelete");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsArtifactsToDelete
        /// awsArtifactsToDelete(input: AwsArtifactsToDeleteInput!): AwsArtifactsToDelete!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsArtifactsToDelete();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsArtifactsToDelete()
        {
            this._logger.name += " -awsArtifactsToDelete";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AwsArtifactsToDeleteInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsArtifactsToDelete",
                "($input: AwsArtifactsToDeleteInput!)",
                "AwsArtifactsToDelete",
                Query.AwsArtifactsToDelete_ObjectFieldSpec,
                Query.AwsArtifactsToDeleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsNativeId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}"
            );
        }

    } // class New-RscGqlQueryAwsArtifactsToDelete
}