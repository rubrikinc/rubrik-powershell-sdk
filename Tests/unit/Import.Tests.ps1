& "$PSScriptRoot\..\..\Utils\import.ps1"
# . Join-Path $PSScriptRoot '../import.ps1' -Verbose

Describe -Name 'Connect-Rsc' -Fixture {
    Context -Name 'Validate Connect-Rsc exists' {
        It -Name 'Connect-Rsc exists' -Test {
            (Get-Command -Name Connect-Rsc -ErrorAction SilentlyContinue) | Out-String |
                Should -BeLikeExactly '*Connect-Rsc*'
        }
    }
}

Describe -Name 'Disconnect-Rsc' -Fixture {
    Context -Name 'Validate Disconnect-Rsc exists' {
        It -Name 'Disconnect-Rsc exists' -Test {
            (Get-Command -Name Disconnect-Rsc -ErrorAction SilentlyContinue) | Out-String |
                Should -BeLikeExactly '*Disconnect-Rsc*'
        }
    }
}

Describe -Name 'Get-RscVsphereVm' -Fixture {
    Context -Name 'Validate Get-RscVsphereVm exists' {
        It -Name 'Get-RscVsphereVm exists' -Test {
            (Get-Command -Name Get-RscVsphereVm -ErrorAction SilentlyContinue) | Out-String |
                Should -BeLikeExactly '*Get-RscVsphereVm*'
        }
    }
}
