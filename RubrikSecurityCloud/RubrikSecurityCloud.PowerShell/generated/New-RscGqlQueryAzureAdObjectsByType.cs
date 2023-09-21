// New-RscGqlQueryAzureAdObjectsByType.cs
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
    /// Create new GraphQL Query azureAdObjectsByType
    /// azureAdObjectsByType(
    ///     first: Int
    ///     after: String
    ///     sortByOption: [AzureAdObjectSearchType!]
    ///     sortOrder: SortOrder
    ///     input: AzureAdObjectTypeInput!
    ///   ): AzureAdObjectConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureAdObjectsByType")
    ]
    public class New_RscGqlQueryAzureAdObjectsByType : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureAdObjectsByType");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureAdObjectsByType
        /// azureAdObjectsByType(
        ///     first: Int
        ///     after: String
        ///     sortByOption: [AzureAdObjectSearchType!]
        ///     sortOrder: SortOrder
        ///     input: AzureAdObjectTypeInput!
        ///   ): AzureAdObjectConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureAdObjectsByType();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureAdObjectsByType()
        {
            this._logger.name += " -azureAdObjectsByType";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortByOption", "[AzureAdObjectSearchType!]"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("input", "AzureAdObjectTypeInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdObjectsByType",
                "($first: Int,$after: String,$sortByOption: [AzureAdObjectSearchType!],$sortOrder: SortOrder,$input: AzureAdObjectTypeInput!)",
                "AzureAdObjectConnection",
                Query.AzureAdObjectsByType_ObjectFieldSpec,
                Query.AzureAdObjectsByTypeFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortByOption = @(
	<AzureAdObjectSearchType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
)
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	azureAdObjectType = <AzureAdObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
}"
            );
        }

    } // class New-RscGqlQueryAzureAdObjectsByType
}