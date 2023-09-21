// New-RscGqlQueryAllOptionGroupsByRegionFromAws.cs
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
    /// Create new GraphQL Query allOptionGroupsByRegionFromAws
    /// allOptionGroupsByRegionFromAws(
    ///     awsAccountRubrikId: UUID!
    ///     region: AwsNativeRegion!
    ///     dbEngine: AwsNativeRdsDbEngine!
    ///     dbEngineVersion: String!
    ///     majorEngineVersion: String!
    ///   ): [OptionGroup!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllOptionGroupsByRegionFromAws")
    ]
    public class New_RscGqlQueryAllOptionGroupsByRegionFromAws : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allOptionGroupsByRegionFromAws");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allOptionGroupsByRegionFromAws
        /// allOptionGroupsByRegionFromAws(
        ///     awsAccountRubrikId: UUID!
        ///     region: AwsNativeRegion!
        ///     dbEngine: AwsNativeRdsDbEngine!
        ///     dbEngineVersion: String!
        ///     majorEngineVersion: String!
        ///   ): [OptionGroup!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allOptionGroupsByRegionFromAws();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allOptionGroupsByRegionFromAws()
        {
            this._logger.name += " -allOptionGroupsByRegionFromAws";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("majorEngineVersion", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllOptionGroupsByRegionFromAws",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$majorEngineVersion: String!)",
                "List<OptionGroup>",
                Query.AllOptionGroupsByRegionFromAws_ObjectFieldSpec,
                Query.AllOptionGroupsByRegionFromAwsFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# REQUIRED
$inputs.Var.majorEngineVersion = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllOptionGroupsByRegionFromAws
}