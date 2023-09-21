// New-RscGqlMutationUpdateO365AppAuthStatus.cs
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
    /// Create new GraphQL Mutation updateO365AppAuthStatus
    /// updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!): UpdateO365AppAuthStatusReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateO365AppAuthStatus")
    ]
    public class New_RscGqlMutationUpdateO365AppAuthStatus : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateO365AppAuthStatus");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateO365AppAuthStatus
        /// updateO365AppAuthStatus(input: UpdateO365AppAuthStatusInput!): UpdateO365AppAuthStatusReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateO365AppAuthStatus();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateO365AppAuthStatus()
        {
            this._logger.name += " -updateO365AppAuthStatus";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateO365AppAuthStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateO365AppAuthStatus",
                "($input: UpdateO365AppAuthStatusInput!)",
                "UpdateO365AppAuthStatusReply",
                Mutation.UpdateO365AppAuthStatus_ObjectFieldSpec,
                Mutation.UpdateO365AppAuthStatusFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365OrgId = <System.String>
	# REQUIRED
	o365AppId = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateO365AppAuthStatus
}