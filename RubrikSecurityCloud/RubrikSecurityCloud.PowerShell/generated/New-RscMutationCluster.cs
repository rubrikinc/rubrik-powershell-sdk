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
    /// Create a new RscQuery object for any of the 12
    /// operations in the 'Cluster' API domain:
    /// AddClusterNodes, AddNodesToCloud, GenerateClusterRegistrationToken, RecoverCloud, RegisterCloud, RemoveCdm, RemoveClusterNodes, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterSettings, or UpdatePreviewerClusterConfig.
    /// </summary>
    /// <description>
    /// New-RscMutationCluster creates a new
    /// mutation object for operations
    /// in the 'Cluster' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 12 operations
    /// in the 'Cluster' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddClusterNodes, AddNodesToCloud, GenerateClusterRegistrationToken, RecoverCloud, RegisterCloud, RemoveCdm, RemoveClusterNodes, UpdateClusterDefaultAddress, UpdateClusterLocation, UpdateClusterNtpServers, UpdateClusterSettings, or UpdatePreviewerClusterConfig.
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
    /// 			# OPTIONAL
    /// 			symmetricKey = @{
    /// 				# REQUIRED
    /// 				key = $someString
    /// 				# REQUIRED
    /// 				keyId = $someInt
    /// 				# REQUIRED
    /// 				keyType = $someString
    /// 			}
    /// 			# REQUIRED
    /// 			server = $someString
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
                "AddNodesToCloud",
                "GenerateClusterRegistrationToken",
                "RecoverCloud",
                "RegisterCloud",
                "RemoveCdm",
                "RemoveClusterNodes",
                "UpdateClusterDefaultAddress",
                "UpdateClusterLocation",
                "UpdateClusterNtpServers",
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
                    case "AddNodesToCloud":
                        this.ProcessRecord_AddNodesToCloud();
                        break;
                    case "GenerateClusterRegistrationToken":
                        this.ProcessRecord_GenerateClusterRegistrationToken();
                        break;
                    case "RecoverCloud":
                        this.ProcessRecord_RecoverCloud();
                        break;
                    case "RegisterCloud":
                        this.ProcessRecord_RegisterCloud();
                        break;
                    case "RemoveCdm":
                        this.ProcessRecord_RemoveCdm();
                        break;
                    case "RemoveClusterNodes":
                        this.ProcessRecord_RemoveClusterNodes();
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
        // addNodesToCloudCluster.
        internal void ProcessRecord_AddNodesToCloud()
        {
            this._logger.name += " -AddNodesToCloud";
            // Create new graphql operation addNodesToCloudCluster
            InitMutationAddNodesToCloudCluster();
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
                Mutation.AddClusterNodes_ObjectFieldSpec,
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
                Mutation.AddNodesToCloudCluster_ObjectFieldSpec,
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
                Mutation.GenerateClusterRegistrationToken_ObjectFieldSpec,
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
                Mutation.RecoverCloudCluster_ObjectFieldSpec,
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
                Mutation.RegisterCloudCluster_ObjectFieldSpec,
                Mutation.RegisterCloudClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	clusterUuid = $someString
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
                Mutation.RemoveCdmCluster_ObjectFieldSpec,
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
                Mutation.RemoveClusterNodes_ObjectFieldSpec,
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
                Mutation.UpdateClusterDefaultAddress_ObjectFieldSpec,
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
                Mutation.UpdateClusterLocation_ObjectFieldSpec,
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
                Mutation.UpdateClusterNtpServers_ObjectFieldSpec,
                Mutation.UpdateClusterNtpServersFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	ntpServerConfigs = @(
		@{
			# OPTIONAL
			symmetricKey = @{
				# REQUIRED
				key = $someString
				# REQUIRED
				keyId = $someInt
				# REQUIRED
				keyType = $someString
			}
			# REQUIRED
			server = $someString
		}
	)
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
                Mutation.UpdateClusterSettings_ObjectFieldSpec,
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
                Mutation.UpdatePreviewerClusterConfig_ObjectFieldSpec,
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