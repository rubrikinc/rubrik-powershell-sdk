// New-RscGqlMutationExportNutanixSnapshot.cs
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
    /// Create new GraphQL Mutation exportNutanixSnapshot
    /// exportNutanixSnapshot(input: ExportNutanixSnapshotInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExportNutanixSnapshot")
    ]
    public class New_RscGqlMutationExportNutanixSnapshot : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("exportNutanixSnapshot");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation exportNutanixSnapshot
        /// exportNutanixSnapshot(input: ExportNutanixSnapshotInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_exportNutanixSnapshot();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_exportNutanixSnapshot()
        {
            this._logger.name += " -exportNutanixSnapshot";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportNutanixSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportNutanixSnapshot",
                "($input: ExportNutanixSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.ExportNutanixSnapshot_ObjectFieldSpec,
                Mutation.ExportNutanixSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		nutanixClusterId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
		# OPTIONAL
		keepMacAddresses = <System.Boolean>
		# OPTIONAL
		nicNetworkUuids = @(
			<System.String>
		)
		# REQUIRED
		containerNaturalId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationExportNutanixSnapshot
}