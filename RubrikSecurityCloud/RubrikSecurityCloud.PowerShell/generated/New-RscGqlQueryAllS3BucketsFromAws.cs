// New-RscGqlQueryAllS3BucketsFromAws.cs
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
    /// Create new GraphQL Query allS3BucketsFromAws
    /// allS3BucketsFromAws(awsAccountRubrikId: UUID!): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllS3BucketsFromAws")
    ]
    public class New_RscGqlQueryAllS3BucketsFromAws : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allS3BucketsFromAws");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allS3BucketsFromAws
        /// allS3BucketsFromAws(awsAccountRubrikId: UUID!): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allS3BucketsFromAws();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allS3BucketsFromAws()
        {
            this._logger.name += " -allS3BucketsFromAws";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllS3BucketsFromAws",
                "($awsAccountRubrikId: UUID!)",
                "List<System.String>",
                Query.AllS3BucketsFromAws_ObjectFieldSpec,
                Query.AllS3BucketsFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllS3BucketsFromAws
}