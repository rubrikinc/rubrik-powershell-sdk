. "${PSScriptRoot}\..\Utils\import.ps1"
. "${PSScriptRoot}\SampleUtils.ps1"


# Check if the RSC_SERVICE_ACCOUNT_FILE environment variable is defined
if (!(Test-Path Env:RSC_SERVICE_ACCOUNT_FILE)) {
   # RSC_SERVICE_ACCOUNT_FILE environment variable is not defined
   throw "Error: RSC_SERVICE_ACCOUNT_FILE environment variable is not defined"
}

# Connect to the Rubrik Security Cloud using the service account
# file specified in the RSC_SERVICE_ACCOUNT_FILE environment variable:
Connect-Rsc -FromEnv

<#
# A set of parameters to filter objects.
input Filter {
  # ~ needed: description ~
  field: HierarchyFilterField = IS_ARCHIVED
  # ~ needed: description ~
  texts: [String!] = []
  # ~ needed: description ~
  tagFilterParams: [TagFilterParams!] = []
  # ~ needed: description ~
  objectTypeFilterParams: [ManagedObjectType!] = []
  # ~ needed: description ~
  awsNativeProtectionFeatureNames: [AwsNativeProtectionFeature!] = []
  # ~ needed: description ~
  isNegative: Boolean = false
  # ~ needed: description ~
  isSlowSearchEnabled: Boolean = false
  # ~ needed: description ~
  azureNativeProtectionFeatureNames: [AzureNativeProtectionFeature!] = []
  # ~ needed: description ~
  unmanagedObjectAvailabilityFilter: [UnmanagedObjectAvailabilityFilter!] = []
}
#>
$list = New-Object System.Collections.Generic.List[string]
# $list = New-Object System.Collections.ArrayList[string]
# $list.Add("*")

$filter =Get-RscType -name Filter -InitialValues @{ 
   "texts" = $list 
}

$in = @{
   "filter" = $filter
}

<#
# Paginated list of VsphereVm objects.
type VsphereVmConnection {
  # List of VsphereVm objects with supplemental pagination information. Use `nodes` if per-object cursors are not needed.
  edges: [VsphereVmEdge!]!
  # List of VsphereVm objects.
  nodes: [VsphereVm!]!
  # General information about this page of results.
  pageInfo: PageInfo!
  # Total number of VsphereVm objects matching the request arguments.
  count: Int!
}#>

$nodes = New-Object System.Collections.Generic.List[RubrikSecurityCloud.Types.VsphereVm]
$node = [RubrikSecurityCloud.Types.VsphereVm]@{
   "id" = "fetch"
   "name" = "fetch"
   "cluster" = [RubrikSecurityCloud.Types.Cluster]@{
      "id" = "fetch"
      "name" = "fetch"
   }
}
$nodes.Add($node)
$reply = [RubrikSecurityCloud.Types.VsphereVmConnection]@{
   "nodes" = $nodes
}
Get-RscVsphere -VmNewConnection -Input $in -Reply $reply -Debug





