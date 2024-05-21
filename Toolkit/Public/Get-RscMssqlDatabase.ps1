#Requires -Version 3
function Get-RscMssqlDatabase {
    <#
    .SYNOPSIS
    Returns information about a MSSQL Database

    .DESCRIPTION
    Returns information about a MSSQL Database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Used to create a list of Databases
    
    .PARAMETER Name
    Used to return a specific Database based on the name

    .PARAMETER RscMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance


    .PARAMETER RscMssqlAvailabilityGroup
    SQL Server Availability Group Objeft returned from Get-RscMssqlAvailabilityGroup

    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .EXAMPLE
    Return a list of MSSQL Databases
    Get-RscMssqlDatabase -List

    .EXAMPLE
    Return a list of MSSQL Databases named AdventureWorks2019
    Get-RscMssqlDatabase -Name AdventureWorks2019

    .EXAMPLE
    Return a list of MSSQL Databases named AdventureWorks2019 on the SQL 2019 Instance
    $RscMssqlInstance = Get-RscMssqlInstance -HostName sql19.demo.com -clusterID hja87-ajb43-v4avna-hnjag
    Get-RscMssqlDatabase -Name AdventureWorks2019 -RscMssqlInstance $RscMssqlInstance
    #>

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(ParameterSetName = "List", Mandatory = $false)]
        [Switch]$List,

        [Parameter(ParameterSetName = "Name", Mandatory = $true)]
        [String]$Name,

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(ParameterSetName = "Instance", Mandatory = $true)]
        [RubrikSecurityCloud.Types.MssqlInstance]$RscMssqlInstance, 

        [Parameter(ParameterSetName = "Name", Mandatory = $false)]
        [Parameter(ParameterSetName = "AvailabilityGroup", Mandatory = $true)]
        [RubrikSecurityCloud.Types.MssqlAvailabilityGroup]$RscMssqlAvailabilityGroup, 

        [Parameter(ParameterSetName = "Id", Mandatory = $true)]
        [String]$Id
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlDatabase"
        #region Create Query
        switch($PSCmdlet.ParameterSetName){
            "List"{
                $query = New-RscQueryMssql -Operation Databases -AddField Nodes.PhysicalPath
            }
            { ($_ -eq "Name") -or ($_ -eq "Instance") -or ($_ -eq "AvailabilityGroup")  } {
                $query = New-RscQueryMssql -Op Databases `
                -AddField Nodes.PhysicalPath, `
                    Nodes.PostBackupScript, `
                    Nodes.PreBackupScript, `
                    Nodes.CopyOnly, `
                    Nodes.HostLogRetention, `
                    Nodes.LogBackupFrequencyInSeconds, `
                    Nodes.LogBackupRetentionInHours    
                    $query.Var.filter = @()
            }
            "Id"{
                $query = New-RscQueryMssql -Operation Database 
                $query.Field.PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
                $query.Field.PhysicalPath.SelectForRetrieval() 
                $query.Var.fid = $Id
            }
        }
        #endregion
        if ($Name){
            $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
            $nameFilter.texts = $Name
            $query.Var.filter += $nameFilter
        }

        $results = $query.Invoke()   
                
        switch($PSCmdlet.ParameterSetName){
            "List"{
                $results.Nodes
            }
            "Id"{
                $results
            }
            { ($_ -eq "Name") -or ($_ -eq "Instance") -or ($_ -eq "AvailabilityGroup")  } {
                if ($RscMssqlInstance) {
                    $results = ($results.Nodes | Where-Object {$_.PhysicalPath.Fid -eq $RscMssqlInstance.id})
                    $results
                }elseif ($RscMssqlAvailabilityGroup) {
                    $results = $results.Nodes | Where-Object {$_.PhysicalPath.Fid -eq $RscMssqlAvailabilityGroup.id}
                    $results                
                }else{
                    $results.nodes
                }
            }
        }
    } 
}
