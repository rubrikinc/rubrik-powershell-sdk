<#
.SYNOPSIS
Unit tests for Get-RscHost parameter validation.
Extracted from Tests/e2e/Get-RscHost.Tests.ps1 — no RSC connection needed.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name 'Get-RscHost Parameter Validation' -Tag 'Public' -Fixture {
    Context -Name 'Parameter Validation' {
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

        It -Name 'Parameter OsType cannot be $null' -Test {
            { Get-RscHost -OsType $null } |
            Should -Throw "Cannot validate argument on parameter 'OsType'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
    }
}
