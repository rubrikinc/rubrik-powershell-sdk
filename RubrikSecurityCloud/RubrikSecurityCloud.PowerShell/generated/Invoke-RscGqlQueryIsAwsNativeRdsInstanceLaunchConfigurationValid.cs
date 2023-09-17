// Invoke-RscGqlQueryIsAwsNativeRdsInstanceLaunchConfigurationValid.cs
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
    /// Invoke GraphQL Query isAwsNativeRdsInstanceLaunchConfigurationValid
    /// isAwsNativeRdsInstanceLaunchConfigurationValid(
    ///     awsAccountRubrikId: UUID!
    ///     region: AwsNativeRegion!
    ///     dbEngine: AwsNativeRdsDbEngine!
    ///     dbEngineVersion: String!
    ///     dbClass: AwsNativeRdsDbInstanceClass!
    ///     databaseInstanceClass: String
    ///     primaryAz: String
    ///     storageType: AwsNativeRdsStorageType
    ///     isMultiAz: Boolean!
    ///     kmsKeyId: String
    ///     iops: Int
    ///   ): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryIsAwsNativeRdsInstanceLaunchConfigurationValid")
    ]
    public class Invoke_RscGqlQueryIsAwsNativeRdsInstanceLaunchConfigurationValid : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("isAwsNativeRdsInstanceLaunchConfigurationValid");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query isAwsNativeRdsInstanceLaunchConfigurationValid
        /// isAwsNativeRdsInstanceLaunchConfigurationValid(
        ///     awsAccountRubrikId: UUID!
        ///     region: AwsNativeRegion!
        ///     dbEngine: AwsNativeRdsDbEngine!
        ///     dbEngineVersion: String!
        ///     dbClass: AwsNativeRdsDbInstanceClass!
        ///     databaseInstanceClass: String
        ///     primaryAz: String
        ///     storageType: AwsNativeRdsStorageType
        ///     isMultiAz: Boolean!
        ///     kmsKeyId: String
        ///     iops: Int
        ///   ): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_isAwsNativeRdsInstanceLaunchConfigurationValid();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_isAwsNativeRdsInstanceLaunchConfigurationValid()
        {
            this._logger.name += " -isAwsNativeRdsInstanceLaunchConfigurationValid";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("awsAccountRubrikId", "UUID!"),
                Tuple.Create("region", "AwsNativeRegion!"),
                Tuple.Create("dbEngine", "AwsNativeRdsDbEngine!"),
                Tuple.Create("dbEngineVersion", "String!"),
                Tuple.Create("dbClass", "AwsNativeRdsDbInstanceClass!"),
                Tuple.Create("databaseInstanceClass", "String"),
                Tuple.Create("primaryAz", "String"),
                Tuple.Create("storageType", "AwsNativeRdsStorageType"),
                Tuple.Create("isMultiAz", "Boolean!"),
                Tuple.Create("kmsKeyId", "String"),
                Tuple.Create("iops", "Int"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeRdsInstanceLaunchConfigurationValid",
                "($awsAccountRubrikId: UUID!,$region: AwsNativeRegion!,$dbEngine: AwsNativeRdsDbEngine!,$dbEngineVersion: String!,$dbClass: AwsNativeRdsDbInstanceClass!,$databaseInstanceClass: String,$primaryAz: String,$storageType: AwsNativeRdsStorageType,$isMultiAz: Boolean!,$kmsKeyId: String,$iops: Int)",
                "System.Boolean",
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValid_ObjectFieldSpec,
                Query.IsAwsNativeRdsInstanceLaunchConfigurationValidFieldSpec,
                @"# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# REQUIRED
$inputs.Var.dbClass = <AwsNativeRdsDbInstanceClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
# OPTIONAL
$inputs.Var.databaseInstanceClass = <System.String>
# OPTIONAL
$inputs.Var.primaryAz = <System.String>
# OPTIONAL
$inputs.Var.storageType = <AwsNativeRdsStorageType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
# REQUIRED
$inputs.Var.isMultiAz = <System.Boolean>
# OPTIONAL
$inputs.Var.kmsKeyId = <System.String>
# OPTIONAL
$inputs.Var.iops = <System.Int32>"
            );
        }

    } // class Invoke-RscGqlQueryIsAwsNativeRdsInstanceLaunchConfigurationValid
}