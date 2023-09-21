// New-RscGqlQueryIsAzureStorageAccountNameAvailable.cs
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
    /// Create new GraphQL Query isAzureStorageAccountNameAvailable
    /// isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryIsAzureStorageAccountNameAvailable")
    ]
    public class New_RscGqlQueryIsAzureStorageAccountNameAvailable : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("isAzureStorageAccountNameAvailable");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query isAzureStorageAccountNameAvailable
        /// isAzureStorageAccountNameAvailable(azureSubscriptionRubrikId: UUID!, storageAccountName: String!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_isAzureStorageAccountNameAvailable();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_isAzureStorageAccountNameAvailable()
        {
            this._logger.name += " -isAzureStorageAccountNameAvailable";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("storageAccountName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureStorageAccountNameAvailable",
                "($azureSubscriptionRubrikId: UUID!,$storageAccountName: String!)",
                "System.Boolean",
                Query.IsAzureStorageAccountNameAvailable_ObjectFieldSpec,
                Query.IsAzureStorageAccountNameAvailableFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.storageAccountName = <System.String>"
            );
        }

    } // class New-RscGqlQueryIsAzureStorageAccountNameAvailable
}