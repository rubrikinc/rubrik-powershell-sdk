BeforeAll {
    . "$PSScriptRoot\..\..\Utils\ToolkitDev.ps1" -Quiet -Connect
}

Describe -Name 'Get-RscAccount' -Tag 'Public' -Fixture {
    It -Name 'Get-RscAccount' -Test {
        { Get-RscAccount | Out-Null } | Should -Not -Throw
    }        
}
