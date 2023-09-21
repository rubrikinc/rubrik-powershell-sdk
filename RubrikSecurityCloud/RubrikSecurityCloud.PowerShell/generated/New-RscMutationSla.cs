// New-RscMutationSla.cs
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
    /// Mutations for the 'SLA' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationSla is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationSla -CreateGlobal [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -UpdateGlobal [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -Assign [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -AssignsForSnappableHierarchies [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -AssignRetentionToSnappables [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -AssignRetentionToSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -Pause [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -GetPendingAssignments [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscMutationSla -ExportManagedVolumeSnapshot [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationSla",
        DefaultParameterSetName = "Pause")
    ]
    public class New_RscMutationSla : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// CreateGlobal parameter set
        ///
        /// [GraphQL: createGlobalSla]
        /// </summary>
        [Parameter(
            ParameterSetName = "CreateGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create SLA Domain.
[GraphQL: createGlobalSla]",
            Position = 0
        )]
        public SwitchParameter CreateGlobal { get; set; }

        
        /// <summary>
        /// UpdateGlobal parameter set
        ///
        /// [GraphQL: updateGlobalSla]
        /// </summary>
        [Parameter(
            ParameterSetName = "UpdateGlobal",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Update SLA Domain.
[GraphQL: updateGlobalSla]",
            Position = 0
        )]
        public SwitchParameter UpdateGlobal { get; set; }

        
        /// <summary>
        /// Assign parameter set
        ///
        /// [GraphQL: assignSla]
        /// </summary>
        [Parameter(
            ParameterSetName = "Assign",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Endpoint to assign SLA Domain.
[GraphQL: assignSla]",
            Position = 0
        )]
        public SwitchParameter Assign { get; set; }

        
        /// <summary>
        /// AssignsForSnappableHierarchies parameter set
        ///
        /// [GraphQL: assignSlasForSnappableHierarchies]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignsForSnappableHierarchies",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Assign SLA Domain to workloads with multiple hierarchies.
[GraphQL: assignSlasForSnappableHierarchies]",
            Position = 0
        )]
        public SwitchParameter AssignsForSnappableHierarchies { get; set; }

        
        /// <summary>
        /// AssignRetentionToSnappables parameter set
        ///
        /// [GraphQL: assignRetentionSLAToSnappables]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignRetentionToSnappables",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Endpoint to assign retention SLA Domain to workloads.
[GraphQL: assignRetentionSLAToSnappables]",
            Position = 0
        )]
        public SwitchParameter AssignRetentionToSnappables { get; set; }

        
        /// <summary>
        /// AssignRetentionToSnapshots parameter set
        ///
        /// [GraphQL: assignRetentionSLAToSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "AssignRetentionToSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Endpoint to assign retention SLA Domain to snapshots.
[GraphQL: assignRetentionSLAToSnapshots]",
            Position = 0
        )]
        public SwitchParameter AssignRetentionToSnapshots { get; set; }

        
        /// <summary>
        /// Pause parameter set
        ///
        /// [GraphQL: pauseSla]
        /// </summary>
        [Parameter(
            ParameterSetName = "Pause",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Pause or resume SLA Domain on the given Rubrik clusters.
[GraphQL: pauseSla]",
            Position = 0
        )]
        public SwitchParameter Pause { get; set; }

        
        /// <summary>
        /// GetPendingAssignments parameter set
        ///
        /// [GraphQL: getPendingSlaAssignments]
        /// </summary>
        [Parameter(
            ParameterSetName = "GetPendingAssignments",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get pending SLA Domain assignments on selected managed objects

Supported in v5.2+
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs.
[GraphQL: getPendingSlaAssignments]",
            Position = 0
        )]
        public SwitchParameter GetPendingAssignments { get; set; }

        
        /// <summary>
        /// ExportManagedVolumeSnapshot parameter set
        ///
        /// [GraphQL: exportSlaManagedVolumeSnapshot]
        /// </summary>
        [Parameter(
            ParameterSetName = "ExportManagedVolumeSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Create a request to export a snapshot and mount it on a host

Supported in v5.3+
Export a managed volume snapshot as a share and mount it on a given host.
[GraphQL: exportSlaManagedVolumeSnapshot]",
            Position = 0
        )]
        public SwitchParameter ExportManagedVolumeSnapshot { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "CreateGlobal":
                        this.ProcessRecord_CreateGlobal();
                        break;
                    case "UpdateGlobal":
                        this.ProcessRecord_UpdateGlobal();
                        break;
                    case "Assign":
                        this.ProcessRecord_Assign();
                        break;
                    case "AssignsForSnappableHierarchies":
                        this.ProcessRecord_AssignsForSnappableHierarchies();
                        break;
                    case "AssignRetentionToSnappables":
                        this.ProcessRecord_AssignRetentionToSnappables();
                        break;
                    case "AssignRetentionToSnapshots":
                        this.ProcessRecord_AssignRetentionToSnapshots();
                        break;
                    case "Pause":
                        this.ProcessRecord_Pause();
                        break;
                    case "GetPendingAssignments":
                        this.ProcessRecord_GetPendingAssignments();
                        break;
                    case "ExportManagedVolumeSnapshot":
                        this.ProcessRecord_ExportManagedVolumeSnapshot();
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
        // createGlobalSla.
        internal void ProcessRecord_CreateGlobal()
        {
            this._logger.name += " -CreateGlobal";
            // Create new graphql operation createGlobalSla
            InitMutationCreateGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // updateGlobalSla.
        internal void ProcessRecord_UpdateGlobal()
        {
            this._logger.name += " -UpdateGlobal";
            // Create new graphql operation updateGlobalSla
            InitMutationUpdateGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // assignSla.
        internal void ProcessRecord_Assign()
        {
            this._logger.name += " -Assign";
            // Create new graphql operation assignSla
            InitMutationAssignSla();
        }

        // This parameter set invokes a single graphql operation:
        // assignSlasForSnappableHierarchies.
        internal void ProcessRecord_AssignsForSnappableHierarchies()
        {
            this._logger.name += " -AssignsForSnappableHierarchies";
            // Create new graphql operation assignSlasForSnappableHierarchies
            InitMutationAssignSlasForSnappableHierarchies();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnappables.
        internal void ProcessRecord_AssignRetentionToSnappables()
        {
            this._logger.name += " -AssignRetentionToSnappables";
            // Create new graphql operation assignRetentionSLAToSnappables
            InitMutationAssignRetentionSlaToSnappables();
        }

        // This parameter set invokes a single graphql operation:
        // assignRetentionSLAToSnapshots.
        internal void ProcessRecord_AssignRetentionToSnapshots()
        {
            this._logger.name += " -AssignRetentionToSnapshots";
            // Create new graphql operation assignRetentionSLAToSnapshots
            InitMutationAssignRetentionSlaToSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // pauseSla.
        internal void ProcessRecord_Pause()
        {
            this._logger.name += " -Pause";
            // Create new graphql operation pauseSla
            InitMutationPauseSla();
        }

        // This parameter set invokes a single graphql operation:
        // getPendingSlaAssignments.
        internal void ProcessRecord_GetPendingAssignments()
        {
            this._logger.name += " -GetPendingAssignments";
            // Create new graphql operation getPendingSlaAssignments
            InitMutationGetPendingSlaAssignments();
        }

        // This parameter set invokes a single graphql operation:
        // exportSlaManagedVolumeSnapshot.
        internal void ProcessRecord_ExportManagedVolumeSnapshot()
        {
            this._logger.name += " -ExportManagedVolumeSnapshot";
            // Create new graphql operation exportSlaManagedVolumeSnapshot
            InitMutationExportSlaManagedVolumeSnapshot();
        }


        // Create new GraphQL Mutation:
        // createGlobalSla(input: CreateGlobalSlaInput!): GlobalSlaReply!
        internal void InitMutationCreateGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateGlobalSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCreateGlobalSla",
                "($input: CreateGlobalSlaInput!)",
                "GlobalSlaReply",
                Mutation.CreateGlobalSla_ObjectFieldSpec,
                Mutation.CreateGlobalSlaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = <DayOfMonth> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = <DayOfQuarter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = <DayOfYear> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	replicationSpecInput = @{
		# OPTIONAL
		replicationType = <ReplicationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
		# OPTIONAL
		specificReplicationSpecInput = @{
			# OPTIONAL
			unidirectionalSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			bidirectionalSpecInput = @{
				# OPTIONAL
				replicationSpec1 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				replicationSpec2 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
			# OPTIONAL
			cloudRegionSpecInput = @{
				# OPTIONAL
				replicationTargetRegion = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cloudLocationSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retentionDuration = @{
					# OPTIONAL
					duration = <System.Int32>
					# OPTIONAL
					unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
	}
	# OPTIONAL
	localRetentionLimit = @{
		# OPTIONAL
		duration = <System.Int32>
		# OPTIONAL
		unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	}
	# OPTIONAL
	firstFullBackupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	backupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	logConfig = @{
		# OPTIONAL
		slaLogFrequencyConfig = @{
			# OPTIONAL
			retention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	objectSpecificConfigsInput = @{
		# OPTIONAL
		sapHanaConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		awsRdsConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		vmwareVmConfigInput = @{
			# OPTIONAL
			logRetentionSeconds = <System.Int64>
		}
		# OPTIONAL
		azureSqlDatabaseDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		azureSqlManagedInstanceDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		db2ConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mssqlConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		oracleConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			hostLogRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mongoConfigInput = @{
			# OPTIONAL
			logFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		azureBlobConfigInput = @{
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		awsNativeS3SlaConfigInput = @{
			# OPTIONAL
			archivalLocationId = <System.String>
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		managedVolumeSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	archivalSpecs = @(
		@{
			# OPTIONAL
			archivalGroupId = <System.String>
			# OPTIONAL
			threshold = <System.Int32>
			# OPTIONAL
			thresholdUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			# OPTIONAL
			archivalTieringSpecInput = @{
				# OPTIONAL
				isInstantTieringEnabled = <System.Boolean>
				# OPTIONAL
				minAccessibleDurationInSeconds = <System.Int64>
				# OPTIONAL
				coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
				# OPTIONAL
				shouldTierExistingSnapshots = <System.Boolean>
			}
			# OPTIONAL
			frequencies = @(
				<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			)
			# OPTIONAL
			archivalLocationToClusterMapping = @(
				@{
					# OPTIONAL
					clusterUuid = <System.String>
					# OPTIONAL
					locationId = <System.String>
				}
			)
		}
	)
	# OPTIONAL
	replicationSpecsV2 = @(
		@{
			# OPTIONAL
			clusterUuid = <System.String>
			# OPTIONAL
			storageSettingId = <System.String>
			# OPTIONAL
			retentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			awsAccount = <System.String>
			# OPTIONAL
			azureSubscription = <System.String>
			# OPTIONAL
			replicationLocalRetentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cascadingArchivalSpecs = @(
				@{
					# OPTIONAL
					archivalLocationId = <System.String>
					# OPTIONAL
					archivalThreshold = @{
						# OPTIONAL
						duration = <System.Int32>
						# OPTIONAL
						unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					}
					# OPTIONAL
					archivalTieringSpecInput = @{
						# OPTIONAL
						isInstantTieringEnabled = <System.Boolean>
						# OPTIONAL
						minAccessibleDurationInSeconds = <System.Int64>
						# OPTIONAL
						coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
						# OPTIONAL
						shouldTierExistingSnapshots = <System.Boolean>
					}
					# OPTIONAL
					frequency = @(
						<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					)
				}
			)
			# OPTIONAL
			awsRegion = <AwsNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
			# OPTIONAL
			azureRegion = <AzureNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
		}
	)
	# OPTIONAL
	objectTypes = @(
		<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
	)
	# OPTIONAL
	isRetentionLockedSla = <System.Boolean>
	# OPTIONAL
	retentionLockMode = <RetentionLockMode> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionLockMode]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateGlobalSla(input: UpdateGlobalSlaInput!): GlobalSlaReply!
        internal void InitMutationUpdateGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGlobalSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateGlobalSla",
                "($input: UpdateGlobalSlaInput!)",
                "GlobalSlaReply",
                Mutation.UpdateGlobalSla_ObjectFieldSpec,
                Mutation.UpdateGlobalSlaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = <DayOfMonth> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = <DayOfQuarter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = <DayOfYear> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	stateVersion = <System.Int64>
	# OPTIONAL
	replicationSpecInput = @{
		# OPTIONAL
		replicationType = <ReplicationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
		# OPTIONAL
		specificReplicationSpecInput = @{
			# OPTIONAL
			unidirectionalSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			bidirectionalSpecInput = @{
				# OPTIONAL
				replicationSpec1 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				replicationSpec2 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
			# OPTIONAL
			cloudRegionSpecInput = @{
				# OPTIONAL
				replicationTargetRegion = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cloudLocationSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retentionDuration = @{
					# OPTIONAL
					duration = <System.Int32>
					# OPTIONAL
					unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
	}
	# OPTIONAL
	localRetentionLimit = @{
		# OPTIONAL
		duration = <System.Int32>
		# OPTIONAL
		unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	}
	# OPTIONAL
	firstFullBackupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	backupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	logConfig = @{
		# OPTIONAL
		slaLogFrequencyConfig = @{
			# OPTIONAL
			retention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	objectSpecificConfigsInput = @{
		# OPTIONAL
		sapHanaConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		awsRdsConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		vmwareVmConfigInput = @{
			# OPTIONAL
			logRetentionSeconds = <System.Int64>
		}
		# OPTIONAL
		azureSqlDatabaseDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		azureSqlManagedInstanceDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		db2ConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mssqlConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		oracleConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			hostLogRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mongoConfigInput = @{
			# OPTIONAL
			logFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		azureBlobConfigInput = @{
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		awsNativeS3SlaConfigInput = @{
			# OPTIONAL
			archivalLocationId = <System.String>
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		managedVolumeSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	shouldApplyToExistingSnapshots = @{
		# OPTIONAL
		value = <System.Boolean>
	}
	# OPTIONAL
	shouldApplyToNonPolicySnapshots = @{
		# OPTIONAL
		value = <System.Boolean>
	}
	# OPTIONAL
	userNote = <System.String>
	# OPTIONAL
	archivalSpecs = @(
		@{
			# OPTIONAL
			archivalGroupId = <System.String>
			# OPTIONAL
			threshold = <System.Int32>
			# OPTIONAL
			thresholdUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			# OPTIONAL
			archivalTieringSpecInput = @{
				# OPTIONAL
				isInstantTieringEnabled = <System.Boolean>
				# OPTIONAL
				minAccessibleDurationInSeconds = <System.Int64>
				# OPTIONAL
				coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
				# OPTIONAL
				shouldTierExistingSnapshots = <System.Boolean>
			}
			# OPTIONAL
			frequencies = @(
				<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			)
			# OPTIONAL
			archivalLocationToClusterMapping = @(
				@{
					# OPTIONAL
					clusterUuid = <System.String>
					# OPTIONAL
					locationId = <System.String>
				}
			)
		}
	)
	# OPTIONAL
	replicationSpecsV2 = @(
		@{
			# OPTIONAL
			clusterUuid = <System.String>
			# OPTIONAL
			storageSettingId = <System.String>
			# OPTIONAL
			retentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			awsAccount = <System.String>
			# OPTIONAL
			azureSubscription = <System.String>
			# OPTIONAL
			replicationLocalRetentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cascadingArchivalSpecs = @(
				@{
					# OPTIONAL
					archivalLocationId = <System.String>
					# OPTIONAL
					archivalThreshold = @{
						# OPTIONAL
						duration = <System.Int32>
						# OPTIONAL
						unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					}
					# OPTIONAL
					archivalTieringSpecInput = @{
						# OPTIONAL
						isInstantTieringEnabled = <System.Boolean>
						# OPTIONAL
						minAccessibleDurationInSeconds = <System.Int64>
						# OPTIONAL
						coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
						# OPTIONAL
						shouldTierExistingSnapshots = <System.Boolean>
					}
					# OPTIONAL
					frequency = @(
						<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					)
				}
			)
			# OPTIONAL
			awsRegion = <AwsNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
			# OPTIONAL
			azureRegion = <AzureNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
		}
	)
	# OPTIONAL
	objectTypes = @(
		<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
	)
	# OPTIONAL
	isRetentionLockedSla = <System.Boolean>
	# OPTIONAL
	retentionLockMode = <RetentionLockMode> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionLockMode]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // assignSla(input: AssignSlaInput!): SlaAssignResult!
        internal void InitMutationAssignSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AssignSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSla",
                "($input: AssignSlaInput!)",
                "SlaAssignResult",
                Mutation.AssignSla_ObjectFieldSpec,
                Mutation.AssignSlaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	slaDomainAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
	# OPTIONAL
	slaOptionalId = <System.String>
	# REQUIRED
	objectIds = @(
		<System.String>
	)
	# OPTIONAL
	applicableWorkloadType = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
	# OPTIONAL
	shouldApplyToExistingSnapshots = <System.Boolean>
	# OPTIONAL
	shouldApplyToNonPolicySnapshots = <System.Boolean>
	# OPTIONAL
	existingSnapshotRetention = <GlobalExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
	# OPTIONAL
	userNote = <System.String>
}"
            );
        }

        // Create new GraphQL Mutation:
        // assignSlasForSnappableHierarchies(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     objectIds: [UUID!]!
        //     applicableSnappableTypes: [WorkloadLevelHierarchy!]
        //     shouldApplyToExistingSnapshots: Boolean
        //     shouldApplyToNonPolicySnapshots: Boolean
        //     globalExistingSnapshotRetention: GlobalExistingSnapshotRetention
        //     userNote: String
        //   ): [SlaAssignResult!]!
        internal void InitMutationAssignSlasForSnappableHierarchies()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("shouldApplyToExistingSnapshots", "Boolean"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("globalExistingSnapshotRetention", "GlobalExistingSnapshotRetention"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignSlasForSnappableHierarchies",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!],$shouldApplyToExistingSnapshots: Boolean,$shouldApplyToNonPolicySnapshots: Boolean,$globalExistingSnapshotRetention: GlobalExistingSnapshotRetention,$userNote: String)",
                "List<SlaAssignResult>",
                Mutation.AssignSlasForSnappableHierarchies_ObjectFieldSpec,
                Mutation.AssignSlasForSnappableHierarchiesFieldSpec,
                @"# OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$inputs.Var.shouldApplyToExistingSnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldApplyToNonPolicySnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.globalExistingSnapshotRetention = <GlobalExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
# OPTIONAL
$inputs.Var.userNote = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // assignRetentionSLAToSnappables(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     objectIds: [UUID!]!
        //     applicableSnappableType: WorkloadLevelHierarchy
        //     shouldApplyToNonPolicySnapshots: Boolean
        //     userNote: String
        //   ): SlaAssignResult!
        internal void InitMutationAssignRetentionSlaToSnappables()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableType", "WorkloadLevelHierarchy"),
                Tuple.Create("shouldApplyToNonPolicySnapshots", "Boolean"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignRetentionSlaToSnappables",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$objectIds: [UUID!]!,$applicableSnappableType: WorkloadLevelHierarchy,$shouldApplyToNonPolicySnapshots: Boolean,$userNote: String)",
                "SlaAssignResult",
                Mutation.AssignRetentionSlaToSnappables_ObjectFieldSpec,
                Mutation.AssignRetentionSlaToSnappablesFieldSpec,
                @"# OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableType = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$inputs.Var.shouldApplyToNonPolicySnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.userNote = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // assignRetentionSLAToSnapshots(
        //     globalSlaOptionalFid: UUID
        //     globalSlaAssignType: SlaAssignTypeEnum!
        //     snapshotFids: [UUID!]!
        //     userNote: String
        //   ): SlaAssignResult!
        internal void InitMutationAssignRetentionSlaToSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("globalSlaOptionalFid", "UUID"),
                Tuple.Create("globalSlaAssignType", "SlaAssignTypeEnum!"),
                Tuple.Create("snapshotFids", "[UUID!]!"),
                Tuple.Create("userNote", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAssignRetentionSlaToSnapshots",
                "($globalSlaOptionalFid: UUID,$globalSlaAssignType: SlaAssignTypeEnum!,$snapshotFids: [UUID!]!,$userNote: String)",
                "SlaAssignResult",
                Mutation.AssignRetentionSlaToSnapshots_ObjectFieldSpec,
                Mutation.AssignRetentionSlaToSnapshotsFieldSpec,
                @"# OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.snapshotFids = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.userNote = <System.String>"
            );
        }

        // Create new GraphQL Mutation:
        // pauseSla(input: PauseSlaInput!): PauseSlaReply!
        internal void InitMutationPauseSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "PauseSlaInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationPauseSla",
                "($input: PauseSlaInput!)",
                "PauseSlaReply",
                Mutation.PauseSla_ObjectFieldSpec,
                Mutation.PauseSlaFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	slaId = <System.String>
	# REQUIRED
	clusterUuids = @(
		<System.String>
	)
	# REQUIRED
	pauseSla = <System.Boolean>
}"
            );
        }

        // Create new GraphQL Mutation:
        // getPendingSlaAssignments(input: GetPendingSlaAssignmentsInput!): GetPendingSlaAssignmentsReply!
        internal void InitMutationGetPendingSlaAssignments()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetPendingSlaAssignmentsInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationGetPendingSlaAssignments",
                "($input: GetPendingSlaAssignmentsInput!)",
                "GetPendingSlaAssignmentsReply",
                Mutation.GetPendingSlaAssignments_ObjectFieldSpec,
                Mutation.GetPendingSlaAssignmentsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	pendingAssignmentsRequest = @{
		# REQUIRED
		objectIds = @(
			<System.String>
		)
	}
}"
            );
        }

        // Create new GraphQL Mutation:
        // exportSlaManagedVolumeSnapshot(input: ExportSlaManagedVolumeSnapshotInput!): AsyncRequestStatus!
        internal void InitMutationExportSlaManagedVolumeSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExportSlaManagedVolumeSnapshotInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationExportSlaManagedVolumeSnapshot",
                "($input: ExportSlaManagedVolumeSnapshotInput!)",
                "AsyncRequestStatus",
                Mutation.ExportSlaManagedVolumeSnapshot_ObjectFieldSpec,
                Mutation.ExportSlaManagedVolumeSnapshotFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	params = @{
		# OPTIONAL
		shouldDownloadToLocal = <System.Boolean>
		# OPTIONAL
		managedVolumeSlaExportConfig = @{
			# OPTIONAL
			managedVolumeExportConfig = @{
				# OPTIONAL
				subnet = <System.String>
				# OPTIONAL
				managedVolumePatchConfig = @{
					# OPTIONAL
					hostPatterns = @(
						<System.String>
					)
					# OPTIONAL
					nodeHint = @(
						<System.String>
					)
					# OPTIONAL
					smbDomainName = <System.String>
					# OPTIONAL
					smbValidIps = @(
						<System.String>
					)
					# OPTIONAL
					smbValidUsers = @(
						<System.String>
					)
				}
				# OPTIONAL
				shareType = <ManagedVolumeShareType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
			}
			# REQUIRED
			hostId = <System.String>
			# REQUIRED
			hostMountPaths = @(
				<System.String>
			)
		}
	}
}"
            );
        }


    } // class New_RscMutationSla
}