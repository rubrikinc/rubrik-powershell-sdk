// New-RscGqlQueryAllAwsExocomputeConfigs.cs
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
    /// Create new GraphQL Query allAwsExocomputeConfigs
    /// allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!): [AwsExocomputeConfig!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAwsExocomputeConfigs")
    ]
    public class New_RscGqlQueryAllAwsExocomputeConfigs : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAwsExocomputeConfigs");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAwsExocomputeConfigs
        /// allAwsExocomputeConfigs(awsNativeAccountIdOrNamePrefix: String!): [AwsExocomputeConfig!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAwsExocomputeConfigs();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAwsExocomputeConfigs()
        {
            this._logger.name += " -allAwsExocomputeConfigs";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountIdOrNamePrefix", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAwsExocomputeConfigs",
                "($awsNativeAccountIdOrNamePrefix: String!)",
                "List<AwsExocomputeConfig>",
                Query.AllAwsExocomputeConfigs_ObjectFieldSpec,
                Query.AllAwsExocomputeConfigsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsNativeAccountIdOrNamePrefix = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllAwsExocomputeConfigs
}