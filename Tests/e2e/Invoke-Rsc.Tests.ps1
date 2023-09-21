BeforeAll {
    . "$PSScriptRoot\e2eInit.ps1"
}

Describe -Name "Send a generic GraphQL call" -Fixture {
    It -Name 'Invoke-RscGraphQLCall' -Test {

        # Query object
        $q = New-RscQueryCluster -List -Var @{first = 1 }
        Invoke-Rsc $q
        
        # Query string
        $response = Invoke-Rsc -GqlQuery "query accountSettings{accountSettings{isEulaAccepted}}"
        $response.GetType().Name | Should -BeExactly 'AccountSetting'
        $fields = ($response | gm -MemberType Property).Name
        $fields | Should -BeExactly @('IsEmailNotificationEnabled', 'IsEulaAccepted')
        $response.IsEmailNotificationEnabled | Should -BeNullOrEmpty
        $response.IsEulaAccepted | Should -Not -BeNullOrEmpty

        # Query file with no variables
        $owners = Get-Content -Path $PSScriptRoot\..\..\Samples\queryAccountOwners.gql -Raw | Invoke-Rsc
        $owners[0].GetType().Name | Should -BeExactly 'User'

        # Query file with variables embedded in top comment
        $clusters = (Get-Content -Path $PSScriptRoot\..\..\Samples\queryClusterListFirst.gql -Raw | Invoke-Rsc)
        $clusters.GetType().Name | Should -BeExactly 'ClusterConnection'
        $clusters.Nodes.Count | Should -BeExactly 1

        # Query file with variables embedded in top comment
        $clusters = (Get-Content -Path $PSScriptRoot\..\..\Samples\queryClusterListFirstTwo.gql -Raw | Invoke-Rsc)
        $clusters.GetType().Name | Should -BeExactly 'ClusterConnection'
        $clusters.Nodes.Count | Should -BeExactly 2
        
    }
}
