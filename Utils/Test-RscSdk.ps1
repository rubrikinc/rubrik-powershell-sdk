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