#Requires -Version 3
function Get-RscOrganization {
    <#
    .SYNOPSIS
    Retrieves organizations defined in Rubrik Security Cloud.

    .DESCRIPTION
    Returns RSC organizations, which provide multi-tenant separation of users,
    permissions, and objects. Use -Name to filter by organization name or -Id
    to retrieve a specific organization. The output can be piped to workload
    cmdlets to filter by organization.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    The RSC object ID.

    .PARAMETER Name
    Filter by name. Matches organizations whose name contains the specified string.

    .EXAMPLE
    # Get all organizations
    Get-RscOrganization

    .EXAMPLE
    # Get an organization by name
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
        [String]$Id,
        [Parameter(
            Position = 0,
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
       # The query is different for getting a single object by ID.
        if ($Id) {
            $roleTempQuery = New-RscQuery -Gql getRolesByIds -FieldProfile FULL
            $query = New-RscQuery -Gql org
            $query.var.orgId = $Id
            $query.field.Id = "tacos"
            $query.field.Name = "FETCH"
            $query.field.FullName = "FETCH"
            $query.field.Description = "FETCH"
            $query.field.AuthDomainConfig = [RubrikSecurityCloud.Types.TenantAuthDomainConfig]::ALLOW_AUTH_DOMAIN_CONTROL
            $query.field.ShouldEnforceMfaForAll = $true
            $query.field.IsEnvoyRequired = $true
            $query.field.AllowedClusters = "FETCH"
            $query.field.TenantNetworkHealth =  [RubrikSecurityCloud.Types.TenantNetworkHealth]::TENANT_NETWORK_HEALTH_UNSPECIFIED
            $query.field.HasOwnIdpConfigured = $true
            $query.field.IsServiceAccountDisabled = $true
            $query.field.OrgAdminRole = $roleTempQuery.field[0]
            $query.field.Users = New-Object -TypeName RubrikSecurityCloud.Types.ExistingUser
            $query.field.Users[0].id = "FETCH"
            $query.field.Users[0].isOrgAdmin = $true
            $query.field.Users[0].user = New-Object -TypeName RubrikSecurityCloud.Types.User
            $query.field.Users[0].user.email = "FETCH"
            $query.field.Users[0].user.id = "FETCH"
            $query.field.Permissions = $roleTempQuery.field[0].Permissions[0]
            $query.field.SelfServicePermissions = New-Object -TypeName RubrikSecurityCloud.Types.SelfServicePermission
            $query.field.SsoGroups = New-Object -TypeName RubrikSecurityCloud.Types.SsoGroup
            $query.field.PhysicalStorageUsed = 1
            $query.field.AllUrls = "FETCH"
            # "ClusterWithCapacityQuota" does not exist in the SDK
            # $query.Nodes[0].AllClusterCapacityQuotas = New-Object -TypeName RubrikSecurityCloud.Types.ClusterWithCapacityQuota
            $query.field.CrossAccountCapabilities = @([RubrikSecurityCloud.Types.CrossAccountCapability]::CROSS_ACCOUNT_CAPABILITY_UNSPECIFIED)

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql orgs
            if ($Name) {
                $query.var.nameFilter = $Name
            }

            # I'm using these to populate all fields instead of doing them individually.
            $roleTempQuery = New-RscQuery -Gql getRolesByIds -FieldProfile FULL

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
            $query.field.Nodes[0].CrossAccountCapabilities = @([RubrikSecurityCloud.Types.CrossAccountCapability]::CROSS_ACCOUNT_CAPABILITY_UNSPECIFIED)

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    }
}
