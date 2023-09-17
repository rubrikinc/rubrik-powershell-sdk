// Invoke-RscGqlMutateCreateO365AppComplete.cs
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
    /// Invoke GraphQL Mutation createO365AppComplete
    /// createO365AppComplete(input: CreateO365AppCompleteInput!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateCreateO365AppComplete")
    ]
    public class Invoke_RscGqlMutateCreateO365AppComplete : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createO365AppComplete");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation createO365AppComplete
        /// createO365AppComplete(input: CreateO365AppCompleteInput!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createO365AppComplete();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createO365AppComplete()
        {
            this._logger.name += " -createO365AppComplete";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateO365AppCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateO365AppComplete",
                "($input: CreateO365AppCompleteInput!)",
                "RequestStatus",
                Mutation.CreateO365AppComplete_ObjectFieldSpec,
                Mutation.CreateO365AppCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appClientId = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	tenantId = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateCreateO365AppComplete
}