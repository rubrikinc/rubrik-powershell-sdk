// New-RscGqlMutationCreateCloudNativeRcvAzureStorageSetting.cs
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
    /// Create new GraphQL Mutation createCloudNativeRcvAzureStorageSetting
    /// createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateCloudNativeRcvAzureStorageSetting")
    ]
    public class New_RscGqlMutationCreateCloudNativeRcvAzureStorageSetting : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createCloudNativeRcvAzureStorageSetting");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createCloudNativeRcvAzureStorageSetting
        /// createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createCloudNativeRcvAzureStorageSetting();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createCloudNativeRcvAzureStorageSetting()
        {
            this._logger.name += " -createCloudNativeRcvAzureStorageSetting";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeRcvAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeRcvAzureStorageSetting",
                "($input: CreateCloudNativeRcvAzureStorageSettingInput!)",
                "CreateCloudNativeRcvAzureStorageSettingReply",
                Mutation.CreateCloudNativeRcvAzureStorageSetting_ObjectFieldSpec,
                Mutation.CreateCloudNativeRcvAzureStorageSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	cloudNativeLocTemplateType = <CloudNativeLocTemplateType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationCreateCloudNativeRcvAzureStorageSetting
}