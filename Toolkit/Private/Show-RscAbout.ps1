#Requires -Version 3
function Show-RscAbout {
    <#
    .SYNOPSIS
    Display the RSC PowerShell SDK About page.

    .DESCRIPTION
    Shows an animated About page with the RSC PowerShell SDK logo,
    scrolling author credits, and animated decorations.
    Press any key to exit.

    Also callable via: Get-RscHelp -About

    .EXAMPLE
    Show-RscAbout
    #>
    [CmdletBinding()]
    param()

    $e = [char]27
    $RS = "$e[0m"
    $BO = "$e[1m"

    function _fg($n) { "$e[38;5;${n}m" }
    function _bg($n) { "$e[48;5;${n}m" }

    # ── Palette ──────────────────────────────────────────────────────
    $T1=_fg 23; $T2=_fg 30; $T3=_fg 37; $T4=_fg 44
    $T5=_fg 51; $T6=_fg 87; $TW=_fg 159

    $P4=_fg 27; $P5=_fg 33; $P6=_fg 39; $P7=_fg 75

    $WH=_fg 255; $GR=_fg 245; $DG=_fg 239; $VD=_fg 235; $YL=_fg 220

    $BG1=_bg 232

    # ── Terminal size & centering ────────────────────────────────────
    $tw = [Console]::WindowWidth
    $th = [Console]::WindowHeight
    $artW = 80; $artH = 31

    $ox = [Math]::Max(0, [Math]::Floor(($tw - $artW) / 2))
    $oy = [Math]::Max(0, [Math]::Floor(($th - $artH) / 2))

    # ── Drawing primitives ───────────────────────────────────────────
    function _At([int]$x, [int]$y) {
        [Console]::SetCursorPosition($ox + $x, $oy + $y)
    }

    function _W([string]$color, [string]$text) {
        Write-Host "${BG1}${color}${text}${RS}" -NoNewline
    }

    # ── Static elements ──────────────────────────────────────────────

    function _DrawBorder {
        _At 0 0
        Write-Host "${T2}╔$('═'*78)╗${RS}" -NoNewline
        _At 0 ($artH - 1)
        Write-Host "${T2}╚$('═'*78)╝${RS}" -NoNewline
        for ($y = 1; $y -lt ($artH - 1); $y++) {
            _At 0 $y
            Write-Host "${T2}║${BG1}$(' ' * 78)${RS}${T2}║${RS}" -NoNewline
        }
    }

    function _DrawTexture {
        _At 1 1;          _W $T1 ('░' * 78)
        _At 1 ($artH - 2); _W $T1 ('░' * 78)
    }

    function _DrawDivider {
        $y = 4
        _At 12 $y
        _W $T3 ('─' * 19)
        _W $T5 '◆'
        _W $T5 ('─' * 4)
        _W $T5 '◇ '
        _W $WH 'R S C'
        _W $T5 ' ◇'
        _W $T5 ('─' * 4)
        _W $T5 '◆'
        _W $T3 ('─' * 19)
    }

    function _DrawRSC {
        $rX = 10; $sX = 32; $cX = 54; $y0 = 6

        _At $rX $y0;       _W $P5 '▄▄▄▄▄▄▄▄▄▄▄▄▄▄'
        _At $sX $y0;       _W $P5 ' ▄▄▄▄▄▄▄▄▄▄▄▄ '
        _At $cX $y0;       _W $P5 ' ▄▄▄▄▄▄▄▄▄▄▄▄ '

        _At $rX ($y0+1);   _W $P6 '█'; _W $P4 '████████████'; _W $P6 '█'
        _At $sX ($y0+1);   _W $P6 '█'; _W $P4 '████████████'; _W $P6 '█'
        _At $cX ($y0+1);   _W $P6 '█'; _W $P4 '████████████'; _W $P6 '█'

        _At $rX ($y0+2);   _W $P7 '██'; _W '' '      '; _W $P4 '░▒██'
        _At $sX ($y0+2);   _W $P7 '██'; _W '' '      '; _W $P4 '░▒██'
        _At $cX ($y0+2);   _W $P7 '██'; _W '' '      '; _W $P4 '░░░░'

        _At $rX ($y0+3);   _W $P7 '██'; _W '' '     '; _W $P4 '░▒██'
        _At $sX ($y0+3);   _W $P7 '██'; _W '' '     '; _W $P4 '░▒██'
        _At $cX ($y0+3);   _W $P7 '██'

        _At $rX ($y0+4);   _W "$BO$P7" '████████████'; _W $P5 '▓▓'
        _At $sX ($y0+4);   _W $P5 '▓▓'; _W "$BO$P7" '██████████'; _W $P5 '▓▓'
        _At $cX ($y0+4);   _W $P7 '██'

        _At $rX ($y0+5);   _W $P7 '██'; _W $P6 '▓▓▓▓▓▓▓▓▓▓'; _W $P5 '▒▒'
        _At $sX ($y0+5);   _W $P5 '▒▒'; _W $P6 '▓▓▓▓▓▓▓▓▓▓'; _W $P5 '▒▒'
        _At $cX ($y0+5);   _W $P7 '██'

        _At $rX ($y0+6);   _W $P7 '██'; _W '' '   '; _W $P4 '▒███'
        _At ($sX+8) ($y0+6); _W $P4 '░▒██'
        _At $cX ($y0+6);   _W $P7 '██'; _W '' '      '; _W $P4 '░░░░'

        _At $rX ($y0+7);   _W $P7 '██'; _W '' '    '; _W $P4 '▒███'
        _At $sX ($y0+7);   _W $P7 '██'; _W '' '      '; _W $P4 '░▒██'
        _At $cX ($y0+7);   _W $P6 '█'; _W $P4 '████████████'; _W $P6 '█'

        _At $rX ($y0+8);   _W $P7 '██'; _W '' '     '; _W $P4 '▒███'
        _At $sX ($y0+8);   _W $P6 '█'; _W $P4 '████████████'; _W $P6 '█'
        _At $cX ($y0+8);   _W $P4 ' ░▒▓▓▓▓▓▓▓▓▓▓ '

        _At $rX ($y0+9);   _W $P4 '▀▀'; _W '' '      '; _W $P4 '▀▀▀▀'
        _At $sX ($y0+9);   _W $P4 ' ░▒▓▓▓▓▓▓▓▓▓▓ '
        _At $cX ($y0+9);   _W $P4 ' ▀▀▀▀▀▀▀▀▀▀▀▀ '
    }

    function _DrawPSBanner {
        $y = 17
        $bx = 17
        _At $bx $y;       _W $P4 '╔══╗'; _W $DG '░'; _W $P5 "◄$('▬'*33)►"; _W $DG '░'; _W $P4 '╔══╗'
        _At $bx ($y+1);   _W $P4 '║'; _W "$BO$P7" 'PS'; _W $P4 '║ '
                          _W "$BO$WH" 'P o w e r S h e l l    S D K'
                          _W '' '  '; _W $YL '⚡'; _W '' ' '
                          _W "$BO$T5" '>>'; _W '' ' '
                          _W $P4 '║'; _W "$BO$P7" 'PS'; _W $P4 '║'
        _At $bx ($y+2);   _W $P4 '╚══╝'; _W $DG '░'; _W $P5 "◄$('▬'*33)►"; _W $DG '░'; _W $P4 '╚══╝'
    }

    function _DrawPrompt {
        $y = 26
        $rightCol = 56
        _At 2 $y
        _W $P4 '┌──'; _W $P5 '('; _W $T5 'RSC'; _W $P5 ')'
        _W $P4 '──('; _W $YL '~'; _W $P4 ")$('─' * 41)"
        _At $rightCol $y
        _W $P4 '┐'
        _At 2 ($y + 1)
        _W $P4 '└─'
        _W $T5 '❯❯❯ '
        _W $GR 'Import-Module RubrikSecurityCloud'
        _W $VD '_'; _W $DG '▌'
        _At $rightCol ($y + 1)
        _W $P4 '│'
    }

    # ── Authors ──────────────────────────────────────────────────────
    # Regenerate: git -C ~/src/rubrikinc/rubrik-powershell-sdk log --format='%an' | sort | uniq -c | sort -rn
    # Then consolidate aliases (e.g. Gui/Guillaume → Gui Rava)
    $authors = @(
        @{ Name = 'Gui Rava';            Color = _fg 51  }
        @{ Name = 'Jake Robinson';       Color = _fg 220 }
        @{ Name = 'Evan Cheng';          Color = _fg 208 }
        @{ Name = 'Chris Lumnah';        Color = _fg 120 }
        @{ Name = 'Lokesh Kumar';        Color = _fg 177 }
        @{ Name = 'Aman Bedi';           Color = _fg 196 }
        @{ Name = 'Rynardt Spies';       Color = _fg 75  }
        @{ Name = 'Marsh Gardiner';      Color = _fg 215 }
        @{ Name = 'Shivakumar Suresh';   Color = _fg 87  }
    )

    $creditSegs = [System.Collections.ArrayList]::new()
    foreach ($a in $authors) {
        [void]$creditSegs.Add(@{ C = $a.Color; T = $a.Name })
        [void]$creditSegs.Add(@{ C = (_fg 240); T = '  ·  ' })
    }
    [void]$creditSegs.Add(@{ C = (_fg 220); T = ' ★ ' })

    $creditLen = 0
    foreach ($s in $creditSegs) { $creditLen += $s.T.Length }

    # ── Sparkle config ───────────────────────────────────────────────
    $sparklePos = @(
        @(5, 6),  @(5, 10), @(5, 14),
        @(7, 8),  @(7, 12),
        @(26, 5), @(48, 5),
        @(26, 16),@(48, 16),
        @(71, 6), @(71, 10),@(71, 14),
        @(73, 8), @(73, 12)
    )
    $sparkleGlyphs = @('✦', '✧', '⋆', '·')
    $sparkleColors = @((_fg 226), (_fg 220), (_fg 51), (_fg 159), (_fg 255), (_fg 87), (_fg 228))

    # ═════════════════════════════════════════════════════════════════
    # Render
    # ═════════════════════════════════════════════════════════════════

    [Console]::CursorVisible = $false
    Clear-Host

    _DrawBorder
    _DrawTexture
    _DrawDivider
    _DrawRSC
    _DrawPSBanner
    _DrawPrompt

    # Taglines (centered under PS banner, center=39)
    $tagY1 = 21; $tagY2 = 22
    $tagLeft = 21
    $tagRight = 52
    _At $tagLeft $tagY1; _W $DG '·····'; _W $T3 '▸ '; _W (_fg 229) 'Rubrik Security Cloud  '; _W $T3 '◂'; _W $DG '·····'
    # SDK version line: centered in 23 chars (same width as tagline above)
    $sdkVer = try { "v" + (Get-Module RubrikSecurityCloud).Version.ToString() } catch { '?' }
    if ($sdkVer.Length -gt 23) { $sdkVer = $sdkVer.Substring(0, 22) + '…' }
    $pad = [Math]::Max(0, 23 - $sdkVer.Length)
    $verLabel = (' ' * [Math]::Floor($pad / 2)) + $sdkVer + (' ' * [Math]::Ceiling($pad / 2))
    _At $tagLeft $tagY2; _W $DG '·····'; _W $T3 '▸ '; _W $GR $verLabel; _W $T3 '◂'; _W $DG '·····'

    $frame = 0
    $mqOff = 0
    $mqY = 24
    $mqVisW = 52
    $mqLeft = 13

    try {
        while ($true) {

            # ── Sparkles (every 3rd frame) ───────────────────
            if ($frame % 3 -eq 0) {
                foreach ($sp in $sparklePos) {
                    _At $sp[0] $sp[1]
                    if ((Get-Random -Maximum 8) -lt 2) {
                        $g = $sparkleGlyphs[(Get-Random -Maximum $sparkleGlyphs.Count)]
                        $c = $sparkleColors[(Get-Random -Maximum $sparkleColors.Count)]
                        _W $c $g
                    }
                    else {
                        _W '' ' '
                    }
                }
            }

            # ── RSC title wave: gentle pulse right→left ──────────
            # Palette: 101 (dim olive) → 107 (sage) → 143 (light olive) → 144 (khaki) → back
            $rscText = 'Rubrik Security Cloud'
            $rscCol = $tagLeft + 7
            $rscLen = $rscText.Length
            # ~7 frames for wave to cross (4x speed) + ~77 pause ≈ 10s
            $waveCycle = [Math]::Floor(($rscLen + 4) / 4) + 77
            $waveFrame = $frame % $waveCycle
            $wavePos = $rscLen + 1 - ($waveFrame * 4)  # 4x speed, right to left
            for ($ci = 0; $ci -lt $rscLen; $ci++) {
                _At ($rscCol + $ci) $tagY1
                $dist = [Math]::Abs($ci - $wavePos)
                if ($dist -eq 0) {
                    _W (_fg 144) $rscText[$ci]     # khaki (peak)
                } elseif ($dist -eq 1) {
                    _W (_fg 143) $rscText[$ci]     # light olive
                } elseif ($dist -eq 2) {
                    _W (_fg 107) $rscText[$ci]     # sage
                } else {
                    _W (_fg 101) $rscText[$ci]     # dim olive (base)
                }
            }

            # ── Vegas arrows (1/3 speed) ─────────────────────
            $dotPhase = [Math]::Floor($frame / 3) % 5
            for ($tagY = $tagY1; $tagY -le $tagY2; $tagY++) {
                _At $tagLeft $tagY
                for ($d = 0; $d -lt 5; $d++) {
                    if ($d -eq $dotPhase) { _W $T5 '·' }
                    else                  { _W $DG '·' }
                }
                _At $tagRight $tagY
                for ($d = 4; $d -ge 0; $d--) {
                    if ($d -eq $dotPhase) { _W $T5 '·' }
                    else                  { _W $DG '·' }
                }
            }

            # ── Marquee ──────────────────────────────────────
            _At $mqLeft $mqY
            _W $T3 '▸ '

            $pos = $mqOff % $creditLen
            $remaining = $mqVisW

            $acc = 0; $si = 0; $sc = 0
            for ($i = 0; $i -lt $creditSegs.Count; $i++) {
                $slen = $creditSegs[$i].T.Length
                if ($acc + $slen -gt $pos) {
                    $si = $i
                    $sc = $pos - $acc
                    break
                }
                $acc += $slen
            }

            $idx = $si; $skip = $sc
            while ($remaining -gt 0) {
                $seg = $creditSegs[$idx % $creditSegs.Count]
                $txt = $seg.T.Substring($skip)
                if ($txt.Length -gt $remaining) {
                    $txt = $txt.Substring(0, $remaining)
                }
                _W $seg.C $txt
                $remaining -= $txt.Length
                $idx++
                $skip = 0
            }

            _W $T3 ' ◂'
            $mqOff = ($mqOff + 1) % $creditLen

            # ── Exit check ───────────────────────────────────
            if ([Console]::KeyAvailable) {
                $null = [Console]::ReadKey($true)
                break
            }

            $frame++
            Start-Sleep -Milliseconds 120
        }
    }
    finally {
        [Console]::SetCursorPosition(0, [Math]::Min($oy + $artH + 1, [Console]::BufferHeight - 1))
        [Console]::CursorVisible = $true
        Write-Host $RS
    }
}
