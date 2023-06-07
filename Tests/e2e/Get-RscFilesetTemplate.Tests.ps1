<#
.SYNOPSIS
Run tests around fileset templates
#>
BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}


Describe -Name 'Get-RscFilesetTemplate' -Tag 'Public' -Fixture{
    Context -Name 'Parameter Validation' {
        It -Name 'Parameter Name can be $null' -Test {
            { Get-RscFilesetTemplate -OsType Windows -Name $null } |
                Should -Not -Throw
        }

        It -Name 'Parameter Name can be empty' -Test {
            { Get-RscFilesetTemplate -OsType Windows -Name '' } |
                Should -Not -Throw
        }

        It -Name 'Parameter ID cannot be $null' -Test {
            { Get-RscFilesetTemplate -Id $null } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }

        It -Name 'Parameter ID cannot be empty' -Test {
            { Get-RscFilesetTemplate -Id '' } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }

        It -Name 'Parameters Id and Name cannot be simultaneously used' -Test {
            { Get-RscFilesetTemplate -Id my-host-id-that-doesnot-exist -Name 'swagsanta' } |
                Should -Throw "Parameter set cannot be resolved using the specified named parameters. One or more parameters issued cannot be used together or an insufficient number of parameters were provided."
        }

        It -Name 'Parameter OsType cannot be $null' -Test{
            {Get-RscFilesetTemplate -OsType $null } |
            Should -Throw "Cannot validate argument on parameter 'OsType'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }

        It -Name 'Fields work as expected' -Test {
            $fields = Get-RscType -Name FilesetTemplate -InitialProperties @("Name","OsType")
            $results = Get-RscFilesetTemplate -OsType Windows -Field $fields -First 1
            $results[0].Id | Should -BeNullOrEmpty
            $results[0].Name | Should -Not -BeNullOrEmpty
            $results[0].OsType | Should -Not -BeNullOrEmpty
            $results[0].ObjectType | Should -BeNullOrEmpty
        }
    }
}
