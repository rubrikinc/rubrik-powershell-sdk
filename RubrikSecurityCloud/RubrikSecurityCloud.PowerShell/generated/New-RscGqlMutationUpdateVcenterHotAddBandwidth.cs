// New-RscGqlMutationUpdateVcenterHotAddBandwidth.cs
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
    /// Create new GraphQL Mutation updateVcenterHotAddBandwidth
    /// updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateVcenterHotAddBandwidth")
    ]
    public class New_RscGqlMutationUpdateVcenterHotAddBandwidth : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateVcenterHotAddBandwidth");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateVcenterHotAddBandwidth
        /// updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateVcenterHotAddBandwidth();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateVcenterHotAddBandwidth()
        {
            this._logger.name += " -updateVcenterHotAddBandwidth";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddBandwidthInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcenterHotAddBandwidth",
                "($input: UpdateVcenterHotAddBandwidthInput!)",
                "RequestSuccess",
                Mutation.UpdateVcenterHotAddBandwidth_ObjectFieldSpec,
                Mutation.UpdateVcenterHotAddBandwidthFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	hotAddBandwidthInfo = @{
		# REQUIRED
		exportLimit = <System.Int32>
		# REQUIRED
		ingestLimit = <System.Int32>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateVcenterHotAddBandwidth
}