// New-RscGqlMutationCreateAwsCluster.cs
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
    /// Create new GraphQL Mutation createAwsCluster
    /// createAwsCluster(input: CreateAwsClusterInput!): CcProvisionJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateAwsCluster")
    ]
    public class New_RscGqlMutationCreateAwsCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAwsCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createAwsCluster
        /// createAwsCluster(input: CreateAwsClusterInput!): CcProvisionJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAwsCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAwsCluster()
        {
            this._logger.name += " -createAwsCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAwsClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAwsCluster",
                "($input: CreateAwsClusterInput!)",
                "CcProvisionJobReply",
                Mutation.CreateAwsCluster_ObjectFieldSpec,
                Mutation.CreateAwsClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	keepClusterOnFailure = <System.Boolean>
	# OPTIONAL
	region = <System.String>
	# OPTIONAL
	disableApiTermination = <System.Boolean>
	# OPTIONAL
	clusterConfig = @{
		# OPTIONAL
		userEmail = <System.String>
		# OPTIONAL
		adminPassword = <System.String>
		# OPTIONAL
		clusterName = <System.String>
		# OPTIONAL
		numNodes = <System.Int32>
		# OPTIONAL
		dnsSearchDomains = @(
			<System.String>
		)
		# OPTIONAL
		dnsNameServers = @(
			<System.String>
		)
		# OPTIONAL
		ntpServers = @(
			<System.String>
		)
		# OPTIONAL
		azureEsConfig = @{
			# OPTIONAL
			storageAccount = <System.String>
			# OPTIONAL
			resourceGroup = <System.String>
			# OPTIONAL
			storageSecret = <System.String>
			# OPTIONAL
			containerName = <System.String>
			# OPTIONAL
			shouldCreateContainer = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
		# OPTIONAL
		awsEsConfig = @{
			# OPTIONAL
			bucketName = <System.String>
			# OPTIONAL
			shouldCreateBucket = <System.Boolean>
			# OPTIONAL
			enableObjectLock = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
	}
	# OPTIONAL
	vmConfig = @{
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		imageId = <System.String>
		# OPTIONAL
		instanceProfileName = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			<System.String>
		)
		# OPTIONAL
		instanceType = <AwsInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
	}
}"
            );
        }

    } // class New-RscGqlMutationCreateAwsCluster
}