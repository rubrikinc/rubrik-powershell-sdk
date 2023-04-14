
. "${PSScriptRoot}\..\Utils\import.ps1"
. "${PSScriptRoot}\SampleUtils.ps1"

# Path to the service account file must be set in the 
# environment variable RSC_SERVICE_ACCOUNT_FILE
Connect-Rsc -FromEnv

$cluster = Query-RscCluster -Cluster -Input "120a6149-7801-4f0a-a1b8-d4c31a45b580"
Write-Message "Cluster:" $cluster "(type=$($cluster.GetType().Name))"
Write-Host $cluster
Write-Host "-------"
Get-RscType "Cluster"
Write-Host "-------"
Get-RscType "ClusterConnection"
Query-RscCluster -Debug -Connection -Input @{"first"=0} -Reply 

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