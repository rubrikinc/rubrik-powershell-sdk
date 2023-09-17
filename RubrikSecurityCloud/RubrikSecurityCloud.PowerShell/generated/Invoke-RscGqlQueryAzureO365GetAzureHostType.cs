// Invoke-RscGqlQueryAzureO365GetAzureHostType.cs
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
    /// Invoke GraphQL Query azureO365GetAzureHostType
    /// azureO365GetAzureHostType: GetAzureHostTypeResp!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAzureO365GetAzureHostType")
    ]
    public class Invoke_RscGqlQueryAzureO365GetAzureHostType : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("azureO365GetAzureHostType");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query azureO365GetAzureHostType
        /// azureO365GetAzureHostType: GetAzureHostTypeResp!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_azureO365GetAzureHostType();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_azureO365GetAzureHostType()
        {
            this._logger.name += " -azureO365GetAzureHostType";
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryAzureO365GetAzureHostType",
                "",
                "GetAzureHostTypeResp",
                Query.AzureO365GetAzureHostType_ObjectFieldSpec,
                Query.AzureO365GetAzureHostTypeFieldSpec,
                @""
            );
        }

    } // class Invoke-RscGqlQueryAzureO365GetAzureHostType
}