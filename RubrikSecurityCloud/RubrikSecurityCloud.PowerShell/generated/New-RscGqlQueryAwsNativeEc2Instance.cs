// New-RscGqlQueryAwsNativeEc2Instance.cs
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
    /// Create new GraphQL Query awsNativeEc2Instance
    /// awsNativeEc2Instance(ec2InstanceRubrikId: UUID!): AwsNativeEc2Instance!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsNativeEc2Instance")
    ]
    public class New_RscGqlQueryAwsNativeEc2Instance : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeEc2Instance");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsNativeEc2Instance
        /// awsNativeEc2Instance(ec2InstanceRubrikId: UUID!): AwsNativeEc2Instance!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeEc2Instance();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeEc2Instance()
        {
            this._logger.name += " -awsNativeEc2Instance";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ec2InstanceRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEc2Instance",
                "($ec2InstanceRubrikId: UUID!)",
                "AwsNativeEc2Instance",
                Query.AwsNativeEc2Instance_ObjectFieldSpec,
                Query.AwsNativeEc2InstanceFieldSpec,
                @"# REQUIRED
$inputs.Var.ec2InstanceRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAwsNativeEc2Instance
}