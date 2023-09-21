// New-RscGqlMutationUpdateAzureTarget.cs
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
    /// Create new GraphQL Mutation updateAzureTarget
    /// updateAzureTarget(input: UpdateAzureTargetInput!): Target!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateAzureTarget")
    ]
    public class New_RscGqlMutationUpdateAzureTarget : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateAzureTarget");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateAzureTarget
        /// updateAzureTarget(input: UpdateAzureTargetInput!): Target!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateAzureTarget();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateAzureTarget()
        {
            this._logger.name += " -updateAzureTarget";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureTargetInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAzureTarget",
                "($input: UpdateAzureTargetInput!)",
                "Target",
                Mutation.UpdateAzureTarget_ObjectFieldSpec,
                Mutation.UpdateAzureTargetFieldSpec,
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
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	retrievalTier = <AzureRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = <System.Boolean>
}"
            );
        }

    } // class New-RscGqlMutationUpdateAzureTarget
}