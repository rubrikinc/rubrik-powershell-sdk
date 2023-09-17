// Invoke-RscGqlMutateAddO365Org.cs
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
    /// Invoke GraphQL Mutation addO365Org
    /// addO365Org(input: AddO365OrgInput!): AddO365OrgResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateAddO365Org")
    ]
    public class Invoke_RscGqlMutateAddO365Org : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("addO365Org");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation addO365Org
        /// addO365Org(input: AddO365OrgInput!): AddO365OrgResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_addO365Org();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_addO365Org()
        {
            this._logger.name += " -addO365Org";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddO365OrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddO365Org",
                "($input: AddO365OrgInput!)",
                "AddO365OrgResponse",
                Mutation.AddO365Org_ObjectFieldSpec,
                Mutation.AddO365OrgFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	exocomputeClusterId = <System.String>
	# REQUIRED
	appTypes = @(
		<System.String>
	)
}"
            );
        }

    } // class Invoke-RscGqlMutateAddO365Org
}