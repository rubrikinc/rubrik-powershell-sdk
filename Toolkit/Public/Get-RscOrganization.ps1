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

        # Shared helper: populate Org field spec.
        # $roleTempQuery is used to borrow a fully populated Role object for
        # OrgAdminRole and Permissions fields — cheaper than building one manually.
        function Set-OrgFields($org) {
            $roleTempQuery = New-RscQuery -Gql getRolesByIds -FieldProfile FULL
            $org.Id = "FETCH"
            $org.Name = "FETCH"
            $org.FullName = "FETCH"
            $org.Description = "FETCH"
            $org.AuthDomainConfig = [RubrikSecurityCloud.Types.TenantAuthDomainConfig]::ALLOW_AUTH_DOMAIN_CONTROL
            $org.ShouldEnforceMfaForAll = $true
            $org.IsEnvoyRequired = $true
            $org.AllowedClusters = "FETCH"
            $org.TenantNetworkHealth = [RubrikSecurityCloud.Types.TenantNetworkHealth]::TENANT_NETWORK_HEALTH_UNSPECIFIED
            $org.HasOwnIdpConfigured = $true
            $org.IsServiceAccountDisabled = $true
            $org.OrgAdminRole = $roleTempQuery.field[0]
            $org.Users = Get-RscType -Name ExistingUser -InitialProperties @("id", "isOrgAdmin", "user.email", "user.id")
            $org.Permissions = $roleTempQuery.field[0].Permissions[0]
            $org.SelfServicePermissions = Get-RscType -Name SelfServicePermission -InitialProperties @("*")
            $org.SsoGroups = Get-RscType -Name SsoGroup -InitialProperties @("*")
            $org.PhysicalStorageUsed = 1
            $org.AllUrls = "FETCH"
            $org.CrossAccountCapabilities = @([RubrikSecurityCloud.Types.CrossAccountCapability]::CROSS_ACCOUNT_CAPABILITY_UNSPECIFIED)
        }

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -Gql org
            $query.var.orgId = $Id
            Set-OrgFields $query.field

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql orgs
            if ($Name) {
                $query.var.nameFilter = $Name
            }
            Set-OrgFields $query.field.Nodes[0]

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    }
}
