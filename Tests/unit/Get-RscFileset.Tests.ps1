<#
.SYNOPSIS
Unit tests for Get-RscFileset parameter validation.
Extracted from Tests/e2e/Get-RscFileset.Tests.ps1 — no RSC connection needed.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name 'Get-RscFileset Parameter Validation' -Tag 'Public' -Fixture {
    Context -Name 'Id ParameterSet Validation' {
        It -Name 'FilesetId cannot be $null' -Test {
            { Get-RscFileset -FilesetId $null } |
            Should -Throw "Cannot validate argument on parameter 'FilesetId'. The argument is null or empty. Provide an argument that is not null or empty, and then try the command again."
        }
    }
}
