// New-RscGqlMutationDiscoverDb2Instance.cs
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
    /// Create new GraphQL Mutation discoverDb2Instance
    /// discoverDb2Instance(input: DiscoverDb2InstanceInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDiscoverDb2Instance")
    ]
    public class New_RscGqlMutationDiscoverDb2Instance : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("discoverDb2Instance");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation discoverDb2Instance
        /// discoverDb2Instance(input: DiscoverDb2InstanceInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_discoverDb2Instance();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_discoverDb2Instance()
        {
            this._logger.name += " -discoverDb2Instance";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDiscoverDb2Instance",
                "($input: DiscoverDb2InstanceInput!)",
                "AsyncRequestStatus",
                Mutation.DiscoverDb2Instance_ObjectFieldSpec,
                Mutation.DiscoverDb2InstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDiscoverDb2Instance
}