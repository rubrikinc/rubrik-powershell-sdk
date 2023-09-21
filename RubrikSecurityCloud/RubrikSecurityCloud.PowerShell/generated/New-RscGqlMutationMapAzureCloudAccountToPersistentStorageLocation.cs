// New-RscGqlMutationMapAzureCloudAccountToPersistentStorageLocation.cs
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
    /// Create new GraphQL Mutation mapAzureCloudAccountToPersistentStorageLocation
    /// mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationMapAzureCloudAccountToPersistentStorageLocation")
    ]
    public class New_RscGqlMutationMapAzureCloudAccountToPersistentStorageLocation : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mapAzureCloudAccountToPersistentStorageLocation");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation mapAzureCloudAccountToPersistentStorageLocation
        /// mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mapAzureCloudAccountToPersistentStorageLocation();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mapAzureCloudAccountToPersistentStorageLocation()
        {
            this._logger.name += " -mapAzureCloudAccountToPersistentStorageLocation";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountToPersistentStorageLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMapAzureCloudAccountToPersistentStorageLocation",
                "($input: MapAzureCloudAccountToPersistentStorageLocationInput!)",
                "MapAzureCloudAccountToPersistentStorageLocationReply",
                Mutation.MapAzureCloudAccountToPersistentStorageLocation_ObjectFieldSpec,
                Mutation.MapAzureCloudAccountToPersistentStorageLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	persistentStorageId = <System.String>
	# REQUIRED
	azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}"
            );
        }

    } // class New-RscGqlMutationMapAzureCloudAccountToPersistentStorageLocation
}