// New-RscGqlQueryAllDbParameterGroupsByRegionFromAws.cs
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
    /// Create new GraphQL Query allDbParameterGroupsByRegionFromAws
    /// allDbParameterGroupsByRegionFromAws(
    ///     awsAccountRubrikId: UUID!
    ///     region: AwsNativeRegion!
    ///     dbEngine: AwsNativeRdsDbEngine!
    ///     dbEngineVersion: String!
    ///     rdsType: AwsNativeRdsType
    ///   ): [DbParameterGroup!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllDbParameterGroupsByRegionFromAws")
    ]
    public class New_RscGqlQueryAllDbParameterGroupsByRegionFromAws : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allDbParameterGroupsByRegionFromAws");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allDbParameterGroupsByRegionFromAws
        /// allDbParameterGroupsByRegionFromAws(
        ///     awsAccountRubrikId: UUID!
        ///     region: AwsNativeRegion!
        ///     dbEngine: AwsNativeRdsDbEngine!
        ///     dbEngineVersion: String!
        ///     rdsType: AwsNativeRdsType
        ///   ): [DbParameterGroup!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allDbParameterGroupsByRegionFromAws();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allDbParameterGroupsByRegionFromAws()
        {
            this._logger.name += " -allDbParameterGroupsByRegionFromAws";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("rdsType", "AwsNativeRdsType"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllDbParameterGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$rdsType: AwsNativeRdsType)",
                "List<DbParameterGroup>",
                Query.AllDbParameterGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllDbParameterGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# OPTIONAL
$inputs.Var.rdsType = <AwsNativeRdsType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsType]) for enum values."
            );
        }

    } // class New-RscGqlQueryAllDbParameterGroupsByRegionFromAws
}