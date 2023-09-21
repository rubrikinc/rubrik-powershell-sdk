// New-RscGqlQueryClusterWithUpgradesInfo.cs
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
    /// Create new GraphQL Query clusterWithUpgradesInfo
    /// clusterWithUpgradesInfo(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     upgradeFilter: CdmUpgradeInfoFilterInput
    ///     sortOrder: SortOrder = DESC
    ///     sortBy: UpgradeInfoSortByEnum = ClusterType
    ///   ): ClusterConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryClusterWithUpgradesInfo")
    ]
    public class New_RscGqlQueryClusterWithUpgradesInfo : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("clusterWithUpgradesInfo");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query clusterWithUpgradesInfo
        /// clusterWithUpgradesInfo(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     upgradeFilter: CdmUpgradeInfoFilterInput
        ///     sortOrder: SortOrder = DESC
        ///     sortBy: UpgradeInfoSortByEnum = ClusterType
        ///   ): ClusterConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_clusterWithUpgradesInfo();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_clusterWithUpgradesInfo()
        {
            this._logger.name += " -clusterWithUpgradesInfo";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("upgradeFilter", "CdmUpgradeInfoFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "UpgradeInfoSortByEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterWithUpgradesInfo",
                "($first: Int,$after: String,$last: Int,$before: String,$upgradeFilter: CdmUpgradeInfoFilterInput,$sortOrder: SortOrder,$sortBy: UpgradeInfoSortByEnum)",
                "ClusterConnection",
                Query.ClusterWithUpgradesInfo_ObjectFieldSpec,
                Query.ClusterWithUpgradesInfoFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.upgradeFilter = @{
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
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	downloadedVersion = @(
		<System.String>
	)
	# OPTIONAL
	installedVersion = @(
		<System.String>
	)
	# OPTIONAL
	upgradeJobStatus = @(
		<ClusterJobStatusTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterJobStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	versionStatus = @(
		<VersionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionStatus]) for enum values.
	)
	# OPTIONAL
	prechecksStatus = @(
		<PrechecksStatusTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrechecksStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	upgradeScheduled = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
}
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <UpgradeInfoSortByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UpgradeInfoSortByEnum]) for enum values."
            );
        }

    } // class New-RscGqlQueryClusterWithUpgradesInfo
}