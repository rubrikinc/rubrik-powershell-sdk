// Invoke-RscGqlMutateUpdateAwsComputeSetting.cs
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
    /// Invoke GraphQL Mutation updateAwsComputeSetting
    /// updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!): AwsComputeSettings!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateUpdateAwsComputeSetting")
    ]
    public class Invoke_RscGqlMutateUpdateAwsComputeSetting : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateAwsComputeSetting");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation updateAwsComputeSetting
        /// updateAwsComputeSetting(input: UpdateAwsComputeSettingInput!): AwsComputeSettings!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateAwsComputeSetting();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateAwsComputeSetting()
        {
            this._logger.name += " -updateAwsComputeSetting";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAwsComputeSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateAwsComputeSetting",
                "($input: UpdateAwsComputeSettingInput!)",
                "AwsComputeSettings",
                Mutation.UpdateAwsComputeSetting_ObjectFieldSpec,
                Mutation.UpdateAwsComputeSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	subnetId = <System.String>
	# OPTIONAL
	vpcId = <System.String>
	# OPTIONAL
	securityGroupId = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateUpdateAwsComputeSetting
}