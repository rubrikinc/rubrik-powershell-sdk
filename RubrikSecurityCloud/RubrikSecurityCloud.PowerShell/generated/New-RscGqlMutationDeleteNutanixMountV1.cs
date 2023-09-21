// New-RscGqlMutationDeleteNutanixMountV1.cs
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
    /// Create new GraphQL Mutation deleteNutanixMountV1
    /// deleteNutanixMountV1(input: DeleteNutanixMountV1Input!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteNutanixMountV1")
    ]
    public class New_RscGqlMutationDeleteNutanixMountV1 : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteNutanixMountV1");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteNutanixMountV1
        /// deleteNutanixMountV1(input: DeleteNutanixMountV1Input!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteNutanixMountV1();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteNutanixMountV1()
        {
            this._logger.name += " -deleteNutanixMountV1";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixMountV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixMountV1",
                "($input: DeleteNutanixMountV1Input!)",
                "AsyncRequestStatus",
                Mutation.DeleteNutanixMountV1_ObjectFieldSpec,
                Mutation.DeleteNutanixMountV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteNutanixMountV1
}