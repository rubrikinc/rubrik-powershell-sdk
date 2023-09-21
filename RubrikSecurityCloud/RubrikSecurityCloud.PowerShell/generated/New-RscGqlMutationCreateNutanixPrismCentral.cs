// New-RscGqlMutationCreateNutanixPrismCentral.cs
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
    /// Create new GraphQL Mutation createNutanixPrismCentral
    /// createNutanixPrismCentral(input: CreateNutanixPrismCentralInput!): BatchAsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateNutanixPrismCentral")
    ]
    public class New_RscGqlMutationCreateNutanixPrismCentral : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createNutanixPrismCentral");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createNutanixPrismCentral
        /// createNutanixPrismCentral(input: CreateNutanixPrismCentralInput!): BatchAsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createNutanixPrismCentral();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createNutanixPrismCentral()
        {
            this._logger.name += " -createNutanixPrismCentral";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateNutanixPrismCentralInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateNutanixPrismCentral",
                "($input: CreateNutanixPrismCentralInput!)",
                "BatchAsyncRequestStatus",
                Mutation.CreateNutanixPrismCentral_ObjectFieldSpec,
                Mutation.CreateNutanixPrismCentralFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	prismCentralConfig = @{
		# REQUIRED
		caCerts = <System.String>
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
	# REQUIRED
	prismElementCdmTuple = @(
		@{
			# REQUIRED
			nutanixClusterId = <System.String>
			# REQUIRED
			cdmClusterId = <System.String>
		}
	)
}"
            );
        }

    } // class New-RscGqlMutationCreateNutanixPrismCentral
}