<#
.SYNOPSIS
Run tests around variables.
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
}

Describe -Name "Test variables" -Fixture {
    It -Name "With Invoke-RscQueryMssql -RecoverableRanges" -Test {
        # Make sure the schema hasn't changed:
        $varInfo = (Invoke-RscQueryMssql -RecoverableRanges -GetInput).Var.Info()
        $varInfo.Count | Should -Be 1
        $varInfo[0].Name | Should -Be "input"
        $varInfo[0].Type | Should -Be "GetMssqlDbRecoverableRangesInput"
        $varProps = (Get-RscType -Name GetMssqlDbRecoverableRangesInput) | Get-Member -MemberType Properties | Select-Object -ExpandProperty Name
        $expectedProps = @('AfterTime', 'BeforeTime', 'Id')
        $varProps | Should -Be $expectedProps

        # No variables
        $vars = @{}
        $serialized = (Invoke-RscQueryMssql -RecoverableRanges -Var $vars -GetGqlRequest).Variables
        $serialized | Should -Be '{"input":{}}'

        # Empty input:
        $vars = @{
            "input" = @{}
        }
        $serialized = (Invoke-RscQueryMssql -RecoverableRanges -Var $vars -GetGqlRequest).Variables
        $serialized | Should -Be '{"input":{}}'

        # One variable
        $vars = @{
            "id" = "123"
        }
        $serialized = (Invoke-RscQueryMssql -RecoverableRanges -Var $vars -GetGqlRequest).Variables
        $serialized | Should -Be '{"input":{"id":"123"}}'

        # Two variables
        $vars = @{
            "id"         = "123"
            "beforeTime" = "2020-01-01T00:00:00Z"
        }
        $serialized = (Invoke-RscQueryMssql -RecoverableRanges -Var $vars -GetGqlRequest).Variables
        $isFirstOrder = $serialized -eq '{"input":{"beforeTime":"2020-01-01T00:00:00Z","id":"123"}}'
        $isSecondOrder = $serialized -eq '{"input":{"id":"123","beforeTime":"2020-01-01T00:00:00Z"}}'

        ($isFirstOrder -or $isSecondOrder) | Should -Be $true

        # Lower-case 'id'
        $vars = Get-RscType -Name GetMssqlDbRecoverableRangesInput
        $vars.id = "123"
        $serialized = (Invoke-RscQueryMssql -RecoverableRanges -Var $vars -GetGqlRequest).Variables
        $serialized | Should -Be '{"input":{"id":"123"}}'

        # Upper-case 'Id'
        $vars = Get-RscType -Name GetMssqlDbRecoverableRangesInput
        $vars.Id = "123"
        $serialized = (Invoke-RscQueryMssql -RecoverableRanges -Var $vars -GetGqlRequest).Variables
        $serialized | Should -Be '{"input":{"id":"123"}}'
    }
}