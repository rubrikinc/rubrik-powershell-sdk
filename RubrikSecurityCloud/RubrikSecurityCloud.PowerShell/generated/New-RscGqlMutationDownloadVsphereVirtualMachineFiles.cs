// New-RscGqlMutationDownloadVsphereVirtualMachineFiles.cs
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
    /// Create new GraphQL Mutation downloadVsphereVirtualMachineFiles
    /// downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDownloadVsphereVirtualMachineFiles")
    ]
    public class New_RscGqlMutationDownloadVsphereVirtualMachineFiles : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("downloadVsphereVirtualMachineFiles");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation downloadVsphereVirtualMachineFiles
        /// downloadVsphereVirtualMachineFiles(input: DownloadVsphereVirtualMachineFilesInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_downloadVsphereVirtualMachineFiles();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_downloadVsphereVirtualMachineFiles()
        {
            this._logger.name += " -downloadVsphereVirtualMachineFiles";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadVsphereVirtualMachineFilesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadVsphereVirtualMachineFiles",
                "($input: DownloadVsphereVirtualMachineFilesInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadVsphereVirtualMachineFiles_ObjectFieldSpec,
                Mutation.DownloadVsphereVirtualMachineFilesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		fileNamesToDownload = @(
			<System.String>
		)
		# REQUIRED
		vmId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDownloadVsphereVirtualMachineFiles
}