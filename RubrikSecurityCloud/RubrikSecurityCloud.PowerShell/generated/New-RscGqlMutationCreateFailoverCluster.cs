// New-RscGqlMutationCreateFailoverCluster.cs
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
    /// Create new GraphQL Mutation createFailoverCluster
    /// createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateFailoverCluster")
    ]
    public class New_RscGqlMutationCreateFailoverCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createFailoverCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createFailoverCluster
        /// createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createFailoverCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createFailoverCluster()
        {
            this._logger.name += " -createFailoverCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFailoverCluster",
                "($input: CreateFailoverClusterInput!)",
                "CreateFailoverClusterReply",
                Mutation.CreateFailoverCluster_ObjectFieldSpec,
                Mutation.CreateFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		name = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationCreateFailoverCluster
}