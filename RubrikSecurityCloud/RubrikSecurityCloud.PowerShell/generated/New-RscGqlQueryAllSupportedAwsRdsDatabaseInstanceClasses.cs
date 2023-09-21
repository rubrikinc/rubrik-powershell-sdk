// New-RscGqlQueryAllSupportedAwsRdsDatabaseInstanceClasses.cs
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
    /// Create new GraphQL Query allSupportedAwsRdsDatabaseInstanceClasses
    /// allSupportedAwsRdsDatabaseInstanceClasses(
    ///     awsAccountRubrikId: UUID!
    ///     region: AwsNativeRegion!
    ///     dbEngine: AwsNativeRdsDbEngine!
    ///     dbEngineVersion: String
    ///   ): [String!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllSupportedAwsRdsDatabaseInstanceClasses")
    ]
    public class New_RscGqlQueryAllSupportedAwsRdsDatabaseInstanceClasses : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allSupportedAwsRdsDatabaseInstanceClasses");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allSupportedAwsRdsDatabaseInstanceClasses
        /// allSupportedAwsRdsDatabaseInstanceClasses(
        ///     awsAccountRubrikId: UUID!
        ///     region: AwsNativeRegion!
        ///     dbEngine: AwsNativeRdsDbEngine!
        ///     dbEngineVersion: String
        ///   ): [String!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allSupportedAwsRdsDatabaseInstanceClasses();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allSupportedAwsRdsDatabaseInstanceClasses()
        {
            this._logger.name += " -allSupportedAwsRdsDatabaseInstanceClasses";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSupportedAwsRdsDatabaseInstanceClasses",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String)",
                "List<System.String>",
                Query.AllSupportedAwsRdsDatabaseInstanceClasses_ObjectFieldSpec,
                Query.AllSupportedAwsRdsDatabaseInstanceClassesFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# OPTIONAL
$inputs.Var.dbEngineVersion = <System.String>"
            );
        }

    } // class New-RscGqlQueryAllSupportedAwsRdsDatabaseInstanceClasses
}