// New-RscGqlQueryClusterCsr.cs
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
    /// Create new GraphQL Query clusterCsr
    /// clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterCsr")
    ]
    public class New_RscGqlQueryClusterCsr : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterCsr");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterCsr
        /// clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterCsr();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterCsr()
        {
            this._logger.name += " -clusterCsr";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterCsrInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterCsr",
                "($input: GetClusterCsrInput!)",
                "ClusterCsr",
                Query.ClusterCsr_ObjectFieldSpec,
                Query.ClusterCsrFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryClusterCsr
}