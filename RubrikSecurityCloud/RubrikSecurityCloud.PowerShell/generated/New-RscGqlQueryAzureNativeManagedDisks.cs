// New-RscGqlQueryAzureNativeManagedDisks.cs
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
    /// Create new GraphQL Query azureNativeManagedDisks
    /// azureNativeManagedDisks(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AzureNativeDiskSortFields
    ///     sortOrder: SortOrder
    ///     diskFilters: AzureNativeDiskFilters
    ///   ): AzureNativeManagedDiskConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureNativeManagedDisks")
    ]
    public class New_RscGqlQueryAzureNativeManagedDisks : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureNativeManagedDisks");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureNativeManagedDisks
        /// azureNativeManagedDisks(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AzureNativeDiskSortFields
        ///     sortOrder: SortOrder
        ///     diskFilters: AzureNativeDiskFilters
        ///   ): AzureNativeManagedDiskConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureNativeManagedDisks();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureNativeManagedDisks()
        {
            this._logger.name += " -azureNativeManagedDisks";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureNativeDiskSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("diskFilters", "AzureNativeDiskFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisks",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureNativeDiskSortFields,$sortOrder: SortOrder,$diskFilters: AzureNativeDiskFilters)",
                "AzureNativeManagedDiskConnection",
                Query.AzureNativeManagedDisks_ObjectFieldSpec,
                Query.AzureNativeManagedDisksFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeDiskSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeDiskSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.diskFilters = @{
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
	diskTypeFilter = @{
		# REQUIRED
		diskTypes = @(
			<System.String>
		)
	}
	# OPTIONAL
	attachedVmFilter = @{
		# REQUIRED
		virtualMachineIds = @(
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
}"
            );
        }

    } // class New-RscGqlQueryAzureNativeManagedDisks
}