// New-RscGqlQueryIsAzureNativeManagedDiskSnapshotRestorable.cs
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
    /// Create new GraphQL Query isAzureNativeManagedDiskSnapshotRestorable
    /// isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!): Boolean!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryIsAzureNativeManagedDiskSnapshotRestorable")
    ]
    public class New_RscGqlQueryIsAzureNativeManagedDiskSnapshotRestorable : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("isAzureNativeManagedDiskSnapshotRestorable");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query isAzureNativeManagedDiskSnapshotRestorable
        /// isAzureNativeManagedDiskSnapshotRestorable(azureSubscriptionRubrikId: UUID!, diskSnapshotId: UUID!): Boolean!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_isAzureNativeManagedDiskSnapshotRestorable();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_isAzureNativeManagedDiskSnapshotRestorable()
        {
            this._logger.name += " -isAzureNativeManagedDiskSnapshotRestorable";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("azureSubscriptionRubrikId", "UUID!"),
                Tuple.Create("diskSnapshotId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryIsAzureNativeManagedDiskSnapshotRestorable",
                "($azureSubscriptionRubrikId: UUID!,$diskSnapshotId: UUID!)",
                "System.Boolean",
                Query.IsAzureNativeManagedDiskSnapshotRestorable_ObjectFieldSpec,
                Query.IsAzureNativeManagedDiskSnapshotRestorableFieldSpec,
                @"# REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.diskSnapshotId = <System.String>"
            );
        }

    } // class New-RscGqlQueryIsAzureNativeManagedDiskSnapshotRestorable
}