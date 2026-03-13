<#
.SYNOPSIS
    Working with RSC clusters.

.DESCRIPTION
    Interactive sample that demonstrates cluster operations:
    1. List all clusters (Get-RscCluster)
    2. Limit results with -First
    3. Low-level equivalent using New-RscQuery -Gql clusterConnection

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

. "$PSScriptRoot/SampleUtils.ps1"

Connect-Rsc

try {

# ------------------------------------------------------------------
# 1. List all clusters
# ------------------------------------------------------------------
Write-Title "|  Step 1: List all clusters  |"

Write-Message -GreenMessage "Retrieving all clusters with Get-RscCluster..."

$clusters = Get-RscCluster
Write-Message -GreenMessage "Retrieved $($clusters.Count) cluster(s)."
$clusters | Select-Object Id, Name, Status, Type | Format-Table -AutoSize

Write-Code -Pause -CodeSnippet @'
$clusters = Get-RscCluster
$clusters | Select-Object Id, Name, Status, Type | Format-Table -AutoSize
'@

# ------------------------------------------------------------------
# 2. Limit results with -First
# ------------------------------------------------------------------
Write-Title "|  Step 2: Limit results with -First  |"

Write-Message -GreenMessage "Retrieving only the first cluster..."

$first = Get-RscCluster -First 1
Write-Message -GreenMessage "Cluster:" `
    -YellowMessage "  Name: $($first.Name)`n  Id:   $($first.Id)`n  Status: $($first.Status)"

Write-Code -Pause -CodeSnippet @'
$cluster = Get-RscCluster -First 1
$cluster | Format-List Name, Id, Status, Type, Version
'@

# ------------------------------------------------------------------
# 3. Low-level: New-RscQuery -Gql clusterConnection
# ------------------------------------------------------------------
Write-Title "|  Step 3: Low-level query  |"

Write-Message -GreenMessage "Using New-RscQuery -Gql clusterConnection..." `
    -YellowMessage "  This is the GraphQL query that Get-RscCluster wraps."

$result = New-RscQuery -Gql clusterConnection -Var @{ first = 5 } | Invoke-Rsc
Write-Message -GreenMessage "First $(@($result.Nodes).Count) of $($result.Count) clusters:"
$result.Nodes | Select-Object Id, Name, Status | Format-Table -AutoSize

Write-Code -Pause -CodeSnippet @'
$result = New-RscQuery -Gql clusterConnection -Var @{ first = 5 } | Invoke-Rsc
$result.Nodes | Select-Object Id, Name, Status | Format-Table -AutoSize
$result.Count   # total clusters (even beyond 'first')
'@

Write-Title "|  Done!  |"

} catch {
    Write-Warning "Error: $_"
} finally {
    Disconnect-Rsc
}
