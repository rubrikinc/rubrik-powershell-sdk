// New-RscGqlQueryIsAwsNativeEbsVolumeSnapshotRestorable.cs
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
    /// Create new GraphQL Query isAwsNativeEbsVolumeSnapshotRestorable
    /// isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!): IsVolumeSnapshotRestorableReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryIsAwsNativeEbsVolumeSnapshotRestorable")
    ]
    public class New_RscGqlQueryIsAwsNativeEbsVolumeSnapshotRestorable : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("isAwsNativeEbsVolumeSnapshotRestorable");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query isAwsNativeEbsVolumeSnapshotRestorable
        /// isAwsNativeEbsVolumeSnapshotRestorable(snapshotId: String!): IsVolumeSnapshotRestorableReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_isAwsNativeEbsVolumeSnapshotRestorable();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_isAwsNativeEbsVolumeSnapshotRestorable()
        {
            this._logger.name += " -isAwsNativeEbsVolumeSnapshotRestorable";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snapshotId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAwsNativeEbsVolumeSnapshotRestorable",
                "($snapshotId: String!)",
                "IsVolumeSnapshotRestorableReply",
                Query.IsAwsNativeEbsVolumeSnapshotRestorable_ObjectFieldSpec,
                Query.IsAwsNativeEbsVolumeSnapshotRestorableFieldSpec,
                @"# REQUIRED
$inputs.Var.snapshotId = <System.String>"
            );
        }

    } // class New-RscGqlQueryIsAwsNativeEbsVolumeSnapshotRestorable
}