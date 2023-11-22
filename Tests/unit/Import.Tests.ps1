. "$PSScriptRoot\..\UnitTestInit.ps1"

Describe -Name 'Verify correct import' -Fixture {
    It "should be version 6.0.0" {
        $module = Get-Module -Name RubrikSecurityCloud
        $expectedVersion = New-Object System.Version(5, 0, 0)
        $module.PowerShellVersion | Should -Be $expectedVersion
    }
    It -Name 'Connect-Rsc exists' -Test {
        (Get-Command -Name Connect-Rsc -ErrorAction SilentlyContinue) | Out-String |
            Should -BeLikeExactly '*Connect-Rsc*'
    }
    It -Name 'Disconnect-Rsc exists' -Test {
        (Get-Command -Name Disconnect-Rsc -ErrorAction SilentlyContinue) | Out-String |
            Should -BeLikeExactly '*Disconnect-Rsc*'
    }
    It -Name 'Get-RscVsphereVm exists' -Test {
        (Get-Command -Name Get-RscVsphereVm -ErrorAction SilentlyContinue) | Out-String |
            Should -BeLikeExactly '*Get-RscVsphereVm*'
    }
}
