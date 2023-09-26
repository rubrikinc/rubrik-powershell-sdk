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

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'vSphere vCenter' API domain:
    /// Create, Delete, Refresh, Update, UpdateHotAddBandwidth, or UpdateHotAddNetwork.
    /// </summary>
    /// <description>
    /// New-RscMutationVcenter creates a new
    /// mutation object for operations
    /// in the 'vSphere vCenter' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'vSphere vCenter' API domain. Select the operation this
    /// query is for by specifying the appropriate switch parameter;
    /// one of: -Create, -Delete, -Refresh, -Update, -UpdateHotAddBandwidth, -UpdateHotAddNetwork.
    /// Alternatively, you can specify the operation by setting the
    /// -Op parameter, for example: -Op Create,
    /// which is equivalent to specifying -Create.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationVcenter -Create).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationVcenter -Create).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the Create operation
    /// of the 'vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    vSphere vCenter
    /// # API Operation: Create
    /// 
    /// $query = New-RscMutationVcenter -Create
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	vcenterDetail = @{
    /// 		# OPTIONAL
    /// 		caCerts = $someString
    /// 		# OPTIONAL
    /// 		computeVisibilityFilter = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				isVmwareMetroStorageCluster = $someBoolean
    /// 				# REQUIRED
    /// 				hostGroupFilter = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				id = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldEnableHotAddProxyForOnPrem = $someBoolean
    /// 		# OPTIONAL
    /// 		orgNetworkId = $someString
    /// 		# OPTIONAL
    /// 		conflictResolutionAuthz = $someVcenterConfigV2ConflictResolutionAuthz # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigV2ConflictResolutionAuthz]) for enum values.
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateVsphereVcenterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Delete operation
    /// of the 'vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    vSphere vCenter
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationVcenter -Delete
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Refresh operation
    /// of the 'vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    vSphere vCenter
    /// # API Operation: Refresh
    /// 
    /// $query = New-RscMutationVcenter -Refresh
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fid = $someString
    /// 	# OPTIONAL
    /// 	shouldDiagnose = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Update operation
    /// of the 'vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    vSphere vCenter
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationVcenter -Update
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		caCerts = $someString
    /// 		# OPTIONAL
    /// 		computeVisibilityFilter = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				isVmwareMetroStorageCluster = $someBoolean
    /// 				# REQUIRED
    /// 				hostGroupFilter = @(
    /// 					$someString
    /// 				)
    /// 				# REQUIRED
    /// 				id = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		shouldEnableHotAddProxyForOnPrem = $someBoolean
    /// 		# OPTIONAL
    /// 		conflictResolutionAuthz = $someVcenterConfigConflictResolutionAuthz # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigConflictResolutionAuthz]) for enum values.
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateVcenterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateHotAddBandwidth operation
    /// of the 'vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    vSphere vCenter
    /// # API Operation: UpdateHotAddBandwidth
    /// 
    /// $query = New-RscMutationVcenter -UpdateHotAddBandwidth
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	hotAddBandwidthInfo = @{
    /// 		# REQUIRED
    /// 		exportLimit = $someInt
    /// 		# REQUIRED
    /// 		ingestLimit = $someInt
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateHotAddNetwork operation
    /// of the 'vSphere vCenter' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    vSphere vCenter
    /// # API Operation: UpdateHotAddNetwork
    /// 
    /// $query = New-RscMutationVcenter -UpdateHotAddNetwork
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	hotAddNetworkInfo = @{
    /// 		# OPTIONAL
    /// 		staticIpInfo = @{
    /// 			# OPTIONAL
    /// 			dnsServers = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			gateway = $someString
    /// 			# REQUIRED
    /// 			ipAddresses = @(
    /// 				$someString
    /// 			)
    /// 			# REQUIRED
    /// 			subnetMask = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		networkId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationVcenter",
        DefaultParameterSetName = "Create")
    ]
    public class New_RscMutationVcenter : RscGqlPSCmdlet
    {
        
        [Parameter(
            ParameterSetName = "Create",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Create' operation
in the 'vSphere vCenter' API domain.
Description of the operation:
Add a vCenter server.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/createvspherevcenter.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Create { get; set; }

        
        [Parameter(
            ParameterSetName = "Delete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Delete' operation
in the 'vSphere vCenter' API domain.
Description of the operation:
Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/vspheredeletevcenter.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Delete { get; set; }

        
        [Parameter(
            ParameterSetName = "Refresh",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Refresh' operation
in the 'vSphere vCenter' API domain.
Description of the operation:
Refresh vCenter Server metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified vCenter Server.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/refreshvspherevcenter.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Refresh { get; set; }

        
        [Parameter(
            ParameterSetName = "Update",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'Update' operation
in the 'vSphere vCenter' API domain.
Description of the operation:
Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatevcenter.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter Update { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateHotAddBandwidth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateHotAddBandwidth' operation
in the 'vSphere vCenter' API domain.
Description of the operation:
Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatevcenterhotaddbandwidth.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateHotAddBandwidth { get; set; }

        
        [Parameter(
            ParameterSetName = "UpdateHotAddNetwork",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a mutation object for the 'UpdateHotAddNetwork' operation
in the 'vSphere vCenter' API domain.
Description of the operation:
Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
[GraphQL: https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/updatevcenterhotaddnetwork.doc.html]"
            // No Position -> named parameter only.
        )]
        public SwitchParameter UpdateHotAddNetwork { get; set; }



        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
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
                    case "UpdateHotAddBandwidth":
                        this.ProcessRecord_UpdateHotAddBandwidth();
                        break;
                    case "UpdateHotAddNetwork":
                        this.ProcessRecord_UpdateHotAddNetwork();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

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
        // updateVcenterHotAddBandwidth.
        internal void ProcessRecord_UpdateHotAddBandwidth()
        {
            this._logger.name += " -UpdateHotAddBandwidth";
            // Create new graphql operation updateVcenterHotAddBandwidth
            InitMutationUpdateVcenterHotAddBandwidth();
        }

        // This parameter set invokes a single graphql operation:
        // updateVcenterHotAddNetwork.
        internal void ProcessRecord_UpdateHotAddNetwork()
        {
            this._logger.name += " -UpdateHotAddNetwork";
            // Create new graphql operation updateVcenterHotAddNetwork
            InitMutationUpdateVcenterHotAddNetwork();
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
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	vcenterDetail = @{
		# OPTIONAL
		caCerts = $someString
		# OPTIONAL
		computeVisibilityFilter = @(
			@{
				# OPTIONAL
				isVmwareMetroStorageCluster = $someBoolean
				# REQUIRED
				hostGroupFilter = @(
					$someString
				)
				# REQUIRED
				id = $someString
			}
		)
		# OPTIONAL
		shouldEnableHotAddProxyForOnPrem = $someBoolean
		# OPTIONAL
		orgNetworkId = $someString
		# OPTIONAL
		conflictResolutionAuthz = $someVcenterConfigV2ConflictResolutionAuthz # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigV2ConflictResolutionAuthz]) for enum values.
		# REQUIRED
		hostname = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
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
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
$query.Var.input = @{
	# REQUIRED
	fid = $someString
	# OPTIONAL
	shouldDiagnose = $someBoolean
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
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		caCerts = $someString
		# OPTIONAL
		computeVisibilityFilter = @(
			@{
				# OPTIONAL
				isVmwareMetroStorageCluster = $someBoolean
				# REQUIRED
				hostGroupFilter = @(
					$someString
				)
				# REQUIRED
				id = $someString
			}
		)
		# OPTIONAL
		shouldEnableHotAddProxyForOnPrem = $someBoolean
		# OPTIONAL
		conflictResolutionAuthz = $someVcenterConfigConflictResolutionAuthz # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigConflictResolutionAuthz]) for enum values.
		# REQUIRED
		hostname = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
	}
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
$query.Var.input = @{
	# REQUIRED
	hotAddBandwidthInfo = @{
		# REQUIRED
		exportLimit = $someInt
		# REQUIRED
		ingestLimit = $someInt
	}
	# REQUIRED
	id = $someString
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
$query.Var.input = @{
	# REQUIRED
	hotAddNetworkInfo = @{
		# OPTIONAL
		staticIpInfo = @{
			# OPTIONAL
			dnsServers = @(
				$someString
			)
			# OPTIONAL
			gateway = $someString
			# REQUIRED
			ipAddresses = @(
				$someString
			)
			# REQUIRED
			subnetMask = $someString
		}
		# REQUIRED
		networkId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationVcenter
}