// New-RscGqlMutationCreateAzureCluster.cs
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
    /// Create new GraphQL Mutation createAzureCluster
    /// createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateAzureCluster")
    ]
    public class New_RscGqlMutationCreateAzureCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAzureCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createAzureCluster
        /// createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAzureCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAzureCluster()
        {
            this._logger.name += " -createAzureCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAzureCluster",
                "($input: CreateAzureClusterInput!)",
                "CcProvisionJobReply",
                Mutation.CreateAzureCluster_ObjectFieldSpec,
                Mutation.CreateAzureClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	keepClusterOnFailure = <System.Boolean>
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
		resourceGroup = <System.String>
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		location = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		networkResourceGroup = <System.String>
		# OPTIONAL
		vnetResourceGroup = <System.String>
		# OPTIONAL
		networkSecurityGroup = <System.String>
		# OPTIONAL
		networkSecurityResourceGroup = <System.String>
		# OPTIONAL
		vnet = <System.String>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		vmImage = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = <AzureInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
}"
            );
        }

    } // class New-RscGqlMutationCreateAzureCluster
}