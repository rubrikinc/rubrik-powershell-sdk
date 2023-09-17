// Invoke-RscGqlMutateVsphereVmRecoverFilesNew.cs
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
    /// Invoke GraphQL Mutation vsphereVmRecoverFilesNew
    /// vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "Invoke",
        "RscGqlMutateVsphereVmRecoverFilesNew")
    ]
    public class Invoke_RscGqlMutateVsphereVmRecoverFilesNew : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the Invoke-RscGqlQuery* cmdlets
        // fit in the Invoke-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("vsphereVmRecoverFilesNew");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Invoke GraphQL Mutation vsphereVmRecoverFilesNew
        /// vsphereVmRecoverFilesNew(input: VsphereVmRecoverFilesNewInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_vsphereVmRecoverFilesNew();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_vsphereVmRecoverFilesNew()
        {
            this._logger.name += " -vsphereVmRecoverFilesNew";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereVmRecoverFilesNewInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereVmRecoverFilesNew",
                "($input: VsphereVmRecoverFilesNewInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereVmRecoverFilesNew_ObjectFieldSpec,
                Mutation.VsphereVmRecoverFilesNewFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		domainName = <System.String>
		# OPTIONAL
		ignoreErrors = <System.Boolean>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		shouldSaveCredentials = <System.Boolean>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		destObjectId = <System.String>
		# OPTIONAL
		shouldRestoreXAttrs = <System.Boolean>
		# OPTIONAL
		shouldUseAgent = <System.Boolean>
		# OPTIONAL
		guestCredentialId = <System.String>
		# REQUIRED
		restoreConfig = @(
			@{
				# OPTIONAL
				restorePathPair = @{
					# OPTIONAL
					restorePath = <System.String>
					# REQUIRED
					path = <System.String>
				}
			}
		)
	}
	# OPTIONAL
	deltaRequest = @{
		# REQUIRED
		nextSnapshotFid = <System.String>
		# REQUIRED
		deltaTypeFilter = @(
			<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
		)
	}
}"
            );
        }

    } // class Invoke-RscGqlMutateVsphereVmRecoverFilesNew
}