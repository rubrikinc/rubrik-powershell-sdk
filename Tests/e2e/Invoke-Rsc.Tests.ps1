BeforeAll {
    . "$PSScriptRoot\..\..\Toolkit\Utils\E2eTestInit.ps1"
}

Describe -Name "Send a generic GraphQL call" -Fixture {
    It -Name 'Invoke-RscGraphQLCall' -Test {

        # Query object
        $q = New-RscQueryCluster -List -Var @{first = 1 }
        { Invoke-Rsc $q } | Should -Not -Throw
        
        # Query string
        $response = Invoke-Rsc -GqlQuery "query accountSettings{accountSettings{isEulaAccepted}}"
        $response.GetType().Name | Should -BeExactly 'AccountSetting'
        $fields = ($response | gm -MemberType Property).Name
        $fields | Should -BeExactly @('IsEmailNotificationEnabled', 'IsEulaAccepted')
        $response.IsEmailNotificationEnabled | Should -BeNullOrEmpty
        $response.IsEulaAccepted | Should -Not -BeNullOrEmpty

        # Query file with no variables
        $gqlFile = "$PSScriptRoot\..\..\Samples\queryAccountOwners.gql"
        $owners = Get-Content -Path $gqlFile -Raw | Invoke-Rsc
        $owners[0].GetType().Name | Should -BeExactly 'User'
        # Same but pass as parameter
        $owners = Invoke-Rsc (Get-Item -Path $gqlFile).FullName
        $owners[0].GetType().Name | Should -BeExactly 'User'

        # Query file with variables embedded in top comment
        $clusters = (Get-Content -Path $PSScriptRoot\..\..\Samples\queryClusterListFirst.gql -Raw | Invoke-Rsc)
        $clusters.GetType().Name | Should -BeExactly 'ClusterConnection'
        $clusters.Nodes.Count | Should -BeExactly 1

        # Query file with variables embedded in top comment
        $clusters = (Get-Content -Path $PSScriptRoot\..\..\Samples\queryClusterListFirstTwo.gql -Raw | Invoke-Rsc)
        $clusters.GetType().Name | Should -BeExactly 'ClusterConnection'
        $clusters.Nodes.Count | Should -BeExactly 2

        # Different ways to pass a quey object
        $q = New-RscQueryCluster -List -RemoveField Nodes
        $clusters1 = Invoke-Rsc $q
        
    }
}
