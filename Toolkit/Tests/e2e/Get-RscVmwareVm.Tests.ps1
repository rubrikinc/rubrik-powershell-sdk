BeforeAll {
    . "$PSScriptRoot\..\..\Utils\ToolkitDev.ps1" -Quiet -Connect
}

Describe -Name 'Get-RscVmwareVm' -Tag 'Public' -Fixture {
    Context -Name 'Id' {
        It -Name 'retrieves single VM' -Test {
            { Get-RscVMwareVm -Id '00000000-0000-0000-0000-000000000000' | Out-Null} | Should -Not -Throw
        }
    }
    Context -Name 'Name' {
        It -Name 'retrieves multiple VMs' -Test {
            { Get-RscVMwareVm | Out-Null} | Should -Not -Throw
        }
    }
}
