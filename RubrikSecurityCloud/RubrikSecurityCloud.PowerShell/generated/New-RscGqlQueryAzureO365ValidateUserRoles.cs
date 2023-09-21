// New-RscGqlQueryAzureO365ValidateUserRoles.cs
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
    /// Create new GraphQL Query azureO365ValidateUserRoles
    /// azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!): AzureUserRoleResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureO365ValidateUserRoles")
    ]
    public class New_RscGqlQueryAzureO365ValidateUserRoles : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureO365ValidateUserRoles");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureO365ValidateUserRoles
        /// azureO365ValidateUserRoles(tenantId: String!, subscriptionId: UUID!): AzureUserRoleResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureO365ValidateUserRoles();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureO365ValidateUserRoles()
        {
            this._logger.name += " -azureO365ValidateUserRoles";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("tenantId", "String!"),
                Tuple.Create("subscriptionId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365ValidateUserRoles",
                "($tenantId: String!,$subscriptionId: UUID!)",
                "AzureUserRoleResp",
                Query.AzureO365ValidateUserRoles_ObjectFieldSpec,
                Query.AzureO365ValidateUserRolesFieldSpec,
                @"# REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureO365ValidateUserRoles
}