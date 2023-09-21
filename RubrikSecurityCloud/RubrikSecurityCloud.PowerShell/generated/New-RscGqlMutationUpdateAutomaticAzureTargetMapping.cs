// New-RscGqlMutationUpdateAutomaticAzureTargetMapping.cs
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
    /// Create new GraphQL Mutation updateAutomaticAzureTargetMapping
    /// updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateAutomaticAzureTargetMapping")
    ]
    public class New_RscGqlMutationUpdateAutomaticAzureTargetMapping : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateAutomaticAzureTargetMapping");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateAutomaticAzureTargetMapping
        /// updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateAutomaticAzureTargetMapping();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateAutomaticAzureTargetMapping()
        {
            this._logger.name += " -updateAutomaticAzureTargetMapping";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAzureTargetMappingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAutomaticAzureTargetMapping",
                "($input: UpdateAutomaticAzureTargetMappingInput!)",
                "TargetMapping",
                Mutation.UpdateAutomaticAzureTargetMapping_ObjectFieldSpec,
                Mutation.UpdateAutomaticAzureTargetMappingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	storageAccountName = <System.String>
	# OPTIONAL
	accessKey = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
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
	# OPTIONAL
	isConsolidationEnabled = <System.Boolean>
}"
            );
        }

    } // class New-RscGqlMutationUpdateAutomaticAzureTargetMapping
}