#Requires -Version 3
function Set-RscSla
{
    <#
    .SYNOPSIS
    Updates an existing Rubrik SLA Domain

    .DESCRIPTION
    The Set-RscSla cmdlet will update an existing SLA Domain. Rubrik SLA
    Domains are policies that define the frequency, retention, and rules for
    acrhival and replication.

    This Cmdlet offers a 'PATCH' experience over the Graphql mutation to update
    the Global SLA Domain which otherwise behaves like a 'PUT' operation. You
    only need to provide the fields that you want to update.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    The ID of the SLA Domain to update.

    .PARAMETER Name
    The new name of the SLA Domain.

    .PARAMETER Description
    The new description of the SLA Domain.

    .PARAMETER MinuteSchedule
    The new Minute Schedule of the SLA Domain.

    .PARAMETER HourlySchedule
    The new Hourly Schedule of the SLA Domain.

    .PARAMETER DailySchedule
    The new Daily Schedule of the SLA Domain.

    .PARAMETER WeeklySchedule
    The new Weekly Schedule of the SLA Domain.

    .PARAMETER MonthlySchedule
    The new Monthly Schedule of the SLA Domain.

    .PARAMETER QuarterlySchedule
    The new Quarterly Schedule of the SLA Domain.

    .PARAMETER YearlySchedule
    The new Yearly Schedule of the SLA Domain.

    .PARAMETER UserNote
    An optional note to add to the SLA Domain.

    .PARAMETER ObjectTypes
    The list of object types to which this SLA Domain applies.

    .PARAMETER LocalRetentionLimit
    Retention limit for snapshots on the local Rubrik system. If none, they will remain as long as SLA requires.

    .PARAMETER BackupWindows
    The list of backup windows for the SLA Domain.

    .PARAMETER FirstFullBackupWindows
    The list of first full backup windows for the SLA Domain.

    .PARAMETER ShouldApplyToExistingSnapshots
    Should the SLA be applied to existing snapshots.

    .PARAMETER ShouldApplyToNonPolicySnapshots
    Should the SLA be applied to non-policy snapshots.

    .PARAMETER RetentionLockSla
    Should the SLA be a retention locked SLA.

    .PARAMETER RetentionLockMode
    The retention lock mode for the intended SLA Domain update.

    .PARAMETER ArchivalSpecs
    Archival specs for this SLA.

    .PARAMETER ReplicationSpecs
    Replication specs for this SLA.

    .PARAMETER VmwareVmConfig
    VmwareVm specific settings of this SLA.

    .PARAMETER OracleConfig
    Oracle specific settings of this SLA.

    .PARAMETER SapHana
    SAP HANA specific settings of this SLA.

    .PARAMETER AwsRds
    AWS RDS specific settings of this SLA.

    .PARAMETER AzureSqlDatabaseConfig
    Azure Sql DatabaseDb specific settings of this SLA.

    .PARAMETER AzureSqlManagedInstanceConfig
    Azure Sql Managed InstanceDb specific settings of this SLA.

    .PARAMETER Db2Config
    Db2 specific settings of this SLA.

    .PARAMETER MsSqlConfig
    MS Sql specific settings of this SLA.

    .PARAMETER MongoConfig
    Mongo specific settings of this SLA.

    .PARAMETER AzureBlobConfig
    Azure Blob specific settings of this SLA.

    .PARAMETER AwsNativeS3Config
    Aws Native S3 specific settings of this SLA.

    .PARAMETER ManagedVolumeConfig
    Managed Volume specific settings of this SLA.

    .PARAMETER PostgresDbClusterConfig
    Postgres Db Cluster specific settings of this SLA.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    The example below updates the SLA Domain with the ID
    '01646285-9b5f-4b54-ae0e-c829e148453e' to have a new name, description,
    and snapshot schedule.

    A new snapshot schedule is first created using the New-RscSlaSnapshotSchedule cmdlet.

    $dailySchedule = New-RscSlaSnapshotSchedule -Type Daily -Frequency 2 -Retention 1 -RetentionUnit MONTHS
    $name = 'New SLA Domain Name'
    $description = 'New SLA Domain Description'
    Set-RscSla -ID '01646285-9b5f-4b54-ae0e-c829e148453e' -Name $name -Description $description -DailySchedule $dailySchedule

    .EXAMPLE
    A more complicated example. Here we update oracle specific config of the
    SLA along with backup window and archival specifcations of the SLA.

    $name='Name assigned via Powershell-SDK'
    $description = 'Description updated by SDK.'
    $objectTypes = @('ORACLE_OBJECT_TYPE', 'VSPHERE_OBJECT_TYPE')

    $dailySchedule = New-RscSlaSnapshotSchedule -Type Daily
    -Frequency 2 -Retention 6 -RetentionUnit DAYS

    $monthlySchedule = New-RscSlaSnapshotSchedule -Type Monthly
    -Frequency 1 -Retention 7 -RetentionUnit MONTHS

    $yearlySchedule = New-RscSlaSnapshotSchedule -Type Yearly
    -Frequency 1 -Retention 3 -RetentionUnit YEARS

    $backupWindow=New-RscSlaBackupWindow -Duration 2
    -DayOfWeek TUESDAY -Hour 1 -Minute 30

    $slaDuration = New-RscSlaDuration -Duration 10 -Unit DAYS

    $oracle = New-RscSlaObjectSpecificConfig -Oracle
    -Frequency $slaDuration -LogRetention $slaDuration

    $archivalSpec = New-RscSlaArchivalSpecs -ArchivalThreshold 230
    -Frequencies @('MONTHS','YEARS') -ArchivalThresholdUnit DAYS
    -ClusterUuids @('9c930153-2a3c-4b7d-8603-48145315e71f')
    -LocationIds @('aa137af1-6abf-59aa-984f-a9ac21301f0e')

    Set-RscSla -ID '6dd0b7ed-15b9-431b-bc15-89d539aee65e'
    -Name $name -Description $description -ObjectTypes $objectTypes
    -DailySchedule $dailySchedule -MonthlySchedule $monthlySchedule
    -YearlySchedule $yearlySchedule -BackupWindows @($backupWindow)
    -LocalRetentionLimit $slaDuration -OracleConfig $oracle
    -ArchivalSpecs @($archivalSpec) -UserNote $userNote

    .EXAMPLE
    $replicationSpec = New-RscSlaReplicationSpecs
    -ClusterUuid '33eab10e-c0d8-459d-907c-b19c6958ef76'
    -RetentionDuration (New-RscSlaDuration -Duration 12 -Unit DAYS)

    Set-RscSla -ID 'daa1807c-c766-4826-9ddb-fa3e87774a77' -Name $name
    -Description $description -ObjectTypes $objectTypes
    -HourlySchedule $hourlySchedule -WeeklySchedule $weeklySchedule
    -LocalRetentionLimit $slaDuration -ReplicationSpecs @($replicationSpec)
    #>

    [CmdletBinding()]
    Param(
        # SLA Domain Name
        [Parameter()]
        [String]$Name,

        # SLA Domain Object
        [Parameter(ValueFromPipeline=$true)]
        [ValidateNotNullOrEmpty()]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,

        # SLA Domain Description
        [Parameter()]
        [String]$Description,

        # Minute Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.MinuteSnapshotScheduleInput]$MinuteSchedule,

        # Hourly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.HourlySnapshotScheduleInput]$HourlySchedule,

        # Daily Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.DailySnapshotScheduleInput]$DailySchedule,

        # Weekly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.WeeklySnapshotScheduleInput]$WeeklySchedule,

        # Monthly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.MonthlySnapshotScheduleInput]$MonthlySchedule,

        # Quarterly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.QuarterlySnapshotScheduleInput]$QuarterlySchedule,

        # Yearly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.YearlySnapshotScheduleInput]$YearlySchedule,

        # SLA Domain object type
        [Parameter()]
        [RubrikSecurityCloud.Types.SlaObjectType[]]$ObjectTypes,

        # Local Retention Limit
        [Parameter()]
        [RubrikSecurityCloud.Types.SlaDurationInput]$LocalRetentionLimit,

        # Backup Windows
        [Parameter()]
        [RubrikSecurityCloud.Types.BackupWindowInput[]]$BackupWindows,

        # First full Backup Windows
        [Parameter()]
        [RubrikSecurityCloud.Types.BackupWindowInput[]]$FirstFullBackupWindows,

        # Should the SLA be applied to existing snapshots
        [Parameter()]
        [Switch]$ShouldApplyToExistingSnapshots,

        # Should the SLA be applied to non-policy snapshots
        [Parameter()]
        [Switch]$ShouldApplyToNonPolicySnapshots,

        # Retention Lock SLA
        [Parameter()]
        [Switch]$RetentionLockSla,

        # The retention lock mode for the intended SLA Domain update.
        [Parameter()]
        [RubrikSecurityCloud.Types.RetentionLockMode]
        $RetentionLockMode = [RubrikSecurityCloud.Types.RetentionLockMode]::NO_MODE,

        # Archival specs for this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.ArchivalSpecInput[]]$ArchivalSpecs,

        # Replication specs for this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.ReplicationSpecV2Input[]]$ReplicationSpecs,

        # VmwareVm specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.VmwareVmConfigInput]$VmwareVmConfig,

        # Oracle specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.OracleConfigInput]$OracleConfig,

        # SAP HANA specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.SapHanaConfigInput]$SapHanaConfig,

        # AWS RDS specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AwsRdsConfigInput]$AwsRdsConfig,

        # Azure Sql DatabaseDb specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AzureSqlDatabaseDbConfigInput]$AzureSqlDatabaseConfig,

        # Azure Sql Managed InstanceDb specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AzureSqlManagedInstanceDbConfigInput]$AzureSqlManagedInstanceConfig,

        # Db2 specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.Db2ConfigInput]$Db2Config,

        # MS Sql specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.MsSqlConfigInput]$MsSqlConfig,

        # MySqlDb specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.MysqldbSlaConfigInput]$MysqldbConfig,

        # Mongo specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.MongoConfigInput]$MongoConfig,

        # AzureBlob specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AzureBlobConfigInput]$AzureBlobConfig,

        # Aws Native S3 specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AwsNativeS3SlaConfigInput]$AwsNativeS3Config,

        # Managed Volume specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.ManagedVolumeSlaConfigInput]$ManagedVolumeConfig,

        # Postgres Db Cluster specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.PostgresDbClusterSlaConfigInput]$PostgresDbClusterConfig,

        # User Note
        [Parameter()]
        [String]$UserNote,

        # Should Cmdlet return the query object instead of running it
        [Parameter()]
        [Switch]$AsQuery
    )

    Process {
        # ------------------------------- Function Block Start ----------------------------------
        # Cast Duration To SlaDurationInput Type
        function CastToSlaDurationInput {
            param (
                [RubrikSecurityCloud.Types.Duration]$Duration
            )
            if ($null -eq $Duration) {
                return $null
            }
            
            $obj = New-Object -TypeName RubrikSecurityCloud.Types.SlaDurationInput
            $obj.Duration = $Duration.DurationField
            $obj.Unit = $Duration.Unit
            return $obj
        }

        # Cast BackupWindow To BackupWindowInput Type
        function CastToBackupWindowInput {
            param (
                [RubrikSecurityCloud.Types.BackupWindow]$BackupWindow
            )
            if ($null -eq $BackupWindow) {
                return $null
            }

            $BackupWindowInput = New-Object RubrikSecurityCloud.Types.BackupWindowInput
            $BackupWindowInput.DurationInHours = $BackupWindow.DurationInHours

            if ($null -ne $BackupWindow.StartTimeAttributes) {
                $StartTimeAttributesInput = New-Object RubrikSecurityCloud.Types.StartTimeAttributesInput

                if ($null -ne $BackupWindow.StartTimeAttributes.DayOfWeek) {
                    $DayOfWeekOptInput = New-Object RubrikSecurityCloud.Types.DayOfWeekOptInput
                    $DayOfWeekOptInput.day = $BackupWindow.StartTimeAttributes.DayOfWeek.day
                    $StartTimeAttributesInput.DayOfWeek = $DayOfWeekOptInput
                } else {
                    $StartTimeAttributesInput.DayOfWeek = $null
                }

                $StartTimeAttributesInput.Hour = $BackupWindow.StartTimeAttributes.Hour
                $StartTimeAttributesInput.Minute = $BackupWindow.StartTimeAttributes.Minute 
                $BackupWindowInput.StartTimeAttributes = $StartTimeAttributesInput
            } else {
                $BackupWindowInput.StartTimeAttributes = $null
            }

            return $BackupWindowInput
        }
        
        # Cast ArchivalSpec To ArchivalSpecInput Type
        function CastToArchivalSpecInput {
            param (
                [RubrikSecurityCloud.Types.ArchivalSpec]$ArchivalSpec
            )
            
            if ($null -eq $ArchivalSpec) {
                return $null
            }
        
            $ArchivalSpecInput = New-Object RubrikSecurityCloud.Types.ArchivalSpecInput
        

            # For new global SLA archival design, the archival group id is not supported in the archival 
            # spec input for data center archival.
            if ($ArchivalSpec.StorageSetting -and $ArchivalSpec.ArchivalLocationToClusterMapping.Count -eq 0 ) {
                $ArchivalSpecInput.ArchivalGroupId = [string]$ArchivalSpec.StorageSetting.Id
            } else {
                $ArchivalSpecInput.ArchivalGroupId = $null
            }

            $ArchivalSpecInput.Threshold = $ArchivalSpec.Threshold
            $ArchivalSpecInput.ThresholdUnit = $ArchivalSpec.ThresholdUnit
        
            if ($ArchivalSpec.ArchivalTieringSpec) {
                $ArchivalTieringSpecInput = New-Object RubrikSecurityCloud.Types.ArchivalTieringSpecInput
                $ArchivalTieringSpecInput.IsInstantTieringEnabled = $ArchivalSpec.ArchivalTieringSpec.IsInstantTieringEnabled
                $ArchivalTieringSpecInput.MinAccessibleDurationInSeconds = $ArchivalSpec.ArchivalTieringSpec.MinAccessibleDurationInSeconds
                $ArchivalTieringSpecInput.ColdStorageClass = $ArchivalSpec.ArchivalTieringSpec.ColdStorageClass
                $ArchivalTieringSpecInput.ShouldTierExistingSnapshots = $ArchivalSpec.ArchivalTieringSpec.ShouldTierExistingSnapshots
                $ArchivalSpecInput.ArchivalTieringSpecInput = $ArchivalTieringSpecInput
            } else {
                $ArchivalSpecInput.ArchivalTieringSpecInput = $null
            }
        
            $ArchivalSpecInput.Frequencies = $ArchivalSpec.Frequencies
        
            $ArchivalLocationToClusterMappingInputs = @()
            foreach ($Mapping in $ArchivalSpec.ArchivalLocationToClusterMapping) {
                $MappingInput = New-Object RubrikSecurityCloud.Types.ArchivalLocationToClusterMappingInput
                if ($Mapping.Cluster) {
                    $MappingInput.ClusterUuid = [string]$Mapping.Cluster.Id
                } else {
                    $MappingInput.ClusterUuid = $null
                }
        
                if ($Mapping.Location) {
                    $MappingInput.LocationId = [string]$Mapping.Location.Id
                } else {
                    $MappingInput.LocationId = $null
                }
                $ArchivalLocationToClusterMappingInputs += $MappingInput
            }
            $ArchivalSpecInput.ArchivalLocationToClusterMapping = $ArchivalLocationToClusterMappingInputs
        
            return $ArchivalSpecInput
        }

        # Cast ReplicationSpec To ReplicationSpecInput Type
        function CastToReplicationSpecToInput {
            param (
                [RubrikSecurityCloud.Types.ReplicationSpecV2]$ReplicationSpec
            )
            
            if ($null -eq $ReplicationSpec) {
                return $null
            }
        
            $ReplicationSpecInput = New-Object RubrikSecurityCloud.Types.ReplicationSpecV2Input
        
            if ($null -ne $ReplicationSpec.Cluster) {
                $ReplicationSpecInput.ClusterUuid = [string]$ReplicationSpec.Cluster.Id
            } else {
                $ReplicationSpecInput.ClusterUuid = $null
            }
            
            
            if ($null -ne $ReplicationSpec.TargetMapping) {
                $ReplicationSpecInput.StorageSettingId = [string]$ReplicationSpec.TargetMapping.Id
            } else {
                $ReplicationSpecInput.StorageSettingId = $null
            }

            $ReplicationSpecInput.RetentionDuration = CastToSlaDurationInput -Duration $ReplicationSpec.RetentionDuration
        
            if ($null -ne $ReplicationSpec.AwsTarget) {
                $ReplicationSpecInput.AwsAccount = $ReplicationSpec.AwsTarget.AccountName
            } else {
                $ReplicationSpecInput.AwsAccount = $null
            }
        
            if ($null -ne $ReplicationSpec.AzureTarget) {
                $ReplicationSpecInput.AzureSubscription = $ReplicationSpec.AzureTarget.SubscriptionName
            } else {
                $ReplicationSpecInput.AzureSubscription = $null
            }
        
            $ReplicationSpecInput.ReplicationLocalRetentionDuration = CastToSlaDurationInput -Duration $ReplicationSpec.ReplicationLocalRetentionDuration
        
            $CascadingArchivalSpecInputs = @()
            foreach ($CascadingArchivalSpec in $ReplicationSpec.CascadingArchivalSpecs) {
                $CascadingArchivalSpecInput = New-Object RubrikSecurityCloud.Types.CascadingArchivalSpecInput
                $CascadingArchivalSpecInput.ArchivalThreshold = CastToSlaDurationInput -Duration $CascadingArchivalSpec.ArchivalThreshold
                if ($CascadingArchivalSpec.ArchivalTieringSpec) {
                    $ArchivalTieringSpecInput = New-Object RubrikSecurityCloud.Types.ArchivalTieringSpecInput
                    $ArchivalTieringSpecInput.IsInstantTieringEnabled = $CascadingArchivalSpec.ArchivalTieringSpec.IsInstantTieringEnabled
                    $ArchivalTieringSpecInput.MinAccessibleDurationInSeconds = $CascadingArchivalSpec.ArchivalTieringSpec.MinAccessibleDurationInSeconds
                    $ArchivalTieringSpecInput.ColdStorageClass = $CascadingArchivalSpec.ArchivalTieringSpec.ColdStorageClass
                    $ArchivalTieringSpecInput.ShouldTierExistingSnapshots = $CascadingArchivalSpec.ArchivalTieringSpec.ShouldTierExistingSnapshots
                    $CascadingArchivalSpecInput.ArchivalTieringSpecInput = $ArchivalTieringSpecInput
                } else {
                    $CascadingArchivalSpecInput.ArchivalTieringSpecInput = $null
                }
                $CascadingArchivalSpecInput.Frequency = $CascadingArchivalSpec.Frequency
                $CascadingArchivalSpecInput.ArchivalLocationId = [string]$CascadingArchivalSpec.ArchivalLocation.Id
                $ArchivalLocationToClusterMappingInputs = @()
                foreach ($Mapping in $CascadingArchivalSpec.ArchivalLocationToClusterMapping) {
                    $MappingInput = New-Object RubrikSecurityCloud.Types.ArchivalLocationToClusterMappingInput
                    if ($Mapping.Cluster) {
                        $MappingInput.ClusterUuid = [string]$Mapping.Cluster.Id
                    } else {
                        $MappingInput.ClusterUuid = $null
                    }
        
                    if ($Mapping.Location) {
                        $MappingInput.LocationId = [string]$Mapping.Location.Id
                    } else {
                        $MappingInput.LocationId = $null
                    }
                    $ArchivalLocationToClusterMappingInputs += $MappingInput
                }
                $CascadingArchivalSpecInput.ArchivalLocationToClusterMapping = $ArchivalLocationToClusterMappingInputs
                $CascadingArchivalSpecInputs += $CascadingArchivalSpecInput
            }
            $ReplicationSpecInput.CascadingArchivalSpecs = $CascadingArchivalSpecInputs

            $ReplicationPairInputs = @()
            foreach ($Pair in $ReplicationSpec.ReplicationPairs) {
                $PairInput = New-Object RubrikSecurityCloud.Types.ReplicationPairInput
                if ($Pair.SourceCluster) {
                    $PairInput.SourceClusterUuid = [string]$Pair.SourceCluster.Id
                } else {
                    $PairInput.SourceClusterUuid = $null
                }
        
                if ($Pair.TargetCluster) {
                    $PairInput.TargetClusterUuid = [string]$Pair.TargetCluster.Id
                } else {
                    $PairInput.TargetClusterUuid = $null
                }
                $ReplicationPairInputs += $PairInput
            }
            $ReplicationSpecInput.ReplicationPairs = $ReplicationPairInputs

            $ReplicationSpecInput.AwsRegion = [RubrikSecurityCloud.Types.AwsNativeRegionForReplication] $ReplicationSpec.AwsRegion
            $ReplicationSpecInput.AzureRegion = [RubrikSecurityCloud.Types.AzureNativeRegionForReplication] $ReplicationSpec.AzureRegion
        
            return $ReplicationSpecInput
        }
        # ------------------------------- Function Block End ----------------------------------

        $Mutation = New-RscMutationSla -Operation UpdateGlobal
        $Mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.UpdateGlobalSlaInput
        $Mutation.Var.Input.Id = $Sla.Id

        # Prevent race conditions during SLA updates. 
        # Only set stateVersion programmatically, not by user input.
        $Mutation.Var.Input.stateVersion = $Sla.stateVersion

        if ($Name) {
            $Mutation.Var.Input.Name = $Name
        }
        else {
            $Mutation.Var.Input.Name = $Sla.Name
        }

        if ($Description) {
            $Mutation.Var.Input.Description = $Description
        }
        else {
            $Mutation.Var.Input.Description = $Sla.Description
        }
        
        # If UserNote is not provided, set it to null 
        if ($UserNote) {
            $Mutation.Var.Input.UserNote = $UserNote
        } else {
            $Mutation.Var.Input.UserNote = $null
        }

        if ($ObjectTypes) {
            $Mutation.Var.Input.ObjectTypes = $ObjectTypes
        }
        else {
            $Mutation.Var.Input.ObjectTypes = $Sla.ObjectTypes
        }
        
        # ------------------------------- Snapshot Schedule Block Start ----------------------------------
        # Setting each SnapshotSchedule from the existing SLA if not provided
        $Mutation.Var.Input.SnapshotSchedule =
            New-Object -TypeName RubrikSecurityCloud.Types.GlobalSnapshotScheduleInput

        if ($MinuteSchedule) {
            $Mutation.Var.Input.SnapshotSchedule.Minute = $MinuteSchedule
        }
        else {
            if ($Sla.SnapshotSchedule.Minute) {
                $ConfigObj = $Sla.SnapshotSchedule.Minute
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.MinuteSnapshotScheduleInput
                if($ConfigObj.BasicSchedule) {
                    $InputObj.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
                    $InputObj.BasicSchedule.Frequency = $ConfigObj.BasicSchedule.Frequency
                    $InputObj.BasicSchedule.RetentionUnit = $ConfigObj.BasicSchedule.RetentionUnit
                    $InputObj.BasicSchedule.Retention = $ConfigObj.BasicSchedule.Retention
                } else {
                    $InputObj.BasicSchedule = $null
                }
                $Mutation.Var.Input.SnapshotSchedule.Minute = $InputObj
            } else {
                $Mutation.Var.Input.SnapshotSchedule.Minute = $null;
            }
        }
        if ($HourlySchedule) {
            $Mutation.Var.Input.SnapshotSchedule.Hourly = $HourlySchedule
        }
        else {
            if ($Sla.SnapshotSchedule.Hourly) {
                $ConfigObj = $Sla.SnapshotSchedule.Hourly
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.HourlySnapshotScheduleInput
                if($ConfigObj.BasicSchedule) {
                    $InputObj.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
                    $InputObj.BasicSchedule.Frequency = $ConfigObj.BasicSchedule.Frequency
                    $InputObj.BasicSchedule.RetentionUnit = $ConfigObj.BasicSchedule.RetentionUnit
                    $InputObj.BasicSchedule.Retention = $ConfigObj.BasicSchedule.Retention
                } else {
                    $InputObj.BasicSchedule = $null
                }
                $Mutation.Var.Input.SnapshotSchedule.Hourly = $InputObj
            } else {
                $Mutation.Var.Input.SnapshotSchedule.Hourly = $null;
            }
        }

        if ($DailySchedule) {
            $Mutation.Var.Input.SnapshotSchedule.Daily = $DailySchedule
        }
        else {
            if ($Sla.SnapshotSchedule.Daily) {
                $ConfigObj = $Sla.SnapshotSchedule.Daily
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.DailySnapshotScheduleInput
                if($ConfigObj.BasicSchedule) {
                    $InputObj.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
                    $InputObj.BasicSchedule.Frequency = $ConfigObj.BasicSchedule.Frequency
                    $InputObj.BasicSchedule.RetentionUnit = $ConfigObj.BasicSchedule.RetentionUnit
                    $InputObj.BasicSchedule.Retention = $ConfigObj.BasicSchedule.Retention
                } else {
                    $InputObj.BasicSchedule = $null
                }
                $Mutation.Var.Input.SnapshotSchedule.Daily = $InputObj
            } else {
                $Mutation.Var.Input.SnapshotSchedule.Daily = $null;
            }
                
        }

        if ($WeeklySchedule) {
            $Mutation.Var.Input.SnapshotSchedule.Weekly = $WeeklySchedule
        }
        else {
            if ($Sla.SnapshotSchedule.Weekly) {
                $ConfigObj = $Sla.SnapshotSchedule.Weekly
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.WeeklySnapshotScheduleInput
                if($ConfigObj.BasicSchedule) {
                    $InputObj.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
                    $InputObj.BasicSchedule.Frequency = $ConfigObj.BasicSchedule.Frequency
                    $InputObj.BasicSchedule.RetentionUnit = $ConfigObj.BasicSchedule.RetentionUnit
                    $InputObj.BasicSchedule.Retention = $ConfigObj.BasicSchedule.Retention
                } else {
                    $InputObj.BasicSchedule = $null
                }
                $InputObj.DayOfWeek = $ConfigObj.DayOfWeek
                $Mutation.Var.Input.SnapshotSchedule.Weekly = $InputObj
            } else {
                $Mutation.Var.Input.SnapshotSchedule.Weekly = $null;
            }
        }

        if ($MonthlySchedule) {
            $Mutation.Var.Input.SnapshotSchedule.Monthly = $MonthlySchedule
        }
        else {

            if ($Sla.SnapshotSchedule.Monthly) {
                $ConfigObj = $Sla.SnapshotSchedule.Monthly
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.MonthlySnapshotScheduleInput
                if($ConfigObj.BasicSchedule) {
                    $InputObj.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
                    $InputObj.BasicSchedule.Frequency = $ConfigObj.BasicSchedule.Frequency
                    $InputObj.BasicSchedule.RetentionUnit = $ConfigObj.BasicSchedule.RetentionUnit
                    $InputObj.BasicSchedule.Retention = $ConfigObj.BasicSchedule.Retention
                } else {
                    $InputObj.BasicSchedule = $null
                }
                $InputObj.DayOfMonth = $ConfigObj.DayOfMonth
                $Mutation.Var.Input.SnapshotSchedule.Monthly = $InputObj
            } else {
                $Mutation.Var.Input.SnapshotSchedule.Monthly = $null;
            }
        }

        if ($QuarterlySchedule) {
            $Mutation.Var.Input.SnapshotSchedule.Quarterly = $QuarterlySchedule
        }
        else {

            if ($Sla.SnapshotSchedule.Quarterly) {
                $ConfigObj = $Sla.SnapshotSchedule.Quarterly
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.QuarterlySnapshotScheduleInput
                if($ConfigObj.BasicSchedule) {
                    $InputObj.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
                    $InputObj.BasicSchedule.Frequency = $ConfigObj.BasicSchedule.Frequency
                    $InputObj.BasicSchedule.RetentionUnit = $ConfigObj.BasicSchedule.RetentionUnit
                    $InputObj.BasicSchedule.Retention = $ConfigObj.BasicSchedule.Retention
                } else {
                    $InputObj.BasicSchedule = $null
                }
                $InputObj.DayOfQuarter = $ConfigObj.DayOfQuarter
                $InputObj.QuarterStartMonth = $ConfigObj.QuarterStartMonth
                $Mutation.Var.Input.SnapshotSchedule.Quarterly = $InputObj
            } else {
                $Mutation.Var.Input.SnapshotSchedule.Quarterly = $null;
            }
        }

        if ($YearlySchedule) {
            $Mutation.Var.Input.SnapshotSchedule.Yearly = $YearlySchedule
        }
        else {

            if ($Sla.SnapshotSchedule.Yearly) {
                $ConfigObj = $Sla.SnapshotSchedule.Yearly
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.YearlySnapshotScheduleInput
                if($ConfigObj.BasicSchedule) {
                    $InputObj.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
                    $InputObj.BasicSchedule.Frequency = $ConfigObj.BasicSchedule.Frequency
                    $InputObj.BasicSchedule.RetentionUnit = $ConfigObj.BasicSchedule.RetentionUnit
                    $InputObj.BasicSchedule.Retention = $ConfigObj.BasicSchedule.Retention
                } else {
                    $InputObj.BasicSchedule = $null
                }
                $InputObj.DayOfYear = $ConfigObj.DayOfYear
                $InputObj.YearStartMonth = $ConfigObj.YearStartMonth
                $Mutation.Var.Input.SnapshotSchedule.Yearly = $InputObj
            } else {
                $Mutation.Var.Input.SnapshotSchedule.Yearly = $null;
            }
        }
        # ------------------------------- Snapshot Schedule Block End ----------------------------------

        if ($LocalRetentionLimit) {
            $Mutation.Var.Input.LocalRetentionLimit = $LocalRetentionLimit
        } else {
            $Mutation.Var.Input.LocalRetentionLimit = CastToSlaDurationInput -Duration $Sla.LocalRetentionLimit
        }
        

        if ($BackupWindows) {
            $Mutation.Var.Input.BackupWindows = $BackupWindows
        } else {
            $BackupWindowInputs = @()
            if ($null -ne $Sla.BackupWindows) {
                foreach ($BackupWindow in $Sla.BackupWindows) {
                    $BackupWindowInputs += CastToBackupWindowInput -BackupWindow $BackupWindow
                }
            }
            $Mutation.Var.Input.BackupWindows = $BackupWindowInputs
        }   

        if ($FirstFullBackupWindows) {
            $Mutation.Var.Input.FirstFullBackupWindows = $FirstFullBackupWindows
        } else {
            $FirstFullBackupWindowInputs = @()
            if ($null -ne $Sla.FirstFullBackupWindows) {
                foreach ($FirstFullBackupWindow in $Sla.FirstFullBackupWindows) {
                    $FirstFullBackupWindowInputs += CastToBackupWindowInput -BackupWindow $FirstFullBackupWindow
                }
            }
            $Mutation.Var.Input.FirstFullBackupWindows = $FirstFullBackupWindowInputs
        }

        $ShouldApplyToExistingSnapshotsInput = New-Object -TypeName RubrikSecurityCloud.Types.ShouldApplyToExistingSnapshots
        if ($ShouldApplyToExistingSnapshots) { 
            $ShouldApplyToExistingSnapshotsInput.Value = $true
        } else {
            $ShouldApplyToExistingSnapshotsInput.Value = $false
        }
        $Mutation.Var.Input.ShouldApplyToExistingSnapshots = $ShouldApplyToExistingSnapshotsInput

        $ShouldApplyToNonPolicySnapshotsInput = New-Object -TypeName RubrikSecurityCloud.Types.ShouldApplyToNonPolicySnapshots
        if($ShouldApplyToNonPolicySnapshots) {
            $ShouldApplyToNonPolicySnapshotsInput.Value = $true
        } else {
            $ShouldApplyToNonPolicySnapshotsInput.Value = $false
        }
        $Mutation.Var.Input.ShouldApplyToNonPolicySnapshots = $ShouldApplyToNonPolicySnapshotsInput

        if ($RetentionLockSla) {
            $Mutation.Var.Input.IsRetentionLockedSla = $true
        } else {
            $Mutation.Var.Input.IsRetentionLockedSla = $Sla.IsRetentionLockedSla
        }

        if ($RetentionLockMode) {
            $Mutation.Var.Input.RetentionLockMode = $RetentionLockMode
        } else {
            $Mutation.Var.Input.RetentionLockMode = $Sla.RetentionLockMode
        }
        
        if ($ArchivalSpecs) {
            $Mutation.Var.Input.ArchivalSpecs = $ArchivalSpecs
        } else {
            if ($Sla.ArchivalSpecs) {
                $ArchivalSpecInputs = @()
                foreach ($ArchivalSpec in $Sla.ArchivalSpecs) {
                    $ArchivalSpecInputs += CastToArchivalSpecInput -ArchivalSpec $ArchivalSpec
                }
                $Mutation.Var.Input.ArchivalSpecs = $ArchivalSpecInputs
            } else {
                $Mutation.Var.Input.ArchivalSpecs = $null
            }
        }
  
        if ($ReplicationSpecs) {
            $Mutation.Var.Input.ReplicationSpecsV2 = $ReplicationSpecs
        } else {
            if ($Sla.ReplicationSpecsV2) {
                $ReplicationSpecInputs = @()
                foreach ($ReplicationSpec in $Sla.ReplicationSpecsV2) {
                    $ReplicationSpecInput = CastToReplicationSpecToInput -ReplicationSpec $ReplicationSpec
                    $ReplicationSpecInputs += $ReplicationSpecInput
                }
                $Mutation.Var.Input.ReplicationSpecsV2 = $ReplicationSpecInputs
            } else {
                $Mutation.Var.Input.ReplicationSpecsV2 = $null
            }
        }

        # ------------------------------- Object Specific Config Block Start ----------------------------------
        $ObjectSpecificConfig = New-Object -TypeName RubrikSecurityCloud.Types.ObjectSpecificConfigsInput
        if ($VmwareVmConfig) {
            $ObjectSpecificConfig.VmwareVmConfigInput = $VmwareVmConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.VmwareVmConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.VmwareVmConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.VmwareVmConfigInput
                $InputObj.LogRetentionSeconds = $ConfigObj.LogRetentionSeconds
                $ObjectSpecificConfig.VmwareVmConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.VmwareVmConfigInput = $null
            }
        }

        if ($OracleConfig) {
            $ObjectSpecificConfig.OracleConfigInput = $OracleConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.OracleConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.OracleConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.OracleConfigInput
                $InputObj.Frequency = CastToSlaDurationInput -Duration $ConfigObj.Frequency
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $InputObj.HostLogRetention = CastToSlaDurationInput -Duration $ConfigObj.HostLogRetention
                $ObjectSpecificConfig.OracleConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.OracleConfigInput = $null
            }
        }

        if ($SapHanaConfig) {
            $ObjectSpecificConfig.SapHanaConfigInput = $SapHanaConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.SapHanaConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.SapHanaConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaConfigInput
                $InputObj.IncrementalFrequency = CastToSlaDurationInput -Duration $ConfigObj.IncrementalFrequency
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $InputObj.DifferentialFrequency = CastToSlaDurationInput -Duration $ConfigObj.DifferentialFrequency

                if ($null -ne $ConfigObj.StorageSnapshotConfig) {
                    $StorageSnapshotConfigInput = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaStorageSnapshotConfigInput
                    $StorageSnapshotConfigInput.Retention = CastToSlaDurationInput -Duration $ConfigObj.StorageSnapshotConfig.Retention
                    $StorageSnapshotConfigInput.Frequency = CastToSlaDurationInput -Duration $ConfigObj.StorageSnapshotConfig.Frequency
                    $InputObj.StorageSnapshotConfig = $StorageSnapshotConfigInput
                }

                $ObjectSpecificConfig.SapHanaConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.SapHanaConfigInput = $null
            }
        }

        if ($AwsRdsConfig) {
            $ObjectSpecificConfig.AwsRdsConfigInput = $AwsRdsConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.AwsRdsConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.AwsRdsConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.AwsRdsConfigInput
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $ObjectSpecificConfig.AwsRdsConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.AwsRdsConfigInput = $null
            }
        }
        
        if ($AzureSqlDatabaseConfig) {
            $ObjectSpecificConfig.AzureSqlDatabaseDbConfigInput = $AzureSqlDatabaseConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.AzureSqlDatabaseDbConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.AzureSqlDatabaseDbConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlDatabaseDbConfigInput
                $InputObj.LogRetentionInDays = $ConfigObj.LogRetentionInDays
                $ObjectSpecificConfig.AzureSqlDatabaseDbConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.AzureSqlDatabaseDbConfigInput = $null
            }
        }

        if ($AzureSqlManagedInstanceConfig) {
            $ObjectSpecificConfig.AzureSqlManagedInstanceDbConfigInput = $AzureSqlManagedInstanceConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.AzureSqlManagedInstanceDbConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.AzureSqlManagedInstanceDbConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlManagedInstanceDbConfigInput
                $InputObj.LogRetentionInDays = $ConfigObj.LogRetentionInDays
                $ObjectSpecificConfig.AzureSqlManagedInstanceDbConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.AzureSqlManagedInstanceDbConfigInput = $null
            }
        }

        if ($Db2Config) {
            $ObjectSpecificConfig.Db2ConfigInput = $Db2Config
        } else {
            if ($Sla.ObjectSpecificConfigs.Db2Config) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.Db2Config
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.Db2ConfigInput
                $InputObj.IncrementalFrequency = CastToSlaDurationInput -Duration $ConfigObj.IncrementalFrequency
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $InputObj.DifferentialFrequency = CastToSlaDurationInput -Duration $ConfigObj.DifferentialFrequency
                $InputObj.LogArchivalMethod = $ConfigObj.LogArchivalMethod
                $ObjectSpecificConfig.Db2ConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.Db2ConfigInput = $null
            }
        }

        if ($MsSqlConfig) {
            $ObjectSpecificConfig.MsSqlConfigInput = $MsSqlConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.MssqlConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.MssqlConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.MssqlConfigInput
                $InputObj.Frequency = CastToSlaDurationInput -Duration $ConfigObj.Frequency
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $ObjectSpecificConfig.MsSqlConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.MsSqlConfigInput = $null
            }
        }


        if ($MysqldbConfig) {
            $ObjectSpecificConfig.MysqldbConfigInput = $MysqldbConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.MysqldbSlaConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.MysqldbSlaConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.MysqldbSlaConfigInput
                $InputObj.LogFrequency = CastToSlaDurationInput -Duration $ConfigObj.LogFrequency
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $ObjectSpecificConfig.MysqldbConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.MysqldbConfigInput = $null
            }
        }

        if ($MongoConfig) {
            $ObjectSpecificConfig.MongoConfigInput = $MongoConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.MongoConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.MongoConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.MongoConfigInput
                $InputObj.LogFrequency = CastToSlaDurationInput -Duration $ConfigObj.LogFrequency
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $ObjectSpecificConfig.MongoConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.MongoConfigInput = $null
            }
        }

        if ($AzureBlobConfig) {
            $ObjectSpecificConfig.AzureBlobConfigInput = $AzureBlobConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.AzureBlobConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.AzureBlobConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.AzureBlobConfigInput
                $InputObj.ContinuousBackupRetentionInDays = $ConfigObj.ContinuousBackupRetentionInDays
                $InputObj.BackupLocationId = $ConfigObj.BackupLocationId
                $ObjectSpecificConfig.AzureBlobConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.AzureBlobConfigInput = $null
            }
        }

        if ($AwsNativeS3Config) {
            $ObjectSpecificConfig.AwsNativeS3SlaConfigInput = $AwsNativeS3Config
        } else {
            if ($Sla.ObjectSpecificConfigs.AwsNativeS3SlaConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.AwsNativeS3SlaConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.AwsNativeS3SlaConfigInput
                $InputObj.ContinuousBackupRetentionInDays = $ConfigObj.ContinuousBackupRetentionInDays
                $InputObj.ArchivalLocationId = $ConfigObj.ArchivalLocationId
                $ObjectSpecificConfig.AwsNativeS3SlaConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.AwsNativeS3SlaConfigInput = $null
            }
        }

        if ($ManagedVolumeConfig) {
            $ObjectSpecificConfig.ManagedVolumeSlaConfigInput = $ManagedVolumeConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.ManagedVolumeSlaConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.ManagedVolumeSlaConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.ManagedVolumeSlaConfigInput
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $ObjectSpecificConfig.ManagedVolumeSlaConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.ManagedVolumeSlaConfigInput = $null
            }
        }

        if ($PostgresDbClusterConfig) {
            $ObjectSpecificConfig.PostgresDbClusterSlaConfigInput = $PostgresDbClusterConfig
        } else {
            if ($Sla.ObjectSpecificConfigs.PostgresDbClusterSlaConfig) {
                $ConfigObj = $Sla.ObjectSpecificConfigs.PostgresDbClusterSlaConfig
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.PostgresDbClusterSlaConfigInput
                $InputObj.LogRetention = CastToSlaDurationInput -Duration $ConfigObj.LogRetention
                $ObjectSpecificConfig.PostgresDbClusterSlaConfigInput = $InputObj
            } else {
                $ObjectSpecificConfig.PostgresDbClusterSlaConfigInput = $null
            }
        }

        $Mutation.Var.Input.ObjectSpecificConfigsInput = $ObjectSpecificConfig
        # ------------------------------- Object Specific Config Block End ----------------------------------

        if ($AsQuery) {
            return $Mutation
        }

        return Invoke-Rsc -Query $Mutation
    }
}