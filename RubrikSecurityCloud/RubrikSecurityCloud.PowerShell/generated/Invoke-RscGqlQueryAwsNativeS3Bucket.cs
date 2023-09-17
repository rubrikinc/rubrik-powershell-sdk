// Invoke-RscGqlQueryAwsNativeS3Bucket.cs
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
    /// Invoke GraphQL Query awsNativeS3Bucket
    /// awsNativeS3Bucket(s3BucketRubrikId: UUID!): AwsNativeS3Bucket!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAwsNativeS3Bucket")
    ]
    public class Invoke_RscGqlQueryAwsNativeS3Bucket : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeS3Bucket");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query awsNativeS3Bucket
        /// awsNativeS3Bucket(s3BucketRubrikId: UUID!): AwsNativeS3Bucket!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeS3Bucket();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeS3Bucket()
        {
            this._logger.name += " -awsNativeS3Bucket";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("s3BucketRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeS3Bucket",
                "($s3BucketRubrikId: UUID!)",
                "AwsNativeS3Bucket",
                Query.AwsNativeS3Bucket_ObjectFieldSpec,
                Query.AwsNativeS3BucketFieldSpec,
                @"# REQUIRED
$inputs.Var.s3BucketRubrikId = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAwsNativeS3Bucket
}