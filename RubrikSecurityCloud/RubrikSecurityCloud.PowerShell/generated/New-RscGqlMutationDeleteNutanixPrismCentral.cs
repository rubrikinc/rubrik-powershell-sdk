// New-RscGqlMutationDeleteNutanixPrismCentral.cs
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
    /// Create new GraphQL Mutation deleteNutanixPrismCentral
    /// deleteNutanixPrismCentral(input: DeleteNutanixPrismCentralInput!): BatchAsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteNutanixPrismCentral")
    ]
    public class New_RscGqlMutationDeleteNutanixPrismCentral : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteNutanixPrismCentral");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteNutanixPrismCentral
        /// deleteNutanixPrismCentral(input: DeleteNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteNutanixPrismCentral();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteNutanixPrismCentral()
        {
            this._logger.name += " -deleteNutanixPrismCentral";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteNutanixPrismCentralInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteNutanixPrismCentral",
                "($input: DeleteNutanixPrismCentralInput!)",
                "BatchAsyncRequestStatus",
                Mutation.DeleteNutanixPrismCentral_ObjectFieldSpec,
                Mutation.DeleteNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDeleteNutanixPrismCentral
}