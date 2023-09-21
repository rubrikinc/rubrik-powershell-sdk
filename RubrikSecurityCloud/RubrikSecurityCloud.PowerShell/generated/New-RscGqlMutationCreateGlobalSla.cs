// New-RscGqlMutationCreateGlobalSla.cs
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
    /// Create new GraphQL Mutation createGlobalSla
    /// createGlobalSla(input: CreateGlobalSlaInput!): GlobalSlaReply!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationCreateGlobalSla")
    ]
    public class New_RscGqlMutationCreateGlobalSla : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("createGlobalSla");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation createGlobalSla
        /// createGlobalSla(input: CreateGlobalSlaInput!): GlobalSlaReply!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_createGlobalSla();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_createGlobalSla()
        {
            this._logger.name += " -createGlobalSla";
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

    } // class New-RscGqlMutationCreateGlobalSla
}