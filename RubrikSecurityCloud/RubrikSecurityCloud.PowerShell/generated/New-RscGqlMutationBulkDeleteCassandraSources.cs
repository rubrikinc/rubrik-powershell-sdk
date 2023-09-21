// New-RscGqlMutationBulkDeleteCassandraSources.cs
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
    /// Create new GraphQL Mutation bulkDeleteCassandraSources
    /// bulkDeleteCassandraSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBulkDeleteCassandraSources")
    ]
    public class New_RscGqlMutationBulkDeleteCassandraSources : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkDeleteCassandraSources");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation bulkDeleteCassandraSources
        /// bulkDeleteCassandraSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkDeleteCassandraSources();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkDeleteCassandraSources()
        {
            this._logger.name += " -bulkDeleteCassandraSources";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteMosaicSourcesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteCassandraSources",
                "($input: BulkDeleteMosaicSourcesInput!)",
                "MosaicAsyncResponse",
                Mutation.BulkDeleteCassandraSources_ObjectFieldSpec,
                Mutation.BulkDeleteCassandraSourcesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2BulkDeleteMosaicSourcesRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# REQUIRED
		sourceNames = @(
			<System.String>
		)
	}
}"
            );
        }

    } // class New-RscGqlMutationBulkDeleteCassandraSources
}