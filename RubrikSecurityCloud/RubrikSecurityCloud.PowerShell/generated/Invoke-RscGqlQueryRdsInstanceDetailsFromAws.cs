// Invoke-RscGqlQueryRdsInstanceDetailsFromAws.cs
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
    /// Invoke GraphQL Query rdsInstanceDetailsFromAws
    /// rdsInstanceDetailsFromAws(
    ///     awsAccountRubrikId: UUID!
    ///     region: AwsNativeRegion!
    ///     rdsInstanceName: String!
    ///     rdsDatabaseRubrikId: UUID
    ///   ): RdsInstanceDetailsFromAws!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryRdsInstanceDetailsFromAws")
    ]
    public class Invoke_RscGqlQueryRdsInstanceDetailsFromAws : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("rdsInstanceDetailsFromAws");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query rdsInstanceDetailsFromAws
        /// rdsInstanceDetailsFromAws(
        ///     awsAccountRubrikId: UUID!
        ///     region: AwsNativeRegion!
        ///     rdsInstanceName: String!
        ///     rdsDatabaseRubrikId: UUID
        ///   ): RdsInstanceDetailsFromAws!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_rdsInstanceDetailsFromAws();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_rdsInstanceDetailsFromAws()
        {
            this._logger.name += " -rdsInstanceDetailsFromAws";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryRdsInstanceDetailsFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                "RdsInstanceDetailsFromAws",
                Query.RdsInstanceDetailsFromAws_ObjectFieldSpec,
                Query.RdsInstanceDetailsFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>
# OPTIONAL
$inputs.Var.rdsDatabaseRubrikId = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryRdsInstanceDetailsFromAws
}