// New-RscGqlQueryAllS3BucketsDetailsFromAws.cs
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
    /// Create new GraphQL Query allS3BucketsDetailsFromAws
    /// allS3BucketsDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion): [S3BucketDetails!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllS3BucketsDetailsFromAws")
    ]
    public class New_RscGqlQueryAllS3BucketsDetailsFromAws : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allS3BucketsDetailsFromAws");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allS3BucketsDetailsFromAws
        /// allS3BucketsDetailsFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion): [S3BucketDetails!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allS3BucketsDetailsFromAws();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allS3BucketsDetailsFromAws()
        {
            this._logger.name += " -allS3BucketsDetailsFromAws";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllS3BucketsDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion)",
                "List<S3BucketDetails>",
                Query.AllS3BucketsDetailsFromAws_ObjectFieldSpec,
                Query.AllS3BucketsDetailsFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# OPTIONAL
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

    } // class New-RscGqlQueryAllS3BucketsDetailsFromAws
}