BeforeAll {
    . "$PSScriptRoot\..\E2eTestInit.ps1"
}
Describe -Name 'Query mssqlTopLevelDescendants' -Fixture {
    # This test exercises manual field spec construction for List<Interface>
    # fields. The same result can be achieved more concisely with the on:
    # type selector syntax (e.g. "nodes.on:PhysicalHost.id"), but this
    # manual approach remains valid and is kept here to exercise that path.
    #
    # MssqlTopLevelDescendantTypeConnection.nodes is a List<MssqlTopLevelDescendantType>,
    # where MssqlTopLevelDescendantType is an INTERFACE with 6 implementing types:
    #   MssqlAvailabilityGroup, MssqlDatabase, MssqlHost,
    #   MssqlInstance, PhysicalHost, WindowsCluster
    #
    # Here we only want PhysicalHost (and its child MssqlInstances).
    # The manual approach:
    #   1. Create the specific implementing type separately (PhysicalHost)
    #   2. Manually assign it to .nodes on an empty Connection object
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
