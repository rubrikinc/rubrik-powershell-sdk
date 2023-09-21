// New-RscGqlQueryAzureNativeVirtualMachines.cs
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
    /// Create new GraphQL Query azureNativeVirtualMachines
    /// azureNativeVirtualMachines(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AzureNativeVirtualMachineSortFields
    ///     sortOrder: SortOrder
    ///     descendantTypeFilter: [HierarchyObjectTypeEnum!]
    ///     virtualMachineFilters: AzureNativeVirtualMachineFilters
    ///   ): AzureNativeVirtualMachineConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureNativeVirtualMachines")
    ]
    public class New_RscGqlQueryAzureNativeVirtualMachines : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureNativeVirtualMachines");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureNativeVirtualMachines
        /// azureNativeVirtualMachines(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AzureNativeVirtualMachineSortFields
        ///     sortOrder: SortOrder
        ///     descendantTypeFilter: [HierarchyObjectTypeEnum!]
        ///     virtualMachineFilters: AzureNativeVirtualMachineFilters
        ///   ): AzureNativeVirtualMachineConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureNativeVirtualMachines();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureNativeVirtualMachines()
        {
            this._logger.name += " -azureNativeVirtualMachines";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeVirtualMachineSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("descendantTypeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("virtualMachineFilters", "AzureNativeVirtualMachineFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeVirtualMachines",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeVirtualMachineSortFields,$sortOrder: SortOrder,$descendantTypeFilter: [HierarchyObjectTypeEnum!],$virtualMachineFilters: AzureNativeVirtualMachineFilters)",
                "AzureNativeVirtualMachineConnection",
                Query.AzureNativeVirtualMachines_ObjectFieldSpec,
                Query.AzureNativeVirtualMachinesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeVirtualMachineSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeVirtualMachineSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.descendantTypeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.virtualMachineFilters = @{
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
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
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
	vmSizeFilter = @{
		# REQUIRED
		vmSizes = @(
			<System.String>
		)
	}
	# OPTIONAL
	vnetFilter = @{
		# REQUIRED
		vnetNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	exocomputeConnectedFilter = @{
		# REQUIRED
		isConnected = <System.Boolean>
	}
	# OPTIONAL
	fileIndexingFilter = @{
		# REQUIRED
		statuses = @(
			<AzureNativeFileIndexingStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
		)
	}
	# OPTIONAL
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = <System.Boolean>
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = <CloudInstanceRbsConnectionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
}"
            );
        }

    } // class New-RscGqlQueryAzureNativeVirtualMachines
}