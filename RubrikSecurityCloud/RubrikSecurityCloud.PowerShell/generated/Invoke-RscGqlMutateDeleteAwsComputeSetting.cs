// Invoke-RscGqlMutateDeleteAwsComputeSetting.cs
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
    /// Invoke GraphQL Mutation deleteAwsComputeSetting
    /// deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!): Void
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateDeleteAwsComputeSetting")
    ]
    public class Invoke_RscGqlMutateDeleteAwsComputeSetting : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("deleteAwsComputeSetting");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation deleteAwsComputeSetting
        /// deleteAwsComputeSetting(input: DeleteAwsComputeSettingInput!): Void
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_deleteAwsComputeSetting();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_deleteAwsComputeSetting()
        {
            this._logger.name += " -deleteAwsComputeSetting";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAwsComputeSettingInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAwsComputeSetting",
                "($input: DeleteAwsComputeSettingInput!)",
                "System.String",
                Mutation.DeleteAwsComputeSetting_ObjectFieldSpec,
                Mutation.DeleteAwsComputeSettingFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	id = <System.String>
}"
            );
        }

    } // class Invoke-RscGqlMutateDeleteAwsComputeSetting
}