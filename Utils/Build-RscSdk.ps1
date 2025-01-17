<#
.SYNOPSIS
Wrapper for running the SDK build process in a separate PowerShell process to avoid file locking issues.

.DESCRIPTION
This script invokes the actual `_Build-RscSdk.ps1` script in a new `pwsh.exe` process.
This approach streams the build output in real-time to the console.

#>

# Get the current script directory
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

# Construct the command to run in a new pwsh session
$buildCommand = "$scriptDir\_Build-RscSdk.ps1 $args"

# Create a process to execute the command and stream output in real-time
$processStartInfo = New-Object System.Diagnostics.ProcessStartInfo
$processStartInfo.FileName = "pwsh.exe"
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
