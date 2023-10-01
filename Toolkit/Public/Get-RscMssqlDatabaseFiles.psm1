#Requires -Version 3
function Get-RscMssqlDatabaseFiles {
  <#  
      .SYNOPSIS
      Connects to Rubrik Security Cloud and retrieves all the data files for a SQL Server Database Snapshot
            
      .DESCRIPTION
      The Get-RscMssqlDatabaseFiles cmdlet will return all the available database files for a database 
      snapshot. This is based on the recovery time for the database, as file locations could change
      between snapshots and log backups.

      .NOTES
            
      .LINK
            
      .EXAMPLE
      Get-RscMssqlDatabaseFiles -id '11111111-2222-3333-4444-555555555555' -RecoveryDateTime (Get-Date).AddDays(-1)
      This will return datavase file location information for DB "11111111-2222-3333-4444-555555555555"
      from a recovery point one day ago, assuming that recovery point exists.

      .EXAMPLE
      Get-RscMssqlDatabaseFiles -id '11111111-2222-3333-4444-555555555555' -RecoveryDateTime (Get-RscMssqlDatabaseRecoveryPoint -Id '11111111-2222-3333-4444-555555555555' -Latest)
      This will return datavase file location information for DB "11111111-2222-3333-4444-555555555555" 
      from the latest recovery point available.

  #>

  [CmdletBinding()]
  Param(
    #Id of the MSSQL Database
    [Parameter(
      ParameterSetName = 'Time',
      Position = 0,
      Mandatory = $true,
      ValueFromPipelineByPropertyName = $true)]
    [Parameter(
      ParameterSetName = 'LSN',
      Position = 0,
      Mandatory = $true,
      ValueFromPipelineByPropertyName = $true)]
    [ValidateNotNullOrEmpty()]
    [String]$Id,
    # Recovery Point desired in the form of DateTime value
    [Parameter(ParameterSetName = 'Time')]
    [ValidateNotNullOrEmpty()]
    [datetime]$RecoveryDateTime,
    # Recovery Point desired in the form of a UTC string (yyyy-MM-ddTHH:mm:ss)
    [Parameter(ParameterSetName = 'LSN')]
    [ValidateNotNullOrEmpty()]
    [string]$Lsn,    
    # Recovery fork GUID of LSN to recover to. Meaningful only when lsn is specified.
    [Parameter(ParameterSetName = 'LSN')]
    [string]$RecoveryForKGuid
  )

  Begin {

    # Re-use existing connection, or create a new one:
    Connect-Rsc -ErrorAction Stop | Out-Null
    
    # Determine field profile
    $fieldProfile = "DEFAULT"
  }

  Process {

    $query = New-RscQueryMssql -Op AllDatabaseRestoreFiles -FieldProfile $fieldProfile

    # Customize inputs
    $inputValues = @{
      "id" = $Id
    }

    switch ($PSCmdLet.ParameterSetName) {
      "Time" {
        $inputValues.Time = $RecoveryDateTime.ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ssZ')
      }

      "Lsn" {
        $inputValues.Lsn = $Lsn
        if ($RecoveryForKGuid) {
          $inputValues.recoveryForKGuid = $RecoveryForKGuid
        }
      }
    }

    $query.Var["input"] = $inputValues

    # Define the desired fields to be included in the response
    $query.Field = Get-RscType -Name V1MssqlGetRestoreFilesV1Response -InitialProperties @(
      "items.fileId",
      "items.fileType",
      "items.logicalName",
      "items.originalName",
      "items.originalPath"
    )

    # Send request to the API server
    $result = Invoke-Rsc $query

    # Filter results
    # the response's `Items` field contains the list
    if ( $PSCmdlet.ParameterSetName -eq "List" ) {
      $result = $result.Items
    }

    # Filter out null values:
    # fields that weren't requested
    # come back as nulls in the `$result` object,
    # but that's not interesting to display
    $result | Remove-NullProperties
  } # End of process
} # End of function
