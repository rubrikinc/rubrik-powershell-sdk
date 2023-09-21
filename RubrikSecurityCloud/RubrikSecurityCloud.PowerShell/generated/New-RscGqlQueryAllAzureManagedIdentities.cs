// New-RscGqlQueryAllAzureManagedIdentities.cs
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
    /// Create new GraphQL Query allAzureManagedIdentities
    /// allAzureManagedIdentities(managedIdentitiesRequest: AzureManagedIdentitiesRequest!): [AzureManagedIdentity!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureManagedIdentities")
    ]
    public class New_RscGqlQueryAllAzureManagedIdentities : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureManagedIdentities");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureManagedIdentities
        /// allAzureManagedIdentities(managedIdentitiesRequest: AzureManagedIdentitiesRequest!): [AzureManagedIdentity!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureManagedIdentities();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureManagedIdentities()
        {
            this._logger.name += " -allAzureManagedIdentities";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("managedIdentitiesRequest", "AzureManagedIdentitiesRequest!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureManagedIdentities",
                "($managedIdentitiesRequest: AzureManagedIdentitiesRequest!)",
                "List<AzureManagedIdentity>",
                Query.AllAzureManagedIdentities_ObjectFieldSpec,
                Query.AllAzureManagedIdentitiesFieldSpec,
                @"# REQUIRED
$inputs.Var.managedIdentitiesRequest = @{
	# REQUIRED
	cloudAccountId = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureManagedIdentities
}