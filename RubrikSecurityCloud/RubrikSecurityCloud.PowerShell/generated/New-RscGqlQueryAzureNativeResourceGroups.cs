// New-RscGqlQueryAzureNativeResourceGroups.cs
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
    /// Create new GraphQL Query azureNativeResourceGroups
    /// azureNativeResourceGroups(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AzureNativeCommonResourceGroupSortFields
    ///     sortOrder: SortOrder
    ///     commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters
    ///     protectedObjectTypes: [WorkloadLevelHierarchy!]
    ///     azureNativeProtectionFeatures: [AzureNativeProtectionFeature!]
    ///   ): AzureNativeResourceGroupConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureNativeResourceGroups")
    ]
    public class New_RscGqlQueryAzureNativeResourceGroups : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureNativeResourceGroups");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureNativeResourceGroups
        /// azureNativeResourceGroups(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AzureNativeCommonResourceGroupSortFields
        ///     sortOrder: SortOrder
        ///     commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters
        ///     protectedObjectTypes: [WorkloadLevelHierarchy!]
        ///     azureNativeProtectionFeatures: [AzureNativeProtectionFeature!]
        ///   ): AzureNativeResourceGroupConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureNativeResourceGroups();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureNativeResourceGroups()
        {
            this._logger.name += " -azureNativeResourceGroups";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeCommonResourceGroupSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("commonResourceGroupFilters", "AzureNativeCommonResourceGroupFilters"),
                Tuple.Create("protectedObjectTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("azureNativeProtectionFeatures", "[AzureNativeProtectionFeature!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeResourceGroups",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeCommonResourceGroupSortFields,$sortOrder: SortOrder,$commonResourceGroupFilters: AzureNativeCommonResourceGroupFilters,$protectedObjectTypes: [WorkloadLevelHierarchy!],$azureNativeProtectionFeatures: [AzureNativeProtectionFeature!])",
                "AzureNativeResourceGroupConnection",
                Query.AzureNativeResourceGroups_ObjectFieldSpec,
                Query.AzureNativeResourceGroupsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeCommonResourceGroupSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeCommonResourceGroupSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.commonResourceGroupFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
}
# OPTIONAL
$inputs.Var.protectedObjectTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$inputs.Var.azureNativeProtectionFeatures = @(
	<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
)"
            );
        }

    } // class New-RscGqlQueryAzureNativeResourceGroups
}