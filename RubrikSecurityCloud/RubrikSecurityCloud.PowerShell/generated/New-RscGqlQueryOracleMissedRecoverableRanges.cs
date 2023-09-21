// New-RscGqlQueryOracleMissedRecoverableRanges.cs
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
    /// Create new GraphQL Query oracleMissedRecoverableRanges
    /// oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!): OracleMissedRecoverableRangeListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleMissedRecoverableRanges")
    ]
    public class New_RscGqlQueryOracleMissedRecoverableRanges : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleMissedRecoverableRanges");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleMissedRecoverableRanges
        /// oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!): OracleMissedRecoverableRangeListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleMissedRecoverableRanges();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleMissedRecoverableRanges()
        {
            this._logger.name += " -oracleMissedRecoverableRanges";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbMissedRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleMissedRecoverableRanges",
                "($input: GetOracleDbMissedRecoverableRangesInput!)",
                "OracleMissedRecoverableRangeListResponse",
                Query.OracleMissedRecoverableRanges_ObjectFieldSpec,
                Query.OracleMissedRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryOracleMissedRecoverableRanges
}