// New-RscGqlMutationDownloadFilesNutanixSnapshot.cs
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
    /// Create new GraphQL Mutation downloadFilesNutanixSnapshot
    /// downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadFilesNutanixSnapshot")
    ]
    public class New_RscGqlMutationDownloadFilesNutanixSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadFilesNutanixSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadFilesNutanixSnapshot
        /// downloadFilesNutanixSnapshot(input: DownloadFilesNutanixSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadFilesNutanixSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadFilesNutanixSnapshot()
        {
            this._logger.name += " -downloadFilesNutanixSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadFilesNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadFilesNutanixSnapshot",
                "($input: DownloadFilesNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadFilesNutanixSnapshot_ObjectFieldSpec,
                Mutation.DownloadFilesNutanixSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# REQUIRED
		paths = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadFilesNutanixSnapshot
}