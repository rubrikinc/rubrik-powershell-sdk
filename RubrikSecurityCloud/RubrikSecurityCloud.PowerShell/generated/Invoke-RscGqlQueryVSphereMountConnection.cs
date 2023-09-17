// Invoke-RscGqlQueryVSphereMountConnection.cs
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
    /// Invoke GraphQL Query vSphereMountConnection
    /// vSphereMountConnection(
    ///     first: Int
    ///     after: String
    ///     filter: VSphereMountFilter
    ///     sortBy: VsphereMountSortBy
    ///     sortOrder: SortOrder
    ///   ): VsphereMountConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryVSphereMountConnection")
    ]
    public class Invoke_RscGqlQueryVSphereMountConnection : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vSphereMountConnection");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query vSphereMountConnection
        /// vSphereMountConnection(
        ///     first: Int
        ///     after: String
        ///     filter: VSphereMountFilter
        ///     sortBy: VsphereMountSortBy
        ///     sortOrder: SortOrder
        ///   ): VsphereMountConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vSphereMountConnection();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vSphereMountConnection()
        {
            this._logger.name += " -vSphereMountConnection";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "VSphereMountFilter"),
                Tuple.Create("sortBy", "VsphereMountSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVsphereMountConnection",
                "($first: Int,$after: String,$filter: VSphereMountFilter,$sortBy: VsphereMountSortBy,$sortOrder: SortOrder)",
                "VsphereMountConnection",
                Query.VsphereMountConnection_ObjectFieldSpec,
                Query.VsphereMountConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	powerStatus = @(
		<System.Boolean>
	)
	# OPTIONAL
	sourceVmId = <System.String>
}
# OPTIONAL
$inputs.Var.sortBy = <VsphereMountSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereMountSortBy]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

    } // class Invoke-RscGqlQueryVSphereMountConnection
}