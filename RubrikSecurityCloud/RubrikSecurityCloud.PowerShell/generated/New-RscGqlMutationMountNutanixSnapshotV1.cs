// New-RscGqlMutationMountNutanixSnapshotV1.cs
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
    /// Create new GraphQL Mutation mountNutanixSnapshotV1
    /// mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationMountNutanixSnapshotV1")
    ]
    public class New_RscGqlMutationMountNutanixSnapshotV1 : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("mountNutanixSnapshotV1");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation mountNutanixSnapshotV1
        /// mountNutanixSnapshotV1(input: MountNutanixSnapshotV1Input!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_mountNutanixSnapshotV1();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_mountNutanixSnapshotV1()
        {
            this._logger.name += " -mountNutanixSnapshotV1";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountNutanixSnapshotV1Input!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMountNutanixSnapshotV1",
                "($input: MountNutanixSnapshotV1Input!)",
                "AsyncRequestStatus",
                Mutation.MountNutanixSnapshotV1_ObjectFieldSpec,
                Mutation.MountNutanixSnapshotV1FieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		containerNaturalId = <System.String>
		# OPTIONAL
		nutanixClusterId = <System.String>
		# OPTIONAL
		shouldMigrateImmediately = <System.Boolean>
		# OPTIONAL
		shouldPowerOn = <System.Boolean>
		# OPTIONAL
		shouldRemoveNetwork = <System.Boolean>
		# OPTIONAL
		targetNetwork = <System.String>
		# OPTIONAL
		vmName = <System.String>
		# OPTIONAL
		keepMacAddresses = <System.Boolean>
		# OPTIONAL
		nicNetworkUuids = @(
			<System.String>
		)
		# REQUIRED
		shouldDisableMigration = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationMountNutanixSnapshotV1
}