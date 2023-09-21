// New-RscGqlMutationDeleteDb2Instance.cs
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
    /// Create new GraphQL Mutation deleteDb2Instance
    /// deleteDb2Instance(input: DeleteDb2InstanceInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteDb2Instance")
    ]
    public class New_RscGqlMutationDeleteDb2Instance : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteDb2Instance");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteDb2Instance
        /// deleteDb2Instance(input: DeleteDb2InstanceInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteDb2Instance();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteDb2Instance()
        {
            this._logger.name += " -deleteDb2Instance";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteDb2InstanceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteDb2Instance",
                "($input: DeleteDb2InstanceInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteDb2Instance_ObjectFieldSpec,
                Mutation.DeleteDb2InstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteDb2Instance
}