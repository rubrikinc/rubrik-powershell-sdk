// New-RscGqlMutationBulkDeleteMongodbSources.cs
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
    /// Create new GraphQL Mutation bulkDeleteMongodbSources
    /// bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationBulkDeleteMongodbSources")
    ]
    public class New_RscGqlMutationBulkDeleteMongodbSources : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("bulkDeleteMongodbSources");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation bulkDeleteMongodbSources
        /// bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_bulkDeleteMongodbSources();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_bulkDeleteMongodbSources()
        {
            this._logger.name += " -bulkDeleteMongodbSources";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteMosaicSourcesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteMongodbSources",
                "($input: BulkDeleteMosaicSourcesInput!)",
                "MosaicAsyncResponse",
                Mutation.BulkDeleteMongodbSources_ObjectFieldSpec,
                Mutation.BulkDeleteMongodbSourcesFieldSpec,
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

    } // class New-RscGqlMutationBulkDeleteMongodbSources
}