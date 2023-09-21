// New-RscGqlQueryNutanixVmMissedSnapshots.cs
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
    /// Create new GraphQL Query nutanixVmMissedSnapshots
    /// nutanixVmMissedSnapshots(input: NutanixMissedSnapshotsInput!): MissedSnapshotListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryNutanixVmMissedSnapshots")
    ]
    public class New_RscGqlQueryNutanixVmMissedSnapshots : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixVmMissedSnapshots");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query nutanixVmMissedSnapshots
        /// nutanixVmMissedSnapshots(input: NutanixMissedSnapshotsInput!): MissedSnapshotListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixVmMissedSnapshots();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixVmMissedSnapshots()
        {
            this._logger.name += " -nutanixVmMissedSnapshots";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "NutanixMissedSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixVmMissedSnapshots",
                "($input: NutanixMissedSnapshotsInput!)",
                "MissedSnapshotListResponse",
                Query.NutanixVmMissedSnapshots_ObjectFieldSpec,
                Query.NutanixVmMissedSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryNutanixVmMissedSnapshots
}