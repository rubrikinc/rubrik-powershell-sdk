// New-RscGqlMutationDeleteO365AzureApp.cs
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
    /// Create new GraphQL Mutation deleteO365AzureApp
    /// deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!): RequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDeleteO365AzureApp")
    ]
    public class New_RscGqlMutationDeleteO365AzureApp : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteO365AzureApp");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation deleteO365AzureApp
        /// deleteO365AzureApp(o365AppClientId: String!, o365AppType: String!): RequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteO365AzureApp();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteO365AzureApp()
        {
            this._logger.name += " -deleteO365AzureApp";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("o365AppClientId", "String!"),
                Tuple.Create("o365AppType", "String!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteO365AzureApp",
                "($o365AppClientId: String!,$o365AppType: String!)",
                "RequestStatus",
                Mutation.DeleteO365AzureApp_ObjectFieldSpec,
                Mutation.DeleteO365AzureAppFieldSpec,
                @"# REQUIRED
$inputs.Var.o365AppClientId = <System.String>
# REQUIRED
$inputs.Var.o365AppType = <System.String>"
            );
        }

    } // class New-RscGqlMutationDeleteO365AzureApp
}