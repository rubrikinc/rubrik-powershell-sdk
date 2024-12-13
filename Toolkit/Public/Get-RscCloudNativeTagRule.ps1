#Requires -Version 3
function Get-RscCloudNativeTagRule {
    <#
    .SYNOPSIS
    Retrieves RscCloudNativeTagRule objects protected by Rubrik Security Cloud

    .DESCRIPTION
    This cmdlet uses the GQL query 'cloudNativeTagRules' to retrieve a list of VMs with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all
    Get-RscCloudNativeTagRule

    .EXAMPLE
    # Get object with specific name
    Get-RscCloudNativeTagRule -Name "jake-001"

    .EXAMPLE
    # Get objects by specifying part of a name
    Get-RscCloudNativeTagRule -Name "*jake*"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String]$Id,
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,
        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $false,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.CloudNativeTagObjectType]$ObjectType
    )
    
    Process {

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -GqlQuery 
            $query.var.filters = @()
            $query.var.fid = $Id

            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -GqlQuery cloudNativeTagRules
            $query.field.tagRules = New-Object -TypeName RubrikSecurityCloud.Types.CloudNativeTagRule
            $query.field.tagRules[0].name = "FETCH"
            $query.field.tagRules[0].id = "FETCH"
            $query.field.tagRules[0].effectiveSla = New-Object -Typename RubrikSecurityCloud.Types.TagRuleEffectiveSla
            $query.field.tagRules[0].effectiveSla.name = "FETCH"
            $query.field.tagRules[0].effectiveSla.id = "FETCH"
            $query.field.tagRules[0].objectType = [RubrikSecurityCloud.Types.ManagedObjectType]::AWS_NATIVE_EC2_INSTANCE

            $query.var.filters = @()

            if ($Name) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.CloudNativeFilter 
                $nameFilter.Field = [RubrikSecurityCloud.Types.CloudNativeTagRuleFilterFields]::NAME
                $nameFilter.texts = $Name
                $query.var.filter += $nameFilter
            }
    
            if ($Sla) {
                $slaFilter = New-Object -TypeName RubrikSecurityCloud.Types.CloudNativeFilter
                $slaFilter.Field = [RubrikSecurityCloud.Types.CloudNativeTagRuleFilterFields]::SLA_DOMAIN
                $slaFilter.Texts = $Sla.id
                $query.var.filter += $slaFilter
            }

            $query.var.ObjectType += $ObjectType

            $result = Invoke-Rsc -Query $query
            $result.tagRules
        }





    } 
}

