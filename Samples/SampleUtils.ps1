$nl = [System.Environment]::NewLine
function Write-Title {
    param (
        [string]$Title
    )
    Clear-Host
    # OS-independent way to get the newline character
    # OS-independent way to get the console width
    $width = (Get-Host).UI.RawUI.WindowSize.Width
    $title = "|  $Title  |"
    $titleIndent = (" " * (($width - $Title.Length) / 2))
    $titleLine = "+" + "-" * ($Title.Length - 2) + "+"
    # Center the title:
    Write-Host $titleIndent -NoNewline
    Write-Host -ForegroundColor Green $titleLine
    Write-Host $titleIndent -NoNewline
    Write-Host -ForegroundColor Green $Title
    Write-Host $titleIndent -NoNewline
    Write-Host -ForegroundColor Green $titleLine
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
        Write-Host -NoNewline -ForegroundColor Green "$GreenMessage "
    }
    if ($YellowMessage) {
        Write-Host -NoNewline -ForegroundColor Yellow "$YellowMessage "
    }
    if ($BlueMessage) {
        Write-Host -NoNewline -ForegroundColor Blue "$BlueMessage "
    }
    Write-Host
    # If the Pause switch is used, pause and wait for a keypress
    if ($Pause) {
        Wait-ForKey
    }
}

function Write-Code {
    param (
        # Optional parameter to pause after displaying the code
        [switch]$Pause,
        # The code snippet to display
        [string]$CodeSnippet
    )
    Write-Host -ForegroundColor Green "$nl PS > $CodeSnippet $nl"
    # If the Pause switch is used, pause and wait for a keypress
    if ($Pause) {
        Wait-ForKey
    }
}

function Wait-ForKey {
    $Continue = "  Press any key to continue, or ESC to exit..  "
    Write-Host -NoNewline -BackgroundColor Green -ForegroundColor DarkGreen $Continue
    [Console]::TreatControlCAsInput = $true
    $key = [Console]::ReadKey($false)
    Write-Host "`r$('-' * ($Continue.Length + 1))`r"
    if ($key.Key -eq [System.ConsoleKey]::Escape || ($key.Key -eq [System.ConsoleKey]::C -and $key.Modifiers -eq [System.ConsoleModifiers]::Control)) {
        exit
    }
}