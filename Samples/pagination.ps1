<#
.SYNOPSIS
    Paginating through large result sets.

.DESCRIPTION
    This sample demonstrates cursor-based pagination using
    first/after variables and PageInfo fields.

    See also: docs/HOWTO_pagination.md

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

Connect-Rsc

# ------------------------------------------------------------------
# Paginate through all clusters
# ------------------------------------------------------------------
$pageSize = 10
$allClusters = @()

$q = New-RscQuery -Gql clusterConnection `
    -Var @{ first = $pageSize } `
    -AddField PageInfo.HasNextPage, PageInfo.EndCursor

$page = 0
do {
    $page++
    $result = $q | Invoke-Rsc
    $allClusters += $result.Nodes
    Write-Host "Page $page : fetched $($result.Nodes.Count) clusters (total so far: $($allClusters.Count) of $($result.Count))"

    # Advance to the next page
    $q.Var.after = $result.PageInfo.EndCursor
} while ($result.PageInfo.HasNextPage)

Write-Host "`nAll $($allClusters.Count) clusters retrieved:"
$allClusters | Select-Object Id, Name, Status | Format-Table -AutoSize

Disconnect-Rsc
