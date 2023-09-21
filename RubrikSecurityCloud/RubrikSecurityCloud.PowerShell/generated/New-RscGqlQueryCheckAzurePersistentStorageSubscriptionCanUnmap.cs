// New-RscGqlQueryCheckAzurePersistentStorageSubscriptionCanUnmap.cs
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
    /// Create new GraphQL Query checkAzurePersistentStorageSubscriptionCanUnmap
    /// checkAzurePersistentStorageSubscriptionCanUnmap(cloudAccountId: UUID!, feature: CloudAccountFeature!, unmappingValidationType: UnmappingValidationType!): CheckAzurePersistentStorageSubscriptionCanUnmapReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryCheckAzurePersistentStorageSubscriptionCanUnmap")
    ]
    public class New_RscGqlQueryCheckAzurePersistentStorageSubscriptionCanUnmap : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("checkAzurePersistentStorageSubscriptionCanUnmap");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query checkAzurePersistentStorageSubscriptionCanUnmap
        /// checkAzurePersistentStorageSubscriptionCanUnmap(cloudAccountId: UUID!, feature: CloudAccountFeature!, unmappingValidationType: UnmappingValidationType!): CheckAzurePersistentStorageSubscriptionCanUnmapReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_checkAzurePersistentStorageSubscriptionCanUnmap();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_checkAzurePersistentStorageSubscriptionCanUnmap()
        {
            this._logger.name += " -checkAzurePersistentStorageSubscriptionCanUnmap";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cloudAccountId", "UUID!"),
                Tuple.Create("feature", "CloudAccountFeature!"),
                Tuple.Create("unmappingValidationType", "UnmappingValidationType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCheckAzurePersistentStorageSubscriptionCanUnmap",
                "($cloudAccountId: UUID!,$feature: CloudAccountFeature!,$unmappingValidationType: UnmappingValidationType!)",
                "CheckAzurePersistentStorageSubscriptionCanUnmapReply",
                Query.CheckAzurePersistentStorageSubscriptionCanUnmap_ObjectFieldSpec,
                Query.CheckAzurePersistentStorageSubscriptionCanUnmapFieldSpec,
                @"# REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.unmappingValidationType = <UnmappingValidationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values."
            );
        }

    } // class New-RscGqlQueryCheckAzurePersistentStorageSubscriptionCanUnmap
}