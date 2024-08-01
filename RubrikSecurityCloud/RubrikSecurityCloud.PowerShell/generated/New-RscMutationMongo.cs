// New-RscMutationMongo.cs
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
    /// Create a new RscQuery object for any of the 10
    /// operations in the 'Mongo' API domain:
    /// AddOpsManagerManagedSource, AddSource, CreateOnDemandDatabaseBackup, DeleteSource, DiscoverSource, PatchOpsManagerManagedSource, PatchSource, RecoverSource, RetryAddOpsManagerManagedSource, or RetryAddSource.
    /// </summary>
    /// <description>
    /// New-RscMutationMongo creates a new
    /// mutation object for operations
    /// in the 'Mongo' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 10 operations
    /// in the 'Mongo' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddOpsManagerManagedSource, AddSource, CreateOnDemandDatabaseBackup, DeleteSource, DiscoverSource, PatchOpsManagerManagedSource, PatchSource, RecoverSource, RetryAddOpsManagerManagedSource, or RetryAddSource.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMongo -AddOpsManagerManagedSource).Info().
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
    /// (New-RscMutationMongo -AddOpsManagerManagedSource).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddOpsManagerManagedSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: AddOpsManagerManagedSource
    /// 
    /// $query = New-RscMutationMongo -AddOpsManagerManagedSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	mongoOpsmanagerSourceAddRequestConfig = @{
    /// 		# OPTIONAL
    /// 		ignoreNodes = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		opsManagerApiToken = $someString
    /// 		# REQUIRED
    /// 		opsManagerClusterId = $someString
    /// 		# REQUIRED
    /// 		opsManagerGroupId = $someString
    /// 		# REQUIRED
    /// 		opsManagerNodes = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddOpsManagerMongoSourceResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: AddSource
    /// 
    /// $query = New-RscMutationMongo -AddSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	mongoSourceAddRequestConfig = @{
    /// 		# OPTIONAL
    /// 		caCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfilePath = $someString
    /// 		# OPTIONAL
    /// 		sslCertfilePath = $someString
    /// 		# REQUIRED
    /// 		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
    /// 		# OPTIONAL
    /// 		sourceAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
    /// 		# REQUIRED
    /// 		mongoClientHosts = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				configurationPort = $someInt
    /// 				# REQUIRED
    /// 				hostId = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddMongoSourceReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateOnDemandDatabaseBackup operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: CreateOnDemandDatabaseBackup
    /// 
    /// $query = New-RscMutationMongo -CreateOnDemandDatabaseBackup
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	config = @{
    /// 		# REQUIRED
    /// 		isFullbackup = $someBoolean
    /// 		# REQUIRED
    /// 		slaId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.attributes = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		value = $someString
    /// 		# REQUIRED
    /// 		attribute = $someFlagAttribute # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FlagAttribute]) for enum values.
    /// }
    /// )
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
    /// Runs the DeleteSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: DeleteSource
    /// 
    /// $query = New-RscMutationMongo -DeleteSource
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
    /// Runs the DiscoverSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: DiscoverSource
    /// 
    /// $query = New-RscMutationMongo -DiscoverSource
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
    /// Runs the PatchOpsManagerManagedSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: PatchOpsManagerManagedSource
    /// 
    /// $query = New-RscMutationMongo -PatchOpsManagerManagedSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	patch = @{
    /// 		# OPTIONAL
    /// 		ignoreNodes = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		opsManagerApiToken = $someString
    /// 	}
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
    /// Runs the PatchSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: PatchSource
    /// 
    /// $query = New-RscMutationMongo -PatchSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	mongoSourcePatchRequestConfig = @{
    /// 		# OPTIONAL
    /// 		caCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfilePath = $someString
    /// 		# OPTIONAL
    /// 		sslCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
    /// 	}
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
    /// Runs the RecoverSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: RecoverSource
    /// 
    /// $query = New-RscMutationMongo -RecoverSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	input = @{
    /// 		# OPTIONAL
    /// 		prefix = $someString
    /// 		# OPTIONAL
    /// 		restoreDbPassword = $someString
    /// 		# OPTIONAL
    /// 		restoreDbUsername = $someString
    /// 		# OPTIONAL
    /// 		shouldDropExistingCollection = $someBoolean
    /// 		# OPTIONAL
    /// 		sourceCollectionIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDatabaseIds = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		targetCollectionName = $someString
    /// 		# OPTIONAL
    /// 		targetDatabaseName = $someString
    /// 		# OPTIONAL
    /// 		versionTime = $someDateTime
    /// 		# OPTIONAL
    /// 		restoreThrottleInBytesPerSecond = $someInt64
    /// 		# OPTIONAL
    /// 		isRestoreWithIndex = $someBoolean
    /// 		# OPTIONAL
    /// 		targetAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
    /// 		# REQUIRED
    /// 		sourceMongoClusterId = $someString
    /// 		# REQUIRED
    /// 		targetMongoClusterId = $someString
    /// 	}
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
    /// Runs the RetryAddOpsManagerManagedSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: RetryAddOpsManagerManagedSource
    /// 
    /// $query = New-RscMutationMongo -RetryAddOpsManagerManagedSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	mongoOpsmanagerSourceUpdateRequestConfig = @{
    /// 		# OPTIONAL
    /// 		ignoreNodes = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		opsManagerApiToken = $someString
    /// 		# REQUIRED
    /// 		opsManagerClusterId = $someString
    /// 		# REQUIRED
    /// 		opsManagerGroupId = $someString
    /// 		# REQUIRED
    /// 		opsManagerNodes = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
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
    /// Runs the RetryAddSource operation
    /// of the 'Mongo' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Mongo
    /// # API Operation: RetryAddSource
    /// 
    /// $query = New-RscMutationMongo -RetryAddSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// 	# REQUIRED
    /// 	mongoSourceRequestConfig = @{
    /// 		# OPTIONAL
    /// 		caCertfilePath = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfilePath = $someString
    /// 		# OPTIONAL
    /// 		sslCertfilePath = $someString
    /// 		# REQUIRED
    /// 		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
    /// 		# OPTIONAL
    /// 		sourceAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
    /// 		# REQUIRED
    /// 		mongoClientHosts = @(
    /// 			@{
    /// 				# REQUIRED
    /// 				configurationPort = $someInt
    /// 				# REQUIRED
    /// 				hostId = $someString
    /// 			}
    /// 		)
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 	}
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
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationMongo",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationMongo : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddOpsManagerManagedSource",
                "AddSource",
                "CreateOnDemandDatabaseBackup",
                "DeleteSource",
                "DiscoverSource",
                "PatchOpsManagerManagedSource",
                "PatchSource",
                "RecoverSource",
                "RetryAddOpsManagerManagedSource",
                "RetryAddSource",
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
                    case "AddOpsManagerManagedSource":
                        this.ProcessRecord_AddOpsManagerManagedSource();
                        break;
                    case "AddSource":
                        this.ProcessRecord_AddSource();
                        break;
                    case "CreateOnDemandDatabaseBackup":
                        this.ProcessRecord_CreateOnDemandDatabaseBackup();
                        break;
                    case "DeleteSource":
                        this.ProcessRecord_DeleteSource();
                        break;
                    case "DiscoverSource":
                        this.ProcessRecord_DiscoverSource();
                        break;
                    case "PatchOpsManagerManagedSource":
                        this.ProcessRecord_PatchOpsManagerManagedSource();
                        break;
                    case "PatchSource":
                        this.ProcessRecord_PatchSource();
                        break;
                    case "RecoverSource":
                        this.ProcessRecord_RecoverSource();
                        break;
                    case "RetryAddOpsManagerManagedSource":
                        this.ProcessRecord_RetryAddOpsManagerManagedSource();
                        break;
                    case "RetryAddSource":
                        this.ProcessRecord_RetryAddSource();
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
        // addOpsManagerManagedMongoSource.
        internal void ProcessRecord_AddOpsManagerManagedSource()
        {
            this._logger.name += " -AddOpsManagerManagedSource";
            // Create new graphql operation addOpsManagerManagedMongoSource
            InitMutationAddOpsManagerManagedMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // addMongoSource.
        internal void ProcessRecord_AddSource()
        {
            this._logger.name += " -AddSource";
            // Create new graphql operation addMongoSource
            InitMutationAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // createOnDemandMongoDatabaseBackup.
        internal void ProcessRecord_CreateOnDemandDatabaseBackup()
        {
            this._logger.name += " -CreateOnDemandDatabaseBackup";
            // Create new graphql operation createOnDemandMongoDatabaseBackup
            InitMutationCreateOnDemandMongoDatabaseBackup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongoSource.
        internal void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Create new graphql operation deleteMongoSource
            InitMutationDeleteMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // discoverMongoSource.
        internal void ProcessRecord_DiscoverSource()
        {
            this._logger.name += " -DiscoverSource";
            // Create new graphql operation discoverMongoSource
            InitMutationDiscoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // patchOpsManagerManagedMongoSource.
        internal void ProcessRecord_PatchOpsManagerManagedSource()
        {
            this._logger.name += " -PatchOpsManagerManagedSource";
            // Create new graphql operation patchOpsManagerManagedMongoSource
            InitMutationPatchOpsManagerManagedMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // patchMongoSource.
        internal void ProcessRecord_PatchSource()
        {
            this._logger.name += " -PatchSource";
            // Create new graphql operation patchMongoSource
            InitMutationPatchMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongoSource.
        internal void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Create new graphql operation recoverMongoSource
            InitMutationRecoverMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddOpsManagerManagedMongoSource.
        internal void ProcessRecord_RetryAddOpsManagerManagedSource()
        {
            this._logger.name += " -RetryAddOpsManagerManagedSource";
            // Create new graphql operation retryAddOpsManagerManagedMongoSource
            InitMutationRetryAddOpsManagerManagedMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddMongoSource.
        internal void ProcessRecord_RetryAddSource()
        {
            this._logger.name += " -RetryAddSource";
            // Create new graphql operation retryAddMongoSource
            InitMutationRetryAddMongoSource();
        }


        // Create new GraphQL Mutation:
        // addOpsManagerManagedMongoSource(input: AddOpsManagerManagedMongoSourceInput!): AddOpsManagerMongoSourceResponse!
        internal void InitMutationAddOpsManagerManagedMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddOpsManagerManagedMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddOpsManagerManagedMongoSource",
                "($input: AddOpsManagerManagedMongoSourceInput!)",
                "AddOpsManagerMongoSourceResponse",
                Mutation.AddOpsManagerManagedMongoSource,
                Mutation.AddOpsManagerManagedMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	mongoOpsmanagerSourceAddRequestConfig = @{
		# OPTIONAL
		ignoreNodes = @(
			$someString
		)
		# REQUIRED
		opsManagerApiToken = $someString
		# REQUIRED
		opsManagerClusterId = $someString
		# REQUIRED
		opsManagerGroupId = $someString
		# REQUIRED
		opsManagerNodes = @(
			$someString
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // addMongoSource(input: AddMongoSourceInput!): AddMongoSourceReply!
        internal void InitMutationAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddMongoSource",
                "($input: AddMongoSourceInput!)",
                "AddMongoSourceReply",
                Mutation.AddMongoSource,
                Mutation.AddMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	mongoSourceAddRequestConfig = @{
		# OPTIONAL
		caCertfilePath = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sslKeyfilePath = $someString
		# OPTIONAL
		sslCertfilePath = $someString
		# REQUIRED
		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sourceAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = $someInt
				# REQUIRED
				hostId = $someString
			}
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOnDemandMongoDatabaseBackup(input: CreateOnDemandMongoDatabaseSnapshotInput!, attributes: [FeatureFlagAttributeInput!]!): AsyncRequestStatus!
        internal void InitMutationCreateOnDemandMongoDatabaseBackup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOnDemandMongoDatabaseSnapshotInput!"),
                Tuple.Create("attributes", "[FeatureFlagAttributeInput!]!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOnDemandMongoDatabaseBackup",
                "($input: CreateOnDemandMongoDatabaseSnapshotInput!,$attributes: [FeatureFlagAttributeInput!]!)",
                "AsyncRequestStatus",
                Mutation.CreateOnDemandMongoDatabaseBackup,
                Mutation.CreateOnDemandMongoDatabaseBackupFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		isFullbackup = $someBoolean
		# REQUIRED
		slaId = $someString
	}
	# REQUIRED
	id = $someString
}
# REQUIRED
$query.Var.attributes = @(
	@{
		# REQUIRED
		value = $someString
		# REQUIRED
		attribute = $someFlagAttribute # Call [Enum]::GetValues([RubrikSecurityCloud.Types.FlagAttribute]) for enum values.
}
)"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMongoSource(input: DeleteMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationDeleteMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMongoSource",
                "($input: DeleteMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteMongoSource,
                Mutation.DeleteMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // discoverMongoSource(input: DiscoverMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationDiscoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDiscoverMongoSource",
                "($input: DiscoverMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.DiscoverMongoSource,
                Mutation.DiscoverMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchOpsManagerManagedMongoSource(input: PatchOpsManagerManagedMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationPatchOpsManagerManagedMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchOpsManagerManagedMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchOpsManagerManagedMongoSource",
                "($input: PatchOpsManagerManagedMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.PatchOpsManagerManagedMongoSource,
                Mutation.PatchOpsManagerManagedMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	patch = @{
		# OPTIONAL
		ignoreNodes = @(
			$someString
		)
		# REQUIRED
		opsManagerApiToken = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // patchMongoSource(input: PatchMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationPatchMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PatchMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPatchMongoSource",
                "($input: PatchMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.PatchMongoSource,
                Mutation.PatchMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	mongoSourcePatchRequestConfig = @{
		# OPTIONAL
		caCertfilePath = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sslKeyfilePath = $someString
		# OPTIONAL
		sslCertfilePath = $someString
		# OPTIONAL
		sourceAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverMongoSource(input: RecoverMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationRecoverMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RecoverMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverMongoSource",
                "($input: RecoverMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.RecoverMongoSource,
                Mutation.RecoverMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	input = @{
		# OPTIONAL
		prefix = $someString
		# OPTIONAL
		restoreDbPassword = $someString
		# OPTIONAL
		restoreDbUsername = $someString
		# OPTIONAL
		shouldDropExistingCollection = $someBoolean
		# OPTIONAL
		sourceCollectionIds = @(
			$someString
		)
		# OPTIONAL
		sourceDatabaseIds = @(
			$someString
		)
		# OPTIONAL
		targetCollectionName = $someString
		# OPTIONAL
		targetDatabaseName = $someString
		# OPTIONAL
		versionTime = $someDateTime
		# OPTIONAL
		restoreThrottleInBytesPerSecond = $someInt64
		# OPTIONAL
		isRestoreWithIndex = $someBoolean
		# OPTIONAL
		targetAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
		# REQUIRED
		sourceMongoClusterId = $someString
		# REQUIRED
		targetMongoClusterId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // retryAddOpsManagerManagedMongoSource(input: PutOpsManagerManagedMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationRetryAddOpsManagerManagedMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PutOpsManagerManagedMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRetryAddOpsManagerManagedMongoSource",
                "($input: PutOpsManagerManagedMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.RetryAddOpsManagerManagedMongoSource,
                Mutation.RetryAddOpsManagerManagedMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	mongoOpsmanagerSourceUpdateRequestConfig = @{
		# OPTIONAL
		ignoreNodes = @(
			$someString
		)
		# REQUIRED
		opsManagerApiToken = $someString
		# REQUIRED
		opsManagerClusterId = $someString
		# REQUIRED
		opsManagerGroupId = $someString
		# REQUIRED
		opsManagerNodes = @(
			$someString
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // retryAddMongoSource(input: RetryAddMongoSourceInput!): AsyncRequestStatus!
        internal void InitMutationRetryAddMongoSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RetryAddMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRetryAddMongoSource",
                "($input: RetryAddMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.RetryAddMongoSource,
                Mutation.RetryAddMongoSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
	# REQUIRED
	mongoSourceRequestConfig = @{
		# OPTIONAL
		caCertfilePath = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sslKeyfilePath = $someString
		# OPTIONAL
		sslCertfilePath = $someString
		# REQUIRED
		mongoType = $someMongoType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sourceAuthenticationType = $someMongoAuthenticationType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoAuthenticationType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = $someMongoSslCertificateRequirement # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = $someInt
				# REQUIRED
				hostId = $someString
			}
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }


    } // class New_RscMutationMongo
}