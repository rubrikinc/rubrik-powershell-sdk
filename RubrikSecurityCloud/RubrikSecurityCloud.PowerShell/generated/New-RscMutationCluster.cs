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
    /// Create a new RscQuery object for any of the 41
    /// operations in the 'Cluster' API domain:
    /// AddClusterNodes, AddClusterRoute, AddNodesToCloud, AddPostgreSqlDb, BulkRotateClusterEncryptionKey, CreateMultiClusterPc, DeleteClusterRoute, DeleteMultiClusterPc, DeletePostgreSqlDb, DeletePostgreSqlDbClusterLiveMount, DeleteTerminatedClusterOperationJobData, GenerateClusterRegistrationToken, PatchPostgreSqlDb, PauseClusterAlerts, PingMultiClusterPc, PitRestorePostgreSqlDb, RecoverCloud, RefreshMultiClusterPc, RefreshPostgreSqlDb, RegisterCloud, ReleasePersistentExo, RemoveCdm, RemoveClusterNodes, ReplaceClusterNode, RequestPersistentExo, ResetNewMigrationClustersInfo, RestorePostgreSqlDbClusterToSnapshot, SetMissingClusterStatus, SyncRotateClusterEncryptionKey, TakeOnDemandPostgreSqlDbClusterSnapshot, UnpauseClusterAlerts, UpdateClusterCapacityQuotasForOrg, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterPauseStatus, UpdateClusterRegisteredMode, UpdateClusterSettings, UpdateClusterThriftAuthToken, UpdateMultiClusterPc, or UpdatePreviewerClusterConfig.
    /// </summary>
    /// <description>
    /// New-RscMutationCluster creates a new
    /// mutation object for operations
    /// in the 'Cluster' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 41 operations
    /// in the 'Cluster' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddClusterNodes, AddClusterRoute, AddNodesToCloud, AddPostgreSqlDb, BulkRotateClusterEncryptionKey, CreateMultiClusterPc, DeleteClusterRoute, DeleteMultiClusterPc, DeletePostgreSqlDb, DeletePostgreSqlDbClusterLiveMount, DeleteTerminatedClusterOperationJobData, GenerateClusterRegistrationToken, PatchPostgreSqlDb, PauseClusterAlerts, PingMultiClusterPc, PitRestorePostgreSqlDb, RecoverCloud, RefreshMultiClusterPc, RefreshPostgreSqlDb, RegisterCloud, ReleasePersistentExo, RemoveCdm, RemoveClusterNodes, ReplaceClusterNode, RequestPersistentExo, ResetNewMigrationClustersInfo, RestorePostgreSqlDbClusterToSnapshot, SetMissingClusterStatus, SyncRotateClusterEncryptionKey, TakeOnDemandPostgreSqlDbClusterSnapshot, UnpauseClusterAlerts, UpdateClusterCapacityQuotasForOrg, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterPauseStatus, UpdateClusterRegisteredMode, UpdateClusterSettings, UpdateClusterThriftAuthToken, UpdateMultiClusterPc, or UpdatePreviewerClusterConfig.
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
    /// $query = New-RscMutationCluster -AddClusterNodes
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
    /// $query = New-RscMutationCluster -AddClusterRoute
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
    /// $query = New-RscMutationCluster -AddNodesToCloud
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
    /// Runs the AddPostgreSqlDb operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: AddPostgreSqlDb
    /// 
    /// $query = New-RscMutationCluster -AddPostgreSqlDb
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	postgresqlDbClusterConfig = @{
    /// 		# REQUIRED
    /// 		discoveryInfo = @{
    /// 			# REQUIRED
    /// 			entityInfo = @{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			hostInfo = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					portNumber = $someInt
    /// 					# REQUIRED
    /// 					hostId = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		loginInfo = @{
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		systemUsername = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddPostgreSqlDbClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BulkRotateClusterEncryptionKey operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: BulkRotateClusterEncryptionKey
    /// 
    /// $query = New-RscMutationCluster -BulkRotateClusterEncryptionKey
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	targetKeyType = $someClusterKeyProtection # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterKeyProtection]) for enum values.
    /// 	# REQUIRED
    /// 	clusters = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BulkRotateClusterEncryptionKeyReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateMultiClusterPc operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CreateMultiClusterPc
    /// 
    /// $query = New-RscMutationCluster -CreateMultiClusterPc
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	prismCentralConfig = @{
    /// 		# REQUIRED
    /// 		caCerts = $someString
    /// 		# REQUIRED
    /// 		hostname = $someString
    /// 		# REQUIRED
    /// 		password = $someString
    /// 		# REQUIRED
    /// 		username = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	prismElementCdmTuple = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			nutanixClusterId = $someString
    /// 			# REQUIRED
    /// 			cdmClusterId = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	isDrEnabled = $someBoolean
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
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
    /// $query = New-RscMutationCluster -DeleteClusterRoute
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
    /// Runs the DeleteMultiClusterPc operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DeleteMultiClusterPc
    /// 
    /// $query = New-RscMutationCluster -DeleteMultiClusterPc
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeletePostgreSqlDb operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DeletePostgreSqlDb
    /// 
    /// $query = New-RscMutationCluster -DeletePostgreSqlDb
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
    /// Runs the DeletePostgreSqlDbClusterLiveMount operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DeletePostgreSqlDbClusterLiveMount
    /// 
    /// $query = New-RscMutationCluster -DeletePostgreSqlDbClusterLiveMount
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
    /// $query = New-RscMutationCluster -DeleteTerminatedClusterOperationJobData
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
    /// $query = New-RscMutationCluster -GenerateClusterRegistrationToken
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
    /// Runs the PatchPostgreSqlDb operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: PatchPostgreSqlDb
    /// 
    /// $query = New-RscMutationCluster -PatchPostgreSqlDb
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	postgresqlDbClusterConfig = @{
    /// 		# REQUIRED
    /// 		discoveryInfo = @{
    /// 			# REQUIRED
    /// 			entityInfo = @{
    /// 				# REQUIRED
    /// 				name = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			hostInfo = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					portNumber = $someInt
    /// 					# REQUIRED
    /// 					hostId = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 		# OPTIONAL
    /// 		loginInfo = @{
    /// 			# REQUIRED
    /// 			password = $someString
    /// 			# REQUIRED
    /// 			username = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		systemUsername = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PatchPostgresDbClusterResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PauseClusterAlerts operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: PauseClusterAlerts
    /// 
    /// $query = New-RscMutationCluster -PauseClusterAlerts
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
    /// Runs the PingMultiClusterPc operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: PingMultiClusterPc
    /// 
    /// $query = New-RscMutationCluster -PingMultiClusterPc
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	cdmClusterId = $someString
    /// 	# OPTIONAL
    /// 	id = $someString
    /// 	# OPTIONAL
    /// 	username = $someString
    /// 	# OPTIONAL
    /// 	password = $someString
    /// 	# OPTIONAL
    /// 	hostname = $someString
    /// 	# OPTIONAL
    /// 	caCerts = $someString
    /// 	# REQUIRED
    /// 	nutanixClusters = @(
    /// 		$someString
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PingMultiClusterPcReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PitRestorePostgreSqlDb operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: PitRestorePostgreSqlDb
    /// 
    /// $query = New-RscMutationCluster -PitRestorePostgreSqlDb
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	postgresqlDbClusterPitRestoreConfig = @{
    /// 		# OPTIONAL
    /// 		nodeInfo = @{
    /// 			# OPTIONAL
    /// 			nodeHint = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			subnet = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		pitRestoreInfo = @{
    /// 			# OPTIONAL
    /// 			recoveryTime = $someDateTime
    /// 			# OPTIONAL
    /// 			extendedRecoveryTimeInSec = $someInt64
    /// 			# REQUIRED
    /// 			hostRecoveryTargets = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					hostMountPaths = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					hostId = $someString
    /// 				}
    /// 			)
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PitRestorePostgresDbClusterResponse
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
    /// $query = New-RscMutationCluster -RecoverCloud
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
    /// Runs the RefreshMultiClusterPc operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RefreshMultiClusterPc
    /// 
    /// $query = New-RscMutationCluster -RefreshMultiClusterPc
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
    /// Write-Host $result.GetType().Name # prints: BatchAsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RefreshPostgreSqlDb operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RefreshPostgreSqlDb
    /// 
    /// $query = New-RscMutationCluster -RefreshPostgreSqlDb
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
    /// $query = New-RscMutationCluster -RegisterCloud
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
    /// $query = New-RscMutationCluster -ReleasePersistentExo
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
    /// $query = New-RscMutationCluster -RemoveCdm
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
    /// $query = New-RscMutationCluster -RemoveClusterNodes
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
    /// 		}
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
    /// $query = New-RscMutationCluster -ReplaceClusterNode
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
    /// $query = New-RscMutationCluster -RequestPersistentExo
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
    /// Runs the ResetNewMigrationClustersInfo operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: ResetNewMigrationClustersInfo
    /// 
    /// $query = New-RscMutationCluster -ResetNewMigrationClustersInfo
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ResetNewMigrationClustersInfoReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RestorePostgreSqlDbClusterToSnapshot operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: RestorePostgreSqlDbClusterToSnapshot
    /// 
    /// $query = New-RscMutationCluster -RestorePostgreSqlDbClusterToSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	postgresqlDbClusterRestoreConfig = @{
    /// 		# OPTIONAL
    /// 		nodeInfo = @{
    /// 			# OPTIONAL
    /// 			nodeHint = @(
    /// 				$someString
    /// 			)
    /// 			# OPTIONAL
    /// 			subnet = $someString
    /// 		}
    /// 		# REQUIRED
    /// 		restoreInfo = @{
    /// 			# REQUIRED
    /// 			hostRecoveryTargets = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					hostMountPaths = @(
    /// 						$someString
    /// 					)
    /// 					# REQUIRED
    /// 					hostId = $someString
    /// 				}
    /// 			)
    /// 			# OPTIONAL
    /// 			logSnapshotTimeRange = @{
    /// 				# OPTIONAL
    /// 				startTime = $someDateTime
    /// 				# OPTIONAL
    /// 				endTime = $someDateTime
    /// 			}
    /// 			# REQUIRED
    /// 			snapshotId = $someString
    /// 		}
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: RestorePostgresDbClusterSnapshotResponse
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
    /// $query = New-RscMutationCluster -SetMissingClusterStatus
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
    /// Runs the SyncRotateClusterEncryptionKey operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: SyncRotateClusterEncryptionKey
    /// 
    /// $query = New-RscMutationCluster -SyncRotateClusterEncryptionKey
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	keyType = $someClusterKeyProtection # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterKeyProtection]) for enum values.
    /// 	# OPTIONAL
    /// 	currentEncryptionPassword = $someString
    /// 	# OPTIONAL
    /// 	newEncryptionPassword = $someString
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
    /// Runs the TakeOnDemandPostgreSqlDbClusterSnapshot operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: TakeOnDemandPostgreSqlDbClusterSnapshot
    /// 
    /// $query = New-RscMutationCluster -TakeOnDemandPostgreSqlDbClusterSnapshot
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		slaId = $someString
    /// 	}
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
    /// Runs the UnpauseClusterAlerts operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UnpauseClusterAlerts
    /// 
    /// $query = New-RscMutationCluster -UnpauseClusterAlerts
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
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
    /// Runs the UpdateClusterCapacityQuotasForOrg operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterCapacityQuotasForOrg
    /// 
    /// $query = New-RscMutationCluster -UpdateClusterCapacityQuotasForOrg
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	configs = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterId = $someString
    /// 			# REQUIRED
    /// 			hardLimitGb = $someInt64
    /// 			# REQUIRED
    /// 			softLimitGb = $someInt64
    /// 			# REQUIRED
    /// 			clusterCapacityQuotaType = $someClusterCapacityQuotaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCapacityQuotaType]) for enum values.
    /// 		}
    /// 	)
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
    /// $query = New-RscMutationCluster -UpdateClusterDefaultAddress
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
    /// $query = New-RscMutationCluster -UpdateClusterLocation
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
    /// $query = New-RscMutationCluster -UpdateClusterNtpServers
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
    /// $query = New-RscMutationCluster -UpdateClusterPauseStatus
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
    /// Runs the UpdateClusterRegisteredMode operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterRegisteredMode
    /// 
    /// $query = New-RscMutationCluster -UpdateClusterRegisteredMode
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	registeredMode = $someRegisteredMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RegisteredMode]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateClusterRegisteredModeReply
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
    /// $query = New-RscMutationCluster -UpdateClusterSettings
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
    /// Runs the UpdateClusterThriftAuthToken operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateClusterThriftAuthToken
    /// 
    /// $query = New-RscMutationCluster -UpdateClusterThriftAuthToken
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	sendToken = @{
    /// 		# REQUIRED
    /// 		tokenValue = $someString
    /// 	}
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
    /// Runs the UpdateMultiClusterPc operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateMultiClusterPc
    /// 
    /// $query = New-RscMutationCluster -UpdateMultiClusterPc
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	fid = $someString
    /// 	# OPTIONAL
    /// 	caCerts = $someString
    /// 	# OPTIONAL
    /// 	hostname = $someString
    /// 	# OPTIONAL
    /// 	password = $someString
    /// 	# OPTIONAL
    /// 	username = $someString
    /// 	# OPTIONAL
    /// 	isDrEnabled = $someBoolean
    /// 	# REQUIRED
    /// 	prismElementCdmTuple = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			nutanixClusterId = $someString
    /// 			# REQUIRED
    /// 			cdmClusterId = $someString
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateMultiClusterPcReply
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
    /// $query = New-RscMutationCluster -UpdatePreviewerClusterConfig
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
                "AddPostgreSqlDb",
                "BulkRotateClusterEncryptionKey",
                "CreateMultiClusterPc",
                "DeleteClusterRoute",
                "DeleteMultiClusterPc",
                "DeletePostgreSqlDb",
                "DeletePostgreSqlDbClusterLiveMount",
                "DeleteTerminatedClusterOperationJobData",
                "GenerateClusterRegistrationToken",
                "PatchPostgreSqlDb",
                "PauseClusterAlerts",
                "PingMultiClusterPc",
                "PitRestorePostgreSqlDb",
                "RecoverCloud",
                "RefreshMultiClusterPc",
                "RefreshPostgreSqlDb",
                "RegisterCloud",
                "ReleasePersistentExo",
                "RemoveCdm",
                "RemoveClusterNodes",
                "ReplaceClusterNode",
                "RequestPersistentExo",
                "ResetNewMigrationClustersInfo",
                "RestorePostgreSqlDbClusterToSnapshot",
                "SetMissingClusterStatus",
                "SyncRotateClusterEncryptionKey",
                "TakeOnDemandPostgreSqlDbClusterSnapshot",
                "UnpauseClusterAlerts",
                "UpdateClusterCapacityQuotasForOrg",
                "UpdateClusterDefaultAddress",
                "UpdateClusterLocation",
                "UpdateClusterNtpServers",
                "UpdateClusterPauseStatus",
                "UpdateClusterRegisteredMode",
                "UpdateClusterSettings",
                "UpdateClusterThriftAuthToken",
                "UpdateMultiClusterPc",
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
                    case "AddPostgreSqlDb":
                        this.ProcessRecord_AddPostgreSqlDb();
                        break;
                    case "BulkRotateClusterEncryptionKey":
                        this.ProcessRecord_BulkRotateClusterEncryptionKey();
                        break;
                    case "CreateMultiClusterPc":
                        this.ProcessRecord_CreateMultiClusterPc();
                        break;
                    case "DeleteClusterRoute":
                        this.ProcessRecord_DeleteClusterRoute();
                        break;
                    case "DeleteMultiClusterPc":
                        this.ProcessRecord_DeleteMultiClusterPc();
                        break;
                    case "DeletePostgreSqlDb":
                        this.ProcessRecord_DeletePostgreSqlDb();
                        break;
                    case "DeletePostgreSqlDbClusterLiveMount":
                        this.ProcessRecord_DeletePostgreSqlDbClusterLiveMount();
                        break;
                    case "DeleteTerminatedClusterOperationJobData":
                        this.ProcessRecord_DeleteTerminatedClusterOperationJobData();
                        break;
                    case "GenerateClusterRegistrationToken":
                        this.ProcessRecord_GenerateClusterRegistrationToken();
                        break;
                    case "PatchPostgreSqlDb":
                        this.ProcessRecord_PatchPostgreSqlDb();
                        break;
                    case "PauseClusterAlerts":
                        this.ProcessRecord_PauseClusterAlerts();
                        break;
                    case "PingMultiClusterPc":
                        this.ProcessRecord_PingMultiClusterPc();
                        break;
                    case "PitRestorePostgreSqlDb":
                        this.ProcessRecord_PitRestorePostgreSqlDb();
                        break;
                    case "RecoverCloud":
                        this.ProcessRecord_RecoverCloud();
                        break;
                    case "RefreshMultiClusterPc":
                        this.ProcessRecord_RefreshMultiClusterPc();
                        break;
                    case "RefreshPostgreSqlDb":
                        this.ProcessRecord_RefreshPostgreSqlDb();
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
                    case "ResetNewMigrationClustersInfo":
                        this.ProcessRecord_ResetNewMigrationClustersInfo();
                        break;
                    case "RestorePostgreSqlDbClusterToSnapshot":
                        this.ProcessRecord_RestorePostgreSqlDbClusterToSnapshot();
                        break;
                    case "SetMissingClusterStatus":
                        this.ProcessRecord_SetMissingClusterStatus();
                        break;
                    case "SyncRotateClusterEncryptionKey":
                        this.ProcessRecord_SyncRotateClusterEncryptionKey();
                        break;
                    case "TakeOnDemandPostgreSqlDbClusterSnapshot":
                        this.ProcessRecord_TakeOnDemandPostgreSqlDbClusterSnapshot();
                        break;
                    case "UnpauseClusterAlerts":
                        this.ProcessRecord_UnpauseClusterAlerts();
                        break;
                    case "UpdateClusterCapacityQuotasForOrg":
                        this.ProcessRecord_UpdateClusterCapacityQuotasForOrg();
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
                    case "UpdateClusterRegisteredMode":
                        this.ProcessRecord_UpdateClusterRegisteredMode();
                        break;
                    case "UpdateClusterSettings":
                        this.ProcessRecord_UpdateClusterSettings();
                        break;
                    case "UpdateClusterThriftAuthToken":
                        this.ProcessRecord_UpdateClusterThriftAuthToken();
                        break;
                    case "UpdateMultiClusterPc":
                        this.ProcessRecord_UpdateMultiClusterPc();
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
        // addPostgreSQLDbCluster.
        internal void ProcessRecord_AddPostgreSqlDb()
        {
            this._logger.name += " -AddPostgreSqlDb";
            // Create new graphql operation addPostgreSQLDbCluster
            InitMutationAddPostgreSqlDbCluster();
        }

        // This parameter set invokes a single graphql operation:
        // bulkRotateClusterEncryptionKey.
        internal void ProcessRecord_BulkRotateClusterEncryptionKey()
        {
            this._logger.name += " -BulkRotateClusterEncryptionKey";
            // Create new graphql operation bulkRotateClusterEncryptionKey
            InitMutationBulkRotateClusterEncryptionKey();
        }

        // This parameter set invokes a single graphql operation:
        // createMultiClusterPc.
        internal void ProcessRecord_CreateMultiClusterPc()
        {
            this._logger.name += " -CreateMultiClusterPc";
            // Create new graphql operation createMultiClusterPc
            InitMutationCreateMultiClusterPc();
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
        // deleteMultiClusterPc.
        internal void ProcessRecord_DeleteMultiClusterPc()
        {
            this._logger.name += " -DeleteMultiClusterPc";
            // Create new graphql operation deleteMultiClusterPc
            InitMutationDeleteMultiClusterPc();
        }

        // This parameter set invokes a single graphql operation:
        // deletePostgreSQLDbCluster.
        internal void ProcessRecord_DeletePostgreSqlDb()
        {
            this._logger.name += " -DeletePostgreSqlDb";
            // Create new graphql operation deletePostgreSQLDbCluster
            InitMutationDeletePostgreSqlDbCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deletePostgreSQLDbClusterLiveMount.
        internal void ProcessRecord_DeletePostgreSqlDbClusterLiveMount()
        {
            this._logger.name += " -DeletePostgreSqlDbClusterLiveMount";
            // Create new graphql operation deletePostgreSQLDbClusterLiveMount
            InitMutationDeletePostgreSqlDbClusterLiveMount();
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
        // generateClusterRegistrationToken.
        internal void ProcessRecord_GenerateClusterRegistrationToken()
        {
            this._logger.name += " -GenerateClusterRegistrationToken";
            // Create new graphql operation generateClusterRegistrationToken
            InitMutationGenerateClusterRegistrationToken();
        }

        // This parameter set invokes a single graphql operation:
        // patchPostgreSQLDbCluster.
        internal void ProcessRecord_PatchPostgreSqlDb()
        {
            this._logger.name += " -PatchPostgreSqlDb";
            // Create new graphql operation patchPostgreSQLDbCluster
            InitMutationPatchPostgreSqlDbCluster();
        }

        // This parameter set invokes a single graphql operation:
        // pauseClusterAlerts.
        internal void ProcessRecord_PauseClusterAlerts()
        {
            this._logger.name += " -PauseClusterAlerts";
            // Create new graphql operation pauseClusterAlerts
            InitMutationPauseClusterAlerts();
        }

        // This parameter set invokes a single graphql operation:
        // pingMultiClusterPc.
        internal void ProcessRecord_PingMultiClusterPc()
        {
            this._logger.name += " -PingMultiClusterPc";
            // Create new graphql operation pingMultiClusterPc
            InitMutationPingMultiClusterPc();
        }

        // This parameter set invokes a single graphql operation:
        // pitRestorePostgreSQLDbCluster.
        internal void ProcessRecord_PitRestorePostgreSqlDb()
        {
            this._logger.name += " -PitRestorePostgreSqlDb";
            // Create new graphql operation pitRestorePostgreSQLDbCluster
            InitMutationPitRestorePostgreSqlDbCluster();
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
        // refreshMultiClusterPc.
        internal void ProcessRecord_RefreshMultiClusterPc()
        {
            this._logger.name += " -RefreshMultiClusterPc";
            // Create new graphql operation refreshMultiClusterPc
            InitMutationRefreshMultiClusterPc();
        }

        // This parameter set invokes a single graphql operation:
        // refreshPostgreSQLDbCluster.
        internal void ProcessRecord_RefreshPostgreSqlDb()
        {
            this._logger.name += " -RefreshPostgreSqlDb";
            // Create new graphql operation refreshPostgreSQLDbCluster
            InitMutationRefreshPostgreSqlDbCluster();
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
        // resetNewMigrationClustersInfo.
        internal void ProcessRecord_ResetNewMigrationClustersInfo()
        {
            this._logger.name += " -ResetNewMigrationClustersInfo";
            // Create new graphql operation resetNewMigrationClustersInfo
            InitMutationResetNewMigrationClustersInfo();
        }

        // This parameter set invokes a single graphql operation:
        // restorePostgreSQLDbClusterToSnapshot.
        internal void ProcessRecord_RestorePostgreSqlDbClusterToSnapshot()
        {
            this._logger.name += " -RestorePostgreSqlDbClusterToSnapshot";
            // Create new graphql operation restorePostgreSQLDbClusterToSnapshot
            InitMutationRestorePostgreSqlDbClusterToSnapshot();
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
        // syncRotateClusterEncryptionKey.
        internal void ProcessRecord_SyncRotateClusterEncryptionKey()
        {
            this._logger.name += " -SyncRotateClusterEncryptionKey";
            // Create new graphql operation syncRotateClusterEncryptionKey
            InitMutationSyncRotateClusterEncryptionKey();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandPostgreSQLDbClusterSnapshot.
        internal void ProcessRecord_TakeOnDemandPostgreSqlDbClusterSnapshot()
        {
            this._logger.name += " -TakeOnDemandPostgreSqlDbClusterSnapshot";
            // Create new graphql operation takeOnDemandPostgreSQLDbClusterSnapshot
            InitMutationTakeOnDemandPostgreSqlDbClusterSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // unpauseClusterAlerts.
        internal void ProcessRecord_UnpauseClusterAlerts()
        {
            this._logger.name += " -UnpauseClusterAlerts";
            // Create new graphql operation unpauseClusterAlerts
            InitMutationUnpauseClusterAlerts();
        }

        // This parameter set invokes a single graphql operation:
        // updateClusterCapacityQuotasForOrg.
        internal void ProcessRecord_UpdateClusterCapacityQuotasForOrg()
        {
            this._logger.name += " -UpdateClusterCapacityQuotasForOrg";
            // Create new graphql operation updateClusterCapacityQuotasForOrg
            InitMutationUpdateClusterCapacityQuotasForOrg();
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
        // updateClusterRegisteredMode.
        internal void ProcessRecord_UpdateClusterRegisteredMode()
        {
            this._logger.name += " -UpdateClusterRegisteredMode";
            // Create new graphql operation updateClusterRegisteredMode
            InitMutationUpdateClusterRegisteredMode();
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
        // updateClusterThriftAuthToken.
        internal void ProcessRecord_UpdateClusterThriftAuthToken()
        {
            this._logger.name += " -UpdateClusterThriftAuthToken";
            // Create new graphql operation updateClusterThriftAuthToken
            InitMutationUpdateClusterThriftAuthToken();
        }

        // This parameter set invokes a single graphql operation:
        // updateMultiClusterPc.
        internal void ProcessRecord_UpdateMultiClusterPc()
        {
            this._logger.name += " -UpdateMultiClusterPc";
            // Create new graphql operation updateMultiClusterPc
            InitMutationUpdateMultiClusterPc();
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
        // addPostgreSQLDbCluster(input: AddPostgreSqlDbClusterInput!): AddPostgreSqlDbClusterReply!
        internal void InitMutationAddPostgreSqlDbCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddPostgreSqlDbClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddPostgreSqlDbCluster",
                "($input: AddPostgreSqlDbClusterInput!)",
                "AddPostgreSqlDbClusterReply",
                Mutation.AddPostgreSqlDbCluster,
                Mutation.AddPostgreSqlDbClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	postgresqlDbClusterConfig = @{
		# REQUIRED
		discoveryInfo = @{
			# REQUIRED
			entityInfo = @{
				# REQUIRED
				name = $someString
			}
			# REQUIRED
			hostInfo = @(
				@{
					# OPTIONAL
					portNumber = $someInt
					# REQUIRED
					hostId = $someString
				}
			)
		}
		# OPTIONAL
		loginInfo = @{
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
		# REQUIRED
		systemUsername = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkRotateClusterEncryptionKey(input: BulkRotateClusterEncryptionKeyInput!): BulkRotateClusterEncryptionKeyReply!
        internal void InitMutationBulkRotateClusterEncryptionKey()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkRotateClusterEncryptionKeyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkRotateClusterEncryptionKey",
                "($input: BulkRotateClusterEncryptionKeyInput!)",
                "BulkRotateClusterEncryptionKeyReply",
                Mutation.BulkRotateClusterEncryptionKey,
                Mutation.BulkRotateClusterEncryptionKeyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	targetKeyType = $someClusterKeyProtection # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterKeyProtection]) for enum values.
	# REQUIRED
	clusters = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createMultiClusterPc(input: CreateMultiClusterPcInput!): BatchAsyncRequestStatus!
        internal void InitMutationCreateMultiClusterPc()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateMultiClusterPcInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMultiClusterPc",
                "($input: CreateMultiClusterPcInput!)",
                "BatchAsyncRequestStatus",
                Mutation.CreateMultiClusterPc,
                Mutation.CreateMultiClusterPcFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	prismCentralConfig = @{
		# REQUIRED
		caCerts = $someString
		# REQUIRED
		hostname = $someString
		# REQUIRED
		password = $someString
		# REQUIRED
		username = $someString
	}
	# REQUIRED
	prismElementCdmTuple = @(
		@{
			# REQUIRED
			nutanixClusterId = $someString
			# REQUIRED
			cdmClusterId = $someString
		}
	)
	# OPTIONAL
	isDrEnabled = $someBoolean
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
        // deleteMultiClusterPc(input: DeleteMultiClusterPcInput!): BatchAsyncRequestStatus!
        internal void InitMutationDeleteMultiClusterPc()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMultiClusterPcInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMultiClusterPc",
                "($input: DeleteMultiClusterPcInput!)",
                "BatchAsyncRequestStatus",
                Mutation.DeleteMultiClusterPc,
                Mutation.DeleteMultiClusterPcFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deletePostgreSQLDbCluster(input: DeletePostgresDbClusterInput!): AsyncRequestStatus!
        internal void InitMutationDeletePostgreSqlDbCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeletePostgresDbClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeletePostgreSqlDbCluster",
                "($input: DeletePostgresDbClusterInput!)",
                "AsyncRequestStatus",
                Mutation.DeletePostgreSqlDbCluster,
                Mutation.DeletePostgreSqlDbClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deletePostgreSQLDbClusterLiveMount(input: DeletePostgresDbClusterLiveMountInput!): AsyncRequestStatus!
        internal void InitMutationDeletePostgreSqlDbClusterLiveMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeletePostgresDbClusterLiveMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeletePostgreSqlDbClusterLiveMount",
                "($input: DeletePostgresDbClusterLiveMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeletePostgreSqlDbClusterLiveMount,
                Mutation.DeletePostgreSqlDbClusterLiveMountFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
        // patchPostgreSQLDbCluster(input: PatchPostgresDbClusterInput!): PatchPostgresDbClusterResponse!
        internal void InitMutationPatchPostgreSqlDbCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchPostgresDbClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchPostgreSqlDbCluster",
                "($input: PatchPostgresDbClusterInput!)",
                "PatchPostgresDbClusterResponse",
                Mutation.PatchPostgreSqlDbCluster,
                Mutation.PatchPostgreSqlDbClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	postgresqlDbClusterConfig = @{
		# REQUIRED
		discoveryInfo = @{
			# REQUIRED
			entityInfo = @{
				# REQUIRED
				name = $someString
			}
			# REQUIRED
			hostInfo = @(
				@{
					# OPTIONAL
					portNumber = $someInt
					# REQUIRED
					hostId = $someString
				}
			)
		}
		# OPTIONAL
		loginInfo = @{
			# REQUIRED
			password = $someString
			# REQUIRED
			username = $someString
		}
		# REQUIRED
		systemUsername = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // pauseClusterAlerts(input: PauseClusterAlertsInput!): Void
        internal void InitMutationPauseClusterAlerts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseClusterAlertsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPauseClusterAlerts",
                "($input: PauseClusterAlertsInput!)",
                "System.String",
                Mutation.PauseClusterAlerts,
                Mutation.PauseClusterAlertsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // pingMultiClusterPc(input: PingMultiClusterPcInput!): PingMultiClusterPcReply!
        internal void InitMutationPingMultiClusterPc()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PingMultiClusterPcInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPingMultiClusterPc",
                "($input: PingMultiClusterPcInput!)",
                "PingMultiClusterPcReply",
                Mutation.PingMultiClusterPc,
                Mutation.PingMultiClusterPcFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	cdmClusterId = $someString
	# OPTIONAL
	id = $someString
	# OPTIONAL
	username = $someString
	# OPTIONAL
	password = $someString
	# OPTIONAL
	hostname = $someString
	# OPTIONAL
	caCerts = $someString
	# REQUIRED
	nutanixClusters = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // pitRestorePostgreSQLDbCluster(input: PitRestorePostgresDbClusterInput!): PitRestorePostgresDbClusterResponse!
        internal void InitMutationPitRestorePostgreSqlDbCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PitRestorePostgresDbClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPitRestorePostgreSqlDbCluster",
                "($input: PitRestorePostgresDbClusterInput!)",
                "PitRestorePostgresDbClusterResponse",
                Mutation.PitRestorePostgreSqlDbCluster,
                Mutation.PitRestorePostgreSqlDbClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	postgresqlDbClusterPitRestoreConfig = @{
		# OPTIONAL
		nodeInfo = @{
			# OPTIONAL
			nodeHint = @(
				$someString
			)
			# OPTIONAL
			subnet = $someString
		}
		# REQUIRED
		pitRestoreInfo = @{
			# OPTIONAL
			recoveryTime = $someDateTime
			# OPTIONAL
			extendedRecoveryTimeInSec = $someInt64
			# REQUIRED
			hostRecoveryTargets = @(
				@{
					# OPTIONAL
					hostMountPaths = @(
						$someString
					)
					# REQUIRED
					hostId = $someString
				}
			)
		}
	}
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
        // refreshMultiClusterPc(input: RefreshMultiClusterPcInput!): BatchAsyncRequestStatus!
        internal void InitMutationRefreshMultiClusterPc()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshMultiClusterPcInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshMultiClusterPc",
                "($input: RefreshMultiClusterPcInput!)",
                "BatchAsyncRequestStatus",
                Mutation.RefreshMultiClusterPc,
                Mutation.RefreshMultiClusterPcFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshPostgreSQLDbCluster(input: RefreshPostgresDbClusterInput!): AsyncRequestStatus!
        internal void InitMutationRefreshPostgreSqlDbCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshPostgresDbClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshPostgreSqlDbCluster",
                "($input: RefreshPostgresDbClusterInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshPostgreSqlDbCluster,
                Mutation.RefreshPostgreSqlDbClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
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
		}
	)
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
        // resetNewMigrationClustersInfo: ResetNewMigrationClustersInfoReply!
        internal void InitMutationResetNewMigrationClustersInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationResetNewMigrationClustersInfo",
                "",
                "ResetNewMigrationClustersInfoReply",
                Mutation.ResetNewMigrationClustersInfo,
                Mutation.ResetNewMigrationClustersInfoFieldSpec,
                @""
            );
        }

        // Create new GraphQL Mutation:
        // restorePostgreSQLDbClusterToSnapshot(input: RestorePostgresDbClusterSnapshotInput!): RestorePostgresDbClusterSnapshotResponse!
        internal void InitMutationRestorePostgreSqlDbClusterToSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestorePostgresDbClusterSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestorePostgreSqlDbClusterToSnapshot",
                "($input: RestorePostgresDbClusterSnapshotInput!)",
                "RestorePostgresDbClusterSnapshotResponse",
                Mutation.RestorePostgreSqlDbClusterToSnapshot,
                Mutation.RestorePostgreSqlDbClusterToSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	postgresqlDbClusterRestoreConfig = @{
		# OPTIONAL
		nodeInfo = @{
			# OPTIONAL
			nodeHint = @(
				$someString
			)
			# OPTIONAL
			subnet = $someString
		}
		# REQUIRED
		restoreInfo = @{
			# REQUIRED
			hostRecoveryTargets = @(
				@{
					# OPTIONAL
					hostMountPaths = @(
						$someString
					)
					# REQUIRED
					hostId = $someString
				}
			)
			# OPTIONAL
			logSnapshotTimeRange = @{
				# OPTIONAL
				startTime = $someDateTime
				# OPTIONAL
				endTime = $someDateTime
			}
			# REQUIRED
			snapshotId = $someString
		}
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
        // syncRotateClusterEncryptionKey(input: SyncRotateClusterEncryptionKeyInput!): String!
        internal void InitMutationSyncRotateClusterEncryptionKey()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SyncRotateClusterEncryptionKeyInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSyncRotateClusterEncryptionKey",
                "($input: SyncRotateClusterEncryptionKeyInput!)",
                "System.String",
                Mutation.SyncRotateClusterEncryptionKey,
                Mutation.SyncRotateClusterEncryptionKeyFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	keyType = $someClusterKeyProtection # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterKeyProtection]) for enum values.
	# OPTIONAL
	currentEncryptionPassword = $someString
	# OPTIONAL
	newEncryptionPassword = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeOnDemandPostgreSQLDbClusterSnapshot(input: TakeOnDemandPostgreSQLDbClusterSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationTakeOnDemandPostgreSqlDbClusterSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandPostgreSQLDbClusterSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandPostgreSqlDbClusterSnapshot",
                "($input: TakeOnDemandPostgreSQLDbClusterSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeOnDemandPostgreSqlDbClusterSnapshot,
                Mutation.TakeOnDemandPostgreSqlDbClusterSnapshotFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // unpauseClusterAlerts(input: UnpauseClusterAlertsInput!): Void
        internal void InitMutationUnpauseClusterAlerts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnpauseClusterAlertsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUnpauseClusterAlerts",
                "($input: UnpauseClusterAlertsInput!)",
                "System.String",
                Mutation.UnpauseClusterAlerts,
                Mutation.UnpauseClusterAlertsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateClusterCapacityQuotasForOrg(input: UpdateClusterCapacityQuotasForOrgInput!): Void
        internal void InitMutationUpdateClusterCapacityQuotasForOrg()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterCapacityQuotasForOrgInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterCapacityQuotasForOrg",
                "($input: UpdateClusterCapacityQuotasForOrgInput!)",
                "System.String",
                Mutation.UpdateClusterCapacityQuotasForOrg,
                Mutation.UpdateClusterCapacityQuotasForOrgFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			clusterId = $someString
			# REQUIRED
			hardLimitGb = $someInt64
			# REQUIRED
			softLimitGb = $someInt64
			# REQUIRED
			clusterCapacityQuotaType = $someClusterCapacityQuotaType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterCapacityQuotaType]) for enum values.
		}
	)
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
        // updateClusterRegisteredMode(input: UpdateClusterRegisteredModeInput!): UpdateClusterRegisteredModeReply!
        internal void InitMutationUpdateClusterRegisteredMode()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterRegisteredModeInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterRegisteredMode",
                "($input: UpdateClusterRegisteredModeInput!)",
                "UpdateClusterRegisteredModeReply",
                Mutation.UpdateClusterRegisteredMode,
                Mutation.UpdateClusterRegisteredModeFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	registeredMode = $someRegisteredMode # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RegisteredMode]) for enum values.
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
        // updateClusterThriftAuthToken(input: UpdateClusterThriftAuthTokenInput!): ResponseSuccess!
        internal void InitMutationUpdateClusterThriftAuthToken()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateClusterThriftAuthTokenInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateClusterThriftAuthToken",
                "($input: UpdateClusterThriftAuthTokenInput!)",
                "ResponseSuccess",
                Mutation.UpdateClusterThriftAuthToken,
                Mutation.UpdateClusterThriftAuthTokenFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	id = $someString
	# REQUIRED
	sendToken = @{
		# REQUIRED
		tokenValue = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMultiClusterPc(input: UpdateMultiClusterPcInput!): UpdateMultiClusterPcReply!
        internal void InitMutationUpdateMultiClusterPc()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateMultiClusterPcInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMultiClusterPc",
                "($input: UpdateMultiClusterPcInput!)",
                "UpdateMultiClusterPcReply",
                Mutation.UpdateMultiClusterPc,
                Mutation.UpdateMultiClusterPcFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	fid = $someString
	# OPTIONAL
	caCerts = $someString
	# OPTIONAL
	hostname = $someString
	# OPTIONAL
	password = $someString
	# OPTIONAL
	username = $someString
	# OPTIONAL
	isDrEnabled = $someBoolean
	# REQUIRED
	prismElementCdmTuple = @(
		@{
			# REQUIRED
			nutanixClusterId = $someString
			# REQUIRED
			cdmClusterId = $someString
		}
	)
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