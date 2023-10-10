#Requires -Version 3
function Get-RscMssqlDatabase {
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
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [Switch]$List,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$Name,

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(
            ParameterSetName = "RscMssqlInstance",
            Mandatory = $false, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.PhysicalHost]$RscMssqlInstance, 

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(
            ParameterSetName = "RscMssqlInstanceId",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$RscMssqlInstanceId,
        
        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [Switch]$Detail
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlDatabase field profile: $fieldProfile"

        #region Create Query
        switch ( $PSCmdlet.ParameterSetName){
            "List" {
                $query = New-RscQueryMssql -Op Databases -FieldProfile $fieldProfile -AddField Nodes.PhysicalPath 
            }
            "Name"{
                $query = New-RscQueryMssql -Op Databases -FieldProfile $fieldProfile `
                    -AddField Nodes.PhysicalPath, `
                    Nodes.PostBackupScript, `
                    Nodes.PreBackupScript, `
                    Nodes.ConfiguredSlaDomain, `
                    Nodes.CopyOnly, `
                    Nodes.HostLogRetention, `
                    Nodes.LogBackupFrequencyInSeconds, `
                    Nodes.LogBackupRetentionInHours       
                $query.Var.filter = @()
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $Name
                $query.Var.filter += $nameFilter
            }
        }
        #endregion

        $result = $query.Invoke()

        If ( $PSBoundParameters.ContainsKey('RscMssqlInstance') ) {
            $Instance = $RscMssqlInstance.PhysicalChildConnection.Nodes | Where-Object {$_.ObjectType -eq "MSSQL_INSTANCE"}
            $result = $result.Nodes | Where-Object { $_.PhysicalPath.Fid -eq $Instance.Id }
        }
        If ( $PSBoundParameters.ContainsKey('RscMssqlInstanceId') ) {
            $result = $result.Nodes | Where-Object { $_.PhysicalPath.Fid -eq $RscMssqlInstanceId }
        }


        if ($null -ne $result.Nodes){
            $result.Nodes #| Remove-NullProperties
        }else{
            $result #| Remove-NullProperties
        }
    } 
}
