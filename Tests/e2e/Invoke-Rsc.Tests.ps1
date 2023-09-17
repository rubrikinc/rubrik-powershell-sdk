BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name "Send a generic GraphQL call" -Fixture {
    It -Name 'Invoke-RscGraphQLCall' -Test {

        $response = Invoke-Rsc -GqlQuery "query accountSettings{accountSettings{isEulaAccepted}}"
        $response.GetType().Name | Should -BeExactly 'AccountSetting'
        $fields =  ($response|gm -MemberType Property).Name
        $fields | Should -BeExactly @('IsEmailNotificationEnabled','IsEulaAccepted')
        $response.IsEmailNotificationEnabled | Should -BeNullOrEmpty
        $response.IsEulaAccepted | Should -Not -BeNullOrEmpty

        $owners = Get-Content -Path $PSScriptRoot\..\..\Samples\queryAccountOwners.gql -Raw | Invoke-Rsc
        $owners[0].GetType().Name | Should -BeExactly 'User'

        $clusters=(Get-Content -Path $PSScriptRoot\..\..\Samples\queryClusterListFirst.gql -Raw | Invoke-Rsc)
        $clusters.GetType().Name | Should -BeExactly 'ClusterConnection'
        $clusters.Nodes.Count | Should -BeExactly 1

        $clusters=(Get-Content -Path $PSScriptRoot\..\..\Samples\queryClusterListFirstTwo.gql -Raw | Invoke-Rsc)
        $clusters.GetType().Name | Should -BeExactly 'ClusterConnection'
        $clusters.Nodes.Count | Should -BeExactly 2

        $q=Invoke-RscQueryCluster -List -GetInput
        Invoke-Rsc $q
    }
}
