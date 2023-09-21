// New-RscGqlQueryClusterConnection.cs
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
    /// Create new GraphQL Query clusterConnection
    /// clusterConnection(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     filter: ClusterFilterInput
    ///     sortOrder: SortOrder = DESC
    ///     sortBy: ClusterSortByEnum = ClusterType
    ///   ): ClusterConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterConnection")
    ]
    public class New_RscGqlQueryClusterConnection : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterConnection");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterConnection
        /// clusterConnection(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     filter: ClusterFilterInput
        ///     sortOrder: SortOrder = DESC
        ///     sortBy: ClusterSortByEnum = ClusterType
        ///   ): ClusterConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterConnection();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterConnection()
        {
            this._logger.name += " -clusterConnection";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "ClusterFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ClusterSortByEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)",
                "ClusterConnection",
                Query.ClusterConnection_ObjectFieldSpec,
                Query.ClusterConnectionFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	id = @(
		<System.String>
	)
	# OPTIONAL
	name = @(
		<System.String>
	)
	# OPTIONAL
	type = @(
		<ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	objectType = @(
		<ObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	excludeEmptyCluster = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
	# OPTIONAL
	registeredMode = @(
		<ClusterRegistrationMode> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
	)
	# OPTIONAL
	product = <Product> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
	# OPTIONAL
	orgId = @(
		<System.String>
	)
	# OPTIONAL
	productFilters = @(
		@{
			# REQUIRED
			productType = <ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
			# OPTIONAL
			minSoftwareVersion = <System.String>
		}
	)
	# OPTIONAL
	excludeId = @(
		<System.String>
	)
	# OPTIONAL
	systemStatus = @(
		<ClusterSystemStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	isInFatalOrDisconnectedState = <System.Boolean>
}
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <ClusterSortByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values."
            );
        }

    } // class New-RscGqlQueryClusterConnection
}