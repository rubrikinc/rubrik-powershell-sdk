<#
.SYNOPSIS
    Paginating through large result sets.

.DESCRIPTION
    Interactive sample that demonstrates pagination:
    1. Automatic pagination — Invoke-Rsc fetches all pages internally
    2. Limiting total results with the 'first' variable
    3. Manual cursor-based pagination for per-page control

    See also: docs/HOWTO_pagination.md

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

. "$PSScriptRoot/SampleUtils.ps1"

Connect-Rsc

try {

# ------------------------------------------------------------------
# 1. Automatic pagination (recommended)
# ------------------------------------------------------------------
Write-Title "|  Step 1: Automatic pagination  |"

Write-Message -GreenMessage "Invoke-Rsc fetches all pages internally." `
    -YellowMessage "  You get back the complete result set in one call."

$result = New-RscQuery -Gql slaDomains -Var @{ first = 100 } | Invoke-Rsc
Write-Message -GreenMessage "Retrieved $(@($result.Nodes).Count) SLAs (of $($result.Count) total)."

$allSlas = Get-RscSla -First 100
Write-Message -YellowMessage "  Get-RscSla -First 100 returned $(@($allSlas).Count) SLAs."

Write-Code -Pause -CodeSnippet @'
# Invoke-Rsc handles all pages automatically.
# 'first' caps the total items returned:
$result = New-RscQuery -Gql slaDomains -Var @{ first = 100 } | Invoke-Rsc
$result.Nodes | Select-Object Id, Name | Format-Table -AutoSize
$result.Count   # total matching objects (even beyond 'first')

# Toolkit wrappers also auto-paginate:
$allSlas = Get-RscSla           # all SLAs
$allSlas = Get-RscSla -First 100  # cap at 100
'@

# ------------------------------------------------------------------
# 2. Limiting total results
# ------------------------------------------------------------------
Write-Title "|  Step 2: Limiting total results  |"

Write-Message -GreenMessage "Set 'first' to cap the total number of items returned."

$result = New-RscQuery -Gql slaDomains -Var @{ first = 5 } | Invoke-Rsc
Write-Message -GreenMessage "Requested first 5:" `
    -YellowMessage "  Got $(@($result.Nodes).Count) SLAs (out of $($result.Count) total)"
$result.Nodes | Select-Object Id, Name | Format-Table -AutoSize

Write-Code -Pause -CodeSnippet @'
# 'first' limits the total items returned (not per-page):
$result = New-RscQuery -Gql slaDomains -Var @{ first = 5 } | Invoke-Rsc
$result.Nodes.Count  # 5 (or fewer if less exist)
$result.Count        # total matching objects
'@

# ------------------------------------------------------------------
# 3. Manual cursor-based pagination
# ------------------------------------------------------------------
Write-Title "|  Step 3: Manual cursor-based pagination  |"

Write-Message -GreenMessage "For per-page control, loop with first/after." `
    -YellowMessage "  Useful when you need to process each page separately`n  (e.g. progress reporting, early exit, memory constraints)."

$pageSize = 10
$maxItems = 100
$allNodes = @()

$q = New-RscQuery -Gql slaDomains `
    -Var @{ first = $pageSize } `
    -AddField PageInfo.HasNextPage, PageInfo.EndCursor

$page = 0
do {
    $page++
    $result = $q | Invoke-Rsc
    $allNodes += $result.Nodes
    Write-Message -YellowMessage "  Page ${page}: fetched $(@($result.Nodes).Count) items (total so far: $($allNodes.Count) of $($result.Count))"

    if ($allNodes.Count -ge $maxItems) {
        Write-Message -YellowMessage "  Reached $maxItems item limit — stopping early."
        break
    }

    # Advance cursor to next page
    $q.Var.after = $result.PageInfo.EndCursor
} while ($result.PageInfo.HasNextPage)

Write-Message -GreenMessage "Retrieved $($allNodes.Count) items across $page pages."

Write-Code -Pause -CodeSnippet @'
$pageSize = 10
$maxItems = 100
$allNodes = @()
$q = New-RscQuery -Gql slaDomains `
    -Var @{ first = $pageSize } `
    -AddField PageInfo.HasNextPage, PageInfo.EndCursor

do {
    $result = $q | Invoke-Rsc
    $allNodes += $result.Nodes
    if ($allNodes.Count -ge $maxItems) { break }
    $q.Var.after = $result.PageInfo.EndCursor
} while ($result.PageInfo.HasNextPage)
'@

Write-Title "|  Done!  |"

} catch {
    Write-Warning "Error: $_"
} finally {
    Disconnect-Rsc
}
