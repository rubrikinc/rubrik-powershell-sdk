// New-RscGqlQueryOracleAcoParameters.cs
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
    /// Create new GraphQL Query oracleAcoParameters
    /// oracleAcoParameters(input: ClusterUuidWithDbIdInput!): OracleAcoParameterList!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleAcoParameters")
    ]
    public class New_RscGqlQueryOracleAcoParameters : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleAcoParameters");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleAcoParameters
        /// oracleAcoParameters(input: ClusterUuidWithDbIdInput!): OracleAcoParameterList!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleAcoParameters();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleAcoParameters()
        {
            this._logger.name += " -oracleAcoParameters";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleAcoParameters",
                "($input: ClusterUuidWithDbIdInput!)",
                "OracleAcoParameterList",
                Query.OracleAcoParameters_ObjectFieldSpec,
                Query.OracleAcoParametersFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryOracleAcoParameters
}