
. "${PSScriptRoot}\..\Utils\import.ps1"
. "${PSScriptRoot}\SampleUtils.ps1"

Connect-Rsc

Write-Title "Working with clusters"

Write-Message "Retrieve all clusters" -Pause
$clusters = Get-RscCluster
$clusters

Write-Message "$($clusters.Count) clusters retrieved." -Pause

Write-Message "First cluster from the list:" $clusters[0] -Pause

Write-Message "Retrieving just the first cluster" "Get-RscCluster -First 1" -Pause
Get-RscCluster -First 1

<# In GraphQL:
  # List of the available cluster objects.
  clusterConnection(
    # Returns the first n elements from the list.
    first: Int
    # Returns the elements in the list that come after the specified cursor.
    after: String
    # Returns the last n elements from the list.
    last: Int
    # Returns the elements in the list that come before the specified cursor.
    before: String
    filter: ClusterFilterInput
    # Cluster sort order.
    sortOrder: SortOrder = DESC
    # Sort clusters by field.
    sortBy: ClusterSortByEnum = ClusterType
  ): ClusterConnection!

# Paginated list of Cluster objects.
type ClusterConnection {
  # List of Cluster objects with supplemental pagination information. Use `nodes` if per-object cursors are not needed.
  edges: [ClusterEdge!]!
  # List of Cluster objects.
  nodes: [Cluster!]!
  # General information about this page of results.
  pageInfo: PageInfo!
  # Total number of Cluster objects matching the request arguments.
  count: Int!
  # Aggregate statistics across Clusters with respect for the applied filters and pagination arguments.
  aggregateClusterStatistics: ClusterStatsAggregation!
  # Aggregate Rubrik clusters' health information based on filters and pagination arguments.
  aggregateClusterHealth: ClusterHealthAggregation!
}
#>