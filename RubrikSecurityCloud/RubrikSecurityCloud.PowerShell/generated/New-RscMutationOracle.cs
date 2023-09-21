// New-RscMutationOracle.cs
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
    /// Mutations for the 'Oracle' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationOracle is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationOracle -BulkUpdateHosts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -RefreshDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -UpdateDataGuardGroup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -DeleteAllDatabaseSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -TakeOnDemandDatabaseSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -TakeOnDemandLogSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -BulkUpdateRacs [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -ExportTablespace [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -ValidateAcoFile [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -ValidateDatabaseBackups [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -BulkUpdateDatabases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -InstantRecoverSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -MountDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -ExportDatabase [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -CreatePdbRestore [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -DownloadDatabaseSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -DeleteMount [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationOracle -RestoreLogs [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationOracle",
        DefaultParameterSetName = "DeleteMount")
    ]
    public class New_RscMutationOracle : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// BulkUpdateHosts parameter set
        ///
        /// [GraphQL: bulkUpdateOracleHosts]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkUpdateHosts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle Hosts

Supported in v5.2+
Update properties to Oracle Host objects.
[GraphQL: bulkUpdateOracleHosts]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateHosts { get; set; }

        
        /// <summary>
        /// RefreshDatabase parameter set
        ///
        /// [GraphQL: refreshOracleDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "RefreshDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Refresh an Oracle database

Supported in v6.0+
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts.
[GraphQL: refreshOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter RefreshDatabase { get; set; }

        
        /// <summary>
        /// UpdateDataGuardGroup parameter set
        ///
        /// [GraphQL: updateOracleDataGuardGroup]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateDataGuardGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update an Oracle Data Guard group

Supported in v6.0+
Update properties of an Oracle Data Guard group object.
[GraphQL: updateOracleDataGuardGroup]",
            Position = 0
        )]
        public SwitchParameter UpdateDataGuardGroup { get; set; }

        
        /// <summary>
        /// DeleteAllDatabaseSnapshots parameter set
        ///
        /// [GraphQL: deleteAllOracleDatabaseSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteAllDatabaseSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete Oracle database snapshots

Supported in v5.0+
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain.
[GraphQL: deleteAllOracleDatabaseSnapshots]",
            Position = 0
        )]
        public SwitchParameter DeleteAllDatabaseSnapshots { get; set; }

        
        /// <summary>
        /// TakeOnDemandDatabaseSnapshot parameter set
        ///
        /// [GraphQL: takeOnDemandOracleDatabaseSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "TakeOnDemandDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand backup of an Oracle database

Supported in v5.0+
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
[GraphQL: takeOnDemandOracleDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter TakeOnDemandDatabaseSnapshot { get; set; }

        
        /// <summary>
        /// TakeOnDemandLogSnapshot parameter set
        ///
        /// [GraphQL: takeOnDemandOracleLogSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "TakeOnDemandLogSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"On-demand log backup for an Oracle database log

Supported in v5.0+
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}.
[GraphQL: takeOnDemandOracleLogSnapshot]",
            Position = 0
        )]
        public SwitchParameter TakeOnDemandLogSnapshot { get; set; }

        
        /// <summary>
        /// BulkUpdateRacs parameter set
        ///
        /// [GraphQL: bulkUpdateOracleRacs]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkUpdateRacs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle RACs

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle RAC.
[GraphQL: bulkUpdateOracleRacs]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateRacs { get; set; }

        
        /// <summary>
        /// ExportTablespace parameter set
        ///
        /// [GraphQL: exportOracleTablespace]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportTablespace",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export an Oracle tablespace

Supported in v5.0+
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp.
[GraphQL: exportOracleTablespace]",
            Position = 0
        )]
        public SwitchParameter ExportTablespace { get; set; }

        
        /// <summary>
        /// ValidateAcoFile parameter set
        ///
        /// [GraphQL: validateOracleAcoFile]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateAcoFile",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate Oracle ACO file

Supported in v6.0+
Validate the provided Oracle ACO (Advanced Cloning Options) file.
[GraphQL: validateOracleAcoFile]",
            Position = 0
        )]
        public SwitchParameter ValidateAcoFile { get; set; }

        
        /// <summary>
        /// ValidateDatabaseBackups parameter set
        ///
        /// [GraphQL: validateOracleDatabaseBackups]
        /// </summary>
        [Parameter(
            ParameterSetName = "ValidateDatabaseBackups",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Validate Oracle database backups

Supported in v5.3+
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp.
[GraphQL: validateOracleDatabaseBackups]",
            Position = 0
        )]
        public SwitchParameter ValidateDatabaseBackups { get; set; }

        
        /// <summary>
        /// BulkUpdateDatabases parameter set
        ///
        /// [GraphQL: bulkUpdateOracleDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "BulkUpdateDatabases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update Oracle Databases

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle Databases.
[GraphQL: bulkUpdateOracleDatabases]",
            Position = 0
        )]
        public SwitchParameter BulkUpdateDatabases { get; set; }

        
        /// <summary>
        /// InstantRecoverSnapshot parameter set
        ///
        /// [GraphQL: instantRecoverOracleSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "InstantRecoverSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Instant recovery of a database

Supported in v5.0+
Creates an instant recover request that restores a target database from the given snapshot.
[GraphQL: instantRecoverOracleSnapshot]",
            Position = 0
        )]
        public SwitchParameter InstantRecoverSnapshot { get; set; }

        
        /// <summary>
        /// MountDatabase parameter set
        ///
        /// [GraphQL: mountOracleDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "MountDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Live Mount an Oracle database snapshot

Supported in v5.0+
Create an asynchronous job to Live Mount an Oracle database from a snapshot.
[GraphQL: mountOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter MountDatabase { get; set; }

        
        /// <summary>
        /// ExportDatabase parameter set
        ///
        /// [GraphQL: exportOracleDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportDatabase",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Export an Oracle database

Supported in v5.0+
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp.
[GraphQL: exportOracleDatabase]",
            Position = 0
        )]
        public SwitchParameter ExportDatabase { get; set; }

        
        /// <summary>
        /// CreatePdbRestore parameter set
        ///
        /// [GraphQL: createOraclePdbRestore]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreatePdbRestore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore PDBs on an Oracle database

Supported in v8.0+
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp.
[GraphQL: createOraclePdbRestore]",
            Position = 0
        )]
        public SwitchParameter CreatePdbRestore { get; set; }

        
        /// <summary>
        /// DownloadDatabaseSnapshot parameter set
        ///
        /// [GraphQL: downloadOracleDatabaseSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "DownloadDatabaseSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Download Oracle snapshot from cloud

Supported in v5.0+
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
[GraphQL: downloadOracleDatabaseSnapshot]",
            Position = 0
        )]
        public SwitchParameter DownloadDatabaseSnapshot { get; set; }

        
        /// <summary>
        /// DeleteMount parameter set
        ///
        /// [GraphQL: deleteOracleMount]
        /// </summary>
        [Parameter(
            ParameterSetName = "DeleteMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Delete an Oracle database Live Mount

Supported in v5.0+
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}.
[GraphQL: deleteOracleMount]",
            Position = 0
        )]
        public SwitchParameter DeleteMount { get; set; }

        
        /// <summary>
        /// RestoreLogs parameter set
        ///
        /// [GraphQL: restoreOracleLogs]
        /// </summary>
        [Parameter(
            ParameterSetName = "RestoreLogs",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Restore archive logs of an Oracle database

Supported in v6.0+
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database.
[GraphQL: restoreOracleLogs]",
            Position = 0
        )]
        public SwitchParameter RestoreLogs { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "BulkUpdateHosts":
                        this.ProcessRecord_BulkUpdateHosts();
                        break;
                    case "RefreshDatabase":
                        this.ProcessRecord_RefreshDatabase();
                        break;
                    case "UpdateDataGuardGroup":
                        this.ProcessRecord_UpdateDataGuardGroup();
                        break;
                    case "DeleteAllDatabaseSnapshots":
                        this.ProcessRecord_DeleteAllDatabaseSnapshots();
                        break;
                    case "TakeOnDemandDatabaseSnapshot":
                        this.ProcessRecord_TakeOnDemandDatabaseSnapshot();
                        break;
                    case "TakeOnDemandLogSnapshot":
                        this.ProcessRecord_TakeOnDemandLogSnapshot();
                        break;
                    case "BulkUpdateRacs":
                        this.ProcessRecord_BulkUpdateRacs();
                        break;
                    case "ExportTablespace":
                        this.ProcessRecord_ExportTablespace();
                        break;
                    case "ValidateAcoFile":
                        this.ProcessRecord_ValidateAcoFile();
                        break;
                    case "ValidateDatabaseBackups":
                        this.ProcessRecord_ValidateDatabaseBackups();
                        break;
                    case "BulkUpdateDatabases":
                        this.ProcessRecord_BulkUpdateDatabases();
                        break;
                    case "InstantRecoverSnapshot":
                        this.ProcessRecord_InstantRecoverSnapshot();
                        break;
                    case "MountDatabase":
                        this.ProcessRecord_MountDatabase();
                        break;
                    case "ExportDatabase":
                        this.ProcessRecord_ExportDatabase();
                        break;
                    case "CreatePdbRestore":
                        this.ProcessRecord_CreatePdbRestore();
                        break;
                    case "DownloadDatabaseSnapshot":
                        this.ProcessRecord_DownloadDatabaseSnapshot();
                        break;
                    case "DeleteMount":
                        this.ProcessRecord_DeleteMount();
                        break;
                    case "RestoreLogs":
                        this.ProcessRecord_RestoreLogs();
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
        // bulkUpdateOracleHosts.
        internal void ProcessRecord_BulkUpdateHosts()
        {
            this._logger.name += " -BulkUpdateHosts";
            // Create new graphql operation bulkUpdateOracleHosts
            InitMutationBulkUpdateOracleHosts();
        }

        // This parameter set invokes a single graphql operation:
        // refreshOracleDatabase.
        internal void ProcessRecord_RefreshDatabase()
        {
            this._logger.name += " -RefreshDatabase";
            // Create new graphql operation refreshOracleDatabase
            InitMutationRefreshOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // updateOracleDataGuardGroup.
        internal void ProcessRecord_UpdateDataGuardGroup()
        {
            this._logger.name += " -UpdateDataGuardGroup";
            // Create new graphql operation updateOracleDataGuardGroup
            InitMutationUpdateOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAllOracleDatabaseSnapshots.
        internal void ProcessRecord_DeleteAllDatabaseSnapshots()
        {
            this._logger.name += " -DeleteAllDatabaseSnapshots";
            // Create new graphql operation deleteAllOracleDatabaseSnapshots
            InitMutationDeleteAllOracleDatabaseSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleDatabaseSnapshot.
        internal void ProcessRecord_TakeOnDemandDatabaseSnapshot()
        {
            this._logger.name += " -TakeOnDemandDatabaseSnapshot";
            // Create new graphql operation takeOnDemandOracleDatabaseSnapshot
            InitMutationTakeOnDemandOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // takeOnDemandOracleLogSnapshot.
        internal void ProcessRecord_TakeOnDemandLogSnapshot()
        {
            this._logger.name += " -TakeOnDemandLogSnapshot";
            // Create new graphql operation takeOnDemandOracleLogSnapshot
            InitMutationTakeOnDemandOracleLogSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleRacs.
        internal void ProcessRecord_BulkUpdateRacs()
        {
            this._logger.name += " -BulkUpdateRacs";
            // Create new graphql operation bulkUpdateOracleRacs
            InitMutationBulkUpdateOracleRacs();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleTablespace.
        internal void ProcessRecord_ExportTablespace()
        {
            this._logger.name += " -ExportTablespace";
            // Create new graphql operation exportOracleTablespace
            InitMutationExportOracleTablespace();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleAcoFile.
        internal void ProcessRecord_ValidateAcoFile()
        {
            this._logger.name += " -ValidateAcoFile";
            // Create new graphql operation validateOracleAcoFile
            InitMutationValidateOracleAcoFile();
        }

        // This parameter set invokes a single graphql operation:
        // validateOracleDatabaseBackups.
        internal void ProcessRecord_ValidateDatabaseBackups()
        {
            this._logger.name += " -ValidateDatabaseBackups";
            // Create new graphql operation validateOracleDatabaseBackups
            InitMutationValidateOracleDatabaseBackups();
        }

        // This parameter set invokes a single graphql operation:
        // bulkUpdateOracleDatabases.
        internal void ProcessRecord_BulkUpdateDatabases()
        {
            this._logger.name += " -BulkUpdateDatabases";
            // Create new graphql operation bulkUpdateOracleDatabases
            InitMutationBulkUpdateOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // instantRecoverOracleSnapshot.
        internal void ProcessRecord_InstantRecoverSnapshot()
        {
            this._logger.name += " -InstantRecoverSnapshot";
            // Create new graphql operation instantRecoverOracleSnapshot
            InitMutationInstantRecoverOracleSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // mountOracleDatabase.
        internal void ProcessRecord_MountDatabase()
        {
            this._logger.name += " -MountDatabase";
            // Create new graphql operation mountOracleDatabase
            InitMutationMountOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // exportOracleDatabase.
        internal void ProcessRecord_ExportDatabase()
        {
            this._logger.name += " -ExportDatabase";
            // Create new graphql operation exportOracleDatabase
            InitMutationExportOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // createOraclePdbRestore.
        internal void ProcessRecord_CreatePdbRestore()
        {
            this._logger.name += " -CreatePdbRestore";
            // Create new graphql operation createOraclePdbRestore
            InitMutationCreateOraclePdbRestore();
        }

        // This parameter set invokes a single graphql operation:
        // downloadOracleDatabaseSnapshot.
        internal void ProcessRecord_DownloadDatabaseSnapshot()
        {
            this._logger.name += " -DownloadDatabaseSnapshot";
            // Create new graphql operation downloadOracleDatabaseSnapshot
            InitMutationDownloadOracleDatabaseSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // deleteOracleMount.
        internal void ProcessRecord_DeleteMount()
        {
            this._logger.name += " -DeleteMount";
            // Create new graphql operation deleteOracleMount
            InitMutationDeleteOracleMount();
        }

        // This parameter set invokes a single graphql operation:
        // restoreOracleLogs.
        internal void ProcessRecord_RestoreLogs()
        {
            this._logger.name += " -RestoreLogs";
            // Create new graphql operation restoreOracleLogs
            InitMutationRestoreOracleLogs();
        }


        // Create new GraphQL Mutation:
        // bulkUpdateOracleHosts(input: BulkUpdateOracleHostsInput!): BulkUpdateOracleHostsReply!
        internal void InitMutationBulkUpdateOracleHosts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleHostsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleHosts",
                "($input: BulkUpdateOracleHostsInput!)",
                "BulkUpdateOracleHostsReply",
                Mutation.BulkUpdateOracleHosts_ObjectFieldSpec,
                Mutation.BulkUpdateOracleHostsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			configuredSlaDomainIdDeprecated = <System.String>
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = <System.String>
					# REQUIRED
					order = <System.Int32>
				}
			)
			# OPTIONAL
			shouldDistributeBackupsAutomatically = <System.Boolean>
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = <System.Int32>
				# OPTIONAL
				hostMount = <System.String>
				# OPTIONAL
				logBackupFrequencyInMinutes = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				numChannels = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				shouldEnableHighFileCountSupport = <System.Boolean>
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = <System.Boolean>
				# OPTIONAL
				sectionSizeInGb = <System.Int32>
			}
		}
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // refreshOracleDatabase(input: RefreshOracleDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationRefreshOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RefreshOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRefreshOracleDatabase",
                "($input: RefreshOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.RefreshOracleDatabase_ObjectFieldSpec,
                Mutation.RefreshOracleDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateOracleDataGuardGroup(input: UpdateOracleDataGuardGroupInput!): OracleDbDetail!
        internal void InitMutationUpdateOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateOracleDataGuardGroupInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateOracleDataGuardGroup",
                "($input: UpdateOracleDataGuardGroupInput!)",
                "OracleDbDetail",
                Mutation.UpdateOracleDataGuardGroup_ObjectFieldSpec,
                Mutation.UpdateOracleDataGuardGroupFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		preferredDgMemberUniqueNames = @(
			<System.String>
		)
		# OPTIONAL
		shouldBackupFromPrimaryOnly = <System.Boolean>
		# OPTIONAL
		oracleUpdateCommon = @{
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hasLogConfigFromSla = <System.Boolean>
			# OPTIONAL
			shouldEnableHighFileCountSupport = <System.Boolean>
			# OPTIONAL
			shouldUseSecureThriftForDataTransfer = <System.Boolean>
			# OPTIONAL
			sectionSizeInGb = <System.Int32>
		}
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteAllOracleDatabaseSnapshots(input: DeleteAllOracleDatabaseSnapshotsInput!): Void
        internal void InitMutationDeleteAllOracleDatabaseSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAllOracleDatabaseSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteAllOracleDatabaseSnapshots",
                "($input: DeleteAllOracleDatabaseSnapshotsInput!)",
                "System.String",
                Mutation.DeleteAllOracleDatabaseSnapshots_ObjectFieldSpec,
                Mutation.DeleteAllOracleDatabaseSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeOnDemandOracleDatabaseSnapshot(input: TakeOnDemandOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationTakeOnDemandOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandOracleDatabaseSnapshot",
                "($input: TakeOnDemandOracleDatabaseSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeOnDemandOracleDatabaseSnapshot_ObjectFieldSpec,
                Mutation.TakeOnDemandOracleDatabaseSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // takeOnDemandOracleLogSnapshot(input: TakeOnDemandOracleLogSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationTakeOnDemandOracleLogSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "TakeOnDemandOracleLogSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationTakeOnDemandOracleLogSnapshot",
                "($input: TakeOnDemandOracleLogSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.TakeOnDemandOracleLogSnapshot_ObjectFieldSpec,
                Mutation.TakeOnDemandOracleLogSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateOracleRacs(input: BulkUpdateOracleRacsInput!): BulkUpdateOracleRacsReply!
        internal void InitMutationBulkUpdateOracleRacs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleRacsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleRacs",
                "($input: BulkUpdateOracleRacsInput!)",
                "BulkUpdateOracleRacsReply",
                Mutation.BulkUpdateOracleRacs_ObjectFieldSpec,
                Mutation.BulkUpdateOracleRacsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			configuredSlaDomainIdDeprecated = <System.String>
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = <System.String>
					# REQUIRED
					order = <System.Int32>
				}
			)
			# OPTIONAL
			shouldDistributeBackupsAutomatically = <System.Boolean>
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = <System.Int32>
				# OPTIONAL
				hostMount = <System.String>
				# OPTIONAL
				logBackupFrequencyInMinutes = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				numChannels = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				shouldEnableHighFileCountSupport = <System.Boolean>
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = <System.Boolean>
				# OPTIONAL
				sectionSizeInGb = <System.Int32>
			}
		}
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportOracleTablespace(input: ExportOracleTablespaceInput!): AsyncRequestStatus!
        internal void InitMutationExportOracleTablespace()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleTablespaceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportOracleTablespace",
                "($input: ExportOracleTablespaceInput!)",
                "AsyncRequestStatus",
                Mutation.ExportOracleTablespace_ObjectFieldSpec,
                Mutation.ExportOracleTablespaceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		exposeAllLogs = <System.Boolean>
		# REQUIRED
		auxiliaryDestinationPath = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
		# REQUIRED
		tablespaceName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateOracleAcoFile(input: ValidateOracleAcoFileInput!): ValidateOracleAcoFileReply!
        internal void InitMutationValidateOracleAcoFile()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleAcoFileInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateOracleAcoFile",
                "($input: ValidateOracleAcoFileInput!)",
                "ValidateOracleAcoFileReply",
                Mutation.ValidateOracleAcoFile_ObjectFieldSpec,
                Mutation.ValidateOracleAcoFileFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	acoContentsBase64 = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	isLiveMount = <System.Boolean>
	# REQUIRED
	dbId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // validateOracleDatabaseBackups(input: ValidateOracleDatabaseBackupsInput!): AsyncRequestStatus!
        internal void InitMutationValidateOracleDatabaseBackups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ValidateOracleDatabaseBackupsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationValidateOracleDatabaseBackups",
                "($input: ValidateOracleDatabaseBackupsInput!)",
                "AsyncRequestStatus",
                Mutation.ValidateOracleDatabaseBackups_ObjectFieldSpec,
                Mutation.ValidateOracleDatabaseBackupsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		numChannels = <System.Int32>
		# OPTIONAL
		sgaMaxSizeInMb = <System.Int64>
		# OPTIONAL
		targetMountPath = <System.String>
		# OPTIONAL
		targetOracleHome = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
		# REQUIRED
		targetOracleHostOrRacId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // bulkUpdateOracleDatabases(input: BulkUpdateOracleDatabasesInput!): BulkUpdateOracleDatabasesReply!
        internal void InitMutationBulkUpdateOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkUpdateOracleDatabasesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationBulkUpdateOracleDatabases",
                "($input: BulkUpdateOracleDatabasesInput!)",
                "BulkUpdateOracleDatabasesReply",
                Mutation.BulkUpdateOracleDatabases_ObjectFieldSpec,
                Mutation.BulkUpdateOracleDatabasesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			configuredSlaDomainIdDeprecated = <System.String>
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = <System.String>
					# REQUIRED
					order = <System.Int32>
				}
			)
			# OPTIONAL
			shouldDistributeBackupsAutomatically = <System.Boolean>
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = <System.Int32>
				# OPTIONAL
				hostMount = <System.String>
				# OPTIONAL
				logBackupFrequencyInMinutes = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				numChannels = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				shouldEnableHighFileCountSupport = <System.Boolean>
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = <System.Boolean>
				# OPTIONAL
				sectionSizeInGb = <System.Int32>
			}
		}
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // instantRecoverOracleSnapshot(input: InstantRecoverOracleSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationInstantRecoverOracleSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "InstantRecoverOracleSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationInstantRecoverOracleSnapshot",
                "($input: InstantRecoverOracleSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.InstantRecoverOracleSnapshot_ObjectFieldSpec,
                Mutation.InstantRecoverOracleSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		numChannels = <System.Int32>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // mountOracleDatabase(input: MountOracleDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationMountOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MountOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMountOracleDatabase",
                "($input: MountOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.MountOracleDatabase_ObjectFieldSpec,
                Mutation.MountOracleDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			shouldMountFilesOnly = <System.Boolean>
			# OPTIONAL
			targetMountPath = <System.String>
			# OPTIONAL
			advancedRecoveryConfigBase64 = <System.String>
			# OPTIONAL
			customPfilePath = <System.String>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			postScriptPath = <System.String>
			# OPTIONAL
			preScriptPath = <System.String>
			# OPTIONAL
			shouldStopRecoveryOnPreScriptFailure = <System.Boolean>
			# OPTIONAL
			pdbsToLiveMount = @(
				<System.String>
			)
			# OPTIONAL
			targetRacHostIds = @(
				<System.String>
			)
			# OPTIONAL
			lmDbName = <System.String>
			# OPTIONAL
			targetRacPrimaryHostId = <System.String>
			# OPTIONAL
			shouldAllowRenameToSource = <System.Boolean>
			# REQUIRED
			recoveryPoint = @{
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				timestampMs = <System.Int64>
			}
			# REQUIRED
			targetOracleHostOrRacId = <System.String>
		}
		# REQUIRED
		id = <System.String>
	}
	# OPTIONAL
	advancedRecoveryConfigMap = @(
		@{
			# OPTIONAL
			key = <System.String>
			# OPTIONAL
			value = <System.String>
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportOracleDatabase(input: ExportOracleDatabaseInput!): AsyncRequestStatus!
        internal void InitMutationExportOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportOracleDatabaseInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportOracleDatabase",
                "($input: ExportOracleDatabaseInput!)",
                "AsyncRequestStatus",
                Mutation.ExportOracleDatabase_ObjectFieldSpec,
                Mutation.ExportOracleDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			restoreFilesPath = <System.String>
			# OPTIONAL
			shouldRestoreFilesOnly = <System.Boolean>
			# OPTIONAL
			targetMountPath = <System.String>
			# OPTIONAL
			advancedRecoveryConfigBase64 = <System.String>
			# OPTIONAL
			archiveLogPath = <System.String>
			# OPTIONAL
			cloneDbName = <System.String>
			# OPTIONAL
			customPfilePath = <System.String>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			postScriptPath = <System.String>
			# OPTIONAL
			preScriptPath = <System.String>
			# OPTIONAL
			shouldStopRecoveryOnPreScriptFailure = <System.Boolean>
			# OPTIONAL
			pdbsToClone = @(
				<System.String>
			)
			# OPTIONAL
			shouldSkipDropDbInUndo = <System.Boolean>
			# OPTIONAL
			shouldAllowRenameToSource = <System.Boolean>
			# REQUIRED
			recoveryPoint = @{
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				timestampMs = <System.Int64>
			}
			# REQUIRED
			targetOracleHostOrRacId = <System.String>
		}
		# REQUIRED
		id = <System.String>
	}
	# OPTIONAL
	advancedRecoveryConfigMap = @(
		@{
			# OPTIONAL
			key = <System.String>
			# OPTIONAL
			value = <System.String>
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // createOraclePdbRestore(input: CreateOraclePdbRestoreInput!): AsyncRequestStatus!
        internal void InitMutationCreateOraclePdbRestore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateOraclePdbRestoreInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateOraclePdbRestore",
                "($input: CreateOraclePdbRestoreInput!)",
                "AsyncRequestStatus",
                Mutation.CreateOraclePdbRestore_ObjectFieldSpec,
                Mutation.CreateOraclePdbRestoreFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		pdbsToRestore = @(
			<System.String>
		)
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // downloadOracleDatabaseSnapshot(input: DownloadOracleDatabaseSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationDownloadOracleDatabaseSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DownloadOracleDatabaseSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDownloadOracleDatabaseSnapshot",
                "($input: DownloadOracleDatabaseSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.DownloadOracleDatabaseSnapshot_ObjectFieldSpec,
                Mutation.DownloadOracleDatabaseSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteOracleMount(input: DeleteOracleMountInput!): AsyncRequestStatus!
        internal void InitMutationDeleteOracleMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteOracleMountInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteOracleMount",
                "($input: DeleteOracleMountInput!)",
                "AsyncRequestStatus",
                Mutation.DeleteOracleMount_ObjectFieldSpec,
                Mutation.DeleteOracleMountFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // restoreOracleLogs(input: RestoreOracleLogsInput!): AsyncRequestStatus!
        internal void InitMutationRestoreOracleLogs()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "RestoreOracleLogsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationRestoreOracleLogs",
                "($input: RestoreOracleLogsInput!)",
                "AsyncRequestStatus",
                Mutation.RestoreOracleLogs_ObjectFieldSpec,
                Mutation.RestoreOracleLogsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetMountPath = <System.String>
		# REQUIRED
		oracleLogRecoveryRange = @{
			# OPTIONAL
			oracleTimeRange = @{
				# OPTIONAL
				endTime = <DateTime>
				# OPTIONAL
				startTime = <DateTime>
			}
		}
		# REQUIRED
		shouldMountFilesOnly = <System.Boolean>
		# REQUIRED
		targetOracleHostOrRacId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}"
            );
        }


    } // class New_RscMutationOracle
}