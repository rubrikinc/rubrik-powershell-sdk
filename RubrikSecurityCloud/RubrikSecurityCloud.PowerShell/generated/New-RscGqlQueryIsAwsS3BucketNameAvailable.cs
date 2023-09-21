// New-RscGqlQueryIsAwsS3BucketNameAvailable.cs
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
    /// Create new GraphQL Query isAwsS3BucketNameAvailable
    /// isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryIsAwsS3BucketNameAvailable")
    ]
    public class New_RscGqlQueryIsAwsS3BucketNameAvailable : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("isAwsS3BucketNameAvailable");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query isAwsS3BucketNameAvailable
        /// isAwsS3BucketNameAvailable(bucketName: String!, awsAccountRubrikId: UUID!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_isAwsS3BucketNameAvailable();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_isAwsS3BucketNameAvailable()
        {
            this._logger.name += " -isAwsS3BucketNameAvailable";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("bucketName", "String!"),
                Tuple.Create("awsAccountRubrikId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsS3BucketNameAvailable",
                "($bucketName: String!,$awsAccountRubrikId: UUID!)",
                "System.Boolean",
                Query.IsAwsS3BucketNameAvailable_ObjectFieldSpec,
                Query.IsAwsS3BucketNameAvailableFieldSpec,
                @"# REQUIRED
$inputs.Var.bucketName = <System.String>
# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>"
            );
        }

    } // class New-RscGqlQueryIsAwsS3BucketNameAvailable
}