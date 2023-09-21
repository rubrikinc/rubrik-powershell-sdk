// New-RscGqlQueryAzureSqlManagedInstanceServers.cs
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
    /// Create new GraphQL Query azureSqlManagedInstanceServers
    /// azureSqlManagedInstanceServers(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AzureSqlManagedInstanceServerSortFields
    ///     sortOrder: SortOrder
    ///     azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters
    ///   ): AzureSqlManagedInstanceServerConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureSqlManagedInstanceServers")
    ]
    public class New_RscGqlQueryAzureSqlManagedInstanceServers : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSqlManagedInstanceServers");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureSqlManagedInstanceServers
        /// azureSqlManagedInstanceServers(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AzureSqlManagedInstanceServerSortFields
        ///     sortOrder: SortOrder
        ///     azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters
        ///   ): AzureSqlManagedInstanceServerConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSqlManagedInstanceServers();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSqlManagedInstanceServers()
        {
            this._logger.name += " -azureSqlManagedInstanceServers";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceServerSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceServerFilters", "AzureSqlManagedInstanceServerFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceServers",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceServerSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceServerFilters: AzureSqlManagedInstanceServerFilters)",
                "AzureSqlManagedInstanceServerConnection",
                Query.AzureSqlManagedInstanceServers_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceServersFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlManagedInstanceServerSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceServerSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlManagedInstanceServerFilters = @{
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
}"
            );
        }

    } // class New-RscGqlQueryAzureSqlManagedInstanceServers
}