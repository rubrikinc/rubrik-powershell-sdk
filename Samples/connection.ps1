<#
.SYNOPSIS
    Connecting to RSC and running a simple query.

.DESCRIPTION
    This sample demonstrates:
    1. Connecting to RSC using a service account file
    2. Running a query with New-RscQuery -Gql
    3. Disconnecting from RSC

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

# --- Connect ---
# Connect-Rsc reuses an existing session or creates a new one.
# Call it at the top of every script — it's safe to call repeatedly.
Connect-Rsc

# --- Check version ---
$version = Get-RscVersion
Write-Host "SDK schema: $($version.SdkSchemaVersion)  Server: $($version.ServerVersion)"

# --- Run a simple query ---
# List clusters using the GraphQL query name directly
$result = New-RscQuery -Gql clusterConnection -Var @{ first = 5 } | Invoke-Rsc
Write-Host "`nFirst $($result.Nodes.Count) of $($result.Count) clusters:"
$result.Nodes | Select-Object Id, Name, Status | Format-Table -AutoSize

# --- Disconnect ---
Disconnect-Rsc
