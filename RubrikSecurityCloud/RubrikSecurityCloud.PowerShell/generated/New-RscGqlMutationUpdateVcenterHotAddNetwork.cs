// New-RscGqlMutationUpdateVcenterHotAddNetwork.cs
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
    /// Create new GraphQL Mutation updateVcenterHotAddNetwork
    /// updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!): RequestSuccess!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationUpdateVcenterHotAddNetwork")
    ]
    public class New_RscGqlMutationUpdateVcenterHotAddNetwork : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("updateVcenterHotAddNetwork");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation updateVcenterHotAddNetwork
        /// updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!): RequestSuccess!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_updateVcenterHotAddNetwork();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_updateVcenterHotAddNetwork()
        {
            this._logger.name += " -updateVcenterHotAddNetwork";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterHotAddNetworkInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcenterHotAddNetwork",
                "($input: UpdateVcenterHotAddNetworkInput!)",
                "RequestSuccess",
                Mutation.UpdateVcenterHotAddNetwork_ObjectFieldSpec,
                Mutation.UpdateVcenterHotAddNetworkFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	hotAddNetworkInfo = @{
		# OPTIONAL
		staticIpInfo = @{
			# OPTIONAL
			dnsServers = @(
				<System.String>
			)
			# OPTIONAL
			gateway = <System.String>
			# REQUIRED
			ipAddresses = @(
				<System.String>
			)
			# REQUIRED
			subnetMask = <System.String>
		}
		# REQUIRED
		networkId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationUpdateVcenterHotAddNetwork
}