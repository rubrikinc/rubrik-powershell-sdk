// Invoke-RscGqlQueryAllAwsComputeSettings.cs
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
    /// Invoke GraphQL Query allAwsComputeSettings
    /// allAwsComputeSettings(
    ///     sortBy: AwsCloudComputeSettingQuerySortByField
    ///     sortOrder: SortOrder
    ///     filter: [AwsCloudComputeSettingFilterInput!]
    ///     contextFilter: ContextFilterTypeEnum
    ///   ): [AwsComputeSettings!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAllAwsComputeSettings")
    ]
    public class Invoke_RscGqlQueryAllAwsComputeSettings : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAwsComputeSettings");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query allAwsComputeSettings
        /// allAwsComputeSettings(
        ///     sortBy: AwsCloudComputeSettingQuerySortByField
        ///     sortOrder: SortOrder
        ///     filter: [AwsCloudComputeSettingFilterInput!]
        ///     contextFilter: ContextFilterTypeEnum
        ///   ): [AwsComputeSettings!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAwsComputeSettings();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAwsComputeSettings()
        {
            this._logger.name += " -allAwsComputeSettings";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sortBy", "AwsCloudComputeSettingQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[AwsCloudComputeSettingFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsComputeSettings",
                "($sortBy: AwsCloudComputeSettingQuerySortByField,$sortOrder: SortOrder,$filter: [AwsCloudComputeSettingFilterInput!],$contextFilter: ContextFilterTypeEnum)",
                "List<AwsComputeSettings>",
                Query.AllAwsComputeSettings_ObjectFieldSpec,
                Query.AllAwsComputeSettingsFieldSpec,
                @"# OPTIONAL
$inputs.Var.sortBy = <AwsCloudComputeSettingQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <AwsCloudComputeSettingFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingFilterField]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values."
            );
        }

    } // class Invoke-RscGqlQueryAllAwsComputeSettings
}