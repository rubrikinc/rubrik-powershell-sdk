// New-RscGqlMutationExportHypervVirtualMachine.cs
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
    /// Create new GraphQL Mutation exportHypervVirtualMachine
    /// exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationExportHypervVirtualMachine")
    ]
    public class New_RscGqlMutationExportHypervVirtualMachine : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("exportHypervVirtualMachine");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation exportHypervVirtualMachine
        /// exportHypervVirtualMachine(input: ExportHypervVirtualMachineInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_exportHypervVirtualMachine();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_exportHypervVirtualMachine()
        {
            this._logger.name += " -exportHypervVirtualMachine";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportHypervVirtualMachineInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportHypervVirtualMachine",
                "($input: ExportHypervVirtualMachineInput!)",
                "AsyncRequestStatus",
                Mutation.ExportHypervVirtualMachine_ObjectFieldSpec,
                Mutation.ExportHypervVirtualMachineFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		disableNetwork = <System.Boolean>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
		# REQUIRED
		path = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationExportHypervVirtualMachine
}