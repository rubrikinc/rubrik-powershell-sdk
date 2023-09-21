// New-RscGqlQueryAzureNativeManagedDisk.cs
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
    /// Create new GraphQL Query azureNativeManagedDisk
    /// azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!): AzureNativeManagedDisk!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAzureNativeManagedDisk")
    ]
    public class New_RscGqlQueryAzureNativeManagedDisk : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureNativeManagedDisk");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query azureNativeManagedDisk
        /// azureNativeManagedDisk(azureManagedDiskRubrikId: UUID!): AzureNativeManagedDisk!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureNativeManagedDisk();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureNativeManagedDisk()
        {
            this._logger.name += " -azureNativeManagedDisk";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureManagedDiskRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureNativeManagedDisk",
                "($azureManagedDiskRubrikId: UUID!)",
                "AzureNativeManagedDisk",
                Query.AzureNativeManagedDisk_ObjectFieldSpec,
                Query.AzureNativeManagedDiskFieldSpec,
                @"# REQUIRED
$inputs.Var.azureManagedDiskRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAzureNativeManagedDisk
}