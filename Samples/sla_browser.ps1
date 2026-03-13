<#
.SYNOPSIS
    Interactive TUI for browsing SLA domains page by page.

.DESCRIPTION
    Demonstrates server-side cursor pagination with on-demand fetching,
    sorting, and filtering — all driven by the RSC GraphQL API.

    Each page is fetched only when navigated to; visited pages are cached
    so going backward is instant. When you land on a page, the next page
    is prefetched synchronously into cache so forward feels instant too.

    Changing sort or filter resets pagination and re-queries the API.

    Controls:
      H / Home         — first page
      N / Right arrow  — next page
      P / Left arrow   — previous page
      S                — cycle sort field (Name / Protected / Retention)
      O                — toggle sort order (Asc / Desc)
      F                — set name filter (text search)
      C                — clear filter
      D                — toggle last column: Description / Id
      Q / Esc          — quit

    TUI drawing helpers (box chars, Write-Row, Write-NavBar, etc.)
    live in SampleUtils.ps1.

.NOTES
    Prerequisites:
    - Install-Module RubrikSecurityCloud
    - Set-RscServiceAccountFile /path/to/service_account.json
#>

. "$PSScriptRoot/SampleUtils.ps1"

Connect-Rsc

try {

$B = $Script:BoxChars  # shorthand

# ══════════════════════════════════════════════════════════════════════
# Configuration
# ══════════════════════════════════════════════════════════════════════

$pageSize = 10

$sortFields = @(
    [RubrikSecurityCloud.Types.SlaQuerySortByField]::NAME,
    [RubrikSecurityCloud.Types.SlaQuerySortByField]::PROTECTED_OBJECT_COUNT,
    [RubrikSecurityCloud.Types.SlaQuerySortByField]::RETENTION
)
$sortFieldLabels = @("Name", "Protected", "Retention")

# ══════════════════════════════════════════════════════════════════════
# Pagination state
# ══════════════════════════════════════════════════════════════════════

$script:pageCache   = [System.Collections.ArrayList]::new()
$script:cursorCache = [System.Collections.ArrayList]::new()
$script:totalItems  = $null
$script:totalPages  = $null
$script:currentPage = 0
$script:sortIndex   = 0
$script:sortOrder   = [RubrikSecurityCloud.Types.SortOrder]::ASC
$script:nameFilter  = ""
$script:statusMsg   = ""
$script:showId      = $false  # toggle: Description vs Id in last column

# ══════════════════════════════════════════════════════════════════════
# Query building — constructs the slaDomains query with current
# sort, filter, and field spec (using Get-RscType pattern from PR #231)
# ══════════════════════════════════════════════════════════════════════

function New-BrowserQuery {
    $vars = @{
        first     = $pageSize
        sortBy    = $sortFields[$script:sortIndex]
        sortOrder = $script:sortOrder
        shouldShowProtectedObjectCount = $true
    }

    if ($script:nameFilter -ne "") {
        $f = New-Object RubrikSecurityCloud.Types.GlobalSlaFilterInput
        $f.Field = [RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]::NAME
        $f.Text = $script:nameFilter
        $vars['filter'] = $f
    }

    $script:q = New-RscQuery -Gql slaDomains `
        -Var $vars `
        -AddField PageInfo.HasNextPage, PageInfo.EndCursor

    # Populate GlobalSlaReply field spec
    $gsr = $script:q.field.nodes |
        Where-Object { $_.GetType().Name -eq "GlobalSlaReply" } |
        Select-Object -First 1

    if ($null -ne $gsr) {
        $gsr.version = "FETCH"
        $gsr.description = "FETCH"
        $gsr.protectedObjectCount = 1
        $gsr.isDefault = $true
        $gsr.isRetentionLockedSla = $true
        $gsr.isReadOnly = $true
        $gsr.objectTypes = @([RubrikSecurityCloud.Types.SlaObjectType]::KUPR_OBJECT_TYPE)

        $gsr.SnapshotSchedule = Get-RscType -Name SnapshotSchedule -InitialProperties @(
            "minute.basicSchedule.frequency",
            "minute.basicSchedule.retention",
            "minute.basicSchedule.retentionUnit",
            "hourly.basicSchedule.frequency",
            "hourly.basicSchedule.retention",
            "hourly.basicSchedule.retentionUnit",
            "daily.basicSchedule.frequency",
            "daily.basicSchedule.retention",
            "daily.basicSchedule.retentionUnit",
            "weekly.basicSchedule.frequency",
            "weekly.basicSchedule.retention",
            "weekly.basicSchedule.retentionUnit",
            "monthly.basicSchedule.frequency",
            "monthly.basicSchedule.retention",
            "monthly.basicSchedule.retentionUnit",
            "quarterly.basicSchedule.frequency",
            "quarterly.basicSchedule.retention",
            "quarterly.basicSchedule.retentionUnit",
            "yearly.basicSchedule.frequency",
            "yearly.basicSchedule.retention",
            "yearly.basicSchedule.retentionUnit"
        )

        $gsr.baseFrequency = Get-RscType -Name Duration -InitialProperties @(
            "durationField", "unit"
        )
    }
}

# ══════════════════════════════════════════════════════════════════════
# Pagination logic — cursor-based, one page at a time, with cache
# ══════════════════════════════════════════════════════════════════════

function Reset-Pagination {
    $script:pageCache.Clear()
    $script:cursorCache.Clear()
    $script:totalItems  = $null
    $script:totalPages  = $null
    $script:currentPage = 0
    New-BrowserQuery
}

function Fetch-Page {
    param([int]$PageIndex)

    # Already cached
    if ($PageIndex -lt $script:pageCache.Count) { return }

    # Set cursor (page 0 has none)
    if ($PageIndex -eq 0) {
        $script:q.Var.Remove('after') | Out-Null
    } else {
        $script:q.Var.after = $script:cursorCache[$PageIndex - 1]
    }

    $result = $script:q | Invoke-Rsc

    # Capture totals on first fetch
    if ($null -eq $script:totalItems) {
        $script:totalItems = $result.Count
        $script:totalPages = [math]::Max(1, [math]::Ceiling($result.Count / $pageSize))
    }

    [void]$script:pageCache.Add(@($result.Nodes))
    [void]$script:cursorCache.Add($result.PageInfo.EndCursor)
}

function Prefetch-NextPage {
    $next = $script:currentPage + 1
    if ($null -ne $script:totalPages -and $next -ge $script:totalPages) { return }
    if ($next -lt $script:pageCache.Count) { return }
    Fetch-Page -PageIndex $next
}

# ══════════════════════════════════════════════════════════════════════
# SLA-specific formatters
# ══════════════════════════════════════════════════════════════════════

function Get-SnapshotFrequency {
    param($Sla)
    $s = $Sla.SnapshotSchedule
    if ($null -eq $s) { return "-" }
    if ($s.Minute -and $s.Minute.BasicSchedule)    { return "$($s.Minute.BasicSchedule.Frequency)min" }
    if ($s.Hourly -and $s.Hourly.BasicSchedule)    { return "$($s.Hourly.BasicSchedule.Frequency)h" }
    if ($s.Daily  -and $s.Daily.BasicSchedule)     { return "$($s.Daily.BasicSchedule.Frequency)d" }
    if ($s.Weekly -and $s.Weekly.BasicSchedule)    { return "$($s.Weekly.BasicSchedule.Frequency)w" }
    if ($s.Monthly -and $s.Monthly.BasicSchedule)  { return "$($s.Monthly.BasicSchedule.Frequency)mo" }
    if ($s.Quarterly -and $s.Quarterly.BasicSchedule) { return "$($s.Quarterly.BasicSchedule.Frequency)q" }
    if ($s.Yearly -and $s.Yearly.BasicSchedule)    { return "$($s.Yearly.BasicSchedule.Frequency)y" }
    return "-"
}

function Get-BaseFrequency {
    param($Sla)
    $bf = $Sla.BaseFrequency
    if ($null -eq $bf -or $null -eq $bf.DurationField) { return "-" }
    $u = switch ("$($bf.Unit)") {
        "MINUTES"  { "min" }
        "HOURS"    { "h" }
        "DAYS"     { "d" }
        "WEEKS"    { "w" }
        "MONTHS"   { "mo" }
        "QUARTERS" { "q" }
        "YEARS"    { "y" }
        default    { "$($bf.Unit)" }
    }
    return "$($bf.DurationField)$u"
}

# ══════════════════════════════════════════════════════════════════════
# Render — assembles the TUI using helpers from SampleUtils.ps1
# ══════════════════════════════════════════════════════════════════════

function Render-Page {
    Clear-Host

    $width = Get-TerminalWidth
    $displayPage  = $script:currentPage + 1
    $totalDisplay = if ($null -ne $script:totalPages) { "$($script:totalPages)" } else { "?" }

    # ── Column widths (6 columns, overhead = 6*2 padding + 5 sep + 2 border = 19)
    $freqW = 6; $baseW = 6; $protW = 10; $typeW = 5
    $overhead = 19
    $flexW = $width - ($freqW + $baseW + $protW + $typeW) - $overhead
    $nameW = [math]::Floor($flexW * 0.40)
    $descW = $flexW - $nameW

    $colW   = @($nameW, $freqW, $baseW, $protW, $typeW, $descW)
    $aligns = @("L",     "L",    "L",    "R",    "L",    "L")
    $innerW = $width - 2

    # ── Title bar ─────────────────────────────────────────────────────
    $sortLabel  = $sortFieldLabels[$script:sortIndex]
    $orderArrow = if ($script:sortOrder -eq [RubrikSecurityCloud.Types.SortOrder]::ASC) { [char]0x25B2 } else { [char]0x25BC }
    $filterPart = if ($script:nameFilter -ne "") { "  Filter: `"$($script:nameFilter)`"" } else { "" }

    $rscLabel = "Rubrik Security Cloud"
    $title    = "${rscLabel}   SLA Browser   Sort: $sortLabel $orderArrow$filterPart"
    $titlePad = [math]::Max(0, $innerW - $title.Length)
    $lp = [math]::Floor($titlePad / 2)
    $rp = $titlePad - $lp

    Write-Host -ForegroundColor DarkCyan (Make-SimpleLine $B.TL $B.TR $innerW)
    Write-Host -ForegroundColor DarkCyan -NoNewline "$($B.V)"
    Write-Host -NoNewline (" " * $lp)
    Write-Host -ForegroundColor Cyan -NoNewline $rscLabel
    Write-Host -ForegroundColor Yellow -NoNewline $title.Substring($rscLabel.Length)
    Write-Host -NoNewline (" " * $rp)
    Write-Host -ForegroundColor DarkCyan "$($B.V)"

    # ── Column headers ────────────────────────────────────────────────
    Write-Host -ForegroundColor DarkCyan (Make-HLine $B.LT $B.TT $B.RT $colW)
    $lastCol = if ($script:showId) { "Id" } else { "Description" }
    Write-Row -Cells @("Name","Freq","Base","Protected","Type",$lastCol) `
              -Colors @("Green","Green","Green","Green","Green","Green") `
              -Aligns $aligns -ColWidths $colW
    Write-Host -ForegroundColor DarkCyan (Make-HLine $B.LT $B.X $B.RT $colW)

    # ── Data rows ─────────────────────────────────────────────────────
    $nodes = @()
    if ($script:currentPage -lt $script:pageCache.Count) {
        $nodes = $script:pageCache[$script:currentPage]
    }

    $rowIdx = 0
    foreach ($sla in $nodes) {
        $lastVal = if ($script:showId) { Truncate-String $sla.Id $descW } else { Truncate-String $sla.Description $descW }
        $vals = @(
            (Truncate-String $sla.Name $nameW),
            (Get-SnapshotFrequency $sla),
            (Get-BaseFrequency $sla),
            $(if ($null -ne $sla.ProtectedObjectCount) { "$($sla.ProtectedObjectCount)" } else { "-" }),
            $(if ($sla.IsDefault) { "Def" } elseif ($sla.IsReadOnly) { "RO" } else { "" }),
            $lastVal
        )
        $rowColor  = if ($rowIdx % 2 -eq 0) { "White" } else { "Gray" }
        $protColor = if ($null -ne $sla.ProtectedObjectCount -and $sla.ProtectedObjectCount -gt 0) { "Cyan" } else { "DarkGray" }
        $typeColor = if ($sla.IsDefault) { "Magenta" } else { "DarkGray" }

        Write-Row -Cells $vals `
                  -Colors @($rowColor, "DarkYellow", "DarkYellow", $protColor, $typeColor, $rowColor) `
                  -Aligns $aligns -ColWidths $colW
        $rowIdx++
    }

    # ── Empty rows ────────────────────────────────────────────────────
    $empty = @("","","","","","")
    $dimC  = @("DarkCyan","DarkCyan","DarkCyan","DarkCyan","DarkCyan","DarkCyan")
    for ($i = $rowIdx; $i -lt $pageSize; $i++) {
        Write-Row -Cells $empty -Colors $dimC -Aligns $aligns -ColWidths $colW
    }

    # ── Nav bar ───────────────────────────────────────────────────────
    Write-Host -ForegroundColor DarkCyan (Make-HLine $B.LT $B.BT $B.RT $colW)

    $canPrev = $script:currentPage -gt 0
    $canNext = $null -eq $script:totalPages -or ($script:currentPage + 1) -lt $script:totalPages
    $hasFilt = $script:nameFilter -ne ""

    $navParts = @(
        @{ key="H"; label="Home";   color=$(if($canPrev){"White"}else{"DarkGray"}); dim=$(if($canPrev){"Gray"}else{"DarkGray"}) },
        @{ key="P"; label="Prev";   color=$(if($canPrev){"White"}else{"DarkGray"}); dim=$(if($canPrev){"Gray"}else{"DarkGray"}) },
        @{ key="N"; label="Next";   color=$(if($canNext){"White"}else{"DarkGray"}); dim=$(if($canNext){"Gray"}else{"DarkGray"}) },
        @{ key="S"; label="Sort";   color="White"; dim="Gray" },
        @{ key="O"; label="Order";  color="White"; dim="Gray" },
        @{ key="F"; label="Filter"; color="White"; dim="Gray" },
        @{ key="C"; label="Clear";  color=$(if($hasFilt){"White"}else{"DarkGray"}); dim=$(if($hasFilt){"Gray"}else{"DarkGray"}) },
        @{ key="D"; label=$(if($script:showId){"Desc"}else{"Id"}); color="White"; dim="Gray" },
        @{ key="Q"; label="Quit";   color="White"; dim="Gray" }
    )

    $itemCount  = @($nodes).Count
    $rangeStart = $script:currentPage * $pageSize + 1
    $rangeEnd   = $script:currentPage * $pageSize + $itemCount
    $pageInfo   = if ($null -ne $script:totalItems) { "$rangeStart-$rangeEnd of $($script:totalItems)  [$displayPage/$totalDisplay]" } else { "" }

    Write-NavBar -NavParts $navParts -PageInfo $pageInfo -InnerWidth $innerW

    # ── Bottom border ─────────────────────────────────────────────────
    Write-Host -ForegroundColor DarkCyan (Make-SimpleLine $B.BL $B.BR $innerW)

    if ($script:statusMsg -ne "") {
        Write-Host -ForegroundColor Yellow " $($script:statusMsg)"
        $script:statusMsg = ""
    }
}

# ══════════════════════════════════════════════════════════════════════
# Main loop — keyboard-driven navigation
# ══════════════════════════════════════════════════════════════════════

New-BrowserQuery
Write-Host -ForegroundColor Yellow " Loading first page..."
Fetch-Page -PageIndex 0
Render-Page
Prefetch-NextPage

[Console]::TreatControlCAsInput = $true

while ($true) {
    $key = [Console]::ReadKey($true)

    # Quit
    if ($key.Key -eq [System.ConsoleKey]::Q -or
        $key.Key -eq [System.ConsoleKey]::Escape -or
        ($key.Key -eq [System.ConsoleKey]::C -and
         $key.Modifiers -eq [System.ConsoleModifiers]::Control)) {
        break
    }

    # Home
    if ($key.Key -eq [System.ConsoleKey]::H -or
        $key.Key -eq [System.ConsoleKey]::Home) {
        if ($currentPage -ne 0) {
            $currentPage = 0
            Render-Page
        }
        continue
    }

    # Next
    if ($key.Key -eq [System.ConsoleKey]::RightArrow -or
        $key.Key -eq [System.ConsoleKey]::N) {
        if ($null -ne $totalPages -and ($currentPage + 1) -lt $totalPages) {
            $currentPage++
            if ($currentPage -ge $pageCache.Count) {
                $script:statusMsg = "Loading page $($currentPage + 1)..."
                Render-Page
                Fetch-Page -PageIndex $currentPage
            }
            Render-Page
            Prefetch-NextPage
        }
        continue
    }

    # Prev
    if ($key.Key -eq [System.ConsoleKey]::LeftArrow -or
        $key.Key -eq [System.ConsoleKey]::P) {
        if ($currentPage -gt 0) { $currentPage--; Render-Page }
        continue
    }

    # Sort field
    if ($key.Key -eq [System.ConsoleKey]::S) {
        $script:sortIndex = ($script:sortIndex + 1) % $sortFields.Count
        $script:statusMsg = "Sorting by $($sortFieldLabels[$script:sortIndex])..."
        Render-Page; Reset-Pagination; Fetch-Page -PageIndex 0; Render-Page; Prefetch-NextPage
        continue
    }

    # Sort order
    if ($key.Key -eq [System.ConsoleKey]::O) {
        $script:sortOrder = if ($script:sortOrder -eq [RubrikSecurityCloud.Types.SortOrder]::ASC) {
            [RubrikSecurityCloud.Types.SortOrder]::DESC } else { [RubrikSecurityCloud.Types.SortOrder]::ASC }
        $label = if ($script:sortOrder -eq [RubrikSecurityCloud.Types.SortOrder]::ASC) { "Ascending" } else { "Descending" }
        $script:statusMsg = "Sort order: $label..."
        Render-Page; Reset-Pagination; Fetch-Page -PageIndex 0; Render-Page; Prefetch-NextPage
        continue
    }

    # Filter
    if ($key.Key -eq [System.ConsoleKey]::F -and $key.Modifiers -ne [System.ConsoleModifiers]::Control) {
        [Console]::TreatControlCAsInput = $false
        Write-Host ""
        Write-Host -ForegroundColor Yellow -NoNewline " Filter by name (empty to clear): "
        $userInput = Read-Host
        [Console]::TreatControlCAsInput = $true
        $script:nameFilter = $userInput.Trim()
        $script:statusMsg = if ($script:nameFilter -ne "") { "Filtering by `"$($script:nameFilter)`"..." } else { "Filter cleared." }
        Render-Page; Reset-Pagination; Fetch-Page -PageIndex 0; Render-Page; Prefetch-NextPage
        continue
    }

    # Toggle Description / Id
    if ($key.Key -eq [System.ConsoleKey]::D -and $key.Modifiers -ne [System.ConsoleModifiers]::Control) {
        $script:showId = -not $script:showId
        Render-Page
        continue
    }

    # Clear filter
    if ($key.Key -eq [System.ConsoleKey]::C -and $key.Modifiers -ne [System.ConsoleModifiers]::Control) {
        if ($script:nameFilter -ne "") {
            $script:nameFilter = ""
            $script:statusMsg = "Filter cleared."
            Render-Page; Reset-Pagination; Fetch-Page -PageIndex 0; Render-Page; Prefetch-NextPage
        }
        continue
    }
}

Clear-Host
Write-Host "Bye!"

} catch {
    Write-Warning "Error: $_"
} finally {
    [Console]::TreatControlCAsInput = $false
    Disconnect-Rsc
}
