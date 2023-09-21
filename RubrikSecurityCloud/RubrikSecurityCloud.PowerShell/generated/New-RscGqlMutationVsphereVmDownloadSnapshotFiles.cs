// New-RscGqlMutationVsphereVmDownloadSnapshotFiles.cs
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
    /// Create new GraphQL Mutation vsphereVmDownloadSnapshotFiles
    /// vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationVsphereVmDownloadSnapshotFiles")
    ]
    public class New_RscGqlMutationVsphereVmDownloadSnapshotFiles : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmDownloadSnapshotFiles");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation vsphereVmDownloadSnapshotFiles
        /// vsphereVmDownloadSnapshotFiles(input: VsphereVmDownloadSnapshotFilesInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmDownloadSnapshotFiles();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmDownloadSnapshotFiles()
        {
            this._logger.name += " -vsphereVmDownloadSnapshotFiles";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmDownloadSnapshotFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmDownloadSnapshotFiles",
                "($input: VsphereVmDownloadSnapshotFilesInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmDownloadSnapshotFiles_ObjectFieldSpec,
                Mutation.VsphereVmDownloadSnapshotFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotFid = <System.String>
	# REQUIRED
	paths = @(
		<System.String>
	)
	# OPTIONAL
	deltaTypeFilter = @(
		<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
	# OPTIONAL
	nextSnapshotFid = <System.String>
	# OPTIONAL
	isLegalHoldDownload = <System.Boolean>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationVsphereVmDownloadSnapshotFiles
}