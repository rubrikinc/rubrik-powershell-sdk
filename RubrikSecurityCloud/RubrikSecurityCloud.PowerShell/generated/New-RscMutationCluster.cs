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
    /// Create a new RscQuery object for any of the 9
    /// operations in the 'Cluster' API domain:
    /// AddNodesToCloud, BulkDeleteFailover, CreateFailover, DeleteFailover, RecoverCloud, RegisterCloud, RemoveCdm, UpdateDatabaseLogReportingProperties, or UpdateFailover.
    /// </summary>
    /// <description>
    /// New-RscMutationCluster creates a new
    /// mutation object for operations
    /// in the 'Cluster' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 9 operations
    /// in the 'Cluster' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddNodesToCloud, BulkDeleteFailover, CreateFailover, DeleteFailover, RecoverCloud, RegisterCloud, RemoveCdm, UpdateDatabaseLogReportingProperties, or UpdateFailover.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCluster -AddNodesToCloud).Info().
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
    /// (New-RscMutationCluster -AddNodesToCloud).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
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
    /// 	shouldKeepResourcesOnFailure = $someBoolean
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
    /// Runs the BulkDeleteFailover operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: BulkDeleteFailover
    /// 
    /// $query = New-RscMutationCluster -BulkDeleteFailover
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	ids = @(
    /// 		$someString
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
    /// Runs the CreateFailover operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: CreateFailover
    /// 
    /// $query = New-RscMutationCluster -CreateFailover
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CreateFailoverClusterReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteFailover operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: DeleteFailover
    /// 
    /// $query = New-RscMutationCluster -DeleteFailover
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	preserveSnapshots = $someBoolean
    /// 	# REQUIRED
    /// 	id = $someString
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
    /// Runs the UpdateDatabaseLogReportingProperties operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateDatabaseLogReportingProperties
    /// 
    /// $query = New-RscMutationCluster -UpdateDatabaseLogReportingProperties
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	properties = @{
    /// 		# OPTIONAL
    /// 		enableDelayNotification = $someBoolean
    /// 		# OPTIONAL
    /// 		logDelayThresholdInMin = $someInt64
    /// 		# OPTIONAL
    /// 		logDelayNotificationFrequencyInMin = $someInt64
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DbLogReportProperties
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateFailover operation
    /// of the 'Cluster' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Cluster
    /// # API Operation: UpdateFailover
    /// 
    /// $query = New-RscMutationCluster -UpdateFailover
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	updateProperties = @{
    /// 		# OPTIONAL
    /// 		configuredSlaDomainId = $someString
    /// 		# REQUIRED
    /// 		hostIds = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		name = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateFailoverClusterReply
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
                "AddNodesToCloud",
                "BulkDeleteFailover",
                "CreateFailover",
                "DeleteFailover",
                "RecoverCloud",
                "RegisterCloud",
                "RemoveCdm",
                "UpdateDatabaseLogReportingProperties",
                "UpdateFailover",
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
                    case "AddNodesToCloud":
                        this.ProcessRecord_AddNodesToCloud();
                        break;
                    case "BulkDeleteFailover":
                        this.ProcessRecord_BulkDeleteFailover();
                        break;
                    case "CreateFailover":
                        this.ProcessRecord_CreateFailover();
                        break;
                    case "DeleteFailover":
                        this.ProcessRecord_DeleteFailover();
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
                    case "UpdateDatabaseLogReportingProperties":
                        this.ProcessRecord_UpdateDatabaseLogReportingProperties();
                        break;
                    case "UpdateFailover":
                        this.ProcessRecord_UpdateFailover();
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
        // addNodesToCloudCluster.
        internal void ProcessRecord_AddNodesToCloud()
        {
            this._logger.name += " -AddNodesToCloud";
            // Create new graphql operation addNodesToCloudCluster
            InitMutationAddNodesToCloudCluster();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteFailoverCluster.
        internal void ProcessRecord_BulkDeleteFailover()
        {
            this._logger.name += " -BulkDeleteFailover";
            // Create new graphql operation bulkDeleteFailoverCluster
            InitMutationBulkDeleteFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // createFailoverCluster.
        internal void ProcessRecord_CreateFailover()
        {
            this._logger.name += " -CreateFailover";
            // Create new graphql operation createFailoverCluster
            InitMutationCreateFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteFailoverCluster.
        internal void ProcessRecord_DeleteFailover()
        {
            this._logger.name += " -DeleteFailover";
            // Create new graphql operation deleteFailoverCluster
            InitMutationDeleteFailoverCluster();
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
        // updateDatabaseLogReportingPropertiesForCluster.
        internal void ProcessRecord_UpdateDatabaseLogReportingProperties()
        {
            this._logger.name += " -UpdateDatabaseLogReportingProperties";
            // Create new graphql operation updateDatabaseLogReportingPropertiesForCluster
            InitMutationUpdateDatabaseLogReportingPropertiesForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // updateFailoverCluster.
        internal void ProcessRecord_UpdateFailover()
        {
            this._logger.name += " -UpdateFailover";
            // Create new graphql operation updateFailoverCluster
            InitMutationUpdateFailoverCluster();
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
	shouldKeepResourcesOnFailure = $someBoolean
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
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteFailoverCluster(input: BulkDeleteFailoverClusterInput!): ResponseSuccess!
        internal void InitMutationBulkDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteFailoverCluster",
                "($input: BulkDeleteFailoverClusterInput!)",
                "ResponseSuccess",
                Mutation.BulkDeleteFailoverCluster_ObjectFieldSpec,
                Mutation.BulkDeleteFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	ids = @(
		$someString
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createFailoverCluster(input: CreateFailoverClusterInput!): CreateFailoverClusterReply!
        internal void InitMutationCreateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateFailoverCluster",
                "($input: CreateFailoverClusterInput!)",
                "CreateFailoverClusterReply",
                Mutation.CreateFailoverCluster_ObjectFieldSpec,
                Mutation.CreateFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		hostIds = @(
			$someString
		)
		# REQUIRED
		name = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteFailoverCluster(input: DeleteFailoverClusterInput!): ResponseSuccess!
        internal void InitMutationDeleteFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteFailoverCluster",
                "($input: DeleteFailoverClusterInput!)",
                "ResponseSuccess",
                Mutation.DeleteFailoverCluster_ObjectFieldSpec,
                Mutation.DeleteFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	preserveSnapshots = $someBoolean
	# REQUIRED
	id = $someString
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
        // updateDatabaseLogReportingPropertiesForCluster(input: UpdateDatabaseLogReportingPropertiesForClusterInput!): DbLogReportProperties!
        internal void InitMutationUpdateDatabaseLogReportingPropertiesForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateDatabaseLogReportingPropertiesForClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateDatabaseLogReportingPropertiesForCluster",
                "($input: UpdateDatabaseLogReportingPropertiesForClusterInput!)",
                "DbLogReportProperties",
                Mutation.UpdateDatabaseLogReportingPropertiesForCluster_ObjectFieldSpec,
                Mutation.UpdateDatabaseLogReportingPropertiesForClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	properties = @{
		# OPTIONAL
		enableDelayNotification = $someBoolean
		# OPTIONAL
		logDelayThresholdInMin = $someInt64
		# OPTIONAL
		logDelayNotificationFrequencyInMin = $someInt64
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateFailoverCluster(input: UpdateFailoverClusterInput!): UpdateFailoverClusterReply!
        internal void InitMutationUpdateFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateFailoverClusterInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateFailoverCluster",
                "($input: UpdateFailoverClusterInput!)",
                "UpdateFailoverClusterReply",
                Mutation.UpdateFailoverCluster_ObjectFieldSpec,
                Mutation.UpdateFailoverClusterFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = $someString
		# REQUIRED
		hostIds = @(
			$someString
		)
		# REQUIRED
		name = $someString
	}
}"
            );
        }


    } // class New_RscMutationCluster
}