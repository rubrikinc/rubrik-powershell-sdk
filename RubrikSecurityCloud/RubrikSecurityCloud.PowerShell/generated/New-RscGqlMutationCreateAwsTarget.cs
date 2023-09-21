// New-RscGqlMutationCreateAwsTarget.cs
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
    /// Create new GraphQL Mutation createAwsTarget
    /// createAwsTarget(input: CreateAwsTargetInput!): Target!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateAwsTarget")
    ]
    public class New_RscGqlMutationCreateAwsTarget : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAwsTarget");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createAwsTarget
        /// createAwsTarget(input: CreateAwsTargetInput!): Target!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAwsTarget();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAwsTarget()
        {
            this._logger.name += " -createAwsTarget";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsTarget",
                "($input: CreateAwsTargetInput!)",
                "Target",
                Mutation.CreateAwsTarget_ObjectFieldSpec,
                Mutation.CreateAwsTargetFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	bucketName = <System.String>
	# REQUIRED
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# REQUIRED
	region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = <System.String>
	# OPTIONAL
	rsaKey = <System.String>
	# OPTIONAL
	encryptionPassword = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	awsComputeSettingsId = <System.String>
	# OPTIONAL
	cloudComputeSettings = @{
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		vpcId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
	}
	# OPTIONAL
	computeProxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	awsRetrievalTier = <AwsRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	s3Endpoint = <System.String>
	# OPTIONAL
	kmsEndpoint = <System.String>
	# REQUIRED
	bypassProxy = <System.Boolean>
}"
            );
        }

    } // class New-RscGqlMutationCreateAwsTarget
}