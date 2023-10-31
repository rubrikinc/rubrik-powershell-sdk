#Requires -Version 3
function Get-RscMssqlDatabaseFiles {
    <#
    .SYNOPSIS
    Return a list of database files that existed at the time of the backup

    .DESCRIPTION
    Return a list of database files that existed at the time of the backup. This is used for Export-RscMssqlDatabase

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Returns the list of database files based on the latest recovery point
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseFiles -RscMssqlDatabase $RscMssqlDatabase -Latest

    .EXAMPLE
    Returns the list of database files based on the last snapshot taken
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseFiles -RscMssqlDatabase $RscMssqlDatabase -LastFull

    .EXAMPLE
    Returns the list of database files based on a specific point in time. 
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseFiles -RscMssqlDatabase $RscMssqlDatabase -RestoreTime "2023-10-27 08:37:00.000Z"
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,
        
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Latest,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$LastFull,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][datetime]$RestoreTime,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$IncludeNullProperties,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlDatabaseFiles field profile: $fieldProfile"
        
        $query = New-RscQueryMssql -Operation DatabaseRestoreFiles -FieldProfile $fieldProfile -Addfield Items.fileType, Items.logicalName, Items.originalName, Items.originalPath
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.MssqlGetRestoreFilesV1Input
        $query.Var.input.id = $RscMssqlDatabase.Id
        
        if($PSBoundParameters.ContainsKey('Latest')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -Latest
        }

        if($PSBoundParameters.ContainsKey('LastFull')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -LastFull
        }

        if($PSBoundParameters.ContainsKey('RestoreTime')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -RestoreTime $RestoreTime
        }
        $query.Var.input.time = $RecoveryPoint

        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }

        if ($null -ne $result.Nodes){
            if ( $IncludeNullProperties -eq $true ) {
                $result.Nodes
            }else{
                $result.Nodes | Remove-NullProperties
            }
        }else{
            if ( $IncludeNullProperties -eq $true ) {
                $result
            }else{
                $result | Remove-NullProperties
            }
        } 
    } 
}
