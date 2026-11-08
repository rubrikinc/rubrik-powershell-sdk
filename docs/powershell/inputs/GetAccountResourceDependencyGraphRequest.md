### GetAccountResourceDependencyGraphRequest
GetAccountResourceDependencyGraphRequest requests a full dependency graph
covering every entitled config and workload resource for an account+region.

- cloudNativeAccountId: System.String
  - Cloud native account ID of the AWS account to build the graph for.
- region: CloudRegionInput
  - Region to build the graph for.
- tags: list of TagFilterInputs
  - Tags used only to compute each node's isTagged flag. Multiple tags use
OR logic. The graph structure never depends on these tags.
- cloudType: CloudServiceProvider
  - Cloud provider of the account. Only AWS is supported; unset means AWS.
