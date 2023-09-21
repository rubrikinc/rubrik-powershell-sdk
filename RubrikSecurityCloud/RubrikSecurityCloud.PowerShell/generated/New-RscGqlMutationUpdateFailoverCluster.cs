// New-RscGqlMutationUpdateFailoverCluster.cs
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
    /// Create new GraphQL Mutation updateFailoverCluster
    /// updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateFailoverCluster")
    ]
    public class New_RscGqlMutationUpdateFailoverCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateFailoverCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateFailoverCluster
        /// updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateFailoverCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateFailoverCluster()
        {
            this._logger.name += " -updateFailoverCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFailoverCluster",
                "($input: UpdateFailoverClusterInput!)",
                "UpdateFailoverClusterReply",
                Mutation.UpdateFailoverCluster_ObjectFieldSpec,
                Mutation.UpdateFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
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

    } // class New-RscGqlMutationUpdateFailoverCluster
}