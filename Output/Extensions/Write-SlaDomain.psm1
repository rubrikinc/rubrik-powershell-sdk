#Requires -Version 3
function Write-SlaDomain
{
  <#  
      .SYNOPSIS
      Create an SLA domain.
            
      .DESCRIPTION
      The Write-SlaDomain cmdlet will create an SLA domain.

      .NOTES
            
      .LINK
            
      .EXAMPLE
      $snapshotSchedule=@{
        "yearly"=@{
          "basicSchedule"=@{
            "frequency"=1
            "retention"=1
            "retentionUnit"="YEARS"}
          "dayOfYear"="LAST_DAY"
          "yearStartMonth"="JANUARY"
        }
      }
      Write-SlaDomain -Name "name" -Description "description" -SnapshotSchedule $snapshotSchedule -ObjectTypes @("MANAGED_VOLUME_OBJECT_TYPE")
      
      This will create an SLA domain that takes a snapshot of a managed volume once a year.
  #>

  [CmdletBinding()]
  Param(
    # Name of the SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [string]$Name,
    # Description of the SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [string]$Description,
    # Snapshot schedule of the SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.GlobalSnapshotScheduleInput]$SnapshotSchedule,
    # Replication specification of the SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.ReplicationSpecInput]$ReplicationSpecInput,
    # Retention limit for snapshots on the local Rubrik system. If none, they will remain as long as SLA requires.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.SlaDurationInput]$LocalRetentionLimit,
    # Backup Window specifications of first full backup for SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.BackupWindowInput[]]$FirstFullBackupWindows,
    # Backup Window specifications for SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.BackupWindowInput[]]$BackupWindows,
    # Log configuration of the SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.LogConfig]$LogConfig,
    # Object-specific configuration of the SLA Domain.
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.ObjectSpecificConfigsInput]$ObjectSpecificConfigsInput,
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.ArchivalSpecInput[]]$ArchivalSpecs,
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.ReplicationSpecV2Input[]]$ReplicationSpecsV2,
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [RubrikSecurityCloud.Types.SlaObjectType[]]$ObjectTypes,
    # Recovery Point desired in the form of DateTime value
    [Parameter(
      Mandatory = $false, 
      ValueFromPipelineByPropertyName = $true
    )]
    [bool]$IsRetentionLockedSla
  )

    Begin {

    # -1- Re-use existing connection, or create a new one:
    Connect-Rsc -ErrorAction Stop | Out-Null
    
    # -2- Determine input profile:
    $inputProfile = "DEFAULT"
    if ( $Detail -eq $true ) {
        $inputProfile = "DETAIL"
    }

    # -3- Retrieve pre-defined operation
    $operation = "createGlobal"  
  }

  Process {
    $inputs = Invoke-RscMutateSla -Op $operation -InputProfile $inputProfile -GetInput

    # -4- Customize inputs
    $inputValues = @{
      "name" = $Name
      "description" = $Description
      "snapshotSchedule" = $SnapshotSchedule
      "replicationSpecInput" = $ReplicationSpecInput
      "localRetentionLimit" = $LocalRetentionLimit
      "firstFullBackupWindows" = $FirstFullBackupWindows
      "backupWindows" = $BackupWindows
      "logConfig" = $LogConfig
      "objectSpecificConfigsInput" = $ObjectSpecificConfigsInput
      "archivalSpecs" = $ArchivalSpecs
      "replicationSpecsV2" = $ReplicationSpecsV2
      "objectTypes" = $ObjectTypes
      "isRetentionLockedSla" = $IsRetentionLockedSla
    }

    $inputs.Var.input = $inputValues

    return Invoke-RscMutateSla -Op $operation -Var $inputs.Var -Field $inputs.Field
  }
}
