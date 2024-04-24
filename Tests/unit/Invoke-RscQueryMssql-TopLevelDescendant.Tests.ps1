BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"
}
Describe -Name 'New-RscQueryMssql -Op TopLevelDescendants' -Fixture {
    It -Name 'PhysicalHost' -Test {
        $query=(New-RscQueryMssql -Op TopLevelDescendants)

        # Field is a MssqlTopLevelDescendantTypeConnection
        $query.Field.GetType().Name | Should -Be 'MssqlTopLevelDescendantTypeConnection'

        # which has a Nodes field,
        $query.Field.Nodes.GetType().Name | Should -Be 'RscInterface`1'

        # which is a list of interfaces of type MssqlTopLevelDescendantType
        # https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/mssqltopleveldescendanttype.doc.html
        $query.Field.Nodes.GetType().GenericTypeArguments[0].Name | Should -Be 'MssqlTopLevelDescendantType'

        # Auto exploration fills this list with all the possible implementations of MssqlTopLevelDescendantType
        $nodeTypeNames=$query.Field.Nodes| ForEach-Object { $_.GetType().Name} | Sort-Object
        $impls=@(Get-RscType -Interface MssqlTopLevelDescendantType)| Sort-Object
        $nodeTypeNames | Should -Be $impls
        
        # Let's select the node in the list that is a PhysicalHost
        $node=($query.Field.Nodes | Where-Object { $_.GetType().Name -eq 'PhysicalHost' })

        # Verify that exploration set ObjectType for retrieval
        $node.ObjectType | Should -Not -BeNullOrEmpty

        # Verify that exploration set PhysicalChildConnection for retrieval
        $node.PhysicalChildConnection | Should -Not -BeNullOrEmpty

        # PhysicalChildConnection.Nodes is a list of interfaces
        $nodes = $node.PhysicalChildConnection.Nodes
        $nodes.GetType().Name | Should -Be 'RscInterface`1'
        $nodes.GetType().GenericTypeArguments[0].Name | Should -Be 'PhysicalHostPhysicalChildType'

        # Auto exploration fills this list with all the possible implementations of PhysicalHostPhysicalChildType
        $nodeTypeNames=$nodes| ForEach-Object { $_.GetType().Name} | Sort-Object
        $impls=@(Get-RscType -Interface PhysicalHostPhysicalChildType)| Sort-Object
        $nodeTypeNames | Should -Be $impls
    }
}