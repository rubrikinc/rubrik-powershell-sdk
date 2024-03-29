<#
.SYNOPSIS
Run tests around variables.
#>
BeforeAll {
    . "$PSScriptRoot\..\UnitTestInit.ps1"

    function FieldSpec {
        param (
            [Parameter(Mandatory = $true)]
            [RubrikSecurityCloud.RscQuery]$query
        )
        $gqlRequest = $query.GqlRequest()
        $queryDoc = $gqlRequest.Query
        # make it all in one line
        $queryDoc = $queryDoc -replace '\n', ' '
        # minimize whitespace
        $queryDoc = $queryDoc -replace '\s+', ' '
        # Strip everything until the second '{'
        $queryDoc = $queryDoc -replace '^.*?\{', ''
        $queryDoc = $queryDoc -replace '^.*?\{', ''
        # Strip the last two '}'
        $queryDoc = $queryDoc -replace '\}[ ]*\}[ ]*$', ''
        $fsFromQueryDoc = $queryDoc.Trim()
        $fsFromFieldObj = ($query.Field.AsFieldSpec() -Replace '\s+', ' ').Trim()
        $fsFromQueryDoc | Should -Be $fsFromFieldObj
        return $fsFromQueryDoc
    }
}
Describe -Name "Test patching" -Fixture {
    It -Name "With New-RscQueryCluster -Op List" -Test {

        # Some schema definitions

        # The following hard-coded list needs to be updated manually
        # when the schema changes. The repetition is intentional.
        $defaultNodes = "pauseStatus status subStatus systemStatus type id isHealthy name systemStatusMessage version"

        $defaultNodesSnapshot = $defaultNodes -replace 'name', 'name snapshotcount'
        $pageInfo = "pageInfo { endCursor hasNextPage hasPreviousPage startCursor }"
        $cdmUpgradeInfoFieldSpec = ((New-RscQueryCluster -Op List -AddField Nodes.CdmUpgradeInfo).Field.Nodes.CdmUpgradeInfo.AsFieldSpec()).Replace("`n", " ").Trim()
        $cdmUpgradeInfo = "cdmUpgradeInfo { " + $cdmUpgradeInfoFieldSpec + " }"

        # Start with the default
        $q0 = New-RscQueryCluster -Op List
        $q0Fs = FieldSpec($q0)
        $q0ExpectedFs = "count nodes { $defaultNodes } $pageInfo"
        $q0Fs | Should -Be $q0ExpectedFs

        # Add a scalar
        $q1 = New-RscQueryCluster -Op List -AddField nodes.snapshotcount
        $q1Fs = FieldSpec($q1)
        $q1ExpectedFs = "count nodes { $defaultNodesSnapshot } $pageInfo"
        $q1Fs | Should -Be $q1ExpectedFs

        # Case doesn't matter
        $q1 = New-RscQueryCluster -Op List -AddField Nodes.snapSHOTcount
        $q1Fs = FieldSpec($q1)
        $q1ExpectedFs = "count nodes { $defaultNodesSnapshot } $pageInfo"
        $q1Fs | Should -Be $q1ExpectedFs

        # Invalid patches throw
        { New-RscQueryCluster -Op List -AddField xyz } | Should -Throw
        { New-RscQueryCluster -Op List -RemoveField xyz } | Should -Throw

        # Add an object
        $q2 = New-RscQueryCluster -Op List -AddField nodes.cdmupgradeinfo
        $q2Fs = FieldSpec($q2)
        $q2ExpectedFs = "count nodes { $defaultNodes $cdmUpgradeInfo } $pageInfo"
        $q2FS | Should -Be $q2ExpectedFs

        # Take out a scalar
        $q3 = New-RscQueryCluster -Op List -RemoveField nodes.name
        $q3Fs = FieldSpec($q3)
        $q3ExpectedFs = "count nodes { $($defaultNodes -replace 'name ', '') } $pageInfo"
        $q3Fs | Should -Be $q3ExpectedFs

        # Take out an object
        $q4 = New-RscQueryCluster -Op List -RemoveField nodes
        $q4Fs = FieldSpec($q4)
        $q4ExpectedFs = "count $pageInfo"
        $q4Fs | Should -Be $q4ExpectedFs

        # Take out page info
        $q5 = New-RscQueryCluster -Op List -RemoveField pageInfo
        $q5Fs = FieldSpec($q5)
        $q5ExpectedFs = "count nodes { $defaultNodes }"
        $q5Fs | Should -Be $q5ExpectedFs

        # Patches are *added first, removed second:
        $q5b = New-RscQueryCluster -Op List -RemoveField pageInfo -AddField pageInfo
        $q5bFs = FieldSpec($q5)
        $q5bExpectedFs = "count nodes { $defaultNodes }"
        $q5bFs | Should -Be $q5bExpectedFs

        # Add a scalar, via copy
        $qc1 = New-RscQueryCluster -Op List -Copy $q0 -AddField nodes.snapshotcount
        $qc1Fs = FieldSpec($qc1)
        $qc1ExpectedFs = "count nodes { $defaultNodesSnapshot } $pageInfo"
        $qc1Fs | Should -Be $qc1ExpectedFs

        # Cascading copies, add a scalar
        $qc2 = New-RscQueryCluster -Op List -Copy $qc1 -AddField nodes.estimatedrunway
        $qc2Fs = FieldSpec($qc2)

        # The following hard-coded list needs to be updated manually
        # when the schema changes. The repetition is intentional.
        $defaultWithSnapshotAndEstimatedRunway = "pauseStatus status subStatus systemStatus type estimatedRunway id isHealthy name snapshotCount systemStatusMessage version"

        $qc2ExpectedFs = "count nodes { $defaultWithSnapshotAndEstimatedRunway } $pageInfo"
        $qc2Fs | Should -Be $qc2ExpectedFs

        # Take it back
        $qc3 = New-RscQueryCluster -Op List -Copy $qc2 -RemoveField nodes.estimatedrunway
        $qc3Fs = FieldSpec($qc3)
        $qc3ExpectedFs = $qc1ExpectedFs
        $qc3Fs | Should -Be $qc3ExpectedFs

        # Add an object, via copy
        $qc4 = New-RscQueryCluster -Op List -Copy $qc3 -AddField nodes.cdmupgradeinfo
        $qc4Fs = FieldSpec($qc4)
        $qc4ExpectedFs = "count nodes { $defaultNodesSnapshot $cdmUpgradeInfo } $pageInfo"
        $qc4Fs | Should -Be $qc4ExpectedFs
        # But it doesn't modify the original query object
        FieldSpec(New-RscQueryCluster -Op List -Copy $qc2 -RemoveField nodes.estimatedrunway) | Should -Be $qc3ExpectedFs

        # Take it back
        $qc5 = New-RscQueryCluster -Op List -Copy $qc4 -RemoveField nodes.cdmupgradeinfo
        $qc5Fs = FieldSpec($qc5)
        $qc5ExpectedFs = "count nodes { $defaultNodesSnapshot } $pageInfo"
        $qc5Fs | Should -Be $qc5ExpectedFs

        # Start with a field object
        $qf1FieldName = (New-RscQueryCluster -Op List).Field.GetType().Name
        $qf1Field = Get-RscType -Name $qf1FieldName
        $qf1Field.SelectForRetrieval()
        $qf1 = New-RscQueryCluster -Op List -Field $qf1Field
        $qf1Fs = FieldSpec($qf1)
        $qf1ExpectedFs = "count nodes { $defaultNodes } $pageInfo"
        $qf1Fs | Should -Be $qf1ExpectedFs
        
        # Add a scalar to a field object
        $qf2 = New-RscQueryCluster -Op List -Field $qf1Field -AddField nodes.snapshotcount
        $qf2Fs = FieldSpec($qf2)
        $qf2ExpectedFs = "count nodes { $defaultNodesSnapshot } $pageInfo"
        $qf2Fs | Should -Be $qf2ExpectedFs
        # But it doesn't modify the original field object
        FieldSpec(New-RscQueryCluster -Op List -Field $qf1Field) | Should -Be $qf1ExpectedFs

        # Add another scalar to a field object
        $qf2b = New-RscQueryCluster -Op List -Field $qf2.Field -AddField nodes.estimatedrunway
        $qf2bFs = FieldSpec($qf2b)
        $qf2bExpectedFs = $qc2ExpectedFs
        # But it doesn't modify the original field object
        FieldSpec(New-RscQueryCluster -Op List -Field $qf2.Field) | Should -Be $qf2ExpectedFs

        # Take first one back
        $qf3 = New-RscQueryCluster -Op List -Field $qf2b.Field -RemoveField nodes.snapshotcount
        $qf3Fs = FieldSpec($qf3)

        # The following hard-coded list needs to be updated manually
        # when the schema changes. The repetition is intentional.
        $defaultNodesEstimatedRunway = "pauseStatus status subStatus systemStatus type estimatedRunway id isHealthy name systemStatusMessage version"

        $qf3ExpectedFs = "count nodes { $defaultNodesEstimatedRunway } $pageInfo"
        $qf3Fs | Should -Be $qf3ExpectedFs

        # Add an object to a field object
        $qf4 = New-RscQueryCluster -Op List -Field $qf3.FIeld -AddField nodes.cdmupgradeinfo
        $qf4Fs = FieldSpec($qf4)
        $qf4ExpectedFs = "count nodes { $defaultNodesEstimatedRunway $cdmUpgradeInfo } $pageInfo"
        $qf4Fs | Should -Be $qf4ExpectedFs

        # Take it back
        $qf5 = New-RscQueryCluster -Op List -Field $qf4.Field -RemoveField nodes.cdmupgradeinfo
        $qf5Fs = FieldSpec($qf5)
        $qf5ExpectedFs = "count nodes { $defaultNodesEstimatedRunway } $pageInfo"
        $qf5Fs | Should -Be $qf5ExpectedFs

        # Schema assumption: ClusterConnection only has 3 top fields:
        # count, nodes, pageInfo
        $qe1 = New-RscQueryCluster -Op List -FieldProfile EMPTY -AddField Count
        $qe2 = New-RscQueryCluster -Op List -RemoveField Nodes, PageInfo
        $qe1.Field.AsFieldSpec() | Should -Be $qe2.Field.AsFieldSpec()
    }

    It -Name "With New-RscQueryMSsql -Operation Databases" -Test {

        # Patching with -AddField
        $qobj1 = New-RscQueryMSsql -Op Databases -AddField Nodes.PhysicalPath
        $q1 = $qobj1.GqlRequest().Query

        # Patching after copy
        $qobj2 = New-RscQuery -Copy $qobj1 -AddField Nodes.PhysicalPath
        $q2 = $qobj2.GqlRequest().Query

        # Post-patching with Get-RscType -InitialProperties
        $qobj3 = New-RscQueryMSsql -Operation Databases
        $qobj3.Field.Nodes[0].PhysicalPath = Get-RscType -Name PathNode -InitialProperties @("Fid", "Name", "ObjectType")
        $q3 = $qobj3.GqlRequest().Query

        # Post-patching with SelectForRetrieval
        $qobj4 = New-RscQueryMSsql -Op Databases
        $qobj4.Field.Nodes[0].PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
        $qobj4.Field.Nodes[0].PhysicalPath[0].SelectForRetrieval()
        $q4 = $qobj4.GqlRequest().Query

        $q1 | Should -Be $q2
        $q1 | Should -Be $q3
        $q1 | Should -Be $q4
    }
}