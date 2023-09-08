#Requires -Version 3
function New-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding(
        # ___ Example ___
        # DefaultParameterSetName = "Id"
    )]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$MountedDatabaseName,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$TargetInstanceId,
        
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Latest,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$LastFull,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [datetime]$RestoreTime
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }
        Write-Host "New-RscMssqlLiveMount: $inputProfile"
        

        $mssqlInputs = Invoke-RscMutateMssql -CreateLiveMount -GetInput
        $mssqlInputs.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.CreateMssqlLiveMountInput

        if($PSBoundParameters.ContainsKey('Latest')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -id $RscMssqlDatabase.Id -Latest
        }

        if($PSBoundParameters.ContainsKey('LastFull')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -id $RscMssqlDatabase.Id -LastFull
        }
        
        if($PSBoundParameters.ContainsKey('RestoreTime')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -id $RscMssqlDatabase.Id -RestoreTime $RestoreTime
        }

        $mssqlInputs.Var.input.id = "$($RscMssqlDatabase.Id)"
        $mssqlInputs.Var.input.config = New-Object RubrikSecurityCloud.Types.MountMssqlDbConfigInput
        $mssqlInputs.Var.input.config.mountedDatabaseName = "$($MountedDatabaseName)"
        $mssqlInputs.Var.input.config.targetInstanceId = "$($TargetInstanceId)"
        $mssqlInputs.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
        $mssqlInputs.Var.input.config.recoveryPoint.date = $RecoveryPoint

        Invoke-RscMutateMssql -CreateLiveMount -Var $mssqlInputs.var
    } 
}
