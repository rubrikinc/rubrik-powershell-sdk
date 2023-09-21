// New-RscGqlQueryAzureAdDirectory.cs
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
    /// Create new GraphQL Query azureAdDirectory
    /// azureAdDirectory(workloadFid: UUID!): AzureAdDirectory!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureAdDirectory")
    ]
    public class New_RscGqlQueryAzureAdDirectory : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureAdDirectory");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureAdDirectory
        /// azureAdDirectory(workloadFid: UUID!): AzureAdDirectory!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureAdDirectory();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureAdDirectory()
        {
            this._logger.name += " -azureAdDirectory";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("workloadFid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureAdDirectory",
                "($workloadFid: UUID!)",
                "AzureAdDirectory",
                Query.AzureAdDirectory_ObjectFieldSpec,
                Query.AzureAdDirectoryFieldSpec,
                @"# REQUIRED
$inputs.Var.workloadFid = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureAdDirectory
}