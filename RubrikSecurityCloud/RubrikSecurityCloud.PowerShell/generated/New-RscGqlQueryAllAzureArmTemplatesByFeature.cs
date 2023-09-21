// New-RscGqlQueryAllAzureArmTemplatesByFeature.cs
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
    /// Create new GraphQL Query allAzureArmTemplatesByFeature
    /// allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!): [AzureArmTemplateByFeature!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAzureArmTemplatesByFeature")
    ]
    public class New_RscGqlQueryAllAzureArmTemplatesByFeature : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAzureArmTemplatesByFeature");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAzureArmTemplatesByFeature
        /// allAzureArmTemplatesByFeature(input: AzureArmTemplatesByFeatureInput!): [AzureArmTemplateByFeature!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAzureArmTemplatesByFeature();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAzureArmTemplatesByFeature()
        {
            this._logger.name += " -allAzureArmTemplatesByFeature";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureArmTemplatesByFeatureInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAzureArmTemplatesByFeature",
                "($input: AzureArmTemplatesByFeatureInput!)",
                "List<AzureArmTemplateByFeature>",
                Query.AllAzureArmTemplatesByFeature_ObjectFieldSpec,
                Query.AllAzureArmTemplatesByFeatureFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	customerTenantDomainName = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	operationType = <CloudAccountOperation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountOperation]) for enum values.
	# REQUIRED
	cloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	featuresToInclude = @(
		@{
			# OPTIONAL
			permissionsGroups = @(
				<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
			# REQUIRED
			featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		}
	)
}"
            );
        }

    } // class New-RscGqlQueryAllAzureArmTemplatesByFeature
}