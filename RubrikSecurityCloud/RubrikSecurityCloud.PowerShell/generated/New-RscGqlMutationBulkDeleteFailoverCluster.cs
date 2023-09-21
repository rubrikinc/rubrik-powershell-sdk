// New-RscGqlMutationBulkDeleteFailoverCluster.cs
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
    /// Create new GraphQL Mutation bulkDeleteFailoverCluster
    /// bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBulkDeleteFailoverCluster")
    ]
    public class New_RscGqlMutationBulkDeleteFailoverCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkDeleteFailoverCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation bulkDeleteFailoverCluster
        /// bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkDeleteFailoverCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkDeleteFailoverCluster()
        {
            this._logger.name += " -bulkDeleteFailoverCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFailoverCluster",
                "($input: BulkDeleteFailoverClusterInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFailoverCluster_ObjectFieldSpec,
                Mutation.BulkDeleteFailoverClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	ids = @(
		<System.String>
	)
}"
            );
        }

    } // class New-RscGqlMutationBulkDeleteFailoverCluster
}