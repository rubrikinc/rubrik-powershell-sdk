// New-RscMutationMongoDb.cs
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
    /// Create a new RscQuery object for any of the 6
    /// operations in the 'Mongo DB' API domain:
    /// AssignSlaToCollection, BulkDeleteSources, CreateSource, DeleteSource, RecoverSource, or UpdateSource.
    /// </summary>
    /// <description>
    /// New-RscMutationMongoDb creates a new
    /// mutation object for operations
    /// in the 'Mongo DB' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 6 operations
    /// in the 'Mongo DB' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AssignSlaToCollection, BulkDeleteSources, CreateSource, DeleteSource, RecoverSource, or UpdateSource.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationMongoDb -AssignSlaToCollection).Info().
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
    /// (New-RscMutationMongoDb -AssignSlaToCollection).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AssignSlaToCollection operation
    /// of the 'Mongo DB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    MongoDb
    /// # API Operation: AssignSlaToCollection
    /// 
    /// $query = New-RscMutationMongoDb -AssignSlaToCollection
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	input = @{
    /// 		# REQUIRED
    /// 		ids = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		slaId = $someString
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
    /// Runs the BulkDeleteSources operation
    /// of the 'Mongo DB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    MongoDb
    /// # API Operation: BulkDeleteSources
    /// 
    /// $query = New-RscMutationMongoDb -BulkDeleteSources
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	sourceType = $someV2BulkDeleteMosaicSourcesRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceData = @{
    /// 		# OPTIONAL
    /// 		async = $someBoolean
    /// 		# REQUIRED
    /// 		sourceNames = @(
    /// 			$someString
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CreateSource operation
    /// of the 'Mongo DB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    MongoDb
    /// # API Operation: CreateSource
    /// 
    /// $query = New-RscMutationMongoDb -CreateSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceData = @{
    /// 		# OPTIONAL
    /// 		async = $someBoolean
    /// 		# OPTIONAL
    /// 		cassandraYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dseYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		enableSsl = $someBoolean
    /// 		# OPTIONAL
    /// 		httpsCertificate = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		jmxPassword = $someString
    /// 		# OPTIONAL
    /// 		jmxUser = $someString
    /// 		# OPTIONAL
    /// 		parameterEncoded = $someBoolean
    /// 		# OPTIONAL
    /// 		sourceAuthKey = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthKeyfile = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthPassphrase = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sourceHttpsPort = $someString
    /// 		# OPTIONAL
    /// 		sourcePassword = $someString
    /// 		# OPTIONAL
    /// 		sourcePort = $someString
    /// 		# OPTIONAL
    /// 		sourceRpcPort = $someString
    /// 		# OPTIONAL
    /// 		sourceSshPort = $someString
    /// 		# OPTIONAL
    /// 		sourceUser = $someString
    /// 		# OPTIONAL
    /// 		sslCaCerts = $someString
    /// 		# OPTIONAL
    /// 		sslCertfile = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfile = $someString
    /// 		# REQUIRED
    /// 		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
    /// 		# REQUIRED
    /// 		sourceIp = @(
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
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteSource operation
    /// of the 'Mongo DB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    MongoDb
    /// # API Operation: DeleteSource
    /// 
    /// $query = New-RscMutationMongoDb -DeleteSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	sourceType = $someV2DeleteMosaicSourceRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceName = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the RecoverSource operation
    /// of the 'Mongo DB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    MongoDb
    /// # API Operation: RecoverSource
    /// 
    /// $query = New-RscMutationMongoDb -RecoverSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	recoveryData = @{
    /// 		# OPTIONAL
    /// 		destinationSourceName = $someString
    /// 		# OPTIONAL
    /// 		keyspaceConfig = $someString
    /// 		# OPTIONAL
    /// 		maxDiskUsage = $someString
    /// 		# OPTIONAL
    /// 		restoreDbUserPwd = $someString
    /// 		# OPTIONAL
    /// 		restoreDbUsername = $someString
    /// 		# OPTIONAL
    /// 		startTimestamp = $someInt
    /// 		# OPTIONAL
    /// 		targetEncryptionKey = $someString
    /// 		# OPTIONAL
    /// 		targetQuery = $someString
    /// 		# OPTIONAL
    /// 		sourceType = $someMosaicRetrieveRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRetrieveRequestSourceType]) for enum values.
    /// 		# OPTIONAL
    /// 		destinationManagementObjects = @{
    /// 			# OPTIONAL
    /// 			databases = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					dbName = $someString
    /// 					# OPTIONAL
    /// 					tables = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		destinationPath = $someString
    /// 		# REQUIRED
    /// 		managementObjects = @{
    /// 			# OPTIONAL
    /// 			databases = @(
    /// 				@{
    /// 					# OPTIONAL
    /// 					dbName = $someString
    /// 					# OPTIONAL
    /// 					tables = @(
    /// 						$someString
    /// 					)
    /// 				}
    /// 			)
    /// 		}
    /// 		# REQUIRED
    /// 		parameterEncoded = $someBoolean
    /// 		# REQUIRED
    /// 		sourceName = $someString
    /// 		# REQUIRED
    /// 		versionTime = $someInt
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateSource operation
    /// of the 'Mongo DB' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    MongoDb
    /// # API Operation: UpdateSource
    /// 
    /// $query = New-RscMutationMongoDb -UpdateSource
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// 	# REQUIRED
    /// 	sourceData = @{
    /// 		# OPTIONAL
    /// 		async = $someBoolean
    /// 		# OPTIONAL
    /// 		cassandraYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		dseYaml = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		enableSsl = $someBoolean
    /// 		# OPTIONAL
    /// 		httpsCertificate = $someString
    /// 		# OPTIONAL
    /// 		ignoreSecondaries = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		jmxPassword = $someString
    /// 		# OPTIONAL
    /// 		jmxUser = $someString
    /// 		# OPTIONAL
    /// 		parameterEncoded = $someBoolean
    /// 		# OPTIONAL
    /// 		sourceAuthKey = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthKeyfile = $someString
    /// 		# OPTIONAL
    /// 		sourceAuthPassphrase = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverPassword = $someString
    /// 		# OPTIONAL
    /// 		sourceDriverUser = $someString
    /// 		# OPTIONAL
    /// 		sourceHttpsPort = $someString
    /// 		# OPTIONAL
    /// 		sourcePassword = $someString
    /// 		# OPTIONAL
    /// 		sourcePort = $someString
    /// 		# OPTIONAL
    /// 		sourceRpcPort = $someString
    /// 		# OPTIONAL
    /// 		sourceSshPort = $someString
    /// 		# OPTIONAL
    /// 		sourceUser = $someString
    /// 		# OPTIONAL
    /// 		sslCaCerts = $someString
    /// 		# OPTIONAL
    /// 		sslCertfile = $someString
    /// 		# OPTIONAL
    /// 		sslKeyfile = $someString
    /// 		# REQUIRED
    /// 		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
    /// 		# OPTIONAL
    /// 		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
    /// 		# REQUIRED
    /// 		sourceIp = @(
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
    /// Write-Host $result.GetType().Name # prints: MosaicAsyncResponse
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
        "RscMutationMongoDb",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationMongoDb : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AssignSlaToCollection",
                "BulkDeleteSources",
                "CreateSource",
                "DeleteSource",
                "RecoverSource",
                "UpdateSource",
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
                    case "AssignSlaToCollection":
                        this.ProcessRecord_AssignSlaToCollection();
                        break;
                    case "BulkDeleteSources":
                        this.ProcessRecord_BulkDeleteSources();
                        break;
                    case "CreateSource":
                        this.ProcessRecord_CreateSource();
                        break;
                    case "DeleteSource":
                        this.ProcessRecord_DeleteSource();
                        break;
                    case "RecoverSource":
                        this.ProcessRecord_RecoverSource();
                        break;
                    case "UpdateSource":
                        this.ProcessRecord_UpdateSource();
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
        // assignSlaToMongoDbCollection.
        internal void ProcessRecord_AssignSlaToCollection()
        {
            this._logger.name += " -AssignSlaToCollection";
            // Create new graphql operation assignSlaToMongoDbCollection
            InitMutationAssignSlaToMongoDbCollection();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteMongodbSources.
        internal void ProcessRecord_BulkDeleteSources()
        {
            this._logger.name += " -BulkDeleteSources";
            // Create new graphql operation bulkDeleteMongodbSources
            InitMutationBulkDeleteMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // createMongodbSource.
        internal void ProcessRecord_CreateSource()
        {
            this._logger.name += " -CreateSource";
            // Create new graphql operation createMongodbSource
            InitMutationCreateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongodbSource.
        internal void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Create new graphql operation deleteMongodbSource
            InitMutationDeleteMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongodbSource.
        internal void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Create new graphql operation recoverMongodbSource
            InitMutationRecoverMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateMongodbSource.
        internal void ProcessRecord_UpdateSource()
        {
            this._logger.name += " -UpdateSource";
            // Create new graphql operation updateMongodbSource
            InitMutationUpdateMongodbSource();
        }


        // Create new GraphQL Mutation:
        // assignSlaToMongoDbCollection(input: AssignSlaToMongoDbCollectionInput!): AsyncRequestStatus!
        internal void InitMutationAssignSlaToMongoDbCollection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaToMongoDbCollectionInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSlaToMongoDbCollection",
                "($input: AssignSlaToMongoDbCollectionInput!)",
                "AsyncRequestStatus",
                Mutation.AssignSlaToMongoDbCollection_ObjectFieldSpec,
                Mutation.AssignSlaToMongoDbCollectionFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	input = @{
		# REQUIRED
		ids = @(
			$someString
		)
		# REQUIRED
		slaId = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkDeleteMongodbSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        internal void InitMutationBulkDeleteMongodbSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteMosaicSourcesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteMongodbSources",
                "($input: BulkDeleteMosaicSourcesInput!)",
                "MosaicAsyncResponse",
                Mutation.BulkDeleteMongodbSources_ObjectFieldSpec,
                Mutation.BulkDeleteMongodbSourcesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	sourceType = $someV2BulkDeleteMosaicSourcesRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = $someBoolean
		# REQUIRED
		sourceNames = @(
			$someString
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // createMongodbSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationCreateMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateMongodbSource",
                "($input: AddMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.CreateMongodbSource_ObjectFieldSpec,
                Mutation.CreateMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = $someBoolean
		# OPTIONAL
		cassandraYaml = @(
			$someString
		)
		# OPTIONAL
		dseYaml = @(
			$someString
		)
		# OPTIONAL
		enableSsl = $someBoolean
		# OPTIONAL
		httpsCertificate = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		jmxPassword = $someString
		# OPTIONAL
		jmxUser = $someString
		# OPTIONAL
		parameterEncoded = $someBoolean
		# OPTIONAL
		sourceAuthKey = $someString
		# OPTIONAL
		sourceAuthKeyfile = $someString
		# OPTIONAL
		sourceAuthPassphrase = $someString
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sourceHttpsPort = $someString
		# OPTIONAL
		sourcePassword = $someString
		# OPTIONAL
		sourcePort = $someString
		# OPTIONAL
		sourceRpcPort = $someString
		# OPTIONAL
		sourceSshPort = $someString
		# OPTIONAL
		sourceUser = $someString
		# OPTIONAL
		sslCaCerts = $someString
		# OPTIONAL
		sslCertfile = $someString
		# OPTIONAL
		sslKeyfile = $someString
		# REQUIRED
		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			$someString
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteMongodbSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationDeleteMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteMongodbSource",
                "($input: DeleteMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.DeleteMongodbSource_ObjectFieldSpec,
                Mutation.DeleteMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	sourceType = $someV2DeleteMosaicSourceRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceName = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // recoverMongodbSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        internal void InitMutationRecoverMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicRestoreDataInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverMongodbSource",
                "($input: MosaicRestoreDataInput!)",
                "MosaicAsyncResponse",
                Mutation.RecoverMongodbSource_ObjectFieldSpec,
                Mutation.RecoverMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	recoveryData = @{
		# OPTIONAL
		destinationSourceName = $someString
		# OPTIONAL
		keyspaceConfig = $someString
		# OPTIONAL
		maxDiskUsage = $someString
		# OPTIONAL
		restoreDbUserPwd = $someString
		# OPTIONAL
		restoreDbUsername = $someString
		# OPTIONAL
		startTimestamp = $someInt
		# OPTIONAL
		targetEncryptionKey = $someString
		# OPTIONAL
		targetQuery = $someString
		# OPTIONAL
		sourceType = $someMosaicRetrieveRequestSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRetrieveRequestSourceType]) for enum values.
		# OPTIONAL
		destinationManagementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = $someString
					# OPTIONAL
					tables = @(
						$someString
					)
				}
			)
		}
		# REQUIRED
		destinationPath = $someString
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = $someString
					# OPTIONAL
					tables = @(
						$someString
					)
				}
			)
		}
		# REQUIRED
		parameterEncoded = $someBoolean
		# REQUIRED
		sourceName = $someString
		# REQUIRED
		versionTime = $someInt
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateMongodbSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationUpdateMongodbSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateMongodbSource",
                "($input: ModifyMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.UpdateMongodbSource_ObjectFieldSpec,
                Mutation.UpdateMongodbSourceFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	clusterUuid = $someString
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = $someBoolean
		# OPTIONAL
		cassandraYaml = @(
			$someString
		)
		# OPTIONAL
		dseYaml = @(
			$someString
		)
		# OPTIONAL
		enableSsl = $someBoolean
		# OPTIONAL
		httpsCertificate = $someString
		# OPTIONAL
		ignoreSecondaries = @(
			$someString
		)
		# OPTIONAL
		jmxPassword = $someString
		# OPTIONAL
		jmxUser = $someString
		# OPTIONAL
		parameterEncoded = $someBoolean
		# OPTIONAL
		sourceAuthKey = $someString
		# OPTIONAL
		sourceAuthKeyfile = $someString
		# OPTIONAL
		sourceAuthPassphrase = $someString
		# OPTIONAL
		sourceDriverPassword = $someString
		# OPTIONAL
		sourceDriverUser = $someString
		# OPTIONAL
		sourceHttpsPort = $someString
		# OPTIONAL
		sourcePassword = $someString
		# OPTIONAL
		sourcePort = $someString
		# OPTIONAL
		sourceRpcPort = $someString
		# OPTIONAL
		sourceSshPort = $someString
		# OPTIONAL
		sourceUser = $someString
		# OPTIONAL
		sslCaCerts = $someString
		# OPTIONAL
		sslCertfile = $someString
		# OPTIONAL
		sslKeyfile = $someString
		# REQUIRED
		sourceType = $someSourceSourceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = $someSourceSslCertReqs # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			$someString
		)
		# REQUIRED
		sourceName = $someString
	}
}"
            );
        }


    } // class New_RscMutationMongoDb
}