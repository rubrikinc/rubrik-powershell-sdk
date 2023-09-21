// New-RscGqlQueryAwsNativeAccounts.cs
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
    /// Create new GraphQL Query awsNativeAccounts
    /// awsNativeAccounts(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AwsNativeAccountSortFields
    ///     sortOrder: SortOrder
    ///     accountFilters: AwsNativeAccountFilters
    ///     authorizedOperationFilter: Operation
    ///     awsNativeProtectionFeature: AwsNativeProtectionFeature!
    ///   ): AwsNativeAccountConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsNativeAccounts")
    ]
    public class New_RscGqlQueryAwsNativeAccounts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeAccounts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsNativeAccounts
        /// awsNativeAccounts(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AwsNativeAccountSortFields
        ///     sortOrder: SortOrder
        ///     accountFilters: AwsNativeAccountFilters
        ///     authorizedOperationFilter: Operation
        ///     awsNativeProtectionFeature: AwsNativeProtectionFeature!
        ///   ): AwsNativeAccountConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeAccounts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeAccounts()
        {
            this._logger.name += " -awsNativeAccounts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeAccountSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("accountFilters", "AwsNativeAccountFilters"),
                Tuple.Create("authorizedOperationFilter", "Operation"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccounts",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeAccountSortFields,$sortOrder: SortOrder,$accountFilters: AwsNativeAccountFilters,$authorizedOperationFilter: Operation,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccountConnection",
                Query.AwsNativeAccounts_ObjectFieldSpec,
                Query.AwsNativeAccountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeAccountSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeAccountSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.accountFilters = @{
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
	cloudTypeFilter = @{
		# REQUIRED
		cloudTypes = @(
			<AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		)
	}
}
# OPTIONAL
$inputs.Var.authorizedOperationFilter = <Operation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# REQUIRED
$inputs.Var.awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

    } // class New-RscGqlQueryAwsNativeAccounts
}