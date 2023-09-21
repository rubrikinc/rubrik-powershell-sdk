// New-RscGqlQueryMssqlDatabaseMissedRecoverableRanges.cs
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
    /// Create new GraphQL Query mssqlDatabaseMissedRecoverableRanges
    /// mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!): MssqlMissedRecoverableRangeListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMssqlDatabaseMissedRecoverableRanges")
    ]
    public class New_RscGqlQueryMssqlDatabaseMissedRecoverableRanges : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mssqlDatabaseMissedRecoverableRanges");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mssqlDatabaseMissedRecoverableRanges
        /// mssqlDatabaseMissedRecoverableRanges(input: GetMssqlDbMissedRecoverableRangesInput!): MssqlMissedRecoverableRangeListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mssqlDatabaseMissedRecoverableRanges();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mssqlDatabaseMissedRecoverableRanges()
        {
            this._logger.name += " -mssqlDatabaseMissedRecoverableRanges";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMssqlDbMissedRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseMissedRecoverableRanges",
                "($input: GetMssqlDbMissedRecoverableRangesInput!)",
                "MssqlMissedRecoverableRangeListResponse",
                Query.MssqlDatabaseMissedRecoverableRanges_ObjectFieldSpec,
                Query.MssqlDatabaseMissedRecoverableRangesFieldSpec,
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

    } // class New-RscGqlQueryMssqlDatabaseMissedRecoverableRanges
}