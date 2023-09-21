// New-RscGqlMutationDeleteCassandraSource.cs
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
    /// Create new GraphQL Mutation deleteCassandraSource
    /// deleteCassandraSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteCassandraSource")
    ]
    public class New_RscGqlMutationDeleteCassandraSource : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteCassandraSource");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteCassandraSource
        /// deleteCassandraSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteCassandraSource();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteCassandraSource()
        {
            this._logger.name += " -deleteCassandraSource";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCassandraSource",
                "($input: DeleteMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.DeleteCassandraSource_ObjectFieldSpec,
                Mutation.DeleteCassandraSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2DeleteMosaicSourceRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceName = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteCassandraSource
}