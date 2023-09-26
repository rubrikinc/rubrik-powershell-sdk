<#
.SYNOPSIS
Run tests around variables.
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"
}

Describe -Name "Test variables" -Fixture {
    It -Name "With New-RscQueryMssql -RecoverableRanges" -Test {
        # Make sure the schema hasn't changed:
        $varInfo = (New-RscQueryMssql -RecoverableRanges).Var.Info()
        $varInfo.Count | Should -Be 1
        $varInfo[0].Name | Should -Be "input"
        $varInfo[0].Type | Should -Be "GetMssqlDbRecoverableRangesInput"
        $varProps = (Get-RscType -Name GetMssqlDbRecoverableRangesInput) | Get-Member -MemberType Properties | Select-Object -ExpandProperty Name
        $expectedProps = @('AfterTime', 'BeforeTime', 'Id')
        $varProps | Should -Be $expectedProps

        # No variables
        $vars = @{}
        $serialized = (New-RscQueryMssql -RecoverableRanges -Var $vars).GqlRequest().Variables
        $serialized | Should -Be '{"input":{}}'

        # Empty input:
        $vars = @{
            "input" = @{}
        }
        $serialized = (New-RscQueryMssql -RecoverableRanges -Var $vars).GqlRequest().Variables
        $serialized | Should -Be '{"input":{}}'

        # One variable
        $vars = @{
            "id" = "123"
        }
        $serialized = (New-RscQueryMssql -RecoverableRanges -Var $vars).GqlRequest().Variables
        $serialized | Should -Be '{"input":{"id":"123"}}'

        # Two variables
        $vars = @{
            "id"         = "123"
            "beforeTime" = "2020-01-01T00:00:00Z"
        }
        $serialized = (New-RscQueryMssql -RecoverableRanges -Var $vars).GqlRequest().Variables
        $isFirstOrder = $serialized -eq '{"input":{"beforeTime":"2020-01-01T00:00:00Z","id":"123"}}'
        $isSecondOrder = $serialized -eq '{"input":{"id":"123","beforeTime":"2020-01-01T00:00:00Z"}}'

        ($isFirstOrder -or $isSecondOrder) | Should -Be $true

        # Lower-case 'id'
        $vars = Get-RscType -Name GetMssqlDbRecoverableRangesInput
        $vars.id = "123"
        $serialized = (New-RscQueryMssql -RecoverableRanges -Var $vars).GqlRequest().Variables
        $serialized | Should -Be '{"input":{"id":"123"}}'

        # Upper-case 'Id'
        $vars = Get-RscType -Name GetMssqlDbRecoverableRangesInput
        $vars.Id = "123"
        $serialized = (New-RscQueryMssql -RecoverableRanges -Var $vars).GqlRequest().Variables
        $serialized | Should -Be '{"input":{"id":"123"}}'

        # different ways to pass a variable:
        $vars = (New-RscQueryCluster -List -Var @{first = 1 }).Var.ToString()
        $q = New-RscQueryCluster -List -Var first=1
        $q.Var.ToString() | Should -Be $vars
        $q = New-RscQueryCluster -List -Var @{First = 1 }
        $q.Var.ToString() | Should -Be $vars
        $q = New-RscQueryCluster -List -Var First=1
        $q.Var.ToString() | Should -Be $vars
        # Var def says First is an int, but we pass a string
        $q = New-RscQueryCluster -List -Var @{First = "1" }
        $q.Var.ToString() | Should -Be $vars

        # different ways to pass 2 variables
        $vars = (New-RscQueryCluster -List -Var @{first = 1; after = "2" }).Var.ToString()
        $q = New-RscQueryCluster -List -Var "first=1,after=2"
        $q.Var.ToString() | Should -Be $vars
        $q = New-RscQueryCluster -List -Var @{First = 1; After = "2" }
        $q.Var.ToString() | Should -Be $vars 
        $q = New-RscQueryCluster -List -Var "First=1,After=2"
        $q.Var.ToString() | Should -Be $vars
        # Var def says Last is a string, but we pass an int
        $q = New-RscQueryCluster -List -Var @{First = 1; After = 2 }
        $q.Var.ToString() | Should -Be $vars

        # Enum values
        $q1 = New-RscQueryCluster -Connected -Var @{"clusterFilterArg" = [RubrikSecurityCloud.Types.ClusterTypeEnum]::POLARIS }
        $q2 = New-RscQueryCluster -Connected -Var ([RubrikSecurityCloud.Types.ClusterTypeEnum]::POLARIS)
        $q1.Var.ToString() | Should -Be $q2.Var.ToString()

    }
}