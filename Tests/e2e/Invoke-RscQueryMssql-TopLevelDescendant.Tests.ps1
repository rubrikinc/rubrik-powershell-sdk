BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}
Describe -Name 'Query mssqlTopLevelDescendants' -Fixture {
    # This test exercises a key Get-RscType limitation with List<Interface>
    # fields and shows the workaround.
    #
    # MssqlTopLevelDescendantTypeConnection.nodes is a List<MssqlTopLevelDescendantType>,
    # where MssqlTopLevelDescendantType is an INTERFACE with 6 implementing types:
    #   MssqlAvailabilityGroup, MssqlDatabase, MssqlHost,
    #   MssqlInstance, PhysicalHost, WindowsCluster
    #
    # If we used Get-RscType with -InitialProperties "nodes.id", the
    # List<Interface> code path would create one instance of EVERY
    # implementing type, producing a field spec with all 6 fragments:
    #
    #   nodes {
    #     ... on MssqlAvailabilityGroup { id }
    #     ... on MssqlDatabase { id }
    #     ... on MssqlHost { id }
    #     ... on MssqlInstance { id }
    #     ... on PhysicalHost { id }
    #     ... on WindowsCluster { id }
    #   }
    #
    # But here we only want PhysicalHost (and its child MssqlInstances).
    # Get-RscType has no way to select a single implementing type from an
    # interface list. The workaround is to:
    #   1. Create the specific implementing type separately (PhysicalHost)
    #   2. Manually assign it to .nodes on an empty Connection object
    #
    # This gives us a targeted field spec with only the PhysicalHost fragment:
    #
    #   nodes {
    #     ... on PhysicalHost {
    #       id
    #       name
    #       physicalChildConnection { count nodes { ... } }
    #     }
    #   }
    #
    # The same pattern applies one level deeper:
    # PhysicalHost.physicalChildConnection.nodes is also a List<Interface>
    # (PhysicalHostPhysicalChildType), so we manually set .Nodes to
    # MssqlInstance to avoid expanding all 9 implementing types.

    It -Name 'PhysicalHost with MssqlInstance children' -Test {
        # Step 1: Build a PhysicalHost field spec.
        # "physicalChildConnection.count" walks into the Connection object
        # and selects its "count" field. This also instantiates
        # PhysicalChildConnection as a side effect, so we can assign
        # .Nodes in the next step.
        $physicalHostFields =
        Get-RscType -Name PhysicalHost -InitialProperties @(
            "id",
            "name",
            "physicalChildConnection.count"
        )

        # Step 2: PhysicalChildConnection.Nodes is a List<Interface>.
        # Manually set it to MssqlInstance to avoid expanding all
        # implementing types (ExchangeServer, FilesetTemplate, etc.).
        $physicalHostFields.PhysicalChildConnection.Nodes =
        Get-RscType -Name MssqlInstance -InitialProperties ("Id", "Name")

        # Step 3: Build the top-level Connection and assign .nodes to
        # our PhysicalHost (instead of letting Get-RscType expand all
        # 6 implementing types of MssqlTopLevelDescendantType).
        $fields = Get-RscType -Name MssqlTopLevelDescendantTypeConnection
        $fields.nodes = $physicalHostFields

        # Step 4: Query using the hand-crafted field spec.
        $sqlObjects = (New-RscQuery -Gql mssqlTopLevelDescendants -Field $fields).Invoke()
        $sqlObjects.nodes | Should -Not -BeNullOrEmpty
    }
}
