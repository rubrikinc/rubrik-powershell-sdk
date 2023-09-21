// New-RscGqlMutationAssignSlaToMongoDbCollection.cs
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
    /// Create new GraphQL Mutation assignSlaToMongoDbCollection
    /// assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationAssignSlaToMongoDbCollection")
    ]
    public class New_RscGqlMutationAssignSlaToMongoDbCollection : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("assignSlaToMongoDbCollection");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation assignSlaToMongoDbCollection
        /// assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_assignSlaToMongoDbCollection();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_assignSlaToMongoDbCollection()
        {
            this._logger.name += " -assignSlaToMongoDbCollection";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaToMongoDbCollectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSlaToMongoDbCollection",
                "($input: AssignSlaToMongoDbCollectionInput!)",
                "AsyncRequestStatus",
                Mutation.AssignSlaToMongoDbCollection_ObjectFieldSpec,
                Mutation.AssignSlaToMongoDbCollectionFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	input = @{
		# REQUIRED
		ids = @(
			<System.String>
		)
		# REQUIRED
		slaId = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationAssignSlaToMongoDbCollection
}