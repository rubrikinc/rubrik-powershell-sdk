<#
.SYNOPSIS
Build the Rubrik Security Cloud SDK.

.DESCRIPTION
This script

- runs Clean-RscSdk.ps1 to remove any previous build artifacts.
- builds the Rubrik Security Cloud SDK and copies the output
  to the Output/ directory.
- runs Test-RscSdk.ps1 to run the tests.

By default, the script will run the tests.
You can skip the tests by passing -NoTests.

By default, the script will build the Debug version of the SDK.
You can build the Release version by passing -Release.
Note that the Release build is copied to the Output.Release/ directory
instead of Output/.
#>
param(
    [switch]$NoClean = $false,
    [switch]$Release = $false,
    [switch]$NoDocs = $false,
    [switch]$NoTests = $false,
    [switch]$Pw5Tests = $false,
    [switch]$CI = $false
)

# This script runs the build
# in a separate PowerShell process
# to avoid file locking issues.
# This script invokes `_Build-RscSdk.ps1`
# in a new `pwsh` process.
# This approach streams the build output
# in real-time to the console.

# Get the current script directory
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

# Construct the command to run in a new pwsh session
$buildCommand = "& '$scriptDir\_Build-RscSdk.ps1' -NoClean:`$NoClean -Release:`$Release -NoDocs:`$NoDocs"

# Create a process to execute the command and stream output in real-time
$processStartInfo = New-Object System.Diagnostics.ProcessStartInfo
# Always build with PowerShell 7
$processStartInfo.FileName = "pwsh"
$processStartInfo.Arguments = "-Command $buildCommand"
$processStartInfo.RedirectStandardOutput = $true
$processStartInfo.RedirectStandardError = $true
$processStartInfo.UseShellExecute = $false
$processStartInfo.CreateNoWindow = $true

$process = New-Object System.Diagnostics.Process
$process.StartInfo = $processStartInfo

# Start the process
$process.Start() | Out-Null

# Stream stdout and stderr in real-time
while (-not $process.StandardOutput.EndOfStream) {
    $line = $process.StandardOutput.ReadLine()
    Write-Host $line
}

while (-not $process.StandardError.EndOfStream) {
    $line = $process.StandardError.ReadLine()
    Write-Host $line -ForegroundColor Red
}

# Wait for the process to exit and capture the exit code
$process.WaitForExit()
$exitCode = $process.ExitCode

# Return the exit code
if ($exitCode -ne 0) {
    exit $exitCode
}

# Run tests
if (-not $NoTests) {
    $pwshArgs = "-File `"$scriptDir\Test-RscSdk.ps1`""
    if ($CI) {
        $pwshArgs += " -CI"
    }

    # Run tests in a PowerShell 7 sub-process
    Write-Host "Running tests in PowerShell 7..."
    $pwshTestProcess = Start-Process -FilePath "pwsh" `
        -ArgumentList $pwshArgs -NoNewWindow -Wait -PassThru
    if ($pwshTestProcess.ExitCode -ne 0) {
        Write-Error "PowerShell 7 tests failed."
        exit $pwshTestProcess.ExitCode
    }
    Write-Host "Tests passed in PowerShell 7." -back green -fore white

    # Run tests in a PowerShell 5.1 sub-process (if requested)
    if ($Pw5Tests -or $CI) {
        Write-Host "Running tests in PowerShell 5..."
        
        $pwsh5TestProcess = Start-Process -FilePath "powershell.exe" `
            -ArgumentList $pwshArgs -NoNewWindow -Wait -PassThru
        if ($pwsh5TestProcess.ExitCode -ne 0) {
            Write-Error "PowerShell 5 tests failed."
            exit $pwsh5TestProcess.ExitCode
        }
        Write-Host "Tests passed in PowerShell 5." -back green -fore blue
    }
}
