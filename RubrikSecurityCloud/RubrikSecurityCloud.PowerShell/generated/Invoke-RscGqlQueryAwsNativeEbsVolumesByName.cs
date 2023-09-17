// Invoke-RscGqlQueryAwsNativeEbsVolumesByName.cs
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
    /// Invoke GraphQL Query awsNativeEbsVolumesByName
    /// awsNativeEbsVolumesByName(
    ///     first: Int
    ///     after: String
    ///     last: Int
    ///     before: String
    ///     sortBy: AwsNativeEbsVolumeSortFields
    ///     sortOrder: SortOrder
    ///     ebsVolumeName: String!
    ///   ): AwsNativeEbsVolumeConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlQueryAwsNativeEbsVolumesByName")
    ]
    public class Invoke_RscGqlQueryAwsNativeEbsVolumesByName : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("awsNativeEbsVolumesByName");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Query awsNativeEbsVolumesByName
        /// awsNativeEbsVolumesByName(
        ///     first: Int
        ///     after: String
        ///     last: Int
        ///     before: String
        ///     sortBy: AwsNativeEbsVolumeSortFields
        ///     sortOrder: SortOrder
        ///     ebsVolumeName: String!
        ///   ): AwsNativeEbsVolumeConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_awsNativeEbsVolumesByName();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_awsNativeEbsVolumesByName()
        {
            this._logger.name += " -awsNativeEbsVolumesByName";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("ebsVolumeName", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAwsNativeEbsVolumesByName",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: AwsNativeEbsVolumeSortFields,$sortOrder: SortOrder,$ebsVolumeName: String!)",
                "AwsNativeEbsVolumeConnection",
                Query.AwsNativeEbsVolumesByName_ObjectFieldSpec,
                Query.AwsNativeEbsVolumesByNameFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEbsVolumeSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$inputs.Var.ebsVolumeName = <System.String>"
            );
        }

    } // class Invoke-RscGqlQueryAwsNativeEbsVolumesByName
}