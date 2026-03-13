BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Test -Gql alias on cmdlets" -Fixture {

    It -Name "Invoke-Rsc has -Gql alias for -GqlQuery" -Test {
        $param = (Get-Command Invoke-Rsc).Parameters['GqlQuery']
        $param | Should -Not -BeNullOrEmpty
        $param.Aliases | Should -Contain 'Gql'
    }

    It -Name "New-RscQuery has -Gql alias for -GqlQuery" -Test {
        $param = (Get-Command New-RscQuery).Parameters['GqlQuery']
        $param | Should -Not -BeNullOrEmpty
        $param.Aliases | Should -Contain 'Gql'
    }

    It -Name "New-RscMutation has -Gql alias for -GqlMutation" -Test {
        $param = (Get-Command New-RscMutation).Parameters['GqlMutation']
        $param | Should -Not -BeNullOrEmpty
        $param.Aliases | Should -Contain 'Gql'
    }

    It -Name "New-RscQuery -Gql works the same as -GqlQuery" -Test {
        $q1 = New-RscQuery -GqlQuery clusterConnection
        $q2 = New-RscQuery -Gql clusterConnection
        $q1.GqlRequest().Query | Should -Be $q2.GqlRequest().Query
    }

    It -Name "New-RscMutation -Gql works the same as -GqlMutation" -Test {
        $q1 = New-RscMutation -GqlMutation deleteFailoverCluster
        $q2 = New-RscMutation -Gql deleteFailoverCluster
        $q1.GqlRequest().Query | Should -Be $q2.GqlRequest().Query
    }
}
