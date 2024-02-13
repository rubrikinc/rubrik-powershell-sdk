BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}

Describe -Name "Test New-RscQuery and New-RscMutation" -Fixture {
    It -Name "With cluster operations" -Test {
        $q = New-RscQuery -GqlQuery clusterConnection
        $q.Field.GetType().Name | Should -Be "ClusterConnection"
        $q2 = new-rscquery -dom Cluster -op List
        $q.GqlRequest().Query | Should -Be $q2.GqlRequest().Query
        $q3 = new-rscquerycluster -op List
        $q.GqlRequest().Query | Should -Be $q3.GqlRequest().Query

        $q4 = new-rscmutation -gqlmutation deleteFailoverCluster
        $q5 = New-RscMutationFailoverCluster -op Delete
        $q4.GqlRequest().Query | Should -Be $q5.GqlRequest().Query
        $q6 = New-RscMutationFailoverCluster -Operation Delete
        $q6.GqlRequest().Query | Should -Be $q5.GqlRequest().Query

        # You cannot build a query from a mutation root field:
        {New-RscQuery -GqlQuery deleteFailoverCluster} | Should -Throw
        # and vice versa:
        {New-RscMutation -GqlMutation clusterConnection} | Should -Throw

        # Copying
        $q7 = New-RscQuery -Copy $q3
        $q7.GqlRequest().Query | Should -Be $q3.GqlRequest().Query
        $q8 = New-RscMutation -Copy $q5
        $q8.GqlRequest().Query | Should -Be $q5.GqlRequest().Query
        $q9 = New-RscQuery -Copy $q3 -AddField nodes.snapshotcount
        $q10 =  new-rscquerycluster -op List -AddField nodes.snapshotcount
        $q9.GqlRequest().Query | Should -Be $q10.GqlRequest().Query
        
        # copy a mutation to a query fails because
        # it can't validate the operation
        $qa=(New-RscMutationCluster -op RecoverCloud)
        {New-RscQuery -Copy $qa} | Should -Throw

    }
}