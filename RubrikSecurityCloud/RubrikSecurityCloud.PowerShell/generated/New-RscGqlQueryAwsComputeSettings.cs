// New-RscGqlQueryAwsComputeSettings.cs
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
    /// Create new GraphQL Query awsComputeSettings
    /// awsComputeSettings(computeSettingId: UUID!): AwsComputeSettings!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsComputeSettings")
    ]
    public class New_RscGqlQueryAwsComputeSettings : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsComputeSettings");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsComputeSettings
        /// awsComputeSettings(computeSettingId: UUID!): AwsComputeSettings!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsComputeSettings();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsComputeSettings()
        {
            this._logger.name += " -awsComputeSettings";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("computeSettingId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsComputeSettings",
                "($computeSettingId: UUID!)",
                "AwsComputeSettings",
                Query.AwsComputeSettings_ObjectFieldSpec,
                Query.AwsComputeSettingsFieldSpec,
                @"# REQUIRED
$inputs.Var.computeSettingId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAwsComputeSettings
}