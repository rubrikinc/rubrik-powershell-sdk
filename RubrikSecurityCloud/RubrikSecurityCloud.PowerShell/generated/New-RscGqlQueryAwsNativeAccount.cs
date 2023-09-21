// New-RscGqlQueryAwsNativeAccount.cs
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
    /// Create new GraphQL Query awsNativeAccount
    /// awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!): AwsNativeAccount!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAwsNativeAccount")
    ]
    public class New_RscGqlQueryAwsNativeAccount : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeAccount");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query awsNativeAccount
        /// awsNativeAccount(awsNativeAccountRubrikId: UUID!, awsNativeProtectionFeature: AwsNativeProtectionFeature!): AwsNativeAccount!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeAccount();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeAccount()
        {
            this._logger.name += " -awsNativeAccount";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsNativeAccountRubrikId", "UUID!"),
                Tuple.Create("awsNativeProtectionFeature", "AwsNativeProtectionFeature!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeAccount",
                "($awsNativeAccountRubrikId: UUID!,$awsNativeProtectionFeature: AwsNativeProtectionFeature!)",
                "AwsNativeAccount",
                Query.AwsNativeAccount_ObjectFieldSpec,
                Query.AwsNativeAccountFieldSpec,
                @"# REQUIRED
$inputs.Var.awsNativeAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values."
            );
        }

    } // class New-RscGqlQueryAwsNativeAccount
}