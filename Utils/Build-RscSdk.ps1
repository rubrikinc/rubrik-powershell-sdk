<#
.SYNOPSIS
Wrapper for running the SDK build process in a separate PowerShell process to avoid file locking issues.

.DESCRIPTION
This script invokes the actual `_Build-RscSdk.ps1` script in a new `pwsh.exe` process. 
This approach ensures that no files remain locked after the build process.

#>

# Get the current script directory
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

# Construct the command to run in a new pwsh session
$buildCommand = "& `$scriptDir/_Build-RscSdk.ps1 $args"

# Run the build command in a new PowerShell process
$exitCode = & pwsh.exe -Command $buildCommand

# Exit with the same code as the sub-process
if ($LASTEXITCODE -ne 0) {
    exit $LASTEXITCODE
}
