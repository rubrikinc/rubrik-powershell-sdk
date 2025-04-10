// New-RscMutationCluster.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
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
    /// Create a new RscQuery object for any of the 23
    /// operations in the 'Cluster' API domain:
    /// AddClusterNodes, AddClusterRoute, AddNodesToCloud, DeleteClusterRoute, DeleteTerminatedClusterOperationJobData, DisconnectExocompute, ExocomputeClusterConnect, GenerateClusterRegistrationToken, MigrateCloudClusterDisks, RecoverCloud, RegisterCloud, ReleasePersistentExo, RemoveCdm, RemoveClusterNodes, ReplaceClusterNode, RequestPersistentExo, SetMissingClusterStatus, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterPauseStatus, UpdateClusterSettings, or UpdatePreviewerClusterConfig.
    /// </summary>
    /// <description>
    /// New-RscMutationCluster creates a new
    /// mutation object for operations
    /// in the 'Cluster' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 23 operations
    /// in the 'Cluster' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddClusterNodes, AddClusterRoute, AddNodesToCloud, DeleteClusterRoute, DeleteTerminatedClusterOperationJobData, DisconnectExocompute, ExocomputeClusterConnect, GenerateClusterRegistrationToken, MigrateCloudClusterDisks, RecoverCloud, RegisterCloud, ReleasePersistentExo, RemoveCdm, RemoveClusterNodes, ReplaceClusterNode, RequestPersistentExo, SetMissingClusterStatus, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterPauseStatus, UpdateClusterSettings, or UpdatePreviewerClusterConfig.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCluster -AddClusterNodes).Info().
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
    /// (New-RscMutationCluster -AddClusterNodes).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddClusterNodes operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: AddClusterNodes
    /// 
    /// $query = New-RscMutationCluster -Operation AddClusterNodes
    /// 
    /// # REQUIRED
    /// $query.Var.AddClusterNodesInput = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	nodesMap = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			key = $someString
    /// 			# REQUIRED
    /// 			value = @{
    /// 				# OPTIONAL
    /// 				dataIpConfig = @{
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# REQUIRED
    /// 					address = $someString
    /// 					# REQUIRED
    /// 					gateway = $someString
    /// 					# REQUIRED
    /// 					netmask = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				ipmiIpConfig = @{
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# REQUIRED
    /// 					address = $someString
    /// 					# REQUIRED
    /// 					gateway = $someString
    /// 					# REQUIRED
    /// 					netmask = $someString
    /// 				}
    /// 				# REQUIRED
    /// 				managementIpConfig = @{
    /// 					# OPTIONAL
    /// 					vlan = $someInt
    /// 					# REQUIRED
    /// 					address = $someString
    /// 					# REQUIRED
    /// 					gateway = $someString
    /// 					# REQUIRED
    /// 					netmask = $someString
    /// 				}
    /// 				# OPTIONAL
    /// 				vlanIpConfigs = @(
    /// 					@{
    /// 						# REQUIRED
    /// 						ip = $someString
    /// 						# REQUIRED
    /// 						vlan = $someInt
    /// 					}
    /// 				)
    /// 				# OPTIONAL
    /// 				chassisId = $someString
    /// 			}
    /// 		}
    /// 	)
    /// 	# REQUIRED
    /// 	request = @{
    /// 		# OPTIONAL
    /// 		encryptionPassword = $someString
    /// 		# OPTIONAL
    /// 		isIpv4ManualDiscoveryMode = $someBoolean
    /// 		# OPTIONAL
    /// 		isLinkLocalIpv4Mode = $someBoolean
    /// 		# REQUIRED
    /// 		ipmiPassword = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddClusterNodesReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddClusterRoute operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: AddClusterRoute
    /// 
    /// $query = New-RscMutationCluster -Operation AddClusterRoute
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	routeConfig = @{
    /// 		# REQUIRED
    /// 		device = $someString
    /// 		# REQUIRED
    /// 		gateway = $someString
    /// 		# REQUIRED
    /// 		netmask = $someString
    /// 		# REQUIRED
    /// 		network = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddClusterRouteReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddNodesToCloud operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: AddNodesToCloud
    /// 
    /// $query = New-RscMutationCluster -Operation AddNodesToCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	numberOfNodes = $someInt
    /// 	# OPTIONAL
    /// 	awsImageId = $someString
    /// 	# OPTIONAL
    /// 	azureImageName = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	vendor = $someCcpVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	shouldKeepResourcesOnFailure = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteClusterRoute operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DeleteClusterRoute
    /// 
    /// $query = New-RscMutationCluster -Operation DeleteClusterRoute
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	routeConfig = @{
    /// 		# REQUIRED
    /// 		netmask = $someString
    /// 		# REQUIRED
    /// 		network = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteTerminatedClusterOperationJobData operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DeleteTerminatedClusterOperationJobData
    /// 
    /// $query = New-RscMutationCluster -Operation DeleteTerminatedClusterOperationJobData
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	jobType = $someCcpJobType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteTerminatedClusterOperationJobDataReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DisconnectExocompute operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DisconnectExocompute
    /// 
    /// $query = New-RscMutationCluster -Operation DisconnectExocompute
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterId = $someString
    /// 	# REQUIRED
    /// 	cloudType = $someCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ExocomputeClusterConnect operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ExocomputeClusterConnect
    /// 
    /// $query = New-RscMutationCluster -Operation ExocomputeClusterConnect
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterName = $someString
    /// 	# REQUIRED
    /// 	exocomputeConfigId = $someString
    /// 	# REQUIRED
    /// 	cloudType = $someCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ExocomputeClusterConnectReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GenerateClusterRegistrationToken operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: GenerateClusterRegistrationToken
    /// 
    /// $query = New-RscMutationCluster -Operation GenerateClusterRegistrationToken
    /// 
    /// # OPTIONAL
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	managedByPolaris = $someBoolean
    /// 	# OPTIONAL
    /// 	nodeConfigs = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			id = $someString
    /// 			# OPTIONAL
    /// 			manufactureTime = $someDateTime
    /// 			# OPTIONAL
    /// 			serial = $someString
    /// 			# OPTIONAL
    /// 			systemUuid = $someString
    /// 			# OPTIONAL
    /// 			teleportToken = $someString
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 			# OPTIONAL
    /// 			platform = $someString
    /// 			# OPTIONAL
    /// 			capacity = $someString
    /// 			# OPTIONAL
    /// 			isEntitled = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isOfflineRegistration = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterRegistrationToken
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MigrateCloudClusterDisks operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: MigrateCloudClusterDisks
    /// 
    /// $query = New-RscMutationCluster -Operation MigrateCloudClusterDisks
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	vendor = $someCcpVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	batchSize = $someInt
    /// 	# OPTIONAL
    /// 	newNodeCount = $someInt
    /// 	# OPTIONAL
    /// 	migrateToExtraDense = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverCloud operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RecoverCloud
    /// 
    /// $query = New-RscMutationCluster -Operation RecoverCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	adminPassword = $someString
    /// 	# OPTIONAL
    /// 	userEmail = $someString
    /// 	# REQUIRED
    /// 	cloudAccountId = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	azureEsResourceGroup = $someString
    /// 	# OPTIONAL
    /// 	azureVmConfig = @{
    /// 		# OPTIONAL
    /// 		resourceGroup = $someString
    /// 		# OPTIONAL
    /// 		cdmVersion = $someString
    /// 		# OPTIONAL
    /// 		location = $someString
    /// 		# OPTIONAL
    /// 		nodeSizeGb = $someInt
    /// 		# OPTIONAL
    /// 		networkResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnetResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityGroup = $someString
    /// 		# OPTIONAL
    /// 		networkSecurityResourceGroup = $someString
    /// 		# OPTIONAL
    /// 		vnet = $someString
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		tags = $someString
    /// 		# OPTIONAL
    /// 		vmImage = $someString
    /// 		# OPTIONAL
    /// 		cdmProduct = $someString
    /// 		# OPTIONAL
    /// 		availabilityZone = $someString
    /// 		# OPTIONAL
    /// 		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
    /// 		# OPTIONAL
    /// 		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
    /// 	}
    /// 	# OPTIONAL
    /// 	awsVmConfig = @{
    /// 		# OPTIONAL
    /// 		cdmVersion = $someString
    /// 		# OPTIONAL
    /// 		nodeSizeGb = $someInt
    /// 		# OPTIONAL
    /// 		subnet = $someString
    /// 		# OPTIONAL
    /// 		tags = $someString
    /// 		# OPTIONAL
    /// 		imageId = $someString
    /// 		# OPTIONAL
    /// 		instanceProfileName = $someString
    /// 		# OPTIONAL
    /// 		cdmProduct = $someString
    /// 		# OPTIONAL
    /// 		placementGroupName = $someString
    /// 		# OPTIONAL
    /// 		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
    /// 		# OPTIONAL
    /// 		securityGroups = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		instanceType = $someAwsInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
    /// 		# OPTIONAL
    /// 		networkConfig = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				availabilityZone = $someString
    /// 				# OPTIONAL
    /// 				subnet = $someString
    /// 			}
    /// 		)
    /// 	}
    /// 	# OPTIONAL
    /// 	awsRegion = $someString
    /// 	# REQUIRED
    /// 	shouldDisableAwsApiTermination = $someBoolean
    /// 	# REQUIRED
    /// 	shouldKeepClusterOnFailure = $someBoolean
    /// 	# OPTIONAL
    /// 	ntpServers = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RegisterCloud operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RegisterCloud
    /// 
    /// $query = New-RscMutationCluster -Operation RegisterCloud
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RegisterCloudClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReleasePersistentExo operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ReleasePersistentExo
    /// 
    /// $query = New-RscMutationCluster -Operation ReleasePersistentExo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// 	# REQUIRED
    /// 	exocomputeConfigId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveCdm operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RemoveCdm
    /// 
    /// $query = New-RscMutationCluster -Operation RemoveCdm
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUUID = $someString
    /// # REQUIRED
    /// $query.Var.isForce = $someBoolean
    /// # OPTIONAL
    /// $query.Var.expireInDays = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RemoveClusterNodes operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RemoveClusterNodes
    /// 
    /// $query = New-RscMutationCluster -Operation RemoveClusterNodes
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	nodeIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	useQuickDrain = $someBoolean
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	nodeMetadata = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			nodeId = $someString
    /// 			# OPTIONAL
    /// 			chassisId = $someString
    /// 			# OPTIONAL
    /// 			platform = $someClusterNodePlatformType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodePlatformType]) for enum values.
    /// 			# OPTIONAL
    /// 			status = $someClusterNodeStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodeStatus]) for enum values.
    /// 			# OPTIONAL
    /// 			useQuickDrain = $someBoolean
    /// 			# OPTIONAL
    /// 			resetAfterRemoveType = $someResetAfterRemoveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResetAfterRemoveType]) for enum values.
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	resetAfterRemoveType = $someResetAfterRemoveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResetAfterRemoveType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CcProvisionJobReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ReplaceClusterNode operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ReplaceClusterNode
    /// 
    /// $query = New-RscMutationCluster -Operation ReplaceClusterNode
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	newNodeId = $someString
    /// 	# OPTIONAL
    /// 	ipmiPassword = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ReplaceClusterNodeReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RequestPersistentExo operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RequestPersistentExo
    /// 
    /// $query = New-RscMutationCluster -Operation RequestPersistentExo
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
    /// 	# REQUIRED
    /// 	exocomputeConfigId = $someString
    /// 	# OPTIONAL
    /// 	durationInDays = $someInt
    /// 	# OPTIONAL
    /// 	azureSpecificClusterParams = @{
    /// 		# OPTIONAL
    /// 		nodeType = $someString
    /// 	}
    /// 	# OPTIONAL
    /// 	awsSpecificClusterParams = @{
    /// 		# OPTIONAL
    /// 		nodeKeypairName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RequestPersistentExoclusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetMissingClusterStatus operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: SetMissingClusterStatus
    /// 
    /// $query = New-RscMutationCluster -Operation SetMissingClusterStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	disconnectedState = $someMissingClusterDisconnectedState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MissingClusterDisconnectedState]) for enum values.
    /// 	# OPTIONAL
    /// 	exclusionReason = $someString
    /// 	# REQUIRED
    /// 	uuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SetMissingClusterStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClusterDefaultAddress operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterDefaultAddress
    /// 
    /// $query = New-RscMutationCluster -Operation UpdateClusterDefaultAddress
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# OPTIONAL
    /// 	address = $someString
    /// 	# OPTIONAL
    /// 	port = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateClusterDefaultAddressReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClusterLocation operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterLocation
    /// 
    /// $query = New-RscMutationCluster -Operation UpdateClusterLocation
    /// 
    /// # REQUIRED
    /// $query.Var.clusterUuid = $someString
    /// # REQUIRED
    /// $query.Var.clusterLocation = @{
    /// 	# REQUIRED
    /// 	address = $someString
    /// 	# REQUIRED
    /// 	latitude = $someSingle
    /// 	# REQUIRED
    /// 	longitude = $someSingle
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Cluster
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClusterNtpServers operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterNtpServers
    /// 
    /// $query = New-RscMutationCluster -Operation UpdateClusterNtpServers
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	ntpServerConfigs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			server = $someString
    /// 			# OPTIONAL
    /// 			symmetricKey = @{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				keyId = $someInt
    /// 				# REQUIRED
    /// 				keyType = $someString
    /// 			}
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResponseSuccess
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClusterPauseStatus operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterPauseStatus
    /// 
    /// $query = New-RscMutationCluster -Operation UpdateClusterPauseStatus
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	clusterUuids = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	togglePauseStatus = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateClusterPauseStatusReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateClusterSettings operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterSettings
    /// 
    /// $query = New-RscMutationCluster -Operation UpdateClusterSettings
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUpdate = @{
    /// 		# OPTIONAL
    /// 		acceptedEulaVersion = $someString
    /// 		# OPTIONAL
    /// 		geolocation = @{
    /// 			# REQUIRED
    /// 			address = $someString
    /// 		}
    /// 		# OPTIONAL
    /// 		name = $someString
    /// 		# OPTIONAL
    /// 		timezone = @{
    /// 			# REQUIRED
    /// 			timezone = $someClusterTimezoneType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTimezoneType]) for enum values.
    /// 		}
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateClusterSettingsReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdatePreviewerClusterConfig operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdatePreviewerClusterConfig
    /// 
    /// $query = New-RscMutationCluster -Operation UpdatePreviewerClusterConfig
    /// 
    /// # REQUIRED
    /// $query.Var.previewerClusterConfig = @{
    /// 	# OPTIONAL
    /// 	clusterId = $someString
    /// 	# OPTIONAL
    /// 	enabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: Cluster
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
        "RscMutationCluster",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationCluster : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddClusterNodes",
                "AddClusterRoute",
                "AddNodesToCloud",
                "DeleteClusterRoute",
                "DeleteTerminatedClusterOperationJobData",
                "DisconnectExocompute",
                "ExocomputeClusterConnect",
                "GenerateClusterRegistrationToken",
                "MigrateCloudClusterDisks",
                "RecoverCloud",
                "RegisterCloud",
                "ReleasePersistentExo",
                "RemoveCdm",
                "RemoveClusterNodes",
                "ReplaceClusterNode",
                "RequestPersistentExo",
                "SetMissingClusterStatus",
                "UpdateClusterDefaultAddress",
                "UpdateClusterLocation",
                "UpdateClusterNtpServers",
                "UpdateClusterPauseStatus",
                "UpdateClusterSettings",
                "UpdatePreviewerClusterConfig",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AddClusterNodes":
                        this.ProcessRecord_AddClusterNodes();
                        break;
                    case "AddClusterRoute":
                        this.ProcessRecord_AddClusterRoute();
                        break;
                    case "AddNodesToCloud":
                        this.ProcessRecord_AddNodesToCloud();
                        break;
                    case "DeleteClusterRoute":
                        this.ProcessRecord_DeleteClusterRoute();
                        break;
                    case "DeleteTerminatedClusterOperationJobData":
                        this.ProcessRecord_DeleteTerminatedClusterOperationJobData();
                        break;
                    case "DisconnectExocompute":
                        this.ProcessRecord_DisconnectExocompute();
                        break;
                    case "ExocomputeClusterConnect":
                        this.ProcessRecord_ExocomputeClusterConnect();
                        break;
                    case "GenerateClusterRegistrationToken":
                        this.ProcessRecord_GenerateClusterRegistrationToken();
                        break;
                    case "MigrateCloudClusterDisks":
                        this.ProcessRecord_MigrateCloudClusterDisks();
                        break;
                    case "RecoverCloud":
                        this.ProcessRecord_RecoverCloud();
                        break;
                    case "RegisterCloud":
                        this.ProcessRecord_RegisterCloud();
                        break;
                    case "ReleasePersistentExo":
                        this.ProcessRecord_ReleasePersistentExo();
                        break;
                    case "RemoveCdm":
                        this.ProcessRecord_RemoveCdm();
                        break;
                    case "RemoveClusterNodes":
                        this.ProcessRecord_RemoveClusterNodes();
                        break;
                    case "ReplaceClusterNode":
                        this.ProcessRecord_ReplaceClusterNode();
                        break;
                    case "RequestPersistentExo":
                        this.ProcessRecord_RequestPersistentExo();
                        break;
                    case "SetMissingClusterStatus":
                        this.ProcessRecord_SetMissingClusterStatus();
                        break;
                    case "UpdateClusterDefaultAddress":
                        this.ProcessRecord_UpdateClusterDefaultAddress();
                        break;
                    case "UpdateClusterLocation":
                        this.ProcessRecord_UpdateClusterLocation();
                        break;
                    case "UpdateClusterNtpServers":
                        this.ProcessRecord_UpdateClusterNtpServers();
                        break;
                    case "UpdateClusterPauseStatus":
                        this.ProcessRecord_UpdateClusterPauseStatus();
                        break;
                    case "UpdateClusterSettings":
                        this.ProcessRecord_UpdateClusterSettings();
                        break;
                    case "UpdatePreviewerClusterConfig":
                        this.ProcessRecord_UpdatePreviewerClusterConfig();
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
        // addClusterNodes.
        internal void ProcessRecord_AddClusterNodes()
        {
            this._logger.name += " -AddClusterNodes";
            // Create new graphql operation addClusterNodes
            InitMutationAddClusterNodes();
        }

        // This parameter set invokes a single graphql operation:
        // addClusterRoute.
        internal void ProcessRecord_AddClusterRoute()
        {
            this._logger.name += " -AddClusterRoute";
            // Create new graphql operation addClusterRoute
            InitMutationAddClusterRoute();
        }

        // This parameter set invokes a single graphql operation:
        // addNodesToCloudCluster.
        internal void ProcessRecord_AddNodesToCloud()
        {
            this._logger.name += " -AddNodesToCloud";
            // Create new graphql operation addNodesToCloudCluster
            InitMutationAddNodesToCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteClusterRoute.
        internal void ProcessRecord_DeleteClusterRoute()
        {
            this._logger.name += " -DeleteClusterRoute";
            // Create new graphql operation deleteClusterRoute
            InitMutationDeleteClusterRoute();
        }

        // This parameter set invokes a single graphql operation:
        // deleteTerminatedClusterOperationJobData.
        internal void ProcessRecord_DeleteTerminatedClusterOperationJobData()
        {
            this._logger.name += " -DeleteTerminatedClusterOperationJobData";
            // Create new graphql operation deleteTerminatedClusterOperationJobData
            InitMutationDeleteTerminatedClusterOperationJobData();
        }

        // This parameter set invokes a single graphql operation:
        // disconnectExocomputeCluster.
        internal void ProcessRecord_DisconnectExocompute()
        {
            this._logger.name += " -DisconnectExocompute";
            // Create new graphql operation disconnectExocomputeCluster
            InitMutationDisconnectExocomputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // exocomputeClusterConnect.
        internal void ProcessRecord_ExocomputeClusterConnect()
        {
            this._logger.name += " -ExocomputeClusterConnect";
            // Create new graphql operation exocomputeClusterConnect
            InitMutationExocomputeClusterConnect();
        }

        // This parameter set invokes a single graphql operation:
        // generateClusterRegistrationToken.
        internal void ProcessRecord_GenerateClusterRegistrationToken()
        {
            this._logger.name += " -GenerateClusterRegistrationToken";
            // Create new graphql operation generateClusterRegistrationToken
            InitMutationGenerateClusterRegistrationToken();
        }

        // This parameter set invokes a single graphql operation:
        // migrateCloudClusterDisks.
        internal void ProcessRecord_MigrateCloudClusterDisks()
        {
            this._logger.name += " -MigrateCloudClusterDisks";
            // Create new graphql operation migrateCloudClusterDisks
            InitMutationMigrateCloudClusterDisks();
        }

        // This parameter set invokes a single graphql operation:
        // recoverCloudCluster.
        internal void ProcessRecord_RecoverCloud()
        {
            this._logger.name += " -RecoverCloud";
            // Create new graphql operation recoverCloudCluster
            InitMutationRecoverCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // registerCloudCluster.
        internal void ProcessRecord_RegisterCloud()
        {
            this._logger.name += " -RegisterCloud";
            // Create new graphql operation registerCloudCluster
            InitMutationRegisterCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // releasePersistentExoclusters.
        internal void ProcessRecord_ReleasePersistentExo()
        {
            this._logger.name += " -ReleasePersistentExo";
            // Create new graphql operation releasePersistentExoclusters
            InitMutationReleasePersistentExoclusters();
        }

        // This parameter set invokes a single graphql operation:
        // removeCdmCluster.
        internal void ProcessRecord_RemoveCdm()
        {
            this._logger.name += " -RemoveCdm";
            // Create new graphql operation removeCdmCluster
            InitMutationRemoveCdmCluster();
        }

        // This parameter set invokes a single graphql operation:
        // removeClusterNodes.
        internal void ProcessRecord_RemoveClusterNodes()
        {
            this._logger.name += " -RemoveClusterNodes";
            // Create new graphql operation removeClusterNodes
            InitMutationRemoveClusterNodes();
        }

        // This parameter set invokes a single graphql operation:
        // replaceClusterNode.
        internal void ProcessRecord_ReplaceClusterNode()
        {
            this._logger.name += " -ReplaceClusterNode";
            // Create new graphql operation replaceClusterNode
            InitMutationReplaceClusterNode();
        }

        // This parameter set invokes a single graphql operation:
        // requestPersistentExocluster.
        internal void ProcessRecord_RequestPersistentExo()
        {
            this._logger.name += " -RequestPersistentExo";
            // Create new graphql operation requestPersistentExocluster
            InitMutationRequestPersistentExocluster();
        }

        // This parameter set invokes a single graphql operation:
        // setMissingClusterStatus.
        internal void ProcessRecord_SetMissingClusterStatus()
        {
            this._logger.name += " -SetMissingClusterStatus";
            // Create new graphql operation setMissingClusterStatus
            InitMutationSetMissingClusterStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterDefaultAddress.
        internal void ProcessRecord_UpdateClusterDefaultAddress()
        {
            this._logger.name += " -UpdateClusterDefaultAddress";
            // Create new graphql operation updateClusterDefaultAddress
            InitMutationUpdateClusterDefaultAddress();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterLocation.
        internal void ProcessRecord_UpdateClusterLocation()
        {
            this._logger.name += " -UpdateClusterLocation";
            // Create new graphql operation updateClusterLocation
            InitMutationUpdateClusterLocation();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterNtpServers.
        internal void ProcessRecord_UpdateClusterNtpServers()
        {
            this._logger.name += " -UpdateClusterNtpServers";
            // Create new graphql operation updateClusterNtpServers
            InitMutationUpdateClusterNtpServers();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterPauseStatus.
        internal void ProcessRecord_UpdateClusterPauseStatus()
        {
            this._logger.name += " -UpdateClusterPauseStatus";
            // Create new graphql operation updateClusterPauseStatus
            InitMutationUpdateClusterPauseStatus();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterSettings.
        internal void ProcessRecord_UpdateClusterSettings()
        {
            this._logger.name += " -UpdateClusterSettings";
            // Create new graphql operation updateClusterSettings
            InitMutationUpdateClusterSettings();
        }

        // This parameter set invokes a single graphql operation:
        // updatePreviewerClusterConfig.
        internal void ProcessRecord_UpdatePreviewerClusterConfig()
        {
            this._logger.name += " -UpdatePreviewerClusterConfig";
            // Create new graphql operation updatePreviewerClusterConfig
            InitMutationUpdatePreviewerClusterConfig();
        }


        // Create new GraphQL Mutation:
        // addClusterNodes(AddClusterNodesInput: AddClusterNodesInput!): AddClusterNodesReply!
        internal void InitMutationAddClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("AddClusterNodesInput", "AddClusterNodesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddClusterNodes",
                "($AddClusterNodesInput: AddClusterNodesInput!)",
                "AddClusterNodesReply",
                Mutation.AddClusterNodes,
                Mutation.AddClusterNodesFieldSpec,
                @"# REQUIRED
$query.Var.AddClusterNodesInput = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	nodesMap = @(
		@{
			# OPTIONAL
			key = $someString
			# REQUIRED
			value = @{
				# OPTIONAL
				dataIpConfig = @{
					# OPTIONAL
					vlan = $someInt
					# REQUIRED
					address = $someString
					# REQUIRED
					gateway = $someString
					# REQUIRED
					netmask = $someString
				}
				# REQUIRED
				ipmiIpConfig = @{
					# OPTIONAL
					vlan = $someInt
					# REQUIRED
					address = $someString
					# REQUIRED
					gateway = $someString
					# REQUIRED
					netmask = $someString
				}
				# REQUIRED
				managementIpConfig = @{
					# OPTIONAL
					vlan = $someInt
					# REQUIRED
					address = $someString
					# REQUIRED
					gateway = $someString
					# REQUIRED
					netmask = $someString
				}
				# OPTIONAL
				vlanIpConfigs = @(
					@{
						# REQUIRED
						ip = $someString
						# REQUIRED
						vlan = $someInt
					}
				)
				# OPTIONAL
				chassisId = $someString
			}
		}
	)
	# REQUIRED
	request = @{
		# OPTIONAL
		encryptionPassword = $someString
		# OPTIONAL
		isIpv4ManualDiscoveryMode = $someBoolean
		# OPTIONAL
		isLinkLocalIpv4Mode = $someBoolean
		# REQUIRED
		ipmiPassword = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // addClusterRoute(input: AddClusterRouteInput!): AddClusterRouteReply!
        internal void InitMutationAddClusterRoute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddClusterRouteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddClusterRoute",
                "($input: AddClusterRouteInput!)",
                "AddClusterRouteReply",
                Mutation.AddClusterRoute,
                Mutation.AddClusterRouteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	routeConfig = @{
		# REQUIRED
		device = $someString
		# REQUIRED
		gateway = $someString
		# REQUIRED
		netmask = $someString
		# REQUIRED
		network = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // addNodesToCloudCluster(input: AddNodesToCloudClusterInput!): CcProvisionJobReply!
        internal void InitMutationAddNodesToCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddNodesToCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddNodesToCloudCluster",
                "($input: AddNodesToCloudClusterInput!)",
                "CcProvisionJobReply",
                Mutation.AddNodesToCloudCluster,
                Mutation.AddNodesToCloudClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	numberOfNodes = $someInt
	# OPTIONAL
	awsImageId = $someString
	# OPTIONAL
	azureImageName = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	vendor = $someCcpVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	shouldKeepResourcesOnFailure = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteClusterRoute(input: DeleteClusterRouteInput!): Void
        internal void InitMutationDeleteClusterRoute()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteClusterRouteInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteClusterRoute",
                "($input: DeleteClusterRouteInput!)",
                "System.String",
                Mutation.DeleteClusterRoute,
                Mutation.DeleteClusterRouteFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	routeConfig = @{
		# REQUIRED
		netmask = $someString
		# REQUIRED
		network = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteTerminatedClusterOperationJobData(input: DeleteTerminatedClusterOperationJobDataInput!): DeleteTerminatedClusterOperationJobDataReply!
        internal void InitMutationDeleteTerminatedClusterOperationJobData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteTerminatedClusterOperationJobDataInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteTerminatedClusterOperationJobData",
                "($input: DeleteTerminatedClusterOperationJobDataInput!)",
                "DeleteTerminatedClusterOperationJobDataReply",
                Mutation.DeleteTerminatedClusterOperationJobData,
                Mutation.DeleteTerminatedClusterOperationJobDataFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	jobType = $someCcpJobType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // disconnectExocomputeCluster(input: DisconnectExocomputeClusterInput!): Void
        internal void InitMutationDisconnectExocomputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DisconnectExocomputeClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDisconnectExocomputeCluster",
                "($input: DisconnectExocomputeClusterInput!)",
                "System.String",
                Mutation.DisconnectExocomputeCluster,
                Mutation.DisconnectExocomputeClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterId = $someString
	# REQUIRED
	cloudType = $someCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // exocomputeClusterConnect(input: ExocomputeClusterConnectInput!): ExocomputeClusterConnectReply!
        internal void InitMutationExocomputeClusterConnect()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExocomputeClusterConnectInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExocomputeClusterConnect",
                "($input: ExocomputeClusterConnectInput!)",
                "ExocomputeClusterConnectReply",
                Mutation.ExocomputeClusterConnect,
                Mutation.ExocomputeClusterConnectFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterName = $someString
	# REQUIRED
	exocomputeConfigId = $someString
	# REQUIRED
	cloudType = $someCloudType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // generateClusterRegistrationToken(input: GenerateClusterRegistrationTokenInput): ClusterRegistrationToken!
        internal void InitMutationGenerateClusterRegistrationToken()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GenerateClusterRegistrationTokenInput"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGenerateClusterRegistrationToken",
                "($input: GenerateClusterRegistrationTokenInput)",
                "ClusterRegistrationToken",
                Mutation.GenerateClusterRegistrationToken,
                Mutation.GenerateClusterRegistrationTokenFieldSpec,
                @"# OPTIONAL
$query.Var.input = @{
	# OPTIONAL
	managedByPolaris = $someBoolean
	# OPTIONAL
	nodeConfigs = @(
		@{
			# OPTIONAL
			id = $someString
			# OPTIONAL
			manufactureTime = $someDateTime
			# OPTIONAL
			serial = $someString
			# OPTIONAL
			systemUuid = $someString
			# OPTIONAL
			teleportToken = $someString
			# OPTIONAL
			clusterUuid = $someString
			# OPTIONAL
			platform = $someString
			# OPTIONAL
			capacity = $someString
			# OPTIONAL
			isEntitled = $someBoolean
		}
	)
	# OPTIONAL
	isOfflineRegistration = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // migrateCloudClusterDisks(input: MigrateCloudClusterDisksInput!): CcProvisionJobReply!
        internal void InitMutationMigrateCloudClusterDisks()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MigrateCloudClusterDisksInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMigrateCloudClusterDisks",
                "($input: MigrateCloudClusterDisksInput!)",
                "CcProvisionJobReply",
                Mutation.MigrateCloudClusterDisks,
                Mutation.MigrateCloudClusterDisksFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	vendor = $someCcpVendorType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	batchSize = $someInt
	# OPTIONAL
	newNodeCount = $someInt
	# OPTIONAL
	migrateToExtraDense = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverCloudCluster(input: RecoverCloudClusterInput!): CcProvisionJobReply!
        internal void InitMutationRecoverCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverCloudCluster",
                "($input: RecoverCloudClusterInput!)",
                "CcProvisionJobReply",
                Mutation.RecoverCloudCluster,
                Mutation.RecoverCloudClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	adminPassword = $someString
	# OPTIONAL
	userEmail = $someString
	# REQUIRED
	cloudAccountId = $someString
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	azureEsResourceGroup = $someString
	# OPTIONAL
	azureVmConfig = @{
		# OPTIONAL
		resourceGroup = $someString
		# OPTIONAL
		cdmVersion = $someString
		# OPTIONAL
		location = $someString
		# OPTIONAL
		nodeSizeGb = $someInt
		# OPTIONAL
		networkResourceGroup = $someString
		# OPTIONAL
		vnetResourceGroup = $someString
		# OPTIONAL
		networkSecurityGroup = $someString
		# OPTIONAL
		networkSecurityResourceGroup = $someString
		# OPTIONAL
		vnet = $someString
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		tags = $someString
		# OPTIONAL
		vmImage = $someString
		# OPTIONAL
		cdmProduct = $someString
		# OPTIONAL
		availabilityZone = $someString
		# OPTIONAL
		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = $someAzureInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
	# OPTIONAL
	awsVmConfig = @{
		# OPTIONAL
		cdmVersion = $someString
		# OPTIONAL
		nodeSizeGb = $someInt
		# OPTIONAL
		subnet = $someString
		# OPTIONAL
		tags = $someString
		# OPTIONAL
		imageId = $someString
		# OPTIONAL
		instanceProfileName = $someString
		# OPTIONAL
		cdmProduct = $someString
		# OPTIONAL
		placementGroupName = $someString
		# OPTIONAL
		vmType = $someVmType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			$someString
		)
		# OPTIONAL
		instanceType = $someAwsInstanceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
		# OPTIONAL
		networkConfig = @(
			@{
				# OPTIONAL
				availabilityZone = $someString
				# OPTIONAL
				subnet = $someString
			}
		)
	}
	# OPTIONAL
	awsRegion = $someString
	# REQUIRED
	shouldDisableAwsApiTermination = $someBoolean
	# REQUIRED
	shouldKeepClusterOnFailure = $someBoolean
	# OPTIONAL
	ntpServers = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // registerCloudCluster(input: RegisterCloudClusterInput!): RegisterCloudClusterReply!
        internal void InitMutationRegisterCloudCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RegisterCloudClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRegisterCloudCluster",
                "($input: RegisterCloudClusterInput!)",
                "RegisterCloudClusterReply",
                Mutation.RegisterCloudCluster,
                Mutation.RegisterCloudClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // releasePersistentExoclusters(input: ReleasePersistentExoclustersInput!): Void
        internal void InitMutationReleasePersistentExoclusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ReleasePersistentExoclustersInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationReleasePersistentExoclusters",
                "($input: ReleasePersistentExoclustersInput!)",
                "System.String",
                Mutation.ReleasePersistentExoclusters,
                Mutation.ReleasePersistentExoclustersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
	# REQUIRED
	exocomputeConfigId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // removeCdmCluster(clusterUUID: UUID!, isForce: Boolean!, expireInDays: Long): Boolean!
        internal void InitMutationRemoveCdmCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUUID", "UUID!"),
                Tuple.Create("isForce", "Boolean!"),
                Tuple.Create("expireInDays", "Long"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveCdmCluster",
                "($clusterUUID: UUID!,$isForce: Boolean!,$expireInDays: Long)",
                "System.Boolean",
                Mutation.RemoveCdmCluster,
                Mutation.RemoveCdmClusterFieldSpec,
                @"# REQUIRED
$query.Var.clusterUUID = $someString
# REQUIRED
$query.Var.isForce = $someBoolean
# OPTIONAL
$query.Var.expireInDays = $someInt64"
            );
        }

        // Create new GraphQL Mutation:
        // removeClusterNodes(input: RemoveClusterNodesInput!): CcProvisionJobReply!
        internal void InitMutationRemoveClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RemoveClusterNodesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRemoveClusterNodes",
                "($input: RemoveClusterNodesInput!)",
                "CcProvisionJobReply",
                Mutation.RemoveClusterNodes,
                Mutation.RemoveClusterNodesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	nodeIds = @(
		$someString
	)
	# OPTIONAL
	useQuickDrain = $someBoolean
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	nodeMetadata = @(
		@{
			# OPTIONAL
			nodeId = $someString
			# OPTIONAL
			chassisId = $someString
			# OPTIONAL
			platform = $someClusterNodePlatformType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodePlatformType]) for enum values.
			# OPTIONAL
			status = $someClusterNodeStatus # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterNodeStatus]) for enum values.
			# OPTIONAL
			useQuickDrain = $someBoolean
			# OPTIONAL
			resetAfterRemoveType = $someResetAfterRemoveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResetAfterRemoveType]) for enum values.
		}
	)
	# OPTIONAL
	resetAfterRemoveType = $someResetAfterRemoveType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ResetAfterRemoveType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // replaceClusterNode(input: ReplaceClusterNodeInput!): ReplaceClusterNodeReply!
        internal void InitMutationReplaceClusterNode()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ReplaceClusterNodeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationReplaceClusterNode",
                "($input: ReplaceClusterNodeInput!)",
                "ReplaceClusterNodeReply",
                Mutation.ReplaceClusterNode,
                Mutation.ReplaceClusterNodeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	newNodeId = $someString
	# OPTIONAL
	ipmiPassword = $someString
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // requestPersistentExocluster(input: RequestPersistentExoclusterInput!): RequestPersistentExoclusterReply!
        internal void InitMutationRequestPersistentExocluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RequestPersistentExoclusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRequestPersistentExocluster",
                "($input: RequestPersistentExoclusterInput!)",
                "RequestPersistentExoclusterReply",
                Mutation.RequestPersistentExocluster,
                Mutation.RequestPersistentExoclusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cloudVendor = $someCloudVendor # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
	# REQUIRED
	exocomputeConfigId = $someString
	# OPTIONAL
	durationInDays = $someInt
	# OPTIONAL
	azureSpecificClusterParams = @{
		# OPTIONAL
		nodeType = $someString
	}
	# OPTIONAL
	awsSpecificClusterParams = @{
		# OPTIONAL
		nodeKeypairName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // setMissingClusterStatus(input: SetMissingClusterStatusInput!): SetMissingClusterStatusReply!
        internal void InitMutationSetMissingClusterStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetMissingClusterStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetMissingClusterStatus",
                "($input: SetMissingClusterStatusInput!)",
                "SetMissingClusterStatusReply",
                Mutation.SetMissingClusterStatus,
                Mutation.SetMissingClusterStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	disconnectedState = $someMissingClusterDisconnectedState # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MissingClusterDisconnectedState]) for enum values.
	# OPTIONAL
	exclusionReason = $someString
	# REQUIRED
	uuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterDefaultAddress(input: UpdateClusterDefaultAddressInput!): UpdateClusterDefaultAddressReply!
        internal void InitMutationUpdateClusterDefaultAddress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterDefaultAddressInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterDefaultAddress",
                "($input: UpdateClusterDefaultAddressInput!)",
                "UpdateClusterDefaultAddressReply",
                Mutation.UpdateClusterDefaultAddress,
                Mutation.UpdateClusterDefaultAddressFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# OPTIONAL
	address = $someString
	# OPTIONAL
	port = $someInt
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterLocation(clusterUuid: UUID!, clusterLocation: ClusterLocationEdit!): Cluster!
        internal void InitMutationUpdateClusterLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("clusterLocation", "ClusterLocationEdit!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterLocation",
                "($clusterUuid: UUID!,$clusterLocation: ClusterLocationEdit!)",
                "Cluster",
                Mutation.UpdateClusterLocation,
                Mutation.UpdateClusterLocationFieldSpec,
                @"# REQUIRED
$query.Var.clusterUuid = $someString
# REQUIRED
$query.Var.clusterLocation = @{
	# REQUIRED
	address = $someString
	# REQUIRED
	latitude = $someSingle
	# REQUIRED
	longitude = $someSingle
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterNtpServers(input: UpdateClusterNtpServersInput!): ResponseSuccess!
        internal void InitMutationUpdateClusterNtpServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterNtpServersInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterNtpServers",
                "($input: UpdateClusterNtpServersInput!)",
                "ResponseSuccess",
                Mutation.UpdateClusterNtpServers,
                Mutation.UpdateClusterNtpServersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	ntpServerConfigs = @(
		@{
			# REQUIRED
			server = $someString
			# OPTIONAL
			symmetricKey = @{
				# REQUIRED
				key = $someString
				# REQUIRED
				keyId = $someInt
				# REQUIRED
				keyType = $someString
			}
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterPauseStatus(input: UpdateClusterPauseStatusInput!): UpdateClusterPauseStatusReply!
        internal void InitMutationUpdateClusterPauseStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterPauseStatusInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterPauseStatus",
                "($input: UpdateClusterPauseStatusInput!)",
                "UpdateClusterPauseStatusReply",
                Mutation.UpdateClusterPauseStatus,
                Mutation.UpdateClusterPauseStatusFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterUuids = @(
		$someString
	)
	# OPTIONAL
	togglePauseStatus = $someBoolean
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterSettings(input: UpdateClusterSettingsInput!): UpdateClusterSettingsReply!
        internal void InitMutationUpdateClusterSettings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterSettingsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterSettings",
                "($input: UpdateClusterSettingsInput!)",
                "UpdateClusterSettingsReply",
                Mutation.UpdateClusterSettings,
                Mutation.UpdateClusterSettingsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUpdate = @{
		# OPTIONAL
		acceptedEulaVersion = $someString
		# OPTIONAL
		geolocation = @{
			# REQUIRED
			address = $someString
		}
		# OPTIONAL
		name = $someString
		# OPTIONAL
		timezone = @{
			# REQUIRED
			timezone = $someClusterTimezoneType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTimezoneType]) for enum values.
		}
	}
	# REQUIRED
	id = $someString
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updatePreviewerClusterConfig(previewerClusterConfig: PreviewerClusterConfigInput!): Cluster!
        internal void InitMutationUpdatePreviewerClusterConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("previewerClusterConfig", "PreviewerClusterConfigInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdatePreviewerClusterConfig",
                "($previewerClusterConfig: PreviewerClusterConfigInput!)",
                "Cluster",
                Mutation.UpdatePreviewerClusterConfig,
                Mutation.UpdatePreviewerClusterConfigFieldSpec,
                @"# REQUIRED
$query.Var.previewerClusterConfig = @{
	# OPTIONAL
	clusterId = $someString
	# OPTIONAL
	enabled = $someBoolean
}"
            );
        }


    } // class New_RscMutationCluster
}