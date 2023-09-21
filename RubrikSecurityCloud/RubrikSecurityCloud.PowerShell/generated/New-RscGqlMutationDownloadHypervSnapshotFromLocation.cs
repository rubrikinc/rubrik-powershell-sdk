// New-RscGqlMutationDownloadHypervSnapshotFromLocation.cs
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
    /// Create new GraphQL Mutation downloadHypervSnapshotFromLocation
    /// downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadHypervSnapshotFromLocation")
    ]
    public class New_RscGqlMutationDownloadHypervSnapshotFromLocation : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadHypervSnapshotFromLocation");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadHypervSnapshotFromLocation
        /// downloadHypervSnapshotFromLocation(input: DownloadHypervSnapshotFromLocationInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadHypervSnapshotFromLocation();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadHypervSnapshotFromLocation()
        {
            this._logger.name += " -downloadHypervSnapshotFromLocation";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadHypervSnapshotFromLocationInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadHypervSnapshotFromLocation",
                "($input: DownloadHypervSnapshotFromLocationInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadHypervSnapshotFromLocation_ObjectFieldSpec,
                Mutation.DownloadHypervSnapshotFromLocationFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		slaId = <System.String>
	}
}"
            );
        }

    } // class New-RscGqlMutationDownloadHypervSnapshotFromLocation
}