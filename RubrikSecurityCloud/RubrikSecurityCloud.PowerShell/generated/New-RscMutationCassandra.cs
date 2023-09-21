// New-RscMutationCassandra.cs
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
    /// Mutations for the 'Cassandra' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationCassandra is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationCassandra -RecoverSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCassandra -CreateSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCassandra -UpdateSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCassandra -DeleteSource [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationCassandra -BulkDeleteSources [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationCassandra",
        DefaultParameterSetName = "CreateSource")
    ]
    public class New_RscMutationCassandra : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// RecoverSource parameter set
        ///
        /// [GraphQL: recoverCassandraSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Recover a cassandra source.
[GraphQL: recoverCassandraSource]",
            Position = 0
        )]
        public SwitchParameter RecoverSource { get; set; }

        
        /// <summary>
        /// CreateSource parameter set
        ///
        /// [GraphQL: createCassandraSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a cassandra source.
[GraphQL: createCassandraSource]",
            Position = 0
        )]
        public SwitchParameter CreateSource { get; set; }

        
        /// <summary>
        /// UpdateSource parameter set
        ///
        /// [GraphQL: updateCassandraSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update a cassandra source.
[GraphQL: updateCassandraSource]",
            Position = 0
        )]
        public SwitchParameter UpdateSource { get; set; }

        
        /// <summary>
        /// DeleteSource parameter set
        ///
        /// [GraphQL: deleteCassandraSource]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteSource",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete a cassandra source.
[GraphQL: deleteCassandraSource]",
            Position = 0
        )]
        public SwitchParameter DeleteSource { get; set; }

        
        /// <summary>
        /// BulkDeleteSources parameter set
        ///
        /// [GraphQL: bulkDeleteCassandraSources]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkDeleteSources",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Bulk Delete cassandra sources.
[GraphQL: bulkDeleteCassandraSources]",
            Position = 0
        )]
        public SwitchParameter BulkDeleteSources { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "RecoverSource":
                        this.ProcessRecord_RecoverSource();
                        break;
                    case "CreateSource":
                        this.ProcessRecord_CreateSource();
                        break;
                    case "UpdateSource":
                        this.ProcessRecord_UpdateSource();
                        break;
                    case "DeleteSource":
                        this.ProcessRecord_DeleteSource();
                        break;
                    case "BulkDeleteSources":
                        this.ProcessRecord_BulkDeleteSources();
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
        // recoverCassandraSource.
        internal void ProcessRecord_RecoverSource()
        {
            this._logger.name += " -RecoverSource";
            // Create new graphql operation recoverCassandraSource
            InitMutationRecoverCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // createCassandraSource.
        internal void ProcessRecord_CreateSource()
        {
            this._logger.name += " -CreateSource";
            // Create new graphql operation createCassandraSource
            InitMutationCreateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // updateCassandraSource.
        internal void ProcessRecord_UpdateSource()
        {
            this._logger.name += " -UpdateSource";
            // Create new graphql operation updateCassandraSource
            InitMutationUpdateCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCassandraSource.
        internal void ProcessRecord_DeleteSource()
        {
            this._logger.name += " -DeleteSource";
            // Create new graphql operation deleteCassandraSource
            InitMutationDeleteCassandraSource();
        }

        // This parameter set invokes a single graphql operation:
        // bulkDeleteCassandraSources.
        internal void ProcessRecord_BulkDeleteSources()
        {
            this._logger.name += " -BulkDeleteSources";
            // Create new graphql operation bulkDeleteCassandraSources
            InitMutationBulkDeleteCassandraSources();
        }


        // Create new GraphQL Mutation:
        // recoverCassandraSource(input: MosaicRestoreDataInput!): MosaicAsyncResponse!
        internal void InitMutationRecoverCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MosaicRestoreDataInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRecoverCassandraSource",
                "($input: MosaicRestoreDataInput!)",
                "MosaicAsyncResponse",
                Mutation.RecoverCassandraSource_ObjectFieldSpec,
                Mutation.RecoverCassandraSourceFieldSpec,
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

        // Create new GraphQL Mutation:
        // createCassandraSource(input: AddMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationCreateCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateCassandraSource",
                "($input: AddMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.CreateCassandraSource_ObjectFieldSpec,
                Mutation.CreateCassandraSourceFieldSpec,
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
        // updateCassandraSource(input: ModifyMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationUpdateCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ModifyMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCassandraSource",
                "($input: ModifyMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.UpdateCassandraSource_ObjectFieldSpec,
                Mutation.UpdateCassandraSourceFieldSpec,
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
        // deleteCassandraSource(input: DeleteMosaicSourceInput!): MosaicAsyncResponse!
        internal void InitMutationDeleteCassandraSource()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteMosaicSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCassandraSource",
                "($input: DeleteMosaicSourceInput!)",
                "MosaicAsyncResponse",
                Mutation.DeleteCassandraSource_ObjectFieldSpec,
                Mutation.DeleteCassandraSourceFieldSpec,
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
        // bulkDeleteCassandraSources(input: BulkDeleteMosaicSourcesInput!): MosaicAsyncResponse!
        internal void InitMutationBulkDeleteCassandraSources()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkDeleteMosaicSourcesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkDeleteCassandraSources",
                "($input: BulkDeleteMosaicSourcesInput!)",
                "MosaicAsyncResponse",
                Mutation.BulkDeleteCassandraSources_ObjectFieldSpec,
                Mutation.BulkDeleteCassandraSourcesFieldSpec,
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


    } // class New_RscMutationCassandra
}