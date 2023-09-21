<#
.SYNOPSIS
Run tests around variables.
#>
BeforeAll {
    & "$PSScriptRoot\..\..\Utils\import.ps1"

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
        return $queryDoc.Trim()
    }
}
Describe -Name "Test patching" -Fixture {
    It -Name "With New-RscQueryCluster -List" -Test {
        # Make sure the schema hasn't changed:
        $fieldSpec = FieldSpec(New-RscQueryCluster -List)
        $fieldSpec | Should -Be "count nodes { pauseStatus status subStatus systemStatus type id isHealthy name systemStatusMessage version } pageInfo { endCursor hasNextPage hasPreviousPage startCursor }"

        # Add a scalar
        $fieldSpec = FieldSpec(New-RscQueryCluster -List -Patch nodes.snapshotcount)
        $fieldSpec | Should -Be "count nodes { pauseStatus status subStatus systemStatus type id isHealthy name snapshotcount systemStatusMessage version } pageInfo { endCursor hasNextPage hasPreviousPage startCursor }"
        # Add an object
        $fieldSpec = FieldSpec(New-RscQueryCluster -List -Patch nodes.cdmupgradeinfo)
        $fieldSpec | Should -Be "count nodes { pauseStatus status subStatus systemStatus type id isHealthy name systemStatusMessage version cdmUpgradeInfo { clusterJobStatus versionStatus clusterUuid currentStateProgress downloadedVersion fastUpgradePreferred finishedStates overallProgress pendingStates previousVersion scheduleUpgradeAction scheduleUpgradeAt scheduleUpgradeMode stateMachineStatus stateMachineStatusAt upgradeEndAt upgradeEventSeriesId upgradeStartAt version } } pageInfo { endCursor hasNextPage hasPreviousPage startCursor }"
        # Take out a scalar
        $fieldSpec = FieldSpec(New-RscQueryCluster -List -Patch '-nodes.name')
        $fieldSpec | Should -Be "count nodes { pauseStatus status subStatus systemStatus type id isHealthy systemStatusMessage version } pageInfo { endCursor hasNextPage hasPreviousPage startCursor }"

        # Take out an object
        $fieldSpec = FieldSpec(New-RscQueryCluster -List -Patch '-nodes')
        $fieldSpec | Should -Be "count pageInfo { endCursor hasNextPage hasPreviousPage startCursor }"
    }
}