// New-RscGqlMutationDeleteAzureCluster.cs
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
    /// Create new GraphQL Mutation deleteAzureCluster
    /// deleteAzureCluster(input: DeleteAzureClusterInput!): CcProvisionJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteAzureCluster")
    ]
    public class New_RscGqlMutationDeleteAzureCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteAzureCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteAzureCluster
        /// deleteAzureCluster(input: DeleteAzureClusterInput!): CcProvisionJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteAzureCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteAzureCluster()
        {
            this._logger.name += " -deleteAzureCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAzureCluster",
                "($input: DeleteAzureClusterInput!)",
                "CcProvisionJobReply",
                Mutation.DeleteAzureCluster_ObjectFieldSpec,
                Mutation.DeleteAzureClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	clusterName = <System.String>
	# OPTIONAL
	numNodes = <System.Int32>
	# OPTIONAL
	resourceGroupName = <System.String>
	# OPTIONAL
	networkResourceGroup = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	storageAccount = <System.String>
	# OPTIONAL
	containerName = <System.String>
	# OPTIONAL
	storageResourceGroup = <System.String>
	# OPTIONAL
	isNewContainer = <System.Boolean>
	# OPTIONAL
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteAzureCluster
}