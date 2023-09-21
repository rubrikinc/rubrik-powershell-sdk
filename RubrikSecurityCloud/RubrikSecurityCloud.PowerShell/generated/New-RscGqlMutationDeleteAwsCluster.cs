// New-RscGqlMutationDeleteAwsCluster.cs
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
    /// Create new GraphQL Mutation deleteAwsCluster
    /// deleteAwsCluster(input: DeleteAwsClusterInput!): CcProvisionJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteAwsCluster")
    ]
    public class New_RscGqlMutationDeleteAwsCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteAwsCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteAwsCluster
        /// deleteAwsCluster(input: DeleteAwsClusterInput!): CcProvisionJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteAwsCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteAwsCluster()
        {
            this._logger.name += " -deleteAwsCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAwsCluster",
                "($input: DeleteAwsClusterInput!)",
                "CcProvisionJobReply",
                Mutation.DeleteAwsCluster_ObjectFieldSpec,
                Mutation.DeleteAwsClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	clusterName = <System.String>
	# OPTIONAL
	numNodes = <System.Int32>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	bucketName = <System.String>
	# OPTIONAL
	isNewContainer = <System.Boolean>
	# OPTIONAL
	clusterUuid = <System.String>
	# OPTIONAL
	region = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteAwsCluster
}