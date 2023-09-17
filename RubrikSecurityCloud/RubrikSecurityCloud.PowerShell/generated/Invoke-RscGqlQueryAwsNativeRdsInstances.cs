// Invoke-RscGqlQueryAwsNativeRdsInstances.cs
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
    /// Invoke GraphQL Query awsNativeRdsInstances
    /// awsNativeRdsInstances(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AwsNativeRdsInstanceSortFields
    ///     sortOrder: SortOrder
    ///     rdsInstanceFilters: AwsNativeRdsInstanceFilters
    ///   ): AwsNativeRdsInstanceConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAwsNativeRdsInstances")
    ]
    public class Invoke_RscGqlQueryAwsNativeRdsInstances : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeRdsInstances");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query awsNativeRdsInstances
        /// awsNativeRdsInstances(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AwsNativeRdsInstanceSortFields
        ///     sortOrder: SortOrder
        ///     rdsInstanceFilters: AwsNativeRdsInstanceFilters
        ///   ): AwsNativeRdsInstanceConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeRdsInstances();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeRdsInstances()
        {
            this._logger.name += " -awsNativeRdsInstances";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeRdsInstanceSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("rdsInstanceFilters", "AwsNativeRdsInstanceFilters"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstances",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeRdsInstanceSortFields,$sortOrder: SortOrder,$rdsInstanceFilters: AwsNativeRdsInstanceFilters)",
                "AwsNativeRdsInstanceConnection",
                Query.AwsNativeRdsInstances_ObjectFieldSpec,
                Query.AwsNativeRdsInstancesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeRdsInstanceSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsInstanceSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.rdsInstanceFilters = @{
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
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
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
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	dbEngineFilter = @{
		# REQUIRED
		dbEngines = @(
			<AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
		)
	}
	# OPTIONAL
	dbInstanceClassFilter = @{
		# REQUIRED
		dbInstanceClasses = @(
			<AwsNativeRdsDbInstanceClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			<System.String>
		)
	}
}"
            );
        }

    } // class Invoke-RscGqlQueryAwsNativeRdsInstances
}