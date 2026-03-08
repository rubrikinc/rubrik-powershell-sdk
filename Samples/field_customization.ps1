<#
.SYNOPSIS
    Customizing field selection in queries.

.DESCRIPTION
    This sample demonstrates:
    1. Default field selection (AutoField)
    2. Adding fields with -AddField
    3. Using -FieldProfile for broader field sets
    4. Discovering available fields with -ValidPatchSet
    5. Manual field objects with -Field and -FieldProfile EMPTY

    See also: docs/autofield.md

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

Connect-Rsc

# ------------------------------------------------------------------
# 1. Default fields (AutoField DEFAULT profile)
# ------------------------------------------------------------------
Write-Host "=== DEFAULT fields ==="
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } | Invoke-Rsc
$result.Nodes[0] | Remove-NullProperties | Format-List

# ------------------------------------------------------------------
# 2. Add specific fields with -AddField
# ------------------------------------------------------------------
Write-Host "`n=== Adding Version and GeoLocation ==="
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -AddField Nodes.Version, Nodes.GeoLocation.Address | Invoke-Rsc
$result.Nodes[0] | Select-Object Name, Version | Format-List

# ------------------------------------------------------------------
# 3. Use DETAIL profile for more fields
# ------------------------------------------------------------------
Write-Host "`n=== DETAIL profile ==="
$result = New-RscQuery -Gql clusterConnection `
    -Var @{ first = 1 } `
    -FieldProfile DETAIL | Invoke-Rsc
$result.Nodes[0] | Remove-NullProperties | Format-List

# ------------------------------------------------------------------
# 4. Discover available fields with -ValidPatchSet
# ------------------------------------------------------------------
Write-Host "`n=== Available fields (first 20) ==="
$fields = New-RscQuery -Gql clusterConnection -ValidPatchSet
$fields | Select-Object -First 20

Write-Host "`n=== Fields matching 'snapshot' ==="
$fields | Where-Object { $_ -match "snapshot" }

# ------------------------------------------------------------------
# 5. Manual field object with EMPTY profile
# ------------------------------------------------------------------
Write-Host "`n=== Manual field selection (EMPTY + custom fields) ==="
$fieldObj = Get-RscType -Name ClusterConnection -InitialProperties @(
    "Nodes.Id", "Nodes.Name", "Nodes.Version", "Count"
)
$result = New-RscQuery -Gql clusterConnection `
    -Field $fieldObj `
    -FieldProfile EMPTY | Invoke-Rsc
Write-Host "Total clusters: $($result.Count)"
$result.Nodes | Select-Object Id, Name, Version | Format-Table -AutoSize

Disconnect-Rsc
