// Invoke-RscGqlQueryAwsNativeRdsPointInTimeRestoreWindow.cs
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
    /// Invoke GraphQL Query awsNativeRdsPointInTimeRestoreWindow
    /// awsNativeRdsPointInTimeRestoreWindow(
    ///     awsAccountRubrikId: UUID!
    ///     region: AwsNativeRegion!
    ///     rdsInstanceName: String!
    ///     rdsDatabaseRubrikId: UUID
    ///   ): AwsNativeRdsPointInTimeRestoreWindow!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAwsNativeRdsPointInTimeRestoreWindow")
    ]
    public class Invoke_RscGqlQueryAwsNativeRdsPointInTimeRestoreWindow : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeRdsPointInTimeRestoreWindow");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query awsNativeRdsPointInTimeRestoreWindow
        /// awsNativeRdsPointInTimeRestoreWindow(
        ///     awsAccountRubrikId: UUID!
        ///     region: AwsNativeRegion!
        ///     rdsInstanceName: String!
        ///     rdsDatabaseRubrikId: UUID
        ///   ): AwsNativeRdsPointInTimeRestoreWindow!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeRdsPointInTimeRestoreWindow();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeRdsPointInTimeRestoreWindow()
        {
            this._logger.name += " -awsNativeRdsPointInTimeRestoreWindow";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("rdsInstanceName", "String!"),
                Tuple.Create("rdsDatabaseRubrikId", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeRdsPointInTimeRestoreWindow",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$rdsInstanceName: String!,$rdsDatabaseRubrikId: UUID)",
                "AwsNativeRdsPointInTimeRestoreWindow",
                Query.AwsNativeRdsPointInTimeRestoreWindow_ObjectFieldSpec,
                Query.AwsNativeRdsPointInTimeRestoreWindowFieldSpec,
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

    } // class Invoke-RscGqlQueryAwsNativeRdsPointInTimeRestoreWindow
}