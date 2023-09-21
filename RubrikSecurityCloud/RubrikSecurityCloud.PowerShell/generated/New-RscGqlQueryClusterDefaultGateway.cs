// New-RscGqlQueryClusterDefaultGateway.cs
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
    /// Create new GraphQL Query clusterDefaultGateway
    /// clusterDefaultGateway(input: GetDefaultGatewayInput!): InternalGetDefaultGatewayResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterDefaultGateway")
    ]
    public class New_RscGqlQueryClusterDefaultGateway : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterDefaultGateway");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterDefaultGateway
        /// clusterDefaultGateway(input: GetDefaultGatewayInput!): InternalGetDefaultGatewayResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterDefaultGateway();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterDefaultGateway()
        {
            this._logger.name += " -clusterDefaultGateway";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultGatewayInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterDefaultGateway",
                "($input: GetDefaultGatewayInput!)",
                "InternalGetDefaultGatewayResponse",
                Query.ClusterDefaultGateway_ObjectFieldSpec,
                Query.ClusterDefaultGatewayFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryClusterDefaultGateway
}