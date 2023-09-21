// New-RscGqlMutationSetAzureCloudAccountCustomerAppCredentials.cs
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
    /// Create new GraphQL Mutation setAzureCloudAccountCustomerAppCredentials
    /// setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationSetAzureCloudAccountCustomerAppCredentials")
    ]
    public class New_RscGqlMutationSetAzureCloudAccountCustomerAppCredentials : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("setAzureCloudAccountCustomerAppCredentials");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation setAzureCloudAccountCustomerAppCredentials
        /// setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_setAzureCloudAccountCustomerAppCredentials();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_setAzureCloudAccountCustomerAppCredentials()
        {
            this._logger.name += " -setAzureCloudAccountCustomerAppCredentials";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAzureCloudAccountCustomerAppCredentialsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetAzureCloudAccountCustomerAppCredentials",
                "($input: SetAzureCloudAccountCustomerAppCredentialsInput!)",
                "System.Boolean",
                Mutation.SetAzureCloudAccountCustomerAppCredentials_ObjectFieldSpec,
                Mutation.SetAzureCloudAccountCustomerAppCredentialsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appId = <System.String>
	# REQUIRED
	appSecretKey = <System.String>
	# OPTIONAL
	appTenantId = <System.String>
	# OPTIONAL
	appName = <System.String>
	# OPTIONAL
	tenantDomainName = <System.String>
	# REQUIRED
	shouldReplace = <System.Boolean>
	# REQUIRED
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationSetAzureCloudAccountCustomerAppCredentials
}