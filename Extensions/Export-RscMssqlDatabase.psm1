<#
    This cmdlet has been ported from
    https://github.com/rubrikinc/rubrik-sdk-for-powershell/blob/devel/Rubrik/Public/Export-RubrikDatabase.ps1
#>

#Requires -Version 3
function Export-RscMssqlDatabase
{
  <#
      .SYNOPSIS
      Export a backup of a database to a MSSQL instance

      .DESCRIPTION
      The Export-RscMssqlDatabase command will request a database export from a Rubrik Cluster to a MSSQL instance

      .NOTES

      .EXAMPLE
      Export-RscMssqlDatabase -id c5ecf3ef-248d-4bb2-8fe1-4d3c820a0e38 -targetInstanceId 0085b247-e718-4177-869f-e3ae1f7bb503 -targetDatabaseName ReportServer -finishRecovery -maxDataStreams 4 -timestampMs 1492661627000
      
      .EXAMPLE
      $db = $(Get-RscMssqlDatabase -Name MyTestDatabase)[0].Id
      Export-RscMssqlDatabase -id $db -recoveryDateTime (Get-RscMssqlDatabaseRecoveryPoint -Id c5ecf3ef-248d-4bb2-8fe1-4d3c820a0e38 -Latest) -targetInstanceId 0085b247-e718-4177-869f-e3ae1f7bb503 -targetDatabaseName 'BAR_EXP' -TargetFilePaths $targetFiles

      Restore the $db (where $db is the output of a Get-RscMssqlDatabase call) to the most recent recovery point for that database. New file paths are 
      in the $targetfiles array. Each individual file declaration (logicalName, exportPath,newFilename) will be a hashtable, so what gets passed to the
      cmdlet is an array of hashtables
      
      $targetfiles = @()
      $targetfiles += @{logicalName='BAR_1';exportPath='E:\SQLFiles\Data\BAREXP\'}
      $targetfiles += @{logicalName='BAR_LOG';exportPath='E:\SQLFiles\Log\BAREXP\'}
      
      .LINK
      Schema reference:
      https://rubrikinc.github.io/rubrik-api-documentation/schema/reference
  #>


  [CmdletBinding(SupportsShouldProcess = $true,ConfirmImpact = 'High')]
  Param(
    # Rubrik identifier of database to be exported
    [Parameter(Mandatory = $true,ValueFromPipelineByPropertyName = $true)]
    [String]$Id,

    # Number of parallel streams to copy data
    [int]$MaxDataStreams,

    # Recovery Point desired in the form of Epoch with Milliseconds
    [Parameter(ParameterSetName='Recovery_timestamp')]
    [int64]$TimestampMs,

    # Recovery Point desired in the form of DateTime value
    [Parameter(ParameterSetName='Recovery_DateTime')]
    [datetime]$RecoveryDateTime,

    #Recovery Point desired in the form of an LSN (Log Sequence Number) TODO:SPARK-224340
    #[Parameter(ParameterSetName='Recovery_LSN')]
    #[string]$RecoveryLSN,

    # Take database out of recovery mode after export
    [Switch]$FinishRecovery,

    # Rubrik identifier of MSSQL instance to export to
    [string]$TargetInstanceId,

    # Name to give database upon export
    [string]$TargetDatabaseName,

    [Switch]$Overwrite,

    #Simple Mode - Data File Path 
    [Alias('DataFilePath')]   
    [string]$TargetDataFilePath,

    #Simple Mode - Data File Path
    [Alias('LogFilePath')]    
    [string]$TargetLogFilePath,

    #Advanced Mode - Array of hash tables for file reloaction.
    [PSCustomObject[]] $TargetFilePaths
  )
    

  Begin {
    # -1- Re-use existing connection, or create a new one:
    Connect-Rsc -ErrorAction Stop | Out-Null

    # -2- Determine input profile:
    $inputProfile = "DEFAULT"

    # -3- Retrieve pre-defined input objects:
    $operation = "exportDatabase"

    #If recoveryDateTime, convert to epoch milliseconds
    #if($RecoveryDateTime){  
    #  $TimestampMs = (New-TimeSpan -Start ([datetime]'1970-01-01Z').ToUniversalTime() -End $RecoveryDateTime.ToUniversalTime()).TotalMilliseconds
    #}
  }

  Process {

    $inputs = (Invoke-RscMutateMssql -Op $operation -FieldProfile $inputProfile -GetInput)

    # -4- Customize input objects:
        
    $recoveryPointValues = $null

    switch ($PSCmdLet.ParameterSetName){
        "Recovery_timestamp" {
            $recoveryPointValues = @{
                "timeStampMs" = $TimestampMs
            }
        }
            
        "Recovery_DateTIme" {
            $recoveryPointValues = @{
                "date" = $(Get-Date $RecoveryDateTime).ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ss.fffZ')
            }
        }
            
        "Recovery_LSN" {
            recoveryPointValues = @{
                "lsnPoint" = @{
                    "lsn" = "" #TODO: SPARK-224340
                    "recoveryForkGuid" = "" #TODO: SPARK-224340
                }
            }
        }
    }

    $recoveryPoint = $recoveryPointValues

    $config = @{
        "RecoveryPoint" = $recoveryPoint
        "TargetDatabaseName" = $TargetDatabaseName
        "TargetFilePaths" = $targetFilePaths
        "TargetInstanceId" = $TargetInstanceId
    }

    if ($Overwrite) { $config.AllowOverwrite = $Overwrite }
    if ($FinishRecovery) { $config.FinishRecovery = $FinishRecovery }
    if ($MaxDataStreams) { $config.MaxDataStreams = $MaxDataStreams }
    if ($TargetDataFilePath) { $config.TargetDataFilePath = $TargetDataFilePath }
    if ($TargetLogFilePath) { $config.TargetLogFilePath = $TargetLogFilePath }

    $inputConf = @{
        "id" = $Id
        "config" = $config
    }

    $inputs.Var["input"] = $inputConf
    
    $fields = Get-RscType -Name AsyncRequestStatus -InitialProperties @(
        "endTime",
        "error.message",
        "id",
        "links.href",
        "links.rel",
        "nodeId",
        "startTime",
        "status")
    $fields.Progress = 0;

    # -5- Invoke GraphQL operation:
    $result = Invoke-RscMutateMssql -Op $operation -Field $fields -Var $inputs.Var

    $result
  }
}
