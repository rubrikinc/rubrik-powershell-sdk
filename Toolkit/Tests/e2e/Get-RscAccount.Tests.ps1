BeforeAll {
    . "$PSScriptRoot\..\..\Utils\E2eTestInit.ps1"
}

Describe -Name 'Get-RscAccount' -Tag 'Public' -Fixture {
    It -Name 'Get-RscAccount' -Test {
        { Get-RscAccount | Out-Null } | Should -Not -Throw
    }        
}
