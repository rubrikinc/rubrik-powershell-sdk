<#
.SYNOPSIS
Run tests around vSphere VMs
#>
BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name 'Get-RscVSphereVM' -Tag 'Public' -Fixture{

    Context -Name 'Parameter Validation' {
        It -Name 'Parameter Name cannot be $null' -Test {
            { Get-RscVsphereVm -Name $null } |
                Should -Throw "Cannot validate argument on parameter 'Name'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter Name cannot be empty' -Test {
            { Get-RscVsphereVm -Name '' } |
                Should -Throw "Cannot validate argument on parameter 'Name'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter ID cannot be $null' -Test {
            { Get-RscVsphereVm -Id $null } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameter ID cannot be empty' -Test {
            { Get-RscVsphereVm -Id '' } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
        It -Name 'Parameters Id and Name cannot be simultaneously used' -Test {
            { Get-RscVsphereVm -Id VirtualMachine:::1226ff04-6100-454f-905b-5df817b6981a-vm-1025 -Name 'swagsanta' } |
                Should -Throw "Parameter set cannot be resolved using the specified named parameters. One or more parameters issued cannot be used together or an insufficient number of parameters were provided."
        }
    }
}
