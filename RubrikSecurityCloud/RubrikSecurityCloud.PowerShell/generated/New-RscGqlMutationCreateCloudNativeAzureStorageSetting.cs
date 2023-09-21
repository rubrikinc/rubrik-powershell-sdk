// New-RscGqlMutationCreateCloudNativeAzureStorageSetting.cs
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
    /// Create new GraphQL Mutation createCloudNativeAzureStorageSetting
    /// createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateCloudNativeAzureStorageSetting")
    ]
    public class New_RscGqlMutationCreateCloudNativeAzureStorageSetting : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createCloudNativeAzureStorageSetting");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createCloudNativeAzureStorageSetting
        /// createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createCloudNativeAzureStorageSetting();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createCloudNativeAzureStorageSetting()
        {
            this._logger.name += " -createCloudNativeAzureStorageSetting";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAzureStorageSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCloudNativeAzureStorageSetting",
                "($input: CreateCloudNativeAzureStorageSettingInput!)",
                "CreateCloudNativeAzureStorageSettingReply",
                Mutation.CreateCloudNativeAzureStorageSetting_ObjectFieldSpec,
                Mutation.CreateCloudNativeAzureStorageSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	containerName = <System.String>
	# OPTIONAL
	storageAccountTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = <System.String>
				# REQUIRED
				value = <System.String>
			}
		)
	}
	# OPTIONAL
	storageAccountRegion = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	storageTier = <AzureStorageTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	redundancy = <AzureRedundancy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRedundancy]) for enum values.
	# REQUIRED
	subscriptionNativeId = <System.String>
	# REQUIRED
	cloudNativeLocTemplateType = <CloudNativeLocTemplateType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = <System.String>
			# OPTIONAL
			keyName = <System.String>
			# OPTIONAL
			region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationCreateCloudNativeAzureStorageSetting
}