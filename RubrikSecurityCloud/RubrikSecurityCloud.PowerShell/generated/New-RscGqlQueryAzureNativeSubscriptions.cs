// New-RscGqlQueryAzureNativeSubscriptions.cs
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
    /// Create new GraphQL Query azureNativeSubscriptions
    /// azureNativeSubscriptions(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AzureNativeSubscriptionSortFields
    ///     sortOrder: SortOrder
    ///     subscriptionFilters: AzureNativeSubscriptionFilters
    ///     authorizedOperationFilter: Operation
    ///     workloadHierarchy: WorkloadLevelHierarchy
    ///     azureNativeProtectionFeature: AzureNativeProtectionFeature
    ///   ): AzureNativeSubscriptionConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureNativeSubscriptions")
    ]
    public class New_RscGqlQueryAzureNativeSubscriptions : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureNativeSubscriptions");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureNativeSubscriptions
        /// azureNativeSubscriptions(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AzureNativeSubscriptionSortFields
        ///     sortOrder: SortOrder
        ///     subscriptionFilters: AzureNativeSubscriptionFilters
        ///     authorizedOperationFilter: Operation
        ///     workloadHierarchy: WorkloadLevelHierarchy
        ///     azureNativeProtectionFeature: AzureNativeProtectionFeature
        ///   ): AzureNativeSubscriptionConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureNativeSubscriptions();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureNativeSubscriptions()
        {
            this._logger.name += " -azureNativeSubscriptions";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeSubscriptionSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("subscriptionFilters", "AzureNativeSubscriptionFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                Tuple.Create("azureNativeProtectionFeature", "AzureNativeProtectionFeature"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeSubscriptions",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeSubscriptionSortFields,$sortOrder: SortOrder,$subscriptionFilters: AzureNativeSubscriptionFilters,$authorizedOperationFilter: Operation,$workloadHierarchy: WorkloadLevelHierarchy,$azureNativeProtectionFeature: AzureNativeProtectionFeature)",
                "AzureNativeSubscriptionConnection",
                Query.AzureNativeSubscriptions_ObjectFieldSpec,
                Query.AzureNativeSubscriptionsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeSubscriptionSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeSubscriptionSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.subscriptionFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
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
$inputs.Var.authorizedOperationFilter = <Operation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# OPTIONAL
$inputs.Var.workloadHierarchy = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$inputs.Var.azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values."
            );
        }

    } // class New-RscGqlQueryAzureNativeSubscriptions
}