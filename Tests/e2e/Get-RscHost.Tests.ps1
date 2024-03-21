<#
.SYNOPSIS
Run tests around hosts
#>


Describe -Name 'Get-RscHost' -Tag 'Public' -Fixture{
    BeforeAll {
        . "$PSScriptRoot\..\E2eTestInit.ps1"
    }

    Context -Name 'Parameter Validation' {
        It -Name 'Parameter Name can be $null' -Test {
            { Get-RscHost -OsType Windows -Name $null } |
                Should -Not -Throw 
        }

        It -Name 'Parameter Name can be empty' -Test {
            { Get-RscHost -OsType Windows -Name '' } |
                Should -Not -Throw
        }

        It -Name 'Parameter ID cannot be $null' -Test {
            { Get-RscHost -Id $null } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }

        It -Name 'Parameter ID cannot be empty' -Test {
            { Get-RscHost -Id '' } |
                Should -Throw "Cannot validate argument on parameter 'Id'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }

        It -Name 'Parameters Id and Name cannot be simultaneously used' -Test {
            { Get-RscHost -Id my-host-id-that-doesnot-exist -Name 'swagsanta' } |
                Should -Throw -ErrorId 'AmbiguousParameterSet,RubrikSecurityCloud.PowerShell.Cmdlets.Get_RscHost'
        }

        It -Name 'Parameter OsType cannot be $null' -Test{
            {Get-RscHost -OsType $null } |
            Should -Throw "Cannot validate argument on parameter 'OsType'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }

        It -Name 'Fields work as expected' -Test {
            $fields = Get-RscType -Name PhysicalHost -InitialProperties @("Name","OsType")
            $results = Get-RscHost -OsType Windows -Field $fields -First 1
            if ($results.Count -eq 0) {
                Set-ItResult -Skipped -Because "No hosts found"
                return
            }
            $results[0].Id | Should -BeNullOrEmpty
            $results[0].Name | Should -Not -BeNullOrEmpty
            $results[0].OsType | Should -Not -BeNullOrEmpty
            $results[0].ObjectType | Should -BeNullOrEmpty
        }
    }
}
