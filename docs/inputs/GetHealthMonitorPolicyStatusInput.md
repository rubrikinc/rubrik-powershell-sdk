### GetHealthMonitorPolicyStatusInput
Input for retrieving the health monitor policy status.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- hasDetailedStatus: System.Boolean
  - Indicates if the policy enforcement status should include expanded result for each policy.
- nodeIds: a list of System.Strings
  - Optional list of Node IDs. If not provided, the response includes the status of all the nodes.
- policyIds: a list of System.Strings
  - Optional list of policy IDs. If not provided, the response includes the status of all the policies.
