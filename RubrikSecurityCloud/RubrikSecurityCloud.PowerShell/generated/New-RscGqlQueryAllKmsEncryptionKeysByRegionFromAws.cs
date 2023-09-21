// New-RscGqlQueryAllKmsEncryptionKeysByRegionFromAws.cs
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
    /// Create new GraphQL Query allKmsEncryptionKeysByRegionFromAws
    /// allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [KmsEncryptionKey!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllKmsEncryptionKeysByRegionFromAws")
    ]
    public class New_RscGqlQueryAllKmsEncryptionKeysByRegionFromAws : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allKmsEncryptionKeysByRegionFromAws");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allKmsEncryptionKeysByRegionFromAws
        /// allKmsEncryptionKeysByRegionFromAws(awsAccountRubrikId: UUID!, region: AwsNativeRegion!): [KmsEncryptionKey!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allKmsEncryptionKeysByRegionFromAws();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allKmsEncryptionKeysByRegionFromAws()
        {
            this._logger.name += " -allKmsEncryptionKeysByRegionFromAws";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllKmsEncryptionKeysByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!)",
                "List<KmsEncryptionKey>",
                Query.AllKmsEncryptionKeysByRegionFromAws_ObjectFieldSpec,
                Query.AllKmsEncryptionKeysByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values."
            );
        }

    } // class New-RscGqlQueryAllKmsEncryptionKeysByRegionFromAws
}