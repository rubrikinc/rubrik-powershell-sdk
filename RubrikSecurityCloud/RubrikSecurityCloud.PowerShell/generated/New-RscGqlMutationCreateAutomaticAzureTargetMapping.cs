// New-RscGqlMutationCreateAutomaticAzureTargetMapping.cs
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
    /// Create new GraphQL Mutation createAutomaticAzureTargetMapping
    /// createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateAutomaticAzureTargetMapping")
    ]
    public class New_RscGqlMutationCreateAutomaticAzureTargetMapping : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createAutomaticAzureTargetMapping");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createAutomaticAzureTargetMapping
        /// createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createAutomaticAzureTargetMapping();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createAutomaticAzureTargetMapping()
        {
            this._logger.name += " -createAutomaticAzureTargetMapping";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateAutomaticAzureTargetMapping",
                "($input: CreateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.CreateAutomaticAzureTargetMapping_ObjectFieldSpec,
                Mutation.CreateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	containerNamePrefix = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	instanceType = <InstanceTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
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
		# OPTIONAL
		cloudAccountId = <System.String>
	}
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
	clusterUuidList = @(
		<System.String>
	)
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
}"
            );
        }

    } // class New-RscGqlMutationCreateAutomaticAzureTargetMapping
}