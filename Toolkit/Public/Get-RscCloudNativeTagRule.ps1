#Requires -Version 3
function Get-RscCloudNativeTagRule {
    <#
    .SYNOPSIS
    Retrieves cloud-native tag rules configured in Rubrik Security Cloud.

    .DESCRIPTION
    Returns tag-based auto-protection rules for cloud-native workloads. These rules
    automatically assign SLA Domains to cloud resources that match specified tags.
    The -ObjectType parameter is required to specify which cloud resource type
    to query (e.g., AWS EC2, Azure VM).

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get all
    Get-RscCloudNativeTagRule

.PARAMETER Name
    Filter by name. Supports partial matching.

    .PARAMETER Sla
    An SLA Domain object to filter by. Pipe from Get-RscSla.

    .PARAMETER ObjectType
    The cloud-native object type to query tag rules for. This parameter is required.

    .EXAMPLE
    # Get all tag rules for AWS EC2 instances
    Get-RscCloudNativeTagRule -ObjectType AWS_EC2_INSTANCE

    .EXAMPLE
    # Get tag rules assigned to a specific SLA
    Get-RscSla -Name "Gold" | Get-RscCloudNativeTagRule -ObjectType AZURE_VM
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
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
        [RubrikSecurityCloud.Types.CloudNativeTagObjectType]$ObjectType,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
            $query = New-RscQuery -Gql cloudNativeTagRules
            $query.field.tagRules = New-Object -TypeName RubrikSecurityCloud.Types.CloudNativeTagRule
            $query.field.tagRules[0].name = "FETCH"
            $query.field.tagRules[0].id = "FETCH"
            $query.field.tagRules[0].effectiveSla = New-Object -Typename RubrikSecurityCloud.Types.TagRuleEffectiveSla
            $query.field.tagRules[0].effectiveSla.name = "FETCH"
            $query.field.tagRules[0].effectiveSla.id = "FETCH"
            $query.field.tagRules[0].objectType = [RubrikSecurityCloud.Types.ManagedObjectType]::AWS_NATIVE_EC2_INSTANCE

            $query.var.filter = @()

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

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.tagRules
    } 
}

