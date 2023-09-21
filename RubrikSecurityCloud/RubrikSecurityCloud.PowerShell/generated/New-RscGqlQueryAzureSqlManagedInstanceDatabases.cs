// New-RscGqlQueryAzureSqlManagedInstanceDatabases.cs
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
    /// Create new GraphQL Query azureSqlManagedInstanceDatabases
    /// azureSqlManagedInstanceDatabases(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AzureSqlManagedInstanceDatabaseSortFields
    ///     sortOrder: SortOrder
    ///     azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters
    ///   ): AzureSqlManagedInstanceDatabaseConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureSqlManagedInstanceDatabases")
    ]
    public class New_RscGqlQueryAzureSqlManagedInstanceDatabases : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureSqlManagedInstanceDatabases");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureSqlManagedInstanceDatabases
        /// azureSqlManagedInstanceDatabases(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AzureSqlManagedInstanceDatabaseSortFields
        ///     sortOrder: SortOrder
        ///     azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters
        ///   ): AzureSqlManagedInstanceDatabaseConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureSqlManagedInstanceDatabases();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureSqlManagedInstanceDatabases()
        {
            this._logger.name += " -azureSqlManagedInstanceDatabases";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AzureSqlManagedInstanceDatabaseSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("azureSqlManagedInstanceDatabaseFilters", "AzureSqlManagedInstanceDatabaseFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureSqlManagedInstanceDatabases",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AzureSqlManagedInstanceDatabaseSortFields,$sortOrder: SortOrder,$azureSqlManagedInstanceDatabaseFilters: AzureSqlManagedInstanceDatabaseFilters)",
                "AzureSqlManagedInstanceDatabaseConnection",
                Query.AzureSqlManagedInstanceDatabases_ObjectFieldSpec,
                Query.AzureSqlManagedInstanceDatabasesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlManagedInstanceDatabaseSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceDatabaseSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlManagedInstanceDatabaseFilters = @{
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
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			<System.String>
		)
	}
}"
            );
        }

    } // class New-RscGqlQueryAzureSqlManagedInstanceDatabases
}