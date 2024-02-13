BeforeAll {
    . "$PSScriptRoot\..\..\Utils\ToolkitDev.ps1" -Quiet -Connect
}

# Broken: replace -Skip for -Fixture to run the tests
Describe -Name 'Get-RscSlaDomain' -Tag 'Public' -Skip {
    Context -Name 'Id' {
        It -Name 'retrieves single SLA Domain' -Test {
            { Get-RscSlaDomain -Id '00000000-0000-0000-0000-000000000000' | Out-Null} | Should -Not -Throw
        }
    }
    Context -Name 'Name' {
        It -Name 'retrieves multiple SLA Domains' -Test {
            { Get-RscSlaDomain | Out-Null} | Should -Not -Throw
        }
    }
}
