// New-RscGqlMutationDeleteO365Org.cs
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
    /// Create new GraphQL Mutation deleteO365Org
    /// deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteO365Org")
    ]
    public class New_RscGqlMutationDeleteO365Org : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteO365Org");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteO365Org
        /// deleteO365Org(orgId: UUID!): CreateOnDemandJobReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteO365Org();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteO365Org()
        {
            this._logger.name += " -deleteO365Org";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365Org",
                "($orgId: UUID!)",
                "CreateOnDemandJobReply",
                Mutation.DeleteO365Org_ObjectFieldSpec,
                Mutation.DeleteO365OrgFieldSpec,
                @"# REQUIRED
$inputs.Var.orgId = <System.String>"
            );
        }

    } // class New-RscGqlMutationDeleteO365Org
}