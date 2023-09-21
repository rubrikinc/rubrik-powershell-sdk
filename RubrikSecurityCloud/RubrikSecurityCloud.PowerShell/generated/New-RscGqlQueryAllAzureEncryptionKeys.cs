// New-RscGqlQueryAllAzureEncryptionKeys.cs
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
    /// Create new GraphQL Query allAzureEncryptionKeys
    /// allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!): [AzureEncryptionKey!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureEncryptionKeys")
    ]
    public class New_RscGqlQueryAllAzureEncryptionKeys : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureEncryptionKeys");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureEncryptionKeys
        /// allAzureEncryptionKeys(azureEncryptionKeysInput: AzureEncryptionKeysInput!): [AzureEncryptionKey!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureEncryptionKeys();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureEncryptionKeys()
        {
            this._logger.name += " -allAzureEncryptionKeys";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureEncryptionKeysInput", "AzureEncryptionKeysInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureEncryptionKeys",
                "($azureEncryptionKeysInput: AzureEncryptionKeysInput!)",
                "List<AzureEncryptionKey>",
                Query.AllAzureEncryptionKeys_ObjectFieldSpec,
                Query.AllAzureEncryptionKeysFieldSpec,
                @"# REQUIRED
$inputs.Var.azureEncryptionKeysInput = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	keyVaultName = <System.String>
	# REQUIRED
	resourceGroupName = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAllAzureEncryptionKeys
}