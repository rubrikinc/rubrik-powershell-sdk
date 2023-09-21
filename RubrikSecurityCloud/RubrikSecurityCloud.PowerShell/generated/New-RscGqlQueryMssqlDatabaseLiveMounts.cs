// New-RscGqlQueryMssqlDatabaseLiveMounts.cs
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
    /// Create new GraphQL Query mssqlDatabaseLiveMounts
    /// mssqlDatabaseLiveMounts(
    ///     first: Int
    ///     after: String
    ///     sortBy: MssqlDatabaseLiveMountSortByInput
    ///     filters: [MssqlDatabaseLiveMountFilterInput!]
    ///   ): MssqlDatabaseLiveMountConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryMssqlDatabaseLiveMounts")
    ]
    public class New_RscGqlQueryMssqlDatabaseLiveMounts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mssqlDatabaseLiveMounts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query mssqlDatabaseLiveMounts
        /// mssqlDatabaseLiveMounts(
        ///     first: Int
        ///     after: String
        ///     sortBy: MssqlDatabaseLiveMountSortByInput
        ///     filters: [MssqlDatabaseLiveMountFilterInput!]
        ///   ): MssqlDatabaseLiveMountConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mssqlDatabaseLiveMounts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mssqlDatabaseLiveMounts()
        {
            this._logger.name += " -mssqlDatabaseLiveMounts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "MssqlDatabaseLiveMountSortByInput"),
                Tuple.Create("filters", "[MssqlDatabaseLiveMountFilterInput!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryMssqlDatabaseLiveMounts",
                "($first: Int,$after: String,$sortBy: MssqlDatabaseLiveMountSortByInput,$filters: [MssqlDatabaseLiveMountFilterInput!])",
                "MssqlDatabaseLiveMountConnection",
                Query.MssqlDatabaseLiveMounts_ObjectFieldSpec,
                Query.MssqlDatabaseLiveMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <MssqlDatabaseLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <MssqlDatabaseLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)"
            );
        }

    } // class New-RscGqlQueryMssqlDatabaseLiveMounts
}