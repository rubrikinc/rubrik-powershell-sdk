// New-RscGqlQueryAmiTypeForAwsNativeArchivedSnapshotExport.cs
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
    /// Create new GraphQL Query amiTypeForAwsNativeArchivedSnapshotExport
    /// amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!): AmiTypeForAwsNativeArchivedSnapshotExportReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAmiTypeForAwsNativeArchivedSnapshotExport")
    ]
    public class New_RscGqlQueryAmiTypeForAwsNativeArchivedSnapshotExport : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("amiTypeForAwsNativeArchivedSnapshotExport");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query amiTypeForAwsNativeArchivedSnapshotExport
        /// amiTypeForAwsNativeArchivedSnapshotExport(input: AmiTypeForAwsNativeArchivedSnapshotExportInput!): AmiTypeForAwsNativeArchivedSnapshotExportReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_amiTypeForAwsNativeArchivedSnapshotExport();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_amiTypeForAwsNativeArchivedSnapshotExport()
        {
            this._logger.name += " -amiTypeForAwsNativeArchivedSnapshotExport";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AmiTypeForAwsNativeArchivedSnapshotExportInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAmiTypeForAwsNativeArchivedSnapshotExport",
                "($input: AmiTypeForAwsNativeArchivedSnapshotExportInput!)",
                "AmiTypeForAwsNativeArchivedSnapshotExportReply",
                Query.AmiTypeForAwsNativeArchivedSnapshotExport_ObjectFieldSpec,
                Query.AmiTypeForAwsNativeArchivedSnapshotExportFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	destinationRegionId = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	destinationAwsAccountRubrikId = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryAmiTypeForAwsNativeArchivedSnapshotExport
}