// New-RscGqlMutationRegisterAwsFeatureArtifacts.cs
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
    /// Create new GraphQL Mutation registerAwsFeatureArtifacts
    /// registerAwsFeatureArtifacts(input: RegisterAwsFeatureArtifactsInput!): RegisterAwsFeatureArtifactsReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationRegisterAwsFeatureArtifacts")
    ]
    public class New_RscGqlMutationRegisterAwsFeatureArtifacts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("registerAwsFeatureArtifacts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation registerAwsFeatureArtifacts
        /// registerAwsFeatureArtifacts(input: RegisterAwsFeatureArtifactsInput!): RegisterAwsFeatureArtifactsReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_registerAwsFeatureArtifacts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_registerAwsFeatureArtifacts()
        {
            this._logger.name += " -registerAwsFeatureArtifacts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterAwsFeatureArtifactsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterAwsFeatureArtifacts",
                "($input: RegisterAwsFeatureArtifactsInput!)",
                "RegisterAwsFeatureArtifactsReply",
                Mutation.RegisterAwsFeatureArtifacts_ObjectFieldSpec,
                Mutation.RegisterAwsFeatureArtifactsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsArtifacts = @(
		@{
			# REQUIRED
			awsNativeId = <System.String>
			# REQUIRED
			externalArtifacts = @(
				@{
					# REQUIRED
					externalArtifactValue = <System.String>
					# OPTIONAL
					externalArtifactKey = <AwsCloudExternalArtifact> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
				}
			)
			# REQUIRED
			features = @(
				<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			)
		}
	)
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationRegisterAwsFeatureArtifacts
}