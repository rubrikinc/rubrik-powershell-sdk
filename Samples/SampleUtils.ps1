###########################################################################
# SampleUtils.ps1 — Shared helpers for SDK sample scripts
###########################################################################

$nl = [System.Environment]::NewLine

# ═══════════════════════════════════════════════════════════════════════
# Step-by-step sample helpers (used by clusters, pagination, sla_lifecycle)
# ═══════════════════════════════════════════════════════════════════════

function Write-Title {
    param (
        [string]$Title
    )
    Clear-Host
    $width = (Get-Host).UI.RawUI.WindowSize.Width
    $title = "|  $Title  |"
    $titleIndent = (" " * (($width - $Title.Length) / 2))
    $titleLine = "+" + "-" * ($Title.Length - 2) + "+"
    Write-Host $titleIndent -NoNewline
    Write-Host -ForegroundColor Green $titleLine
    Write-Host $titleIndent -NoNewline
    Write-Host -ForegroundColor Green $Title
    Write-Host $titleIndent -NoNewline
    Write-Host -ForegroundColor Green $titleLine
}

function Write-IndentedWrappedMessage {
    param(
        [Parameter(Mandatory=$true)]
        [string] $Message,

        [Parameter(Mandatory=$false)]
        [System.ConsoleColor] $Color = $null,

        [Parameter(Mandatory=$false)]
        [int] $Indent = 2,

        [Parameter(Mandatory=$false)]
        [int] $Width =  80
    )

    if ($Host.UI -and $Host.UI.RawUI) {
        $Width = $Host.UI.RawUI.BufferSize.Width
    }

    $indentString = " " * $Indent
    $width = $Width - $Indent
    $lines = $Message -split "`n"
    foreach ($line in $lines) {
        $words = $line -split ' '
        $buffer = $indentString
        foreach ($word in $words) {
            if (($buffer + $word).Length -gt $Width) {
                Write-Color -Message $buffer -Color $Color
                $buffer = $indentString + $word + ' '
            } else {
                $buffer += $word + ' '
            }
        }
        Write-Color -Message $buffer -Color $Color
    }
}

function Write-Color {
    param(
        [Parameter(Mandatory=$true)]
        [string] $Message,

        [Parameter(Mandatory=$false)]
        [System.ConsoleColor] $Color = $null
    )

    if ($null -eq $Color) {
        Write-Host $Message
    } else {
        Write-Host $Message -ForegroundColor $Color
    }
}

function Write-Message {
    param (
        [string]$GreenMessage,
        [string]$YellowMessage,
        [string]$BlueMessage,
        # Optional parameter to pause after displaying the code
        [switch]$Pause
    )
    if ($GreenMessage) {
        Write-Color "$GreenMessage " Green
    }
    if ($YellowMessage) {
        Write-IndentedWrappedMessage "$YellowMessage" Yellow
    }
    if ($BlueMessage) {
        Write-IndentedWrappedMessage "$BlueMessage" Blue
    }
    Write-Host
    if ($Pause) {
        Wait-ForKey
    }
}

function Write-Code {
    param (
        [switch]$Pause,
        [string]$CodeSnippet
    )
    Write-Host -ForegroundColor Green "$nl PS > $CodeSnippet $nl"
    if ($Pause) {
        Wait-ForKey
    }
}

function Wait-ForKey {
    $Continue = "  Press any key to continue, or ESC to exit..  "
    Write-Host -NoNewline -BackgroundColor DarkGray -ForegroundColor White $Continue
    [Console]::TreatControlCAsInput = $true
    $key = [Console]::ReadKey($false)
    Write-Host "`r$('-' * ($Continue.Length + 1))`r"
    if ($key.Key -eq [System.ConsoleKey]::Escape -or ($key.Key -eq [System.ConsoleKey]::C -and $key.Modifiers -eq [System.ConsoleModifiers]::Control)) {
        exit
    }
}

# ═══════════════════════════════════════════════════════════════════════
# TUI table helpers (used by sla_browser and similar interactive samples)
# ═══════════════════════════════════════════════════════════════════════

# ── Box-drawing characters ────────────────────────────────────────────
$Script:BoxChars = @{
    TL = [char]0x250C; TR = [char]0x2510  # ┌ ┐
    BL = [char]0x2514; BR = [char]0x2518  # └ ┘
    H  = [char]0x2500; V  = [char]0x2502  # ─ │
    LT = [char]0x251C; RT = [char]0x2524  # ├ ┤
    TT = [char]0x252C; BT = [char]0x2534  # ┬ ┴
    X  = [char]0x253C                      # ┼
}

# ── ANSI escape sequences ────────────────────────────────────────────
$Script:Esc   = [char]0x1B
$Script:UlOn  = "$([char]0x1B)[4m"   # underline on
$Script:UlOff = "$([char]0x1B)[24m"  # underline off

# ── Terminal width (with 1-col margin to avoid wrapping) ─────────────
function Get-TerminalWidth {
    param([int]$Min = 80)
    $w = 100
    if ($Host.UI -and $Host.UI.RawUI -and $Host.UI.RawUI.WindowSize.Width -gt 0) {
        $w = $Host.UI.RawUI.WindowSize.Width
    }
    return [math]::Max($Min, $w - 1)
}

# ── String sanitization (strip newlines, tabs, control chars) ────────
function Sanitize-String {
    param([string]$Str)
    if ($null -eq $Str) { return "" }
    return ($Str -replace '[\r\n\t]+', ' ' -replace '  +', ' ').Trim()
}

# ── Truncate with ellipsis ───────────────────────────────────────────
function Truncate-String {
    param([string]$Str, [int]$MaxLen)
    $s = Sanitize-String $Str
    if ($s.Length -le $MaxLen) { return $s }
    return $s.Substring(0, $MaxLen - 1) + [char]0x2026
}

# ── Horizontal line with column separators ───────────────────────────
#    Make-HLine ┌ ┬ ┐ @(10, 6, 20)  →  ┌────────────┬────────┬──────────────────────┐
function Make-HLine {
    param(
        [char]$Left, [char]$Sep, [char]$Right,
        [int[]]$ColWidths
    )
    $B = $Script:BoxChars
    $parts = $ColWidths | ForEach-Object { "$($B.H)" * ($_ + 2) }
    return "${Left}$($parts -join $Sep)${Right}"
}

# ── Simple horizontal line (no column separators) ────────────────────
function Make-SimpleLine {
    param([char]$Left, [char]$Right, [int]$InnerWidth)
    $B = $Script:BoxChars
    return "${Left}$("$($B.H)" * $InnerWidth)${Right}"
}

# ── Write one table row ──────────────────────────────────────────────
#    Write-Row -Cells @("foo","bar") -Colors @("White","Cyan") -Aligns @("L","R") -ColWidths @(20,10)
function Write-Row {
    param(
        [string[]]$Cells,
        [string[]]$Colors,
        [string[]]$Aligns,
        [int[]]$ColWidths
    )
    $B = $Script:BoxChars
    Write-Host -ForegroundColor DarkCyan -NoNewline "$($B.V)"
    for ($c = 0; $c -lt $Cells.Count; $c++) {
        Write-Host -NoNewline " "
        $val = Sanitize-String $Cells[$c]
        $w = $ColWidths[$c]
        if ($val.Length -gt $w) { $val = $val.Substring(0, $w) }
        if ($Aligns[$c] -eq "R") { $cell = $val.PadLeft($w) } else { $cell = $val.PadRight($w) }
        Write-Host -ForegroundColor $Colors[$c] -NoNewline $cell
        Write-Host -ForegroundColor DarkCyan -NoNewline " "
        if ($c -lt $Cells.Count - 1) {
            Write-Host -ForegroundColor DarkCyan -NoNewline "$($B.V)"
        }
    }
    Write-Host -ForegroundColor DarkCyan "$($B.V)"
}

# ── Navigation bar with underlined hotkeys ───────────────────────────
#    Write-NavBar -NavParts @(@{key="N";label="Next";color="White";dim="Gray"}, ...)
#                 -PageInfo "1-10 of 570  [1/57]"
#                 -InnerWidth 120
function Write-NavBar {
    param(
        [array]$NavParts,
        [string]$PageInfo = "",
        [int]$InnerWidth
    )
    $B = $Script:BoxChars

    # Measure plain text: " label  label  ...label"
    $navPlain = " "
    foreach ($n in $NavParts) { $navPlain += "$($n.label)  " }
    $navPlain = $navPlain.TrimEnd(" ")
    $navGap = [math]::Max(2, $InnerWidth - $navPlain.Length - $PageInfo.Length - 1)

    # Render
    Write-Host -ForegroundColor DarkCyan -NoNewline "$($B.V)"
    Write-Host -NoNewline " "
    for ($ni = 0; $ni -lt $NavParts.Count; $ni++) {
        $n = $NavParts[$ni]
        $label = $n.label
        $keyIdx = $label.IndexOf($n.key, [System.StringComparison]::OrdinalIgnoreCase)

        if ($keyIdx -ge 0) {
            $before  = $label.Substring(0, $keyIdx)
            $keyChar = $label.Substring($keyIdx, 1)
            $after   = $label.Substring($keyIdx + 1)
            if ($before.Length -gt 0) { Write-Host -ForegroundColor $n.dim -NoNewline $before }
            Write-Host -ForegroundColor $n.color -NoNewline "$($Script:UlOn)${keyChar}$($Script:UlOff)"
            if ($after.Length -gt 0)  { Write-Host -ForegroundColor $n.dim -NoNewline $after }
        } else {
            Write-Host -ForegroundColor $n.dim -NoNewline $label
        }

        if ($ni -lt $NavParts.Count - 1) { Write-Host -NoNewline "  " }
    }
    Write-Host -NoNewline (" " * $navGap)
    Write-Host -ForegroundColor DarkYellow -NoNewline $PageInfo
    Write-Host -NoNewline " "
    Write-Host -ForegroundColor DarkCyan "$($B.V)"
}
