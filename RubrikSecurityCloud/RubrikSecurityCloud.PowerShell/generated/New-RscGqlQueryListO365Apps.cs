// New-RscGqlQueryListO365Apps.cs
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
    /// Create new GraphQL Query listO365Apps
    /// listO365Apps(
    ///     first: Int
    ///     after: String
    ///     o365AppFilters: [AppFilter!]!
    ///     o365AppSortByParam: AppSortByParam
    ///   ): O365AppConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryListO365Apps")
    ]
    public class New_RscGqlQueryListO365Apps : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("listO365Apps");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query listO365Apps
        /// listO365Apps(
        ///     first: Int
        ///     after: String
        ///     o365AppFilters: [AppFilter!]!
        ///     o365AppSortByParam: AppSortByParam
        ///   ): O365AppConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_listO365Apps();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_listO365Apps()
        {
            this._logger.name += " -listO365Apps";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("o365AppFilters", "[AppFilter!]!"),
                Tuple.Create("o365AppSortByParam", "AppSortByParam"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryListO365Apps",
                "($first: Int,$after: String,$o365AppFilters: [AppFilter!]!,$o365AppSortByParam: AppSortByParam)",
                "O365AppConnection",
                Query.ListO365Apps_ObjectFieldSpec,
                Query.ListO365AppsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.o365AppFilters = @(
	@{
		# OPTIONAL
		field = <AppFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AppFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.o365AppSortByParam = @{
	# OPTIONAL
	field = <AppSortByParamField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AppSortByParamField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

    } // class New-RscGqlQueryListO365Apps
}