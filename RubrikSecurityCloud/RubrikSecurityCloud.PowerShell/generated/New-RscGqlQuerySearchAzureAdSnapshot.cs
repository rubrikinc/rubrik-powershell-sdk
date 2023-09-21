// New-RscGqlQuerySearchAzureAdSnapshot.cs
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
    /// Create new GraphQL Query searchAzureAdSnapshot
    /// searchAzureAdSnapshot(first: Int, after: String, input: SearchAzureAdSnapshotInput!): AzureAdObjectConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQuerySearchAzureAdSnapshot")
    ]
    public class New_RscGqlQuerySearchAzureAdSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("searchAzureAdSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query searchAzureAdSnapshot
        /// searchAzureAdSnapshot(first: Int, after: String, input: SearchAzureAdSnapshotInput!): AzureAdObjectConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_searchAzureAdSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_searchAzureAdSnapshot()
        {
            this._logger.name += " -searchAzureAdSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("input", "SearchAzureAdSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchAzureAdSnapshot",
                "($first: Int,$after: String,$input: SearchAzureAdSnapshotInput!)",
                "AzureAdObjectConnection",
                Query.SearchAzureAdSnapshot_ObjectFieldSpec,
                Query.SearchAzureAdSnapshotFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	azureAdSearchKeyword = <System.String>
	# REQUIRED
	azureAdObjectType = <AzureAdObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectType]) for enum values.
	# REQUIRED
	azureAdSearchKeywordType = <AzureAdObjectSearchType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureAdObjectSearchType]) for enum values.
}"
            );
        }

    } // class New-RscGqlQuerySearchAzureAdSnapshot
}