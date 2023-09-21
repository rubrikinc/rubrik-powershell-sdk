// New-RscGqlQueryAwsNativeRdsInstance.cs
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
    /// Create new GraphQL Query awsNativeRdsInstance
    /// awsNativeRdsInstance(rdsInstanceRubrikId: UUID!): AwsNativeRdsInstance!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsNativeRdsInstance")
    ]
    public class New_RscGqlQueryAwsNativeRdsInstance : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeRdsInstance");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsNativeRdsInstance
        /// awsNativeRdsInstance(rdsInstanceRubrikId: UUID!): AwsNativeRdsInstance!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeRdsInstance();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeRdsInstance()
        {
            this._logger.name += " -awsNativeRdsInstance";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rdsInstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsInstance",
                "($rdsInstanceRubrikId: UUID!)",
                "AwsNativeRdsInstance",
                Query.AwsNativeRdsInstance_ObjectFieldSpec,
                Query.AwsNativeRdsInstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAwsNativeRdsInstance
}