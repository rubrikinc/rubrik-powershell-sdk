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
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Mutations for the 'Mongo' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationMongo is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationMongo -AddSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -DeleteSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -DiscoverSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -PatchSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -RetryAddSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -AssignSlaToDbCollection [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -RecoverSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -CreatedbSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -UpdatedbSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -DeletedbSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -BulkDeletedbSources [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationMongo -RecoverdbSource [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationMongo",
        DefaultParameterSetName = "AddSource")
    ]
    public class New_RscMutationMongo : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// AddSource parameter set
        ///
        /// [GraphQL: addMongoSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "AddSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.
[GraphQL: addMongoSource]",
            Position = 0
        )]
        public SwitchParameter AddSource { get; set; }

        
        /// <summary>
        /// DeleteSource parameter set
        ///
        /// [GraphQL: deleteMongoSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.
[GraphQL: deleteMongoSource]",
            Position = 0
        )]
        public SwitchParameter DeleteSource { get; set; }

        
        /// <summary>
        /// DiscoverSource parameter set
        ///
        /// [GraphQL: discoverMongoSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "DiscoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.
[GraphQL: discoverMongoSource]",
            Position = 0
        )]
        public SwitchParameter DiscoverSource { get; set; }

        
        /// <summary>
        /// PatchSource parameter set
        ///
        /// [GraphQL: patchMongoSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "PatchSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.
[GraphQL: patchMongoSource]",
            Position = 0
        )]
        public SwitchParameter PatchSource { get; set; }

        
        /// <summary>
        /// RetryAddSource parameter set
        ///
        /// [GraphQL: retryAddMongoSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "RetryAddSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
[GraphQL: retryAddMongoSource]",
            Position = 0
        )]
        public SwitchParameter RetryAddSource { get; set; }

        
        /// <summary>
        /// AssignSlaToDbCollection parameter set
        ///
        /// [GraphQL: assignSlaToMongoDbCollection]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignSlaToDbCollection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.
[GraphQL: assignSlaToMongoDbCollection]",
            Position = 0
        )]
        public SwitchParameter AssignSlaToDbCollection { get; set; }

        
        /// <summary>
        /// RecoverSource parameter set
        ///
        /// [GraphQL: recoverMongoSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a MongoDB source from Rubrik CDM cluster.
[GraphQL: recoverMongoSource]",
            Position = 0
        )]
        public SwitchParameter RecoverSource { get; set; }

        
        /// <summary>
        /// CreatedbSource parameter set
        ///
        /// [GraphQL: createMongodbSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreatedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.
[GraphQL: createMongodbSource]",
            Position = 0
        )]
        public SwitchParameter CreatedbSource { get; set; }

        
        /// <summary>
        /// UpdatedbSource parameter set
        ///
        /// [GraphQL: updateMongodbSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdatedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Modifies configuration for a registered MongoDB source in NoSQL cluster.
[GraphQL: updateMongodbSource]",
            Position = 0
        )]
        public SwitchParameter UpdatedbSource { get; set; }

        
        /// <summary>
        /// DeletedbSource parameter set
        ///
        /// [GraphQL: deleteMongodbSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeletedbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Remove a registered MongoDB source from NoSQL cluster.
[GraphQL: deleteMongodbSource]",
            Position = 0
        )]
        public SwitchParameter DeletedbSource { get; set; }

        
        /// <summary>
        /// BulkDeletedbSources parameter set
        ///
        /// [GraphQL: bulkDeleteMongodbSources]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkDeletedbSources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
[GraphQL: bulkDeleteMongodbSources]",
            Position = 0
        )]
        public SwitchParameter BulkDeletedbSources { get; set; }

        
        /// <summary>
        /// RecoverdbSource parameter set
        ///
        /// [GraphQL: recoverMongodbSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverdbSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a MongoDB source from NoSQL cluster.
[GraphQL: recoverMongodbSource]",
            Position = 0
        )]
        public SwitchParameter RecoverdbSource { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "AddSource":
                        this.ProcessRecord_AddSource();
                        break;
                    case "DeleteSource":
                        this.ProcessRecord_DeleteSource();
                        break;
                    case "DiscoverSource":
                        this.ProcessRecord_DiscoverSource();
                        break;
                    case "PatchSource":
                        this.ProcessRecord_PatchSource();
                        break;
                    case "RetryAddSource":
                        this.ProcessRecord_RetryAddSource();
                        break;
                    case "AssignSlaToDbCollection":
                        this.ProcessRecord_AssignSlaToDbCollection();
                        break;
                    case "RecoverSource":
                        this.ProcessRecord_RecoverSource();
                        break;
                    case "CreatedbSource":
                        this.ProcessRecord_CreatedbSource();
                        break;
                    case "UpdatedbSource":
                        this.ProcessRecord_UpdatedbSource();
                        break;
                    case "DeletedbSource":
                        this.ProcessRecord_DeletedbSource();
                        break;
                    case "BulkDeletedbSources":
                        this.ProcessRecord_BulkDeletedbSources();
                        break;
                    case "RecoverdbSource":
                        this.ProcessRecord_RecoverdbSource();
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
        // addMongoSource.
        internal void ProcessRecord_AddSource()
        {
            this._logger.name += " -AddSource";
            // Create new graphql operation addMongoSource
            InitMutationAddMongoSource();
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
        // patchMongoSource.
        internal void ProcessRecord_PatchSource()
        {
            this._logger.name += " -PatchSource";
            // Create new graphql operation patchMongoSource
            InitMutationPatchMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // retryAddMongoSource.
        internal void ProcessRecord_RetryAddSource()
        {
            this._logger.name += " -RetryAddSource";
            // Create new graphql operation retryAddMongoSource
            InitMutationRetryAddMongoSource();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlaToMongoDbCollection.
        internal void ProcessRecord_AssignSlaToDbCollection()
        {
            this._logger.name += " -AssignSlaToDbCollection";
            // Create new graphql operation assignSlaToMongoDbCollection
            InitMutationAssignSlaToMongoDbCollection();
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
        // createMongodbSource.
        internal void ProcessRecord_CreatedbSource()
        {
            this._logger.name += " -CreatedbSource";
            // Create new graphql operation createMongodbSource
            InitMutationCreateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateMongodbSource.
        internal void ProcessRecord_UpdatedbSource()
        {
            this._logger.name += " -UpdatedbSource";
            // Create new graphql operation updateMongodbSource
            InitMutationUpdateMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteMongodbSource.
        internal void ProcessRecord_DeletedbSource()
        {
            this._logger.name += " -DeletedbSource";
            // Create new graphql operation deleteMongodbSource
            InitMutationDeleteMongodbSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteMongodbSources.
        internal void ProcessRecord_BulkDeletedbSources()
        {
            this._logger.name += " -BulkDeletedbSources";
            // Create new graphql operation bulkDeleteMongodbSources
            InitMutationBulkDeleteMongodbSources();
        }

        // This parameter set invokes a single graphql operation:
        // recoverMongodbSource.
        internal void ProcessRecord_RecoverdbSource()
        {
            this._logger.name += " -RecoverdbSource";
            // Create new graphql operation recoverMongodbSource
            InitMutationRecoverMongodbSource();
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
                Mutation.AddMongoSource_ObjectFieldSpec,
                Mutation.AddMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	mongoSourceAddRequestConfig = @{
		# OPTIONAL
		caCertfilePath = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sslKeyfilePath = <System.String>
		# OPTIONAL
		sslCertfilePath = <System.String>
		# REQUIRED
		mongoType = <MongoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = <MongoSslCertificateRequirement> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = <System.Int32>
				# REQUIRED
				hostId = <System.String>
			}
		)
		# REQUIRED
		sourceName = <System.String>
	}
}"
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
                Mutation.DeleteMongoSource_ObjectFieldSpec,
                Mutation.DeleteMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
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
                Mutation.DiscoverMongoSource_ObjectFieldSpec,
                Mutation.DiscoverMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
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
                Mutation.PatchMongoSource_ObjectFieldSpec,
                Mutation.PatchMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	mongoSourcePatchRequestConfig = @{
		# OPTIONAL
		caCertfilePath = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sslKeyfilePath = <System.String>
		# OPTIONAL
		sslCertfilePath = <System.String>
		# OPTIONAL
		sslCertificateRequired = <MongoSslCertificateRequirement> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
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
                Mutation.RetryAddMongoSource_ObjectFieldSpec,
                Mutation.RetryAddMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	mongoSourceRequestConfig = @{
		# OPTIONAL
		caCertfilePath = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sslKeyfilePath = <System.String>
		# OPTIONAL
		sslCertfilePath = <System.String>
		# REQUIRED
		mongoType = <MongoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = <MongoSslCertificateRequirement> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = <System.Int32>
				# REQUIRED
				hostId = <System.String>
			}
		)
		# REQUIRED
		sourceName = <System.String>
	}
}"
            );
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
$inputs.Var.input = @{
	# REQUIRED
	input = @{
		# REQUIRED
		ids = @(
			<System.String>
		)
		# REQUIRED
		slaId = <System.String>
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
                Mutation.RecoverMongoSource_ObjectFieldSpec,
                Mutation.RecoverMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	input = @{
		# OPTIONAL
		prefix = <System.String>
		# OPTIONAL
		restoreDbPassword = <System.String>
		# OPTIONAL
		restoreDbUsername = <System.String>
		# OPTIONAL
		shouldDropExistingCollection = <System.Boolean>
		# OPTIONAL
		sourceCollectionIds = @(
			<System.String>
		)
		# OPTIONAL
		sourceDatabaseIds = @(
			<System.String>
		)
		# OPTIONAL
		targetCollectionName = <System.String>
		# OPTIONAL
		targetDatabaseName = <System.String>
		# OPTIONAL
		versionTime = <DateTime>
		# OPTIONAL
		restoreThrottleInBytesPerSecond = <System.Int64>
		# OPTIONAL
		isRestoreWithIndex = <System.Boolean>
		# REQUIRED
		sourceMongoClusterId = <System.String>
		# REQUIRED
		targetMongoClusterId = <System.String>
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
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# OPTIONAL
		cassandraYaml = @(
			<System.String>
		)
		# OPTIONAL
		dseYaml = @(
			<System.String>
		)
		# OPTIONAL
		enableSsl = <System.Boolean>
		# OPTIONAL
		httpsCertificate = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		jmxPassword = <System.String>
		# OPTIONAL
		jmxUser = <System.String>
		# OPTIONAL
		parameterEncoded = <System.Boolean>
		# OPTIONAL
		sourceAuthKey = <System.String>
		# OPTIONAL
		sourceAuthKeyfile = <System.String>
		# OPTIONAL
		sourceAuthPassphrase = <System.String>
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sourceHttpsPort = <System.String>
		# OPTIONAL
		sourcePassword = <System.String>
		# OPTIONAL
		sourcePort = <System.String>
		# OPTIONAL
		sourceRpcPort = <System.String>
		# OPTIONAL
		sourceSshPort = <System.String>
		# OPTIONAL
		sourceUser = <System.String>
		# OPTIONAL
		sslCaCerts = <System.String>
		# OPTIONAL
		sslCertfile = <System.String>
		# OPTIONAL
		sslKeyfile = <System.String>
		# REQUIRED
		sourceType = <SourceSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = <SourceSslCertReqs> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			<System.String>
		)
		# REQUIRED
		sourceName = <System.String>
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
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# OPTIONAL
		cassandraYaml = @(
			<System.String>
		)
		# OPTIONAL
		dseYaml = @(
			<System.String>
		)
		# OPTIONAL
		enableSsl = <System.Boolean>
		# OPTIONAL
		httpsCertificate = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		jmxPassword = <System.String>
		# OPTIONAL
		jmxUser = <System.String>
		# OPTIONAL
		parameterEncoded = <System.Boolean>
		# OPTIONAL
		sourceAuthKey = <System.String>
		# OPTIONAL
		sourceAuthKeyfile = <System.String>
		# OPTIONAL
		sourceAuthPassphrase = <System.String>
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sourceHttpsPort = <System.String>
		# OPTIONAL
		sourcePassword = <System.String>
		# OPTIONAL
		sourcePort = <System.String>
		# OPTIONAL
		sourceRpcPort = <System.String>
		# OPTIONAL
		sourceSshPort = <System.String>
		# OPTIONAL
		sourceUser = <System.String>
		# OPTIONAL
		sslCaCerts = <System.String>
		# OPTIONAL
		sslCertfile = <System.String>
		# OPTIONAL
		sslKeyfile = <System.String>
		# REQUIRED
		sourceType = <SourceSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = <SourceSslCertReqs> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			<System.String>
		)
		# REQUIRED
		sourceName = <System.String>
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
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2DeleteMosaicSourceRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceName = <System.String>
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
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2BulkDeleteMosaicSourcesRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# REQUIRED
		sourceNames = @(
			<System.String>
		)
	}
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
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryData = @{
		# OPTIONAL
		destinationManagementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# OPTIONAL
		destinationSourceName = <System.String>
		# OPTIONAL
		keyspaceConfig = <System.String>
		# OPTIONAL
		maxDiskUsage = <System.String>
		# OPTIONAL
		restoreDbUserPwd = <System.String>
		# OPTIONAL
		restoreDbUsername = <System.String>
		# OPTIONAL
		startTimestamp = <System.Int32>
		# OPTIONAL
		targetEncryptionKey = <System.String>
		# OPTIONAL
		targetQuery = <System.String>
		# OPTIONAL
		sourceType = <MosaicRetrieveRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRetrieveRequestSourceType]) for enum values.
		# REQUIRED
		destinationPath = <System.String>
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# REQUIRED
		parameterEncoded = <System.Boolean>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		versionTime = <System.Int32>
	}
}"
            );
        }


    } // class New_RscMutationMongo
}