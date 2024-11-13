#Requires -Version 3
function Get-RscOrganization {
    <#
    .SYNOPSIS
    Retrieves Organizations defined in Rubrik Security Cloud

    .DESCRIPTION
    Rubrik Security Cloud Organizations are logically separated users, permissions and objects to achieve multi-tenancy.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all roles
    Get-RscOrganization

    .EXAMPLE
    # Get role with specific name
    Get-RscOrganization "TenantA"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String[]]$Id,
        [Parameter(
            Position = 0,
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name
    )
    
    Process {
       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -GqlQuery org
            $query.var.orgId = $Id





            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -GqlQuery orgs
            if ($Name) {
                $query.var.nameFilter = $Name
            }

            # I'm using these to populate all fields instead of doing them individually.
            $roleTempQuery = New-RscQuery -GqlQuery getRolesByIds -FieldProfile FULL

            $query.field.Nodes[0].Id = "tacos"
            $query.field.Nodes[0].Name = "FETCH"
            $query.field.Nodes[0].FullName = "FETCH"
            $query.field.Nodes[0].Description = "FETCH"
            $query.field.Nodes[0].AuthDomainConfig = [RubrikSecurityCloud.Types.TenantAuthDomainConfig]::ALLOW_AUTH_DOMAIN_CONTROL
            $query.field.Nodes[0].ShouldEnforceMfaForAll = $true
            $query.field.Nodes[0].IsEnvoyRequired = $true
            $query.field.Nodes[0].AllowedClusters = "FETCH"
            $query.field.Nodes[0].TenantNetworkHealth =  [RubrikSecurityCloud.Types.TenantNetworkHealth]::TENANT_NETWORK_HEALTH_UNSPECIFIED
            $query.field.Nodes[0].HasOwnIdpConfigured = $true
            $query.field.Nodes[0].IsServiceAccountDisabled = $true
            $query.field.Nodes[0].OrgAdminRole = $roleTempQuery.field[0]
            $query.field.Nodes[0].Users = New-Object -TypeName RubrikSecurityCloud.Types.ExistingUser
            $query.field.Nodes[0].Users[0].id = "FETCH"
            $query.field.Nodes[0].Users[0].isOrgAdmin = $true
            $query.field.Nodes[0].Users[0].user = New-Object -TypeName RubrikSecurityCloud.Types.User
            $query.field.Nodes[0].Users[0].user.email = "FETCH"
            $query.field.Nodes[0].Users[0].user.id = "FETCH"
            $query.field.Nodes[0].Permissions = $roleTempQuery.field[0].Permissions[0]
            $query.field.Nodes[0].SelfServicePermissions = New-Object -TypeName RubrikSecurityCloud.Types.SelfServicePermission
            $query.field.Nodes[0].SsoGroups = New-Object -TypeName RubrikSecurityCloud.Types.SsoGroup
            $query.field.Nodes[0].PhysicalStorageUsed = 1
            $query.field.Nodes[0].AllUrls = "FETCH"
            # "ClusterWithCapacityQuota" does not exist in the SDK
            # $query.Nodes[0].AllClusterCapacityQuotas = New-Object -TypeName RubrikSecurityCloud.Types.ClusterWithCapacityQuota
            $query.field.Nodes[0].CrossAccountCapabilities = [RubrikSecurityCloud.Types.CrossAccountCapability]::CROSS_ACCOUNT_CAPABILITY_UNSPECIFIED

            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    } 
}
