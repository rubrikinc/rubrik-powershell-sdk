// New-RscGqlQueryOracleRecoverableRanges.cs
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
    /// Create new GraphQL Query oracleRecoverableRanges
    /// oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!): OracleRecoverableRangeListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleRecoverableRanges")
    ]
    public class New_RscGqlQueryOracleRecoverableRanges : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleRecoverableRanges");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleRecoverableRanges
        /// oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!): OracleRecoverableRangeListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleRecoverableRanges();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleRecoverableRanges()
        {
            this._logger.name += " -oracleRecoverableRanges";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRecoverableRanges",
                "($input: GetOracleDbRecoverableRangesInput!)",
                "OracleRecoverableRangeListResponse",
                Query.OracleRecoverableRanges_ObjectFieldSpec,
                Query.OracleRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# OPTIONAL
	shouldIncludeDbSnapshotSummaries = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryOracleRecoverableRanges
}