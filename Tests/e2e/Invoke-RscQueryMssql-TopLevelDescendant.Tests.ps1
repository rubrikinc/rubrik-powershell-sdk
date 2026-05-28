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
        # Mutate the Autofield-built spec in place — the same pattern
        # Get-RscMssqlInstance uses (see Toolkit/Public/Get-RscMssqlInstance.ps1
        # and rubrik-powershell-sdk PR #253). Passing -Field to override
        # the spec does NOT work reliably: the SDK still runs Autofield
        # DEFAULT on top of any -Field input, re-pulling fields the test
        # didn't ask for.
        $query = New-RscQuery -Gql mssqlTopLevelDescendants

        # Reduce the top-level nodes list to PhysicalHost only. This
        # eliminates the GraphQL field-merging conflict between
        # MssqlDatabase (hasPermissions: Boolean!, version: String) and
        # MssqlInstance (hasPermissions: Boolean, version: String!) that
        # Autofield's DEFAULT profile triggers when both implementers
        # appear as sibling inline fragments under the same nodes selection.
        # (Schema split on 2026-04-20, commit 375007994861.)
        #
        # Mutate the underlying List<T> directly with RemoveAt — Clear()
        # + Add() with a pipeline-retrieved $physicalHost silently
        # no-ops, likely because the pipeline returns a PSObject wrapper
        # the typed list rejects.
        for ($i = $query.Field.Nodes.Count - 1; $i -ge 0; $i--) {
            if ($query.Field.Nodes[$i].GetType().Name -ne "PhysicalHost") {
                $query.Field.Nodes.RemoveAt($i)
            }
        }
        $physicalHost = $query.Field.Nodes[0]

        # Replace PhysicalHost.physicalChildConnection (which Autofield
        # filled with all 9 implementers of PhysicalHostPhysicalChildType)
        # with a fresh connection holding only MssqlInstance — this
        # exercises the manual List<Interface> construction the test was
        # written to validate.
        $physicalHost.PhysicalChildConnection = New-Object `
            -TypeName RubrikSecurityCloud.Types.PhysicalHostPhysicalChildTypeConnection
        $physicalHost.PhysicalChildConnection.Count = [Int32]::MinValue
        $physicalHost.PhysicalChildConnection.Nodes = New-Object `
            -TypeName RubrikSecurityCloud.Types.MssqlInstance
        $childIndex = $physicalHost.PhysicalChildConnection.Nodes.FindIndex(
            {param($n) $n.GetType().Name -eq "MssqlInstance"})
        $physicalHost.PhysicalChildConnection.Nodes[$childIndex].Id = "FETCH"
        $physicalHost.PhysicalChildConnection.Nodes[$childIndex].Name = "FETCH"

        $sqlObjects = $query.Invoke()
        $sqlObjects.nodes | Should -Not -BeNullOrEmpty
    }
}
