// New-RscGqlMutationCreateK8sCluster.cs
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
    /// Create new GraphQL Mutation createK8sCluster
    /// createK8sCluster(input: CreateK8sClusterInput!): CreateK8sClusterReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateK8sCluster")
    ]
    public class New_RscGqlMutationCreateK8sCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createK8sCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createK8sCluster
        /// createK8sCluster(input: CreateK8sClusterInput!): CreateK8sClusterReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createK8sCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createK8sCluster()
        {
            this._logger.name += " -createK8sCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateK8sClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateK8sCluster",
                "($input: CreateK8sClusterInput!)",
                "CreateK8sClusterReply",
                Mutation.CreateK8sCluster_ObjectFieldSpec,
                Mutation.CreateK8sClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cdmClusterId = <System.String>
	# REQUIRED
	hostList = @(
		<System.String>
	)
	# REQUIRED
	name = <System.String>
	# REQUIRED
	port = <System.Int32>
	# REQUIRED
	rbsPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# OPTIONAL
	userDrivenPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# REQUIRED
	type = <K8sClusterProtoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.K8sClusterProtoType]) for enum values.
	# OPTIONAL
	proxyUrl = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationCreateK8sCluster
}