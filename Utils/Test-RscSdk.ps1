<#
.SYNOPSIS
    Run the Rubrik PowerShell SDK tests.

.DESCRIPTION
    This script runs the unit and e2e tests for both
    the Core and Toolkit components of the RSC SDK.

    By default, all tests are run. You can skip some tests
    by passing the appropriate switches.

    The script will stop on the first error.

.PARAMETER SkipUnitTests
    Skip all unit tests (in Core and Toolkit).

.PARAMETER SkipE2ETests
    Skip all e2e tests (in Core and Toolkit).

.PARAMETER SkipCoreTests
    Skip all Core tests (unit and e2e).

.PARAMETER SkipToolkitTests
    Skip all Toolkit tests (unit and e2e).

.EXAMPLE
    .\Utils\Test-RscSdk.ps1 -SkipUnitTests
    # Run only e2e tests for Core and Toolkit.

.EXAMPLE
    .\Utils\Test-RscSdk.ps1 -SkipCoreTests
    # Run only Toolkit tests.
    # Note: this is what ToolkitDev.ps1's Test-RscToolkit does.

.EXAMPLE
    .\Utils\Test-RscSdk.ps1 -SkipE2ETests -SkipCoreTests
    # Run only Toolkit unit tests.
#>
param(
    [switch]$SkipUnitTests = $false,
    [switch]$SkipE2ETests = $false,
    [switch]$SkipCoreTests = $false,
    [switch]$SkipToolkitTests = $false
)
# Change to the root of the repository
Set-Location $PSScriptRoot\..

# Stop on error
$ErrorActionPreference = "Stop"

if ( -not $SkipUnitTests ) {
    if ( -not $SkipCoreTests ) {
        # Run Core unit tests (Pester)
        .\Toolkit\Utils\Run-PesterTests.ps1 .\Tests\unit

        # Run Core unit tests (C#)
        Set-Location .\RubrikSecurityCloud\RubrikSecurityCloud.Common.Tests\
        dotnet test
        Set-Location $PSScriptRoot\..
    }

    if ( -not $SkipToolkitTests ) {
        # Run Toolkit unit tests (Pester)
        .\Toolkit\Utils\Run-PesterTests.ps1 .\Toolkit\Tests\unit
    }
}

if ( -not $SkipE2ETests ) {
    if ( -not $SkipCoreTests ) {
        # Run Core e2e tests (Pester)
        .\Toolkit\Utils\Run-PesterTests.ps1 .\Tests\e2e
    }

    if ( -not $SkipToolkitTests ) {
        # Run Toolkit e2e tests (Pester)
        .\Toolkit\Utils\Run-PesterTests.ps1 .\Toolkit\Tests\e2e
    }
}