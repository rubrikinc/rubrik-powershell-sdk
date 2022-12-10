<#
.SYNOPSIS
Mock test for Get-RscSnapshot

.DESCRIPTION
This script makes use of the SDK's mock API server 'mock_api_server'

.PARAMETER u
Equivalent to --user-existing. Set this to use an already running
mock_api_server and skip start and stop.
#>
param(
  [Alias("u")]
  [Parameter(Mandatory = $false)]
  [switch]$UseExistingMockServer
)

& "$PSScriptRoot\..\..\Samples\import.ps1"
. "$PSScriptRoot\..\mock_api_server.ps1"

BeforeAll {
  if ( ! $UseExistingMockServer) {
    Start-MockApiServer
  }
  $Env:RSC_SERVICE_ACCOUNT_FILE = "$PSScriptRoot/mock_service_account.json"
  . "$PSScriptRoot\..\serviceaccount.ps1"
}

Describe -Name 'Query for Snapshot' -Fixture {
  It "Returns <expected> (for <name>)" -ForEach @(
    @{ 
      Query =
      "{
        'query':
          'query SnapshotListQuery(
`$after: String
`$before: String
`$first: Int
`$ignoreActiveWorkloadCheck: Boolean
`$last: Int
`$snapshotFilter: [SnapshotQueryFilterInput!]
`$sortBy: SnapshotQuerySortByField
`$sortOrder: SortOrder
`$timeRange: TimeRangeInput
`$workloadId: String!
){snapshotOfASnappableConnection
(
after: `$after
before: `$before
first: `$first
ignoreActiveWorkloadCheck: `$ignoreActiveWorkloadCheck
last: `$last
snapshotFilter: `$snapshotFilter
sortBy: `$sortBy
sortOrder: `$sortOrder
timeRange: `$timeRange
workloadId: `$workloadId
){
nodes
{
... on CdmSnapshot
{
date
expirationDate
id
isOnDemandSnapshot
snappableId
 __typename}
 __typename}
 __typename}
 __typename}',
'Variables': '{\'workloadId\':\'76254be7-baa4-5145-a4b7-a7a7773ad97d\'}'
      }"

      ExpectedReply =
      "{
        'snapshotOfASnappableConnection': {
          'nodes': [
              {
                'date': '2022-12-07T13:04:25.000Z',
                'expirationDate': null,
                'id': 'b7b4231e-9750-58de-8892-1521abc6d0a1',
                'isOnDemandSnapshot': true,
                'snappableId': '79893e4a-50de-4167-b147-de6ed87bedac-vm-58319',
                  '__typename': 'CdmSnapshot'
              }
          ],
          '__typename': 'GenericSnapshotConnection'
      },
      '__typename': 'Query'
      }"
    }
  ) {
    Update-MockApiServerCache -Query $Query -Reply $ExpectedReply
    Connect-Rsc -ServiceAccountFile (Get-ServiceAccountFile) |
    Should -BeLikeExactly "AUTHORIZED"

    Get-RscSnapshot -SnappableId "76254be7-baa4-5145-a4b7-a7a7773ad97d"
    $snapshots[0].Id | Should -Be "b7b4231e-9750-58de-8892-1521abc6d0a1"
  }
}

AfterAll {
  if ( ! $UseExistingMockServer) {
    Close-MockApiServer
  }
}
