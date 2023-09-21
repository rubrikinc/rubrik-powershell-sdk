// New-RscMutationVcenter.cs
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
    /// Mutations for the 'vSphere vCenter' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationVcenter is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationVcenter -Create [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVcenter -Delete [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVcenter -Refresh [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVcenter -Update [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVcenter -UpdateHotAddNetwork [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationVcenter -UpdateHotAddBandwidth [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationVcenter",
        DefaultParameterSetName = "Create")
    ]
    public class New_RscMutationVcenter : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Create parameter set
        ///
        /// [GraphQL: createVsphereVcenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add a vCenter server.
[GraphQL: createVsphereVcenter]",
            Position = 0
        )]
        public SwitchParameter Create { get; set; }

        
        /// <summary>
        /// Delete parameter set
        ///
        /// [GraphQL: vsphereDeleteVcenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Delete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.
[GraphQL: vsphereDeleteVcenter]",
            Position = 0
        )]
        public SwitchParameter Delete { get; set; }

        
        /// <summary>
        /// Refresh parameter set
        ///
        /// [GraphQL: refreshVsphereVcenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Refresh",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh vCenter Server metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified vCenter Server.
[GraphQL: refreshVsphereVcenter]",
            Position = 0
        )]
        public SwitchParameter Refresh { get; set; }

        
        /// <summary>
        /// Update parameter set
        ///
        /// [GraphQL: updateVcenter]
        /// </summary>
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.
[GraphQL: updateVcenter]",
            Position = 0
        )]
        public SwitchParameter Update { get; set; }

        
        /// <summary>
        /// UpdateHotAddNetwork parameter set
        ///
        /// [GraphQL: updateVcenterHotAddNetwork]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateHotAddNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
[GraphQL: updateVcenterHotAddNetwork]",
            Position = 0
        )]
        public SwitchParameter UpdateHotAddNetwork { get; set; }

        
        /// <summary>
        /// UpdateHotAddBandwidth parameter set
        ///
        /// [GraphQL: updateVcenterHotAddBandwidth]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateHotAddBandwidth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
[GraphQL: updateVcenterHotAddBandwidth]",
            Position = 0
        )]
        public SwitchParameter UpdateHotAddBandwidth { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "Create":
                        this.ProcessRecord_Create();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "Refresh":
                        this.ProcessRecord_Refresh();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "UpdateHotAddNetwork":
                        this.ProcessRecord_UpdateHotAddNetwork();
                        break;
                    case "UpdateHotAddBandwidth":
                        this.ProcessRecord_UpdateHotAddBandwidth();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // createVsphereVcenter.
        internal void ProcessRecord_Create()
        {
            this._logger.name += " -Create";
            // Create new graphql operation createVsphereVcenter
            InitMutationCreateVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereDeleteVcenter.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation vsphereDeleteVcenter
            InitMutationVsphereDeleteVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // refreshVsphereVcenter.
        internal void ProcessRecord_Refresh()
        {
            this._logger.name += " -Refresh";
            // Create new graphql operation refreshVsphereVcenter
            InitMutationRefreshVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenter.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateVcenter
            InitMutationUpdateVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddNetwork.
        internal void ProcessRecord_UpdateHotAddNetwork()
        {
            this._logger.name += " -UpdateHotAddNetwork";
            // Create new graphql operation updateVcenterHotAddNetwork
            InitMutationUpdateVcenterHotAddNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddBandwidth.
        internal void ProcessRecord_UpdateHotAddBandwidth()
        {
            this._logger.name += " -UpdateHotAddBandwidth";
            // Create new graphql operation updateVcenterHotAddBandwidth
            InitMutationUpdateVcenterHotAddBandwidth();
        }


        // Create new GraphQL Mutation:
        // createVsphereVcenter(input: CreateVsphereVcenterInput!): CreateVsphereVcenterReply!
        internal void InitMutationCreateVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateVsphereVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateVsphereVcenter",
                "($input: CreateVsphereVcenterInput!)",
                "CreateVsphereVcenterReply",
                Mutation.CreateVsphereVcenter_ObjectFieldSpec,
                Mutation.CreateVsphereVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	vcenterDetail = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		computeVisibilityFilter = @(
			@{
				# OPTIONAL
				isVmwareMetroStorageCluster = <System.Boolean>
				# REQUIRED
				hostGroupFilter = @(
					<System.String>
				)
				# REQUIRED
				id = <System.String>
			}
		)
		# OPTIONAL
		shouldEnableHotAddProxyForOnPrem = <System.Boolean>
		# OPTIONAL
		orgNetworkId = <System.String>
		# OPTIONAL
		conflictResolutionAuthz = <VcenterConfigV2ConflictResolutionAuthz> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigV2ConflictResolutionAuthz]) for enum values.
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // vsphereDeleteVcenter(input: VsphereDeleteVcenterInput!): AsyncRequestStatus!
        internal void InitMutationVsphereDeleteVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "VsphereDeleteVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationVsphereDeleteVcenter",
                "($input: VsphereDeleteVcenterInput!)",
                "AsyncRequestStatus",
                Mutation.VsphereDeleteVcenter_ObjectFieldSpec,
                Mutation.VsphereDeleteVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshVsphereVcenter(input: RefreshVsphereVcenterInput!): AsyncRequestStatus!
        internal void InitMutationRefreshVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshVsphereVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshVsphereVcenter",
                "($input: RefreshVsphereVcenterInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshVsphereVcenter_ObjectFieldSpec,
                Mutation.RefreshVsphereVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	fid = <System.String>
	# OPTIONAL
	shouldDiagnose = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVcenter(input: UpdateVcenterInput!): UpdateVcenterReply!
        internal void InitMutationUpdateVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateVcenterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateVcenter",
                "($input: UpdateVcenterInput!)",
                "UpdateVcenterReply",
                Mutation.UpdateVcenter_ObjectFieldSpec,
                Mutation.UpdateVcenterFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		computeVisibilityFilter = @(
			@{
				# OPTIONAL
				isVmwareMetroStorageCluster = <System.Boolean>
				# REQUIRED
				hostGroupFilter = @(
					<System.String>
				)
				# REQUIRED
				id = <System.String>
			}
		)
		# OPTIONAL
		shouldEnableHotAddProxyForOnPrem = <System.Boolean>
		# OPTIONAL
		conflictResolutionAuthz = <VcenterConfigConflictResolutionAuthz> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigConflictResolutionAuthz]) for enum values.
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateVcenterHotAddNetwork(input: UpdateVcenterHotAddNetworkInput!): RequestSuccess!
        internal void InitMutationUpdateVcenterHotAddNetwork()
        {
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

        // Create new GraphQL Mutation:
        // updateVcenterHotAddBandwidth(input: UpdateVcenterHotAddBandwidthInput!): RequestSuccess!
        internal void InitMutationUpdateVcenterHotAddBandwidth()
        {
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


    } // class New_RscMutationVcenter
}