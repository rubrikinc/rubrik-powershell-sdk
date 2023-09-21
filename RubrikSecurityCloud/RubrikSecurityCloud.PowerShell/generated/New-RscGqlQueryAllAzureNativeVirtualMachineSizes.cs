// New-RscGqlQueryAllAzureNativeVirtualMachineSizes.cs
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
    /// Create new GraphQL Query allAzureNativeVirtualMachineSizes
    /// allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureNativeVirtualMachineSizes")
    ]
    public class New_RscGqlQueryAllAzureNativeVirtualMachineSizes : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureNativeVirtualMachineSizes");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureNativeVirtualMachineSizes
        /// allAzureNativeVirtualMachineSizes(azureSubscriptionRubrikId: UUID): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureNativeVirtualMachineSizes();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureNativeVirtualMachineSizes()
        {
            this._logger.name += " -allAzureNativeVirtualMachineSizes";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureNativeVirtualMachineSizes",
                "($azureSubscriptionRubrikId: UUID)",
                "List<System.String>",
                Query.AllAzureNativeVirtualMachineSizes_ObjectFieldSpec,
                Query.AllAzureNativeVirtualMachineSizesFieldSpec,
                @"# OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAzureNativeVirtualMachineSizes
}