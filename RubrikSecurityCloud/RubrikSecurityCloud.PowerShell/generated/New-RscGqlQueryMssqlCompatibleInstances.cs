// New-RscGqlQueryMssqlCompatibleInstances.cs
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
    /// Create new GraphQL Query mssqlCompatibleInstances
    /// mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!): MssqlInstanceSummaryListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMssqlCompatibleInstances")
    ]
    public class New_RscGqlQueryMssqlCompatibleInstances : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mssqlCompatibleInstances");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mssqlCompatibleInstances
        /// mssqlCompatibleInstances(input: GetCompatibleMssqlInstancesV1Input!): MssqlInstanceSummaryListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mssqlCompatibleInstances();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mssqlCompatibleInstances()
        {
            this._logger.name += " -mssqlCompatibleInstances";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetCompatibleMssqlInstancesV1Input!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlCompatibleInstances",
                "($input: GetCompatibleMssqlInstancesV1Input!)",
                "MssqlInstanceSummaryListResponse",
                Query.MssqlCompatibleInstances_ObjectFieldSpec,
                Query.MssqlCompatibleInstancesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	recoveryTime = <DateTime>
	# REQUIRED
	recoveryType = <V1GetCompatibleMssqlInstancesV1RequestRecoveryType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1GetCompatibleMssqlInstancesV1RequestRecoveryType]) for enum values.
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryMssqlCompatibleInstances
}