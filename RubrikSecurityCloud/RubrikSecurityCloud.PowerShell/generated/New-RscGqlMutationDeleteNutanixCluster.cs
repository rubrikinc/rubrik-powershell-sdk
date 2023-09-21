// New-RscGqlMutationDeleteNutanixCluster.cs
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
    /// Create new GraphQL Mutation deleteNutanixCluster
    /// deleteNutanixCluster(input: DeleteNutanixClusterInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteNutanixCluster")
    ]
    public class New_RscGqlMutationDeleteNutanixCluster : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteNutanixCluster");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteNutanixCluster
        /// deleteNutanixCluster(input: DeleteNutanixClusterInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteNutanixCluster();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteNutanixCluster()
        {
            this._logger.name += " -deleteNutanixCluster";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixCluster",
                "($input: DeleteNutanixClusterInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteNutanixCluster_ObjectFieldSpec,
                Mutation.DeleteNutanixClusterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteNutanixCluster
}