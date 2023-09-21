// New-RscGqlMutationO365OauthConsentComplete.cs
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
    /// Create new GraphQL Mutation o365OauthConsentComplete
    /// o365OauthConsentComplete(input: O365OauthConsentCompleteInput!): O365OauthConsentCompleteReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationO365OauthConsentComplete")
    ]
    public class New_RscGqlMutationO365OauthConsentComplete : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("o365OauthConsentComplete");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation o365OauthConsentComplete
        /// o365OauthConsentComplete(input: O365OauthConsentCompleteInput!): O365OauthConsentCompleteReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_o365OauthConsentComplete();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_o365OauthConsentComplete()
        {
            this._logger.name += " -o365OauthConsentComplete";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "O365OauthConsentCompleteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationO365OauthConsentComplete",
                "($input: O365OauthConsentCompleteInput!)",
                "O365OauthConsentCompleteReply",
                Mutation.O365OauthConsentComplete_ObjectFieldSpec,
                Mutation.O365OauthConsentCompleteFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	code = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# REQUIRED
	resourceNaturalId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationO365OauthConsentComplete
}