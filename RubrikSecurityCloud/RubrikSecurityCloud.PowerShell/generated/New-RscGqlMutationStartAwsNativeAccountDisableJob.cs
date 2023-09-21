// New-RscGqlMutationStartAwsNativeAccountDisableJob.cs
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
    /// Create new GraphQL Mutation startAwsNativeAccountDisableJob
    /// startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!): AsyncJobStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationStartAwsNativeAccountDisableJob")
    ]
    public class New_RscGqlMutationStartAwsNativeAccountDisableJob : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("startAwsNativeAccountDisableJob");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation startAwsNativeAccountDisableJob
        /// startAwsNativeAccountDisableJob(input: StartAwsNativeAccountDisableJobInput!): AsyncJobStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_startAwsNativeAccountDisableJob();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_startAwsNativeAccountDisableJob()
        {
            this._logger.name += " -startAwsNativeAccountDisableJob";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAwsNativeAccountDisableJobInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationStartAwsNativeAccountDisableJob",
                "($input: StartAwsNativeAccountDisableJobInput!)",
                "AsyncJobStatus",
                Mutation.StartAwsNativeAccountDisableJob_ObjectFieldSpec,
                Mutation.StartAwsNativeAccountDisableJobFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsAccountRubrikId = <System.String>
	# REQUIRED
	shouldDeleteNativeSnapshots = <System.Boolean>
	# REQUIRED
	awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationStartAwsNativeAccountDisableJob
}